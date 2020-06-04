Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim CodeFound As String = 0
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Label_Product_Name.Visible = True
            If (TextBox1.Text = "hola") Then
                Label_Product_Name.Text = "Manaos papa"
                TextBox1.Text = ""
            Else
                TextBox1.Text = ""
                Label_Product_Name.Text = "PRODUCTO NO ENCOTNRADO"
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            RadioButton1.Checked = False
            RadioButton3.Checked = False
            Label_Descuento.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True) Then
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            Label_Descuento.Visible = True
            Label_Descuento.Text = "descuento:" & DescVisa
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked = True) Then
            RadioButton2.Checked = False
            RadioButton1.Checked = False
            Label_Descuento.Visible = True
            Label_Descuento.Text = "descuento:" & DescMastercard

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class
