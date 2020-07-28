Public Class print_invoice
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_email.Click

    End Sub

    Private Sub btn_seal_Click(sender As Object, e As EventArgs) Handles btn_seal.Click

        If Panel3.Controls.Count = 0 Then
            Dim p As New PictureBox
            p.Height = CompanyLogoPictureBox.Height + 20
            p.Width = p.Height
            p.Image = CompanyLogoPictureBox.Image
            p.SizeMode = PictureBoxSizeMode.StretchImage
            Panel3.Controls.Add(p)
            p.Left = (Panel3.Width / 2) - (p.Width / 2)
            p.Top = (Panel3.Height / 2) - (p.Height / 2)
        Else
            Panel3.Controls.Clear()
        End If
    End Sub
End Class