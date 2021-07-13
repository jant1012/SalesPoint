Public Class Inventario
    Public y As String
    Private Sub Inventario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        llenaGrid()
    End Sub
    Private Sub Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
        conexion.Open()
        llenaGrid()
    End Sub
    Private Sub llenaGrid()
        Dim ds As New DataSet
        Dim strSql As String = "SELECT ID, Nombre, Codigo, PrecioUnitario, Precio, Marca, Cantidad  FROM Productos"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conexion)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Me.DataGrid1.DataSource = ds.Tables("tabla")
    End Sub
    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        Dim codigo As String
        codigo = textborrar.Text
        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion
        sql = "Delete from Productos where Codigo='" & codigo & "'"
        cmd.CommandText = sql
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Registro Eliminado")
            llenaGrid()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim codigo As String
        codigo = textbuscar.Text
        consultar(codigo)
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        y = MsgBox("¿Desea salir?", MsgBoxStyle.YesNo, "Salir")
        If y = vbYes Then
            End
        End If
    End Sub
    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub
    Private Sub PanelAdministraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelAdministraciónToolStripMenuItem.Click
        Me.Hide()
        Menup.Show()
    End Sub
    Private Sub PanelAdministraciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelAdministraciónToolStripMenuItem1.Click
        Me.Hide()
        Pprincipal.Show()
    End Sub
    
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If textborrar.Visible = True And btnborrar.Visible = True Then
            textborrar.Visible = False
            btnborrar.Visible = False
        End If
        textbuscar.Visible = True
        btnbuscar.Visible = True
    End Sub
    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Productonuevo.Show()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If textborrar.Visible = True And btnborrar.Visible = True Then
            textborrar.Visible = False
            btnborrar.Visible = False
        End If
        textbuscar.Visible = True
        btnbuscar.Visible = True

        textbuscar.Focus()
        textbuscar.Select()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Productonuevo.Show()
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If textbuscar.Visible = True And btnbuscar.Visible = True Then
            textbuscar.Visible = False
            btnbuscar.Visible = False
        End If
        textborrar.Visible = True
        btnborrar.Visible = True

        textborrar.Focus()
        textborrar.Select()
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem1.Click
        Me.Hide()
        Productonuevo.Show()
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

    Private Sub VolverToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem1.Click
        Dim x As Integer
        x = MsgBox("¿Desea volver?", MsgBoxStyle.YesNo, "Volver")
        If x = vbYes Then
            Me.Hide()
            Menup.Show()
        End If
        Me.Hide()
    End Sub
End Class
