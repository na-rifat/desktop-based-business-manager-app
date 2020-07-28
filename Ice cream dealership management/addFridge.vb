Public Class addFridge
    Private Sub addFridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSuppliers' table. You can move, or remove it, as needed.
        Me.TblSuppliersTableAdapter.Fill(Me.DataSet.tblSuppliers)
        'TODO: This line of code loads data into the 'DataSet.tblFridges' table. You can move, or remove it, as needed.
        Me.TblFridgesTableAdapter.Fill(Me.DataSet.tblFridges)
        center(Me, Panel1)
    End Sub

    Private Sub TblFridgesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblFridgesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IssueDateTextBox.Text = DateTimePicker2.Text
        If rdN.Checked = True Then
            FridgeConditionTextBox.Text = "New"
        ElseIf rdO.Checked = True Then
            FridgeConditionTextBox.Text = "Uesd"
        End If


        up(3, 0)
        index(27)
        fll(27)
        ld(27)
        status("Fridge updated.")
    End Sub

    Private Sub CompanySecurityMoneyLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CompanySecurityMoneyTextBox_TextChanged(sender As Object, e As EventArgs) Handles CompanySecurityMoneyTextBox.TextChanged

    End Sub

    Private Sub chkC_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkS_CheckedChanged(sender As Object, e As EventArgs) Handles chkS.CheckedChanged
        If chkS.Checked = True Then
            CompanyRentTextBox.ReadOnly = True
            CompanyRentTextBox.Text = 0
        Else
            CompanyRentTextBox.ReadOnly = False
            CompanyRentTextBox.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printP0(Panel1, "Rent fridge from company")
    End Sub

    Private Sub SupplierNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierNameTextBox.TextChanged

    End Sub

    Private Sub SupplierNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SupplierNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblSuppliersBindingSource.Filter = "supplierName LIKE '%" & SupplierNameTextBox.Text & "%'"
                If TblSuppliersBindingSource.Count > 0 Then
                    SupplierNameTextBox.Text = SupplierNameTextBox1.Text
                Else
                    SupplierNameTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CompanyRentTextBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyRentTextBox.TextChanged

    End Sub

    Private Sub CompanyRentTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CompanyRentTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            IssueDateTextBox.Text = DateTimePicker2.Text
            If rdN.Checked = True Then
                FridgeConditionTextBox.Text = "New"
            ElseIf rdO.Checked = True Then
                FridgeConditionTextBox.Text = "Uesd"
            End If


            up(3, 0)
            index(27)
            fll(27)
            ld(27)
            status("Fridge updated.")
        End If
    End Sub
End Class