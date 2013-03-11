Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.WeeklyStyle

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private lbLayout As DevExpress.XtraEditors.LabelControl
		Private cmbLayout As DevExpress.XtraEditors.ComboBoxEdit
		Private lbResourceCount As DevExpress.XtraEditors.LabelControl
		Private spinResourceCount As DevExpress.XtraEditors.SpinEdit
		Protected edtEnd As DevExpress.XtraEditors.DateEdit
		Protected edtStart As DevExpress.XtraEditors.DateEdit
		Protected lblEnd As DevExpress.XtraEditors.LabelControl
		Protected lblStart As DevExpress.XtraEditors.LabelControl

		Private printInterval As TimeInterval = TimeInterval.Empty
		Private pagesPerWeek As Integer
		Private resourceCount As Integer

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property
		Private Property EndDate() As DateTime
			Get
				Return edtEnd.DateTime.AddDays(1)
			End Get
			Set
				edtEnd.DateTime = Value.AddDays(-1)
			End Set
		End Property
		Private Property StartDate() As DateTime
			Get
				Return edtStart.DateTime
			End Get
			Set
				edtStart.DateTime = Value
			End Set
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
			SubscribeEvents()
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
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(14))
		End Sub
		Private Sub InitializeControlValues()
			printInterval = New TimeInterval(DemoUtils.Date, DemoUtils.Date.AddDays(6))
			StartDate = printInterval.Start
			EndDate = printInterval.End

			Me.pagesPerWeek = Report.ColumnCount
			Me.cmbLayout.SelectedIndex = pagesPerWeek - 1
			InitializeResourceCount()
		End Sub
		Private Sub InitializeResourceCount()
			Me.spinResourceCount.Properties.MinValue = 1
			Me.spinResourceCount.Properties.MaxValue = schedulerStorage.Resources.Count
			Me.resourceCount = Report.ResourceCount
			Me.spinResourceCount.Value = Me.resourceCount
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			StoragePrintAdapter.TimeInterval = printInterval
			MyBase.UpdateReportProperties(report)
            Me.Report.ColumnCount = pagesPerWeek
            Me.Report.ResourceCount = resourceCount
		End Sub
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lbLayout = New DevExpress.XtraEditors.LabelControl()
			Me.cmbLayout = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbResourceCount = New DevExpress.XtraEditors.LabelControl()
			Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
			Me.edtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.edtStart = New DevExpress.XtraEditors.DateEdit()
			Me.lblEnd = New DevExpress.XtraEditors.LabelControl()
			Me.lblStart = New DevExpress.XtraEditors.LabelControl()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' smplEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(620, 35)
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.edtEnd)
			Me.pnlSettings.Controls.Add(Me.edtStart)
			Me.pnlSettings.Controls.Add(Me.lblEnd)
			Me.pnlSettings.Controls.Add(Me.lblStart)
			Me.pnlSettings.Controls.Add(Me.lbResourceCount)
			Me.pnlSettings.Controls.Add(Me.spinResourceCount)
			Me.pnlSettings.Controls.Add(Me.cmbLayout)
			Me.pnlSettings.Controls.Add(Me.lbLayout)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 68)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbLayout, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.cmbLayout, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbResourceCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lblStart, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lblEnd, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.edtStart, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.edtEnd, 0)
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
			' lbLayout
			' 
			Me.lbLayout.Location = New System.Drawing.Point(9, 41)
			Me.lbLayout.Name = "lbLayout"
			Me.lbLayout.Size = New System.Drawing.Size(37, 13)
			Me.lbLayout.TabIndex = 4
			Me.lbLayout.Text = "Layout:"
			' 
			' cmbLayout
			' 
			Me.cmbLayout.EditValue = "1 page/week"
			Me.cmbLayout.Location = New System.Drawing.Point(95, 37)
			Me.cmbLayout.Name = "cmbLayout"
			Me.cmbLayout.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbLayout.Properties.Items.AddRange(New Object() { "1 page/week", "2 pages/week"})
			Me.cmbLayout.Size = New System.Drawing.Size(85, 20)
			Me.cmbLayout.TabIndex = 5
'			Me.cmbLayout.SelectedIndexChanged += New System.EventHandler(Me.cmbLayout_SelectedIndexChanged);
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
			Me.spinResourceCount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.spinResourceCount.Properties.IsFloatValue = False
			Me.spinResourceCount.Properties.Mask.EditMask = "N00"
			Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinResourceCount.Size = New System.Drawing.Size(85, 20)
			Me.spinResourceCount.TabIndex = 42
			' 
			' edtEnd
			' 
			Me.edtEnd.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtEnd.Location = New System.Drawing.Point(256, 37)
			Me.edtEnd.Name = "edtEnd"
			Me.edtEnd.Properties.AccessibleName = "End date:"
			Me.edtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtEnd.Size = New System.Drawing.Size(86, 20)
			Me.edtEnd.TabIndex = 47
			' 
			' edtStart
			' 
			Me.edtStart.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
			Me.edtStart.Location = New System.Drawing.Point(256, 11)
			Me.edtStart.Name = "edtStart"
			Me.edtStart.Properties.AccessibleName = "Start date:"
			Me.edtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.edtStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtStart.Size = New System.Drawing.Size(86, 20)
			Me.edtStart.TabIndex = 46
			' 
			' lblEnd
			' 
			Me.lblEnd.AccessibleName = "End date:"
			Me.lblEnd.Location = New System.Drawing.Point(198, 41)
			Me.lblEnd.Name = "lblEnd"
			Me.lblEnd.Size = New System.Drawing.Size(47, 13)
			Me.lblEnd.TabIndex = 44
			Me.lblEnd.Text = "End date:"
			' 
			' lblStart
			' 
			Me.lblStart.AccessibleName = "Start date:"
			Me.lblStart.Location = New System.Drawing.Point(198, 15)
			Me.lblStart.Name = "lblStart"
			Me.lblStart.Size = New System.Drawing.Size(53, 13)
			Me.lblStart.TabIndex = 45
			Me.lblStart.Text = "Start date:"
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
			CType(Me.cmbLayout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Protected Friend Overridable Sub UnsubscribeEvents()
			RemoveHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			RemoveHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			RemoveHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
		End Sub
		Protected Friend Overridable Sub SubscribeEvents()
			AddHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			AddHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			AddHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
		End Sub

		Protected Friend Overridable Function IsValidInterval(ByVal start As DateTime, ByVal [end] As DateTime) As Boolean
			Return start <= [end]
		End Function
		Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtEnd.EditValue = StartDate
			End If

			Me.printInterval = New TimeInterval(StartDate, EndDate)
			SubscribeEvents()
			UpdateActiveReport()
		End Sub

		Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.resourceCount = CInt(Fix(Me.spinResourceCount.Value))
			UpdateActiveReport()
		End Sub
		Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtStart.EditValue = EndDate.AddDays(-1)
			End If

			Me.printInterval = New TimeInterval(StartDate, EndDate)
			SubscribeEvents()
			UpdateActiveReport()
		End Sub
		Private Sub cmbLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.pagesPerWeek = cmbLayout.SelectedIndex + 1
			UpdateActiveReport()
		End Sub
	End Class
End Namespace

