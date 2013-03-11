Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class DayViewModule
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
            Me.cbSnapToCellsMode = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblSnapToCellMode = New System.Windows.Forms.Label
            Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblStatus = New DevExpress.XtraEditors.LabelControl
            Me.cbAllDayStatus = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblAllDayStatus = New DevExpress.XtraEditors.LabelControl
            Me.lblDaysCount = New DevExpress.XtraEditors.LabelControl
            Me.spinDaysCount = New DevExpress.XtraEditors.SpinEdit
            Me.chkShowWorkTimeOnly = New DevExpress.XtraEditors.CheckEdit
            Me.chkShowAllDayArea = New DevExpress.XtraEditors.CheckEdit
            Me.chkAppointmentShadows = New DevExpress.XtraEditors.CheckEdit
            Me.chkShowDayHeaders = New DevExpress.XtraEditors.CheckEdit
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbSnapToCellsMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbAllDayStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinDaysCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowWorkTimeOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowAllDayArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAppointmentShadows.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowDayHeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 72)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 332)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbSnapToCellsMode)
            Me.panelControl.Controls.Add(Me.lblSnapToCellMode)
            Me.panelControl.Controls.Add(Me.cbStatus)
            Me.panelControl.Controls.Add(Me.lblStatus)
            Me.panelControl.Controls.Add(Me.cbAllDayStatus)
            Me.panelControl.Controls.Add(Me.lblAllDayStatus)
            Me.panelControl.Controls.Add(Me.lblDaysCount)
            Me.panelControl.Controls.Add(Me.spinDaysCount)
            Me.panelControl.Controls.Add(Me.chkShowWorkTimeOnly)
            Me.panelControl.Controls.Add(Me.chkShowAllDayArea)
            Me.panelControl.Controls.Add(Me.chkAppointmentShadows)
            Me.panelControl.Controls.Add(Me.chkShowDayHeaders)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 64)
            Me.panelControl.TabIndex = 2
            '
            'cbSnapToCellsMode
            '
            Me.cbSnapToCellsMode.Location = New System.Drawing.Point(371, 35)
            Me.cbSnapToCellsMode.Name = "cbSnapToCellsMode"
            Me.cbSnapToCellsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbSnapToCellsMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.[Auto], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Always", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never, -1)})
            Me.cbSnapToCellsMode.Size = New System.Drawing.Size(80, 19)
            Me.cbSnapToCellsMode.TabIndex = 92
            '
            'lblSnapToCellMode
            '
            Me.lblSnapToCellMode.AutoSize = True
            Me.lblSnapToCellMode.Location = New System.Drawing.Point(261, 38)
            Me.lblSnapToCellMode.Name = "lblSnapToCellMode"
            Me.lblSnapToCellMode.Size = New System.Drawing.Size(104, 13)
            Me.lblSnapToCellMode.TabIndex = 91
            Me.lblSnapToCellMode.Text = "Snap To Cells Mode:"
            '
            'cbStatus
            '
            Me.cbStatus.EditValue = ""
            Me.cbStatus.Location = New System.Drawing.Point(618, 10)
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbStatus.Size = New System.Drawing.Size(80, 19)
            Me.cbStatus.TabIndex = 89
            '
            'lblStatus
            '
            Me.lblStatus.Location = New System.Drawing.Point(471, 13)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(104, 13)
            Me.lblStatus.TabIndex = 88
            Me.lblStatus.Text = "Appointments Status:"
            '
            'cbAllDayStatus
            '
            Me.cbAllDayStatus.EditValue = ""
            Me.cbAllDayStatus.Location = New System.Drawing.Point(618, 35)
            Me.cbAllDayStatus.Name = "cbAllDayStatus"
            Me.cbAllDayStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbAllDayStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbAllDayStatus.Size = New System.Drawing.Size(80, 19)
            Me.cbAllDayStatus.TabIndex = 87
            '
            'lblAllDayStatus
            '
            Me.lblAllDayStatus.Location = New System.Drawing.Point(471, 38)
            Me.lblAllDayStatus.Name = "lblAllDayStatus"
            Me.lblAllDayStatus.Size = New System.Drawing.Size(141, 13)
            Me.lblAllDayStatus.TabIndex = 86
            Me.lblAllDayStatus.Text = "All-Day Appointments Status:"
            '
            'lblDaysCount
            '
            Me.lblDaysCount.Location = New System.Drawing.Point(264, 13)
            Me.lblDaysCount.Name = "lblDaysCount"
            Me.lblDaysCount.Size = New System.Drawing.Size(60, 13)
            Me.lblDaysCount.TabIndex = 4
            Me.lblDaysCount.Text = "Days Count:"
            '
            'spinDaysCount
            '
            Me.spinDaysCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinDaysCount.Location = New System.Drawing.Point(371, 10)
            Me.spinDaysCount.Name = "spinDaysCount"
            Me.spinDaysCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinDaysCount.Properties.IsFloatValue = False
            Me.spinDaysCount.Properties.Mask.EditMask = "N00"
            Me.spinDaysCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinDaysCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinDaysCount.Size = New System.Drawing.Size(80, 19)
            Me.spinDaysCount.TabIndex = 5
            '
            'chkShowWorkTimeOnly
            '
            Me.chkShowWorkTimeOnly.Location = New System.Drawing.Point(5, 10)
            Me.chkShowWorkTimeOnly.Name = "chkShowWorkTimeOnly"
            Me.chkShowWorkTimeOnly.Properties.Caption = "Show Work Time Only"
            Me.chkShowWorkTimeOnly.Size = New System.Drawing.Size(128, 19)
            Me.chkShowWorkTimeOnly.TabIndex = 0
            '
            'chkShowAllDayArea
            '
            Me.chkShowAllDayArea.Location = New System.Drawing.Point(139, 10)
            Me.chkShowAllDayArea.Name = "chkShowAllDayArea"
            Me.chkShowAllDayArea.Properties.Caption = "Show All Day Area"
            Me.chkShowAllDayArea.Size = New System.Drawing.Size(112, 19)
            Me.chkShowAllDayArea.TabIndex = 1
            '
            'chkAppointmentShadows
            '
            Me.chkAppointmentShadows.Location = New System.Drawing.Point(5, 35)
            Me.chkAppointmentShadows.Name = "chkAppointmentShadows"
            Me.chkAppointmentShadows.Properties.Caption = "Appointment Shadows"
            Me.chkAppointmentShadows.Size = New System.Drawing.Size(128, 19)
            Me.chkAppointmentShadows.TabIndex = 2
            '
            'chkShowDayHeaders
            '
            Me.chkShowDayHeaders.Location = New System.Drawing.Point(139, 35)
            Me.chkShowDayHeaders.Name = "chkShowDayHeaders"
            Me.chkShowDayHeaders.Properties.Caption = "Show Day Headers"
            Me.chkShowDayHeaders.Size = New System.Drawing.Size(112, 19)
            Me.chkShowDayHeaders.TabIndex = 3
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 64)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'DayViewModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "DayViewModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbSnapToCellsMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbAllDayStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinDaysCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowWorkTimeOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowAllDayArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAppointmentShadows.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowDayHeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private panelControl As DevExpress.XtraEditors.PanelControl
        Private lblDaysCount As DevExpress.XtraEditors.LabelControl
        Private WithEvents spinDaysCount As DevExpress.XtraEditors.SpinEdit
        Private WithEvents chkShowWorkTimeOnly As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkShowAllDayArea As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkAppointmentShadows As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkShowDayHeaders As DevExpress.XtraEditors.CheckEdit
        Private WithEvents cbAllDayStatus As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblAllDayStatus As DevExpress.XtraEditors.LabelControl
        Private WithEvents cbStatus As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblStatus As DevExpress.XtraEditors.LabelControl
        Private components As System.ComponentModel.IContainer = Nothing
        Friend WithEvents lblSnapToCellMode As System.Windows.Forms.Label
        Friend WithEvents cbSnapToCellsMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
