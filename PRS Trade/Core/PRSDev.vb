#Region "<Import>"
Imports System
Imports System.Math
Imports System.Resources
Imports System.Diagnostics
Imports System.Net
Imports System.Xml

Imports PRS_Trade_v._1._0.My.Resources
#End Region

#Region "<PRSDev (c) 2012 Module>"
Module PRSDev
    Public Sub PRS_Exit(ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Dim Result As System.Windows.Forms.DialogResult
        Result = MessageBox.Show("Вы действительно хотите выйти? Все несохраненные данные будут потеряны!", "PRS Trade", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            E.Cancel = False
        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            E.Cancel = True
        End If
    End Sub

    Public Sub PRS_GoToURL(ByVal URL As String)
        If URL.Length > 6 Then
            If URL(0) = "h" And URL(1) = "t" And URL(2) = "t" And URL(3) = "p" And URL(4) = ":" And URL(5) = "/" And URL(6) = "/" Then
                Process.Start(URL)
            Else
                Process.Start("http://" & URL)
            End If
        Else
            Process.Start("http://" & URL)
        End If
    End Sub

    Public Sub PRS_ShowMDI(ByVal mdiform As Form, ByVal newform As Form)
        Dim Child As New System.Windows.Forms.Form
        Child = newform
        Child.MdiParent = mdiform
        Child.Show()
    End Sub

    Public Sub PRS_Open(ByVal file As String)
        Process.Start(file)
    End Sub

    Public Function PRS_GetConnectionState(ByVal _string As String)
        Dim re As String = ""
        If _string = True Then
            re = "Подключена"
        ElseIf _string = False Then
            re = "Отключена"
        End If
        Return re
    End Function

    Public Function PRS_Connected() As Boolean
        Dim re As Boolean
        Try
            Dim HostName As String = Dns.GetHostName()
            Dim thisHost As IPHostEntry = Dns.GetHostEntry(HostName)
            Dim thisIpAddr As String = thisHost.AddressList(0).ToString
            re = thisIpAddr <> Net.IPAddress.Parse("127.0.0.1").ToString()
        Catch ex As Exception
            Return False
        End Try
        Return re
    End Function

    Public Function PRS_ShortName(ByVal name As String, ByVal surname As String, ByVal otchestvo As String, ByVal isDot As Boolean)
        Dim re As String = ""
        If isDot = True Then
            re = surname & " " & name(0) & ". " & otchestvo(0) & "."
        Else
            re = surname & " " & name(0) & ". " & otchestvo(0)
        End If
        Return re
    End Function

    Public Function PRS_getSName(ByVal name As String)
        Dim x As Integer = name.Length
        Dim _name As String = "" : Dim _surname As String = "" : Dim _otchestvo As String = ""
        Dim fs As Integer = 0 : Dim ss As Integer = 0
        For i = 0 To x - 1
            If name(i) = " " Then
                If fs = 0 Then
                    fs = i
                Else
                    ss = i
                End If
            End If
        Next
        _name = Mid(name, 1, (x - 1) - ((x - 1) - fs))
        _surname = Mid(name, fs + 2, 1)
        _otchestvo = Mid(name, ss + 2, 1)
        Return _name & " " & _surname & "." & _otchestvo
    End Function

    Public Function PRS_DigitGrouping(ByVal value As String)
        'Группировка цифр по разрядам (мой вариант)
        Dim new_value As String = "" : Dim s_lenght As Byte = value.Length
        Select Case s_lenght
            Case 4
                new_value = value(0) & value(1) & value(2) & " " & value(3)
            Case 5
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4)
            Case 6
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5)
            Case 7
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6)
            Case 8
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7)
            Case 9
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8)
            Case 10
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9)
            Case 11
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10)
            Case 12
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11)
            Case 13
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12)
            Case 14
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13)
            Case 15
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13) & value(14)
            Case 16
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13) & value(14) & " " & value(15)
            Case 17
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13) & value(14) & " " & value(15) & value(16)
            Case 18
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13) & value(14) & " " & value(15) & value(16) & value(17)
            Case 19
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13) & value(14) & " " & value(15) & value(16) & value(17) & " " & value(18)
            Case 20
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13) & value(14) & " " & value(15) & value(16) & value(17) & " " & value(18) & value(19)
            Case 21
                new_value = value(0) & value(1) & value(2) & " " & value(3) & value(4) & value(5) & " " & value(6) & value(7) & value(8) & " " & value(9) & value(10) & value(11) & " " & value(12) & value(13) & value(14) & " " & value(15) & value(16) & value(17) & " " & value(18) & value(19) & value(20)
            Case Else
                new_value = value
        End Select
        Return new_value
    End Function

    Public Sub PRS_LoadSource(ByVal cb As ComboBox)
        Dim Xml As New XmlDocument()
        Dim XmlNodes As XmlNodeList
        Dim Group As XmlNode
        If IO.File.Exists(Application.StartupPath & "\Resources" & "\rocid.xml") Then
            Xml.Load(Application.StartupPath & "\Resources" & "\rocid.xml")
            XmlNodes = Xml.DocumentElement.SelectNodes("country")
            For Each Group In XmlNodes
                cb.Items.Add(Group.Attributes("name").Value)
            Next Group
        End If
    End Sub

    Public Function getSelectedRow(ByVal d As Byte)
        If d = 1 Then
            With Sklad.DataGridView1
                Dim x As Integer = .Rows.Count
                For i As Integer = 0 To x
                    If .Rows(i).Selected = True Then
                        Return i
                    End If
                Next
            End With
        ElseIf d = 2 Then
            With Personal.DataGridView1
                Dim x As Integer = .Rows.Count
                For i As Integer = 0 To x
                    If .Rows(i).Selected = True Then
                        Return i
                    End If
                Next
            End With
        ElseIf d = 3 Then
            With Postavshiki.DataGridView1
                Dim x As Integer = .Rows.Count
                For i As Integer = 0 To x
                    If .Rows(i).Selected = True Then
                        Return i
                    End If
                Next
            End With
        End If
    End Function

    Public Sub PRS_Locked(ByVal v As Boolean)
        If v = False Then
            With Main
                .ribbonControl.Enabled = False
                .siInfo.Caption = "Не авторизован"
                .siInfo.Glyph = offline
                My.Computer.FileSystem.WriteAllText(_EnterOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Блокировка " & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Блокировка " & vbCrLf, True)
                .BarButtonItem66.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .tmr1.Stop()
            End With
        Else
            With Main
                .ribbonControl.Enabled = True
                .siInfo.Caption = "Авторизован [" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] - " & PRS_entered
                My.Computer.FileSystem.WriteAllText(_EnterOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Авторизация: " & PRS_entered & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(_AllOperations, "[" & Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] Авторизация: " & PRS_entered & vbCrLf, True)
                .siInfo.Glyph = online
                PRS_ShowMDI(Main, Welcome)
                .BarButtonItem66.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                .tmr1.Start()
                PRS_shopname = My.Computer.FileSystem.ReadAllText(_ShopName)
            End With
        End If
    End Sub

    Public Function InicializeStyle(ByVal type As PRSStyles)
        Select Case type
            Case PRSStyles.Aero
                Return "DevExpress Style"
            Case PRSStyles.MsOfficeBlue
                Return "Office 2010 Blue"
            Case PRSStyles.MsOfficeSilver
                Return "Office 2010 Silver"
            Case PRSStyles.TradeLight
                Return "Foggy"
            Case PRSStyles.TradeDark
                Return "Sharp Plus"
            Case Else
                Return "Error"
        End Select
    End Function
End Module
#End Region
