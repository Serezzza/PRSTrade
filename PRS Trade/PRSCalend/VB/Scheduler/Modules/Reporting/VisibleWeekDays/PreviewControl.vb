Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Demos.Reporting.DateFormatting

Namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays

	Public Class PreviewControl
		Inherits ReportPreviewControlBase
		Private components As System.ComponentModel.IContainer = Nothing
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents weekDaysCheckEdit1 As DevExpress.XtraScheduler.UI.WeekDaysCheckEdit
		Private visibleWeekDays_Renamed As WeekDays = WeekDays.EveryDay
		Private monthReport_Renamed As MonthReport
		Private WithEvents rgrpView As DevExpress.XtraEditors.RadioGroup
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private dayReport_Renamed As DayReport

		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			InitializeControlValues()
		End Sub
		Private ReadOnly Property ViewType() As SchedulerViewType
			Get
				Return CType(rgrpView.EditValue, SchedulerViewType)
			End Get
		End Property
		Private ReadOnly Property MonthReport() As MonthReport
			Get
				Return monthReport_Renamed
			End Get
		End Property
		Private ReadOnly Property DayReport() As DayReport
			Get
				Return dayReport_Renamed
			End Get
		End Property
		Private Property VisibleWeekDays() As WeekDays
			Get
				Return visibleWeekDays_Renamed
			End Get
			Set(ByVal value As WeekDays)
				visibleWeekDays_Renamed = value
			End Set
		End Property

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		Protected Overrides Sub CreateReports()
			If monthReport_Renamed IsNot Nothing Then
				monthReport_Renamed.Dispose()
			End If
			Me.monthReport_Renamed = New MonthReport()
			If dayReport_Renamed IsNot Nothing Then
				dayReport_Renamed.Dispose()
			End If
			Me.dayReport_Renamed = New DayReport()
		End Sub
		Protected Overrides Function GetActiveReport() As XtraSchedulerReport
			If ViewType = SchedulerViewType.Month Then
				Return MonthReport
			Else
				Return DayReport
			End If
		End Function
		Protected Overrides Sub InitAdapterTimeInterval()
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(7 * 8))
		End Sub
		Private Sub InitializeControlValues()
			Dim report As IVisibleWeekDaysReport = CType(GetActiveReport(), IVisibleWeekDaysReport)
			Me.VisibleWeekDays = report.VisibleWeekDays

		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
			If ViewType = SchedulerViewType.Month Then
				CType(report, MonthReport).VisibleWeekDays = Me.VisibleWeekDays
			Else
				Dim dayReport As DayReport = CType(report, DayReport)
				dayReport.VisibleWeekDays = Me.VisibleWeekDays
				dayReport.DayCount = CalculateDayCount()
			End If
			UpdateFormatServices()
		End Sub
		Private Function CalculateDayCount() As Integer
			Dim dayCount As Integer = DevExpress.XtraScheduler.Native.DateTimeHelper.ToDayOfWeeks(Me.VisibleWeekDays).Length
			If dayCount = 0 Then
				Return 7
			Else
				Return dayCount
			End If
		End Function
		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.weekDaysCheckEdit1 = New DevExpress.XtraScheduler.UI.WeekDaysCheckEdit()
			Me.rgrpView = New DevExpress.XtraEditors.RadioGroup()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.groupControl1)
			Me.pnlSettings.Controls.Add(Me.groupControl2)
			Me.pnlSettings.Size = New System.Drawing.Size(720, 94)
			Me.pnlSettings.Controls.SetChildIndex(Me.groupControl2, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.groupControl1, 0)
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 94)
			Me.panelSeparatorControl.Size = New System.Drawing.Size(720, 10)
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 104)
			Me.printControl.Size = New System.Drawing.Size(720, 337)
			' 
			' btnEdit
			' 
			Me.btnEdit.Location = New System.Drawing.Point(640, 64)
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.weekDaysCheckEdit1)
			Me.groupControl2.Location = New System.Drawing.Point(99, 8)
			Me.groupControl2.Margin = New System.Windows.Forms.Padding(0)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(534, 79)
			Me.groupControl2.TabIndex = 79
			Me.groupControl2.Text = "Visible Weekdays"
			' 
			' weekDaysCheckEdit1
			' 
			Me.weekDaysCheckEdit1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.weekDaysCheckEdit1.Appearance.Options.UseBackColor = True
			Me.weekDaysCheckEdit1.Location = New System.Drawing.Point(11, 38)
			Me.weekDaysCheckEdit1.Margin = New System.Windows.Forms.Padding(0)
			Me.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1"
			Me.weekDaysCheckEdit1.Size = New System.Drawing.Size(501, 41)
			Me.weekDaysCheckEdit1.TabIndex = 6
'			Me.weekDaysCheckEdit1.WeekDaysChanged += New System.EventHandler(Me.weekDaysCheckEdit1_WeekDaysChanged_1);
			' 
			' rgrpView
			' 
			Me.rgrpView.EditValue = DevExpress.XtraScheduler.SchedulerViewType.Month
			Me.rgrpView.Location = New System.Drawing.Point(10, 20)
			Me.rgrpView.Name = "rgrpView"
			Me.rgrpView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgrpView.Properties.Appearance.Options.UseBackColor = True
			Me.rgrpView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgrpView.Properties.Columns = 1
            Me.rgrpView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Day, "Day"), New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraScheduler.SchedulerViewType.Month, "Month")})
			Me.rgrpView.Size = New System.Drawing.Size(66, 59)
			Me.rgrpView.TabIndex = 81
'			Me.rgrpView.SelectedIndexChanged += New System.EventHandler(Me.rgrpView_SelectedIndexChanged_1);
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.rgrpView)
			Me.groupControl1.Location = New System.Drawing.Point(7, 8)
			Me.groupControl1.Margin = New System.Windows.Forms.Padding(0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(87, 79)
			Me.groupControl1.TabIndex = 83
			Me.groupControl1.Text = "Report Type"
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
			Me.Size = New System.Drawing.Size(720, 441)
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.weekDaysCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgrpView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub weekDaysCheckEdit1_WeekDaysChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles weekDaysCheckEdit1.WeekDaysChanged
			Me.VisibleWeekDays = weekDaysCheckEdit1.WeekDays
			UpdateActiveReport()
		End Sub

		Private Sub rgrpView_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles rgrpView.SelectedIndexChanged
			Me.VisibleWeekDays = weekDaysCheckEdit1.WeekDays
			UpdateActiveReport()
		End Sub

		Public Sub UpdateFormatServices()
			StoragePrintAdapter.RemoveService(GetType(IHeaderCaptionService))
            Dim customHeaderCaptionService As IHeaderCaptionService = New CustomHeaderCaptionService("MM/dd, ddd")
			StoragePrintAdapter.AddService(GetType(IHeaderCaptionService), customHeaderCaptionService)
		End Sub
	End Class
	Public Interface IVisibleWeekDaysReport
		Property VisibleWeekDays() As WeekDays
	End Interface
End Namespace

