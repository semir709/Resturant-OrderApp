<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.LabelPassw = New System.Windows.Forms.Label()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxPassw = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Location = New System.Drawing.Point(108, 132)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(77, 17)
        Me.LabelUserName.TabIndex = 0
        Me.LabelUserName.Text = "User name"
        '
        'LabelPassw
        '
        Me.LabelPassw.AutoSize = True
        Me.LabelPassw.Location = New System.Drawing.Point(108, 199)
        Me.LabelPassw.Name = "LabelPassw"
        Me.LabelPassw.Size = New System.Drawing.Size(69, 17)
        Me.LabelPassw.TabIndex = 1
        Me.LabelPassw.Text = "Password"
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(111, 268)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(102, 35)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "Log in"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(240, 268)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(102, 35)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(111, 152)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(231, 22)
        Me.TextBoxUserName.TabIndex = 4
        '
        'TextBoxPassw
        '
        Me.TextBoxPassw.Location = New System.Drawing.Point(111, 219)
        Me.TextBoxPassw.Name = "TextBoxPassw"
        Me.TextBoxPassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassw.Size = New System.Drawing.Size(231, 22)
        Me.TextBoxPassw.TabIndex = 5
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(126, 33)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(189, 38)
        Me.LabelTitle.TabIndex = 6
        Me.LabelTitle.Text = "Fast Food II"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 387)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.TextBoxPassw)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.LabelPassw)
        Me.Controls.Add(Me.LabelUserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUserName As Label
    Friend WithEvents LabelPassw As Label
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents TextBoxPassw As TextBox
    Friend WithEvents LabelTitle As Label
End Class
