Public Class ReproList
    Dim AllowDataManage As Boolean = False
    Private Sub NombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombreToolStripMenuItem.Click
        Try
            ListURL.SendToBack()
            ListURL.Visible = False
            ListName.Visible = True
            ListName.BringToFront()
            LblType.Text = "Nombre de la/s canciones:"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub URLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles URLToolStripMenuItem.Click
        Try
            ListName.SendToBack()
            ListName.Visible = False
            ListURL.Visible = True
            ListURL.BringToFront()
            LblType.Text = "URL de la/s canciones:"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListName.SelectedIndexChanged
        If AllowDataManage = True Then
            Try
                ListURL.SelectedIndex = ListName.SelectedIndex
            Catch ex As Exception
            End Try
            Main.MediaPlayer.URL = ""
            Main.ListUpdate(True)
        End If
    End Sub
    Private Sub ListURL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListURL.SelectedIndexChanged
        If AllowDataManage = True Then
            Try
                ListName.SelectedIndex = ListURL.SelectedIndex
            Catch ex As Exception
            End Try
            Main.MediaPlayer.URL = ""
            Main.ListUpdate(True)
        End If
    End Sub
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        If AllowDataManage = True Then
            ListName.Items.Clear()
            ListURL.Items.Clear()
            Main.ListClear()
        End If
    End Sub
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        If AllowDataManage = True Then
            OpenFileDialog1.ShowDialog()
        End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each track As String In OpenFileDialog1.FileNames
            ListURL.Items.Add(track)
            Dim nombre
            nombre = track
            nombre = nombre.Remove(0, nombre.LastIndexOf("\") + 1)
            nombre = nombre.Substring(0, nombre.LastIndexOf("."))
            ListName.Items.Add(nombre)
        Next
        If DialogResult.OK Then
            ListURL.SetSelected(0, True)
            Main.MediaPlayer.URL = ""
            Main.ListUpdate(True)
        End If
    End Sub
    Private Sub ReproList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.OpacityForm < 0.1 Then
            My.Settings.OpacityForm = 0.1
        End If
        Dim tmpName As ListBox = Main.ListBoxName
        Dim tmpURL As ListBox = Main.ListBoxURL
        Try
            ListName.Items.Clear()
            ListURL.Items.Clear()
            For Each item In tmpName.Items
                ListName.Items.Add(item)
            Next
            For Each item In tmpURL.Items
                ListURL.Items.Add(item)
            Next
            If tmpName.Items.Count = 0 Then
                AllowDataManage = True
            ElseIf (tmpName.Items.Count = 0) = False Then
                ListName.SetSelected(tmpName.SelectedIndex, True)
                ListURL.SetSelected(tmpURL.SelectedIndex, True)
                AllowDataManage = True
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class