Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Native
Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class RangeControlModule
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
            Dim RangeControlRange1 As DevExpress.XtraEditors.RangeControlRange = New DevExpress.XtraEditors.RangeControlRange
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.lblThumbnailHeight = New DevExpress.XtraEditors.LabelControl
            Me.spinThumbnailHeight = New DevExpress.XtraEditors.SpinEdit
            Me.rgrpSchedulerType = New DevExpress.XtraEditors.RadioGroup
            Me.lblMaxIntervalCount = New DevExpress.XtraEditors.LabelControl
            Me.spinMaxIntervalCount = New DevExpress.XtraEditors.SpinEdit
            Me.chkAutoFormatCaptions = New DevExpress.XtraEditors.CheckEdit
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.cbThumbnailDisplay = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.chkAllowChangeActiveView = New DevExpress.XtraEditors.CheckEdit
            Me.lbSchedulerType = New DevExpress.XtraEditors.LabelControl
            Me.rangeControl = New DevExpress.XtraEditors.RangeControl
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.spinThumbnailHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rgrpSchedulerType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinMaxIntervalCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAutoFormatCaptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbThumbnailDisplay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAllowChangeActiveView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.lblThumbnailHeight)
            Me.panelControl.Controls.Add(Me.spinThumbnailHeight)
            Me.panelControl.Controls.Add(Me.rgrpSchedulerType)
            Me.panelControl.Controls.Add(Me.lblMaxIntervalCount)
            Me.panelControl.Controls.Add(Me.spinMaxIntervalCount)
            Me.panelControl.Controls.Add(Me.chkAutoFormatCaptions)
            Me.panelControl.Controls.Add(Me.labelControl1)
            Me.panelControl.Controls.Add(Me.cbThumbnailDisplay)
            Me.panelControl.Controls.Add(Me.chkAllowChangeActiveView)
            Me.panelControl.Controls.Add(Me.lbSchedulerType)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 91)
            Me.panelControl.TabIndex = 94
            '
            'lblThumbnailHeight
            '
            Me.lblThumbnailHeight.Location = New System.Drawing.Point(434, 39)
            Me.lblThumbnailHeight.Name = "lblThumbnailHeight"
            Me.lblThumbnailHeight.Size = New System.Drawing.Size(86, 13)
            Me.lblThumbnailHeight.TabIndex = 103
            Me.lblThumbnailHeight.Text = "Thumbnail Height:"
            '
            'spinThumbnailHeight
            '
            Me.spinThumbnailHeight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinThumbnailHeight.Location = New System.Drawing.Point(581, 36)
            Me.spinThumbnailHeight.Name = "spinThumbnailHeight"
            Me.spinThumbnailHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinThumbnailHeight.Properties.Increment = New Decimal(New Integer() {2, 0, 0, 0})
            Me.spinThumbnailHeight.Properties.IsFloatValue = False
            Me.spinThumbnailHeight.Properties.Mask.EditMask = "N00"
            Me.spinThumbnailHeight.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinThumbnailHeight.Size = New System.Drawing.Size(116, 20)
            Me.spinThumbnailHeight.TabIndex = 4
            '
            'rgrpSchedulerType
            '
            Me.rgrpSchedulerType.EditValue = 0
            Me.rgrpSchedulerType.Location = New System.Drawing.Point(16, 32)
            Me.rgrpSchedulerType.Name = "rgrpSchedulerType"
            Me.rgrpSchedulerType.Properties.Columns = 3
            Me.rgrpSchedulerType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Daily"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Monthly"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Yearly")})
            Me.rgrpSchedulerType.Size = New System.Drawing.Size(194, 23)
            Me.rgrpSchedulerType.TabIndex = 101
            '
            'lblMaxIntervalCount
            '
            Me.lblMaxIntervalCount.Location = New System.Drawing.Point(434, 65)
            Me.lblMaxIntervalCount.Name = "lblMaxIntervalCount"
            Me.lblMaxIntervalCount.Size = New System.Drawing.Size(141, 13)
            Me.lblMaxIntervalCount.TabIndex = 100
            Me.lblMaxIntervalCount.Text = "Max Selected Interval Count:"
            '
            'spinMaxIntervalCount
            '
            Me.spinMaxIntervalCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinMaxIntervalCount.Location = New System.Drawing.Point(581, 62)
            Me.spinMaxIntervalCount.Name = "spinMaxIntervalCount"
            Me.spinMaxIntervalCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinMaxIntervalCount.Properties.IsFloatValue = False
            Me.spinMaxIntervalCount.Properties.Mask.EditMask = "N00"
            Me.spinMaxIntervalCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinMaxIntervalCount.Size = New System.Drawing.Size(116, 20)
            Me.spinMaxIntervalCount.TabIndex = 5
            '
            'chkAutoFormatCaptions
            '
            Me.chkAutoFormatCaptions.Location = New System.Drawing.Point(230, 36)
            Me.chkAutoFormatCaptions.Name = "chkAutoFormatCaptions"
            Me.chkAutoFormatCaptions.Properties.Caption = "Auto Format Captions"
            Me.chkAutoFormatCaptions.Size = New System.Drawing.Size(135, 19)
            Me.chkAutoFormatCaptions.TabIndex = 2
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(434, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(122, 13)
            Me.labelControl1.TabIndex = 98
            Me.labelControl1.Text = "Display Appointments As:"
            '
            'cbThumbnailDisplay
            '
            Me.cbThumbnailDisplay.EditValue = ""
            Me.cbThumbnailDisplay.Location = New System.Drawing.Point(581, 9)
            Me.cbThumbnailDisplay.Name = "cbThumbnailDisplay"
            Me.cbThumbnailDisplay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbThumbnailDisplay.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.RangeControlDataDisplayType.[Auto], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Thumbnail", DevExpress.XtraScheduler.RangeControlDataDisplayType.Thumbnail, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Number", DevExpress.XtraScheduler.RangeControlDataDisplayType.Number, -1)})
            Me.cbThumbnailDisplay.Size = New System.Drawing.Size(116, 20)
            Me.cbThumbnailDisplay.TabIndex = 3
            '
            'chkAllowChangeActiveView
            '
            Me.chkAllowChangeActiveView.Location = New System.Drawing.Point(230, 11)
            Me.chkAllowChangeActiveView.Name = "chkAllowChangeActiveView"
            Me.chkAllowChangeActiveView.Properties.Caption = "Auto Change Scheduler View"
            Me.chkAllowChangeActiveView.Size = New System.Drawing.Size(188, 19)
            Me.chkAllowChangeActiveView.TabIndex = 1
            '
            'lbSchedulerType
            '
            Me.lbSchedulerType.Location = New System.Drawing.Point(16, 13)
            Me.lbSchedulerType.Name = "lbSchedulerType"
            Me.lbSchedulerType.Size = New System.Drawing.Size(70, 13)
            Me.lbSchedulerType.TabIndex = 95
            Me.lbSchedulerType.Text = "Schedule Type"
            '
            'rangeControl
            '
            Me.rangeControl.Client = Me.schedulerControl
            Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.rangeControl.Location = New System.Drawing.Point(0, 91)
            Me.rangeControl.MinimumSize = New System.Drawing.Size(100, 140)
            Me.rangeControl.Name = "rangeControl"
            RangeControlRange1.Maximum = New Date(2012, 4, 2, 0, 0, 0, 0)
            RangeControlRange1.Minimum = New Date(2012, 4, 1, 0, 0, 0, 0)
            Me.rangeControl.SelectedRange = RangeControlRange1
            Me.rangeControl.Size = New System.Drawing.Size(704, 140)
            Me.rangeControl.TabIndex = 5
            Me.rangeControl.Text = "rangeControl"
            Me.rangeControl.VisibleRangeMaximumScaleFactor = Double.PositiveInfinity
            Me.rangeControl.VisibleRangeScaleFactor = 6.5
            '
            'schedulerControl
            '
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.LimitInterval.Duration = System.TimeSpan.Parse("364.00:00:00")
            Me.schedulerControl.LimitInterval.Start = New Date(2010, 1, 1, 0, 0, 0, 0)
            Me.schedulerControl.Location = New System.Drawing.Point(0, 236)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.OptionsRangeControl.AutoAdjustMode = False
            Me.schedulerControl.Size = New System.Drawing.Size(704, 168)
            Me.schedulerControl.Start = New Date(2010, 12, 16, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 6
            Me.schedulerControl.Text = "schedulerControl"
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.GanttView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'splitterControl1
            '
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitterControl1.Location = New System.Drawing.Point(0, 231)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(704, 5)
            Me.splitterControl1.TabIndex = 95
            Me.splitterControl1.TabStop = False
            '
            'RangeControlModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.rangeControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "RangeControlModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.spinThumbnailHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rgrpSchedulerType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinMaxIntervalCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAutoFormatCaptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbThumbnailDisplay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAllowChangeActiveView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl As DevExpress.XtraEditors.PanelControl
		Private lbSchedulerType As DevExpress.XtraEditors.LabelControl
		Private rangeControl As DevExpress.XtraEditors.RangeControl
		Private schedulerControl As SchedulerControl
		Private WithEvents chkAllowChangeActiveView As DevExpress.XtraEditors.CheckEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents cbThumbnailDisplay As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents chkAutoFormatCaptions As DevExpress.XtraEditors.CheckEdit
		Private lblMaxIntervalCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinMaxIntervalCount As DevExpress.XtraEditors.SpinEdit
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents rgrpSchedulerType As DevExpress.XtraEditors.RadioGroup
		Private lblThumbnailHeight As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinThumbnailHeight As DevExpress.XtraEditors.SpinEdit

	End Class
End Namespace
