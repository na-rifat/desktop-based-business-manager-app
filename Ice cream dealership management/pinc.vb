Public Class pinc
    Private Sub pinc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.DataSet.tblEmployee)
        center(Me, Panel1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TblEmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblEmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        txtpin.Text = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        txtpin.Text = 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        txtpin.Text = 2
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        txtpin.Text = 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        txtpin.Text = 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        txtpin.Text = 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        txtpin.Text = 6
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txtpin.Text = 7
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtpin.Text = 8
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        txtpin.Text = 9
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        txtpin.Text = txtpin.Text & 2
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        txtpin.Text = txtpin.Text & 3
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        txtpin.Text = txtpin.Text & 4
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        txtpin.Text = txtpin.Text & 5
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        txtpin.Text = txtpin.Text & 6
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtpin.Text = txtpin.Text & 7
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txtpin.Text = txtpin.Text & 8
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        txtpin.Text = txtpin.Text & 9
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        txtpin.Text = txtpin.Text & 0
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        conf()
        txtpin.Clear()
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        index(34)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        txtpin.Text = txtpin.Text & 1
    End Sub

    Private Sub txtpin_TextChanged(sender As Object, e As EventArgs) Handles txtpin.TextChanged

    End Sub

    Private Sub txtpin_DragDrop(sender As Object, e As DragEventArgs) Handles txtpin.DragDrop

    End Sub

    Private Sub txtpin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpin.KeyDown
        If e.KeyCode = Keys.Enter Then
            conf()
            txtpin.Clear()
        End If
    End Sub
End Class