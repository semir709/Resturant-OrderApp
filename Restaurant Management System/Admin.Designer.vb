<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelLastName = New System.Windows.Forms.Label()
        Me.LabelNum = New System.Windows.Forms.Label()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.LabelCardId = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxLast_N = New System.Windows.Forms.TextBox()
        Me.TextBoxNum = New System.Windows.Forms.TextBox()
        Me.TextBoxAdress = New System.Windows.Forms.TextBox()
        Me.TextBoxIdCard = New System.Windows.Forms.TextBox()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.TextBoxMail = New System.Windows.Forms.TextBox()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonBegin = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEnd = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonFoodForm = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(22, 28)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(45, 17)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Name"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Location = New System.Drawing.Point(22, 73)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(49, 17)
        Me.LabelLastName.TabIndex = 1
        Me.LabelLastName.Text = "Last N"
        '
        'LabelNum
        '
        Me.LabelNum.AutoSize = True
        Me.LabelNum.Location = New System.Drawing.Point(22, 118)
        Me.LabelNum.Name = "LabelNum"
        Me.LabelNum.Size = New System.Drawing.Size(58, 17)
        Me.LabelNum.TabIndex = 2
        Me.LabelNum.Text = "Number"
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(22, 163)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(60, 17)
        Me.LabelAddress.TabIndex = 3
        Me.LabelAddress.Text = "Address"
        '
        'LabelCardId
        '
        Me.LabelCardId.AutoSize = True
        Me.LabelCardId.Location = New System.Drawing.Point(22, 208)
        Me.LabelCardId.Name = "LabelCardId"
        Me.LabelCardId.Size = New System.Drawing.Size(53, 17)
        Me.LabelCardId.TabIndex = 4
        Me.LabelCardId.Text = "ID card"
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(259, 28)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(72, 17)
        Me.LabelType.TabIndex = 6
        Me.LabelType.Text = "Type user"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(25, 48)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxName.TabIndex = 7
        '
        'TextBoxLast_N
        '
        Me.TextBoxLast_N.Location = New System.Drawing.Point(25, 93)
        Me.TextBoxLast_N.Name = "TextBoxLast_N"
        Me.TextBoxLast_N.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxLast_N.TabIndex = 8
        '
        'TextBoxNum
        '
        Me.TextBoxNum.Location = New System.Drawing.Point(25, 138)
        Me.TextBoxNum.Name = "TextBoxNum"
        Me.TextBoxNum.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxNum.TabIndex = 9
        '
        'TextBoxAdress
        '
        Me.TextBoxAdress.Location = New System.Drawing.Point(25, 183)
        Me.TextBoxAdress.Name = "TextBoxAdress"
        Me.TextBoxAdress.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxAdress.TabIndex = 10
        '
        'TextBoxIdCard
        '
        Me.TextBoxIdCard.Location = New System.Drawing.Point(25, 228)
        Me.TextBoxIdCard.Name = "TextBoxIdCard"
        Me.TextBoxIdCard.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxIdCard.TabIndex = 11
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(262, 94)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxUserName.TabIndex = 15
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(262, 138)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxPass.TabIndex = 17
        '
        'TextBoxMail
        '
        Me.TextBoxMail.Location = New System.Drawing.Point(262, 183)
        Me.TextBoxMail.Name = "TextBoxMail"
        Me.TextBoxMail.Size = New System.Drawing.Size(162, 22)
        Me.TextBoxMail.TabIndex = 18
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Location = New System.Drawing.Point(259, 74)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(79, 17)
        Me.LabelUserName.TabIndex = 19
        Me.LabelUserName.Text = "User Name"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(259, 163)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(47, 17)
        Me.LabelEmail.TabIndex = 20
        Me.LabelEmail.Text = "E-mail"
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Location = New System.Drawing.Point(259, 119)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(69, 17)
        Me.labelPassword.TabIndex = 21
        Me.labelPassword.Text = "Password"
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(525, 39)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(191, 141)
        Me.PictureBoxUser.TabIndex = 22
        Me.PictureBoxUser.TabStop = False
        '
        'ComboBoxType
        '
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Items.AddRange(New Object() {"Admin", "Worker"})
        Me.ComboBoxType.Location = New System.Drawing.Point(262, 48)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(162, 24)
        Me.ComboBoxType.TabIndex = 23
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(66, 276)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(37, 37)
        Me.ButtonBack.TabIndex = 24
        Me.ButtonBack.Text = "<"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonBegin
        '
        Me.ButtonBegin.Location = New System.Drawing.Point(12, 276)
        Me.ButtonBegin.Name = "ButtonBegin"
        Me.ButtonBegin.Size = New System.Drawing.Size(48, 37)
        Me.ButtonBegin.TabIndex = 25
        Me.ButtonBegin.Text = "<<"
        Me.ButtonBegin.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.Location = New System.Drawing.Point(442, 276)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(111, 37)
        Me.ButtonSave.TabIndex = 26
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        Me.ButtonSave.Visible = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(206, 276)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(89, 37)
        Me.ButtonDelete.TabIndex = 27
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonEnd
        '
        Me.ButtonEnd.Location = New System.Drawing.Point(344, 276)
        Me.ButtonEnd.Name = "ButtonEnd"
        Me.ButtonEnd.Size = New System.Drawing.Size(48, 37)
        Me.ButtonEnd.TabIndex = 28
        Me.ButtonEnd.Text = ">>"
        Me.ButtonEnd.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(301, 276)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(37, 37)
        Me.ButtonNext.TabIndex = 29
        Me.ButtonNext.Text = ">"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(109, 276)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(89, 37)
        Me.ButtonAdd.TabIndex = 30
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Enabled = False
        Me.ButtonCancel.Location = New System.Drawing.Point(312, 213)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(64, 37)
        Me.ButtonCancel.TabIndex = 31
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        Me.ButtonCancel.Visible = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(442, 276)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(111, 37)
        Me.ButtonUpdate.TabIndex = 32
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonFoodForm
        '
        Me.ButtonFoodForm.Location = New System.Drawing.Point(693, 276)
        Me.ButtonFoodForm.Name = "ButtonFoodForm"
        Me.ButtonFoodForm.Size = New System.Drawing.Size(95, 37)
        Me.ButtonFoodForm.TabIndex = 33
        Me.ButtonFoodForm.Text = "ADD FOOD"
        Me.ButtonFoodForm.UseVisualStyleBackColor = True
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(525, 188)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(64, 37)
        Me.ButtonBrowse.TabIndex = 34
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 325)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.ButtonFoodForm)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonEnd)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonBegin)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ComboBoxType)
        Me.Controls.Add(Me.PictureBoxUser)
        Me.Controls.Add(Me.labelPassword)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.TextBoxMail)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.TextBoxIdCard)
        Me.Controls.Add(Me.TextBoxAdress)
        Me.Controls.Add(Me.TextBoxNum)
        Me.Controls.Add(Me.TextBoxLast_N)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.LabelCardId)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.LabelNum)
        Me.Controls.Add(Me.LabelLastName)
        Me.Controls.Add(Me.LabelName)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents LabelLastName As Label
    Friend WithEvents LabelNum As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelCardId As Label
    Friend WithEvents LabelType As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxLast_N As TextBox
    Friend WithEvents TextBoxNum As TextBox
    Friend WithEvents TextBoxAdress As TextBox
    Friend WithEvents TextBoxIdCard As TextBox
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBoxMail As TextBox
    Friend WithEvents LabelUserName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents ComboBoxType As ComboBox
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonBegin As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEnd As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonFoodForm As Button
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
