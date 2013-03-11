Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.SmartSyncPrinting

	Public Partial Class Report
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		'private dsCustomers dsCustomers1;
		'private DevExpress.XtraScheduler.Reporting.Demos.MultiColumnReport.dsCustomersTableAdapters.CustomersTableAdapter customersTableAdapter1;
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
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

		#Region "Component Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim TimeOfDayInterval1 As DevExpress.XtraScheduler.TimeOfDayInterval = New DevExpress.XtraScheduler.TimeOfDayInterval
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.timeIntervalInfo3 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
            Me.horizontalWeek1 = New DevExpress.XtraScheduler.Reporting.HorizontalWeek
            Me.reportMonthView1 = New DevExpress.XtraScheduler.Reporting.ReportMonthView
            Me.timeIntervalInfo2 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
            Me.fullWeek1 = New DevExpress.XtraScheduler.Reporting.FullWeek
            Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
            Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells
            Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView
            Me.dayOfWeekHeaders1 = New DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders
            Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
            Me.resourceInfo1 = New DevExpress.XtraScheduler.Reporting.ResourceInfo
            CType(Me.reportMonthView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.reportWeekView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.timeIntervalInfo3, Me.timeIntervalInfo2, Me.timeIntervalInfo1, Me.dayOfWeekHeaders1, Me.dayViewTimeRuler1, Me.fullWeek1, Me.horizontalWeek1, Me.dayViewTimeCells1, Me.xrLine1, Me.resourceInfo1})
            Me.Detail.HeightF = 792.25!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'timeIntervalInfo3
            '
            Me.timeIntervalInfo3.AutoScaleFont = False
            Me.timeIntervalInfo3.Font = New System.Drawing.Font("Times New Roman", 14.0!)
            Me.timeIntervalInfo3.LocationFloat = New DevExpress.Utils.PointFloat(611.0!, 57.00002!)
            Me.timeIntervalInfo3.Name = "timeIntervalInfo3"
            Me.timeIntervalInfo3.SizeF = New System.Drawing.SizeF(279.0!, 50.0!)
            Me.timeIntervalInfo3.TimeCells = Me.horizontalWeek1
            '
            'horizontalWeek1
            '
            Me.horizontalWeek1.LocationFloat = New DevExpress.Utils.PointFloat(612.04!, 133.6!)
            Me.horizontalWeek1.Name = "horizontalWeek1"
            Me.horizontalWeek1.SizeF = New System.Drawing.SizeF(279.0!, 511.9166!)
            Me.horizontalWeek1.View = Me.reportMonthView1
            '
            'timeIntervalInfo2
            '
            Me.timeIntervalInfo2.AutoScaleFont = False
            Me.timeIntervalInfo2.Font = New System.Drawing.Font("Times New Roman", 14.0!)
            Me.timeIntervalInfo2.LocationFloat = New DevExpress.Utils.PointFloat(317.7081!, 56.95831!)
            Me.timeIntervalInfo2.Name = "timeIntervalInfo2"
            Me.timeIntervalInfo2.SizeF = New System.Drawing.SizeF(280.21!, 50.0!)
            Me.timeIntervalInfo2.TimeCells = Me.fullWeek1
            '
            'fullWeek1
            '
            Me.fullWeek1.LocationFloat = New DevExpress.Utils.PointFloat(317.7084!, 113.4583!)
            Me.fullWeek1.Name = "fullWeek1"
            Me.fullWeek1.SizeF = New System.Drawing.SizeF(280.2084!, 531.9584!)
            Me.fullWeek1.View = Me.reportWeekView1
            '
            'timeIntervalInfo1
            '
            Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1.041476!, 56.95831!)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(305.1251!, 44.79168!)
            Me.timeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
            '
            'dayViewTimeCells1
            '
            Me.dayViewTimeCells1.ExtraCells.MinCount = 1
            Me.dayViewTimeCells1.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 113.5!)
            Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
            Me.dayViewTimeCells1.ShowWorkTimeOnly = True
            Me.dayViewTimeCells1.SizeF = New System.Drawing.SizeF(255.1251!, 531.9584!)
            Me.dayViewTimeCells1.TimeScale = System.TimeSpan.Parse("01:00:00")
            Me.dayViewTimeCells1.View = Me.reportDayView1
            TimeOfDayInterval1.End = System.TimeSpan.Parse("18:00:00")
            TimeOfDayInterval1.Start = System.TimeSpan.Parse("09:00:00")
            Me.dayViewTimeCells1.VisibleTime = TimeOfDayInterval1
            '
            'dayOfWeekHeaders1
            '
            Me.dayOfWeekHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(612.0417!, 113.5!)
            Me.dayOfWeekHeaders1.Name = "dayOfWeekHeaders1"
            Me.dayOfWeekHeaders1.SizeF = New System.Drawing.SizeF(279.0!, 20.0!)
            Me.dayOfWeekHeaders1.TimeCells = Me.horizontalWeek1
            Me.dayOfWeekHeaders1.View = Me.reportWeekView1
            '
            'dayViewTimeRuler1
            '
            Me.dayViewTimeRuler1.LocationFloat = New DevExpress.Utils.PointFloat(1.041667!, 113.5!)
            Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
            Me.dayViewTimeRuler1.SizeF = New System.Drawing.SizeF(50.0!, 531.9166!)
            Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
            Me.dayViewTimeRuler1.View = Me.reportDayView1
            '
            'xrLine1
            '
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 42.00001!)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(890.0!, 8.0!)
            Me.xrLine1.StylePriority.UseBorderWidth = False
            '
            'resourceInfo1
            '
            Me.resourceInfo1.Font = New System.Drawing.Font("Times New Roman", 24.0!)
            Me.resourceInfo1.ForeColor = System.Drawing.Color.Navy
            Me.resourceInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 1.0!)
            Me.resourceInfo1.Name = "resourceInfo1"
            Me.resourceInfo1.SizeF = New System.Drawing.SizeF(872.2085!, 33.0!)
            Me.resourceInfo1.TimeCells = Me.dayViewTimeCells1
            '
            'Report
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Landscape = True
            Me.PageHeight = 850
            Me.PageWidth = 1100
            Me.Version = "10.1"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportMonthView1, Me.reportWeekView1, Me.reportDayView1})
            CType(Me.reportMonthView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.reportWeekView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
		#End Region

		Private reportWeekView1 As DevExpress.XtraScheduler.Reporting.ReportWeekView
        Private WithEvents resourceInfo1 As DevExpress.XtraScheduler.Reporting.ResourceInfo
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler
		Private dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells
		Private reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView
		Private fullWeek1 As DevExpress.XtraScheduler.Reporting.FullWeek
		Private horizontalWeek1 As DevExpress.XtraScheduler.Reporting.HorizontalWeek
		Private reportMonthView1 As DevExpress.XtraScheduler.Reporting.ReportMonthView
		Private dayOfWeekHeaders1 As DevExpress.XtraScheduler.Reporting.DayOfWeekHeaders
		Private timeIntervalInfo3 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
		Private timeIntervalInfo2 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
		Private timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo


	End Class
End Namespace
