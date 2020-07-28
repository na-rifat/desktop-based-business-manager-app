Public Class addNote
    Private Sub TblNotesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblNotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub addNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.DataSet.tblUser)
        center(Me, Panel1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TimeTextBox.Text = dtTime.Value
        DateTextBox.Text = dtDate.Value.Date
        up(4, 0)
        index(12)
        fll(12)
        ld(12)
        status("New notice added for " & DateTextBox.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP0(Panel1, "Add note")
    End Sub

    Private Sub SubmittedByTextBox_TextChanged(sender As Object, e As EventArgs) Handles SubmittedByTextBox.TextChanged

    End Sub

    Private Sub SubmittedByTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SubmittedByTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeTextBox.Text = dtTime.Value
            DateTextBox.Text = dtDate.Value.Date
            up(4, 0)
            index(12)
            fll(12)
            ld(12)
            status("New notice added for " & DateTextBox.Text)
        End If
    End Sub
End Class