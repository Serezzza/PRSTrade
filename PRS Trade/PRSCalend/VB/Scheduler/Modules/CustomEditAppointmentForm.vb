Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class CustomEditAppointmentFormModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
			Get
				Return schedulerControl
			End Get
		End Property

		Private Sub AddCustomFieldsMapping()
			Dim customNameMapping As AppointmentCustomFieldMapping = New AppointmentCustomFieldMapping("CustomName", "CustomName")
			Dim customStatusMapping As AppointmentCustomFieldMapping = New AppointmentCustomFieldMapping("CustomStatus", "CustomStatus")
			schedulerStorage.Appointments.CustomFieldMappings.Add(customNameMapping)
			schedulerStorage.Appointments.CustomFieldMappings.Add(customStatusMapping)
		End Sub

		Private Sub CustomEditAppointmentFormModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			cbView.EditValue = schedulerControl.ActiveViewType
			rgrpGrouping.EditValue = schedulerControl.GroupType

			AddCustomFieldsMapping()

			DemoUtils.FillData(schedulerControl)
		End Sub

		Private Sub rgrpGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgrpGrouping.SelectedIndexChanged
			schedulerControl.GroupType = CType(rgrpGrouping.EditValue, SchedulerGroupType)
		End Sub

		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub

		Private Sub cbViews_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
        End Sub

		Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles schedulerControl.EditAppointmentFormShowing
			Dim apt As Appointment = e.Appointment
			Dim openRecurrenceForm As Boolean = apt.IsRecurring AndAlso schedulerStorage.Appointments.IsNewAppointment(apt)

			Dim f As MyAppointmentEditForm = New MyAppointmentEditForm(CType(sender, SchedulerControl), apt, openRecurrenceForm)
			f.LookAndFeel.ParentLookAndFeel = Me.LookAndFeel.ParentLookAndFeel
			e.DialogResult = f.ShowDialog()
			e.Handled = True

			If apt.Type = AppointmentType.Pattern AndAlso schedulerControl.SelectedAppointments.Contains(apt) Then
				schedulerControl.SelectedAppointments.Remove(apt)
			End If

			schedulerControl.Refresh()
		End Sub
	End Class
End Namespace
