Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class AppointmentFormStylesModule
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
            Me.lblStyle = New DevExpress.XtraEditors.LabelControl
            Me.rgrpAptFormStyle = New DevExpress.XtraEditors.RadioGroup
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.rgrpGrouping = New DevExpress.XtraEditors.RadioGroup
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.rgrpAptFormStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.lblStyle)
            Me.panelControl.Controls.Add(Me.rgrpAptFormStyle)
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
            'lblStyle
            '
            Me.lblStyle.Location = New System.Drawing.Point(12, 14)
            Me.lblStyle.Name = "lblStyle"
            Me.lblStyle.Size = New System.Drawing.Size(28, 13)
            Me.lblStyle.TabIndex = 8
            Me.lblStyle.Text = "Style:"
            '
            'rgrpAptFormStyle
            '
            Me.rgrpAptFormStyle.Location = New System.Drawing.Point(46, 9)
            Me.rgrpAptFormStyle.Name = "rgrpAptFormStyle"
            Me.rgrpAptFormStyle.Properties.Columns = 2
            Me.rgrpAptFormStyle.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Outlook"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Ribbon")})
            Me.rgrpAptFormStyle.Size = New System.Drawing.Size(155, 22)
            Me.rgrpAptFormStyle.TabIndex = 7
            '
            'cbView
            '
            Me.cbView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(258, 11)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(120, 19)
            Me.cbView.TabIndex = 6
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(222, 14)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 5
            Me.lblView.Text = "Show:"
            '
            'lblGroup
            '
            Me.lblGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblGroup.Location = New System.Drawing.Point(392, 14)
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
            Me.rgrpGrouping.Size = New System.Drawing.Size(239, 22)
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
            'AppointmentFormStylesModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "AppointmentFormStylesModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.rgrpAptFormStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rgrpGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents rgrpGrouping As DevExpress.XtraEditors.RadioGroup
        Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
		Private WithEvents schedulerControl As SchedulerControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private rgrpAptFormStyle As DevExpress.XtraEditors.RadioGroup
        Private lblStyle As DevExpress.XtraEditors.LabelControl
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
