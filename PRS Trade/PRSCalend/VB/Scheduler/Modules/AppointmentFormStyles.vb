Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class AppointmentFormStylesModule
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

        Private Sub AppointmentFormStylesModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DemoUtils.FillData(schedulerControl)
            UpdateControls()
        End Sub

		Private Sub UpdateControls()
			cbView.EditValue = schedulerControl.ActiveViewType
			rgrpGrouping.EditValue = schedulerControl.GroupType
		End Sub
		Private Sub rgrpGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgrpGrouping.SelectedIndexChanged
			schedulerControl.GroupType = CType(rgrpGrouping.EditValue, SchedulerGroupType)
		End Sub

		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub

		Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
        End Sub

		Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl.EditAppointmentFormShowing
			Dim form As XtraForm
			If rgrpAptFormStyle.SelectedIndex = 0 Then
				form = New AppointmentFormOutlookStyle(schedulerControl, e.Appointment, e.OpenRecurrenceForm)
				CType(form, AppointmentFormOutlookStyle).ReadOnly = e.ReadOnly
			Else
				form = New AppointmentFormRibbonStyle(schedulerControl, e.Appointment, e.OpenRecurrenceForm)
				CType(form, AppointmentFormRibbonStyle).ReadOnly = e.ReadOnly
			End If
			form.LookAndFeel.ParentLookAndFeel = schedulerControl.LookAndFeel
			e.DialogResult = form.ShowDialog(e.Parent)
			e.Handled = True
		End Sub
	End Class
End Namespace
