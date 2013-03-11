Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.SmartSyncPrinting

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private lbGroupType As DevExpress.XtraEditors.LabelControl
        Private WithEvents rgrpGroupType As DevExpress.XtraEditors.RadioGroup

		Private groupType As SchedulerGroupType

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
            InitializeControlValues()
		End Sub

		Public Shadows ReadOnly Property Report() As Report
			Get
				Return CType(MyBase.Report, Report)
			End Get
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
		Protected Overrides Sub FillReportSourceData()
			DemoUtils.FillReportsStorageData(SchedulerStorage)
		End Sub
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date.AddDays(17), TimeSpan.FromDays(4))
		End Sub
		Private Sub InitializeControlValues()
            groupType = StoragePrintAdapter.SmartSyncOptions.GroupType
			rgrpGroupType.EditValue = groupType
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
			StoragePrintAdapter.SmartSyncOptions.GroupType = groupType
		End Sub
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lbGroupType = New DevExpress.XtraEditors.LabelControl()
			Me.rgrpGroupType = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgrpGroupType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.rgrpGroupType)
			Me.pnlSettings.Controls.Add(Me.lbGroupType)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 42)
			Me.pnlSettings.Controls.SetChildIndex(Me.lbGroupType, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.rgrpGroupType, 0)
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
			' btnEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(620, 9)
			' 
			' storagePrintAdapter
			' 
            Me.StoragePrintAdapter.EnableSmartSync = True
			' 
			' lbGroupType
			' 
			Me.lbGroupType.Location = New System.Drawing.Point(9, 15)
			Me.lbGroupType.Name = "lbGroupType"
			Me.lbGroupType.Size = New System.Drawing.Size(60, 13)
			Me.lbGroupType.TabIndex = 4
			Me.lbGroupType.Text = "Group Type:"
			' 
			' rgrpGroupType
			' 
			Me.rgrpGroupType.Location = New System.Drawing.Point(70, 10)
			Me.rgrpGroupType.Name = "rgrpGroupType"
			Me.rgrpGroupType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgrpGroupType.Properties.Appearance.Options.UseBackColor = True
			Me.rgrpGroupType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgrpGroupType.Properties.Columns = 5
			Me.rgrpGroupType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.None, "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.Date, "Date"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerGroupType.Resource, "Resource")})
			Me.rgrpGroupType.Size = New System.Drawing.Size(218, 24)
			Me.rgrpGroupType.TabIndex = 5
'			Me.rgrpGroupType.SelectedIndexChanged += New System.EventHandler(Me.rgrpGroupType_SelectedIndexChanged);
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			Me.pnlSettings.PerformLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgrpGroupType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub rgrpGroupType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpGroupType.SelectedIndexChanged
			groupType = CType(rgrpGroupType.EditValue, SchedulerGroupType)
			UpdateActiveReport()
		End Sub

	End Class
End Namespace

