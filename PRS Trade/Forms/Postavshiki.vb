Public Class Postavshiki

    Private Sub Postavshiki_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.RibbonPageCategory3.Visible = False
    End Sub

    Private Sub Postavshiki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PostavshikiDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
        Me.ПоставщикиTableAdapter.Fill(Me.PostavshikiDataSet.Поставщики)

    End Sub
End Class