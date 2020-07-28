Imports System.ComponentModel

Public Class employeeAttendence
    Private Sub TblAttendenceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblAttendenceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub employeeAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.DataSet.tblEmployee)
        'TODO: This line of code loads data into the 'DataSet.tblAttendence' table. You can move, or remove it, as needed.
        Me.TblAttendenceTableAdapter.Fill(Me.DataSet.tblAttendence)
        cto(Me, Panel1)
    End Sub

    Private Sub TblAttendenceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblAttendenceDataGridView.CellContentClick
        If DateTextBox.Text = Date.Today = False Then
            chk.Enabled = False
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chk.CheckedChanged
        If chk.Checked = True Then
            AttendedTextBox.Text = "Yes"
        Else
            AttendedTextBox.Text = "No"
        End If
        Validate()
        TblAttendenceBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        TblAttendenceBindingSource.Filter = "employeeID LIKE '%" & IdTextBox.Text & "%' OR date LIKE '%" & Date.Today & "%'"

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        TblAttendenceBindingSource.AddNew()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs)
        TblEmployeeBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Validate()
        TblAttendenceBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub TblAttendenceDataGridView_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles TblAttendenceDataGridView.RowStateChanged

    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 1 Then
                TblAttendenceBindingSource.Filter = "employeeID =" & txtSearch.Text
            ElseIf txtFilter.SelectedIndex = 0 Then
                TblAttendenceBindingSource.Filter = "date ='" & txtSearch.Text & "'"
            ElseIf txtFilter.SelectedIndex = 2 Then
                filter(15, txtFilter.SelectedIndex, 0, 0, txtSearch.Text)
            End If
        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblAttendenceBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        printP0(Panel1, "Employee attendence")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        While TblAttendenceBindingSource.Count <> 0
            TblAttendenceBindingSource.RemoveCurrent()

        End While
        Validate()
        TblAttendenceBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 
        ld(15)
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblAttendenceBindingSource.RemoveCurrent()
                Validate()
                TblAttendenceBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class