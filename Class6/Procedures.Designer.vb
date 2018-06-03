<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Procedures
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnComputeTotal = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtExam = New System.Windows.Forms.TextBox()
        Me.TxtCAT = New System.Windows.Forms.TextBox()
        Me.TxtAssgn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNetPay = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTax = New System.Windows.Forms.TextBox()
        Me.TxtGrossPay = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnComputeTotal)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.TxtExam)
        Me.GroupBox1.Controls.Add(Me.TxtCAT)
        Me.GroupBox1.Controls.Add(Me.TxtAssgn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compile Marks"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnComputeTotal
        '
        Me.BtnComputeTotal.Location = New System.Drawing.Point(18, 142)
        Me.BtnComputeTotal.Name = "BtnComputeTotal"
        Me.BtnComputeTotal.Size = New System.Drawing.Size(123, 23)
        Me.BtnComputeTotal.TabIndex = 8
        Me.BtnComputeTotal.Text = "Compute Total"
        Me.BtnComputeTotal.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(50, 94)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 7
        '
        'TxtExam
        '
        Me.TxtExam.Location = New System.Drawing.Point(50, 64)
        Me.TxtExam.Name = "TxtExam"
        Me.TxtExam.Size = New System.Drawing.Size(100, 20)
        Me.TxtExam.TabIndex = 6
        '
        'TxtCAT
        '
        Me.TxtCAT.Location = New System.Drawing.Point(50, 37)
        Me.TxtCAT.Name = "TxtCAT"
        Me.TxtCAT.Size = New System.Drawing.Size(100, 20)
        Me.TxtCAT.TabIndex = 5
        '
        'TxtAssgn
        '
        Me.TxtAssgn.Location = New System.Drawing.Point(50, 12)
        Me.TxtAssgn.Name = "TxtAssgn"
        Me.TxtAssgn.Size = New System.Drawing.Size(100, 20)
        Me.TxtAssgn.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CAT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assgn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNetPay)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtNet)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtTax)
        Me.GroupBox2.Controls.Add(Me.TxtGrossPay)
        Me.GroupBox2.Location = New System.Drawing.Point(296, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 209)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NetPay"
        '
        'BtnNetPay
        '
        Me.BtnNetPay.Location = New System.Drawing.Point(55, 164)
        Me.BtnNetPay.Name = "BtnNetPay"
        Me.BtnNetPay.Size = New System.Drawing.Size(75, 23)
        Me.BtnNetPay.TabIndex = 7
        Me.BtnNetPay.Text = "Net Pay"
        Me.BtnNetPay.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Net"
        '
        'TxtNet
        '
        Me.TxtNet.Location = New System.Drawing.Point(78, 115)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.Size = New System.Drawing.Size(100, 20)
        Me.TxtNet.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "GrossPay"
        '
        'TxtTax
        '
        Me.TxtTax.Location = New System.Drawing.Point(78, 77)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.Size = New System.Drawing.Size(100, 20)
        Me.TxtTax.TabIndex = 1
        '
        'TxtGrossPay
        '
        Me.TxtGrossPay.Location = New System.Drawing.Point(78, 30)
        Me.TxtGrossPay.Name = "TxtGrossPay"
        Me.TxtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.TxtGrossPay.TabIndex = 0
        '
        'Procedures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 383)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Procedures"
        Me.Text = "Procedures"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtExam As System.Windows.Forms.TextBox
    Friend WithEvents TxtCAT As System.Windows.Forms.TextBox
    Friend WithEvents TxtAssgn As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNetPay As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTax As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
