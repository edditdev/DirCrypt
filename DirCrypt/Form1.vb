Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Public Class Form1

    ' Zmienne
    Public FileFinalPath As String
    Public Password As String
    Public EncryptionIndicatorFileName As String = "encryption_indicator" ' Nazwa pliku wskazującego na zaszyfrowanie

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If SelectDirectory.ShowDialog() = DialogResult.OK Then
            FileTxtPath.Text = SelectDirectory.SelectedPath
            FileFinalPath = FileTxtPath.Text
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        LoadingPanel.Visible = True
        If Not String.IsNullOrEmpty(FileFinalPath) AndAlso Not String.IsNullOrEmpty(Password) Then
            If Not IsFolderEncrypted(FileFinalPath) Then
                Dim encryptionThread As New Thread(Sub()
                                                       Try
                                                           EncryptFilesInFolder(FileFinalPath, Password)
                                                           MarkFolderAsEncrypted(FileFinalPath)
                                                           Dim soundPlayer As New System.Media.SoundPlayer(My.Resources.Notification)
                                                           soundPlayer.Play()
                                                           MsgBox("Encrypted")

                                                       Catch ex As CryptographicException
                                                           Dim soundPlayer As New System.Media.SoundPlayer(My.Resources.Notification)
                                                           soundPlayer.Play()
                                                           MsgBox("Invaild password")


                                                       End Try


                                                   End Sub)
                encryptionThread.Start()

            Else
                Notification.TextX.Text = "This directory is already encrypted"
                Notification.TextX.ForeColor = Color.Silver
                Notification.Show()
            End If
        Else
            Notification.TextX.Text = "Select directory and set password"
            Notification.TextX.ForeColor = Color.Crimson
            Notification.Show()

        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        LoadingPanel.Visible = True
        If Not String.IsNullOrEmpty(FileFinalPath) AndAlso Not String.IsNullOrEmpty(Password) Then
            If IsFolderEncrypted(FileFinalPath) Then
                Dim decryptionThread As New Thread(Sub()
                                                       Try
                                                           DecryptFilesInFolder(FileFinalPath, Password)
                                                           MarkFolderAsDecrypted(FileFinalPath)
                                                           Dim soundPlayer As New System.Media.SoundPlayer(My.Resources.Notification)
                                                           soundPlayer.Play()
                                                           MsgBox("Decrypted")

                                                       Catch ex As CryptographicException
                                                           Dim soundPlayer As New System.Media.SoundPlayer(My.Resources.Notification)
                                                           soundPlayer.Play()
                                                           MsgBox("Invaild password")

                                                       End Try
                                                   End Sub)
                decryptionThread.Start()
            Else
                Notification.TextX.Text = "This directory is not encrypted"
                Notification.TextX.ForeColor = Color.Silver
                Notification.Show()
            End If
        Else
            Notification.TextX.Text = "Select directory and set password"
            Notification.TextX.ForeColor = Color.Crimson
            Notification.Show()
        End If
    End Sub

    Private Sub EncryptFilesInFolder(folderPath As String, password As String)
        Dim filesToEncrypt As String() = Directory.GetFiles(folderPath)
        Dim totalFiles = filesToEncrypt.Length
        Dim progressBarValue As Integer = 0

        For Each filePath As String In filesToEncrypt
            EncryptFile(filePath, password)
            progressBarValue += 1
            UpdateProgressBar(progressBarValue, totalFiles)
            UpdateStatusLabel(filePath)
        Next
    End Sub

    Private Sub DecryptFilesInFolder(folderPath As String, password As String)
        Dim filesToDecrypt As String() = Directory.GetFiles(folderPath)
        Dim totalFiles = filesToDecrypt.Length
        Dim progressBarValue As Integer = 0

        For Each filePath As String In filesToDecrypt
            DecryptFile(filePath, password)
            progressBarValue += 1
            UpdateProgressBar(progressBarValue, totalFiles)
            UpdateStatusLabel(filePath)
        Next
    End Sub

    Public Sub EncryptFile(filePath As String, password As String)

        Dim originalBytes As Byte() = File.ReadAllBytes(filePath)
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim saltBytes As Byte() = Encoding.UTF8.GetBytes("SALT_VALUE") ' Zmień na własną wartość soli.

        Using passwordDeriveBytes As New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
            Using aesAlg As New AesCryptoServiceProvider()
                aesAlg.Key = passwordDeriveBytes.GetBytes(32)
                aesAlg.IV = passwordDeriveBytes.GetBytes(16)

                Using encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
                    Using memoryStream As New MemoryStream()
                        Using cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
                            cryptoStream.Write(originalBytes, 0, originalBytes.Length)
                        End Using

                        File.WriteAllBytes(filePath, memoryStream.ToArray())
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Public Sub DecryptFile(filePath As String, password As String)

        Dim encryptedBytes As Byte() = File.ReadAllBytes(filePath)
        Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim saltBytes As Byte() = Encoding.UTF8.GetBytes("SALT_VALUE")

        Using passwordDeriveBytes As New Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000)
            Using aesAlg As New AesCryptoServiceProvider()
                aesAlg.Key = passwordDeriveBytes.GetBytes(32)
                aesAlg.IV = passwordDeriveBytes.GetBytes(16)

                Using decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
                    Using memoryStream As New MemoryStream()

                        Using cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write)
                            cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length)
                        End Using


                        File.WriteAllBytes(filePath, memoryStream.ToArray())
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub MarkFolderAsEncrypted(folderPath As String)
        File.WriteAllText(Path.Combine(folderPath, EncryptionIndicatorFileName), "")
    End Sub

    Private Sub MarkFolderAsDecrypted(folderPath As String)
        Dim indicatorFilePath As String = Path.Combine(folderPath, EncryptionIndicatorFileName)
        If File.Exists(indicatorFilePath) Then
            File.Delete(indicatorFilePath)
        End If
    End Sub

    Private Function IsFolderEncrypted(folderPath As String) As Boolean
        Dim indicatorFilePath As String = Path.Combine(folderPath, EncryptionIndicatorFileName)
        Return File.Exists(indicatorFilePath)
    End Function

    Private Sub UpdateProgressBar(value As Integer, max As Integer)
        If EncTab.Checked = True Then
            Bar.ProgressColor = Color.Gold
            Bar.ProgressColor2 = Color.Green
            If InvokeRequired Then
                Invoke(Sub() Bar.Maximum = max)
                Invoke(Sub() Bar.Value = value)
            Else
                Bar.Maximum = max
                Bar.Value = value
            End If
        End If

        If DecTab.Checked = True Then
            Bar.ProgressColor = Color.Purple
            Bar.ProgressColor2 = Color.Red
            If InvokeRequired Then
                Invoke(Sub() Bar.Maximum = max)
                Invoke(Sub() Bar.Value = value)
            Else
                Bar.Maximum = max
                Bar.Value = value
            End If
        End If
    End Sub

    Private Sub UpdateStatusLabel(text As String)


        If EncTab.Checked = True Then
            If InvokeRequired Then
                Invoke(Sub() StatLbl.Text = "Encrypting: " & text & " file.")
            Else
                StatLbl.Text = "Encrypting: " & text & " file."
            End If
        Else
            If InvokeRequired Then
                Invoke(Sub() StatLbl.Text = "Decrypting: " & text & " file.")
            Else
                StatLbl.Text = "Decrypting: " & text & " file."
            End If
        End If

        If Bar.Value = 100 Then
            LoadingPanel.Visible = False
        End If
    End Sub
    Private Sub PasswordBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordBox.TextChanged
        Password = PasswordBox.Text
    End Sub

    Private Sub EncTab_Click(sender As Object, e As EventArgs) Handles EncTab.Click

        DecTab.Checked = False
        If EncTab.Checked = True Then
            With EncGroup
                Mother.Controls.Add(EncGroup)
                .Visible = True
                .BringToFront()
                .Dock = DockStyle.Fill
            End With
        Else
            EncGroup.Visible = False
        End If
    End Sub

    Private Sub DecTab_Click(sender As Object, e As EventArgs) Handles DecTab.Click

        EncTab.Checked = False
        If DecTab.Checked = True Then
            With DecGroup
                Mother.Controls.Add(DecGroup)
                .Visible = True
                .BringToFront()
                .Dock = DockStyle.Fill
            End With
        Else
            DecGroup.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EncTab.Checked = True

            DecTab.Checked = False
            If EncTab.Checked = True Then
                With EncGroup
                    Mother.Controls.Add(EncGroup)
                    .Visible = True
                    .BringToFront()
                    .Dock = DockStyle.Fill
                End With
            Else
                EncGroup.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class