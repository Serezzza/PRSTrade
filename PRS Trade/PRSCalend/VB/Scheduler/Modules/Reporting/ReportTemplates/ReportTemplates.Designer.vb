Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos.Reporting.ReportTemplates

    Partial Public Class ReportTemplatesModule
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
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl()
            Me.btnResourceColorSchemas = New DevExpress.XtraEditors.SimpleButton()
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl()
            Me.ControlPrintAdapter1 = New DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter()
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ControlPrintAdapter1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 50)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 354)
            Me.schedulerControl.Start = New System.DateTime(2010, 6, 30, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("01:00:00")
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 3
            Me.schedulerControl.Views.TimelineView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 3
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.WorkWeekView.TimeScale = System.TimeSpan.Parse("01:00:00")
            ' 
            ' panelControl
            ' 
            Me.panelControl.Controls.Add(Me.btnResourceColorSchemas)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 42)
            Me.panelControl.TabIndex = 2
            ' 
            ' btnResourceColorSchemas
            ' 
            Me.btnResourceColorSchemas.ImageIndex = 2
            Me.btnResourceColorSchemas.Location = New System.Drawing.Point(11, 9)
            Me.btnResourceColorSchemas.Name = "btnResourceColorSchemas"
            Me.btnResourceColorSchemas.Size = New System.Drawing.Size(254, 24)
            Me.btnResourceColorSchemas.TabIndex = 87
            Me.btnResourceColorSchemas.Text = "&Preview a report via the template file..."
            '			Me.btnResourceColorSchemas.Click += New System.EventHandler(Me.btnResourceColorSchemas_Click);
            ' 
            ' panelSeparatorControl
            ' 
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 42)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 9
            ' 
            ' ControlPrintAdapter1
            ' 
            Me.ControlPrintAdapter1.SchedulerControl = Me.schedulerControl
            ' 
            ' ReportTemplatesModule
            ' 
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "ReportTemplatesModule"
            Me.Size = New System.Drawing.Size(704, 404)
            '			Me.Load += New System.EventHandler(Me.DayViewModule_Load);
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ControlPrintAdapter1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private panelControl As DevExpress.XtraEditors.PanelControl
        Private components As System.ComponentModel.IContainer = Nothing
        Private panelSeparatorControl As DevExpress.XtraEditors.PanelControl
        Private WithEvents btnResourceColorSchemas As DevExpress.XtraEditors.SimpleButton
        Private ControlPrintAdapter1 As DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter

    End Class
End Namespace
