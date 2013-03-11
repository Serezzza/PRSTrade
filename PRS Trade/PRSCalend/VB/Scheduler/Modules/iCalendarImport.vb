Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraScheduler.iCalendar
Imports DevExpress.Xpo
Imports DevExpress.XtraScheduler.iCalendar.Components
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class iCalendarImportModule
        Inherits DevExpress.XtraScheduler.Demos.TutorialControl
        Private filePath As String
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub

		Protected ReadOnly Property IsCancelForRecurring() As Boolean
			Get
				Return CType(cbCancelingTypes.EditValue, UsedAppointmentType) = UsedAppointmentType.Recurring
			End Get
		End Property
		Protected ReadOnly Property IsCancelForNonRecurring() As Boolean
			Get
				Return CType(cbCancelingTypes.EditValue, UsedAppointmentType) = UsedAppointmentType.NonRecurring
			End Get
		End Property

		Private Sub iCalendarImportModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            DemoUtils.FillStorageResources(schedulerControl.Storage)
            cbCancelingTypes.EditValue = UsedAppointmentType.None
            schedulerControl.Storage.EnableReminders = True
        End Sub

		Private Sub btnImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImport.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "iCalendar files (*.ics)|*.ics"
			dialog.FilterIndex = 1
			If dialog.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			BeforeImportActions()
            Using stream As Stream = dialog.OpenFile()
                Me.filePath = dialog.FileName
                ImportAppointments(stream)
            End Using
            AfterImportActions()
        End Sub

		Private Sub ImportAppointments(ByVal stream As Stream)
			If stream Is Nothing Then
				Return
			End If
			Dim importer As New iCalendarImporter(schedulerStorage)
			AddHandler importer.CalendarStructureCreated, AddressOf importer_CalendarStructureCreated
            AddHandler importer.AppointmentImporting, AddressOf importer_AppointmentImporting
            AddHandler importer.OnException, AddressOf importer_OnException
			importer.Import(stream)
      End Sub
      Private Sub importer_OnException(ByVal sender As Object, ByVal e As ExchangeExceptionEventArgs)
            If TypeOf e.OriginalException Is iCalendarInvalidFileFormatException Then
                Dim message As String = String.Format("The file ""{0}"" is not a valid Internet Calendar file", Path.GetFileName(Me.filePath))
                XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Dim args As iCalendarParseExceptionEventArgs = TryCast(e, iCalendarParseExceptionEventArgs)
            If args IsNot Nothing Then
                XtraMessageBox.Show(String.Format("Can't parse line '{1}' at {0} index", args.LineIndex, args.LineText))
                Dim importer As iCalendarImporter = CType(sender, iCalendarImporter)
                importer.Terminate()
            End If
            e.Handled = True
      End Sub

		Private Sub importer_AppointmentImporting(ByVal sender As Object, ByVal e As AppointmentImportingEventArgs)
			ProgressBarControl1.Position += 1
			ProgressBarControl1.Update()
			Dim cancel As Boolean
			If e.Appointment.IsRecurring Then
				cancel = IsCancelForRecurring
			Else
				cancel = IsCancelForNonRecurring
			End If
			If cancel Then
				e.Cancel = True
			End If
		End Sub
        Private Sub importer_CalendarStructureCreated(ByVal sender As Object, ByVal e As iCalendarStructureCreatedEventArgs)
            Dim importer As iCalendarImporter = CType(sender, iCalendarImporter)
            ProgressBarControl1.Position = 0
            ProgressBarControl1.Properties.Maximum = importer.SourceObjectCount
            ProgressBarControl1.Update()
        End Sub

		Private Sub BeforeImportActions()
			If chkClearBeforImport.Checked Then
				schedulerStorage.Appointments.Clear()
			End If
		End Sub
		Private Sub AfterImportActions()
			ProgressBarControl1.Properties.Maximum = 100
			ProgressBarControl1.Position = 0
		End Sub
	End Class
End Namespace
