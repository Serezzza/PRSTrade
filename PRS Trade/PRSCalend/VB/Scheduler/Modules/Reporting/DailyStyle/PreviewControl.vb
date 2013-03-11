Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler.Native

Namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle

    Public Class PreviewControl
        Inherits SingleReportPreviewControl
        Private components As System.ComponentModel.IContainer = Nothing
        Protected WithEvents chkPrintAllAppointments As DevExpress.XtraEditors.CheckEdit
        Protected WithEvents cbTimeScale As DevExpress.XtraScheduler.UI.DurationEdit
        Protected WithEvents lblTimeScale As DevExpress.XtraEditors.LabelControl
        Protected WithEvents steToTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit
        Protected WithEvents steFromTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit
        Protected WithEvents lblPrintTo As DevExpress.XtraEditors.LabelControl
        Protected WithEvents lblPrintFrom As DevExpress.XtraEditors.LabelControl
        Protected WithEvents edtEnd As DevExpress.XtraEditors.DateEdit
        Protected WithEvents edtStart As DevExpress.XtraEditors.DateEdit
        Protected WithEvents lblEnd As DevExpress.XtraEditors.LabelControl
        Protected WithEvents lblStart As DevExpress.XtraEditors.LabelControl
        Private WithEvents lbResourceCount As DevExpress.XtraEditors.LabelControl
        Private WithEvents spinResourceCount As DevExpress.XtraEditors.SpinEdit

        Private visibleResourceCount As Integer = 0
        Private visibleDayCount As Integer = 1
        Private printAllAppointments As Boolean = False
        Private timeScale As TimeSpan = TimeSpan.Zero
        Private printInterval As TimeInterval = TimeInterval.Empty
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private spinDayCount As DevExpress.XtraEditors.SpinEdit
        Private visibleTime As TimeOfDayInterval = TimeOfDayInterval.Day

        'SchedulerGroupType groupType = SchedulerGroupType.None;

        Public Shadows ReadOnly Property Report() As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property
        Private Property EndDate() As DateTime
            Get
                Return edtEnd.DateTime.AddDays(1)
            End Get
            Set(ByVal value As DateTime)
                edtEnd.DateTime = value.AddDays(-1)
            End Set
        End Property
        Private Property StartDate() As DateTime
            Get
                Return edtStart.DateTime
            End Get
            Set(ByVal value As DateTime)
                edtStart.DateTime = value
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
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.visibleResourceCount = Report.VisibleResourceCount
            Me.spinResourceCount.EditValue = visibleResourceCount
            Me.spinResourceCount.Properties.MaxValue = StoragePrintAdapter.ResourceCount

            Me.visibleDayCount = Report.VisibleDayCount
            Me.spinDayCount.EditValue = Me.visibleDayCount
            Me.spinDayCount.Properties.MinValue = 1
            Me.spinDayCount.Properties.MaxValue = 7

            visibleTime = Report.VisibleTime
            steFromTime.Time = New DateTime(visibleTime.Start.Ticks)
            steToTime.Time = New DateTime(visibleTime.End.Ticks)

            printInterval = New TimeInterval(DemoUtils.Date, DemoUtils.Date.AddDays(6))
            StartDate = printInterval.Start
            EndDate = printInterval.End
            
            timeScale = Report.TimeScale
            cbTimeScale.EditValue = timeScale

            printAllAppointments = Report.PrintAllAppointments
            chkPrintAllAppointments.Checked = printAllAppointments

        End Sub
        Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
            StoragePrintAdapter.TimeInterval = printInterval
            MyBase.UpdateReportProperties(report)

            Me.Report.VisibleResourceCount = Me.visibleResourceCount
            Me.Report.VisibleTime = Me.visibleTime
            Me.Report.TimeScale = Me.timeScale
            Me.Report.VisibleDayCount = Me.visibleDayCount

            Me.Report.PrintAllAppointments = printAllAppointments
        End Sub
