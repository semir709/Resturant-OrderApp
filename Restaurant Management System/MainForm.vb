Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class MainForm
    Dim pic As New PictureBox
    Dim labelName As Label
    Dim labelPrice As Label

    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Restaurant Management System\DataBase\ResturantDb.mdb")

    Dim mainFoodA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'main food'", con)
    Dim desertA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'desert'", con)
    Dim appetA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'appetizer'", con)
    Dim drinksA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'drinks'", con)
    Dim orderA As New OleDbDataAdapter("SELECT * FROM [orderr]", con)
    Dim orderDA As New OleDbDataAdapter("SELECT * FROM [orderDetails]", con)
    Dim allFood As New OleDbDataAdapter("SELECT * FROM [food]", con)

    Dim dataMainFood As DataSet = New DataSet()
    Dim dataDesert As DataSet = New DataSet()
    Dim dataAppet As DataSet = New DataSet()
    Dim dataDrinks As DataSet = New DataSet()
    Dim dataOrder As DataSet = New DataSet()
    Dim dataOrderD As DataSet = New DataSet()
    Dim dataAllFood As DataSet = New DataSet()



    Dim counterChecking As Integer = 0
    Dim distanceLeft As Integer = 10
    Dim counter As Integer = 0
    Dim distanceTop As Integer = 10
    Dim distancTopName As Integer = 130
    Dim distanceLeftName As Integer = 10

    Dim c As Integer

    Dim imageName As String
    Dim locatio As String = "C:\Restaurant Management System\img"

    Dim totalPrice As Integer = 0
    Dim mainFoodID As Integer
    Dim desertID As Integer
    Dim appatizerID As Integer
    Dim drinksID As Integer

    Dim amountMainFood As Integer = 0
    Dim amountDeserts As Integer = 0
    Dim amountAppatizer As Integer = 0
    Dim amountDrinks As Integer = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'ComboBoxAmount.SelectedIndex = 0
        mainFoodA.Fill(dataMainFood, "food")
        desertA.Fill(dataDesert, "food")
        appetA.Fill(dataAppet, "food")
        drinksA.Fill(dataDrinks, "food")
        orderA.Fill(dataOrder, "orderr")
        orderDA.Fill(dataOrderD, "orderDetails")
        allFood.Fill(dataAllFood, "food")

        Timer1.Start()
        LabelTime.Text = DateTime.Now


    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
        con.Close()

    End Sub

    Sub img(ByVal i As PictureBox, Optional ByVal s As String = "M")
        If s = "M" Then
            imageName = dataMainFood.Tables("food").Rows(c)("img")
            i.Width = 170 '141
            i.Height = 120 '111
            i.Name = dataMainFood.Tables("food").Rows(c)("name")
            i.Tag = dataMainFood.Tables("food").Rows(c)("price")
            i.Top = distanceTop
            i.Left = distanceLeft
            i.ImageLocation = System.IO.Path.Combine(locatio, imageName)
            i.SizeMode = PictureBoxSizeMode.StretchImage
            i.BackColor = Color.Red
            Me.PanelMain.Controls.Add(i)

        ElseIf s = "D" Then
            imageName = dataDesert.Tables("food").Rows(c)("img")
            i.Width = 170 '141
            i.Height = 120 '111
            i.Name = dataDesert.Tables("food").Rows(c)("name")
            i.Tag = dataDesert.Tables("food").Rows(c)("price")
            i.Top = distanceTop
            i.Left = distanceLeft
            i.ImageLocation = System.IO.Path.Combine(locatio, imageName)
            i.SizeMode = PictureBoxSizeMode.StretchImage
            i.BackColor = Color.Red
            Me.PanelMain.Controls.Add(i)
        ElseIf s = "A" Then
            imageName = dataAppet.Tables("food").Rows(c)("img")
            i.Width = 170 '141
            i.Height = 120 '111
            i.Name = dataAppet.Tables("food").Rows(c)("name")
            i.Tag = dataAppet.Tables("food").Rows(c)("price")
            i.Top = distanceTop
            i.Left = distanceLeft
            i.ImageLocation = System.IO.Path.Combine(locatio, imageName)
            i.SizeMode = PictureBoxSizeMode.StretchImage
            i.BackColor = Color.Red
            Me.PanelMain.Controls.Add(i)
        ElseIf s = "Dr" Then
            imageName = dataDrinks.Tables("food").Rows(c)("img")
            i.Width = 170 '141
            i.Height = 120 '111
            i.Name = dataDrinks.Tables("food").Rows(c)("name")
            i.Tag = dataDrinks.Tables("food").Rows(c)("price")
            i.Top = distanceTop
            i.Left = distanceLeft
            i.ImageLocation = System.IO.Path.Combine(locatio, imageName)
            i.SizeMode = PictureBoxSizeMode.StretchImage
            i.BackColor = Color.Red
            Me.PanelMain.Controls.Add(i)
        End If

    End Sub

    Sub label(ByVal l As Label, Optional ByVal s As String = "M")
        If s = "M" Then
            l.Top = distancTopName
            l.Left = distanceLeftName
            l.Text = dataMainFood.Tables("food").Rows(c)("name")
            l.AutoSize = True
            l.Font = New Font("Arial", 12)
            Me.PanelMain.Controls.Add(l)
        ElseIf s = "D" Then
            l.Top = distancTopName
            l.Left = distanceLeftName
            l.Text = dataDesert.Tables("food").Rows(c)("name")
            l.AutoSize = True
            l.Font = New Font("Arial", 12)
            Me.PanelMain.Controls.Add(l)
        ElseIf s = "A" Then
            l.Top = distancTopName
            l.Left = distanceLeftName
            l.Text = dataAppet.Tables("food").Rows(c)("name")
            l.AutoSize = True
            l.Font = New Font("Arial", 12)
            Me.PanelMain.Controls.Add(l)
        ElseIf s = "Dr" Then
            l.Top = distancTopName
            l.Left = distanceLeftName
            l.Text = dataDrinks.Tables("food").Rows(c)("name")
            l.AutoSize = True
            l.Font = New Font("Arial", 12)
            Me.PanelMain.Controls.Add(l)
        End If

    End Sub

    Sub RemoveAllLabels()
        Dim Labels As New List(Of Label)
        Dim Stack As New Stack(Of Control)
        Stack.Push(Me)
        While Stack.Count > 0
            Dim Ctrl As Control = Stack.Pop()
            Labels.Add(TryCast(Ctrl, Label))
            For Each C As Control In Ctrl.Controls
                Stack.Push(C)
            Next
        End While
        For Each L As Label In Labels
            If Not IsNothing(L) Then Me.PanelMain.Controls.Remove(L)
        Next
    End Sub

    Sub removeAllImg()
        For Each ctrl In Me.PanelMain.Controls
            If TypeOf ctrl Is PictureBox Then
                If ctrl IsNot Nothing Then
                    Me.PanelMain.Controls.Remove(ctrl)
                    'ctrl.Dispose()
                End If
            End If
        Next
    End Sub

    Sub resetPositions()

        distanceLeft = 10
        distanceLeftName = 10
        distanceTop = 10
        distancTopName = 130
    End Sub
    Sub totalAmount()
        totalPrice = 0
        For i = 0 To ListBox1.Items.Count - 1
            totalPrice += ListBox1.Items(i).ToString.Split("- ")(1) * ListBox1.Items(i).ToString.Split(" ").Last
        Next

        LabelPriceVal.Text = totalPrice
    End Sub
    Private Sub take_img(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As PictureBox = DirectCast(sender, PictureBox)

        c = 0

        LabelN.Text = i.Name
        LabelP.Text = i.Tag

        Dim p

        For n = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items.Item(n).ToString.Split(" ").First = i.Name Then
                MsgBox(i.Name & " is already record!!!")
                GoTo p
            End If

        Next

        ListBox1.Items.Add(i.Name & " - " & i.Tag & " - " & LabelTC.Text & " - " & ComboBoxAmount.Items.Item(0))
p:

        index = ListBox1.Items.Count - 1
        ListBox1.SelectedIndex = index

        ComboBoxAmount.SelectedIndex = 0

        totalAmount()

    End Sub
    Dim index As Integer
    Dim name As String = ""
    Dim finalName As String
    Dim finalPrice As String
    Dim finalTC As String
    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click

        index = ListBox1.GetItemText(ListBox1.SelectedIndex)
        ListBox1.SelectedIndex = index

        name = ListBox1.SelectedItem
        finalName = name.Split("- ")(0)
        finalPrice = name.Split("- ")(1)
        finalTC = name.Split("- ")(2)

        LabelN.Text = String.Join(" ", finalName.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)) 'Clear white space
        LabelP.Text = String.Join(" ", finalPrice.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))
        LabelTC.Text = String.Join(" ", finalTC.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))

        ComboBoxAmount.SelectedItem = name.Split(" ").Last
    End Sub
    Private Sub ComboBoxAmount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAmount.SelectedIndexChanged

        If ListBox1.SelectedIndex > -1 Then

            ListBox1.Items(ListBox1.SelectedIndex) = LabelN.Text & " - " & LabelP.Text & " - " & LabelTC.Text & " - " & ComboBoxAmount.SelectedItem

            totalAmount()

        End If

    End Sub

    Private Sub ButtonSet_Click(sender As Object, e As EventArgs) Handles ButtonSet.Click
        ComboBoxAmount.Items.Add(ComboBoxAmount.Text)
        ComboBoxAmount.SelectedIndex = ComboBoxAmount.Items.Count - 1
        If ListBox1.SelectedIndex > -1 Then

            ListBox1.Items(ListBox1.SelectedIndex) = LabelN.Text & " - " & LabelP.Text & " - " & LabelTC.Text & " - " & ComboBoxAmount.SelectedItem

        End If

    End Sub

    Sub clearIDs()
        mainFoodID = 0
        desertID = 0
        appatizerID = 0
        drinksID = 0
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        LabelN.Text = "_________"
        LabelP.Text = "_________"
        ListBox1.Items.Clear()
        LabelPriceVal.Text = "_________"
        ComboBoxAmount.SelectedIndex = 0
        clearIDs()
    End Sub

    Private Sub ButtonFinish_Click(sender As Object, e As EventArgs) Handles ButtonFinish.Click

        If (ListBox1.Items.Count - 1) < 0 Then
            MsgBox("There is no orders!!")
            Exit Sub
        End If

        Dim d As Integer = ListBox1.Items.Count - 1
        Dim myArray(d) As String
        Dim myFinalArr(d) As String
        Dim amonutArr(d) As String

        ListBox1.Items.CopyTo(myArray, 0)

        For i = 0 To myArray.Length - 1
            myFinalArr(i) = myArray(i).Substring(0, myArray(i).IndexOf(" "))
            amonutArr(i) = myArray(i).Split(" ").Last
        Next

        Dim comandBuilderOrder As New OleDb.OleDbCommandBuilder(orderA)
        Dim dataRowD As DataRow = dataOrder.Tables("orderr").NewRow()

        dataRowD.Item("date_time") = LabelTime.Text
        dataRowD.Item("worker_id") = LoginForm.idWorker

        dataOrder.Tables("orderr").Rows.Add(dataRowD)

        orderA.Update(dataOrder, "orderr")
        dataOrder.AcceptChanges()

        orderA.Fill(dataOrder, "orderr")



        For i = 0 To myFinalArr.Length - 1
            For j = 0 To dataAllFood.Tables("food").Rows.Count - 1

                Dim comandBuilderOrderD As New OleDb.OleDbCommandBuilder(orderDA)
                Dim dataRowDA As DataRow = dataOrderD.Tables("orderDetails").NewRow()


                If myFinalArr(i) = dataAllFood.Tables("food").Rows(j)("name") Then
                    dataRowDA.Item("ID_Food") = dataAllFood.Tables("food").Rows(j)("ID_Food")
                    dataRowDA.Item("amount") = amonutArr(i)
                    dataRowDA.Item("ID_Order") = dataOrder.Tables("orderr").Rows(dataOrder.Tables("orderr").Rows.Count - 1)("ID_order")
                    dataRowDA.Item("totalPrice") = LabelPriceVal.Text

                    dataOrderD.Tables("orderDetails").Rows.Add(dataRowDA)

                    orderDA.Update(dataOrderD, "orderDetails")
                    dataOrderD.AcceptChanges()

                    orderDA.Fill(dataOrderD, "orderDetails")
                End If
            Next
        Next

        MsgBox("Successful!!!")

        LabelN.Text = "_________"
        LabelP.Text = "_________"
        ListBox1.Items.Clear()
        LabelPriceVal.Text = "_________"
        ComboBoxAmount.SelectedIndex = 0
        clearIDs()
    End Sub

    Private Sub ButtonLogaout_Click(sender As Object, e As EventArgs) Handles ButtonLogaout.Click
        con.Close()
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub LabelMainFood_Click(sender As Object, e As EventArgs) Handles LabelMainFood.Click
        clearIDs()
        c = 0

        LabelTC.Text = LabelMainFood.Text

        removeAllImg()
        RemoveAllLabels()
        resetPositions()

        While counterChecking <= dataMainFood.Tables("food").Rows.Count - 1
            pic = New PictureBox
            labelName = New Label

            img(pic)
            label(labelName)

            If ((pic.Left + pic.Width) >= PanelMain.Width) Then

                distanceLeft = 10
                distanceLeftName = 10
                distanceTop += 155
                distancTopName += 155

                img(pic)
                label(labelName)


            End If

            distanceLeft += 180 '155
            distanceLeftName += 180 '155

            counter += 1
            counterChecking += 1

            c += 1

            AddHandler pic.Click, AddressOf take_img
        End While
        counterChecking = 0

        LabelMainFood.Enabled = False
        LabelDessert.Enabled = True
        LabelAppetizer.Enabled = True
        LabelDrinks.Enabled = True

    End Sub
    Private Sub LabelDessert_Click(sender As Object, e As EventArgs) Handles LabelDessert.Click
        clearIDs()
        removeAllImg()
        RemoveAllLabels()
        resetPositions()

        LabelTC.Text = LabelDessert.Text

        c = 0

        While counterChecking <= dataDesert.Tables("food").Rows.Count - 1
            pic = New PictureBox
            labelName = New Label

            img(pic, "D")
            label(labelName, "D")

            If ((pic.Left + pic.Width) >= PanelMain.Width) Then

                distanceLeft = 10
                distanceLeftName = 10
                distanceTop += 155
                distancTopName += 155

                img(pic, "D")
                label(labelName, "D")


            End If

            distanceLeft += 180 '155
            distanceLeftName += 180 '155

            counter += 1
            counterChecking += 1

            c += 1

            AddHandler pic.Click, AddressOf take_img
        End While
        counterChecking = 0

        LabelMainFood.Enabled = True
        LabelDessert.Enabled = False
        LabelAppetizer.Enabled = True
        LabelDrinks.Enabled = True
    End Sub

    Private Sub LabelAppetizer_Click(sender As Object, e As EventArgs) Handles LabelAppetizer.Click
        clearIDs()
        c = 0
        removeAllImg()
        RemoveAllLabels()
        resetPositions()

        LabelTC.Text = LabelAppetizer.Text

        While counterChecking <= dataAppet.Tables("food").Rows.Count - 1
            pic = New PictureBox
            labelName = New Label

            img(pic, "A")
            label(labelName, "A")

            If ((pic.Left + pic.Width) >= PanelMain.Width) Then

                distanceLeft = 10
                distanceLeftName = 10
                distanceTop += 155
                distancTopName += 155

                img(pic, "A")
                label(labelName, "A")


            End If

            distanceLeft += 180 '155
            distanceLeftName += 180 '155

            counter += 1
            counterChecking += 1

            c += 1

            AddHandler pic.Click, AddressOf take_img
        End While
        counterChecking = 0

        LabelMainFood.Enabled = True
        LabelDessert.Enabled = True
        LabelAppetizer.Enabled = False
        LabelDrinks.Enabled = True

    End Sub

    Private Sub LabelDrinks_Click(sender As Object, e As EventArgs) Handles LabelDrinks.Click
        clearIDs()
        c = 0
        removeAllImg()
        RemoveAllLabels()
        resetPositions()

        LabelTC.Text = LabelDrinks.Text

        While counterChecking <= dataDrinks.Tables("food").Rows.Count - 1
            pic = New PictureBox
            labelName = New Label

            img(pic, "Dr")
            label(labelName, "Dr")

            If ((pic.Left + pic.Width) >= PanelMain.Width) Then

                distanceLeft = 10
                distanceLeftName = 10
                distanceTop += 155
                distancTopName += 155

                img(pic, "Dr")
                label(labelName, "Dr")


            End If

            distanceLeft += 180 '155
            distanceLeftName += 180 '155

            counter += 1
            counterChecking += 1

            c += 1

            AddHandler pic.Click, AddressOf take_img
        End While
        counterChecking = 0

        LabelMainFood.Enabled = True
        LabelDessert.Enabled = True
        LabelAppetizer.Enabled = True
        LabelDrinks.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTime.Text = DateTime.Now

    End Sub

End Class