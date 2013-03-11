Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class OutlookImportModule
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
            Me.session1 = New DevExpress.Xpo.Session
            Me.xpCollectionEvents = New DevExpress.Xpo.XPCollection
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.lbCalendarNames = New DevExpress.XtraEditors.LabelControl
            Me.cbCalendarFolderPaths = New DevExpress.XtraEditors.ComboBoxEdit
            Me.cbCancelingTypes = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lbApplyTypes = New DevExpress.XtraEditors.LabelControl
            Me.btnImport = New DevExpress.XtraEditors.SimpleButton
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.calendarTabPage = New DevExpress.XtraTab.XtraTabPage
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.logTabPage = New DevExpress.XtraTab.XtraTabPage
            Me.lbcLog = New DevExpress.XtraEditors.ListBoxControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.lblLogInfo = New DevExpress.XtraEditors.LabelControl
            Me.btnClearLog = New DevExpress.XtraEditors.SimpleButton
            Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpCollectionEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbCalendarFolderPaths.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbCancelingTypes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.calendarTabPage.SuspendLayout()
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.logTabPage.SuspendLayout()
            CType(Me.lbcLog, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'session1
            '
            Me.session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Mode=Share Deny None;data source=OutlookSync.mdb" & _
                ";user id=Admin;XPOProvider=MSAccessSafe;"
            '
            'xpCollectionEvents
            '
            Me.xpCollectionEvents.DeleteObjectOnRemove = True
            Me.xpCollectionEvents.DisplayableProperties = "This;Oid;Start;End;Subject;Body;AllDayEvent;BusyStatus;Location;RecurrencePattern" & _
                ";ReminderSet;AppointmentType;Label;EntryID"
            Me.xpCollectionEvents.ObjectType = GetType(DevExpress.XtraScheduler.Demos.OlAppointment)
            Me.xpCollectionEvents.Session = Me.session1
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.lbCalendarNames)
            Me.panelControl.Controls.Add(Me.cbCalendarFolderPaths)
            Me.panelControl.Controls.Add(Me.cbCancelingTypes)
            Me.panelControl.Controls.Add(Me.lbApplyTypes)
            Me.panelControl.Controls.Add(Me.btnImport)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 60)
            Me.panelControl.TabIndex = 3
            '
            'lbCalendarNames
            '
            Me.lbCalendarNames.Location = New System.Drawing.Point(10, 11)
            Me.lbCalendarNames.Name = "lbCalendarNames"
            Me.lbCalendarNames.Size = New System.Drawing.Size(86, 13)
            Me.lbCalendarNames.TabIndex = 99
            Me.lbCalendarNames.Text = "Choose Calendar:"
            '
            'cbCalendarFolderPaths
            '
            Me.cbCalendarFolderPaths.Location = New System.Drawing.Point(102, 8)
            Me.cbCalendarFolderPaths.Name = "cbCalendarFolderPaths"
            Me.cbCalendarFolderPaths.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbCalendarFolderPaths.Size = New System.Drawing.Size(322, 19)
            Me.cbCalendarFolderPaths.TabIndex = 98
            '
            'cbCancelingTypes
            '
            Me.cbCancelingTypes.EditValue = ""
            Me.cbCancelingTypes.Location = New System.Drawing.Point(274, 33)
            Me.cbCancelingTypes.Name = "cbCancelingTypes"
            Me.cbCancelingTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbCancelingTypes.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.UsedAppointmentType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Recurring", DevExpress.XtraScheduler.UsedAppointmentType.Recurring, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("NonRecurring", DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring, -1)})
            Me.cbCancelingTypes.Size = New System.Drawing.Size(150, 19)
            Me.cbCancelingTypes.TabIndex = 93
            '
            'lbApplyTypes
            '
            Me.lbApplyTypes.Location = New System.Drawing.Point(10, 36)
            Me.lbApplyTypes.Name = "lbApplyTypes"
            Me.lbApplyTypes.Size = New System.Drawing.Size(258, 13)
            Me.lbApplyTypes.TabIndex = 89
            Me.lbApplyTypes.Text = "Cancel import for the following Outlook appointments:"
            '
            'btnImport
            '
            Me.btnImport.ImageIndex = 2
            Me.btnImport.Location = New System.Drawing.Point(432, 6)
            Me.btnImport.Name = "btnImport"
            Me.btnImport.Size = New System.Drawing.Size(81, 24)
            Me.btnImport.TabIndex = 88
            Me.btnImport.Text = "&Import"
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 68)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.calendarTabPage
            Me.xtraTabControl1.Size = New System.Drawing.Size(704, 324)
            Me.xtraTabControl1.TabIndex = 4
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.calendarTabPage, Me.logTabPage})
            '
            'calendarTabPage
            '
            Me.calendarTabPage.Controls.Add(Me.schedulerControl)
            Me.calendarTabPage.Name = "calendarTabPage"
            Me.calendarTabPage.Size = New System.Drawing.Size(695, 293)
            Me.calendarTabPage.Text = "Calendar"
            '
            'schedulerControl
            '
            Me.schedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(695, 293)
            Me.schedulerControl.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 2
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 5
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
            Me.schedulerStorage.Appointments.DataSource = Me.xpCollectionEvents
            Me.schedulerStorage.Appointments.Mappings.AllDay = "AllDayEvent"
            Me.schedulerStorage.Appointments.Mappings.Description = "Body"
            Me.schedulerStorage.Appointments.Mappings.End = "End"
            Me.schedulerStorage.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrencePattern"
            Me.schedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderSet"
            Me.schedulerStorage.Appointments.Mappings.Start = "Start"
            Me.schedulerStorage.Appointments.Mappings.Status = "BusyStatus"
            Me.schedulerStorage.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage.Appointments.Mappings.Type = "AppointmentType"
            '
            'logTabPage
            '
            Me.logTabPage.Controls.Add(Me.lbcLog)
            Me.logTabPage.Controls.Add(Me.panelControl1)
            Me.logTabPage.Name = "logTabPage"
            Me.logTabPage.Size = New System.Drawing.Size(695, 293)
            Me.logTabPage.Text = "Log"
            '
            'lbcLog
            '
            Me.lbcLog.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbcLog.Location = New System.Drawing.Point(0, 32)
            Me.lbcLog.Name = "lbcLog"
            Me.lbcLog.Size = New System.Drawing.Size(695, 261)
            Me.lbcLog.TabIndex = 5
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.lblLogInfo)
            Me.panelControl1.Controls.Add(Me.btnClearLog)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(695, 32)
            Me.panelControl1.TabIndex = 6
            '
            'lblLogInfo
            '
            Me.lblLogInfo.Location = New System.Drawing.Point(3, 8)
            Me.lblLogInfo.Name = "lblLogInfo"
            Me.lblLogInfo.Size = New System.Drawing.Size(76, 13)
            Me.lblLogInfo.TabIndex = 90
            Me.lblLogInfo.Text = "Import process:"
            '
            'btnClearLog
            '
            Me.btnClearLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClearLog.ImageIndex = 2
            Me.btnClearLog.Location = New System.Drawing.Point(628, 4)
            Me.btnClearLog.Name = "btnClearLog"
            Me.btnClearLog.Size = New System.Drawing.Size(64, 24)
            Me.btnClearLog.TabIndex = 76
            Me.btnClearLog.Text = "&Clear"
            '
            'ProgressBarControl1
            '
            Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 392)
            Me.ProgressBarControl1.Name = "ProgressBarControl1"
            Me.ProgressBarControl1.Properties.Step = 1
            Me.ProgressBarControl1.Size = New System.Drawing.Size(704, 12)
            Me.ProgressBarControl1.TabIndex = 6
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 60)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'OutlookImportModule
            '
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Controls.Add(Me.ProgressBarControl1)
            Me.Name = "OutlookImportModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpCollectionEvents, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbCalendarFolderPaths.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbCancelingTypes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.calendarTabPage.ResumeLayout(False)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.logTabPage.ResumeLayout(False)
            CType(Me.lbcLog, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private session1 As DevExpress.Xpo.Session
        Private xpCollectionEvents As DevExpress.Xpo.XPCollection
        Private panelControl As DevExpress.XtraEditors.PanelControl
        Private cbCancelingTypes As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lbApplyTypes As DevExpress.XtraEditors.LabelControl
        Private WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private calendarTabPage As DevExpress.XtraTab.XtraTabPage
        Private WithEvents schedulerControl As SchedulerControl
        Private logTabPage As DevExpress.XtraTab.XtraTabPage
        Private lbcLog As DevExpress.XtraEditors.ListBoxControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private lblLogInfo As DevExpress.XtraEditors.LabelControl
        Private WithEvents btnClearLog As DevExpress.XtraEditors.SimpleButton
        Private WithEvents schedulerStorage As SchedulerStorage
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents lbCalendarNames As DevExpress.XtraEditors.LabelControl
        Private WithEvents cbCalendarFolderPaths As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
