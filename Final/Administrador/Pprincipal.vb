Public Class Pprincipal
    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Me.Hide()
        Editar.Show()
    End Sub
    Private Sub btninventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninventario.Click
        Me.Hide()
        Inventario.Show()
    End Sub

    Private Sub btnreportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreportes.Click
        Me.Hide()
        Reportes.Show()
    End Sub

    Private Sub btnventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnventas.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        CUsuarios.Show()
    End Sub

    Private Sub Pprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class