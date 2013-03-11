Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.XtraScheduler.Demos.Forms
	Public Partial Class UserDefinedFilterAppointmentForm
		Inherits AppointmentForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
			MyBase.New(control, apt, openRecurrenceForm)
			InitializeComponent()
			UpdateCustomFieldsControls()
		End Sub

		Protected Friend Shadows ReadOnly Property Controller() As UserDefinedFilterAppointmentFormController
			Get
				Return CType(MyBase.Controller, UserDefinedFilterAppointmentFormController)
			End Get
		End Property

		Protected Overrides Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
			Return New UserDefinedFilterAppointmentFormController(control, apt)
		End Function

		Protected Overrides Sub UpdateCustomFieldsControls()
			MyBase.UpdateCustomFieldsControls()
			If Not edtPrice Is Nothing Then
				edtPrice.EditValue = Controller.Price
			End If
		End Sub

		Private Sub edtPrice_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtPrice.EditValueChanged
			Controller.Price = Convert.ToDecimal(edtPrice.EditValue)
		End Sub
	End Class

	Public Class UserDefinedFilterAppointmentFormController
		Inherits AppointmentFormController
		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			MyBase.New(control, apt)
		End Sub

		Public Property Price() As Decimal
			Get
				Dim Value As Object = EditedAppointmentCopy.CustomFields("CustomFieldPrice")
				Try
					Return Convert.ToDecimal(Value)
				Catch
					Return 0
				End Try
			End Get
			Set
				EditedAppointmentCopy.CustomFields("CustomFieldPrice") = Value
			End Set
		End Property

		Protected Overrides Sub ApplyCustomFieldsValues()
			MyBase.ApplyCustomFieldsValues()
			SourceAppointment.CustomFields("CustomFieldPrice") = Price
		End Sub
	End Class
End Namespace
