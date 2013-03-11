Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Public Partial Class MonthReport
		Inherits XtraSchedulerReport
		Implements IAutoHeightReport

		Public Sub New()
			InitializeComponent()
		End Sub

		
		Public Property CellsHeight() As Single Implements IAutoHeightReport.CellsHeight
			Get
				Return horizontalWeek.HeightF
			End Get
			Set
				horizontalWeek.HeightF = Value
			End Set
		End Property
		Public Property CellsCanShrink() As Boolean Implements IAutoHeightReport.CellsCanShrink
			Get
				Return horizontalWeek.CanShrink
			End Get
			Set
				horizontalWeek.CanShrink = Value
			End Set
		End Property
		Public Property CellsCanGrow() As Boolean Implements IAutoHeightReport.CellsCanGrow
			Get
				Return horizontalWeek.CanGrow
			End Get
			Set
				horizontalWeek.CanGrow = Value
			End Set
		End Property
	End Class
End Namespace
