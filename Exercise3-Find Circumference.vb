Public Class mainForm

    Const PI As Double = 3.1416

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDiameter As Double
        Dim dblCircumference As Double

        If Double.TryParse(txtDiameter.Text, dblDiameter) Then
            dblCircumference = PI * dblDiameter
            lblCircumference.Text = "THE CIRCUMFERENCE = " & dblCircumference.ToString("F2")
        Else
            MessageBox.Show("PLEASE ENTER A VALID NUMBER FOR DIAMETER.", "Input Error")
            txtDiameter.Focus()
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

End Class