<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textusuario = New System.Windows.Forms.TextBox()
        Me.textcontra = New System.Windows.Forms.TextBox()
        Me.btnseguir = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(330, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario:"
        '
        'textusuario
        '
        Me.textusuario.Location = New System.Drawing.Point(44, 32)
        Me.textusuario.Name = "textusuario"
        Me.textusuario.Size = New System.Drawing.Size(330, 20)
        Me.textusuario.TabIndex = 3
        '
        'textcontra
        '
        Me.textcontra.Location = New System.Drawing.Point(44, 102)
        Me.textcontra.Name = "textcontra"
        Me.textcontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textcontra.Size = New System.Drawing.Size(330, 20)
        Me.textcontra.TabIndex = 4
        '
        'btnseguir
        '
        Me.btnseguir.BackgroundImage = CType(resources.GetObject("btnseguir.BackgroundImage"), System.Drawing.Image)
        Me.btnseguir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnseguir.Location = New System.Drawing.Point(233, 144)
        Me.btnseguir.Name = "btnseguir"
        Me.btnseguir.Size = New System.Drawing.Size(141, 27)
        Me.btnseguir.TabIndex = 5
        Me.btnseguir.Text = "Seguir"
        Me.btnseguir.UseVisualStyleBackColor = True
        '
        'btnvolver
        '
        Me.btnvolver.BackgroundImage = CType(resources.GetObject("btnvolver.BackgroundImage"), System.Drawing.Image)
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnvolver.Location = New System.Drawing.Point(30, 144)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(129, 27)
        Me.btnvolver.TabIndex = 11
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(409, 183)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnseguir)
        Me.Controls.Add(Me.textcontra)
        Me.Controls.Add(Me.textusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Contraseña"
        Me.Text = "Contraseña Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textusuario As System.Windows.Forms.TextBox
    Friend WithEvents textcontra As System.Windows.Forms.TextBox
    Friend WithEvents btnseguir As System.Windows.Forms.Button
    Friend WithEvents btnvolver As System.Windows.Forms.Button
End Class
