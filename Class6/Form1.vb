Public Class Form1

    Private Sub BtnDoWhileLoop_Click(sender As System.Object, e As System.EventArgs) Handles BtnDoWhileLoop.Click
        Dim Num, Sum As Integer
        Num = 1
        Sum = 0
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        Do While Num <= 10
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)
            Num = Num + 1 'It can also be written as Num += 1'
        Loop
    End Sub

    Private Sub BtnDoLoopWhile_Click(sender As System.Object, e As System.EventArgs) Handles BtnDoLoopWhile.Click
        Dim Num, Sum As Integer
        Num = 2
        Sum = 0
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        Do
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)
            Num = Num + 2 'It can also be written as Num += 2'
        Loop While Num <= 10
    End Sub

    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        LstLoops.Items.Clear()

    End Sub

    Private Sub BtnDoUntilLoop_Click(sender As System.Object, e As System.EventArgs) Handles BtnDoUntilLoop.Click
        Dim Num, Sum As Integer
        Num = 1
        Sum = 0
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        Do Until Num = 10
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)
            Num = Num + 1 'It can also be written as Num += 1'
        Loop
    End Sub

    Private Sub BtnDoLoopUntil_Click(sender As System.Object, e As System.EventArgs) Handles BtnDoLoopUntil.Click
        Dim Num, Sum As Integer
        Num = 1
        Sum = 0
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        Do
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)
            Num = Num + 1 'It can also be written as Num += 1'
        Loop Until (Num = 10)

    End Sub

    Private Sub BtnForNext_Click(sender As System.Object, e As System.EventArgs) Handles BtnForNext.Click
        Dim Num, Sum As Integer
        Sum = 0
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        For Num = 1 To 10
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)

        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Loops_With_Start_Increment_and_Finish.Show()

    End Sub
End Class
