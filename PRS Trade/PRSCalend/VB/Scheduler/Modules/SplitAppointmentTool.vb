Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class SplitAppointmentToolModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub SplitAppointmentToolModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			DemoUtils.FillData(Me.schedulerControl)
		End Sub
        Private Sub schedulerControl_PreparePopupMenu(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
            If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu Then
                Dim command As New SplitAppointmentOperationCommand(schedulerControl)
                Dim menuItemCommandAdapter As New SchedulerMenuItemCommandWinAdapter(command)
                Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(), DXMenuItem)
                menuItem.BeginGroup = True
                e.Menu.Items.Add(menuItem)
            End If
        End Sub
	End Class
End Namespace
