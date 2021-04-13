Imports System.Environment
Imports System.IO
Public Class cacheDelete
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub yesbtn_Click(sender As Object, e As EventArgs) Handles yesbtn.Click
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FiveM\FiveM.app\cache\browser"
        Dim path2 As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FiveM\FiveM.app\cache\db"
        Dim path3 As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FiveM\FiveM.app\cache\priv"
        Dim path4 As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FiveM\FiveM.app\cache\servers"
        Dim path5 As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FiveM\FiveM.app\cache\subprocess"
        Dim path6 As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\FiveM\FiveM.app\cache\unconfirmed"
        Dim Cache As String = GetFolderPath(SpecialFolder.LocalApplicationData)
        Dim Caches As String = GetFolderPath(SpecialFolder.LocalApplicationData)

        Dim FileToDelete1 As String = Cache & "\FiveM\FiveM.app\cache\crashometry"
        Dim FileToDelete2 As String = Cache & "\FiveM\FiveM.app\cache\launcher_skip_mtl2"
        Dim FileToDelete As String = Cache & "\FiveM\FiveM.app\caches.xml"
        If Directory.Exists(path) Then
            Try
                System.IO.Directory.Delete(path, True)
                System.IO.Directory.Delete(path2, True)
                System.IO.Directory.Delete(path3, True)
                System.IO.Directory.Delete(path4, True)
                System.IO.Directory.Delete(path5, True)
                System.IO.Directory.Delete(path6, True)
                System.IO.File.Delete(FileToDelete)
                System.IO.File.Delete(FileToDelete1)
                System.IO.File.Delete(FileToDelete2)
                MessageBox.Show("Delete Cache Sukses")
                Me.Close()
            Catch

            End Try
        Else
            MessageBox.Show("Cache Sudah Tidak ada")
            Me.Close()
        End If
    End Sub

    Private Sub cacheDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class