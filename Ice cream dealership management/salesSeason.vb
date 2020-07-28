Public Class salesSeason
    Private Sub salesSeason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)

        center(Me, Panel1)
    End Sub

    Private Sub TblSCommissionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSCommissionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            StartTextBox.Text = dtpstart.Value.Date
            EndTextBox.Text = dtpend.Value.Date
            If QuantityTextBox.Text = Nothing Then
                QuantityTextBox.Text = 0
            End If
            If TargetQuantityTextBox.Text = Nothing Then
                TargetQuantityTextBox.Text = 0
            End If
            If StatusTextBox.Text = Nothing Then
                StatusTextBox.Text = 0
            End If


            up(68, 0)

            index(38)
            fll(38)
            ld(38)
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
                    ProductNameTextBox.Text = ProductNameTextBox1.Text
                    ProductCodeTextBox.Text = ProductCodeTextBox1.Text
                    CashrewardTextBox.Text = SupplierTextBox.Text
                Else
                    ProductCodeTextBox.Clear()
                    ProductNameTextBox.Clear()
                    CashrewardTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductCodeTextBox.TextChanged

    End Sub

    Private Sub ProductCodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductCodeTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblProductsBindingSource.Filter = "productCode =" & ProductCodeTextBox.Text
                If TblProductsBindingSource.Count > 0 Then
                    ProductNameTextBox.Text = ProductNameTextBox1.Text
                    ProductCodeTextBox.Text = ProductCodeTextBox1.Text
                    CashrewardTextBox.Text = SupplierTextBox.Text
                Else
                    ProductCodeTextBox.Clear()
                    ProductNameTextBox.Clear()
                    CashrewardTextBox.Clear()
                End If
                TargetQuantityTextBox.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductrewardTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductrewardTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        'Try
        '    If e.KeyCode = Keys.Enter Then
        '        TblProductsBindingSource.Filter = "productName LIKE '%" & ProductrewardTextBox.Text & "%'"
        '        If TblProductsBindingSource.Count > 0 Then
        '            ProductrewardTextBox.Text = ProductNameTextBox1.Text
        '            ProductrewardCodeTextBox.Text = ProductCodeTextBox1.Text
        '        Else
        '            ProductrewardTextBox.Clear()
        '            ProductrewardCodeTextBox.Clear()
        '        End If
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ProductrewardCodeTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductrewardCodeTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        'Try
        '    If e.KeyCode = Keys.Enter Then
        '        TblProductsBindingSource.Filter = "productCode =" & ProductrewardCodeTextBox.Text
        '        If TblProductsBindingSource.Count > 0 Then
        '            ProductrewardTextBox.Text = ProductNameTextBox1.Text
        '            ProductrewardCodeTextBox.Text = ProductCodeTextBox1.Text
        '        Else
        '            ProductrewardTextBox.Clear()
        '            ProductrewardCodeTextBox.Clear()
        '        End If
        '        ProductrewardQuantityTextBox.Select()
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub CashrewardTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashrewardTextBox.TextChanged

    End Sub
End Class