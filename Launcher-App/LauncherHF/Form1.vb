Imports System.Net
Imports System.Text.RegularExpressions
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.Environment
Imports System.IO

Public Class Form1
    Dim MoveForm As Boolean
    Dim MoveForm_MousePosition As Point
    Dim vpncek As Boolean = False
    Dim updatecek As Boolean = False
    Dim mustUpdate As Boolean = False
    Dim serverStats As Boolean = False

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "J8WfJ7u6soH6DIMVWYaU9HhsV3s11RiuuCJsIhMX",
        .BasePath = "https://vbshippu.firebaseio.com/"
        }
    Private client As IFirebaseClient

    'cek Versi Update
    Public Sub checkUpdate()
        Try
            client = New FireSharp.FirebaseClient(fcon)
            Dim res = client.Get("Update/2")
            Dim sws As New Update()
            sws = res.ResultAs(Of Update)
            Dim newestVersion As String = sws.version
            Dim currentVersion As String = Application.ProductVersion
            versi.Text = currentVersion.ToString
            If newestVersion > versi.Text Then
                Dim msg_update = New msg_update()
                msg_update.ShowDialog()
                Me.Dispose()
                updatecek = True
                mustUpdate = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Cek IP Public User
    Private Function IpAddress() As String
        Try
            Dim json As String = New System.Net.WebClient().DownloadString("https://api.ipify.org/?format=json")
            Dim IP As String = json.Split(":"c)(1).Replace("}", "").Replace("""", "")
            Return IP
        Catch
        End Try

    End Function

    'Cek VPN ON
    Public Sub checkVPN()
        Try
            Dim ip As String
            Dim ip2 As String
            Dim ip3 As String
            Dim ip4 As String
            client = New FireSharp.FirebaseClient(fcon)
            Dim res = client.Get("Update/2")
            Dim sws As New Update()
            sws = res.ResultAs(Of Update)
            ip = sws.ip
            ip2 = sws.ip2
            ip3 = sws.ip3
            ip4 = sws.ip4

            If IpAddress() = ip Or IpAddress() = ip2 Or IpAddress() = ip3 Or IpAddress() = ip4 Then
                labelvpn.Text = "ON"
                labelvpn.ForeColor = System.Drawing.Color.Green
                vpncek = True
            Else
                labelvpn.Text = "OFF"
                labelvpn.ForeColor = System.Drawing.Color.Red
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Main Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkUpdate()
        If updatecek = True Then
            WindowState = FormWindowState.Minimized
            Me.Hide()
        End If
        versi.Text = Application.ProductVersion
        hfstatus.Hide()
        'Cek Status Server
        If My.Computer.Network.Ping("8.8.8.8") Then
            hfstatus.Text = "ON"
            hfstatus.ForeColor = System.Drawing.Color.Green
            hfstatus.Show()
            serverStats = True
        Else
            hfstatus.Text = "ON"
            hfstatus.ForeColor = System.Drawing.Color.Green
            hfstatus.Show()
            serverStats = False
        End If
        Try
            My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\HellFireRP\oldHellFireRP.exe")
        Catch

        End Try
        Label3.Visible = False
        labelvpn.Visible = False
        'Cek VPN With Timer
        'checkVPN()
        'Dim Timer1 As New Timer()
        'Timer1.Interval = 5000
        'AddHandler Timer1.Tick, AddressOf Timer1_Tick
        'Timer1.Start()
    End Sub

    'VPN Button
    Private Sub vpnbutton_Click(sender As Object, e As EventArgs) Handles vpnbutton.Click
        Dim msg = New msg()
        If mustUpdate = False Then
            If serverStats = True Then
                If Application.OpenForms().OfType(Of msg).Any Then

                Else
                    msg.Show()
                End If
            End If
        End If
    End Sub

    'Play Button
    Private Sub playbutton_Click(sender As Object, e As EventArgs) Handles playbutton.Click
        Dim msg_alert = New msg_alert()
        If mustUpdate = False Then
            Dim _proceses2 As Process()
            _proceses2 = Process.GetProcessesByName("ts3client_win64")
            If _proceses2.Count > 0 Then
                System.Diagnostics.Process.Start($"fivem://connect/hellfire.parahyangan.my.id")
            Else
                System.Diagnostics.Process.Start($"fivem://connect/hellfire.parahyangan.my.id")
                System.Diagnostics.Process.Start($"ts3server://ts.parahyangan.my.id")
            End If
        End If
    End Sub

    'Mouse Move
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
    '-------------
    'Exit Button
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim _proceses As Process()
        _proceses = Process.GetProcessesByName("OpenVPNConnect")
        For Each proces As Process In _proceses
            proces.Kill()
        Next
        Close()

    End Sub

    Private Sub labelvpn_Click(sender As Object, e As EventArgs) Handles labelvpn.Click

    End Sub

    'Discord
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        System.Diagnostics.Process.Start("https://discord.gg/K78juje")
    End Sub

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles Label7.MouseHover
        Label7.ForeColor = Color.Red
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.White
    End Sub

    'Cek Status VPN Setiap 5 Detik
    Private Sub RefreshMyForm()
        Try
            Dim ip As String
            Dim ip2 As String
            Dim ip3 As String
            Dim ip4 As String
            client = New FireSharp.FirebaseClient(fcon)
            Dim res = client.Get("Update/2")
            Dim sws As New Update()
            sws = res.ResultAs(Of Update)
            ip = sws.ip
            ip2 = sws.ip2
            ip3 = sws.ip3
            ip4 = sws.ip4
            Dim ipku As String
            ipku = (New WebClient()).DownloadString("https://tools.feron.it/php/ip.php")

            If ipku = ip Or ipku = ip2 Or ipku = ip3 Or ipku = ip4 Then
                labelvpn.Text = "ON"
                labelvpn.ForeColor = System.Drawing.Color.Green
                vpncek = True
            Else
                labelvpn.Text = "OFF"
                labelvpn.ForeColor = System.Drawing.Color.Red
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Timer Tick
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshMyForm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cacheDel = New cacheDelete()
        cacheDel.ShowDialog()
    End Sub
End Class
