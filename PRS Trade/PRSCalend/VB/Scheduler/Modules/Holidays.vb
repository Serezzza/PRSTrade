Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Xml
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Schedule
Imports DevExpress.Schedule.Serializing


Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class HolidaysModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl

        Private Const OutlookHolidaysFileName As String = "OUTLOOK.HOL"
        Private Const SchedulerHolidaysFileName As String = "holidays.xml"
        Private fAllHolidays As HolidayBaseCollection = New HolidayBaseCollection()
        Private suspendUpdateCount As Integer

		Public Sub New()
			' This call is required by the Windows Form Designer.
            SuspendUpdate()
            Try
                InitializeComponent()
            Finally
                ResumeUpdate()
            End Try
            ' TODO: Add any initialization after the InitializeComponent call
        End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property
        Protected ReadOnly Property AllHolidays() As HolidayBaseCollection
            Get
                Return fAllHolidays
            End Get
        End Property
        Protected ReadOnly Property IsUpdateSuspended() As Boolean
            Get
                Return suspendUpdateCount > 0
            End Get
        End Property

        Protected Sub SuspendUpdate()
            suspendUpdateCount += 1
        End Sub
        Protected Sub ResumeUpdate()
            If suspendUpdateCount > 0 Then
                suspendUpdateCount -= 1
            End If
        End Sub

        Private Sub HolidaysModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            UpdateControls()
            ActiveControl = Me.clbLocations
        End Sub
		Private Sub UpdateControls()
			FillLocationListBox(SelectHolidayLocations(AllHolidays))
			FillHolidaysListBox(New List(Of HolidayListBoxItem)(0))
			UpdateStatusLabel(0, 0)
        End Sub

		Private Function SelectHolidayLocations(ByVal holidays As HolidayBaseCollection) As String()
			Dim locations As List(Of String) = New List(Of String)()
			For Each item As Holiday In holidays
				If (Not locations.Contains(item.Location)) Then
					locations.Add(item.Location)
				End If
			Next item
			Return locations.ToArray()
		End Function
		Private Sub FillLocationListBox(ByVal locations As String())
			clbLocations.Items.BeginUpdate()
			Try
				clbLocations.Items.Clear()
				Dim i As Integer = 0
				Do While i < locations.Length
					clbLocations.Items.Add(locations(i), False)
					i += 1
				Loop
				clbLocations.SelectedIndex = 0
			Finally
				clbLocations.Items.EndUpdate()
			End Try
		End Sub
		Private Function CreateListBoxData(ByVal items As HolidayBaseCollection) As List(Of HolidayListBoxItem)
			Dim data As List(Of HolidayListBoxItem) = New List(Of HolidayListBoxItem)()
			Dim i As Integer = 0
			Do While i < items.Count
				data.Add(New HolidayListBoxItem(items(i)))
				i += 1
			Loop
			Return data
		End Function
		Private Sub FillHolidaysListBox(ByVal data As List(Of HolidayListBoxItem))
			lbHolidays.Items.BeginUpdate()
			Try
				lbHolidays.DataSource = data
				lbHolidays.DisplayMember = "DisplayText"
			Finally
				lbHolidays.Items.EndUpdate()
			End Try
		End Sub
        Private Sub UpdateStatusLabel(ByVal holidayCount As Integer, ByVal locationCount As Integer)
            lblStatus.Text = String.Format("Loaded {0} holiday(s) for {1} location(s)", holidayCount, locationCount)
        End Sub
		Private Sub clbLocations_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbLocations.ItemCheck
			Dim locations As List(Of String) = GetSelectedLocations()
            Dim holidays As HolidayBaseCollection = GetSelectedHolidays(locations)

            AddHolidaysToScheduler(holidays)
            FillHolidaysListBox(CreateListBoxData(holidays))
            UpdateStatusLabel(holidays.Count, locations.Count)
		End Sub
		Private Function GetSelectedHolidays(ByVal locations As List(Of String)) As HolidayBaseCollection
			Dim result As HolidayBaseCollection = New HolidayBaseCollection()
			If locations.Count = 0 Then
				Return result
			End If

			For Each item As Holiday In AllHolidays
				If locations.Contains(item.Location) Then
					result.Add(item)
				End If
            Next item

			Return result
		End Function
		Private Function GetSelectedLocations() As List(Of String)
			Dim result As List(Of String) = New List(Of String)()
			Dim i As Integer = 0
			Do While i < clbLocations.Items.Count
				Dim item As CheckedListBoxItem = clbLocations.Items(i)
				If item.CheckState = CheckState.Checked Then
					result.Add(item.Value.ToString())
				End If
				i += 1
			Loop
			Return result
		End Function
		Private Sub lbHolidays_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lbHolidays.DoubleClick
			Dim item As HolidayListBoxItem = TryCast(lbHolidays.SelectedItem, HolidayListBoxItem)
			If Not item Is Nothing Then
				schedulerControl.GoToDate(item.Holiday.Date)
			End If
		End Sub
		Private Sub AddHolidaysToScheduler(ByVal items As HolidayBaseCollection)
			schedulerControl.BeginUpdate()
			Try
				schedulerControl.WorkDays.Clear()
				schedulerControl.WorkDays.Add(WeekDays.WorkDays)
				schedulerControl.WorkDays.AddRange(items)
			Finally
				schedulerControl.EndUpdate()
			End Try
		End Sub
		Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
			GenerateHolidayAppointments()
		End Sub
		Private Sub GenerateHolidayAppointments()
            Dim apts As AppointmentBaseCollection = HolidaysHelper.GenerateHolidayAppointments(schedulerStorage, schedulerControl.WorkDays)
			schedulerStorage.BeginUpdate()
			Try
				schedulerStorage.Appointments.Items.AddRange(apts)
                XtraMessageBox.Show(String.Format("{0} appointment(s) were added", apts.Count), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
			Finally
				schedulerStorage.EndUpdate()
			End Try
		End Sub
		Private Sub btnImportFromXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportFromXml.Click
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Scheduler holidays files (*.xml)|*.xml|All files (*.*)|*.*"
            dlg.FilterIndex = 1
            dlg.FileName = SchedulerHolidaysFileName
            Dim filePath As String = DemoUtils.GetFileRelativePath(SchedulerHolidaysFileName)
            dlg.InitialDirectory = New System.IO.FileInfo(filePath).DirectoryName

            dlg.DefaultExt = "*.xml"
            dlg.CheckFileExists = True

            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ImportHolidaysFromXmlFile(dlg.FileName)
                UpdateControls()
            End If
        End Sub
        Private Sub ImportHolidaysFromXmlFile(ByVal path As String)
            If (Not File.Exists(path)) Then
                Return
            End If

            Dim doc As XmlDocument = New XmlDocument()
            doc.Load(path)
            Me.fAllHolidays = HolidayCollectionXmlPersistenceHelper.ObjectFromXml(doc.OuterXml)
        End Sub
		Private Sub btnImportFromOutlook_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportFromOutlook.Click
			Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "Microsoft Office Outlook Holidays files (*.hol)|*.hol|Text files (*.txt)|*.txt|All files (*.*)|*.*"
			dlg.FilterIndex = 1
			dlg.FileName = OutlookHolidaysFileName
			dlg.DefaultExt = "*.hol"
			dlg.CheckFileExists = True
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				ImportHolidaysFromOutlookFile(dlg.FileName)
			End If

		End Sub
		Private Sub ImportHolidaysFromOutlookFile(ByVal path As String)
			If (Not File.Exists(path)) Then
				Return
			End If

			Dim loader As OutlookHolidaysLoader = New OutlookHolidaysLoader()
            Me.fAllHolidays = loader.FromFile(path)
			UpdateControls()
        End Sub

        Private Sub schedulerControl_CustomDrawDayHeader(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs) Handles schedulerControl.CustomDrawDayHeader
            Dim header As SchedulerHeader = Nothing

            If TypeOf e.ObjectInfo Is DayHeader Then
                header = TryCast(e.ObjectInfo, DayHeader)
            Else
                If TypeOf e.ObjectInfo Is TimeScaleHeader Then
                    Dim scaleHeader As TimeScaleHeader = TryCast(e.ObjectInfo, TimeScaleHeader)
                    If TypeOf scaleHeader.Scale Is TimeScaleDay Then
                        header = scaleHeader
                    End If

                End If
            End If

            If Not header Is Nothing Then
                'Check whether the current date is a known holiday.
                Dim hol As Holiday = FindHoliday(header.Interval.Start.Date)
                If Not hol Is Nothing Then
                    header.Caption = String.Format("{0} ({1})", hol.DisplayName, hol.Location)
                    header.Appearance.HeaderCaption.ForeColor = Color.Red
                    header.ToolTipText = header.Caption
                    header.ShouldShowToolTip = True
                End If
            End If
        End Sub
        'This method finds a holiday for the specified date.
        Private Function FindHoliday(ByVal searchDate As DateTime) As Holiday
            For Each item As WorkDay In Me.schedulerControl.WorkDays
                Dim hol As Holiday = TryCast(item, Holiday)
                If Not hol Is Nothing Then
                    If hol.Date = searchDate Then
                        Return hol
                    End If
                End If
            Next item

            Return Nothing

        End Function


    End Class

#Region "HolidayListBoxItem class"
    Public Class HolidayListBoxItem
        Private fHoliday As Holiday
        'INSTANT VB NOTE: The parameter holiday was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        Public Sub New(ByVal holiday_Renamed As Holiday)
            Me.fHoliday = holiday_Renamed
        End Sub
        Public ReadOnly Property Holiday() As Holiday
            Get
                Return fHoliday
            End Get
        End Property
        Public ReadOnly Property DisplayText() As String
            Get
                Return String.Format("{0} ({1}) {2}", fHoliday.DisplayName, fHoliday.Location, fHoliday.Date.ToShortDateString())
            End Get
        End Property
    End Class
#End Region
End Namespace
