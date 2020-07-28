Public Class vehicleAccounts
    Private Sub vehicleAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.DataSet.tblSales)
        'TODO: This line of code loads data into the 'DataSet.tblVehicleAccounts' table. You can move, or remove it, as needed.
        Me.TblVehicleAccountsTableAdapter.Fill(Me.DataSet.tblVehicleAccounts)
        center(Me, Panel1)
    End Sub

    Private Sub TblVehicleAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblVehicleAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            TblVehicleAccountsBindingSource.Filter = "vehicleID =" & txtVehicleID.Text & " AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtVehicleID.Clear()
        TblVehicleAccountsBindingSource.RemoveFilter()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        printFP(Panel1, "Vehicle accounts")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblVehicleAccountsBindingSource.RemoveCurrent()
                Validate()
                TblVehicleAccountsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtVehicleID_TextChanged(sender As Object, e As EventArgs) Handles txtVehicleID.TextChanged
        Try
            TblVehicleAccountsBindingSource.Filter = "vehicleID =" & txtVehicleID.Text & " AND date >= '" & fromDt.Value.Date.ToString & "' AND date <= '" & toDt.Value.Date.ToString & "'"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        Validate()
        TblVehicleAccountsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub
End Class