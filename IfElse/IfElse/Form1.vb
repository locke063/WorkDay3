Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        'if user did wrong thing, then msgBox and eliminate them

        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then 'imporrant that the inumber sections are in ()
            MessageBox.Show("Error: Please provide a number")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)


        'If user did the wrong thing, then msgbox and eliminate them

        If (num1 < 0 Or num2 < 0) Then
            MessageBox.Show("error: please type a positive number")
            Return
        End If



        If (num1 > num2) Then
            largerNum = num1

            txtResult.Text = "the larger number is..." & num1



        ElseIf (num1 < num2) Then
            largerNum = num2

            txtResult.Text = "the larger number is..." & num2


        End If




    End Sub
End Class
