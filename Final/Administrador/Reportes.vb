Public Class Reportes
    Private Sub MenuPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPrincipalToolStripMenuItem.Click
        Me.Hide()
        Menup.Show()
    End Sub
    Private Sub MenuDeAdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDeAdministraciónToolStripMenuItem.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub
    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim x As Integer
        x = MsgBox("¿Desea salir?", MsgBoxStyle.YesNo, "Salir")
        If x = vbYes Then
            End
        End If
    End Sub

    Private Sub Reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class