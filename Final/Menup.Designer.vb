<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menup))
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnadmin
        '
        Me.btnadmin.BackgroundImage = CType(resources.GetObject("btnadmin.BackgroundImage"), System.Drawing.Image)
        Me.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadmin.Location = New System.Drawing.Point(237, 68)
        Me.btnadmin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(169, 56)
        Me.btnadmin.TabIndex = 3
        Me.btnadmin.Text = "Administrador"
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.BackColor = System.Drawing.SystemColors.Control
        Me.btnventas.BackgroundImage = CType(resources.GetObject("btnventas.BackgroundImage"), System.Drawing.Image)
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnventas.Location = New System.Drawing.Point(29, 68)
        Me.btnventas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(154, 56)
        Me.btnventas.TabIndex = 2
        Me.btnventas.Text = "Ventas"
        Me.btnventas.UseVisualStyleBackColor = False
        '
        'Menup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(448, 170)
        Me.Controls.Add(Me.btnadmin)
        Me.Controls.Add(Me.btnventas)
        Me.Name = "Menup"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents btnventas As System.Windows.Forms.Button
End Class
