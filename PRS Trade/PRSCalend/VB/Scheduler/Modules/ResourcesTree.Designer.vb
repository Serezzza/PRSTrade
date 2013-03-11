Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class ResourcesTreeModule
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
            Me.resourcesTree1 = New DevExpress.XtraScheduler.UI.ResourcesTree
            Me.colDescription = New DevExpress.XtraScheduler.Native.ResourceTreeColumn
            Me.colDaysPlanned = New DevExpress.XtraScheduler.Native.ResourceTreeColumn
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.tasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.tasksDataSet = New TasksDataSet1
            Me.resourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.taskDependenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.chkFilterPanel = New DevExpress.XtraEditors.CheckEdit
            Me.chkAutoFilterRow = New DevExpress.XtraEditors.CheckEdit
            Me.chkShowResourceHeaders = New DevExpress.XtraEditors.CheckEdit
            Me.chkAutoHeightCells = New DevExpress.XtraEditors.CheckEdit
            Me.lblWeeksCount = New DevExpress.XtraEditors.LabelControl
            Me.spinResurcesPerPage = New DevExpress.XtraEditors.SpinEdit
            Me.tasksTableAdapter = New TasksDataSet1TableAdapters.TasksTableAdapter
            Me.resourcesTableAdapter = New TasksDataSet1TableAdapters.ResourcesTableAdapter
            Me.taskDependenciesTableAdapter = New TasksDataSet1TableAdapters.TaskDependenciesTableAdapter
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tasksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.taskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.chkFilterPanel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowResourceHeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAutoHeightCells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinResurcesPerPage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 83)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.resourcesTree1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.schedulerControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(788, 307)
            Me.splitContainerControl1.SplitterPosition = 180
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'resourcesTree1
            '
            Me.resourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colDescription, Me.colDaysPlanned})
            Me.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resourcesTree1.Location = New System.Drawing.Point(0, 0)
            Me.resourcesTree1.Name = "resourcesTree1"
            Me.resourcesTree1.OptionsBehavior.EnableFiltering = True
            Me.resourcesTree1.OptionsPrint.UsePrintStyles = True
            Me.resourcesTree1.OptionsView.ShowAutoFilterRow = True
            Me.resourcesTree1.SchedulerControl = Me.schedulerControl1
            Me.resourcesTree1.Size = New System.Drawing.Size(180, 307)
            Me.resourcesTree1.TabIndex = 6
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 0
            Me.colDescription.Width = 140
            '
            'colDaysPlanned
            '
            Me.colDaysPlanned.Caption = "Days"
            Me.colDaysPlanned.FieldName = "DaysPlanned"
            Me.colDaysPlanned.Name = "colDaysPlanned"
            Me.colDaysPlanned.Visible = True
            Me.colDaysPlanned.VisibleIndex = 1
            Me.colDaysPlanned.Width = 38
            '
            'schedulerControl1
            '
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.MenuManager = Me
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(603, 307)
            Me.schedulerControl1.Start = New Date(2011, 10, 5, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            TimeRuler1.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.Russian
            TimeRuler1.UseClientTimeZone = False
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.Enabled = True
            Me.schedulerControl1.Views.GanttView.ResourcesPerPage = 9
            Me.schedulerControl1.Views.GanttView.ShowResourceHeaders = False
            Me.schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.Enabled = True
            Me.schedulerControl1.Views.TimelineView.ResourcesPerPage = 9
            Me.schedulerControl1.Views.TimelineView.ShowResourceHeaders = False
            TimeRuler2.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.Russian
            TimeRuler2.UseClientTimeZone = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'schedulerStorage1
            '
            Me.schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "Dependent"
            Me.schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "Parent"
            Me.schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type"
            Me.schedulerStorage1.Appointments.CommitIdToDataSource = False
            Me.schedulerStorage1.Appointments.DataSource = Me.tasksBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.AppointmentId = "Id"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
            Me.schedulerStorage1.Resources.CustomFieldMappings.Add(New DevExpress.XtraScheduler.ResourceCustomFieldMapping("DaysPlanned", "DaysPlanned"))
            Me.schedulerStorage1.Resources.DataSource = Me.resourcesBindingSource
            Me.schedulerStorage1.Resources.Mappings.Caption = "Description"
            Me.schedulerStorage1.Resources.Mappings.Id = "Id"
            Me.schedulerStorage1.Resources.Mappings.ParentId = "ParentId"
            '
            'tasksBindingSource
            '
            Me.tasksBindingSource.DataMember = "Tasks"
            Me.tasksBindingSource.DataSource = Me.tasksDataSet
            '
            'tasksDataSet
            '
            Me.tasksDataSet.DataSetName = "TasksDataSet"
            Me.tasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'resourcesBindingSource
            '
            Me.resourcesBindingSource.DataMember = "Resources"
            Me.resourcesBindingSource.DataSource = Me.tasksDataSet
            '
            'taskDependenciesBindingSource
            '
            Me.taskDependenciesBindingSource.DataMember = "TaskDependencies"
            Me.taskDependenciesBindingSource.DataSource = Me.tasksDataSet
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 73)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(788, 10)
            Me.panelSeparatorControl.TabIndex = 9
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.chkFilterPanel)
            Me.panelControl.Controls.Add(Me.chkAutoFilterRow)
            Me.panelControl.Controls.Add(Me.chkShowResourceHeaders)
            Me.panelControl.Controls.Add(Me.chkAutoHeightCells)
            Me.panelControl.Controls.Add(Me.lblWeeksCount)
            Me.panelControl.Controls.Add(Me.spinResurcesPerPage)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(788, 73)
            Me.panelControl.TabIndex = 2
            '
            'chkFilterPanel
            '
            Me.chkFilterPanel.EditValue = True
            Me.chkFilterPanel.Location = New System.Drawing.Point(183, 36)
            Me.chkFilterPanel.Name = "chkFilterPanel"
            Me.chkFilterPanel.Properties.Caption = "Show Filter Panel"
            Me.chkFilterPanel.Size = New System.Drawing.Size(132, 19)
            Me.chkFilterPanel.TabIndex = 7
            '
            'chkAutoFilterRow
            '
            Me.chkAutoFilterRow.EditValue = True
            Me.chkAutoFilterRow.Location = New System.Drawing.Point(183, 11)
            Me.chkAutoFilterRow.Name = "chkAutoFilterRow"
            Me.chkAutoFilterRow.Properties.Caption = "Show AutoFilter Row"
            Me.chkAutoFilterRow.Size = New System.Drawing.Size(144, 19)
            Me.chkAutoFilterRow.TabIndex = 6
            '
            'chkShowResourceHeaders
            '
            Me.chkShowResourceHeaders.Location = New System.Drawing.Point(16, 10)
            Me.chkShowResourceHeaders.Name = "chkShowResourceHeaders"
            Me.chkShowResourceHeaders.Properties.Caption = "Show Resource Headers"
            Me.chkShowResourceHeaders.Size = New System.Drawing.Size(144, 19)
            Me.chkShowResourceHeaders.TabIndex = 3
            '
            'chkAutoHeightCells
            '
            Me.chkAutoHeightCells.EditValue = True
            Me.chkAutoHeightCells.Location = New System.Drawing.Point(16, 35)
            Me.chkAutoHeightCells.Name = "chkAutoHeightCells"
            Me.chkAutoHeightCells.Properties.Caption = "Autoheight Resources"
            Me.chkAutoHeightCells.Size = New System.Drawing.Size(132, 19)
            Me.chkAutoHeightCells.TabIndex = 2
            '
            'lblWeeksCount
            '
            Me.lblWeeksCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblWeeksCount.Location = New System.Drawing.Point(550, 13)
            Me.lblWeeksCount.Name = "lblWeeksCount"
            Me.lblWeeksCount.Size = New System.Drawing.Size(94, 13)
            Me.lblWeeksCount.TabIndex = 4
            Me.lblWeeksCount.Text = "Resurces Per Page:"
            Me.lblWeeksCount.Visible = False
            '
            'spinResurcesPerPage
            '
            Me.spinResurcesPerPage.EditValue = New Decimal(New Integer() {9, 0, 0, 0})
            Me.spinResurcesPerPage.Location = New System.Drawing.Point(650, 10)
            Me.spinResurcesPerPage.Name = "spinResurcesPerPage"
            Me.spinResurcesPerPage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinResurcesPerPage.Properties.IsFloatValue = False
            Me.spinResurcesPerPage.Properties.Mask.EditMask = "N00"
            Me.spinResurcesPerPage.Properties.MaxValue = New Decimal(New Integer() {11, 0, 0, 0})
            Me.spinResurcesPerPage.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinResurcesPerPage.Size = New System.Drawing.Size(112, 20)
            Me.spinResurcesPerPage.TabIndex = 5
            '
            'tasksTableAdapter
            '
            Me.tasksTableAdapter.ClearBeforeFill = True
            '
            'resourcesTableAdapter
            '
            Me.resourcesTableAdapter.ClearBeforeFill = True
            '
            'taskDependenciesTableAdapter
            '
            Me.taskDependenciesTableAdapter.ClearBeforeFill = True
            '
            'ResourcesTreeModule
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "ResourcesTreeModule"
            Me.Size = New System.Drawing.Size(788, 390)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tasksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.taskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.chkFilterPanel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowResourceHeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAutoHeightCells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinResurcesPerPage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents resourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree
        Private WithEvents schedulerControl1 As SchedulerControl
        Private WithEvents schedulerStorage1 As SchedulerStorage
        Private taskDependenciesBindingSource As System.Windows.Forms.BindingSource
        Private tasksDataSet As TasksDataSet1
        Private tasksBindingSource As System.Windows.Forms.BindingSource
        Private resourcesBindingSource As System.Windows.Forms.BindingSource
        Private tasksTableAdapter As TasksDataSet1TableAdapters.TasksTableAdapter
        Private resourcesTableAdapter As TasksDataSet1TableAdapters.ResourcesTableAdapter
        Private taskDependenciesTableAdapter As TasksDataSet1TableAdapters.TaskDependenciesTableAdapter
        Private panelControl As DevExpress.XtraEditors.PanelControl
        Private panelSeparatorControl As DevExpress.XtraEditors.PanelControl
        Private WithEvents chkShowResourceHeaders As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkAutoHeightCells As DevExpress.XtraEditors.CheckEdit
        Private lblWeeksCount As DevExpress.XtraEditors.LabelControl
        Private WithEvents spinResurcesPerPage As DevExpress.XtraEditors.SpinEdit
        Private colDescription As Native.ResourceTreeColumn
        Private colDaysPlanned As DevExpress.XtraScheduler.Native.ResourceTreeColumn
        Private WithEvents chkFilterPanel As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkAutoFilterRow As DevExpress.XtraEditors.CheckEdit
	End Class

End Namespace
