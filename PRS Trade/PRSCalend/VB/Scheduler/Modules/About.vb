Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Tutorials
Imports DevExpress.Utils.About

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class About
		Inherits ucAboutPage
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Properies"
		Protected Overrides ReadOnly Property ProductText() As String
			Get
				Return "Microsoft Office Style Scheduling Controls for WinForms" & Constants.vbCrLf & Constants.vbCrLf & "Features multiple calendar view types and side-by-side calendar display. Ships with complete Microsoft Outlook style end-user interface."
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductImage() As Image
			Get
                Return DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("XtraScheduler.png", GetType(frmMain).Assembly)
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductImageLight() As Image
			Get
                Return DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("XtraScheduler_light.png", GetType(frmMain).Assembly)
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductKind() As ProductKind
			Get
				Return ProductKind.XtraScheduler
			End Get
		End Property
		#End Region
	End Class
End Namespace

