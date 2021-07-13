<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pprincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pprincipal))
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnreportes = New System.Windows.Forms.Button()
        Me.btninventario = New System.Windows.Forms.Button()
        Me.btnventas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = CType(resources.GetObject("btneditar.BackgroundImage"), System.Drawing.Image)
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btneditar.Location = New System.Drawing.Point(12, 92)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(170, 56)
        Me.btneditar.TabIndex = 0
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnreportes
        '
        Me.btnreportes.BackgroundImage = CType(resources.GetObject("btnreportes.BackgroundImage"), System.Drawing.Image)
        Me.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnreportes.Location = New System.Drawing.Point(12, 182)
        Me.btnreportes.Name = "btnreportes"
        Me.btnreportes.Size = New System.Drawing.Size(170, 56)
        Me.btnreportes.TabIndex = 2
        Me.btnreportes.Text = "Venta Diaria"
        Me.btnreportes.UseVisualStyleBackColor = True
        '
        'btninventario
        '
        Me.btninventario.BackgroundImage = CType(resources.GetObject("btninventario.BackgroundImage"), System.Drawing.Image)
        Me.btninventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btninventario.Location = New System.Drawing.Point(230, 92)
        Me.btninventario.Name = "btninventario"
        Me.btninventario.Size = New System.Drawing.Size(170, 56)
        Me.btninventario.TabIndex = 3
        Me.btninventario.Text = "Inventario"
        Me.btninventario.UseVisualStyleBackColor = True
        '
        'btnventas
        '
        Me.btnventas.BackgroundImage = CType(resources.GetObject("btnventas.BackgroundImage"), System.Drawing.Image)
        Me.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnventas.Location = New System.Drawing.Point(230, 182)
        Me.btnventas.Name = "btnventas"
        Me.btnventas.Size = New System.Drawing.Size(170, 56)
        Me.btnventas.TabIndex = 4
        Me.btnventas.Text = "Ventas"
        Me.btnventas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(124, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Control de Usuarios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(159, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(291, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Pprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(424, 334)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnventas)
        Me.Controls.Add(Me.btninventario)
        Me.Controls.Add(Me.btnreportes)
        Me.Controls.Add(Me.btneditar)
        Me.Name = "Pprincipal"
        Me.Text = "Punto de Administración"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnreportes As System.Windows.Forms.Button
    Friend WithEvents btninventario As System.Windows.Forms.Button
    Friend WithEvents btnventas As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
