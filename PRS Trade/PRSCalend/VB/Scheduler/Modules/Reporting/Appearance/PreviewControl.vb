Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos.Reporting.Appearance

    Public Class PreviewControl
        Inherits SingleReportPreviewControl
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents btnViewAppearance As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnResourceColorSchemas As DevExpress.XtraEditors.SimpleButton
        Private grPrintColorSchema As DevExpress.XtraEditors.GroupControl
        Private WithEvents cmbAppointmentSchema As DevExpress.XtraEditors.ImageComboBoxEdit
        Protected WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents cmbReportSchema As DevExpress.XtraEditors.ImageComboBoxEdit
        Protected lblReportSchema As DevExpress.XtraEditors.LabelControl

        Public Shadows ReadOnly Property Report() As Report
            Get
                Return CType(MyBase.Report, Report)
            End Get
        End Property

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            InitializeControlValues()
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
        Protected Overrides Sub InitAdapterTimeInterval()
            StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(2))
        End Sub
        Private Sub InitializeControlValues()
            cmbReportSchema.EditValue = Report.ReportColorSchema
            cmbAppointmentSchema.EditValue = Report.AppointmentsColorSchema
        End Sub
        Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
            MyBase.UpdateReportProperties(report)
            Me.Report.ReportColorSchema = CType(cmbReportSchema.EditValue, PrintColorSchema)
            Me.Report.AppointmentsColorSchema = CType(cmbAppointmentSchema.EditValue, PrintColorSchema)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewControl))
            Me.btnViewAppearance = New DevExpress.XtraEditors.SimpleButton()
            Me.btnResourceColorSchemas = New DevExpress.XtraEditors.SimpleButton()
            Me.grPrintColorSchema = New DevExpress.XtraEditors.GroupControl()
            Me.cmbAppointmentSchema = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.cmbReportSchema = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.lblReportSchema = New DevExpress.XtraEditors.LabelControl()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSettings.SuspendLayout()
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grPrintColorSchema, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grPrintColorSchema.SuspendLayout()
            CType(Me.cmbAppointmentSchema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbReportSchema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' smplEdit
            ' 
            Me.btnEdit.Location = New System.Drawing.Point(620, 33)
            ' 
            ' fPrintBarManager
            ' 
            Me.fPrintBarManager.ImageStream = (CType(resources.GetObject("fPrintBarManager.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            ' 
            ' pnlSettings
            ' 
            Me.pnlSettings.Controls.Add(Me.grPrintColorSchema)
            Me.pnlSettings.Controls.Add(Me.btnResourceColorSchemas)
            Me.pnlSettings.Controls.Add(Me.btnViewAppearance)
            Me.pnlSettings.Size = New System.Drawing.Size(700, 66)
            Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.btnViewAppearance, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.btnResourceColorSchemas, 0)
            Me.pnlSettings.Controls.SetChildIndex(Me.grPrintColorSchema, 0)
            ' 
            ' panelSeparatorControl
            ' 
            Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 66)
            ' 
            ' printControl
            ' 
            Me.printControl.Location = New System.Drawing.Point(0, 74)
            Me.printControl.Size = New System.Drawing.Size(700, 322)
            ' 
            ' btnViewAppearance
            ' 
            Me.btnViewAppearance.ImageIndex = 2
            Me.btnViewAppearance.Location = New System.Drawing.Point(16, 5)
            Me.btnViewAppearance.Name = "btnViewAppearance"
            Me.btnViewAppearance.Size = New System.Drawing.Size(175, 24)
            Me.btnViewAppearance.TabIndex = 0
            Me.btnViewAppearance.Text = "&Edit View Appearance..."
            '			Me.btnViewAppearance.Click += New System.EventHandler(Me.btnEditAppearance_Click);
            ' 
            ' btnResourceColorSchemas
            ' 
            Me.btnResourceColorSchemas.ImageIndex = 2
            Me.btnResourceColorSchemas.Location = New System.Drawing.Point(16, 35)
            Me.btnResourceColorSchemas.Name = "btnResourceColorSchemas"
            Me.btnResourceColorSchemas.Size = New System.Drawing.Size(175, 24)
            Me.btnResourceColorSchemas.TabIndex = 1
            Me.btnResourceColorSchemas.Text = "&Edit Resource Color Schemas..."
            '			Me.btnResourceColorSchemas.Click += New System.EventHandler(Me.btnResourceColorSchemas_Click);
            ' 
            ' grPrintColorSchema
            ' 
            Me.grPrintColorSchema.Controls.Add(Me.cmbAppointmentSchema)
            Me.grPrintColorSchema.Controls.Add(Me.labelControl1)
            Me.grPrintColorSchema.Controls.Add(Me.cmbReportSchema)
            Me.grPrintColorSchema.Controls.Add(Me.lblReportSchema)
            Me.grPrintColorSchema.Location = New System.Drawing.Point(209, 5)
            Me.grPrintColorSchema.Name = "grPrintColorSchema"
            Me.grPrintColorSchema.Size = New System.Drawing.Size(345, 53)
            Me.grPrintColorSchema.TabIndex = 2
            Me.grPrintColorSchema.Text = "Print Color Schema"
            ' 
            ' cmbAppointmentSchema
            ' 
            Me.cmbAppointmentSchema.EditValue = DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default
            Me.cmbAppointmentSchema.Location = New System.Drawing.Point(232, 25)
            Me.cmbAppointmentSchema.Name = "cmbAppointmentSchema"
            Me.cmbAppointmentSchema.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbAppointmentSchema.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Default", DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("FullColor", DevExpress.XtraScheduler.Reporting.PrintColorSchema.FullColor, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayScale", DevExpress.XtraScheduler.Reporting.PrintColorSchema.GrayScale, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", DevExpress.XtraScheduler.Reporting.PrintColorSchema.BlackAndWhite, -1)})
            Me.cmbAppointmentSchema.Size = New System.Drawing.Size(100, 20)
            Me.cmbAppointmentSchema.TabIndex = 1
            '			Me.cmbAppointmentSchema.SelectedIndexChanged += New System.EventHandler(Me.cmbAppointmentSchema_SelectedIndexChanged);
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AccessibleName = "ReportSchema:"
            Me.labelControl1.Location = New System.Drawing.Point(160, 28)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(66, 13)
            Me.labelControl1.TabIndex = 91
            Me.labelControl1.Text = "Appointments"
            ' 
            ' cmbReportSchema
            ' 
            Me.cmbReportSchema.EditValue = DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default
            Me.cmbReportSchema.Location = New System.Drawing.Point(44, 25)
            Me.cmbReportSchema.Name = "cmbReportSchema"
            Me.cmbReportSchema.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cmbReportSchema.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Default", DevExpress.XtraScheduler.Reporting.PrintColorSchema.Default, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("FullColor", DevExpress.XtraScheduler.Reporting.PrintColorSchema.FullColor, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayScale", DevExpress.XtraScheduler.Reporting.PrintColorSchema.GrayScale, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("BlackAndWhite", DevExpress.XtraScheduler.Reporting.PrintColorSchema.BlackAndWhite, -1)})
            Me.cmbReportSchema.Size = New System.Drawing.Size(100, 20)
            Me.cmbReportSchema.TabIndex = 0
            '			Me.cmbReportSchema.SelectedIndexChanged += New System.EventHandler(Me.cmbReportSchema_SelectedIndexChanged);
            ' 
            ' lblReportSchema
            ' 
            Me.lblReportSchema.AccessibleName = "ReportSchema:"
            Me.lblReportSchema.Location = New System.Drawing.Point(5, 28)
            Me.lblReportSchema.Name = "lblReportSchema"
            Me.lblReportSchema.Size = New System.Drawing.Size(33, 13)
            Me.lblReportSchema.TabIndex = 89
            Me.lblReportSchema.Text = "Report"
            ' 
            ' PreviewControl
            ' 
            Me.Name = "PreviewControl"
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.fPrintBarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSettings.ResumeLayout(False)
            CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grPrintColorSchema, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grPrintColorSchema.ResumeLayout(False)
            Me.grPrintColorSchema.PerformLayout()
            CType(Me.cmbAppointmentSchema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbReportSchema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        Private Sub btnEditAppearance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewAppearance.Click
            AddHandler Report.Appearances.Changed, AddressOf Appearances_Changed
            Try
                Dim frm As AppearancesEditForm = New AppearancesEditForm(Report.Appearances, Me.FindForm())
                frm.ShowDialog()
            Finally
                RemoveHandler Report.Appearances.Changed, AddressOf Appearances_Changed
            End Try
        End Sub
        Private Sub Appearances_Changed(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub

        Private Sub btnResourceColorSchemas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResourceColorSchemas.Click
            AddHandler StoragePrintAdapter.ResourceColorsChanged, AddressOf StoragePrintAdapter_ResourceColorsChanged
            Try
                Dim frm As ColorSchemasEditForm = New ColorSchemasEditForm(StoragePrintAdapter.ResourceColorSchemas, Me.FindForm())
                frm.ShowDialog()
            Finally
                RemoveHandler StoragePrintAdapter.ResourceColorsChanged, AddressOf StoragePrintAdapter_ResourceColorsChanged
            End Try
        End Sub

        Private Sub StoragePrintAdapter_ResourceColorsChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateActiveReport()
        End Sub
        Public Sub ResourceColorSchemasChanged(ByVal sender As Object, ByVal e As CollectionChangedEventArgs(Of SchedulerColorSchema))
            UpdateActiveReport()
        End Sub

        Private Sub cmbAppointmentSchema_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAppointmentSchema.SelectedIndexChanged
            UpdateActiveReport()
        End Sub

        Private Sub cmbReportSchema_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbReportSchema.SelectedIndexChanged
            UpdateActiveReport()
        End Sub
    End Class
End Namespace

