Imports System.Data.OleDb
Imports System.IO

Public Class LoginForm
    'Dim con As OleDbConnection
    Dim cmd As OleDbCommand

    Public idWorker As Integer

    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Restaurant Management System\DataBase\ResturantDb.mdb")

    Dim workerA As New OleDbDataAdapter("SELECT * FROM [workers]", con)
    Dim dataWorker As DataSet = New DataSet()

    Dim adminA As New OleDbDataAdapter("SELECT * FROM [admin]", con)
    Dim dataAdmin As DataSet = New DataSet


    Private Sub LabelForAdmin_Click(sender As Object, e As EventArgs)
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click


        For i = 0 To dataWorker.Tables("workers").Rows.Count - 1
            If (dataWorker.Tables("workers").Rows(i)("user_name") = TextBoxUserName.Text) And (dataWorker.Tables("workers").Rows(i)("password_worker") = TextBoxPassw.Text) Then
                'MsgBox("You are user!!!")

                idWorker = dataWorker.Tables("workers").Rows(i)("ID_worker")
                MainForm.Show()
                Me.Hide()

            End If
        Next

        For i = 0 To dataAdmin.Tables("admin").Rows.Count - 1
            If (dataAdmin.Tables("admin").Rows(i)("user_name") = TextBoxUserName.Text) And (dataAdmin.Tables("admin").Rows(i)("password_Admin") = TextBoxPassw.Text) Then
                'MsgBox("You are Admin!!!")
                Admin.Show()
                Me.Hide()

            End If

        Next



        TextBoxUserName.Clear()
        TextBoxPassw.Clear()



    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        ButtonLogin.Select()
        con.Open()
        workerA.Fill(dataWorker, "workers")
        adminA.Fill(dataAdmin, "admin")
        con.Close()

        Dim saveDirectory As String = "C:\Restaurant Management System\img\"


        If Not Directory.Exists(saveDirectory) Then
            Directory.CreateDirectory(saveDirectory)
        End If

    End Sub
End Class
