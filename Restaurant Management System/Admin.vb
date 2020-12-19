Imports System.IO
Imports System.Data.OleDb
Imports System.Linq
Public Class Admin
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Restaurant Management System\DataBase\ResturantDb.mdb")

    Dim dataAdmin As DataSet = New DataSet()
    Dim dataWorkers As DataSet = New DataSet()

    Dim adminAdapter As New OleDbDataAdapter("SELECT * FROM [admin]", con)
    Dim workersAdapter As New OleDbDataAdapter("SELECT * FROM [workers]", con)

    Dim c As Integer = 0
    Dim maxRowAdmin As Integer
    Dim maxRowWorkers As Integer

    Dim imageName As String
    Dim locatio As String = "C:\Restaurant Management System\img"

    Public Sub loadData()

        maxRowAdmin = dataAdmin.Tables("admin").Rows.Count
        maxRowWorkers = dataWorkers.Tables("workers").Rows.Count

        If ComboBoxType.SelectedIndex = 0 Then
            imageName = dataAdmin.Tables("admin").Rows(c)("img")

            TextBoxName.Text = dataAdmin.Tables("admin").Rows(c)("name")
            TextBoxLast_N.Text = dataAdmin.Tables("admin").Rows(c)("last_name")
            TextBoxNum.Text = dataAdmin.Tables("admin").Rows(c)("phone_num")
            TextBoxAdress.Text = dataAdmin.Tables("admin").Rows(c)("adress")
            TextBoxIdCard.Text = dataAdmin.Tables("admin").Rows(c)("id_card")
            TextBoxUserName.Text = dataAdmin.Tables("admin").Rows(c)("user_name")
            TextBoxPass.Text = dataAdmin.Tables("admin").Rows(c)("password_Admin")
            TextBoxMail.Text = dataAdmin.Tables("admin").Rows(c)("mail")
            PictureBoxUser.ImageLocation = Path.Combine(locatio, imageName)

        ElseIf ComboBoxType.SelectedIndex = 1 Then
            imageName = dataWorkers.Tables("workers").Rows(c)("img")

            TextBoxName.Text = dataWorkers.Tables("workers").Rows(c)("name")
            TextBoxLast_N.Text = dataWorkers.Tables("workers").Rows(c)("last_name")
            TextBoxNum.Text = dataWorkers.Tables("workers").Rows(c)("phone_num")
            TextBoxAdress.Text = dataWorkers.Tables("workers").Rows(c)("adress")
            TextBoxIdCard.Text = dataWorkers.Tables("workers").Rows(c)("id_card")
            TextBoxUserName.Text = dataWorkers.Tables("workers").Rows(c)("user_name")
            TextBoxPass.Text = dataWorkers.Tables("workers").Rows(c)("password_worker")
            TextBoxMail.Text = dataWorkers.Tables("workers").Rows(c)("mail")
            PictureBoxUser.ImageLocation = Path.Combine(locatio, imageName)

        End If
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()

            adminAdapter.Fill(dataAdmin, "admin")
            workersAdapter.Fill(dataWorkers, "workers")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        ComboBoxType.SelectedIndex = 1
        loadData()

    End Sub

    Private Sub Admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
    End Sub

    Private Sub ComboBoxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxType.SelectedIndexChanged
        c = 0
        loadData()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click

        If ComboBoxType.SelectedIndex = 0 Then
            If c <> maxRowAdmin - 1 Then

                c = c + 1

                'loadData()

            Else

                'MessageBox.Show("No More Rows")
                c = 0

            End If
        End If
        If ComboBoxType.SelectedIndex = 1 Then
                If c <> maxRowWorkers - 1 Then

                    c = c + 1

                'loadData()

            Else

                    'MessageBox.Show("No More Rows")
                    c = 0

                End If
            End If
            'MsgBox(c & "  " & dataWorkers.Tables("workers").Rows.Count) 'PROBLEM je ovdje sa count
            loadData()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        If ComboBoxType.SelectedIndex = 0 Then
            If c > 0 Then

                c = c - 1

                'loadData()

            Else

                'MessageBox.Show("First Record")
                c = maxRowAdmin - 1
                'loadData()
            End If
        End If

        If ComboBoxType.SelectedIndex = 1 Then
            If c > 0 Then

                c = c - 1

                'loadData()

            Else

                'MessageBox.Show("First Record")
                c = maxRowWorkers - 1
                'loadData()
            End If
        End If
        loadData()
    End Sub

    Private Sub ButtonBegin_Click(sender As Object, e As EventArgs) Handles ButtonBegin.Click
        If ComboBoxType.SelectedIndex = 0 Then
            If c <> 0 Then

                c = 0

                'loadData()

            End If
        End If

        If ComboBoxType.SelectedIndex = 1 Then
            If c <> 0 Then

                c = 0

                'loadData()

            End If
        End If
        loadData()
    End Sub

    Private Sub ButtonEnd_Click(sender As Object, e As EventArgs) Handles ButtonEnd.Click
        If ComboBoxType.SelectedIndex = 0 Then
            If c <> maxRowAdmin - 1 Then

                c = maxRowAdmin - 1

                'loadData()

            End If
        End If

        If ComboBoxType.SelectedIndex = 1 Then
            If c <> maxRowWorkers - 1 Then

                c = maxRowWorkers - 1

                'loadData()

            End If

        End If
        loadData()

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
            ButtonFoodForm.Enabled = False

        Else
            ButtonBegin.Enabled = True
            ButtonEnd.Enabled = True
            ButtonAdd.Enabled = True
            ButtonBack.Enabled = True
            ButtonNext.Enabled = True
            ButtonUpdate.Enabled = True
            ButtonUpdate.Visible = True
            ButtonDelete.Enabled = True
            ButtonFoodForm.Enabled = True

        End If
    End Sub

    Sub clearFields()
        TextBoxName.Clear()
        TextBoxLast_N.Clear()
        TextBoxNum.Clear()
        TextBoxAdress.Clear()
        TextBoxIdCard.Clear()
        TextBoxUserName.Clear()
        TextBoxPass.Clear()
        TextBoxMail.Clear()
        PictureBoxUser.Image = Nothing
    End Sub

    Private Sub TextBoxNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNum.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
            MsgBox("This field alow just numeric characters")
            TextBoxNum.Select()

        End If
    End Sub

    Private Sub TextBoxIdCard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxIdCard.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
            MsgBox("This field alow just numeric characters")
            TextBoxIdCard.Select()

        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click


        clearFields()
        alowBtns(False)

        ButtonCancel.Enabled = True
        ButtonCancel.Visible = True
        ButtonSave.Enabled = True
        ButtonSave.Visible = True
        ButtonBrowse.Enabled = True

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ButtonSave.Enabled = False
        ButtonSave.Visible = False
        ButtonCancel.Enabled = False
        ButtonCancel.Visible = False

        alowBtns(True)
        loadData()

    End Sub

    Sub folderImage()

        Dim saveDirectory As String = "C:\Restaurant Management System\img\"


        If Not Directory.Exists(saveDirectory) Then
            Directory.CreateDirectory(saveDirectory)
        End If

        Dim fileName As String = Path.GetFileName(OpenFileDialog1.FileName)
        Dim fileSavePath As String = Path.Combine(saveDirectory, fileName)
        Try
            File.Copy(OpenFileDialog1.FileName, fileSavePath, True)
        Catch ex As System.ArgumentException
            'MsgBox(imageName)
            If ComboBoxType.SelectedIndex = 0 Then
                dataAdmin.Tables("admin").Rows(c).Item("img") = imageName
            Else
                dataWorkers.Tables("workers").Rows(c).Item("img") = imageName
            End If

        End Try

    End Sub




    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        If TextBoxAdress.Text = "" Or TextBoxName.Text = "" Or TextBoxLast_N.Text = "" Or
          TextBoxNum.Text = "" Or TextBoxIdCard.Text = "" Or TextBoxUserName.Text = "" Or
          TextBoxPass.Text = "" Or TextBoxMail.Text = "" Or PictureBoxUser.Image Is Nothing Then
            MsgBox("You must fill all fields")
            Exit Sub
        End If

        Dim userName As String = TextBoxUserName.Text
        Dim email As String = TextBoxMail.Text
        Dim idCard As String = TextBoxIdCard.Text

        If ComboBoxType.SelectedIndex = 0 Then

            For i = 0 To dataAdmin.Tables("admin").Rows.Count - 1
                'MsgBox(dataAdmin.Tables("admin").Rows(i)("password_Admin"))
                If userName = dataAdmin.Tables("admin").Rows(i)("user_name") Or email = dataAdmin.Tables("admin").Rows(i)("mail") Or
                    idCard = dataAdmin.Tables("admin").Rows(i)("id_card") Then
                    MsgBox("That User already exist in our data")
                    clearFields()
                    Exit Sub

                End If
            Next

            Dim comandBuilderA As New OleDb.OleDbCommandBuilder(adminAdapter)
            Dim dataRowAdmin As DataRow = dataAdmin.Tables("admin").NewRow()

            dataRowAdmin.Item("name") = TextBoxName.Text
            dataRowAdmin.Item("last_name") = TextBoxLast_N.Text
            dataRowAdmin.Item("phone_num") = TextBoxNum.Text
            dataRowAdmin.Item("adress") = TextBoxAdress.Text
            dataRowAdmin.Item("id_card") = TextBoxIdCard.Text
            dataRowAdmin.Item("user_name") = TextBoxUserName.Text
            dataRowAdmin.Item("password_Admin") = TextBoxPass.Text
            dataRowAdmin.Item("mail") = TextBoxMail.Text
            dataRowAdmin.Item("img") = Path.GetFileName(OpenFileDialog1.FileName)

            folderImage()


            dataAdmin.Tables("admin").Rows.Add(dataRowAdmin)

            adminAdapter.Update(dataAdmin, "admin")
            dataAdmin.AcceptChanges()

            c = dataAdmin.Tables("admin").Rows.Count - 1
            adminAdapter.Fill(dataAdmin, "admin")

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
            ButtonBrowse.Enabled = True

        ElseIf ComboBoxType.SelectedIndex = 1 Then

            For i = 0 To dataWorkers.Tables("workers").Rows.Count - 1
                If userName = dataWorkers.Tables("workers").Rows(i)("user_name") Or email = dataWorkers.Tables("workers").Rows(i)("mail") Or
                    idCard = dataWorkers.Tables("workers").Rows(i)("id_card") Then
                    MsgBox("That User already exist in our data")
                    clearFields()
                    Exit Sub

                End If
            Next

            Dim comandBuilderW As New OleDb.OleDbCommandBuilder(workersAdapter)
            Dim dataRowWokers As DataRow = dataWorkers.Tables("workers").NewRow()

            dataRowWokers.Item("name") = TextBoxName.Text
            dataRowWokers.Item("last_name") = TextBoxLast_N.Text
            dataRowWokers.Item("phone_num") = TextBoxNum.Text
            dataRowWokers.Item("adress") = TextBoxAdress.Text
            dataRowWokers.Item("id_card") = TextBoxIdCard.Text
            dataRowWokers.Item("user_name") = TextBoxUserName.Text
            dataRowWokers.Item("password_worker") = TextBoxPass.Text
            dataRowWokers.Item("mail") = TextBoxMail.Text
            dataRowWokers.Item("img") = Path.GetFileName(OpenFileDialog1.FileName)

            folderImage()

            dataWorkers.Tables("workers").Rows.Add(dataRowWokers)

            workersAdapter.Update(dataWorkers, "workers")

            dataWorkers.AcceptChanges()

            workersAdapter.Fill(dataWorkers, "workers")

            c = dataWorkers.Tables("workers").Rows.Count - 1
            maxRowWorkers = dataWorkers.Tables("workers").Rows.Count - 1


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
                ButtonBrowse.Enabled = True
            End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click

        If TextBoxAdress.Text = "" Or TextBoxName.Text = "" Or TextBoxLast_N.Text = "" Or
          TextBoxNum.Text = "" Or TextBoxIdCard.Text = "" Or TextBoxUserName.Text = "" Or
          TextBoxPass.Text = "" Or TextBoxMail.Text = "" Or PictureBoxUser.Image Is Nothing Then
            MsgBox("You must fill all fields")
            Exit Sub
        End If

        If ComboBoxType.SelectedIndex = 0 Then
            Dim comandBuilderA As New OleDb.OleDbCommandBuilder(adminAdapter)

            dataAdmin.Tables("admin").Rows(c).Item(1) = TextBoxName.Text
            dataAdmin.Tables("admin").Rows(c).Item(2) = TextBoxLast_N.Text
            dataAdmin.Tables("admin").Rows(c).Item(6) = TextBoxNum.Text
            dataAdmin.Tables("admin").Rows(c).Item(8) = TextBoxAdress.Text
            dataAdmin.Tables("admin").Rows(c).Item(7) = TextBoxIdCard.Text
            dataAdmin.Tables("admin").Rows(c).Item(4) = TextBoxUserName.Text
            dataAdmin.Tables("admin").Rows(c).Item(5) = TextBoxPass.Text
            dataAdmin.Tables("admin").Rows(c).Item(3) = TextBoxMail.Text
            dataAdmin.Tables("admin").Rows(c).Item("img") = Path.GetFileName(OpenFileDialog1.FileName)

            Try
                folderImage()
            Catch ex As FileNotFoundException
                'MsgBox(imageName)
                dataAdmin.Tables("admin").Rows(c).Item("img") = imageName
            End Try


            adminAdapter.Update(dataAdmin, "admin")

            'loadData

            'If c = 0 Then
            'c = 1
            'ElseIf c = 1 Then
            ' c = 0  
            'Else
            ' c = 0
            'End If
            OpenFileDialog1.Reset()

            loadData()
            MsgBox("Data updated")

        ElseIf ComboBoxType.SelectedIndex = 1 Then
            ' Dim d As Integer = 0
            Dim comandBuilderW As New OleDb.OleDbCommandBuilder(workersAdapter)

            dataWorkers.Tables("workers").Rows(c).Item(1) = TextBoxName.Text
            dataWorkers.Tables("workers").Rows(c).Item(2) = TextBoxLast_N.Text
            dataWorkers.Tables("workers").Rows(c).Item(6) = TextBoxNum.Text
            dataWorkers.Tables("workers").Rows(c).Item(8) = TextBoxAdress.Text
            dataWorkers.Tables("workers").Rows(c).Item(7) = TextBoxIdCard.Text
            dataWorkers.Tables("workers").Rows(c).Item(4) = TextBoxUserName.Text
            dataWorkers.Tables("workers").Rows(c).Item(5) = TextBoxPass.Text
            dataWorkers.Tables("workers").Rows(c).Item(3) = TextBoxMail.Text
            dataWorkers.Tables("workers").Rows(c).Item("img") = Path.GetFileName(OpenFileDialog1.FileName)


            Try
                folderImage()
            Catch ex As FileNotFoundException
                ' MsgBox(imageName)
                dataWorkers.Tables("workers").Rows(c).Item("img") = imageName
            End Try


            workersAdapter.Update(dataWorkers, "workers")

            'If c = 0 Then
            'c = 1
            'ElseIf c = 1 Then 
            'c = 0
            'Else
            'c = 0
            'End If
            OpenFileDialog1.Reset()

            'MsgBox(OpenFileDialog1.FileName)

            loadData()
            MsgBox("Data updated")

        End If


    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim comandBuilderW As New OleDb.OleDbCommandBuilder(workersAdapter)
        Dim comandBuilderA As New OleDb.OleDbCommandBuilder(adminAdapter)


        If ComboBoxType.SelectedIndex = 0 Then

                If maxRowAdmin - 1 > 0 Then
                    dataAdmin.Tables("admin").Rows(c).Delete()
                    maxRowAdmin = maxRowAdmin - 1

                    c = 0
                    'dataAdmin.AcceptChanges()
                    adminAdapter.Update(dataAdmin, "admin")
                    'workersAdapter.Fill(dataWorkers, "workers")
                Else
                    MsgBox("You can't delete last data!!!")
                    Exit Sub
                End If
            End If

            If ComboBoxType.SelectedIndex = 1 Then
                dataWorkers.Tables("workers").Rows(c).Delete()
                maxRowWorkers = maxRowWorkers - 1

                c = 0

                workersAdapter.Update(dataWorkers, "workers")
                dataWorkers.AcceptChanges()


                workersAdapter.Fill(dataWorkers, "workers")

            End If


            MsgBox("Data is delete!!!!")
        loadData()
    End Sub

    Private Sub ButtonFoodForm_Click(sender As Object, e As EventArgs) Handles ButtonFoodForm.Click
        Me.Hide()
        FoodForm.Show()

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        OpenFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JEPGs|*.jpg"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBoxUser.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub
End Class