Public Class stock_statement
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        dtg1.Rows.Add(dtg1.Rows.Count, 12, 12)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub btn_email_Click(sender As Object, e As EventArgs) Handles btn_email.Click

    End Sub
End Class