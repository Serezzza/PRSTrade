Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins

Imports System.Windows.Forms
Imports System.Xml
Imports PRS_Trade_v._1._0.PRSDev

Public Class Sklad_AddTov
    Private Xml As New XmlDocument()

    Private tmp_shtrih As String = ""
    Public r_state As Boolean = False

    Private Const msg_normal As String = "Заполните поля для добавления товара. Для получения справки нажмите F1."

    Private Sub Sklad_AddTov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PostavshikiDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
        Me.ПоставщикиTableAdapter.Fill(Me.PostavshikiDataSet.Поставщики)
        TextEdit2.Width = 143
        save_shtrih.Visible = False
        If TextEdit2.Text <> "" Then
            AxBarcode1.Text = TextEdit2.Text
        Else
            AxBarcode1.Text = "000000000"
        End If
        ComboBoxEdit3.Properties.Items.Clear()
        Dim x As Integer = DataGridView1.Rows.Count - 2
        For i As Integer = 0 To x
            ComboBoxEdit3.Properties.Items.Add(DataGridView1.Item(2, i).Value.ToString)
        Next
        tmr1.Start()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub TextEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit2.KeyDown
        If e.KeyValue = Keys.Escape Then
            TextEdit2.Text = tmp_shtrih
            TextEdit2.Width = 143
            save_shtrih.Visible = False
            tmp_shtrih = ""
        End If
    End Sub

    Private Sub TextEdit2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit2.TextChanged
        TextEdit2.Width = 113
        save_shtrih.Visible = True
        If tmp_shtrih = "" Then
            If (TextEdit2.Text.Length - 1 > 0) Then
                tmp_shtrih = TextEdit2.Text.Remove(TextEdit2.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub save_shtrih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_shtrih.Click
        If TextEdit2.Text <> "" Then
            AxBarcode1.Text = TextEdit2.Text
            save_shtrih.Visible = False
            TextEdit2.Width = 143
            tmp_shtrih = ""
        Else
            MsgBox("Заполните значение поля <Штрих-код> для применения значений!", MsgBoxStyle.Information, "PRS Trade")
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Добавление айтемов
        With Sklad.DataGridView1
            If r_state = False Then
                Dim x As Integer = .RowCount - 1 '!!!!!!!!!!!!!!!!!
                With Sklad.SkladDataSet1
                    .Tables.Item("Склад").Rows.Add()
                End With

                .Item(0, x).Value = x
                .Item(1, x).Value = TextEdit1.Text
                .Item(2, x).Value = TextEdit2.Text
                .Item(3, x).Value = TextEdit3.Text
                .Item(4, x).Value = ComboBoxEdit1.Text
                .Item(5, x).Value = TextEdit4.Text
                .Item(6, x).Value = ComboBoxEdit2.Text
                .Item(8, x).Value = ComboBoxEdit3.Text
                .Item(7, x).Value = ComboBoxEdit4.Text
                .Item(9, x).Value = TextEdit5.Text
                .Item(10, x).Value = Label3.Text
                .Item(11, x).Value = TextEdit6.Text
                .Item(12, x).Value = Label6.Text
                .Item(13, x).Value = TextEdit7.Text

                For i As Integer = 0 To DataGridView1.Rows.Count - 2
                    If ComboBoxEdit3.Text.ToString = DataGridView1.Item(2, i).Value.ToString Then
                        DataGridView1.Item(5, i).Value += 1
                        TableAdapterManager1.UpdateAll(PostavshikiDataSet)
                    End If
                Next
                SimpleButton2.Text = "Закрыть"

                My.Computer.FileSystem.WriteAllText(_SkladOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Добавление товара: Штрих-код - " & TextEdit2.Text & "; Наименование - " & TextEdit1.Text & "; Кол-во - " & TextEdit5.Text & "; Стоимость - " & TextEdit4.Text & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Добавление товара: Штрих-код - " & TextEdit2.Text & "; Наименование - " & TextEdit1.Text & "; Кол-во - " & TextEdit5.Text & "; Стоимость - " & TextEdit4.Text & vbCrLf, True)

                TextEdit1.Text = ""
                TextEdit2.Text = ""
                TextEdit3.Text = ""
                ComboBoxEdit1.Text = ""
                TextEdit4.Text = ""
                ComboBoxEdit2.Text = ""
                ComboBoxEdit3.Text = ""
                ComboBoxEdit4.Text = ""
                TextEdit5.Text = ""
                ' Label3.Text =  ""
                TextEdit6.Text = ""
                ' Label6.Text =  ""
                TextEdit7.Text = ""
            Else
                Dim x As Integer = getSelectedRow(1)
                '.Item(0, x).Value = x
                .Item(1, x).Value = TextEdit1.Text
                .Item(2, x).Value = TextEdit2.Text
                .Item(3, x).Value = TextEdit3.Text
                .Item(4, x).Value = ComboBoxEdit1.Text
                .Item(5, x).Value = TextEdit4.Text
                .Item(6, x).Value = ComboBoxEdit2.Text
                .Item(8, x).Value = ComboBoxEdit3.Text
                .Item(7, x).Value = ComboBoxEdit4.Text
                .Item(9, x).Value = TextEdit5.Text
                .Item(10, x).Value = Label3.Text
                .Item(11, x).Value = TextEdit6.Text
                .Item(12, x).Value = Label6.Text
                .Item(13, x).Value = TextEdit7.Text
                SimpleButton2.Text = "Закрыть"

                My.Computer.FileSystem.WriteAllText(_SkladOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Редактирование товара: Штрих-код - " & TextEdit2.Text & "; Наименование - " & TextEdit1.Text & "; Кол-во - " & TextEdit5.Text & "; Стоимость - " & TextEdit4.Text & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Редактирование товара: Штрих-код - " & TextEdit2.Text & "; Наименование - " & TextEdit1.Text & "; Кол-во - " & TextEdit5.Text & "; Стоимость - " & TextEdit4.Text & vbCrLf, True)

            End If
        End With
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click
        TextEdit1.Text = "test"
        TextEdit2.Text = "12345"
        TextEdit3.Text = "123"
        ComboBoxEdit1.Text = "Шт."
        TextEdit4.Text = "123"
        ComboBoxEdit2.Text = "10"
        ComboBoxEdit3.Text = "1"
        ComboBoxEdit4.Text = "Пакистан"
        TextEdit5.Text = "123"
        TextEdit6.Text = "123"
        TextEdit7.Text = "test"
    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        If (TextEdit4.Text <> "" And ComboBoxEdit2.Text <> "") Then
            Try
                Label3.Text = Val(TextEdit4.Text) + (Val(TextEdit4.Text) / 100 * Val(ComboBoxEdit2.Text))
                If TextEdit6.Text <> "" Then
                    Label6.Text = Val(Label3.Text) - (Val(Label3.Text) / 100 * Val(TextEdit6.Text))
                End If
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub
End Class
