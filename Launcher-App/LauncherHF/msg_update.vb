Imports System.Net
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.Environment
Imports System.IO

Public Class msg_update
    Dim wc As WebClient
    Dim form As New Form1
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "J8WfJ7u6soH6DIMVWYaU9HhsV3s11RiuuCJsIhMX",
        .BasePath = "https://vbshippu.firebaseio.com/"
        }
    Private client As IFirebaseClient
    Private Sub msg_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wc = New WebClient
    End Sub

    Private Sub download_Click(sender As Object, e As EventArgs) Handles vpnid.Click
        client = New FireSharp.FirebaseClient(fcon)
        Dim res = client.Get("Update/2")
        Dim sws As New Update()
        sws = res.ResultAs(Of Update)
        Dim urlDownload As String = sws.download
        Dim downloadPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\HellFireRP"
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        wc.DownloadFileAsync(New Uri(urlDownload), downloadPath + "\HellFireRP_New" + ".exe")

    End Sub

    Private Sub ProgChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        Dim downloadPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\HellFireRP"
        pbStatus.Value = e.ProgressPercentage
        lblProgPerc.Text = e.ProgressPercentage.ToString() + "%"
        If e.ProgressPercentage.ToString() = 100 Then
            Dim answer As Integer
            answer = MsgBox("Silahkan Restart Launcher", vbOKOnly, "Restart Launcher")
            If answer = vbOK Then
                My.Computer.FileSystem.RenameFile(downloadPath + "\HellFireRP.exe", "oldHellFireRP.exe")

                System.Threading.Thread.CurrentThread.Sleep(2000)
                My.Computer.FileSystem.RenameFile(downloadPath + "\HellFireRP_New.exe", "HellFireRP.exe")

                Form1.Close()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Close()
        Me.Close()
    End Sub
End Class