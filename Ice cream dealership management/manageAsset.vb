Public Class manageAsset
    Private Sub TblassetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblassetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub manageAsset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblasset' table. You can move, or remove it, as needed.
        Me.TblassetTableAdapter.Fill(Me.DataSet.tblasset)
        cto(Me, Panel1)
        KeyPreview = True
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        nw(22, 0)
        Panel2.Enabled = True
        AssetNameTextBox.Select()

        chkN.Checked = False
        Button2.Enabled = True
        GroupBox1.Text = "New withdraw"
        Button1.Text = "Add"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rdnN.Checked = True Then
            AssetConditionTextBox.Text = "New"
        ElseIf rdnO.Checked = True Then
            AssetConditionTextBox.Text = "Used"
        End If
        If chkN.Checked = True Then
            BcTextBox.Text = "Yes"
        Else
            BcTextBox.Text = "No"
        End If


        IssueDateTextBox.Text = dtp.Value.Date
        up(22, 0)
        Panel2.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        rm(22, 0)
        up(22, 0)

        Button2.Enabled = False
        Button1.Text = "Add"
        Panel2.Enabled = False
        GroupBox1.Text = "New asset"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ab(22, 0)
        AssetNameTextBox.Select()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If txtFilter.Selected = 1 Then
                TblassetBindingSource.Filter = "issueDate ='" & txtSearch.Text & "'"
            Else
                filter(22, 42, txtFilter.SelectedIndex, 0, txtSearch.Text)
            End If
            If txtSearch.Text = Nothing Then
                TblassetBindingSource.RemoveFilter()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        printD(TblassetDataGridView, "Asset")
    End Sub

    Private Sub IssueDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles IssueDateTextBox.TextChanged

    End Sub

    Private Sub manageAsset_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.N Then
            nw(22, 0)
            Panel2.Enabled = True
            AssetNameTextBox.Select()

            chkN.Checked = False
            Button2.Enabled = True
            GroupBox1.Text = "New withdraw"
            Button1.Text = "Add"
        ElseIf e.Control = True AndAlso e.KeyCode = Keys.Delete Then
            rm(22, 0)
            up(22, 0)

            Button2.Enabled = False
            Button1.Text = "Add"
            Panel2.Enabled = False
            GroupBox1.Text = "New asset"

        End If
    End Sub

    Private Sub PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles PriceTextBox.TextChanged

    End Sub

    Private Sub PriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PriceTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rdnN.Checked = True Then
                AssetConditionTextBox.Text = "New"
            ElseIf rdnO.Checked = True Then
                AssetConditionTextBox.Text = "Used"
            End If
            If chkN.Checked = True Then
                BcTextBox.Text = "Yes"
            Else
                BcTextBox.Text = "No"
            End If


            IssueDateTextBox.Text = dtp.Value.Date
            up(22, 0)
            Panel2.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged

    End Sub

    Private Sub dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp.KeyDown
        If e.KeyCode = Keys.Enter Then
            rdnN.Select()
        End If
    End Sub

    Private Sub rdnN_CheckedChanged(sender As Object, e As EventArgs) Handles rdnN.CheckedChanged

    End Sub

    Private Sub rdnN_KeyDown(sender As Object, e As KeyEventArgs) Handles rdnN.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkN.Select()
        End If
    End Sub

    Private Sub rdnO_CheckedChanged(sender As Object, e As EventArgs) Handles rdnO.CheckedChanged

    End Sub

    Private Sub rdnO_KeyDown(sender As Object, e As KeyEventArgs) Handles rdnO.KeyDown
        If e.KeyCode = Keys.Enter Then
            chkN.Select()
        End If
    End Sub

    Private Sub chkN_CheckedChanged(sender As Object, e As EventArgs) Handles chkN.CheckedChanged

    End Sub

    Private Sub chkN_KeyDown(sender As Object, e As KeyEventArgs) Handles chkN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rdnN.Checked = True Then
                AssetConditionTextBox.Text = "New"
            ElseIf rdnO.Checked = True Then
                AssetConditionTextBox.Text = "Used"
            End If
            If chkN.Checked = True Then
                BcTextBox.Text = "Yes"
            Else
                BcTextBox.Text = "No"
            End If

            IssueDateTextBox.Text = dtp.Value.Date
            up(22, 0)
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        upp(ImagePictureBox)
    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged

    End Sub

    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuantityTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If QuantityTextBox.Text = Nothing Then
                QuantityTextBox.Text = 1
            End If
        End If
    End Sub

    Private Sub UnitpriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles UnitpriceTextBox.TextChanged
        PriceTextBox.Text = Double.Parse(QuantityTextBox.Text) * Double.Parse(UnitpriceTextBox.Text)
    End Sub

    Private Sub UnitpriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UnitpriceTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If UnitpriceTextBox.Text = Nothing Then
                UnitpriceTextBox.Text = 0
            End If
        End If
    End Sub

    Private Sub AssetNameLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class