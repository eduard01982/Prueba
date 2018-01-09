<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Llamador
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
        Me.ButtonLibre = New System.Windows.Forms.Button()
        Me.ButtonOcupado = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumeroDeCaja = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonLibre
        '
        Me.ButtonLibre.BackColor = System.Drawing.Color.LightGreen
        Me.ButtonLibre.Location = New System.Drawing.Point(102, 8)
        Me.ButtonLibre.Name = "ButtonLibre"
        Me.ButtonLibre.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLibre.TabIndex = 0
        Me.ButtonLibre.Text = "Libre"
        Me.ButtonLibre.UseVisualStyleBackColor = False
        '
        'ButtonOcupado
        '
        Me.ButtonOcupado.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonOcupado.Location = New System.Drawing.Point(102, 37)
        Me.ButtonOcupado.Name = "ButtonOcupado"
        Me.ButtonOcupado.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOcupado.TabIndex = 1
        Me.ButtonOcupado.Text = "Ocupado"
        Me.ButtonOcupado.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero de Caja"
        '
        'NumeroDeCaja
        '
        Me.NumeroDeCaja.AutoSize = True
        Me.NumeroDeCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDeCaja.Location = New System.Drawing.Point(36, 32)
        Me.NumeroDeCaja.Name = "NumeroDeCaja"
        Me.NumeroDeCaja.Size = New System.Drawing.Size(29, 31)
        Me.NumeroDeCaja.TabIndex = 9
        Me.NumeroDeCaja.Text = "0"
        '
        'Llamador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 72)
        Me.Controls.Add(Me.NumeroDeCaja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonOcupado)
        Me.Controls.Add(Me.ButtonLibre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Llamador"
        Me.Text = "Llamador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLibre As Button
    Friend WithEvents ButtonOcupado As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumeroDeCaja As Label
End Class
