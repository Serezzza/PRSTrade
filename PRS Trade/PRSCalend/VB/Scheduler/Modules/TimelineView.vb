Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
    Partial Public Class TimelineViewModule
        Inherits DevExpress.XtraScheduler.Demos.TutorialControl
        Dim fLoaded As Boolean

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            PrepareViews()
        End Sub
        Public Overrides ReadOnly Property PrintingSchedulerControl() As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property
        Protected ReadOnly Property DisplayOptions() As AppointmentDisplayOptions
            Get
                Return schedulerControl.TimelineView.AppointmentDisplayOptions
            End Get
        End Property

        Private Sub PrepareViews()
            schedulerControl.DayView.Enabled = False
            schedulerControl.WeekView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
        End Sub

        Private Sub TimelineViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DemoUtils.FillData(schedulerControl)
            UpdateControls()
            fLoaded = True
        End Sub
        Private Sub schedulerControl_PreparePopupMenu(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles schedulerControl.PopupMenuShowing
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub
        Private Sub TimelineViewModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
            schedulerControl.ActiveViewType = SchedulerViewType.Timeline
        End Sub
        Private Sub UpdateControls()
            Dim options As AppointmentDisplayOptions = DisplayOptions
            chkAutoHeight.Checked = options.AppointmentAutoHeight
            spinHeight.Value = options.AppointmentHeight
            cbSnapToCellsMode.EditValue = options.SnapToCellsMode
            cbStatus.EditValue = options.StatusDisplayType
            chkSelectionBarVisible.Checked = schedulerControl.TimelineView.SelectionBar.Visible
            spinSelectionBarHeight.Value = schedulerControl.TimelineView.SelectionBar.Height
            UpdateTimeScaleWidthTrackBar()
        End Sub

        Private Sub UpdateTimeScaleWidthTrackBar()
            schedulerControl.TimelineView.GetBaseTimeScale().Width = trckScaleWidth.Value
            trckScaleWidth.Enabled = schedulerControl.TimelineView.Scales.Count > 0
        End Sub

        Private Sub chkSelectionBarVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSelectionBarVisible.CheckedChanged
            schedulerControl.TimelineView.SelectionBar.Visible = chkSelectionBarVisible.Checked
        End Sub
        Private Sub spinSelectionBarHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinSelectionBarHeight.EditValueChanged
            schedulerControl.TimelineView.SelectionBar.Height = Convert.ToInt32(spinSelectionBarHeight.Value)
        End Sub
        Private Sub btnEditScales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditScales.Click
            EditTimeScales(schedulerControl.TimelineView.Scales)
            UpdateTimeScaleWidthTrackBar()
        End Sub
        Private Sub EditTimeScales(ByVal scales As TimeScaleCollection)
            Dim frm As TimeScalesEditForm = New TimeScalesEditForm(scales, Me.FindForm())
            frm.ShowDialog()
        End Sub

        Private Sub chkAutoHeight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAutoHeight.CheckedChanged
            If fLoaded Then
                DisplayOptions.AppointmentAutoHeight = chkAutoHeight.Checked
            End If
        End Sub

        Private Sub spinHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinHeight.EditValueChanged
            If fLoaded Then
                DisplayOptions.AppointmentHeight = Convert.ToInt32(spinHeight.Value)
            End If
        End Sub

        Private Sub cbStatus_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStatus.EditValueChanged
            If fLoaded Then
                DisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
            End If
        End Sub

        Private Sub cbSnapToCellsMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSnapToCellsMode.SelectedIndexChanged
            If fLoaded Then
                DisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
            End If
        End Sub

    Private Sub trckScaleWidth_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trckScaleWidth.EditValueChanged
        If fLoaded Then
            schedulerControl.TimelineView.GetBaseTimeScale().Width = trckScaleWidth.Value
        End If

    End Sub
    End Class
End Namespace
