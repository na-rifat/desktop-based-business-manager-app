Imports System.IO
Imports System.Net.Mail
Imports System.Net.Mime
Imports Zuby

Public Class email_sender
    Public bm() As Bitmap
    Public subj As String = Nothing
    Public body As String = Nothing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Try
            My.Settings.mail_to = txt_to.Text
            If chk_save.Checked Then
                My.Settings.mail_from = txt_from.Text
                My.Settings.mail_pass = txt_password.Text
            End If
            My.Settings.Save()
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(My.Settings.mail_from, My.Settings.mail_pass)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(My.Settings.mail_from)
            e_mail.To.Add(My.Settings.mail_to)
            e_mail.Subject = subj
            e_mail.IsBodyHtml = False
            e_mail.Body = txt_note.Text
            'adding attachments 
            For a As Integer = 0 To bm.Count - 1
                If IsNothing(bm(a)) = True Then
                    Exit For
                End If
                Dim b As Bitmap = New Bitmap(bm(a))
                Dim ic As ImageConverter = New ImageConverter
                Dim ba = CType(ic.ConvertTo(b, GetType([Byte]())), [Byte]())
                Dim img = New MemoryStream(ba)
                Dim ct As New ContentType
                ct.Name = "product_stock_statement" & a
                ct.MediaType = MediaTypeNames.Image.Jpeg
                e_mail.Attachments.Add(New Attachment(img, ct))
            Next
            '''''''''            
            Smtp_Server.Send(e_mail)
            status("Mail Sent")
            Close()

        Catch error_t As Exception
            MsgBox(error_t.Message)
        End Try
    End Sub

    Private Sub chk_save_CheckedChanged(sender As Object, e As EventArgs) Handles chk_save.CheckedChanged

    End Sub

    Private Sub email_sender_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_to.Text = My.Settings.mail_to
        txt_from.Text = My.Settings.mail_from
        txt_password.Text = My.Settings.mail_pass
        txt_sub.Text = subj
        txt_note.Text = body
    End Sub
End Class