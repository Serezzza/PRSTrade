Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.MultiColumn

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private lbResourceCount As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinColumnCount As DevExpress.XtraEditors.SpinEdit
		Private WithEvents rgrpColumnArrangement As DevExpress.XtraEditors.RadioGroup
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

		Private visibleWeekDayColumnCount As Integer = 0
		Private columnArrangement As ColumnArrangementMode = ColumnArrangementMode.Ascending

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
		End Sub
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		Private Sub InitializeControlValues()
			visibleWeekDayColumnCount = Report.VisibleWeekDayColumnCount
			columnArrangement = Report.ColumnArrangement

			spinColumnCount.Value = visibleWeekDayColumnCount
			rgrpColumnArrangement.EditValue = columnArrangement
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
            Me.Report.VisibleWeekDayColumnCount = visibleWeekDayColumnCount
            Me.Report.ColumnArrangement = columnArrangement
		End Sub
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
			Me.spinColumnCount = New DevExpress.XtraEditors.SpinEdit()
			Me.lbResourceCount = New DevExpress.XtraEditors.LabelControl()
			Me.rgrpColumnArrangement = New DevExpress.XtraEditors.RadioGroup()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinColumnCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgrpColumnArrangement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' smplEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(620, 9)
			' 
			' fPrintBarManager
			' 
			Me.fPrintBarManager.ImageStream = (CType(resources.GetObject("fPrintBarManager.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.rgrpColumnArrangement)
			Me.pnlSettings.Controls.Add(Me.labelControl1)
			Me.pnlSettings.Controls.Add(Me.lbResourceCount)
			Me.pnlSettings.Controls.Add(Me.spinColumnCount)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 42)
			Me.pnlSettings.Controls.SetChildIndex(Me.spinColumnCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbResourceCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.labelControl1, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.rgrpColumnArrangement, 0)
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 42)
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 50)
			Me.printControl.Size = New System.Drawing.Size(700, 346)
			' 
			' spinColumnCount
			' 
			Me.spinColumnCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinColumnCount.Location = New System.Drawing.Point(139, 11)
			Me.spinColumnCount.Name = "spinColumnCount"
			Me.spinColumnCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinColumnCount.Properties.IsFloatValue = False
			Me.spinColumnCount.Properties.Mask.EditMask = "N00"
			Me.spinColumnCount.Properties.MaxValue = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.spinColumnCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinColumnCount.Size = New System.Drawing.Size(69, 20)
			Me.spinColumnCount.TabIndex = 3
'			Me.spinColumnCount.EditValueChanged += New System.EventHandler(Me.spinColumnPerPage_EditValueChanged);
			' 
			' lbResourceCount
			' 
			Me.lbResourceCount.Location = New System.Drawing.Point(9, 15)
			Me.lbResourceCount.Name = "lbResourceCount"
			Me.lbResourceCount.Size = New System.Drawing.Size(125, 13)
			Me.lbResourceCount.TabIndex = 4
			Me.lbResourceCount.Text = "WeekDays Column Count:"
'			Me.lbResourceCount.Click += New System.EventHandler(Me.lbResourceCount_Click);
			' 
			' rgrpColumnArrangement
			' 
			Me.rgrpColumnArrangement.Location = New System.Drawing.Point(332, 10)
			Me.rgrpColumnArrangement.Name = "rgrpColumnArrangement"
			Me.rgrpColumnArrangement.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgrpColumnArrangement.Properties.Appearance.Options.UseBackColor = True
			Me.rgrpColumnArrangement.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgrpColumnArrangement.Properties.Columns = 5
			Me.rgrpColumnArrangement.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.Reporting.ColumnArrangementMode.Ascending, "Ascending"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.Reporting.ColumnArrangementMode.Descending, "Descending")})
			Me.rgrpColumnArrangement.Size = New System.Drawing.Size(175, 24)
			Me.rgrpColumnArrangement.TabIndex = 7
'			Me.rgrpColumnArrangement.SelectedIndexChanged += New System.EventHandler(Me.rgrpColumnMode_SelectedIndexChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(226, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(105, 13)
			Me.labelControl1.TabIndex = 6
			Me.labelControl1.Text = "Column Arrangement:"
'			Me.labelControl1.Click += New System.EventHandler(Me.labelControl1_Click);
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			Me.pnlSettings.PerformLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinColumnCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgrpColumnArrangement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub spinColumnPerPage_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinColumnCount.EditValueChanged
			Me.visibleWeekDayColumnCount = Convert.ToInt32(spinColumnCount.Value)
			UpdateActiveReport()
		End Sub
		Private Sub rgrpColumnMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpColumnArrangement.SelectedIndexChanged
			Me.columnArrangement = CType(rgrpColumnArrangement.EditValue, ColumnArrangementMode)
			UpdateActiveReport()
        End Sub
	End Class
End Namespace

