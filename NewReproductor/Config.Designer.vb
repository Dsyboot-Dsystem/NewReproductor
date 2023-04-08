<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Config
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config))
        Me.LblType = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBAutoPlay = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpacityProgressBar = New System.Windows.Forms.TrackBar()
        Me.LblOpacity = New System.Windows.Forms.Label()
        Me.CBRealTime = New System.Windows.Forms.CheckBox()
        Me.TimerReal = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LblVolume = New System.Windows.Forms.Label()
        Me.PBVolume = New System.Windows.Forms.PictureBox()
        Me.VolumeProgressBar = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpacityProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.BackColor = System.Drawing.Color.Transparent
        Me.LblType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblType.Location = New System.Drawing.Point(12, 8)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(95, 20)
        Me.LblType.TabIndex = 1005
        Me.LblType.Text = "Reproductor:"
        Me.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NewReproductor.My.Resources.Resources.clock
        Me.PictureBox1.Location = New System.Drawing.Point(16, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1006
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.NewReproductor.My.Resources.Resources.fast_forward
        Me.PictureBox2.Location = New System.Drawing.Point(30, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1007
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 1008
        Me.Label1.Text = "AutoPlayNext:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 17)
        Me.Label2.TabIndex = 1009
        Me.Label2.Text = "Reproduce la siguiente cancion de forma automatica"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-19, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(487, 13)
        Me.Label3.TabIndex = 1010
        Me.Label3.Text = "---------------------------------------------------------------------------------" &
    "-------------------------------------------------------------------------------"
        '
        'CBAutoPlay
        '
        Me.CBAutoPlay.AutoSize = True
        Me.CBAutoPlay.Location = New System.Drawing.Point(378, 56)
        Me.CBAutoPlay.Name = "CBAutoPlay"
        Me.CBAutoPlay.Size = New System.Drawing.Size(56, 17)
        Me.CBAutoPlay.TabIndex = 1011
        Me.CBAutoPlay.Text = "Active"
        Me.CBAutoPlay.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1012
        Me.Button1.Text = "Aplicar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.NewReproductor.My.Resources.Resources.eye
        Me.PictureBox3.Location = New System.Drawing.Point(16, 92)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1013
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 1014
        Me.Label4.Text = "Opacity:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 17)
        Me.Label5.TabIndex = 1015
        Me.Label5.Text = "cambia la visibilidad del programa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpacityProgressBar
        '
        Me.OpacityProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpacityProgressBar.AutoSize = False
        Me.OpacityProgressBar.Location = New System.Drawing.Point(322, 101)
        Me.OpacityProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.OpacityProgressBar.Maximum = 100
        Me.OpacityProgressBar.Minimum = 10
        Me.OpacityProgressBar.Name = "OpacityProgressBar"
        Me.OpacityProgressBar.Size = New System.Drawing.Size(69, 24)
        Me.OpacityProgressBar.TabIndex = 1016
        Me.OpacityProgressBar.TabStop = False
        Me.OpacityProgressBar.Value = 100
        '
        'LblOpacity
        '
        Me.LblOpacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblOpacity.AutoSize = True
        Me.LblOpacity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpacity.Location = New System.Drawing.Point(389, 100)
        Me.LblOpacity.Name = "LblOpacity"
        Me.LblOpacity.Size = New System.Drawing.Size(45, 20)
        Me.LblOpacity.TabIndex = 1017
        Me.LblOpacity.Text = "100%"
        Me.LblOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBRealTime
        '
        Me.CBRealTime.AutoSize = True
        Me.CBRealTime.Location = New System.Drawing.Point(313, 140)
        Me.CBRealTime.Name = "CBRealTime"
        Me.CBRealTime.Size = New System.Drawing.Size(109, 17)
        Me.CBRealTime.TabIndex = 1018
        Me.CBRealTime.Text = "RealTime Update"
        Me.CBRealTime.UseVisualStyleBackColor = True
        '
        'TimerReal
        '
        Me.TimerReal.Interval = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.NewReproductor.My.Resources.Resources.eye_off
        Me.PictureBox4.Location = New System.Drawing.Point(31, 111)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 1019
        Me.PictureBox4.TabStop = False
        '
        'LblVolume
        '
        Me.LblVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblVolume.AutoSize = True
        Me.LblVolume.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolume.Location = New System.Drawing.Point(389, 208)
        Me.LblVolume.Name = "LblVolume"
        Me.LblVolume.Size = New System.Drawing.Size(33, 20)
        Me.LblVolume.TabIndex = 1022
        Me.LblVolume.Text = "100"
        Me.LblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBVolume
        '
        Me.PBVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBVolume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBVolume.Image = Global.NewReproductor.My.Resources.Resources.volume_2
        Me.PBVolume.Location = New System.Drawing.Point(27, 207)
        Me.PBVolume.Name = "PBVolume"
        Me.PBVolume.Size = New System.Drawing.Size(24, 24)
        Me.PBVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PBVolume.TabIndex = 1021
        Me.PBVolume.TabStop = False
        '
        'VolumeProgressBar
        '
        Me.VolumeProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VolumeProgressBar.AutoSize = False
        Me.VolumeProgressBar.Location = New System.Drawing.Point(63, 207)
        Me.VolumeProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.VolumeProgressBar.Maximum = 100
        Me.VolumeProgressBar.Name = "VolumeProgressBar"
        Me.VolumeProgressBar.Size = New System.Drawing.Size(323, 24)
        Me.VolumeProgressBar.TabIndex = 1020
        Me.VolumeProgressBar.TabStop = False
        Me.VolumeProgressBar.Value = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-19, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(487, 13)
        Me.Label6.TabIndex = 1023
        Me.Label6.Text = "---------------------------------------------------------------------------------" &
    "-------------------------------------------------------------------------------"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 20)
        Me.Label7.TabIndex = 1024
        Me.Label7.Text = "Control del Sistema:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(434, 286)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblVolume)
        Me.Controls.Add(Me.PBVolume)
        Me.Controls.Add(Me.VolumeProgressBar)
        Me.Controls.Add(Me.CBRealTime)
        Me.Controls.Add(Me.LblOpacity)
        Me.Controls.Add(Me.OpacityProgressBar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBAutoPlay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.NewReproductor.My.MySettings.Default, "OpacityForm", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 325)
        Me.Name = "Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpacityProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblType As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBAutoPlay As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpacityProgressBar As TrackBar
    Friend WithEvents LblOpacity As Label
    Friend WithEvents CBRealTime As CheckBox
    Friend WithEvents TimerReal As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LblVolume As Label
    Friend WithEvents PBVolume As PictureBox
    Friend WithEvents VolumeProgressBar As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
