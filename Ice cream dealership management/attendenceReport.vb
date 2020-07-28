Public Class attendenceReport
    Private Sub TblAttendenceReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub attendenceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSet.tblAttendence' table. You can move, or remove it, as needed.
        Me.TblAttendenceTableAdapter.Fill(Me.DataSet.tblAttendence)
        'TODO: This line of code loads data into the 'DataSet.tblAttendence' table. You can move, or remove it, as needed.
        Me.TblAttendenceTableAdapter.Fill(Me.DataSet.tblAttendence)
        'TODO: This line of code loads data into the 'DataSet.tblAttendenceReport' table. You can move, or remove it, as needed.
        Me.TblAttendenceReportTableAdapter.Fill(Me.DataSet.tblAttendenceReport)
        cto(Me, Panel1)
    End Sub

    Private Sub TblAttendenceReportBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblAttendenceReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        fromDt.ResetText()
        toDt.ResetText()
        txtSearch.Clear()
        TblAttendenceReportBindingSource.RemoveFilter()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.SelectedIndex = 1 Then
                TblAttendenceReportBindingSource.Filter = "employeeID =" & txtSearch.Text & " AND [date ] >=" & "'" & fromDt.Value.Date.ToString & "'" & "AND [date ] <= " & "'" & toDt.Value.Date.ToString & "'"
            Else
                TblAttendenceReportBindingSource.Filter = "employeeName LIKE '%" & txtSearch.Text & "%' AND [date ] >=" & "'" & fromDt.Value.Date.ToString & "'" & "AND [date ] <= " & "'" & toDt.Value.Date.ToString & "'"
            End If

        Catch ex As Exception

        End Try
        If txtSearch.Text = Nothing Then
            TblAttendenceReportBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub AttendenceStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TblAttendenceReportBindingSource.Count > 0 Then
                Dim total As Integer = 0
                Dim attend As Integer = 0
                Dim absent As Integer = 0
                TblAttendenceReportBindingSource.Filter = "employeeID =" & EmployeeIDTextBox2.Text & " AND [date ] <=" & toDt.Value.Date & " AND [date ] >=" & fromDt.Value.Date
                total = TblAttendenceReportBindingSource.Count
                TblAttendenceReportBindingSource.Filter = "employeeID =" & EmployeeIDTextBox2.Text & " AND attended LIKE '%Yes%' ND [date ] <=" & toDt.Value.Date & " AND [date ] >=" & fromDt.Value.Date
                attend = TblAttendenceReportBindingSource.Count
                TblAttendenceReportBindingSource.Filter = "employeeID =" & EmployeeIDTextBox2.Text & " AND attended LIKE '%No%' ND [date ] <=" & toDt.Value.Date & " AND [date ] >=" & fromDt.Value.Date
                absent = TblAttendenceReportBindingSource.Count
                MsgBox("Attendence status" & vbNewLine & vbNewLine & "Employee name : " & EmployeeNameTextBox.Text & vbNewLine & "Employee ID : " & EmployeeIDTextBox2.Text & vbNewLine & "Total working days : " & total & vbNewLine & "Total attended : " & attend & vbNewLine & "Total absent : " & absent, MsgBoxStyle.OkOnly, "Employee attendence report")
                txtSearch.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) 
        While TblAttendenceReportBindingSource.Count <> 0
            TblAttendenceReportBindingSource.RemoveCurrent()
        End While
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        fll(8)
        ld(8)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        TblAttendenceReportBindingSource.Filter = "[date ] LIKE '%" & Today & "%'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        TblAttendenceReportBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) 
        TblAttendenceReportTableAdapter.Fill(DataSet.tblAttendenceReport)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) 
        TblAttendenceReportBindingSource.RemoveFilter()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        Validate()
        TblAttendenceReportBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) 
        TblAttendenceBindingSource.RemoveFilter()
        TblAttendenceBindingSource.MoveFirst()

        For a = 0 To TblAttendenceBindingSource.Count - 1
            TblAttendenceReportBindingSource.AddNew()

            EmployeeNameTextBox1.Text = EmployeeNameTextBox.Text
            EmployeeIDTextBox1.Text = EmployeeIDTextBox.Text
            AttendedTextBox1.Text = AttendedTextBox.Text
            Date_TextBox.Text = Date.Today

            TblAttendenceBindingSource.MoveNext()
        Next
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = MsgBoxResult.Yes Then
                TblAttendenceReportBindingSource.RemoveCurrent()
                Validate()
                TblAttendenceReportBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DataSet)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class