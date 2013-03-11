Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class WorkWeekViewModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			PrepareViews()
			weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays
		End Sub

		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub PrepareViews()
			schedulerControl.DayView.Enabled = False
			schedulerControl.WeekView.Enabled = False
			schedulerControl.MonthView.Enabled = False
			schedulerControl.TimelineView.Enabled = False
		End Sub
		Private Sub WorkWeekViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DemoUtils.FillData(schedulerControl)
		End Sub

		Private Sub weekDaysCheckEdit1_WeekDaysChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles weekDaysCheckEdit1.WeekDaysChanged
			Dim workDays As WorkDaysCollection = schedulerControl.WorkDays
			workDays.BeginUpdate()
			workDays.Clear()
			If weekDaysCheckEdit1.WeekDays <> CType(0, WeekDays) Then
				workDays.Add(New WeekDaysWorkDay(weekDaysCheckEdit1.WeekDays))
			End If
			workDays.EndUpdate()
		End Sub

        Private Sub schedulerControl_PreparePopupMenu(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub

		Private Sub WorkWeekViewModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
			schedulerControl.ActiveViewType = SchedulerViewType.WorkWeek
		End Sub
	End Class
End Namespace
