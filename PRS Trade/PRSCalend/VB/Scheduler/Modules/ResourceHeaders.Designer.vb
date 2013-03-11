Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class ResourceHeadersModule
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResourceHeadersModule))
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.grImageSize = New DevExpress.XtraEditors.GroupControl
            Me.lbImageSize = New DevExpress.XtraEditors.LabelControl
            Me.cbImageSize = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.cbImageSizeMode = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lbImageSizeMode = New DevExpress.XtraEditors.LabelControl
            Me.cbImageAlign = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lbImageAlign = New DevExpress.XtraEditors.LabelControl
            Me.grHeaderHeight = New DevExpress.XtraEditors.GroupControl
            Me.lbHeight = New DevExpress.XtraEditors.LabelControl
            Me.cbHeaderHeight = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.chkWordWrap = New DevExpress.XtraEditors.CheckEdit
            Me.chkRotateCaption = New DevExpress.XtraEditors.CheckEdit
            Me.cbGrouping = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblGroup = New DevExpress.XtraEditors.LabelControl
            Me.cbView = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblView = New DevExpress.XtraEditors.LabelControl
            Me.imgCars = New System.Windows.Forms.ImageList(Me.components)
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.grImageSize, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grImageSize.SuspendLayout()
            CType(Me.cbImageSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbImageSizeMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbImageAlign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grHeaderHeight.SuspendLayout()
            CType(Me.cbHeaderHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkWordWrap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkRotateCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Week
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 104)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.StretchImage
            Me.schedulerControl.Size = New System.Drawing.Size(704, 300)
            Me.schedulerControl.Start = New Date(2010, 6, 30, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.DayCount = 3
            Me.schedulerControl.Views.DayView.ResourcesPerPage = 4
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.MonthView.ResourcesPerPage = 4
            Me.schedulerControl.Views.MonthView.WeekCount = 2
            Me.schedulerControl.Views.WeekView.ResourcesPerPage = 4
            Me.schedulerControl.Views.WorkWeekView.ResourcesPerPage = 4
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.grImageSize)
            Me.panelControl.Controls.Add(Me.grHeaderHeight)
            Me.panelControl.Controls.Add(Me.cbGrouping)
            Me.panelControl.Controls.Add(Me.lblGroup)
            Me.panelControl.Controls.Add(Me.cbView)
            Me.panelControl.Controls.Add(Me.lblView)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 96)
            Me.panelControl.TabIndex = 2
            '
            'grImageSize
            '
            Me.grImageSize.Controls.Add(Me.lbImageSize)
            Me.grImageSize.Controls.Add(Me.cbImageSize)
            Me.grImageSize.Controls.Add(Me.cbImageSizeMode)
            Me.grImageSize.Controls.Add(Me.lbImageSizeMode)
            Me.grImageSize.Controls.Add(Me.cbImageAlign)
            Me.grImageSize.Controls.Add(Me.lbImageAlign)
            Me.grImageSize.Location = New System.Drawing.Point(345, 11)
            Me.grImageSize.Name = "grImageSize"
            Me.grImageSize.Size = New System.Drawing.Size(319, 75)
            Me.grImageSize.TabIndex = 4
            Me.grImageSize.Text = "Image"
            '
            'lbImageSize
            '
            Me.lbImageSize.Location = New System.Drawing.Point(142, 26)
            Me.lbImageSize.Name = "lbImageSize"
            Me.lbImageSize.Size = New System.Drawing.Size(23, 13)
            Me.lbImageSize.TabIndex = 64
            Me.lbImageSize.Text = "Size:"
            '
            'cbImageSize
            '
            Me.cbImageSize.EditValue = ""
            Me.cbImageSize.Location = New System.Drawing.Point(200, 23)
            Me.cbImageSize.Name = "cbImageSize"
            Me.cbImageSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbImageSize.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Automatic", New System.Drawing.Size(0, 0), -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("25x25", New System.Drawing.Size(25, 25), -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("50x50", New System.Drawing.Size(50, 50), -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("100x100", New System.Drawing.Size(100, 100), -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("200x200", New System.Drawing.Size(200, 200), -1)})
            Me.cbImageSize.Size = New System.Drawing.Size(112, 19)
            Me.cbImageSize.TabIndex = 63
            '
            'cbImageSizeMode
            '
            Me.cbImageSizeMode.EditValue = ""
            Me.cbImageSizeMode.Location = New System.Drawing.Point(200, 48)
            Me.cbImageSizeMode.Name = "cbImageSizeMode"
            Me.cbImageSizeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbImageSizeMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", DevExpress.XtraScheduler.HeaderImageSizeMode.Normal, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("CenterImage", DevExpress.XtraScheduler.HeaderImageSizeMode.CenterImage, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("StretchImage", DevExpress.XtraScheduler.HeaderImageSizeMode.StretchImage, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("ZoomImage", DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage, -1)})
            Me.cbImageSizeMode.Size = New System.Drawing.Size(112, 19)
            Me.cbImageSizeMode.TabIndex = 4
            '
            'lbImageSizeMode
            '
            Me.lbImageSizeMode.Location = New System.Drawing.Point(142, 51)
            Me.lbImageSizeMode.Name = "lbImageSizeMode"
            Me.lbImageSizeMode.Size = New System.Drawing.Size(52, 13)
            Me.lbImageSizeMode.TabIndex = 62
            Me.lbImageSizeMode.Text = "Size Mode:"
            '
            'cbImageAlign
            '
            Me.cbImageAlign.EditValue = ""
            Me.cbImageAlign.Location = New System.Drawing.Point(8, 48)
            Me.cbImageAlign.Name = "cbImageAlign"
            Me.cbImageAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbImageAlign.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Left", DevExpress.XtraScheduler.HeaderImageAlign.Left, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Top", DevExpress.XtraScheduler.HeaderImageAlign.Top, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Right", DevExpress.XtraScheduler.HeaderImageAlign.Right, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bottom", DevExpress.XtraScheduler.HeaderImageAlign.Bottom, -1)})
            Me.cbImageAlign.Size = New System.Drawing.Size(112, 19)
            Me.cbImageAlign.TabIndex = 0
            '
            'lbImageAlign
            '
            Me.lbImageAlign.Location = New System.Drawing.Point(8, 26)
            Me.lbImageAlign.Name = "lbImageAlign"
            Me.lbImageAlign.Size = New System.Drawing.Size(51, 13)
            Me.lbImageAlign.TabIndex = 61
            Me.lbImageAlign.Text = "Alignment:"
            '
            'grHeaderHeight
            '
            Me.grHeaderHeight.Controls.Add(Me.lbHeight)
            Me.grHeaderHeight.Controls.Add(Me.cbHeaderHeight)
            Me.grHeaderHeight.Controls.Add(Me.chkWordWrap)
            Me.grHeaderHeight.Controls.Add(Me.chkRotateCaption)
            Me.grHeaderHeight.Location = New System.Drawing.Point(144, 11)
            Me.grHeaderHeight.Name = "grHeaderHeight"
            Me.grHeaderHeight.Size = New System.Drawing.Size(192, 75)
            Me.grHeaderHeight.TabIndex = 3
            Me.grHeaderHeight.Text = "Header"
            '
            'lbHeight
            '
            Me.lbHeight.Location = New System.Drawing.Point(10, 26)
            Me.lbHeight.Name = "lbHeight"
            Me.lbHeight.Size = New System.Drawing.Size(35, 13)
            Me.lbHeight.TabIndex = 62
            Me.lbHeight.Text = "Height:"
            '
            'cbHeaderHeight
            '
            Me.cbHeaderHeight.EditValue = ""
            Me.cbHeaderHeight.Location = New System.Drawing.Point(51, 23)
            Me.cbHeaderHeight.Name = "cbHeaderHeight"
            Me.cbHeaderHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbHeaderHeight.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Automatic", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("30", 20, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("50", 50, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("100", 100, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("200", 200, -1)})
            Me.cbHeaderHeight.Size = New System.Drawing.Size(136, 19)
            Me.cbHeaderHeight.TabIndex = 4
            '
            'chkWordWrap
            '
            Me.chkWordWrap.Location = New System.Drawing.Point(112, 48)
            Me.chkWordWrap.Name = "chkWordWrap"
            Me.chkWordWrap.Properties.Caption = "Word Wrap"
            Me.chkWordWrap.Size = New System.Drawing.Size(80, 19)
            Me.chkWordWrap.TabIndex = 3
            '
            'chkRotateCaption
            '
            Me.chkRotateCaption.Location = New System.Drawing.Point(8, 48)
            Me.chkRotateCaption.Name = "chkRotateCaption"
            Me.chkRotateCaption.Properties.Caption = "Rotate Caption"
            Me.chkRotateCaption.Size = New System.Drawing.Size(96, 19)
            Me.chkRotateCaption.TabIndex = 2
            '
            'cbGrouping
            '
            Me.cbGrouping.EditValue = ""
            Me.cbGrouping.Location = New System.Drawing.Point(16, 67)
            Me.cbGrouping.Name = "cbGrouping"
            Me.cbGrouping.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbGrouping.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Date", DevExpress.XtraScheduler.SchedulerGroupType.[Date], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Resource", DevExpress.XtraScheduler.SchedulerGroupType.Resource, -1)})
            Me.cbGrouping.Size = New System.Drawing.Size(112, 19)
            Me.cbGrouping.TabIndex = 1
            '
            'lblGroup
            '
            Me.lblGroup.Location = New System.Drawing.Point(16, 51)
            Me.lblGroup.Name = "lblGroup"
            Me.lblGroup.Size = New System.Drawing.Size(48, 13)
            Me.lblGroup.TabIndex = 36
            Me.lblGroup.Text = "Group By:"
            '
            'cbView
            '
            Me.cbView.EditValue = ""
            Me.cbView.Location = New System.Drawing.Point(16, 26)
            Me.cbView.Name = "cbView"
            Me.cbView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Day View", DevExpress.XtraScheduler.SchedulerViewType.Day, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Work Week View", DevExpress.XtraScheduler.SchedulerViewType.WorkWeek, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Week View", DevExpress.XtraScheduler.SchedulerViewType.Week, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Month View", DevExpress.XtraScheduler.SchedulerViewType.Month, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Timeline View", DevExpress.XtraScheduler.SchedulerViewType.Timeline, -1)})
            Me.cbView.Size = New System.Drawing.Size(112, 19)
            Me.cbView.TabIndex = 0
            '
            'lblView
            '
            Me.lblView.Location = New System.Drawing.Point(16, 11)
            Me.lblView.Name = "lblView"
            Me.lblView.Size = New System.Drawing.Size(30, 13)
            Me.lblView.TabIndex = 34
            Me.lblView.Text = "Show:"
            '
            'imgCars
            '
            Me.imgCars.ImageStream = CType(resources.GetObject("imgCars.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgCars.TransparentColor = System.Drawing.Color.Magenta
            Me.imgCars.Images.SetKeyName(0, "")
            Me.imgCars.Images.SetKeyName(1, "")
            Me.imgCars.Images.SetKeyName(2, "")
            Me.imgCars.Images.SetKeyName(3, "")
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 96)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'ResourceHeadersModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "ResourceHeadersModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.grImageSize, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grImageSize.ResumeLayout(False)
            Me.grImageSize.PerformLayout()
            CType(Me.cbImageSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbImageSizeMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbImageAlign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grHeaderHeight.ResumeLayout(False)
            Me.grHeaderHeight.PerformLayout()
            CType(Me.cbHeaderHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkWordWrap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkRotateCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbGrouping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private WithEvents cbGrouping As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbView As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblView As DevExpress.XtraEditors.LabelControl
		Private imgCars As System.Windows.Forms.ImageList
		Private grHeaderHeight As DevExpress.XtraEditors.GroupControl
		Private grImageSize As DevExpress.XtraEditors.GroupControl
		Private WithEvents cbImageSizeMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lbImageSizeMode As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbImageAlign As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lbImageAlign As DevExpress.XtraEditors.LabelControl
		Private WithEvents chkRotateCaption As DevExpress.XtraEditors.CheckEdit
		Private WithEvents chkWordWrap As DevExpress.XtraEditors.CheckEdit
        Private lbHeight As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbHeaderHeight As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lbImageSize As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbImageSize As DevExpress.XtraEditors.ImageComboBoxEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
