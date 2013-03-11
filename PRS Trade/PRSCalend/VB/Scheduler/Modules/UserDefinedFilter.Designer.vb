Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Namespace DevExpress.XtraScheduler.Demos
    Partial Public Class UserDefinedFilterModule
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
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
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
            Me.filterControlForAppointments = New DevExpress.XtraEditors.FilterControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.btnApply = New DevExpress.XtraEditors.SimpleButton
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always
            Me.schedulerControl.Size = New System.Drawing.Size(700, 272)
            Me.schedulerControl.Storage = Me.schedulerStorage1
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.ToolTipController = Me.toolTipController1
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 2
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'schedulerStorage1
            '
            Me.schedulerStorage1.Appointments.Filter = "[CustomFieldPrice] > 10.0m"
            '
            'toolTipController1
            '
            Me.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.schedulerControl)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.filterControlForAppointments)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.panelControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(704, 404)
            Me.splitContainerControl1.SplitterPosition = 122
            Me.toolTipController1.SetSuperTip(Me.splitContainerControl1, Nothing)
            Me.splitContainerControl1.TabIndex = 3
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'filterControlForAppointments
            '
            Me.filterControlForAppointments.Dock = System.Windows.Forms.DockStyle.Fill
            Me.filterControlForAppointments.Location = New System.Drawing.Point(0, 0)
            Me.filterControlForAppointments.Name = "filterControlForAppointments"
            Me.filterControlForAppointments.Size = New System.Drawing.Size(700, 85)
            Me.filterControlForAppointments.SourceControl = Me.schedulerStorage1.Appointments
            Me.filterControlForAppointments.TabIndex = 2
            Me.filterControlForAppointments.Text = "appointmentsFilterControl"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.btnApply)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 85)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(700, 33)
            Me.toolTipController1.SetSuperTip(Me.panelControl1, Nothing)
            Me.panelControl1.TabIndex = 3
            '
            'btnApply
            '
            Me.btnApply.Location = New System.Drawing.Point(5, 5)
            Me.btnApply.Name = "btnApply"
            Me.btnApply.Size = New System.Drawing.Size(96, 23)
            Me.btnApply.TabIndex = 0
            Me.btnApply.Text = "Apply filter"
            '
            'UserDefinedFilterModule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "UserDefinedFilterModule"
            Me.Size = New System.Drawing.Size(704, 404)
            Me.toolTipController1.SetSuperTip(Me, Nothing)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents schedulerControl As SchedulerControl
        Private filterControlForAppointments As DevExpress.XtraEditors.FilterControl
        Private schedulerStorage1 As SchedulerStorage
        Private WithEvents btnApply As DevExpress.XtraEditors.SimpleButton
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace
