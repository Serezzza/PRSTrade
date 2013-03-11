Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class RestrictionsModule
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
            Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.chkAllowConflicts = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowInplaceEditor = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowResize = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowMultiSelect = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowEdit = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowDragBetweenResources = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowDrag = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowDelete = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowCopy = New DevExpress.XtraEditors.CheckEdit
            Me.chkAllowCreate = New DevExpress.XtraEditors.CheckEdit
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.chkAllowConflicts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowInplaceEditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowResize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowMultiSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowDragBetweenResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowDrag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowCopy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowCreate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 91)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 313)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbGrouping)
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.groupControl1)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 83)
            Me.panelControl.TabIndex = 16
            '
            'cbGrouping
            '
            Me.cbGrouping.EditValue = ""
            Me.cbGrouping.Location = New System.Drawing.Point(65, 50)
            Me.cbGrouping.Name = "cbGrouping"
            Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.SchedulerGroupType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.[Date], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
            Me.cbGrouping.Size = New System.Drawing.Size(118, 19)
            Me.cbGrouping.TabIndex = 20
            '
            'cbView
            '
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(65, 19)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(118, 19)
            Me.cbView.TabIndex = 19
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(11, 22)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 18
            Me.lblView.Text = "Show:"
            '
            'lblGroup
            '
            Me.lblGroup.Location = New System.Drawing.Point(11, 53)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 17
            Me.lblGroup.Text = "Group By:"
            '
            'groupControl1
            '
            Me.groupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupControl1.Controls.Add(Me.chkAllowConflicts)
            Me.groupControl1.Controls.Add(Me.chkAllowInplaceEditor)
            Me.groupControl1.Controls.Add(Me.chkAllowResize)
            Me.groupControl1.Controls.Add(Me.chkAllowMultiSelect)
            Me.groupControl1.Controls.Add(Me.chkAllowEdit)
            Me.groupControl1.Controls.Add(Me.chkAllowDragBetweenResources)
            Me.groupControl1.Controls.Add(Me.chkAllowDrag)
            Me.groupControl1.Controls.Add(Me.chkAllowDelete)
            Me.groupControl1.Controls.Add(Me.chkAllowCopy)
            Me.groupControl1.Controls.Add(Me.chkAllowCreate)
            Me.groupControl1.Location = New System.Drawing.Point(209, 5)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(490, 72)
            Me.groupControl1.TabIndex = 16
            Me.groupControl1.Text = "Allow appointment"
            '
            'chkAllowConflicts
            '
            Me.chkAllowConflicts.Location = New System.Drawing.Point(184, 24)
            Me.chkAllowConflicts.Name = "chkAllowConflicts"
            Me.chkAllowConflicts.Properties.Caption = "Conflicts"
            Me.chkAllowConflicts.Size = New System.Drawing.Size(68, 19)
            Me.chkAllowConflicts.TabIndex = 9
            '
            'chkAllowInplaceEditor
            '
            Me.chkAllowInplaceEditor.Location = New System.Drawing.Point(264, 48)
            Me.chkAllowInplaceEditor.Name = "chkAllowInplaceEditor"
            Me.chkAllowInplaceEditor.Properties.Caption = "Inplace Editor"
            Me.chkAllowInplaceEditor.Size = New System.Drawing.Size(88, 19)
            Me.chkAllowInplaceEditor.TabIndex = 8
            '
            'chkAllowResize
            '
            Me.chkAllowResize.Location = New System.Drawing.Point(128, 24)
            Me.chkAllowResize.Name = "chkAllowResize"
            Me.chkAllowResize.Properties.Caption = "Resize"
            Me.chkAllowResize.Size = New System.Drawing.Size(56, 19)
            Me.chkAllowResize.TabIndex = 7
            '
            'chkAllowMultiSelect
            '
            Me.chkAllowMultiSelect.Location = New System.Drawing.Point(184, 48)
            Me.chkAllowMultiSelect.Name = "chkAllowMultiSelect"
            Me.chkAllowMultiSelect.Properties.Caption = "Multi Select"
            Me.chkAllowMultiSelect.Size = New System.Drawing.Size(75, 19)
            Me.chkAllowMultiSelect.TabIndex = 6
            '
            'chkAllowEdit
            '
            Me.chkAllowEdit.Location = New System.Drawing.Point(72, 24)
            Me.chkAllowEdit.Name = "chkAllowEdit"
            Me.chkAllowEdit.Properties.Caption = "Edit"
            Me.chkAllowEdit.Size = New System.Drawing.Size(56, 19)
            Me.chkAllowEdit.TabIndex = 5
            '
            'chkAllowDragBetweenResources
            '
            Me.chkAllowDragBetweenResources.Location = New System.Drawing.Point(264, 24)
            Me.chkAllowDragBetweenResources.Name = "chkAllowDragBetweenResources"
            Me.chkAllowDragBetweenResources.Properties.Caption = "Drag Between Resources"
            Me.chkAllowDragBetweenResources.Size = New System.Drawing.Size(144, 19)
            Me.chkAllowDragBetweenResources.TabIndex = 4
            '
            'chkAllowDrag
            '
            Me.chkAllowDrag.Location = New System.Drawing.Point(128, 48)
            Me.chkAllowDrag.Name = "chkAllowDrag"
            Me.chkAllowDrag.Properties.Caption = "Drag"
            Me.chkAllowDrag.Size = New System.Drawing.Size(52, 19)
            Me.chkAllowDrag.TabIndex = 3
            '
            'chkAllowDelete
            '
            Me.chkAllowDelete.Location = New System.Drawing.Point(8, 48)
            Me.chkAllowDelete.Name = "chkAllowDelete"
            Me.chkAllowDelete.Properties.Caption = "Delete"
            Me.chkAllowDelete.Size = New System.Drawing.Size(56, 19)
            Me.chkAllowDelete.TabIndex = 2
            '
            'chkAllowCopy
            '
            Me.chkAllowCopy.Location = New System.Drawing.Point(72, 48)
            Me.chkAllowCopy.Name = "chkAllowCopy"
            Me.chkAllowCopy.Properties.Caption = "Copy"
            Me.chkAllowCopy.Size = New System.Drawing.Size(52, 19)
            Me.chkAllowCopy.TabIndex = 1
            '
            'chkAllowCreate
            '
            Me.chkAllowCreate.Location = New System.Drawing.Point(8, 24)
            Me.chkAllowCreate.Name = "chkAllowCreate"
            Me.chkAllowCreate.Properties.Caption = "Create"
            Me.chkAllowCreate.Size = New System.Drawing.Size(64, 19)
            Me.chkAllowCreate.TabIndex = 0
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 83)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 17
            '
            'RestrictionsModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "RestrictionsModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType(Me.chkAllowConflicts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowInplaceEditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowResize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowMultiSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowDragBetweenResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowDrag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowCopy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowCreate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbGrouping As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
        Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents chkAllowConflicts As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowInplaceEditor As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowResize As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowMultiSelect As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowEdit As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowDragBetweenResources As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowDrag As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowDelete As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowCopy As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkAllowCreate As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
