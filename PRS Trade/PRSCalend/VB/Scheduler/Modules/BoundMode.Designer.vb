Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class BoundModeModule
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
            Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet = New CarsDBDataSet
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.rgrpGrouping = New DevExpress.XtraEditors.RadioGroup
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl
            Me.splitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
            Me.resourcesCheckedListBoxControl1 = New DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator
            Me.carSchedulingTableAdapter = New CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
            Me.carsTableAdapter = New CarsDBDataSetTableAdapters.CarsTableAdapter
            Me.usageTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.usageTypeTableAdapter = New CarsDBDataSetTableAdapters.UsageTypeTableAdapter
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rgrpGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl2.SuspendLayout()
            CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.usageTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 48)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
            Me.schedulerControl.OptionsView.ResourceHeaders.ImageSize = New System.Drawing.Size(100, 50)
            Me.schedulerControl.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage
            Me.schedulerControl.Size = New System.Drawing.Size(522, 356)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'schedulerStorage
            '
            Me.schedulerStorage.Appointments.DataSource = Me.carSchedulingBindingSource
            Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage.Appointments.Mappings.End = "EndTime"
            Me.schedulerStorage.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage.Appointments.Mappings.ResourceId = "CarId"
            Me.schedulerStorage.Appointments.Mappings.Start = "StartTime"
            Me.schedulerStorage.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage.Appointments.Mappings.Type = "EventType"
            Me.schedulerStorage.Resources.DataSource = Me.carsBindingSource
            Me.schedulerStorage.Resources.Mappings.Id = "ID"
            Me.schedulerStorage.Resources.Mappings.Image = "Picture"
            '
            'carSchedulingBindingSource
            '
            Me.carSchedulingBindingSource.DataMember = "CarScheduling"
            Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet
            '
            'carsDBDataSet
            '
            Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'carsBindingSource
            '
            Me.carsBindingSource.AllowNew = False
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.carsDBDataSet
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.rgrpGrouping)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 40)
            Me.panelControl.TabIndex = 2
            '
            'cbView
            '
            Me.cbView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(50, 12)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(328, 19)
            Me.cbView.TabIndex = 4
            '
            'lblGroup
            '
            Me.lblGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblGroup.Location = New System.Drawing.Point(392, 15)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 3
            Me.lblGroup.Text = "Group By:"
            '
            'rgrpGrouping
            '
            Me.rgrpGrouping.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rgrpGrouping.EditValue = 1
            Me.rgrpGrouping.Location = New System.Drawing.Point(446, 8)
            Me.rgrpGrouping.Name = "rgrpGrouping"
            Me.rgrpGrouping.Properties.Columns = 3
            Me.rgrpGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.None, "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.[Date], "Date"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.Resource, "Resource")})
            Me.rgrpGrouping.Size = New System.Drawing.Size(253, 24)
            Me.rgrpGrouping.TabIndex = 2
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(14, 15)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 3
            Me.lblView.Text = "Show:"
            '
            'splitterControl1
            '
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitterControl1.Location = New System.Drawing.Point(523, 48)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(5, 356)
            Me.splitterControl1.TabIndex = 4
            Me.splitterControl1.TabStop = False
            '
            'splitContainerControl2
            '
            Me.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitContainerControl2.Horizontal = False
            Me.splitContainerControl2.Location = New System.Drawing.Point(528, 48)
            Me.splitContainerControl2.Name = "splitContainerControl2"
            Me.splitContainerControl2.Panel1.Controls.Add(Me.resourcesCheckedListBoxControl1)
            Me.splitContainerControl2.Panel1.Text = "splitContainerControl2_Panel1"
            Me.splitContainerControl2.Panel2.Controls.Add(Me.dateNavigator1)
            Me.splitContainerControl2.Panel2.Text = "splitContainerControl2_Panel2"
            Me.splitContainerControl2.Size = New System.Drawing.Size(176, 356)
            Me.splitContainerControl2.SplitterPosition = 96
            Me.splitContainerControl2.TabIndex = 5
            Me.splitContainerControl2.Text = "splitContainerControl2"
            '
            'resourcesCheckedListBoxControl1
            '
            Me.resourcesCheckedListBoxControl1.CheckOnClick = True
            Me.resourcesCheckedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resourcesCheckedListBoxControl1.ItemHeight = 16
            Me.resourcesCheckedListBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.resourcesCheckedListBoxControl1.Name = "resourcesCheckedListBoxControl1"
            Me.resourcesCheckedListBoxControl1.SchedulerControl = Me.schedulerControl
            Me.resourcesCheckedListBoxControl1.Size = New System.Drawing.Size(176, 96)
            Me.resourcesCheckedListBoxControl1.TabIndex = 4
            '
            'dateNavigator1
            '
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateNavigator1.HotDate = Nothing
            Me.dateNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl
            Me.dateNavigator1.Size = New System.Drawing.Size(176, 255)
            Me.dateNavigator1.TabIndex = 0
            '
            'carSchedulingTableAdapter
            '
            Me.carSchedulingTableAdapter.ClearBeforeFill = True
            '
            'carsTableAdapter
            '
            Me.carsTableAdapter.ClearBeforeFill = True
            '
            'usageTypeBindingSource
            '
            Me.usageTypeBindingSource.AllowNew = False
            Me.usageTypeBindingSource.DataMember = "UsageType"
            Me.usageTypeBindingSource.DataSource = Me.carsDBDataSet
            '
            'usageTypeTableAdapter
            '
            Me.usageTypeTableAdapter.ClearBeforeFill = True
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 40)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'BoundModeModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.splitContainerControl2)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "BoundModeModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rgrpGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl2.ResumeLayout(False)
            CType(Me.resourcesCheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.usageTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents rgrpGrouping As DevExpress.XtraEditors.RadioGroup
        Private lblGroup As DevExpress.XtraEditors.LabelControl
        Private lblView As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private splitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
		Private resourcesCheckedListBoxControl1 As DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl
		Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
		Private carSchedulingBindingSource As BindingSource
		Private carsDBDataSet As CarsDBDataSet
		Private carsBindingSource As BindingSource
        Private carSchedulingTableAdapter As CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
        Private carsTableAdapter As CarsDBDataSetTableAdapters.CarsTableAdapter
		Private usageTypeBindingSource As BindingSource
        Private usageTypeTableAdapter As CarsDBDataSetTableAdapters.UsageTypeTableAdapter
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
