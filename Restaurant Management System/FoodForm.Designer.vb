<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoodForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainFoodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppatizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonEnd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonBegin = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonCancled = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DrinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainFoodToolStripMenuItem, Me.DesertToolStripMenuItem, Me.AppatizerToolStripMenuItem, Me.DrinksToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(487, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainFoodToolStripMenuItem
        '
        Me.MainFoodToolStripMenuItem.Name = "MainFoodToolStripMenuItem"
        Me.MainFoodToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.MainFoodToolStripMenuItem.Text = "Main Food"
        '
        'DesertToolStripMenuItem
        '
        Me.DesertToolStripMenuItem.Name = "DesertToolStripMenuItem"
        Me.DesertToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.DesertToolStripMenuItem.Text = "Desert"
        '
        'AppatizerToolStripMenuItem
        '
        Me.AppatizerToolStripMenuItem.Name = "AppatizerToolStripMenuItem"
        Me.AppatizerToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.AppatizerToolStripMenuItem.Text = "Appatizer"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(12, 43)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(45, 17)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = "Name"
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Location = New System.Drawing.Point(12, 90)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(40, 17)
        Me.LabelPrice.TabIndex = 2
        Me.LabelPrice.Text = "Price"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(15, 65)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxName.TabIndex = 8
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(15, 110)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxPrice.TabIndex = 9
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.Location = New System.Drawing.Point(273, 43)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(191, 141)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUser.TabIndex = 23
        Me.PictureBoxUser.TabStop = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(364, 246)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(111, 37)
        Me.ButtonUpdate.TabIndex = 40
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(21, 246)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(87, 37)
        Me.ButtonAdd.TabIndex = 50
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(112, 147)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(37, 37)
        Me.ButtonNext.TabIndex = 38
        Me.ButtonNext.Text = ">"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonEnd
        '
        Me.ButtonEnd.Location = New System.Drawing.Point(155, 147)
        Me.ButtonEnd.Name = "ButtonEnd"
        Me.ButtonEnd.Size = New System.Drawing.Size(48, 37)
        Me.ButtonEnd.TabIndex = 37
        Me.ButtonEnd.Text = ">>"
        Me.ButtonEnd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(114, 246)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(89, 37)
        Me.ButtonDelete.TabIndex = 36
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Enabled = False
        Me.ButtonSave.Location = New System.Drawing.Point(364, 246)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(111, 37)
        Me.ButtonSave.TabIndex = 35
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        Me.ButtonSave.Visible = False
        '
        'ButtonBegin
        '
        Me.ButtonBegin.Location = New System.Drawing.Point(15, 147)
        Me.ButtonBegin.Name = "ButtonBegin"
        Me.ButtonBegin.Size = New System.Drawing.Size(48, 37)
        Me.ButtonBegin.TabIndex = 34
        Me.ButtonBegin.Text = "<<"
        Me.ButtonBegin.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(69, 147)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(37, 37)
        Me.ButtonBack.TabIndex = 33
        Me.ButtonBack.Text = "<"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonCancled
        '
        Me.ButtonCancled.Enabled = False
        Me.ButtonCancled.Location = New System.Drawing.Point(69, 190)
        Me.ButtonCancled.Name = "ButtonCancled"
        Me.ButtonCancled.Size = New System.Drawing.Size(80, 37)
        Me.ButtonCancled.TabIndex = 41
        Me.ButtonCancled.Text = "Cancled"
        Me.ButtonCancled.UseVisualStyleBackColor = True
        Me.ButtonCancled.Visible = False
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Enabled = False
        Me.ButtonBrowse.Location = New System.Drawing.Point(273, 190)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(65, 37)
        Me.ButtonBrowse.TabIndex = 51
        Me.ButtonBrowse.Text = "Browse "
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DrinksToolStripMenuItem
        '
        Me.DrinksToolStripMenuItem.Name = "DrinksToolStripMenuItem"
        Me.DrinksToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.DrinksToolStripMenuItem.Text = "Drinks"
        '
        'FoodForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 295)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.ButtonCancled)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonEnd)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonBegin)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.PictureBoxUser)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FoodForm"
        Me.Text = "FoodForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainFoodToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppatizerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents PictureBoxUser As PictureBox
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents ButtonEnd As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonBegin As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonCancled As Button
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DrinksToolStripMenuItem As ToolStripMenuItem
End Class
