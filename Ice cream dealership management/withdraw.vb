Public Class withdraw
    Private Sub TblwithdrawBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblwithdrawBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblwithdraw' table. You can move, or remove it, as needed.
        Me.TblwithdrawTableAdapter.Fill(Me.DataSet.tblwithdraw)
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DateTextBox.Text = DateTimePicker1.Value.Date
        up(60, 0)
        Panel2.Enabled = False
        GroupBox1.Text = "New withdraw"
        Button1.Text = "Add"

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        nw(60, 0)

        Panel2.Enabled = True
        GroupBox1.Text = "New withdraw"
        Button1.Text = "Add"
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(60, 0)
        up(60, 0)

        Panel2.Enabled = False
        GroupBox1.Text = "New withdraw"
        Button1.Text = "Add"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(60, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            TblwithdrawBindingSource.Filter = "date LIKE '%" & txtSearch.Text & "%'"
            If txtSearch.Text = Nothing Then
                TblwithdrawBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub withdraw_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            nw(60, 0)

            Panel2.Enabled = True
            GroupBox1.Text = "New withdraw"
            Button1.Text = "Add"
        ElseIf e.Control AndAlso e.KeyCode = Keys.Delete Then
            rm(60, 0)
            up(60, 0)

            Panel2.Enabled = False
            GroupBox1.Text = "New withdraw"
            Button1.Text = "Add"

        End If
    End Sub

    Private Sub PersonTextBox_TextChanged(sender As Object, e As EventArgs) Handles PersonTextBox.TextChanged

    End Sub

    Private Sub PersonTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PersonTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker1.Select()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTextBox.Text = DateTimePicker1.Value.Date
            up(60, 0)
            Panel2.Enabled = False
            GroupBox1.Text = "New withdraw"
            Button1.Text = "Add"
        End If
    End Sub
End Class