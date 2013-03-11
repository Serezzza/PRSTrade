Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class XPOBoundModeModule
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
            Me.xpCollectionTasks = New DevExpress.Xpo.XPCollection
            Me.session1 = New DevExpress.Xpo.Session
            Me.xpCollectionEmployees = New DevExpress.Xpo.XPCollection
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.rgrpGrouping = New DevExpress.XtraEditors.RadioGroup
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCollectionTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCollectionEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rgrpGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 48)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 356)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 2
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'schedulerStorage
            '
            Me.schedulerStorage.Appointments.DataSource = Me.xpCollectionTasks
            Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage.Appointments.Mappings.End = "Finish"
            Me.schedulerStorage.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "Recurrence"
            Me.schedulerStorage.Appointments.Mappings.ReminderInfo = "Reminder"
            Me.schedulerStorage.Appointments.Mappings.ResourceId = "Employee!Key"
            Me.schedulerStorage.Appointments.Mappings.Start = "Created"
            Me.schedulerStorage.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage.Appointments.Mappings.Type = "AppointmentType"
            Me.schedulerStorage.Resources.DataSource = Me.xpCollectionEmployees
            Me.schedulerStorage.Resources.Mappings.Caption = "Name"
            Me.schedulerStorage.Resources.Mappings.Id = "Oid"
            '
            'xpCollectionTasks
            '
            Me.xpCollectionTasks.DeleteObjectOnRemove = True
            Me.xpCollectionTasks.DisplayableProperties = "This;Oid;AllDay;Description;Finish;Label;Location;Recurrence;Reminder;Created;Sta" & _
                "tus;Subject;AppointmentType;Employee!;Employee!Key;Employee"
            Me.xpCollectionTasks.ObjectType = GetType(DevExpress.XtraScheduler.Demos.Task)
            Me.xpCollectionTasks.Session = Me.session1
            '
            'session1
            '
            Me.session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;data source=XPOBoundMode.md" & _
                "b;user id=Admin;password=;"
            '
            'xpCollectionEmployees
            '
            Me.xpCollectionEmployees.DeleteObjectOnRemove = True
            Me.xpCollectionEmployees.DisplayableProperties = "This;Oid;Name"
            Me.xpCollectionEmployees.ObjectType = GetType(DevExpress.XtraScheduler.Demos.Employee)
            Me.xpCollectionEmployees.Session = Me.session1
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.rgrpGrouping)
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
            Me.cbView.TabIndex = 6
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(14, 15)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 5
            Me.lblView.Text = "Show:"
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
            Me.rgrpGrouping.Location = New System.Drawing.Point(446, 9)
            Me.rgrpGrouping.Name = "rgrpGrouping"
            Me.rgrpGrouping.Properties.Columns = 3
            Me.rgrpGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.None, "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.[Date], "Date"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.Resource, "Resource")})
            Me.rgrpGrouping.Size = New System.Drawing.Size(253, 24)
            Me.rgrpGrouping.TabIndex = 2
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
            'XPOBoundModeModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "XPOBoundModeModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCollectionTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCollectionEmployees, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rgrpGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private xpCollectionTasks As DevExpress.Xpo.XPCollection
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents rgrpGrouping As DevExpress.XtraEditors.RadioGroup
        Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
		Private WithEvents schedulerControl As SchedulerControl
		Private xpCollectionEmployees As XPCollection
		Private session1 As Session
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
