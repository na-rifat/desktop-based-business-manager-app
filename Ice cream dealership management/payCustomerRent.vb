


Public Class payCustomerRent
    Private Sub TblRentCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblRentCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub payCustomerRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblFridges' table. You can move, or remove it, as needed.
        Me.TblFridgesTableAdapter.Fill(Me.DataSet.tblFridges)
        'TODO: This line of code loads data into the 'DataSet.tblRentC' table. You can move, or remove it, as needed.
        Me.TblRentCTableAdapter.Fill(Me.DataSet.tblRentC)
        'TODO: This line of code loads data into the 'DataSet.tblRentC' table. You can move, or remove it, as needed.
        Me.TblRentCTableAdapter.Fill(Me.DataSet.tblRentC)
        center(Me, Panel1)
    End Sub

    Private Sub TblRentCBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblRentCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = Integer.Parse(FridgeIDTextBox.Text)
        Dim m As String = MTextBox.Text
        Dim y As String = YTextBox.Text
        Dim paid As Double = Double.Parse(paidRent.Text)
        Dim due As Double = Double.Parse(txtdue.Text)

        TblRentCTableAdapter.Fill(DataSet.tblRentC)
        TblRentCBindingSource.Filter = "fridgeID =" & id & " AND m =" & m & " AND y =" & y

        paidRent.Text = paid
        DueTextBox.Text = due
        RentTextBox.Text = paidRent.Text

        Validate()
        TblRentCBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
        index(27)



        status("Monthly customer rent paid for fridge " & FridgeIDTextBox.Text)
    End Sub

    Private Sub RentTextBox_TextChanged(sender As Object, e As EventArgs) Handles RentTextBox.TextChanged


    End Sub

    Private Sub paidRent_TextChanged(sender As Object, e As EventArgs) Handles paidRent.TextChanged
        Try
            If Double.Parse(paidRent.Text) > Double.Parse(DueTextBox.Text) Then
                paidRent.Text = DueTextBox.Text
            Else
                txtdue.Text = Double.Parse(DueTextBox.Text) - Double.Parse(paidRent.Text)
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtdue_TextChanged(sender As Object, e As EventArgs) Handles txtdue.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        index(27)
        fll(27)
        ld(27)
    End Sub
End Class