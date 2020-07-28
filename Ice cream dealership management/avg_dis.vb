Public Class avg_dis
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        average_dis()
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If Double.Parse(TextBox1.Text) > 100 Then
                TextBox1.Text = 100
            ElseIf Double.Parse(TextBox1.text) < 0 Then
                TextBox1.Text = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            average_dis()
            Close()
        End If
    End Sub

    Private Sub avg_dis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_total.Text = all.newsale.TotalAmountTextBox.Text

        Dim t As New Timer
        AddHandler t.Tick, Function()
                               Try
                                   If TextBox1.Text = Nothing Then
                                       lbl_discount.Text = "0"
                                   Else
                                       lbl_discount.Text = prc(Double.Parse(lbl_total.Text), Double.Parse(TextBox1.Text))
                                   End If
                                   lbl_grand.text = Double.Parse(lbl_total.Text) - Double.Parse(lbl_discount.text)
                               Catch ex As Exception

                               End Try
                               Return 0
                           End Function

        t.Start()

        TextBox1.Clear()
        TextBox1.Select()
        num(TextBox1)
    End Sub
End Class