Public Class documents
    Private Sub TblDocumentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblDocumentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub documents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblDocuments' table. You can move, or remove it, as needed.
        Me.TblDocumentsTableAdapter.Fill(Me.DataSet.tblDocuments)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Add"
        GroupBox1.Text = "New document"
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Text = "Update"
        GroupBox1.Text = "Edit document"
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nw(71, 0)
        Button1.Text = "Add"
        GroupBox1.Text = "New document"
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        rm(71, 0)
        up(71, 0)
        Button1.Text = "Add"
        GroupBox1.Text = "New document"
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TblDocumentsBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TblDocumentsBindingSource.MoveNext()
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged

    End Sub

    Private Sub DateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateDateTimePicker.ValueChanged

    End Sub

    Private Sub SerialTextBox_TextChanged(sender As Object, e As EventArgs) Handles SerialTextBox.TextChanged

    End Sub

    Private Sub Document_nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Document_nameTextBox.TextChanged

    End Sub
End Class