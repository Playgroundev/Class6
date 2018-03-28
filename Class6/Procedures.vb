Public Class Procedures
    'Declaring a procedure compute total
    Private Sub ComputeTotal()
        Dim Assgn, CAT, Exam, Total As Double
        Assgn = TxtAssgn.Text
        CAT = TxtCAT.Text
        Exam = TxtExam.Text
        Total = Assgn + CAT + Exam
        TxtTotal.Text = Total

    End Sub
    'Calling the procedure compute total
    Private Sub BtnComputeTotal_Click(sender As System.Object, e As System.EventArgs) Handles BtnComputeTotal.Click
        Call ComputeTotal()

    End Sub
    'Declaring a procedure called computeNetPay()
    Private Sub TxtGrossPay_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtGrossPay.TextChanged
        Dim Gross, Tax, Net As Double
        Gross = TxtGrossPay.Text
        Tax = TxtTax.Text
        Net = Gross - Gross * Tax
        TxtNet.Text = Net



    End Sub
    'Calling the procedure compute Net
    Private Sub BtnNetPay_Click(sender As System.Object, e As System.EventArgs) Handles BtnNetPay.Click


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class