<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LstLoops = New System.Windows.Forms.ListBox()
        Me.Loops = New System.Windows.Forms.GroupBox()
        Me.BtnDoWhileLoop = New System.Windows.Forms.Button()
        Me.BtnDoLoopWhile = New System.Windows.Forms.Button()
        Me.BtnDoUntilLoop = New System.Windows.Forms.Button()
        Me.BtnDoLoopUntil = New System.Windows.Forms.Button()
        Me.BtnForNext = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Loops.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstLoops
        '
        Me.LstLoops.FormattingEnabled = True
        Me.LstLoops.Location = New System.Drawing.Point(367, 36)
        Me.LstLoops.Name = "LstLoops"
        Me.LstLoops.Size = New System.Drawing.Size(120, 95)
        Me.LstLoops.TabIndex = 0
        '
        'Loops
        '
        Me.Loops.Controls.Add(Me.Button1)
        Me.Loops.Controls.Add(Me.BtnClear)
        Me.Loops.Controls.Add(Me.BtnForNext)
        Me.Loops.Controls.Add(Me.BtnDoLoopUntil)
        Me.Loops.Controls.Add(Me.BtnDoUntilLoop)
        Me.Loops.Controls.Add(Me.BtnDoLoopWhile)
        Me.Loops.Controls.Add(Me.BtnDoWhileLoop)
        Me.Loops.Location = New System.Drawing.Point(33, 31)
        Me.Loops.Name = "Loops"
        Me.Loops.Size = New System.Drawing.Size(200, 247)
        Me.Loops.TabIndex = 1
        Me.Loops.TabStop = False
        Me.Loops.Text = "Loops"
        '
        'BtnDoWhileLoop
        '
        Me.BtnDoWhileLoop.Location = New System.Drawing.Point(7, 20)
        Me.BtnDoWhileLoop.Name = "BtnDoWhileLoop"
        Me.BtnDoWhileLoop.Size = New System.Drawing.Size(126, 23)
        Me.BtnDoWhileLoop.TabIndex = 0
        Me.BtnDoWhileLoop.Text = "Do While Loop"
        Me.BtnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'BtnDoLoopWhile
        '
        Me.BtnDoLoopWhile.Location = New System.Drawing.Point(7, 50)
        Me.BtnDoLoopWhile.Name = "BtnDoLoopWhile"
        Me.BtnDoLoopWhile.Size = New System.Drawing.Size(126, 23)
        Me.BtnDoLoopWhile.TabIndex = 1
        Me.BtnDoLoopWhile.Text = "Do Loop While"
        Me.BtnDoLoopWhile.UseVisualStyleBackColor = True
        '
        'BtnDoUntilLoop
        '
        Me.BtnDoUntilLoop.Location = New System.Drawing.Point(7, 76)
        Me.BtnDoUntilLoop.Name = "BtnDoUntilLoop"
        Me.BtnDoUntilLoop.Size = New System.Drawing.Size(126, 23)
        Me.BtnDoUntilLoop.TabIndex = 2
        Me.BtnDoUntilLoop.Text = "Do Until Loop"
        Me.BtnDoUntilLoop.UseVisualStyleBackColor = True
        '
        'BtnDoLoopUntil
        '
        Me.BtnDoLoopUntil.Location = New System.Drawing.Point(7, 106)
        Me.BtnDoLoopUntil.Name = "BtnDoLoopUntil"
        Me.BtnDoLoopUntil.Size = New System.Drawing.Size(126, 23)
        Me.BtnDoLoopUntil.TabIndex = 3
        Me.BtnDoLoopUntil.Text = "Do Loop Until"
        Me.BtnDoLoopUntil.UseVisualStyleBackColor = True
        '
        'BtnForNext
        '
        Me.BtnForNext.Location = New System.Drawing.Point(7, 136)
        Me.BtnForNext.Name = "BtnForNext"
        Me.BtnForNext.Size = New System.Drawing.Size(126, 23)
        Me.BtnForNext.TabIndex = 4
        Me.BtnForNext.Text = "For Next"
        Me.BtnForNext.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(7, 166)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 375)
        Me.Controls.Add(Me.Loops)
        Me.Controls.Add(Me.LstLoops)
        Me.Name = "Form1"
        Me.Text = "Loops"
        Me.Loops.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstLoops As System.Windows.Forms.ListBox
    Friend WithEvents Loops As System.Windows.Forms.GroupBox
    Friend WithEvents BtnForNext As System.Windows.Forms.Button
    Friend WithEvents BtnDoLoopUntil As System.Windows.Forms.Button
    Friend WithEvents BtnDoUntilLoop As System.Windows.Forms.Button
    Friend WithEvents BtnDoLoopWhile As System.Windows.Forms.Button
    Friend WithEvents BtnDoWhileLoop As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
