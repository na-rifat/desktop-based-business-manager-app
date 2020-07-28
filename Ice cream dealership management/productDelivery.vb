Public Class productDelivery
    Private Sub TblDeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblDeliveryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub productDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
        'TODO: This line of code loads data into the 'DataSet.tblVehicle' table. You can move, or remove it, as needed.
        Me.TblVehicleTableAdapter.Fill(Me.DataSet.tblVehicle)
        'TODO: This line of code loads data into the 'DataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.DataSet.tblCustomers)
        'TODO: This line of code loads data into the 'DataSet.tblDelivery' table. You can move, or remove it, as needed.
        Me.TblDeliveryTableAdapter.Fill(Me.DataSet.tblDelivery)
        cto(Me, Panel1)

        KeyPreview = True
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If MsgBox("Confirm this delivery?" & vbNewLine & vbNewLine & "Sale invoice : " & SaleInvoiceTextBox.Text & vbNewLine & "Customer name : " & CustomerNameTextBox.Text & vbNewLine & "Shipping address : " & ShippingAddressTextBox.Text, MsgBoxStyle.YesNo, "Product delivery confirmation") = MsgBoxResult.Yes Then
                ConfirmationTextBox.Text = "Confirmed"
                Validate()
                TblDeliveryBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(39, 0)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        rm(39, 0)
        up(39, 0)
        GroupBox1.Text = "New product delivery"
        Panel2.Enabled = False
        Button1.Text = "Add"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Panel2.Enabled = True
        SaleInvoiceTextBox.Select()
        nw(39, 0)
        GroupBox1.Text = "New product delivery"
        Button1.Text = "Add"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ConfirmationTextBox.Text = Nothing Then
            ConfirmationTextBox.Text = "Not confirmed"
        End If
        DateTextBox.Text = DateTimePicker1.Value.Date
        TimeTextBox.Text = DateTimePicker2.Value
        up(39, 0)
        Panel2.Enabled = False
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 0 Then
                TblDeliveryBindingSource.Filter = "saleInvoice =" & txtSearch.Text
            Else
                filter(39, txtFilter.SelectedIndex, 37, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblDeliveryBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printD(TblDeliveryDataGridView, "Product delivery")
    End Sub

    Private Sub CustomerNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerNameTextBox.TextChanged

    End Sub

    Private Sub CustomerNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblCustomersBindingSource.Filter = "customerName LIKE '%" & CustomerNameTextBox.Text & "%'"
                If TblCustomersBindingSource.Count > 0 Then
                    CustomerNameTextBox.Text = CustomerNameTextBox1.Text
                    ShippingAddressTextBox.Text = ShippingAddressTextBox1.Text
                    ContactNumberTextBox.Text = ContactNumberTextBox1.Text
                Else
                    CustomerNameTextBox.Clear()
                    ShippingAddressTextBox.Clear()
                    ContactNumberTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DriverNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles DriverNameTextBox.TextChanged

    End Sub

    Private Sub DriverNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DriverNameTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblVehicleBindingSource.Filter = "driverName LIKE '%" & DriverNameTextBox.Text & "%'"
                If TblVehicleBindingSource.Count > 0 Then
                    DriverNameTextBox.Text = DriverNameTextBox1.Text
                    VehicleIDTextBox.Text = VehicleIDTextBox1.Text
                Else
                    DriverNameTextBox.Clear()
                    VehicleIDTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VehicleIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles VehicleIDTextBox.TextChanged

    End Sub

    Private Sub VehicleIDTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles VehicleIDTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblVehicleBindingSource.Filter = "vehicleID =" & VehicleIDTextBox.Text
                If TblVehicleBindingSource.Count > 0 Then
                    DriverNameTextBox.Text = DriverNameTextBox1.Text
                    VehicleIDTextBox.Text = VehicleIDTextBox1.Text
                Else
                    DriverNameTextBox.Clear()
                    VehicleIDTextBox.Clear()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaleInvoiceTextBox_TextChanged(sender As Object, e As EventArgs) Handles SaleInvoiceTextBox.TextChanged

    End Sub

    Private Sub SaleInvoiceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SaleInvoiceTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                TblInvoiceBindingSource.Filter = "invoiceNo =" & SaleInvoiceTextBox.Text
                If TblInvoiceBindingSource.Count > 0 Then
                    CustomerNameTextBox.Text = CustomerNameTextBox2.Text
                    TblCustomersBindingSource.Filter = "customerID =" & CustomerIDTextBox.Text
                    ShippingAddressTextBox.Text = ShippingAddressTextBox1.Text
                    ContactNumberTextBox.Text = ContactNumberTextBox2.Text
                    DriverNameTextBox.Text = DriverNameTextBox2.Text
                    VehicleIDTextBox.Text = VehicleIDTextBox2.Text
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub productDelivery_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            Panel2.Enabled = True
            SaleInvoiceTextBox.Select()
            nw(39, 0)
            GroupBox1.Text = "New product delivery"
            Button1.Text = "Add"
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(39, 0)
            up(39, 0)
            GroupBox1.Text = "New product delivery"
            Panel2.Enabled = False
            Button1.Text = "Add"
        ElseIf e.Control = True AndAlso e.Shift = True AndAlso e.KeyCode = Keys.Enter AndAlso e.Alt = False Then
            Try
                If MsgBox("Confirm this delivery?" & vbNewLine & vbNewLine & "Sale invoice : " & SaleInvoiceTextBox.Text & vbNewLine & "Customer name : " & CustomerNameTextBox.Text & vbNewLine & "Shipping address : " & ShippingAddressTextBox.Text, MsgBoxStyle.YesNo, "Product delivery confirmation") = MsgBoxResult.Yes Then
                    ConfirmationTextBox.Text = "Confirmed"
                    Validate()
                    TblDeliveryBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(DataSet)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DeliveryChargeTextBox_TextChanged(sender As Object, e As EventArgs) Handles DeliveryChargeTextBox.TextChanged

    End Sub

    Private Sub DeliveryChargeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DeliveryChargeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker1.Select()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker2.Select()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker2_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ConfirmationTextBox.Text = Nothing Then
                ConfirmationTextBox.Text = "Not confirmed"
            End If
            DateTextBox.Text = DateTimePicker1.Value.Date
            TimeTextBox.Text = DateTimePicker2.Value
            up(39, 0)
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub chk_show_pending_CheckedChanged(sender As Object, e As EventArgs) Handles chk_show_pending.CheckedChanged
        If chk_show_pending.Checked = True Then
            TblDeliveryBindingSource.Filter = "confirmation LIKE '%Not confirmed%'"
        Else
            TblDeliveryBindingSource.RemoveFilter()
            txtSearch.Clear()
        End If
    End Sub
End Class