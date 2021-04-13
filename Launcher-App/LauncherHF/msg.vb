Imports System.Net.NetworkInformation
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class msg
    Dim form As New Form1
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "J8WfJ7u6soH6DIMVWYaU9HhsV3s11RiuuCJsIhMX",
        .BasePath = "https://vbshippu.firebaseio.com/"
        }
    Private client As IFirebaseClient


    Private Sub msg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ping1 As String
        Dim ping2 As String
        Dim vpnList(5) As String
        Try
            client = New FireSharp.FirebaseClient(fcon)
            Dim res = client.Get("Update/2")
            Dim sws As New Update()
            sws = res.ResultAs(Of Update)
            box_vpn.Items.Add(sws.vpn_list)
            box_vpn.Items.Add(sws.vpn_list2)
            box_vpn.Items.Add(sws.vpn_list3)
            box_vpn.Items.Add(sws.vpn_list4)
        Catch
            MessageBox.Show("Koneksi Internet Tidak dijangkau")

        End Try
        'Combo Box VPN


    End Sub


    Private Sub vpnsg_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub vpnkonek_Click(sender As Object, e As EventArgs) Handles vpnkonek.Click
        Dim selectVpn As String
        Dim VPNList As String = "Japan"
        Dim VPNList2 As String = "Japan2"
        Dim VPNList3 As String = "Japan3"
        Dim VPNList4 As String = "singapura"
        'If SelectedItem in Combo box
        selectVpn = box_vpn.SelectedItem
        If selectVpn = VPNList Then
            Try
                Dim Japan As String
                Dim Jap As String
                client = New FireSharp.FirebaseClient(fcon)
                Dim res = client.Get("Update/2")
                Dim sws As New Update()
                sws = res.ResultAs(Of Update)
                Japan = sws.Japan
                Jap = sws.Jap
                Dim p = New Process()
                p.StartInfo.CreateNoWindow = True
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                p.StartInfo.FileName = "cmd.exe"
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardInput = True
                p.Start()

                p.StandardInput.WriteLine(Japan)
                System.Threading.Thread.CurrentThread.Sleep(2000)
                p.StandardInput.WriteLine("y")
                System.Threading.Thread.CurrentThread.Sleep(1000)
                p.Start()
                p.StandardInput.WriteLine(Jap)
                Hide()
            Catch ex As Exception

            End Try
        ElseIf selectVpn = VPNList2 Then
            Try
                Dim Japan2 As String
                Dim Jap2 As String
                client = New FireSharp.FirebaseClient(fcon)
                Dim res = client.Get("Update/2")
                Dim sws As New Update()
                sws = res.ResultAs(Of Update)
                Japan2 = sws.Japan2
                Jap2 = sws.Jap2
                Dim p = New Process()
                p.StartInfo.CreateNoWindow = True
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                p.StartInfo.FileName = "cmd.exe"
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardInput = True
                p.Start()

                p.StandardInput.WriteLine(Japan2)
                System.Threading.Thread.CurrentThread.Sleep(2000)
                p.StandardInput.WriteLine("y")
                System.Threading.Thread.CurrentThread.Sleep(1000)
                p.Start()
                p.StandardInput.WriteLine(Jap2)
                Hide()
            Catch ex As Exception

            End Try
        ElseIf selectVpn = VPNList3 Then
            Try
                Dim Japan3 As String
                Dim Jap3 As String
                client = New FireSharp.FirebaseClient(fcon)
                Dim res = client.Get("Update/2")
                Dim sws As New Update()
                sws = res.ResultAs(Of Update)
                Japan3 = sws.Japan3
                Jap3 = sws.Jap3
                Dim p = New Process()
                p.StartInfo.CreateNoWindow = True
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                p.StartInfo.FileName = "cmd.exe"
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardInput = True
                p.Start()

                p.StandardInput.WriteLine(Japan3)
                System.Threading.Thread.CurrentThread.Sleep(2000)
                p.StandardInput.WriteLine("y")
                System.Threading.Thread.CurrentThread.Sleep(1000)
                p.Start()
                p.StandardInput.WriteLine(Jap3)
                Hide()
            Catch ex As Exception

            End Try
        ElseIf selectVpn = VPNList4 Then
            Try
                Dim singa As String
                Dim sing As String
                client = New FireSharp.FirebaseClient(fcon)
                Dim res = client.Get("Update/2")
                Dim sws As New Update()
                sws = res.ResultAs(Of Update)
                singa = sws.singa
                sing = sws.sing
                Dim p = New Process()
                p.StartInfo.CreateNoWindow = True
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                p.StartInfo.FileName = "cmd.exe"
                p.StartInfo.UseShellExecute = False
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.RedirectStandardInput = True
                p.Start()

                p.StandardInput.WriteLine(singa)
                System.Threading.Thread.CurrentThread.Sleep(2000)
                p.StandardInput.WriteLine("y")
                System.Threading.Thread.CurrentThread.Sleep(1000)
                p.Start()
                p.StandardInput.WriteLine(sing)
                Hide()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class
