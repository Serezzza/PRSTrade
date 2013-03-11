Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports DevExpress.XtraTreeList

Namespace DevExpress.XtraScheduler.Demos
    Partial Public Class ResourcesTreeModule
        Inherits DevExpress.XtraScheduler.Demos.TutorialControl
        Private lastSplitContainerControlSplitterPosition_Renamed As Integer
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub GanttViewModule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            FillData()
            UpdateControls()
        End Sub
#Region "Properties"
        Private Property LastSplitContainerControlSplitterPosition() As Integer
            Get
                Return lastSplitContainerControlSplitterPosition_Renamed
            End Get
            Set(ByVal value As Integer)
                lastSplitContainerControlSplitterPosition_Renamed = value
            End Set
        End Property
        Public ReadOnly Property ActiveTimeLineBasedView() As TimelineView
            Get
                If schedulerControl1.ActiveViewType = SchedulerViewType.Gantt Then
                    Return schedulerControl1.GanttView
                End If
                Return schedulerControl1.TimelineView
            End Get
        End Property
#End Region
#Region "FillData"
        Private Sub FillData()
            Dim connectionString As String = DemoUtils.GetFileRelativePath("Tasks.mdb")
            If connectionString.Length <= 0 Then
                Return
            End If

            DemoUtils.SetConnectionString(tasksTableAdapter.Connection, connectionString)
            'DemoUtils.SetConnectionString(taskDependenciesTableAdapter.Connection, connectionString)
            DemoUtils.SetConnectionString(resourcesTableAdapter.Connection, connectionString)

            tasksTableAdapter.Fill(Me.tasksDataSet.Tasks)
            'taskDependenciesTableAdapter.Fill(Me.tasksDataSet.TaskDependencies)
            resourcesTableAdapter.Fill(Me.tasksDataSet.Resources)

            AddHandler tasksTableAdapter.Adapter.RowUpdated, AddressOf tasksTableAdapter_RowUpdated
            'AddHandler taskDependenciesTableAdapter.Adapter.RowUpdated, AddressOf taskDependenciesTableAdapter_RowUpdated
            AddHandler resourcesTableAdapter.Adapter.RowUpdated, AddressOf resourcesTableAdapter_RowUpdated
            Me.schedulerControl1.Start = DemoUtils.Date
        End Sub
#End Region
#Region "UpdateControls"
        Private Sub UnsubscribeEvents()
            RemoveHandler chkAutoHeightCells.CheckedChanged, AddressOf chkAutoHeightCells_CheckedChanged
            RemoveHandler chkShowResourceHeaders.CheckedChanged, AddressOf chkShowResourceHeaders_CheckedChanged
            RemoveHandler splitContainerControl1.SplitterPositionChanged, AddressOf splitContainerControl1_SplitterPositionChanged
            RemoveHandler chkAutoFilterRow.CheckedChanged, AddressOf chkAutoFilterRow_CheckedChanged
            RemoveHandler chkFilterPanel.CheckedChanged, AddressOf chkFilterPanel_CheckedChanged
            UnsubscribeSpinEditEvents()
        End Sub
        Private Sub SubscribeEvents()
            AddHandler chkAutoHeightCells.CheckedChanged, AddressOf chkAutoHeightCells_CheckedChanged
            AddHandler chkShowResourceHeaders.CheckedChanged, AddressOf chkShowResourceHeaders_CheckedChanged
            AddHandler splitContainerControl1.SplitterPositionChanged, AddressOf splitContainerControl1_SplitterPositionChanged
            AddHandler chkAutoFilterRow.CheckedChanged, AddressOf chkAutoFilterRow_CheckedChanged
            AddHandler chkFilterPanel.CheckedChanged, AddressOf chkFilterPanel_CheckedChanged
            SubscribeSpinEditEvents()
        End Sub
        Private Sub SubscribeSpinEditEvents()
            AddHandler spinResurcesPerPage.EditValueChanged, AddressOf spinResurcesPerPage_EditValueChanged
        End Sub

        Private Sub UnsubscribeSpinEditEvents()
            RemoveHandler spinResurcesPerPage.EditValueChanged, AddressOf spinResurcesPerPage_EditValueChanged
        End Sub
        Private Sub UpdateControls()
            UnsubscribeEvents()
            Try
                Me.chkShowResourceHeaders.Checked = ActiveTimeLineBasedView.ShowResourceHeaders
                Me.chkAutoHeightCells.Checked = ActiveTimeLineBasedView.CellsAutoHeightOptions.Enabled
                Me.chkAutoFilterRow.Checked = resourcesTree1.OptionsView.ShowAutoFilterRow
                Me.chkFilterPanel.Checked = resourcesTree1.OptionsView.ShowFilterPanelMode <> ShowFilterPanelMode.Never
                splitContainerControl1.SplitterPosition = 230
                UpdateSpinEdit()
                LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition
            Finally
                SubscribeEvents()
            End Try
        End Sub
        Private Sub UpdateSpinEdit()
            Me.spinResurcesPerPage.EditValue = ActiveTimeLineBasedView.ResourcesPerPage
        End Sub
