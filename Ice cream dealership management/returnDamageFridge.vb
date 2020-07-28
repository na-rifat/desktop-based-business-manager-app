Public Class returnDamageFridge
    Private Sub TblDamageFridgeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblDamageFridgeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub returnDamageFridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblDamageFridge' table. You can move, or remove it, as needed.
        Me.TblDamageFridgeTableAdapter.Fill(Me.DataSet.tblDamageFridge)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblDamageFridgeBindingSource.RemoveCurrent()
        Validate()
        TblDamageFridgeBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
        index(11)
        fll(11)
        ld(11)
    End Sub
End Class