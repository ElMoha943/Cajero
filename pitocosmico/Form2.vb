Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        SubmenuReportes.Visible = True
        Panel8.Visible = False
    End Sub

    Private Sub btnrptventa_Click(sender As Object, e As EventArgs) Handles btnrptventa.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub btnrptcompra_Click(sender As Object, e As EventArgs) Handles btnrptcompra.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub btnrptpagos_Click(sender As Object, e As EventArgs) Handles btnrptpagos.Click
        SubmenuReportes.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sqlquery As String = "INSERT INTO productos (nombre, precio) VALUES ('" & TextBox2.Text & "', " & TextBox3.Text & ");" ' COMANDO A EJECUTAR
        Dim comando As New MySqlCommand(sqlquery, conn)
        Try
            conn.Open()
            comando.ExecuteNonQuery()
            MsgBox("Producto agregado correctamente.")
        Catch ex As Exception
            MsgBox("Ocurrio un error al añadir el producto.")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim sqlquery As String = "SELECT * FROM productos WHERE id = " & TextBox4.Text & ");" ' COMANDO A EJECUTAR
        Dim comando As New MySqlCommand(sqlquery, conn)
        Dim datos As MySqlDataReader 'AQUI SE GUARDAN LOS DATOS DE LA CONSULTA
        Dim Exists = 0
        Try
            conn.Open()
            datos = comando.ExecuteReader()
            While datos.Read() 'AQUI SE PASAN LOS DATOS DE CADA COLUMNA A LAS VARIABLES DONDE SE GUARDARAN
                TextBox5.Text = datos("nombre").ToString 'nombre
                TextBox6.Text = datos("precio").ToString 'precio
                Exists = Exists + 1
            End While
            'Catch ex As Exception
            'MsgBox("Ocurrio un error al añadir el producto.")
        Finally
            conn.Close()
        End Try
        If Exists < 1 Then 'VERIFICA QUE EL PRODUCTO EXISTA
            MsgBox("No se encontro el producto")
        End If
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Dim conexion As String
        'conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\Desktop\pitocosmico\pitocosmico\Database1.mdf;Integrated Security=True"
        'Dim cn As New SqlConnection
        ' cn.ConnectionString = conexion

        'Dim adaptador As New SqlCommand()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Dim conexion As String
        ' conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\Desktop\pitocosmico\pitocosmico\Database1.mdf;Integrated Security=True"
        'Dim cn As New SqlConnection
        'cn.ConnectionString = conexion
        ' Dim adaptador As New SqlCommand("update Productos set producto_nombre = '" & TextBox5.Text & "',producto_precio = " & TextBox6.Text & " where producto_id = " & TextBox4.Text & " ", cn)

        ' cn.Open()
        'adaptador.ExecuteNonQuery()
        'MsgBox("Datos actualizados exitosamente")
    End Sub

End Class