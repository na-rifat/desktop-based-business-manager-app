Public Class date_changer
    Private Sub date_changer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Timer
        AddHandler t.Tick, Function()
                               time_label.Text = Today
                               Return 0
                           End Function
        t.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Microsoft.VisualBasic.DateString = New Date(picker.Value.Date.Year, picker.Value.Date.Month, picker.Value.Date.Day)
        Catch ex As Exception

        End Try
        Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class