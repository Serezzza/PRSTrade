Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class GroupByDateModule
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

		Private Sub GroupByDateModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DemoUtils.FillData(schedulerControl)
			UpdateControls()
		End Sub

		Private Sub UpdateControls()
			rgrpView.EditValue = schedulerControl.ActiveViewType
		End Sub
		Private Sub rgrpView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgrpView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(rgrpView.EditValue, SchedulerViewType)
        End Sub
        Private Sub GroupByDateModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
            If Visible Then
                UpdateCaption()
            End If
        End Sub

        Private Sub UpdateCaption()
            Caption.Text = String.Format("Grouping {0}", TutorialName)
        End Sub

        Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
            rgrpView.EditValue = schedulerControl.ActiveViewType
        End Sub
	End Class
End Namespace

