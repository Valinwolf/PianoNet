Imports System.IO

Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        My.Settings.RememberLogs = RememberCheckbox.Checked
        Pianobar.WriteCfg(UsernameTextBox.Text, PasswordTextBox.Text)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RememberCheckbox.Checked = My.Settings.RememberLogs
    End Sub
End Class
