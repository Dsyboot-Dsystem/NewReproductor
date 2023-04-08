Imports AxWMPLib
Imports NewReproductor.My.Resources
Public Class Main
    'ReproList ListBox's
    Dim URLListbox As ListBox = ReproList.ListURL
    Dim NameListBox As ListBox = ReproList.ListName
    'MyBase ListBox
    Public WithEvents ListBoxName As New ListBox
    Public WithEvents ListBoxURL As New ListBox
    'Others
    Dim MediaStopped As Boolean = False
    Private ReadOnly DefaultNameProgram As String = "Reproductor"
    ReadOnly MusicNameProgram As String = DefaultNameProgram + ": "
    Public Sub ListUpdate(listclear As Boolean)
        If listclear = True Then
            ListBoxName.Items.Clear()
            ListBoxURL.Items.Clear()
        End If
        'Load Data
        URLListbox = ReproList.ListURL
        NameListBox = ReproList.ListName
        'Apply data
        MediaPlayer.Ctlcontrols.stop()
        PBPlay.Image = play
        TimerMediaController.Stop()
        LblDuration.Text = "00:00/00:00"
        MusicProgressBar.Value = 0
        MusicProgressBar.Maximum = 100
        Me.Text = DefaultNameProgram
        ListBoxName.Items.Clear()
        ListBoxURL.Items.Clear()
        MediaPlayer.URL = ""
        MediaPlayer.Invalidate()
        For Each item In NameListBox.Items
            ListBoxName.Items.Add(item)
        Next
        For Each item In URLListbox.Items
            ListBoxURL.Items.Add(item)
        Next
        PBPlay.Image = pause
        ListBoxName.SelectedIndex = NameListBox.SelectedIndex
        ListBoxURL.SelectedIndex = URLListbox.SelectedIndex
        MediaStopped = False
    End Sub
    Public Sub ListClear()
        TimerMediaController.Stop()
        ListBoxName.Items.Clear()
        ListBoxURL.Items.Clear()
        MediaPlayer.Ctlcontrols.stop()
        PBPlay.Image = play
        LblDuration.Text = "00:00/00:00"
        MusicProgressBar.Value = 0
        MusicProgressBar.Maximum = 100
        Me.Text = DefaultNameProgram
        ListBoxName.Items.Clear()
        ListBoxURL.Items.Clear()
        MediaPlayer.URL = ""
        MediaPlayer.Invalidate()
        MediaStopped = False
    End Sub
    Private Sub ListBoxURL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxURL.SelectedIndexChanged
        Try
            ListBoxName.SelectedIndex = ListBoxURL.SelectedIndex
            MediaPlayer.URL = ListBoxURL.SelectedItem
            MediaStopped = False
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxName.SelectedIndexChanged
        Try
            ListBoxURL.SelectedIndex = ListBoxName.SelectedIndex
            If TimerMediaController.Enabled = False Then
                TimerMediaController.Start()
                MediaStopped = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.OpacityForm < 0.1 Then
            My.Settings.OpacityForm = 0.1
        End If
        MediaPlayer.URL = ""
        MediaPlayer.uiMode = "none"
        MediaPlayer.enableContextMenu = False
        Me.DoubleBuffered = True
        MusicProgressBar.TabStop = False
        MediaPlayer.settings.volume = 100
    End Sub
    Private Sub PBPlay_Click(sender As Object, e As EventArgs) Handles PBPlay.Click
        Try
            If (ListBoxName.Items.Count = 0 And ListBoxURL.Items.Count = 0) = False Then
                If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                    MediaPlayer.Ctlcontrols.pause()
                    PBPlay.Image = play
                ElseIf MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
                    MediaPlayer.Ctlcontrols.play()
                    PBPlay.Image = pause
                ElseIf MediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
                    MediaPlayer.URL = ListBoxURL.SelectedItem
                    MediaPlayer.Ctlcontrols.play()
                    PBPlay.Image = pause
                    MediaStopped = False
                End If
            Else
                MsgBox("No hay ninguna multimedia!", MsgBoxStyle.Exclamation, "MediaPlayer")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PBStop_Click(sender As Object, e As EventArgs) Handles PBStop.Click
        If (ListBoxName.Items.Count = 0 And ListBoxURL.Items.Count = 0) = False Then
            MediaStopped = True
            MediaPlayer.Ctlcontrols.stop()
            PBPlay.Image = play
        End If
    End Sub
    Private Sub VolumeTest()
        If VolumeProgressBar.Value = 0 Then
            PBVolume.Image = volume_x
        ElseIf VolumeProgressBar.Value > 0 And VolumeProgressBar.Value < 34 Then
            PBVolume.Image = volume
        ElseIf VolumeProgressBar.Value >= 34 And VolumeProgressBar.Value < 67 Then
            PBVolume.Image = volume_1
        ElseIf VolumeProgressBar.Value >= 67 And VolumeProgressBar.Value <= 100 Then
            PBVolume.Image = volume_2
        End If
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles VolumeProgressBar.Scroll
        Try
            LblVolume.Text = VolumeProgressBar.Value
            MediaPlayer.settings.volume = VolumeProgressBar.Value
            VolumeTest()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MediaPlayer_MediaChange(sender As Object, e As _WMPOCXEvents_MediaChangeEvent) Handles MediaPlayer.MediaChange
        If MediaPlayer.currentMedia IsNot Nothing Then
            Dim dur As Double = MediaPlayer.currentMedia.duration
            If dur > 0 Then
                MusicProgressBar.Maximum = CInt(dur)
                TimerMediaController.Enabled = True 'activar el temporizador
            End If
        End If
    End Sub
    Private Sub TimerMediaController_Tick(sender As Object, e As EventArgs) Handles TimerMediaController.Tick
        Try
            Dim dur As Integer
            dur = MediaPlayer.currentMedia.duration
            MusicProgressBar.Maximum = Val(dur)
            MusicProgressBar.Value = MediaPlayer.Ctlcontrols.currentPosition
            LblDuration.Text = MediaPlayer.Ctlcontrols.currentPositionString + "/" + MediaPlayer.currentMedia.durationString
            Me.Text = MusicNameProgram + MediaPlayer.currentMedia.name

            Try
                If My.Settings.AutoPlayNext = True Then
                    If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped And MediaStopped = False Then
                        If ListBoxURL.SelectedIndex <> ListBoxURL.Items.Count - 1 Then
                            ListBoxURL.SelectedIndex += 1
                        End If
                    End If
                Else
                    If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped And MediaStopped = True Then
                        PBPlay.Image = play
                    End If
                End If
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MusicProgressBar_Scroll(sender As Object, e As EventArgs) Handles MusicProgressBar.Scroll
        MediaPlayer.Ctlcontrols.currentPosition = MusicProgressBar.Value
    End Sub
    Dim stoped As Boolean = False
    Private Sub PBVolume_Click(sender As Object, e As EventArgs) Handles PBVolume.Click
        Try
            If stoped = False Then
                VolumeProgressBar.Enabled = False
                MediaPlayer.settings.volume = 0
                PBVolume.Image = volume_x
                stoped = True
            ElseIf stoped = True Then
                VolumeProgressBar.Enabled = True
                MediaPlayer.settings.volume = VolumeProgressBar.Value
                VolumeTest()
                stoped = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ListaDeReproduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeReproduccionToolStripMenuItem.Click
        ReproList.Show()
    End Sub
    Private Sub PBMusicFordward_Click(sender As Object, e As EventArgs) Handles PBMusicFordward.Click
        If (ListBoxName.Items.Count = 0 And ListBoxURL.Items.Count = 0) = False Then
            Try
                ListBoxURL.SelectedIndex += 1
                MediaPlayer.URL = ListBoxURL.SelectedItem
            Catch ex As Exception
                ListBoxURL.SelectedIndex = 0
            End Try
        End If
    End Sub
    Private Sub PBMusicBack_Click(sender As Object, e As EventArgs) Handles PBMusicBack.Click
        If (ListBoxName.Items.Count = 0 And ListBoxURL.Items.Count = 0) = False Then
            Try
                If ListBoxURL.SelectedIndex <> 0 Then
                    ListBoxURL.SelectedIndex -= 1
                End If
                MediaPlayer.URL = ListBoxURL.SelectedItem
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        Config.Show()
    End Sub
End Class