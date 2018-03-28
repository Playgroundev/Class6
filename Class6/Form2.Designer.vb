<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtHours = New System.Windows.Forms.TextBox()
        Me.TxtHourlyPay = New System.Windows.Forms.TextBox()
        Me.TxtTax = New System.Windows.Forms.TextBox()
        Me.TxtGrossPay = New System.Windows.Forms.TextBox()
        Me.TxtNetPay = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hourly Pay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gross Pay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Net Pay"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TxtNetPay)
        Me.GroupBox1.Controls.Add(Me.TxtGrossPay)
        Me.GroupBox1.Controls.Add(Me.TxtTax)
        Me.GroupBox1.Controls.Add(Me.TxtHourlyPay)
        Me.GroupBox1.Controls.Add(Me.TxtHours)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 218)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gross Salary"
        '
        'TxtHours
        '
        Me.TxtHours.Location = New System.Drawing.Point(61, 33)
        Me.TxtHours.Name = "TxtHours"
        Me.TxtHours.Size = New System.Drawing.Size(100, 20)
        Me.TxtHours.TabIndex = 6
        '
        'TxtHourlyPay
        '
        Me.TxtHourlyPay.Location = New System.Drawing.Point(71, 58)
        Me.TxtHourlyPay.Name = "TxtHourlyPay"
        Me.TxtHourlyPay.Size = New System.Drawing.Size(100, 20)
        Me.TxtHourlyPay.TabIndex = 7
        '
        'TxtTax
        '
        Me.TxtTax.Location = New System.Drawing.Point(50, 85)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.Size = New System.Drawing.Size(100, 20)
        Me.TxtTax.TabIndex = 8
        '
        'TxtGrossPay
        '
        Me.TxtGrossPay.Location = New System.Drawing.Point(71, 112)
        Me.TxtGrossPay.Name = "TxtGrossPay"
        Me.TxtGrossPay.Size = New System.Drawing.Size(100, 20)
        Me.TxtGrossPay.TabIndex = 9
        '
        'TxtNetPay
        '
        Me.TxtNetPay.Location = New System.Drawing.Point(71, 138)
        Me.TxtNetPay.Name = "TxtNetPay"
        Me.TxtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.TxtNetPay.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Process Pay Slip"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Functions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents TxtTax As System.Windows.Forms.TextBox
    Friend WithEvents TxtHourlyPay As System.Windows.Forms.TextBox
    Friend WithEvents TxtHours As System.Windows.Forms.TextBox
End Class
