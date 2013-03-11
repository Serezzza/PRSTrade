Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports System.Windows.Forms
Imports System.IO

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

	Public Class PreviewControl
		Inherits ReportPreviewControlBase
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents rgrpView As DevExpress.XtraEditors.RadioGroup
		Private monthReport_Renamed As MonthReport
		Private WithEvents spinHeight As DevExpress.XtraEditors.SpinEdit
		Private lblHeight As DevExpress.XtraEditors.LabelControl
		Protected WithEvents chkCanGrow As DevExpress.XtraEditors.CheckEdit
		Protected WithEvents chkCanShrink As DevExpress.XtraEditors.CheckEdit
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private timelineReport_Renamed As TimelineReport


		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			printControl.Zoom = 0.6f
			InitializeControlValues()
		End Sub

		Private ReadOnly Property MonthReport() As MonthReport
			Get
				Return monthReport_Renamed
			End Get
		End Property
		Private ReadOnly Property TimelineReport() As TimelineReport
			Get
				Return timelineReport_Renamed
			End Get
		End Property
		Private ReadOnly Property ViewType() As SchedulerViewType
			Get
				Return CType(rgrpView.EditValue, SchedulerViewType)
			End Get
		End Property

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		Protected Overrides Sub CreateReports()
			If monthReport_Renamed IsNot Nothing Then
				monthReport_Renamed.Dispose()
			End If
			Me.monthReport_Renamed = New MonthReport()
			If timelineReport_Renamed IsNot Nothing Then
				timelineReport_Renamed.Dispose()
			End If
			Me.timelineReport_Renamed = New TimelineReport()
		End Sub
		Protected Overrides Function GetActiveReport() As XtraSchedulerReport
			If ViewType = SchedulerViewType.Month Then
				Return MonthReport
			Else
				Return TimelineReport
			End If
		End Function
		Protected Overrides Sub FillReportSourceData()
			DemoUtils.FillReportsStorageData(SchedulerStorage)
		End Sub
		Protected Overrides Sub InitAdapterTimeInterval()
   StoragePrintAdapter.TimeInterval = New TimeInterval(New DateTime(2010, 7, 1), TimeSpan.FromDays(14))
		End Sub
		Private Sub InitializeControlValues()
			Dim report As IAutoHeightReport = CType(GetActiveReport(), IAutoHeightReport)
			chkCanShrink.Checked = report.CellsCanShrink
			chkCanGrow.Checked = report.CellsCanGrow
			spinHeight.Value = CDec(report.CellsHeight)
		End Sub

		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
			Dim autoHeightReport As IAutoHeightReport = CType(report, IAutoHeightReport)
			autoHeightReport.CellsHeight = CSng(spinHeight.Value)
			autoHeightReport.CellsCanGrow = chkCanGrow.Checked
			autoHeightReport.CellsCanShrink = chkCanShrink.Checked
		End Sub


		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.rgrpView = New DevExpress.XtraEditors.RadioGroup()
			Me.spinHeight = New DevExpress.XtraEditors.SpinEdit()
			Me.lblHeight = New DevExpress.XtraEditors.LabelControl()
			Me.chkCanShrink = New DevExpress.XtraEditors.CheckEdit()
			Me.chkCanGrow = New DevExpress.XtraEditors.CheckEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkCanShrink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkCanGrow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.groupControl1)
			Me.pnlSettings.Controls.Add(Me.groupControl2)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 83)
			Me.pnlSettings.Controls.SetChildIndex(Me.groupControl2, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.groupControl1, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 83)
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 91)
			Me.printControl.Size = New System.Drawing.Size(700, 305)
			' 
			' btnEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(620, 50)
			' 
			' rgrpView
			' 
			Me.rgrpView.EditValue = DevExpress.XtraScheduler.SchedulerViewType.Month
			Me.rgrpView.Location = New System.Drawing.Point(5, 28)
			Me.rgrpView.Name = "rgrpView"
			Me.rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgrpView.Properties.Appearance.Options.UseBackColor = True
			Me.rgrpView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgrpView.Properties.Columns = 5
			Me.rgrpView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Month, "Month"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Timeline, "Timeline")})
			Me.rgrpView.Size = New System.Drawing.Size(143, 24)
			Me.rgrpView.TabIndex = 5
