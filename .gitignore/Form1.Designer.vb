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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboExistingMortgage = New System.Windows.Forms.TextBox()
        Me.tboPriceOldHome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tboPriceNewHome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tboStampDuty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tboNewHomeDeposit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tboAgentCommission = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.tboPriceNewHome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tboPriceOldHome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tboExistingMortgage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 321)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tboStampDuty)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tboNewHomeDeposit)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tboAgentCommission)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(361, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 321)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outputs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Existing Mortgage:"
        '
        'tboExistingMortgage
        '
        Me.tboExistingMortgage.Location = New System.Drawing.Point(170, 48)
        Me.tboExistingMortgage.Name = "tboExistingMortgage"
        Me.tboExistingMortgage.Size = New System.Drawing.Size(100, 26)
        Me.tboExistingMortgage.TabIndex = 1
        '
        'tboPriceOldHome
        '
        Me.tboPriceOldHome.Location = New System.Drawing.Point(170, 112)
        Me.tboPriceOldHome.Name = "tboPriceOldHome"
        Me.tboPriceOldHome.Size = New System.Drawing.Size(100, 26)
        Me.tboPriceOldHome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price of Old Home:"
        '
        'tboPriceNewHome
        '
        Me.tboPriceNewHome.Location = New System.Drawing.Point(170, 177)
        Me.tboPriceNewHome.Name = "tboPriceNewHome"
        Me.tboPriceNewHome.Size = New System.Drawing.Size(100, 26)
        Me.tboPriceNewHome.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price of New Home:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(20, 240)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(250, 42)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'tboStampDuty
        '
        Me.tboStampDuty.Location = New System.Drawing.Point(171, 183)
        Me.tboStampDuty.Name = "tboStampDuty"
        Me.tboStampDuty.ReadOnly = True
        Me.tboStampDuty.Size = New System.Drawing.Size(100, 26)
        Me.tboStampDuty.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Stamp Duty:"
        '
        'tboNewHomeDeposit
        '
        Me.tboNewHomeDeposit.Location = New System.Drawing.Point(171, 118)
        Me.tboNewHomeDeposit.Name = "tboNewHomeDeposit"
        Me.tboNewHomeDeposit.ReadOnly = True
        Me.tboNewHomeDeposit.Size = New System.Drawing.Size(100, 26)
        Me.tboNewHomeDeposit.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "New Home Deposit:"
        '
        'tboAgentCommission
        '
        Me.tboAgentCommission.Location = New System.Drawing.Point(171, 54)
        Me.tboAgentCommission.Name = "tboAgentCommission"
        Me.tboAgentCommission.ReadOnly = True
        Me.tboAgentCommission.Size = New System.Drawing.Size(100, 26)
        Me.tboAgentCommission.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Agent Commission:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 373)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents tboPriceNewHome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tboPriceOldHome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tboExistingMortgage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tboStampDuty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tboNewHomeDeposit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tboAgentCommission As TextBox
    Friend WithEvents Label6 As Label
End Class
