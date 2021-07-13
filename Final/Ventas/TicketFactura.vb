Public Class TicketFactura
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnticket.Click
        Me.Hide()
        Ticket.Show()
    End Sub

    Private Sub btnfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfactura.Click
        Me.Hide()
        Factura.Show()
    End Sub

    Private Sub TicketFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class