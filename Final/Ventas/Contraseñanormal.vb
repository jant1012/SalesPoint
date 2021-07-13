Public Class Contraseñanormal
    Dim f As Integer
    Private Sub Contraseñanormal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        conexion.Open()
        textusuario.Focus()
        textusuario.Select()
    End Sub
    Private Sub btnentrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentrar.Click
        consulta = "SELECT Usuario FROM Usuarios WHERE Usuario ='" & textusuario.Text & "'and Contraseña ='" & textcontra.Text & "'"
        cmd = New OleDb.OleDbCommand(consulta, conexion)
        adaptador.SelectCommand = cmd

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            Me.Hide()
            Ventas.Show()
            conexion.Close()
        Else
            MsgBox("La Contraseña o el Usuario son incorrectos")
            f = f + 1
            If f >= 5 Then
                MsgBox("Numero maximo de intentos alcanzamos", MsgBoxStyle.Critical, "Maximo de intentos")
                End
                conexion.Close()
            End If
            textusuario.Text = ""
            textcontra.Text = ""
            textusuario.Focus()
        End If
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        MsgBox("Introduzca la clave de administrador para poder acceder a crear una nueva cuenta")
        ContraseñaAdmin.Show()
    End Sub
End Class