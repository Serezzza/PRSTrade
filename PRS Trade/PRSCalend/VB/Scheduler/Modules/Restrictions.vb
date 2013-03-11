Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms


Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class RestrictionsModule
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


		Private Sub RestrictionsModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DemoUtils.FillData(schedulerControl)
			UpdateControls()
		End Sub


		Private Sub UpdateControls()
			cbView.EditValue = schedulerControl.ActiveViewType
			cbGrouping.EditValue = schedulerControl.GroupType
			Dim opts As SchedulerOptionsCustomization = schedulerControl.OptionsCustomization
			chkAllowConflicts.Checked = opts.AllowAppointmentConflicts = AppointmentConflictsMode.Allowed
			chkAllowCopy.Checked = opts.AllowAppointmentCopy = UsedAppointmentType.All
			chkAllowCreate.Checked = opts.AllowAppointmentCreate = UsedAppointmentType.All
			chkAllowDelete.Checked = opts.AllowAppointmentDelete = UsedAppointmentType.All
			chkAllowDrag.Checked = opts.AllowAppointmentDrag = UsedAppointmentType.All
			chkAllowDragBetweenResources.Checked = opts.AllowAppointmentDragBetweenResources = UsedAppointmentType.All
			chkAllowEdit.Checked = opts.AllowAppointmentEdit = UsedAppointmentType.All
			chkAllowInplaceEditor.Checked = opts.AllowInplaceEditor = UsedAppointmentType.All
			chkAllowMultiSelect.Checked = opts.AllowAppointmentMultiSelect
			chkAllowResize.Checked = opts.AllowAppointmentResize = UsedAppointmentType.All
		End Sub
		Private Sub chkAllowCreate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowCreate.CheckedChanged
			If chkAllowCreate.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None
			End If
		End Sub

		Private Sub chkAllowEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowEdit.CheckedChanged
			If chkAllowEdit.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
			End If
		End Sub

		Private Sub chkAllowResize_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowResize.CheckedChanged
			If chkAllowResize.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None
			End If
		End Sub

		Private Sub chkAllowConflicts_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowConflicts.CheckedChanged
			If chkAllowConflicts.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentConflicts = AppointmentConflictsMode.Allowed
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentConflicts = AppointmentConflictsMode.Forbidden
			End If
		End Sub

		Private Sub chkAllowDragBetweenResources_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowDragBetweenResources.CheckedChanged
			If chkAllowDragBetweenResources.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentDragBetweenResources = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentDragBetweenResources = UsedAppointmentType.None
			End If
		End Sub

		Private Sub chkAllowDelete_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowDelete.CheckedChanged
			If chkAllowDelete.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None
			End If
		End Sub

		Private Sub chkAllowCopy_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowCopy.CheckedChanged
			If chkAllowCopy.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.None
			End If
		End Sub

		Private Sub chkAllowDrag_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowDrag.CheckedChanged
			If chkAllowDrag.Checked Then
				schedulerControl.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None
			End If
		End Sub

		Private Sub chkAllowMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowMultiSelect.CheckedChanged
			schedulerControl.OptionsCustomization.AllowAppointmentMultiSelect = chkAllowMultiSelect.Checked
		End Sub

		Private Sub chkAllowInplaceEditor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAllowInplaceEditor.CheckedChanged
			If chkAllowInplaceEditor.Checked Then
				schedulerControl.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.All
			Else
				schedulerControl.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.None
			End If
		End Sub

		Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
        End Sub

		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub

		Private Sub cbGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrouping.SelectedIndexChanged
			schedulerControl.GroupType = CType(cbGrouping.EditValue, SchedulerGroupType)
		End Sub
	End Class
End Namespace
