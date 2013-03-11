Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class HolidaysModule
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
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
            Me.clbLocations = New DevExpress.XtraEditors.CheckedListBoxControl
            Me.lbHolidays = New DevExpress.XtraEditors.ListBoxControl
            Me.pnlStatus = New DevExpress.XtraEditors.PanelControl
            Me.btnImportFromXml = New DevExpress.XtraEditors.SimpleButton
            Me.btnImportFromOutlook = New DevExpress.XtraEditors.SimpleButton
            Me.lblStatus = New DevExpress.XtraEditors.LabelControl
            Me.btnGenerate = New DevExpress.XtraEditors.SimpleButton
            Me.splitterControl2 = New DevExpress.XtraEditors.SplitterControl
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.clbLocations, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lbHolidays, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlStatus.SuspendLayout()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 159)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(519, 245)
            Me.schedulerControl.Start = New Date(2010, 7, 4, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 4
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 5
            Me.schedulerControl.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.WorkWeekView.ShowFullWeek = True
            Me.schedulerControl.Views.WorkWeekView.ShowWorkTimeOnly = True
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl.Controls.Add(Me.splitContainerControl1)
            Me.panelControl.Controls.Add(Me.pnlStatus)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 153)
            Me.panelControl.TabIndex = 0
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 36)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.clbLocations)
            Me.splitContainerControl1.Panel1.ShowCaption = True
            Me.splitContainerControl1.Panel1.Text = "Locations:"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.lbHolidays)
            Me.splitContainerControl1.Panel2.ShowCaption = True
            Me.splitContainerControl1.Panel2.Text = "Holidays:"
            Me.splitContainerControl1.Size = New System.Drawing.Size(704, 117)
            Me.splitContainerControl1.SplitterPosition = 256
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'clbLocations
            '
            Me.clbLocations.CheckOnClick = True
            Me.clbLocations.Dock = System.Windows.Forms.DockStyle.Fill
            Me.clbLocations.Location = New System.Drawing.Point(0, 0)
            Me.clbLocations.Name = "clbLocations"
            Me.clbLocations.Size = New System.Drawing.Size(252, 96)
            Me.clbLocations.TabIndex = 2
            '
            'lbHolidays
            '
            Me.lbHolidays.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbHolidays.Location = New System.Drawing.Point(0, 0)
            Me.lbHolidays.Name = "lbHolidays"
            Me.lbHolidays.Size = New System.Drawing.Size(438, 96)
            Me.lbHolidays.TabIndex = 3
            '
            'pnlStatus
            '
            Me.pnlStatus.Controls.Add(Me.btnImportFromXml)
            Me.pnlStatus.Controls.Add(Me.btnImportFromOutlook)
            Me.pnlStatus.Controls.Add(Me.lblStatus)
            Me.pnlStatus.Controls.Add(Me.btnGenerate)
            Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlStatus.Location = New System.Drawing.Point(0, 0)
            Me.pnlStatus.Name = "pnlStatus"
            Me.pnlStatus.Size = New System.Drawing.Size(704, 36)
            Me.pnlStatus.TabIndex = 0
            '
            'btnImportFromXml
            '
            Me.btnImportFromXml.Location = New System.Drawing.Point(5, 7)
            Me.btnImportFromXml.Name = "btnImportFromXml"
            Me.btnImportFromXml.Size = New System.Drawing.Size(107, 23)
            Me.btnImportFromXml.TabIndex = 0
            Me.btnImportFromXml.Text = "Import From Xml..."
            '
            'btnImportFromOutlook
            '
            Me.btnImportFromOutlook.Location = New System.Drawing.Point(118, 7)
            Me.btnImportFromOutlook.Name = "btnImportFromOutlook"
            Me.btnImportFromOutlook.Size = New System.Drawing.Size(141, 23)
            Me.btnImportFromOutlook.TabIndex = 1
            Me.btnImportFromOutlook.Text = "Import Outlook Holidays..."
            '
            'lblStatus
            '
            Me.lblStatus.Location = New System.Drawing.Point(280, 12)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(31, 13)
            Me.lblStatus.TabIndex = 34
            Me.lblStatus.Text = "Status"
            '
            'btnGenerate
            '
            Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGenerate.Location = New System.Drawing.Point(567, 7)
            Me.btnGenerate.Name = "btnGenerate"
            Me.btnGenerate.Size = New System.Drawing.Size(132, 23)
            Me.btnGenerate.TabIndex = 2
            Me.btnGenerate.Text = "Generate Appointments"
            '
            'splitterControl2
            '
            Me.splitterControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitterControl2.Location = New System.Drawing.Point(0, 153)
            Me.splitterControl2.Name = "splitterControl2"
            Me.splitterControl2.Size = New System.Drawing.Size(704, 6)
            Me.splitterControl2.TabIndex = 6
            Me.splitterControl2.TabStop = False
            '
            'dateNavigator1
            '
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
            Me.dateNavigator1.Location = New System.Drawing.Point(525, 159)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl
            Me.dateNavigator1.Size = New System.Drawing.Size(179, 245)
            Me.dateNavigator1.TabIndex = 5
            Me.dateNavigator1.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo
            '
            'splitterControl1
            '
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitterControl1.Location = New System.Drawing.Point(519, 159)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(6, 245)
            Me.splitterControl1.TabIndex = 7
            Me.splitterControl1.TabStop = False
            '
            'HolidaysModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.dateNavigator1)
            Me.Controls.Add(Me.splitterControl2)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "HolidaysModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.clbLocations, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lbHolidays, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlStatus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlStatus.ResumeLayout(False)
            Me.pnlStatus.PerformLayout()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private panelControl As DevExpress.XtraEditors.PanelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
        Private splitterControl2 As DevExpress.XtraEditors.SplitterControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents clbLocations As DevExpress.XtraEditors.CheckedListBoxControl
		Private WithEvents lbHolidays As DevExpress.XtraEditors.ListBoxControl
		Private pnlStatus As DevExpress.XtraEditors.PanelControl
        Private lblStatus As DevExpress.XtraEditors.LabelControl
		Private WithEvents btnGenerate As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportFromOutlook As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnImportFromXml As DevExpress.XtraEditors.SimpleButton
        Private dateNavigator1 As DateNavigator
        Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl

	End Class
End Namespace
