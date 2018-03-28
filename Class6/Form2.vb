Public Class Form2

    Private Sub TxtHours_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtHours.TextChanged

    End Sub


    Function ProcessPaySlip(ByVal Hrsworked As Double, ByVal hrly As Double, ByVal Tax As Double) As Double
        Dim Pay As Double
        Pay = Hrsworked * hrly - Tax
        Return Pay
    End Function


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim hrsworked, payhour, tax As Double
        hrsworked = TxtHours.Text
        payhour = TxtHourlyPay.Text
        tax = TxtTax.Text
        TxtNetPay.Text = ProcessPaySlip(hrsworked, payhour, tax)

    End Sub

    Private Sub TxtHourlyPay_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtHourlyPay.TextChanged

    End Sub
End Class