'			Me.rgrpView.SelectedIndexChanged += New System.EventHandler(Me.rgrpView_SelectedIndexChanged);
			' 
			' spinHeight
			' 
			Me.spinHeight.EditValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.spinHeight.Location = New System.Drawing.Point(46, 30)
			Me.spinHeight.Name = "spinHeight"
			Me.spinHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinHeight.Properties.Increment = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinHeight.Properties.IsFloatValue = False
			Me.spinHeight.Properties.Mask.EditMask = "N00"
			Me.spinHeight.Properties.MaxValue = New Decimal(New Integer() { 800, 0, 0, 0})
			Me.spinHeight.Properties.MinValue = New Decimal(New Integer() { 50, 0, 0, 0})
			Me.spinHeight.Size = New System.Drawing.Size(72, 20)
			Me.spinHeight.TabIndex = 39
'			Me.spinHeight.EditValueChanged += New System.EventHandler(Me.spinHeight_EditValueChanged);
			' 
			' lblHeight
			' 
			Me.lblHeight.Location = New System.Drawing.Point(5, 33)
			Me.lblHeight.Name = "lblHeight"
			Me.lblHeight.Size = New System.Drawing.Size(35, 13)
			Me.lblHeight.TabIndex = 40
			Me.lblHeight.Text = "Height:"
			' 
			' chkCanShrink
			' 
			Me.chkCanShrink.Location = New System.Drawing.Point(148, 31)
			Me.chkCanShrink.Name = "chkCanShrink"
			Me.chkCanShrink.Properties.AutoWidth = True
			Me.chkCanShrink.Properties.Caption = "Can Shrink"
			Me.chkCanShrink.Size = New System.Drawing.Size(74, 19)
			Me.chkCanShrink.TabIndex = 50
'			Me.chkCanShrink.CheckedChanged += New System.EventHandler(Me.chkCanShrink_CheckedChanged);
			' 
			' chkCanGrow
			' 
			Me.chkCanGrow.Location = New System.Drawing.Point(242, 31)
			Me.chkCanGrow.Name = "chkCanGrow"
			Me.chkCanGrow.Properties.AutoWidth = True
			Me.chkCanGrow.Properties.Caption = "Can Grow"
			Me.chkCanGrow.Size = New System.Drawing.Size(70, 19)
			Me.chkCanGrow.TabIndex = 51
'			Me.chkCanGrow.CheckedChanged += New System.EventHandler(Me.chkCanGrow_CheckedChanged);
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.rgrpView)
			Me.groupControl1.Location = New System.Drawing.Point(15, 9)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(173, 60)
			Me.groupControl1.TabIndex = 77
			Me.groupControl1.Text = "Report Type"
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.spinHeight)
			Me.groupControl2.Controls.Add(Me.lblHeight)
			Me.groupControl2.Controls.Add(Me.chkCanGrow)
			Me.groupControl2.Controls.Add(Me.chkCanShrink)
			Me.groupControl2.Location = New System.Drawing.Point(214, 9)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(356, 60)
			Me.groupControl2.TabIndex = 78
			Me.groupControl2.Text = "Cells Options"
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkCanShrink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkCanGrow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub rgrpView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpView.SelectedIndexChanged
			UpdateActiveReport()
		End Sub

		Private Sub spinHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinHeight.EditValueChanged
			UpdateActiveReport()
		End Sub
		Private Sub chkCanShrink_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCanShrink.CheckedChanged
			UpdateActiveReport()
		End Sub

		Private Sub chkCanGrow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkCanGrow.CheckedChanged
			UpdateActiveReport()
		End Sub

		Private Sub chkCompressWeekend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateActiveReport()
		End Sub

	End Class

	Public Interface IAutoHeightReport
		Property CellsCanShrink() As Boolean
		Property CellsCanGrow() As Boolean
		Property CellsHeight() As Single

	End Interface
End Namespace

