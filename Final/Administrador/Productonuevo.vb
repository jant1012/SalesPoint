Public Class Productonuevo
    Private Sub Productonuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        conexion.Open()
    End Sub
    Private Sub btnguardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim nombre, codigo, marca, precio, preciounitario, cantidad As String
        nombre = textnombre.Text
        codigo = textcodigo.Text
        marca = textmarca.Text
        preciounitario = textunitario.Text
        precio = textprecio.Text
        cantidad = textcantidad.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        sql = "insert into Productos(nombre, codigo, marca, precio, cantidad, PrecioUnitario)"
        sql += "values('" & nombre & "','" & codigo & "','" & marca & "','" & precio & "','" & cantidad & "','" & preciounitario & "')"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Hide()
        Inventario.Show()

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim x As Integer
        x = MsgBox("¿Desea salir?", MsgBoxStyle.YesNo, "Salir")
        If x = vbYes Then
            End
        End If
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Inventario.Show()
    End Sub

    Private Sub MenuDeAdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDeAdministraciónToolStripMenuItem.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub

    Private Sub MenuPrinicipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPrinicipalToolStripMenuItem.Click
        Me.Hide()
        Menup.Show()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim nombre, codigo, marca, precio, cantidad As String
        nombre = textnombre.Text
        codigo = textcodigo.Text
        marca = textmarca.Text
        precio = textprecio.Text
        cantidad = textcantidad.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        sql = "insert into Productos(nombre, codigo, marca, precio, cantidad)"
        sql += "values('" & nombre & "','" & codigo & "','" & marca & "','" & precio & "','" & cantidad & "')"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Hide()
        Inventario.Show()
    End Sub
End Class