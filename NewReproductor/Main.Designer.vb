<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeReproduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblDuration = New System.Windows.Forms.Label()
        Me.LblVolume = New System.Windows.Forms.Label()
        Me.PBVolume = New System.Windows.Forms.PictureBox()
        Me.VolumeProgressBar = New System.Windows.Forms.TrackBar()
        Me.PBMusicFordward = New System.Windows.Forms.PictureBox()
        Me.PBMusicBack = New System.Windows.Forms.PictureBox()
        Me.PBStop = New System.Windows.Forms.PictureBox()
        Me.PBPlay = New System.Windows.Forms.PictureBox()
        Me.MusicProgressBar = New System.Windows.Forms.TrackBar()
        Me.TimerMediaController = New System.Windows.Forms.Timer(Me.components)
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PBVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMusicFordward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBMusicBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.GhostWhite
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(645, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeReproduccionToolStripMenuItem, Me.ConfiguracionToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ListaDeReproduccionToolStripMenuItem
        '
        Me.ListaDeReproduccionToolStripMenuItem.Name = "ListaDeReproduccionToolStripMenuItem"
        Me.ListaDeReproduccionToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ListaDeReproduccionToolStripMenuItem.Text = "Lista de Reproduccion"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.LblDuration)
        Me.Panel1.Controls.Add(Me.LblVolume)
        Me.Panel1.Controls.Add(Me.PBVolume)
        Me.Panel1.Controls.Add(Me.VolumeProgressBar)
        Me.Panel1.Controls.Add(Me.PBMusicFordward)
        Me.Panel1.Controls.Add(Me.PBMusicBack)
        Me.Panel1.Controls.Add(Me.PBStop)
        Me.Panel1.Controls.Add(Me.PBPlay)
        Me.Panel1.Controls.Add(Me.MusicProgressBar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 68)
        Me.Panel1.TabIndex = 2
        '
        'LblDuration
        '
        Me.LblDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDuration.AutoSize = True
        Me.LblDuration.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDuration.Location = New System.Drawing.Point(437, 39)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(85, 20)
        Me.LblDuration.TabIndex = 1003
        Me.LblDuration.Text = "00:00/00:00"
        Me.LblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVolume
        '
        Me.LblVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblVolume.AutoSize = True
        Me.LblVolume.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolume.Location = New System.Drawing.Point(608, 39)
        Me.LblVolume.Name = "LblVolume"
        Me.LblVolume.Size = New System.Drawing.Size(33, 20)
        Me.LblVolume.TabIndex = 1002
        Me.LblVolume.Text = "100"
        Me.LblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBVolume
        '
        Me.PBVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBVolume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBVolume.Image = Global.NewReproductor.My.Resources.Resources.volume_2
        Me.PBVolume.Location = New System.Drawing.Point(528, 38)
        Me.PBVolume.Name = "PBVolume"
        Me.PBVolume.Size = New System.Drawing.Size(24, 24)
        Me.PBVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBVolume.TabIndex = 1001
        Me.PBVolume.TabStop = False
        '
        'VolumeProgressBar
        '
        Me.VolumeProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VolumeProgressBar.AutoSize = False
        Me.VolumeProgressBar.Location = New System.Drawing.Point(555, 38)
        Me.VolumeProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.VolumeProgressBar.Maximum = 100
        Me.VolumeProgressBar.Name = "VolumeProgressBar"
        Me.VolumeProgressBar.Size = New System.Drawing.Size(50, 24)
        Me.VolumeProgressBar.TabIndex = 6
        Me.VolumeProgressBar.TabStop = False
        Me.VolumeProgressBar.Value = 100
        '
        'PBMusicFordward
        '
        Me.PBMusicFordward.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PBMusicFordward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBMusicFordward.Image = Global.NewReproductor.My.Resources.Resources.skip_forward
        Me.PBMusicFordward.Location = New System.Drawing.Point(72, 38)
        Me.PBMusicFordward.Name = "PBMusicFordward"
        Me.PBMusicFordward.Size = New System.Drawing.Size(24, 24)
        Me.PBMusicFordward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBMusicFordward.TabIndex = 4
        Me.PBMusicFordward.TabStop = False
        '
        'PBMusicBack
        '
        Me.PBMusicBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PBMusicBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBMusicBack.Image = Global.NewReproductor.My.Resources.Resources.skip_back
        Me.PBMusicBack.Location = New System.Drawing.Point(12, 38)
        Me.PBMusicBack.Name = "PBMusicBack"
        Me.PBMusicBack.Size = New System.Drawing.Size(24, 24)
        Me.PBMusicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBMusicBack.TabIndex = 3
        Me.PBMusicBack.TabStop = False
        '
        'PBStop
        '
        Me.PBStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PBStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBStop.Image = Global.NewReproductor.My.Resources.Resources.square
        Me.PBStop.Location = New System.Drawing.Point(102, 38)
        Me.PBStop.Name = "PBStop"
        Me.PBStop.Size = New System.Drawing.Size(24, 24)
        Me.PBStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBStop.TabIndex = 2
        Me.PBStop.TabStop = False
        '
        'PBPlay
        '
        Me.PBPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PBPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBPlay.Image = Global.NewReproductor.My.Resources.Resources.play
        Me.PBPlay.Location = New System.Drawing.Point(42, 38)
        Me.PBPlay.Name = "PBPlay"
        Me.PBPlay.Size = New System.Drawing.Size(24, 24)
        Me.PBPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBPlay.TabIndex = 1
        Me.PBPlay.TabStop = False
        '
        'MusicProgressBar
        '
        Me.MusicProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MusicProgressBar.AutoSize = False
        Me.MusicProgressBar.Location = New System.Drawing.Point(12, 7)
        Me.MusicProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.MusicProgressBar.Maximum = 100
        Me.MusicProgressBar.Name = "MusicProgressBar"
        Me.MusicProgressBar.Size = New System.Drawing.Size(621, 25)
        Me.MusicProgressBar.TabIndex = 5
        Me.MusicProgressBar.TabStop = False
        '
        'TimerMediaController
        '
        Me.TimerMediaController.Interval = 1
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(0, 24)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(645, 282)
        Me.MediaPlayer.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(645, 370)
        Me.Controls.Add(Me.MediaPlayer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.NewReproductor.My.MySettings.Default, "OpacityForm", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(450, 325)
        Me.Name = "Main"
        Me.Opacity = Global.NewReproductor.My.MySettings.Default.OpacityForm
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reproductor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMusicFordward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBMusicBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MusicProgressBar As TrackBar
    Friend WithEvents PBPlay As PictureBox
    Friend WithEvents PBStop As PictureBox
    Friend WithEvents PBMusicFordward As PictureBox
    Friend WithEvents PBMusicBack As PictureBox
    Friend WithEvents VolumeProgressBar As TrackBar
    Friend WithEvents LblVolume As Label
    Friend WithEvents TimerMediaController As Timer
    Friend WithEvents LblDuration As Label
    Public WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ListaDeReproduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PBVolume As PictureBox
    Friend WithEvents ConfiguracionToolStripMenuItem As ToolStripMenuItem
End Class
