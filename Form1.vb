Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtbx1 As Decimal
        Dim txtbx2 As Decimal
        Dim txtbx3 As Integer
        Dim txtbx4 As Integer
        Dim txtbx5 As Decimal
        Dim txtbx6 As Integer
        Dim txtbxanswer As Double

        Decimal.TryParse(TextBox1.Text, txtbx1)
        Decimal.TryParse(TextBox2.Text, txtbx2)
        Integer.TryParse(TextBox3.Text, txtbx3)
        Integer.TryParse(TextBox4.Text, txtbx4)
        Decimal.TryParse(TextBox5.Text, txtbx5)
        Integer.TryParse(TextBox6.Text, txtbx6)

        txtbxanswer = ((txtbx1 * txtbx3) + (txtbx2 * txtbx4) + (txtbx5 * txtbx6)) / 100
        Label8.Text = txtbxanswer & "%"
    End Sub
End Class
