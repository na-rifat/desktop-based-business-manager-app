Public Class frmBanks
    Private Sub BanksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmBanks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblBanks' table. You can move, or remove it, as needed.
        Me.TblBanksTableAdapter.Fill(Me.DataSet1.tblBanks)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TblBanksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TblBanksBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblBanksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(19, 0)
        up(19, 0)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        printFP(Panel1, "Banks")
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            filter(19, txtFilter.SelectedIndex, 2, 0, txtSearch.Text)
            If txtSearch.Text = Nothing Then
                TblBanksBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ab(19, 0)
    End Sub
End Class