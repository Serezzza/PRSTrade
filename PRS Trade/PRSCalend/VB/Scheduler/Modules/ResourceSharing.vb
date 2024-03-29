Imports Microsoft.VisualBasic
Imports System

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class ResourceSharingModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Private Const AttendeeDescription As String = "The following persons are invited:" & Constants.vbCrLf

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

		Private Sub GroupByDateModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			schedulerControl.Start = DateTime.Today
			DemoUtils.FillResources(schedulerStorage, Integer.MaxValue)
			'schedulerControl.GroupType = SchedulerGroupType.Resource;
			'schedulerStorage.Appointments.ResourceSharing = true;
			PrepareMeetings()

			cbView.EditValue = schedulerControl.ActiveViewType
			cbGrouping.EditValue = schedulerControl.GroupType
		End Sub

		#Region "data initialization"
		Private Sub PrepareMeetings()
			Dim resourceCount As Integer = schedulerStorage.Resources.Count
			System.Diagnostics.Debug.Assert(resourceCount = 8)

			schedulerStorage.BeginUpdate()
			Try
				Dim today As DateTime = DateTime.Today
				Dim apt As Appointment = CreateMeeting("Morning meeting", today + TimeSpan.FromHours(9), New Integer() { 1, 3, 5 })
				apt.StatusId = 2
				apt.LabelId = 2
				schedulerStorage.Appointments.Add(apt)

				Dim dayShift As Integer = DemoUtils.RandomInstance.Next(3)
				apt = CreateMeeting("Product delivery planning", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(12), New Integer() { 2, 4, 5 })
				apt.StatusId = 2
				apt.LabelId = 5
				schedulerStorage.Appointments.Add(apt)

				dayShift = DemoUtils.RandomInstance.Next(3)
				apt = CreateMeeting("New product concept presentation", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(14), New Integer() { 2, 3, 6 })
				apt.StatusId = 1
				apt.LabelId = 6
				schedulerStorage.Appointments.Add(apt)

				dayShift = DemoUtils.RandomInstance.Next(3)
				apt = CreateMeeting("Discussion", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(16), New Integer() { 1, 2, 3, 5 })
				apt.StatusId = 2
				apt.LabelId = 5
				schedulerStorage.Appointments.Add(apt)

				dayShift = DemoUtils.RandomInstance.Next(3)
				apt = CreateMeeting("New employee interview", today + TimeSpan.FromDays(dayShift) + TimeSpan.FromHours(11), New Integer() { 2, 3 })
				apt.StatusId = 1
				apt.LabelId = 4
				schedulerStorage.Appointments.Add(apt)
			Finally
				schedulerStorage.EndUpdate()
			End Try
		End Sub
		Private Function CreateMeeting(ByVal subject As String, ByVal [date] As DateTime, ByVal participants() As Integer) As Appointment
			Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
			apt.Start = [date]
			apt.Duration = TimeSpan.FromHours(1)
			apt.Subject = subject

			Dim description As String = AttendeeDescription
			Dim count As Integer = participants.Length
			For i As Integer = 0 To count - 1
				Dim resource As Resource = schedulerStorage.Resources(participants(i))
				description &= String.Format("{0}" & Constants.vbCrLf, resource.Caption)
				apt.ResourceIds.Add(resource.Id)
			Next i
			apt.Description = description
			Return apt
		End Function
		#End Region

		Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
		End Sub
		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub
		Private Sub cbGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbGrouping.SelectedIndexChanged
			schedulerControl.GroupType = CType(cbGrouping.EditValue, SchedulerGroupType)
		End Sub

		Private Sub schedulerStorage_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage.AppointmentChanging, schedulerStorage.AppointmentInserting
			Dim apt As Appointment = TryCast(e.Object, Appointment)
			apt.Description = AttendeeDescription & GetAttendeeNames(apt.ResourceIds)
		End Sub
		Private Function GetAttendeeNames(ByVal resIds As AppointmentResourceIdCollection) As String
			Dim result As String = String.Empty
			Dim resources As ResourceCollection = schedulerStorage.Resources.Items
			For Each resource As Resource In resources
				If resIds.Contains(resource.Id) Then
					result &= String.Format("{0}" & Constants.vbCrLf, resource.Caption)
				End If
			Next resource
			Return result
		End Function

	End Class
End Namespace

