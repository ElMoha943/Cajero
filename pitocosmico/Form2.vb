Imports MySql.Data.MySqlClient
Public Class Form2

    Function Registrar()
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
        Return 0
    End Function

    Function Buscar()
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
        Return 0
    End Function

    Function Borrar()
        Dim sqlquery As String = "INSERT INTO productos (nombre, precio) VALUES ('" & TextBox2.Text & "', " & TextBox3.Text & ");" ' COMANDO A EJECUTAR
        Dim comando As New MySqlCommand(sqlquery, conn)
        Try
            conn.Open()

            conn.Close()
        Catch ex As Exception
            MsgBox("No se encontro el producto")
        Finally
            conn.Dispose()
        End Try
        Return 0
    End Function

    Function Actualizar()
        Dim sqlquery As String = "INSERT INTO productos (nombre, precio) VALUES ('" & TextBox2.Text & "', " & TextBox3.Text & ");" ' COMANDO A EJECUTAR
        Dim comando As New MySqlCommand(sqlquery, conn)
        Try
            conn.Open()

            conn.Close()
        Catch ex As Exception
            MsgBox("No se encontro el producto")
        Finally
            conn.Dispose()
        End Try
        Return 0
    End Function


    '====================EVENTOS=================================

    'BORRAR
    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Borrar()
    End Sub

    'ACTUALIZAR
    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Actualizar()
    End Sub

    'REGISTRAR
    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Registrar()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Registrar()
        End If
    End Sub
    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Registrar()
    End Sub
    'BUSCAR
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Buscar()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Buscar()
        End If
    End Sub

    'VISIBILIDAD DE MENUS
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
    'CERRAR SESION
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class