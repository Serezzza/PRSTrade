Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI
' ...

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class MyAppointmentEditForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private control As SchedulerControl
		Private apt As Appointment
		Private openRecurrenceForm As Boolean = False
		Private suspendUpdateCount As Integer
		Private WithEvents checkAllDay As DevExpress.XtraEditors.CheckEdit
		' Note that the MyAppointmentFormController class is inherited from
		' the AppointmentFormController one to add custom properties.
		' See its declaration at the end of this file.
		Private controller As MyAppointmentFormController

		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
			Me.openRecurrenceForm = openRecurrenceForm
			Me.controller = New MyAppointmentFormController(control, apt)
			Me.apt = apt
			Me.control = control
			'
			' Required for Windows Form Designer support
            '
            SuspendUpdate()
            InitializeComponent()
            ResumeUpdate()

			UpdateForm()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Protected ReadOnly Property Appointments() As AppointmentStorage
			Get
				Return control.Storage.Appointments
			End Get
        End Property
        Protected Friend ReadOnly Property IsNewAppointment() As Boolean
            Get
                If Not controller Is Nothing Then
                    Return controller.IsNewAppointment
                Else
                    Return True
                End If
            End Get
        End Property
		Protected ReadOnly Property IsUpdateSuspended() As Boolean
			Get
				Return suspendUpdateCount > 0
			End Get
		End Property

		Protected Sub SuspendUpdate()
			suspendUpdateCount += 1
		End Sub
		Protected Sub ResumeUpdate()
			If suspendUpdateCount > 0 Then
				suspendUpdateCount -= 1
			End If
		End Sub

		Private Sub btnAddRec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReccurrence.Click
			OnRecurrenceButton()
		End Sub

		Private Sub OnRecurrenceButton()
			ShowRecurrenceForm()
		End Sub

		Private Sub ShowRecurrenceForm()

			If (Not control.SupportsRecurrence) Then
				Return
			End If

			' Prepare to edit appointment's recurrence.
			Dim editedAptCopy As Appointment = controller.EditedAppointmentCopy
			Dim editedPattern As Appointment = controller.EditedPattern
			Dim patternCopy As Appointment = controller.PrepareToRecurrenceEdit()

			Dim dlg As AppointmentRecurrenceForm = New AppointmentRecurrenceForm(patternCopy, control.OptionsView.FirstDayOfWeek, controller)

			' Required for skins support.
            dlg.LookAndFeel.ParentLookAndFeel = Me.LookAndFeel.ParentLookAndFeel
            dlg.ShowExceptionsRemoveMsgBox = controller.AreExceptionsPresent()

			Dim result As DialogResult = dlg.ShowDialog(Me)
			dlg.Dispose()

            If result = Windows.Forms.DialogResult.Abort Then
                controller.RemoveRecurrence()
            Else
                If result = System.Windows.Forms.DialogResult.OK Then
                    controller.ApplyRecurrence(patternCopy)
                    If Not controller.EditedAppointmentCopy Is editedAptCopy Then
                        UpdateForm()
                    End If
                End If
            End If
			UpdateIntervalControls()
		End Sub

		Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
			' Required to check appointment's conflicts.
			If (Not controller.IsConflictResolved()) Then
				Return
			End If

			controller.Subject = txSubject.Text
			controller.SetStatus(edStatus.Status)
			controller.SetLabel(edLabel.Label)
			controller.AllDay = Me.checkAllDay.Checked
            controller.DisplayStart = Me.dtStart.DateTime.Date + Me.timeStart.Time.TimeOfDay
            controller.DisplayEnd = Me.dtEnd.DateTime.Date + Me.timeEnd.Time.TimeOfDay
            controller.CustomName = txCustomName.Text
			controller.CustomStatus = txCustomStatus.Text

			' Save all changes made to the appointment edited in a form.
			controller.ApplyChanges()
		End Sub

		Private Sub UpdateForm()
			SuspendUpdate()
			Try
				txSubject.Text = controller.Subject
				edStatus.Status = Appointments.Statuses(controller.StatusId)
				edLabel.Label = Appointments.Labels(controller.LabelId)

                dtStart.DateTime = controller.DisplayStart.Date
                dtEnd.DateTime = controller.DisplayEnd.Date

                timeStart.Time = DateTime.MinValue.AddTicks(controller.DisplayStart.TimeOfDay.Ticks)
                timeEnd.Time = DateTime.MinValue.AddTicks(controller.DisplayEnd.TimeOfDay.Ticks)
				checkAllDay.Checked = controller.AllDay

				edStatus.Storage = control.Storage
				edLabel.Storage = control.Storage

				txCustomName.Text = controller.CustomName
				txCustomStatus.Text = controller.CustomStatus
			Finally
				ResumeUpdate()
			End Try
			UpdateIntervalControls()
		End Sub

		Private Sub MyAppointmentEditForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
			' Required to show the recurrence form.
			If openRecurrenceForm Then
				openRecurrenceForm = False
				OnRecurrenceButton()
			End If
		End Sub

		Private Sub dtStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtStart.EditValueChanged
			If (Not IsUpdateSuspended) Then
                controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
            End If
			UpdateIntervalControls()
		End Sub
		Protected Overridable Sub UpdateIntervalControls()
			If IsUpdateSuspended Then
				Return
			End If

			SuspendUpdate()
			Try
                dtStart.EditValue = controller.DisplayStart.Date
                dtEnd.EditValue = controller.DisplayEnd.Date
                timeStart.EditValue = controller.DisplayStart.TimeOfDay
                timeEnd.EditValue = controller.DisplayEnd.TimeOfDay

                Dim editedAptCopy As Appointment = controller.EditedAppointmentCopy
                Dim showControls As Boolean = IsNewAppointment OrElse editedAptCopy.Type <> AppointmentType.Pattern
                dtStart.Enabled = showControls
                dtEnd.Enabled = showControls
                Dim enableTime As Boolean = showControls AndAlso Not controller.AllDay
                timeStart.Visible = enableTime
                timeStart.Enabled = enableTime
                timeEnd.Visible = enableTime
                timeEnd.Enabled = enableTime
                checkAllDay.Enabled = showControls
            Finally
                ResumeUpdate()
			End Try
		End Sub
		Private Sub timeStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeStart.EditValueChanged
			If (Not IsUpdateSuspended) Then
                controller.DisplayStart = dtStart.DateTime.Date + timeStart.Time.TimeOfDay
			End If
			UpdateIntervalControls()
		End Sub
		Private Sub timeEnd_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeEnd.EditValueChanged
			If IsUpdateSuspended Then
			Return
			End If
			If IsIntervalValid() Then
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay
			Else
                timeEnd.EditValue = controller.DisplayEnd.TimeOfDay
			End If
		End Sub
		Private Sub dtEnd_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtEnd.EditValueChanged
			If IsUpdateSuspended Then
			Return
			End If
			If IsIntervalValid() Then
                controller.DisplayEnd = dtEnd.DateTime.Date + timeEnd.Time.TimeOfDay
			Else
                dtEnd.EditValue = controller.DisplayEnd.Date
			End If
		End Sub
		Private Function IsIntervalValid() As Boolean
			Dim lStart As DateTime = dtStart.DateTime + timeStart.Time.TimeOfDay
			Dim lEnd As DateTime = dtEnd.DateTime + timeEnd.Time.TimeOfDay
			Return lEnd >= lStart
		End Function

		Private Sub checkAllDay_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkAllDay.CheckedChanged
			controller.AllDay = Me.checkAllDay.Checked
			If (Not IsUpdateSuspended) Then
				UpdateAppointmentStatus()
			End If

			UpdateIntervalControls()
		End Sub
		Private Sub UpdateAppointmentStatus()
			Dim currentStatus As AppointmentStatus = edStatus.Status
			Dim newStatus As AppointmentStatus = controller.UpdateAppointmentStatus(currentStatus)
			If Not newStatus Is currentStatus Then
				edStatus.Status = newStatus
			End If
		End Sub
	End Class
	Public Class MyAppointmentFormController
		Inherits AppointmentFormController

		Public Property CustomName() As String
			Get
				Return CStr(EditedAppointmentCopy.CustomFields("CustomName"))
			End Get
			Set
				EditedAppointmentCopy.CustomFields("CustomName") = Value
			End Set
		End Property
		Public Property CustomStatus() As String
			Get
				Return CStr(EditedAppointmentCopy.CustomFields("CustomStatus"))
			End Get
			Set
				EditedAppointmentCopy.CustomFields("CustomStatus") = Value
			End Set
		End Property

		Private Property SourceCustomName() As String
			Get
				Return CStr(SourceAppointment.CustomFields("CustomName"))
			End Get
			Set
				SourceAppointment.CustomFields("CustomName") = Value
			End Set
		End Property
		Private Property SourceCustomStatus() As String
			Get
				Return CStr(SourceAppointment.CustomFields("CustomStatus"))
			End Get
			Set
				SourceAppointment.CustomFields("CustomStatus") = Value
			End Set
		End Property

		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			MyBase.New(control, apt)
		End Sub

		Public Overrides Function IsAppointmentChanged() As Boolean
			If MyBase.IsAppointmentChanged() Then
				Return True
			End If
			Return SourceCustomName <> CustomName OrElse SourceCustomStatus <> CustomStatus
		End Function

		Protected Overrides Sub ApplyCustomFieldsValues()
			SourceCustomName = CustomName
			SourceCustomStatus = CustomStatus
		End Sub
	End Class
End Namespace
