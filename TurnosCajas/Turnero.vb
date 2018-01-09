
Imports System.Threading
Public Class Turnero

    Dim oCaja As New BLL.Caja
    Dim todasocupadas As Boolean
    Dim cajadisponible As Int16
    Dim nuestroThread As Thread
    Dim nuestroThreadStart As New ThreadStart(AddressOf ActualizacionesBackground)
    Dim CallFuncionGenerar As New MethodInvoker(AddressOf Me.FuncionGenerar)
    Private Sub Turnero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nuestroThread = New Thread(nuestroThreadStart)
        nuestroThread.IsBackground = True
        nuestroThread.Name = "nuestroThread"
        nuestroThread.Start()

        Me.LabelHora.Text = String.Format("{0:HH:mm}", DateTime.Now)

        Timer1.Interval = 1000  ' Un segundo
        Timer1.Start()

        'Dim owms As New OpenWeatherMapService
        'LabelClima.Text = owms.GetForecastAsync("Río Gallegos", 1).ToString
        LabelClima.Visible = False

        Dim ruta As String

        ruta = "C:\Videos\video2.wmv"
        Me.AxWindowsMediaPlayer1.URL = ruta
        Try
            AxWindowsMediaPlayer1.BeginInit()
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            AxWindowsMediaPlayer1.settings.mute = True
            AxWindowsMediaPlayer1.uiMode = "none"
            AxWindowsMediaPlayer1.settings.setMode("loop", True)

        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub
    Sub cambiarmonitor(ByVal monitor As Integer)
        Dim pantalla As Screen
        Dim area As Rectangle
        pantalla = Screen.AllScreens(monitor)   'le paso 0 para el monitor principal y 1 para el secundario
        area = pantalla.Bounds
        Me.WindowState = FormWindowState.Normal
        Me.Hide()
        Me.StartPosition = FormStartPosition.Manual
        Dim p As New Point(pantalla.Bounds.Location.X, pantalla.Bounds.Location.Y)
        Me.Location = p
        Me.Width = area.Width
        Me.Height = area.Height
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        Me.LabelHora.Text = String.Format("{0:HH:mm}", DateTime.Now)

    End Sub

    Public Sub FuncionGenerar()
        Dim caj As Int16
        Dim todasocupadas As Boolean = True
        caj = oCaja.CajaConectadaYLibre()
        If (caj > 0) Then
            If (caj <> NumeroCajaLabel.Text) Or (EspereLabel.Visible) Then My.Computer.Audio.Play("c:\Windows\Media\notify.wav")
            NumeroCajaLabel.Text = caj
            NumeroCajaLabel.Visible = True
            EspereLabel.Visible = False
            todasocupadas = False

        End If


        If todasocupadas Then
            NumeroCajaLabel.Visible = False
            EspereLabel.Visible = True
        End If
    End Sub
    Public Sub ActualizacionesBackground()
        Try
            While True
                Me.BeginInvoke(CallFuncionGenerar)
                Thread.Sleep(150)
            End While
        Catch
        End Try
    End Sub
End Class
