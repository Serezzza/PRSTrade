Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class TimeZonesModule
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
            Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim TimeRuler4 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim TimeRuler5 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim TimeRuler6 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.lblTimeZone = New DevExpress.XtraEditors.LabelControl
            Me.edtTimeZone = New DevExpress.XtraScheduler.UI.TimeZoneEdit
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtTimeZone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 48)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 356)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 2
            TimeRuler1.Caption = "GMT"
            TimeRuler1.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.Greenwich
            TimeRuler1.UseClientTimeZone = False
            TimeRuler2.Caption = "Local"
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler3)
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 2
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            TimeRuler4.Caption = "GMT"
            TimeRuler4.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.Greenwich
            TimeRuler4.UseClientTimeZone = False
            TimeRuler5.Caption = "Local"
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler4)
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler5)
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler6)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Controls.Add(Me.cbGrouping)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.lblTimeZone)
            Me.panelControl.Controls.Add(Me.edtTimeZone)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 40)
            Me.panelControl.TabIndex = 2
            '
            'cbView
            '
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(408, 10)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(112, 19)
            Me.cbView.TabIndex = 41
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(372, 13)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 40
            Me.lblView.Text = "Show:"
            '
            'cbGrouping
            '
            Me.cbGrouping.EditValue = ""
            Me.cbGrouping.Location = New System.Drawing.Point(589, 10)
            Me.cbGrouping.Name = "cbGrouping"
            Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.SchedulerGroupType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.[Date], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
            Me.cbGrouping.Size = New System.Drawing.Size(110, 19)
            Me.cbGrouping.TabIndex = 39
            '
            'lblGroup
            '
            Me.lblGroup.Location = New System.Drawing.Point(535, 13)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 38
            Me.lblGroup.Text = "Group By:"
            '
            'lblTimeZone
            '
            Me.lblTimeZone.Location = New System.Drawing.Point(12, 13)
            Me.lblTimeZone.Name = "lblTimeZone"
            Me.lblTimeZone.Size = New System.Drawing.Size(53, 13)
            Me.lblTimeZone.TabIndex = 2
            Me.lblTimeZone.Text = "Time Zone:"
            '
            'edtTimeZone
            '
            Me.edtTimeZone.Location = New System.Drawing.Point(71, 10)
            Me.edtTimeZone.Name = "edtTimeZone"
            Me.edtTimeZone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edtTimeZone.Size = New System.Drawing.Size(274, 19)
            Me.edtTimeZone.TabIndex = 1
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
            'TimeZonesModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "TimeZonesModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtTimeZone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents edtTimeZone As DevExpress.XtraScheduler.UI.TimeZoneEdit
        Private lblTimeZone As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbGrouping As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblGroup As DevExpress.XtraEditors.LabelControl
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
