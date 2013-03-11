Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class DateNavigatorModule
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
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.cbWeekNumberRule = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblWeeksCount = New DevExpress.XtraEditors.LabelControl
            Me.chkShowWeekNumbers = New DevExpress.XtraEditors.CheckEdit
            Me.chkBoldAppointmentDates = New DevExpress.XtraEditors.CheckEdit
            Me.chkShowTodayButton = New DevExpress.XtraEditors.CheckEdit
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbWeekNumberRule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowWeekNumbers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkBoldAppointmentDates.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkShowTodayButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbWeekNumberRule)
            Me.panelControl.Controls.Add(Me.lblWeeksCount)
            Me.panelControl.Controls.Add(Me.chkShowWeekNumbers)
            Me.panelControl.Controls.Add(Me.chkBoldAppointmentDates)
            Me.panelControl.Controls.Add(Me.chkShowTodayButton)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 40)
            Me.panelControl.TabIndex = 1
            '
            'cbWeekNumberRule
            '
            Me.cbWeekNumberRule.EditValue = ""
            Me.cbWeekNumberRule.Location = New System.Drawing.Point(560, 11)
            Me.cbWeekNumberRule.Name = "cbWeekNumberRule"
            Me.cbWeekNumberRule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbWeekNumberRule.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Default", DevExpress.XtraEditors.Controls.WeekNumberRule.[Default], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("FirstDay", DevExpress.XtraEditors.Controls.WeekNumberRule.FirstDay, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("FirstFullWeek", DevExpress.XtraEditors.Controls.WeekNumberRule.FirstFullWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("FirstFourDayWeek", DevExpress.XtraEditors.Controls.WeekNumberRule.FirstFourDayWeek, -1)})
            Me.cbWeekNumberRule.Size = New System.Drawing.Size(112, 20)
            Me.cbWeekNumberRule.TabIndex = 34
            '
            'lblWeeksCount
            '
            Me.lblWeeksCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblWeeksCount.Location = New System.Drawing.Point(459, 14)
            Me.lblWeeksCount.Name = "lblWeeksCount"
            Me.lblWeeksCount.Size = New System.Drawing.Size(95, 13)
            Me.lblWeeksCount.TabIndex = 32
            Me.lblWeeksCount.Text = "Week Number Rule:"
            '
            'chkShowWeekNumbers
            '
            Me.chkShowWeekNumbers.EditValue = True
            Me.chkShowWeekNumbers.Location = New System.Drawing.Point(303, 11)
            Me.chkShowWeekNumbers.Name = "chkShowWeekNumbers"
            Me.chkShowWeekNumbers.Properties.Caption = "Show Week Numbers"
            Me.chkShowWeekNumbers.Size = New System.Drawing.Size(129, 19)
            Me.chkShowWeekNumbers.TabIndex = 1
            '
            'chkBoldAppointmentDates
            '
            Me.chkBoldAppointmentDates.EditValue = True
            Me.chkBoldAppointmentDates.Location = New System.Drawing.Point(16, 11)
            Me.chkBoldAppointmentDates.Name = "chkBoldAppointmentDates"
            Me.chkBoldAppointmentDates.Properties.Caption = "Bold Appointment Dates"
            Me.chkBoldAppointmentDates.Size = New System.Drawing.Size(144, 19)
            Me.chkBoldAppointmentDates.TabIndex = 0
            '
            'chkShowTodayButton
            '
            Me.chkShowTodayButton.EditValue = True
            Me.chkShowTodayButton.Location = New System.Drawing.Point(170, 11)
            Me.chkShowTodayButton.Name = "chkShowTodayButton"
            Me.chkShowTodayButton.Properties.Caption = "Show Today Button"
            Me.chkShowTodayButton.Size = New System.Drawing.Size(118, 19)
            Me.chkShowTodayButton.TabIndex = 0
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 48)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.schedulerControl)
            Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.dateNavigator1)
            Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(704, 356)
            Me.splitContainerControl1.SplitterPosition = 191
            Me.splitContainerControl1.TabIndex = 4
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(508, 356)
            Me.schedulerControl.Start = New Date(2010, 7, 4, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 1
            Me.schedulerControl.Text = "schedulerControl"
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'dateNavigator1
            '
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateNavigator1.HotDate = Nothing
            Me.dateNavigator1.Location = New System.Drawing.Point(0, 0)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl
            Me.dateNavigator1.Size = New System.Drawing.Size(191, 356)
            Me.dateNavigator1.TabIndex = 4
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
            'DateNavigatorModule
            '
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "DateNavigatorModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbWeekNumberRule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowWeekNumbers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkBoldAppointmentDates.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkShowTodayButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents chkBoldAppointmentDates As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkShowTodayButton As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkShowWeekNumbers As DevExpress.XtraEditors.CheckEdit
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private lblWeeksCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbWeekNumberRule As DevExpress.XtraEditors.ImageComboBoxEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
