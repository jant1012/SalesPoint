<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAdministraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstv = New System.Windows.Forms.ListView()
        Me.textcod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cambiofinal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textsubt = New System.Windows.Forms.Label()
        Me.textiva = New System.Windows.Forms.Label()
        Me.btnfinalizar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PanelAdministraciónToolStripMenuItem, Me.PanelAdministraciónToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'PanelAdministraciónToolStripMenuItem
        '
        Me.PanelAdministraciónToolStripMenuItem.Name = "PanelAdministraciónToolStripMenuItem"
        Me.PanelAdministraciónToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PanelAdministraciónToolStripMenuItem.Text = "Panel Principal"
        '
        'PanelAdministraciónToolStripMenuItem1
        '
        Me.PanelAdministraciónToolStripMenuItem1.Name = "PanelAdministraciónToolStripMenuItem1"
        Me.PanelAdministraciónToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.PanelAdministraciónToolStripMenuItem1.Text = "Panel Administración"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Magneto", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(612, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mini Super Anchondo"
        '
        'lstv
        '
        Me.lstv.Location = New System.Drawing.Point(12, 198)
        Me.lstv.Name = "lstv"
        Me.lstv.Size = New System.Drawing.Size(658, 232)
        Me.lstv.TabIndex = 2
        Me.lstv.UseCompatibleStateImageBehavior = False
        '
        'textcod
        '
        Me.textcod.Location = New System.Drawing.Point(132, 146)
        Me.textcod.Name = "textcod"
        Me.textcod.Size = New System.Drawing.Size(227, 20)
        Me.textcod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(20, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código del Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(365, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad:"
        '
        'textcantidad
        '
        Me.textcantidad.Location = New System.Drawing.Point(425, 146)
        Me.textcantidad.Name = "textcantidad"
        Me.textcantidad.Size = New System.Drawing.Size(110, 20)
        Me.textcantidad.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(553, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cambiofinal
        '
        Me.cambiofinal.BackColor = System.Drawing.Color.Transparent
        Me.cambiofinal.Location = New System.Drawing.Point(541, 521)
        Me.cambiofinal.Name = "cambiofinal"
        Me.cambiofinal.Size = New System.Drawing.Size(71, 13)
        Me.cambiofinal.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(493, 521)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Cambio"
        '
        'textotal
        '
        Me.textotal.BackColor = System.Drawing.Color.Transparent
        Me.textotal.Location = New System.Drawing.Point(533, 497)
        Me.textotal.Name = "textotal"
        Me.textotal.Size = New System.Drawing.Size(71, 13)
        Me.textotal.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(493, 497)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(148, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Vender"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(493, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Subtotal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(493, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "I.V.A:"
        '
        'textsubt
        '
        Me.textsubt.BackColor = System.Drawing.Color.Transparent
        Me.textsubt.Location = New System.Drawing.Point(541, 451)
        Me.textsubt.Name = "textsubt"
        Me.textsubt.Size = New System.Drawing.Size(71, 13)
        Me.textsubt.TabIndex = 24
        '
        'textiva
        '
        Me.textiva.BackColor = System.Drawing.Color.Transparent
        Me.textiva.Location = New System.Drawing.Point(532, 473)
        Me.textiva.Name = "textiva"
        Me.textiva.Size = New System.Drawing.Size(71, 13)
        Me.textiva.TabIndex = 25
        '
        'btnfinalizar
        '
        Me.btnfinalizar.BackColor = System.Drawing.SystemColors.Control
        Me.btnfinalizar.BackgroundImage = CType(resources.GetObject("btnfinalizar.BackgroundImage"), System.Drawing.Image)
        Me.btnfinalizar.Enabled = False
        Me.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfinalizar.Location = New System.Drawing.Point(148, 510)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(176, 35)
        Me.btnfinalizar.TabIndex = 26
        Me.btnfinalizar.Text = "Finalizar Venta"
        Me.btnfinalizar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(708, 589)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnfinalizar)
        Me.Controls.Add(Me.textiva)
        Me.Controls.Add(Me.textsubt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cambiofinal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.textotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textcod)
        Me.Controls.Add(Me.lstv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ventas"
        Me.Text = "Punto de Ventas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelAdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelAdministraciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstv As System.Windows.Forms.ListView
    Friend WithEvents textcod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents textcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cambiofinal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents textsubt As System.Windows.Forms.Label
    Friend WithEvents textiva As System.Windows.Forms.Label
    Friend WithEvents btnfinalizar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
