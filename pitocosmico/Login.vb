Imports MySql.Data.MySqlClient
Public Class Login

    Function login()
        'EN ESTAS VARIABLES ALMACENAN LOS DATOS DE LOS USUARIOS
        Dim tempuser As String = ""
        Dim temppass As String = ""
        Dim temprole As String = ""
        'COMIENZA CONEXION BASE DE DATOS
        Dim sqlquery As String = "SELECT * FROM usuarios WHERE username = '" & TextBox1.Text & "';" ' COMANDO A EJECUTAR
        Dim comando As New MySqlCommand(sqlquery, conn)
        Dim datos As MySqlDataReader 'AQUI SE GUARDAN LOS DATOS DE LA CONSULTA
        Try
            conn.Open()
            datos = comando.ExecuteReader()
            While datos.Read() 'AQUI SE PASAN LOS DATOS DE CADA COLUMNA A LAS VARIABLES DONDE SE GUARDARAN
                tempuser = datos("username").ToString 'nombre
                temppass = datos("password").ToString 'pass
                temprole = datos("rol").ToString 'rol
            End While
            If TextBox2.Text = temppass And TextBox1.Text = tempuser Then 'COMPRUEBA QUE LAS CREDENCIALES DE LA BASE DE DATOS COINCIDAN CON LAS INGRESADAS
                If temprole = "admin" Then 'COMPRUEBA SI EL USUARIO ES ADMIN
                    Form2.Show() 'ABRE EL PANEL DE ADMIN
                    Me.Hide() 'CIERRA EL PANEL DE LOGIN
                Else
                    Form1.Show() 'ABRE EL PANEL DE USUARIO
                    Me.Hide()
                End If
            Else
                MsgBox("Credenciales Incorrectas")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("SE PRODUJO UN ERROR")
        Finally
            conn.Dispose()
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
        Return 0
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            login()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            login()
        End If
    End Sub

End Class