Imports System.Data.OleDb
Imports System.IO
Public Class FoodForm

    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Restaurant Management System\DataBase\ResturantDb.mdb")

    Dim mainFoodA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'main food'", con)
    Dim desertFoodA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'desert'", con)
    Dim appatizerFoodA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'appetizer'", con)
    Dim drinksFoodA As New OleDbDataAdapter("SELECT * FROM [food] WHERE [category] = 'drinks'", con)

    Dim dataMainFood As DataSet = New DataSet()
    Dim dataDesert As DataSet = New DataSet()
    Dim dataAppet As DataSet = New DataSet()
    Dim dataDrniks As DataSet = New DataSet


    'Dim gridMainFood As DataGridView

    Dim c As Integer
    Dim flagM, flagD, flagA, flagDr As Boolean

    Dim maxM, maxD, maxA, maxDr As Integer

    Dim imageName As String
    Dim locatio As String = "C:\Restaurant Management System\img"
    Public Sub loadData(Optional ByVal p As Integer = 0)

        maxM = dataMainFood.Tables("food").Rows.Count
        maxD = dataDesert.Tables("food").Rows.Count
        maxA = dataAppet.Tables("food").Rows.Count
        maxDr = dataDrniks.Tables("food").Rows.Count


        Select Case p
            Case 0
                imageName = dataMainFood.Tables("food").Rows(c)("img")

                TextBoxName.Text = dataMainFood.Tables("food").Rows(c)("name")
                TextBoxPrice.Text = dataMainFood.Tables("food").Rows(c)("price")
                PictureBoxUser.ImageLocation = Path.Combine(locatio, imageName)

            Case 1
                imageName = dataDesert.Tables("food").Rows(c)("img")

                TextBoxName.Text = dataDesert.Tables("food").Rows(c)("name")
                TextBoxPrice.Text = dataDesert.Tables("food").Rows(c)("price")
                PictureBoxUser.ImageLocation = Path.Combine(locatio, imageName)
            Case 2
                imageName = dataAppet.Tables("food").Rows(c)("img")

                TextBoxName.Text = dataAppet.Tables("food").Rows(c)("name")
                TextBoxPrice.Text = dataAppet.Tables("food").Rows(c)("price")
                PictureBoxUser.ImageLocation = Path.Combine(locatio, imageName)

            Case 3
                imageName = dataDrniks.Tables("food").Rows(c)("img")

                TextBoxName.Text = dataDrniks.Tables("food").Rows(c)("name")
                TextBoxPrice.Text = dataDrniks.Tables("food").Rows(c)("price")
                PictureBoxUser.ImageLocation = Path.Combine(locatio, imageName)
            Case Else
                MsgBox("Not recognize value")
        End Select
    End Sub

    Public Sub alowBtns(Optional ByVal b As Boolean = False)
        If b = False Then
            ButtonBegin.Enabled = False
            ButtonEnd.Enabled = False
            ButtonAdd.Enabled = False
            ButtonBack.Enabled = False
            ButtonNext.Enabled = False
            ButtonUpdate.Enabled = False
            ButtonUpdate.Visible = False
            ButtonDelete.Enabled = False


        Else
            ButtonBegin.Enabled = True
            ButtonEnd.Enabled = True
            ButtonAdd.Enabled = True
            ButtonBack.Enabled = True
            ButtonNext.Enabled = True
            ButtonUpdate.Enabled = True
            ButtonUpdate.Visible = True
            ButtonDelete.Enabled = True

        End If
    End Sub

    Private Sub FoodForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Admin.Show()

    End Sub

    Private Sub FoodForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()

            mainFoodA.Fill(dataMainFood, "food")
            desertFoodA.Fill(dataDesert, "food")
            appatizerFoodA.Fill(dataAppet, "food")
            drinksFoodA.Fill(dataDrniks, "food")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        alowBtns(False)
    End Sub

    Private Sub MainFoodToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainFoodToolStripMenuItem.Click
        c = 0
        loadData()
        flagM = True
        flagD = False
        flagA = False
        flagDr = False
        alowBtns(True)
        ButtonBrowse.Enabled = True
    End Sub

    Private Sub DesertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesertToolStripMenuItem.Click
        c = 0
        loadData(1)
        flagM = False
        flagD = True
        flagA = False
        flagDr = False
        alowBtns(True)
        ButtonBrowse.Enabled = True
    End Sub

    Private Sub AppatizerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppatizerToolStripMenuItem.Click
        c = 0
        loadData(2)
        flagM = False
        flagD = False
        flagA = True
        flagDr = False
        alowBtns(True)
        ButtonBrowse.Enabled = True
    End Sub

    Private Sub DrinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrinksToolStripMenuItem.Click
        c = 0
        loadData(3)
        flagM = False
        flagD = False
        flagA = False
        flagDr = True
        alowBtns(True)
        ButtonBrowse.Enabled = True
    End Sub
    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If flagM Then
            If c <> maxM - 1 Then
                c = c + 1
            Else
                c = 0

            End If
            loadData()
        ElseIf flagD Then
            If c <> maxD - 1 Then
                c = c + 1
            Else
                c = 0

            End If
            loadData(1)
        ElseIf flagA Then
            If c <> maxA - 1 Then
                c = c + 1
            Else
                c = 0

            End If
            loadData(2)

        ElseIf flagDr Then
            If c <> maxDr - 1 Then
                c = c + 1
            Else
                c = 0

            End If
            loadData(3)
        Else
            MsgBox("Smoething is wrong")
        End If

    End Sub
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        If flagM Then
            If c > 0 Then
                c = c - 1
            Else
                c = maxM - 1

            End If
            loadData()
        ElseIf flagD Then
            If c > 0 Then
                c = c - 1
            Else
                c = maxD - 1

            End If
            loadData(1)
        ElseIf flagA Then
            If c > 0 Then
                c = c - 1
            Else
                c = maxA - 1

            End If
            loadData(2)
        ElseIf flagDr Then
            If c > 0 Then
                c = c - 1
            Else
                c = maxDr - 1

            End If
            loadData(3)
        Else
            MsgBox("Smoething is wrong")
        End If
    End Sub

    Private Sub ButtonCancled_Click_1(sender As Object, e As EventArgs) Handles ButtonCancled.Click
        alowBtns(True)
        ButtonCancled.Enabled = False
        ButtonCancled.Visible = False
        ButtonSave.Enabled = False
        ButtonSave.Visible = False

    End Sub

    Private Sub ButtonEnd_Click(sender As Object, e As EventArgs) Handles ButtonEnd.Click
        If flagM Then
            If c <> maxM - 1 Then
                c = maxM - 1
            End If
            loadData()
        ElseIf flagD Then
            If c <> maxD - 1 Then
                c = maxD - 1
            End If
            loadData(1)
        ElseIf flagA Then
            If c <> maxA - 1 Then
                c = maxA - 1
            End If
            loadData(2)

        ElseIf flagDr Then
            If c <> maxDr - 1 Then
                c = maxDr - 1
            End If
            loadData(3)
        Else
            MsgBox("Smoething is wrong")
        End If
    End Sub

    Private Sub ButtonBegin_Click(sender As Object, e As EventArgs) Handles ButtonBegin.Click
        If flagM Then
            If c <> 0 Then
                c = 0
            End If
            loadData()
        ElseIf flagD Then
            If c <> 0 Then
                c = 0
            End If
            loadData(1)
        ElseIf flagA Then
            If c <> 0 Then
                c = 0
            End If
            loadData(2)
        ElseIf flagDr Then
            If c <> 0 Then
                c = 0
            End If
            loadData(3)
        Else
            MsgBox("Smoething is wrong")
        End If
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JEPGs|*.jpg"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBoxUser.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        TextBoxName.Clear()
        TextBoxPrice.Clear()
        ButtonCancled.Enabled = True
        ButtonCancled.Visible = True
        ButtonSave.Enabled = True
        ButtonSave.Visible = True
        ButtonBrowse.Enabled = True

        alowBtns(False)
    End Sub

    Sub folderImage()

        Dim saveDirectory As String = "C:\Restaurant Management System\img\"


        If Not Directory.Exists(saveDirectory) Then
            Directory.CreateDirectory(saveDirectory)
        End If

        Dim fileName As String = Path.GetFileName(OpenFileDialog1.FileName)
        Dim fileSavePath As String = Path.Combine(saveDirectory, fileName)
        File.Copy(OpenFileDialog1.FileName, fileSavePath, True)


    End Sub
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If flagM Then
            Dim comandBuilderM As New OleDb.OleDbCommandBuilder(mainFoodA)
            Dim dataRowM As DataRow = dataMainFood.Tables("food").NewRow()

            dataRowM.Item("name") = TextBoxName.Text
            dataRowM.Item("price") = TextBoxPrice.Text
            dataRowM.Item("img") = Path.GetFileName(OpenFileDialog1.FileName)
            dataRowM.Item("category") = "main food"

            folderImage()

            dataMainFood.Tables("food").Rows.Add(dataRowM)

            mainFoodA.Update(dataMainFood, "food")
            dataMainFood.AcceptChanges()

            mainFoodA.Fill(dataMainFood, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If

            loadData()

            MsgBox("Data is saved !!!")
            alowBtns(True)
            ButtonSave.Enabled = False
            ButtonSave.Visible = False


        ElseIf flagD Then
            Dim comandBuilderD As New OleDb.OleDbCommandBuilder(desertFoodA)
            Dim dataRowD As DataRow = dataDesert.Tables("food").NewRow()

            dataRowD.Item("name") = TextBoxName.Text
            dataRowD.Item("price") = TextBoxPrice.Text
            dataRowD.Item("img") = Path.GetFileName(OpenFileDialog1.FileName)
            dataRowD.Item("category") = "desert"

            folderImage()

            dataDesert.Tables("food").Rows.Add(dataRowD)

            desertFoodA.Update(dataDesert, "food")
            dataDesert.AcceptChanges()

            desertFoodA.Fill(dataDesert, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If

            loadData(1)

            MsgBox("Data is saved !!!")
            alowBtns(True)
            ButtonSave.Enabled = False
            ButtonSave.Visible = False
        ElseIf flagA Then
            Dim comandBuilderA As New OleDb.OleDbCommandBuilder(appatizerFoodA)
            Dim dataRowA As DataRow = dataAppet.Tables("food").NewRow()

            dataRowA.Item("name") = TextBoxName.Text
            dataRowA.Item("price") = TextBoxPrice.Text
            dataRowA.Item("img") = Path.GetFileName(OpenFileDialog1.FileName)
            dataRowA.Item("category") = "appetizer"

            folderImage()

            dataAppet.Tables("food").Rows.Add(dataRowA)

            appatizerFoodA.Update(dataAppet, "food")
            dataAppet.AcceptChanges()

            appatizerFoodA.Fill(dataAppet, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If

            loadData(2)

            MsgBox("Data is saved !!!")
            alowBtns(True)
            ButtonSave.Enabled = False
            ButtonSave.Visible = False

        ElseIf flagDr Then
            Dim comandBuilderDr As New OleDb.OleDbCommandBuilder(drinksFoodA)
            Dim dataRowDr As DataRow = dataDrniks.Tables("food").NewRow()

            dataRowDr.Item("name") = TextBoxName.Text
            dataRowDr.Item("price") = TextBoxPrice.Text
            dataRowDr.Item("img") = Path.GetFileName(OpenFileDialog1.FileName)
            dataRowDr.Item("category") = "drinks"

            folderImage()

            dataDrniks.Tables("food").Rows.Add(dataRowDr)

            drinksFoodA.Update(dataDrniks, "food")
            dataDrniks.AcceptChanges()

            drinksFoodA.Fill(dataDrniks, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If

            loadData(3)

            MsgBox("Data is saved !!!")
            alowBtns(True)
            ButtonSave.Enabled = False
            ButtonSave.Visible = False
            ButtonCancled.Enabled = False
            ButtonCancled.Visible = False

        End If
    End Sub
    'fix folderImage() 
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If flagM Then
            OpenFileDialog1.FileName = PictureBoxUser.ImageLocation
            Dim comandBuilderM As New OleDb.OleDbCommandBuilder(mainFoodA)

            dataMainFood.Tables("food").Rows(c).Item("name") = TextBoxName.Text
            dataMainFood.Tables("food").Rows(c).Item("price") = TextBoxPrice.Text
            dataMainFood.Tables("food").Rows(c).Item("img") = Path.GetFileName(OpenFileDialog1.FileName)

            ' folderImage()

            mainFoodA.Update(dataMainFood, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If


            loadData()
            MsgBox("Data updated")

        ElseIf flagD Then

            Dim comandBuilderD As New OleDb.OleDbCommandBuilder(desertFoodA)

            dataDesert.Tables("food").Rows(c).Item("name") = TextBoxName.Text
            dataDesert.Tables("food").Rows(c).Item("price") = TextBoxPrice.Text
            dataDesert.Tables("food").Rows(c).Item("img") = Path.GetFileName(OpenFileDialog1.FileName)

            desertFoodA.Update(dataDesert, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If


            loadData(1)
            MsgBox("Data updated")

        ElseIf flagA Then
            Dim comandBuilderA As New OleDb.OleDbCommandBuilder(appatizerFoodA)

            dataAppet.Tables("food").Rows(c).Item("name") = TextBoxName.Text
            dataAppet.Tables("food").Rows(c).Item("price") = TextBoxPrice.Text
            dataAppet.Tables("food").Rows(c).Item("img") = Path.GetFileName(OpenFileDialog1.FileName)

            appatizerFoodA.Update(dataAppet, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If

            loadData(2)

            MsgBox("Data updated")

        ElseIf flagDr Then
            Dim comandBuilderDr As New OleDb.OleDbCommandBuilder(drinksFoodA)

            dataDrniks.Tables("food").Rows(c).Item("name") = TextBoxName.Text
            dataDrniks.Tables("food").Rows(c).Item("price") = TextBoxPrice.Text
            dataDrniks.Tables("food").Rows(c).Item("img") = Path.GetFileName(OpenFileDialog1.FileName)

            drinksFoodA.Update(dataDrniks, "food")

            If c = 0 Then
                c = 1
            ElseIf c = 1 Then
                c = 0
            Else
                c = 0
            End If

            loadData(3)

            MsgBox("Data updated")
        End If
    End Sub


    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Try
            If flagM Then
                Dim comandBuilderM As New OleDb.OleDbCommandBuilder(mainFoodA)

                dataMainFood.Tables("food").Rows(c).Delete()
                maxM = maxM - 1

                c = 0

                mainFoodA.Update(dataMainFood, "food")
                loadData()
            End If

            If flagD Then
                Dim comandBuilderD As New OleDb.OleDbCommandBuilder(desertFoodA)

                dataDesert.Tables("food").Rows(c).Delete()
                maxD = maxD - 1

                c = 0

                desertFoodA.Update(dataDesert, "food")
                loadData(1)
            ElseIf flagA Then
                Dim comandBuilderA As New OleDb.OleDbCommandBuilder(appatizerFoodA)

                dataAppet.Tables("food").Rows(c).Delete()
                maxA = maxA - 1

                c = 0

                appatizerFoodA.Update(dataAppet, "food")
                loadData(2)

            ElseIf flagDr Then
                Dim comandBuilderDr As New OleDb.OleDbCommandBuilder(drinksFoodA)

                dataDrniks.Tables("food").Rows(c).Delete()
                maxDr = maxDr - 1

                c = 0

                drinksFoodA.Update(dataDrniks, "food")
                loadData(3)
            End If

            MsgBox("Data is delete!!!!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class