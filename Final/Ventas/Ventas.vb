Public Class Ventas
    Dim codigoproducto As String
    Dim cantidad, precio, subtotal, nombre, preciofac As String
    Dim total, subt As Double
    Private Sub Ventas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        conexion.Open()

        Me.lstv.FullRowSelect = True
        Me.lstv.MultiSelect = False
        Me.lstv.View = View.Details
        Me.lstv.Columns.Clear()
        Me.lstv.Items.Clear()

        Me.lstv.Columns.Add("Codigo", 250, HorizontalAlignment.Left)
        Me.lstv.Columns.Add("Nombre", 250, HorizontalAlignment.Left)
        Me.lstv.Columns.Add("Precio", 80, HorizontalAlignment.Left)
        Me.lstv.Columns.Add("Cantidad", 80, HorizontalAlignment.Left)
    End Sub
    Private Sub PanelAdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelAdministraciónToolStripMenuItem.Click
        Me.Hide()
        Menup.Show()
    End Sub
    Private Sub PanelAdministraciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelAdministraciónToolStripMenuItem1.Click
        Me.Hide()
        Contraseña.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        codigoproducto = textcod.Text
        cantidad = textcantidad.Text

        sql = "SELECT Id, Codigo, Nombre, Precio FROM Productos where Codigo='" & codigoproducto & "'"
        cmd.CommandText = sql
        cmd.Connection = conexion
        adaptador.SelectCommand = cmd

        adaptador.Fill(tabla)

        If (tabla.Rows.Count = 0) Then
            MsgBox("Producto no existente")
        End If

        For i = 0 To tabla.Rows.Count - 1
            Me.lstv.Items.Add(tabla.Rows(i)("Codigo"))
            Me.lstv.Items(Me.lstv.Items.Count - 1).SubItems.Add(tabla.Rows(i)("Nombre"))
            Me.lstv.Items(Me.lstv.Items.Count - 1).SubItems.Add(tabla.Rows(i)("Precio"))
            Me.lstv.Items(Me.lstv.Items.Count - 1).SubItems.Add(cantidad)


            Ticket.lstv2.Items.Add(tabla.Rows(i)("Nombre"))
            Ticket.lstv3.Items.Add(tabla.Rows(i)("Precio"))
            Ticket.lstv1.Items.Add(cantidad)


            Factura.lstv2.Items.Add(tabla.Rows(i)("Nombre"))
            Factura.lstv3.Items.Add(tabla.Rows(i)("Precio"))
            Factura.lstv1.Items.Add(cantidad)

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            dr = cmd.ExecuteReader
            If dr.Read Then
                precio = dr(3).ToString
                subt = subt + Val(cantidad) * Val(precio)
            End If
            dr.Close()

        Next
        conexion.Close()
        tabla.Clear()
        calcularTotales()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cambio As String
        calcularTotales()

        cambio = InputBox("Total pagado:")
        If cambio <> String.Empty Then
            If Val(cambio) < total Then
                MsgBox("El total es mayor")
            Else
                cambiofinal.Text = Val(cambio) - total
                Ticket.cambiofinal.Text = cambiofinal.Text
            End If

        End If
        btnfinalizar.Enabled = True
    End Sub

    Private Sub calcularTotales()
        Dim iva As Double

        iva = 0.16



        textsubt.Text = subt
        textiva.Text = subt * iva
        total = subt + Val(textiva.Text)

        Ticket.textotal.Text = total
        Ticket.textiva.Text = textiva.Text
        Ticket.textsubt.Text = textsubt.Text

        Factura.total.Text = total

        textotal.Text = total
        totalreporte = total
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfinalizar.Click
        Dim x As Integer
        Dim i As Integer
        Dim cantidad As String
        Dim codigo As String
        Dim sql As String
        x = MsgBox("¿Finalizar venta?", MsgBoxStyle.YesNo, "Finalizar venta")
        If x = vbYes Then
            For i = 0 To lstv.Items.Count - 1

                nombre = lstv.Items(i).SubItems(1).Text
                preciofac = lstv.Items(i).SubItems(2).Text
                cantidad = lstv.Items(i).SubItems(3).Text
                codigo = lstv.Items(i).SubItems(0).Text
                sql = "UPDATE Productos SET Cantidad = Cantidad-" & cantidad & " WHERE Codigo = '" & codigo & "' "
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If
                contadortotal = Val(contadortotal) + Val(total)
                Reportes.textventa.Text = contadortotal

                cmd.CommandText = sql
                cmd.Connection = conexion
                cmd.ExecuteNonQuery()

                conexion.Close()

            Next
            MsgBox("Venta finalizada correctamente")
            lstv.Items.Clear()
            textsubt.Text = ""
            textiva.Text = ""
            textotal.Text = ""
            cambiofinal.Text = ""

            subt = 0
            total = 0

        End If
        x = MsgBox("¿Desea Ticket/Factura?", MsgBoxStyle.YesNo, "Opciones")
        If x = vbYes Then
            Me.Hide()
            TicketFactura.Show()
        Else
            Ticket.lstv1.Items.Clear()
            Ticket.lstv2.Items.Clear()
            Ticket.lstv3.Items.Clear()
            Factura.lstv1.Items.Clear()
            Factura.lstv2.Items.Clear()
            Factura.lstv3.Items.Clear()

        End If
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
        Menup.Show()
    End Sub
End Class