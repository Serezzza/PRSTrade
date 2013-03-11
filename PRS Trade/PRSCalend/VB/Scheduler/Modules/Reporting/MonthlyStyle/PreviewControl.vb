Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.MonthlyStyle


	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private lbResourceCount As DevExpress.XtraEditors.LabelControl
		Private spinResourceCount As DevExpress.XtraEditors.SpinEdit
		Protected chkCompressWeekend As DevExpress.XtraEditors.CheckEdit
		Protected chkPrintExactlyOneMonth As DevExpress.XtraEditors.CheckEdit
		Protected chkDontPrintWeekends As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cmbLayout As DevExpress.XtraEditors.ComboBoxEdit
		Private lbLayout As DevExpress.XtraEditors.LabelControl

		Private initialized As Boolean
		Private dontPrintWeekends As Boolean
		Private compressWeekend As Boolean
		Private printExactlyOneMonth As Boolean
		Private visibleResourceCount As Integer = 0
		Private pageLayout As Integer = 1

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
			SubscribeEvents()
		End Sub

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lbResourceCount = New DevExpress.XtraEditors.LabelControl()
			Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
			Me.cmbLayout = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbLayout = New DevExpress.XtraEditors.LabelControl()
			Me.chkCompressWeekend = New DevExpress.XtraEditors.CheckEdit()
			Me.chkPrintExactlyOneMonth = New DevExpress.XtraEditors.CheckEdit()
			Me.chkDontPrintWeekends = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkCompressWeekend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkPrintExactlyOneMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDontPrintWeekends.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' smplEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(620, 35)
			Me.btnEdit.TabIndex = 5
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.chkCompressWeekend)
			Me.pnlSettings.Controls.Add(Me.chkPrintExactlyOneMonth)
			Me.pnlSettings.Controls.Add(Me.chkDontPrintWeekends)
			Me.pnlSettings.Controls.Add(Me.cmbLayout)
			Me.pnlSettings.Controls.Add(Me.lbLayout)
			Me.pnlSettings.Controls.Add(Me.lbResourceCount)
			Me.pnlSettings.Controls.Add(Me.spinResourceCount)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 68)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbResourceCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbLayout, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.cmbLayout, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkDontPrintWeekends, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkPrintExactlyOneMonth, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkCompressWeekend, 0)
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 68)
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 76)
			Me.printControl.Size = New System.Drawing.Size(700, 320)
			' 
			' lbResourceCount
			' 
			Me.lbResourceCount.Location = New System.Drawing.Point(9, 15)
			Me.lbResourceCount.Name = "lbResourceCount"
			Me.lbResourceCount.Size = New System.Drawing.Size(81, 13)
			Me.lbResourceCount.TabIndex = 43
			Me.lbResourceCount.Text = "Resource Count:"
			' 
			' spinResourceCount
			' 
			Me.spinResourceCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinResourceCount.Location = New System.Drawing.Point(95, 11)
			Me.spinResourceCount.Name = "spinResourceCount"
			Me.spinResourceCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinResourceCount.Properties.IsFloatValue = False
			Me.spinResourceCount.Properties.Mask.EditMask = "N00"
			Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinResourceCount.Size = New System.Drawing.Size(85, 20)
			Me.spinResourceCount.TabIndex = 42
			' 
			' cmbLayout
			' 
			Me.cmbLayout.EditValue = "1 page/week"
			Me.cmbLayout.Location = New System.Drawing.Point(95, 37)
			Me.cmbLayout.Name = "cmbLayout"
			Me.cmbLayout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbLayout.Properties.Items.AddRange(New Object() { "1 page/week", "2 pages/week"})
			Me.cmbLayout.Size = New System.Drawing.Size(85, 20)
			Me.cmbLayout.TabIndex = 45
			' 
			' lbLayout
			' 
			Me.lbLayout.Location = New System.Drawing.Point(9, 41)
			Me.lbLayout.Name = "lbLayout"
			Me.lbLayout.Size = New System.Drawing.Size(37, 13)
			Me.lbLayout.TabIndex = 44
			Me.lbLayout.Text = "Layout:"
			' 
			' chkCompressWeekend
			' 
			Me.chkCompressWeekend.Location = New System.Drawing.Point(198, 38)
			Me.chkCompressWeekend.Name = "chkCompressWeekend"
			Me.chkCompressWeekend.Properties.AutoWidth = True
			Me.chkCompressWeekend.Properties.Caption = "Compress weekend"
			Me.chkCompressWeekend.Size = New System.Drawing.Size(116, 19)
			Me.chkCompressWeekend.TabIndex = 48
			' 
			' chkPrintExactlyOneMonth
			' 
			Me.chkPrintExactlyOneMonth.Location = New System.Drawing.Point(336, 12)
			Me.chkPrintExactlyOneMonth.Name = "chkPrintExactlyOneMonth"
			Me.chkPrintExactlyOneMonth.Properties.AutoWidth = True
			Me.chkPrintExactlyOneMonth.Properties.Caption = "Print exactly one month per page"
			Me.chkPrintExactlyOneMonth.Size = New System.Drawing.Size(183, 19)
			Me.chkPrintExactlyOneMonth.TabIndex = 47
			' 
			' chkDontPrintWeekends
			' 
			Me.chkDontPrintWeekends.Location = New System.Drawing.Point(198, 12)
			Me.chkDontPrintWeekends.Name = "chkDontPrintWeekends"
			Me.chkDontPrintWeekends.Properties.AutoWidth = True
			Me.chkDontPrintWeekends.Properties.Caption = "Don't print &weekends"
			Me.chkDontPrintWeekends.Size = New System.Drawing.Size(124, 19)
			Me.chkDontPrintWeekends.TabIndex = 46
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			Me.pnlSettings.PerformLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkCompressWeekend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkPrintExactlyOneMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDontPrintWeekends.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

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
		Private Sub SubscribeEvents()
			AddHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
			AddHandler chkPrintExactlyOneMonth.CheckedChanged, AddressOf chkPrintExactlyOneMonth_CheckedChanged
			AddHandler chkDontPrintWeekends.CheckedChanged, AddressOf chkDontPrintWeekends_CheckedChanged
			AddHandler chkCompressWeekend.CheckedChanged, AddressOf chkCompressWeekend_CheckedChanged
			AddHandler cmbLayout.SelectedIndexChanged, AddressOf cmbLayout_SelectedIndexChanged
		End Sub
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		Private Sub InitializeControlValues()
			Me.dontPrintWeekends = Report.DontPrintWeekends
			Me.compressWeekend = Report.CompressWeekend
			Me.visibleResourceCount = Report.VisibleResourceCount
			Me.printExactlyOneMonth = Report.PrintExactlyOneMonth
			Me.pageLayout = Report.ColumnCount - 1
			Me.cmbLayout.SelectedIndex = Me.pageLayout
			Me.spinResourceCount.Value = Me.visibleResourceCount
			Me.spinResourceCount.Properties.MinValue = 1
			Me.spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount
			Me.chkCompressWeekend.Checked = Me.compressWeekend
			Me.chkDontPrintWeekends.Checked = Me.dontPrintWeekends
			Me.chkPrintExactlyOneMonth.Checked = Me.printExactlyOneMonth
			Me.initialized = True
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
            Me.Report.DontPrintWeekends = Me.dontPrintWeekends
            Me.Report.VisibleResourceCount = Me.visibleResourceCount
            Me.Report.ColumnCount = Me.cmbLayout.SelectedIndex + 1
            Me.Report.CompressWeekend = Me.compressWeekend
            Me.Report.DontPrintWeekends = Me.dontPrintWeekends
            Me.Report.PrintExactlyOneMonth = Me.printExactlyOneMonth
		End Sub
		Private Sub cmbLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbLayout.SelectedIndexChanged
			Me.pageLayout = Me.cmbLayout.SelectedIndex + 1
			UpdateActiveReport()
		End Sub
		Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.initialized) Then
				Return
			End If
			Me.visibleResourceCount = Convert.ToInt32(spinResourceCount.Value)
			UpdateActiveReport()
		End Sub
		Private Sub chkCompressWeekend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not initialized) Then
				Return
			End If
			Me.compressWeekend = Me.chkCompressWeekend.Checked
			UpdateActiveReport()
		End Sub
		Private Sub chkDontPrintWeekends_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not initialized) Then
				Return
			End If
			Me.dontPrintWeekends = Me.chkDontPrintWeekends.Checked
			UpdateActiveReport()
		End Sub
		Private Sub chkPrintExactlyOneMonth_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not initialized) Then
				Return
			End If
			Me.printExactlyOneMonth = Me.chkPrintExactlyOneMonth.Checked
			UpdateActiveReport()
		End Sub
	End Class
End Namespace

