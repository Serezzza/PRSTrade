Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.Reporting

Namespace DevExpress.XtraScheduler.Demos.Reporting.AutoHeight
	''' <summary>
	''' Summary description for Report.
	''' </summary>
	Public Partial Class TimelineReport
		Inherits XtraSchedulerReport
		Implements IAutoHeightReport


		Public Sub New()

			InitializeComponent()
		End Sub
		
		Public Property CellsHeight() As Single Implements IAutoHeightReport.CellsHeight
			Get
				Return timelineCells.HeightF
			End Get
			Set
				timelineCells.HeightF = Value
			End Set
		End Property
		Public Property CellsCanShrink() As Boolean Implements IAutoHeightReport.CellsCanShrink
			Get
				Return timelineCells.CanShrink
			End Get
			Set
				timelineCells.CanShrink = Value
			End Set
		End Property
		Public Property CellsCanGrow() As Boolean Implements IAutoHeightReport.CellsCanGrow
			Get
				Return timelineCells.CanGrow
			End Get
			Set
				timelineCells.CanGrow = Value
			End Set
        End Property
	End Class
End Namespace
