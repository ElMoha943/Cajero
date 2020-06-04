Imports System.Data.SqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String
        conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\Desktop\pitocosmico\pitocosmico\Database1.mdf;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim tempuser As String
        Dim temppass As String
        Dim temprole As String

        Dim adaptador As New SqlDataAdapter("select*from Usuarios where username='" & TextBox1.Text & "'", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            tempuser = ds.Tables("datos").Rows(0).Item(0).ToString 'nombre
            temppass = ds.Tables("datos").Rows(0).Item(1).ToString 'pass
            temprole = ds.Tables("datos").Rows(0).Item(2).ToString 'rol
            If TextBox2.Text = temppass And TextBox1.Text = tempuser Then
                If temprole = "admin" Then
                    Form2.Show()
                Else
                    Form1.Show()
                End If
            Else
                MsgBox("Contraseña incorrecta")
            End If
        Else
            MsgBox("Este usuario No existe")
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            If (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then
                Me.Hide()
                Form2.Show()
            Else
                If (TextBox1.Text = "user" And TextBox2.Text = "user") Then
                    Me.Hide()
                    Form1.Show()
                Else
                    MsgBox("A INGRESADO MAL LA CLAVE O USUARIO")
                End If
            End If
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            If (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then
                Me.Hide()
                Form2.Show()
            Else
                If (TextBox1.Text = "user" And TextBox2.Text = "user") Then
                    Me.Hide()
                    Form1.Show()
                Else
                    MsgBox("A INGRESADO MAL LA CLAVE O USUARIO")
                End If
            End If
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
End Class