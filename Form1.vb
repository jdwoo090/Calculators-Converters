Public Class Form1
    Dim money As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As New Random
        Label1.Text = r.Next(1, 69)
        Label2.Text = r.Next(1, 69)
        Label3.Text = r.Next(1, 69)
        Label4.Text = r.Next(1, 69)
        Label5.Text = r.Next(1, 69)
        Label6.Text = r.Next(1, 69)
        Label7.Text = r.Next(1, 69)
        Label8.Text = r.Next(1, 69)
        money = money - 20
        If TextBox1.Text = Label1.Text And TextBox2.Text = Label2.Text And TextBox3.Text = Label3.Text And TextBox4.Text = Label4.Text And TextBox5.Text = Label5.Text And TextBox6.Text = Label6.Text And TextBox7.Text = Label7.Text And TextBox8.Text = Label8.Text And TextBox1.Text <> "" Then
            MessageBox.Show("JACKPOT!!!!!")
            money = money + 2500000
            moneyLabel.Text = "Money: " & money
        ElseIf TextBox1.Text = Label1.Text And TextBox3.Text = Label3.Text And TextBox5.Text = Label5.Text And TextBox7.Text = Label7.Text And TextBox1.Text <> "" Then
            MessageBox.Show("All odds!")
            money = money + 1500
            moneyLabel.Text = "Money: " & money
        ElseIf TextBox2.Text = Label2.Text And TextBox4.Text = Label4.Text And TextBox6.Text = Label6.Text And TextBox8.Text = Label8.Text And textbox2.Text <> "" Then
            MessageBox.Show("All evens!")
            money = money + 2000
            moneyLabel.Text = "Money: " & money
        ElseIf TextBox1.Text = Label1.Text Or TextBox2.Text = Label2.Text Or TextBox3.Text = Label3.Text Or TextBox4.Text = Label4.Text Or TextBox5.Text = Label5.Text Or TextBox6.Text = Label6.Text Or TextBox7.Text = Label7.Text Or TextBox8.Text = Label8.Text And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" Then
            MessageBox.Show("You won a small prize!")
            money = money + 25
            moneyLabel.Text = "Money: " & money
        Else
            moneyLabel.Text = "Money: " & money
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.ShowDialog()
        money = 20
        moneyLabel.Text = "Money: " & money
    End Sub
End Class
