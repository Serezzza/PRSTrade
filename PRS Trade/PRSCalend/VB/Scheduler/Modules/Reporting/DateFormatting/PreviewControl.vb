Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services.Implementation
Imports System.Globalization

Namespace DevExpress.XtraScheduler.Demos.Reporting.DateFormatting

	Public Class PreviewControl
		Inherits SingleReportPreviewControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private grHorzApt As GroupControl
		Private grVertApt As GroupControl
		Private WithEvents cmbVertAptEnd As ComboBoxEdit
		Private WithEvents cmbVertAptStart As ComboBoxEdit
		Private labelControl6 As LabelControl
		Private WithEvents cmbHorzAptEnd As ComboBoxEdit
		Private labelControl4 As LabelControl
		Private WithEvents cmbHorzAptStart As ComboBoxEdit
		Private groupControl1 As GroupControl
		Private labelControl7 As LabelControl
		Private WithEvents cmbHeaderCaptions As ComboBoxEdit
		Private labelControl3 As LabelControl
		Private labelControl2 As LabelControl
		Private labelControl1 As LabelControl


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
			StoragePrintAdapter.TimeInterval = New TimeInterval(DemoUtils.Date, TimeSpan.FromDays(21))
		End Sub
		Private Sub InitializeControlValues()
			PopulateFormatCombo(cmbHorzAptStart)
			PopulateFormatCombo(cmbHorzAptEnd)
			PopulateFormatCombo(cmbVertAptStart)
			PopulateFormatCombo(cmbVertAptEnd)

			PopulateFormatCombo(cmbHeaderCaptions)

		End Sub
		Private Sub PopulateFormatCombo(ByVal comboBox As ComboBoxEdit)
			comboBox.Properties.Items.Clear()
			comboBox.Properties.Items.Add("Default")
			comboBox.Properties.Items.AddRange(DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns())
			comboBox.SelectedIndex = 0
		End Sub
		Protected Overrides Sub UpdateReportProperties(ByVal report As XtraSchedulerReport)
			MyBase.UpdateReportProperties(report)
			UpdateFormatServices()
		End Sub
		Public Sub UpdateFormatServices()
			StoragePrintAdapter.RemoveService(GetType(IHeaderCaptionService))
			Dim customHeaderCaptionService As IHeaderCaptionService = New CustomHeaderCaptionService(cmbHeaderCaptions.Text)
			StoragePrintAdapter.AddService(GetType(IHeaderCaptionService), customHeaderCaptionService)

			StoragePrintAdapter.RemoveService(GetType(IAppointmentFormatStringService))
			Dim customAptFormatService As CustomAppointmentFormatStringService = New CustomAppointmentFormatStringService()
			customAptFormatService.HorizontalAppointmentStart = cmbHorzAptStart.Text
			customAptFormatService.HorizontalAppointmentEnd = cmbHorzAptEnd.Text
			customAptFormatService.VerticalAppointmentStart = cmbVertAptStart.Text
			customAptFormatService.VerticalAppointmentEnd = cmbVertAptEnd.Text
			StoragePrintAdapter.AddService(GetType(IAppointmentFormatStringService), customAptFormatService)
		End Sub


		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
			Me.grHorzApt = New DevExpress.XtraEditors.GroupControl()
			Me.cmbHorzAptEnd = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.cmbHorzAptStart = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.grVertApt = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.cmbVertAptEnd = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbVertAptStart = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.cmbHeaderCaptions = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).BeginInit()

			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSettings.SuspendLayout()
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.grHorzApt, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grHorzApt.SuspendLayout()
			CType(Me.cmbHorzAptEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbHorzAptStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.grVertApt, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grVertApt.SuspendLayout()
			CType(Me.cmbVertAptEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbVertAptStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.cmbHeaderCaptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' smplEdit
			' 
			Me.btnEdit.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnEdit.Location = New System.Drawing.Point(476, 97)
			' 
			' pnlSettings
			' 
			Me.pnlSettings.Controls.Add(Me.groupControl1)
			Me.pnlSettings.Controls.Add(Me.grVertApt)
			Me.pnlSettings.Controls.Add(Me.grHorzApt)
			Me.pnlSettings.Size = New System.Drawing.Size(700, 141)
			Me.pnlSettings.Controls.SetChildIndex(Me.btnEdit, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.grHorzApt, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.grVertApt, 0)
			Me.pnlSettings.Controls.SetChildIndex(Me.groupControl1, 0)
			' 
			' panelSeparatorControl
			' 
			Me.panelSeparatorControl.Location = New System.Drawing.Point(0, 141)
			' 
			' printControl
			' 
			Me.printControl.Location = New System.Drawing.Point(0, 149)
			Me.printControl.Size = New System.Drawing.Size(700, 247)
			' 
			' grHorzApt
			' 
			Me.grHorzApt.Controls.Add(Me.cmbHorzAptEnd)
			Me.grHorzApt.Controls.Add(Me.labelControl4)
			Me.grHorzApt.Controls.Add(Me.cmbHorzAptStart)
			Me.grHorzApt.Controls.Add(Me.labelControl1)
			Me.grHorzApt.Location = New System.Drawing.Point(8, 8)
			Me.grHorzApt.Name = "grHorzApt"
			Me.grHorzApt.Size = New System.Drawing.Size(220, 125)
			Me.grHorzApt.TabIndex = 54
			Me.grHorzApt.Text = "Horizontal Appointment"
			' 
			' cmbHorzAptEnd
			' 
			Me.cmbHorzAptEnd.Location = New System.Drawing.Point(12, 93)
			Me.cmbHorzAptEnd.Name = "cmbHorzAptEnd"
			Me.cmbHorzAptEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", Nothing, Nothing, True)})
			Me.cmbHorzAptEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbHorzAptEnd.Size = New System.Drawing.Size(196, 20)
			Me.cmbHorzAptEnd.TabIndex = 53
'			Me.cmbHorzAptEnd.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(12, 74)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(85, 13)
			Me.labelControl4.TabIndex = 52
			Me.labelControl4.Text = "End Date Format:"
			' 
			' cmbHorzAptStart
			' 
			Me.cmbHorzAptStart.Location = New System.Drawing.Point(12, 48)
			Me.cmbHorzAptStart.Name = "cmbHorzAptStart"
			Me.cmbHorzAptStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", Nothing, Nothing, True)})
			Me.cmbHorzAptStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbHorzAptStart.Size = New System.Drawing.Size(196, 20)
			Me.cmbHorzAptStart.TabIndex = 51
'			Me.cmbHorzAptStart.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 29)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(91, 13)
			Me.labelControl1.TabIndex = 50
			Me.labelControl1.Text = "Start Date Format:"
			' 
			' grVertApt
			' 
			Me.grVertApt.Controls.Add(Me.labelControl3)
			Me.grVertApt.Controls.Add(Me.labelControl2)
			Me.grVertApt.Controls.Add(Me.cmbVertAptEnd)
			Me.grVertApt.Controls.Add(Me.cmbVertAptStart)
			Me.grVertApt.Controls.Add(Me.labelControl6)
			Me.grVertApt.Location = New System.Drawing.Point(234, 8)
			Me.grVertApt.Name = "grVertApt"
			Me.grVertApt.Size = New System.Drawing.Size(220, 125)
			Me.grVertApt.TabIndex = 55
			Me.grVertApt.Text = "Vertical Appointment"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(12, 74)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(85, 13)
			Me.labelControl3.TabIndex = 55
			Me.labelControl3.Text = "End Date Format:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 29)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(91, 13)
			Me.labelControl2.TabIndex = 54
			Me.labelControl2.Text = "Start Date Format:"
			' 
			' cmbVertAptEnd
			' 
			Me.cmbVertAptEnd.Location = New System.Drawing.Point(12, 93)
			Me.cmbVertAptEnd.Name = "cmbVertAptEnd"
			Me.cmbVertAptEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
			Me.cmbVertAptEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbVertAptEnd.Size = New System.Drawing.Size(196, 20)
			Me.cmbVertAptEnd.TabIndex = 53
'			Me.cmbVertAptEnd.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' cmbVertAptStart
			' 
			Me.cmbVertAptStart.Location = New System.Drawing.Point(12, 48)
			Me.cmbVertAptStart.Name = "cmbVertAptStart"
			Me.cmbVertAptStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
			Me.cmbVertAptStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbVertAptStart.Size = New System.Drawing.Size(196, 20)
			Me.cmbVertAptStart.TabIndex = 51
'			Me.cmbVertAptStart.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' labelControl6
			' 
			Me.labelControl6.Location = New System.Drawing.Point(5, 24)
			Me.labelControl6.Name = "labelControl6"
			Me.labelControl6.Size = New System.Drawing.Size(0, 13)
			Me.labelControl6.TabIndex = 50
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.cmbHeaderCaptions)
			Me.groupControl1.Controls.Add(Me.labelControl7)
			Me.groupControl1.Location = New System.Drawing.Point(464, 8)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(220, 80)
			Me.groupControl1.TabIndex = 56
			Me.groupControl1.Text = "Day Headers"
			' 
			' cmbHeaderCaptions
			' 
			Me.cmbHeaderCaptions.Location = New System.Drawing.Point(12, 48)
			Me.cmbHeaderCaptions.Name = "cmbHeaderCaptions"
			Me.cmbHeaderCaptions.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.cmbHeaderCaptions.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbHeaderCaptions.Size = New System.Drawing.Size(196, 20)
			Me.cmbHeaderCaptions.TabIndex = 53
'			Me.cmbHeaderCaptions.SelectedIndexChanged += New System.EventHandler(Me.cmbHorzAptStart_SelectedIndexChanged);
			' 
			' labelControl7
			' 
			Me.labelControl7.Location = New System.Drawing.Point(12, 29)
			Me.labelControl7.Name = "labelControl7"
			Me.labelControl7.Size = New System.Drawing.Size(38, 13)
			Me.labelControl7.TabIndex = 50
			Me.labelControl7.Text = "Format:"
			' 
			' PreviewControl
			' 
			Me.Name = "PreviewControl"
			CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.storagePrintAdapter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSettings.ResumeLayout(False)
			CType(Me.panelSeparatorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.grHorzApt, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grHorzApt.ResumeLayout(False)
			Me.grHorzApt.PerformLayout()
			CType(Me.cmbHorzAptEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbHorzAptStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.grVertApt, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grVertApt.ResumeLayout(False)
			Me.grVertApt.PerformLayout()
			CType(Me.cmbVertAptEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbVertAptStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.cmbHeaderCaptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub cmbHorzAptStart_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbHorzAptEnd.SelectedIndexChanged, cmbHorzAptStart.SelectedIndexChanged, cmbVertAptEnd.SelectedIndexChanged, cmbVertAptStart.SelectedIndexChanged, cmbHeaderCaptions.SelectedIndexChanged
			UpdateActiveReport()
		End Sub

	End Class

   Public Class CustomHeaderCaptionService
	   Inherits HeaderCaptionServiceWrapper
	   Private format As String
		Public Sub New(ByVal format As String)
			MyBase.New(New HeaderCaptionService())
			Me.format = format
		End Sub
	   Protected Overridable Function CreateFormat(ByVal format As String) As String
		   If format = "Default" Then
			   Return String.Empty
		   End If
		   Return String.Format("{{0:{0}}}", format)
	   End Function
	   Public Overrides Function GetDayColumnHeaderCaption(ByVal header As DayHeader) As String
			Return CreateFormat(format)
	   End Function
   End Class
	Public Class CustomAppointmentFormatStringService
		Inherits AppointmentFormatStringServiceWrapper
		Private horizontalAppointmentStart_Renamed As String
		Private horizontalAppointmentEnd_Renamed As String
		Private verticalAppointmentStart_Renamed As String
		Private verticalAppointmentEnd_Renamed As String

		Public Sub New()
			MyBase.New(New AppointmentFormatStringService())
		End Sub
		Public Property HorizontalAppointmentStart() As String
			Get
				Return horizontalAppointmentStart_Renamed
			End Get
			Set
				horizontalAppointmentStart_Renamed = Value
			End Set
		End Property
		Public Property HorizontalAppointmentEnd() As String
			Get
				Return horizontalAppointmentEnd_Renamed
			End Get
			Set
				horizontalAppointmentEnd_Renamed = Value
			End Set
		End Property
		Public Property VerticalAppointmentStart() As String
			Get
				Return verticalAppointmentStart_Renamed
			End Get
			Set
				verticalAppointmentStart_Renamed = Value
			End Set
		End Property
		Public Property VerticalAppointmentEnd() As String
			Get
				Return verticalAppointmentEnd_Renamed
			End Get
			Set
				verticalAppointmentEnd_Renamed = Value
			End Set
		End Property

		Protected Overridable Function CreateFormat(ByVal format As String) As String
			If format = "Default" Then
				Return String.Empty
			End If
			Return String.Format("{{0:{0}}} ", format)
		End Function
		Public Overrides Function GetHorizontalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(horizontalAppointmentStart_Renamed)
		End Function
		Public Overrides Function GetHorizontalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(horizontalAppointmentEnd_Renamed)
		End Function
		Public Overrides Function GetVerticalAppointmentStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(verticalAppointmentStart_Renamed)
		End Function
		Public Overrides Function GetVerticalAppointmentEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return CreateFormat(verticalAppointmentEnd_Renamed)
		End Function
		Public Overrides Function GetContinueItemStartFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return MyBase.GetContinueItemStartFormat(aptViewInfo)
		End Function
		Public Overrides Function GetContinueItemEndFormat(ByVal aptViewInfo As IAppointmentViewInfo) As String
			Return MyBase.GetContinueItemEndFormat(aptViewInfo)
		End Function
	End Class


End Namespace

