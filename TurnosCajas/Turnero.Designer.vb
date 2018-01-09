<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turnero
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turnero))
        Me.GroupBoxCaja = New System.Windows.Forms.GroupBox()
        Me.EspereLabel = New System.Windows.Forms.Label()
        Me.NumeroCajaLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.LabelClima = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GroupBoxCaja.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxCaja
        '
        Me.GroupBoxCaja.Controls.Add(Me.EspereLabel)
        Me.GroupBoxCaja.Controls.Add(Me.NumeroCajaLabel)
        Me.GroupBoxCaja.Font = New System.Drawing.Font("Helvetica-Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCaja.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBoxCaja.Location = New System.Drawing.Point(32, 319)
        Me.GroupBoxCaja.Name = "GroupBoxCaja"
        Me.GroupBoxCaja.Size = New System.Drawing.Size(234, 209)
        Me.GroupBoxCaja.TabIndex = 0
        Me.GroupBoxCaja.TabStop = False
        Me.GroupBoxCaja.Text = "PASE POR CAJA"
        '
        'EspereLabel
        '
        Me.EspereLabel.AutoSize = True
        Me.EspereLabel.Font = New System.Drawing.Font("Helvetica-Black", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EspereLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.EspereLabel.Location = New System.Drawing.Point(32, 92)
        Me.EspereLabel.Name = "EspereLabel"
        Me.EspereLabel.Size = New System.Drawing.Size(174, 50)
        Me.EspereLabel.TabIndex = 1
        Me.EspereLabel.Text = "Espere"
        '
        'NumeroCajaLabel
        '
        Me.NumeroCajaLabel.AutoSize = True
        Me.NumeroCajaLabel.Font = New System.Drawing.Font("Helvetica-Black", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroCajaLabel.Location = New System.Drawing.Point(57, 58)
        Me.NumeroCajaLabel.Name = "NumeroCajaLabel"
        Me.NumeroCajaLabel.Size = New System.Drawing.Size(114, 119)
        Me.NumeroCajaLabel.TabIndex = 0
        Me.NumeroCajaLabel.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TurnosCajas.My.Resources.Resources.logo_verde
        Me.PictureBox1.Location = New System.Drawing.Point(61, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHora.ForeColor = System.Drawing.Color.SeaGreen
        Me.LabelHora.Location = New System.Drawing.Point(48, 558)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(218, 64)
        Me.LabelHora.TabIndex = 3
        Me.LabelHora.Text = "HH:MM"
        '
        'LabelClima
        '
        Me.LabelClima.AutoSize = True
        Me.LabelClima.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClima.ForeColor = System.Drawing.Color.SeaGreen
        Me.LabelClima.Location = New System.Drawing.Point(83, 621)
        Me.LabelClima.Name = "LabelClima"
        Me.LabelClima.Size = New System.Drawing.Size(136, 64)
        Me.LabelClima.TabIndex = 5
        Me.LabelClima.Text = "0 °C"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(296, 12)
        Me.AxWindowsMediaPlayer1.MaximumSize = New System.Drawing.Size(1046, 800)
        Me.AxWindowsMediaPlayer1.MinimumSize = New System.Drawing.Size(10, 100)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1046, 686)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        '
        'Turnero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.LabelClima)
        Me.Controls.Add(Me.LabelHora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBoxCaja)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Turnero"
        Me.Text = "Turnero"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxCaja.ResumeLayout(False)
        Me.GroupBoxCaja.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxCaja As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NumeroCajaLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelHora As Label
    Friend WithEvents LabelClima As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents EspereLabel As Label
End Class
