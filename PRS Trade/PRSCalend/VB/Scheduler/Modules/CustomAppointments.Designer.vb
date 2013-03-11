Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class CustomAppointmentsModule
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomAppointmentsModule))
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.imAppointmentIcons = New System.Windows.Forms.ImageList(Me.components)
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.lblAppointmentImages = New DevExpress.XtraEditors.LabelControl
            Me.rgrpAptImages = New DevExpress.XtraEditors.RadioGroup
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.chkShowRecurrence = New DevExpress.XtraEditors.CheckEdit
            Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblStatus = New DevExpress.XtraEditors.LabelControl
            Me.cbTimeDisplayType = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblTime = New DevExpress.XtraEditors.LabelControl
            Me.chkShowReminder = New DevExpress.XtraEditors.CheckEdit
            Me.chkStartTimeVisibility = New DevExpress.XtraEditors.CheckEdit
            Me.chkEndTimeVisibility = New DevExpress.XtraEditors.CheckEdit
            Me.chkToolTip = New DevExpress.XtraEditors.CheckEdit
            Me.chkText = New DevExpress.XtraEditors.CheckEdit
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.rgrpAptImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkToolTip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.AppointmentImages = Me.imAppointmentIcons
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 91)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always
            Me.schedulerControl.Size = New System.Drawing.Size(704, 313)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.ToolTipController = Me.toolTipController1
            Me.schedulerControl.Views.DayView.DayCount = 5
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'imAppointmentIcons
            '
            Me.imAppointmentIcons.ImageStream = CType(resources.GetObject("imAppointmentIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imAppointmentIcons.TransparentColor = System.Drawing.Color.Magenta
            Me.imAppointmentIcons.Images.SetKeyName(0, "clock-light.bmp")
            Me.imAppointmentIcons.Images.SetKeyName(1, "clock-dark.bmp")
            Me.imAppointmentIcons.Images.SetKeyName(2, "")
            Me.imAppointmentIcons.Images.SetKeyName(3, "")
            Me.imAppointmentIcons.Images.SetKeyName(4, "")
            '
            'toolTipController1
            '
            Me.toolTipController1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(93, Byte), Integer))
            Me.toolTipController1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(4, Byte), Integer))
            Me.toolTipController1.Appearance.Font = New System.Drawing.Font("Verdana", 7.25!)
            Me.toolTipController1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.toolTipController1.Appearance.Options.UseBackColor = True
            Me.toolTipController1.Appearance.Options.UseBorderColor = True
            Me.toolTipController1.Appearance.Options.UseFont = True
            Me.toolTipController1.Appearance.Options.UseForeColor = True
            Me.toolTipController1.AppearanceTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
            Me.toolTipController1.AppearanceTitle.Options.UseFont = True
            Me.toolTipController1.Rounded = True
            Me.toolTipController1.ShowBeak = True
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.lblAppointmentImages)
            Me.panelControl.Controls.Add(Me.rgrpAptImages)
            Me.panelControl.Controls.Add(Me.groupControl1)
            Me.panelControl.Controls.Add(Me.chkToolTip)
            Me.panelControl.Controls.Add(Me.chkText)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 83)
            Me.toolTipController1.SetSuperTip(Me.panelControl, Nothing)
            Me.panelControl.TabIndex = 2
            '
            'lblAppointmentImages
            '
            Me.lblAppointmentImages.Appearance.Options.UseTextOptions = True
            Me.lblAppointmentImages.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lblAppointmentImages.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.lblAppointmentImages.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lblAppointmentImages.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.lblAppointmentImages.Location = New System.Drawing.Point(330, 7)
            Me.lblAppointmentImages.Name = "lblAppointmentImages"
            Me.lblAppointmentImages.Size = New System.Drawing.Size(67, 26)
            Me.lblAppointmentImages.TabIndex = 83
            Me.lblAppointmentImages.Text = "Appointment images:"
            '
            'rgrpAptImages
            '
            Me.rgrpAptImages.EditValue = 0
            Me.rgrpAptImages.Location = New System.Drawing.Point(403, 7)
            Me.rgrpAptImages.Name = "rgrpAptImages"
            Me.rgrpAptImages.Properties.Columns = 1
            Me.rgrpAptImages.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Default"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "External"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Custom")})
            Me.rgrpAptImages.Size = New System.Drawing.Size(75, 72)
            Me.rgrpAptImages.TabIndex = 82
            '
            'groupControl1
            '
            Me.groupControl1.Controls.Add(Me.chkShowRecurrence)
            Me.groupControl1.Controls.Add(Me.cbStatus)
            Me.groupControl1.Controls.Add(Me.lblStatus)
            Me.groupControl1.Controls.Add(Me.cbTimeDisplayType)
            Me.groupControl1.Controls.Add(Me.lblTime)
            Me.groupControl1.Controls.Add(Me.chkShowReminder)
            Me.groupControl1.Controls.Add(Me.chkStartTimeVisibility)
            Me.groupControl1.Controls.Add(Me.chkEndTimeVisibility)
            Me.groupControl1.Location = New System.Drawing.Point(5, 7)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(321, 72)
            Me.toolTipController1.SetSuperTip(Me.groupControl1, Nothing)
            Me.groupControl1.TabIndex = 17
            Me.groupControl1.Text = "Display Options"
            '
            'chkShowRecurrence
            '
            Me.chkShowRecurrence.Location = New System.Drawing.Point(233, 24)
            Me.chkShowRecurrence.Name = "chkShowRecurrence"
            Me.chkShowRecurrence.Properties.Caption = "Recurrence"
            Me.chkShowRecurrence.Size = New System.Drawing.Size(85, 19)
            Me.chkShowRecurrence.TabIndex = 74
            '
            'cbStatus
            '
            Me.cbStatus.EditValue = ""
            Me.cbStatus.Location = New System.Drawing.Point(53, 23)
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbStatus.Size = New System.Drawing.Size(96, 19)
            Me.cbStatus.TabIndex = 73
            '
            'lblStatus
            '
            Me.lblStatus.Location = New System.Drawing.Point(12, 26)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(35, 13)
            Me.lblStatus.TabIndex = 72
            Me.lblStatus.Text = "Status:"
            '
            'cbTimeDisplayType
            '
            Me.cbTimeDisplayType.EditValue = ""
            Me.cbTimeDisplayType.Location = New System.Drawing.Point(53, 49)
            Me.cbTimeDisplayType.Name = "cbTimeDisplayType"
            Me.cbTimeDisplayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeDisplayType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentTimeDisplayType.[Auto], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Clock", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Clock, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Text", DevExpress.XtraScheduler.AppointmentTimeDisplayType.Text, -1)})
            Me.cbTimeDisplayType.Size = New System.Drawing.Size(96, 19)
            Me.cbTimeDisplayType.TabIndex = 22
            '
            'lblTime
            '
            Me.lblTime.Location = New System.Drawing.Point(12, 52)
            Me.lblTime.Name = "lblTime"
            Me.lblTime.Size = New System.Drawing.Size(26, 13)
            Me.lblTime.TabIndex = 21
            Me.lblTime.Text = "Time:"
            '
            'chkShowReminder
            '
            Me.chkShowReminder.Location = New System.Drawing.Point(233, 49)
            Me.chkShowReminder.Name = "chkShowReminder"
            Me.chkShowReminder.Properties.Caption = "Reminder"
            Me.chkShowReminder.Size = New System.Drawing.Size(72, 19)
            Me.chkShowReminder.TabIndex = 13
            '
            'chkStartTimeVisibility
            '
            Me.chkStartTimeVisibility.Location = New System.Drawing.Point(155, 24)
            Me.chkStartTimeVisibility.Name = "chkStartTimeVisibility"
            Me.chkStartTimeVisibility.Properties.AllowGrayed = True
            Me.chkStartTimeVisibility.Properties.Caption = "Start Time"
            Me.chkStartTimeVisibility.Size = New System.Drawing.Size(72, 19)
            Me.chkStartTimeVisibility.TabIndex = 11
            '
            'chkEndTimeVisibility
            '
            Me.chkEndTimeVisibility.Location = New System.Drawing.Point(155, 49)
            Me.chkEndTimeVisibility.Name = "chkEndTimeVisibility"
            Me.chkEndTimeVisibility.Properties.AllowGrayed = True
            Me.chkEndTimeVisibility.Properties.Caption = "End Time"
            Me.chkEndTimeVisibility.Size = New System.Drawing.Size(72, 19)
            Me.chkEndTimeVisibility.TabIndex = 10
            '
            'chkToolTip
            '
            Me.chkToolTip.EditValue = True
            Me.chkToolTip.Location = New System.Drawing.Point(484, 30)
            Me.chkToolTip.Name = "chkToolTip"
            Me.chkToolTip.Properties.Caption = "Custom tooltip"
            Me.chkToolTip.Size = New System.Drawing.Size(96, 19)
            Me.chkToolTip.TabIndex = 3
            '
            'chkText
            '
            Me.chkText.EditValue = True
            Me.chkText.Location = New System.Drawing.Point(484, 7)
            Me.chkText.Name = "chkText"
            Me.chkText.Properties.Caption = "Custom text"
            Me.chkText.Size = New System.Drawing.Size(88, 19)
            Me.chkText.TabIndex = 2
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 83)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.toolTipController1.SetSuperTip(Me.panelSeparatorControl, Nothing)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'CustomAppointmentsModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "CustomAppointmentsModule"
            Me.Size = New System.Drawing.Size(704, 404)
            Me.toolTipController1.SetSuperTip(Me, Nothing)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            CType(Me.rgrpAptImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.chkShowRecurrence.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbTimeDisplayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkStartTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkEndTimeVisibility.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkToolTip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private imAppointmentIcons As System.Windows.Forms.ImageList
		Private WithEvents chkText As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkToolTip As DevExpress.XtraEditors.CheckEdit
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents chkStartTimeVisibility As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkEndTimeVisibility As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkShowReminder As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cbTimeDisplayType As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblTime As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbStatus As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblStatus As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkShowRecurrence As DevExpress.XtraEditors.CheckEdit
		Private WithEvents rgrpAptImages As DevExpress.XtraEditors.RadioGroup
        Private lblAppointmentImages As DevExpress.XtraEditors.LabelControl
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
