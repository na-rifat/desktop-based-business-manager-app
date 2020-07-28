Public Class manageVehicle
    Private Sub TblVehicleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblVehicleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblVehicle' table. You can move, or remove it, as needed.
        Me.TblVehicleTableAdapter.Fill(Me.DataSet.tblVehicle)
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(62, 0)
        up(62, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblVehicleBindingSource.Filter = "vehicleID =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 3 Then
                TblVehicleBindingSource.Filter = "issueDate ='" & txtSearch.Text & "'"
            Else
                filter(63, txtFilter.SelectedIndex, 46, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblVehicleBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printD(TblVehicleDataGridView, "Vehicles")
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(63, 0)
    End Sub

    Private Sub manageVehicle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            index(62)
            fll(62)
            ld(62)
            nw(62, 0)
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(62, 0)
            up(62, 0)
        End If
    End Sub
End Class