#End Region
#Region "RowUpdated handlers"
        Private id As Integer = 0
        Private Sub tasksTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                id = 0
                Using cmd As New OleDbCommand("SELECT @@IDENTITY", tasksTableAdapter.Connection)
                    id = CInt(Fix(cmd.ExecuteScalar()))
                End Using
                e.Row("Id") = id
            End If
        End Sub
        'Private id2 As Integer = 0
        'Private Sub taskDependenciesTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs)
        '	If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
        '		id2 = 0
        '		Using cmd As New OleDbCommand("SELECT @@IDENTITY", taskDependenciesTableAdapter.Connection)
        '			id2 = CInt(Fix(cmd.ExecuteScalar()))
        '		End Using
        '		e.Row("Id") = id2
        '	End If
        'End Sub
        Private id3 As Integer = 0
        Private Sub resourcesTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                id3 = 0
                Using cmd As New OleDbCommand("SELECT @@IDENTITY", resourcesTableAdapter.Connection)
                    id3 = CInt(Fix(cmd.ExecuteScalar()))
                End Using
                e.Row("Id") = id3
            End If
        End Sub
#End Region
#Region "Appointment"
        Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsChanged
            CommitTask()
        End Sub

        Private Sub schedulerStorage1_AppointmentsDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsDeleted
            CommitTask()
        End Sub
        Private Sub schedulerStorage1_AppointmentsInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsInserted
            CommitTask()
            schedulerStorage1.SetAppointmentId((CType(e.Objects(0), Appointment)), id)
        End Sub
        Private Sub CommitTask()
            'try {
            '    DataSet ch = this.tasksDataSet.GetChanges();
            '    TasksDataSet.TasksRow row = tasksDataSet.Tasks[0];
            '    DataTable cht = tasksDataSet.Tasks.GetChanges();
            '} catch {
            '}
            tasksTableAdapter.Update(Me.tasksDataSet)
            Me.tasksDataSet.AcceptChanges()
        End Sub
#End Region
#Region "Task Dependencies"
        'Private Sub schedulerStorage1_AppointmentDependenciesChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentDependenciesChanged
        '	CommitTaskDependency()
        'End Sub

        'Private Sub schedulerStorage1_AppointmentDependenciesDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentDependenciesDeleted
        '	CommitTaskDependency()
        'End Sub

        'Private Sub schedulerStorage1_AppointmentDependenciesInserted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentDependenciesInserted
        '	CommitTaskDependency()
        'End Sub
        'Private Sub CommitTaskDependency()
        '	taskDependenciesTableAdapter.Update(Me.tasksDataSet)
        '	Me.tasksDataSet.AcceptChanges()
        'End Sub
#End Region
#Region "UI elelents event handles"
        Private Sub chkShowResourceHeaders_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs) Handles chkShowResourceHeaders.CheckedChanged
            ActiveTimeLineBasedView.ShowResourceHeaders = chkShowResourceHeaders.Checked
        End Sub
        Private Sub chkAutoHeightCells_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs) Handles chkAutoHeightCells.CheckedChanged
            ActiveTimeLineBasedView.CellsAutoHeightOptions.Enabled = chkAutoHeightCells.Checked
        End Sub
        Private Sub spinResurcesPerPage_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinResurcesPerPage.EditValueChanged
            ActiveTimeLineBasedView.ResourcesPerPage = Convert.ToInt32(spinResurcesPerPage.EditValue)
        End Sub
#Region "ResourcesTree hide/show"
        Private Sub chkShowResourcesTree_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)

        End Sub

        Private Sub splitContainerControl1_SplitterPositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles splitContainerControl1.SplitterPositionChanged
            LastSplitContainerControlSplitterPosition = splitContainerControl1.SplitterPosition
        End Sub
#End Region

        Private Sub schedulerControl1_ActiveViewChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.ActiveViewChanged
            UnsubscribeEvents()
            Dim isGanttView As Boolean = schedulerControl1.ActiveViewType = SchedulerViewType.Gantt
            Try
                splitContainerControl1.SplitterPosition = If((isGanttView), LastSplitContainerControlSplitterPosition, 0)
            Finally
                SubscribeEvents()
            End Try
        End Sub
#End Region

        Private Sub chkAutoFilterRow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoFilterRow.CheckedChanged
            resourcesTree1.OptionsView.ShowAutoFilterRow = chkAutoFilterRow.Checked
        End Sub
        Private Sub chkFilterPanel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFilterPanel.CheckedChanged
            resourcesTree1.OptionsView.ShowFilterPanelMode = If(chkFilterPanel.Checked, ShowFilterPanelMode.Default, ShowFilterPanelMode.Never)
        End Sub

        
        Private Sub resourcesTree1_LayoutUpdated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resourcesTree1.LayoutUpdated
            UnsubscribeSpinEditEvents()
            UpdateSpinEdit()
            SubscribeSpinEditEvents()
        End Sub
    End Class
End Namespace
