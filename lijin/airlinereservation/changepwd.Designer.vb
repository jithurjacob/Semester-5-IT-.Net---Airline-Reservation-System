<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepwd
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
        Me.repwd_txt = New System.Windows.Forms.TextBox()
        Me.npwd_txt = New System.Windows.Forms.TextBox()
        Me.pwd_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'repwd_txt
        '
        Me.repwd_txt.Location = New System.Drawing.Point(241, 240)
        Me.repwd_txt.Name = "repwd_txt"
        Me.repwd_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repwd_txt.Size = New System.Drawing.Size(172, 20)
        Me.repwd_txt.TabIndex = 12
        '
        'npwd_txt
        '
        Me.npwd_txt.Location = New System.Drawing.Point(241, 193)
        Me.npwd_txt.Name = "npwd_txt"
        Me.npwd_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.npwd_txt.Size = New System.Drawing.Size(172, 20)
        Me.npwd_txt.TabIndex = 11
        '
        'pwd_txt
        '
        Me.pwd_txt.Location = New System.Drawing.Point(241, 138)
        Me.pwd_txt.Name = "pwd_txt"
        Me.pwd_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd_txt.Size = New System.Drawing.Size(172, 20)
        Me.pwd_txt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(77, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(77, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(77, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Current Password "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(334, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 48)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'changepwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 398)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.repwd_txt)
        Me.Controls.Add(Me.npwd_txt)
        Me.Controls.Add(Me.pwd_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "changepwd"
        Me.Text = "changepwd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents repwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents npwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents pwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
