Public Class Personal

    Private Sub Personal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.RibbonPageCategory2.Visible = False
    End Sub

    Private Sub Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PersonalDataSet.Персонал". При необходимости она может быть перемещена или удалена.
        Me.ПерсоналTableAdapter.Fill(Me.PersonalDataSet.Персонал)
        SplitContainerControl2.SplitterPosition = 180
        SplitContainerControl1.SplitterPosition = 678
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        With DataGridView1
            Dim x As Integer = getSelectedRow(2)
            'Фото
            If .Item(6, x).Value <> "N\A" Then
                pic.Image = Image.FromFile(.Item(6, x).Value.ToString)
            Else
                pic.Image = My.Resources.user
            End If

                Label1.Text = "Личный №: " & .Item(1, x).Value
                Label2.Text = "ФИО: " & .Item(2, x).Value
                Label3.Text = "Должность: " & .Item(3, x).Value
                Label4.Text = "Дата приема: " & .Item(4, x).Value
                Label5.Text = "Последняя активность: " & .Item(5, x).Value.ToString
                Label7.Text = "Адрес: " & .Item(7, x).Value.ToString
                Label8.Text = "Телефон: " & .Item(8, x).Value.ToString
                Label9.Text = "Отдел: " & .Item(9, x).Value.ToString
                Label10.Text = "E-mail: " & .Item(10, x).Value.ToString
                Label11.Text = "Дополнительно: " & .Item(11, x).Value.ToString
                Label6.Text = "Логин: " & .Item(12, x).Value.ToString 'логин
        End With
    End Sub
End Class