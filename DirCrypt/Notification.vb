Public Class Notification
    Private Sub Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim soundPlayer As New System.Media.SoundPlayer(My.Resources.Notification)
        soundPlayer.Play()
    End Sub
End Class