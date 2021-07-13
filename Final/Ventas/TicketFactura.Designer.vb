<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketFactura))
        Me.btnticket = New System.Windows.Forms.Button()
        Me.btnfactura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnticket
        '
        Me.btnticket.BackgroundImage = CType(resources.GetObject("btnticket.BackgroundImage"), System.Drawing.Image)
        Me.btnticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnticket.Location = New System.Drawing.Point(19, 35)
        Me.btnticket.Name = "btnticket"
        Me.btnticket.Size = New System.Drawing.Size(127, 44)
        Me.btnticket.TabIndex = 0
        Me.btnticket.Text = "Ticket"
        Me.btnticket.UseVisualStyleBackColor = True
        '
        'btnfactura
        '
        Me.btnfactura.BackgroundImage = CType(resources.GetObject("btnfactura.BackgroundImage"), System.Drawing.Image)
        Me.btnfactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfactura.Location = New System.Drawing.Point(180, 35)
        Me.btnfactura.Name = "btnfactura"
        Me.btnfactura.Size = New System.Drawing.Size(127, 44)
        Me.btnfactura.TabIndex = 1
        Me.btnfactura.Text = "Factura"
        Me.btnfactura.UseVisualStyleBackColor = True
        '
        'TicketFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(332, 110)
        Me.Controls.Add(Me.btnfactura)
        Me.Controls.Add(Me.btnticket)
        Me.Name = "TicketFactura"
        Me.Text = "Ticket o Factura"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnticket As System.Windows.Forms.Button
    Friend WithEvents btnfactura As System.Windows.Forms.Button
End Class
