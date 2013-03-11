Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing



Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class ResourceHeadersModule
        Inherits DevExpress.XtraScheduler.Demos.TutorialControl
        Dim fLoaded As Boolean
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

		Protected ReadOnly Property ResourceHeaderOptions() As SchedulerResourceHeaderOptions
			Get
				Return schedulerControl.OptionsView.ResourceHeaders
			End Get
		End Property

		Private Sub GroupByResourceModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitControlValues()
			DemoUtils.FillData(schedulerControl)
            CreateResources()
            fLoaded = True
		End Sub
		Private Sub InitControlValues()
			cbView.EditValue = schedulerControl.ActiveViewType
			cbGrouping.EditValue = schedulerControl.GroupType
			cbHeaderHeight.EditValue = ResourceHeaderOptions.Height
			cbImageSize.EditValue = ResourceHeaderOptions.ImageSize
			cbImageAlign.EditValue = ResourceHeaderOptions.ImageAlign
			cbImageSizeMode.EditValue = ResourceHeaderOptions.ImageSizeMode
			chkRotateCaption.Checked = ResourceHeaderOptions.RotateCaption
			chkWordWrap.Checked = schedulerControl.Appearance.HeaderCaption.TextOptions.WordWrap = WordWrap.Wrap
		End Sub
		Private Sub CreateResources()
			schedulerStorage.Resources.Clear()

            Dim r As Resource = schedulerStorage.CreateResource(1)
            r.Caption = "Aston Martin"
			r.Image = Me.imgCars.Images(0)
			schedulerStorage.Resources.Add(r)

            r = schedulerStorage.CreateResource(2)
            r.Caption = "Audi TT"
			r.Image = Me.imgCars.Images(1)
			schedulerStorage.Resources.Add(r)

            r = schedulerStorage.CreateResource(3)
            r.Caption = "Jaguar XK"
			r.Image = Me.imgCars.Images(2)
			schedulerStorage.Resources.Add(r)

            r = schedulerStorage.CreateResource(4)
            r.Caption = "Porsche Boxter"
			r.Image = Me.imgCars.Images(3)
			schedulerStorage.Resources.Add(r)
		End Sub

		Private Sub cbGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGrouping.SelectedIndexChanged
			schedulerControl.GroupType = CType(cbGrouping.EditValue, SchedulerGroupType)
			UpdateControls()
		End Sub

		Private Sub cbView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbView.SelectedIndexChanged
			schedulerControl.ActiveViewType = CType(cbView.EditValue, SchedulerViewType)
            UpdateControls()
		End Sub

		Private Sub chkWordWrap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkWordWrap.CheckedChanged
			Dim wrap As WordWrap
			If chkWordWrap.Checked Then
				wrap = WordWrap.Wrap
			Else
				wrap = WordWrap.Default
			End If
			schedulerControl.Appearance.HeaderCaption.TextOptions.WordWrap = wrap
		End Sub
        Private Sub cbImageSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbImageSize.SelectedIndexChanged
            If fLoaded Then
                ResourceHeaderOptions.ImageSize = CType(cbImageSize.EditValue, Size)
                cbImageSizeMode.Enabled = ResourceHeaderOptions.ImageSize <> System.Drawing.Size.Empty
            End If
        End Sub

        Private Sub cbHeaderHeight_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbHeaderHeight.EditValueChanged
            If fLoaded Then
                ResourceHeaderOptions.Height = Convert.ToInt32(cbHeaderHeight.EditValue)
            End If
        End Sub

		Private Sub schedulerControl_ActiveViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.ActiveViewChanged
			cbView.EditValue = schedulerControl.ActiveViewType
		End Sub
        Private Sub chkRotateCaption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkRotateCaption.CheckedChanged
            If fLoaded Then
                ResourceHeaderOptions.RotateCaption = chkRotateCaption.Checked
            End If
        End Sub
        Private Sub cbImageAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbImageAlign.SelectedIndexChanged
            If fLoaded Then
                ResourceHeaderOptions.ImageAlign = CType(cbImageAlign.EditValue, HeaderImageAlign)
            End If
        End Sub
        Private Sub UpdateControls()
            Dim view As SchedulerViewBase = schedulerControl.ActiveView
            Dim groupType As SchedulerGroupType = schedulerControl.GroupType
            chkRotateCaption.Enabled = (TypeOf view Is WeekView AndAlso groupType = SchedulerGroupType.Date) OrElse (TypeOf view Is TimelineView AndAlso groupType <> SchedulerGroupType.None)
        End Sub

        Private Sub cbImageSizeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbImageSizeMode.SelectedIndexChanged
            If fLoaded Then
                ResourceHeaderOptions.ImageSizeMode = CType(cbImageSizeMode.EditValue, HeaderImageSizeMode)
            End If
        End Sub
		Private Sub schedulerControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles schedulerControl.DoubleClick
			Dim pt As Point = schedulerControl.PointToClient(Control.MousePosition)
			Dim hitInfo As SchedulerHitInfo = schedulerControl.ActiveView.ViewInfo.CalcHitInfo(pt, True)
			If hitInfo.HitTest = SchedulerHitTest.ResourceHeader Then
				Dim customImage As Image = LoadCustomResourceImage()
				If Not customImage Is Nothing Then
					Dim header As ResourceHeader = CType(hitInfo.ViewInfo, ResourceHeader)
					header.Resource.Image = customImage
					schedulerControl.ActiveView.LayoutChanged()
				End If
			End If
		End Sub

		Private Function LoadCustomResourceImage() As Image
			Dim image As Image = Nothing
			Dim dlg As OpenFileDialog = New OpenFileDialog()
			dlg.Title = "Select image file"
			dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"

			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				image = LoadImageFromFile(dlg.FileName)
			End If
			Return image
		End Function

		Private Function LoadImageFromFile(ByVal fileName As String) As Image
			Dim image As Image = Nothing
			Try
                image = System.Drawing.Image.FromFile(fileName)
			Catch e As Exception
                XtraMessageBox.Show("Can't load image from file - " + e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
			Return image
		End Function

    End Class
End Namespace

