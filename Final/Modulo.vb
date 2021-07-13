Module Modulo
    Public conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseDeDatos.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public adaptador As New OleDb.OleDbDataAdapter
    Public sql, eliminar, consulta As String
    Public tabla As New DataTable
    Public totalreporte, cantidad, nombre, precio, contadortotal As String
    Public Sub conectarse()
        Try
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub consultar(ByRef identificacion As String)
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        If identificacion <> " " Then
            cmd.CommandText = "SELECT ID, Nombre, Codigo, PrecioUnitario, Precio, Marca, Cantidad  FROM Productos WHERE Codigo='" & identificacion & "'"
        Else
            cmd.CommandText = "SELECT ID, Nombre, Codigo, PrecioUnitario, Precio, Marca, Cantidad  FROM Productos"
        End If

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            dr = cmd.ExecuteReader()


            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString + " " + dr(4).ToString + " " + dr(5).ToString + " " + dr(6).ToString)
                End While
            Else
                MsgBox("No existen registros")
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub consultarcodigo(ByRef identificacion As String)
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT nombre, precio, cantidad, preciounitario, marca FROM Productos WHERE Codigo='" & identificacion & "'"

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
