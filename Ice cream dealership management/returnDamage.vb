Public Class returnDamage
    Private Sub TblDamageProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblDamageProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub returnDamage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblDamageProducts' table. You can move, or remove it, as needed.
        Me.TblDamageProductsTableAdapter.Fill(Me.DataSet.tblDamageProducts)
        center(Me, Panel1)
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TblDamageProductsBindingSource.Filter = "productCode =" & ProductCodeTextBox.Text
            If TblDamageProductsBindingSource.Count > 0 Then
                If Integer.Parse(txt.Text) < Integer.Parse(QuantityTextBox.Text) Then
                    QuantityTextBox.Text = Integer.Parse(QuantityTextBox.Text) - Integer.Parse(txt.Text)
                ElseIf Integer.Parse(txt.text) = Integer.Parse(QuantityTextBox.text) Then
                    TblDamageProductsBindingSource.RemoveCurrent()
                End If
            End If


            up(45, 0)
            index(24)
            fll(24)
            ld(24)
            status(txt.Text & " damage product returned.")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TblDamageProductsBindingSource.Filter = "Id =" & txtF.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtF_TextChanged(sender As Object, e As EventArgs) Handles txtF.TextChanged
        If txtF.Text = Nothing Then
            TblDamageProductsBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP0(Panel1, "Return damage products")
    End Sub
End Class