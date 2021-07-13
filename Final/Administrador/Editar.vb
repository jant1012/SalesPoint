Public Class Editar
    Private Sub Editar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        conexion.Open()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim nombre, codigo, preciounitario, precio, cantidad, marca As String

        If textnombre.Text = "" Then
            MsgBox("Rellene el campo de Nombre")
            textnombre.Select()
        ElseIf textcodigo.Text = "" Then
            MsgBox("Rellene el campo de Codigo")
            textcodigo.Select()
        ElseIf textunitario.Text = "" Then
            MsgBox("Rellene el campo de Precio Unitario")
            textunitario.Select()
        ElseIf textprecio.Text = "" Then
            MsgBox("Rellene el campo de Precio")
            textprecio.Select()
        ElseIf textcantidad.Text = "" Then
            MsgBox("Rellene el campo de Cantidad")
            textcantidad.Select()
        ElseIf textmarca.Text = "" Then
            MsgBox("Rellene el campo de Marca")
            textmarca.Select()
        End If
        nombre = textnombre.Text
        codigo = textcodigo.Text
        preciounitario = textunitario.Text
        precio = textprecio.Text
        cantidad = textcantidad.Text
        marca = textmarca.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        sql = "update [productos] set"
        sql += "[Nombre]='" & nombre & "', "
        sql += "[PrecioUnitario]='" & preciounitario & "', "
        sql += "[Precio]='" & precio & "', "
        sql += "[Cantidad]='" & cantidad & "', "
        sql += "[Marca]='" & marca & "' "
        sql += "Where [Codigo]='" & codigo & "' "
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro guardado")
            textnombre.Text = ""
            textcodigo.Text = ""
            textunitario.Text = ""
            textprecio.Text = ""
            textcantidad.Text = ""
            textmarca.Text = ""


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Hide()
        Inventario.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim nombre, codigo, preciounitario, precio, cantidad, marca As String

        If textnombre.Text = "" Then
            MsgBox("Rellene el campo de Nombre")
            textnombre.Select()
        ElseIf textcodigo.Text = "" Then
            MsgBox("Rellene el campo de Codigo")
            textcodigo.Select()
        ElseIf textunitario.Text = "" Then
            MsgBox("Rellene el campo de Precio Unitario")
            textunitario.Select()
        ElseIf textprecio.Text = "" Then
            MsgBox("Rellene el campo de Precio")
            textprecio.Select()
        ElseIf textcantidad.Text = "" Then
            MsgBox("Rellene el campo de Cantidad")
            textcantidad.Select()
        ElseIf textmarca.Text = "" Then
            MsgBox("Rellene el campo de Marca")
            textmarca.Select()
        End If
        nombre = textnombre.Text
        codigo = textcodigo.Text
        preciounitario = textunitario.Text
        precio = textprecio.Text
        cantidad = textcantidad.Text
        marca = textmarca.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        sql = "update [productos] set"
        sql += "[Nombre]='" & nombre & "', "
        sql += "[PrecioUnitario]='" & preciounitario & "', "
        sql += "[Precio]='" & precio & "', "
        sql += "[Cantidad]='" & cantidad & "', "
        sql += "[Marca]='" & marca & "' "
        sql += "Where [Codigo]='" & codigo & "' "
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro guardado")
            textnombre.Text = ""
            textcodigo.Text = ""
            textunitario.Text = ""
            textprecio.Text = ""
            textcantidad.Text = ""
            textmarca.Text = ""


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Hide()
        Inventario.Show()
    End Sub
    Private Sub MenuDeAdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDeAdministraciónToolStripMenuItem.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub
    Private Sub MenuPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPrincipalToolStripMenuItem.Click
        Me.Hide()
        Menup.Show()
    End Sub

    Private Sub textcodigo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textcodigo.Leave
        If textcodigo.Text <> String.Empty Then
            consultarcodigo(textcodigo.Text)
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            If dr.Read Then
                textnombre.Text = dr(0).ToString
                textunitario.Text = dr(3).ToString
                textprecio.Text = dr(1).ToString
                textcantidad.Text = dr(2).ToString
                textmarca.Text = dr(4).ToString

                dr.Close()
                btnguardar.Enabled = True
            Else
                MsgBox("No se encontraron registros")
                btnguardar.Enabled = True
            End If
        Else
            btnguardar.Enabled = False

        End If
    End Sub
End Class