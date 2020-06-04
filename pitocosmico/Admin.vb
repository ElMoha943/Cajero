Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'CAJA
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'CREAR
        comando = New OleDb.OleDbCommand("INSERT INTO Usuarios(username, password, rol)" & Chr(13) &
                                         "VALUES(TextBox1, TextBox2, TextBox3)", conexion)
        comando.ExecuteNonQuery()
        MsgBox("Usuario Registrado!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'LOGS
        Me.Hide()
        Logs.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'CERRAR SESION
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class