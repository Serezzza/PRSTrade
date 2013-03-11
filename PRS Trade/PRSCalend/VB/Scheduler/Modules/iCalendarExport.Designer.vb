Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class iCalendarExportModule
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
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.cbCancelingTypes = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.btnImport = New DevExpress.XtraEditors.SimpleButton
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.cbCancelingTypes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 70)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 317)
            Me.schedulerControl.Start = New Date(2010, 7, 13, 0, 0, 0, 0)
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
            'ProgressBarControl1
            '
            Me.ProgressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ProgressBarControl1.Location = New System.Drawing.Point(0, 392)
            Me.ProgressBarControl1.Name = "ProgressBarControl1"
            Me.ProgressBarControl1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.ProgressBarControl1.Properties.Step = 1
            Me.ProgressBarControl1.Size = New System.Drawing.Size(704, 12)
            Me.ProgressBarControl1.TabIndex = 7
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.cbCancelingTypes)
            Me.panelControl.Controls.Add(Me.label1)
            Me.panelControl.Controls.Add(Me.btnImport)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 62)
            Me.panelControl.TabIndex = 8
            '
            'cbCancelingTypes
            '
            Me.cbCancelingTypes.EditValue = ""
            Me.cbCancelingTypes.Location = New System.Drawing.Point(236, 9)
            Me.cbCancelingTypes.Name = "cbCancelingTypes"
            Me.cbCancelingTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbCancelingTypes.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("None", DevExpress.XtraScheduler.UsedAppointmentType.None, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Recurring", DevExpress.XtraScheduler.UsedAppointmentType.Recurring, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("NonRecurring", DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring, -1)})
            Me.cbCancelingTypes.Size = New System.Drawing.Size(144, 19)
            Me.cbCancelingTypes.TabIndex = 93
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(10, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(220, 13)
            Me.label1.TabIndex = 94
            Me.label1.Text = "Cancel export for the following appointments:"
            '
            'btnImport
            '
            Me.btnImport.ImageIndex = 2
            Me.btnImport.Location = New System.Drawing.Point(10, 34)
            Me.btnImport.Name = "btnImport"
            Me.btnImport.Size = New System.Drawing.Size(81, 22)
            Me.btnImport.TabIndex = 88
            Me.btnImport.Text = "&Export"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 387)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(704, 5)
            Me.panelControl1.TabIndex = 9
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 62)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'iCalendarExportModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.ProgressBarControl1)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "iCalendarExportModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.cbCancelingTypes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private schedulerControl As SchedulerControl
		Private schedulerStorage As SchedulerStorage
		Friend ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private cbCancelingTypes As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents btnImport As DevExpress.XtraEditors.SimpleButton
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private label1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
