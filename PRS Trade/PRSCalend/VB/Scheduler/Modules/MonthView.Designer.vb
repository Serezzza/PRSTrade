Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class MonthViewModule
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblStatus = New DevExpress.XtraEditors.LabelControl
            Me.cbTimeDisplayType = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblTime = New DevExpress.XtraEditors.LabelControl
            Me.chkStartTimeVisibility = New DevExpress.XtraEditors.CheckEdit
            Me.lblWeeksCount = New DevExpress.XtraEditors.LabelControl
            Me.spinWeekCount = New DevExpress.XtraEditors.SpinEdit
            Me.chkCompressWeekEnd = New DevExpress.XtraEditors.CheckEdit
            Me.chkEndTimeVisibility = New DevExpress.XtraEditors.CheckEdit
            Me.chkShowWeekend = New DevExpress.XtraEditors.CheckEdit
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinWeekCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkCompressWeekEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowWeekend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 64)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 340)
            Me.schedulerControl.Start = New Date(2010, 6, 30, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl"
			Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
			Me.schedulerControl.Views.MonthView.ShowMoreButtons = False
			Me.schedulerControl.Views.MonthView.WeekCount = 3
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbStatus)
            Me.panelControl.Controls.Add(Me.lblStatus)
            Me.panelControl.Controls.Add(Me.cbTimeDisplayType)
            Me.panelControl.Controls.Add(Me.lblTime)
            Me.panelControl.Controls.Add(Me.chkStartTimeVisibility)
            Me.panelControl.Controls.Add(Me.lblWeeksCount)
            Me.panelControl.Controls.Add(Me.spinWeekCount)
            Me.panelControl.Controls.Add(Me.chkCompressWeekEnd)
            Me.panelControl.Controls.Add(Me.chkEndTimeVisibility)
            Me.panelControl.Controls.Add(Me.chkShowWeekend)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 56)
            Me.panelControl.TabIndex = 1
            '
            'cbStatus
            '
            Me.cbStatus.EditValue = ""
            Me.cbStatus.Location = New System.Drawing.Point(507, 5)
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbStatus.Size = New System.Drawing.Size(96, 19)
            Me.cbStatus.TabIndex = 77
            '
            'lblStatus
            '
            Me.lblStatus.Location = New System.Drawing.Point(466, 8)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(35, 13)
            Me.lblStatus.TabIndex = 76
            Me.lblStatus.Text = "Status:"
            '
            'cbTimeDisplayType
            '
            Me.cbTimeDisplayType.EditValue = ""
            Me.cbTimeDisplayType.Location = New System.Drawing.Point(350, 5)
            Me.cbTimeDisplayType.Name = "cbTimeDisplayType"
            Me.cbTimeDisplayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeDisplayType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentTimeDisplayType.[Auto], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Clock", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Text", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text, -1)})
            Me.cbTimeDisplayType.Size = New System.Drawing.Size(96, 19)
            Me.cbTimeDisplayType.TabIndex = 24
            '
            'lblTime
            '
            Me.lblTime.Location = New System.Drawing.Point(266, 8)
            Me.lblTime.Name = "lblTime"
            Me.lblTime.Size = New System.Drawing.Size(78, 13)
            Me.lblTime.TabIndex = 23
            Me.lblTime.Text = "Display Time As:"
            '
            'chkStartTimeVisibility
            '
            Me.chkStartTimeVisibility.Location = New System.Drawing.Point(8, 5)
            Me.chkStartTimeVisibility.Name = "chkStartTimeVisibility"
            Me.chkStartTimeVisibility.Properties.AllowGrayed = True
            Me.chkStartTimeVisibility.Properties.Caption = "Start Time"
            Me.chkStartTimeVisibility.Size = New System.Drawing.Size(81, 19)
            Me.chkStartTimeVisibility.TabIndex = 3
            '
            'lblWeeksCount
            '
            Me.lblWeeksCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblWeeksCount.Location = New System.Drawing.Point(266, 34)
            Me.lblWeeksCount.Name = "lblWeeksCount"
            Me.lblWeeksCount.Size = New System.Drawing.Size(63, 13)
            Me.lblWeeksCount.TabIndex = 2
            Me.lblWeeksCount.Text = "Week Count:"
            '
            'spinWeekCount
            '
            Me.spinWeekCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinWeekCount.Location = New System.Drawing.Point(350, 31)
            Me.spinWeekCount.Name = "spinWeekCount"
            Me.spinWeekCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinWeekCount.Properties.IsFloatValue = False
            Me.spinWeekCount.Properties.Mask.EditMask = "N00"
            Me.spinWeekCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinWeekCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinWeekCount.Size = New System.Drawing.Size(96, 19)
            Me.spinWeekCount.TabIndex = 1
            '
            'chkCompressWeekEnd
            '
            Me.chkCompressWeekEnd.Location = New System.Drawing.Point(121, 31)
            Me.chkCompressWeekEnd.Name = "chkCompressWeekEnd"
            Me.chkCompressWeekEnd.Properties.Caption = "Compress Weekend"
            Me.chkCompressWeekEnd.Size = New System.Drawing.Size(136, 19)
            Me.chkCompressWeekEnd.TabIndex = 0
            '
            'chkEndTimeVisibility
            '
            Me.chkEndTimeVisibility.Location = New System.Drawing.Point(121, 5)
            Me.chkEndTimeVisibility.Name = "chkEndTimeVisibility"
            Me.chkEndTimeVisibility.Properties.AllowGrayed = True
            Me.chkEndTimeVisibility.Properties.Caption = "End Time"
            Me.chkEndTimeVisibility.Size = New System.Drawing.Size(69, 19)
            Me.chkEndTimeVisibility.TabIndex = 0
            '
            'chkShowWeekend
            '
            Me.chkShowWeekend.Location = New System.Drawing.Point(8, 31)
            Me.chkShowWeekend.Name = "chkShowWeekend"
            Me.chkShowWeekend.Properties.Caption = "Show Weekend"
            Me.chkShowWeekend.Size = New System.Drawing.Size(136, 19)
            Me.chkShowWeekend.TabIndex = 0
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 56)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'MonthViewModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "MonthViewModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinWeekCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkCompressWeekEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowWeekend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents chkCompressWeekEnd As DevExpress.XtraEditors.CheckEdit
		Private WithEvents spinWeekCount As DevExpress.XtraEditors.SpinEdit
        Private lblWeeksCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkShowWeekend As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbTimeDisplayType As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblTime As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkStartTimeVisibility As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkEndTimeVisibility As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbStatus As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblStatus As DevExpress.XtraEditors.LabelControl
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
