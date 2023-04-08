Public Class Loader
    Public Sub New()
        InitializeComponent()
        Me.Visible = False
        Me.ShowInTaskbar = False
        Me.Opacity = 0
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Show()
        Main.Activate()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim frm As Form = Application.OpenForms().Cast(Of Form)().FirstOrDefault(Function(f) f.Name.Equals("Main"))
        Dim frm1 As Form = Application.OpenForms().Cast(Of Form)().FirstOrDefault(Function(f) f.Name.Equals("ReproList"))
        If frm Is Nothing And frm1 Is Nothing Then
            Application.Exit()
        End If
    End Sub
End Class