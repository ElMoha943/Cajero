Imports System.Data.SqlClient
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
        Dim conexion As String
        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\Desktop\pitocosmico\pitocosmico\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("insert into Productos values('" & TextBox2.Text & "','" & TextBox3.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Producto agregado correctamente")
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim conexion As String
        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\Desktop\pitocosmico\pitocosmico\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select*from Productos where producto_id=" & TextBox4.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            TextBox5.Text = ds.Tables("datos").Rows(0).Item(1).ToString 'nombre
            TextBox6.Text = ds.Tables("datos").Rows(0).Item(2).ToString 'precio
        Else
            MsgBox("No se encontro el producto")
        End If
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim conexion As String
        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\Desktop\pitocosmico\pitocosmico\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand()
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim conexion As String
        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\Desktop\pitocosmico\pitocosmico\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlCommand("update Productos set producto_nombre = '" & TextBox5.Text & "',producto_precio = " & TextBox6.Text & " where producto_id = " & TextBox4.Text & " ", cn)

        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Datos actualizados exitosamente")
    End Sub

    Private Sub panelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles panelContenedor.Paint

    End Sub
End Class