Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing

Imports System.Windows.Forms


Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class ListBoundModeModule
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

        Private Sub ListBoundModeModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DemoUtils.FillResources(schedulerStorage, 5)
            InitAppointments()
            schedulerControl.Start = DateTime.Now
            UpdateControls()
        End Sub
        Private Sub InitAppointments()
            Dim mappings As DevExpress.XtraScheduler.AppointmentMappingInfo = Me.schedulerStorage.Appointments.Mappings
            mappings.Start = "StartTime"
            mappings.End = "EndTime"
            mappings.Subject = "Subject"
            mappings.AllDay = "AllDay"
            mappings.Description = "Description"
            mappings.Label = "Label"
            mappings.Location = "Location"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.ResourceId = "OwnerId"
            mappings.Status = "Status"
            mappings.Type = "EventType"

            Dim eventList As CustomEventList = New CustomEventList()
            GenerateEvents(eventList)
            Me.schedulerStorage.Appointments.DataSource = eventList

        End Sub
		Private Sub GenerateEvents(ByVal eventList As CustomEventList)
			Dim count As Integer = schedulerStorage.Resources.Count
			Dim i As Integer = 0
			Do While i < count
				Dim resource As Resource = schedulerStorage.Resources(i)
				Dim subjPrefix As String = resource.Caption & "'s "
				eventList.Add(CreateEvent(eventList, subjPrefix & "meeting", resource.Id, 2, 5))
				eventList.Add(CreateEvent(eventList, subjPrefix & "travel", resource.Id, 3, 6))
				eventList.Add(CreateEvent(eventList, subjPrefix & "phone call", resource.Id, 0, 10))
				i += 1
			Loop
		End Sub
		Private Function CreateEvent(ByVal eventList As CustomEventList, ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As CustomEvent
			Dim apt As CustomEvent = New CustomEvent(eventList)
			apt.Subject = subject
			apt.OwnerId = resourceId
			Dim rnd As Random = DemoUtils.RandomInstance
			Dim rangeInMinutes As Integer = 60 * 24
			apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, Convert.ToInt32(rangeInMinutes / 4)))
			apt.Status = status
			apt.Label = label
			Return apt
		End Function

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
	End Class
End Namespace
