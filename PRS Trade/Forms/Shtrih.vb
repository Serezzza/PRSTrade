Imports BARCODELib
Imports AxBARCODELib

Public Class Shtrih

    Private Sub Shtrih_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxEdit1.Text = "Code 128"
        TextEdit1.Text = "PRSCode1"
        ColorEdit1.Text = "Black"
        FontEdit1.Text = "Arial"
        ComboBoxEdit3.Text = "18"
        ComboBoxEdit2.Text = 0
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        ComboBoxEdit1.Text = "Code 128"
        ColorEdit1.Text = "Black"
        FontEdit1.Text = "Arial"
        ComboBoxEdit3.Text = "18"
        ComboBoxEdit2.Text = 0
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If ((ComboBoxEdit1.Text <> "") And (ColorEdit1.Text <> "") And (FontEdit1.Text <> "") And (ComboBoxEdit2.Text <> "") And (ComboBoxEdit3.Text <> "")) Then
            AxBarcode1.TypeName = ComboBoxEdit1.Text
            AxBarcode1.ForeColor = ColorEdit1.Color
            Dim font1 As New Font(FontEdit1.Text, ComboBoxEdit3.Text)
            AxBarcode1.CtlFont = font1
            AxBarcode1.Rotate = ComboBoxEdit2.Text
            AxBarcode1.Text = TextEdit1.Text
        Else
            MsgBox("Заполните все поля для генерирования штрих-кода!", MsgBoxStyle.Information, "PRS Trade")
        End If
    End Sub
End Class