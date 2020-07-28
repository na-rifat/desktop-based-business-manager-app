Public Class cal
    Dim first_number As Double
    Dim second_number As Double
    Dim result As Double

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Close()
    End Sub

    Function send()

        Return 0
    End Function

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        push("1")
    End Sub
    Function push(str As String)
        If lblMain.Text = "0" Then
            lblMain.Text = str
        Else
            lblMain.Text = lblMain.Text & str
        End If
        Return lblMain.Text = str
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        push("2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        push("3")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        push("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        push("5")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        push("6")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        push("7")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        push("8")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        push("9")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        push("0")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        push("00")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        push(".")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        lblMain.Text = "0"
        lbl_2.Text = "0"
    End Sub
End Class