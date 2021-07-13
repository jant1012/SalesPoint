<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAdministraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.textborrar = New System.Windows.Forms.TextBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.DocumentoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(496, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PanelAdministraciónToolStripMenuItem, Me.PanelAdministraciónToolStripMenuItem1, Me.VolverToolStripMenuItem1})
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
        'VolverToolStripMenuItem1
        '
        Me.VolverToolStripMenuItem1.Name = "VolverToolStripMenuItem1"
        Me.VolverToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.VolverToolStripMenuItem1.Text = "Volver"
        '
        'DocumentoToolStripMenuItem
        '
        Me.DocumentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem1, Me.BorrarToolStripMenuItem1, Me.BuscarToolStripMenuItem1})
        Me.DocumentoToolStripMenuItem.Name = "DocumentoToolStripMenuItem"
        Me.DocumentoToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DocumentoToolStripMenuItem.Text = "Documento"
        '
        'AgregarToolStripMenuItem1
        '
        Me.AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        Me.AgregarToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.AgregarToolStripMenuItem1.Text = "Agregar"
        '
        'BorrarToolStripMenuItem1
        '
        Me.BorrarToolStripMenuItem1.Name = "BorrarToolStripMenuItem1"
        Me.BorrarToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.BorrarToolStripMenuItem1.Text = "Borrar"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.BuscarToolStripMenuItem1.Text = "Buscar"
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
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'DataGrid1
        '
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(52, 105)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(385, 231)
        Me.DataGrid1.TabIndex = 2
        '
        'textborrar
        '
        Me.textborrar.Location = New System.Drawing.Point(12, 51)
        Me.textborrar.Name = "textborrar"
        Me.textborrar.Size = New System.Drawing.Size(157, 20)
        Me.textborrar.TabIndex = 5
        Me.textborrar.Text = "Buscar"
        Me.textborrar.Visible = False
        '
        'btnborrar
        '
        Me.btnborrar.BackgroundImage = CType(resources.GetObject("btnborrar.BackgroundImage"), System.Drawing.Image)
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnborrar.Location = New System.Drawing.Point(175, 48)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 6
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        Me.btnborrar.Visible = False
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(12, 51)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(157, 20)
        Me.textbuscar.TabIndex = 7
        Me.textbuscar.Text = "Buscar"
        Me.textbuscar.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackgroundImage = CType(resources.GetObject("btnbuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscar.Location = New System.Drawing.Point(175, 48)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        Me.btnbuscar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(356, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(284, 39)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(426, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(496, 348)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.textbuscar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.textborrar)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents textborrar As System.Windows.Forms.TextBox
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents textbuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DocumentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
