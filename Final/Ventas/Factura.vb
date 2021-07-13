Public Class Factura
    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim x As Integer
        x = MsgBox("¿Desea salir?", MsgBoxStyle.YesNo, "Salir")
        If x = vbYes Then
            End
        End If
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Ventas.Show()
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Imprimir.Print()
    End Sub

    Private Sub Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class