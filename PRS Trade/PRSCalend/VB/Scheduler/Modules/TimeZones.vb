Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class TimeZonesModule
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

		Private Sub TimeZonesModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DemoUtils.FillData(schedulerControl)
			UpdateControls()
		End Sub

		Private Sub UpdateControls()
			cbView.EditValue = schedulerControl.ActiveViewType
			cbGrouping.EditValue = schedulerControl.GroupType
			schedulerControl.DayView.TimeRulers(1).UseClientTimeZone = False
			schedulerControl.WorkWeekView.TimeRulers(1).UseClientTimeZone = False
			edtTimeZone.TimeZoneId = schedulerControl.OptionsBehavior.ClientTimeZoneId
		End Sub


		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
        End Sub

		Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
		End Sub

		Private Sub cbGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbGrouping.SelectedIndexChanged
			schedulerControl.GroupType = CType(cbGrouping.EditValue, SchedulerGroupType)
		End Sub

		Private Sub edtTimeZone_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtTimeZone.SelectedIndexChanged
			schedulerControl.OptionsBehavior.ClientTimeZoneId = edtTimeZone.TimeZoneId
			Dim caption As String = schedulerControl.OptionsBehavior.ClientTimeZoneId.ToString()
			schedulerControl.DayView.TimeRulers(2).Caption = caption
			schedulerControl.WorkWeekView.TimeRulers(2).Caption = caption
		End Sub
	End Class
End Namespace

