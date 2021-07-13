Public Class CUsuarios
    Private Sub CUsuarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Grid()
    End Sub

    Private Sub CUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        conexion.Open()
        Grid()
    End Sub
    Private Sub Grid()
        Dim ds As New DataSet
        Dim strSql As String = "select usuario, contraseña FROM Usuarios"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conexion)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGrid1.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picbuscar.Click
        If textborrar.Visible = True And btnborrar.Visible = True Then
            textborrar.Visible = False
            btnborrar.Visible = False
        End If
        textbuscar.Visible = True
        btnbuscar.Visible = True

        textbuscar.Focus()
        textbuscar.Select()
    End Sub

    Private Sub picagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picagregar.Click
        Me.Hide()
        UsuarioNuevoAdmin.Show()
    End Sub

    Private Sub picborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picborrar.Click
        If textbuscar.Visible = True And btnbuscar.Visible = True Then
            textbuscar.Visible = False
            btnbuscar.Visible = False
        End If
        textborrar.Visible = True
        btnborrar.Visible = True

        textborrar.Focus()
        textborrar.Select()
    End Sub

    Private Sub PanelAdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelAdministraciónToolStripMenuItem.Click
        Me.Hide()
        Menup.Show()
    End Sub

    Private Sub PanelAdministraciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelAdministraciónToolStripMenuItem1.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub

    Private Sub VolverToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem1.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem1.Click
        Me.Hide()
        UsuarioNuevoAdmin.Show()
    End Sub

    Private Sub BorrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarToolStripMenuItem1.Click
        If textbuscar.Visible = True And btnbuscar.Visible = True Then
            textbuscar.Visible = False
            btnbuscar.Visible = False
        End If
        textborrar.Visible = True
        btnborrar.Visible = True

        textborrar.Focus()
        textborrar.Select()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem1.Click
        If textborrar.Visible = True And btnborrar.Visible = True Then
            textborrar.Visible = False
            btnborrar.Visible = False
        End If
        textbuscar.Visible = True
        btnbuscar.Visible = True

        textbuscar.Focus()
        textbuscar.Select()
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

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim nombre As String
        nombre = textbuscar.Text
        consultaru(nombre)
    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        Dim nombre As String
        nombre = textborrar.Text
        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        sql = "Delete from Usuarios where Usuario='" & nombre & "'"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro Eliminado")
            Grid()
            textborrar.SelectAll()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub consultaru(ByRef identificacion As String)
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        If identificacion <> String.Empty Then
            cmd.CommandText = "SELECT Usuario, Contraseña, UsuarioAdmin, ContraseñaAdmin FROM Usuarios WHERE Usuario='" & identificacion & "'"
        Else
            cmd.CommandText = "SELECT Usuario, Contraseña FROM Usuarios"
        End If
        Try
            dr = cmd.ExecuteReader()


            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr(0).ToString + " " + dr(1).ToString)
                End While
            Else
                MsgBox("No existen registros")
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class