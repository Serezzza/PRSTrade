Imports System.Windows.Forms
Imports PRS_Trade_v._1._0.PRSDev
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class Personal_Add
    Private val1 As ConditionValidationRule = New ConditionValidationRule()
    Private val2 As ConditionValidationRule = New ConditionValidationRule()
    Private val3 As ConditionValidationRule = New ConditionValidationRule()
    Private val4 As ConditionValidationRule = New ConditionValidationRule()
    Private val5 As ConditionValidationRule = New ConditionValidationRule()
    Private val6 As ConditionValidationRule = New ConditionValidationRule()

    Public r_state As Boolean = False
    Public photo_path As String = "N\A"

    Public Sub ValueChecker()
        val1.ConditionOperator = ConditionOperator.Between
        val1.Value1 = 100
        val1.Value2 = 999
        val1.ErrorText = "Личный номер должен находиться в диапазоне 111-999"
        DxValidationProvider1.SetValidationRule(TextEdit1, val1)

        val2.ConditionOperator = ConditionOperator.NotEquals
        val2.Value1 = ""
        val2.ErrorText = "Выберите должность"
        val2.ErrorType = ErrorType.Information
        DxValidationProvider1.SetValidationRule(ComboBoxEdit1, val2)

        val3.ConditionOperator = ConditionOperator.Contains
        val3.Value1 = "@"
        val3.ErrorText = "Пожалуйста введите верный e-mail"
        val3.ErrorType = ErrorType.Warning
        DxValidationProvider1.SetValidationRule(TextEdit7, val3)

        val4.ConditionOperator = ConditionOperator.NotEquals
        val4.Value1 = ""
        val4.ErrorText = "Заполните поле"
        val4.ErrorType = ErrorType.Information
        DxValidationProvider1.SetValidationRule(TextEdit2, val4)

        val5.ConditionOperator = ConditionOperator.NotEquals
        val5.Value1 = ""
        val5.ErrorText = "Заполните поле"
        val5.ErrorType = ErrorType.Information
        DxValidationProvider1.SetValidationRule(TextEdit3, val5)

        val6.ConditionOperator = ConditionOperator.NotEquals
        val6.Value1 = ""
        val6.ErrorText = "Заполните поле (Рекомендуется пароль более 5-ти символов)"
        val6.ErrorType = ErrorType.Information
        DxValidationProvider1.SetValidationRule(TextEdit4, val6)
    End Sub

    Public Sub getPhotoPath(ByVal s As String)
        photo_path = s
        If photo_path <> "N\A" Then
            PictureBox2.Image = Image.FromFile(photo_path)
        Else
            PictureBox2.Image = My.Resources.user
        End If
    End Sub

    Private Sub Personal_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValueChecker()
        If r_state = False Then
            PictureBox2.Image = My.Resources.user
        End If
        DxValidationProvider1.Validate()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        With Personal.DataGridView1
            If r_state = False Then
                Dim x As Integer = .RowCount - 1 '!!!!!!!!!!!!!!!!!
                With Personal.PersonalDataSet
                    .Tables.Item("Персонал").Rows.Add()
                End With

                .Item(0, x).Value = x + 1
                .Item(1, x).Value = TextEdit1.Text
                .Item(2, x).Value = TextEdit2.Text
                .Item(3, x).Value = ComboBoxEdit1.Text
                .Item(4, x).Value = DateEdit1.Text
                'последняя активность
                If photo_path <> "" Then
                    .Item(6, x).Value = photo_path
                Else
                    .Item(6, x).Value = "N\A"
                End If
                .Item(7, x).Value = MemoEdit1.Text.ToString
                .Item(8, x).Value = TextEdit5.Text.ToString
                .Item(9, x).Value = TextEdit6.Text.ToString
                .Item(10, x).Value = TextEdit7.Text.ToString
                .Item(11, x).Value = MemoEdit2.Text.ToString
                .Item(12, x).Value = TextEdit3.Text.ToString 'логин
                .Item(13, x).Value = TextEdit4.Text.ToString 'пароль
                SimpleButton4.Text = "Закрыть"

                My.Computer.FileSystem.WriteAllText(_PersonalOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Добавление персонала: Личный № - " & TextEdit1.Text & "; ФИО - " & TextEdit2.Text & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Добавление персонала: Личный № - " & TextEdit1.Text & "; ФИО - " & TextEdit2.Text & vbCrLf, True)

                TextEdit1.Text = ""
                TextEdit2.Text = ""
                ComboBoxEdit1.Text = ""
                DateEdit1.Text = ""
                photo_path = ""
                MemoEdit1.Text = ""
                TextEdit5.Text = ""
                TextEdit6.Text = ""
                TextEdit7.Text = ""
                MemoEdit2.Text = ""
                TextEdit3.Text = "" 'логин
                TextEdit4.Text = "" 'пароль
            Else
                Dim x As Integer = getSelectedRow(2)
                '.Item(0, x).Value = x
                .Item(1, x).Value = TextEdit1.Text
                .Item(2, x).Value = TextEdit2.Text
                .Item(3, x).Value = ComboBoxEdit1.Text
                .Item(4, x).Value = DateEdit1.Text
                'последняя активность
                If photo_path <> "" Then
                    .Item(6, x).Value = photo_path
                Else
                    .Item(6, x).Value = "N\A"
                End If
                .Item(7, x).Value = MemoEdit1.Text.ToString
                .Item(8, x).Value = TextEdit5.Text.ToString
                .Item(9, x).Value = TextEdit6.Text.ToString
                .Item(10, x).Value = TextEdit7.Text.ToString
                .Item(11, x).Value = MemoEdit2.Text.ToString
                .Item(12, x).Value = TextEdit3.Text.ToString 'логин
                .Item(13, x).Value = TextEdit4.Text.ToString 'пароль
                SimpleButton4.Text = "Закрыть"
                My.Computer.FileSystem.WriteAllText(_PersonalOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Изменение персонала: Личный № - " & TextEdit1.Text & "; ФИО - " & TextEdit2.Text & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Изменение персонала: Личный № - " & TextEdit1.Text & "; ФИО - " & TextEdit2.Text & vbCrLf, True)
            End If
        End With
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click
        TextEdit1.Text = "100"
        TextEdit2.Text = "Иванов Иван Иванович"
        ComboBoxEdit1.Text = "Менеджер"
        DateEdit1.Text = "12.11.2002"
        'photo_path=""
        MemoEdit1.Text = "test Adress"
        TextEdit5.Text = "89017835612"
        TextEdit6.Text = "Продуктовый"
        TextEdit7.Text = "ivan@mail.ru"
        MemoEdit2.Text = "test Dopolnit"
        TextEdit3.Text = "Ivan" 'логин
        TextEdit4.Text = "12345" 'пароль
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        opf.Title = "Загрузить фото для профиля"
        opf.Filter = "Фотографии (bmp, jpg, jpeg, gif, jpe, png)|*.bmp;*.jpg ;*.jpeg ;*.gif ;*.jpe;*.png"
        opf.InitialDirectory = cam_path
        opf.ShowDialog()
    End Sub

    Private Sub opf_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opf.FileOk
        photo_path = opf.FileName
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        With Camera
            If r_state = False Then
                Dim x As Integer = Personal.DataGridView1.RowCount - 1
                .getNumber(x, True)
                .ShowDialog()
            Else
                Dim x As Integer = getSelectedRow(2)
                .getNumber(x, True)
                .ShowDialog()
            End If
        End With
    End Sub

End Class
