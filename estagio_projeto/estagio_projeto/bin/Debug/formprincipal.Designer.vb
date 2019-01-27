<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formprincipal
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
        Me.btnregistar = New System.Windows.Forms.Button()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnregistar
        '
        Me.btnregistar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnregistar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistar.Location = New System.Drawing.Point(91, 149)
        Me.btnregistar.Name = "btnregistar"
        Me.btnregistar.Size = New System.Drawing.Size(97, 56)
        Me.btnregistar.TabIndex = 13
        Me.btnregistar.Text = "&Consultar Ativiades"
        Me.btnregistar.UseVisualStyleBackColor = True
        '
        'btnentrar
        '
        Me.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnentrar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrar.Location = New System.Drawing.Point(91, 77)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(97, 56)
        Me.btnentrar.TabIndex = 12
        Me.btnentrar.Text = "&Inserir Atividades"
        Me.btnentrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.estagio_projeto.My.Resources.Resources.gnome_panel_force_quit
        Me.PictureBox1.Location = New System.Drawing.Point(214, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'formprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnregistar)
        Me.Controls.Add(Me.btnentrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnregistar As Button
    Friend WithEvents btnentrar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
