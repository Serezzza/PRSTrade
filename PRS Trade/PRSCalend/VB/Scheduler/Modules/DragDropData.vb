Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraEditors


Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class DragDropDataModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Private downHitInfo As GridHitInfo

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

		Private Sub DragDropDataModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			schedulerControl.GroupType = SchedulerGroupType.Resource
			schedulerStorage.Appointments.ResourceSharing = True

			cbView.EditValue = schedulerControl.ActiveViewType
			cbGrouping.EditValue = schedulerControl.GroupType

			DemoUtils.FillResources(schedulerStorage, 5)
			grdTasks.DataSource = DemoUtils.GenerateScheduleTasks()
        End Sub

        Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbView.SelectedIndexChanged
            schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
        End Sub

		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub
		Private Sub cbGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbGrouping.SelectedIndexChanged
			schedulerControl.GroupType = CType(cbGrouping.EditValue, SchedulerGroupType)
		End Sub

		Private Sub grdTasks_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseDown
			Dim view As GridView = TryCast(sender, GridView)
			downHitInfo = Nothing

			Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
			If Control.ModifierKeys <> Keys.None Then
				Return
			End If
            If e.Button = Windows.Forms.MouseButtons.Left AndAlso hitInfo.InRow AndAlso hitInfo.HitTest <> GridHitTest.RowIndicator Then
                downHitInfo = hitInfo
            End If
		End Sub

		Private Sub grdTasks_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
			Dim view As GridView = TryCast(sender, GridView)
            If e.Button = Windows.Forms.MouseButtons.Left AndAlso Not downHitInfo Is Nothing Then
                Dim dragSize As Size = SystemInformation.DragSize
                Dim dragRect As Rectangle = New Rectangle(New Point(Convert.ToInt32(downHitInfo.HitPoint.X - dragSize.Width / 2), Convert.ToInt32(downHitInfo.HitPoint.Y - dragSize.Height / 2)), dragSize)

                If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
                    view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All)
                    downHitInfo = Nothing
                End If
            End If
		End Sub
        Private Function GetDragData(ByVal view As GridView) As SchedulerDragData
            Dim selection As Integer() = view.GetSelectedRows()
            If selection Is Nothing Then
                Return Nothing
            End If

            Dim appointments As AppointmentBaseCollection = New AppointmentBaseCollection()
            Dim count As Integer = selection.Length
            Dim i As Integer = 0
            Do While i < count
                Dim rowIndex As Integer = selection(i)
                Dim apt As Appointment = schedulerStorage.CreateAppointment(AppointmentType.Normal)
                apt.Subject = CStr(view.GetRowCellValue(rowIndex, "Subject"))
                apt.LabelId = CInt(Fix(view.GetRowCellValue(rowIndex, "Severity")))
                apt.StatusId = CInt(Fix(view.GetRowCellValue(rowIndex, "Priority")))
                apt.Duration = TimeSpan.FromHours(CInt(Fix(view.GetRowCellValue(rowIndex, "Duration"))))
                apt.Description = CStr(view.GetRowCellValue(rowIndex, "Description"))
                appointments.Add(apt)
                i += 1
            Loop

            Return New SchedulerDragData(appointments, 0)
        End Function

        Private Sub schedulerControl_AppointmentDrop(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentDragEventArgs) Handles schedulerControl.AppointmentDrop
            Dim createEventMsg As String = "Creating an event at {0} on {1}."
            Dim moveEventMsg As String = "Moving the event from {0} on {1} to {2} on {3}."

            Dim srcStart As DateTime = e.SourceAppointment.Start
            Dim NewStart As DateTime = e.EditedAppointment.Start



            Dim msg As String = String.Empty
            If srcStart = DateTime.MinValue Then
                msg = String.Format(createEventMsg, NewStart.ToShortTimeString, NewStart.ToShortDateString)
            Else
                msg = String.Format(moveEventMsg, srcStart.ToShortTimeString, srcStart.ToShortDateString, NewStart.ToShortTimeString, NewStart.ToShortDateString)
            End If

            If XtraMessageBox.Show(msg & Constants.vbCrLf & "Proceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Allow = False
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
