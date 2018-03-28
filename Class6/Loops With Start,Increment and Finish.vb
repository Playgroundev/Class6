Public Class Loops_With_Start_Increment_and_Finish

    Private Sub Increment_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtIncrement.TextChanged

    End Sub

    Private Sub BTnForNext_Click(sender As System.Object, e As System.EventArgs) Handles BTnForNext.Click
        Dim Num, Sum, Start, Increment, Finish As Integer
        Sum = 0
        Start = TxtStart.Text
        Increment = TxtIncrement.Text
        Finish = TxtFinish.Text
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        For Num = Start To Finish Step Increment
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)
        Next




    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Procedures.Show()


    End Sub
End Class