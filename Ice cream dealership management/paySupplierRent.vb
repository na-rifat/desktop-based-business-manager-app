Public Class paySupplierRent
    Private Sub TblRentSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblRentSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub paySupplierRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblFridges' table. You can move, or remove it, as needed.
        Me.TblFridgesTableAdapter.Fill(Me.DataSet.tblFridges)
        'TODO: This line of code loads data into the 'DataSet.tblRentS' table. You can move, or remove it, as needed.
        Me.TblRentSTableAdapter.Fill(Me.DataSet.tblRentS)
        center(Me, Panel1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RentTextBox_TextChanged(sender As Object, e As EventArgs) Handles RentTextBox.TextChanged
        'DueTextBox.Text = CType(RentTextBox.Text, Double) - CType(CompanyRentTextBox.Text, Double)
    End Sub

    Function chk()
        Dim i As Integer = 0



        Return 0
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = FridgeIDTextBox.Text
        Dim m As String = MTextBox.Text
        Dim y As String = YTextBox.Text
        Dim paid As Double = Double.Parse(paidRent.Text)
        Dim due As Double = Double.Parse(txtdue.Text)

        TblRentSTableAdapter.Fill(DataSet.tblRentS)
        Try
            TblRentSBindingSource.Filter = "fridgeID =" & id & " AND m =" & m & " AND y =" & y
        Catch ex As Exception

        End Try
        RentTextBox.Text = paid
        DueTextBox.Text = due


        Validate()
        TblRentSBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)

        index(27)
        fll(27)
        ld(27)


        status("Monthly company rent paid for fridge :-" & FridgeIDTextBox.Text)
    End Sub

    Private Sub paidRent_TextChanged(sender As Object, e As EventArgs) Handles paidRent.TextChanged
        Try
            If Double.Parse(paidRent.Text) > Double.Parse(CompanyRentTextBox.Text) Then
                paidRent.Text = DueTextBox.Text
            ElseIf Double.Parse(paidRent.Text) < 0 Then
                paidRent.Text = 0
            Else
                txtdue.Text = Double.Parse(DueTextBox.Text) - Double.Parse(paidRent.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TblRentSDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblRentSDataGridView.CellContentClick
        paidRent.Text = RentTextBox.Text
        txtdue.Text = DueTextBox.Text
    End Sub

    Private Sub TblRentSDataGridView_MouseEnter(sender As Object, e As EventArgs) Handles TblRentSDataGridView.MouseEnter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        ld(55)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 
        TblRentSTableAdapter.Fill(DataSet.tblRentS)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Validate()
        TblRentSBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        TblRentSBindingSource.Filter = "fridgeID =" & FridgeIDTextBox1.Text & " AND m=" & Today.Month & " AND y=" & Today.Year
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        If TblRentSBindingSource.Count = 0 AndAlso ((DueTextBox.Text = 0) = False) AndAlso (DueTextBox.Text = Nothing) Then
            If (Double.Parse(CompanyRentTextBox.Text) = 0) = False Then
                TblRentSBindingSource.AddNew()
                DateTextBox.Text = Date.Today
                FridgeIDTextBox.Text = FridgeIDTextBox1.Text
                MonthTextBox.Text = Format(Date.Today, "MMMMM")
                RentTextBox.Text = "0"
                DueTextBox.Text = CompanyRentTextBox.Text
                MTextBox.Text = Today.Month
                YTextBox.Text = Today.Year
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        TblRentSBindingSource.RemoveFilter()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) 
        TblRentSBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        index(27)
        fll(27)
        ld(27)
    End Sub
End Class