Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing

		Private allowCustomDrawDayHeader As Boolean
		Private allowCustomDrawResourceHeader As Boolean
		Private allowCustomDrawAllDayArea As Boolean
		Private allowCustomDrawTimeCell As Boolean
		Private allowCustomDrawTimeRuler As Boolean
		Private allowCustomDrawAppointment As Boolean
		Private WithEvents chkTimeRuler As CheckEdit
		Private WithEvents chkAppointmentBackground As CheckEdit
		Private WithEvents chkAppointment As CheckEdit
		Private WithEvents chkDayViewAllDayArea As CheckEdit
		Private WithEvents chkTimeCell As CheckEdit
		Private WithEvents chkDayHeader As CheckEdit
		Private WithEvents chkResourceHeader As CheckEdit
		Private allowCustomDrawAppointmentBackground As Boolean


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
		Protected Overrides Function CreateReportInstance() As XtraSchedulerReport
			Return New Report()
		End Function
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(7))
		End Sub
		Private Sub InitializeControlValues()
			allowCustomDrawDayHeader = chkDayHeader.Checked
			allowCustomDrawResourceHeader = chkResourceHeader.Checked
			allowCustomDrawAllDayArea = chkDayViewAllDayArea.Checked
			allowCustomDrawTimeCell = chkTimeCell.Checked
			allowCustomDrawTimeRuler = chkTimeRuler.Checked
			allowCustomDrawAppointment = chkAppointment.Checked
			allowCustomDrawAppointmentBackground = chkAppointmentBackground.Checked
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
            Me.Report.AllowCustomDrawAllDayArea = allowCustomDrawAllDayArea
            Me.Report.AllowCustomDrawAppointment = allowCustomDrawAppointment
            Me.Report.AllowCustomDrawAppointmentBackground = allowCustomDrawAppointmentBackground
            Me.Report.AllowCustomDrawDayHeader = allowCustomDrawDayHeader
            Me.Report.AllowCustomDrawResourceHeader = allowCustomDrawResourceHeader
            Me.Report.AllowCustomDrawTimeCell = allowCustomDrawTimeCell
            Me.Report.AllowCustomDrawTimeRuler = allowCustomDrawTimeRuler
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.chkTimeRuler = New DevExpress.XtraEditors.CheckEdit()
			Me.chkAppointmentBackground = New DevExpress.XtraEditors.CheckEdit()
			Me.chkAppointment = New DevExpress.XtraEditors.CheckEdit()
			Me.chkDayViewAllDayArea = New DevExpress.XtraEditors.CheckEdit()
			Me.chkTimeCell = New DevExpress.XtraEditors.CheckEdit()
			Me.chkDayHeader = New DevExpress.XtraEditors.CheckEdit()
			Me.chkResourceHeader = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()

			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkTimeRuler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkAppointment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' smplEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(616, 30)
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.chkTimeRuler)
			Me.pnlSettings.Controls.Add(Me.chkAppointmentBackground)
			Me.pnlSettings.Controls.Add(Me.chkAppointment)
			Me.pnlSettings.Controls.Add(Me.chkDayViewAllDayArea)
			Me.pnlSettings.Controls.Add(Me.chkTimeCell)
			Me.pnlSettings.Controls.Add(Me.chkDayHeader)
			Me.pnlSettings.Controls.Add(Me.chkResourceHeader)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 60)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkResourceHeader, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkDayHeader, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkTimeCell, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkDayViewAllDayArea, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkAppointment, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkAppointmentBackground, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.chkTimeRuler, 0)
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 60)
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 68)
			Me.printControl.Size = New System.Drawing.Size(700, 328)
			' 
			' chkTimeRuler
			' 
			Me.chkTimeRuler.EditValue = True
			Me.chkTimeRuler.Location = New System.Drawing.Point(12, 8)
			Me.chkTimeRuler.Name = "chkTimeRuler"
			Me.chkTimeRuler.Properties.Caption = "Time Ruler"
			Me.chkTimeRuler.Size = New System.Drawing.Size(85, 19)
			Me.chkTimeRuler.TabIndex = 101
'			Me.chkTimeRuler.CheckedChanged += New System.EventHandler(Me.chkTimeRuler_CheckedChanged);
			' 
			' chkAppointmentBackground
			' 
			Me.chkAppointmentBackground.EditValue = True
			Me.chkAppointmentBackground.Location = New System.Drawing.Point(364, 8)
			Me.chkAppointmentBackground.Name = "chkAppointmentBackground"
			Me.chkAppointmentBackground.Properties.Caption = "Appointment Background"
			Me.chkAppointmentBackground.Size = New System.Drawing.Size(149, 19)
			Me.chkAppointmentBackground.TabIndex = 100
