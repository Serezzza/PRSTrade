Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class DragDropDataModule
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
            Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl
            Me.grdTasks = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repSpinDuration = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repImgPriority = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.colSeverity = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repImgSeverity = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grdTasks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repSpinDuration, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repImgPriority, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repImgSeverity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 48)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Forbidden
            Me.schedulerControl.Size = New System.Drawing.Size(704, 232)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.DayView.VisibleTime.End = System.TimeSpan.Parse("19:00:00")
            Me.schedulerControl.Views.DayView.VisibleTime.Start = System.TimeSpan.Parse("08:00:00")
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            TimeScaleYear1.Enabled = False
            TimeScaleQuarter1.Enabled = False
            TimeScaleMonth1.Enabled = False
            TimeScaleWeek1.Enabled = False
            TimeScaleWeek1.Width = 80
            TimeScaleDay1.Width = 80
            TimeScaleHour1.Width = 80
            TimeScaleFixedInterval1.Enabled = False
            TimeScaleFixedInterval1.Width = 80
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleYear1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleQuarter1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleMonth1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleWeek1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleDay1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleHour1)
            Me.schedulerControl.Views.TimelineView.Scales.Add(TimeScaleFixedInterval1)
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.WorkWeekView.VisibleTime.End = System.TimeSpan.Parse("18:00:00")
            Me.schedulerControl.Views.WorkWeekView.VisibleTime.Start = System.TimeSpan.Parse("08:00:00")
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'schedulerStorage
            '
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)), "Minor", "M&inor"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer)), "Moderate", "&Moderate"))
            Me.schedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer)), "Severe", "&Severe"))
            Me.schedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Free, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)), "Low", "&Low"))
            Me.schedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Tentative, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer)), "Normal", "&Normal"))
            Me.schedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.OutOfOffice, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer)), "High", "&High"))
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbGrouping)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 40)
            Me.panelControl.TabIndex = 2
            '
            'cbGrouping
            '
            Me.cbGrouping.EditValue = ""
            Me.cbGrouping.Location = New System.Drawing.Point(241, 10)
            Me.cbGrouping.Name = "cbGrouping"
            Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.[Date], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
            Me.cbGrouping.Size = New System.Drawing.Size(112, 19)
            Me.cbGrouping.TabIndex = 35
            '
            'lblGroup
            '
            Me.lblGroup.Location = New System.Drawing.Point(187, 13)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 34
            Me.lblGroup.Text = "Group By:"
            '
            'cbView
            '
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(49, 10)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(118, 19)
            Me.cbView.TabIndex = 30
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(13, 13)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 29
            Me.lblView.Text = "Show:"
            '
            'splitterControl1
            '
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.splitterControl1.Location = New System.Drawing.Point(0, 280)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(704, 6)
            Me.splitterControl1.TabIndex = 6
            Me.splitterControl1.TabStop = False
            '
            'grdTasks
            '
            Me.grdTasks.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.grdTasks.EmbeddedNavigator.Name = ""
            Me.grdTasks.Location = New System.Drawing.Point(0, 286)
            Me.grdTasks.MainView = Me.gridView1
            Me.grdTasks.Name = "grdTasks"
            Me.grdTasks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repSpinDuration, Me.repImgPriority, Me.repImgSeverity})
            Me.grdTasks.Size = New System.Drawing.Size(704, 118)
            Me.grdTasks.TabIndex = 8
            Me.grdTasks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSubject, Me.colDuration, Me.colPriority, Me.colSeverity, Me.colDescription})
            Me.gridView1.GridControl = Me.grdTasks
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
            Me.gridView1.OptionsView.ShowGroupPanel = False
            '
            'colSubject
            '
            Me.colSubject.Caption = "Subject"
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 0
            Me.colSubject.Width = 160
            '
            'colDuration
            '
            Me.colDuration.Caption = "Duration (h)"
            Me.colDuration.ColumnEdit = Me.repSpinDuration
            Me.colDuration.FieldName = "Duration"
            Me.colDuration.Name = "colDuration"
            Me.colDuration.Visible = True
            Me.colDuration.VisibleIndex = 1
            '
            'repSpinDuration
            '
            Me.repSpinDuration.AutoHeight = False
            Me.repSpinDuration.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repSpinDuration.IsFloatValue = False
            Me.repSpinDuration.Mask.EditMask = "N00"
            Me.repSpinDuration.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.repSpinDuration.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.repSpinDuration.Name = "repSpinDuration"
            '
            'colPriority
            '
            Me.colPriority.Caption = "Priority"
            Me.colPriority.ColumnEdit = Me.repImgPriority
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.Name = "colPriority"
            Me.colPriority.Visible = True
            Me.colPriority.VisibleIndex = 2
            Me.colPriority.Width = 60
            '
            'repImgPriority
            '
            Me.repImgPriority.AutoHeight = False
            Me.repImgPriority.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repImgPriority.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, -1)})
            Me.repImgPriority.Name = "repImgPriority"
            '
            'colSeverity
            '
            Me.colSeverity.Caption = "Severity"
            Me.colSeverity.ColumnEdit = Me.repImgSeverity
            Me.colSeverity.FieldName = "Severity"
            Me.colSeverity.Name = "colSeverity"
            Me.colSeverity.Visible = True
            Me.colSeverity.VisibleIndex = 3
            Me.colSeverity.Width = 60
            '
            'repImgSeverity
            '
            Me.repImgSeverity.AutoHeight = False
            Me.repImgSeverity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repImgSeverity.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Minor", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Moderate", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Severe", 2, -1)})
            Me.repImgSeverity.Name = "repImgSeverity"
            '
            'colDescription
            '
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 4
            Me.colDescription.Width = 300
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
            'DragDropDataModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.grdTasks)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "DragDropDataModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grdTasks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repSpinDuration, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repImgPriority, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repImgSeverity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private panelControl As DevExpress.XtraEditors.PanelControl
        Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
        Private WithEvents cbGrouping As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblGroup As DevExpress.XtraEditors.LabelControl
        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
        Private grdTasks As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private components As System.ComponentModel.IContainer = Nothing
        Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPriority As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSeverity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents repSpinDuration As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Friend WithEvents repImgPriority As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Friend WithEvents repImgSeverity As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
