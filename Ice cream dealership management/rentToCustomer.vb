Public Class rentToCustomer
    Private Sub TblFridgesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblFridgesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub rentToCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.DataSet.tblCustomers)
        'TODO: This line of code loads data into the 'DataSet.tblFridges' table. You can move, or remove it, as needed.
        Me.TblFridgesTableAdapter.Fill(Me.DataSet.tblFridges)
        center(Me, Panel1)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Try
            TblFridgesBindingSource.Filter = "fridgeID =" & txtID.Text

            If txtID.Text = Nothing Then
                TblFridgesBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RentedAtTextBox.Text = DateTimePicker1.Value.Date
        RentedToIDTextBox.Text = CID.Text
        RentedTextBox.Text = "Yes"
        up(44, 0)
        index(27)
        fll(27)
        ld(27)
        status("Fridge :-" & FridgeIDTextBox.Text & " rented to customer :-" & CustomerNameTextBox.Text)
    End Sub

    Private Sub RentTOTextBox_TextChanged(sender As Object, e As EventArgs) Handles RentTOTextBox.TextChanged

    End Sub

    Private Sub RentTOTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RentTOTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblCustomersBindingSource.Filter = "shopOrCompanyName LIKE '%" & RentTOTextBox.Text & "%'"
                RentTOTextBox.Text = ShopOrCompanyNameTextBox.Text
                CID.Text = CustomerIDTextBox.Text
                If RentedAtTextBox.Text = Nothing Then
                    RentedAtTextBox.Text = Date.Today
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CID_TextChanged(sender As Object, e As EventArgs) Handles CID.TextChanged

    End Sub

    Private Sub CID_KeyDown(sender As Object, e As KeyEventArgs) Handles CID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TblCustomersBindingSource.Filter = "customerID =" & CID.Text
                RentTOTextBox.Text = ShopOrCompanyNameTextBox.Text
                CID.Text = CustomerIDTextBox.Text
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        printP0(Panel1, "Rent fridge to customer")
    End Sub

    Private Sub chkS_CheckedChanged(sender As Object, e As EventArgs) Handles chkS.CheckedChanged
        If chkS.Checked = True Then
            MonthlyRentTextBox.ReadOnly = True
            MonthlyRentTextBox.Text = 0
        Else
            MonthlyRentTextBox.ReadOnly = False
            MonthlyRentTextBox.Clear()
        End If
    End Sub

    Private Sub MonthlyRentTextBox_TextChanged(sender As Object, e As EventArgs) Handles MonthlyRentTextBox.TextChanged

    End Sub

    Private Sub MonthlyRentTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MonthlyRentTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            RentedAtTextBox.Text = DateTimePicker1.Value.Date
            RentedToIDTextBox.Text = CID.Text
            RentedTextBox.Text = "Yes"
            up(44, 0)
            index(27)
            fll(27)
            ld(27)
            status("Fridge :-" & FridgeIDTextBox.Text & " rented to customer :-" & CustomerNameTextBox.Text)
        End If
    End Sub
End Class