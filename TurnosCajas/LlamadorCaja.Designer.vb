<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LlamadorCaja
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
        Me.NumeroDeCaja = New System.Windows.Forms.DomainUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonOcupado = New System.Windows.Forms.Button()
        Me.ButtonLibre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NumeroDeCaja
        '
        Me.NumeroDeCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDeCaja.Items.Add("1")
        Me.NumeroDeCaja.Items.Add("2")
        Me.NumeroDeCaja.Items.Add("3")
        Me.NumeroDeCaja.Items.Add("4")
        Me.NumeroDeCaja.Items.Add("5")
        Me.NumeroDeCaja.Items.Add("6")
        Me.NumeroDeCaja.Items.Add("7")
        Me.NumeroDeCaja.Items.Add("8")
        Me.NumeroDeCaja.Items.Add("9")
        Me.NumeroDeCaja.Items.Add("10")
        Me.NumeroDeCaja.Location = New System.Drawing.Point(30, 25)
        Me.NumeroDeCaja.Name = "NumeroDeCaja"
        Me.NumeroDeCaja.Size = New System.Drawing.Size(45, 27)
        Me.NumeroDeCaja.TabIndex = 8
        Me.NumeroDeCaja.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Numero de Caja"
        '
        'ButtonOcupado
        '
        Me.ButtonOcupado.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonOcupado.Location = New System.Drawing.Point(101, 33)
        Me.ButtonOcupado.Name = "ButtonOcupado"
        Me.ButtonOcupado.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOcupado.TabIndex = 6
        Me.ButtonOcupado.Text = "Ocupado"
        Me.ButtonOcupado.UseVisualStyleBackColor = False
        '
        'ButtonLibre
        '
        Me.ButtonLibre.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonLibre.Location = New System.Drawing.Point(101, 4)
        Me.ButtonLibre.Name = "ButtonLibre"
        Me.ButtonLibre.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLibre.TabIndex = 5
        Me.ButtonLibre.Text = "Libre"
        Me.ButtonLibre.UseVisualStyleBackColor = False
        '
        'LlamadorCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 61)
        Me.Controls.Add(Me.NumeroDeCaja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonOcupado)
        Me.Controls.Add(Me.ButtonLibre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LlamadorCaja"
        Me.Text = "LlamadorCaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumeroDeCaja As DomainUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonOcupado As Button
    Friend WithEvents ButtonLibre As Button
End Class
