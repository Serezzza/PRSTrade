Imports System.Windows.Forms

Public Class Postavshik_Add
    Public r_state As Boolean = False

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        With Postavshiki.DataGridView1
            If r_state = False Then
                Dim x As Integer = .RowCount - 1 '!!!!!!!!!!!!!!!!!
                With Postavshiki.PostavshikiDataSet
                    .Tables.Item("Поставщики").Rows.Add()
                End With

                .Item(0, x).Value = x + 1
                .Item(1, x).Value = TextEdit1.Text
                .Item(2, x).Value = TextEdit2.Text
                .Item(3, x).Value = TextEdit3.Text
                .Item(4, x).Value = DateEdit1.Text
                .Item(5, x).Value = SpinEdit1.Text
                .Item(6, x).Value = MemoEdit1.Text
                .Item(7, x).Value = TextEdit4.Text
                .Item(8, x).Value = MemoEdit2.Text
                SimpleButton1.Text = "Закрыть"

                My.Computer.FileSystem.WriteAllText(_PostavshikiOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Добавление поставщика: Личный № - " & TextEdit1.Text & "; Наименование - " & TextEdit2.Text & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Добавление поставщика: Личный № - " & TextEdit1.Text & "; Наименование - " & TextEdit2.Text & vbCrLf, True)

                TextEdit1.Text = ""
                TextEdit2.Text = ""
                TextEdit3.Text = ""
                DateEdit1.Text = ""
                SpinEdit1.Text = ""
                MemoEdit1.Text = ""
                TextEdit4.Text = ""
                MemoEdit2.Text = ""
            Else
                Dim x As Integer = getSelectedRow(3)
                '.Item(0, x).Value = x
                .Item(1, x).Value = TextEdit1.Text
                .Item(2, x).Value = TextEdit2.Text
                .Item(3, x).Value = TextEdit3.Text
                .Item(4, x).Value = DateEdit1.Text
                .Item(5, x).Value = SpinEdit1.Text
                .Item(6, x).Value = MemoEdit1.Text.ToString
                .Item(7, x).Value = TextEdit4.Text.ToString
                .Item(8, x).Value = MemoEdit2.Text.ToString
                SimpleButton1.Text = "Закрыть"
                My.Computer.FileSystem.WriteAllText(_PostavshikiOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Изменение поставщика: Личный № - " & TextEdit1.Text & "; Наименование - " & TextEdit2.Text & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Изменение поставщика: Личный № - " & TextEdit1.Text & "; Наименование - " & TextEdit2.Text & vbCrLf, True)
            End If
        End With
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class
