Public Class Dashboard
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tbl_sales_target' table. You can move, or remove it, as needed.
        Me.Tbl_sales_targetTableAdapter.Fill(Me.DataSet.tbl_sales_target)
        'TODO: This line of code loads data into the 'DataSet.tbl_sales_target' table. You can move, or remove it, as needed.
        Me.Tbl_sales_targetTableAdapter.Fill(Me.DataSet.tbl_sales_target)
        Try
            'TODO: This line of code loads data into the 'DataSet.tblCompanySettings' table. You can move, or remove it, as needed.
            Me.TblCompanySettingsTableAdapter.Fill(Me.DataSet.tblCompanySettings)
            'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
            Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
            'TODO: This line of code loads data into the 'DataSet.tblProducts' table. You can move, or remove it, as needed.
            Me.TblProductsTableAdapter.Fill(Me.DataSet.tblProducts)
            'TODO: This line of code loads data into the 'DataSet.tblNotes' table. You can move, or remove it, as needed.
            Me.TblNotesTableAdapter.Fill(Me.DataSet.tblNotes)

        Catch ex As Exception

        End Try



    End Sub

    Private Sub TblNoticeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TblNotesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblNotesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_totalsale.Click

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles lbl_totalsale.MouseEnter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            dtn.Value = dtn.Value.AddDays(-1)
            TblNotesBindingSource.Filter = "date = '" & dtn.Value.Date & "'"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            dtn.Value = dtn.Value.AddDays(1)
            TblNotesBindingSource.Filter = "date = '" & dtn.Value.Date & "'"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            important()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTarget_Click(sender As Object, e As EventArgs) Handles lblTarget.Click

    End Sub
    Public Function p_value(i As Integer)
        prg.Value = 0
        prg.Value = i
        Return 0
    End Function

    Private Sub Dashboard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles GroupBox1.KeyDown

    End Sub

    Private Sub Dashboard_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub lbl_income_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class