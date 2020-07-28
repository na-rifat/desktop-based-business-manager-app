Imports System.Data.SqlClient
Imports System.Configuration

Imports System.Threading
Imports System.Threading.Tasks

Imports Google
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v2
Imports Google.Apis.Drive.v2.Data
Imports Google.Apis.Services
Imports Google.Apis.Auth
Imports Google.Apis.Download
Imports System.ComponentModel
Imports System.IO


Module backupmodule




    Private service As DriveService = New DriveService
    Public Sub createService()
        Dim clientid = "241922666444-6pcjmn63fpcamgeoq77kb69bf43n94rq.apps.googleusercontent.com"
        Dim clientsecret = "cmDK2U2i9Jw2Sn1Z1CvLSEyy"
        Dim MyUserCredential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = clientid, .ClientSecret = clientsecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
        service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = MyUserCredential, .ApplicationName = "Rafalo ice cream dealership management software"})
    End Sub
    Public Sub uploadFile()

        Dim thd As New Thread(New ThreadStart(Sub()
                                                  createService()

                                                  Dim Request = service.Files.List()
                                                  Request.Q = "mimeType != 'application/vnd.google-apps.folder' and trashed = false"
                                                  Request.MaxResults = 20
                                                  Dim Results = Request.Execute
                                                  For a = 0 To 2
                                                      If a = 0 Then
                                                          For Each Result In Results.Items
                                                              '(Result.DownloadUrl & vbCrLf & Result.Title & vbCrLf &Result.OriginalFilename)
                                                              'TextBox2.Text = (Result.DownloadUrl & vbCrLf & Result.Title & vbCrLf & Result.OriginalFilename)
                                                              If Result.Title = "data" AndAlso Result.OriginalFilename = "data" Then
                                                                  service.Files.Delete(Result.Id).Execute()
                                                              End If
                                                          Next

                                                      ElseIf a = 1 Then



                                                      ElseIf a = 2 Then
                                                          createService()

                                                          Dim s2 As New Security.Permissions.FileIOPermission(Security.Permissions.FileIOPermissionAccess.Read, AppDomain.CurrentDomain.BaseDirectory & "data.mdf")

                                                          s2.Demand()



                                                          Dim s = New Security.PermissionSet(Security.Permissions.PermissionState.Unrestricted)
                                                          s.AddPermission(New Security.Permissions.FileIOPermission(Security.Permissions.FileIOPermissionAccess.AllAccess, AppDomain.CurrentDomain.BaseDirectory & "data.mdf"))
                                                          s.AddPermission(New Security.Permissions.FileIOPermission(Security.Permissions.FileIOPermissionAccess.AllAccess, IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory & "data.mdf")))
                                                          s.AddPermission(New Security.Permissions.FileIOPermission(Security.Permissions.FileIOPermissionAccess.Read, AppDomain.CurrentDomain.BaseDirectory & "data.mdf"))
                                                          s.AddPermission(New Security.Permissions.FileIOPermission(Security.Permissions.FileIOPermissionAccess.Append, AppDomain.CurrentDomain.BaseDirectory & "data.mdf"))
                                                          s.Demand()



                                                          Dim TheFile As New Google.Apis.Drive.v2.Data.File
                                                          TheFile.Title = "data"
                                                          TheFile.Description = "Data backup for " & Today
                                                          TheFile.MimeType = "text/plain"


                                                          'Dim ByteArray As Byte() = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory & "\data.mdf")
                                                          MsgBox(AppDomain.CurrentDomain.BaseDirectory & "data.mdf")
                                                          Try
                                                              Dim stream As New System.IO.FileStream(AppDomain.CurrentDomain.BaseDirectory & "data.mdf", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

                                                              Dim UploadRequest As FilesResource.InsertMediaUpload = service.Files.Insert(TheFile, stream, TheFile.MimeType)
                                                              UploadRequest.Upload()



                                                              status("Data back up completed for " & Today)

                                                          Catch ex As Exception

                                                          End Try




                                                      End If
                                                  Next
                                              End Sub
                                              ))
        thd.Start()

    End Sub

    Public Sub DownloadFile()
        Dim bcd As New BackgroundWorker
        AddHandler bcd.DoWork, Function()
                                   For a As Integer = 0 To 1
                                       If a = 0 Then
                                           Try
                                               My.Computer.FileSystem.DeleteFile(AppDomain.CurrentDomain.BaseDirectory & "\data.mdf")
                                           Catch ex As Exception

                                           End Try

                                       ElseIf a = 1 Then
                                           createService()
                                           Dim Downloader = New MediaDownloader(service)
                                           Downloader.ChunkSize = 2560 * 1024

                                           Dim Filename = AppDomain.CurrentDomain.BaseDirectory & "\data.mdf"

                                           Dim url As String = ""

                                           Dim Request = service.Files.List()
                                           Request.Q = "mimeType != 'application/vnd.google-apps.folder' and trashed = false"
                                           Request.MaxResults = 1000
                                           Dim Results = Request.Execute
                                           For Each Result In Results.Items
                                               '(Result.DownloadUrl & vbCrLf & Result.Title & vbCrLf &Result.OriginalFilename)
                                               'TextBox2.Text = (Result.DownloadUrl & vbCrLf & Result.Title & vbCrLf & Result.OriginalFilename)
                                               If Result.Title = "data" AndAlso Result.OriginalFilename = "data" Then
                                                   url = Result.DownloadUrl
                                                   Using FileStream = New System.IO.FileStream(Filename, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                                                       Dim progress = Downloader.Download(url, FileStream)
                                                       Threading.Thread.Sleep(1000)

                                                   End Using

                                               End If
                                           Next
                                           Return 0
                                       End If
                                   Next
                                   Return 0
                               End Function

        bcd.RunWorkerAsync()

    End Sub

End Module
