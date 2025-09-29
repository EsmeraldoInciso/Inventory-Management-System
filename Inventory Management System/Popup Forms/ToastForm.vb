Imports System.Runtime.InteropServices

Public Class ToastForm
    Private WithEvents toastTimer As New Timer()
    Private fadeOutTimer As New Timer()
    Private fadeInTimer As New Timer()
    Private isTop As Boolean = False
    Private duration As Integer = 3000

    ' 🔷 Shared list to track active toasts
    Private Shared ActiveToasts As New List(Of ToastForm)

    ' Rounded corners (Win32 API)
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
        ByVal nLeftRect As Integer,
        ByVal nTopRect As Integer,
        ByVal nRightRect As Integer,
        ByVal nBottomRect As Integer,
        ByVal nWidthEllipse As Integer,
        ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Public Sub New(message As String,
                   Optional isTop As Boolean = False,
                   Optional duration As Integer = 3000,
                   Optional cornerRadius As Integer = 20)

        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.FromArgb(255, 33, 33, 33)
        Me.ForeColor = Color.White
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.Opacity = 0
        Me.Height = 50
        Me.StartPosition = FormStartPosition.Manual
        Me.isTop = isTop
        Me.duration = duration

        ' Measure text
        Dim g = CreateGraphics()
        Dim textSize = g.MeasureString(message, New Font("Segoe UI", 14))
        g.Dispose()

        Dim minWidth As Integer = 300
        Dim padding As Integer = 40
        Dim buttonExtra As Integer = If(isTop, 40, 0)
        Dim finalWidth = Math.Max(minWidth, CInt(textSize.Width) + padding + buttonExtra)

        Me.Width = finalWidth
        Me.Height = 50

        ' Rounded corners
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, cornerRadius, cornerRadius))

        ' Label
        Dim lbl As New Label With {
            .Text = message,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 14),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill
        }
        Me.Controls.Add(lbl)

        ' Fade timers
        fadeInTimer.Interval = 20
        AddHandler fadeInTimer.Tick, AddressOf FadeIn_Tick

        fadeOutTimer.Interval = 20
        AddHandler fadeOutTimer.Tick, AddressOf FadeOut_Tick

        toastTimer.Interval = duration

        ' Close button (only for pinned toasts)
        If isTop Then
            toastTimer.Enabled = True ' 🔹 Enable auto close even for top toasts
            toastTimer.Interval = 10000 ' 🔹 10 seconds
            Dim btnClose As New Button With {
                .Text = "×",
                .ForeColor = Color.White,
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .BackColor = Color.Transparent,
                .FlatStyle = FlatStyle.Flat,
                .Size = New Size(30, 30),
                .Dock = DockStyle.Right,
                .TabStop = False
            }
            btnClose.FlatAppearance.BorderSize = 0
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red
            btnClose.FlatAppearance.MouseDownBackColor = Color.DarkRed
            btnClose.Cursor = Cursors.Hand

            AddHandler btnClose.MouseEnter, Sub(sender, e) btnClose.ForeColor = Color.White
            AddHandler btnClose.MouseLeave, Sub(sender, e) btnClose.ForeColor = Color.White
            AddHandler btnClose.Click, Sub(sender, e) CloseToast()
            Me.Controls.Add(btnClose)
            btnClose.BringToFront()
        End If
    End Sub
    Public Function GetMessageText() As String
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                Return DirectCast(ctrl, Label).Text
            End If
        Next
        Return ""
    End Function

    Private Sub ToastForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Register this toast
        ActiveToasts.Add(Me)
        UpdatePositions()

        ' Start fade in
        fadeInTimer.Start()
    End Sub

    ' 🔄 Update positions of all active toasts
    Private Shared Sub UpdatePositions()
        Dim screenArea = Screen.PrimaryScreen.WorkingArea

        For i As Integer = 0 To ActiveToasts.Count - 1
            Dim toast = ActiveToasts(i)
            toast.Location = New Point(screenArea.Width - toast.Width - 20,
                                           50 + (i * (toast.Height + 5)))
            'If toast.isTop Then
            '    toast.Location = New Point(screenArea.Width - toast.Width - 20,
            '                               50 + (i * (toast.Height + 5)))
            'Else
            '    toast.Location = New Point(screenArea.Width - toast.Width - 20,
            '                               screenArea.Height - toast.Height - (-80) - (i * (toast.Height + 5)))
            'End If
        Next
    End Sub

    ' Fade In
    Private Sub FadeIn_Tick(sender As Object, e As EventArgs)
        Me.Opacity += 0.08
        If Me.Opacity >= 1 Then
            fadeInTimer.Stop()
            If Not isTop Then toastTimer.Start()
        End If
    End Sub

    ' Auto-close timer
    Private Sub toastTimer_Tick(sender As Object, e As EventArgs) Handles toastTimer.Tick
        toastTimer.Stop()
        fadeOutTimer.Start()
    End Sub

    ' Fade Out
    Private Sub FadeOut_Tick(sender As Object, e As EventArgs)
        Me.Opacity -= 0.08
        If Me.Opacity <= 0 Then
            fadeOutTimer.Stop()
            CloseToast()
        End If
    End Sub

    ' Proper close
    Private Sub CloseToast()
        ActiveToasts.Remove(Me)
        UpdatePositions()
        Me.Close()
    End Sub
End Class
