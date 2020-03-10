Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim entree As Double
        Dim drinks As Double
        Dim meal As Double
        Dim addit As Double
        Dim tip As Double
        Dim tax As Double
        Dim ans As Double
        Dim ans2 As Double
        Dim ans3 As Double
        Dim ans4 As Double

        Double.TryParse(TextBox1.Text, entree)
        Double.TryParse(TextBox2.Text, drinks)
        Double.TryParse(TextBox3.Text, meal)
        Double.TryParse(TextBox4.Text, addit)
        Double.TryParse(TextBox5.Text, tip)
        Double.TryParse(TextBox6.Text, tax)

        ans = (entree + drinks + meal + addit) * tip
        ans2 = (entree + drinks + meal + addit)
        ans4 = ans2 * tax
        ans3 = ans + (entree + drinks + meal + addit) + ans4
        Label9.Text = "$" & ans
        Label8.Text = "$" & ans2
        Label11.Text = "$" & ans3
        Label12.Text = "$" & ans4
    End Sub
End Class
