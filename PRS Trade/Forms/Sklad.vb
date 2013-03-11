Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins

Imports PRS_Trade_v._1._0.Main

Public Class Sklad

    Private Sub Sklad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.RibbonPageCategory1.Visible = False
    End Sub

    Private Sub Sklad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PostavshikiDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
        Me.ПоставщикиTableAdapter.Fill(Me.PostavshikiDataSet.Поставщики)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "SkladDataSet1.Склад". При необходимости она может быть перемещена или удалена.
        Me.СкладTableAdapter1.Fill(Me.SkladDataSet1.Склад)
        SplitContainerControl1.SplitterPosition = 0
    End Sub
End Class