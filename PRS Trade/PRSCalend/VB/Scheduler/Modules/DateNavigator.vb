Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class DateNavigatorModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
		End Sub


		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub MonthViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			chkBoldAppointmentDates.Checked = dateNavigator1.BoldAppointmentDates
			chkShowTodayButton.Checked = dateNavigator1.ShowTodayButton
			chkShowWeekNumbers.Checked = dateNavigator1.ShowWeekNumbers
			cbWeekNumberRule.EditValue = dateNavigator1.WeekNumberRule
			DemoUtils.FillData(schedulerControl)

		End Sub
        
		Private Sub chkBoldAppointmentDates_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBoldAppointmentDates.CheckedChanged
			dateNavigator1.BoldAppointmentDates = chkBoldAppointmentDates.Checked
		End Sub

		Private Sub chkShowTodayButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowTodayButton.CheckedChanged
			dateNavigator1.ShowTodayButton = chkShowTodayButton.Checked
		End Sub

		Private Sub chkShowWeekNumbers_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowWeekNumbers.CheckedChanged
			dateNavigator1.ShowWeekNumbers = chkShowWeekNumbers.Checked
		End Sub

        Private Sub cbWeekNumberRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbWeekNumberRule.SelectedIndexChanged
            dateNavigator1.WeekNumberRule = CType(cbWeekNumberRule.EditValue, WeekNumberRule)
        End Sub

	End Class
End Namespace
