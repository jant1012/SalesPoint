Public Class Menup
    Private Sub btnventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnventas.Click
        Me.Hide()
        Contraseñanormal.Show()
    End Sub
    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        Me.Hide()
        Contraseña.Show()
    End Sub

    Private Sub Menup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class