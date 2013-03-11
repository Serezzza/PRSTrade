Imports System.Windows.Forms

Public Enum DataTypes
    Sklad
    Personal
    Postavshiki
End Enum

Public Class FilterAdd
    Private stype As DataTypes

    Public Sub getDataType(ByVal type As DataTypes)
        stype = type
    End Sub

    Private Sub SpinEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SpinEdit1.EditValueChanged
        Select Case SpinEdit1.Value
            Case 1
                GroupControl1.Height = 89
                Me.Height = 177
            Case 2
                GroupControl1.Height = 113
                Me.Height = 201
            Case 3
                GroupControl1.Height = 142
                Me.Height = 230
        End Select
    End Sub

    Private Sub FilterAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupControl1.Height = 89
        Me.Height = 177
        SpinEdit1.Value = 1
    End Sub


    Public Sub loadColList(ByVal type As DataTypes)
        Select Case type
            Case DataTypes.Sklad
                With Sklad.DataGridView1
                    ComboBoxEdit1.Properties.Items.Clear()
                    ComboBoxEdit2.Properties.Items.Clear()
                    ComboBoxEdit3.Properties.Items.Clear()
                    Dim x As Integer = .ColumnCount - 2
                    For i As Integer = 0 To x
                        ComboBoxEdit1.Properties.Items.Add(.Columns(i).HeaderText)
                        ComboBoxEdit2.Properties.Items.Add(.Columns(i).HeaderText)
                        ComboBoxEdit3.Properties.Items.Add(.Columns(i).HeaderText)
                    Next
                End With
            Case DataTypes.Personal
                With Personal.DataGridView1
                    ComboBoxEdit1.Properties.Items.Clear()
                    ComboBoxEdit2.Properties.Items.Clear()
                    ComboBoxEdit3.Properties.Items.Clear()
                    Dim x As Integer = .ColumnCount - 2
                    For i As Integer = 0 To x
                        ComboBoxEdit1.Properties.Items.Add(.Columns(i).HeaderText)
                        ComboBoxEdit2.Properties.Items.Add(.Columns(i).HeaderText)
                        ComboBoxEdit3.Properties.Items.Add(.Columns(i).HeaderText)
                    Next
                End With
            Case DataTypes.Postavshiki
                With Postavshiki.DataGridView1
                    ComboBoxEdit1.Properties.Items.Clear()
                    ComboBoxEdit2.Properties.Items.Clear()
                    ComboBoxEdit3.Properties.Items.Clear()
                    Dim x As Integer = .ColumnCount - 2
                    For i As Integer = 0 To x
                        ComboBoxEdit1.Properties.Items.Add(.Columns(i).HeaderText)
                        ComboBoxEdit2.Properties.Items.Add(.Columns(i).HeaderText)
                        ComboBoxEdit3.Properties.Items.Add(.Columns(i).HeaderText)
                    Next
                End With
        End Select

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim dv As DataView = New DataView()
        Select Case stype
            Case DataTypes.Sklad
                dv.Table = Sklad.SkladDataSet1.Склад
            Case DataTypes.Personal
                dv.Table = Personal.PersonalDataSet.Персонал
            Case DataTypes.Postavshiki
                dv.Table = Postavshiki.PostavshikiDataSet.Поставщики
        End Select
        Try
            Select Case SpinEdit1.Value
                Case 1
                    dv.RowFilter = "[" & ComboBoxEdit1.Text & "] " & ComboBoxEdit4.Text & " '" & TextEdit1.Text & "'"
                Case 2
                    dv.RowFilter = "[" & ComboBoxEdit1.Text & "] " & ComboBoxEdit4.Text & " '" & TextEdit1.Text & "' AND [" & ComboBoxEdit2.Text & "] " & ComboBoxEdit5.Text & " '" & TextEdit2.Text & "'"
                Case 3
                    dv.RowFilter = "[" & ComboBoxEdit1.Text & "] " & ComboBoxEdit4.Text & " '" & TextEdit1.Text & "' AND [" & ComboBoxEdit2.Text & "] " & ComboBoxEdit5.Text & " '" & TextEdit2.Text & "' AND [" & ComboBoxEdit3.Text & "] " & ComboBoxEdit6.Text & " '" & TextEdit3.Text & "'"
            End Select
        Catch
            MsgBox("Допущена ошибка в составлении условия", MsgBoxStyle.Critical, "PRS Trade")
        End Try
        Select Case stype
            Case DataTypes.Sklad
                Sklad.DataGridView1.DataSource = dv
            Case DataTypes.Personal
                Personal.DataGridView1.DataSource = dv
            Case DataTypes.Postavshiki
                Postavshiki.DataGridView1.DataSource = dv
        End Select

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim dv As DataView = New DataView()
        Select Case stype
            Case DataTypes.Sklad
                dv.Table = Sklad.SkladDataSet1.Склад
                dv.RowFilter = String.Empty
                Sklad.DataGridView1.DataSource = dv
            Case DataTypes.Personal
                dv.Table = Personal.PersonalDataSet.Персонал
                dv.RowFilter = String.Empty
                Personal.DataGridView1.DataSource = dv
            Case DataTypes.Postavshiki
                dv.Table = Postavshiki.PostavshikiDataSet.Поставщики
                dv.RowFilter = String.Empty
                Postavshiki.DataGridView1.DataSource = dv
        End Select
        ComboBoxEdit1.Text = ""
        ComboBoxEdit2.Text = ""
        ComboBoxEdit3.Text = ""
        ComboBoxEdit4.Text = ""
        ComboBoxEdit5.Text = ""
        ComboBoxEdit6.Text = ""
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
    End Sub
End Class
