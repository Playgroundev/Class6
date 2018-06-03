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
        Num = 15
        Sum = 0
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        Do
            'Sum = Sum + Num
            LstLoops.Items.Add(Num + 10)
            Num = Num + 10 'It can also be written as Num += 2'
        Loop While Num <= 80
    End Sub
    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        LstLoops.Items.Clear()

    End Sub
    Private Sub BtnDoUntilLoop_Click(sender As System.Object, e As System.EventArgs) Handles BtnDoUntilLoop.Click
        Dim Num, Sum As Integer
        Num = 15
        Sum = 0
        LstLoops.Items.Add("Num" & vbTab & "Sum")
        Do Until Num = 80
            ' Sum = Sum + Num
            LstLoops.Items.Add(Num + 10)
            Num = Num + 10 'It can also be written as Num += 1'
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
    Private Sub BtnLooperQ_Click(sender As System.Object, e As System.EventArgs) Handles BtnLooperQ.Click
        Dim Sum = 40, n As Integer
        LstLoops.Items.Add("n" & vbTab & "sum")
        Do
            n = n + 20
            Sum = Sum + n
            LstLoops.Items.Add(n & vbTab & Sum)
            If n = 100 Then
                Exit Do
            End If
        Loop
    End Sub
    Private Sub BtnForV2_Click(sender As System.Object, e As System.EventArgs) Handles BtnForV2.Click
        Dim Num As Integer
        Dim Sum As Integer
        Sum = 40
        For Num = 20 To 100 Step 20
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)
        Next
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Num As Integer
        Dim Sum As Integer
        Sum = 40
        Num = 20
        Do While Num <= 100
            Sum = Sum + Num
            LstLoops.Items.Add(Num & vbTab & Sum)
            Num += 20
        Loop
    End Sub

    Private Sub BtnRows_Click(sender As System.Object, e As System.EventArgs) Handles BtnRows.Click
        Dim Row, Mark As String
        LstLoops.Items.Clear()
        For i As Integer = 1 To 3
            Row = "     "
            For j As Integer = 1 To 3
                Mark = i & "+" & j & "=" & (i + j)
                Row &= Mark & "    "
            Next
            LstLoops.Items.Add(Row)
        Next
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim MarksData(), Line As String
        Line = "Christina, 365, Jane, 420, Malcolm, 388, Cliff, 450, Samuel, 430, Gloria, 395, Dorreen, 398, Deny, 410"
        MarksData = Line.Split(","c)
        For Each Mark As String In MarksData
            LstLoops.Items.Add(Mark)
        Next

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim Index As Integer
        For Index = 1 To 30 Step 4
            LstLoops.Items.Add(Index & "    " & Index * 5 & "       " & Index ^ 2)
        Next
    End Sub

    Private Sub BtnOutput_Click(sender As System.Object, e As System.EventArgs) Handles BtnOutput.Click
        Dim Age As Integer
        Age = 5
        Do While Age < 80
            LstLoops.Items.Add(Age + 15)
            Age = Age + 10
        Loop
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim Age As Integer
        For Age = 5 To 80 Step 10
            LstLoops.Items.Add(Age + 15)
            ' Age = Age + 10
        Next
    End Sub
End Class
