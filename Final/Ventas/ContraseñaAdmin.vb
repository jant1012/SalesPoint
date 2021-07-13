Public Class ContraseñaAdmin
    Public x, f As Integer
    Private Sub ContraseñaAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        conexion.Open()
    End Sub

    Private Sub btnseguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseguir.Click
        consulta = "SELECT UsuarioAdmin FROM Usuarios WHERE UsuarioAdmin ='" & textusuario.Text & "'and ContraseñaAdmin ='" & textcontra.Text & "'"
        cmd = New OleDb.OleDbCommand(consulta, conexion)
        adaptador.SelectCommand = cmd
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            Me.Hide()
            UsuarioNuevo.Show()
            conexion.Close()
        Else
            MsgBox("La Contraseña o el Usuario son incorrectos")
            f = f + 1
            If f >= 5 Then
                MsgBox("Numero maximo de intentos alcanzamos", MsgBoxStyle.Critical, "Maximo de intentos")
                End
            End If
            textusuario.Text = ""
            textcontra.Text = ""
            textusuario.Focus()
        End If
    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Dim x As Integer
        x = MsgBox("¿Desea volver?", MsgBoxStyle.YesNo, "Volver")
        If x = vbYes Then
            Me.Hide()
            Contraseñanormal.Show()
        End If
    End Sub
End Class