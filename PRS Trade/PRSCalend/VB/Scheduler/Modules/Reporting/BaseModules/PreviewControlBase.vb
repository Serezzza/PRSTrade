Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting

	''' <summary>
	''' Summary description for ModuleControl.
	''' </summary>
	''' 
	Public Class ReportPreviewControlBase
		Inherits TutorialControl
		Implements IDemoSchedulerReport

		Public Class DesignForm
			Inherits DevExpress.XtraReports.UserDesigner.XRDesignFormEx
			Protected Overrides Sub SaveLayout()
			End Sub
			Protected Overrides Sub RestoreLayout()
			End Sub
		End Class
		#Region "Fields"
		Private components As System.ComponentModel.IContainer
		Private preventUpdate_Renamed As Boolean
		Protected fPrintBarManager As PrintBarManager
        Protected pnlSettings As DevExpress.XtraEditors.PanelControl
		Protected panelSeparatorControl As DevExpress.XtraEditors.PanelControl
		Protected WithEvents printControl As PrintControl
		Protected WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton


        Protected WithEvents fSchedulerStorage As SchedulerStorage
        Protected WithEvents fStoragePrintAdapter As SchedulerStoragePrintAdapter
		#End Region        

		Public Sub New()
			InitializeComponent()
			Me.fPrintBarManager = CreatePrintBarManager(printControl)
            FillReportSourceData()
			InitAdapterTimeInterval()
			CreateReports()
		End Sub
		#Region "Properties"
		Protected Property PreventUpdate() As Boolean
			Get
				Return preventUpdate_Renamed
			End Get
			Set
				preventUpdate_Renamed = Value
			End Set
		End Property
		Public ReadOnly Property StoragePrintAdapter() As SchedulerStoragePrintAdapter
			Get
                Return Me.fStoragePrintAdapter
			End Get
		End Property
		Public ReadOnly Property SchedulerStorage() As SchedulerStorage
			Get
                Return Me.fSchedulerStorage
			End Get
		End Property
		#End Region
		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		''' 
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
            Me.panelSeparatorControl = New DevExpress.XtraEditors.PanelControl()
			Me.pnlSettings = New DevExpress.XtraEditors.PanelControl()
			Me.printControl = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
            Me.fStoragePrintAdapter = New DevExpress.XtraScheduler.Reporting.SchedulerStoragePrintAdapter()
            Me.fSchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)

			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			Me.SuspendLayout()

			' 
			' storagePrintAdapter
			' 
			Me.storagePrintAdapter.SchedulerStorage = Me.schedulerStorage
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelSeparatorControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 37)
			Me.panelSeparatorControl.Name = "panelSeparatorControl"
			Me.panelSeparatorControl.Size = New System.Drawing.Size(700, 8)
			Me.panelSeparatorControl.TabIndex = 10
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.btnEdit)
			Me.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlSettings.Location = New System.Drawing.Point(0, 0)
			Me.pnlSettings.Name = "pnlSettings"
			Me.pnlSettings.Size = New System.Drawing.Size(700, 37)
			Me.pnlSettings.TabIndex = 3
			' 
			' printControl
			' 
			Me.printControl.BackColor = System.Drawing.Color.Empty
			Me.printControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.printControl.ForeColor = System.Drawing.Color.Empty
			Me.printControl.IsMetric = False
			Me.printControl.Location = New System.Drawing.Point(0, 45)
			Me.printControl.Name = "printControl"
            Me.printControl.Size = New System.Drawing.Size(700, 351)
			Me.printControl.TabIndex = 1
			Me.printControl.TabStop = False
			Me.printControl.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
'			Me.printControl.VisibleChanged += New System.EventHandler(Me.printControl_VisibleChanged);
			' 
			' btnEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(620, 8)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New System.Drawing.Size(75, 24)
			Me.btnEdit.TabIndex = 2
			Me.btnEdit.Text = "Edit"
'			Me.btnEdit.Click += New System.EventHandler(Me.btnEdit_Click);
			' 
			' PreviewControlBase
			' 
			Me.Controls.Add(Me.printControl)
			Me.Controls.Add(Me.panelSeparatorControl)
			Me.Controls.Add(Me.pnlSettings)
			Me.Name = "PreviewControlBase"
			Me.Size = New System.Drawing.Size(700, 396)

			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			Me.ResumeLayout(False)


		End Sub
		#End Region        

        Private Sub InitializePrintingSystem(ByVal printingSystem As PrintingSystemBase)
            printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, DevExpress.XtraPrinting.CommandVisibility.None)
        End Sub
		Protected Overridable Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(60))
		End Sub

		Protected Overridable Sub FillReportSourceData()
			DemoUtils.FillStorageData(SchedulerStorage)
		End Sub
		Protected Overridable Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			report.PrintColorSchema = DemoUtils.ReportPrintColorSchema
			report.SchedulerAdapter = StoragePrintAdapter
		End Sub
		Protected Function CreatePrintBarManager(ByVal pc As PrintControl) As PrintBarManager
			Dim printBarManager As PrintBarManager = New PrintBarManager()
			printBarManager.Form = printControl
			printBarManager.Initialize(pc)
			printBarManager.MainMenu.Visible = False
			printBarManager.AllowCustomization = False
			Return printBarManager
		End Function
		Protected Sub ShowDesignerForm(ByVal designForm As Form, ByVal parentForm As Form)
			designForm.MinimumSize = parentForm.MinimumSize
			If parentForm.WindowState = FormWindowState.Normal Then
				designForm.Bounds = parentForm.Bounds
			End If
			designForm.WindowState = parentForm.WindowState
			parentForm.Visible = False
			designForm.ShowDialog()
			parentForm.Visible = True
		End Sub
		Private Sub printControl_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles printControl.VisibleChanged
			If Visible AndAlso (Not preventUpdate_Renamed) Then
				UpdateActiveReport()
			End If
		End Sub

		Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
			Dim designForm As CustomDesignForm = New CustomDesignForm()
			Dim report As XtraSchedulerReport = GetActiveReport()
			If report Is Nothing Then
				Return
			End If

			designForm.OpenReport(report)
			PreventUpdate = True
			Try
				ShowDesignerForm(designForm, Me.FindForm())
			Finally
				PreventUpdate = False
			End Try
			designForm.Dispose()

			CreateReports()
			UpdateActiveReport()
		End Sub

		Private Sub UpdatePrintingSystemDocument(ByVal report As XtraSchedulerReport)
			If report Is Nothing Then
				Return
			End If
            Invalidate()
            Update()
            InitializePrintingSystem(report.PrintingSystem)
            printControl.PrintingSystem = report.PrintingSystem
			report.CreateDocument(True)
		End Sub
		#Region "IDemoSchedulerReport Members"
		Public Sub UpdateActiveReport() Implements IDemoSchedulerReport.UpdateActiveReport
			Dim report As XtraSchedulerReport = GetActiveReport()
			If report Is Nothing Then
				Return
			End If
			UpdateReportProperties(report)
			UpdatePrintingSystemDocument(report)
		End Sub

		#End Region
		Protected Overridable Sub CreateReports()
		End Sub
		Protected Overridable Function GetActiveReport() As XtraSchedulerReport
			Return Nothing
		End Function

	End Class
End Namespace
