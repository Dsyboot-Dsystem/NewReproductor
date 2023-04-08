Imports WMPLib
Imports System.IO
Imports System.Runtime.InteropServices
Imports CSCore.CoreAudioAPI

Public Class UniversalController
    Public Class Reproductor
        Private Shared ReadOnly WMPlayer As WindowsMediaPlayer
        Private Shared MediaFile As String
        Public Sub MediaURL(media As Object)
            MediaFile = media
        End Sub
        Public Sub MediaPlay()
            If MediaFile IsNot Nothing Then
                WMPlayer.controls.play()
            End If
        End Sub
        Public Sub MediaStop()
            If MediaFile IsNot Nothing Then
                WMPlayer.controls.stop()
            End If
        End Sub
    End Class
    Public Class DataManager
        Private Shared ReadOnly DataRoute As String = "%userprofile%\.data\Repro"
        Private Shared ReadOnly DataExtension As String = ".dat"
        Public Shared Sub DataSaver(Filename As String, ListofBox As ListBox)
            Try
                If Filename IsNot Nothing Then
                    Dim sw As New StreamWriter(DataRoute + Filename + DataExtension)
                    For Each item In ListofBox.Items
                        sw.WriteLine(item.ToString)
                    Next
                    sw.Close()
                End If
            Catch ex As Exception
                MsgBox("Eror en la base de datos", "No se pudo guardar los datos correctamente!")
            End Try
        End Sub
        Public Shared Sub DataLoader(Filename As String, ListofBox As ListBox)
            Try
                If Filename IsNot Nothing Then
                    Dim sr As New StreamReader(DataRoute + Filename + DataExtension)
                    While Not sr.EndOfStream
                        ListofBox.Items.Clear()
                        ListofBox.Items.Add(sr.ReadLine())
                    End While
                    sr.Close()
                End If
            Catch ex As Exception
                MsgBox("No se pudo cargar los datos correctamente!")
            End Try
        End Sub
    End Class
    Public Class VolumeControl
        Private ReadOnly endpointVolume As AudioEndpointVolume
        Public Sub New()
            Dim deviceEnumerator As New MMDeviceEnumerator()
            Dim defaultDevice As MMDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
            endpointVolume = AudioEndpointVolume.FromDevice(defaultDevice)
        End Sub
        Public Function GetVolume() As Integer
            Dim volumeLevel As Single = endpointVolume.MasterVolumeLevelScalar
            Return CInt(volumeLevel * 100)
        End Function
        Public Sub SetVolume(ByVal volume As Integer)
            If volume < 0 OrElse volume > 100 Then
                Throw New ArgumentOutOfRangeException("Volume must be between 0 and 100.")
            End If
            endpointVolume.MasterVolumeLevelScalar = CSng(volume / 100.0)
        End Sub
    End Class
End Class