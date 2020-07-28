

Imports CircularProgressBar

Public Class sales_target
    Private Sub Tbl_sales_targetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_sales_targetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub sales_target_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSales' table. You can move, or remove it, as needed.
        Me.TblSalesTableAdapter.Fill(Me.DataSet.tblSales)
        'TODO: This line of code loads data into the 'DataSet.tblInvoice' table. You can move, or remove it, as needed.
        Me.TblInvoiceTableAdapter.Fill(Me.DataSet.tblInvoice)
        'TODO: This line of code loads data into the 'DataSet.tbl_sales_target' table. You can move, or remove it, as needed.
        Me.Tbl_sales_targetTableAdapter.Fill(Me.DataSet.tbl_sales_target)
        'If Tbl_sales_targetBindingSource.Count = 0 Then
        '    Tbl_sales_targetBindingSource.AddNew()
        '    Validate()
        '    Tbl_sales_targetBindingSource.EndEdit()
        '    TableAdapterManager.UpdateAll(DataSet)
        'ElseIf Tbl_sales_targetBindingSource.Count > 1 Then
        '    While Tbl_sales_targetBindingSource.Count <> 0
        '        Tbl_sales_targetBindingSource.RemoveCurrent()
        '    End While
        '    Validate()
        '    Tbl_sales_targetBindingSource.EndEdit()
        '    TableAdapterManager.UpdateAll(DataSet)
        'End If
        auto(CompanyTextBox, DataSet.tblSuppliers, "supplierName")
        autoc(ComboBox2, DataSet.tblSuppliers, "supplierName")

        center(Me, Panel1)
        sethandle(JanuaryTextBox)
        sethandle(FebruaryTextBox)
        sethandle(MarchTextBox)
        sethandle(AprilTextBox)
        sethandle(MayTextBox)
        sethandle(JuneTextBox)
        sethandle(JulyTextBox)
        sethandle(AugustTextBox)
        sethandle(SeptemberTextBox)
        sethandle(OctoberTextBox)
        sethandle(NovemberTextBox)
        sethandle(DecemberTextBox)


        num(JanuaryTextBox)
        num(FebruaryTextBox)
        num(MarchTextBox)
        num(AprilTextBox)
        num(MayTextBox)
        num(JuneTextBox)
        num(JulyTextBox)
        num(AugustTextBox)
        num(SeptemberTextBox)
        num(OctoberTextBox)
        num(NovemberTextBox)
        num(DecemberTextBox)


        slt(YearTextBox, CompanyTextBox)
        num(YearTextBox)

        Dim thd As New Threading.Thread(New Threading.ThreadStart(Sub()
                                                                      For i As Integer = 2000 To 2100
                                                                          ComboBox1.Items.Add(i)
                                                                      Next
                                                                      ComboBox1.Text = Date.Today.Year
                                                                  End Sub))
        dt(Tbl_sales_targetDataGridView)
        thd.Start()
        Dim t As New Timer
        t.Interval = 2000
        Dim janury As Double, february As Double, march As Double, april As Double, may As Double, june As Double, july As Double, august As Double, september As Double, october As Double, november As Double, december As Double
        AddHandler t.Tick, Sub()

                               'Dim thd1 As New Threading.Thread(New Threading.ThreadStart(Sub()
                               Try
                                                                                                  '  TblSalesBindingSource.Filter = "year ='" & ComboBox1.Text & "' AND company ='" & ComboBox2.Text & "'"
                                                                                              Catch ex As Exception

                                                                                              End Try
                                                                                              For i As Integer = 0 To 11
                                                                                                  If i = 0 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '1/1/" & ComboBox1.Text & "' AND date <= '1/31/" & ComboBox1.Text & "'"
                                                                                                      janury = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 1 Then
                                                                                                      If DateTime.DaysInMonth(Integer.Parse(ComboBox1.Text), 2) = 28 Then
                                                                                                          TblSalesBindingSource.Filter = "date >= '2/1/" & ComboBox1.Text & "' AND date <= '2/28/" & ComboBox1.Text & "'"
                                                                                                      Else
                                                                                                          TblSalesBindingSource.Filter = "date >= '2/1/" & ComboBox1.Text & "' AND date <= '2/29/" & ComboBox1.Text & "'"
                                                                                                      End If
                                                                                                      february = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 2 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '3/1/" & ComboBox1.Text & "' AND date <= '3/31/" & ComboBox1.Text & "'"
                                                                                                      march = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 3 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '4/1/" & ComboBox1.Text & "' AND date <= '4/30/" & ComboBox1.Text & "'"
                                                                                                      april = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 4 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '5/1/" & ComboBox1.Text & "' AND date <= '5/30/" & ComboBox1.Text & "'"
                                                                                                      may = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 5 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '6/1/" & ComboBox1.Text & "' AND date <= '6/30/" & ComboBox1.Text & "'"
                                                                                                      june = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 6 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '7/1/" & ComboBox1.Text & "' AND date <= '7/31/" & ComboBox1.Text & "'"
                                                                                                      july = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 7 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '8/1/" & ComboBox1.Text & "' AND date <= '8/31/" & ComboBox1.Text & "'"
                                                                                                      august = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 8 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '9/1/" & ComboBox1.Text & "' AND date <= '9/30/" & ComboBox1.Text & "'"
                                                                                                      september = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 9 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '10/1/" & ComboBox1.Text & "' AND date <= '10/31/" & ComboBox1.Text & "'"
                                                                                                      october = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 10 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '11/1/" & ComboBox1.Text & "' AND date <= '11/30/" & ComboBox1.Text & "'"
                                                                                                      november = dtsum(TblSalesDataGridView, 0)
                                                                                                  ElseIf i = 11 Then
                                                                                                      TblSalesBindingSource.Filter = "date >= '12/1/" & ComboBox1.Text & "' AND date <= '12/31/" & ComboBox1.Text & "'"
                                                                                                      december = dtsum(TblSalesDataGridView, 0)
                                                                                                  End If
                                                                                              Next
                                                                                              set_max(prg_jan, JanuaryTextBox)
                                                                                              set_max(prg_feb, FebruaryTextBox)
                                                                                              set_max(prg_mar, MarchTextBox)
                                                                                              set_max(prg_apr, AprilTextBox)
                                                                                              set_max(prg_may, MayTextBox)
                                                                                              set_max(prg_jun, JuneTextBox)
                                                                                              set_max(prg_jul, JulyTextBox)
                                                                                              set_max(prg_aug, AugustTextBox)
                                                                                              set_max(prg_sep, SeptemberTextBox)
                                                                                              set_max(prg_oct, OctoberTextBox)
                                                                                              set_max(prg_nov, NovemberTextBox)
                                                                                              set_max(prg_dec, DecemberTextBox)

                                                                                              set_val(prg_jan, janury, JanuaryTextBox)
                                                                                              set_val(prg_feb, february, FebruaryTextBox)
                                                                                              set_val(prg_mar, march, MarchTextBox)
                                                                                              set_val(prg_apr, april, AprilTextBox)
                                                                                              set_val(prg_may, may, MayTextBox)
                                                                                              set_val(prg_jun, june, JuneTextBox)
                                                                                              set_val(prg_jul, july, JulyTextBox)
                                                                                              set_val(prg_aug, august, AugustTextBox)
                                                                                              set_val(prg_sep, september, SeptemberTextBox)
                                                                                              set_val(prg_oct, october, OctoberTextBox)
                                                                                              set_val(prg_nov, november, NovemberTextBox)
                                                                                              set_val(prg_dec, december, DecemberTextBox)
                               '      End Sub))

                               '  thd1.Start()
                           End Sub
        t.Start()
        Dim t1 As New Timer
        t1.Interval = 500
        AddHandler t1.Tick, Sub()
                                If Tbl_sales_targetBindingSource.Count = 0 Then
                                    pnl_dock.Enabled = False
                                Else
                                    pnl_dock.Enabled = True
                                End If
                            End Sub
    End Sub
    Function set_max(prg As CircularProgressBar.CircularProgressBar, t As TextBox)
        Try
            prg.Maximum = Convert.ToInt32(t.Text)
        Catch ex As Exception
            prg.Maximum = 0
        End Try
        Return Nothing
    End Function
    Function set_val(prg As CircularProgressBar.CircularProgressBar, val As Double, t As TextBox)

        Dim thd As New Threading.Thread(New Threading.ThreadStart(Sub()
                                                                      If t.Text = Nothing Then
                                                                          prg.Value = 0
                                                                          prg.Text = "0%"
                                                                      Else
                                                                          If Convert.ToInt32(val) <= Convert.ToInt32(t.Text) Then
                                                                              Try
                                                                                  prg.Value = Convert.ToInt32(val)
                                                                                  prg.Text = Convert.ToInt32((100 / (Double.Parse(t.Text) / val))) & "%"
                                                                              Catch ex As Exception
                                                                              End Try
                                                                          ElseIf Convert.ToInt32(val) > Convert.ToInt32(t.Text) Then
                                                                              prg.Value = Convert.ToInt32(t.Text)
                                                                              prg.Text = "100%+"
                                                                          End If

                                                                      End If
                                                                  End Sub))
        thd.Start()
        Return Nothing
    End Function

    Function sethandle(t As TextBox)
        AddHandler t.TextChanged, Sub()
                                      Validate()
                                      Tbl_sales_targetBindingSource.EndEdit()
                                      TableAdapterManager.UpdateAll(DataSet)
                                  End Sub
        Return Nothing
    End Function

    Private Sub CircularProgressBar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Validate()
        Tbl_sales_targetBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DataSet)
        Panel2.Enabled = False
        Button1.Text = "যুক্ত করুন"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Enabled = True
        Tbl_sales_targetBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Enabled = True
        Button1.Text = "সংশোধন করুন"
    End Sub

    Private Sub sales_target_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class