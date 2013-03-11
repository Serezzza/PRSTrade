Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class SplitAppointmentToolModule
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
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl
			' 
			Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl.MenuManager = Me
			Me.schedulerControl.Name = "schedulerControl"
			Me.schedulerControl.Size = New System.Drawing.Size(704, 404)
			Me.schedulerControl.Start = New System.DateTime(2009, 3, 12, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
			Me.schedulerControl.TabIndex = 4
			Me.schedulerControl.Text = "schedulerControl1"
			Me.schedulerControl.Views.DayView.AppointmentDisplayOptions.SnapToCellsMode = DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never
			Me.schedulerControl.Views.DayView.DayCount = 3
			Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl.Views.TimelineView.ShowMoreButtons = False
			Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'			Me.schedulerControl.PreparePopupMenu += New DevExpress.XtraScheduler.PreparePopupMenuEventHandler(Me.schedulerControl_PreparePopupMenu);
            Me.schedulerControl.Views.GanttView.Enabled = False
			' 
			' SplitAppointmentToolModule
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
			Me.Controls.Add(Me.schedulerControl)
			Me.Name = "SplitAppointmentToolModule"
			Me.Size = New System.Drawing.Size(704, 404)
'			Me.Load += New System.EventHandler(Me.SplitAppointmentToolModule_Load);
			CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl As SchedulerControl
		Private schedulerStorage As SchedulerStorage
	End Class
End Namespace
