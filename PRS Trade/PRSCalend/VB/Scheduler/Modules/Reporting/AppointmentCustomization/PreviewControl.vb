Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services.Implementation
Imports System.Globalization

Namespace DevExpress.XtraScheduler.Demos.Reporting.AppointmentCustomization

	Public Class PreviewControl
        Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing

		'bool showReminder;
		'bool showReccurence;

		Private allowInitAptText As Boolean
		Private allowInitAptImages As Boolean
		Private WithEvents chkAptImages As CheckEdit
		Private WithEvents chkAptText As CheckEdit
		Private groupControl1 As GroupControl
		Private WithEvents chkShowRecurrence As CheckEdit
		Private WithEvents cbStatus As ImageComboBoxEdit
		Private lblStatus As LabelControl
		Private WithEvents cbTimeDisplayType As ImageComboBoxEdit
		Private lblTime As LabelControl
		Private WithEvents chkShowReminder As CheckEdit
		Private WithEvents chkStartTimeVisibility As CheckEdit
		Private WithEvents chkEndTimeVisibility As CheckEdit

		Private showStartTime As Boolean
		Private showEndTime As Boolean
		Private statusDisplayType As AppointmentStatusDisplayType
		Private timeDisplayType As AppointmentTimeDisplayType

		Private showBell As Boolean
        Private showRecurrence As Boolean

		Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            'printControl.SetPageView(2, 1);
            InitializeControlValues()

        End Sub


		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(7))
		End Sub
		Private Sub InitializeControlValues()
			allowInitAptText = chkAptText.Checked
			allowInitAptImages = chkAptImages.Checked

			cbTimeDisplayType.SelectedIndex = 0
			cbStatus.SelectedIndex = 0
			showStartTime = chkStartTimeVisibility.Checked
			showEndTime = chkEndTimeVisibility.Checked
			showRecurrence = chkShowRecurrence.Checked
			showBell = chkShowReminder.Checked
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
            Me.Report.AllowInitAppointmentText = allowInitAptText
            Me.Report.AllowInitAppointmentImages = allowInitAptImages

            Me.Report.ShowStartTime = showStartTime
            Me.Report.ShowEndTime = showEndTime
            Me.Report.StatusDisplayType = statusDisplayType
            Me.Report.TimeDisplayType = timeDisplayType
            Me.Report.ShowBell = showBell
            Me.Report.ShowRecurrence = showRecurrence
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.chkAptImages = New DevExpress.XtraEditors.CheckEdit()
			Me.chkAptText = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.chkShowRecurrence = New DevExpress.XtraEditors.CheckEdit()
			Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
			Me.cbTimeDisplayType = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lblTime = New DevExpress.XtraEditors.LabelControl()
			Me.chkShowReminder = New DevExpress.XtraEditors.CheckEdit()
			Me.chkStartTimeVisibility = New DevExpress.XtraEditors.CheckEdit()
			Me.chkEndTimeVisibility = New DevExpress.XtraEditors.CheckEdit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()

			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAptImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAptText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' smplEdit
			' 
            Me.btnEdit.Location = New System.Drawing.Point(616, 67)
            ' 
            ' pnlSettings
            ' 
            Me.pnlSettings.Controls.Add(Me.groupControl1)
            Me.pnlSettings.Controls.Add(Me.chkAptImages)
            Me.pnlSettings.Controls.Add(Me.chkAptText)
            Me.pnlSettings.Size = New System.Drawing.Size(700, 96)
            Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkAptText, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkAptImages, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.groupControl1, 0)
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 96)
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 104)
			Me.printControl.Size = New System.Drawing.Size(700, 292)
			' 
			' chkAptImages
			' 
			Me.chkAptImages.EditValue = True
			Me.chkAptImages.Location = New System.Drawing.Point(389, 61)
			Me.chkAptImages.Name = "chkAptImages"
			Me.chkAptImages.Properties.Caption = "Custom Images"
			Me.chkAptImages.Size = New System.Drawing.Size(103, 19)
			Me.chkAptImages.TabIndex = 49
'			Me.chkAptImages.CheckedChanged += New System.EventHandler(Me.chkAptImages_CheckedChanged);
			' 
			' chkAptText
			' 
			Me.chkAptText.EditValue = True
			Me.chkAptText.Location = New System.Drawing.Point(389, 38)
			Me.chkAptText.Name = "chkAptText"
			Me.chkAptText.Properties.Caption = "Custom Text"
			Me.chkAptText.Size = New System.Drawing.Size(96, 19)
			Me.chkAptText.TabIndex = 48
'			Me.chkAptText.CheckedChanged += New System.EventHandler(Me.chkAptText_CheckedChanged);
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.chkShowRecurrence)
			Me.groupControl1.Controls.Add(Me.cbStatus)
			Me.groupControl1.Controls.Add(Me.lblStatus)
			Me.groupControl1.Controls.Add(Me.cbTimeDisplayType)
			Me.groupControl1.Controls.Add(Me.lblTime)
			Me.groupControl1.Controls.Add(Me.chkShowReminder)
			Me.groupControl1.Controls.Add(Me.chkStartTimeVisibility)
			Me.groupControl1.Controls.Add(Me.chkEndTimeVisibility)
			Me.groupControl1.Location = New System.Drawing.Point(8, 8)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(359, 80)
			Me.groupControl1.TabIndex = 51
			Me.groupControl1.Text = "Display Options"
			' 
			' chkShowRecurrence
			' 
			Me.chkShowRecurrence.EditValue = True
			Me.chkShowRecurrence.Location = New System.Drawing.Point(269, 30)
			Me.chkShowRecurrence.Name = "chkShowRecurrence"
			Me.chkShowRecurrence.Properties.Caption = "Recurrence"
			Me.chkShowRecurrence.Size = New System.Drawing.Size(85, 19)
			Me.chkShowRecurrence.TabIndex = 74
