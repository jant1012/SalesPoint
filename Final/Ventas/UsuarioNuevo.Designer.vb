<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuarioNuevo))
        Me.textcontra = New System.Windows.Forms.TextBox()
        Me.textusuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textconfirmacion = New System.Windows.Forms.TextBox()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textcontra
        '
        Me.textcontra.Location = New System.Drawing.Point(52, 126)
        Me.textcontra.Name = "textcontra"
        Me.textcontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textcontra.Size = New System.Drawing.Size(330, 20)
        Me.textcontra.TabIndex = 15
        '
        'textusuario
        '
        Me.textusuario.Location = New System.Drawing.Point(52, 46)
        Me.textusuario.Name = "textusuario"
        Me.textusuario.Size = New System.Drawing.Size(330, 20)
        Me.textusuario.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(21, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(21, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Location = New System.Drawing.Point(21, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Confirmación Contraseña:"
        '
        'textconfirmacion
        '
        Me.textconfirmacion.Location = New System.Drawing.Point(52, 218)
        Me.textconfirmacion.Name = "textconfirmacion"
        Me.textconfirmacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textconfirmacion.Size = New System.Drawing.Size(330, 20)
        Me.textconfirmacion.TabIndex = 17
        '
        'btnvolver
        '
        Me.btnvolver.BackgroundImage = CType(resources.GetObject("btnvolver.BackgroundImage"), System.Drawing.Image)
        Me.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnvolver.Location = New System.Drawing.Point(52, 259)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(90, 31)
        Me.btnvolver.TabIndex = 18
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImage = CType(resources.GetObject("btnguardar.BackgroundImage"), System.Drawing.Image)
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnguardar.Location = New System.Drawing.Point(228, 259)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(90, 31)
        Me.btnguardar.TabIndex = 19
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'UsuarioNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(413, 302)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.textconfirmacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textcontra)
        Me.Controls.Add(Me.textusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UsuarioNuevo"
        Me.Text = "Registro Nuevo Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textcontra As System.Windows.Forms.TextBox
    Friend WithEvents textusuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textconfirmacion As System.Windows.Forms.TextBox
    Friend WithEvents btnvolver As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
End Class
