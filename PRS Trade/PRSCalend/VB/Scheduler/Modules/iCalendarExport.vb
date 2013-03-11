Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.iCalendar
Imports System.IO

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class iCalendarExportModule
		Inherits DevExpress.XtraScheduler.Demos.TutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected ReadOnly Property IsCancelForRecurring() As Boolean
			Get
				Return CType(cbCancelingTypes.EditValue, UsedAppointmentType) = UsedAppointmentType.Recurring
			End Get
		End Property
		Protected ReadOnly Property IsCancelForNonRecurring() As Boolean
			Get
				Return CType(cbCancelingTypes.EditValue, UsedAppointmentType) = UsedAppointmentType.NonRecurring
			End Get
		End Property


		Private Sub iCalendarExportModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			DemoUtils.FillData(schedulerControl)
			cbCancelingTypes.EditValue = UsedAppointmentType.None
			schedulerControl.Storage.EnableReminders = True
		End Sub
		Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImport.Click
			Dim fileDialog As New SaveFileDialog()
			fileDialog.Filter = "iCalendar files (*.ics)|*.ics"
			fileDialog.FilterIndex = 1
			If fileDialog.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			Try
				Using stream As Stream = fileDialog.OpenFile()
					ExportAppointments(stream)
				End Using
			Catch
				MessageBox.Show("Error: could not export appointments")
			Finally
				AfterExportActions()
			End Try
		End Sub
		Private Sub AfterExportActions()
			ProgressBarControl1.Properties.Maximum = 100
			ProgressBarControl1.Position = 0
		End Sub
		Private Sub ExportAppointments(ByVal stream As Stream)
			If stream Is Nothing Then
				Return
			End If
			Dim exporter As New iCalendarExporter(schedulerStorage)

			ProgressBarControl1.Properties.Maximum = exporter.SourceObjectCount
			ProgressBarControl1.Position = 0

			exporter.ProductIdentifier = "-//Developer Express Inc.//XtraScheduler iCalendarExportDemo//EN"
			AddHandler exporter.AppointmentExporting, AddressOf exporter_AppointmentExporting
			exporter.Export(stream)
		End Sub
		Private Sub exporter_AppointmentExporting(ByVal sender As Object, ByVal e As AppointmentExportingEventArgs)
			ProgressBarControl1.Position += 1
			ProgressBarControl1.Update()
			Dim cancel As Boolean
			If e.Appointment.IsRecurring Then
				cancel = IsCancelForRecurring
			Else
				cancel = IsCancelForNonRecurring
			End If
			If cancel Then
				e.Cancel = True
			End If
		End Sub
	End Class
End Namespace
