Public Class Cargando
    Public contador As Integer
    Private Sub ProgressBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar.Click
        ProgressBar.Value = 0.0
        ProgressBar.Maximum = 100
        Tiempo.Interval = 60
        Tiempo.Enabled = True
    End Sub
    Private Sub Tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tiempo.Tick
        If contador < 100 Then
            ProgressBar.Value = contador
            contador = contador + 1
        Else
            Tiempo.Enabled = False
            Me.Hide()
            Menup.Show()
        End If
    End Sub
End Class