Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Namespace DevExpress.XtraScheduler.Demos.Reporting

	Public Partial Class SingleReportPreviewControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
				If Not Report Is Nothing Then
					Report.Dispose()
					report_Renamed = Nothing
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SingleReportPreviewControl))
			Dim timeInterval1 As DevExpress.XtraScheduler.TimeInterval = New DevExpress.XtraScheduler.TimeInterval()
            Me.fStoragePrintAdapter = New DevExpress.XtraScheduler.Reporting.SchedulerStoragePrintAdapter()
            Me.fSchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.pnlSettings.SuspendLayout()

			CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fPrintBarManager
			' 
			Me.fPrintBarManager.ImageStream = (CType(resources.GetObject("fPrintBarManager.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' storagePrintAdapter
			' 
			Me.storagePrintAdapter.SchedulerStorage = Me.schedulerStorage
			timeInterval1.Duration = System.TimeSpan.Parse("00:00:00")
			Me.storagePrintAdapter.TimeInterval = timeInterval1
			' 
			' StoragePreviewControl
			' 
			Me.Name = "StoragePreviewControl"
			Me.pnlSettings.ResumeLayout(False)

			CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region               


	End Class
End Namespace
