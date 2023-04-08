Imports NewReproductor.UniversalController
Imports NewReproductor.My.Resources
Public Class Config
    Private AutoPlay As Boolean
    Private FormOpacity As Double = My.Settings.OpacityForm
    ReadOnly volControl As New VolumeControl()
    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.OpacityForm < 0.1 Then
            My.Settings.OpacityForm = 0.1
        End If
        If My.Settings.AutoPlayNext = True Then
            CBAutoPlay.Checked = True
        Else
            CBAutoPlay.Checked = False
        End If
        FormOpacity = My.Settings.OpacityForm
        OpacityProgressBar.Value = (My.Settings.OpacityForm * 100)
        LblOpacity.Text = Convert.ToString(OpacityProgressBar.Value) + "%"
        'Systen Volume
        LblVolume.Text = volControl.GetVolume()
        VolumeProgressBar.Value = volControl.GetVolume()
        VolumeTest()
    End Sub
    Sub ConfigUpdate()
        Try
            My.Settings.AutoPlayNext = AutoPlay
            If FormOpacity < 0.1 Then
                FormOpacity = 0.1
            End If
            If FormOpacity >= 0.1 Then
                My.Settings.OpacityForm = FormOpacity
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CBAutoPlay_CheckedChanged(sender As Object, e As EventArgs) Handles CBAutoPlay.CheckedChanged
        If CBAutoPlay.Checked = True Then
            AutoPlay = True
        Else
            AutoPlay = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConfigUpdate()
    End Sub
    Private Sub OpacityProgressBar_Scroll(sender As Object, e As EventArgs) Handles OpacityProgressBar.Scroll
        Try
            FormOpacity = (OpacityProgressBar.Value / 100)
            LblOpacity.Text = Convert.ToString(OpacityProgressBar.Value) + "%"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CBRealTime_CheckedChanged(sender As Object, e As EventArgs) Handles CBRealTime.CheckedChanged
        Try
            Dim allow As Boolean
            If CBRealTime.Checked = True Then
                MsgBox("Esta funcion te permitira ver algunos ajustes en tiempo real", MsgBoxStyle.Information, "Funcion en Pruebas")
                If MsgBoxResult.Ok Then
                    allow = True
                Else
                    allow = False
                End If
            Else
                allow = False
            End If
            If allow = False Then
                TimerReal.Stop()
                CBRealTime.Checked = False
            Else
                TimerReal.Start()
                CBRealTime.Checked = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TimerReal_Tick(sender As Object, e As EventArgs) Handles TimerReal.Tick
        ConfigUpdate()
    End Sub
    Private Sub VolumeProgressBar_Scroll(sender As Object, e As EventArgs) Handles VolumeProgressBar.Scroll
        volControl.SetVolume(VolumeProgressBar.Value)
        LblVolume.Text = VolumeProgressBar.Value
        VolumeTest()
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
    Dim stoped As Boolean = False
    Private Sub PBVolume_Click(sender As Object, e As EventArgs) Handles PBVolume.Click
        Try
            If stoped = False Then
                VolumeProgressBar.Enabled = False
                volControl.SetVolume(0)
                PBVolume.Image = volume_x
                stoped = True
            ElseIf stoped = True Then
                VolumeProgressBar.Enabled = True
                volControl.SetVolume(VolumeProgressBar.Value)
                VolumeTest()
                stoped = False
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class