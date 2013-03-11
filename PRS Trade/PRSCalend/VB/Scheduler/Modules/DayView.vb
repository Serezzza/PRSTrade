Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace DevExpress.XtraScheduler.Demos
    Partial Public Class DayViewModule
        Inherits DevExpress.XtraScheduler.Demos.TutorialControl
        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            PrepareViews()

            ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property
        Protected ReadOnly Property DisplayOptions() As DayViewAppointmentDisplayOptions
            Get
                Return CType(schedulerControl.DayView.AppointmentDisplayOptions, DayViewAppointmentDisplayOptions)
            End Get
        End Property

        Private Sub PrepareViews()
            schedulerControl.WeekView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
        End Sub
        Private Sub DayViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DemoUtils.FillData(schedulerControl)
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            chkShowWorkTimeOnly.Checked = schedulerControl.DayView.ShowWorkTimeOnly
            chkShowAllDayArea.Checked = schedulerControl.DayView.ShowAllDayArea
            chkShowDayHeaders.Checked = schedulerControl.DayView.ShowDayHeaders
            chkAppointmentShadows.Checked = DisplayOptions.ShowShadows

            spinDaysCount.EditValue = schedulerControl.DayView.DayCount

            cbAllDayStatus.EditValue = DisplayOptions.AllDayAppointmentsStatusDisplayType
            cbStatus.EditValue = DisplayOptions.StatusDisplayType
            cbSnapToCellsMode.EditValue = DisplayOptions.SnapToCellsMode
        End Sub
        Private Sub chkShowWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowWorkTimeOnly.CheckedChanged
            schedulerControl.DayView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
        End Sub

        Private Sub chkShowAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowAllDayArea.CheckedChanged
            schedulerControl.DayView.ShowAllDayArea = chkShowAllDayArea.Checked
        End Sub

        Private Sub chkShowDayHeaders_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowDayHeaders.CheckedChanged
            schedulerControl.DayView.ShowDayHeaders = chkShowDayHeaders.Checked
        End Sub

        Private Sub chkAppointmentShadows_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAppointmentShadows.CheckedChanged
            schedulerControl.DayView.AppointmentDisplayOptions.ShowShadows = chkAppointmentShadows.Checked
        End Sub

        Private Sub spinDaysCount_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinDaysCount.EditValueChanged
            schedulerControl.DayView.DayCount = Convert.ToInt32(spinDaysCount.EditValue)
        End Sub

        Private Sub schedulerControl_PreparePopupMenu(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub
        Private Sub DayViewModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
            schedulerControl.ActiveViewType = SchedulerViewType.Day
        End Sub

        Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.SelectedIndexChanged
            DisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbAllDayStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAllDayStatus.SelectedIndexChanged
            DisplayOptions.AllDayAppointmentsStatusDisplayType = CType(cbAllDayStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbSnapToCells_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSnapToCellsMode.SelectedIndexChanged
            DisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
        End Sub
    End Class
End Namespace

