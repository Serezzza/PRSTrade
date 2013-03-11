Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight

	Public Partial Class TimelineReport
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
            Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear
            Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter
            Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth
            Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek
            Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay
            Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour
            Dim TimeScaleFixedInterval1 As DevExpress.XtraScheduler.TimeScaleFixedInterval = New DevExpress.XtraScheduler.TimeScaleFixedInterval
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.verticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
            Me.timelineCells = New DevExpress.XtraScheduler.Reporting.TimelineCells
            Me.timelineScaleHeaders1 = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
            Me.reportTimelineView1 = New DevExpress.XtraScheduler.Reporting.ReportTimelineView
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl
            Me.formatTimeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo
            CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.verticalResourceHeaders1, Me.timelineCells, Me.calendarControl1, Me.timelineScaleHeaders1, Me.formatTimeIntervalInfo1})
            Me.Detail.HeightF = 310.0!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'verticalResourceHeaders1
            '
            Me.verticalResourceHeaders1.Corners.Top = 25
            Me.verticalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(2.000046!, 157.0!)
            Me.verticalResourceHeaders1.Name = "verticalResourceHeaders1"
            Me.verticalResourceHeaders1.SizeF = New System.Drawing.SizeF(25.0!, 136.375!)
            Me.verticalResourceHeaders1.TimeCells = Me.timelineCells
            Me.verticalResourceHeaders1.View = Me.reportTimelineView1
            '
            'timelineCells
            '
            Me.timelineCells.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
            Me.timelineCells.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
            Me.timelineCells.HorizontalHeaders = Me.timelineScaleHeaders1
            Me.timelineCells.LocationFloat = New DevExpress.Utils.PointFloat(27.0!, 182.0!)
            Me.timelineCells.Name = "timelineCells"
            Me.timelineCells.SizeF = New System.Drawing.SizeF(620.0!, 110.0!)
            Me.timelineCells.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.timelineCells.View = Me.reportTimelineView1
            '
            'timelineScaleHeaders1
            '
            Me.timelineScaleHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(27.00005!, 157.0!)
            Me.timelineScaleHeaders1.Name = "timelineScaleHeaders1"
            Me.timelineScaleHeaders1.SizeF = New System.Drawing.SizeF(620.0!, 25.0!)
            Me.timelineScaleHeaders1.View = Me.reportTimelineView1
            '
            'reportTimelineView1
            '
            TimeScaleYear1.Enabled = False
            TimeScaleQuarter1.Enabled = False
            TimeScaleMonth1.Enabled = False
            TimeScaleWeek1.DisplayFormat = "MM/dd/yyyy"
            TimeScaleWeek1.Enabled = False
            TimeScaleHour1.Enabled = False
            TimeScaleFixedInterval1.Enabled = False
            Me.reportTimelineView1.Scales.Add(TimeScaleYear1)
            Me.reportTimelineView1.Scales.Add(TimeScaleQuarter1)
            Me.reportTimelineView1.Scales.Add(TimeScaleMonth1)
            Me.reportTimelineView1.Scales.Add(TimeScaleWeek1)
            Me.reportTimelineView1.Scales.Add(TimeScaleDay1)
            Me.reportTimelineView1.Scales.Add(TimeScaleHour1)
            Me.reportTimelineView1.Scales.Add(TimeScaleFixedInterval1)
            Me.reportTimelineView1.VisibleIntervalCount = 7
            Me.reportTimelineView1.VisibleResourceCount = 0
            '
            'calendarControl1
            '
            Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(292.0!, 0.0!)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.SizeF = New System.Drawing.SizeF(350.0!, 142.0!)
            Me.calendarControl1.TimeCells = Me.timelineCells
            Me.calendarControl1.View = Me.reportTimelineView1
            '
            'formatTimeIntervalInfo1
            '
            Me.formatTimeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
            Me.formatTimeIntervalInfo1.Name = "formatTimeIntervalInfo1"
            Me.formatTimeIntervalInfo1.SizeF = New System.Drawing.SizeF(283.0!, 142.0!)
            Me.formatTimeIntervalInfo1.TimeCells = Me.timelineCells
            '
            'TimelineReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "12.1"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportTimelineView1})
            CType(Me.reportTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
		#End Region

		Private timelineScaleHeaders1 As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
		Private timelineCells As DevExpress.XtraScheduler.Reporting.TimelineCells
		Private calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
		Private verticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
		Private reportTimelineView1 As DevExpress.XtraScheduler.Reporting.ReportTimelineView
		Private formatTimeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo



	End Class
End Namespace
