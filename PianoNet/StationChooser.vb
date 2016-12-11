Imports System.Windows.Forms

Public Class StationChooser
    Private StationCollection As New List(Of String)

    Public Property Stations As List(Of String)
        Get
            Return StationCollection
        End Get
        Set(value As List(Of String))
            StationCollection.Clear()
            StationList.Items.Clear()
            StationCollection.AddRange(value.ToArray)
            StationList.Items.AddRange(value.ToArray)
        End Set
    End Property

    Public Property Station As Integer
        Get
            Return StationList.SelectedIndex
        End Get
        Set(value As Integer)
            StationList.SelectedIndex = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
