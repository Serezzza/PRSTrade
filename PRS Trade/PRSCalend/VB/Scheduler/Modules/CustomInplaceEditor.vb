Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Demos.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class CustomInplaceEditorModule
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

        Private Sub CustomInplaceEditorModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            cbView.EditValue = schedulerControl.ActiveViewType
            rgrpGrouping.EditValue = schedulerControl.GroupType
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

		Private Sub schedulerControl_InplaceEditorShowing(ByVal sender As Object, ByVal e As InplaceEditorEventArgs) Handles schedulerControl.InplaceEditorShowing
			'MyInplaceEditor editor = new MyInplaceEditor((SchedulerControl)sender, e.Appointment);
			e.InplaceEditorEx = New MyInplaceEditorControl(e.SchedulerInplaceEditorEventArgs)
		End Sub
	End Class
	Public Class MyInplaceEditorControl
		Implements ISchedulerInplaceEditorEx
		Private fEditor As MyInplaceEditor
		Private fAppointment As Appointment
		Private fControl As SchedulerControl
		Public Sub New(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
            Me.fAppointment = inplaceEditorArgs.ViewInfo.Appointment
			Me.fControl = inplaceEditorArgs.Control
			CreateEditor(inplaceEditorArgs)
		End Sub
		Private ReadOnly Property Editor() As MyInplaceEditor
			Get
				Return fEditor
			End Get
		End Property
		Private ReadOnly Property Appointment() As Appointment
			Get
				Return fAppointment
			End Get
		End Property
		Private ReadOnly Property Control() As SchedulerControl
			Get
				Return fControl
			End Get
		End Property

		Public Event CommitChanges As EventHandler Implements ISchedulerInplaceEditorEx.CommitChanges
		Public Event RollbackChanges As EventHandler Implements ISchedulerInplaceEditorEx.RollbackChanges

		Private Sub CreateEditor(ByVal inplaceEditorArgs As SchedulerInplaceEditorEventArgs)
			Me.fEditor = New MyInplaceEditor()
            Editor.Bounds = AdjustEditorBounds(inplaceEditorArgs.Control, inplaceEditorArgs.Bounds)
        End Sub


        Private Function AdjustEditorBounds(ByVal control As SchedulerControl, ByVal editorBounds As Rectangle) As Rectangle
            Dim screenControlBounds As Rectangle = control.Parent.RectangleToScreen(control.Bounds)
            editorBounds.Offset(0, -3)
            Dim screenEditorBounds As Rectangle = control.RectangleToScreen(editorBounds)

            Dim preferredSize As Size = editor.GetPreferredSize(editorBounds.Size)
            Dim height As Integer = Math.Max(preferredSize.Height, editorBounds.Height)
            Dim width As Integer = preferredSize.Width

            Dim rect As Rectangle = screenEditorBounds
            rect.Offset(editorBounds.Width + 6, 0)

            Dim maxBottom As Integer = Math.Min(screenControlBounds.Bottom, rect.Top + height)
            Dim top As Integer = maxBottom - height

            Dim result As Rectangle = New Rectangle(rect.Left, top, width, height)
            If screenControlBounds.Right < rect.Right Then
                Dim horzOffset As Integer = 8
                If TypeOf control.ActiveView Is DayView Then
                    horzOffset = 12
                End If
                result = New Rectangle(screenEditorBounds.Left - width - horzOffset, top, width, height)
            End If
            Return result
        End Function

		Public Sub Dispose() Implements ISchedulerInplaceEditorEx.Dispose
			Dispose(True)
			GC.SuppressFinalize(Me)
		End Sub
		Protected Overrides Sub Finalize()
			Dispose(False)
		End Sub
		Protected Overridable Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not Editor Is Nothing Then
					Editor.Dispose()
					Me.fEditor = Nothing
				End If
				Me.fAppointment = Nothing
			End If
		End Sub
		Public Overridable Sub Activate() Implements ISchedulerInplaceEditorEx.Activate
			Editor.FillForm(fControl, fAppointment)
			SubscribeEditorEvents()
			Editor.Show(Control.FindForm())
		End Sub
		Public Overridable Sub Deactivate() Implements ISchedulerInplaceEditorEx.Deactivate
			UnsibscribeEditorEvents()
			Editor.Close()
        End Sub
        Public Overridable Sub ApplyChanges() Implements ISchedulerInplaceEditorEx.ApplyChanges
            Editor.ApplyChanges()
        End Sub
        Protected Friend Overridable Sub SubscribeEditorEvents()
            AddHandler Editor.FormClosed, AddressOf Editor_FormClosed
            AddHandler Editor.Deactivate, AddressOf Editor_Deactivate
            AddHandler Editor.CommitChanges, AddressOf Editor_CommitChanges
            AddHandler Editor.RollbackChanges, AddressOf Editor_RollbackChanges
        End Sub

		Protected Friend Overridable Sub UnsibscribeEditorEvents()
			RemoveHandler Editor.FormClosed, AddressOf Editor_FormClosed
			RemoveHandler Editor.Deactivate, AddressOf Editor_Deactivate
			RemoveHandler Editor.CommitChanges, AddressOf Editor_CommitChanges
			RemoveHandler Editor.RollbackChanges, AddressOf Editor_RollbackChanges
		End Sub
		Private Sub Editor_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			OnCommitChanges()
		End Sub

		Private Sub Editor_Deactivate(ByVal sender As Object, ByVal e As EventArgs)
			OnCommitChanges()
		End Sub


		Private Sub Editor_RollbackChanges(ByVal sender As Object, ByVal e As EventArgs)
			OnRollbackChanges()
		End Sub

		Private Sub Editor_CommitChanges(ByVal sender As Object, ByVal e As EventArgs)
			OnCommitChanges()
		End Sub
		Protected Friend Overridable Sub TextBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
			Editor.Close()
			OnCommitChanges()
		End Sub

		Protected Friend Overridable Sub OnRollbackChanges()
			If Not RollbackChangesEvent Is Nothing Then
				RaiseEvent RollbackChanges(Me, EventArgs.Empty)
			End If
		End Sub
		Protected Friend Overridable Sub OnCommitChanges()
            RaiseCommitChanges()
		End Sub
		Protected Friend Overridable Sub RaiseCommitChanges()
			If Not CommitChangesEvent Is Nothing Then
				RaiseEvent CommitChanges(Me, EventArgs.Empty)
			End If
		End Sub
	End Class
End Namespace
