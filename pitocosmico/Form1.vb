Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Label_Product_Name.Visible = True
            Dim exists = 0
            Dim tempprice = 0
            Dim tempname As String = ""
            Dim tempstock = 0
            Dim sqlquery As String = "SELECT * FROM productos WHERE id = '" & TextBox1.Text & "';" ' COMANDO A EJECUTAR
            Dim comando As New MySqlCommand(sqlquery, conn)
            Dim datos As MySqlDataReader 'AQUI SE GUARDAN LOS DATOS DE LA CONSULTA
            Try
                conn.Open()
                datos = comando.ExecuteReader()
                While datos.Read() 'AQUI SE PASAN LOS DATOS DE CADA COLUMNA A LAS VARIABLES DONDE SE GUARDARAN
                    tempprice = datos("precio").ToString 'precio
                    tempname = datos("nombre").ToString 'nombre
                    tempstock = datos("stock").ToString 'strok
                    exists = exists + 1
                End While
                conn.Close()
            Catch ex As Exception
                MsgBox("SE PRODUJO UN ERROR")
            Finally
                conn.Dispose()
            End Try
            If exists = 1 Then
                Label_Product_Name.Text = tempname
                total = total + tempprice
                Label1.Text = ("TOTAL: " & total)
            Else
                Label_Product_Name.Text = "PRODUCTO NO ENCOTNRADO"
            End If
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            RadioButton1.Checked = False
            RadioButton3.Checked = False
            Label_Descuento.Visible = False
            tipo = "efectivo"
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True) Then
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            Label_Descuento.Visible = True
            Label_Descuento.Text = "descuento:" & DescVisa
            tipo = "visa"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked = True) Then
            RadioButton2.Checked = False
            RadioButton1.Checked = False
            Label_Descuento.Visible = True
            Label_Descuento.Text = "descuento:" & DescMastercard
            tipo = "mastercard"
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

    End Sub

    Private Sub Caja_Click(sender As Object, e As EventArgs) Handles Caja.Click
        Panel3.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Ventas_Click(sender As Object, e As EventArgs) Handles Ventas.Click
        Panel3.Visible = True
        Panel8.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click 'LOGOUT
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim fecha As Date = Today
        Dim sqlquery As String = "INSERT INTO tickets ('total', 'tipo', 'fecha') VALUES (" & total & ", '" & tipo & "', " & fecha & ")" ' COMANDO A EJECUTAR
        Dim comando As New MySqlCommand(sqlquery, conn)
        Try
            conn.Open()
            comando.ExecuteNonQuery()
            MsgBox("TICKET CREADO")
            total = 0
            Label1.Text = ("TOTAL: " & total)
            conn.Close()
        Catch ex As Exception
            MsgBox("OCURRIO UN ERROR")
        Finally
            conn.Dispose()
        End Try

    End Sub
End Class
