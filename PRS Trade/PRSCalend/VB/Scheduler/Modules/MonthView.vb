Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class MonthViewModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			PrepareViews()
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property
		Protected ReadOnly Property DisplayOptions() As AppointmentDisplayOptions
			Get
				Return schedulerControl.MonthView.AppointmentDisplayOptions
			End Get
		End Property

		Private Sub PrepareViews()
			schedulerControl.DayView.Enabled = False
			schedulerControl.WeekView.Enabled = False
			schedulerControl.WorkWeekView.Enabled = False
			schedulerControl.TimelineView.Enabled = False
		End Sub

		Private Sub MonthViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DemoUtils.FillData(schedulerControl)
			UpdateControls()
		End Sub
		Private Sub UpdateControls()
			Dim options As AppointmentDisplayOptions = DisplayOptions
			chkStartTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.StartTimeVisibility)
			chkEndTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.EndTimeVisibility)

			chkCompressWeekEnd.Checked = schedulerControl.MonthView.CompressWeekend
			chkShowWeekend.Checked = schedulerControl.MonthView.ShowWeekend
			chkCompressWeekEnd.Enabled = chkShowWeekend.Checked

			cbTimeDisplayType.EditValue = options.TimeDisplayType
			cbStatus.EditValue = options.StatusDisplayType
			spinWeekCount.EditValue = schedulerControl.MonthView.WeekCount
		End Sub

		Private Sub chkCompressWeekEnd_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCompressWeekEnd.CheckedChanged
			schedulerControl.MonthView.CompressWeekend = chkCompressWeekEnd.Checked
		End Sub
		Private Sub chkShowWeekend_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowWeekend.CheckedChanged
			schedulerControl.MonthView.ShowWeekend = chkShowWeekend.Checked
			chkCompressWeekEnd.Enabled = chkShowWeekend.Checked
		End Sub
		Private Sub spinWeekCount_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinWeekCount.EditValueChanged
			schedulerControl.MonthView.WeekCount = Convert.ToInt32(spinWeekCount.EditValue)
		End Sub
        Private Sub schedulerControl_PreparePopupMenu(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub
		Private Sub MonthViewModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
			schedulerControl.ActiveViewType = SchedulerViewType.Month
		End Sub

		Private Sub chkStartTimeVisibility_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkStartTimeVisibility.CheckStateChanged
			DisplayOptions.StartTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkStartTimeVisibility.CheckState)
		End Sub

		Private Sub chkEndTimeVisibility_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEndTimeVisibility.CheckStateChanged
			DisplayOptions.EndTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkEndTimeVisibility.CheckState)
		End Sub

		Private Sub cbTimeDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTimeDisplayType.SelectedIndexChanged
			DisplayOptions.TimeDisplayType = CType(cbTimeDisplayType.EditValue, AppointmentTimeDisplayType)
		End Sub

		Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.SelectedIndexChanged
			DisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
		End Sub
	End Class
End Namespace