#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.chkPrintAllAppointments = New DevExpress.XtraEditors.CheckEdit()
            Me.edtEnd = New DevExpress.XtraEditors.DateEdit()
            Me.edtStart = New DevExpress.XtraEditors.DateEdit()
            Me.lblEnd = New DevExpress.XtraEditors.LabelControl()
            Me.lblStart = New DevExpress.XtraEditors.LabelControl()
            Me.cbTimeScale = New DevExpress.XtraScheduler.UI.DurationEdit()
            Me.lblTimeScale = New DevExpress.XtraEditors.LabelControl()
            Me.steToTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
            Me.steFromTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
            Me.lblPrintTo = New DevExpress.XtraEditors.LabelControl()
            Me.lblPrintFrom = New DevExpress.XtraEditors.LabelControl()
            Me.lbResourceCount = New DevExpress.XtraEditors.LabelControl()
            Me.spinResourceCount = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.spinDayCount = New DevExpress.XtraEditors.SpinEdit()
            CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSettings.SuspendLayout()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkPrintAllAppointments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbTimeScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.steToTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.steFromTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinDayCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' smplEdit
            ' 
            Me.btnEdit.Location = New System.Drawing.Point(620, 61)
            ' 
            ' pnlSettings
            ' 
            Me.pnlSettings.Controls.Add(Me.labelControl1)
            Me.pnlSettings.Controls.Add(Me.lbResourceCount)
            Me.pnlSettings.Controls.Add(Me.spinDayCount)
            Me.pnlSettings.Controls.Add(Me.spinResourceCount)
            Me.pnlSettings.Controls.Add(Me.cbTimeScale)
            Me.pnlSettings.Controls.Add(Me.lblTimeScale)
            Me.pnlSettings.Controls.Add(Me.steToTime)
            Me.pnlSettings.Controls.Add(Me.steFromTime)
            Me.pnlSettings.Controls.Add(Me.lblPrintTo)
            Me.pnlSettings.Controls.Add(Me.lblPrintFrom)
            Me.pnlSettings.Controls.Add(Me.edtEnd)
            Me.pnlSettings.Controls.Add(Me.edtStart)
            Me.pnlSettings.Controls.Add(Me.lblEnd)
            Me.pnlSettings.Controls.Add(Me.lblStart)
            Me.pnlSettings.Controls.Add(Me.chkPrintAllAppointments)
            Me.pnlSettings.Size = New System.Drawing.Size(700, 94)
            '			Me.pnlSettings.Paint += New System.Windows.Forms.PaintEventHandler(Me.pnlSettings_Paint);
            Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.chkPrintAllAppointments, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lblStart, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lblEnd, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.edtStart, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.edtEnd, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lblPrintFrom, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lblPrintTo, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.steFromTime, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.steToTime, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lblTimeScale, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.cbTimeScale, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.spinResourceCount, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.spinDayCount, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.lbResourceCount, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.labelControl1, 0)
            ' 
            ' panelSeparatorControl
            ' 
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 94)
            ' 
            ' printControl
            ' 
            Me.printControl.Location = New System.Drawing.Point(0, 102)
            Me.printControl.Size = New System.Drawing.Size(700, 294)
            ' 
            ' chkPrintAllAppointments
            ' 
            Me.chkPrintAllAppointments.Location = New System.Drawing.Point(198, 64)
            Me.chkPrintAllAppointments.Name = "chkPrintAllAppointments"
            Me.chkPrintAllAppointments.Properties.AccessibleName = "Print all appointments"
            Me.chkPrintAllAppointments.Properties.AutoWidth = True
            Me.chkPrintAllAppointments.Properties.Caption = "Print all appointments"
            Me.chkPrintAllAppointments.Size = New System.Drawing.Size(126, 19)
            Me.chkPrintAllAppointments.TabIndex = 8
            '			Me.chkPrintAllAppointments.CheckedChanged += New System.EventHandler(Me.chkPrintAllAppointments_CheckedChanged);
            ' 
            ' edtEnd
            ' 
            Me.edtEnd.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
            Me.edtEnd.Location = New System.Drawing.Point(256, 37)
            Me.edtEnd.Name = "edtEnd"
            Me.edtEnd.Properties.AccessibleName = "End date:"
            Me.edtEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edtEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtEnd.Size = New System.Drawing.Size(86, 20)
            Me.edtEnd.TabIndex = 16
            '			Me.edtEnd.EditValueChanged += New System.EventHandler(Me.edtEnd_EditValueChanged);
            ' 
            ' edtStart
            ' 
            Me.edtStart.EditValue = New System.DateTime(2005, 9, 5, 0, 0, 0, 0)
            Me.edtStart.Location = New System.Drawing.Point(256, 11)
            Me.edtStart.Name = "edtStart"
            Me.edtStart.Properties.AccessibleName = "Start date:"
            Me.edtStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.edtStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtStart.Size = New System.Drawing.Size(86, 20)
            Me.edtStart.TabIndex = 15
            '			Me.edtStart.EditValueChanged += New System.EventHandler(Me.edtStart_EditValueChanged);
            ' 
            ' lblEnd
            ' 
            Me.lblEnd.AccessibleName = "End date:"
            Me.lblEnd.Location = New System.Drawing.Point(198, 41)
            Me.lblEnd.Name = "lblEnd"
            Me.lblEnd.Size = New System.Drawing.Size(47, 13)
            Me.lblEnd.TabIndex = 13
            Me.lblEnd.Text = "End date:"
            '			Me.lblEnd.Click += New System.EventHandler(Me.lblEnd_Click);
            ' 
            ' lblStart
            ' 
            Me.lblStart.AccessibleName = "Start date:"
            Me.lblStart.Location = New System.Drawing.Point(198, 15)
            Me.lblStart.Name = "lblStart"
            Me.lblStart.Size = New System.Drawing.Size(53, 13)
            Me.lblStart.TabIndex = 14
            Me.lblStart.Text = "Start date:"
            '			Me.lblStart.Click += New System.EventHandler(Me.lblStart_Click);
            ' 
            ' cbTimeScale
            ' 
            Me.cbTimeScale.EditValue = ""
            Me.cbTimeScale.Location = New System.Drawing.Point(95, 63)
            Me.cbTimeScale.Name = "cbTimeScale"
            Me.cbTimeScale.Properties.AccessibleName = "Duration:"
            Me.cbTimeScale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbTimeScale.Properties.Items.AddRange(New Object() {System.TimeSpan.Parse("00:05:00"), System.TimeSpan.Parse("00:10:00"), System.TimeSpan.Parse("00:15:00"), System.TimeSpan.Parse("00:30:00"), System.TimeSpan.Parse("01:00:00"), System.TimeSpan.Parse("02:00:00"), System.TimeSpan.Parse("03:00:00"), System.TimeSpan.Parse("04:00:00"), System.TimeSpan.Parse("05:00:00"), System.TimeSpan.Parse("06:00:00"), System.TimeSpan.Parse("07:00:00"), System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("09:00:00"), System.TimeSpan.Parse("10:00:00"), System.TimeSpan.Parse("11:00:00"), System.TimeSpan.Parse("12:00:00")})
            Me.cbTimeScale.Size = New System.Drawing.Size(85, 20)
            Me.cbTimeScale.TabIndex = 22
            '			Me.cbTimeScale.SelectedIndexChanged += New System.EventHandler(Me.cbDuration_SelectedIndexChanged);
            ' 
            ' lblTimeScale
            ' 
            Me.lblTimeScale.AccessibleName = "Time Scale:"
            Me.lblTimeScale.Location = New System.Drawing.Point(9, 67)
            Me.lblTimeScale.Name = "lblTimeScale"
            Me.lblTimeScale.Size = New System.Drawing.Size(54, 13)
            Me.lblTimeScale.TabIndex = 21
            Me.lblTimeScale.Text = "Time S&cale:"
            '			Me.lblTimeScale.Click += New System.EventHandler(Me.lblTimeScale_Click);
            ' 
            ' steToTime
            ' 
            Me.steToTime.EditValue = New System.DateTime(2005, 8, 24, 0, 0, 0, 0)
            Me.steToTime.Location = New System.Drawing.Point(416, 37)
            Me.steToTime.Name = "steToTime"
            Me.steToTime.Properties.AccessibleName = "Print to:"
            Me.steToTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.steToTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.steToTime.Size = New System.Drawing.Size(77, 20)
            Me.steToTime.TabIndex = 20
            '			Me.steToTime.EditValueChanged += New System.EventHandler(Me.steToTime_EditValueChanged_1);
            ' 
            ' steFromTime
            ' 
            Me.steFromTime.EditValue = New System.DateTime(2005, 8, 24, 0, 0, 0, 0)
            Me.steFromTime.Location = New System.Drawing.Point(416, 11)
            Me.steFromTime.Name = "steFromTime"
            Me.steFromTime.Properties.AccessibleName = "Print from:"
            Me.steFromTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.steFromTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.steFromTime.Size = New System.Drawing.Size(77, 20)
            Me.steFromTime.TabIndex = 18
            '			Me.steFromTime.EditValueChanged += New System.EventHandler(Me.steFromTime_EditValueChanged_1);
            ' 
            ' lblPrintTo
            ' 
            Me.lblPrintTo.AccessibleName = "Print to:"
            Me.lblPrintTo.Location = New System.Drawing.Point(360, 41)
            Me.lblPrintTo.Name = "lblPrintTo"
            Me.lblPrintTo.Size = New System.Drawing.Size(39, 13)
            Me.lblPrintTo.TabIndex = 19
            Me.lblPrintTo.Text = "Print &to:"
            '			Me.lblPrintTo.Click += New System.EventHandler(Me.lblPrintTo_Click);
            ' 
            ' lblPrintFrom
            ' 
            Me.lblPrintFrom.AccessibleName = "Print from:"
            Me.lblPrintFrom.Location = New System.Drawing.Point(360, 15)
            Me.lblPrintFrom.Name = "lblPrintFrom"
            Me.lblPrintFrom.Size = New System.Drawing.Size(51, 13)
            Me.lblPrintFrom.TabIndex = 17
            Me.lblPrintFrom.Text = "Print fro&m:"
            '			Me.lblPrintFrom.Click += New System.EventHandler(Me.lblPrintFrom_Click);
            ' 
            ' lbResourceCount
            ' 
            Me.lbResourceCount.Location = New System.Drawing.Point(9, 15)
            Me.lbResourceCount.Name = "lbResourceCount"
            Me.lbResourceCount.Size = New System.Drawing.Size(81, 13)
            Me.lbResourceCount.TabIndex = 39
            Me.lbResourceCount.Text = "Resource Count:"
            '			Me.lbResourceCount.Click += New System.EventHandler(Me.lbResourceCount_Click);
            ' 
            ' spinResourceCount
            ' 
            Me.spinResourceCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinResourceCount.Location = New System.Drawing.Point(95, 11)
            Me.spinResourceCount.Name = "spinResourceCount"
            Me.spinResourceCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinResourceCount.Properties.IsFloatValue = False
            Me.spinResourceCount.Properties.Mask.EditMask = "N00"
            Me.spinResourceCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinResourceCount.Size = New System.Drawing.Size(85, 20)
            Me.spinResourceCount.TabIndex = 38
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(9, 41)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(55, 13)
            Me.labelControl1.TabIndex = 39
            Me.labelControl1.Text = "Day Count:"
            '			Me.labelControl1.Click += New System.EventHandler(Me.lbResourceCount_Click);
            ' 
            ' spinDayCount
            ' 
            Me.spinDayCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinDayCount.Location = New System.Drawing.Point(95, 37)
            Me.spinDayCount.Name = "spinDayCount"
            Me.spinDayCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinDayCount.Properties.IsFloatValue = False
            Me.spinDayCount.Properties.Mask.EditMask = "N00"
            Me.spinDayCount.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinDayCount.Size = New System.Drawing.Size(85, 20)
            Me.spinDayCount.TabIndex = 38
            ' 
            ' PreviewControl
            ' 
            Me.Name = "PreviewControl"
            CType(Me.fSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.fStoragePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSettings.ResumeLayout(False)
            Me.pnlSettings.PerformLayout()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkPrintAllAppointments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbTimeScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.steToTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.steFromTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinResourceCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinDayCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        Protected Friend Overridable Sub UnsubscribeEvents()
            RemoveHandler spinDayCount.EditValueChanged, AddressOf spinDayCount_EditValueChanged
            RemoveHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
            RemoveHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
            RemoveHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
            RemoveHandler steFromTime.EditValueChanged, AddressOf steFromTime_EditValueChanged
            RemoveHandler steToTime.EditValueChanged, AddressOf steToTime_EditValueChanged
        End Sub
        Protected Friend Overridable Sub SubscribeEvents()
            AddHandler spinDayCount.EditValueChanged, AddressOf spinDayCount_EditValueChanged
            AddHandler spinResourceCount.EditValueChanged, AddressOf spinResourceCount_EditValueChanged
            AddHandler edtStart.EditValueChanged, AddressOf StartEditValueChanged
            AddHandler edtEnd.EditValueChanged, AddressOf EndEditValueChanged
            AddHandler steFromTime.EditValueChanged, AddressOf steFromTime_EditValueChanged
            AddHandler steToTime.EditValueChanged, AddressOf steToTime_EditValueChanged
            AddHandler cbTimeScale.SelectedIndexChanged, AddressOf cbDuration_SelectedIndexChanged
            AddHandler chkPrintAllAppointments.CheckedChanged, AddressOf chkPrintAllAppointments_CheckedChanged

        End Sub

        Private Sub spinResourceCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.visibleResourceCount = Convert.ToInt32(spinResourceCount.EditValue)
            UpdateActiveReport()
        End Sub
        Private Sub spinDayCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.visibleDayCount = Convert.ToInt32(spinDayCount.EditValue)
            UpdateActiveReport()
        End Sub
        Private Sub cbDuration_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.timeScale = cbTimeScale.Duration
            UpdateActiveReport()
        End Sub
        Private Sub StartEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            If (Not IsValidInterval(StartDate, EndDate)) Then
                edtEnd.EditValue = StartDate
            End If

            Me.printInterval = New TimeInterval(StartDate, EndDate)
            SubscribeEvents()
            UpdateActiveReport()
        End Sub
        Protected Friend Overridable Function IsValidInterval(ByVal start As DateTime, ByVal [end] As DateTime) As Boolean
            Return start <= [end]
        End Function
        Private Sub EndEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UnsubscribeEvents()
            If (Not IsValidInterval(StartDate, EndDate)) Then
                edtStart.EditValue = EndDate.AddDays(-1)
            End If

            Me.printInterval = New TimeInterval(StartDate, EndDate)
            SubscribeEvents()
            UpdateActiveReport()
        End Sub

        Private Sub steFromTime_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateVisibleTime()
        End Sub
        Private Sub steToTime_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateVisibleTime()
        End Sub
        Protected Friend Overridable Sub UpdateVisibleTime()
            'Debug.Assert(edtStart.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
            'Debug.Assert(edtEnd.Time.Ticks < DateTimeHelper.DaySpan.Ticks);
            Dim start As TimeSpan = steFromTime.Time.TimeOfDay
            Dim [end] As TimeSpan = steToTime.Time.TimeOfDay
            Dim duration As TimeSpan = [end].Subtract(start)
            If duration.Ticks <= 0 Then
                [end] = [end] + DateTimeHelper.DaySpan
            End If

            Me.visibleTime = New TimeOfDayInterval(start, [end])
            UpdateActiveReport()
        End Sub

        Private Sub chkPrintAllAppointments_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            printAllAppointments = chkPrintAllAppointments.Checked
            UpdateActiveReport()
        End Sub

    End Class
End Namespace

