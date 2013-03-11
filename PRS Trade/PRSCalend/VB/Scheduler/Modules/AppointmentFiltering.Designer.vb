Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class AppointmentFilteringModule
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
            Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear
            Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter
            Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth
            Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek
            Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay
            Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour
            Dim TimeScaleFixedInterval1 As DevExpress.XtraScheduler.TimeScaleFixedInterval = New DevExpress.XtraScheduler.TimeScaleFixedInterval
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.lblSportFilter = New DevExpress.XtraEditors.LabelControl
            Me.imcbSports = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblResource = New DevExpress.XtraEditors.LabelControl
            Me.resourcesComboBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesComboBoxControl
            Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.resourcesCheckedListBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.imcbSports.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 62)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsView.ResourceHeaders.Height = 90
            Me.schedulerControl.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
            Me.schedulerControl.OptionsView.ResourceHeaders.RotateCaption = False
            Me.schedulerControl.Size = New System.Drawing.Size(522, 342)
            Me.schedulerControl.Start = New Date(2010, 6, 22, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.AppointmentHeight = 27
            Me.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
            Me.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
            Me.schedulerControl.Views.TimelineView.AppointmentDisplayOptions.StatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            TimeScaleYear1.Enabled = False
            TimeScaleYear1.Width = 100
            TimeScaleQuarter1.Enabled = False
            TimeScaleQuarter1.Width = 100
            TimeScaleMonth1.Enabled = False
            TimeScaleMonth1.Width = 100
            TimeScaleWeek1.Width = 100
            TimeScaleDay1.Width = 100
            TimeScaleHour1.Width = 100
            TimeScaleFixedInterval1.Enabled = False
            TimeScaleFixedInterval1.Width = 100
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleYear1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleQuarter1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleMonth1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleWeek1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleDay1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleHour1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleFixedInterval1)
            Me.schedulerControl.Views.TimelineView.TimelineScrollBarVisible = True
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'schedulerStorage
            '
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "Basketball", "&Basketball"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(190, Byte), Integer)), "Boxing", "&Boxing"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer)), "Tennis", "&Tennis"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(156, Byte), Integer)), "Weightlifting", "&Weightlifting"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(199, Byte), Integer)), "Fencing", "&Fencing"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(147, Byte), Integer)), "Soccer", "&Soccer"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer)), "Artistic Gymnastics", "&Artistic Gymnastics"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(152, Byte), Integer)), "Canoe", "&Canoe"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer)), "Kayak", "&Kayak"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(223, Byte), Integer)), "Wrestling", "&Wrestling"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(165, Byte), Integer)), "Equestrianism", "&Equestrianism"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(160, Byte), Integer)), "Sailing"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(225, Byte), Integer)), "Swimming", "S&wimming"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(126, Byte), Integer)), "Diving", "&Diving"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(169, Byte), Integer)), "Handball", "&Handball"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer)), "Gymnastics", "&Gymnastics"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(225, Byte), Integer)), "Athletics", "&Athletics"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(122, Byte), Integer)), "Shooting", "Shoo&ting"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(213, Byte), Integer)), "Archery", "Arche&ry"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(193, Byte), Integer)), "Cycling", "C&ycling"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(135, Byte), Integer)), "Water Polo", "Water &Polo"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(130, Byte), Integer)), "Volleyball", "&Volleyball"))
            Me.schedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Busy, System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(226, Byte), Integer)), "Busy", "&Busy"))
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.lblSportFilter)
            Me.panelControl.Controls.Add(Me.imcbSports)
            Me.panelControl.Controls.Add(Me.lblResource)
            Me.panelControl.Controls.Add(Me.resourcesComboBoxControl1)
            Me.panelControl.Controls.Add(Me.cbGrouping)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 54)
            Me.panelControl.TabIndex = 2
            '
            'lblSportFilter
            '
            Me.lblSportFilter.Location = New System.Drawing.Point(195, 10)
            Me.lblSportFilter.Name = "lblSportFilter"
            Me.lblSportFilter.Size = New System.Drawing.Size(71, 13)
            Me.lblSportFilter.TabIndex = 39
            Me.lblSportFilter.Text = "Display sports:"
            '
            'imcbSports
            '
            Me.imcbSports.Location = New System.Drawing.Point(272, 7)
            Me.imcbSports.Name = "imcbSports"
            Me.imcbSports.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imcbSports.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("All sports", -1, -1)})
            Me.imcbSports.Properties.Sorted = True
            Me.imcbSports.Size = New System.Drawing.Size(171, 20)
            Me.imcbSports.TabIndex = 38
            '
            'lblResource
            '
            Me.lblResource.Location = New System.Drawing.Point(462, 10)
            Me.lblResource.Name = "lblResource"
            Me.lblResource.Size = New System.Drawing.Size(85, 13)
            Me.lblResource.TabIndex = 37
            Me.lblResource.Text = "Display Channels:"
            '
            'resourcesComboBoxControl1
            '
            Me.resourcesComboBoxControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.resourcesComboBoxControl1.Location = New System.Drawing.Point(553, 7)
            Me.resourcesComboBoxControl1.Name = "resourcesComboBoxControl1"
            Me.resourcesComboBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.resourcesComboBoxControl1.SchedulerControl = Me.schedulerControl
            Me.resourcesComboBoxControl1.Size = New System.Drawing.Size(146, 20)
            Me.resourcesComboBoxControl1.TabIndex = 36
            '
            'cbGrouping
            '
            Me.cbGrouping.EditValue = ""
            Me.cbGrouping.Location = New System.Drawing.Point(63, 28)
            Me.cbGrouping.Name = "cbGrouping"
            Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.SchedulerGroupType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.[Date], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
            Me.cbGrouping.Size = New System.Drawing.Size(118, 20)
            Me.cbGrouping.TabIndex = 35
            '
            'lblGroup
            '
            Me.lblGroup.Location = New System.Drawing.Point(9, 31)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 34
            Me.lblGroup.Text = "Group By:"
            '
            'cbView
            '
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(63, 7)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(118, 20)
            Me.cbView.TabIndex = 30
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(9, 10)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 29
            Me.lblView.Text = "Show:"
            '
            'resourcesCheckedListBoxControl1
            '
            Me.resourcesCheckedListBoxControl1.CheckOnClick = True
            Me.resourcesCheckedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.resourcesCheckedListBoxControl1.ItemHeight = 16
            Me.resourcesCheckedListBoxControl1.Location = New System.Drawing.Point(528, 62)
            Me.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1"
            Me.resourcesCheckedListBoxControl1.SchedulerControl = Me.schedulerControl
            Me.resourcesCheckedListBoxControl1.Size = New System.Drawing.Size(176, 342)
            Me.resourcesCheckedListBoxControl1.TabIndex = 5
            '
            'splitterControl1
            '
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitterControl1.Location = New System.Drawing.Point(522, 62)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(6, 342)
            Me.splitterControl1.TabIndex = 6
            Me.splitterControl1.TabStop = False
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 54)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'AppointmentFilteringModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.resourcesCheckedListBoxControl1)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "AppointmentFilteringModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.imcbSports.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbGrouping As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private resourcesCheckedListBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private resourcesComboBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesComboBoxControl
        Private lblResource As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer = Nothing
        Private lblSportFilter As DevExpress.XtraEditors.LabelControl
        Private WithEvents imcbSports As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
