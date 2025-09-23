Imports System.Runtime.InteropServices

Public Class ToastForm
    Private WithEvents toastTimer As New Timer()
    Private fadeOutTimer As New Timer()
    Private fadeInTimer As New Timer()

    ' 🔷 Rounded corners (Win32 API)
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
        ByVal nLeftRect As Integer,
        ByVal nTopRect As Integer,
        ByVal nRightRect As Integer,
        ByVal nBottomRect As Integer,
        ByVal nWidthEllipse As Integer,
        ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Public Sub New(message As String)
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.FromArgb(255, 33, 33, 33)
        Me.ForeColor = Color.FromArgb(255, 250, 250, 250)
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.Opacity = 0 ' Start invisible
        Me.Height = 50
        Me.StartPosition = FormStartPosition.Manual

        ' Create Label
        Dim lbl As New Label With {
            .Text = message,
            .ForeColor = Color.FromArgb(255, 250, 250, 250),
            .Font = New Font("Segoe UI", 14),
            .TextAlign = ContentAlignment.MiddleCenter,
            .AutoSize = True
        }

        ' Measure message
        Dim g = CreateGraphics()
        Dim textSize = g.MeasureString(message, lbl.Font)
        g.Dispose()

        Dim minWidth As Integer = 300
        Dim padding As Integer = 40
        Dim finalWidth = Math.Max(minWidth, CInt(textSize.Width) + padding)

        Me.Width = finalWidth
        Me.Height = 50

        lbl.Dock = DockStyle.Fill
        lbl.AutoSize = False
        Me.Controls.Add(lbl)

        ' 🔷 Rounded corners
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 20, 20))

        ' Fade In timer
        fadeInTimer.Interval = 30
        AddHandler fadeInTimer.Tick, AddressOf FadeIn_Tick

        ' Fade Out timer
        fadeOutTimer.Interval = 30
        AddHandler fadeOutTimer.Tick, AddressOf FadeOut_Tick

        ' Show duration
        toastTimer.Interval = 3000
    End Sub

    Private Sub ToastForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenArea = Screen.PrimaryScreen.WorkingArea
        Me.Location = New Point(screenArea.Width - Me.Width - 20, screenArea.Height - Me.Height - 10)
        fadeInTimer.Start()
    End Sub

    ' 🔆 Fade In Animation
    Private Sub FadeIn_Tick(sender As Object, e As EventArgs)
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            fadeInTimer.Stop()
            toastTimer.Start()
        End If
    End Sub

    ' 🕒 Wait then fade out
    Private Sub toastTimer_Tick(sender As Object, e As EventArgs) Handles toastTimer.Tick
        toastTimer.Stop()
        fadeOutTimer.Start()
    End Sub

    ' 🔅 Fade Out Animation
    Private Sub FadeOut_Tick(sender As Object, e As EventArgs)
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.05
        Else
            fadeOutTimer.Stop()
            Me.Close()
        End If
    End Sub
End Class
