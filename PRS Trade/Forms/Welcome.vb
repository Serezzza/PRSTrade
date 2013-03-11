Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars.Helpers

Public Class Welcome
    Sub New()
        InitializeComponent()
    End Sub

    Private Sub Welcome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.BarButtonItem26.Down = False
    End Sub
End Class