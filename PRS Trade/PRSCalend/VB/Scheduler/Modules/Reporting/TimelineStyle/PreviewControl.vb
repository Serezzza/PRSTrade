Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.TimelineStyle

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private lbTimeCells As DevExpress.XtraEditors.LabelControl
		Private cmbFirstTimeScale As DevExpress.XtraEditors.ComboBoxEdit
		Private lbResourceCount As DevExpress.XtraEditors.LabelControl
		Private spinResourceCount As DevExpress.XtraEditors.SpinEdit
		Protected edtEnd As DevExpress.XtraEditors.DateEdit
		Protected edtStart As DevExpress.XtraEditors.DateEdit
		Protected lblEnd As DevExpress.XtraEditors.LabelControl
		Protected lblStart As DevExpress.XtraEditors.LabelControl

		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinIntervalCount As DevExpress.XtraEditors.SpinEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private cmbSecondTimeScale As DevExpress.XtraEditors.ComboBoxEdit

		Private printInterval As TimeInterval = TimeInterval.Empty
		Private visibleResourceCount As Integer
		Private visibleIntevalCount As Integer
		Private firstLevelTimeScale As String
		Private secondLevelTimeScale As String

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
		End Property

		Public Sub New()
			' This call is required by the Windows Form Designer. 
			InitializeComponent()
			PopulateFirstLevelScaleCombo()
			PopulateSecondLevelScaleCombo()
			InitializeControlValues()
			SubscribeEvents()
		End Sub
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
			visibleIntevalCount = Report.VisibleIntervalCount
			visibleResourceCount = Report.VisibleResourceCount

			firstLevelTimeScale = Report.FirstLevelTimeScale
			secondLevelTimeScale = Report.SecondLevelTimeScale
			cmbFirstTimeScale.EditValue = firstLevelTimeScale
			cmbSecondTimeScale.EditValue = secondLevelTimeScale

			spinIntervalCount.EditValue = visibleIntevalCount
			spinResourceCount.EditValue = visibleResourceCount

			printInterval = New TimeInterval(DemoUtils.Date.AddDays(-30), DemoUtils.Date.AddDays(30))
			StartDate = printInterval.Start
			EndDate = printInterval.End
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			StoragePrintAdapter.TimeInterval = printInterval

			MyBase.UpdateReportProperties(report)
            Me.Report.VisibleResourceCount = visibleResourceCount
            Me.Report.VisibleIntervalCount = visibleIntevalCount
            Me.Report.FirstLevelTimeScale = firstLevelTimeScale
            Me.Report.SecondLevelTimeScale = secondLevelTimeScale
		End Sub
		Private Sub PopulateFirstLevelScaleCombo()
			cmbFirstTimeScale.Properties.Items.Clear()
			Dim scaleCount As Integer = Report.Scales.Count
			Dim i As Integer = 0
			Do While i < scaleCount - 1
				cmbFirstTimeScale.Properties.Items.Add(Report.Scales(i).DisplayName)
				i += 1
			Loop
			cmbFirstTimeScale.SelectedIndex = 0
			firstLevelTimeScale = CStr(cmbFirstTimeScale.SelectedItem)
		End Sub
		Private Sub PopulateSecondLevelScaleCombo()
			Dim index As Integer = cmbFirstTimeScale.SelectedIndex

			cmbSecondTimeScale.Properties.Items.Clear()
			Dim i As Integer = index + 1
			Do While i < Report.Scales.Count
				cmbSecondTimeScale.Properties.Items.Add(Report.Scales(i).DisplayName)
				i += 1
			Loop
			cmbSecondTimeScale.SelectedIndex = 0
			secondLevelTimeScale = CStr(cmbSecondTimeScale.SelectedItem)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
			Me.lbTimeCells = New DevExpress.XtraEditors.LabelControl()
			Me.cmbFirstTimeScale = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbResourceCount = New DevExpress.XtraEditors.LabelControl()
			Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
			Me.edtEnd = New DevExpress.XtraEditors.DateEdit()
			Me.edtStart = New DevExpress.XtraEditors.DateEdit()
			Me.lblEnd = New DevExpress.XtraEditors.LabelControl()
			Me.lblStart = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.spinIntervalCount = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.cmbSecondTimeScale = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbFirstTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinIntervalCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbSecondTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' smplEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(620, 35)
			' 
			' fPrintBarManager
			' 
			Me.fPrintBarManager.ImageStream = (CType(resources.GetObject("fPrintBarManager.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.labelControl2)
			Me.pnlSettings.Controls.Add(Me.cmbSecondTimeScale)
			Me.pnlSettings.Controls.Add(Me.labelControl1)
			Me.pnlSettings.Controls.Add(Me.spinIntervalCount)
			Me.pnlSettings.Controls.Add(Me.lbResourceCount)
			Me.pnlSettings.Controls.Add(Me.spinResourceCount)
			Me.pnlSettings.Controls.Add(Me.edtEnd)
			Me.pnlSettings.Controls.Add(Me.edtStart)
			Me.pnlSettings.Controls.Add(Me.lblEnd)
			Me.pnlSettings.Controls.Add(Me.lblStart)
			Me.pnlSettings.Controls.Add(Me.lbTimeCells)
			Me.pnlSettings.Controls.Add(Me.cmbFirstTimeScale)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 68)
			Me.pnlSettings.Controls.SetChildIndex(Me.cmbFirstTimeScale, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbTimeCells, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lblStart, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lblEnd, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.edtStart, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.edtEnd, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbResourceCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.spinIntervalCount, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.labelControl1, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.cmbSecondTimeScale, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.labelControl2, 0)
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
			' lbTimeCells
			' 
			Me.lbTimeCells.Location = New System.Drawing.Point(360, 15)
			Me.lbTimeCells.Name = "lbTimeCells"
			Me.lbTimeCells.Size = New System.Drawing.Size(77, 13)
			Me.lbTimeCells.TabIndex = 4
			Me.lbTimeCells.Text = "First level scale:"
			' 
			' cmbFirstTimeScale
			' 
			Me.cmbFirstTimeScale.EditValue = ""
			Me.cmbFirstTimeScale.Location = New System.Drawing.Point(456, 11)
			Me.cmbFirstTimeScale.Name = "cmbFirstTimeScale"
			Me.cmbFirstTimeScale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbFirstTimeScale.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbFirstTimeScale.Size = New System.Drawing.Size(84, 20)
			Me.cmbFirstTimeScale.TabIndex = 5
			' 
			' lbResourceCount
			' 
			Me.lbResourceCount.Location = New System.Drawing.Point(9, 15)
			Me.lbResourceCount.Name = "lbResourceCount"
			Me.lbResourceCount.Size = New System.Drawing.Size(81, 13)
			Me.lbResourceCount.TabIndex = 47
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
			Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() { 3, 0, 0, 0})
			Me.spinResourceCount.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinResourceCount.Size = New System.Drawing.Size(85, 20)
			Me.spinResourceCount.TabIndex = 46
'			Me.spinResourceCount.EditValueChanged += New System.EventHandler(Me.spinResourceCount_EditValueChanged);
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
			Me.edtEnd.TabIndex = 43
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
			Me.edtStart.TabIndex = 42
			' 
			' lblEnd
			' 
			Me.lblEnd.AccessibleName = "End date:"
			Me.lblEnd.Location = New System.Drawing.Point(198, 41)
			Me.lblEnd.Name = "lblEnd"
			Me.lblEnd.Size = New System.Drawing.Size(47, 13)
			Me.lblEnd.TabIndex = 40
			Me.lblEnd.Text = "End date:"
			' 
			' lblStart
			' 
			Me.lblStart.AccessibleName = "Start date:"
			Me.lblStart.Location = New System.Drawing.Point(198, 15)
			Me.lblStart.Name = "lblStart"
			Me.lblStart.Size = New System.Drawing.Size(53, 13)
			Me.lblStart.TabIndex = 41
			Me.lblStart.Text = "Start date:"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(9, 41)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(74, 13)
			Me.labelControl1.TabIndex = 49
			Me.labelControl1.Text = "Interval Count:"
			' 
			' spinIntervalCount
			' 
			Me.spinIntervalCount.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinIntervalCount.Location = New System.Drawing.Point(95, 37)
			Me.spinIntervalCount.Name = "spinIntervalCount"
			Me.spinIntervalCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinIntervalCount.Properties.IsFloatValue = False
			Me.spinIntervalCount.Properties.Mask.EditMask = "N00"
			Me.spinIntervalCount.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.spinIntervalCount.Size = New System.Drawing.Size(85, 20)
			Me.spinIntervalCount.TabIndex = 48
'			Me.spinIntervalCount.EditValueChanged += New System.EventHandler(Me.spinIntervalCount_EditValueChanged);
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(360, 41)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(91, 13)
			Me.labelControl2.TabIndex = 50
			Me.labelControl2.Text = "Second level scale:"
			' 
			' cmbSecondTimeScale
			' 
			Me.cmbSecondTimeScale.EditValue = ""
			Me.cmbSecondTimeScale.Location = New System.Drawing.Point(456, 37)
			Me.cmbSecondTimeScale.Name = "cmbSecondTimeScale"
			Me.cmbSecondTimeScale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbSecondTimeScale.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbSecondTimeScale.Size = New System.Drawing.Size(84, 20)
			Me.cmbSecondTimeScale.TabIndex = 51
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
			CType(Me.cmbFirstTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinIntervalCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbSecondTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub cmbFirstTimeScale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			firstLevelTimeScale = cmbFirstTimeScale.EditValue.ToString()

			PopulateSecondLevelScaleCombo()
			UpdateActiveReport()
		End Sub
		Private Sub cmbSecondTimeScale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			secondLevelTimeScale = cmbSecondTimeScale.EditValue.ToString()
			UpdateActiveReport()
		End Sub
		Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue)
			UpdateActiveReport()
		End Sub

		Private Sub spinIntervalCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinIntervalCount.EditValueChanged
			visibleIntevalCount = Convert.ToInt32(spinIntervalCount.EditValue)
			UpdateActiveReport()
		End Sub
		Protected Friend Overridable Sub UnsubscribeEvents()
			RemoveHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			RemoveHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			RemoveHandler cmbFirstTimeScale.SelectedIndexChanged, AddressOf cmbFirstTimeScale_SelectedIndexChanged
			RemoveHandler cmbSecondTimeScale.SelectedIndexChanged, AddressOf cmbSecondTimeScale_SelectedIndexChanged

		End Sub
		Protected Friend Overridable Sub SubscribeEvents()
			AddHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
			AddHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
			AddHandler cmbFirstTimeScale.SelectedIndexChanged, AddressOf cmbFirstTimeScale_SelectedIndexChanged
			AddHandler cmbSecondTimeScale.SelectedIndexChanged, AddressOf cmbSecondTimeScale_SelectedIndexChanged
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

		Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UnsubscribeEvents()
			If (Not IsValidInterval(StartDate, EndDate)) Then
				edtStart.EditValue = EndDate.AddDays(-1)
			End If

			Me.printInterval = New TimeInterval(StartDate, EndDate)
			SubscribeEvents()
			UpdateActiveReport()
		End Sub

	End Class
End Namespace

