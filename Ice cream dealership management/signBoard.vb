Public Class signBoard
    Private Sub TblSignboardBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblSignboardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub signBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSignboard' table. You can move, or remove it, as needed.
        Me.TblSignboardTableAdapter.Fill(Me.DataSet.tblSignboard)

    End Sub
End Class