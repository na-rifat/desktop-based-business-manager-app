Public Class manageFridge
    Private Sub TblFridgesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblFridgesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageFridge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblRentS' table. You can move, or remove it, as needed.
        Me.TblRentSTableAdapter.Fill(Me.DataSet.tblRentS)
        'TODO: This line of code loads data into the 'DataSet.tblRentS' table. You can move, or remove it, as needed.
        Me.TblRentSTableAdapter.Fill(Me.DataSet.tblRentS)
        'TODO: This line of code loads data into the 'DataSet.tblRentC' table. You can move, or remove it, as needed.
        Me.TblRentCTableAdapter.Fill(Me.DataSet.tblRentC)
        'TODO: This line of code loads data into the 'DataSet.tblFridges' table. You can move, or remove it, as needed.
        Me.TblFridgesTableAdapter.Fill(Me.DataSet.tblFridges)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(27, 0)
        up(27, 0)
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        Try
            If txtFilter.SelectedIndex = 3 Then
                TblFridgesBindingSource.Filter = "fridgeID =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 2 Then
                TblFridgesBindingSource.Filter = "date " & Today
            Else
                filter(27, txtFilter.SelectedIndex, 10, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblFridgesBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = Nothing Then
            TblFridgesBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PayCustomerRentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayCustomerRentToolStripMenuItem.Click
        index(56)
        fll(65)
        ld(56)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If MsgBox("Confirm fridge withdraw?" & vbNewLine & vbNewLine & "Fridge ID : " & FridgeIDTextBox.Text & vbNewLine & "Model : " & FridgeModelNoTextBox.Text & vbNewLine & "Company : " & SupplierNameTextBox.Text & vbNewLine & "Rented to : " & RentTOTextBox.Text, MsgBoxStyle.YesNo, "Fridge withdraw from customer confirmation") = MsgBoxResult.Yes Then
            RentTOTextBox.Clear()
            RentedToIDTextBox.Clear()
            RentedAtTextBox.Clear()
            RentedTextBox.Clear()
            Validate()
            TblFridgesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DataSet)
        End If
    End Sub

    Private Sub PayCompanyRentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayCompanyRentToolStripMenuItem.Click
        index(55)
        fll(55)
        ld(55)
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditCompanyInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCompanyInformationToolStripMenuItem.Click
        ab(3, 0)
    End Sub

    Private Sub EditCustomerInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCustomerInformationToolStripMenuItem.Click
        ab(44, 0)
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        printFP(Panel1, "Fridges")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

    End Sub
End Class