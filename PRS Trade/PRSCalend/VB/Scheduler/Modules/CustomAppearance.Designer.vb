Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class AppearanceModule
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
            Me.btnEdit = New DevExpress.XtraEditors.SimpleButton
            Me.rgrpEdit = New DevExpress.XtraEditors.RadioGroup
            Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.rgrpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 74)
            Me.schedulerControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            Me.schedulerControl.LookAndFeel.UseDefaultLookAndFeel = False
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 330)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.btnEdit)
            Me.panelControl.Controls.Add(Me.rgrpEdit)
            Me.panelControl.Controls.Add(Me.cbGrouping)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 66)
            Me.panelControl.TabIndex = 26
            '
            'btnEdit
            '
            Me.btnEdit.ImageIndex = 2
            Me.btnEdit.Location = New System.Drawing.Point(499, 4)
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(73, 24)
            Me.btnEdit.TabIndex = 84
            Me.btnEdit.Text = "&Edit..."
            '
            'rgrpEdit
            '
            Me.rgrpEdit.EditValue = 0
            Me.rgrpEdit.Location = New System.Drawing.Point(192, 4)
            Me.rgrpEdit.Name = "rgrpEdit"
            Me.rgrpEdit.Properties.Columns = 2
            Me.rgrpEdit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Scheduler Appearances"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "View Appearances"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Resource Color Schemas")})
            Me.rgrpEdit.Size = New System.Drawing.Size(301, 57)
            Me.rgrpEdit.TabIndex = 83
            '
            'cbGrouping
            '
            Me.cbGrouping.EditValue = ""
            Me.cbGrouping.Location = New System.Drawing.Point(66, 41)
            Me.cbGrouping.Name = "cbGrouping"
            Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.SchedulerGroupType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.[Date], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
            Me.cbGrouping.Size = New System.Drawing.Size(112, 19)
            Me.cbGrouping.TabIndex = 33
            '
            'lblGroup
            '
            Me.lblGroup.Location = New System.Drawing.Point(12, 44)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 30
            Me.lblGroup.Text = "Group By:"
            '
            'cbView
            '
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(66, 10)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(112, 19)
            Me.cbView.TabIndex = 29
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(12, 13)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 28
            Me.lblView.Text = "Show:"
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 66)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 27
            '
            'AppearanceModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "AppearanceModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.rgrpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private rgrpEdit As DevExpress.XtraEditors.RadioGroup
		Private WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
