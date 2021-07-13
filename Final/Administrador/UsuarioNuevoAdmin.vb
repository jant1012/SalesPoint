Public Class UsuarioNuevoAdmin

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim usuario, contraseñausuario As String
        usuario = textusuario.Text
        contraseñausuario = textcontra.Text

        If textcontra.Text = textconfirmacion.Text Then
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion
            sql = "insert into Usuarios(Usuario, Contraseña)"
            sql += "values('" & usuario & "','" & contraseñausuario & "')"
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.Hide()
            CUsuarios.Show()
        Else
            MsgBox("Confirmación de clave erronea")
            textconfirmacion.Focus()
            textconfirmacion.SelectAll()
        End If
    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Hide()
        CUsuarios.Show()
    End Sub

    Private Sub UsuarioNuevoAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class