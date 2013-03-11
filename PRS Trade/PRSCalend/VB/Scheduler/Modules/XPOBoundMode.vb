Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms
Imports DevExpress.Xpo


Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class XPOBoundModeModule
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

        Private Sub UnboundModeModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            schedulerControl.Start = DateTime.Today
            InitData()
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

		Private Sub OnAppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsInserted, schedulerStorage.AppointmentsChanged
			For Each apt As Appointment In e.Objects
				Dim o As XPBaseObject = TryCast(apt.GetSourceObject(schedulerStorage), XPBaseObject)
				If Not o Is Nothing Then
					o.Save()
				End If
			Next apt
		End Sub
		Private Sub InitData()
			If xpCollectionEmployees.Count <= 0 Then
				For i As Integer = 0 To 4
					AddEmployee(DemoUtils.Users(i))
				Next i
			End If
			If xpCollectionTasks.Count <= 0 Then
				Dim i As Integer = 0
				Do While i < xpCollectionEmployees.Count
					AddTasks(CType(xpCollectionEmployees(i), Employee))
					i += 1
				Loop
			End If
		End Sub
		Private Sub AddEmployee(ByVal name As String)
			Dim employee As Employee = New Employee(session1)
			employee.Name = name
			xpCollectionEmployees.Add(employee)
			employee.Save()
		End Sub
		Private Sub AddTasks(ByVal employee As Employee)
			AddTask(employee, "meeting", 2, 5)
			AddTask(employee, "travel", 3, 6)
			AddTask(employee, "phone call", 0, 10)
		End Sub
		Private Sub AddTask(ByVal employee As Employee, ByVal taskName As String, ByVal status As Integer, ByVal label As Integer)
			Dim task As Task = New Task(session1)
			task.Employee = employee
			task.Subject = employee.Name & "'s " & taskName

			Dim rangeInMinutes As Integer = 60 * 24
			task.Created = DateTime.Today + TimeSpan.FromMinutes(DemoUtils.RandomInstance.Next(0, rangeInMinutes))
            task.Finish = task.Created + TimeSpan.FromMinutes(DemoUtils.RandomInstance.Next(0, Convert.ToInt32(rangeInMinutes / 4)))

			task.Status = status
			task.Label = label

			xpCollectionTasks.Add(task)
			task.Save()
		End Sub
	End Class

	' XP object
	Public Class Task
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public AllDay As Boolean ' Appointment.AllDay

		<Size(SizeAttribute.Unlimited)> _
		Public Description As String ' Appointment.Description

		Public Finish As DateTime ' Appointment.End
		Public Label As Integer ' Appointment.Label
		Public Location As String ' Appointment.Location

		<Size(SizeAttribute.Unlimited)> _
		Public Recurrence As String ' Appointment.RecurrenceInfo

		<Size(SizeAttribute.Unlimited)> _
		Public Reminder As String ' Appointment.ReminderInfo

		Public Created As DateTime ' Appointment.Start
		Public Status As Integer ' Appointment.Status
		Public Subject As String ' Appointment.Subject
		Public AppointmentType As Integer ' Appointment.Type

		Public Employee As Employee
	End Class

	' XP object
	Public Class Employee
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		<Size(SizeAttribute.Unlimited)> _
		Public Name As String ' Resource.Caption
	End Class
End Namespace
