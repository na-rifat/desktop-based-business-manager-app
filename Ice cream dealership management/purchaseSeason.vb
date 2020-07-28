Public Class purchaseSeason
    Private Sub purchaseSeason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)
        'TODO: This line of code loads data into the 'DataSet.tblPCommission' table. You can move, or remove it, as needed.
        Me.TblPCommissionTableAdapter.Fill(Me.DataSet.tblPCommission)
        center(Me, Panel1)
    End Sub

    Private Sub TblPCommissionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblPCommissionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If QuantityTextBox.Text = Nothing Then
                QuantityTextBox.Text = 0
            End If

            StartTextBox.Text = dtpstart.Value.Date
            EndTextBox.Text = dtpend.Value.Date

            up(67, 0)
            index(38)
            fll(38)
            ld(38)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown

    End Sub

    Private Sub ProductCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductCodeTextBox.TextChanged

    End Sub

    Private Sub ProductCodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductCodeTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblProductsBindingSource.Filter = "productCode =" & ProductCodeTextBox.Text
                If TblProductsBindingSource.Count > 0 Then
                    ProductNameTextBox.Text = ProductNameTextBox.Text
                    ProductCodeTextBox.Text = ProductCodeTextBox1.Text
                Else
                    ProductNameTextBox.Clear()
                    ProductCodeTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductrewardTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductrewardTextBox.TextChanged

    End Sub

    Private Sub ProductrewardTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductrewardTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblProductsBindingSource.Filter = "productName LIKE '%" & ProductrewardTextBox.Text & "%'"
                If TblProductsBindingSource.Count > 0 Then
                    ProductrewardTextBox.Text = ProductNameTextBox1.Text
                    ProductrewardCodeTextBox.Text = ProductCodeTextBox1.Text
                Else
                    ProductrewardCodeTextBox.Clear()
                    ProductrewardTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductrewardCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductrewardCodeTextBox.TextChanged

    End Sub

    Private Sub ProductrewardCodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductrewardCodeTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblProductsBindingSource.Filter = "productCode =" & ProductrewardCodeTextBox.Text
                If TblProductsBindingSource.Count > 0 Then
                    ProductrewardTextBox.Text = ProductNameTextBox1.Text
                    ProductrewardCodeTextBox.Text = ProductCodeTextBox1.Text
                Else
                    ProductrewardCodeTextBox.Clear()
                    ProductrewardTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged

    End Sub

    Private Sub ProductNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblProductsBindingSource.Filter = "productName LIKE '%" & ProductNameTextBox.Text & "%'"
                If TblProductsBindingSource.Count > 0 Then
                    ProductNameTextBox.Text = ProductNameTextBox.Text
                    ProductCodeTextBox.Text = ProductCodeTextBox1.Text
                Else
                    ProductNameTextBox.Clear()
                    ProductCodeTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TblPCommissionBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Validate()
        TblPCommissionBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub
End Class