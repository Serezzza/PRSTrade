Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class CustomDrawModule
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
            Me.chkNavigationButton = New DevExpress.XtraEditors.CheckEdit
            Me.chkAppointmentBackground = New DevExpress.XtraEditors.CheckEdit
            Me.chkDayOfWeekHeader = New DevExpress.XtraEditors.CheckEdit
            Me.chkWeekViewTopLeftCorner = New DevExpress.XtraEditors.CheckEdit
            Me.chkGroupSeparator = New DevExpress.XtraEditors.CheckEdit
            Me.chkAppointment = New DevExpress.XtraEditors.CheckEdit
            Me.chkDayViewAllDayArea = New DevExpress.XtraEditors.CheckEdit
            Me.chkTimeCell = New DevExpress.XtraEditors.CheckEdit
            Me.chkDayHeader = New DevExpress.XtraEditors.CheckEdit
            Me.chkResourceHeader = New DevExpress.XtraEditors.CheckEdit
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.chkNavigationButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkDayOfWeekHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkWeekViewTopLeftCorner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkGroupSeparator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAppointment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.[Date]
            Me.schedulerControl.Location = New System.Drawing.Point(0, 88)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None
            Me.schedulerControl.Size = New System.Drawing.Size(704, 316)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("01:00:00")
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.chkNavigationButton)
            Me.panelControl.Controls.Add(Me.chkAppointmentBackground)
            Me.panelControl.Controls.Add(Me.chkDayOfWeekHeader)
            Me.panelControl.Controls.Add(Me.chkWeekViewTopLeftCorner)
            Me.panelControl.Controls.Add(Me.chkGroupSeparator)
            Me.panelControl.Controls.Add(Me.chkAppointment)
            Me.panelControl.Controls.Add(Me.chkDayViewAllDayArea)
            Me.panelControl.Controls.Add(Me.chkTimeCell)
            Me.panelControl.Controls.Add(Me.chkDayHeader)
            Me.panelControl.Controls.Add(Me.chkResourceHeader)
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Controls.Add(Me.cbGrouping)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 80)
            Me.panelControl.TabIndex = 26
            '
            'chkNavigationButton
            '
            Me.chkNavigationButton.EditValue = True
            Me.chkNavigationButton.Location = New System.Drawing.Point(557, 5)
            Me.chkNavigationButton.Name = "chkNavigationButton"
            Me.chkNavigationButton.Properties.Caption = "Navigation Button"
            Me.chkNavigationButton.Size = New System.Drawing.Size(117, 19)
            Me.chkNavigationButton.TabIndex = 89
            '
            'chkAppointmentBackground
            '
            Me.chkAppointmentBackground.EditValue = True
            Me.chkAppointmentBackground.Location = New System.Drawing.Point(433, 30)
            Me.chkAppointmentBackground.Name = "chkAppointmentBackground"
            Me.chkAppointmentBackground.Properties.Caption = "Appointment Background"
            Me.chkAppointmentBackground.Size = New System.Drawing.Size(149, 19)
            Me.chkAppointmentBackground.TabIndex = 87
            '
            'chkDayOfWeekHeader
            '
            Me.chkDayOfWeekHeader.EditValue = True
            Me.chkDayOfWeekHeader.Location = New System.Drawing.Point(186, 55)
            Me.chkDayOfWeekHeader.Name = "chkDayOfWeekHeader"
            Me.chkDayOfWeekHeader.Properties.Caption = "Day-Of-Week Header"
            Me.chkDayOfWeekHeader.Size = New System.Drawing.Size(131, 19)
            Me.chkDayOfWeekHeader.TabIndex = 86
            '
            'chkWeekViewTopLeftCorner
            '
            Me.chkWeekViewTopLeftCorner.EditValue = True
            Me.chkWeekViewTopLeftCorner.Location = New System.Drawing.Point(433, 55)
            Me.chkWeekViewTopLeftCorner.Name = "chkWeekViewTopLeftCorner"
            Me.chkWeekViewTopLeftCorner.Properties.Caption = "Top-Left Corner"
            Me.chkWeekViewTopLeftCorner.Size = New System.Drawing.Size(104, 19)
            Me.chkWeekViewTopLeftCorner.TabIndex = 85
            '
            'chkGroupSeparator
            '
            Me.chkGroupSeparator.EditValue = True
            Me.chkGroupSeparator.Location = New System.Drawing.Point(323, 5)
            Me.chkGroupSeparator.Name = "chkGroupSeparator"
            Me.chkGroupSeparator.Properties.Caption = "Group Separator"
            Me.chkGroupSeparator.Size = New System.Drawing.Size(104, 19)
            Me.chkGroupSeparator.TabIndex = 84
            '
            'chkAppointment
            '
            Me.chkAppointment.EditValue = True
            Me.chkAppointment.Location = New System.Drawing.Point(433, 5)
            Me.chkAppointment.Name = "chkAppointment"
            Me.chkAppointment.Properties.Caption = "Appointment"
            Me.chkAppointment.Size = New System.Drawing.Size(85, 19)
            Me.chkAppointment.TabIndex = 83
            '
            'chkDayViewAllDayArea
            '
            Me.chkDayViewAllDayArea.EditValue = True
            Me.chkDayViewAllDayArea.Location = New System.Drawing.Point(323, 55)
            Me.chkDayViewAllDayArea.Name = "chkDayViewAllDayArea"
            Me.chkDayViewAllDayArea.Properties.Caption = "All-Day Area"
            Me.chkDayViewAllDayArea.Size = New System.Drawing.Size(85, 19)
            Me.chkDayViewAllDayArea.TabIndex = 82
            '
            'chkTimeCell
            '
            Me.chkTimeCell.EditValue = True
            Me.chkTimeCell.Location = New System.Drawing.Point(323, 30)
            Me.chkTimeCell.Name = "chkTimeCell"
            Me.chkTimeCell.Properties.Caption = "Time Cell"
            Me.chkTimeCell.Size = New System.Drawing.Size(72, 19)
            Me.chkTimeCell.TabIndex = 81
            '
            'chkDayHeader
            '
            Me.chkDayHeader.EditValue = True
            Me.chkDayHeader.Location = New System.Drawing.Point(186, 5)
            Me.chkDayHeader.Name = "chkDayHeader"
            Me.chkDayHeader.Properties.Caption = "Day Header"
            Me.chkDayHeader.Size = New System.Drawing.Size(88, 19)
            Me.chkDayHeader.TabIndex = 80
            '
            'chkResourceHeader
            '
            Me.chkResourceHeader.EditValue = True
            Me.chkResourceHeader.Location = New System.Drawing.Point(186, 30)
            Me.chkResourceHeader.Name = "chkResourceHeader"
            Me.chkResourceHeader.Properties.Caption = "Resource Header"
            Me.chkResourceHeader.Size = New System.Drawing.Size(107, 19)
            Me.chkResourceHeader.TabIndex = 79
            '
            'cbView
            '
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(68, 5)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(112, 19)
            Me.cbView.TabIndex = 37
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(14, 8)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 36
            Me.lblView.Text = "Show:"
            '
            'cbGrouping
            '
            Me.cbGrouping.EditValue = ""
            Me.cbGrouping.Location = New System.Drawing.Point(68, 30)
            Me.cbGrouping.Name = "cbGrouping"
            Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.SchedulerGroupType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.[Date], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
            Me.cbGrouping.Size = New System.Drawing.Size(112, 19)
            Me.cbGrouping.TabIndex = 35
            '
            'lblGroup
            '
            Me.lblGroup.Location = New System.Drawing.Point(14, 33)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 34
            Me.lblGroup.Text = "Group By:"
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 80)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 27
            '
            'CustomDrawModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "CustomDrawModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.chkNavigationButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkDayOfWeekHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkWeekViewTopLeftCorner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkGroupSeparator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAppointment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbGrouping As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkDayOfWeekHeader As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkWeekViewTopLeftCorner As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkGroupSeparator As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAppointment As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkDayViewAllDayArea As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkTimeCell As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkDayHeader As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkResourceHeader As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAppointmentBackground As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents chkNavigationButton As DevExpress.XtraEditors.CheckEdit
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
