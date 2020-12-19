<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitterCate = New System.Windows.Forms.Splitter()
        Me.LabelAppetizer = New System.Windows.Forms.Label()
        Me.LabelMainFood = New System.Windows.Forms.Label()
        Me.LabelDessert = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelRightInfo = New System.Windows.Forms.Panel()
        Me.ButtonSet = New System.Windows.Forms.Button()
        Me.ComboBoxAmount = New System.Windows.Forms.ComboBox()
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.ButtonLogaout = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabelTC = New System.Windows.Forms.Label()
        Me.LabelP = New System.Windows.Forms.Label()
        Me.LabelN = New System.Windows.Forms.Label()
        Me.LabelPriceVal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonFinish = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelDrinks = New System.Windows.Forms.Label()
        Me.PanelRightInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitterCate
        '
        Me.SplitterCate.BackColor = System.Drawing.Color.LightGray
        Me.SplitterCate.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterCate.Location = New System.Drawing.Point(0, 0)
        Me.SplitterCate.Name = "SplitterCate"
        Me.SplitterCate.Size = New System.Drawing.Size(1349, 45)
        Me.SplitterCate.TabIndex = 0
        Me.SplitterCate.TabStop = False
        '
        'LabelAppetizer
        '
        Me.LabelAppetizer.AutoSize = True
        Me.LabelAppetizer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelAppetizer.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppetizer.Location = New System.Drawing.Point(310, 9)
        Me.LabelAppetizer.Name = "LabelAppetizer"
        Me.LabelAppetizer.Size = New System.Drawing.Size(112, 28)
        Me.LabelAppetizer.TabIndex = 1
        Me.LabelAppetizer.Text = "Appetizer"
        '
        'LabelMainFood
        '
        Me.LabelMainFood.AutoSize = True
        Me.LabelMainFood.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelMainFood.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMainFood.Location = New System.Drawing.Point(12, 9)
        Me.LabelMainFood.Name = "LabelMainFood"
        Me.LabelMainFood.Size = New System.Drawing.Size(125, 28)
        Me.LabelMainFood.TabIndex = 2
        Me.LabelMainFood.Text = "Main Food"
        '
        'LabelDessert
        '
        Me.LabelDessert.AutoSize = True
        Me.LabelDessert.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelDessert.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDessert.Location = New System.Drawing.Point(173, 9)
        Me.LabelDessert.Name = "LabelDessert"
        Me.LabelDessert.Size = New System.Drawing.Size(94, 28)
        Me.LabelDessert.TabIndex = 3
        Me.LabelDessert.Text = "Dessert"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(663, 754)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 20)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Price:"
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(720, 754)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(135, 20)
        Me.TextBox18.TabIndex = 55
        Me.TextBox18.Text = "5KM"
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(667, 731)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(188, 20)
        Me.TextBox19.TabIndex = 54
        Me.TextBox19.Text = "Cijela i deset"
        '
        'PanelMain
        '
        Me.PanelMain.AutoScroll = True
        Me.PanelMain.AutoScrollMinSize = New System.Drawing.Size(0, 600)
        Me.PanelMain.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMain.Location = New System.Drawing.Point(0, 45)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1012, 651)
        Me.PanelMain.TabIndex = 57
        '
        'PanelRightInfo
        '
        Me.PanelRightInfo.BackColor = System.Drawing.Color.LightGray
        Me.PanelRightInfo.Controls.Add(Me.ButtonSet)
        Me.PanelRightInfo.Controls.Add(Me.ComboBoxAmount)
        Me.PanelRightInfo.Controls.Add(Me.LabelAmount)
        Me.PanelRightInfo.Controls.Add(Me.ButtonLogaout)
        Me.PanelRightInfo.Controls.Add(Me.ListBox1)
        Me.PanelRightInfo.Controls.Add(Me.LabelTC)
        Me.PanelRightInfo.Controls.Add(Me.LabelP)
        Me.PanelRightInfo.Controls.Add(Me.LabelN)
        Me.PanelRightInfo.Controls.Add(Me.LabelPriceVal)
        Me.PanelRightInfo.Controls.Add(Me.Label4)
        Me.PanelRightInfo.Controls.Add(Me.ButtonFinish)
        Me.PanelRightInfo.Controls.Add(Me.ButtonClear)
        Me.PanelRightInfo.Controls.Add(Me.LabelTime)
        Me.PanelRightInfo.Location = New System.Drawing.Point(1010, 0)
        Me.PanelRightInfo.Name = "PanelRightInfo"
        Me.PanelRightInfo.Size = New System.Drawing.Size(339, 700)
        Me.PanelRightInfo.TabIndex = 58
        '
        'ButtonSet
        '
        Me.ButtonSet.Location = New System.Drawing.Point(148, 142)
        Me.ButtonSet.Name = "ButtonSet"
        Me.ButtonSet.Size = New System.Drawing.Size(65, 29)
        Me.ButtonSet.TabIndex = 18
        Me.ButtonSet.Text = "Set"
        Me.ButtonSet.UseVisualStyleBackColor = True
        '
        'ComboBoxAmount
        '
        Me.ComboBoxAmount.FormattingEnabled = True
        Me.ComboBoxAmount.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBoxAmount.Location = New System.Drawing.Point(92, 145)
        Me.ComboBoxAmount.Name = "ComboBoxAmount"
        Me.ComboBoxAmount.Size = New System.Drawing.Size(48, 24)
        Me.ComboBoxAmount.TabIndex = 17
        '
        'LabelAmount
        '
        Me.LabelAmount.AutoSize = True
        Me.LabelAmount.Location = New System.Drawing.Point(30, 152)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Size = New System.Drawing.Size(56, 17)
        Me.LabelAmount.TabIndex = 16
        Me.LabelAmount.Text = "Amount"
        '
        'ButtonLogaout
        '
        Me.ButtonLogaout.Location = New System.Drawing.Point(22, 387)
        Me.ButtonLogaout.Name = "ButtonLogaout"
        Me.ButtonLogaout.Size = New System.Drawing.Size(272, 29)
        Me.ButtonLogaout.TabIndex = 15
        Me.ButtonLogaout.Text = "Logout"
        Me.ButtonLogaout.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(33, 189)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(225, 100)
        Me.ListBox1.TabIndex = 14
        '
        'LabelTC
        '
        Me.LabelTC.AutoSize = True
        Me.LabelTC.Location = New System.Drawing.Point(145, 74)
        Me.LabelTC.Name = "LabelTC"
        Me.LabelTC.Size = New System.Drawing.Size(105, 17)
        Me.LabelTC.TabIndex = 13
        Me.LabelTC.Text = "Type/Categoria"
        '
        'LabelP
        '
        Me.LabelP.AutoSize = True
        Me.LabelP.Location = New System.Drawing.Point(86, 74)
        Me.LabelP.Name = "LabelP"
        Me.LabelP.Size = New System.Drawing.Size(40, 17)
        Me.LabelP.TabIndex = 12
        Me.LabelP.Text = "Price"
        '
        'LabelN
        '
        Me.LabelN.AutoSize = True
        Me.LabelN.Location = New System.Drawing.Point(19, 74)
        Me.LabelN.Name = "LabelN"
        Me.LabelN.Size = New System.Drawing.Size(45, 17)
        Me.LabelN.TabIndex = 11
        Me.LabelN.Text = "Name"
        '
        'LabelPriceVal
        '
        Me.LabelPriceVal.AutoSize = True
        Me.LabelPriceVal.Location = New System.Drawing.Point(112, 111)
        Me.LabelPriceVal.Name = "LabelPriceVal"
        Me.LabelPriceVal.Size = New System.Drawing.Size(60, 17)
        Me.LabelPriceVal.TabIndex = 10
        Me.LabelPriceVal.Text = "PriceVal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total price"
        '
        'ButtonFinish
        '
        Me.ButtonFinish.Location = New System.Drawing.Point(161, 318)
        Me.ButtonFinish.Name = "ButtonFinish"
        Me.ButtonFinish.Size = New System.Drawing.Size(133, 29)
        Me.ButtonFinish.TabIndex = 5
        Me.ButtonFinish.Text = "Finish"
        Me.ButtonFinish.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(22, 318)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(133, 29)
        Me.ButtonClear.TabIndex = 4
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(21, 28)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(39, 17)
        Me.LabelTime.TabIndex = 0
        Me.LabelTime.Text = "Time"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LabelDrinks
        '
        Me.LabelDrinks.AutoSize = True
        Me.LabelDrinks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelDrinks.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDrinks.Location = New System.Drawing.Point(459, 9)
        Me.LabelDrinks.Name = "LabelDrinks"
        Me.LabelDrinks.Size = New System.Drawing.Size(80, 28)
        Me.LabelDrinks.TabIndex = 59
        Me.LabelDrinks.Text = "Drinks"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1349, 696)
        Me.Controls.Add(Me.LabelDrinks)
        Me.Controls.Add(Me.PanelRightInfo)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.LabelDessert)
        Me.Controls.Add(Me.LabelMainFood)
        Me.Controls.Add(Me.LabelAppetizer)
        Me.Controls.Add(Me.SplitterCate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.name = "MainForm"
        Me.Text = "MainForm"
        Me.PanelRightInfo.ResumeLayout(False)
        Me.PanelRightInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitterCate As Splitter
    Friend WithEvents LabelAppetizer As Label
    Friend WithEvents LabelMainFood As Label
    Friend WithEvents LabelDessert As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelRightInfo As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LabelTime As Label
    Friend WithEvents ButtonFinish As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelTC As Label
    Friend WithEvents LabelP As Label
    Friend WithEvents LabelN As Label
    Friend WithEvents LabelPriceVal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonLogaout As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelDrinks As Label
    Friend WithEvents LabelAmount As Label
    Friend WithEvents ComboBoxAmount As ComboBox
    Friend WithEvents ButtonSet As Button
End Class
