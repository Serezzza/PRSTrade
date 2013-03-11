Imports PRS_Trade_v._1._0.PRSDev
Imports PRS_Trade_v._1._0.PRSPerem

Public Class Calculator
    Private M As Long = 0
    Private znak As Char = ""
    Private tmp_znak As Char = "" '~
    Private temp As Long = 0
    Private value As Long = 0

#Region "Buttons 0-9"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 1
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 1
            Else
                CalcScreen1.Main_dig.Text = 1
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 2
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 2
            Else
                CalcScreen1.Main_dig.Text = 2
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 3
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 3
            Else
                CalcScreen1.Main_dig.Text = 3
            End If
        End If
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 4
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 4
            Else
                CalcScreen1.Main_dig.Text = 4
            End If
        End If
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 5
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 5
            Else
                CalcScreen1.Main_dig.Text = 5
            End If
        End If
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 6
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 6
            Else
                CalcScreen1.Main_dig.Text = 6
            End If
        End If
    End Sub

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 7
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 7
            Else
                CalcScreen1.Main_dig.Text = 7
            End If
        End If
    End Sub

    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 8
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 8
            Else
                CalcScreen1.Main_dig.Text = 8
            End If
        End If
    End Sub

    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 9
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 9
            Else
                CalcScreen1.Main_dig.Text = 9
            End If
        End If
    End Sub

    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        If CalcScreen1.Main_dig.Text = 0 Then
            CalcScreen1.Main_dig.Text = 0
        Else
            If CalcScreen1.Main_dig.Text <> value Then
                CalcScreen1.Main_dig.Text &= 0
            Else
                CalcScreen1.Main_dig.Text = 0
            End If
        End If
    End Sub
#End Region
#Region "Buttons /, *, -, +"
    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton15.Click
        PreCalculate("/")
    End Sub

    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton16.Click
        PreCalculate("*")
    End Sub

    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click
        PreCalculate("-")
    End Sub

    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        PreCalculate("+")
    End Sub
#End Region
#Region "Button ="
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        Dim tmp As Long = 0
        If tmp_znak = "" Then
            value = Calculate(temp, CalcScreen1.Main_dig.Text, znak)
        Else
            value = Calculate(temp, CalcScreen1.Main_dig.Text, tmp_znak)
        End If
        tmp = CalcScreen1.Main_dig.Text
        CalcScreen1.Main_dig.Text = value
        CalcScreen1.Second_dig.Text &= tmp & " = " & value
        temp = 0 : value = 0
    End Sub
#End Region
#Region "Functions"
    '~
    Private Function Calculate(ByVal a As Long, ByVal b As Long, ByVal zn As Char)
        Dim answer As Long = 0
        Select Case zn
            Case "+"
                answer = a + b
            Case "-"
                answer = a - b
            Case "*"
                answer = a * b
            Case "/"
                If b <> 0 Then
                    answer = a / b
                Else
                    MsgBox("Деление на NULL", MsgBoxStyle.Exclamation, "Ошибка")
                End If
        End Select
        Return answer
    End Function

    Private Sub PreCalculate(ByVal zn As Char)
        znak = zn
        If tmp_znak = "" Or tmp_znak <> zn Then
            tmp_znak = zn
        End If
        If (value = 0) Then
            temp = CalcScreen1.Main_dig.Text : value = temp
            CalcScreen1.Main_dig.Text = temp ': MsgBox(temp & " | " & value)
            CalcScreen1.Second_dig.Text = temp & " " & znak & " "
        Else
            temp = value
            If tmp_znak = "" Or tmp_znak <> zn Then
                value = Calculate(temp, CalcScreen1.Main_dig.Text, znak)
            Else
                value = Calculate(temp, CalcScreen1.Main_dig.Text, tmp_znak)
            End If
            CalcScreen1.Second_dig.Text &= CalcScreen1.Main_dig.Text & " " & znak & " "
            CalcScreen1.Main_dig.Text = value ': MsgBox(temp & " | " & value)
            tmp_znak = ""
            refreshd()
        End If
    End Sub

    Private Sub refreshd()
        CalcScreen1.Second_dig.Refresh()
        CalcScreen1.Main_dig.Text = value
    End Sub
#End Region
#Region "Buttons C\CE"
    Private Sub SimpleButton48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton48.Click
        'Clear
        znak = ""
        temp = 0
        value = 0
        CalcScreen1.Main_dig.Text = 0
        CalcScreen1.Second_dig.Text = 0
    End Sub

    Private Sub SimpleButton49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton49.Click
        'Clear MainScreen
        CalcScreen1.Main_dig.Text = 0
    End Sub
#End Region
End Class