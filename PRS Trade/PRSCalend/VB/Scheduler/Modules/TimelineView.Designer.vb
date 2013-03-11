Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Public Partial Class TimelineViewModule
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
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.panelControl = New DevExpress.XtraEditors.PanelControl
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.trckScaleWidth = New DevExpress.XtraEditors.TrackBarControl
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.lblSnapToCellsMode = New DevExpress.XtraEditors.LabelControl
            Me.cbSnapToCellsMode = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.cbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit
            Me.lblStatus = New DevExpress.XtraEditors.LabelControl
            Me.lblHeight = New DevExpress.XtraEditors.LabelControl
            Me.spinHeight = New DevExpress.XtraEditors.SpinEdit
            Me.chkAutoHeight = New DevExpress.XtraEditors.CheckEdit
            Me.grSelectionBar = New DevExpress.XtraEditors.GroupControl
            Me.lblSelectionBarHeight = New DevExpress.XtraEditors.LabelControl
            Me.spinSelectionBarHeight = New DevExpress.XtraEditors.SpinEdit
            Me.chkSelectionBarVisible = New DevExpress.XtraEditors.CheckEdit
            Me.btnEditScales = New DevExpress.XtraEditors.SimpleButton
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl.SuspendLayout()
            CType(Me.trckScaleWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trckScaleWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType(Me.cbSnapToCellsMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAutoHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grSelectionBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grSelectionBar.SuspendLayout()
            CType(Me.spinSelectionBarHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkSelectionBarVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl
            '
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 96)
            Me.schedulerControl.MenuManager = Me
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(704, 308)
            Me.schedulerControl.Start = New Date(2010, 7, 4, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl.Views.TimelineView.ShowMoreButtons = False
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl.Views.GanttView.Enabled = False
            '
            'panelControl
            '
            Me.panelControl.Controls.Add(Me.labelControl1)
            Me.panelControl.Controls.Add(Me.trckScaleWidth)
            Me.panelControl.Controls.Add(Me.groupControl1)
            Me.panelControl.Controls.Add(Me.grSelectionBar)
            Me.panelControl.Controls.Add(Me.btnEditScales)
            Me.panelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl.Location = New System.Drawing.Point(0, 0)
            Me.panelControl.Name = "panelControl"
            Me.panelControl.Size = New System.Drawing.Size(704, 88)
            Me.panelControl.TabIndex = 2
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(501, 16)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(60, 13)
            Me.labelControl1.TabIndex = 80
            Me.labelControl1.Text = "Scale Width:"
            '
            'trckScaleWidth
            '
            Me.trckScaleWidth.EditValue = 80
            Me.trckScaleWidth.Location = New System.Drawing.Point(567, 6)
            Me.trckScaleWidth.MenuManager = Me
            Me.trckScaleWidth.Name = "trckScaleWidth"
            Me.trckScaleWidth.Properties.LargeChange = 50
            Me.trckScaleWidth.Properties.Maximum = 200
            Me.trckScaleWidth.Properties.Minimum = 20
            Me.trckScaleWidth.Properties.ShowValueToolTip = True
            Me.trckScaleWidth.Properties.SmallChange = 20
            Me.trckScaleWidth.Properties.TickFrequency = 20
            Me.trckScaleWidth.Size = New System.Drawing.Size(119, 45)
            Me.trckScaleWidth.TabIndex = 79
            Me.trckScaleWidth.Value = 80
            '
            'groupControl1
            '
            Me.groupControl1.Controls.Add(Me.lblSnapToCellsMode)
            Me.groupControl1.Controls.Add(Me.cbSnapToCellsMode)
            Me.groupControl1.Controls.Add(Me.cbStatus)
            Me.groupControl1.Controls.Add(Me.lblStatus)
            Me.groupControl1.Controls.Add(Me.lblHeight)
            Me.groupControl1.Controls.Add(Me.spinHeight)
            Me.groupControl1.Controls.Add(Me.chkAutoHeight)
            Me.groupControl1.Location = New System.Drawing.Point(5, 8)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(355, 75)
            Me.groupControl1.TabIndex = 76
            Me.groupControl1.Text = "Appointments"
            '
            'lblSnapToCellsMode
            '
            Me.lblSnapToCellsMode.Location = New System.Drawing.Point(161, 26)
            Me.lblSnapToCellsMode.Name = "lblSnapToCellsMode"
            Me.lblSnapToCellsMode.Size = New System.Drawing.Size(97, 13)
            Me.lblSnapToCellsMode.TabIndex = 82
            Me.lblSnapToCellsMode.Text = "Snap To Cells Mode:"
            '
            'cbSnapToCellsMode
            '
            Me.cbSnapToCellsMode.Location = New System.Drawing.Point(264, 23)
            Me.cbSnapToCellsMode.Name = "cbSnapToCellsMode"
            Me.cbSnapToCellsMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbSnapToCellsMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Auto", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.[Auto], -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Always", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Always, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentSnapToCellsMode.Never, -1)})
            Me.cbSnapToCellsMode.Size = New System.Drawing.Size(80, 20)
            Me.cbSnapToCellsMode.TabIndex = 81
            '
            'cbStatus
            '
            Me.cbStatus.EditValue = ""
            Me.cbStatus.Location = New System.Drawing.Point(53, 23)
            Me.cbStatus.Name = "cbStatus"
            Me.cbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbStatus.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Never", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Time, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bounds", DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds, -1)})
            Me.cbStatus.Size = New System.Drawing.Size(80, 20)
            Me.cbStatus.TabIndex = 80
            '
            'lblStatus
            '
            Me.lblStatus.Location = New System.Drawing.Point(12, 26)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(35, 13)
            Me.lblStatus.TabIndex = 79
            Me.lblStatus.Text = "Status:"
            '
            'lblHeight
            '
            Me.lblHeight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblHeight.Location = New System.Drawing.Point(12, 53)
            Me.lblHeight.Name = "lblHeight"
            Me.lblHeight.Size = New System.Drawing.Size(35, 13)
            Me.lblHeight.TabIndex = 78
            Me.lblHeight.Text = "Height:"
            '
            'spinHeight
            '
            Me.spinHeight.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinHeight.Location = New System.Drawing.Point(53, 50)
            Me.spinHeight.Name = "spinHeight"
            Me.spinHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinHeight.Properties.IsFloatValue = False
            Me.spinHeight.Properties.Mask.EditMask = "N00"
            Me.spinHeight.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinHeight.Size = New System.Drawing.Size(80, 20)
            Me.spinHeight.TabIndex = 77
            '
            'chkAutoHeight
            '
            Me.chkAutoHeight.Location = New System.Drawing.Point(159, 50)
            Me.chkAutoHeight.Name = "chkAutoHeight"
            Me.chkAutoHeight.Properties.Caption = "AutoHeight"
            Me.chkAutoHeight.Size = New System.Drawing.Size(80, 19)
            Me.chkAutoHeight.TabIndex = 76
            '
            'grSelectionBar
            '
            Me.grSelectionBar.Controls.Add(Me.lblSelectionBarHeight)
            Me.grSelectionBar.Controls.Add(Me.spinSelectionBarHeight)
            Me.grSelectionBar.Controls.Add(Me.chkSelectionBarVisible)
            Me.grSelectionBar.Location = New System.Drawing.Point(364, 8)
            Me.grSelectionBar.Name = "grSelectionBar"
            Me.grSelectionBar.Size = New System.Drawing.Size(126, 75)
            Me.grSelectionBar.TabIndex = 75
            Me.grSelectionBar.Text = "Selection Bar"
            '
            'lblSelectionBarHeight
            '
            Me.lblSelectionBarHeight.Location = New System.Drawing.Point(7, 26)
            Me.lblSelectionBarHeight.Name = "lblSelectionBarHeight"
            Me.lblSelectionBarHeight.Size = New System.Drawing.Size(35, 13)
            Me.lblSelectionBarHeight.TabIndex = 70
            Me.lblSelectionBarHeight.Text = "Height:"
            '
            'spinSelectionBarHeight
            '
            Me.spinSelectionBarHeight.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinSelectionBarHeight.Location = New System.Drawing.Point(48, 23)
            Me.spinSelectionBarHeight.Name = "spinSelectionBarHeight"
            Me.spinSelectionBarHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinSelectionBarHeight.Properties.IsFloatValue = False
            Me.spinSelectionBarHeight.Properties.Mask.EditMask = "N00"
            Me.spinSelectionBarHeight.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinSelectionBarHeight.Size = New System.Drawing.Size(73, 20)
            Me.spinSelectionBarHeight.TabIndex = 69
            '
            'chkSelectionBarVisible
            '
            Me.chkSelectionBarVisible.Location = New System.Drawing.Point(5, 50)
            Me.chkSelectionBarVisible.Name = "chkSelectionBarVisible"
            Me.chkSelectionBarVisible.Properties.Caption = "Visible"
            Me.chkSelectionBarVisible.Size = New System.Drawing.Size(51, 19)
            Me.chkSelectionBarVisible.TabIndex = 68
            '
            'btnEditScales
            '
            Me.btnEditScales.ImageIndex = 2
            Me.btnEditScales.Location = New System.Drawing.Point(496, 59)
            Me.btnEditScales.Name = "btnEditScales"
            Me.btnEditScales.Size = New System.Drawing.Size(185, 24)
            Me.btnEditScales.TabIndex = 28
            Me.btnEditScales.Text = "Edit Time&Scales..."
            '
            'panelSeparatorControl
            '
            Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 88)
            Me.panelSeparatorControl.Name = "panelSeparatorControl"
            Me.panelSeparatorControl.Size = New System.Drawing.Size(704, 8)
            Me.panelSeparatorControl.TabIndex = 10
            '
            'TimelineViewModule
            '
            Me.Controls.Add(Me.schedulerControl)
            Me.Controls.Add(Me.panelSeparatorControl)
            Me.Controls.Add(Me.panelControl)
            Me.Name = "TimelineViewModule"
            Me.Size = New System.Drawing.Size(704, 404)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl.ResumeLayout(False)
            Me.panelControl.PerformLayout()
            CType(Me.trckScaleWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trckScaleWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType(Me.cbSnapToCellsMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAutoHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grSelectionBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grSelectionBar.ResumeLayout(False)
            Me.grSelectionBar.PerformLayout()
            CType(Me.spinSelectionBarHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkSelectionBarVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private panelControl As DevExpress.XtraEditors.PanelControl
        Private WithEvents btnEditScales As DevExpress.XtraEditors.SimpleButton
        Private groupControl1 As DevExpress.XtraEditors.GroupControl
        Private lblHeight As DevExpress.XtraEditors.LabelControl
        Private WithEvents spinHeight As DevExpress.XtraEditors.SpinEdit
        Private WithEvents chkAutoHeight As DevExpress.XtraEditors.CheckEdit
        Private grSelectionBar As DevExpress.XtraEditors.GroupControl
        Private lblSelectionBarHeight As DevExpress.XtraEditors.LabelControl
        Private WithEvents spinSelectionBarHeight As DevExpress.XtraEditors.SpinEdit
        Private WithEvents chkSelectionBarVisible As DevExpress.XtraEditors.CheckEdit
        Private WithEvents cbStatus As DevExpress.XtraEditors.ImageComboBoxEdit
        Private lblStatus As DevExpress.XtraEditors.LabelControl
        Private components As System.ComponentModel.IContainer = Nothing
        Friend WithEvents cbSnapToCellsMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Friend WithEvents lblSnapToCellsMode As DevExpress.XtraEditors.LabelControl
        Private WithEvents panelSeparatorControl As DevExpress.XtraEditors.PanelControl
        Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents trckScaleWidth As DevExpress.XtraEditors.TrackBarControl
	End Class
End Namespace
