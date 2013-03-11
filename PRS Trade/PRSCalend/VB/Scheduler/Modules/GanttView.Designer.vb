﻿Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class GanttViewModule
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
            Me.taskDependenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.tasksDataSet = New TasksDataSet1
            Me.tasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.resourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.grTasks = New DevExpress.XtraEditors.GroupControl
            Me.chkShowBar = New DevExpress.XtraEditors.CheckEdit
            Me.lblPercentCompleteType = New DevExpress.XtraEditors.LabelControl
            Me.chkShowNumber = New DevExpress.XtraEditors.CheckEdit
            Me.lblWeeksCount = New DevExpress.XtraEditors.LabelControl
            Me.spinResurcesPerPage = New DevExpress.XtraEditors.SpinEdit
            Me.chkShowResourceHeaders = New DevExpress.XtraEditors.CheckEdit
            Me.chkAutoHeightCells = New DevExpress.XtraEditors.CheckEdit
            Me.tasksTableAdapter = New TasksDataSet1TableAdapters.TasksTableAdapter
            Me.resourcesTableAdapter = New TasksDataSet1TableAdapters.ResourcesTableAdapter
            Me.taskDependenciesTableAdapter = New TasksDataSet1TableAdapters.TaskDependenciesTableAdapter
            Me.grResources = New DevExpress.XtraEditors.GroupControl
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.taskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tasksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.grTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grTasks.SuspendLayout()
            CType(Me.chkShowBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinResurcesPerPage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowResourceHeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAutoHeightCells.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grResources, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grResources.SuspendLayout()
            Me.SuspendLayout()
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 84)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.resourcesTree1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.schedulerControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(788, 306)
            Me.splitContainerControl1.SplitterPosition = 283
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'resourcesTree1
            '
            Me.resourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colDescription, Me.colDaysPlanned})
            Me.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resourcesTree1.Location = New System.Drawing.Point(0, 0)
            Me.resourcesTree1.Name = "resourcesTree1"
            Me.resourcesTree1.SchedulerControl = Me.schedulerControl1
            Me.resourcesTree1.Size = New System.Drawing.Size(283, 306)
            Me.resourcesTree1.TabIndex = 6
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 0
            Me.colDescription.Width = 185
            '
            'colDaysPlanned
            '
            Me.colDaysPlanned.Caption = "Days"
            Me.colDaysPlanned.FieldName = "DaysPlanned"
            Me.colDaysPlanned.Name = "colDaysPlanned"
            Me.colDaysPlanned.Visible = True
            Me.colDaysPlanned.VisibleIndex = 1
            Me.colDaysPlanned.Width = 96
            '
            'schedulerControl1
            '
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.MenuManager = Me
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(500, 306)
            Me.schedulerControl1.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            TimeRuler1.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.Russian
            TimeRuler1.UseClientTimeZone = False
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.Enabled = True
            Me.schedulerControl1.Views.GanttView.ResourcesPerPage = 9
            Me.schedulerControl1.Views.GanttView.ShowResourceHeaders = False
            Me.schedulerControl1.Views.MonthView.Enabled = False
            Me.schedulerControl1.Views.TimelineView.Enabled = False
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.Enabled = False
            TimeRuler2.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.Russian
            TimeRuler2.UseClientTimeZone = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'schedulerStorage1
            '
            Me.schedulerStorage1.AppointmentDependencies.DataSource = Me.taskDependenciesBindingSource
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
            Me.schedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete"
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
            'taskDependenciesBindingSource
            '
            Me.taskDependenciesBindingSource.DataMember = "TaskDependencies"
            Me.taskDependenciesBindingSource.DataSource = Me.tasksDataSet
            '
            'tasksDataSet
            '
            Me.tasksDataSet.DataSetName = "TasksDataSet"
            Me.tasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'tasksBindingSource
            '
            Me.tasksBindingSource.DataMember = "Tasks"
            Me.tasksBindingSource.DataSource = Me.tasksDataSet
            '
            'resourcesBindingSource
            '
            Me.resourcesBindingSource.DataMember = "Resources"
            Me.resourcesBindingSource.DataSource = Me.tasksDataSet
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 74)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(788, 10)
            Me.panelSeparatorControl.TabIndex = 9
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.grTasks)
            Me.panelControl.Controls.Add(Me.lblWeeksCount)
            Me.panelControl.Controls.Add(Me.spinResurcesPerPage)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(788, 74)
            Me.panelControl.TabIndex = 2
            '
            'grTasks
            '
            Me.grTasks.Controls.Add(Me.chkShowBar)
            Me.grTasks.Controls.Add(Me.lblPercentCompleteType)
            Me.grTasks.Controls.Add(Me.chkShowNumber)
            Me.grTasks.Location = New System.Drawing.Point(233, 11)
            Me.grTasks.Name = "grTasks"
            Me.grTasks.Size = New System.Drawing.Size(218, 54)
            Me.grTasks.TabIndex = 9
            Me.grTasks.Text = "Tasks"
            '
            'chkShowBar
            '
            Me.chkShowBar.Location = New System.Drawing.Point(106, 24)
            Me.chkShowBar.Name = "chkShowBar"
            Me.chkShowBar.Properties.AutoWidth = True
            Me.chkShowBar.Properties.Caption = "Bar"
            Me.chkShowBar.Size = New System.Drawing.Size(39, 19)
            Me.chkShowBar.TabIndex = 3
            '
            'lblPercentCompleteType
            '
            Me.lblPercentCompleteType.Location = New System.Drawing.Point(11, 27)
            Me.lblPercentCompleteType.Name = "lblPercentCompleteType"
            Me.lblPercentCompleteType.Size = New System.Drawing.Size(89, 13)
            Me.lblPercentCompleteType.TabIndex = 2
            Me.lblPercentCompleteType.Text = "Show Progress as:"
            '
            'chkShowNumber
            '
            Me.chkShowNumber.EditValue = True
            Me.chkShowNumber.Location = New System.Drawing.Point(152, 24)
            Me.chkShowNumber.Name = "chkShowNumber"
            Me.chkShowNumber.Properties.AutoWidth = True
            Me.chkShowNumber.Properties.Caption = "Number"
            Me.chkShowNumber.Size = New System.Drawing.Size(60, 19)
            Me.chkShowNumber.TabIndex = 4
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
            Me.spinResurcesPerPage.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinResurcesPerPage.Location = New System.Drawing.Point(650, 10)
            Me.spinResurcesPerPage.Name = "spinResurcesPerPage"
            Me.spinResurcesPerPage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinResurcesPerPage.Properties.IsFloatValue = False
            Me.spinResurcesPerPage.Properties.Mask.EditMask = "N00"
            Me.spinResurcesPerPage.Size = New System.Drawing.Size(112, 20)
            Me.spinResurcesPerPage.TabIndex = 5
            Me.spinResurcesPerPage.Visible = False
            '
            'chkShowResourceHeaders
            '
            Me.chkShowResourceHeaders.Location = New System.Drawing.Point(8, 24)
            Me.chkShowResourceHeaders.Name = "chkShowResourceHeaders"
            Me.chkShowResourceHeaders.Properties.AutoWidth = True
            Me.chkShowResourceHeaders.Properties.Caption = "Show Headers"
            Me.chkShowResourceHeaders.Size = New System.Drawing.Size(92, 19)
            Me.chkShowResourceHeaders.TabIndex = 0
            '
            'chkAutoHeightCells
            '
            Me.chkAutoHeightCells.EditValue = True
            Me.chkAutoHeightCells.Location = New System.Drawing.Point(113, 24)
            Me.chkAutoHeightCells.Name = "chkAutoHeightCells"
            Me.chkAutoHeightCells.Properties.AutoWidth = True
            Me.chkAutoHeightCells.Properties.Caption = "Autoheight"
            Me.chkAutoHeightCells.Size = New System.Drawing.Size(76, 19)
            Me.chkAutoHeightCells.TabIndex = 1
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
            'grResources
            '
            Me.grResources.Controls.Add(Me.chkShowResourceHeaders)
            Me.grResources.Controls.Add(Me.chkAutoHeightCells)
            Me.grResources.Location = New System.Drawing.Point(20, 11)
            Me.grResources.Name = "grResources"
            Me.grResources.Size = New System.Drawing.Size(198, 54)
            Me.grResources.TabIndex = 8
            Me.grResources.Text = "Resources"
            '
            'GanttViewModule
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Controls.Add(Me.grResources)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "GanttViewModule"
            Me.Size = New System.Drawing.Size(788, 390)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.taskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tasksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.grTasks, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grTasks.ResumeLayout(False)
            Me.grTasks.PerformLayout()
            CType(Me.chkShowBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinResurcesPerPage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowResourceHeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAutoHeightCells.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grResources, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grResources.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private resourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree
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
        Private WithEvents lblPercentCompleteType As DevExpress.XtraEditors.LabelControl
        Private WithEvents grResources As DevExpress.XtraEditors.GroupControl
        Private WithEvents grTasks As DevExpress.XtraEditors.GroupControl
        Private WithEvents chkShowBar As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chkShowNumber As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents colDaysPlanned As DevExpress.XtraScheduler.Native.ResourceTreeColumn
	End Class

End Namespace
