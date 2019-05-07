Public Class Form1
    Dim Num1 As Double
    Dim Num2 As Double
    Dim Numma1 As Double
    Dim Numma2 As Double
    Dim ans As Double
    Dim answer As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        Numma1 = Double.Parse(txtNum1.Text)
        Numma2 = Double.Parse(txtNum2.Text)
        ans = Numma1 + Numma2

        answer = ans.ToString
        txtAns.Text = answer

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click

        Numma1 = Double.Parse(txtNum1.Text)
        Numma2 = Double.Parse(txtNum2.Text)
        ans = Numma1 - Numma2

        answer = ans.ToString
        txtAns.Text = answer

    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click

        Numma1 = Double.Parse(txtNum1.Text)
        Numma2 = Double.Parse(txtNum2.Text)
        ans = Numma1 * Numma2

        answer = ans.ToString
        txtAns.Text = answer

    End Sub

    Private Sub btnDividedBy_Click(sender As Object, e As EventArgs) Handles btnDividedBy.Click

        Numma1 = Double.Parse(txtNum1.Text)
        Numma2 = Double.Parse(txtNum2.Text)
        ans = Numma1 / Numma2

        answer = ans.ToString
        txtAns.Text = answer

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
