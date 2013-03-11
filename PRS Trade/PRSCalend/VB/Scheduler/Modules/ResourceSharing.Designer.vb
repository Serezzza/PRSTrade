Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class ResourceSharingModule
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeScaleYear1 As New DevExpress.XtraScheduler.TimeScaleYear()
			Dim timeScaleQuarter1 As New DevExpress.XtraScheduler.TimeScaleQuarter()
			Dim timeScaleMonth1 As New DevExpress.XtraScheduler.TimeScaleMonth()
			Dim timeScaleWeek1 As New DevExpress.XtraScheduler.TimeScaleWeek()
			Dim timeScaleDay1 As New DevExpress.XtraScheduler.TimeScaleDay()
			Dim timeScaleHour1 As New DevExpress.XtraScheduler.TimeScaleHour()
			Dim timeScaleFixedInterval1 As New DevExpress.XtraScheduler.TimeScaleFixedInterval()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.resourcesCheckedListBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl()
			Me.panelControl = New DevExpress.XtraEditors.PanelControl()
			Me.lblResource = New DevExpress.XtraEditors.LabelControl()
			Me.resourcesComboBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesComboBoxControl()
			Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lblGroup = New DevExpress.XtraEditors.LabelControl()
			Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.lblView = New DevExpress.XtraEditors.LabelControl()
			Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl()
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl.SuspendLayout()
			CType(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl
			' 
			Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
			Me.schedulerControl.Location = New System.Drawing.Point(0, 42)
			Me.schedulerControl.MenuManager = Me
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(522, 362)
   Me.schedulerControl.Start = New System.DateTime(2010, 6, 29, 0, 0, 0, 0)
			Me.schedulerControl.Storage = Me.schedulerStorage
			Me.schedulerControl.TabIndex = 0
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.DayCount = 2
			Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
			Me.schedulerControl.Views.DayView.ShowMoreButtonsOnEachColumn = True
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("00:10:00")
			Me.schedulerControl.Views.DayView.VisibleTime.End = System.TimeSpan.Parse("19:00:00")
			Me.schedulerControl.Views.DayView.VisibleTime.Start = System.TimeSpan.Parse("08:00:00")
			Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
			Me.schedulerControl.Views.MonthView.WeekCount = 2
			Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 4
			timeScaleYear1.Enabled = False
			timeScaleQuarter1.Enabled = False
			timeScaleMonth1.Enabled = False
			timeScaleDay1.Width = 135
			timeScaleHour1.Enabled = False
			timeScaleHour1.Width = 100
			timeScaleFixedInterval1.Enabled = False
			timeScaleFixedInterval1.Width = 100
			Me.schedulerControl.Views.TimelineView.Scales.Add(timeScaleYear1)
			Me.schedulerControl.Views.TimelineView.Scales.Add(timeScaleQuarter1)
			Me.schedulerControl.Views.TimelineView.Scales.Add(timeScaleMonth1)
			Me.schedulerControl.Views.TimelineView.Scales.Add(timeScaleWeek1)
			Me.schedulerControl.Views.TimelineView.Scales.Add(timeScaleDay1)
			Me.schedulerControl.Views.TimelineView.Scales.Add(timeScaleHour1)
			Me.schedulerControl.Views.TimelineView.Scales.Add(timeScaleFixedInterval1)
			Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
			Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
			Me.schedulerControl.Views.WorkWeekView.ShowMoreButtonsOnEachColumn = True
			Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			Me.schedulerControl.Views.WorkWeekView.TimeScale = System.TimeSpan.Parse("00:10:00")
			Me.schedulerControl.Views.WorkWeekView.VisibleTime.End = System.TimeSpan.Parse("19:00:00")
			Me.schedulerControl.Views.WorkWeekView.VisibleTime.Start = System.TimeSpan.Parse("08:00:00")
            Me.schedulerControl.Views.GanttView.Enabled = False
'			Me.schedulerControl.ActiveViewChanged += New System.EventHandler(Me.schedulerControl_ActiveViewChanged);
			' 
			' schedulerStorage
			' 
			Me.schedulerStorage.Appointments.ResourceSharing = True
'			Me.schedulerStorage.AppointmentChanging += New DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(Me.schedulerStorage_AppointmentChanging);
'			Me.schedulerStorage.AppointmentInserting += New DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(Me.schedulerStorage_AppointmentChanging);
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitterControl1.Location = New System.Drawing.Point(522, 42)
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(6, 362)
			Me.splitterControl1.TabIndex = 9
			Me.splitterControl1.TabStop = False
			' 
			' resourcesCheckedListBoxControl1
			' 
			Me.resourcesCheckedListBoxControl1.CheckOnClick = True
			Me.resourcesCheckedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.resourcesCheckedListBoxControl1.ItemHeight = 16
			Me.resourcesCheckedListBoxControl1.Location = New System.Drawing.Point(528, 42)
			Me.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1"
			Me.resourcesCheckedListBoxControl1.SchedulerControl = Me.schedulerControl
			Me.resourcesCheckedListBoxControl1.Size = New System.Drawing.Size(176, 362)
			Me.resourcesCheckedListBoxControl1.TabIndex = 8
			' 
			' panelControl
			' 
			Me.panelControl.Controls.Add(Me.lblResource)
			Me.panelControl.Controls.Add(Me.resourcesComboBoxControl1)
			Me.panelControl.Controls.Add(Me.cbGrouping)
			Me.panelControl.Controls.Add(Me.lblGroup)
			Me.panelControl.Controls.Add(Me.cbView)
			Me.panelControl.Controls.Add(Me.lblView)
			Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl.Location = New System.Drawing.Point(0, 0)
			Me.panelControl.Name = "panelControl"
			Me.panelControl.Size = New System.Drawing.Size(704, 34)
			Me.panelControl.TabIndex = 7
			' 
			' lblResource
			' 
			Me.lblResource.Location = New System.Drawing.Point(452, 11)
			Me.lblResource.Name = "lblResource"
			Me.lblResource.Size = New System.Drawing.Size(78, 13)
			Me.lblResource.TabIndex = 37
			Me.lblResource.Text = "Select resource:"
			' 
			' resourcesComboBoxControl1
			' 
			Me.resourcesComboBoxControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.resourcesComboBoxControl1.Location = New System.Drawing.Point(536, 8)
			Me.resourcesComboBoxControl1.Name = "resourcesComboBoxControl1"
			Me.resourcesComboBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.resourcesComboBoxControl1.SchedulerControl = Me.schedulerControl
			Me.resourcesComboBoxControl1.Size = New System.Drawing.Size(163, 20)
			Me.resourcesComboBoxControl1.TabIndex = 36
			' 
			' cbGrouping
			' 
			Me.cbGrouping.EditValue = ""
			Me.cbGrouping.Location = New System.Drawing.Point(236, 8)
			Me.cbGrouping.Name = "cbGrouping"
			Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.SchedulerGroupType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.Date, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
			Me.cbGrouping.Size = New System.Drawing.Size(118, 20)
			Me.cbGrouping.TabIndex = 35
'			Me.cbGrouping.SelectedIndexChanged += New System.EventHandler(Me.cbGrouping_SelectedIndexChanged);
			' 
			' lblGroup
			' 
			Me.lblGroup.Location = New System.Drawing.Point(182, 11)
			Me.lblGroup.Name = "lblGroup"
			Me.lblGroup.Size = New System.Drawing.Size(48, 13)
			Me.lblGroup.TabIndex = 34
			Me.lblGroup.Text = "Group By:"
			' 
			' cbView
			' 
			Me.cbView.EditValue = ""
			Me.cbView.Location = New System.Drawing.Point(49, 8)
			Me.cbView.Name = "cbView"
			Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
			Me.cbView.Size = New System.Drawing.Size(118, 20)
			Me.cbView.TabIndex = 30
'			Me.cbView.SelectedIndexChanged += New System.EventHandler(Me.cbView_SelectedIndexChanged);
			' 
			' lblView
			' 
			Me.lblView.Location = New System.Drawing.Point(13, 11)
			Me.lblView.Name = "lblView"
			Me.lblView.Size = New System.Drawing.Size(30, 13)
			Me.lblView.TabIndex = 29
			Me.lblView.Text = "Show:"
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 34)
			Me.panelSeparatorControl.Name = "panelSeparatorControl"
			Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
			Me.panelSeparatorControl.TabIndex = 10
			' 
			' ResourceSharingModule
			' 
			Me.Controls.Add(Me.schedulerControl)
			Me.Controls.Add(Me.splitterControl1)
			Me.Controls.Add(Me.resourcesCheckedListBoxControl1)
			Me.Controls.Add(Me.panelSeparatorControl)
			Me.Controls.Add(Me.panelControl)
			Me.Name = "ResourceSharingModule"
			Me.Size = New System.Drawing.Size(704, 404)
'			Me.Load += New System.EventHandler(Me.GroupByDateModule_Load);
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl.ResumeLayout(False)
			Me.panelControl.PerformLayout()
			CType(Me.resourcesComboBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private resourcesCheckedListBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private lblResource As DevExpress.XtraEditors.LabelControl
		Private resourcesComboBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesComboBoxControl
		Private WithEvents cbGrouping As DevExpress.XtraEditors.ImageComboBoxEdit
		Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
		Private lblView As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
