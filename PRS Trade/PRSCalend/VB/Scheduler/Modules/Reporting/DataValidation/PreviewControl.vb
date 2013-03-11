Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Reporting
Imports System.Collections.Generic

Namespace DevExpress.XtraScheduler.Demos.Reporting.DataValidation

    Public Class PreviewControl
        Inherits SingleReportPreviewControl
        Private components As System.ComponentModel.IContainer = Nothing
        Private lbResources As DevExpress.XtraEditors.LabelControl
        Private WithEvents cmbResources As DevExpress.XtraEditors.ComboBoxEdit
        Private lblAppointments As DevExpress.XtraEditors.LabelControl
        Private WithEvents cmbDays As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblTimeIntervals As DevExpress.XtraEditors.LabelControl
        Private WithEvents cmbAppointments As DevExpress.XtraEditors.ImageComboBoxEdit

        Public Shadows ReadOnly Property Report() As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            UpdateActiveReport()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
            Return New Report()
        End Function
#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
            Me.lbResources = New DevExpress.XtraEditors.LabelControl
            Me.cmbResources = New DevExpress.XtraEditors.ComboBoxEdit
            Me.lblAppointments = New DevExpress.XtraEditors.LabelControl
            Me.cmbAppointments = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.cmbDays = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblTimeIntervals = New DevExpress.XtraEditors.LabelControl
            CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSettings.SuspendLayout()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbAppointments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'fStoragePrintAdapter
            '
            '
            'smplEdit
            '
            Me.btnEdit.Location = New System.Drawing.Point(620, 9)
            '
            'fPrintBarManager
            '
            Me.fPrintBarManager.ImageStream = CType(resources.GetObject("fPrintBarManager.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            '
            'pnlSettings
            '
            Me.pnlSettings.Controls.Add(Me.cmbDays)
            Me.pnlSettings.Controls.Add(Me.lblTimeIntervals)
            Me.pnlSettings.Controls.Add(Me.cmbAppointments)
            Me.pnlSettings.Controls.Add(Me.lblAppointments)
            Me.pnlSettings.Controls.Add(Me.lbResources)
            Me.pnlSettings.Controls.Add(Me.cmbResources)
            Me.pnlSettings.Size = New System.Drawing.Size(700, 42)
            Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.cmbResources, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lbResources, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lblAppointments, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.cmbAppointments, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lblTimeIntervals, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.cmbDays, 0)
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 42)
            '
            'printControl
            '
            Me.printControl.Location = New System.Drawing.Point(0, 50)
            Me.printControl.Size = New System.Drawing.Size(700, 346)
            '
            'lbResources
            '
            Me.lbResources.Location = New System.Drawing.Point(11, 15)
            Me.lbResources.Name = "lbResources"
            Me.lbResources.Size = New System.Drawing.Size(54, 13)
            Me.lbResources.TabIndex = 12
            Me.lbResources.Text = "Resources:"
            '
            'cmbResources
            '
            Me.cmbResources.EditValue = "All"
            Me.cmbResources.Location = New System.Drawing.Point(70, 11)
            Me.cmbResources.Name = "cmbResources"
            Me.cmbResources.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbResources.Properties.Items.AddRange(New Object() {"All", "Top 3 ", "A-Z order", "Z-A order", ""})
            Me.cmbResources.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cmbResources.Size = New System.Drawing.Size(70, 20)
            Me.cmbResources.TabIndex = 13
            '
            'lblAppointments
            '
            Me.lblAppointments.Location = New System.Drawing.Point(158, 15)
            Me.lblAppointments.Name = "lblAppointments"
            Me.lblAppointments.Size = New System.Drawing.Size(70, 13)
            Me.lblAppointments.TabIndex = 14
            Me.lblAppointments.Text = "Appointments:"
            '
            'cmbAppointments
            '
            Me.cmbAppointments.EditValue = DevExpress.XtraScheduler.UsedAppointmentType.All
            Me.cmbAppointments.Location = New System.Drawing.Point(233, 11)
            Me.cmbAppointments.Name = "cmbAppointments"
            Me.cmbAppointments.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbAppointments.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("All", DevExpress.XtraScheduler.UsedAppointmentType.All, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Recurring", DevExpress.XtraScheduler.UsedAppointmentType.Recurring, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("NonRecurring", DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring, -1)})
            Me.cmbAppointments.Size = New System.Drawing.Size(84, 20)
            Me.cmbAppointments.TabIndex = 38
            '
            'cmbDays
            '
            Me.cmbDays.EditValue = DevExpress.XtraScheduler.WeekDays.EveryDay
            Me.cmbDays.Location = New System.Drawing.Point(368, 11)
            Me.cmbDays.Name = "cmbDays"
            Me.cmbDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbDays.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Every Day", DevExpress.XtraScheduler.WeekDays.EveryDay, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Days", DevExpress.XtraScheduler.WeekDays.WorkDays, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Weekend Days", DevExpress.XtraScheduler.WeekDays.WeekendDays, -1)})
            Me.cmbDays.Size = New System.Drawing.Size(96, 20)
            Me.cmbDays.TabIndex = 40
            '
            'lblTimeIntervals
            '
            Me.lblTimeIntervals.Location = New System.Drawing.Point(335, 15)
            Me.lblTimeIntervals.Name = "lblTimeIntervals"
            Me.lblTimeIntervals.Size = New System.Drawing.Size(28, 13)
            Me.lblTimeIntervals.TabIndex = 39
            Me.lblTimeIntervals.Text = "Days:"
            '
            'PreviewControl
            '
            Me.Name = "PreviewControl"
            CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSettings.ResumeLayout(False)
            Me.pnlSettings.PerformLayout()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbAppointments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(10))
        End Sub

        Private Sub storagePrintAdapter_ValidateAppointments(ByVal sender As Object, ByVal e As AppointmentsValidationEventArgs) Handles fStoragePrintAdapter.ValidateAppointments
            Dim aptType As UsedAppointmentType = CType(cmbAppointments.EditValue, UsedAppointmentType)
            If aptType = UsedAppointmentType.All Then
                Return
            End If

            If aptType = UsedAppointmentType.None Then
                e.Appointments.Clear()
                Return
            End If
            Dim count As Integer = e.Appointments.Count
            Dim result As AppointmentBaseCollection = New AppointmentBaseCollection()
            For i As Integer = 0 To count - 1
                Dim apt As Appointment = e.Appointments(i)
                If aptType = UsedAppointmentType.Recurring AndAlso apt.IsRecurring Then
                    result.Add(apt)
                End If
                If aptType = UsedAppointmentType.NonRecurring AndAlso (Not apt.IsRecurring) Then
                    result.Add(apt)
                End If
            Next i
            e.Appointments.Clear()
            e.Appointments.AddRange(result)
        End Sub

        Private Sub storagePrintAdapter_ValidateResources(ByVal sender As Object, ByVal e As ResourcesValidationEventArgs) Handles fStoragePrintAdapter.ValidateResources
            Dim resourceMode As Integer = cmbResources.SelectedIndex
            If resourceMode = 1 Then
                Dim count As Integer = e.Resources.Count
                For i As Integer = count - 1 To 3 Step -1
                    e.Resources.RemoveAt(i)
                Next i
            End If
            If resourceMode = 2 Then
                e.Resources.Sort(New ResourceCaptionComparer())
            End If
            If resourceMode = 3 Then
                e.Resources.Sort(New ResourceCaptionReverseComparer())
            End If
        End Sub

        Private Sub storagePrintAdapter_ValidateTimeIntervals(ByVal sender As Object, ByVal e As TimeIntervalsValidationEventArgs) Handles fStoragePrintAdapter.ValidateTimeIntervals
            Dim weekDays As WeekDays = CType(cmbDays.EditValue, WeekDays)
            If weekDays = weekDays.EveryDay Then
                Return
            End If

            Dim count As Integer = e.Intervals.Count

            Dim result As DayIntervalCollection = New DayIntervalCollection()
            For i As Integer = count - 1 To 0 Step -1
                Dim sourceDays As DayIntervalCollection = New DayIntervalCollection()
                sourceDays.Add(e.Intervals(i))
                FilterDays(sourceDays, weekDays)
                result.AddRange(sourceDays)
            Next i

            e.Intervals.Clear()
            For i As Integer = 0 To result.Count - 1
                e.Intervals.Add(result(i))
            Next i

        End Sub
        'TimeIntervalPro

        Private Sub FilterDays(ByVal dayIntervals As DayIntervalCollection, ByVal validDays As WeekDays)
            Dim count As Integer = dayIntervals.Count
            For i As Integer = count - 1 To 0 Step -1
                Dim day As DayOfWeek = dayIntervals(i).Start.DayOfWeek
                Dim weekDay As WeekDays = DevExpress.XtraScheduler.Native.DateTimeHelper.ToWeekDays(day)
                If (weekDay And validDays) <> weekDay Then
                    dayIntervals.RemoveAt(i)
                End If
            Next i
        End Sub
        Private Sub cmbResources_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbResources.SelectedIndexChanged
            UpdateActiveReport()
        End Sub

        Private Sub cmbAppointments_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAppointments.SelectedIndexChanged
            UpdateActiveReport()
        End Sub

        Private Sub cmbDays_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDays.SelectedIndexChanged
            CreateReports()
            UpdateActiveReport()
        End Sub

    End Class
    Public Class ResourceCaptionComparer
        Implements IComparer(Of Resource), IComparer

#Region "IComparer Members"
        Private Function IComparer_Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Return CompareCore(x, y)
        End Function
        Public Function Compare(ByVal x As Resource, ByVal y As Resource) As Integer Implements IComparer(Of Resource).Compare
            Return CompareCore(x, y)
        End Function
#End Region

        Protected Overridable Function CompareCore(ByVal x As Object, ByVal y As Object) As Integer
            Dim xRes As Resource = CType(x, Resource)
            Dim yRes As Resource = CType(y, Resource)
            If xRes Is Nothing OrElse yRes Is Nothing Then
                Return 0
            End If
            If Resource.Empty.Equals(xRes) OrElse Resource.Empty.Equals(yRes) Then
                Return 0
            End If
            Return CompareCaptions(xRes, yRes)
        End Function
        Protected Overridable Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
            Return String.Compare(xRes.Caption, yRes.Caption)
        End Function

    End Class
    Public Class ResourceCaptionReverseComparer
        Inherits ResourceCaptionComparer
        Protected Overrides Function CompareCaptions(ByVal xRes As Resource, ByVal yRes As Resource) As Integer
            Return String.Compare(yRes.Caption, xRes.Caption)
        End Function
    End Class
End Namespace

