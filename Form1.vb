Public Class Form1
    Dim shopping As Double
    Dim i As Double
    Dim s As Double
    Dim p As Double
    Dim shopping2 As Double
    Dim price As Double
    Dim tax As Double
    Dim total_price As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total_price = 0
        shopping = 0
        shopping2 = 0
        Integer.TryParse(IphoneTextBox.Text, i)
        Integer.TryParse(SamsungTextBox.Text, s)
        Integer.TryParse(PixelTextBox.Text, p)
        Integer.TryParse(PriceTextBox.Text, price)
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        IphoneTextBox.Clear()
        IphoneTextBoxCount.Clear()
        SamsungTextBox.Clear()
        SamsungTextBoxCount.Clear()
        PixelTextBox.Clear()
        PixelTextBoxCount.Clear()
        TotalCostTextBox.Clear()
        PriceTextBox.Clear()
        TaxTextBox.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub IphoneButton_Click(sender As Object, e As EventArgs) Handles IphoneButton.Click
        Integer.TryParse(IphoneTextBox.Text, i)
        IphoneTextBoxCount.Text = i
        PriceTextBox.Text = (i * 900) + (s * 290) + (p * 320)
        Integer.TryParse(PriceTextBox.Text, price)
        TaxTextBox.Text = price * 0.0818
        total_price = TaxTextBox.Text + price
        TotalCostTextBox.Text = total_price.ToString("C2")
    End Sub

    Private Sub ShopButton_Click(sender As Object, e As EventArgs) Handles ShopButton.Click
        MessageBox.Show("Thanks for your purchase!")
        MessageBox.Show("Shipping: five bussiness days")
        MessageBox.Show("Price: " & TotalCostTextBox.Text)
        Me.Close()
    End Sub

    Private Sub SamsungButton_Click(sender As Object, e As EventArgs) Handles SamsungButton.Click
        Integer.TryParse(SamsungTextBox.Text, s)
        SamsungTextBoxCount.Text = s
        PriceTextBox.Text = (i * 900) + (s * 290) + (p * 320)
        Integer.TryParse(PriceTextBox.Text, price)
        TaxTextBox.Text = price * 0.0818
        total_price = TaxTextBox.Text + price
        TotalCostTextBox.Text = total_price.ToString("C2")
    End Sub

    Private Sub PixelButton_Click(sender As Object, e As EventArgs) Handles PixelButton.Click
        Integer.TryParse(PixelTextBox.Text, p)
        PixelTextBoxCount.Text = p
        PriceTextBox.Text = (i * 900) + (s * 290) + (p * 320)
        Integer.TryParse(PriceTextBox.Text, price)
        TaxTextBox.Text = price * 0.0818
        total_price = TaxTextBox.Text + price
        TotalCostTextBox.Text = total_price.ToString("C2")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Get your own help!")
    End Sub

    Private Sub MoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoreToolStripMenuItem.Click
        MessageBox.Show("Our about page")
        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ")
    End Sub
End Class
