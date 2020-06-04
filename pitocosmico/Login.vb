Imports MySql.Data.MySqlClient
Public Class Login

    Function login()
        Dim tempuser As String
        Dim temppass As String
        Dim temprole As String
        ' COMIENZA CONEXION BASE DE DATOS
        Dim connectionstring As String = "server=localhost;database=mercado;user id=mercado;password=mercado123;port=3306;" 'CONNECTION STRING
        Dim sqlquery As String = "SELECT * FROM usuarios WHERE username = '" & Label1.Text & "';" ' COMANDO A EJECUTAR
        Dim conn As New MySqlConnection(connectionstring)
        Dim comando As New MySqlCommand(sqlquery, conn)
        Dim datos As MySqlDataReader
        Try
            conn.Open()
            datos = comando.ExecuteReader()
            While datos.Read()
                'MsgBox("USER = " & datos("username").ToString) ' & " PASSOWRD = " & datos("password").ToString & " ROL = " & datos("rol").ToString)
                tempuser = datos("username").ToString 'nombre
                temppass = datos("password").ToString 'pass
                temprole = datos("rol").ToString 'rol
            End While
            If TextBox2.Text = temppass And TextBox1.Text = tempuser Then
                If temprole = "admin" Then
                    Form2.Show()
                Else
                    Form1.Show()
                End If
            Else
                MsgBox("Contraseña incorrecta")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("SE PRODUJO UN ERROR")
        Finally
            conn.Dispose()
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        login()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        login()
    End Sub

End Class