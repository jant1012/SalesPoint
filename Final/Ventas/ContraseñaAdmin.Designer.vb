<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContraseñaAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContraseñaAdmin))
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.textcontra = New System.Windows.Forms.TextBox()
        Me.textusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnseguir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnvolver
        '
        Me.btnvolver.BackgroundImage = CType(resources.GetObject("btnvolver.BackgroundImage"), System.Drawing.Image)
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnvolver.Location = New System.Drawing.Point(43, 241)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(141, 27)
        Me.btnvolver.TabIndex = 10
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'textcontra
        '
        Me.textcontra.Location = New System.Drawing.Point(43, 188)
        Me.textcontra.Name = "textcontra"
        Me.textcontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textcontra.Size = New System.Drawing.Size(330, 20)
        Me.textcontra.TabIndex = 9
        '
        'textusuario
        '
        Me.textusuario.Location = New System.Drawing.Point(43, 118)
        Me.textusuario.Name = "textusuario"
        Me.textusuario.Size = New System.Drawing.Size(330, 20)
        Me.textusuario.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Contraseña:"
        '
        'btnseguir
        '
        Me.btnseguir.BackgroundImage = CType(resources.GetObject("btnseguir.BackgroundImage"), System.Drawing.Image)
        Me.btnseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnseguir.Location = New System.Drawing.Point(215, 241)
        Me.btnseguir.Name = "btnseguir"
        Me.btnseguir.Size = New System.Drawing.Size(141, 27)
        Me.btnseguir.TabIndex = 11
        Me.btnseguir.Text = "Seguir"
        Me.btnseguir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ContraseñaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(401, 313)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnseguir)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.textcontra)
        Me.Controls.Add(Me.textusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ContraseñaAdmin"
        Me.Text = "Contraseña Administrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnvolver As System.Windows.Forms.Button
    Friend WithEvents textcontra As System.Windows.Forms.TextBox
    Friend WithEvents textusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnseguir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
