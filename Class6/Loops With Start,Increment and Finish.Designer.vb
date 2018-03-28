<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loops_With_Start_Increment_and_Finish
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
        Me.TxtStart = New System.Windows.Forms.TextBox()
        Me.TxtIncrement = New System.Windows.Forms.TextBox()
        Me.TxtFinish = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTnForNext = New System.Windows.Forms.Button()
        Me.LstLoops = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtStart
        '
        Me.TxtStart.Location = New System.Drawing.Point(94, 32)
        Me.TxtStart.Name = "TxtStart"
        Me.TxtStart.Size = New System.Drawing.Size(100, 20)
        Me.TxtStart.TabIndex = 0
        '
        'TxtIncrement
        '
        Me.TxtIncrement.Location = New System.Drawing.Point(94, 69)
        Me.TxtIncrement.Name = "TxtIncrement"
        Me.TxtIncrement.Size = New System.Drawing.Size(100, 20)
        Me.TxtIncrement.TabIndex = 1
        '
        'TxtFinish
        '
        Me.TxtFinish.Location = New System.Drawing.Point(94, 108)
        Me.TxtFinish.Name = "TxtFinish"
        Me.TxtFinish.Size = New System.Drawing.Size(100, 20)
        Me.TxtFinish.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Increment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Finish"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BTnForNext)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BTnForNext
        '
        Me.BTnForNext.Location = New System.Drawing.Point(7, 20)
        Me.BTnForNext.Name = "BTnForNext"
        Me.BTnForNext.Size = New System.Drawing.Size(75, 23)
        Me.BTnForNext.TabIndex = 0
        Me.BTnForNext.Text = "For Next"
        Me.BTnForNext.UseVisualStyleBackColor = True
        '
        'LstLoops
        '
        Me.LstLoops.FormattingEnabled = True
        Me.LstLoops.Location = New System.Drawing.Point(327, 45)
        Me.LstLoops.Name = "LstLoops"
        Me.LstLoops.Size = New System.Drawing.Size(120, 95)
        Me.LstLoops.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Loops_With_Start_Increment_and_Finish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 340)
        Me.Controls.Add(Me.LstLoops)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFinish)
        Me.Controls.Add(Me.TxtIncrement)
        Me.Controls.Add(Me.TxtStart)
        Me.Name = "Loops_With_Start_Increment_and_Finish"
        Me.Text = "Loops_With_Start_Increment_and_Finish"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtStart As System.Windows.Forms.TextBox
    Friend WithEvents TxtIncrement As System.Windows.Forms.TextBox
    Friend WithEvents TxtFinish As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTnForNext As System.Windows.Forms.Button
    Friend WithEvents LstLoops As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
