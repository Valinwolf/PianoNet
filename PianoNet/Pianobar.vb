Imports System.IO

Public Class Pianobar
    Private barproc As Process

    Private Const DIR_PIANOBAR As String = "bar/"
    Private Const FIL_PIANOBAR As String = "pianobar.exe"
    Private Const FIL_CONFIG__ As String = "pianobar.cfg"

    Public Shared Sub WriteCfg(ByVal User As String, ByVal Pass As String)
        Dim tw As TextWriter = New StreamWriter(DIR_PIANOBAR & FIL_CONFIG__, False)

        If My.Settings.RememberLogs Then
            tw.Write("user = ")
            tw.WriteLine(User)

            tw.Write("password = ")
            tw.WriteLine(Pass)
        End If

        If My.Settings.RememberStation Then
            tw.Write("autostart_station = ")
            tw.WriteLine(My.Settings.Station)
        End If

        tw.WriteLine("width = 220")
        tw.WriteLine("height = 60")

        tw.WriteLine("love_icon = 1")
        tw.WriteLine("ban_icon = 0")

        tw.WriteLine("format_nowplaying_station = s: %n;%i")
        tw.WriteLine("format_list_song = %i) %a;%t;%r")
        tw.WriteLine("format_msg_info = i: %s")
        tw.WriteLine("format_msg_nowplaying = %s")
        tw.WriteLine("format_msg_time = %s")
        tw.WriteLine("format_msg_err = e: %s")
        tw.WriteLine("format_msg_question = q: %s")
        tw.WriteLine("format_msg_debug = %s")

        tw.Close()
    End Sub

    Public Sub StartBar()

    End Sub
End Class