'			Me.chkAppointmentBackground.CheckedChanged += New System.EventHandler(Me.chkAppointmentBackground_CheckedChanged);
			' 
			' chkAppointment
			' 
			Me.chkAppointment.EditValue = True
			Me.chkAppointment.Location = New System.Drawing.Point(257, 8)
			Me.chkAppointment.Name = "chkAppointment"
			Me.chkAppointment.Properties.Caption = "Appointment"
			Me.chkAppointment.Size = New System.Drawing.Size(101, 19)
			Me.chkAppointment.TabIndex = 99
'			Me.chkAppointment.CheckedChanged += New System.EventHandler(Me.chkAppointment_CheckedChanged);
			' 
			' chkDayViewAllDayArea
			' 
			Me.chkDayViewAllDayArea.EditValue = True
			Me.chkDayViewAllDayArea.Location = New System.Drawing.Point(12, 33)
			Me.chkDayViewAllDayArea.Name = "chkDayViewAllDayArea"
			Me.chkDayViewAllDayArea.Properties.Caption = "All-Day Area"
			Me.chkDayViewAllDayArea.Size = New System.Drawing.Size(85, 19)
			Me.chkDayViewAllDayArea.TabIndex = 98
'			Me.chkDayViewAllDayArea.CheckedChanged += New System.EventHandler(Me.chkDayViewAllDayArea_CheckedChanged);
			' 
			' chkTimeCell
			' 
			Me.chkTimeCell.EditValue = True
			Me.chkTimeCell.Location = New System.Drawing.Point(257, 33)
			Me.chkTimeCell.Name = "chkTimeCell"
			Me.chkTimeCell.Properties.Caption = "Time Cell"
			Me.chkTimeCell.Size = New System.Drawing.Size(72, 19)
			Me.chkTimeCell.TabIndex = 97
'			Me.chkTimeCell.CheckedChanged += New System.EventHandler(Me.chkTimeCell_CheckedChanged);
			' 
			' chkDayHeader
			' 
			Me.chkDayHeader.EditValue = True
			Me.chkDayHeader.Location = New System.Drawing.Point(131, 8)
			Me.chkDayHeader.Name = "chkDayHeader"
			Me.chkDayHeader.Properties.Caption = "Day Header"
			Me.chkDayHeader.Size = New System.Drawing.Size(88, 19)
			Me.chkDayHeader.TabIndex = 96
'			Me.chkDayHeader.CheckedChanged += New System.EventHandler(Me.chkDayHeader_CheckedChanged);
			' 
			' chkResourceHeader
			' 
			Me.chkResourceHeader.EditValue = True
			Me.chkResourceHeader.Location = New System.Drawing.Point(131, 32)
			Me.chkResourceHeader.Name = "chkResourceHeader"
			Me.chkResourceHeader.Properties.Caption = "Resource Header"
			Me.chkResourceHeader.Size = New System.Drawing.Size(107, 19)
			Me.chkResourceHeader.TabIndex = 95
'			Me.chkResourceHeader.CheckedChanged += New System.EventHandler(Me.chkResourceHeader_CheckedChanged);
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()

			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkTimeRuler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAppointmentBackground.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkAppointment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDayViewAllDayArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkTimeCell.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkDayHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkResourceHeader.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region


		Private Sub chkDayHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDayHeader.CheckedChanged
			Me.allowCustomDrawDayHeader = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkResourceHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkResourceHeader.CheckedChanged
			Me.allowCustomDrawResourceHeader = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkTimeCell_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTimeCell.CheckedChanged
			Me.allowCustomDrawTimeCell = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()

		End Sub

		Private Sub chkDayViewAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkDayViewAllDayArea.CheckedChanged
			Me.allowCustomDrawAllDayArea = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointment.CheckedChanged
			Me.allowCustomDrawAppointment = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()

		End Sub

		Private Sub chkAppointmentBackground_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAppointmentBackground.CheckedChanged
			Me.allowCustomDrawAppointmentBackground = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub

		Private Sub chkTimeRuler_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTimeRuler.CheckedChanged
			Me.allowCustomDrawTimeRuler = (CType(sender, CheckEdit)).Checked
			UpdateActiveReport()
		End Sub
	End Class

End Namespace

