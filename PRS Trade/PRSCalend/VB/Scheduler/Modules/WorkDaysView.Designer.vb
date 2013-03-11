Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class WorkWeekViewModule
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
            Me.weekDaysCheckEdit1 = New DevExpress.XtraScheduler.UI.WeekDaysCheckEdit
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(8, 56)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(688, 340)
            Me.schedulerControl.Start = New Date(2010, 7, 4, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.weekDaysCheckEdit1)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(8, 8)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(688, 40)
            Me.panelControl.TabIndex = 2
            '
            'weekDaysCheckEdit1
            '
            Me.weekDaysCheckEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.weekDaysCheckEdit1.Appearance.Options.UseBackColor = True
            Me.weekDaysCheckEdit1.Location = New System.Drawing.Point(10, 11)
            Me.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1"
            Me.weekDaysCheckEdit1.Size = New System.Drawing.Size(668, 20)
            Me.weekDaysCheckEdit1.TabIndex = 0
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(8, 48)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(688, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'WorkWeekViewModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "WorkWeekViewModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            CType(Me.weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents weekDaysCheckEdit1 As DevExpress.XtraScheduler.UI.WeekDaysCheckEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