'			Me.chkShowRecurrence.CheckedChanged += New System.EventHandler(Me.chkShowRecurrence_CheckedChanged);
			' 
			' cbStatus
			' 
			Me.cbStatus.EditValue = ""
			Me.cbStatus.Location = New System.Drawing.Point(53, 29)
			Me.cbStatus.Name = "cbStatus"
			Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
			Me.cbStatus.Size = New System.Drawing.Size(96, 20)
			Me.cbStatus.TabIndex = 73
'			Me.cbStatus.SelectedIndexChanged += New System.EventHandler(Me.cbStatus_SelectedIndexChanged);
			' 
			' lblStatus
			' 
			Me.lblStatus.Location = New System.Drawing.Point(12, 32)
			Me.lblStatus.Name = "lblStatus"
			Me.lblStatus.Size = New System.Drawing.Size(35, 13)
			Me.lblStatus.TabIndex = 72
			Me.lblStatus.Text = "Status:"
			' 
			' cbTimeDisplayType
			' 
			Me.cbTimeDisplayType.EditValue = ""
			Me.cbTimeDisplayType.Location = New System.Drawing.Point(53, 53)
			Me.cbTimeDisplayType.Name = "cbTimeDisplayType"
			Me.cbTimeDisplayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbTimeDisplayType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Auto, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Clock", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Text", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text, -1)})
			Me.cbTimeDisplayType.Size = New System.Drawing.Size(96, 20)
			Me.cbTimeDisplayType.TabIndex = 22
'			Me.cbTimeDisplayType.SelectedIndexChanged += New System.EventHandler(Me.cbTimeDisplayType_SelectedIndexChanged);
			' 
			' lblTime
			' 
			Me.lblTime.Location = New System.Drawing.Point(12, 55)
			Me.lblTime.Name = "lblTime"
			Me.lblTime.Size = New System.Drawing.Size(26, 13)
			Me.lblTime.TabIndex = 21
			Me.lblTime.Text = "Time:"
			' 
			' chkShowReminder
			' 
			Me.chkShowReminder.EditValue = True
			Me.chkShowReminder.Location = New System.Drawing.Point(269, 54)
			Me.chkShowReminder.Name = "chkShowReminder"
			Me.chkShowReminder.Properties.Caption = "Reminder"
			Me.chkShowReminder.Size = New System.Drawing.Size(72, 19)
			Me.chkShowReminder.TabIndex = 13
'			Me.chkShowReminder.CheckedChanged += New System.EventHandler(Me.chkShowReminder_CheckedChanged);
			' 
			' chkStartTimeVisibility
			' 
			Me.chkStartTimeVisibility.EditValue = True
			Me.chkStartTimeVisibility.Location = New System.Drawing.Point(164, 29)
			Me.chkStartTimeVisibility.Name = "chkStartTimeVisibility"
			Me.chkStartTimeVisibility.Properties.Caption = "Start Time"
			Me.chkStartTimeVisibility.Size = New System.Drawing.Size(72, 19)
			Me.chkStartTimeVisibility.TabIndex = 11
'			Me.chkStartTimeVisibility.CheckedChanged += New System.EventHandler(Me.chkStartTimeVisibility_CheckedChanged);
			' 
			' chkEndTimeVisibility
			' 
			Me.chkEndTimeVisibility.EditValue = True
			Me.chkEndTimeVisibility.Location = New System.Drawing.Point(164, 54)
			Me.chkEndTimeVisibility.Name = "chkEndTimeVisibility"
			Me.chkEndTimeVisibility.Properties.Caption = "End Time"
			Me.chkEndTimeVisibility.Size = New System.Drawing.Size(72, 19)
			Me.chkEndTimeVisibility.TabIndex = 10
'			Me.chkEndTimeVisibility.CheckedChanged += New System.EventHandler(Me.chkEndTimeVisibility_CheckedChanged);
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()

			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAptImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAptText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub chkAptText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAptText.CheckedChanged
			allowInitAptText = (CType(sender, CheckEdit)).Checked
            UpdateActiveReport()
		End Sub

		Private Sub chkAptImages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAptImages.CheckedChanged
			allowInitAptImages = (CType(sender, CheckEdit)).Checked
            UpdateActiveReport()
		End Sub

		Private Sub chkStartTimeVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkStartTimeVisibility.CheckedChanged
			showStartTime = (CType(sender, CheckEdit)).Checked
            UpdateActiveReport()
		End Sub

		Private Sub chkEndTimeVisibility_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEndTimeVisibility.CheckedChanged
			showEndTime = (CType(sender, CheckEdit)).Checked
            UpdateActiveReport()

		End Sub

		Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.SelectedIndexChanged
			statusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
            UpdateActiveReport()
		End Sub

		Private Sub cbTimeDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeDisplayType.SelectedIndexChanged
			timeDisplayType = CType(cbTimeDisplayType.EditValue, AppointmentTimeDisplayType)
            UpdateActiveReport()
		End Sub

		Private Sub chkShowRecurrence_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowRecurrence.CheckedChanged
			showRecurrence = (CType(sender, CheckEdit)).Checked
            UpdateActiveReport()
		End Sub

		Private Sub chkShowReminder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowReminder.CheckedChanged
			showBell = (CType(sender, CheckEdit)).Checked
            UpdateActiveReport()
		End Sub
	End Class
End Namespace

