<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contraseñanormal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contraseñanormal))
        Me.textusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textcontra = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textusuario
        '
        Me.textusuario.Location = New System.Drawing.Point(54, 60)
        Me.textusuario.Name = "textusuario"
        Me.textusuario.Size = New System.Drawing.Size(330, 20)
        Me.textusuario.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(23, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(23, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Contraseña:"
        '
        'textcontra
        '
        Me.textcontra.Location = New System.Drawing.Point(54, 140)
        Me.textcontra.Name = "textcontra"
        Me.textcontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textcontra.Size = New System.Drawing.Size(330, 20)
        Me.textcontra.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(54, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 31)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Nueva Cuenta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnentrar
        '
        Me.btnentrar.BackgroundImage = CType(resources.GetObject("btnentrar.BackgroundImage"), System.Drawing.Image)
        Me.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnentrar.Location = New System.Drawing.Point(235, 192)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(119, 31)
        Me.btnentrar.TabIndex = 11
        Me.btnentrar.Text = "Entrar"
        Me.btnentrar.UseVisualStyleBackColor = True
        '
        'Contraseñanormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(407, 251)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.textcontra)
        Me.Controls.Add(Me.textusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Contraseñanormal"
        Me.Text = "Contraseña Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents textcontra As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnentrar As System.Windows.Forms.Button
End Class
