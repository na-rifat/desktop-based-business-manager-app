Imports CoreAudioApi



Module all
    Dim sVol As Integer = GetVol()

    Dim prg As New ProgressBar
    Public newsale_timer As New Timer
    Public newpurchase_timer As New Timer
    Dim commission_timer As New Timer
    Dim sale_checker As New Timer
    Dim purchase_checker As New Timer
    Dim stock_timer As New Timer
    Dim damage_timer As New Timer
    Dim manage_expense_timer As New Timer
    Dim expense_report_timer As New Timer
    Dim employee_accounts_timer As New Timer
    Dim due_report_timer As New Timer
    Dim company_accounts_timer As New Timer
    Dim customer_accounts_timer As New Timer
    Dim vehicle_accounts_timer As New Timer
    Dim sales_report_timer As New Timer
    Dim purchase_report_timer As New Timer
    Dim product_commission_timer As New Timer
    Dim manage_income_timer As New Timer
    Dim sell_commission_timer As New Timer
    Dim discount_timer As New Timer
    Dim product_timer As New Timer
    Dim vehicle_account_timer As New Timer
    Dim asset_timer As New Timer
    Dim withdraw_timer As New Timer
    Dim bank_acc_timer As New Timer
    Dim transaction_timer As New Timer

    Public current_index As Integer = 0
    Function setVol(i As Integer)
        Try
            Dim DevEnum As New MMDeviceEnumerator
            Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
            device.AudioEndpointVolume.MasterVolumeLevelScalar = i / 100.0F
            Return 0
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Sub money_index(dt As DataGridView, i As Integer)
        dt.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub

    Function GetVol() As Integer
        Try
            Dim MasterMin As Integer = 0
            Dim DevEnum As New MMDeviceEnumerator
            Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
            Dim Vol As Integer = 0

            With device.AudioEndpointVolume
                Vol = CInt(.MasterVolumeLevelScalar * 100)
                If Vol < MasterMin Then
                    Vol = MasterMin / 100
                End If
            End With

            Return Vol

        Catch ex As Exception

        End Try
        Return 0
    End Function


    Public pinconfirmation As New pinc
    Public addbank As New addBank
    Public adddamage As New addDamageProducts
    Public withdraw As New withdraw
    Public addemployee As New addEmployee
    Public addfridge As New addFridge
    Public addnote As New addNote
    Public addproduct As New addProducts
    Public addsupplier As New addSupplier
    Public assetreport As New asset
    Public attendencereport As New attendenceReport
    Public companysettting As New companySettings
    Public createuser As New createUser
    Public damageFridge As New damageFridge
    Public dashboard As New Dashboard
    Public duereport As New dueReport
    Public employeeaccount As New employeeAccounts
    Public employeeattendence As New employeeAttendence
    Public expensecategory As New exepenseCategory
    Public expensereport As New expenseReport
    Public useraccounts As New userRoles
    Public managebank As New frmBanks
    Public incomecategory As New incomeCategory
    Public managesale As New Manage_sale
    Public manageasset As New manageAsset
    Public managebankaccount As New manageBankAccounts
    Public managedamage As New manageDamageProducts
    Public manageemployee As New manageEmployee
    Public manageexpense As New manageExepense
    Public managefridge As New manageFridge
    Public manageincome As New manageIncome
    Public manageproduct As New manageProducts
    Public managepurchase As New managePurchase
    Public managestock As New manageStock
    Public managesupplier As New manageSupplier
    Public managetransaction As New manageTransaction
    Public newexpense As New newExpense
    Public newincome As New newIncome
    Public newpurchase As New newPurchase
    Public newsale As New newSale
    Public productcommission As New productCommission
    Public productdelivery As New productDelivery
    Public productcategory As New productsCategory
    Public profitcalculator As New profitCalculator
    Public purchasereport As New purchaseReport
    Public rentfrom As New rentFromSupplier
    Public rentto As New rentToCustomer
    Public returndamage As New returnDamage
    Public salesreport As New salesReport
    Public supplieraccount As New supplierAccounts
    Public login As New login
    Public customeraccount As New customerAccounts
    Public transactionreport As New transactionReport
    Public managecustomer As New manageCustomer
    Public addcustomer As New addCustomer
    Public paycustomer As New payCustomerRent
    Public paysupplier As New paySupplierRent
    Public returndamagefridge As New returnDamageFridge
    Public managesignboard As New signBoard
    Public myacc As New myaccount
    Public newvehicle As New newVehicle
    Public managevehicle As New manageVehicle
    Public vehicleaccounts As New vehicleAccounts
    Public frmmain As New Form1
    Public purchaseseason As New purchaseSeason
    Public saleseason As New salesSeason
    Public backup As New backup
    Public cashreport As New cashReport
    Public sell_on_commisssion As New sell_on_commission
    Public documents As New documents
    Public discounts As New discount
    Public sold_product As New sold_products
    Public salestarget As New sales_target
    Public clear_datatable As New clear_data

    'current form
    Public cf As Form


    Function index(i)

        If IsNothing(cf) = True Then
            cf = Nothing
        End If
        If i = 0 Then
            cf = addbank
        ElseIf i = 1 Then
            cf = adddamage
        ElseIf i = 2 Then
            cf = addemployee
        ElseIf i = 3 Then
            cf = addfridge
        ElseIf i = 4 Then
            cf = addnote
        ElseIf i = 5 Then
            cf = addproduct
        ElseIf i = 6 Then
            cf = addsupplier
        ElseIf i = 7 Then
            cf = assetreport
        ElseIf i = 8 Then
            cf = attendencereport
        ElseIf i = 9 Then
            cf = companySettings
        ElseIf i = 10 Then
            cf = createuser
        ElseIf i = 11 Then
            cf = damageFridge
        ElseIf i = 12 Then
            cf = dashboard
        ElseIf i = 13 Then
            cf = duereport
        ElseIf i = 14 Then
            cf = employeeaccount
        ElseIf i = 15 Then
            cf = employeeattendence
        ElseIf i = 16 Then
            cf = expensecategory
        ElseIf i = 17 Then
            cf = expensereport
        ElseIf i = 18 Then
            cf = Form1
        ElseIf i = 19 Then
            cf = managebank
        ElseIf i = 20 Then
            cf = incomecategory
        ElseIf i = 21 Then
            cf = managesale
        ElseIf i = 22 Then
            cf = manageasset
        ElseIf i = 23 Then
            cf = managebankaccount
        ElseIf i = 24 Then
            cf = managedamage
        ElseIf i = 25 Then
            cf = manageemployee
        ElseIf i = 26 Then
            cf = manageexpense
        ElseIf i = 27 Then
            cf = managefridge
        ElseIf i = 28 Then
            cf = manageincome
        ElseIf i = 29 Then
            cf = manageproduct
        ElseIf i = 30 Then
            cf = managepurchase
        ElseIf i = 31 Then
            cf = managestock
        ElseIf i = 32 Then
            cf = managesupplier
        ElseIf i = 33 Then
            cf = managetransaction
        ElseIf i = 34 Then
            cf = newexpense
        ElseIf i = 35 Then
            cf = newincome
        ElseIf i = 36 Then
            cf = newpurchase
        ElseIf i = 37 Then
            cf = newsale
        ElseIf i = 38 Then
            cf = productcommission
        ElseIf i = 39 Then
            cf = productdelivery
        ElseIf i = 40 Then
            cf = productcategory
        ElseIf i = 41 Then
            cf = profitcalculator
        ElseIf i = 42 Then
            cf = purchasereport
        ElseIf i = 43 Then
            cf = rentfrom
        ElseIf i = 44 Then
            cf = rentto
        ElseIf i = 45 Then
            cf = returndamage
        ElseIf i = 46 Then
            cf = salesreport
        ElseIf i = 47 Then
            cf = supplieraccount
        ElseIf i = 48 Then
            cf = managesignboard
        ElseIf i = 49 Then
            cf = useraccounts
        ElseIf i = 50 Then
            cf = login
        ElseIf i = 51 Then
            cf = customeraccount
        ElseIf i = 52 Then
            cf = transactionreport
        ElseIf i = 53 Then
            cf = managecustomer
        ElseIf i = 54 Then
            cf = addcustomer
        ElseIf i = 55 Then
            cf = paysupplier
        ElseIf i = 56 Then
            cf = paycustomer
        ElseIf i = 57 Then
            cf = returndamagefridge
        ElseIf i = 58 Then
            'blank
        ElseIf i = 59 Then
            'blank
        ElseIf i = 60 Then
            cf = withdraw
        ElseIf i = 61 Then
            cf = myacc
        ElseIf i = 62 Then
            cf = newvehicle
        ElseIf i = 63 Then
            cf = managevehicle
        ElseIf i = 64 Then
            cf = vehicleaccounts
        ElseIf i = 65 Then
            cf = backup
        ElseIf i = 66 Then
            cf = pinconfirmation
        ElseIf i = 67 Then
            cf = purchaseseason
        ElseIf i = 68 Then
            cf = saleseason
        ElseIf i = 69 Then
            cf = cashreport
        ElseIf i = 70 Then
            cf = sell_on_commisssion
        ElseIf i = 71 Then
        ElseIf i = 72 Then
            cf = discounts
        ElseIf i = 80 Then
            cf = sold_product
        ElseIf i = 81 Then
            cf = salestarget
        ElseIf i = 82 Then
            cf = clear_datatable
        End If
        current_index = i
        Form1.pnlMain.Controls.Clear()
        cf.TopLevel = False
        cf.AutoScroll = True
        cf.Dock = DockStyle.Fill
        cf.Show()
        Form1.pnlMain.Controls.Add(cf)
        cf.Select()

        Return 0
    End Function


    '0'1'2'3'4'5'6'7'8'9'10'11'12'13'14'15'16'17'18'19'20'21'22'23'24'25'26'27'28'29'30'31'32'33'34'35'36'37'38'39'40'41'42'43'44'45'46'47'48'49'50

    Public Function dt(d As DataGridView)
        Try
            d.EnableHeadersVisualStyles = False
            d.DefaultCellStyle.BackColor = Color.White
            d.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
            d.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
            d.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray
            d.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            d.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            d.DefaultCellStyle.ForeColor = Color.Black
            d.GridColor = Color.Black 'd.DefaultCellStyle.BackColor
            d.BackgroundColor = Color.White
            d.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            d.ColumnHeadersDefaultCellStyle.Padding = New Padding(2, 2, 2, 2)
            '    d.RowsDefaultCellStyle.Padding = New Padding(0, 0, 0, 0)
            d.RowHeadersVisible = False
            d.AllowUserToAddRows = False
            d.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            d.DefaultCellStyle.Padding = New Padding(20, 20, 20, 20)
            d.ReadOnly = True
            d.BorderStyle = BorderStyle.None
            d.RowTemplate.Height = 100
            d.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
            d.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
            d.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            d.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            d.FirstDisplayedScrollingRowIndex = d.RowCount - 1
            'If d.Name = manageproduct.TblProductsDataGridView.Name Then
            '    d.DefaultCellStyle.SelectionBackColor = Color.Yellow
            '    d.DefaultCellStyle.SelectionForeColor = Color.Black
            'ElseIf d.Parent.Parent.Parent.Parent.Name = "pnlMain" Then
            '    d.BackgroundColor = Color.FromArgb(21, 27, 46)
            '    d.DefaultCellStyle.BackColor = Color.White
            '    d.DefaultCellStyle.ForeColor = Color.Black
            '    d.GridColor = Color.Black
            '    d.DefaultCellStyle.SelectionBackColor = Color.Gray
            '    d.DefaultCellStyle.SelectionForeColor = Color.White
            'Else
            '    d.DefaultCellStyle.SelectionBackColor = Color.SteelBlue
            'End If

        Catch ex As Exception
            '    MsgBox(ex.Message)
            '    d.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
            '    d.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
            '    d.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
            '    d.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End Try





        Return 0
    End Function
    Public Function dtd(d As DataGridView)
        Try
            d.EnableHeadersVisualStyles = False
            d.DefaultCellStyle.BackColor = Color.SteelBlue
            d.Font = New Font("Verdana", 10, FontStyle.Regular)
            d.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
            d.ColumnHeadersDefaultCellStyle.BackColor = Color.White
            d.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            d.DefaultCellStyle.ForeColor = Color.Black
            d.GridColor = d.BackgroundColor

            d.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            d.ColumnHeadersDefaultCellStyle.Padding = New Padding(0, 5, 0, 5)
            d.RowsDefaultCellStyle.Padding = New Padding(2, 0, 2, 0)

            d.RowHeadersVisible = False
            d.ReadOnly = True
            d.ColumnHeadersVisible = True
            d.AllowUserToAddRows = False
            d.BorderStyle = BorderStyle.None

            Dim t As New Timer
            t.Start()
            AddHandler t.Tick, Function()
                                   For a = 0 To d.Rows.Count - 1
                                       d.Rows(a).Height = 40
                                   Next

                                   Return 0
                               End Function
        Catch ex As Exception

        End Try
        Return 0

    End Function

    Public Function dtd1(d As DataGridView)
        Try
            d.EnableHeadersVisualStyles = False
            d.DefaultCellStyle.BackColor = Color.Silver
            d.Font = New Font("Verdana", 10, FontStyle.Regular)
            d.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 10)

            If d.Name = dashboard.TblInvoiceDataGridView.Name Then
                d.DefaultCellStyle.BackColor = Color.FromArgb(0, 96, 128)
                d.DefaultCellStyle.ForeColor = Color.White
                d.GridColor = d.BackgroundColor
            ElseIf d.Name = dashboard.TblProductsDataGridView.Name Then
                d.DefaultCellStyle.BackColor = Color.FromArgb(255, 92, 51)
                d.DefaultCellStyle.ForeColor = Color.White
                d.GridColor = d.BackgroundColor
            End If
            d.ColumnHeadersDefaultCellStyle.BackColor = Color.White
            d.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black

            'd.GridColor = Color.White

            d.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            d.ColumnHeadersDefaultCellStyle.Padding = New Padding(0, 5, 0, 5)
            d.RowsDefaultCellStyle.Padding = New Padding(0, 5, 0, 5)
            'd.Columns(2).DefaultCellStyle.Padding = New Padding(0, 0, 0, 0)
            d.RowHeadersVisible = False
            d.ReadOnly = True
            d.ColumnHeadersVisible = True
            d.AllowUserToAddRows = False
            d.BorderStyle = BorderStyle.None


            Dim t As New Timer
            t.Start()
            AddHandler t.Tick, Function()
                                   For a = 0 To d.Rows.Count - 1
                                       d.Rows(a).Height = 30
                                   Next

                                   Return 0
                               End Function
        Catch ex As Exception

        End Try

        Return 0
    End Function
    Public Function dtp(n)


        Return 0
    End Function
    Public Function stock_search()
        'stock indicator
        For a As Integer = 0 To manageproduct.TblProductsBindingSource.Count - 1
            If Integer.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(4).Value.ToString) <= Integer.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(7).Value.ToString) AndAlso Integer.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(4).Value.ToString) > 0 Then
                manageproduct.TblProductsDataGridView.Rows(a).DefaultCellStyle.BackColor = Color.Pink
            ElseIf Integer.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(4).Value.ToString) = 0 Then
                manageproduct.TblProductsDataGridView.Rows(a).DefaultCellStyle.BackColor = Color.Red
            Else
                manageproduct.TblProductsDataGridView.Rows(a).DefaultCellStyle.BackColor = Color.Green
            End If
            ' manageproduct.TblProductsBindingSource.MoveNext()
        Next
        ''''''''
        Return 0
    End Function
    Function up(m, s)
        Try
            If m = 0 Then
                addbank.Validate()
                addbank.TblBanksBindingSource.EndEdit()
                addbank.TableAdapterManager.UpdateAll(addbank.DataSet)
            ElseIf m = 1 Then
                adddamage.Validate()
                adddamage.TblDamageProductsBindingSource.EndEdit()
                adddamage.TableAdapterManager.UpdateAll(adddamage.DataSet)
            ElseIf m = 2 Then
                addemployee.Validate()
                addemployee.TblEmployeeBindingSource.EndEdit()
                addemployee.TableAdapterManager.UpdateAll(addemployee.DataSet)
            ElseIf m = 3 Then
                addfridge.Validate()
                addfridge.TblFridgesBindingSource.EndEdit()
                addfridge.TableAdapterManager.UpdateAll(addfridge.DataSet)
            ElseIf m = 4 Then
                addnote.Validate()
                addnote.TblNotesBindingSource.EndEdit()
                addnote.TableAdapterManager.UpdateAll(addnote.DataSet)
            ElseIf m = 5 Then
                addproduct.Validate()
                addproduct.TblProductsBindingSource.EndEdit()
                addproduct.TableAdapterManager.UpdateAll(addproduct.DataSet)
            ElseIf m = 6 Then
                addsupplier.Validate()
                addsupplier.TblSuppliersBindingSource.EndEdit()
                addsupplier.TableAdapterManager.UpdateAll(addsupplier.DataSet)
            ElseIf m = 7 Then
                'blank
            ElseIf m = 8 Then
                attendencereport.Validate()
                attendencereport.TblAttendenceBindingSource.EndEdit()
                attendencereport.TableAdapterManager.UpdateAll(attendencereport.DataSet)
            ElseIf m = 9 Then
                companysettting.Validate()
                companysettting.TblCompanySettingsBindingSource.EndEdit()
                companysettting.TableAdapterManager.UpdateAll(companysettting.DataSet)
            ElseIf m = 10 Then
                createuser.Validate()
                createuser.TblUserBindingSource.EndEdit()
                createuser.TableAdapterManager.UpdateAll(createuser.DataSet)
            ElseIf m = 11 Then
                damageFridge.Validate()
                damageFridge.TblDamageFridgeBindingSource.EndEdit()
                damageFridge.TableAdapterManager.UpdateAll(damageFridge.DataSet)
            ElseIf m = 12 Then
                'no need
            ElseIf m = 13 Then
                duereport.Validate()
                duereport.TblDuesReportBindingSource.EndEdit()
                duereport.TableAdapterManager.UpdateAll(duereport.DataSet)
            ElseIf m = 14 Then
                employeeaccount.Validate()
                employeeaccount.TblEmployeeAccountsBindingSource.EndEdit()
                employeeaccount.TableAdapterManager.UpdateAll(employeeaccount.DataSet)
            ElseIf m = 15 Then
                employeeattendence.Validate()
                employeeattendence.TblAttendenceBindingSource.EndEdit()
                employeeattendence.TableAdapterManager.UpdateAll(employeeattendence.DataSet)
            ElseIf m = 16 Then
                expensecategory.Validate()
                If s = 0 Then
                    expensecategory.TblExpenseCategoryBindingSource.EndEdit()
                ElseIf s = 1 Then
                    expensecategory.TblExpenseSubcategoryBindingSource.EndEdit()
                End If
                expensecategory.TableAdapterManager.UpdateAll(expensecategory.DataSet)
            ElseIf m = 17 Then
                expensereport.Validate()
                expensereport.TblExpenseReportBindingSource.EndEdit()
                expensereport.TableAdapterManager.UpdateAll(expensereport.DataSet)
            ElseIf m = 18 Then
                'blank
            ElseIf m = 19 Then
                managebank.Validate()
                managebank.TblBanksBindingSource.EndEdit()
                managebank.TableAdapterManager.UpdateAll(managebank.DataSet)
            ElseIf m = 20 Then
                incomecategory.Validate()
                If s = 0 Then
                    incomecategory.TblIncomeCategoryBindingSource.EndEdit()
                ElseIf s = 1 Then
                    incomecategory.TblIncomeSubcategoryBindingSource.EndEdit()
                End If
                incomecategory.TableAdapterManager.UpdateAll(incomecategory.DataSet)
            ElseIf m = 21 Then
                managesale.Validate()
                If s = 0 Then
                    managesale.TblInvoiceBindingSource.EndEdit()
                ElseIf s = 1 Then
                    managesale.TblSalesBindingSource.EndEdit()
                End If
                managesale.TableAdapterManager.UpdateAll(managesale.DataSet)
            ElseIf m = 22 Then
                manageasset.Validate()
                manageasset.TblassetBindingSource.EndEdit()
                manageasset.TableAdapterManager.UpdateAll(manageasset.DataSet)
            ElseIf m = 23 Then
                managebankaccount.Validate()
                managebankaccount.TblBankAccountsBindingSource.EndEdit()
                managebankaccount.TableAdapterManager.UpdateAll(managebankaccount.DataSet)
            ElseIf m = 24 Then
                managedamage.Validate()
                managedamage.TblDamageProductsBindingSource.EndEdit()
                managedamage.TableAdapterManager.UpdateAll(managedamage.DataSet)
            ElseIf m = 25 Then
                manageemployee.Validate()
                manageemployee.TblEmployeeBindingSource.EndEdit()
                manageemployee.TableAdapterManager.UpdateAll(manageemployee.DataSet)
            ElseIf m = 26 Then
                manageexpense.Validate()
                manageexpense.TblExpensesBindingSource.EndEdit()
                manageexpense.TableAdapterManager.UpdateAll(manageexpense.DataSet)
            ElseIf m = 27 Then
                managefridge.Validate()
                managefridge.TblFridgesBindingSource.EndEdit()
                managefridge.TableAdapterManager.UpdateAll(managefridge.DataSet)
            ElseIf m = 28 Then
                manageincome.Validate()
                manageincome.TblIncomeBindingSource.EndEdit()
                manageincome.TableAdapterManager.UpdateAll(manageincome.DataSet)
            ElseIf m = 29 Then
                manageproduct.Validate()
                manageproduct.TblProductsBindingSource.EndEdit()
                manageproduct.TableAdapterManager.UpdateAll(manageproduct.DataSet)
            ElseIf m = 30 Then
                managepurchase.Validate()
                If s = 0 Then
                    managepurchase.TblPurchaseInvoiceBindingSource.EndEdit()
                ElseIf s = 1 Then
                    managepurchase.TblPurchaseBindingSource.EndEdit()
                End If
                managepurchase.TableAdapterManager.UpdateAll(managepurchase.DataSet)
            ElseIf m = 31 Then
                managestock.Validate()
                managestock.TblProductsBindingSource.EndEdit()
                managestock.TableAdapterManager.UpdateAll(managestock.DataSet)
            ElseIf m = 32 Then
                managesupplier.Validate()
                managesupplier.TblSuppliersBindingSource.EndEdit()
                managesupplier.TableAdapterManager.UpdateAll(managesupplier.DataSet)
            ElseIf m = 33 Then
                managetransaction.Validate()
                managetransaction.TblTransactionBindingSource.EndEdit()
                managetransaction.TableAdapterManager.UpdateAll(managetransaction.DataSet)
            ElseIf m = 34 Then
                newexpense.Validate()
                newexpense.TblExpensesBindingSource.EndEdit()
                newexpense.TableAdapterManager.UpdateAll(newexpense.DataSet)
            ElseIf m = 35 Then
                newincome.Validate()
                newincome.TblIncomeBindingSource.EndEdit()
                newincome.TableAdapterManager.UpdateAll(newincome.DataSet)
            ElseIf m = 36 Then
                newpurchase.Validate()
                If s = 0 Then
                    newpurchase.TblPurchaseInvoiceBindingSource.EndEdit()
                ElseIf s = 1 Then
                    newpurchase.TblPurchaseBindingSource.EndEdit()
                End If
                newpurchase.TableAdapterManager.UpdateAll(newpurchase.DataSet)
            ElseIf m = 37 Then
                newsale.Validate()
                If s = 0 Then
                    newsale.TblInvoiceBindingSource.EndEdit()
                ElseIf s = 1 Then
                    newsale.TblSalesBindingSource.EndEdit()
                End If
                newsale.TableAdapterManager.UpdateAll(newsale.DataSet)
            ElseIf m = 38 Then
                productcommission.Validate()
                'If s = 0 Then
                '    productcommission.TblSCommissionBindingSource.EndEdit()
                'ElseIf s = 1 Then
                '    productcommission.TblPCommissionBindingSource.EndEdit()
                'End If
                'productcommission.TableAdapterManager.UpdateAll(productcommission.DataSet)
            ElseIf m = 39 Then
                productdelivery.Validate()
                productdelivery.TblDeliveryBindingSource.EndEdit()
                productdelivery.TableAdapterManager.UpdateAll(productdelivery.DataSet)
            ElseIf m = 40 Then
                productcategory.Validate()
                productcategory.TblProductCategoryBindingSource.EndEdit()
                productcategory.TableAdapterManager.UpdateAll(productcategory.DataSet)
            ElseIf m = 41 Then
                profitcalculator.Validate()
                profitcalculator.TblProfitBindingSource.EndEdit()
                profitcalculator.TableAdapterManager.UpdateAll(profitcalculator.DataSet)
            ElseIf m = 42 Then
                purchasereport.Validate()
                purchasereport.TblPurchaseReportBindingSource.EndEdit()
                purchasereport.TableAdapterManager.UpdateAll(purchasereport.DataSet)
            ElseIf m = 43 Then
                'blank
            ElseIf m = 44 Then
                rentto.Validate()
                rentto.TblFridgesBindingSource.EndEdit()
                rentto.TableAdapterManager.UpdateAll(rentto.DataSet)
            ElseIf m = 45 Then
                returndamage.Validate()
                returndamage.TblDamageProductsBindingSource.EndEdit()
                returndamage.TableAdapterManager.UpdateAll(returndamage.DataSet)
            ElseIf m = 46 Then
                salesreport.Validate()
                salesreport.TblSalesreportBindingSource.EndEdit()
                salesreport.TableAdapterManager.UpdateAll(salesreport.DataSet)
            ElseIf m = 47 Then
                supplieraccount.Validate()
                supplieraccount.TblSupplierAccountsBindingSource.EndEdit()
                supplieraccount.TableAdapterManager.UpdateAll(supplieraccount.DataSet)
            ElseIf m = 48 Then
                managesignboard.Validate()
                managesignboard.TblSignboardBindingSource.EndEdit()
                managesignboard.TableAdapterManager.UpdateAll(managesignboard.DataSet)
            ElseIf m = 49 Then
                useraccounts.Validate()
                useraccounts.TblUserBindingSource.EndEdit()
                useraccounts.TableAdapterManager.UpdateAll(useraccounts.DataSet)
            ElseIf m = 50 Then
                login.Validate()
                login.TblUserBindingSource.EndEdit()
                login.TableAdapterManager.UpdateAll(login.DataSet)
            ElseIf m = 51 Then
                customeraccount.Validate()
                customeraccount.TblCusomterAccountsBindingSource.EndEdit()
                customeraccount.TableAdapterManager.UpdateAll(customeraccount.DataSet)
            ElseIf m = 52 Then
                transactionreport.Validate()
                transactionreport.TblTransactionReportBindingSource.EndEdit()
                transactionreport.TableAdapterManager.UpdateAll(transactionreport.DataSet)
            ElseIf m = 53 Then
                managecustomer.Validate()
                managecustomer.TblCustomersBindingSource.EndEdit()
                managecustomer.TableAdapterManager.UpdateAll(managecustomer.DataSet)
            ElseIf m = 54 Then
                addcustomer.Validate()
                addcustomer.TblCustomersBindingSource.EndEdit()
                addcustomer.TableAdapterManager.UpdateAll(addcustomer.DataSet)
            ElseIf m = 55 Then
                paysupplier.Validate()
                paysupplier.TblRentSBindingSource.EndEdit()
                paysupplier.TableAdapterManager.UpdateAll(paysupplier.DataSet)
            ElseIf m = 56 Then
                paycustomer.Validate()
                paycustomer.TblRentCBindingSource.EndEdit()
                paycustomer.TableAdapterManager.UpdateAll(paycustomer.DataSet)
            ElseIf m = 57 Then
                returndamagefridge.Validate()
                returndamagefridge.TblDamageFridgeBindingSource.EndEdit()
                returndamagefridge.TableAdapterManager.UpdateAll(returndamagefridge.DataSet)
            ElseIf m = 58 Then
                'blank
            ElseIf m = 59 Then
                'blank
            ElseIf m = 60 Then
                withdraw.Validate()
                withdraw.TblwithdrawBindingSource.EndEdit()
                withdraw.TableAdapterManager.UpdateAll(withdraw.DataSet)
            ElseIf m = 61 Then
                myacc.Validate()
                myacc.TblUserBindingSource.EndEdit()
                myacc.TableAdapterManager.UpdateAll(myacc.DataSet)
            ElseIf m = 62 Then
                newvehicle.Validate()
                newvehicle.TblVehicleBindingSource.EndEdit()
                newvehicle.TableAdapterManager.UpdateAll(newvehicle.DataSet)
            ElseIf m = 63 Then
                managevehicle.Validate()
                managevehicle.TblVehicleBindingSource.EndEdit()
                managevehicle.TableAdapterManager.UpdateAll(managevehicle.DataSet)
            ElseIf m = 64 Then
                vehicleaccounts.Validate()
                vehicleaccounts.TblVehicleAccountsBindingSource.EndEdit()
                vehicleaccounts.TableAdapterManager.UpdateAll(vehicleaccounts.DataSet)
            ElseIf m = 65 Then
                'blank
            ElseIf m = 66 Then
                'blank
            ElseIf m = 67 Then
                purchaseseason.Validate()
                purchaseseason.TblPCommissionBindingSource.EndEdit()
                purchaseseason.TableAdapterManager.UpdateAll(purchaseseason.DataSet)
            ElseIf m = 68 Then
                saleseason.Validate()
                saleseason.TblSCommissionBindingSource.EndEdit()
                saleseason.TableAdapterManager.UpdateAll(saleseason.DataSet)
            ElseIf m = 69 Then
                cashreport.Validate()
                cashreport.TblCashReportBindingSource.EndEdit()
                cashreport.TableAdapterManager.UpdateAll(cashreport.DataSet)
            ElseIf m = 70 Then
                sell_on_commisssion.Validate()
                sell_on_commisssion.TblsellcommissionBindingSource.EndEdit()
                sell_on_commisssion.TableAdapterManager.UpdateAll(sell_on_commisssion.DataSet)
            ElseIf m = 71 Then
            ElseIf m = 72 Then
                discounts.Validate()
                discounts.TbldiscountBindingSource.EndEdit()
                discounts.TableAdapterManager.UpdateAll(discounts.DataSet)
            End If
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Function filter(pi, fi, ti, si, s)
        Try
            Dim b(,) As String = {
           {"date", "employeeID", "employeeName", "attended", "", "", "", "", "", ""},
           {"accountHolderName", "accountNumber", "", "", "", "", "", "", "", ""},
           {"bankName", "address", "phone", "", "", "", "", "", "", ""},
           {"companyName", "companyAddress", "companePhoneNumber", "currency", "defaultVat", "", "", "", "", ""},
           {"customerName", "contactNumber", "email", "customerID", "shopOrCompanyName", "", "", "", "", ""},
           {"Id", "productName", "productCategory", "supplier", "damageDate", "", "", "", "", ""},
           {"Id", "employeeName", "address", "bloodGroup", "NIDNumber", "contactNumber", "joinDate", "", "", ""},
           {"cName", "", "", "", "", "", "", "", "", ""},
           {"personName", "expenseCategory", "expenseSubCategory", "date", "", "", "", "", "", ""},
           {"cName", "", "", "", "", "", "", "", "", ""},
           {"fridgeModelNo", "supplierName", "issueDate", "fridgeID", "rentTo", "", "", "", "", ""},
           {"incomeCategory", "incomeSubCategory", "date", "", "", "", "", "", "", ""},
           {"cName", "", "", "", "", "", "", "", "", ""},
           {"cName", "", "", "", "", "", "", "", "", ""},
           {"invoiceNo", "customerName", "contactNumber", "date", "", "", "", "", "", ""},
           {"time", "date", "submittedBy", "", "", "", "", "", "", ""},
           {"cName", "", "", "", "", "", "", "", "", ""},
           {"productName", "productCode", "productCategory", "supplier", "", "", "", "", "", ""},
           {"invoiceNo", "productName", "supplier", "", "", "", "", "", "", ""},
           {"invoiceNo", "companyInvoice", "supplier", "date", "", "", "", "", "", ""},
           {"invoiceNo", "productName", "supplier", "", "", "", "", "", "", ""},
           {"supplierName", "contactPerson", "address", "contactNumber", "email", "supplierID", "", "", "", ""},
           {"transactionID", "accNo", "date", "", "", "", "", "", "", ""},
           {"userName", "userID", "password", "role", "", "", "", "", "", ""},
           {"accountNO", "", "", "", "", "", "", "", "", ""},
           {"employeeName", "employeeID", "", "", "", "", "", "", "", ""},
           {"customerName", "shopName", "", "", "", "", "", "", "", ""},
           {"expenseCategory", "", "", "", "", "", "", "", "", ""},
           {"productName", "", "", "", "", "", "", "", "", ""},
           {"date", "", "", "", "", "", "", "", "", ""},
           {"supplierName", "supplierID", "purchaseInvoice", "", "", "", "", "", "", ""},
           {"customerName", "customerID", "saleInvoice", "", "", "", "", "", "", ""},
           {"employeeName", "employeeID", "", "", "", "", "", "", "", ""},
           {"", "", "", "", "", "", "", "", "", ""},
           {"", "", "", "", "", "", "", "", "", ""},
           {"modelNO", "fridgeID", "issueDate", "supplier", "", "", "", "", "", ""},
           {"saleInvoice", "customerName", "shippingAddress", "contactNumber", "date", "", "", "", "", ""},
           {"", "", "", "", "", "", "", "", "", ""},
           {"", "", "", "", "", "", "", "", "", ""}
       }
            Dim i As String = pi
            Dim f As String = b(ti, fi)


            'searching function
            Dim fl As String = f & " Like '%" & s & "%'"
            If i = 0 Then
                addbank.TblBanksBindingSource.Filter = fl
            ElseIf i = 1 Then
                adddamage.TblDamageProductsBindingSource.Filter = fl
            ElseIf i = 2 Then
                addemployee.TblEmployeeBindingSource.Filter = fl
            ElseIf i = 3 Then
                addfridge.TblFridgesBindingSource.Filter = fl
            ElseIf i = 4 Then
                addnote.TblNotesBindingSource.Filter = fl
            ElseIf i = 5 Then
                addproduct.TblProductsBindingSource.Filter = fl
            ElseIf i = 6 Then
                addsupplier.TblSuppliersBindingSource.Filter = fl
            ElseIf i = 7 Then
                'blank
            ElseIf i = 8 Then
                attendencereport.TblAttendenceReportBindingSource.Filter = fl
            ElseIf i = 9 Then
                companysettting.TblCompanySettingsBindingSource.Filter = fl
            ElseIf i = 10 Then
                createuser.TblUserBindingSource.Filter = fl
            ElseIf i = 11 Then
                damageFridge.TblDamageFridgeBindingSource.Filter = fl
            ElseIf i = 12 Then

            ElseIf i = 13 Then
                duereport.TblDuesReportBindingSource.Filter = fl
            ElseIf i = 14 Then
                employeeaccount.TblEmployeeAccountsBindingSource.Filter = fl
            ElseIf i = 15 Then
                employeeattendence.TblAttendenceBindingSource.Filter = fl
            ElseIf i = 16 Then
                If si = 0 Then
                    expensecategory.TblExpenseCategoryBindingSource.Filter = fl
                ElseIf si = 1 Then
                    expensecategory.TblExpenseSubcategoryBindingSource.Filter = fl
                End If
            ElseIf i = 17 Then
                expensereport.TblExpenseReportBindingSource.Filter = fl
            ElseIf i = 18 Then

            ElseIf i = 19 Then
                managebank.TblBanksBindingSource.Filter = fl
            ElseIf i = 20 Then
                If si = 0 Then
                    incomecategory.TblIncomeCategoryBindingSource.Filter = fl
                ElseIf si = 1 Then
                    incomecategory.TblIncomeSubcategoryBindingSource.Filter = fl
                End If
            ElseIf i = 21 Then
                If si = 0 Then
                    managesale.TblInvoiceBindingSource.Filter = fl
                ElseIf si = 1 Then
                    managesale.TblSalesBindingSource.Filter = fl
                End If
            ElseIf i = 22 Then

            ElseIf i = 23 Then
                managebankaccount.TblBankAccountsBindingSource.Filter = fl
            ElseIf i = 24 Then
                managedamage.TblDamageProductsBindingSource.Filter = fl
            ElseIf i = 25 Then
                manageemployee.TblEmployeeBindingSource.Filter = fl
            ElseIf i = 26 Then
                manageexpense.TblExpensesBindingSource.Filter = fl
            ElseIf i = 27 Then
                managefridge.TblFridgesBindingSource.Filter = fl
            ElseIf i = 28 Then
                manageincome.TblIncomeBindingSource.Filter = fl
            ElseIf i = 29 Then
                manageproduct.TblProductsBindingSource.Filter = fl
            ElseIf i = 30 Then
                managepurchase.TblPurchaseInvoiceBindingSource.Filter = fl
            ElseIf i = 31 Then
                managestock.TblProductsBindingSource.Filter = fl
            ElseIf i = 32 Then
                managesupplier.TblSuppliersBindingSource.Filter = fl
            ElseIf i = 33 Then
                managetransaction.TblTransactionBindingSource.Filter = fl
            ElseIf i = 34 Then
                newexpense.TblExpensesBindingSource.Filter = fl
            ElseIf i = 35 Then
                newincome.TblIncomeBindingSource.Filter = fl
            ElseIf i = 36 Then
                If si = 0 Then
                    newpurchase.TblPurchaseBindingSource.Filter = fl
                ElseIf si = 1 Then
                    newpurchase.TblPurchaseInvoiceBindingSource.Filter = fl
                End If
            ElseIf i = 37 Then
                If si = 0 Then
                    newsale.TblInvoiceBindingSource.Filter = fl
                ElseIf si = 1 Then
                    newsale.TblSalesBindingSource.Filter = fl
                End If
            ElseIf i = 38 Then

            ElseIf i = 39 Then
                productdelivery.TblDeliveryBindingSource.Filter = fl
            ElseIf i = 40 Then
                productcategory.TblProductCategoryBindingSource.Filter = fl
            ElseIf i = 41 Then
                profitcalculator.TblProfitBindingSource.Filter = fl
            ElseIf i = 42 Then
                purchasereport.TblPurchaseReportBindingSource.Filter = fl
            ElseIf i = 43 Then

            ElseIf i = 44 Then
                rentto.TblFridgesBindingSource.Filter = fl
            ElseIf i = 45 Then
                returndamage.TblDamageProductsBindingSource.Filter = fl
            ElseIf i = 46 Then
                salesreport.TblSalesreportBindingSource.Filter = fl
            ElseIf i = 47 Then
                supplieraccount.TblSupplierAccountsBindingSource.Filter = fl
            ElseIf i = 48 Then

            ElseIf i = 49 Then
                useraccounts.TblUserBindingSource.Filter = fl
            ElseIf i = 50 Then
                login.TblUserBindingSource.Filter = fl
            ElseIf i = 51 Then
                customeraccount.TblCusomterAccountsBindingSource.Filter = fl
            ElseIf i = 52 Then
                transactionreport.TblTransactionReportBindingSource.Filter = fl
            ElseIf i = 53 Then
                managecustomer.TblCustomersBindingSource.Filter = fl

            End If
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Dim stm As New Timer
    Function status(s As String)

        Try

            Dim p As New ProgressBar
            stm.Stop()
            My.Computer.Audio.Stop()
            p.Value = 0
            sVol = GetVol()
            stm.Interval = 150
            stm.Start()

            AddHandler stm.Tick, Function()
                                     p.Increment(5)
                                     Form1.lblStatus.Text = s
                                     If p.Value = 5 AndAlso companysettting.Is_noti_soundTextBox.Text = "1" Then
                                         setVol(My.Settings.volu)
                                         Try
                                             My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "sound.wav")
                                         Catch ex As Exception

                                         End Try
                                     End If
                                     If p.Value Mod 2 = 0 Then
                                         Form1.lbl.ForeColor = Color.Red
                                         Form1.lbl.BackColor = Color.Black

                                     Else
                                         Form1.lbl.ForeColor = Color.Black
                                         Form1.lbl.BackColor = Color.Red
                                     End If

                                     If p.Value = 85 Then

                                         p.Value = 0
                                         Form1.lbl.BackColor = Color.Black
                                         Form1.lbl.ForeColor = Color.White
                                         My.Computer.Audio.Stop()
                                         Form1.lblStatus.Text = "---------------------"
                                         If companysettting.Is_noti_soundTextBox.Text = "1" Then
                                             setVol(sVol)
                                         End If
                                         stm.Stop()
                                     End If
                                     Return 0
                                 End Function
        Catch ex As Exception

        End Try
        Return 0
    End Function

    Public Function ld(i)
        Try

            If i = 0 Then
                'selection 
                addbank.BankNameTextBox.Select()
                slt(addbank.BankNameTextBox, addbank.AddressTextBox)
                slt(addbank.AddressTextBox, addbank.WebsiteTextBox)
                slt(addbank.WebsiteTextBox, addbank.PhoneTextBox)

                phn(addbank.PhoneTextBox)
            ElseIf i = 1 Then
                adddamage.Product_nameTextBox.Select()

                slt(adddamage.Product_nameTextBox, adddamage.Unit_priceTextBox)
                slt(adddamage.Unit_priceTextBox, adddamage.QuantityTextBox)
                slt(adddamage.QuantityTextBox, adddamage.Invoice_noTextBox)

                auto(adddamage.Product_nameTextBox, adddamage.DataSet.tblProducts, "productName")
                auto(adddamage.Product_codeTextBox, adddamage.DataSet.tblProducts, "productCode")

                num(adddamage.Unit_priceTextBox)
                num(adddamage.QuantityTextBox)
            ElseIf i = 2 Then
                Try
                    addemployee.employee()
                Catch ex As Exception

                End Try
            ElseIf i = 3 Then
                'selection
                addfridge.FridgeModelNoTextBox.Select()
                slt(addfridge.FridgeModelNoTextBox, addfridge.SupplierNameTextBox)
                slt(addfridge.SupplierNameTextBox, addfridge.FridgeIDTextBox)
                slt(addfridge.FridgeIDTextBox, addfridge.FridgeNoteTextBox)
                slt(addfridge.FridgeNoteTextBox, addfridge.CompanySecurityMoneyTextBox)
                slt(addfridge.CompanySecurityMoneyTextBox, addfridge.CompanyRentTextBox)


                num(addfridge.CompanyRentTextBox)
                num(addfridge.CompanySecurityMoneyTextBox)

                addfridge.IssueDateTextBox.Text = Date.Today

                If addfridge.TblSuppliersBindingSource.Count = 0 Then
                    addfridge.Enabled = False
                Else
                    addfridge.Enabled = True
                End If
                auto(addfridge.SupplierNameTextBox, addfridge.DataSet.tblSuppliers, "supplierName")
                id_maker(addfridge.FridgeIDTextBox)
            ElseIf i = 4 Then
                'selection
                addnote.NoteTextBox.Select()
                slt(addnote.TimeTextBox, addnote.DateTextBox)
                slt(addnote.DateTextBox, addnote.NoteTextBox)
                slt(addnote.NoteTextBox, addnote.SubmittedByTextBox)

                addnote.TimeTextBox.Text = TimeOfDay
                addnote.DateTextBox.Text = Date.Today

                addnote.TblUserTableAdapter.Fill(addnote.DataSet.tblUser)
                addnote.TblUserBindingSource.Filter = "userID LIKE '%" & My.Settings.currentac & "%'"
                addnote.SubmittedByTextBox.Text = addnote.UserNameTextBox.Text

                auto(addnote.SubmittedByTextBox, addnote.DataSet.tblUser, "userName")
                auto(addnote.SubmittedByTextBox, addnote.DataSet.tblEmployee, "employeeName")
            ElseIf i = 5 Then
                'selection
                addproduct.ProductNameTextBox.Select()
                slt(addproduct.ProductNameTextBox, addproduct.ProductCategoryTextBox)
                slt(addproduct.ProductCategoryTextBox, addproduct.ProductCodeTextBox)
                slt(addproduct.ProductCodeTextBox, addproduct.SupplierTextBox)
                slt(addproduct.SupplierTextBox, addproduct.PurchasePriceTextBox)
                slt(addproduct.PurchasePriceTextBox, addproduct.ProfitTextBox)
                slt(addproduct.SellPriceTextBox, addproduct.AlertQuantityTextBox)
                slt(addproduct.ProfitTextBox, addproduct.SellPriceTextBox)
                slt(addproduct.SellPriceTextBox, addproduct.AlertQuantityTextBox)
                slt(addproduct.AlertQuantityTextBox, addproduct.AvailableTextBox)

                num(addproduct.AvailableTextBox)
                num(addproduct.PurchasePriceTextBox)
                num(addproduct.SellPriceTextBox)
                num(addproduct.ProfitTextBox)
                num(addproduct.AlertQuantityTextBox)

                auto(addproduct.ProductCategoryTextBox, addproduct.DataSet.tblProductCategory, "cName")
                auto(addproduct.SupplierTextBox, addproduct.DataSet.tblSuppliers, "supplierName")

                If addproduct.TblProductCategoryBindingSource.Count = 0 Then
                    addproduct.Enabled = False
                Else
                    addproduct.Enabled = True
                End If
            ElseIf i = 6 Then
                'selection
                addsupplier.SupplierNameTextBox.Select()
                slt(addsupplier.SupplierNameTextBox, addsupplier.ContactPersonTextBox)
                slt(addsupplier.ContactPersonTextBox, addsupplier.AddressTextBox)
                slt(addsupplier.AddressTextBox, addsupplier.ContactNumberTextBox)
                slt(addsupplier.ContactNumberTextBox, addsupplier.WebsiteTextBox)
                slt(addsupplier.WebsiteTextBox, addsupplier.EmailTextBox)
                slt(addsupplier.EmailTextBox, addsupplier.SupplierIDTextBox)
                slt(addsupplier.SupplierIDTextBox, addsupplier.SupplierNoteTextBox)

                slt(addsupplier.PaymentTextBox, addsupplier.PaidTextBox)
                slt(addsupplier.PaidTextBox, addsupplier.DueTextBox)

                phn(addsupplier.ContactNumberTextBox)

                If addsupplier.Non_profitTextBox.Text = "1" Then
                    addsupplier.chk_nonprofit.Checked = True
                Else
                    addsupplier.chk_nonprofit.Checked = False
                End If

                addsupplier.chk_add.Checked = False
                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If addsupplier.chk_add.Checked = True Then
                                           addsupplier.GroupBox1.Enabled = True
                                       Else
                                           addsupplier.GroupBox1.Enabled = False
                                       End If
                                       Return 0
                                   End Function


            ElseIf i = 7 Then

            ElseIf i = 8 Then
                dt(attendencereport.TblAttendenceReportDataGridView)
                attendencereport.TblAttendenceTableAdapter.Fill(attendencereport.DataSet.tblAttendence)
                attendencereport.TblAttendenceReportTableAdapter.Fill(attendencereport.DataSet.tblAttendenceReport)
                'generate report
                attendencereport.TblAttendenceReportBindingSource.RemoveFilter()
                attendencereport.TblAttendenceReportBindingSource.MoveFirst()
                attendencereport.TblAttendenceBindingSource.RemoveFilter()
                attendencereport.TblAttendenceBindingSource.MoveFirst()

                attendencereport.TblAttendenceReportBindingSource.Filter = "[date ] = '" & Today & "'"
                While attendencereport.TblAttendenceReportBindingSource.Count <> 0
                    attendencereport.TblAttendenceReportBindingSource.RemoveCurrent()
                End While
                attendencereport.TblAttendenceBindingSource.Filter = "date = '" & Today & "'"
                Try
                    For a = 0 To attendencereport.TblAttendenceBindingSource.Count - 1
                        attendencereport.TblAttendenceReportBindingSource.AddNew()
                        attendencereport.EmployeeNameTextBox1.Text = attendencereport.EmployeeNameTextBox.Text
                        attendencereport.EmployeeIDTextBox1.Text = attendencereport.EmployeeIDTextBox.Text
                        attendencereport.AttendedTextBox1.Text = attendencereport.AttendedTextBox.Text
                        attendencereport.Date_TextBox.Text = Date.Today

                        attendencereport.TblAttendenceBindingSource.MoveNext()
                    Next

                Catch ex As Exception

                End Try

                'update
                attendencereport.Validate()
                attendencereport.TblAttendenceReportBindingSource.EndEdit()
                attendencereport.TableAdapterManager.UpdateAll(attendencereport.DataSet)
                attendencereport.TblAttendenceReportBindingSource.RemoveFilter()

                attendencereport.txtFilter.SelectedIndex = 0
                auto(attendencereport.txtSearch, attendencereport.DataSet.tblAttendence, "employeeName")
                auto(attendencereport.txtSearch, attendencereport.DataSet.tblAttendence, "employeeID")
                auto(attendencereport.txtSearch, attendencereport.DataSet.tblAttendence, "date")

                attendencereport.fromDt.ResetText()
                attendencereport.toDt.ResetText()
                dat(attendencereport.fromDt, attendencereport.toDt)

                attendencereport.TblAttendenceBindingSource.RemoveFilter()
                If attendencereport.TblAttendenceBindingSource.Count = 0 Then
                    attendencereport.Enabled = False
                Else
                    attendencereport.Enabled = True
                End If

                'clear unneccessery data
                clear_unneccessery_data(attendencereport.TblAttendenceReportBindingSource, attendencereport.TblAttendenceReportDataGridView, 3)
                'ended

            ElseIf i = 9 Then

                companySettings.csettings()
            ElseIf i = 10 Then

                'selection
                createuser.UserNameTextBox.Select()
                slt(createuser.UserNameTextBox, createuser.UserIDTextBox)
                slt(createuser.UserIDTextBox, createuser.PasswordTextBox)
                slt(createuser.PasswordTextBox, createuser.AddressTextBox)
                slt(createuser.AddressTextBox, createuser.PhoneTextBox)
                slt(createuser.PhoneTextBox, createuser.RoleTextBox)

                createuser.chkProducts.Checked = False
                createuser.chkSales.Checked = False
                createuser.chkPurchase.Checked = False

                createuser.chkTransaction.Checked = False
                createuser.chkExpenses.Checked = False
                createuser.chkOthers.Checked = False
                createuser.chkIncome.Checked = False

                createuser.chkReports.Checked = False
                createuser.chkFridge.Checked = False

                createuser.TblUserBindingSource.AddNew()

            ElseIf i = 11 Then
                dt(damageFridge.TblDamageFridgeDataGridView)
                'selection
                damageFridge.FridgeIDTextBox.Select()
                slt(damageFridge.FridgeIDTextBox, damageFridge.ModelNOTextBox)
                slt(damageFridge.ModelNOTextBox, damageFridge.SupplierTextBox)


                auto(damageFridge.FridgeIDTextBox, damageFridge.DataSet.tblFridges, "fridgeID")

                If damageFridge.TblFridgesBindingSource.Count = 0 Then
                    damageFridge.Enabled = False
                Else
                    damageFridge.Enabled = True
                End If


                damageFridge.Panel2.Enabled = False
            ElseIf i = 12 Then
                Try

                    dtd(dashboard.TblNotesDataGridView)
                    dtd1(dashboard.TblInvoiceDataGridView)
                    dtd1(dashboard.TblProductsDataGridView)
                    'dashboard.Panel1.Left = (dashboard.ClientSize.Width / 2) - (dashboard.Panel1.Width / 2)
                    center(dashboard, dashboard.Panel1)
                Catch ex As Exception

                End Try
                dash_prg()

                'sales target
                'Try
                '    'fll(21)
                '    'ld(21)
                '    'fll(9)
                '    'ld(9)
                '    dashboard.lblTarget.Text = companysettting.txtSaletarget.Text
                '    dashboard.TblInvoiceTableAdapter.Fill(dashboard.DataSet.tblInvoice)
                '    dashboard.TblInvoiceBindingSource.RemoveFilter()
                '    Dim from_date As Date = Today
                '    Dim to_date As Date = Today
                '    While from_date.Day <> 1
                '        from_date = from_date.AddDays(-1)
                '    End While
                '    While to_date.Day <> Date.DaysInMonth(to_date.Year, to_date.Month)
                '        to_date = to_date.AddDays(1)
                '    End While
                '    dashboard.TblInvoiceBindingSource.Filter = "date <=" & to_date & " AND date >=" & from_date
                '    dashboard.lblSold.Text = dtsum(dashboard.TblInvoiceDataGridView, 2)
                'Catch ex As Exception

                'End Try

                'If dashboard.TblInvoiceBindingSource.Count > 0 Then
                '    Try
                '        Dim target As Double = Double.Parse(companysettting.txtSaletarget.Text)
                '        Dim sold As Double = Double.Parse(dtsum(dashboard.TblInvoiceDataGridView, 2))
                '        Dim prc As Double = (100 / target) * sold

                '        dashboard.p_value(Convert.ToInt32(prc))
                '        dashboard.CircularProgressBar1.SuperscriptText = dashboard.CircularProgressBar1.Value & "%"

                '    Catch ex As Exception

                '    End Try
                'End If
                managesale.TblInvoiceBindingSource.RemoveFilter()

                Try

                    'total sale
                    AddHandler dashboard.lbl_totalsale.MouseEnter, Function()
                                                                       Try
                                                                           dashboard.lbl_totalsale.Text = "0000"
                                                                           fll(21)
                                                                           ld(21)
                                                                           managesale.TblInvoiceBindingSource.Filter = "date = '" & Today & "'"
                                                                           Dim a As Double = dtsum(managesale.TblInvoiceDataGridView, 3)
                                                                           If a > 0 Then
                                                                               dashboard.lbl_totalsale.Text = a
                                                                           Else
                                                                               dashboard.lbl_totalsale.Text = "0000"
                                                                           End If
                                                                           dashboard.lbl_totalsale.Text = dashboard.lbl_totalsale.Text & dashboard.CurrencyTextBox.Text
                                                                       Catch ex As Exception

                                                                       End Try
                                                                       Return 0
                                                                   End Function
                    AddHandler dashboard.lbl_totalsale.MouseLeave, Function()
                                                                       dashboard.lbl_totalsale.Text = "বিক্রয়"
                                                                       Return 0
                                                                   End Function

                    'income
                    AddHandler dashboard.lbl_income.MouseEnter, Function()
                                                                    Try
                                                                        dashboard.lbl_income.Text = "0000"
                                                                        fll(41)
                                                                        ld(41)
                                                                        profitcalculator.TblProfitBindingSource.Filter = "date ='" & Today & "'"
                                                                        If profitcalculator.TblProfitBindingSource.Count > 0 Then
                                                                            Dim a As Double = Double.Parse(profitcalculator.TblProfitDataGridView.Rows(0).Cells(1).Value.ToString())
                                                                            If a > 0 Then
                                                                                dashboard.lbl_income.Text = a
                                                                            Else
                                                                                dashboard.lbl_income.Text = "0000"
                                                                            End If
                                                                        End If
                                                                        dashboard.lbl_income.Text = dashboard.lbl_income.Text & dashboard.CurrencyTextBox.Text
                                                                    Catch ex As Exception

                                                                    End Try
                                                                    Return 0
                                                                End Function
                    AddHandler dashboard.lbl_income.MouseLeave, Function()
                                                                    dashboard.lbl_income.Text = "আয়/প্রাপ্তি"
                                                                    Return 0
                                                                End Function

                    'expense
                    AddHandler dashboard.lbl_expense.MouseEnter, Function()
                                                                     Try
                                                                         dashboard.lbl_expense.Text = "0000"
                                                                         fll(41)
                                                                         ld(41)
                                                                         profitcalculator.TblProfitBindingSource.Filter = "date ='" & Today & "'"
                                                                         If profitcalculator.TblProfitBindingSource.Count > 0 Then
                                                                             Dim a As Double = Double.Parse(profitcalculator.TblProfitDataGridView.Rows(0).Cells(2).Value.ToString())
                                                                             If a > 0 Then
                                                                                 dashboard.lbl_expense.Text = a
                                                                             Else
                                                                                 dashboard.lbl_expense.Text = "0000"
                                                                             End If
                                                                         End If
                                                                         dashboard.lbl_expense.Text = dashboard.lbl_expense.Text & dashboard.CurrencyTextBox.Text
                                                                     Catch ex As Exception

                                                                     End Try
                                                                     Return 0
                                                                 End Function
                    AddHandler dashboard.lbl_expense.MouseLeave, Function()
                                                                     dashboard.lbl_expense.Text = "ব্যয়/প্রদান"
                                                                     Return 0
                                                                 End Function

                    'profit
                    AddHandler dashboard.lbl_profit.MouseEnter, Function()
                                                                    Try
                                                                        dashboard.lbl_profit.Text = "0000"
                                                                        fll(41)
                                                                        ld(41)
                                                                        profitcalculator.TblProfitBindingSource.Filter = "date ='" & Today & "'"
                                                                        If profitcalculator.TblProfitBindingSource.Count > 0 Then
                                                                            Dim a As Double = Double.Parse(profitcalculator.TblProfitDataGridView.Rows(0).Cells(3).Value.ToString())
                                                                            If a > 0 Then
                                                                                dashboard.lbl_profit.Text = a
                                                                            Else
                                                                                dashboard.lbl_profit.Text = "0000"
                                                                            End If
                                                                        End If
                                                                        dashboard.lbl_profit.Text = dashboard.lbl_profit.Text & dashboard.CurrencyTextBox.Text
                                                                    Catch ex As Exception

                                                                    End Try
                                                                    Return 0
                                                                End Function
                    AddHandler dashboard.lbl_profit.MouseLeave, Function()
                                                                    dashboard.lbl_profit.Text = "ক্যাশ"
                                                                    Return 0
                                                                End Function



                Catch ex As Exception

                End Try


                'get low products

                Try
                    dashboard.TblProductsBindingSource.RemoveFilter()
                    dashboard.TblProductsBindingSource.MoveFirst()
                    For a = 0 To dashboard.TblProductsBindingSource.Count - 1
                        If Integer.Parse(dashboard.AvailableTextBox.Text) > Integer.Parse(dashboard.AlertQuantityTextBox.Text) Or Integer.Parse(dashboard.AvailableTextBox.Text) = 0 Then
                            dashboard.TblProductsBindingSource.RemoveCurrent()
                        End If
                        dashboard.TblProductsBindingSource.MoveNext()
                        If a = dashboard.TblProductsBindingSource.Count - 1 Then
                            dashboard.TblProductsBindingSource.MoveFirst()
                        End If
                    Next


                Catch ex As Exception

                End Try
                Try
                    'filter notice board
                    dashboard.TblNotesBindingSource.Filter = "date ='" & Today & "'"
                    dashboard.TblInvoiceBindingSource.Filter = "date ='" & Today & "'"


                Catch ex As Exception

                End Try

            ElseIf i = 13 Then


                dt(duereport.TblDuesReportDataGridView)
                dat(duereport.fromDt, duereport.toDt)
                'generate report
                Try
                    duereport.TblInvoiceTableAdapter.Fill(duereport.DataSet.tblInvoice)
                    duereport.TblDuesReportBindingSource.Filter = "date ='" & Today & "'"
                    While duereport.TblDuesReportBindingSource.Count <> 0
                        duereport.TblDuesReportBindingSource.RemoveCurrent()
                    End While
                    duereport.TblCustomersBindingSource.RemoveFilter()
                    duereport.TblCustomersBindingSource.MoveFirst()
                    For a = 0 To duereport.TblCustomersBindingSource.Count - 1
                        duereport.TblInvoiceBindingSource.Filter = "customerID ='" & duereport.CustomerIDTextBox1.Text & "' AND date ='" & Today & "'"
                        If duereport.TblInvoiceBindingSource.Count > 0 AndAlso dtsum(duereport.TblInvoiceDataGridView, 0) > 0 Then
                            duereport.TblDuesReportBindingSource.AddNew()
                            duereport.DateTextBox.Text = Today
                            duereport.CustomerNameTextBox.Text = duereport.CustomerNameTextBox2.Text
                            duereport.ShopNameTextBox.Text = duereport.ShopOrCompanyNameTextBox.Text
                            duereport.AmountTextBox.Text = dtsum(duereport.TblInvoiceDataGridView, 0)
                        End If
                        duereport.TblCustomersBindingSource.MoveNext()
                    Next

                    'update
                    duereport.Validate()
                    duereport.TblDuesReportBindingSource.EndEdit()
                    duereport.TableAdapterManager.UpdateAll(duereport.DataSet)

                    duereport.TblDuesReportBindingSource.RemoveFilter()

                    duereport.txtFilter.SelectedIndex = 0
                    ' auto(duereport.txtSearch, duereport.DataSet.tblDuesReport, "date")
                    auto(duereport.txtSearch, duereport.DataSet.tblDuesReport, "customerName")
                    auto(duereport.txtSearch, duereport.DataSet.tblDuesReport, "shopName")

                    due_report_timer.Start()
                    AddHandler due_report_timer.Tick, Function()
                                                          Try
                                                              duereport.tool.Items(0).Text = "মোট বাকিঃ " & dtsum(duereport.TblDuesReportDataGridView, 3) & dashboard.CurrencyTextBox.Text
                                                          Catch ex As Exception

                                                          End Try
                                                          Return 0
                                                      End Function
                Catch ex As Exception

                End Try

                'unneccessery data clear
                clear_unneccessery_data(duereport.TblDuesReportBindingSource, duereport.TblDuesReportDataGridView, 0)
                'ended
                duereport.TblDuesReportBindingSource.RemoveFilter()

                If duereport.TblCustomersBindingSource.Count = 0 Then
                    duereport.Enabled = False
                Else
                    duereport.Enabled = True
                End If
            ElseIf i = 14 Then
                'selection
                employeeaccount.txtFilter.SelectedIndex = 0
                dt(employeeaccount.TblEmployeeAccountsDataGridView)
                employeeaccount.fromDt.ResetText()
                employeeaccount.toDt.ResetText()
                dat(employeeaccount.fromDt, employeeaccount.toDt)
                'auto
                autot(employeeaccount.txtSearch, employeeaccount.DataSet.tblEmployeeAccounts, "employeeName", employeeaccount)
                autot(employeeaccount.txtSearch, employeeaccount.DataSet.tblEmployeeAccounts, "employeeID", employeeaccount)
                autot(employeeaccount.txtSearch, employeeaccount.DataSet.tblEmployeeAccounts, "date", employeeaccount)
                'clear unneccessery data
                ' clear_unneccessery_data(employeeaccount.TblEmployeeAccountsBindingSource, employeeaccount.TblEmployeeAccountsDataGridView, 3)
                'ended
                'calculate
                employee_accounts_timer.Start()
                AddHandler employee_accounts_timer.Tick, Function()
                                                             Try
                                                                 employeeaccount.tool.Items(0).Text = "মোট প্রদানঃ " & dtsum(employeeaccount.TblEmployeeAccountsDataGridView, 2) & dashboard.CurrencyTextBox.Text
                                                             Catch ex As Exception

                                                             End Try
                                                             Return 0
                                                         End Function
                employeeaccount.TblEmployeeAccountsBindingSource.RemoveFilter()
                If employeeaccount.TblEmployeeAccountsBindingSource.Count = 0 Then

                    employeeaccount.Enabled = False
                Else
                    employeeaccount.Enabled = True
                End If
            ElseIf i = 15 Then
                employeeattendence.txtFilter.SelectedIndex = 0
                dt(employeeattendence.TblAttendenceDataGridView)

                employeeattendence.TblEmployeeTableAdapter.Fill(employeeattendence.DataSet.tblEmployee)
                employeeattendence.TblAttendenceTableAdapter.Fill(employeeattendence.DataSet.tblAttendence)

                employeeattendence.TblEmployeeBindingSource.RemoveFilter()
                employeeattendence.TblEmployeeBindingSource.MoveFirst()
                For a = 0 To employeeattendence.TblEmployeeBindingSource.Count - 1

                    employeeattendence.TblAttendenceBindingSource.Filter = "employeeID ='" & employeeattendence.IdTextBox.Text & "' AND date ='" & Today & "'"
                    If employeeattendence.TblAttendenceBindingSource.Count = 0 Then
                        employeeattendence.TblAttendenceBindingSource.AddNew()
                        employeeattendence.DateTextBox.Text = Today
                        employeeattendence.EmployeeIDTextBox.Text = employeeattendence.IdTextBox.Text
                        employeeattendence.EmployeeNameTextBox1.Text = employeeattendence.EmployeeNameTextBox.Text
                        employeeattendence.AttendedTextBox.Text = "No"
                        employeeattendence.Validate()
                        employeeattendence.TblAttendenceBindingSource.EndEdit()
                        employeeattendence.TableAdapterManager.UpdateAll(employeeattendence.DataSet)
                    End If
                    employeeattendence.TblEmployeeBindingSource.MoveNext()
                Next


                employeeattendence.TblAttendenceBindingSource.RemoveFilter()

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If employeeattendence.AttendedTextBox.Text = "Yes" Then
                                           employeeattendence.chk.Checked = True
                                           employeeattendence.chk.Enabled = False
                                       Else
                                           employeeattendence.chk.Checked = False
                                           employeeattendence.chk.Enabled = True
                                       End If
                                       Try
                                           employeeattendence.TblEmployeeBindingSource.Filter = "Id =" & employeeattendence.EmployeeIDTextBox.Text
                                       Catch ex As Exception

                                       End Try
                                       If employeeattendence.chk.Checked = True Then
                                           employeeattendence.chk.BackColor = Color.Green
                                       Else
                                           employeeattendence.chk.BackColor = Color.Red
                                       End If
                                       Return 0
                                   End Function

                AddHandler employeeattendence.chk.MouseEnter, Function()
                                                                  t.Stop()
                                                                  Return 0
                                                              End Function
                AddHandler employeeattendence.chk.MouseLeave, Function()
                                                                  t.Start()
                                                                  Return 0
                                                              End Function

                employeeattendence.TblAttendenceBindingSource.RemoveFilter()
                If employeeattendence.TblEmployeeBindingSource.Count = 0 Then
                    employeeattendence.Enabled = False
                Else
                    employeeattendence.Enabled = True
                End If


            ElseIf i = 16 Then
                dt(expensecategory.TblExpenseCategoryDataGridView)
                dt(expensecategory.TblExpenseSubcategoryDataGridView)

                slt(expensecategory.CNameTextBox, expensecategory.RemarkTextBox)
                slt(expensecategory.CNameTextBox1, expensecategory.CTextBox)
                slt(expensecategory.CTextBox, expensecategory.RemarkTextBox1)

                expensecategory.txtFilter.SelectedIndex = 0
                autot(expensecategory.txtSearch, expensecategory.DataSet.tblExpenseCategory, "cName", expensecategory)
                'remove '
                For a = 0 To expensecategory.TblExpenseSubcategoryBindingSource.Count - 1
                    expensecategory.TblExpenseSubcategoryDataGridView.Rows(a).Cells(0).Value.ToString.Replace("'", "")
                Next

                Dim t As New Timer
                t.Interval = 500
                t.Start()
                AddHandler t.Tick, Function()
                                       expensecategory.TblExpenseSubcategoryBindingSource.Filter = "c LIKE '%" & expensecategory.CNameTextBox.Text & "%'"
                                       If expensecategory.TblExpenseCategoryBindingSource.Count = 0 Then
                                           expensecategory.GroupBox2.Enabled = False
                                       Else
                                           expensecategory.GroupBox2.Enabled = True
                                       End If
                                       'button enabler
                                       If expensecategory.TblExpenseCategoryBindingSource.Count = 0 Then
                                           expensecategory.ToolStrip1.Enabled = False
                                       Else
                                           expensecategory.ToolStrip1.Enabled = True
                                       End If
                                       Return 0
                                   End Function
                expensecategory.Panel2.Enabled = False
                expensecategory.Panel3.Enabled = False
                expensecategory.TblExpenseCategoryBindingSource.RemoveFilter()
            ElseIf i = 17 Then
                Try
                    expensereport.txtFilter.SelectedIndex = 0
                    dt(expensereport.TblExpenseReportDataGridView)
                    expensereport.fromDt.ResetText()
                    expensereport.toDt.ResetText()
                    expensereport.txtSearch.Clear()
                    dat(expensereport.fromDt, expensereport.toDt)

                    'clear todays old records 
                    expensereport.TblExpenseReportBindingSource.Filter = "date ='" & Today & "'"
                    While expensereport.TblExpenseReportBindingSource.Count <> 0
                        expensereport.TblExpenseReportBindingSource.RemoveCurrent()
                    End While
                    '''''
                    'report creating method started
                    expensereport.TblExpenseSubcategoryBindingSource.RemoveFilter()
                    expensereport.TblExpenseSubcategoryBindingSource.MoveFirst()
                    For a = 0 To expensereport.TblExpenseSubcategoryBindingSource.Count - 1
                        Try
                            expensereport.TblExpensesBindingSource.Filter = "date ='" & Today & "' AND expenseSubCategory LIKE '%" & expensereport.CNameTextBox1.Text & "%'"
                            If expensereport.TblExpensesBindingSource.Count > 0 AndAlso expensereport.CNameTextBox1.Text.Length > 0 Then
                                expensereport.TblExpenseReportBindingSource.AddNew()
                                expensereport.DateTextBox.Text = Today
                                expensereport.ExpenseCategoryTextBox1.Text = expensereport.CNameTextBox1.Text
                                expensereport.AmountTextBox1.Text = dtsum(expensereport.TblExpensesDataGridView, 0) + dtsum(expensereport.TblExpensesDataGridView, 1)
                                expensereport.Validate()
                                expensereport.TblExpenseReportBindingSource.EndEdit()
                                expensereport.TableAdapterManager.UpdateAll(expensereport.DataSet)
                            End If
                        Catch ex As Exception

                        End Try
                        expensereport.TblExpenseSubcategoryBindingSource.MoveNext()
                    Next
                    'employee expense
                    expensereport.TblExpensesBindingSource.Filter = "date ='" & Today & "' AND expenseSubCategory LIKE '%Employee expense%'"
                    If expensereport.TblExpensesBindingSource.Count > 0 Then
                        expensereport.TblExpenseReportBindingSource.AddNew()
                        expensereport.DateTextBox.Text = Today
                        expensereport.ExpenseCategoryTextBox1.Text = "Employee expense"
                        expensereport.AmountTextBox1.Text = dtsum(expensereport.TblExpensesDataGridView, 0) + dtsum(expensereport.TblExpensesDataGridView, 1)
                    End If
                    'employee salary
                    expensereport.TblExpensesBindingSource.Filter = "date ='" & Today & "' AND expenseSubCategory LIKE '%Employee salary%'"
                    If expensereport.TblExpensesBindingSource.Count > 0 Then
                        expensereport.TblExpenseReportBindingSource.AddNew()
                        expensereport.DateTextBox.Text = Today
                        expensereport.ExpenseCategoryTextBox1.Text = "Employee salary"
                        expensereport.AmountTextBox1.Text = dtsum(expensereport.TblExpensesDataGridView, 0) + dtsum(expensereport.TblExpensesDataGridView, 1)
                    End If
                    'withdraw expense
                    expensereport.TblExpensesBindingSource.Filter = "Date ='" & Today & "' AND expenseSubCategory LIKE '%Bank withdraw -expense%'"
                    If expensereport.TblExpensesBindingSource.Count > 0 Then
                        expensereport.TblExpenseReportBindingSource.AddNew()
                        expensereport.DateTextBox.Text = Today
                        expensereport.ExpenseCategoryTextBox1.Text = "Bank withdraw -expense"
                        expensereport.AmountTextBox1.Text = dtsum(expensereport.TblExpensesDataGridView, 0) + dtsum(expensereport.TblExpensesDataGridView, 1)
                    End If
                    'deposit income
                    expensereport.TblExpensesBindingSource.Filter = "date ='" & Date.Today & "' AND expenseSubCategory LIKE '%Bank deposit -income%'"
                    If expensereport.TblExpensesBindingSource.Count > 0 Then
                        expensereport.TblExpenseReportBindingSource.AddNew()
                        expensereport.DateTextBox.Text = Today
                        expensereport.ExpenseCategoryTextBox1.Text = "Bank deposit -income"
                        expensereport.AmountTextBox1.Text = dtsum(expensereport.TblExpensesDataGridView, 0) + dtsum(expensereport.TblExpensesDataGridView, 1)
                    End If
                    'company expense
                    expensereport.TblExpensesBindingSource.Filter = "date ='" & Today & "' AND expenseSubCategory LIKE '%Company payment%'"
                    If expensereport.TblExpensesBindingSource.Count > 0 Then
                        expensereport.TblExpenseReportBindingSource.AddNew()
                        expensereport.DateTextBox.Text = Today
                        expensereport.ExpenseCategoryTextBox1.Text = "Company payment"
                        expensereport.AmountTextBox1.Text = dtsum(expensereport.TblExpensesDataGridView, 0) + dtsum(expensereport.TblExpensesDataGridView, 1)
                    End If
                    'damage product
                    expensereport.TblExpensesBindingSource.Filter = "date ='" & Today & "' AND expenseSubCategory LIKE '%Damage product%'"
                    If expensereport.TblExpensesBindingSource.Count > 0 Then
                        expensereport.TblExpenseReportBindingSource.AddNew()
                        expensereport.DateTextBox.Text = Today
                        expensereport.ExpenseCategoryTextBox1.Text = "Damage product"
                        expensereport.AmountTextBox1.Text = dtsum(expensereport.TblExpensesDataGridView, 0) + dtsum(expensereport.TblExpensesDataGridView, 1)
                    End If

                    expensereport.Validate()
                    expensereport.TblExpenseReportBindingSource.EndEdit()
                    expensereport.TableAdapterManager.UpdateAll(expensereport.DataSet)
                    expensereport.TblExpenseReportBindingSource.RemoveFilter()


                    auto(expensereport.txtSearch, expensereport.DataSet.tblExpenseReport, "date")
                    auto(expensereport.txtSearch, expensereport.DataSet.tblExpenseReport, "expenseCategory")

                    expensereport.TblExpenseReportBindingSource.RemoveFilter()
                    'unneccessery data clear
                    clear_unneccessery_data(expensereport.TblExpenseReportBindingSource, expensereport.TblExpenseReportDataGridView, 0)
                    'ended


                    expensereport.TblExpenseReportBindingSource.MoveFirst()
                    expense_report_timer.Start()
                    AddHandler expense_report_timer.Tick, Function()
                                                              Try
                                                                  expensereport.tool.Items(0).Text = "মোট খরচঃ " & dtsum(expensereport.TblExpenseReportDataGridView, 2) & dashboard.CurrencyTextBox.Text
                                                              Catch ex As Exception

                                                              End Try
                                                              Return 0
                                                          End Function

                Catch ex As Exception

                End Try
            ElseIf i = 18 Then
                'blank
            ElseIf i = 19 Then
                managebank.txtFilter.SelectedIndex = 0
                managebank.txtSearch.Clear()
                managebank.TblBanksBindingSource.RemoveFilter()
                dt(managebank.TblBanksDataGridView)
                autot(managebank.txtSearch, managebank.DataSet1.tblBanks, "bankName", managebank)
            ElseIf i = 20 Then
                incomecategory.txtFilter.SelectedIndex = 0

                autot(incomecategory.txtSearch, incomecategory.DataSet.tblIncome, "cName", incomecategory)


                slt(incomecategory.CNameTextBox, incomecategory.RemarkTextBox)
                slt(incomecategory.CNameTextBox1, incomecategory.CTextBox)
                slt(incomecategory.CTextBox, incomecategory.RemarkTextBox1)

                dt(incomecategory.TblIncomeCategoryDataGridView)
                dt(incomecategory.TblIncomeSubcategoryDataGridView)
                incomecategory.TblIncomeCategoryDataGridView.ColumnHeadersHeight = 50
                incomecategory.TblIncomeSubcategoryDataGridView.ColumnHeadersHeight = 50

                Dim t As New Timer
                t.Interval = 500
                t.Start()
                AddHandler t.Tick, Function()

                                       incomecategory.TblIncomeSubcategoryBindingSource.Filter = "c LIKE '%" & incomecategory.CNameTextBox.Text & "%'"
                                       If incomecategory.TblIncomeCategoryBindingSource.Count = 0 Then
                                           incomecategory.GroupBox2.Enabled = False
                                       Else

                                           incomecategory.GroupBox2.Enabled = True
                                       End If

                                       If incomecategory.TblIncomeCategoryBindingSource.Count = 0 Then
                                           incomecategory.ToolStrip1.Enabled = False
                                       Else
                                           incomecategory.ToolStrip1.Enabled = True
                                       End If
                                       Return 0
                                   End Function
                incomecategory.Panel2.Enabled = False
                incomecategory.Panel3.Enabled = False
                incomecategory.TblIncomeCategoryBindingSource.RemoveFilter()

            ElseIf i = 21 Then
                managesale.txtFilter.SelectedIndex = 0
                If (managesale.txtSearch.AutoCompleteCustomSource.Count = (managesale.DataSet.tblInvoice.Rows.Count * 4)) = False Then
                    autot(managesale.txtSearch, managesale.DataSet.tblInvoice, "invoiceNo", managesale)
                    autot(managesale.txtSearch, managesale.DataSet.tblInvoice, "shopName", managesale)
                    autot(managesale.txtSearch, managesale.DataSet.tblInvoice, "contactNumber", managesale)
                    autot(managesale.txtSearch, managesale.DataSet.tblInvoice, "date", managesale)
                End If

                dt(managesale.TblSalesDataGridView)
                dt(managesale.TblInvoiceDataGridView)

                Dim t As New Timer
                t.Interval = 500
                t.Start()
                AddHandler t.Tick, Function()
                                       Try
                                           managesale.TblSalesBindingSource.Filter = "invoiceNo =" & managesale.InvoiceNoTextBox.Text
                                       Catch ex As Exception

                                       End Try
                                       Return 0
                                   End Function
                '  managesale.TblInvoiceTableAdapter.Fill(managesale.DataSet.tblInvoice)
                managesale.TblInvoiceBindingSource.RemoveFilter()
                If managesale.TblInvoiceBindingSource.Count = 0 Then
                    managesale.Enabled = False
                Else
                    managesale.Enabled = True
                End If

            ElseIf i = 22 Then
                dt(manageasset.TblassetDataGridView)
                'selection
                slt(manageasset.AssetNameTextBox, manageasset.QuantityTextBox)
                slt(manageasset.QuantityTextBox, manageasset.UnitpriceTextBox)
                slt(manageasset.UnitpriceTextBox, manageasset.PriceTextBox)


                manageasset.Button2.Enabled = False
                manageasset.Panel2.Enabled = False
                manageasset.GroupBox1.Text = "New asset"
                manageasset.Button1.Text = "Add"
                AddHandler asset_timer.Tick, Function()
                                                 manageasset.tool.Items(0).Text = "মোট সম্পদঃ " & dtsum(manageasset.TblassetDataGridView, 3) & dashboard.CurrencyTextBox.Text
                                                 Return 0
                                             End Function
                asset_timer.Start()
                manageasset.TblassetBindingSource.RemoveFilter()
                If manageasset.TblassetBindingSource.Count = 0 Then
                    manageasset.Enabled = False
                Else
                    manageasset.Enabled = True
                End If
            ElseIf i = 23 Then
                managebankaccount.txtFilter.SelectedIndex = 0

                slt(managebankaccount.AccountHolderNameTextBox, managebankaccount.BankTextBox)
                slt(managebankaccount.BankTextBox, managebankaccount.BranchTextBox)
                slt(managebankaccount.BranchTextBox, managebankaccount.AccountNumberTextBox)
                slt(managebankaccount.AccountNumberTextBox, managebankaccount.OpeningBalanceTextBox)

                dt(managebankaccount.TblBankAccountsDataGridView)

                managebankaccount.TblBankAccountsBindingSource.RemoveFilter()
                If managebankaccount.TblBanksBindingSource.Count = 0 Then
                    managebankaccount.Enabled = False
                Else
                    managebankaccount.Enabled = True
                End If
                auto(managebankaccount.BankTextBox, managebankaccount.DataSet.tblBanks, "bankName")
                managebankaccount.Panel2.Enabled = False
                AddHandler bank_acc_timer.Tick, Function()
                                                    managebankaccount.tool.Items(0).Text = "মোট ব্যাংক ব্যালেন্সঃ " & dtsum(managebankaccount.TblBankAccountsDataGridView, 4) & dashboard.CurrencyTextBox.Text
                                                    Return 0
                                                End Function
                bank_acc_timer.Start()
            ElseIf i = 24 Then
                managedamage.txtFilter.SelectedIndex = 0

                autot(managedamage.txtSearch, managedamage.DataSet.tblDamageProducts, "product_name", managedamage)
                autot(managedamage.txtSearch, managedamage.DataSet.tblDamageProducts, "product_code", managedamage)
                autot(managedamage.txtSearch, managedamage.DataSet.tblDamageProducts, "product_category", managedamage)
                autot(managedamage.txtSearch, managedamage.DataSet.tblDamageProducts, "company", managedamage)
                autot(managedamage.txtSearch, managedamage.DataSet.tblDamageProducts, "damage_date", managedamage)

                dt(managedamage.TblDamageProductsDataGridView)

                managedamage.txtFilter.SelectedIndex = 0
                managedamage.txtSearch.Clear()
                managedamage.TblDamageProductsBindingSource.RemoveFilter()
                If managedamage.TblDamageProductsBindingSource.Count = 0 Then
                    managedamage.Enabled = False
                Else
                    managedamage.Enabled = True
                End If

                damage_timer.Start()
                AddHandler damage_timer.Tick, Function()
                                                  managedamage.tool.Items(0).Text = "মোট ড্যামেজ পণ্যঃ " & dtsum(managedamage.TblDamageProductsDataGridView, 6) & all.dashboard.CurrencyTextBox.Text
                                                  Return 0
                                              End Function
            ElseIf i = 25 Then
                manageemployee.txtFilter.SelectedIndex = 0


                autot(manageemployee.txtSearch, manageemployee.DataSet.tblEmployee, "Id", manageemployee)
                autot(manageemployee.txtSearch, manageemployee.DataSet.tblEmployee, "employeeName", manageemployee)
                autot(manageemployee.txtSearch, manageemployee.DataSet.tblEmployee, "address", manageemployee)
                autot(manageemployee.txtSearch, manageemployee.DataSet.tblEmployee, "NIDNumber", manageemployee)
                autot(manageemployee.txtSearch, manageemployee.DataSet.tblEmployee, "contactNumber", manageemployee)
                autot(manageemployee.txtSearch, manageemployee.DataSet.tblEmployee, "joinDate", manageemployee)

                dt(manageemployee.TblEmployeeDataGridView)
                manageemployee.txtSearch.Clear()
                manageemployee.TblEmployeeBindingSource.RemoveFilter()

                If manageemployee.TblEmployeeBindingSource.Count = 0 Then
                    manageemployee.Enabled = False
                Else
                    manageemployee.Enabled = True
                End If
            ElseIf i = 26 Then
                manageexpense.txtFilter.SelectedIndex = 0


                autot(manageexpense.txtSearch, manageexpense.DataSet.tblExpenses, "personName", manageexpense)
                autot(manageexpense.txtSearch, manageexpense.DataSet.tblExpenses, "expenseCategory", manageexpense)
                autot(manageexpense.txtSearch, manageexpense.DataSet.tblExpenses, "expenseSubCategory", manageexpense)
                autot(manageexpense.txtSearch, manageexpense.DataSet.tblExpenses, "date", manageexpense)

                dt(manageexpense.TblExpensesDataGridView)
                manageexpense.TblExpensesBindingSource.RemoveFilter()

                If manageexpense.TblExpensesBindingSource.Count = 0 Then
                    manageexpense.Enabled = False
                Else
                    manageexpense.Enabled = True
                End If

                manage_expense_timer.Start()
                manage_expense_timer.Interval = 500
                AddHandler manage_expense_timer.Tick, Function()
                                                          Try
                                                              manageexpense.tool.Items(0).Text = "মোট ব্যয়ঃ " & dtsum(manageexpense.TblExpensesDataGridView, 3) + dtsum(manageexpense.TblExpensesDataGridView, 4) & all.dashboard.CurrencyTextBox.Text
                                                              manageexpense.tool.Items(2).Text = "ব্যাংকে ব্যয়ঃ " & dtsum(manageexpense.TblExpensesDataGridView, 4) & all.dashboard.CurrencyTextBox.Text
                                                              manageexpense.tool.Items(4).Text = "ক্যাশে ব্যয়ঃ " & dtsum(manageexpense.TblExpensesDataGridView, 3) & all.dashboard.CurrencyTextBox.Text
                                                          Catch ex As Exception

                                                          End Try
                                                          Return 0
                                                      End Function
            ElseIf i = 27 Then
                managefridge.txtFilter.SelectedIndex = 0

                dt(managefridge.TblFridgesDataGridView)

                autot(managefridge.txtSearch, managefridge.DataSet.tblFridges, "fridgeModelNo", managefridge)
                autot(managefridge.txtSearch, managefridge.DataSet.tblFridges, "supplierName", managefridge)
                autot(managefridge.txtSearch, managefridge.DataSet.tblFridges, "issueDate", managefridge)
                autot(managefridge.txtSearch, managefridge.DataSet.tblFridges, "fridgeID", managefridge)

                managefridge.GroupBox2.Left = (managefridge.ClientSize.Width / 2) - (managefridge.GroupBox2.Width / 2)

                If managefridge.TblFridgesBindingSource.Count = 0 Then
                    managefridge.Enabled = False
                Else
                    managefridge.Enabled = True
                End If


            ElseIf i = 28 Then
                manageincome.txtFilter.SelectedIndex = 0
                manageincome.txtSearch.Clear()

                autot(manageincome.txtSearch, manageincome.DataSet.tblIncome, "incomeCategory", manageincome)
                autot(manageincome.txtSearch, manageincome.DataSet.tblIncome, "incomeSubCategory", manageincome)
                autot(manageincome.txtSearch, manageincome.DataSet.tblIncome, "date", manageincome)

                dt(manageincome.TblIncomeDataGridView)
                manageincome.TblIncomeBindingSource.RemoveFilter()
                If manageincome.TblIncomeBindingSource.Count = 0 Then
                    manageincome.Enabled = False
                Else
                    manageincome.Enabled = True
                End If

                manage_income_timer.Start()
                manage_income_timer.Interval = 1000
                AddHandler manage_income_timer.Tick, Function()
                                                         manageincome.tool.Items(0).Text = "মোট আয়ঃ " & dtsum(manageincome.TblIncomeDataGridView, 2) + dtsum(manageincome.TblIncomeDataGridView, 3) & all.dashboard.CurrencyTextBox.Text
                                                         manageincome.tool.Items(2).Text = "ব্যাংকে আয়ঃ " & dtsum(manageincome.TblIncomeDataGridView, 3) & all.dashboard.CurrencyTextBox.Text
                                                         manageincome.tool.Items(4).Text = "ক্যাশে আয়ঃ  " & dtsum(manageincome.TblIncomeDataGridView, 2) & all.dashboard.CurrencyTextBox.Text
                                                         Return 0
                                                     End Function
            ElseIf i = 29 Then
                manageproduct.txtFilter.SelectedIndex = 0


                autot(manageproduct.txtSearch, manageproduct.DataSet.tblProducts, "productName", manageproduct)
                autot(manageproduct.txtSearch, manageproduct.DataSet.tblProducts, "productCode", manageproduct)
                autot(manageproduct.txtSearch, manageproduct.DataSet.tblProducts, "productCategory", manageproduct)
                autot(manageproduct.txtSearch, manageproduct.DataSet.tblProducts, "supplier", manageproduct)

                dt(manageproduct.TblProductsDataGridView)
                manageproduct.txtSearch.Clear()
                manageproduct.TblProductsBindingSource.RemoveFilter()

                If manageproduct.TblProductsBindingSource.Count = 0 Then
                    manageproduct.Enabled = False
                Else
                    manageproduct.Enabled = True
                End If

                manageproduct.TblProductsBindingSource.RemoveFilter()
                manageproduct.TblProductsBindingSource.MoveFirst()


                manageproduct.TblProductsBindingSource.MoveFirst()

                AddHandler product_timer.Tick, Function()
                                                   stock_search()
                                                   products_value()
                                                   Return 0
                                               End Function
                product_timer.Start()

            ElseIf i = 30 Then
                managepurchase.txtFilter.SelectedIndex = 0


                autot(managepurchase.txtSearch, managepurchase.DataSet.tblPurchaseInvoice, "supplier", managepurchase)
                autot(managepurchase.txtSearch, managepurchase.DataSet.tblPurchaseInvoice, "invoiceNo", managepurchase)
                autot(managepurchase.txtSearch, managepurchase.DataSet.tblPurchaseInvoice, "companyInvoice", managepurchase)
                autot(managepurchase.txtSearch, managepurchase.DataSet.tblPurchaseInvoice, "date", managepurchase)

                money_index(managepurchase.TblPurchaseInvoiceDataGridView, 3)
                money_index(managepurchase.TblPurchaseInvoiceDataGridView, 5)
                money_index(managepurchase.TblPurchaseInvoiceDataGridView, 6)
                money_index(managepurchase.TblPurchaseInvoiceDataGridView, 7)

                Dim t As New Timer
                t.Interval = 500
                t.Start()
                AddHandler t.Tick, Function()
                                       Try
                                           If managepurchase.TblPurchaseBindingSource.Count > 0 Then
                                               managepurchase.TblPurchaseBindingSource.Filter = "invoiceNo =" & managepurchase.InvoiceNoTextBox.Text
                                           End If
                                       Catch ex As Exception

                                       End Try
                                       Return 0
                                   End Function

                dt(managepurchase.TblPurchaseInvoiceDataGridView)
                dt(managepurchase.TblPurchaseDataGridView)
                managepurchase.TblPurchaseInvoiceBindingSource.RemoveFilter()
                If managepurchase.TblPurchaseInvoiceBindingSource.Count = 0 Then
                    managepurchase.Enabled = False
                Else
                    managepurchase.Enabled = True
                End If


            ElseIf i = 31 Then

                dt(managestock.TblProductsDataGridView)


            ElseIf i = 32 Then
                managesupplier.txtFilter.SelectedIndex = 0
                managesupplier.txtSearch.Clear()

                autot(managesupplier.txtSearch, managesupplier.DataSet.tblSuppliers, "supplierName", managesupplier)
                autot(managesupplier.txtSearch, managesupplier.DataSet.tblSuppliers, "contactPerson", managesupplier)
                autot(managesupplier.txtSearch, managesupplier.DataSet.tblSuppliers, "address", managesupplier)
                autot(managesupplier.txtSearch, managesupplier.DataSet.tblSuppliers, "contactNumber", managesupplier)
                autot(managesupplier.txtSearch, managesupplier.DataSet.tblSuppliers, "supplierID", managesupplier)

                dt(managesupplier.TblSuppliersDataGridView)

                managesupplier.txtSearch.Clear()
                managesupplier.TblSuppliersBindingSource.RemoveFilter()

                If managesupplier.TblSuppliersBindingSource.Count = 0 Then
                    managesupplier.Enabled = False
                Else
                    managesupplier.Enabled = True
                End If


            ElseIf i = 33 Then
                paymentmethod(managetransaction.PaymentMethodComboBox)
                paymentmethod(managetransaction.PaymentmethodComboBox1)

                'selection
                managetransaction.txtFilter.SelectedIndex = 0
                managetransaction.txtSearch.Clear()
                slt(managetransaction.TransactionIDTextBox, managetransaction.AccNoTextBox)
                slt(managetransaction.AccNoTextBox, managetransaction.AmountTextBox)
                slt(managetransaction.AmountTextBox, managetransaction.PersonOrsourceTextBox)
                slt(managetransaction.PersonOrsourceTextBox, managetransaction.NoteTextBox)

                managetransaction.GroupBox1.Text = "New transaction"
                managetransaction.Panel2.Enabled = False
                managetransaction.Button1.Text = "Add"

                num(managetransaction.AmountTextBox)

                dt(managetransaction.TblTransactionDataGridView)
                auto(managetransaction.AccNoTextBox, managetransaction.DataSet.tblBankAccounts, "accountNumber")
                auto(managetransaction.PersonOrsourceTextBox, managetransaction.DataSet.tblEmployee, "employeeName")
                auto(managetransaction.PersonOrsourceTextBox, managetransaction.DataSet.tblCustomers, "customerName")
                auto(managetransaction.PersonOrsourceTextBox, managetransaction.DataSet.tblSuppliers, "supplierName")

                autot(managetransaction.txtSearch, managetransaction.DataSet.tblTransaction, "transactionID", managetransaction)
                autot(managetransaction.txtSearch, managetransaction.DataSet.tblTransaction, "accNo", managetransaction)
                autot(managetransaction.txtSearch, managetransaction.DataSet.tblTransaction, "date", managetransaction)

                managetransaction.TblTransactionBindingSource.RemoveFilter()
                If managetransaction.TblBankAccountsBindingSource.Count = 0 Then
                    managetransaction.Enabled = False
                Else
                    managetransaction.Enabled = True
                End If

                Try
                    Dim t As New Timer
                    t.Start()
                    AddHandler t.Tick, Function()
                                           If managetransaction.Panel2.Enabled = True Then
                                               If managetransaction.TransactionTypeTextBox.Text = "Deposit" Then
                                                   managetransaction.rdnD.Checked = True
                                               ElseIf managetransaction.TransactionTypeTextBox.Text = "Withdraw" Then
                                                   managetransaction.rdnW.Checked = True
                                               End If
                                           End If
                                           Return 0
                                       End Function



                Catch ex As Exception

                End Try
                'send to expese/receive from income function
                managetransaction.chk_expense.Checked = False
                managetransaction.chk_income.Checked = False

                Dim chk_timer As New Timer
                chk_timer.Start()
                AddHandler chk_timer.Tick, Function()
                                               If managetransaction.rdnW.Checked = True Then
                                                   managetransaction.chk_expense.Enabled = True
                                                   managetransaction.chk_income.Enabled = False
                                                   managetransaction.chk_income.Checked = False
                                               Else
                                                   managetransaction.chk_expense.Enabled = False
                                                   managetransaction.chk_expense.Checked = False
                                                   managetransaction.chk_income.Enabled = True
                                               End If

                                               Return 0
                                           End Function
                managetransaction.transaction_count()

                'transaction count

            ElseIf i = 34 Then
                'selection
                newexpense.ExpenseSubCategoryComboBox.Select()
                sltc(newexpense.ExpenseCategoryComboBox, newexpense.ExpenseSubCategoryComboBox)
                sltc(newexpense.ExpenseSubCategoryComboBox, newexpense.PaymentMethodComboBox)
                slta(newexpense.PaymentMethodComboBox, newexpense.AmountTextBox)
                slt(newexpense.AmountTextBox, newexpense.PersonNameTextBox)
                'slt(newexpense.BankamountTextBox, newexpense.AccNoTextBox)
                'slt(newexpense.AccNoTextBox, newexpense.PersonNameTextBox)
                slt(newexpense.PersonNameTextBox, newexpense.ExpenseNoteTextBox)


                newexpense.DateTimePicker1.ResetText()
                autoc(newexpense.ExpenseCategoryComboBox, newexpense.DataSet.tblExpenseCategory, "cName")
                autoc(newexpense.ExpenseSubCategoryComboBox, newexpense.DataSet.tblExpenseSubcategory, "cName")
                auto(newexpense.txtEmployeeName, newexpense.DataSet.tblEmployee, "employeeName")
                auto(newexpense.txtEmployeeID, newexpense.DataSet.tblEmployee, "Id")
                auto(newexpense.PersonNameTextBox, newexpense.DataSet.tblEmployee, "employeeName")

                newexpense.chkES.Checked = False
                newexpense.chkEE.Checked = False
                newexpense.txtEmployeeName.Clear()
                newexpense.txtEmployeeID.Clear()
                newexpense.txtEmployeeName.Enabled = False
                newexpense.txtEmployeeID.Enabled = False
                num(newexpense.AmountTextBox)
                num(newexpense.BankamountTextBox)
                num(newexpense.txtEmployeeID)

                paymentmethod(newexpense.PaymentMethodComboBox)
                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If newexpense.PaymentMethodComboBox.SelectedIndex = 0 Then
                                           newexpense.AmountTextBox.ReadOnly = False
                                           newexpense.BankamountTextBox.ReadOnly = True
                                           newexpense.AccNoTextBox.ReadOnly = True
                                           newexpense.BankamountTextBox.Text = 0
                                       ElseIf newexpense.PaymentMethodComboBox.SelectedIndex = 1 Then
                                           newexpense.AmountTextBox.ReadOnly = True
                                           newexpense.BankamountTextBox.ReadOnly = False
                                           newexpense.AccNoTextBox.ReadOnly = False
                                           newexpense.AmountTextBox.Text = 0
                                       ElseIf newexpense.PaymentMethodComboBox.SelectedIndex = 2 Then
                                           newexpense.AmountTextBox.ReadOnly = False
                                           newexpense.BankamountTextBox.ReadOnly = False
                                           newexpense.AccNoTextBox.ReadOnly = False
                                       Else
                                           newexpense.AmountTextBox.ReadOnly = True
                                           newexpense.BankamountTextBox.ReadOnly = True
                                           newexpense.AccNoTextBox.ReadOnly = True
                                           newexpense.AmountTextBox.Text = 0
                                           newexpense.BankamountTextBox.Text = 0
                                       End If
                                       If newexpense.chkEE.Checked = True Or newexpense.chkES.Checked = True Then
                                           newexpense.PersonNameTextBox.ReadOnly = True
                                           newexpense.txtEmployeeName.ReadOnly = False
                                           newexpense.txtEmployeeID.ReadOnly = False
                                       Else
                                           newexpense.PersonNameTextBox.ReadOnly = False
                                           newexpense.txtEmployeeName.ReadOnly = True
                                           newexpense.txtEmployeeID.ReadOnly = True
                                       End If
                                       Return 0
                                   End Function
                If newexpense.TblExpenseCategoryBindingSource.Count = 0 Then
                    newexpense.Enabled = False
                Else
                    newexpense.Enabled = True
                End If
                newexpense.ConfirmatoinTextBox.Clear()
            ElseIf i = 35 Then

                'selection
                newincome.PaymentmethodComboBox.SelectedIndex = 0
                newincome.IncomeCategoryComboBox.Select()
                sltc(newincome.IncomeCategoryComboBox, newincome.IncomeSubcategoryComboBox)
                sltc(newincome.IncomeSubcategoryComboBox, newincome.PaymentmethodComboBox)
                slta(newincome.PaymentmethodComboBox, newincome.AmountTextBox)
                slt(newincome.AmountTextBox, newincome.BankamountTextBox)
                slt(newincome.BankamountTextBox, newincome.AccNoTextBox)
                slt(newincome.AccNoTextBox, newincome.IncomeNoteTextBox)
                newincome.datt.ResetText()

                autoc(newincome.IncomeCategoryComboBox, newincome.DataSet.tblIncomeCategory, "cName")
                autoc(newincome.IncomeSubcategoryComboBox, newincome.DataSet.tblIncomeSubcategory, "cName")

                num(newincome.AmountTextBox)
                num(newincome.BankamountTextBox)

                paymentmethod(newincome.PaymentmethodComboBox)

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If newincome.PaymentmethodComboBox.SelectedIndex = 0 Then
                                           newincome.AmountTextBox.ReadOnly = False
                                           newincome.AccNoTextBox.ReadOnly = True
                                           newincome.BankamountTextBox.ReadOnly = True
                                           newincome.BankamountTextBox.Text = 0
                                       ElseIf newincome.PaymentmethodComboBox.SelectedIndex = 1 Then
                                           newincome.AmountTextBox.ReadOnly = True
                                           newincome.AccNoTextBox.ReadOnly = False
                                           newincome.BankamountTextBox.ReadOnly = False
                                           newincome.AmountTextBox.Text = 0
                                       ElseIf newincome.PaymentmethodComboBox.SelectedIndex = 2 Then
                                           newincome.AmountTextBox.ReadOnly = False
                                           newincome.AccNoTextBox.ReadOnly = False
                                           newincome.BankamountTextBox.ReadOnly = False
                                       Else
                                           newincome.AmountTextBox.ReadOnly = True
                                           newincome.AccNoTextBox.ReadOnly = True
                                           newincome.BankamountTextBox.ReadOnly = True
                                           newincome.AmountTextBox.Text = 0
                                           newincome.BankamountTextBox.Text = 0
                                       End If
                                       Return 0
                                   End Function

                If newincome.TblIncomeCategoryBindingSource.Count = 0 Then
                    newincome.Enabled = False
                Else
                    newincome.Enabled = True
                End If
            ElseIf i = 36 Then
                dt(newpurchase.TblPurchaseDataGridView)
                'newpurchase.chk.Checked = False

                'selection
                newpurchase.SupplierTextBox.Select()
                slt(newpurchase.SupplierTextBox, newpurchase.CompanyInvoiceTextBox)
                'slt(newpurchase.InvoiceNoTextBox, newpurchase.CompanyInvoiceTextBox)
                slt(newpurchase.CompanyInvoiceTextBox, newpurchase.ProductNameTextBox)
                slt(newpurchase.ProductNameTextBox, newpurchase.QuantityTextBox)
                'slt(newpurchase.txt_category, newpurchase.QuantityTextBox)
                slt(newpurchase.QuantityTextBox, newpurchase.Discount_percentTextBox)
                'slt(newpurchase.UnitPriceTextBox, newpurchase.NetPriceTextBox)
                'slt(newpurchase.NetPriceTextBox, newpurchase.PaidTextBox1)
                'sltb(newpurchase.TotalAmountTextBox, newpurchase.PaymentmethodComboBox)
                'slta(newpurchase.PaymentmethodComboBox, newpurchase.PaidTextBox1)
                slt(newpurchase.Discount_percentTextBox, newpurchase.PaidTextBox1)
                slt(newpurchase.PaidTextBox1, newpurchase.DueTextBox1)
                'slt(newpurchase.BankamountTextBox, newpurchase.AccNoTextBox)
                'slt(newpurchase.AccNoTextBox, newpurchase.DueTextBox1)

                newpurchase.DateTextBox1.Text = newpurchase.date_picker.Value.Date

                'newpurchase.chk.Checked = False
                'newpurchase.chk.Enabled = True

                num(newpurchase.TotalAmountTextBox)
                num(newpurchase.PaidTextBox1)
                num(newpurchase.DueTextBox1)
                num(newpurchase.QuantityTextBox)
                num(newpurchase.UnitPriceTextBox)
                num(newpurchase.NetPriceTextBox)
                num(newpurchase.Discount_percentTextBox)

                'auto
                auto(newpurchase.SupplierTextBox, newpurchase.DataSet.tblSuppliers, "supplierName")
                auto(newpurchase.txtSupplierID, newpurchase.DataSet.tblSuppliers, "supplierID")
                auto(newpurchase.ProductNameTextBox, newpurchase.DataSet.tblProducts, "productName")
                auto(newpurchase.ProductCodeTextBox, newpurchase.DataSet.tblProducts, "productCode")

                newpurchase_timer.Interval = 500
                newpurchase_timer.Start()
                AddHandler newpurchase_timer.Tick, Function()
                                                       newpurchase.InvoiceNoTextBox1.Text = newpurchase.InvoiceNoTextBox.Text
                                                       Try
                                                           newpurchase.TblPurchaseBindingSource.Filter = "invoiceNo ='" & newpurchase.InvoiceNoTextBox.Text & "'"


                                                           If newpurchase.PaymentmethodComboBox.SelectedIndex = 0 Then
                                                               newpurchase.PaidTextBox1.ReadOnly = False
                                                               newpurchase.BankamountTextBox.ReadOnly = True
                                                               newpurchase.AccNoTextBox.ReadOnly = True
                                                               newpurchase.BankamountTextBox.Text = 0
                                                           ElseIf newpurchase.PaymentmethodComboBox.SelectedIndex = 1 Then
                                                               newpurchase.PaidTextBox1.ReadOnly = True
                                                               newpurchase.BankamountTextBox.ReadOnly = False
                                                               newpurchase.AccNoTextBox.ReadOnly = False
                                                               newpurchase.PaidTextBox1.Text = 0
                                                           ElseIf newpurchase.PaymentmethodComboBox.SelectedIndex = 2 Then
                                                               newpurchase.PaidTextBox1.ReadOnly = False
                                                               newpurchase.BankamountTextBox.ReadOnly = False
                                                               newpurchase.AccNoTextBox.ReadOnly = False
                                                           Else
                                                               newpurchase.PaidTextBox1.ReadOnly = True
                                                               newpurchase.BankamountTextBox.ReadOnly = True
                                                               newpurchase.AccNoTextBox.ReadOnly = True
                                                               newpurchase.PaidTextBox1.Text = 0
                                                               newpurchase.BankamountTextBox.Text = 0
                                                           End If
                                                           If newpurchase.TblPurchaseBindingSource.Count > 0 Then
                                                               newpurchase.cart_remove_button.Enabled = True
                                                           Else
                                                               newpurchase.cart_remove_button.Enabled = False
                                                           End If
                                                       Catch ex As Exception

                                                       End Try
                                                       Return 0
                                                   End Function
                If newpurchase.TblProductsBindingSource.Count = 0 Then
                    newpurchase.Enabled = False
                Else
                    newpurchase.Enabled = True
                End If
                paymentmethod(newpurchase.PaymentmethodComboBox)



                newpurchase.Panel1.Top = (newpurchase.Panel2.ClientSize.Height / 2) - ((newpurchase.Panel1.Height / 2) - 15)
                newpurchase.Panel1.Left = (newpurchase.Panel2.ClientSize.Width / 2) - (newpurchase.Panel1.Width / 2)
                newpurchase.Label1.Text = "Purchase invoice (" & Form1.Label1.Text & ")"

                newpurchase.KeyPreview = True
                'edit/modify mode
                AddHandler purchase_checker.Tick, Function()
                                                      If newpurchase.mode = 0 Then
                                                          newpurchase.GroupBox1.Enabled = True
                                                          newpurchase.GroupBox2.Enabled = True
                                                          newpurchase.cart_remove_button.Enabled = True
                                                      Else
                                                          newpurchase.GroupBox1.Enabled = False
                                                          newpurchase.GroupBox2.Enabled = False
                                                          newpurchase.cart_remove_button.Enabled = False
                                                      End If
                                                      Return 0
                                                  End Function
                purchase_checker.Start()
                newpurchase.purchase_mng()
            ElseIf i = 37 Then
                newsale.tata.Stop()
                Dim thd As New Threading.Thread(Sub()
                                                    newsale.chk_sell_on.Checked = False
                                                    newsale.chk_discount.Checked = False
                                                    newsale.cmbmethod.SelectedIndex = 0
                                                    'Form1.TblCompanySettingsTableAdapter.Fill(Form1.DataSet.tblCompanySettings)
                                                    'newsale.Label1.Text = "বিক্রয় রশিদ " & vbNewLine & Form1.CompanyNameTextBox.Text

                                                    newsale.DateTextBox.Text = Date.Today
                                                    newsale.datt.ResetText()
                                                    'selection

                                                    slt(newsale.InvoiceNoTextBox, newsale.ShopNameTextBox)
                                                    slt(newsale.ShopNameTextBox, newsale.DriverNameTextBox)
                                                    slt(newsale.DriverNameTextBox, newsale.ProductNameTextBox)
                                                    slt(newsale.ProductNameTextBox, newsale.QuantityTextBox)
                                                    slt(newsale.QuantityTextBox, newsale.PadiTextBox)
                                                    slt(newsale.DiscountTextBox1, newsale.NetPriceTextBox)
                                                    slt(newsale.NetPriceTextBox, newsale.PadiTextBox)
                                                    slt(newsale.PadiTextBox, newsale.DueTextBox)
                                                    '''''''


                                                    If (newsale.CustomerNameTextBox.AutoCompleteCustomSource.Count = newsale.DataSet.tblCustomers.Rows.Count) = False Then
                                                        auto(newsale.ShopNameTextBox, newsale.DataSet.tblCustomers, "shopOrCompanyName")
                                                        auto(newsale.txtCustomerID, newsale.DataSet.tblCustomers, "customerID")
                                                    End If

                                                    If (newsale.ProductNameTextBox.AutoCompleteCustomSource.Count = newsale.DataSet.tblProducts.Rows.Count) = False Then
                                                        auto(newsale.ProductNameTextBox, newsale.DataSet.tblProducts, "productName")
                                                        auto(newsale.txtProductID, newsale.DataSet.tblProducts, "productCode")
                                                    End If
                                                    If (newsale.DriverNameTextBox.AutoCompleteCustomSource.Count = newsale.DataSet.tblVehicle.Rows.Count) = False Then
                                                        auto(newsale.DriverNameTextBox, newsale.DataSet.tblVehicle, "driverName")
                                                        auto(newsale.VehicleIDTextBox, newsale.DataSet.tblVehicle, "vehicleID")
                                                    End If




                                                    phn(newsale.ContactNumberTextBox)
                                                    num(newsale.TotalAmountTextBox)
                                                    num(newsale.DiscountTextBox)
                                                    num(newsale.GrandTotalTextBox)
                                                    num(newsale.PadiTextBox)
                                                    num(newsale.DueTextBox)
                                                    num(newsale.QuantityTextBox)
                                                    num(newsale.UnitPriceTextBox)
                                                    num(newsale.NetPriceTextBox)
                                                    num(newsale.AvailableTextBox)
                                                    num(newsale.VehicleIDTextBox)
                                                    num(newsale.txtCustomerID)
                                                    num(newsale.dsct)
                                                    num(newsale.DiscountTextBox1)


                                                    dt(newsale.TblSalesDataGridView)
                                                    newsale.pnlSale.Top = (newsale.pnl.ClientSize.Height / 2) - ((newsale.pnlSale.Height / 2))
                                                    newsale.pnlSale.Left = (newsale.pnl.ClientSize.Width / 2) - (newsale.pnlSale.Width / 2)

                                                    newsale.KeyPreview = True
                                                    newsale.txt_category.Clear()


                                                    If newsale.TblProductsBindingSource.Count = 0 Then
                                                        newsale.Enabled = False
                                                    Else
                                                        newsale.Enabled = True
                                                    End If

                                                    paymentmethod(newsale.cmbmethod)
                                                End Sub)

                thd.Start()
                newsale.ShopNameTextBox.Select()










                'edit/modifying mode
                AddHandler sale_checker.Tick, Function()
                                                  If newsale.mode = 0 Then
                                                      newsale.GroupBox1.Enabled = True
                                                      newsale.GroupBox2.Enabled = True
                                                      newsale.cart_remove_button.Enabled = True
                                                  Else
                                                      newsale.GroupBox1.Enabled = False
                                                      newsale.GroupBox2.Enabled = False
                                                      newsale.cart_remove_button.Enabled = False
                                                  End If
                                                  If newsale.mode = 0 AndAlso newsale.Is_disTextBox.Text = "1" Then
                                                      newsale.chk_discount.Checked = True
                                                  Else
                                                      newsale.chk_discount.Checked = False
                                                  End If
                                                  If newsale.mode = 0 AndAlso newsale.Is_comTextBox.Text = "1" Then
                                                      newsale.chk_sell_on.Checked = True
                                                  Else
                                                      newsale.chk_sell_on.Checked = False
                                                  End If
                                                  Return 0
                                              End Function

                'sale_checker.Start()
                newsale.tata.Start()
            ElseIf i = 38 Then
                dt(productcommission.TblSCommissionDataGridView)
                dt(productcommission.TblSupplierAccountsDataGridView)


                'status confirmation
                'sales commission
                'productcommission.TblSCommissionBindingSource.RemoveFilter()
                'productcommission.TblSCommissionBindingSource.MoveFirst()

                'For a = 0 To productcommission.TblSCommissionBindingSource.Count - 1
                '    If Integer.Parse(productcommission.TargetQuantityTextBox.Text) = Integer.Parse(productcommission.QuantityTextBox.Text) Then
                '        productcommission.StatusTextBox.Text = "Completed"
                '    Else
                '        productcommission.StatusTextBox.Text = "Not completed"
                '    End If
                '    productcommission.TblSCommissionBindingSource.MoveNext()
                'Next


                'purchase commission
                'productcommission.TblPCommissionBindingSource.RemoveFilter()
                'productcommission.TblPCommissionBindingSource.MoveFirst()

                'For b = 0 To productcommission.TblPCommissionBindingSource.Count - 1
                '    If Integer.Parse(productcommission.TargetQuantityTextBox1.Text) = Integer.Parse(productcommission.QuantityTextBox1.Text) Then
                '        productcommission.StatusTextBox1.Text = "Completed"
                '    Else
                '        productcommission.StatusTextBox1.Text = "Not completed"
                '    End If
                '    productcommission.TblPCommissionBindingSource.MoveNext()
                'Next

                If productcommission.TblSCommissionBindingSource.Count = 0 Then
                    productcommission.TabPage1.Enabled = False
                Else
                    productcommission.TabPage1.Enabled = True
                End If

                If productcommission.TblSupplierAccountsBindingSource.Count = 0 Then
                    productcommission.TabPage2.Enabled = False
                Else
                    productcommission.TabPage2.Enabled = True
                End If

                dat(productcommission.fromDt, productcommission.toDt)
                productcommission.txtfilter.SelectedIndex = 0
                productcommission.txtfilterp.SelectedIndex = 0

                product_commission_timer.Interval = 500
                product_commission_timer.Start()
                AddHandler product_commission_timer.Tick, Function()
                                                              Try
                                                                  productcommission.tool.Items(1).Text = "Total amount paid: " & dtsum(productcommission.TblSupplierAccountsDataGridView, 3)
                                                                  If productcommission.txtCommission.Text.Length > 0 Then
                                                                      productcommission.tool.Items(0).Text = "Total commission: " & prc(dtsum(productcommission.TblSupplierAccountsDataGridView, 3), Double.Parse(productcommission.txtCommission.Text))
                                                                  Else
                                                                      productcommission.tool.Items(0).Text = "Total commission: 0"
                                                                  End If
                                                              Catch ex As Exception

                                                              End Try
                                                              Try
                                                                  productcommission.tool1.Items(2).Text = "Total amount paid: " & dtsum(productcommission.TblSCommissionDataGridView, 4)
                                                                  productcommission.tool1.Items(0).Text = "Total discount (amount): " & dtsum(productcommission.TblSCommissionDataGridView, 5)
                                                              Catch ex As Exception

                                                              End Try
                                                              Return 0
                                                          End Function
            ElseIf i = 39 Then
                'selection
                productdelivery.SaleInvoiceTextBox.Select()
                slt(productdelivery.SaleInvoiceTextBox, productdelivery.CustomerNameTextBox)
                slt(productdelivery.CustomerNameTextBox, productdelivery.ShippingAddressTextBox)
                slt(productdelivery.ShippingAddressTextBox, productdelivery.ContactNumberTextBox)
                slt(productdelivery.ContactNumberTextBox, productdelivery.DriverNameTextBox)
                slt(productdelivery.DriverNameTextBox, productdelivery.DeliveryChargeTextBox)

                num(productdelivery.SaleInvoiceTextBox)
                num(productdelivery.VehicleIDTextBox)
                num(productdelivery.DeliveryChargeTextBox)
                phn(productdelivery.ContactNumberTextBox)

                auto(productdelivery.CustomerNameTextBox, productdelivery.DataSet.tblCustomers, "customerName")
                auto(productdelivery.DriverNameTextBox, productdelivery.DataSet.tblVehicle, "driverName")
                auto(productdelivery.SaleInvoiceTextBox, productdelivery.DataSet.tblInvoice, "invoiceNo")

                dt(productdelivery.TblDeliveryDataGridView)
                productdelivery.Panel2.Enabled = False

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If productdelivery.ConfirmationTextBox.Text = "Confirmed" Then
                                           productdelivery.ToolStripButton2.Enabled = False
                                       Else
                                           productdelivery.ToolStripButton2.Enabled = True
                                       End If
                                       Return 0
                                   End Function


                productdelivery.chk_show_pending.Checked = False
                'delivery count
                'non-confirmed delivery count
                productdelivery.TblDeliveryBindingSource.Filter = "confirmation LIKE '%Not confirmed%'"
                productdelivery.lblpending.Text = "Total pending deliveries: " & productdelivery.TblDeliveryBindingSource.Count
                'confirmed delivery count
                productdelivery.TblDeliveryBindingSource.Filter = "confirmation LIKE '%Confirmed%' AND date LIKE '%" & Today & "%'"
                productdelivery.lbldelivered.Text = "Today delivered invoices: " & productdelivery.TblDeliveryBindingSource.Count

                productdelivery.TblDeliveryBindingSource.RemoveFilter()


            ElseIf i = 40 Then
                dt(productcategory.TblProductCategoryDataGridView)

                productcategory.txtfilter.SelectedIndex = 0
                slt(productcategory.CNameTextBox, productcategory.RemarkTextBox)
                autot(productcategory.txtsearch, productcategory.DataSet.tblProductCategory, "cName", productcategory)

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If productcategory.TblProductCategoryBindingSource.Count = 0 Then
                                           productcategory.ToolStrip1.Enabled = False
                                       Else
                                           productcategory.ToolStrip1.Enabled = True
                                       End If
                                       Return 0
                                   End Function
            ElseIf i = 41 Then
                Try
                    dt(profitcalculator.TblProfitDataGridView)

                    'generate
                    profitcalculator.TblProfitBindingSource.Filter = "date ='" & Date.Today & "'"
                    While profitcalculator.TblProfitBindingSource.Count <> 0
                        profitcalculator.TblProfitBindingSource.RemoveCurrent()
                    End While


                    'calculate income, expense, profit etc.
                    Dim Nincome As Double = 0
                    Dim Nexpense As Double = 0
                    Dim Nprofit As Double = 0
                    Dim Nbalance As Double = 0
                    Dim Nbankbalance As Double = 0
                    Dim NDrdue As Double = 0
                    Dim NCrdue As Double = 0
                    Dim Nasset As Double = 0
                    Dim bank_withdraw As Double = 0
                    Dim bank_deposit As Double = 0
                    Dim cash_withdraw As Double = 0
                    Dim damage_product As Double = 0
                    Dim total_sale As Double = 0
                    Dim total_purchase As Double = 0
                    Dim available_products_value As Double = 0
                    Dim available_products_market_value As Double = 0
                    Dim total_given_discount As Double = 0
                    Dim daily_debit_due As Double = 0
                    Dim daily_credit_due As Double = 0
                    Dim old_cash_balance As Double = 0
                    Dim daily_revenue As Double = 0
                    Dim daily_earned_commission As Double = 0
                    Dim delivery_expense As Double = 0
                    Dim expense_without_purchase As Double = 0


                    'filling process
                    profitcalculator.TblBankAccountsTableAdapter.Fill(profitcalculator.DataSet.tblBankAccounts)
                    profitcalculator.TblCusomterAccountsTableAdapter.Fill(profitcalculator.DataSet.tblCusomterAccounts)
                    profitcalculator.TblIncomeTableAdapter.Fill(profitcalculator.DataSet.tblIncome)
                    profitcalculator.TblRentCTableAdapter.Fill(profitcalculator.DataSet.tblRentC)
                    profitcalculator.TblTransactionTableAdapter.Fill(profitcalculator.DataSet.tblTransaction)
                    profitcalculator.TblEmployeeAccountsTableAdapter.Fill(profitcalculator.DataSet.tblEmployeeAccounts)
                    profitcalculator.TblExpenseReportTableAdapter.Fill(profitcalculator.DataSet.tblExpenseReport)
                    profitcalculator.TblExpensesTableAdapter.Fill(profitcalculator.DataSet.tblExpenses)
                    profitcalculator.TblRentSTableAdapter.Fill(profitcalculator.DataSet.tblRentS)
                    profitcalculator.TblSupplierAccountsTableAdapter.Fill(profitcalculator.DataSet.tblSupplierAccounts)
                    profitcalculator.TblFridgesTableAdapter.Fill(profitcalculator.DataSet.tblFridges)
                    profitcalculator.TblwithdrawTableAdapter.Fill(profitcalculator.DataSet.tblwithdraw)
                    profitcalculator.TblassetTableAdapter.Fill(profitcalculator.DataSet.tblasset)
                    profitcalculator.TblDeliveryTableAdapter.Fill(profitcalculator.DataSet.tblDelivery)
                    profitcalculator.TblVehicleTableAdapter.Fill(profitcalculator.DataSet.tblVehicle)
                    profitcalculator.TblsellcommissionTableAdapter.Fill(profitcalculator.DataSet.tblsellcommission)
                    profitcalculator.TbldiscountTableAdapter.Fill(profitcalculator.DataSet.tbldiscount)
                    'filling and loading process
                    fll(53)
                    ld(53)
                    fll(28)
                    ld(28)
                    fll(33)
                    ld(33)
                    fll(25)
                    ld(25)
                    fll(17)
                    ld(17)
                    fll(32)
                    ld(32)
                    fll(27)
                    ld(27)
                    fll(60)
                    ld(60)
                    fll(22)
                    ld(22)
                    fll(39)
                    ld(39)
                    fll(63)
                    ld(63)
                    fll(70)
                    ld(70)
                    fll(72)
                    ld(72)
                    'filtering process
                    profitcalculator.TblCusomterAccountsBindingSource.Filter = "date <='" & Today & "'"
                    profitcalculator.TblIncomeBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblRentCBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblFridgesBindingSource.Filter = "rentedAt ='" & Today & "'"
                    profitcalculator.TblEmployeeAccountsBindingSource.Filter = "date <='" & Today & "'"
                    profitcalculator.TblExpenseReportBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblExpensesBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblRentSBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblSupplierAccountsBindingSource.Filter = "date <='" & Today & "'"
                    profitcalculator.TblwithdrawBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblassetBindingSource.Filter = "issueDate ='" & Today & "' AND bc LIKE '%New%'"
                    profitcalculator.TblDeliveryBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblVehicleBindingSource.Filter = "issueDate ='" & Today & "' AND bc LIKE '%New%'"
                    profitcalculator.TblsellcommissionBindingSource.Filter = "confirmation_date ='" & Today & "' AND confirmation LIKE '%Yes%'"
                    profitcalculator.TbldiscountBindingSource.Filter = "confirmation_date ='" & Today & "' AND  confirmation LIKE '%Yes%'"

                    'filtering process1
                    profitcalculator.TblTransactionBindingSource.Filter = "date ='" & Today & "' AND transactionType LIKE '%Withdraw%'"


                    Nincome = (
                              dtsum(profitcalculator.TblIncomeDataGridView, 0) + dtsum(profitcalculator.TblIncomeDataGridView, 1) +
                              dtsum(profitcalculator.TblFridgesDataGridView, 0) +
                              dtsum(profitcalculator.TblsellcommissionDataGridView, 0) +
                              dtsum(profitcalculator.TbldiscountDataGridView, 0)
                               )
                    'filtering process 2
                    profitcalculator.TblTransactionBindingSource.Filter = "date ='" & Today & "' AND transactionType LIKE '%Deposit%'"
                    Nexpense = (dtsum(profitcalculator.TblExpensesDataGridView, 0) + dtsum(profitcalculator.TblExpensesDataGridView, 1) +
                               dtsum(profitcalculator.TblwithdrawDataGridView, 0) +
                               dtsum(profitcalculator.TblassetDataGridView, 0) +
                               dtsum(profitcalculator.TblFridgesDataGridView, 1) +
                               dtsum(profitcalculator.TblDeliveryDataGridView, 0) +
                               dtsum(profitcalculator.TblVehicleDataGridView, 0)
                               )
                    Nprofit = (Nincome - Nexpense)

                    'Nbalance = (Nprofit -
                    '         dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    '         )
                    'filtering process 2
                    profitcalculator.TblTransactionBindingSource.Filter = "date ='" & Today & "' AND transactionType LIKE '%Withdraw%'"
                    bank_withdraw = dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    Nbalance = (Nprofit +
                               dtsum(profitcalculator.TblTransactionDataGridView, 0)
                               )
                    profitcalculator.TblTransactionBindingSource.Filter = "date ='" & Today & "' AND transactionType LIKE '%Deposit%'"
                    bank_deposit = dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    Nbalance -= dtsum(profitcalculator.TblTransactionDataGridView, 0)


                    'deposit/withdraw
                    Dim balance_deposit As Double = 0
                    Dim balance_withdraw As Double = 0
                    profitcalculator.TblTransactionBindingSource.Filter = "date ='" & Today & "' AND transactionType LIKE '%Deposit%'"
                    balance_deposit = dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    profitcalculator.TblTransactionBindingSource.Filter = "date ='" & Today & "' AND transactionType LIKE '%Withdraw%'"
                    balance_deposit = dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    'bank balance
                    profitcalculator.TblTransactionBindingSource.Filter = "date <='" & Today & "' AND transactionType LIKE '%Deposit%'"
                    balance_deposit = dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    Nbankbalance += dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    profitcalculator.TblTransactionBindingSource.Filter = "date <='" & Today & "' AND transactionType LIKE '%Withdraw%'"
                    balance_deposit = dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    Nbankbalance -= dtsum(profitcalculator.TblTransactionDataGridView, 0)
                    'filter removing process
                    profitcalculator.TblCusomterAccountsBindingSource.RemoveFilter()
                    profitcalculator.TblRentCBindingSource.RemoveFilter()
                    profitcalculator.TblEmployeeAccountsBindingSource.RemoveFilter()
                    profitcalculator.TblSupplierAccountsBindingSource.RemoveFilter()
                    profitcalculator.TblRentSBindingSource.RemoveFilter()
                    profitcalculator.TblsellcommissionBindingSource.RemoveFilter()
                    profitcalculator.TbldiscountBindingSource.RemoveFilter()
                    'dues filter
                    profitcalculator.TblRentCBindingSource.Filter = "date <='" & Today & "'"
                    profitcalculator.TblRentSBindingSource.Filter = "date <='" & Today & "'"

                    NDrdue = dtsum(profitcalculator.TblCusomterAccountsDataGridView, 1) +
                             dtsum(profitcalculator.TblRentCDataGridView, 1)

                    NCrdue = dtsum(profitcalculator.TblSupplierAccountsDataGridView, 1) +
                             dtsum(profitcalculator.TblRentSDataGridView, 1)
                    'removing new purchased asset and vehicles filter
                    profitcalculator.TblassetBindingSource.RemoveFilter()
                    profitcalculator.TblVehicleBindingSource.RemoveFilter()

                    'asset filter
                    profitcalculator.TblassetBindingSource.Filter = "issueDate <='" & Today & "'"
                    profitcalculator.TblVehicleBindingSource.Filter = "issueDate <='" & Today & "'"
                    Nasset = dtsum(profitcalculator.TblassetDataGridView, 0) +
                    dtsum(profitcalculator.TblVehicleDataGridView, 0)

                    'others filtering

                    'add todays profit
                    profitcalculator.Invoke(New MethodInvoker(Sub()
                                                                  profitcalculator.TblProfitBindingSource.AddNew()
                                                              End Sub))

                    'others
                    cash_withdraw = dtsum(profitcalculator.TblwithdrawDataGridView, 0)
                    'damage product filter

                    profitcalculator.TblExpensesBindingSource.Filter = "expenseCategory LIKE '%Damage product%' And Date ='" & Today & "'"

                                                                                  damage_product = dtsum(profitcalculator.TblExpensesDataGridView, 0)
                    'sales filter
                    'profitcalculator.TblIncomeBindingSource.Filter = "date ='" & Today & "' AND incomeNote LIKE '%Income from sale%'"
                    profitcalculator.TblInvoiceBindingSource.Filter = "date ='" & Today & "'"
                    total_sale = dtsum(profitcalculator.TblInvoiceDataGridView, 4) 'dtsum(profitcalculator.TblInvoiceDataGridView, 0) + dtsum(profitcalculator.TblInvoiceDataGridView, 1) + dtsum(profitcalculator.TblInvoiceDataGridView, 2)
                    'purchase filter
                    'profitcalculator.TblExpensesBindingSource.Filter = "Date ='" & Today & "' AND expenseNote LIKE '%Expense for purchase%'"
                    profitcalculator.TblPurchaseInvoiceBindingSource.Filter = "date ='" & Today & "'"
                    total_purchase = dtsum(profitcalculator.TblPurchaseInvoiceDataGridView, 0) + dtsum(profitcalculator.TblPurchaseInvoiceDataGridView, 1)

                    'total given discount
                    profitcalculator.TbldiscountBindingSource.Filter = "date ='" & Today & "'"
                                                                                  total_given_discount = dtsum(profitcalculator.TbldiscountDataGridView, 0)
                    'due filter
                    profitcalculator.TblSupplierAccountsBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblCusomterAccountsBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblRentCBindingSource.Filter = "date ='" & Today & "'"
                    profitcalculator.TblRentSBindingSource.Filter = "date ='" & Today & "'"
                    daily_debit_due = dtsum(profitcalculator.TblCusomterAccountsDataGridView, 1) +
                             dtsum(profitcalculator.TblRentCDataGridView, 1)

                    daily_credit_due = dtsum(profitcalculator.TblSupplierAccountsDataGridView, 1) +
                             dtsum(profitcalculator.TblRentSDataGridView, 1)
                    'earned commission
                    profitcalculator.TblsellcommissionBindingSource.Filter = "date ='" & Today & "'"
                    daily_earned_commission = dtsum(profitcalculator.TblsellcommissionDataGridView, 0)

                    'delivery expense
                    profitcalculator.TblExpensesBindingSource.Filter = "date ='" & Today & "' AND expenseCategory LIKE '%Delivery expenses%'"
                    delivery_expense = dtsum(profitcalculator.TblExpensesDataGridView, 0)
                    'revenue
                    profitcalculator.TblSalesBindingSource.Filter = "date ='" & Today & "'"
                    'generate revenue
                    Dim revenue As Double = 0
                    profitcalculator.TblSalesBindingSource.Filter = "date >='" & profitcalculator.fromDt.Value.Date & "' AND date <='" & profitcalculator.toDt.Value.Date & "'"
                    For a As Integer = 0 To profitcalculator.TblSalesBindingSource.Count - 1
                        Try
                            revenue += prc((Double.Parse(profitcalculator.TblSalesDataGridView.Rows(a).Cells(1).Value.ToString) * Double.Parse(profitcalculator.TblSalesDataGridView.Rows(a).Cells(0).Value.ToString)), profitcalculator.TblSalesDataGridView.Rows(a).Cells(2).Value.ToString)
                        Catch ex As Exception

                        End Try
                    Next

                    'put other inputs
                    profitcalculator.Bank_withdrawTextBox.Text = bank_withdraw
                    profitcalculator.Bank_depositTextBox.Text = bank_deposit
                    profitcalculator.Cash_withdrawTextBox.Text = cash_withdraw
                    profitcalculator.Damage_productTextBox.Text = damage_product
                    profitcalculator.Total_saleTextBox.Text = total_sale
                    profitcalculator.Total_purchaseTextBox.Text = total_purchase
                    profitcalculator.Total_given_discountTextBox.Text = total_given_discount

                    profitcalculator.Daily_debit_dueTextBox.Text = daily_debit_due
                    profitcalculator.Daily_credit_dueTextBox.Text = daily_credit_due
                    profitcalculator.Daily_revenueTextBox.Text = revenue
                    profitcalculator.Earned_commissionTextBox.Text = daily_earned_commission
                    profitcalculator.Delivery_expenseTextBox.Text = delivery_expense




                    'put input
                    profitcalculator.DateTextBox.Text = Today
                    profitcalculator.IncomeTextBox.Text = Nincome
                    profitcalculator.ExpenseTextBox.Text = Nexpense
                    profitcalculator.ProfitTextBox.Text = Nprofit
                    profitcalculator.BalanceTextBox.Text = Nbalance

                    profitcalculator.BankBalanceTextBox.Text = Nbankbalance
                    profitcalculator.DrdueTextBox.Text = NDrdue
                    profitcalculator.CrdueTextBox.Text = NCrdue
                    profitcalculator.AssetTextBox.Text = Nasset

                    profitcalculator.Validate()
                    profitcalculator.TblProfitBindingSource.EndEdit()
                    profitcalculator.TableAdapterManager.UpdateAll(profitcalculator.DataSet)



                    profitcalculator.fromDt.ResetText()
                    profitcalculator.toDt.ResetText()
                    dat(profitcalculator.fromDt, profitcalculator.toDt)

                    profitcalculator.TblProfitBindingSource.RemoveFilter()




                    'clear unneccessery data
                    clear_unneccessery_data(profitcalculator.TblProfitBindingSource, profitcalculator.TblProfitDataGridView, 0)
                    'ended
                    profitcalculator.Validate()
                    profitcalculator.TblProfitBindingSource.EndEdit()
                    profitcalculator.TableAdapterManager.UpdateAll(profitcalculator.DataSet)


                    Dim t As New Timer
                    t.Interval = 500
                    AddHandler t.Tick, Function()
                                           Try
                                               profitcalculator.lbl_income.Text = "আয়" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 1)
                                               profitcalculator.lbl_expense.Text = "ব্যয়" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 2)
                                               '   profitcalculator.lbl_profit.Text = "ক্যাশ" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 3)
                                               profitcalculator.lbl_cash_balance.Text = "ক্যাশ ব্যালেন্স" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 8)
                                               profitcalculator.lbl_bank_deposit.Text = "ব্যাংক ডিপোজিট" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 10)
                                               profitcalculator.lbl_bank_withdraw.Text = "ব্যাংক উইথ-ড্র" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 9)
                                               profitcalculator.lbl_damageproduct.Text = "ড্যামেজ প্রোডাক্ট" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 12)
                                               'need to generate expense without purchase, and damage products

                                               profitcalculator.lbl_expense_without_purchase.Text = "ক্রয়ব্যতিত ব্যয়" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 2) - dtsum(profitcalculator.TblProfitDataGridView, 14)
                                               profitcalculator.lbl_sale.Text = "বিক্রয়" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 13)
                                               profitcalculator.lbl_purchase.Text = "ক্রয়" & vbNewLine & dtsum(profitcalculator.TblProfitDataGridView, 14)
                                           Catch ex As Exception

                                           End Try

                                           Return 0
                                       End Function

                    t.Start()


                    'total status

                Catch ex As Exception

                End Try
            ElseIf i = 42 Then
                dt(purchasereport.TblPurchaseReportDataGridView)
                purchasereport.txtFilter.SelectedIndex = 0

                Try
                    purchasereport.TblPurchaseReportBindingSource.Filter = "date = '" & Today & "'"
                    purchasereport.TblPurchaseReportBindingSource.MoveFirst()
                    While purchasereport.TblPurchaseReportBindingSource.Count <> 0
                        purchasereport.TblPurchaseReportBindingSource.RemoveCurrent()
                    End While

                    purchasereport.TblProductsBindingSource.RemoveFilter()
                    purchasereport.TblProductsBindingSource.MoveFirst()
                    purchasereport.TblPurchaseBindingSource.Filter = "date = '" & Today & "'"
                    purchasereport.TblPurchaseBindingSource.MoveFirst()
                    For a = 0 To purchasereport.TblProductsBindingSource.Count - 1
                        purchasereport.TblPurchaseBindingSource.Filter = "productCode =" & purchasereport.ProductCodeTextBox.Text & " AND date = '" & Date.Today & "'"
                        If purchasereport.TblPurchaseBindingSource.Count > 0 Then
                            purchasereport.TblPurchaseReportBindingSource.AddNew()
                            purchasereport.DateTextBox.Text = Date.Today
                            purchasereport.ProductNameTextBox.Text = purchasereport.ProductNameTextBox1.Text
                            purchasereport.ProductCodeTextBox1.Text = purchasereport.ProductCodeTextBox.Text
                            purchasereport.QuantityTextBox.Text = dtsum(purchasereport.TblPurchaseDataGridView, 0)
                            purchasereport.AmountTextBox.Text = dtsum(purchasereport.TblPurchaseDataGridView, 1)
                        End If
                        purchasereport.TblProductsBindingSource.MoveNext()
                    Next

                    purchasereport.Validate()
                    purchasereport.TblPurchaseReportBindingSource.EndEdit()
                    purchasereport.TableAdapterManager.UpdateAll(purchasereport.DataSet)

                    purchasereport.TblPurchaseBindingSource.RemoveFilter()
                    purchasereport.TblPurchaseReportBindingSource.RemoveFilter()

                    'unneccessery data clear
                    clear_unneccessery_data(purchasereport.TblPurchaseReportBindingSource, purchasereport.TblPurchaseReportDataGridView, 0)
                    'ended

                    purchase_report_timer.Start()
                    AddHandler purchase_report_timer.Tick, Function()
                                                               Try
                                                                   purchasereport.tool.Items(0).Text = "মোট মূল্যঃ " & dtsum(purchasereport.TblPurchaseReportDataGridView, 4) & all.dashboard.CurrencyTextBox.Text
                                                               Catch ex As Exception

                                                               End Try
                                                               Return 0
                                                           End Function
                Catch ex As Exception

                End Try

                purchasereport.fromDt.ResetText()
                purchasereport.toDt.ResetText()
                dat(purchasereport.fromDt, purchasereport.toDt)

                If purchasereport.TblProductsBindingSource.Count = 0 Then
                    purchasereport.Enabled = False
                Else
                    purchasereport.Enabled = True
                End If
            ElseIf i = 43 Then

            ElseIf i = 44 Then
                'selection
                rentto.chkS.Checked = False
                rentto.txtID.Select()
                slt(rentto.txtID, rentto.RentTOTextBox)
                slt(rentto.RentTOTextBox, rentto.SecurityMoneyTextBox)
                slt(rentto.SecurityMoneyTextBox, rentto.MonthlyRentTextBox)

                rentto.RentedAtTextBox.Text = Date.Today

                auto(rentto.txtID, rentto.DataSet.tblFridges, "fridgeID")
                auto(rentto.RentTOTextBox, rentto.DataSet.tblCustomers, "shopOrCompanyName")
                auto(rentto.CID, rentto.DataSet.tblCustomers, "customerID")

                num(rentto.SecurityMoneyTextBox)
                num(rentto.MonthlyRentTextBox)

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If rentto.TblFridgesBindingSource.Count = 0 Then
                                           rentto.Panel2.Enabled = False
                                       Else
                                           rentto.Panel2.Enabled = True
                                       End If
                                       Return 0
                                   End Function
            ElseIf i = 45 Then
                auto(returndamage.ProductNameTextBox, managedamage.DataSet.tblDamageProducts, "productName")
                auto(returndamage.ProdcutCategoryTextBox, managedamage.DataSet.tblDamageProducts, "prodcutCategory")

                'selection
                returndamage.ProductNameTextBox.Select()
                slt(returndamage.ProductNameTextBox, returndamage.ProdcutCategoryTextBox)
                slt(returndamage.ProdcutCategoryTextBox, returndamage.SupplierTextBox)
                slt(returndamage.SupplierTextBox, returndamage.txt)

                num(returndamage.txt)

                If returndamage.TblDamageProductsBindingSource.Count = 0 Then
                    returndamage.Enabled = False
                Else
                    returndamage.Enabled = True
                End If
            ElseIf i = 46 Then


                dt(salesreport.TblSalesreportDataGridView)

                    salesreport.TblSalesreportBindingSource.Filter = "date ='" & Today & "'"

                    While salesreport.TblSalesreportBindingSource.Count <> 0
                        salesreport.TblSalesreportBindingSource.RemoveCurrent()
                    End While
                    'get paid amounts
                    salesreport.TblIncomeTableAdapter.Fill(salesreport.DataSet.tblIncome)
                    salesreport.TblIncomeBindingSource.Filter = "date ='" & Today & "' AND incomeNote LIKE '%Income from sale%'"

                    'c1
                    salesreport.TblInvoiceBindingSource.RemoveFilter()
                    salesreport.TblInvoiceBindingSource.MoveFirst()
                    salesreport.TblInvoiceBindingSource.Filter = "date ='" & Today & "'"
                If salesreport.TblInvoiceBindingSource.Count > 0 Then
                    salesreport.TblSalesreportBindingSource.AddNew()
                    salesreport.DateTextBox.Text = Date.Today
                    salesreport.Total_saleTextBox.Text = dtsum(salesreport.TblInvoiceDataGridView, 0)
                    salesreport.DiscountTextBox.Text = dtsum(salesreport.TblInvoiceDataGridView, 1)
                    salesreport.Net_saleTextBox.Text = dtsum(salesreport.TblInvoiceDataGridView, 2)
                    salesreport.Paid_amountTextBox.Text = (dtsum(salesreport.TblIncomeDataGridView, 0) + dtsum(salesreport.TblIncomeDataGridView, 1))
                    salesreport.DueTextBox1.Text = dtsum(salesreport.TblInvoiceDataGridView, 4)
                End If


                salesreport.Validate()
                    salesreport.TblSalesreportBindingSource.EndEdit()
                    salesreport.TableAdapterManager.UpdateAll(salesreport.DataSet)

                    salesreport.TblSalesreportBindingSource.RemoveFilter()
                    salesreport.TblInvoiceBindingSource.RemoveFilter()

                    salesreport.fromDt.ResetText()
                    salesreport.toDt.ResetText()
                    dat(salesreport.fromDt, salesreport.toDt)

                    If salesreport.TblInvoiceBindingSource.Count = 0 Then
                        salesreport.Enabled = False
                    Else
                        salesreport.Enabled = True
                    End If


                'clear unneccessery data
                salesreport.TblSalesreportBindingSource.RemoveFilter()
                clear_unneccessery_data(salesreport.TblSalesreportBindingSource, salesreport.TblSalesreportDataGridView, 0)

                sales_report_timer.Start()
                sales_report_timer.Interval = 500
                AddHandler sales_report_timer.Tick, Function()
                                                        Try
                                                            salesreport.tool.Items(8).Text = "মোট বিক্রয়ঃ " & dtsum(salesreport.TblSalesreportDataGridView, 1) & all.dashboard.CurrencyTextBox.Text
                                                            salesreport.tool.Items(6).Text = "ডিসকাউন্টঃ " & dtsum(salesreport.TblSalesreportDataGridView, 2) & all.dashboard.CurrencyTextBox.Text
                                                            salesreport.tool.Items(4).Text = "নিট বিক্রয়ঃ " & dtsum(salesreport.TblSalesreportDataGridView, 3) & all.dashboard.CurrencyTextBox.Text
                                                            salesreport.tool.Items(2).Text = "আদায়ঃ " & dtsum(salesreport.TblSalesreportDataGridView, 4) & all.dashboard.CurrencyTextBox.Text
                                                            salesreport.tool.Items(0).Text = "বাকিঃ " & dtsum(salesreport.TblSalesreportDataGridView, 5) & all.dashboard.CurrencyTextBox.Text
                                                        Catch ex As Exception

                                                        End Try
                                                        Return 0
                                                    End Function


            ElseIf i = 47 Then
                dt(supplieraccount.TblSupplierAccountsDataGridView)

                supplieraccount.txtFilter.SelectedIndex = 0


                autot(supplieraccount.txtSearch, supplieraccount.DataSet.tblSupplierAccounts, "supplierName", supplieraccount)
                autot(supplieraccount.txtSearch, supplieraccount.DataSet.tblSupplierAccounts, "supplierID", supplieraccount)
                autot(supplieraccount.txtSearch, supplieraccount.DataSet.tblSupplierAccounts, "purchaseInvoice", supplieraccount)

                supplieraccount.fromDt.ResetText()
                supplieraccount.toDt.ResetText()
                dat(supplieraccount.fromDt, supplieraccount.toDt)

                If supplieraccount.TblSupplierAccountsBindingSource.Count = 0 Then
                    supplieraccount.Enabled = False
                Else
                    supplieraccount.Enabled = True
                End If

                company_accounts_timer.Stop()
                company_accounts_timer.Start()
                'clear unnneccessery data
                clear_unneccessery_data(supplieraccount.TblSupplierAccountsBindingSource, supplieraccount.TblSupplierAccountsDataGridView, 6)
                'ended
                AddHandler company_accounts_timer.Tick, Function()
                                                            supplieraccount.tool.Items(4).Text = "মোট পাওনাঃ " & dtsum(supplieraccount.TblSupplierAccountsDataGridView, 3) & all.dashboard.CurrencyTextBox.Text
                                                            supplieraccount.tool.Items(2).Text = "পরিশোধঃ " & dtsum(supplieraccount.TblSupplierAccountsDataGridView, 4) & all.dashboard.CurrencyTextBox.Text
                                                            supplieraccount.tool.Items(0).Text = "বাকিঃ " & dtsum(supplieraccount.TblSupplierAccountsDataGridView, 5) & all.dashboard.CurrencyTextBox.Text
                                                            Return 0
                                                        End Function

            ElseIf i = 48 Then
                'blank
            ElseIf i = 49 Then

                useraccounts.txtFilter.SelectedIndex = 0
                dt(useraccounts.TblUserDataGridView)

                autot(useraccounts.txtSearch, useraccounts.DataSet.tblUser, "userName", useraccounts)
                autot(useraccounts.txtSearch, useraccounts.DataSet.tblUser, "userID", useraccounts)
                autot(useraccounts.txtSearch, useraccounts.DataSet.tblUser, "address", useraccounts)
                autot(useraccounts.txtSearch, useraccounts.DataSet.tblUser, "phone", useraccounts)

                useraccounts.GroupBox1.Left = (useraccounts.ClientSize.Width / 2) - (useraccounts.GroupBox1.Width / 2)

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If useraccounts.ProductsTextBox.Text = "1" Then
                                           useraccounts.chkProducts.Checked = True
                                       Else
                                           useraccounts.chkProducts.Checked = False
                                       End If
                                       If useraccounts.PurchaseTextBox.Text = "1" Then
                                           useraccounts.chkPurchase.Checked = True
                                       Else
                                           useraccounts.chkPurchase.Checked = False
                                       End If
                                       If useraccounts.SalesTextBox.Text = "1" Then
                                           useraccounts.chkSales.Checked = True
                                       Else
                                           useraccounts.chkSales.Checked = False
                                       End If
                                       If useraccounts.FridgeTextBox.Text = "1" Then
                                           useraccounts.chkFridge.Checked = True
                                       Else
                                           useraccounts.chkFridge.Checked = False
                                       End If
                                       If useraccounts.IncomeTextBox.Text = "1" Then
                                           useraccounts.chkIncome.Checked = True
                                       Else
                                           useraccounts.chkIncome.Checked = False
                                       End If
                                       If useraccounts.ExpensesTextBox.Text = "1" Then
                                           useraccounts.chkExpenses.Checked = True
                                       Else
                                           useraccounts.chkExpenses.Checked = False
                                       End If
                                       If useraccounts.BankTransactionTextBox.Text = "1" Then
                                           useraccounts.chkTransaction.Checked = True
                                       Else
                                           useraccounts.chkTransaction.Checked = False
                                       End If
                                       If useraccounts.ReportsNdateTextBox.Text = "1" Then
                                           useraccounts.chkReports.Checked = True
                                       Else
                                           useraccounts.chkReports.Checked = False
                                       End If
                                       If useraccounts.OthersTextBox.Text = "1" Then
                                           useraccounts.chkOthers.Checked = True
                                       Else
                                           useraccounts.chkOthers.Checked = False
                                       End If
                                       Return 0
                                   End Function
                AddHandler useraccounts.GroupBox1.MouseLeave, Function()
                                                                  t.Start()
                                                                  useraccounts.Validate()
                                                                  useraccounts.TblUserBindingSource.EndEdit()
                                                                  useraccounts.TableAdapterManager.UpdateAll(useraccounts.DataSet)
                                                                  Return 0
                                                              End Function
                AddHandler useraccounts.GroupBox1.MouseEnter, Function()
                                                                  t.Stop()
                                                                  Return 0
                                                              End Function
            ElseIf i = 50 Then
                login.TblUserTableAdapter.Fill(login.DataSet.tblUser)
                'selection
                login.txtUserID.Select()
                slt(login.txtUserID, login.txtUserPass)
                sltb(login.txtUserPass, login.txtUserRole)
                autoc(login.txtUserRole, login.DataSet.tblUser, "role")



            ElseIf i = 51 Then
                customeraccount.txtFilter.SelectedIndex = 0
                dt(customeraccount.TblCusomterAccountsDataGridView)

                'auto
                autot(customeraccount.txtSearch, customeraccount.DataSet.tblCusomterAccounts, "customerName", customeraccount)
                autot(customeraccount.txtSearch, customeraccount.DataSet.tblCusomterAccounts, "customerID", customeraccount)
                autot(customeraccount.txtSearch, customeraccount.DataSet.tblCusomterAccounts, "saleInvoice", customeraccount)

                'st(customeraccount.sold_product.tool, customeraccount.TblCusomterAccountsDataGridView, 3, 4, 5)
                customeraccount.fromDt.ResetText()
                customeraccount.toDt.ResetText()
                dat(customeraccount.fromDt, customeraccount.toDt)
                customeraccount.txtSearch.Clear()

                customeraccount.TblCusomterAccountsBindingSource.RemoveFilter()
                If customeraccount.TblCusomterAccountsBindingSource.Count = 0 Then
                    customeraccount.Enabled = False
                Else
                    customeraccount.Enabled = True
                End If
                'clear unneccessery data
                clear_unneccessery_data(customeraccount.TblCusomterAccountsBindingSource, customeraccount.TblCusomterAccountsDataGridView, 6)
                'ended      
                customer_accounts_timer.Interval = 500
                customer_accounts_timer.Start()
                AddHandler customer_accounts_timer.Tick, Function()
                                                             Try
                                                                 customeraccount.tool.Items(4).Text = "মোট দেনাঃ " & dtsum(customeraccount.TblCusomterAccountsDataGridView, 3) & all.dashboard.CurrencyTextBox.Text
                                                                 customeraccount.tool.Items(2).Text = "আদায়ঃ " & dtsum(customeraccount.TblCusomterAccountsDataGridView, 4) & all.dashboard.CurrencyTextBox.Text
                                                                 customeraccount.tool.Items(0).Text = "বাকিঃ " & dtsum(customeraccount.TblCusomterAccountsDataGridView, 5) & all.dashboard.CurrencyTextBox.Text
                                                             Catch ex As Exception

                                                             End Try
                                                             Return 0
                                                         End Function

            ElseIf i = 52 Then

                transactionreport.txtFilter.SelectedIndex = 0
                dt(transactionreport.TblTransactionReportDataGridView)

                transactionreport.TblBankAccountsTableAdapter.Fill(transactionreport.DataSet.tblBankAccounts)
                transactionreport.TblTransactionTableAdapter.Fill(transactionreport.DataSet.tblTransaction)
                transactionreport.TblTransactionReportTableAdapter.Fill(transactionreport.DataSet.tblTransactionReport)



                auto(transactionreport.txtSearch, transactionreport.DataSet.tblTransactionReport, "accountNO")
                auto(transactionreport.txtSearch, transactionreport.DataSet.tblTransactionReport, "bankName")
                auto(transactionreport.txtSearch, transactionreport.DataSet.tblTransactionReport, "branch")


                'generate
                transactionreport.TblTransactionReportBindingSource.Filter = "date = '" & Today & "'"
                While transactionreport.TblTransactionReportBindingSource.Count <> 0
                    transactionreport.TblTransactionReportBindingSource.RemoveCurrent()
                End While

                transactionreport.TblBankAccountsBindingSource.RemoveFilter()
                transactionreport.TblBankAccountsBindingSource.MoveFirst()

                For a = 0 To transactionreport.TblBankAccountsBindingSource.Count - 1
                    transactionreport.TblTransactionBindingSource.Filter = "accNo LIKE '%" & transactionreport.AccountNumberTextBox.Text & "%' AND date = '" & Today & "'"

                    If transactionreport.TblTransactionBindingSource.Count > 0 Then
                        transactionreport.TblTransactionReportBindingSource.AddNew()
                        transactionreport.DateTextBox.Text = Date.Today
                        transactionreport.AccountNOTextBox.Text = transactionreport.AccountNumberTextBox.Text
                        transactionreport.BankNameTextBox.Text = transactionreport.BankTextBox.Text
                        transactionreport.BranchTextBox.Text = transactionreport.BranchTextBox1.Text
                        transactionreport.TblTransactionBindingSource.Filter = "accNo LIKE '%" & transactionreport.AccountNumberTextBox.Text & "%' AND transactionType LIKE '%Withdraw%' AND date ='" & Today & "'"
                        If transactionreport.TblTransactionBindingSource.Count > 0 Then
                            transactionreport.DrAmountTextBox.Text = dtsum(transactionreport.TblTransactionDataGridView, 0)
                        Else
                            transactionreport.DrAmountTextBox.Text = 0
                        End If
                        transactionreport.TblTransactionBindingSource.Filter = "accNo LIKE '%" & transactionreport.AccountNumberTextBox.Text & "%' AND transactionType LIKE '%Deposit%' AND date ='" & Today & "'"
                        If transactionreport.TblTransactionBindingSource.Count > 0 Then
                            transactionreport.CrAmountTextBox.Text = dtsum(transactionreport.TblTransactionDataGridView, 0)
                        Else
                            transactionreport.CrAmountTextBox.Text = 0
                        End If
                        transactionreport.BalanceTextBox.Text = transactionreport.OpeningBalanceTextBox.Text

                        transactionreport.Validate()
                        transactionreport.TblTransactionReportBindingSource.EndEdit()
                        transactionreport.TableAdapterManager.UpdateAll(transactionreport.DataSet)
                    End If
                    transactionreport.TblBankAccountsBindingSource.MoveNext()
                Next




                transactionreport.TblTransactionReportBindingSource.RemoveFilter()
                transactionreport.TblTransactionBindingSource.RemoveFilter()

                transactionreport.fromDt.ResetText()
                transactionreport.toDt.ResetText()
                dat(transactionreport.fromDt, transactionreport.toDt)
                transactionreport.TblTransactionReportBindingSource.RemoveFilter()
                'enability
                If transactionreport.TblTransactionBindingSource.Count = 0 Then
                    transactionreport.Enabled = False
                Else
                    transactionreport.Enabled = True
                End If

                'clear unneccessery data
                clear_unneccessery_data(transactionreport.TblTransactionReportBindingSource, transactionreport.TblTransactionReportDataGridView, 0)
                'ended
                Dim t As New Timer
                AddHandler t.Tick, Function()
                                       Try
                                           transactionreport.tool.Items(2).Text = "মোট উইথ-ড্রঃ " & dtsum(transactionreport.TblTransactionReportDataGridView, 4) & dashboard.CurrencyTextBox.Text
                                           transactionreport.tool.Items(0).Text = "মোট ডিপোজিটঃ " & dtsum(transactionreport.TblTransactionReportDataGridView, 5) & dashboard.CurrencyTextBox.Text
                                       Catch ex As Exception

                                       End Try
                                       Return 0
                                   End Function
                t.Start()
            ElseIf i = 53 Then
                managecustomer.txtFilter.SelectedIndex = 4
                dt(managecustomer.TblCustomersDataGridView)


                autot(managecustomer.txtSearch, managecustomer.DataSet.tblCustomers, "customerName", managecustomer)
                autot(managecustomer.txtSearch, managecustomer.DataSet.tblCustomers, "contactNumber", managecustomer)
                autot(managecustomer.txtSearch, managecustomer.DataSet.tblCustomers, "customerID", managecustomer)
                autot(managecustomer.txtSearch, managecustomer.DataSet.tblCustomers, "shopOrCompanyName", managecustomer)

                managecustomer.txtSearch.Clear()
                managecustomer.TblCustomersBindingSource.RemoveFilter()

                If managecustomer.TblCustomersBindingSource.Count = 0 Then
                    managecustomer.Enabled = False
                Else
                    managecustomer.Enabled = True
                End If
            ElseIf i = 54 Then
                'selection
                addcustomer.ShopOrCompanyNameTextBox.Select()
                slt(addcustomer.ShopOrCompanyNameTextBox, addcustomer.BillingAddressTextBox)
                slt(addcustomer.BillingAddressTextBox, addcustomer.ShippingAddressTextBox)
                slt(addcustomer.ShippingAddressTextBox, addcustomer.ContactNumberTextBox)
                slt(addcustomer.ContactNumberTextBox, addcustomer.EmailTextBox)
                slt(addcustomer.EmailTextBox, addcustomer.CustomerIDTextBox)
                slt(addcustomer.CustomerIDTextBox, addcustomer.CustomerNameTextBox)
                slt(addcustomer.CustomerNameTextBox, addcustomer.CustomerNoteTextBox)
                slt(addcustomer.CustomerNoteTextBox, addcustomer.PaymentTextBox)
                slt(addcustomer.PaymentTextBox, addcustomer.PaidTextBox)
                slt(addcustomer.PaidTextBox, addcustomer.DueTextBox)

                num(addcustomer.PaymentTextBox)
                num(addcustomer.PaidTextBox)
                num(addcustomer.DueTextBox)

                phn(addcustomer.ContactNumberTextBox)

                addcustomer.chk_add.Checked = True

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If addcustomer.chk_add.Checked = True Then
                                           addcustomer.GroupBox1.Enabled = True
                                       Else
                                           addcustomer.GroupBox1.Enabled = False
                                       End If
                                       Return 0
                                   End Function
            ElseIf i = 55 Then
                Try
                    'selection
                    paysupplier.DateTextBox.Select()
                    slt(paysupplier.DateTextBox, paysupplier.FridgeIDTextBox)
                    slt(paysupplier.FridgeIDTextBox, paysupplier.MonthTextBox)
                    slt(paysupplier.MonthTextBox, paysupplier.paidRent)
                    slt(paysupplier.paidRent, paysupplier.txtdue)
                    num(paysupplier.paidRent)
                    auto(paysupplier.IdTextBox, paysupplier.DataSet.tblFridges, "fridgeID")
                    dt(paysupplier.TblRentSDataGridView)


                    'generate rent
                    paysupplier.TblFridgesTableAdapter.Fill(paysupplier.DataSet.tblFridges)
                    paysupplier.TblRentSTableAdapter.Fill(paysupplier.DataSet.tblRentS)
                    paysupplier.TextBox1.Text = managefridge.FridgeIDTextBox.Text
                    paysupplier.TblRentSBindingSource.RemoveFilter()
                    paysupplier.TblRentSBindingSource.MoveFirst()
                    paysupplier.TblFridgesBindingSource.RemoveFilter()
                    paysupplier.TblFridgesBindingSource.MoveFirst()

                    For a = 0 To paysupplier.TblFridgesBindingSource.Count - 1
                        paysupplier.TblRentSBindingSource.Filter = "fridgeID =" & paysupplier.FridgeIDTextBox1.Text & " AND m=" & Today.Month & " AND y=" & Today.Year
                        If paysupplier.TblRentSBindingSource.Count = 0 Then
                            If (Double.Parse(paysupplier.CompanyRentTextBox.Text) = 0) = False Then
                                paysupplier.TblRentSBindingSource.AddNew()
                                paysupplier.DateTextBox.Text = Date.Today
                                paysupplier.FridgeIDTextBox.Text = paysupplier.FridgeIDTextBox1.Text
                                paysupplier.MonthTextBox.Text = Format(Date.Today, "MMMMM")
                                paysupplier.RentTextBox.Text = "0"
                                paysupplier.DueTextBox.Text = paysupplier.CompanyRentTextBox.Text
                                paysupplier.MTextBox.Text = Today.Month
                                paysupplier.YTextBox.Text = Today.Year
                                paysupplier.Validate()
                                paysupplier.TblRentSBindingSource.EndEdit()
                                paysupplier.TableAdapterManager.UpdateAll(paysupplier.DataSet)
                            End If
                        End If

                        If a = paysupplier.TblFridgesBindingSource.Count - 1 Then

                            paysupplier.TblRentSTableAdapter.Fill(paysupplier.DataSet.tblRentS)

                            paysupplier.TblFridgesBindingSource.Filter = "fridgeID ='" & paysupplier.TextBox1.Text & "'"
                            paysupplier.TblRentSBindingSource.Filter = "fridgeID ='" & paysupplier.TextBox1.Text & "'" '& " AND m=" & Today.Month & " AND y=" & Today.Year

                            'removing paid rents
                            If paysupplier.TblRentSBindingSource.Count > 0 Then
                                paysupplier.TblRentSBindingSource.MoveFirst()
                                For b = 0 To paysupplier.TblRentSBindingSource.Count - 1
                                    If Double.Parse(paysupplier.RentTextBox.Text) = Double.Parse(paysupplier.CompanyRentTextBox.Text) Then
                                        paysupplier.TblRentSBindingSource.RemoveCurrent()
                                    End If
                                    paysupplier.TblRentSBindingSource.MoveNext()
                                Next
                            End If
                            ''''''''''''''''
                            'paysupplier.TblRentSBindingSource.Filter = "fridgeID =" & paysupplier.TextBox1.Text & " AND m=" & Today.Month & " AND y=" & Today.Year
                            'If (paysupplier.TblRentSBindingSource.Count = 0) = False Then

                            'End If
                            paysupplier.paidRent.Text = 0
                            paysupplier.txtdue.Text = paysupplier.DueTextBox.Text
                        End If

                        paysupplier.TblFridgesBindingSource.MoveNext()
                    Next


                    Dim t As New Timer
                    t.Start()
                    AddHandler t.Tick, Function()
                                           If paysupplier.TblRentSBindingSource.Count = 0 Then
                                               paysupplier.Panel1.Enabled = False
                                           Else
                                               paysupplier.Panel1.Enabled = True
                                           End If
                                           Return 0
                                       End Function

                Catch ex As Exception

                End Try

            ElseIf i = 56 Then
                'selection
                paycustomer.DateTextBox.Select()
                slt(paycustomer.DateTextBox, paycustomer.FridgeIDTextBox)
                slt(paycustomer.FridgeIDTextBox, paycustomer.MonthTextBox)
                slt(paycustomer.MonthTextBox, paycustomer.paidRent)
                slt(paycustomer.paidRent, paycustomer.txtdue)
                dt(paycustomer.TblRentCDataGridView)
                num(paycustomer.paidRent)
                'generate rent
                paycustomer.TblFridgesTableAdapter.Fill(paycustomer.DataSet.tblFridges)
                paycustomer.TblRentCTableAdapter.Fill(paycustomer.DataSet.tblRentC)
                paycustomer.TextBox1.Text = managefridge.FridgeIDTextBox.Text
                paycustomer.TblRentCBindingSource.RemoveFilter()
                paycustomer.TblRentCBindingSource.MoveFirst()
                paycustomer.TblFridgesBindingSource.RemoveFilter()
                paycustomer.TblFridgesBindingSource.MoveFirst()
                For a = 0 To paycustomer.TblFridgesBindingSource.Count - 1

                    paycustomer.TblRentCBindingSource.Filter = "fridgeID ='" & paycustomer.FridgeIDTextBox1.Text & "' AND m='" & Today.Month & "' AND y='" & Today.Year & "'"

                    If paycustomer.TblRentCBindingSource.Count = 0 Then

                        If paycustomer.RentedToIDTextBox.Text.Length > 0 Then

                            If (Double.Parse(paycustomer.MonthlyRentTextBox.Text) = 0) = False Then

                                paycustomer.TblRentCBindingSource.AddNew()
                                paycustomer.DateTextBox.Text = Date.Today
                                paycustomer.FridgeIDTextBox.Text = paycustomer.FridgeIDTextBox1.Text
                                paycustomer.MonthTextBox.Text = Format(Date.Today, "MMMMM")
                                paycustomer.RentTextBox.Text = "0"
                                paycustomer.DueTextBox.Text = paycustomer.MonthlyRentTextBox.Text
                                paycustomer.MTextBox.Text = Today.Month
                                paycustomer.YTextBox.Text = Today.Year
                                paycustomer.Validate()
                                paycustomer.TblRentCBindingSource.EndEdit()
                                paycustomer.TableAdapterManager.UpdateAll(paycustomer.DataSet)
                            End If
                        End If
                    End If
                    If a = paycustomer.TblFridgesBindingSource.Count - 1 Then


                        paycustomer.TblRentCTableAdapter.Fill(paycustomer.DataSet.tblRentC)

                        paycustomer.TblFridgesBindingSource.Filter = "fridgeID =" & paycustomer.TextBox1.Text
                        paycustomer.TblRentCBindingSource.Filter = "fridgeID =" & paycustomer.TextBox1.Text '& " AND m=" & Today.Month & " AND y=" & Today.Year                        
                        If paycustomer.TblRentCBindingSource.Count > 0 Then
                            paycustomer.TblRentCBindingSource.MoveFirst()

                            For b = 0 To paycustomer.TblRentCBindingSource.Count - 1
                                If Double.Parse(paycustomer.RentTextBox.Text) = Double.Parse(paycustomer.MonthlyRentTextBox.Text) Then
                                    paycustomer.TblRentCBindingSource.RemoveCurrent()
                                End If
                                paycustomer.TblRentCBindingSource.MoveNext()
                            Next
                        End If
                        'paycustomer.TblRentCBindingSource.Filter = "fridgeID =" & paycustomer.TextBox1.Text & " AND m=" & Today.Month & " AND y=" & Today.Year
                        'If paycustomer.TblRentCBindingSource.Count = 0 = False Then

                        'End If
                        paycustomer.paidRent.Text = 0
                        paycustomer.txtdue.Text = paycustomer.DueTextBox.Text
                    End If
                    paycustomer.TblFridgesBindingSource.MoveNext()
                Next

                Dim t As New Timer
                t.Start()
                AddHandler t.Tick, Function()
                                       If paycustomer.TblRentCBindingSource.Count = 0 Then
                                           paycustomer.Panel1.Enabled = False
                                       Else
                                           paycustomer.Panel1.Enabled = True
                                       End If
                                       Return 0
                                   End Function



            ElseIf i = 57 Then
                'blank
            ElseIf i = 58 Then
                'blank
            ElseIf i = 59 Then
                'blank
            ElseIf i = 60 Then
                'selection
                slt(withdraw.WithdrawReasonTextBox, withdraw.AmountTextBox)
                slt(withdraw.AmountTextBox, withdraw.PersonTextBox)

                withdraw.DateTimePicker1.ResetText()

                num(withdraw.AmountTextBox)
                dt(withdraw.TblwithdrawDataGridView)
                withdraw.txtFilter.SelectedIndex = 0
                withdraw.txtSearch.Clear()

                withdraw.Panel2.Enabled = False

                withdraw_timer.Start()
                AddHandler withdraw_timer.Tick, Function()
                                                    withdraw.tool.Items(0).Text = "মোট ব্যক্তিগত উত্তোলনঃ " & dtsum(withdraw.TblwithdrawDataGridView, 1) & dashboard.CurrencyTextBox.Text
                                                    Return 0
                                                End Function
                withdraw.TblwithdrawBindingSource.RemoveFilter()
            ElseIf i = 61 Then
                myacc.TblUserBindingSource.Filter = "userID LIKE '%" & frmmain.UserIDTextBox.Text & "%'"

                'selection
                myacc.UserNameTextBox.Select()
                slt(myacc.UserNameTextBox, myacc.UserIDTextBox)
                slt(myacc.UserIDTextBox, myacc.PasswordTextBox)
                slt(myacc.PasswordTextBox, myacc.AddressTextBox)
                slt(myacc.AddressTextBox, myacc.PhoneTextBox)
                slt(myacc.PhoneTextBox, myacc.RoleTextBox)

                phn(myacc.PhoneTextBox)

                myacc.Panel2.Enabled = False
            ElseIf i = 62 Then
                'selection
                newvehicle.VehicleModelTextBox.Select()
                slt(newvehicle.VehicleModelTextBox, newvehicle.VehicleNumberTextBox)
                slt(newvehicle.VehicleNumberTextBox, newvehicle.PriceTextBox)

                slt(newvehicle.PriceTextBox, newvehicle.VehicleIDTextBox)
                slt(newvehicle.VehicleIDTextBox, newvehicle.DriverNameTextBox)
                slt(newvehicle.DriverNameTextBox, newvehicle.NoteTextBox)

                newvehicle.rdN.Checked = True
                newvehicle.chkbc.Checked = True

                num(newvehicle.PriceTextBox)
                newvehicle.DateTimePicker1.ResetText()
            ElseIf i = 63 Then
                dt(managevehicle.TblVehicleDataGridView)
                managevehicle.txtFilter.SelectedIndex = 0
                managevehicle.txtSearch.Clear()

                managevehicle.TblVehicleBindingSource.RemoveFilter()
                If managevehicle.TblVehicleBindingSource.Count = 0 Then
                    managevehicle.Enabled = False
                Else
                    managevehicle.Enabled = True
                End If

                Dim t As New Timer
                AddHandler t.Tick, Function()
                                       managevehicle.tool.Items(0).Text = "গাড়ির মোট মূল্যঃ " & dtsum(managevehicle.TblVehicleDataGridView, 6) & dashboard.CurrencyTextBox.Text
                                       Return 0
                                   End Function
                t.Start()
            ElseIf i = 64 Then
                vehicleaccounts.fromDt.ResetText()
                vehicleaccounts.toDt.ResetText()
                vehicleaccounts.txtVehicleID.Clear()
                dat(vehicleaccounts.fromDt, vehicleaccounts.toDt)

                dt(vehicleaccounts.TblSalesDataGridView)
                dt(vehicleaccounts.TblVehicleAccountsDataGridView)

                vehicle_accounts_timer.Start()
                AddHandler vehicle_accounts_timer.Tick, Function()
                                                            Try
                                                                vehicleaccounts.TblSalesBindingSource.Filter = "invoiceNo =" & vehicleaccounts.SaleInvoiceTextBox.Text
                                                            Catch ex As Exception

                                                            End Try
                                                            Try
                                                                vehicleaccounts.tool.Items(4).Text = "নিট দামঃ " & dtsum(vehicleaccounts.TblVehicleAccountsDataGridView, 5) & all.dashboard.CurrencyTextBox.Text
                                                                vehicleaccounts.tool.Items(2).Text = "আদায়ঃ " & dtsum(vehicleaccounts.TblVehicleAccountsDataGridView, 6) & all.dashboard.CurrencyTextBox.Text
                                                                vehicleaccounts.tool.Items(0).Text = "বাকিঃ " & dtsum(vehicleaccounts.TblVehicleAccountsDataGridView, 7) & all.dashboard.CurrencyTextBox.Text
                                                            Catch ex As Exception

                                                            End Try

                                                            Return 0
                                                        End Function


            ElseIf i = 65 Then

            ElseIf i = 66 Then
                'blank
            ElseIf i = 67 Then
                'seelction
                purchaseseason.ProductNameTextBox.Select()
                slt(purchaseseason.ProductNameTextBox, purchaseseason.TargetQuantityTextBox)
                slt(purchaseseason.TargetQuantityTextBox, purchaseseason.CashrewardTextBox)
                slt(purchaseseason.CashrewardTextBox, purchaseseason.ProductrewardTextBox)
                slt(purchaseseason.ProductrewardTextBox, purchaseseason.ProductrewardQuantityTextBox)


                num(purchaseseason.ProductCodeTextBox)
                num(purchaseseason.ProductrewardCodeTextBox)
                num(purchaseseason.TargetQuantityTextBox)
                num(purchaseseason.CashrewardTextBox)
                num(purchaseseason.ProductrewardQuantityTextBox)

                auto(purchaseseason.ProductNameTextBox, purchaseseason.DataSet.tblProducts, "productName")
                auto(purchaseseason.ProductCodeTextBox, purchaseseason.DataSet.tblProducts, "productCode")
                auto(purchaseseason.ProductrewardTextBox, purchaseseason.DataSet.tblProducts, "productName")
                auto(purchaseseason.ProductrewardCodeTextBox, purchaseseason.DataSet.tblProducts, "productCode")

                If purchaseseason.TblProductsBindingSource.Count = 0 Then
                    purchaseseason.Enabled = False
                Else
                    purchaseseason.Enabled = True
                End If
            ElseIf i = 68 Then
                'selection
                saleseason.ProductNameTextBox.Select()
                slt(saleseason.ProductNameTextBox, saleseason.CashrewardTextBox)
                slt(saleseason.CashrewardTextBox, saleseason.TargetQuantityTextBox)

                num(saleseason.ProductCodeTextBox)
                num(saleseason.TargetQuantityTextBox)

                auto(saleseason.ProductNameTextBox, saleseason.DataSet.tblProducts, "productName")
                auto(saleseason.ProductCodeTextBox, saleseason.DataSet.tblProducts, "productCode")


                If saleseason.TblProductsBindingSource.Count = 0 Then
                    saleseason.Enabled = False
                Else
                    saleseason.Enabled = True
                End If
            ElseIf i = 69 Then

                dt(cashreport.TblCashReportDataGridView)
                    dat(cashreport.fromDt, cashreport.toDt)
                    cashreport.fromDt.ResetText()
                    cashreport.toDt.ResetText()
                    cashreport.TblCashReportBindingSource.RemoveFilter()

                    'creating report
                    cashreport.TblCashReportBindingSource.Filter = "date ='" & Today & "'"
                If cashreport.TblCashReportBindingSource.Count > 0 Then

                    While cashreport.TblCashReportBindingSource.Count <> 0
                        cashreport.TblCashReportBindingSource.RemoveCurrent()
                    End While
                End If


                Dim cash_balance As Double
                '  dockyard(profitcalculator, cashreport)
                profitcalculator.TopLevel = False
                cashreport.Controls.Add(profitcalculator)
                profitcalculator.Show()
                profitcalculator.Dock = DockStyle.None
                profitcalculator.Size = New Size(0, 0)

                fll(41)
                ld(41)
                profitcalculator.Size = New Size(0, 0)
                profitcalculator.Location = New Point(0, 0)

                profitcalculator.TblProfitBindingSource.Filter = "date ='" & Today & "'"
                Try
                    cash_balance = Double.Parse(profitcalculator.ProfitTextBox.Text)
                Catch ex As Exception
                    cash_balance = 0
                End Try
                profitcalculator.TblProfitBindingSource.RemoveFilter()

                    cashreport.TblCashReportBindingSource.AddNew()
                    cashreport.ExpenseTextBox.Text = cash_balance
                    cashreport.DateTextBox.Text = Today
                    cashreport.Validate()
                    cashreport.TblCashReportBindingSource.EndEdit()
                    cashreport.TblCashReportTableAdapter.Update(cashreport.DataSet)
                    cashreport.TblCashReportBindingSource.RemoveFilter()
                    'clear unneccessery data
                    clear_unneccessery_data(cashreport.TblCashReportBindingSource, cashreport.TblCashReportDataGridView, 1)
                    'ended
                    cashreport.TblCashReportBindingSource.RemoveFilter()

                    Dim t As New Timer
                    AddHandler t.Tick, Function()
                                           cashreport.tool.Items(0).Text = "মোট ক্যাশঃ " & dtsum(cashreport.TblCashReportDataGridView, 0) & dashboard.CurrencyTextBox.Text
                                           Return 0
                                       End Function
                    t.Start()

            ElseIf i = 70 Then
                dt(sell_on_commisssion.TblsellcommissionDataGridView)

                sell_on_commisssion.fromDt.ResetText()
                sell_on_commisssion.toDt.ResetText()

                sell_on_commisssion.chk_company.Checked = False
                sell_on_commisssion.chk_product.Checked = False

                auto(sell_on_commisssion.txt_company, sell_on_commisssion.DataSet.tblProducts, "productName")


                sell_on_commisssion.Panel1.Top = (sell_on_commisssion.Height / 2) - ((sell_on_commisssion.Panel1.Height / 2) - 15)
                sell_on_commisssion.Panel1.Left = (sell_on_commisssion.ClientSize.Width / 2) - (sell_on_commisssion.Panel1.Width / 2)

                sell_commission_timer.Start()
                AddHandler sell_commission_timer.Tick, Function()
                                                           If sell_on_commisssion.chk_company.Checked = True Then
                                                               sell_on_commisssion.txt_company.Enabled = True
                                                               sell_on_commisssion.txt_comany_id.Enabled = True
                                                           Else
                                                               sell_on_commisssion.txt_company.Enabled = False
                                                               sell_on_commisssion.txt_comany_id.Enabled = False

                                                           End If
                                                           If sell_on_commisssion.chk_product.Checked = True Then
                                                               sell_on_commisssion.txt_product.Enabled = True
                                                               sell_on_commisssion.txt_product_id.Enabled = True
                                                           Else
                                                               sell_on_commisssion.txt_product.Enabled = False
                                                               sell_on_commisssion.txt_product_id.Enabled = False
                                                           End If
                                                           'toolstrip
                                                           sell_on_commisssion.tool.Items(0).Text = "মোট কমিশনঃ " & dtsum(sell_on_commisssion.TblsellcommissionDataGridView, 5) & all.dashboard.CurrencyTextBox.Text
                                                           Return 0
                                                       End Function
                sell_on_commisssion.TblsellcommissionBindingSource.RemoveFilter()
                If sell_on_commisssion.TblsellcommissionBindingSource.Count = 0 Then
                    sell_on_commisssion.Enabled = False
                Else
                    sell_on_commisssion.Enabled = True
                End If
            ElseIf i = 71 Then
            ElseIf i = 72 Then
                dt(discounts.TbldiscountDataGridView)
                discounts.txtFilter.SelectedIndex = 0

                discounts.fromDt.ResetText()
                discounts.toDt.ResetText()
                discounts.txtSearch.Clear()

                discounts.TbldiscountBindingSource.RemoveFilter()
                If discounts.TbldiscountBindingSource.Count = 0 Then
                    discounts.Enabled = False
                Else
                    discounts.Enabled = True
                End If

                discount_timer.Start()
                AddHandler discount_timer.Tick, Function()
                                                    Try
                                                        discounts.tool.Items(0).Text = "মোট ডিসকাউন্টঃ " & dtsum(discounts.TbldiscountDataGridView, 5) & dashboard.CurrencyTextBox.Text
                                                    Catch ex As Exception

                                                    End Try
                                                    Return 0
                                                End Function

            ElseIf i = 80 Then
                sold_product.fromDt.ResetText()
                sold_product.toDt.ResetText()
                sold_product.txtFilter.SelectedIndex = 0
                sold_product.txtSearch.Clear()
                sold_product.TblSalesBindingSource.RemoveFilter()
                dt(sold_product.TblSalesDataGridView)

                'fill
                'sold_product.TblInvoiceTableAdapter.Fill(sold_product.DataSet.tblInvoice)
                ' sold_product.TblProductsTableAdapter.Fill(sold_product.DataSet.tblProducts)
                sold_product.TblSalesTableAdapter.Fill(sold_product.DataSet.tblSales)
                'auto complete
                auto(sold_product.txtSearch, sold_product.DataSet.tblProducts, "productName")
                auto(sold_product.txtSearch, sold_product.DataSet.tblProducts, "productCode")
                auto(sold_product.txtSearch, sold_product.DataSet.tblSuppliers, "supplierName")
                auto(sold_product.txtSearch, sold_product.DataSet.tblSuppliers, "supplierID")
                auto(sold_product.txtSearch, sold_product.DataSet.tblCustomers, "customerName")
                auto(sold_product.txtSearch, sold_product.DataSet.tblCustomers, "customerID")

                'status
                Dim t As New Timer
                AddHandler t.Tick, Function()
                                       Try
                                           Dim bgw As New ComponentModel.BackgroundWorker
                                           AddHandler bgw.DoWork, Function()
                                                                      sold_product.Invoke(New MethodInvoker(Function()
                                                                                                                Try
                                                                                                                    Dim quantity As Integer = dtsum(sold_product.TblSalesDataGridView, 2)
                                                                                                                    Dim total_sold As Double = 0, total_discount As Double = 0, net_sold As Double = 0, purchase_price As Double = 0, revenue As Double = 0
                                                                                                                    For a As Integer = 0 To sold_product.TblSalesBindingSource.Count - 1
                                                                                                                        If sold_product.TblSalesDataGridView.Rows(a).Cells(1).Value.ToString.Length > 0 Then
                                                                                                                            total_sold += Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(4).Value.ToString)
                                                                                                                            total_discount += Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(4).Value.ToString) - Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(6).Value.ToString)
                                                                                                                            net_sold += Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(6).Value.ToString)
                                                                                                                            purchase_price += Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(9).Value.ToString) * Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(2).Value.ToString)
                                                                                                                            revenue += prc((Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(9).Value.ToString) * Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(2).Value.ToString)), Double.Parse(sold_product.TblSalesDataGridView.Rows(a).Cells(10).Value.ToString))
                                                                                                                        End If
                                                                                                                    Next
                                                                                                                    tool_text(sold_product.tool, 0, "Total quantity", quantity)
                                                                                                                    tool_text(sold_product.tool, 2, "Total sold", total_sold)
                                                                                                                    tool_text(sold_product.tool, 4, "Total discount", total_discount)
                                                                                                                    tool_text(sold_product.tool, 6, "Net sold", net_sold)
                                                                                                                    tool_text(sold_product.tool, 8, "Purchase price", purchase_price)
                                                                                                                    tool_text(sold_product.tool, 10, "Revenue (% of profit)", revenue)
                                                                                                                Catch ex As Exception

                                                                                                                End Try
                                                                                                                Return Nothing
                                                                                                            End Function))
                                                                      Return Nothing
                                                                  End Function
                                           AddHandler bgw.RunWorkerCompleted, Function()
                                                                                  bgw.Dispose()
                                                                                  Return Nothing
                                                                              End Function
                                           bgw.RunWorkerAsync()

                                       Catch ex As Exception

                                       End Try
                                       Return Nothing
                                   End Function
                t.Start()






                'temporaray function for copy data                               
                'For b As Integer = 0 To sold_product.TblSalesBindingSource.Count - 1
                '    Try
                '        If sold_product.TblSalesDataGridView.Rows(b).Cells(1).Value.ToString.Length > 0 Then
                '            sold_product.TblInvoiceBindingSource.Filter = "invoiceNo =" & sold_product.TblSalesDataGridView.Rows(b).Cells(14).Value.ToString
                '            sold_product.TblProductsBindingSource.Filter = "productCode =" & sold_product.TblSalesDataGridView.Rows(b).Cells(1).Value.ToString

                '            'source:invoice
                '            sold_product.TblSalesDataGridView.Rows(b).Cells(11).Value = sold_product.TblInvoiceDataGridView.Rows(0).Cells(0).Value.ToString
                '            sold_product.TblSalesDataGridView.Rows(b).Cells(13).Value = sold_product.TblInvoiceDataGridView.Rows(0).Cells(1).Value.ToString
                '            sold_product.TblSalesDataGridView.Rows(b).Cells(8).Value = sold_product.TblInvoiceDataGridView.Rows(0).Cells(2).Value.ToString
                '            'source:products
                '            sold_product.TblSalesDataGridView.Rows(b).Cells(7).Value = sold_product.TblProductsDataGridView.Rows(0).Cells(0).Value.ToString
                '            sold_product.TblSalesDataGridView.Rows(b).Cells(12).Value = sold_product.TblProductsDataGridView.Rows(0).Cells(3).Value.ToString
                '            sold_product.TblSalesDataGridView.Rows(b).Cells(9).Value = sold_product.TblProductsDataGridView.Rows(0).Cells(1).Value.ToString
                '            sold_product.TblSalesDataGridView.Rows(b).Cells(10).Value = sold_product.TblProductsDataGridView.Rows(0).Cells(2).Value.ToString
                '        End If
                '    Catch ex As Exception

                '    End Try
                'Next
                'sold_product.Validate()
                'sold_product.TblSalesBindingSource.EndEdit()
                'sold_product.TableAdapterManager.UpdateAll(sold_product.DataSet)
                ''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''

            End If


        Catch ex As Exception

        End Try

        Return Nothing
    End Function
    Function tool_text(tool As ToolStrip, i As Integer, s As String, value As Double)
        If s = "Quantity" Or s = "Total quantity" Then
            tool.Items(i).Text = s & ": " & value & "Unit"
        Else
            tool.Items(i).Text = s & ": " & value & dashboard.CurrencyTextBox.Text
        End If
        Return Nothing
    End Function

    Public Function rm(i, s)
        Try
            If MsgBox("Confirm delete?", MsgBoxStyle.YesNo, "Delete confirmation") = DialogResult.Yes Then
                If i = 0 Then
                    addbank.TblBanksBindingSource.RemoveCurrent()
                ElseIf i = 1 Then
                    adddamage.TblDamageProductsBindingSource.RemoveCurrent()
                ElseIf i = 2 Then
                    addemployee.TblEmployeeBindingSource.RemoveCurrent()
                ElseIf i = 3 Then
                    addfridge.TblFridgesBindingSource.RemoveCurrent()
                ElseIf i = 4 Then
                    addnote.TblNotesBindingSource.RemoveCurrent()
                ElseIf i = 5 Then
                    addproduct.TblProductsBindingSource.RemoveCurrent()
                ElseIf i = 6 Then
                    addsupplier.TblSuppliersBindingSource.RemoveCurrent()
                ElseIf i = 7 Then
                    'blank
                ElseIf i = 8 Then
                    attendencereport.TblAttendenceReportBindingSource.RemoveCurrent()
                    attendencereport.TblAttendenceTableAdapter.Fill(attendencereport.DataSet.tblAttendence)
                ElseIf i = 9 Then
                    companysettting.TblCompanySettingsBindingSource.RemoveCurrent()
                ElseIf i = 10 Then
                    createuser.TblUserBindingSource.RemoveCurrent()
                ElseIf i = 11 Then
                    damageFridge.TblDamageFridgeBindingSource.RemoveCurrent()
                ElseIf i = 12 Then
                    'blank
                ElseIf i = 13 Then
                    duereport.TblDuesReportBindingSource.RemoveCurrent()
                ElseIf i = 14 Then
                    employeeaccount.TblEmployeeAccountsBindingSource.RemoveCurrent()
                ElseIf i = 15 Then
                    employeeattendence.TblAttendenceBindingSource.RemoveCurrent()
                ElseIf i = 16 Then
                    If s = 0 Then
                        expensecategory.TblExpenseCategoryBindingSource.RemoveCurrent()
                    ElseIf s = 1 Then
                        expensecategory.TblExpenseSubcategoryBindingSource.RemoveCurrent()
                    End If
                ElseIf i = 17 Then
                    expensereport.TblExpenseReportBindingSource.RemoveCurrent()
                ElseIf i = 18 Then
                    'blank
                ElseIf i = 19 Then
                    managebank.TblBanksBindingSource.RemoveCurrent()
                ElseIf i = 20 Then
                    If s = 0 Then
                        incomecategory.TblIncomeCategoryBindingSource.RemoveCurrent()
                    ElseIf s = 1 Then
                        incomecategory.TblIncomeSubcategoryBindingSource.RemoveCurrent()
                    End If
                ElseIf i = 21 Then
                    If s = 0 Then
                        managesale.TblInvoiceBindingSource.RemoveCurrent()
                    ElseIf s = 1 Then
                        managesale.TblSalesBindingSource.RemoveCurrent()
                    End If
                ElseIf i = 22 Then
                    manageasset.TblassetBindingSource.RemoveCurrent()
                ElseIf i = 23 Then
                    managebankaccount.TblBankAccountsBindingSource.RemoveCurrent()
                    up(23, 0)
                ElseIf i = 24 Then
                    managedamage.TblDamageProductsBindingSource.RemoveCurrent()
                ElseIf i = 25 Then
                    manageemployee.TblEmployeeBindingSource.RemoveCurrent()
                ElseIf i = 26 Then
                    manageexpense.TblExpensesBindingSource.RemoveCurrent()
                    up(26, 0)
                ElseIf i = 27 Then
                    managefridge.TblFridgesBindingSource.RemoveCurrent()
                ElseIf i = 28 Then
                    manageincome.TblIncomeBindingSource.RemoveCurrent()
                ElseIf i = 29 Then
                    manageproduct.TblProductsBindingSource.RemoveCurrent()
                ElseIf i = 30 Then
                    If s = 0 Then
                        managepurchase.TblPurchaseInvoiceBindingSource.RemoveCurrent()
                    ElseIf s = 1 Then
                        managepurchase.TblPurchaseBindingSource.RemoveCurrent()
                    End If
                ElseIf i = 31 Then
                    managestock.TblProductsBindingSource.RemoveCurrent()
                ElseIf i = 32 Then
                    managesupplier.TblSuppliersBindingSource.RemoveCurrent()
                ElseIf i = 33 Then
                    managetransaction.TblTransactionBindingSource.RemoveCurrent()
                ElseIf i = 34 Then
                    newexpense.TblExpensesBindingSource.RemoveCurrent()
                ElseIf i = 35 Then
                    newincome.TblIncomeBindingSource.RemoveCurrent()
                ElseIf i = 36 Then
                    If s = 0 Then
                        newpurchase.TblPurchaseInvoiceBindingSource.RemoveCurrent()
                    ElseIf s = 1 Then
                        newpurchase.TblPurchaseBindingSource.RemoveCurrent()
                    End If
                ElseIf i = 37 Then
                    If s = 0 Then
                        newsale.TblInvoiceBindingSource.RemoveCurrent()
                    ElseIf s = 1 Then
                        newsale.TblSalesBindingSource.RemoveCurrent()
                    End If
                ElseIf i = 38 Then
                    If s = 0 Then
                        productcommission.TblSCommissionBindingSource.RemoveCurrent()
                    ElseIf s = 1 Then
                        'productcommission.TblPCommissionBindingSource.RemoveCurrent()
                    End If
                ElseIf i = 39 Then
                    productdelivery.TblDeliveryBindingSource.RemoveCurrent()
                ElseIf i = 40 Then
                    productcategory.TblProductCategoryBindingSource.RemoveCurrent()
                ElseIf i = 41 Then
                    profitcalculator.TblProfitBindingSource.RemoveCurrent()
                ElseIf i = 42 Then
                    purchasereport.TblPurchaseReportBindingSource.RemoveCurrent()
                ElseIf i = 43 Then
                    'blank
                ElseIf i = 44 Then
                    rentto.TblFridgesBindingSource.RemoveCurrent()
                ElseIf i = 45 Then
                    returndamage.TblDamageProductsBindingSource.RemoveCurrent()
                ElseIf i = 46 Then
                    salesreport.TblSalesreportBindingSource.RemoveCurrent()
                ElseIf i = 47 Then
                    supplieraccount.TblSupplierAccountsBindingSource.RemoveCurrent()
                ElseIf i = 48 Then
                    'blank
                ElseIf i = 49 Then
                    useraccounts.TblUserBindingSource.RemoveCurrent()
                ElseIf i = 50 Then
                    login.TblUserBindingSource.RemoveCurrent()
                ElseIf i = 51 Then
                    customeraccount.TblCusomterAccountsBindingSource.RemoveCurrent()
                ElseIf i = 52 Then
                    transactionreport.TblTransactionReportBindingSource.RemoveCurrent()
                ElseIf i = 53 Then
                    managecustomer.TblCustomersBindingSource.RemoveCurrent()
                ElseIf i = 54 Then
                    addcustomer.TblCustomersBindingSource.RemoveCurrent()
                ElseIf i = 55 Then
                    paysupplier.TblRentSBindingSource.RemoveCurrent()
                ElseIf i = 56 Then
                    paycustomer.TblRentCBindingSource.RemoveCurrent()
                ElseIf i = 57 Then
                    returndamagefridge.TblDamageFridgeBindingSource.RemoveCurrent()
                ElseIf i = 58 Then
                    'blank
                ElseIf i = 59 Then
                    'blank
                ElseIf i = 60 Then
                    withdraw.TblwithdrawBindingSource.RemoveCurrent()
                ElseIf i = 61 Then
                    myacc.TblUserBindingSource.RemoveCurrent()
                ElseIf i = 62 Then
                    newvehicle.TblVehicleBindingSource.RemoveCurrent()
                ElseIf i = 63 Then
                    managevehicle.TblVehicleBindingSource.RemoveCurrent()
                ElseIf i = 64 Then
                    vehicleaccounts.TblVehicleAccountsBindingSource.RemoveCurrent()
                ElseIf i = 65 Then
                    'blank
                ElseIf i = 66 Then
                    'blank
                ElseIf i = 67 Then
                    purchaseseason.TblPCommissionBindingSource.RemoveCurrent()
                ElseIf i = 68 Then
                    saleseason.TblSCommissionBindingSource.RemoveCurrent()
                ElseIf i = 69 Then

                ElseIf i = 70 Then
                    sell_on_commisssion.TblsellcommissionBindingSource.RemoveCurrent()
                ElseIf i = 71 Then
                ElseIf i = 72 Then
                    discounts.TbldiscountBindingSource.RemoveCurrent()
                End If
            End If
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Public Function nw(i, s)
        Try
            If i = 0 Then
                addbank.TblBanksBindingSource.AddNew()
            ElseIf i = 1 Then
                adddamage.TblDamageProductsBindingSource.AddNew()
            ElseIf i = 2 Then
                addemployee.TblEmployeeBindingSource.AddNew()
            ElseIf i = 3 Then
                addfridge.TblFridgesBindingSource.AddNew()
            ElseIf i = 4 Then
                addnote.TblNotesBindingSource.AddNew()
            ElseIf i = 5 Then
                addproduct.TblProductsBindingSource.AddNew()
            ElseIf i = 6 Then
                If s = 0 Then
                    addsupplier.TblSuppliersBindingSource.AddNew()
                ElseIf s = 1 Then
                    addsupplier.TblSupplierAccountsBindingSource.AddNew()
                End If
            ElseIf i = 7 Then
                'blank
            ElseIf i = 8 Then
                attendencereport.TblAttendenceBindingSource.AddNew()
            ElseIf i = 9 Then
                companysettting.TblCompanySettingsBindingSource.AddNew()
            ElseIf i = 10 Then
                createuser.TblUserBindingSource.AddNew()
            ElseIf i = 11 Then
                damageFridge.TblDamageFridgeBindingSource.AddNew()
            ElseIf i = 12 Then
                'no need
            ElseIf i = 13 Then
                duereport.TblDuesReportBindingSource.AddNew()
            ElseIf i = 14 Then
                employeeaccount.TblEmployeeAccountsBindingSource.AddNew()
            ElseIf i = 15 Then
                employeeattendence.TblAttendenceBindingSource.AddNew()
            ElseIf i = 16 Then
                If s = 0 Then
                    expensecategory.TblExpenseCategoryBindingSource.AddNew()
                ElseIf s = 1 Then
                    expensecategory.TblExpenseSubcategoryBindingSource.AddNew()
                End If
            ElseIf i = 17 Then
                expensereport.TblExpenseReportBindingSource.AddNew()
            ElseIf i = 18 Then
                'blank
            ElseIf i = 19 Then
                managebank.TblBanksBindingSource.AddNew()
            ElseIf i = 20 Then
                If s = 0 Then
                    incomecategory.TblIncomeCategoryBindingSource.AddNew()
                ElseIf s = 1 Then
                    incomecategory.TblIncomeSubcategoryBindingSource.AddNew()
                End If
            ElseIf i = 21 Then
                If s = 0 Then
                    managesale.TblInvoiceBindingSource.AddNew()
                ElseIf s = 1 Then
                    managesale.TblSalesBindingSource.AddNew()
                End If
            ElseIf i = 22 Then
                manageasset.TblassetBindingSource.AddNew()
            ElseIf i = 23 Then
                managebankaccount.TblBankAccountsBindingSource.AddNew()
            ElseIf i = 24 Then
                managedamage.TblDamageProductsBindingSource.AddNew()
            ElseIf i = 25 Then
                manageemployee.TblEmployeeBindingSource.AddNew()
            ElseIf i = 26 Then
                manageexpense.TblExpensesBindingSource.AddNew()
            ElseIf i = 27 Then
                managefridge.TblFridgesBindingSource.AddNew()
            ElseIf i = 28 Then
                manageincome.TblIncomeBindingSource.AddNew()
            ElseIf i = 29 Then
                manageproduct.TblProductsBindingSource.AddNew()
            ElseIf i = 30 Then
                If s = 0 Then
                    managepurchase.TblPurchaseInvoiceBindingSource.AddNew()
                ElseIf s = 1 Then
                    managepurchase.TblPurchaseBindingSource.AddNew()
                End If
            ElseIf i = 31 Then
                managestock.TblProductsBindingSource.AddNew()
            ElseIf i = 32 Then
                managesupplier.TblSuppliersBindingSource.AddNew()
            ElseIf i = 33 Then
                managetransaction.TblTransactionBindingSource.AddNew()
            ElseIf i = 34 Then
                newexpense.TblExpensesBindingSource.AddNew()
            ElseIf i = 35 Then
                newincome.TblIncomeBindingSource.AddNew()
            ElseIf i = 36 Then
                If s = 0 Then
                    newpurchase.TblPurchaseInvoiceBindingSource.AddNew()
                ElseIf s = 1 Then
                    newpurchase.TblPurchaseBindingSource.AddNew()
                End If
            ElseIf i = 37 Then
                If s = 0 Then
                    newsale.TblInvoiceBindingSource.AddNew()
                ElseIf s = 1 Then
                    newsale.TblSalesBindingSource.AddNew()
                End If
            ElseIf i = 38 Then
                'blank
            ElseIf i = 39 Then
                productdelivery.TblDeliveryBindingSource.AddNew()
            ElseIf i = 40 Then
                productcategory.TblProductCategoryBindingSource.AddNew()
            ElseIf i = 41 Then
                profitcalculator.TblProfitBindingSource.AddNew()
            ElseIf i = 42 Then
                purchasereport.TblPurchaseReportBindingSource.AddNew()
            ElseIf i = 43 Then
                'blank
            ElseIf i = 44 Then
                returndamage.TblDamageProductsBindingSource.AddNew()
            ElseIf i = 45 Then
                returndamage.TblDamageProductsBindingSource.AddNew()
            ElseIf i = 46 Then
                salesreport.TblSalesreportBindingSource.AddNew()
            ElseIf i = 47 Then
                supplieraccount.TblSupplierAccountsBindingSource.AddNew()
            ElseIf i = 48 Then
                managesignboard.TblSignboardBindingSource.AddNew()
            ElseIf i = 49 Then
                useraccounts.TblUserBindingSource.AddNew()
            ElseIf i = 50 Then
                login.TblUserBindingSource.AddNew()
            ElseIf i = 51 Then
                customeraccount.TblCusomterAccountsBindingSource.AddNew()
            ElseIf i = 52 Then
                transactionreport.TblTransactionReportBindingSource.AddNew()
            ElseIf i = 53 Then
                managecustomer.TblCustomersBindingSource.AddNew()
            ElseIf i = 54 Then
                If s = 0 Then
                    addcustomer.TblCustomersBindingSource.AddNew()
                Else s = 1
                    addcustomer.TblCusomterAccountsBindingSource.AddNew()
                End If
            ElseIf i = 55 Then
                paysupplier.TblRentSBindingSource.AddNew()
            ElseIf i = 56 Then
                paycustomer.TblRentCBindingSource.AddNew()
            ElseIf i = 57 Then
                returndamagefridge.TblDamageFridgeBindingSource.AddNew()
            ElseIf i = 58 Then
                'blank
            ElseIf i = 59 Then
                'blank
            ElseIf i = 60 Then
                withdraw.TblwithdrawBindingSource.AddNew()
            ElseIf i = 61 Then
                myacc.TblUserBindingSource.AddNew()
            ElseIf i = 62 Then
                newvehicle.TblVehicleBindingSource.AddNew()
            ElseIf i = 63 Then
                'blank
            ElseIf i = 64 Then
                vehicleaccounts.TblVehicleAccountsBindingSource.AddNew()
            ElseIf i = 65 Then
                'blank
            ElseIf i = 66 Then
                'blank
            ElseIf i = 67 Then
                purchaseseason.TblPCommissionBindingSource.AddNew()
            ElseIf i = 68 Then
                saleseason.TblSCommissionBindingSource.AddNew()
            ElseIf i = 69 Then

            ElseIf i = 70 Then
                sell_on_commisssion.TblsellcommissionBindingSource.AddNew()
            ElseIf i = 71 Then
            ElseIf i = 72 Then
                discounts.TbldiscountBindingSource.AddNew()
            End If
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Dim t As New Timer

    Function page(i)
        Dim frm As Form() = {
      addbank,
      addDamageProducts,
      addemployee,
      addfridge,
      addnote,
      addProducts,
      addsupplier,
      assetreport,
      attendencereport,
      companySettings,
      createuser,
      damageFridge,
      dashboard,
      duereport,
      employeeAccounts,
      employeeattendence,
      exepenseCategory,
      expensereport,
      Form1,
      frmBanks,
      incomecategory,
      Manage_sale,
      manageasset,
      manageBankAccounts,
      manageDamageProducts,
      manageemployee,
      manageExepense,
      managefridge,
      manageincome,
      manageProducts,
      managepurchase,
      managestock,
      managesupplier,
      managetransaction,
      newexpense,
      newincome,
      newpurchase,
      newsale,
      productcommission,
      productdelivery,
      productsCategory,
      profitcalculator,
      purchasereport,
      rentFromSupplier,
      rentToCustomer,
      returndamage,
      salesreport,
      supplierAccounts
      }
        Dim main As Form = frm(i)
        Return main
    End Function
    Function fll(i)
        Try

            If i = 0 Then
                addbank.TblBanksTableAdapter.Fill(addbank.DataSet.tblBanks)
            ElseIf i = 1 Then
                adddamage.TblProductsTableAdapter.Fill(adddamage.DataSet.tblProducts)
                adddamage.TblDamageProductsTableAdapter.Fill(adddamage.DataSet.tblDamageProducts)
                adddamage.TblExpensesTableAdapter.Fill(adddamage.DataSet.tblExpenses)
            ElseIf i = 2 Then
                addemployee.TblEmployeeTableAdapter.Fill(addemployee.DataSet.tblEmployee)
            ElseIf i = 3 Then
                addfridge.TblFridgesTableAdapter.Fill(addfridge.DataSet.tblFridges)
                addfridge.TblSuppliersTableAdapter.Fill(addfridge.DataSet.tblSuppliers)
            ElseIf i = 4 Then
                addnote.TblNotesTableAdapter.Fill(addnote.DataSet.tblNotes)
                addnote.TblUserTableAdapter.Fill(addnote.DataSet.tblUser)
            ElseIf i = 5 Then
                addproduct.TblSuppliersTableAdapter.Fill(addproduct.DataSet.tblSuppliers)
                addproduct.TblProductsTableAdapter.Fill(addproduct.DataSet.tblProducts)
                addproduct.TblProductCategoryTableAdapter.Fill(addproduct.DataSet.tblProductCategory)
            ElseIf i = 6 Then
                addsupplier.TblSuppliersTableAdapter.Fill(addsupplier.DataSet.tblSuppliers)
            ElseIf i = 7 Then
                'blank
            ElseIf i = 8 Then
                attendencereport.TblAttendenceTableAdapter.Fill(attendencereport.DataSet.tblAttendence)
                attendencereport.TblAttendenceReportTableAdapter.Fill(attendencereport.DataSet.tblAttendenceReport)
            ElseIf i = 9 Then
                companysettting.TblCompanySettingsTableAdapter.Fill(companysettting.DataSet.tblCompanySettings)
            ElseIf i = 10 Then
                createuser.TblUserTableAdapter.Fill(createuser.DataSet.tblUser)
            ElseIf i = 11 Then
                damageFridge.TblFridgesTableAdapter.Fill(damageFridge.DataSet.tblFridges)
                damageFridge.TblDamageFridgeTableAdapter.Fill(damageFridge.DataSet.tblDamageFridge)
            ElseIf i = 12 Then
                dashboard.TblNotesTableAdapter.Fill(dashboard.DataSet.tblNotes)
                dashboard.TblProductsTableAdapter.Fill(dashboard.DataSet.tblProducts)
                dashboard.TblInvoiceTableAdapter.Fill(dashboard.DataSet.tblInvoice)
                dashboard.TblCompanySettingsTableAdapter.Fill(dashboard.DataSet.tblCompanySettings)
            ElseIf i = 13 Then
                duereport.TblCustomersTableAdapter.Fill(duereport.DataSet.tblCustomers)
                duereport.TblCusomterAccountsTableAdapter.Fill(duereport.DataSet.tblCusomterAccounts)
                duereport.TblDuesReportTableAdapter.Fill(duereport.DataSet.tblDuesReport)
                duereport.TblInvoiceTableAdapter.Fill(duereport.DataSet.tblInvoice)
            ElseIf i = 14 Then
                employeeaccount.TblEmployeeAccountsTableAdapter.Fill(employeeaccount.DataSet.tblEmployeeAccounts)
            ElseIf i = 15 Then
                employeeattendence.TblEmployeeTableAdapter.Fill(employeeattendence.DataSet.tblEmployee)
                employeeattendence.TblAttendenceTableAdapter.Fill(employeeattendence.DataSet.tblAttendence)
            ElseIf i = 16 Then
                expensecategory.TblExpenseCategoryTableAdapter.Fill(expensecategory.DataSet.tblExpenseCategory)
                expensecategory.TblExpenseSubcategoryTableAdapter.Fill(expensecategory.DataSet.tblExpenseSubcategory)
            ElseIf i = 17 Then
                expensereport.TblExpenseReportTableAdapter.Fill(expensereport.DataSet.tblExpenseReport)
                expensereport.TblExpensesTableAdapter.Fill(expensereport.DataSet.tblExpenses)
                expensereport.TblExpenseCategoryTableAdapter.Fill(expensereport.DataSet.tblExpenseCategory)
            ElseIf i = 18 Then
                'blank
            ElseIf i = 19 Then
                managebank.TblBanksTableAdapter.Fill(managebank.DataSet1.tblBanks)
            ElseIf i = 20 Then
                incomecategory.TblIncomeCategoryTableAdapter.Fill(incomecategory.DataSet.tblIncomeCategory)
                incomecategory.TblIncomeSubcategoryTableAdapter.Fill(incomecategory.DataSet.tblIncomeSubcategory)
            ElseIf i = 21 Then
                managesale.TblInvoiceTableAdapter.Fill(managesale.DataSet.tblInvoice)
                managesale.TblSalesTableAdapter.Fill(managesale.DataSet.tblSales)
                managesale.TblProductsTableAdapter.Fill(managesale.DataSet.tblProducts)
            ElseIf i = 22 Then
                manageasset.TblassetTableAdapter.Fill(manageasset.DataSet.tblasset)
            ElseIf i = 23 Then
                managebankaccount.TblBanksTableAdapter.Fill(managebankaccount.DataSet.tblBanks)
                managebankaccount.TblBankAccountsTableAdapter.Fill(managebankaccount.DataSet.tblBankAccounts)
            ElseIf i = 24 Then
                managedamage.TblDamageProductsTableAdapter.Fill(managedamage.DataSet.tblDamageProducts)
            ElseIf i = 25 Then
                manageemployee.TblEmployeeTableAdapter.Fill(manageemployee.DataSet.tblEmployee)
            ElseIf i = 26 Then
                manageexpense.TblExpensesTableAdapter.Fill(manageexpense.DataSet.tblExpenses)
            ElseIf i = 27 Then
                managefridge.TblFridgesTableAdapter.Fill(managefridge.DataSet.tblFridges)
            ElseIf i = 28 Then
                manageincome.TblIncomeTableAdapter.Fill(manageincome.DataSet.tblIncome)
            ElseIf i = 29 Then
                manageproduct.TblProductsTableAdapter.Fill(manageproduct.DataSet.tblProducts)
            ElseIf i = 30 Then
                managepurchase.TblPurchaseInvoiceTableAdapter.Fill(managepurchase.DataSet.tblPurchaseInvoice)
                managepurchase.TblPurchaseTableAdapter.Fill(managepurchase.DataSet.tblPurchase)
                managepurchase.TblProductsTableAdapter.Fill(managepurchase.DataSet.tblProducts)
            ElseIf i = 31 Then
                managestock.TblProductsTableAdapter.Fill(managestock.DataSet.tblProducts)
            ElseIf i = 32 Then
                managesupplier.TblSuppliersTableAdapter.Fill(managesupplier.DataSet.tblSuppliers)
            ElseIf i = 33 Then
                managetransaction.TblBankAccountsTableAdapter.Fill(managetransaction.DataSet.tblBankAccounts)
                managetransaction.TblTransactionTableAdapter.Fill(managetransaction.DataSet.tblTransaction)
                managetransaction.TblExpensesTableAdapter.Fill(managetransaction.DataSet.tblExpenses)
                managetransaction.TblIncomeTableAdapter.Fill(managetransaction.DataSet.tblIncome)
            ElseIf i = 34 Then
                newexpense.TblExpensesTableAdapter.Fill(newexpense.DataSet.tblExpenses)
                newexpense.TblEmployeeAccountsTableAdapter.Fill(newexpense.DataSet.tblEmployeeAccounts)
                newexpense.TblEmployeeTableAdapter.Fill(newexpense.DataSet.tblEmployee)
                newexpense.TblExpenseCategoryTableAdapter.Fill(newexpense.DataSet.tblExpenseCategory)
                newexpense.TblExpenseSubcategoryTableAdapter.Fill(newexpense.DataSet.tblExpenseSubcategory)
                newexpense.TblBankAccountsTableAdapter.Fill(newexpense.DataSet.tblBankAccounts)
                newexpense.TblTransactionTableAdapter.Fill(newexpense.DataSet.tblTransaction)
            ElseIf i = 35 Then
                newincome.TblIncomeTableAdapter.Fill(newincome.DataSet.tblIncome)
                newincome.TblBankAccountsTableAdapter.Fill(newincome.DataSet.tblBankAccounts)
                newincome.TblTransactionTableAdapter.Fill(newincome.DataSet.tblTransaction)
                newincome.TblIncomeCategoryTableAdapter.Fill(newincome.DataSet.tblIncomeCategory)
                newincome.TblIncomeSubcategoryTableAdapter.Fill(newincome.DataSet.tblIncomeSubcategory)
            ElseIf i = 36 Then
                newpurchase.TblPurchaseInvoiceTableAdapter.Fill(newpurchase.DataSet.tblPurchaseInvoice)
                newpurchase.TblPurchaseTableAdapter.Fill(newpurchase.DataSet.tblPurchase)
                newpurchase.TblSuppliersTableAdapter.Fill(newpurchase.DataSet.tblSuppliers)
                newpurchase.TblSupplierAccountsTableAdapter.Fill(newpurchase.DataSet.tblSupplierAccounts)
                newpurchase.TblProductsTableAdapter.Fill(newpurchase.DataSet.tblProducts)
                newpurchase.TblExpensesTableAdapter.Fill(newpurchase.DataSet.tblExpenses)
                newpurchase.TblBankAccountsTableAdapter.Fill(newpurchase.DataSet.tblBankAccounts)
                newpurchase.TblTransactionTableAdapter.Fill(newpurchase.DataSet.tblTransaction)
            ElseIf i = 37 Then
                newsale.TblInvoiceTableAdapter.Fill(newsale.DataSet.tblInvoice)
                newsale.TblSalesTableAdapter.Fill(newsale.DataSet.tblSales)
                newsale.TblProductsTableAdapter.Fill(newsale.DataSet.tblProducts)
                newsale.TblCustomersTableAdapter.Fill(newsale.DataSet.tblCustomers)
                newsale.TblCusomterAccountsTableAdapter.Fill(newsale.DataSet.tblCusomterAccounts)
                newsale.TblBankAccountsTableAdapter.Fill(newsale.DataSet.tblBankAccounts)
                newsale.TblTransactionTableAdapter.Fill(newsale.DataSet.tblTransaction)
                newsale.TblVehicleTableAdapter.Fill(newsale.DataSet.tblVehicle)
                newsale.TblVehicleAccountsTableAdapter.Fill(newsale.DataSet.tblVehicleAccounts)
                newsale.TblSuppliersTableAdapter.Fill(newsale.DataSet.tblSuppliers)
                newsale.TblsellcommissionTableAdapter.Fill(newsale.DataSet.tblsellcommission)
                newsale.TblIncomeTableAdapter.Fill(newsale.DataSet.tblIncome)
                newsale.TbldiscountTableAdapter.Fill(newsale.DataSet.tbldiscount)
            ElseIf i = 38 Then
                'productcommission.TblPCommissionTableAdapter.Fill(productcommission.DataSet.tblPCommission)
                productcommission.TblSCommissionTableAdapter.Fill(productcommission.DataSet.tblSCommission)
            ElseIf i = 39 Then
                productdelivery.TblCustomersTableAdapter.Fill(productdelivery.DataSet.tblCustomers)
                productdelivery.TblDeliveryTableAdapter.Fill(productcategory.DataSet.tblDelivery)
                productdelivery.TblVehicleTableAdapter.Fill(productdelivery.DataSet.tblVehicle)
            ElseIf i = 40 Then
                productcategory.TblProductCategoryTableAdapter.Fill(productcategory.DataSet.tblProductCategory)
            ElseIf i = 41 Then
                profitcalculator.TblProfitTableAdapter.Fill(profitcalculator.DataSet.tblProfit)
                profitcalculator.TblCusomterAccountsTableAdapter.Fill(profitcalculator.DataSet.tblCusomterAccounts)
                profitcalculator.TblIncomeTableAdapter.Fill(profitcalculator.DataSet.tblIncome)
                profitcalculator.TblRentCTableAdapter.Fill(profitcalculator.DataSet.tblRentC)
                profitcalculator.TblTransactionTableAdapter.Fill(profitcalculator.DataSet.tblTransaction)
                profitcalculator.TblFridgesTableAdapter.Fill(profitcalculator.DataSet.tblFridges)
                profitcalculator.TblExpenseReportTableAdapter.Fill(profitcalculator.DataSet.tblExpenseReport)
                profitcalculator.TblRentSTableAdapter.Fill(profitcalculator.DataSet.tblRentS)
                profitcalculator.TblSupplierAccountsTableAdapter.Fill(profitcalculator.DataSet.tblSupplierAccounts)
                profitcalculator.TblwithdrawTableAdapter.Fill(profitcalculator.DataSet.tblwithdraw)
                profitcalculator.TblassetTableAdapter.Fill(profitcalculator.DataSet.tblasset)
                profitcalculator.TblsellcommissionTableAdapter.Fill(profitcalculator.DataSet.tblsellcommission)
                profitcalculator.TbldiscountTableAdapter.Fill(profitcalculator.DataSet.tbldiscount)
            ElseIf i = 42 Then
                purchasereport.TblProductsTableAdapter.Fill(purchasereport.DataSet.tblProducts)
                purchasereport.TblPurchaseTableAdapter.Fill(purchasereport.DataSet.tblPurchase)
                purchasereport.TblPurchaseReportTableAdapter.Fill(purchasereport.DataSet.tblPurchaseReport)
            ElseIf i = 43 Then
                'blank
            ElseIf i = 44 Then
                rentto.TblFridgesTableAdapter.Fill(rentto.DataSet.tblFridges)
                rentto.TblCustomersTableAdapter.Fill(rentto.DataSet.tblCustomers)
            ElseIf i = 45 Then
                returndamage.TblDamageProductsTableAdapter.Fill(returndamage.DataSet.tblDamageProducts)
            ElseIf i = 46 Then
                salesreport.TblInvoiceTableAdapter.Fill(salesreport.DataSet.tblInvoice)
                salesreport.TblSalesreportTableAdapter.Fill(salesreport.DataSet.tblSalesreport)
            ElseIf i = 47 Then
                supplieraccount.TblSupplierAccountsTableAdapter.Fill(supplieraccount.DataSet.tblSupplierAccounts)
                supplieraccount.TblPurchaseInvoiceTableAdapter.Fill(supplieraccount.DataSet.tblPurchaseInvoice)
                supplieraccount.TblExpensesTableAdapter.Fill(supplieraccount.DataSet.tblExpenses)
            ElseIf i = 48 Then
                managesignboard.TblSignboardTableAdapter.Fill(managesignboard.DataSet.tblSignboard)
            ElseIf i = 49 Then
                useraccounts.TblUserTableAdapter.Fill(useraccounts.DataSet.tblUser)
            ElseIf i = 50 Then
                login.TblUserTableAdapter.Fill(login.DataSet.tblUser)
            ElseIf i = 51 Then
                customeraccount.TblCusomterAccountsTableAdapter.Fill(customeraccount.DataSet.tblCusomterAccounts)
                customeraccount.TblInvoiceTableAdapter.Fill(customeraccount.DataSet.tblInvoice)
                customeraccount.TblVehicleAccountsTableAdapter.Fill(customeraccount.DataSet.tblVehicleAccounts)
                customeraccount.TblExpensesTableAdapter.Fill(customeraccount.DataSet.tblExpenses)
                customeraccount.TblIncomeTableAdapter.Fill(customeraccount.DataSet.tblIncome)
            ElseIf i = 52 Then
                transactionreport.TblTransactionReportTableAdapter.Fill(transactionreport.DataSet.tblTransactionReport)
                transactionreport.TblBankAccountsTableAdapter.Fill(transactionreport.DataSet.tblBankAccounts)
                transactionreport.TblTransactionTableAdapter.Fill(transactionreport.DataSet.tblTransaction)
            ElseIf i = 53 Then
                managecustomer.TblCustomersTableAdapter.Fill(managecustomer.DataSet.tblCustomers)
            ElseIf i = 54 Then
                addcustomer.TblCustomersTableAdapter.Fill(addcustomer.DataSet.tblCustomers)
            ElseIf i = 55 Then
                paysupplier.TblFridgesTableAdapter.Fill(paysupplier.DataSet.tblFridges)
                paysupplier.TblRentSTableAdapter.Fill(paysupplier.DataSet.tblRentS)
            ElseIf i = 56 Then
                paycustomer.TblFridgesTableAdapter.Fill(paycustomer.DataSet.tblFridges)
                paycustomer.TblRentCTableAdapter.Fill(paycustomer.DataSet.tblRentC)
            ElseIf i = 57 Then
                returndamagefridge.TblDamageFridgeTableAdapter.Fill(returndamagefridge.DataSet.tblDamageFridge)
            ElseIf i = 58 Then
                'blank
            ElseIf i = 59 Then
                'blank
            ElseIf i = 60 Then
                withdraw.TblwithdrawTableAdapter.Fill(withdraw.DataSet.tblwithdraw)
            ElseIf i = 61 Then
                myacc.TblUserTableAdapter.Fill(myacc.DataSet.tblUser)
            ElseIf i = 62 Then
                newvehicle.TblVehicleTableAdapter.Fill(newvehicle.DataSet.tblVehicle)
            ElseIf i = 63 Then
                managevehicle.TblVehicleTableAdapter.Fill(managevehicle.DataSet.tblVehicle)
            ElseIf i = 64 Then
                vehicleaccounts.TblSalesTableAdapter.Fill(vehicleaccounts.DataSet.tblSales)
                vehicleaccounts.TblVehicleAccountsTableAdapter.Fill(vehicleaccounts.DataSet.tblVehicleAccounts)
            ElseIf i = 65 Then
                'blank
            ElseIf i = 66 Then
                pinconfirmation.TblEmployeeTableAdapter.Fill(pinconfirmation.DataSet.tblEmployee)
            ElseIf i = 67 Then
                purchaseseason.TblPCommissionTableAdapter.Fill(purchaseseason.DataSet.tblPCommission)
                purchaseseason.TblProductsTableAdapter.Fill(purchaseseason.DataSet.tblProducts)
            ElseIf i = 68 Then
                saleseason.TblProductsTableAdapter.Fill(saleseason.DataSet.tblProducts)
            ElseIf i = 69 Then
                cashreport.TblCashReportTableAdapter.Fill(cashreport.DataSet.tblCashReport)
            ElseIf i = 70 Then
                sell_on_commisssion.TblsellcommissionTableAdapter.Fill(sell_on_commisssion.DataSet.tblsellcommission)
                sell_on_commisssion.TblProductsTableAdapter.Fill(sell_on_commisssion.DataSet.tblProducts)
                sell_on_commisssion.TblSuppliersTableAdapter.Fill(sell_on_commisssion.DataSet.tblSuppliers)
            ElseIf i = 71 Then
            ElseIf i = 72 Then
                discounts.TbldiscountTableAdapter.Fill(discounts.DataSet.tbldiscount)
            End If
        Catch ex As Exception
        End Try


        Return 0
    End Function
    Function ex(i)
        If i = 0 Then

        ElseIf i = 1 Then

        ElseIf i = 2 Then

        ElseIf i = 3 Then

        ElseIf i = 4 Then

        ElseIf i = 5 Then

        ElseIf i = 6 Then

        ElseIf i = 7 Then

        ElseIf i = 8 Then

        ElseIf i = 9 Then

        ElseIf i = 10 Then

        ElseIf i = 11 Then

        ElseIf i = 12 Then

        ElseIf i = 13 Then

        ElseIf i = 14 Then

        ElseIf i = 15 Then

        ElseIf i = 16 Then

        ElseIf i = 17 Then

        ElseIf i = 18 Then

        ElseIf i = 19 Then

        ElseIf i = 20 Then

        ElseIf i = 21 Then

        ElseIf i = 22 Then

        ElseIf i = 23 Then

        ElseIf i = 24 Then

        ElseIf i = 25 Then

        ElseIf i = 26 Then

        ElseIf i = 27 Then

        ElseIf i = 28 Then

        ElseIf i = 29 Then

        ElseIf i = 30 Then

        ElseIf i = 31 Then

        ElseIf i = 32 Then

        ElseIf i = 33 Then

        ElseIf i = 34 Then

        ElseIf i = 35 Then

        ElseIf i = 36 Then

        ElseIf i = 37 Then

        ElseIf i = 38 Then

        ElseIf i = 39 Then

        ElseIf i = 40 Then

        ElseIf i = 41 Then

        ElseIf i = 42 Then

        ElseIf i = 43 Then

        ElseIf i = 44 Then

        ElseIf i = 45 Then

        ElseIf i = 46 Then

        ElseIf i = 47 Then

        ElseIf i = 48 Then

        ElseIf i = 49 Then

        ElseIf i = 50 Then

        End If
        Return 0
    End Function
    Dim ct As New Timer
    Function center(f As Form, p As Panel)
        Dim t As New Timer
        t.Interval = 500
        t.Start()
        AddHandler t.Tick, Function()
                               If f.Name = "Dashboard" Then
                                   p.Top = (f.ClientSize.Height / 2) - (p.Height / 2)
                                   p.Left = (f.ClientSize.Width / 2) - (p.Width / 2)
                               Else
                                   p.Top = (f.ClientSize.Height / 2) - (p.Height / 2) + 20
                                   p.Left = (f.ClientSize.Width / 2) - (p.Width / 2)
                               End If
                               Return 0
                           End Function
        Return 0
    End Function


    Function cto(f As Form, p As Panel)
        Dim t As New Timer
        t.Start()
        AddHandler t.Tick, Function() ctm1(f, p)
        Return 0
    End Function
    Function ctm1(f As Form, p As Panel)
        p.Left = (f.ClientSize.Width / 2) - (p.Width / 2)
        ct.Stop()
        Return 0
    End Function
    Function ctc(f As Form, p As Panel)
        Dim t As New Timer
        t.Start()
        AddHandler t.Tick, Function() ctm2(f, p)
        Return 0
    End Function
    Function ctm2(f As Form, p As Panel)
        p.Top = (f.ClientSize.Height / 2) - (p.Height / 2)
        ct.Stop()
        Return 0
    End Function

    Function slt(pt As TextBox, nt As TextBox)
        AddHandler pt.KeyDown, Sub(ByVal sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = Keys.Enter Then
                                       nt.Select()
                                   End If
                               End Sub
        AddHandler nt.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = 8 Then
                                       If nt.Text = Nothing Then
                                           pt.Select()
                                       End If
                                   End If
                               End Sub

        Return 0
    End Function
    Function sltb(pt As TextBox, nt As ComboBox)
        AddHandler pt.KeyDown, Sub(ByVal sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = Keys.Enter Then
                                       nt.Select()

                                   End If
                               End Sub
        AddHandler nt.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = 8 Then
                                       If nt.Text = Nothing Then
                                           pt.Select()
                                       End If
                                   End If
                               End Sub

        Return 0
    End Function
    Function slta(pt As ComboBox, nt As TextBox)
        AddHandler pt.KeyDown, Sub(ByVal sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = Keys.Enter Then
                                       nt.Select()
                                   End If
                               End Sub
        AddHandler nt.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = 8 Then
                                       If nt.Text = Nothing Then
                                           pt.Select()
                                       End If
                                   End If
                               End Sub

        Return 0
    End Function

    Function prc(n, p)
        Dim r As Double
        Try
            r = (Double.Parse(p) / 100) * Double.Parse(n)
        Catch ex As Exception

        End Try
        Return r
    End Function
    Function dtsum(dt As DataGridView, a As Integer)
        Dim sum As Double = 0
        Try
            For i As Integer = 0 To dt.Rows.Count() - 1
                Try
                    sum = sum + Double.Parse(dt.Rows(i).Cells(a).Value().ToString())
                Catch ex As Exception
                    sum = sum + 0
                End Try
            Next
        Catch ex As Exception
            sum += 0
        End Try
        Return sum
    End Function

    Function auto(t As TextBox, dt As DataTable, c As String)
        Try
            Dim bw As New ComponentModel.BackgroundWorker
            AddHandler bw.DoWork, Function()
                                      Dim str(dt.Rows.Count - 1) As String
                                      For a = 0 To dt.Rows.Count - 1
                                          Try
                                              str(a) = dt.Rows(a)(c).ToString
                                          Catch ex As Exception

                                          End Try
                                      Next

                                      Try
                                          If t.InvokeRequired Then
                                              t.Invoke(New MethodInvoker(Sub()
                                                                             t.AutoCompleteSource = AutoCompleteSource.CustomSource
                                                                             t.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                                                                             t.AutoCompleteCustomSource.AddRange(str)
                                                                         End Sub))
                                          Else
                                              t.AutoCompleteSource = AutoCompleteSource.CustomSource
                                              t.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                                              t.AutoCompleteCustomSource.AddRange(str)
                                          End If
                                      Catch ex As Exception

                                      End Try
                                      Return Nothing
                                  End Function

            bw.RunWorkerAsync()
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Function autot(t As ToolStripTextBox, dt As DataTable, c As String, f As Form)
        Try
            Dim bw As New ComponentModel.BackgroundWorker
            AddHandler bw.DoWork, Function()
                                      Dim str(dt.Rows.Count - 1) As String
                                      For a = 0 To dt.Rows.Count - 1
                                          Try
                                              str(a) = dt.Rows(a)(c).ToString
                                          Catch ex As Exception

                                          End Try
                                      Next
                                      If f.InvokeRequired Then
                                          f.Invoke(New MethodInvoker(Sub()
                                                                         t.AutoCompleteCustomSource.AddRange(str)
                                                                         t.AutoCompleteSource = AutoCompleteSource.CustomSource
                                                                         t.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                                                                     End Sub))
                                      Else
                                          Try
                                              t.AutoCompleteCustomSource.AddRange(str)
                                              t.AutoCompleteSource = AutoCompleteSource.CustomSource
                                              t.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                                          Catch ex As Exception

                                          End Try
                                      End If
                                      Return Nothing
                                  End Function
            bw.RunWorkerAsync()
        Catch ex As Exception

        End Try
        Return Nothing
    End Function
    Function ft(f As Date, t As Date)
        'Dim s As String = ""
        'Dim d As Date = f
        'While d <= t
        '    d = d.AddDays(1)
        '    s = s + "date LIKE '%" & d & "%' OR "
        'End While
        'Return s & "date LIKE '%" & t & "%'"
        Return Nothing
    End Function
    Function ft1(f As Date, t As Date)
        Dim s As String = ""
        Dim d As Date = f
        While d <= t
            d = d.AddDays(1)
            s = s + "[date ] LIKE '%" + d + "%' OR "
        End While
        Return s & " [date ] LIKE '%" & t & "%'"
    End Function

    Function filterreport(pi As Integer, fi As Integer, ti As Integer, si As Integer, t As TextBox, d As BindingSource, fv As DateTimePicker, tv As DateTimePicker)
        Dim a As String = t.Text & ft(fv.Value.Date, tv.Value.Date)
        filter(pi, fi, ti, si, a)
        If t.Text = Nothing Then
            d.RemoveFilter()
        End If
        Return 0
    End Function
    Function filteracc(pi As Integer, fi As Integer, ti As Integer, si As Integer, s As String, d As BindingSource, fv As DateTimePicker, tv As DateTimePicker)
        Dim a As String = s & ft(fv.Value.Date, tv.Value.Date)
        filter(pi, fi, ti, si, s)
        Return 0
    End Function
    Function upp(p As PictureBox)

        Dim dlg As New OpenFileDialog
        dlg.Filter = "Image Files(*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp"
        Try
            If dlg.ShowDialog = DialogResult.OK Then
                p.Image = New Bitmap(dlg.FileName)
            End If
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Function sltc(pt As ComboBox, nt As ComboBox)
        AddHandler pt.KeyDown, Sub(ByVal sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = Keys.Enter Then
                                       nt.Select()

                                   End If
                               End Sub
        AddHandler nt.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                   If e.KeyCode = 8 Then
                                       If nt.Text = Nothing Then
                                           pt.Select()
                                       End If
                                   End If
                               End Sub



        Return 0
    End Function
    Function num(t As TextBox)
        Try
            AddHandler t.KeyPress, Sub(sender As Object, e As KeyPressEventArgs)
                                       e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Enter) Or e.KeyChar = Convert.ToChar(Keys.Back))
                                       If e.KeyChar = ChrW(Keys.Enter) AndAlso t.Text = Nothing Then
                                           t.Text = "0"
                                       End If
                                   End Sub
            AddHandler t.TextChanged, Sub()
                                          t.Text = t.Text.ToString.Replace("১", "1").Replace("২", "2").Replace("৩", "3").
                                           Replace("৪", "4").Replace("৫", "5").Replace("৬", "6").Replace("৭", "7").Replace("৮", "8").Replace("৯", "9").Replace("০", "0")
                                          t.SelectionStart = t.Text.Length + 1
                                      End Sub
        Catch ex As Exception

        End Try

        Return 0
    End Function
    Function phn(t As TextBox)
        Try
            AddHandler t.KeyPress, Sub(sender As Object, e As KeyPressEventArgs)
                                       e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "+" Or e.KeyChar = Convert.ToChar(Keys.Enter) Or e.KeyChar = Convert.ToChar(Keys.Back))
                                   End Sub
            AddHandler t.TextChanged, Sub()
                                          t.Text = t.Text.ToString.Replace("১", "1").Replace("২", "2").Replace("৩", "3").
                                           Replace("৪", "4").Replace("৫", "5").Replace("৬", "6").Replace("৭", "7").Replace("৮", "8").Replace("৯", "9").Replace("০", "0")
                                          t.SelectionStart = t.Text.Length + 1
                                      End Sub
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Function autoc(t As ComboBox, dt As DataTable, c As String)


        Dim bw As New ComponentModel.BackgroundWorker
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Dim src As New AutoCompleteStringCollection
        AddHandler bw.DoWork, Function(ByVal sender As Object, e As ComponentModel.DoWorkEventArgs)
                                  src = New AutoCompleteStringCollection
                                  src.Clear()
                                  For a = 0 To dt.Rows.Count - 1
                                      src.Add(dt.Rows(a)(c).ToString)
                                  Next
                                  Return Nothing
                              End Function
        AddHandler bw.RunWorkerCompleted, Function()
                                              t.AutoCompleteSource = AutoCompleteSource.CustomSource
                                              t.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                                              t.AutoCompleteCustomSource = src
                                              bw.Dispose()
                                              Return Nothing
                                          End Function
        bw.WorkerReportsProgress = True
        bw.RunWorkerAsync()
        Return Nothing




        '  t.Items.AddRange(src.t)




        Return 0
    End Function


    Function edit(d As BindingSource, i As Integer, pi As Integer, b As Button, l As Label, s As String, l1 As String)
        Try
            fll(pi)
            ld(pi)
            index(pi)
            d.Filter = "Id =" & i
            b.Text = "Update"
            l.Text = s

            AddHandler b.Click, Function()
                                    b.Text = "Add"
                                    l.Text = l1
                                    Return 0
                                End Function

        Catch ex As Exception

        End Try

        Return 0
    End Function
    Function editin(p As Panel, b As Button, g As GroupBox, s As String, s1 As String, dt As DataGridView)
        Try
            dt.Enabled = False
            p.Enabled = True
            b.Text = "সংশোধন"
            g.Text = s
            AddHandler b.Click, Function()
                                    b.Text = "যুক্ত করুন"
                                    g.Text = s1
                                    dt.Enabled = True
                                    Return 0
                                End Function
        Catch ex As Exception

        End Try
        Return 0
    End Function

    Function ab(i As Integer, s As Integer)

        If i = 19 Then
            edit(addbank.TblBanksBindingSource, managebank.IdTextBox.Text, 0, addbank.Button1, addbank.Label1, "ব্যাংক সংশোধন", "ব্যাংক যুক্ত করুন")
        ElseIf i = 3 Then
            Try
                addfridge.DateTimePicker2.Value = Date.Parse(addfridge.IssueDateTextBox.Text)
            Catch ex As Exception

            End Try
            edit(addfridge.TblFridgesBindingSource, managefridge.IdTextBox.Text, 3, addfridge.Button1, addfridge.Label1, "ফ্রিজের কোম্পানি সংক্রান্ত তথ্য সংশোধন", "কোম্পানি হতে ফ্রিজ গ্রহণ")
        ElseIf i = 11 Then
            Try
                damageFridge.dt.Value = Date.Parse(damageFridge.IssueDateTextBox.Text)
            Catch ex As Exception

            End Try
            editin(damageFridge.Panel2, damageFridge.Button1, damageFridge.GroupBox1, "ড্যামেজ ফ্রিজের সংশোধন", "ড্যামেজ ফ্রিজ যুক্ত করুন", damageFridge.TblDamageFridgeDataGridView)
        ElseIf i = 16 Then
            If s = 0 Then
                editin(expensecategory.Panel2, expensecategory.Button4, expensecategory.GroupBox1, "খরচের ধরন সংশোধন", "খরচের নতুন ধরন", expensecategory.TblExpenseCategoryDataGridView)
            ElseIf s = 1 Then
                editin(expensecategory.Panel3, expensecategory.Button3, expensecategory.GroupBox2, "খরচের সহকারী ধরন সংশোধন", "খরচের নতুন সহকারী ধরন", expensecategory.TblExpenseSubcategoryDataGridView)

            End If
        ElseIf i = 20 Then
            If s = 0 Then
                editin(incomecategory.Panel2, incomecategory.Button4, incomecategory.GroupBox1, "প্রাপ্তির ধরন সংশোধন", "প্রাপ্তীর নতুন ধরন", incomecategory.TblIncomeCategoryDataGridView)
            ElseIf s = 1 Then
                editin(incomecategory.Panel3, incomecategory.Button2, incomecategory.GroupBox2, "প্রাপ্তির সহকারী ধরন সংশোধন", "প্রাপ্তির সহকারী ধরন", incomecategory.TblIncomeSubcategoryDataGridView)
            End If
        ElseIf i = 21 Then
            Try
                If newsale.PadiTextBox.Text.Length > 0 AndAlso (newsale.BankamountTextBox.Text = 0 Or newsale.BankamountTextBox.Text = Nothing) Then
                    newsale.cmbmethod.SelectedIndex = 0
                ElseIf newsale.BankamountTextBox.Text.Length > 0 AndAlso (newsale.PadiTextBox.Text = 0 Or newsale.PadiTextBox.Text = Nothing) Then
                    newsale.cmbmethod.SelectedIndex = 1
                ElseIf (newsale.PaidTextBox.Text.Length > 0 AndAlso (newsale.PadiTextBox.Text = 0) = False) AndAlso (newsale.BankamountTextBox.Text.Length > 0 AndAlso (newsale.BankamountTextBox.Text = 0) = False) Then
                    newsale.cmbmethod.SelectedIndex = 2
                End If

                newsale.datt.Value = Date.Parse(newsale.DateTextBox.Text)

            Catch ex As Exception

            End Try
            newsale.mode = 1
            edit(newsale.TblInvoiceBindingSource, managesale.IdTextBox.Text, 37, newsale.Button1, newsale.Label1, newsale.Label1.Text, newsale.Label1.Text)
        ElseIf i = 22 Then
            Try
                manageasset.dtp.Value = Date.Parse(manageasset.IssueDateTextBox.Text)
            Catch ex As Exception

            End Try
            editin(manageasset.Panel1, manageasset.Button1, manageasset.GroupBox1, "সম্পদের তথ্য সংশোধন", "নতুন সম্পদ", manageasset.TblassetDataGridView)
        ElseIf i = 23 Then

            editin(managebankaccount.Panel2, managebankaccount.Button1, managebankaccount.GroupBox1, "", "", managebankaccount.TblBankAccountsDataGridView)
            ElseIf i = 24 Then

            edit(adddamage.TblDamageProductsBindingSource, managedamage.IdTextBox.Text, 1, adddamage.Button1, adddamage.Label1, "ড্যামেজ পণ্যের তথ্য সংশোধন", "ড্যামেজ পণ্য যুক্ত করুন")
        ElseIf i = 25 Then
                Try
                    addemployee.DateTimePicker2.Value = Date.Parse(addemployee.DateOfBirthTextBox.Text)
                    addemployee.DateTimePicker1.Value = Date.Parse(addemployee.JoinDateTextBox.Text)
                Catch ex As Exception

                End Try
            edit(addemployee.TblEmployeeBindingSource, manageemployee.IdTextBox.Text, 2, addemployee.Button1, addemployee.Label1, "কর্মচারীর তথ্য সংশোধন", "নতুন কর্মচারী")
        ElseIf i = 26 Then
                Try
                    newexpense.DateTimePicker1.Value = Date.Parse(newexpense.DateTextBox.Text)
                Catch ex As Exception

                End Try
                'payment method selection 
                If newexpense.AmountTextBox.Text.Length > 0 AndAlso (newexpense.BankamountTextBox.Text = 0 Or newexpense.BankamountTextBox.Text = Nothing) Then
                    newexpense.PaymentMethodComboBox.SelectedIndex = 0
                ElseIf newexpense.BankamountTextBox.Text.Length > 0 AndAlso (newexpense.AmountTextBox.Text = 0 Or newexpense.AmountTextBox.Text = Nothing) Then
                    newexpense.PaymentMethodComboBox.SelectedIndex = 1
                ElseIf (newexpense.AmountTextBox.Text.Length > 0 AndAlso (newexpense.AmountTextBox.Text = 0) = False) AndAlso (newexpense.BankamountTextBox.Text.Length > 0 AndAlso (newexpense.BankamountTextBox.Text = 0) = False) Then
                    newexpense.PaymentMethodComboBox.SelectedIndex = 2
                End If

            edit(newexpense.TblExpensesBindingSource, manageexpense.IdTextBox.Text, 34, newexpense.Button1, newexpense.Label1, "খরচ ও প্রদান সংশোধন", "নতুন খরচ/প্রদান")
        ElseIf i = 27 Then

        ElseIf i = 28 Then
                Try
                    newincome.datt.Value = Date.Parse(newincome.DateTextBox.Text)
                Catch ex As Exception

                End Try
            Try
                'payment method selection
                If newincome.AmountTextBox.Text.Length > 0 AndAlso (newincome.BankamountTextBox.Text = 0 Or newincome.BankamountTextBox.Text = Nothing) Then
                    newincome.PaymentmethodComboBox.SelectedIndex = 0
                ElseIf newincome.BankamountTextBox.Text.Length > 0 AndAlso (newincome.AmountTextBox.Text = 0 Or newincome.AmountTextBox.Text = Nothing) Then
                    newincome.PaymentmethodComboBox.SelectedIndex = 1
                ElseIf (newincome.AmountTextBox.Text.Length > 0 AndAlso (newincome.AmountTextBox.Text = 0) = False) AndAlso (newincome.BankamountTextBox.Text.Length > 0 AndAlso (newincome.BankamountTextBox.Text = 0) = False) Then
                    newincome.PaymentmethodComboBox.SelectedIndex = 2
                End If
            Catch ex As Exception

            End Try

            edit(newincome.TblIncomeBindingSource, Integer.Parse(manageincome.IdTextBox.Text), 35, newincome.Button2, newincome.Label1, "আয় ও প্রাপ্তি সংশোধন", "নতুন আয়/প্রাপ্তি")
        ElseIf i = 29 Then

            edit(addproduct.TblProductsBindingSource, manageproduct.IdTextBox.Text, 5, addproduct.Button1, addproduct.Label1, "পণ্য সংক্রান্ত তথ্যের সংশোধন", "পণ্য যুক্ত করুন")
        ElseIf i = 30 Then
                Try
                newpurchase.date_picker.Value = Date.Parse(newpurchase.DateTextBox.Text)
                'payment method selection

                If newpurchase.PaidTextBox1.Text.Length > 0 AndAlso (newpurchase.BankamountTextBox.Text = 0 Or newpurchase.BankamountTextBox.Text = Nothing) Then
                        newpurchase.PaymentmethodComboBox.SelectedIndex = 0
                    ElseIf newpurchase.BankamountTextBox.Text.Length > 0 AndAlso (newpurchase.PaidTextBox1.Text = 0 Or newpurchase.PaidTextBox1.Text = Nothing) Then
                        newpurchase.PaymentmethodComboBox.SelectedIndex = 1
                    ElseIf (newpurchase.PaidTextBox1.Text.Length > 0 AndAlso (newpurchase.PaidTextBox1.Text = 0) = False) AndAlso (newpurchase.BankamountTextBox.Text.Length > 0 AndAlso (newpurchase.BankamountTextBox.Text = 0) = False) Then
                        newpurchase.PaymentmethodComboBox.SelectedIndex = 2
                    End If


                Catch ex As Exception

                End Try
                newpurchase.mode = 1
                edit(newpurchase.TblPurchaseBindingSource, managepurchase.IdTextBox.Text, 36, newpurchase.Button1, newpurchase.Label1, "Purchase invoice", "Purchase invoice")
            ElseIf i = 32 Then
            edit(addsupplier.TblSuppliersBindingSource, managesupplier.IdTextBox.Text, 6, addsupplier.Button1, addsupplier.Label1, "কোম্পানির তথ্য সংশোধন", "কোম্পানি যুক্ত করুন")
            addsupplier.TblSupplierAccountsBindingSource.AddNew()
            ElseIf i = 33 Then
                If managetransaction.TransactionTypeTextBox.Text = "Deposit" Then
                    managetransaction.rdnD.Checked = True
                ElseIf managetransaction.TransactionTypeTextBox.Text = "Withdraw" Then
                    managetransaction.rdnW.Checked = True
                End If
                Try
                    managetransaction.fromDt.Value = Date.Parse(managetransaction.DateTextBox.Text)
                Catch ex As Exception

                End Try
            editin(managetransaction.Panel2, managetransaction.Button1, managetransaction.GroupBox1, "ব্যাংক লেনদেন সংশোধন", "নতুন ব্যাংক লেনদেন", managetransaction.TblTransactionDataGridView)
        ElseIf i = 39 Then
                Try
                    productdelivery.DateTimePicker1.Value = Date.Parse(productdelivery.DateTextBox.Text)
                    productdelivery.DateTimePicker2.Value = Date.Parse(productdelivery.TimeTextBox.Text)
                Catch ex As Exception

                End Try
            editin(productdelivery.Panel2, productdelivery.Button1, productdelivery.GroupBox1, "পণ্যের ডেলিভারী সংশোধন", "নতুন ডেলিভারী", productdelivery.TblDeliveryDataGridView)
        ElseIf i = 40 Then
            editin(productcategory.Panel2, productcategory.Button4, productcategory.GroupBox1, "পন্যের ধরণ সংশোধন", "পণ্যের নতুন ধরন", productcategory.TblProductCategoryDataGridView)
        ElseIf i = 44 Then
                Try
                    rentto.DateTimePicker1.Value = Date.Parse(rentto.RentedAtTextBox.Text)
                Catch ex As Exception

                End Try
            edit(rentto.TblFridgesBindingSource, managefridge.FridgeIDTextBox.Text, 44, rentto.Button1, rentto.Label1, "ফ্রিজের কাস্টমার সংক্রান্ত তথ্য সংশোধন", "কাস্টমারকে ফ্রিজ প্রদান করুন")
        ElseIf i = 53 Then
            edit(addcustomer.TblCustomersBindingSource, managecustomer.IdTextBox.Text, 54, addcustomer.Button1, addcustomer.Label1, "কাস্টমারের তথ্য সংশোধন", "কাস্টমার যুক্ত করুন")
            addcustomer.TblCusomterAccountsBindingSource.AddNew()
            ElseIf i = 60 Then
                Try
                    withdraw.DateTimePicker1.Value = Date.Parse(withdraw.DateTextBox.Text)
                Catch ex As Exception

                End Try
            editin(withdraw.Panel2, withdraw.Button1, withdraw.GroupBox1, "উত্তোলন সংশোধন", "নতুন উত্তোলন", withdraw.TblwithdrawDataGridView)
        ElseIf i = 63 Then
                Try
                    newvehicle.DateTimePicker1.Value = Date.Parse(newvehicle.IssueDateTextBox.Text)
                Catch ex As Exception

                End Try
            edit(newvehicle.TblVehicleBindingSource, managevehicle.VehicleIDTextBox.Text, 62, newvehicle.Button1, newvehicle.Label1, "বাহনের তথ্য সংশোধন", "নতুন বাহন")
        End If



            Return 0
    End Function


    Function printP(p As Panel)
        Dim pd As New Printing.PrintDocument
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim bmp As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim g As Graphics = Graphics.FromImage(bmp)
                                     p.DrawToBitmap(bmp, p.ClientRectangle)
                                     e.Graphics.DrawImage(bmp, 0, 0)
                                     bmp.RotateFlip(RotateFlipType.Rotate90FlipX)
                                 End Sub

        pd.Print()
        Return 0
    End Function
    Function printD(p As DataGridView)
        Dim pd As New Printing.PrintDocument
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim bmp As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim g As Graphics = Graphics.FromImage(bmp)
                                     p.DrawToBitmap(bmp, p.ClientRectangle)
                                     Dim newMargins As System.Drawing.Printing.Margins
                                     newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     pd.DefaultPageSettings.Margins = newMargins
                                     bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                     Dim ImgRect As New Rectangle(0, 0, 800, 1000)
                                     e.Graphics.DrawImage(bmp, ImgRect)



                                 End Sub

        Try

            pd.Print()
        Catch ex As Exception

        End Try
        Return 0
    End Function

    Function printP0(p As Panel, c As String)
        Dim pd As New Printing.PrintDocument
        Dim newprint As New prnt
        newprint.Show()
        newprint.pnlSign.Visible = True
        newprint.chkShow.Checked = True
        newprint.lblcaption.Text = c
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim w As Integer = p.Width
                                     Dim h As Integer = p.Height

                                     If w > newprint.pnlMain.Width Or h > newprint.pnlMain.Height Then

                                         w = w / 1.2
                                         h = h / 1.2
                                     ElseIf (w / 1.2) > newprint.pnlMain.Width Or (h / 1.2) > newprint.pnlMain.Height Then

                                         w = (w / 1.2) / 1.2
                                         h = (h / 1.2) / 1.2
                                     End If

                                     p.BackColor = Color.White
                                     Dim bm As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim gp As Graphics = Graphics.FromImage(bm)
                                     Dim rct As New Rectangle(3, 3, p.Width, p.Height)
                                     p.DrawToBitmap(bm, rct)

                                     Dim pic As New PictureBox
                                     pic.Image = bm
                                     pic.SizeMode = PictureBoxSizeMode.StretchImage
                                     pic.BorderStyle = BorderStyle.FixedSingle



                                     pic.Height = bm.Height
                                     pic.Width = bm.Width

                                     If pic.Height > newprint.pnlMain.Height Or pic.Width > newprint.pnlMain.Width Then
                                         pic.Height = pic.Height / 1.2
                                         pic.Width = pic.Width / 1.2
                                     ElseIf (pic.Height / 1.2) > newprint.pnlMain.Height Or (pic.Width / 1.2) > newprint.pnlMain.Width Then
                                         pic.Height = (pic.Height / 1.2) / 1.2
                                         pic.Width = (pic.Width / 1.2) / 1.2
                                     End If

                                     pic.Top = (newprint.pnlMain.ClientSize.Height / 2) - (pic.Height / 2)
                                     pic.Left = (newprint.pnlMain.ClientSize.Width / 2) - (pic.Width / 2)

                                     newprint.pnlMain.Controls.Add(pic)


                                     Dim bmp As Bitmap = New Bitmap(newprint.pnl.Width, newprint.pnl.Height)
                                     Dim g As Graphics = Graphics.FromImage(bmp)
                                     newprint.pnl.DrawToBitmap(bmp, newprint.pnl.ClientRectangle)
                                     Dim newMargins As System.Drawing.Printing.Margins
                                     newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     pd.DefaultPageSettings.Margins = newMargins
                                     Dim imgrect As New Rectangle(5, 5, newprint.pnl.Width, newprint.pnl.Height)
                                     e.Graphics.DrawImage(bmp, imgrect)
                                 End Sub

        Try
            AddHandler newprint.btnPrint.Click, Function()
                                                    pd.Print()
                                                    newprint.Close()
                                                    p.BackColor = Color.Transparent
                                                    Return 0
                                                End Function
            AddHandler newprint.btnPrint.Click, Function()
                                                    p.BackColor = Color.Transparent
                                                    Return 0
                                                End Function
            AddHandler newprint.btnClose.Click, Function()
                                                    p.BackColor = Color.Transparent
                                                    Return 0
                                                End Function
        Catch ex As Exception

        End Try
        Return 0
    End Function

    Function printFP(p As Panel, c As String)
        Dim pd As New Printing.PrintDocument
        Dim newprint As New prnt
        newprint.Show()
        newprint.pnlSign.Visible = True
        newprint.chkShow.Checked = True
        newprint.lblcaption.Text = c
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim w As Integer = p.Width
                                     Dim h As Integer = p.Height

                                     If w > newprint.pnlMain.Width Or h > newprint.pnlMain.Height Then

                                         w = w / 1.2
                                         h = h / 1.2
                                     ElseIf (w / 1.2) > newprint.pnlMain.Width Or (h / 1.2) > newprint.pnlMain.Height Then

                                         w = (w / 1.2) / 1.2
                                         h = (h / 1.2) / 1.2
                                     End If

                                     Dim bm As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim gp As Graphics = Graphics.FromImage(bm)
                                     Dim rct As New Rectangle(3, 3, p.Width, p.Height)
                                     p.DrawToBitmap(bm, rct)

                                     Dim pic As New PictureBox
                                     pic.Image = bm
                                     pic.SizeMode = PictureBoxSizeMode.StretchImage
                                     pic.BorderStyle = BorderStyle.FixedSingle



                                     pic.Height = bm.Height
                                     pic.Width = bm.Width

                                     If pic.Height > newprint.pnlMain.Height Or pic.Width > newprint.pnlMain.Width Then
                                         pic.Height = pic.Height / 1.2
                                         pic.Width = pic.Width / 1.2
                                     ElseIf (pic.Height / 1.2) > newprint.pnlMain.Height Or (pic.Width / 1.2) > newprint.pnlMain.Width Then
                                         pic.Height = (pic.Height / 1.2) / 1.2
                                         pic.Width = (pic.Width / 1.2) / 1.2
                                     End If

                                     pic.Top = (newprint.pnlMain.ClientSize.Height / 2) - (pic.Height / 2)
                                     pic.Left = (newprint.pnlMain.ClientSize.Width / 2) - (pic.Width / 2)

                                     newprint.pnlMain.Controls.Add(pic)


                                     Dim bmp As Bitmap = New Bitmap(newprint.pnl.Width, newprint.pnl.Height)
                                     Dim g As Graphics = Graphics.FromImage(bmp)
                                     newprint.pnl.DrawToBitmap(bmp, newprint.pnl.ClientRectangle)
                                     Dim newMargins As System.Drawing.Printing.Margins
                                     newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     pd.DefaultPageSettings.Margins = newMargins
                                     Dim imgrect As New Rectangle(5, 5, newprint.pnl.Width, newprint.pnl.Height)
                                     bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                     e.Graphics.DrawImage(bmp, imgrect)







                                     'While pic.Height <= 722 AndAlso pic.Width <= 694
                                     '    pic.Height = pic.Height / 1.2
                                     '    pic.Width = pic.Width / 1.2
                                     'End While



                                     'Dim bmp1 As Bitmap = New Bitmap(newprint.Width, newprint.Height)
                                     'Dim g1 As Graphics = Graphics.FromImage(bmp1)
                                     'newprint.DrawToBitmap(bmp1, newprint.ClientRectangle)
                                     'Dim newMargins1 As System.Drawing.Printing.Margins
                                     'newMargins1 = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     'pd.DefaultPageSettings.Margins = newMargins1
                                     'Dim ImgRect1 As New Rectangle(5, 5, 850, 1100)
                                     'e.Graphics.DrawImage(bmp1, ImgRect1)



                                 End Sub

        Try
            AddHandler newprint.btnPrint.Click, Function()
                                                    pd.Print()
                                                    newprint.Close()
                                                    Return 0
                                                End Function
            AddHandler newprint.btnClose.Click, Function()
                                                    p.BackColor = Color.Transparent
                                                    Return 0
                                                End Function

        Catch ex As Exception

        End Try
        Return 0
    End Function


    Function printD(p As DataGridView, c As String)
        Dim pd As New Printing.PrintDocument
        Dim newprint As New prnt
        newprint.Show()
        newprint.pnlSign.Visible = True
        newprint.chkShow.Checked = True
        newprint.lblcaption.Text = c
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim w As Integer = p.Width
                                     Dim h As Integer = p.Height

                                     If w > newprint.pnlMain.Width Or h > newprint.pnlMain.Height Then

                                         w = w / 1.2
                                         h = h / 1.2
                                     ElseIf (w / 1.2) > newprint.pnlMain.Width Or (h / 1.2) > newprint.pnlMain.Height Then

                                         w = (w / 1.2) / 1.2
                                         h = (h / 1.2) / 1.2
                                     End If

                                     Dim bm As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim gp As Graphics = Graphics.FromImage(bm)
                                     Dim rct As New Rectangle(3, 3, p.Width, p.Height)
                                     p.DrawToBitmap(bm, rct)

                                     Dim pic As New PictureBox
                                     pic.Image = bm
                                     pic.SizeMode = PictureBoxSizeMode.StretchImage
                                     pic.BorderStyle = BorderStyle.FixedSingle



                                     pic.Height = bm.Height
                                     pic.Width = bm.Width

                                     If pic.Height > newprint.pnlMain.Height Or pic.Width > newprint.pnlMain.Width Then
                                         pic.Height = pic.Height / 1.2
                                         pic.Width = pic.Width / 1.2
                                     ElseIf (pic.Height / 1.2) > newprint.pnlMain.Height Or (pic.Width / 1.2) > newprint.pnlMain.Width Then
                                         pic.Height = (pic.Height / 1.2) / 1.2
                                         pic.Width = (pic.Width / 1.2) / 1.2
                                     End If

                                     pic.Top = (newprint.pnlMain.ClientSize.Height / 2) - (pic.Height / 2)
                                     pic.Left = (newprint.pnlMain.ClientSize.Width / 2) - (pic.Width / 2)

                                     newprint.pnlMain.Controls.Add(pic)


                                     Dim bmp As Bitmap = New Bitmap(newprint.pnl.Width, newprint.pnl.Height)
                                     Dim g As Graphics = Graphics.FromImage(bmp)
                                     newprint.pnl.DrawToBitmap(bmp, newprint.pnl.ClientRectangle)
                                     Dim newMargins As System.Drawing.Printing.Margins
                                     newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     pd.DefaultPageSettings.Margins = newMargins
                                     Dim imgrect As New Rectangle(5, 5, newprint.pnl.Width, newprint.pnl.Height)
                                     bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                     e.Graphics.DrawImage(bmp, imgrect)







                                     'While pic.Height <= 722 AndAlso pic.Width <= 694
                                     '    pic.Height = pic.Height / 1.2
                                     '    pic.Width = pic.Width / 1.2
                                     'End While



                                     'Dim bmp1 As Bitmap = New Bitmap(newprint.Width, newprint.Height)
                                     'Dim g1 As Graphics = Graphics.FromImage(bmp1)
                                     'newprint.DrawToBitmap(bmp1, newprint.ClientRectangle)
                                     'Dim newMargins1 As System.Drawing.Printing.Margins
                                     'newMargins1 = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     'pd.DefaultPageSettings.Margins = newMargins1
                                     'Dim ImgRect1 As New Rectangle(5, 5, 850, 1100)
                                     'e.Graphics.DrawImage(bmp1, ImgRect1)



                                 End Sub

        Try
            AddHandler newprint.btnPrint.Click, Function()
                                                    pd.Print()
                                                    newprint.Close()
                                                    Return 0
                                                End Function

        Catch ex As Exception

        End Try
        Return 0
    End Function

    Function dat(f As DateTimePicker, t As DateTimePicker)
        Try
            Dim tm As New Timer
            tm.Start()
            AddHandler tm.Tick, Function()
                                    If f.Value.Date > t.Value.Date Or f.Value.Date = t.Value.Date Then
                                        While f.Value.Date < t.Value.Date
                                            f.Value.Date.AddDays(-1)
                                        End While
                                    End If
                                    Return 0
                                End Function
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Function st(t As ToolStrip, d As DataGridView, a As Integer, b As Integer, c As Integer)
        Try
            Dim tm As New Timer
            tm.Start()
            AddHandler tm.Tick, Function()
                                    t.Items(0).Text = "Total payment: " & dtsum(d, a)
                                    t.Items(2).Text = "Paid: " & dtsum(d, b)
                                    t.Items(4).Text = "Due: " & dtsum(d, c)
                                    Return 0
                                End Function
        Catch ex As Exception

        End Try

        Return 0
    End Function
    Function printF(p As Form)
        Try
            Dim pd As New Printing.PrintDocument
            AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                         Dim bmp As Bitmap = New Bitmap(p.Width, p.Height)
                                         Dim g As Graphics = Graphics.FromImage(bmp)
                                         p.DrawToBitmap(bmp, p.ClientRectangle)
                                         Dim newMargins As System.Drawing.Printing.Margins
                                         newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                         pd.DefaultPageSettings.Margins = newMargins
                                         Dim ImgRect As New Rectangle(0, 0, 800, p.Height)
                                         e.Graphics.DrawImage(bmp, ImgRect)
                                     End Sub

            Try

                pd.Print()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Function printF0(p As Form)
        Dim pd As New Printing.PrintDocument
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim bmp As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim g As Graphics = Graphics.FromImage(bmp)
                                     p.DrawToBitmap(bmp, p.ClientRectangle)
                                     Dim newMargins As System.Drawing.Printing.Margins
                                     newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     pd.DefaultPageSettings.Margins = newMargins
                                     Dim ImgRect As New Rectangle(0, 0, 800, p.Height)
                                     e.Graphics.DrawImage(bmp, ImgRect)



                                 End Sub

        Try

            pd.Print()
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Function printD0(p As DataGridView)
        Dim pd As New Printing.PrintDocument
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim bmp As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim g As Graphics = Graphics.FromImage(bmp)
                                     p.DrawToBitmap(bmp, p.ClientRectangle)
                                     Dim newMargins As System.Drawing.Printing.Margins
                                     newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     pd.DefaultPageSettings.Margins = newMargins
                                     Dim ImgRect As New Rectangle(0, 0, 800, p.Height)
                                     e.Graphics.DrawImage(bmp, ImgRect)



                                 End Sub

        Try

            pd.Print()
        Catch ex As Exception

        End Try
        Return 0
    End Function


    Function conf()
        Try
            pinconfirmation.TblEmployeeBindingSource.Filter = "Id ='" & newexpense.txtEmployeeID.Text & "'"
            If pinconfirmation.TblEmployeeBindingSource.Count > 0 Then
                If Integer.Parse(pinconfirmation.txtpin.Text) = Integer.Parse(pinconfirmation.PinTextBox.Text) Then
                    newexpense.ConfirmatoinTextBox.Text = "Yes"
                    index(34)
                    newexpense.ExpenseNoteTextBox.Select()
                Else
                    status("Wrong pin!")
                End If
            End If
        Catch ex As Exception

        End Try
        Return 0
    End Function

    Function paymentmethod(c As ComboBox)
        Try
            Dim thd As New Threading.Thread(Sub()
                                                c.Items.Clear()
                                                c.Items.Add("Cash")
                                                c.Items.Add("Bank")
                                                c.Items.Add("Cash & bank")
                                                c.SelectedIndex = 0
                                            End Sub)
            thd.Start()
        Catch ex As Exception

        End Try
        Return 0
    End Function




    Function important()
        Dim i As Integer = 0

        Try
            'filling and loading
            fll(12)
            ld(12)
            'filtering
            managepurchase.TblPurchaseInvoiceBindingSource.Filter = "date = '" & Today & "'"
            manageincome.TblIncomeBindingSource.Filter = "date = '" & Today & "'"
            manageexpense.TblExpensesBindingSource.Filter = "date = '" & Today & "'"
            profitcalculator.TblProfitBindingSource.Filter = "date ='" & Today & "'"
            managedamage.TblDamageProductsBindingSource.Filter = "damage_date ='" & Today & "'"


            Dim salecount As Integer = dashboard.TblInvoiceBindingSource.Count
            Dim purchasecount As Integer = dtsum(managepurchase.TblPurchaseInvoiceDataGridView, 3)
            Dim nincome As Double = dtsum(profitcalculator.TblProfitDataGridView, 1)
            Dim nexpense As Double = dtsum(profitcalculator.TblProfitDataGridView, 2)
            Dim nprofit As Double = dtsum(profitcalculator.TblProfitDataGridView, 3)
            Dim nasset As Double = dtsum(profitcalculator.TblProfitDataGridView, 7)
            Dim bankbalance As Double = dtsum(profitcalculator.TblProfitDataGridView, 4)
            Dim drdue As Double = dtsum(profitcalculator.TblProfitDataGridView, 5)
            Dim crdue As Double = dtsum(profitcalculator.TblProfitDataGridView, 6)
            Dim damageproduct As Integer = dtsum(managedamage.TblDamageProductsDataGridView, 6)
            Dim dmg As Integer = damageFridge.TblDamageFridgeBindingSource.Count
            Dim lowstock As Integer = dashboard.TblProductsBindingSource.Count
            'filter removing


            MsgBox("Important notifcation" & vbNewLine & vbNewLine &
            lowstock & " -products out of stock" & vbNewLine &
            salecount & " -sale invoices created" & vbNewLine &
            purchasecount & " " & dashboard.CurrencyTextBox.Text & " -used for purchase" & vbNewLine &
            nincome & " " & dashboard.CurrencyTextBox.Text & " -total income" & vbNewLine &
            nexpense & " " & dashboard.CurrencyTextBox.Text & " -total expense" & vbNewLine &
            nprofit & " " & dashboard.CurrencyTextBox.Text & " -total profit" & vbNewLine &
            nasset & " " & dashboard.CurrencyTextBox.Text & " -total asset" & vbNewLine &
            bankbalance & " " & dashboard.CurrencyTextBox.Text & " -total bank balance" & vbNewLine &
            drdue & " " & dashboard.CurrencyTextBox.Text & " -total debit due" & vbNewLine &
            crdue & " " & dashboard.CurrencyTextBox.Text & " -total credit due" & vbNewLine &
            damageproduct & " -damage products" & vbNewLine &
            damageproduct & " -damage fridge.",
               MsgBoxStyle.OkOnly
            )


            'removing filter
            profitcalculator.TblProfitBindingSource.RemoveFilter()
            managedamage.TblDamageProductsBindingSource.RemoveFilter()
            damageFridge.TblDamageFridgeBindingSource.RemoveFilter()


        Catch ex As Exception

        End Try
        Return i

    End Function
    Function admin_permission(i As Integer)
        Dim permission_grant As New login
        permission_grant.txtUserID.Select()
        slt(permission_grant.txtUserID, permission_grant.txtUserPass)
        sltb(permission_grant.txtUserPass, permission_grant.txtUserRole)
        autoc(permission_grant.txtUserRole, permission_grant.DataSet.tblUser, "role")
        permission_grant.Show()
        permission_grant.WindowState = FormWindowState.Normal
        permission_grant.TopLevel = False
        permission_grant.Dock = DockStyle.Fill
        Form1.pnlMain.Controls.Clear()
        Form1.pnlMain.Controls.Add(permission_grant)
        autoc(permission_grant.txtUserRole, permission_grant.DataSet.tblUser, "role")
        permission_grant.TblUserTableAdapter.Fill(permission_grant.DataSet.tblUser)

        RemoveHandler permission_grant.txtUserRole.KeyDown, AddressOf permission_grant.txtUserRole_KeyDown
        RemoveHandler permission_grant.btnLogin.Click, AddressOf permission_grant.Button2_Click
        RemoveHandler permission_grant.btnCancel.Click, AddressOf permission_grant.btnCancel_Click
        AddHandler permission_grant.txtUserRole.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                             If e.KeyCode = Keys.Enter Then
                                                                 Try
                                                                     permission_grant.TblUserBindingSource.Filter = "userID =" & permission_grant.txtUserID.Text
                                                                 Catch ex As Exception

                                                                 End Try
                                                                 If permission_grant.txtUserID.Text = permission_grant.UserIDTextBox.Text AndAlso permission_grant.txtUserPass.Text = permission_grant.PasswordTextBox.Text AndAlso permission_grant.txtUserRole.Text = permission_grant.RoleTextBox.Text AndAlso permission_grant.txtUserID.Text IsNot Nothing AndAlso permission_grant.txtUserPass.Text IsNot Nothing AndAlso permission_grant.txtUserRole.Text IsNot Nothing Then
                                                                     index(i)
                                                                     fll(i)
                                                                     ld(i)
                                                                     If i = 10 Then
                                                                         nw(10, 0)
                                                                     End If
                                                                     status("Logged in as " & permission_grant.RoleTextBox.Text)
                                                                     Form1.tmrBasic.Start()
                                                                     Form1.MenuStrip1.Enabled = True
                                                                 Else
                                                                     status("Wrong login information! Please try again :-)")
                                                                 End If
                                                             End If
                                                         End Sub
        AddHandler permission_grant.btnLogin.Click, Function()
                                                        Try
                                                            permission_grant.TblUserBindingSource.Filter = "userID =" & permission_grant.txtUserID.Text
                                                        Catch ex As Exception

                                                        End Try
                                                        If permission_grant.txtUserID.Text = permission_grant.UserIDTextBox.Text AndAlso permission_grant.txtUserPass.Text = permission_grant.PasswordTextBox.Text AndAlso permission_grant.txtUserRole.Text = permission_grant.RoleTextBox.Text AndAlso permission_grant.txtUserID.Text IsNot Nothing AndAlso permission_grant.txtUserPass.Text IsNot Nothing AndAlso permission_grant.txtUserRole.Text IsNot Nothing Then
                                                            index(i)
                                                            fll(i)
                                                            ld(i)
                                                            If i = 10 Then
                                                                nw(10, 0)
                                                            End If
                                                            status("Logged in as " & permission_grant.RoleTextBox.Text)
                                                            Form1.tmrBasic.Start()
                                                            Form1.MenuStrip1.Enabled = True
                                                        Else
                                                            status("Wrong login information! Please try again :-)")
                                                        End If
                                                        Return 0
                                                    End Function
        AddHandler permission_grant.btnCancel.Click, Function()
                                                         index(12)
                                                         fll(12)
                                                         ld(12)
                                                         Return 0
                                                     End Function
        AddHandler permission_grant.txtUserRole.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                             If e.KeyCode = Keys.Enter Then
                                                                 Try
                                                                     permission_grant.TblUserBindingSource.Filter = "userID =" & permission_grant.txtUserID.Text
                                                                 Catch ex As Exception

                                                                 End Try
                                                                 If permission_grant.txtUserID.Text = permission_grant.UserIDTextBox.Text AndAlso permission_grant.txtUserPass.Text = permission_grant.PasswordTextBox.Text AndAlso permission_grant.txtUserRole.Text = permission_grant.RoleTextBox.Text AndAlso permission_grant.txtUserID.Text IsNot Nothing AndAlso permission_grant.txtUserPass.Text IsNot Nothing AndAlso permission_grant.txtUserRole.Text IsNot Nothing Then
                                                                     index(i)
                                                                     fll(i)
                                                                     ld(i)
                                                                     If i = 10 Then
                                                                         nw(10, 0)
                                                                     End If
                                                                     status("Logged in as " & permission_grant.RoleTextBox.Text)
                                                                     Form1.tmrBasic.Start()
                                                                     Form1.MenuStrip1.Enabled = True
                                                                 Else
                                                                     status("Wrong login information! Please try again :-)")
                                                                 End If
                                                             End If
                                                         End Sub
        Form1.Select()
        permission_grant.txtUserID.Select()
        Return 0
    End Function
    Function delivery(sale_invoice As Integer, customer_id As Integer, vehicle_id As Integer)
        index(39)
        fll(39)
        ld(39)
        productdelivery.Panel2.Enabled = True
        productdelivery.TblDeliveryBindingSource.AddNew()

        productdelivery.SaleInvoiceTextBox.Text = sale_invoice
        productdelivery.CustomerNameTextBox.Text = customer_id
        productdelivery.VehicleIDTextBox.Text = vehicle_id
        productdelivery.TblCustomersBindingSource.Filter = "customerID =" & customer_id
        productdelivery.CustomerNameTextBox.Text = productdelivery.CustomerNameTextBox1.Text
        productdelivery.ShippingAddressTextBox.Text = productdelivery.ShippingAddressTextBox1.Text
        productdelivery.ContactNumberTextBox.Text = productdelivery.ContactNumberTextBox1.Text
        productdelivery.TblVehicleBindingSource.Filter = "vehicleID =" & vehicle_id
        productdelivery.DriverNameTextBox.Text = productdelivery.DriverNameTextBox1.Text
        Return 0
    End Function
    Function dockyard(frm As Form, port As Form)
        frm.TopLevel = False
        frm.Show()
        port.Controls.Add(frm)
        frm.Location = New Point(0, 0)
        frm.Size = New Size(0, 0)
        MsgBox(frm.Size)
    End Function

    'Function fun_pay_due(binding_one As BindingSource, binding_two As BindingSource, index_one As Integer, index_two As Integer, id As Integer, due_amount As TextBox, due_amount1 As TextBox, column_1 As String, column_2 As String, paid_1 As TextBox, paid_2 As TextBox)
    '    Dim pay_page As New pay_due
    '    pay_page.ShowDialog()
    '    num(pay_page.pay_text)
    '    pay_page.pay_text.Clear()
    '    Dim old_due As Double = Double.Parse(due_amount.Text)
    '    Dim old_paid As Double = Double.Parse(paid_1.Text)
    '    Dim t As New Timer
    '    t.Start()
    '    AddHandler t.Tick, Function()
    '                           If pay_page.chkbank.Checked = True Then
    '                               pay_page.txtaccountNumber.Enabled = True
    '                           Else
    '                               pay_page.txtaccountNumber.Enabled = False
    '                               pay_page.txtaccountNumber.Clear()
    '                           End If
    '                           Return 0
    '                       End Function
    '    AddHandler pay_page.pay_text.TextChanged, Function()
    '                                                  If Double.Parse(pay_page.pay_text.Text) > Double.Parse(due_amount.Text) Then
    '                                                      pay_page.pay_text.Text = due_amount.Text
    '                                                  ElseIf Double.Parse(pay_page.pay_text.Text) < 0 Then
    '                                                      pay_page.pay_text.Text = 0
    '                                                  End If
    '                                                  Return 0
    '                                              End Function
    '    AddHandler pay_page.pay_button.Click, Function()
    '                                              If index_one = 51 Then
    '                                                  If pay_page.chkbank.Checked = True Then
    '                                                      pay_page.TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & pay_page.txtaccountNumber.Text & "%'"
    '                                                      If pay_page.txtaccountNumber.Text = pay_page.AccountNumberTextBox.Text Then
    '                                                          pay_page.TblTransactionBindingSource.AddNew()
    '                                                          pay_page.AmountTextBox.Text = pay_page.pay_text.Text
    '                                                          pay_page.TransactionTypeTextBox.Text = "Deposit"
    '                                                          pay_page.AccNoTextBox.Text = pay_page.txtaccountNumber.Text
    '                                                          pay_page.DateTextBox.Text = Today
    '                                                          pay_page.PersonOrsourceTextBox.Text = customeraccount.CustomerNameTextBox.Text
    '                                                          pay_page.NoteTextBox.Text = "Due paid from customer"
    '                                                          pay_page.OpeningBalanceTextBox.Text = Double.Parse(pay_page.OpeningBalanceTextBox.Text) + Double.Parse(pay_page.pay_text.Text)
    '                                                          due_amount.Text = Double.Parse(due_amount.Text) - Double.Parse(pay_page.pay_text.Text)
    '                                                          due_amount1.Text = due_amount.Text
    '                                                          'update
    '                                                          pay_page.Validate()
    '                                                          pay_page.TblBankAccountsBindingSource.EndEdit()
    '                                                          pay_page.TblTransactionBindingSource.EndEdit()
    '                                                          pay_page.TableAdapterManager.UpdateAll(pay_page.DataSet)
    '                                                      End If

    '                                                  ElseIf pay_page.chkbank.Checked = False Then
    '                                                      due_amount.Text = Double.Parse(due_amount.Text) - Double.Parse(pay_page.pay_text.Text)
    '                                                      due_amount1.Text = due_amount.Text
    '                                                      paid_1.Text = Double.Parse(paid_1.Text) + Double.Parse(pay_page.pay_text.Text)
    '                                                      paid_2.Text = paid_1.Text


    '                                                  End If
    '                                              ElseIf index_one = 47 Then

    '                                              End If
    '                                              Return 0
    '                                          End Function


    '    Return 0
    'End Function

    Function due_pay(i As Integer, j As Integer)
        Try
            Dim page As New pay_due
            page.Show()
            num(page.pay_text)
            page.pay_text.Select()
            auto(page.txtaccountNumber, page.DataSet.tblBankAccounts, "accountNumber")
            slt(page.pay_text, page.txtaccountNumber)
            If j = 0 Then
                page.lbltitle.Text = "বাকি আদায়"
                page.pay_button.Text = "আদায়"
                page.chkbank.Text = "ব্যাংকের মাধ্যমে আদায়"
            ElseIf j = 1 Then
                page.lbltitle.Text = "দায় পরিশোধ"
                page.pay_button.Text = "পরিশোধ"
                page.chkbank.Text = "ব্যাংকের মাধ্যমে পরিশোধ"
            End If

            AddHandler page.pay_button.Click, Function()
                                                  If i = 0 Then

                                                      If customeraccount.TblCusomterAccountsDataGridView.Rows(customeraccount.TblCusomterAccountsBindingSource.Position).Cells(2).Value.ToString.Length > 0 Then
                                                          Try
                                                              customeraccount.TblInvoiceBindingSource.Filter = "invoiceNo =" & customeraccount.SaleInvoiceTextBox.Text
                                                              customeraccount.TblVehicleAccountsBindingSource.Filter = "saleInvoice =" & customeraccount.SaleInvoiceTextBox.Text
                                                          Catch ex As Exception

                                                          End Try
                                                          'value detection started for sale invoices
                                                          If customeraccount.PadiTextBox.Text = Nothing Then
                                                              customeraccount.PadiTextBox.Text = 0
                                                          End If
                                                          If customeraccount.BankamountTextBox.Text = Nothing Then
                                                              customeraccount.BankamountTextBox.Text = 0
                                                          End If
                                                          If customeraccount.PaidTextBox.Text = Nothing Then
                                                              customeraccount.PaidTextBox.Text = 0
                                                          End If
                                                          'value detection ended
                                                          If page.pay_text.Text = Nothing Then
                                                              MsgBox("Please enter a value!")
                                                          Else
                                                              'paid by bank -invoice related
                                                              If page.chkbank.Checked = True Then
                                                                  'calculation
                                                                  customeraccount.BankamountTextBox.Text = Double.Parse(customeraccount.BankamountTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                                  customeraccount.PaidTextBox.Text = Double.Parse(customeraccount.PaidTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                                  customeraccount.PaidTextBox1.Text = customeraccount.PaidTextBox.Text
                                                                  customeraccount.DueTextBox.Text = Double.Parse(customeraccount.DueTextBox.Text) - Double.Parse(page.pay_text.Text)
                                                                  customeraccount.DueTextBox1.Text = customeraccount.DueTextBox.Text
                                                                  customeraccount.DueTextBox2.Text = customeraccount.DueTextBox.Text
                                                                  '''''
                                                                  'income
                                                                  customeraccount.TblIncomeBindingSource.AddNew()
                                                                  customeraccount.IncomeCategoryTextBox.Text = "Customer payment"
                                                                  customeraccount.IncomeSubcategoryTextBox.Text = "Customer payment"
                                                                  customeraccount.AmountTextBox1.Text = 0
                                                                  customeraccount.DateTextBox1.Text = Today
                                                                  customeraccount.AccNoTextBox1.Text = page.txtaccountNumber.Text
                                                                  customeraccount.BankamountTextBox2.Text = page.pay_text.Text
                                                                  customeraccount.AmountTextBox1.Text = 0
                                                                  customeraccount.PaymentmethodComboBox1.Text = "Bank"
                                                                  customeraccount.Payment_remarkTextBox.Text = "Paid by bank."
                                                                  customeraccount.IncomeNoteTextBox.Text = "Due paid from " & customeraccount.CustomerNameTextBox.Text & " || ID: " & customeraccount.CustomerIDTextBox.Text
                                                                  '''''''
                                                                  'bank transaction
                                                                  page.TblTransactionBindingSource.AddNew()
                                                                  page.TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & page.txtaccountNumber.Text & "%'"
                                                                  page.TransactionTypeTextBox.Text = "Deposit"
                                                                  page.AccNoTextBox.Text = page.txtaccountNumber.Text
                                                                  page.DateTextBox.Text = Today
                                                                  page.PersonOrsourceTextBox.Text = customeraccount.CustomerNameTextBox.Text
                                                                  page.NoteTextBox.Text = "Due payment received from " & customeraccount.CustomerNameTextBox.Text
                                                                  page.AmountTextBox.Text = page.pay_text.Text
                                                                  page.OpeningBalanceTextBox.Text = Double.Parse(page.OpeningBalanceTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                                  ''''''''
                                                                  customeraccount.Validate()
                                                                  page.Validate()
                                                                  customeraccount.TblInvoiceBindingSource.EndEdit()
                                                                  customeraccount.TblVehicleAccountsBindingSource.EndEdit()
                                                                  customeraccount.TblCusomterAccountsBindingSource.EndEdit()
                                                                  customeraccount.TblIncomeBindingSource.EndEdit()
                                                                  page.TblBankAccountsBindingSource.EndEdit()
                                                                  page.TblTransactionBindingSource.EndEdit()
                                                                  customeraccount.TableAdapterManager.UpdateAll(customeraccount.DataSet)
                                                                  page.TableAdapterManager.UpdateAll(page.DataSet)
                                                              ElseIf page.chkbank.Checked = False Then
                                                                  'paid by cash -invoice related
                                                                  customeraccount.PadiTextBox.Text = Double.Parse(customeraccount.PadiTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                                  customeraccount.PaidTextBox.Text = Double.Parse(customeraccount.PaidTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                                  customeraccount.PaidTextBox1.Text = customeraccount.PaidTextBox.Text
                                                                  customeraccount.DueTextBox.Text = Double.Parse(customeraccount.DueTextBox.Text) - Double.Parse(page.pay_text.Text)
                                                                  customeraccount.DueTextBox1.Text = customeraccount.DueTextBox.Text
                                                                  customeraccount.DueTextBox2.Text = customeraccount.DueTextBox.Text
                                                                  '''''
                                                                  'income
                                                                  customeraccount.TblIncomeBindingSource.AddNew()
                                                                  customeraccount.IncomeCategoryTextBox.Text = "Customer payment"
                                                                  customeraccount.IncomeSubcategoryTextBox.Text = "Customer payment"
                                                                  customeraccount.DateTextBox1.Text = Today
                                                                  customeraccount.AccNoTextBox1.Text = page.txtaccountNumber.Text
                                                                  customeraccount.AmountTextBox1.Text = page.pay_text.Text
                                                                  customeraccount.BankamountTextBox2.Text = 0
                                                                  customeraccount.PaymentmethodComboBox1.Text = "Cash"
                                                                  customeraccount.Payment_remarkTextBox.Text = "Paid by cash."
                                                                  customeraccount.IncomeNoteTextBox.Text = "Due paid from " & customeraccount.CustomerNameTextBox.Text & " || ID: " & customeraccount.CustomerIDTextBox.Text
                                                                  '''''''
                                                                  customeraccount.Validate()
                                                                  customeraccount.TblInvoiceBindingSource.EndEdit()
                                                                  customeraccount.TblVehicleAccountsBindingSource.EndEdit()
                                                                  customeraccount.TblCusomterAccountsBindingSource.EndEdit()
                                                                  customeraccount.TblIncomeBindingSource.EndEdit()
                                                                  customeraccount.TableAdapterManager.UpdateAll(customeraccount.DataSet)
                                                              End If

                                                          End If

                                                      Else
                                                          'blank account
                                                          'paid by bank -blank account
                                                          If page.chkbank.Checked = True Then
                                                              'calculation
                                                              customeraccount.PaidTextBox.Text = Double.Parse(customeraccount.PaidTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                              customeraccount.DueTextBox.Text = Double.Parse(customeraccount.DueTextBox.Text) - Double.Parse(page.pay_text.Text)
                                                              '''''
                                                              'income
                                                              customeraccount.TblIncomeBindingSource.AddNew()
                                                              customeraccount.IncomeCategoryTextBox.Text = "Customer payment"
                                                              customeraccount.IncomeSubcategoryTextBox.Text = "Customer payment"
                                                              customeraccount.AmountTextBox1.Text = 0
                                                              customeraccount.DateTextBox1.Text = Today
                                                              customeraccount.AccNoTextBox1.Text = page.txtaccountNumber.Text
                                                              customeraccount.AmountTextBox1.Text = 0
                                                              customeraccount.BankamountTextBox2.Text = page.pay_text.Text
                                                              customeraccount.PaymentmethodComboBox1.Text = "Bank"
                                                              customeraccount.Payment_remarkTextBox.Text = "Paid by bank."
                                                              customeraccount.IncomeNoteTextBox.Text = "Due paid from " & customeraccount.CustomerNameTextBox.Text & " || ID: " & customeraccount.CustomerIDTextBox.Text
                                                              '''''''
                                                              'bank transaction
                                                              page.TblTransactionBindingSource.AddNew()
                                                              page.TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & page.txtaccountNumber.Text & "%'"
                                                              page.TransactionTypeTextBox.Text = "Deposit"
                                                              page.AccNoTextBox.Text = page.txtaccountNumber.Text
                                                              page.DateTextBox.Text = Today
                                                              page.AmountTextBox.Text = page.pay_text.Text
                                                              page.PersonOrsourceTextBox.Text = customeraccount.CustomerNameTextBox.Text
                                                              page.NoteTextBox.Text = "Due payment received from " & customeraccount.CustomerNameTextBox.Text
                                                              page.OpeningBalanceTextBox.Text = Double.Parse(page.OpeningBalanceTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                              ''''''''
                                                              customeraccount.Validate()
                                                              page.Validate()
                                                              customeraccount.TblInvoiceBindingSource.EndEdit()
                                                              customeraccount.TblVehicleAccountsBindingSource.EndEdit()
                                                              customeraccount.TblCusomterAccountsBindingSource.EndEdit()
                                                              customeraccount.TblIncomeBindingSource.EndEdit()
                                                              page.TblBankAccountsBindingSource.EndEdit()
                                                              page.TblTransactionBindingSource.EndEdit()
                                                              customeraccount.TableAdapterManager.UpdateAll(customeraccount.DataSet)
                                                              page.TableAdapterManager.UpdateAll(page.DataSet)
                                                          ElseIf page.chkbank.Checked = False Then
                                                              'paid by cash -blank account
                                                              'calculation
                                                              customeraccount.PaidTextBox.Text = Double.Parse(customeraccount.PaidTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                              customeraccount.DueTextBox.Text = Double.Parse(customeraccount.DueTextBox.Text) - Double.Parse(page.pay_text.Text)
                                                              '''''
                                                              'income
                                                              customeraccount.TblIncomeBindingSource.AddNew()
                                                              customeraccount.IncomeCategoryTextBox.Text = "Customer payment"
                                                              customeraccount.IncomeSubcategoryTextBox.Text = "Customer payment"
                                                              customeraccount.AmountTextBox1.Text = 0
                                                              customeraccount.DateTextBox1.Text = Today
                                                              customeraccount.AccNoTextBox1.Text = page.txtaccountNumber.Text
                                                              customeraccount.AmountTextBox1.Text = page.pay_text.Text
                                                              customeraccount.BankamountTextBox2.Text = 0
                                                              customeraccount.PaymentmethodComboBox1.Text = "Cash"
                                                              customeraccount.Payment_remarkTextBox.Text = "Paid by cash."
                                                              customeraccount.IncomeNoteTextBox.Text = "Due paid from " & customeraccount.CustomerNameTextBox.Text & " || ID: " & customeraccount.CustomerIDTextBox.Text
                                                              '''''''
                                                              customeraccount.Validate()
                                                              customeraccount.TblInvoiceBindingSource.EndEdit()
                                                              customeraccount.TblVehicleAccountsBindingSource.EndEdit()
                                                              customeraccount.TblCusomterAccountsBindingSource.EndEdit()
                                                              customeraccount.TblIncomeBindingSource.EndEdit()
                                                              customeraccount.TableAdapterManager.UpdateAll(customeraccount.DataSet)
                                                          End If
                                                      End If
                                                      page.Close()
                                                  ElseIf i = 1 Then
                                                      Try
                                                          supplieraccount.TblPurchaseInvoiceBindingSource.Filter = "invoiceNo =" & supplieraccount.PurchaseInvoiceTextBox.Text
                                                      Catch ex As Exception

                                                      End Try
                                                      'value checking
                                                      If supplieraccount.PaidTextBox.Text = Nothing Then
                                                          supplieraccount.PaidTextBox.Text = 0
                                                      End If
                                                      If supplieraccount.PaidTextBox1.Text = Nothing Then
                                                          supplieraccount.PaidTextBox1.Text = 0
                                                      End If
                                                      'main
                                                      If supplieraccount.TblSupplierAccountsBindingSource.Count > 0 Then
                                                          If page.pay_text.Text = Nothing Then
                                                              MsgBox("Please enter a value!")
                                                          Else
                                                              'paid by bank -invoice related
                                                              If page.chkbank.Checked = True Then
                                                                  'calculation
                                                                  supplieraccount.BankamountTextBox.Text = Double.Parse(supplieraccount.BankamountTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                                  'supplieraccount.PaidTextBox.Text = supplieraccount.PaidTextBox1.Text
                                                                  supplieraccount.DueTextBox1.Text = Double.Parse(supplieraccount.DueTextBox1.Text) - Double.Parse(page.pay_text.Text)
                                                                  supplieraccount.DueTextBox.Text = supplieraccount.DueTextBox1.Text
                                                                  supplieraccount.PaidTextBox1.Text = Double.Parse(supplieraccount.PaidTextBox1.Text) + Double.Parse(page.pay_text.Text)
                                                                  '''''''''
                                                                  'expense
                                                                  supplieraccount.TblExpensesBindingSource.AddNew()
                                                                  supplieraccount.ExpenseCategoryTextBox.Text = "Company payment"
                                                                  supplieraccount.ExpenseSubCategoryTextBox.Text = "Company payment"
                                                                  supplieraccount.ExpenseNoteTextBox.Text = "Due paid for " & supplieraccount.SupplierNameTextBox.Text & " || Invoice NO: " & supplieraccount.PurchaseInvoiceTextBox.Text
                                                                  supplieraccount.DateTextBox.Text = Today
                                                                  supplieraccount.AmountTextBox.Text = 0
                                                                  supplieraccount.BankamountTextBox1.Text = page.pay_text.Text
                                                                  supplieraccount.AccNoTextBox.Text = page.txtaccountNumber.Text
                                                                  supplieraccount.PaymentMethodComboBox.Text = "Bank"
                                                                  supplieraccount.Payment_remarkTextBox.Text = "Paid by bank"
                                                                  'supplieraccount.ExpenseNoteTextBox.Text = "Due paid for " + supplieraccount.SupplierNameTextBox.Text + " || ID: " + supplieraccount.supplierIDtextbox.text
                                                                  'bank transaction
                                                                  page.TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & page.txtaccountNumber.Text & "%'"
                                                                  page.TblTransactionBindingSource.AddNew()
                                                                  page.TransactionTypeTextBox.Text = "Withdraw"
                                                                  page.AccNoTextBox.Text = page.txtaccountNumber.Text
                                                                  page.DateTextBox.Text = Today
                                                                  page.AmountTextBox.Text = page.pay_text.Text
                                                                  page.PersonOrsourceTextBox.Text = supplieraccount.SupplierNameTextBox.Text
                                                                  page.NoteTextBox.Text = "Due  paid for " & customeraccount.CustomerNameTextBox.Text
                                                                  page.OpeningBalanceTextBox.Text = Double.Parse(page.OpeningBalanceTextBox.Text) - Double.Parse(page.pay_text.Text)
                                                                  '''''''''''''''
                                                                  'update
                                                                  supplieraccount.Validate()
                                                                  page.Validate()
                                                                  supplieraccount.TblExpensesBindingSource.EndEdit()
                                                                  supplieraccount.TblPurchaseInvoiceBindingSource.EndEdit()
                                                                  supplieraccount.TblSupplierAccountsBindingSource.EndEdit()
                                                                  page.TblBankAccountsBindingSource.EndEdit()
                                                                  page.TblTransactionBindingSource.EndEdit()
                                                                  supplieraccount.TableAdapterManager.UpdateAll(supplieraccount.DataSet)
                                                                  page.TableAdapterManager.UpdateAll(page.DataSet)
                                                              ElseIf page.chkbank.Checked = False Then
                                                                  'paid by cash -invoice related
                                                                  'calculation
                                                                  supplieraccount.PaidTextBox1.Text = Double.Parse(supplieraccount.PaidTextBox1.Text) + Double.Parse(page.pay_text.Text)
                                                                  supplieraccount.PaidTextBox.Text = Double.Parse(supplieraccount.PaidTextBox.Text) + Double.Parse(page.pay_text.Text)
                                                                  supplieraccount.DueTextBox1.Text = Double.Parse(supplieraccount.DueTextBox1.Text) - Double.Parse(page.pay_text.Text)
                                                                  supplieraccount.DueTextBox.Text = supplieraccount.DueTextBox1.Text
                                                                  ''''''''''''''
                                                                  'expense
                                                                  supplieraccount.TblExpensesBindingSource.AddNew()
                                                                  supplieraccount.ExpenseCategoryTextBox.Text = "Company payment"
                                                                  supplieraccount.ExpenseSubCategoryTextBox.Text = "Company payment"
                                                                  supplieraccount.ExpenseNoteTextBox.Text = "Due paid for " & supplieraccount.SupplierNameTextBox.Text & " || Invoice NO: " & supplieraccount.PurchaseInvoiceTextBox.Text
                                                                  supplieraccount.DateTextBox.Text = Today
                                                                  supplieraccount.AmountTextBox.Text = page.pay_text.Text
                                                                  supplieraccount.BankamountTextBox1.Text = 0
                                                                  supplieraccount.PaymentMethodComboBox.Text = "Cash"
                                                                  supplieraccount.Payment_remarkTextBox.Text = "Paid by cash"
                                                                  '''''''''''''
                                                                  'update
                                                                  supplieraccount.Validate()
                                                                  supplieraccount.TblExpensesBindingSource.EndEdit()
                                                                  supplieraccount.TblPurchaseInvoiceBindingSource.EndEdit()
                                                                  supplieraccount.TblSupplierAccountsBindingSource.EndEdit()
                                                                  supplieraccount.TableAdapterManager.UpdateAll(supplieraccount.DataSet)

                                                              End If
                                                              page.Close()
                                                          End If
                                                      Else
                                                          'blank account
                                                          'paid by bank -blank account
                                                          If page.chkbank.Checked = True Then
                                                              'calculation
                                                              supplieraccount.PaidTextBox1.Text = Double.Parse(supplieraccount.PaidTextBox1.Text) + Double.Parse(page.pay_text.Text)
                                                              supplieraccount.DueTextBox1.Text = Double.Parse(supplieraccount.DueTextBox1.Text) - Double.Parse(page.pay_text.Text)
                                                              '''''''''
                                                              'expense
                                                              supplieraccount.TblExpensesBindingSource.AddNew()
                                                              supplieraccount.ExpenseCategoryTextBox.Text = "Company payment"
                                                              supplieraccount.ExpenseSubCategoryTextBox.Text = "Company payment"
                                                              supplieraccount.ExpenseNoteTextBox.Text = "Due paid for " & supplieraccount.SupplierNameTextBox.Text & " || Invoice NO: " & supplieraccount.PurchaseInvoiceTextBox.Text
                                                              supplieraccount.DateTextBox.Text = Today
                                                              supplieraccount.AmountTextBox.Text = 0
                                                              supplieraccount.BankamountTextBox1.Text = page.pay_text.Text
                                                              supplieraccount.AccNoTextBox.Text = page.txtaccountNumber.Text
                                                              supplieraccount.PaymentMethodComboBox.Text = "Bank"
                                                              supplieraccount.Payment_remarkTextBox.Text = "Paid by bank"
                                                              'bank transaction
                                                              page.TblBankAccountsBindingSource.Filter = "accountNumber LIKE '%" & page.txtaccountNumber.Text & "%'"
                                                              page.TblTransactionBindingSource.AddNew()
                                                              page.TransactionTypeTextBox.Text = "Withdraw"
                                                              page.AccNoTextBox.Text = page.txtaccountNumber.Text
                                                              page.DateTextBox.Text = Today
                                                              page.AmountTextBox.Text = page.pay_text.Text
                                                              page.PersonOrsourceTextBox.Text = supplieraccount.SupplierNameTextBox.Text
                                                              page.NoteTextBox.Text = "Due  paid for " & customeraccount.CustomerNameTextBox.Text
                                                              page.OpeningBalanceTextBox.Text = Double.Parse(page.OpeningBalanceTextBox.Text) - Double.Parse(page.pay_text.Text)
                                                              '''''''''''''''
                                                              'update
                                                              supplieraccount.Validate()
                                                              page.Validate()
                                                              supplieraccount.TblExpensesBindingSource.EndEdit()
                                                              supplieraccount.TblSupplierAccountsBindingSource.EndEdit()
                                                              page.TblBankAccountsBindingSource.EndEdit()
                                                              page.TblTransactionBindingSource.EndEdit()
                                                              supplieraccount.TableAdapterManager.UpdateAll(supplieraccount.DataSet)
                                                              page.TableAdapterManager.UpdateAll(page.DataSet)

                                                              'paid by cash -blank account
                                                          ElseIf page.chkbank.Checked = False Then
                                                              'calculation
                                                              supplieraccount.PaidTextBox1.Text = Double.Parse(supplieraccount.PaidTextBox1.Text) + Double.Parse(page.pay_text.Text)
                                                              supplieraccount.DueTextBox1.Text = Double.Parse(supplieraccount.DueTextBox1.Text) - Double.Parse(page.pay_text.Text)
                                                              ''''''''''''''''''''
                                                              'expense
                                                              supplieraccount.TblExpensesBindingSource.AddNew()
                                                              supplieraccount.ExpenseCategoryTextBox.Text = "Company payment"
                                                              supplieraccount.ExpenseSubCategoryTextBox.Text = "Company payment"
                                                              supplieraccount.ExpenseNoteTextBox.Text = "Due paid for " & supplieraccount.SupplierNameTextBox.Text & " || Invoice NO: " & supplieraccount.PurchaseInvoiceTextBox.Text
                                                              supplieraccount.DateTextBox.Text = Today
                                                              supplieraccount.AmountTextBox.Text = page.pay_text.Text
                                                              supplieraccount.BankamountTextBox1.Text = 0
                                                              supplieraccount.PaymentMethodComboBox.Text = "Cash"
                                                              supplieraccount.Payment_remarkTextBox.Text = "Paid by cash"
                                                              ''''''''''''''''''''
                                                              'update
                                                              supplieraccount.Validate()
                                                              supplieraccount.TblExpensesBindingSource.EndEdit()
                                                              supplieraccount.TblSupplierAccountsBindingSource.EndEdit()
                                                              supplieraccount.TableAdapterManager.UpdateAll(supplieraccount.DataSet)
                                                              ''''''''''''''''''''
                                                          End If
                                                          page.Close()
                                                      End If
                                                  End If
                                                  Return 0
                                              End Function
            AddHandler page.pay_text.TextChanged, Function()
                                                      If i = 0 Then
                                                          If Double.Parse(page.pay_text.Text) > Double.Parse(customeraccount.DueTextBox.Text) Then
                                                              page.pay_text.Text = customeraccount.DueTextBox.Text
                                                          End If
                                                      ElseIf i = 1 Then
                                                          If Double.Parse(page.pay_text.Text) > Double.Parse(supplieraccount.DueTextBox1.Text) Then
                                                              page.pay_text.Text = supplieraccount.DueTextBox1.Text
                                                          End If
                                                      End If
                                                      Return 0
                                                  End Function
            Dim t As New Timer
            t.Start()
            AddHandler t.Tick, Function()
                                   If page.chkbank.Checked = True Then
                                       page.txtaccountNumber.Enabled = True
                                   Else
                                       page.txtaccountNumber.Enabled = False
                                   End If
                                   Return 0
                               End Function
        Catch ex As Exception

        End Try


        Return 0
    End Function
    Function hidden_index(frm As Form, abcd As Integer)


        Dim hg As Integer = frm.Height
        Dim wd As Integer = frm.Width
        frm.Size = New Size(0, 0)
        frm.TopLevel = False
        frm.Show()
        fll(abcd)
        ld(abcd)
        frm.Size = New Size(1000, 650)

        Return 0
    End Function
    Function lod()
        Try
            hidden_index(duereport, 13)
        Catch ex As Exception

        End Try

        Try
            hidden_index(employeeattendence, 15)
        Catch ex As Exception

        End Try

        Try
            hidden_index(attendencereport, 8)
        Catch ex As Exception

        End Try

        Try
            hidden_index(expensereport, 17)
        Catch ex As Exception

        End Try

        Try
            hidden_index(profitcalculator, 41)
        Catch ex As Exception

        End Try

        Try
            hidden_index(salesreport, 46)
        Catch ex As Exception

        End Try

        Try
            hidden_index(transactionreport, 52)
        Catch ex As Exception

        End Try

        Try
            hidden_index(purchasereport, 42)
        Catch ex As Exception

        End Try

        Try
            hidden_index(cashreport, 69)
        Catch ex As Exception

        End Try

        Return 0
    End Function
    Function how_much(dt As DataGridView, i As Integer, j As Integer, code As Integer)
        Dim result As Integer = 0
        For a As Integer = 1 To dt.Rows.Count
            If dt.Rows.Count = 0 Then
                result = 0
            Else
                If dt.Rows(a).Cells(i).Value = code Then
                    result += Integer.Parse(dt.Rows(a).Cells(j).Value())
                Else
                    result += 0
                End If
            End If
            a += 1
        Next
        Return result
    End Function
    Function clear_unneccessery_data(d As BindingSource, dt As DataGridView, i As Integer)

        'For a As Integer = 0 To d.Count  - 1
        '    If dt.Rows(a).Cells(i).Value.ToString = Nothing Then
        '        d.RemoveAt(a)
        '        a = 0
        '    End If
        'Next


        d.MoveFirst()
            While 1 = 1
                If dt.Rows(d.Position).Cells(i).Value.ToString() = Nothing Then
                    d.RemoveCurrent()
                    d.MoveFirst()
                ElseIf d.Position = d.Count - 1 Then
                    Exit While
                Else
                    d.MoveNext()
                End If

            End While




            Return 0
    End Function
    Function clear_unneccesery(d As BindingSource)

        Return 0
    End Function
    Function delete_invoice()
        fll(28)
        fll(51)
        fll(64)
        fll(70)
        fll(72)
        fll(29)
        'stock back
        managesale.TblProductsBindingSource.RemoveFilter()
        For a As Integer = 0 To managesale.TblSalesBindingSource.Count - 1
            managesale.TblProductsBindingSource.Filter = "productCode =" & managesale.TblSalesDataGridView.Rows(a).Cells(8).Value.ToString
            managesale.TblProductsDataGridView.Rows(0).Cells(0).Value() = Integer.Parse(managesale.TblProductsDataGridView.Rows(0).Cells(0).Value()) + Integer.Parse(managesale.TblSalesDataGridView.Rows(a).Cells(2).Value().ToString())
            managesale.Validate()
            managesale.TblProductsBindingSource.EndEdit()
            managesale.TableAdapterManager.UpdateAll(managesale.DataSet)
        Next
        '''''''''''''''
        Try
            If managesale.TblSalesBindingSource.Count > 0 Then
                While managesale.TblSalesBindingSource.Count <> 0
                    managesale.TblSalesBindingSource.RemoveCurrent()
                End While
            End If
        Catch ex As Exception

        End Try
        Dim current_invoice As Integer = managesale.TblInvoiceDataGridView.Rows(managesale.TblInvoiceBindingSource.Position).Cells(0).Value()
        Dim current_date As String = managesale.TblInvoiceDataGridView.Rows(managesale.TblInvoiceBindingSource.Position).Cells(10).Value()
        'customer account
        customeraccount.TblCusomterAccountsBindingSource.Filter = "saleInvoice =" & current_invoice
        While customeraccount.TblCusomterAccountsBindingSource.Count <> 0
            customeraccount.TblCusomterAccountsBindingSource.RemoveCurrent()
        End While

        customeraccount.Validate()
        customeraccount.TblCusomterAccountsBindingSource.EndEdit()
        customeraccount.TableAdapterManager.UpdateAll(customeraccount.DataSet)
        ''''''''''''''
        'income
        manageincome.TblIncomeBindingSource.Filter = "invoice_no =" & current_invoice
        While manageincome.TblIncomeBindingSource.Count <> 0
            manageincome.TblIncomeBindingSource.RemoveCurrent()
        End While

        manageincome.Validate()
        manageincome.TblIncomeBindingSource.EndEdit()
        manageincome.TableAdapterManager.UpdateAll(manageincome.DataSet)
        '''''''''''''''
        'vehicle accounts
        vehicleaccounts.TblVehicleAccountsBindingSource.Filter = "saleInvoice =" & current_invoice
        While vehicleaccounts.TblVehicleAccountsBindingSource.Count <> 0
            vehicleaccounts.TblVehicleAccountsBindingSource.RemoveCurrent()
        End While

        vehicleaccounts.Validate()
        vehicleaccounts.TblVehicleAccountsBindingSource.EndEdit()
        vehicleaccounts.TableAdapterManager.UpdateAll(vehicleaccounts.DataSet)
        '''''''''''''''''''
        'commission
        sell_on_commisssion.TblsellcommissionBindingSource.Filter = "invoice_no =" & current_invoice
        While sell_on_commisssion.TblsellcommissionBindingSource.Count <> 0
            sell_on_commisssion.TblsellcommissionBindingSource.RemoveCurrent()
        End While

        sell_on_commisssion.Validate()
        sell_on_commisssion.TblsellcommissionBindingSource.EndEdit()
        sell_on_commisssion.TableAdapterManager.UpdateAll(sell_on_commisssion.DataSet)
        ''''''''''''''''
        'discount
        discounts.TbldiscountBindingSource.Filter = "invoice_no =" & current_invoice
        While discounts.TbldiscountBindingSource.Count <> 0
            discounts.TbldiscountBindingSource.RemoveCurrent()
        End While

        discounts.Validate()
        discounts.TbldiscountBindingSource.EndEdit()
        discounts.TableAdapterManager.UpdateAll(discounts.DataSet)
        ''''''''''''''''
        managesale.TblInvoiceBindingSource.RemoveCurrent()
        up(21, 0)
        up(21, 1)
        Return 0
    End Function
    Function products_value()
        Try
            Dim current_value As Double = 0
            Dim current_market_value As Double = 0
            Dim profit_can_earn As Double = 0

            For a As Integer = 0 To manageproduct.TblProductsBindingSource.Count - 1
                current_value += Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(4).Value().ToString) * Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(6).Value().ToString())
                current_market_value += Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(4).Value().ToString) * Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(5).Value().ToString())
            Next
            profit_can_earn = current_market_value - current_value

            manageproduct.tool.Items(4).Text = "মজুত পণ্যের মূল্যঃ " & current_value
            manageproduct.tool.Items(2).Text = "মজুত পণ্যের বাজার মূল্যঃ " & current_market_value
            manageproduct.tool.Items(0).Text = "সম্ভাব্য লভ্যাংশঃ " & profit_can_earn
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Function print_product_statement()

        'page calling 
        Dim page As New stock_statement
        page.Show()
        page.TopLevel = False
        page.Dock = DockStyle.Fill
        Form1.pnlMain.Controls.Clear()
        Form1.pnlMain.Controls.Add(page)
        manageproduct.TopLevel = False
        page.docking_panel.Controls.Add(manageproduct)
        manageproduct.Show()
        page.CompanyLogoPictureBox.Image = Form1.CompanyLogoPictureBox.Image
        page.lbl_shop_name.Text = Form1.Label1.Text & ", " & Form1.CompanyAddressTextBox.Text & ", " & Form1.CompanyPhoneNumberTextBox.Text
        page.lbl_date.Text = Today.Date
        ''''''''''''''''''
        Dim current_value As Double = 0
        Dim current_market_value As Double = 0
        Dim profit_can_earn As Double = 0

        For a As Integer = 0 To manageproduct.TblProductsBindingSource.Count - 1
            current_value += Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(4).Value().ToString) * Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(6).Value().ToString())
            current_market_value += Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(4).Value().ToString) * Double.Parse(manageproduct.TblProductsDataGridView.Rows(a).Cells(5).Value().ToString())
        Next
        profit_can_earn = current_market_value - current_value
        page.lbl_products_value.Text = current_value & dashboard.CurrencyTextBox.Text
        page.lbl_products_maket_value.Text = current_market_value & dashboard.CurrencyTextBox.Text
        page.lbl_profitcanearn.Text = profit_can_earn & dashboard.CurrencyTextBox.Text

        'input started

        Dim i As Integer = 0
        If manageproduct.TblProductsBindingSource.Count <= 38 Then
            For a As Integer = i To manageproduct.TblProductsBindingSource.Count - 1
                page.dtg.Rows.Add(pdtgv(a, 1), pdtgv(a, 0), pdtgv(a, 3), pdtgv(a, 4))
                i = a
            Next
        End If
        If manageproduct.TblProductsBindingSource.Count > 38 Then
            '
            For a As Integer = 0 To 38
                page.dtg.Rows.Add(pdtgv(a, 1), pdtgv(a, 0), pdtgv(a, 3), pdtgv(a, 4))
                i = a
            Next
            '
            For a As Integer = 39 To manageproduct.TblProductsBindingSource.Count - 1
                page.dtg1.Rows.Add(pdtgv(a, 1), pdtgv(a, 0), pdtgv(a, 3), pdtgv(a, 4))
            Next
        End If


        Dim bitmp(2) As Bitmap
        'printing proccess started
        If page.dtg1.Rows.Count = 1 Then
            Dim p As New Panel
            p = page.Panel1
            Dim bp As Bitmap = New Bitmap(p.Width, p.Height)
            Dim gp As Graphics = Graphics.FromImage(bp)
            Dim rct As New Rectangle(0, 0, p.Width, p.Height)
            p.DrawToBitmap(bp, rct)
            bitmp(0) = bp
        ElseIf page.dtg1.Rows.Count > 1 Then
            '1
            Dim p As New Panel
            p = page.Panel1
            Dim bp As Bitmap = New Bitmap(p.Width, p.Height)
            Dim gp As Graphics = Graphics.FromImage(bp)
            Dim rct As New Rectangle(0, 0, p.Width, p.Height)
            p.DrawToBitmap(bp, rct)
            bitmp(0) = bp
            '2            
            p = page.Panel5
            Dim bp1 As Bitmap = New Bitmap(p.Width, p.Height)
            Dim gp1 As Graphics = Graphics.FromImage(bp1)
            Dim rct1 As New Rectangle(0, 0, p.Width, p.Height)
            p.DrawToBitmap(bp1, rct1)
            bitmp(1) = bp1

        End If
        '1
        Dim pd As New Printing.PrintDocument
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     ' bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                     ' e.Graphics.DrawImage(bitmp(0), New Rectangle(0, 0, bitmp(0).Width, bitmp(0).Height))
                                     e.Graphics.DrawImage(bitmp(1), New Rectangle(0, 0, bitmp(1).Width, bitmp(1).Height))
                                 End Sub
        '2
        Dim pd1 As New Printing.PrintDocument
        AddHandler pd1.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                      ' bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                      e.Graphics.DrawImage(bitmp(0), New Rectangle(0, 0, bitmp(0).Width, bitmp(0).Height))
                                      ' e.Graphics.DrawImage(bitmp(1), New Rectangle(0, 0, bitmp(1).Width, bitmp(1).Height))
                                  End Sub

        Try
            AddHandler page.btn_print.Click, Function()
                                                 pd.Print()
                                                 pd1.Print()
                                                 index(29)
                                                 fll(29)
                                                 ld(29)
                                                 Return 0
                                             End Function
            AddHandler page.btn_email.Click, Sub()
                                                 ' bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                                 'e.Graphics.DrawImage(bm, New Rectangle(0, 0, bm.Width, bm.Height))
                                                 send_email("মজুত পণ্যের বিবরণ - " & Date.Today, shop_info() &
                                                            vbNewLine & vbNewLine & "স্যার " & Form1.Owner_nameTextBox.Text &
                                                            "," & vbNewLine & "নিচে আপনার প্রতিষ্ঠানের " &
                                                            Today.TimeOfDay.ToString & " - " & Today.ToString & " তারিখের মজুত পণ্যের বিবরণ উল্লেখ করা হলো।" & software_info(), bitmp)
                                                 'index(29)
                                                 'fll(29)
                                                 'ld(29)
                                             End Sub
        Catch ex As Exception

        End Try



        Return Nothing
    End Function
    Function shop_info()
        Dim s As String = Form1.Label1.Text & vbNewLine & Form1.CompanyAddressTextBox.Text & ", " & Form1.CompanyPhoneNumberTextBox.Text
        Return s
    End Function
    Function software_info()
        Return vbNewLine & vbNewLine & "Powered by- " & vbNewLine & "Rafalo technologies ©  2019"
    End Function
    Function send_email(subj As String, body As String, atc() As Bitmap)
        Dim page As New email_sender
        page.subj = subj
        page.body = body
        page.bm = atc
        page.Show()

        For a As Integer = 0 To atc.Count - 1
            If IsNothing(atc(a)) Then
                Exit For
            End If
            Dim p As New PictureBox
            p.SizeMode = PictureBoxSizeMode.StretchImage
            p.Image = atc(a)
            p.Height = (page.atc_panel.Height / 2) - 1
            p.Width = p.Height
            page.atc_panel.Controls.Add(p)
        Next
        Return Nothing
    End Function


    Function pdtgv(i, j)
        Return manageproduct.TblProductsDataGridView.Rows(i).Cells(j).value.ToString()
    End Function
    Function pdtgv_1(i As Integer, j As Integer, dt As DataGridView)

        Try
                Return Double.Parse(dt.Rows(i).Cells(j).Value.ToString())
            Catch ex As Exception
            If j = 0 Or j = 1 Then
                Return 0
            Else
                Return dt.Rows(i).Cells(j).Value.ToString()
            End If
        End Try

    End Function
    Function damage_return()
        manageexpense.TblExpensesBindingSource.Filter = "damage_id =" & managedamage.TblDamageProductsDataGridView.Rows(managedamage.TblDamageProductsBindingSource.Position).Cells(9).Value().ToString()
        If manageexpense.TblExpensesBindingSource.Count > 0 Then
            manageexpense.TblExpensesBindingSource.RemoveCurrent()
        End If
        manageexpense.Validate()
        manageexpense.TblExpensesBindingSource.EndEdit()
        manageexpense.TableAdapterManager.UpdateAll(manageexpense.DataSet)
        Return 0
    End Function
    Function average_dis()
        newsale.TblSalesBindingSource.MoveLast()
        For a As Integer = 0 To newsale.TblSalesBindingSource.Count - 1
            newsale.chk_discount.Checked = False
            newsale.TblSalesDataGridView.Rows(newsale.TblSalesBindingSource.Position).Cells(3).Value = avg_dis.TextBox1.Text
            newsale.chk_discount.Checked = True

            'MsgBox(newsale.TblSalesDataGridView.Rows(newsale.TblSalesBindingSource.Position).Cells(0).Value)
            newsale.TblSalesBindingSource.MovePrevious()
        Next

        Return 0
    End Function
    Function id_maker(t As TextBox)
        Dim i As Integer = 4 - t.Text.Length
        Dim str As String = "1"
        For a As Integer = 0 To i
            str = str & "0"
        Next
        t.Text = str & t.Text
        Return 0
    End Function
    Function id_maker_label(t As Label)
        Dim i As Integer = 4 - t.Text.Length
        MsgBox(i)
        Dim str As String = "1"
        For a As Integer = 0 To i
            str = str & "0"
        Next
        t.Text = str & t.Text
        Return 0

    End Function
    Function bw_check(bool As Boolean)
        addBank.CheckForIllegalCrossThreadCalls = bool
        addDamageProducts.CheckForIllegalCrossThreadCalls = bool
        addEmployee.CheckForIllegalCrossThreadCalls = bool
        addFridge.CheckForIllegalCrossThreadCalls = bool
        addNote.CheckForIllegalCrossThreadCalls = bool
        addProducts.CheckForIllegalCrossThreadCalls = bool
        addSupplier.CheckForIllegalCrossThreadCalls = bool
        attendenceReport.CheckForIllegalCrossThreadCalls = bool
        companySettings.CheckForIllegalCrossThreadCalls = bool
        createUser.CheckForIllegalCrossThreadCalls = bool
        damageFridge.CheckForIllegalCrossThreadCalls = bool
        Dashboard.CheckForIllegalCrossThreadCalls = bool
        dueReport.CheckForIllegalCrossThreadCalls = bool
        employeeAccounts.CheckForIllegalCrossThreadCalls = bool
        employeeAttendence.CheckForIllegalCrossThreadCalls = bool
        exepenseCategory.CheckForIllegalCrossThreadCalls = bool
        expenseReport.CheckForIllegalCrossThreadCalls = bool
        Form1.CheckForIllegalCrossThreadCalls = bool
        frmBanks.CheckForIllegalCrossThreadCalls = bool
        incomeCategory.CheckForIllegalCrossThreadCalls = bool
        Manage_sale.CheckForIllegalCrossThreadCalls = bool
        manageAsset.CheckForIllegalCrossThreadCalls = bool
        manageBankAccounts.CheckForIllegalCrossThreadCalls = bool
        manageDamageProducts.CheckForIllegalCrossThreadCalls = bool
        manageEmployee.CheckForIllegalCrossThreadCalls = bool
        manageExepense.CheckForIllegalCrossThreadCalls = bool
        manageFridge.CheckForIllegalCrossThreadCalls = bool
        manageIncome.CheckForIllegalCrossThreadCalls = bool
        manageProducts.CheckForIllegalCrossThreadCalls = bool
        managePurchase.CheckForIllegalCrossThreadCalls = bool
        manageSupplier.CheckForIllegalCrossThreadCalls = bool
        manageTransaction.CheckForIllegalCrossThreadCalls = bool
        newExpense.CheckForIllegalCrossThreadCalls = bool
        newIncome.CheckForIllegalCrossThreadCalls = bool
        newPurchase.CheckForIllegalCrossThreadCalls = bool
        newSale.CheckForIllegalCrossThreadCalls = bool
        productDelivery.CheckForIllegalCrossThreadCalls = bool
        productsCategory.CheckForIllegalCrossThreadCalls = bool
        profitCalculator.CheckForIllegalCrossThreadCalls = bool
        purchaseReport.CheckForIllegalCrossThreadCalls = bool
        rentToCustomer.CheckForIllegalCrossThreadCalls = bool
        salesReport.CheckForIllegalCrossThreadCalls = bool
        supplierAccounts.CheckForIllegalCrossThreadCalls = bool
        userRoles.CheckForIllegalCrossThreadCalls = bool
        login.CheckForIllegalCrossThreadCalls = bool
        customerAccounts.CheckForIllegalCrossThreadCalls = bool
        transactionReport.CheckForIllegalCrossThreadCalls = bool
        manageCustomer.CheckForIllegalCrossThreadCalls = bool
        addCustomer.CheckForIllegalCrossThreadCalls = bool
        paySupplierRent.CheckForIllegalCrossThreadCalls = bool
        payCustomerRent.CheckForIllegalCrossThreadCalls = bool
        withdraw.CheckForIllegalCrossThreadCalls = bool
        myaccount.CheckForIllegalCrossThreadCalls = bool
        newVehicle.CheckForIllegalCrossThreadCalls = bool
        manageVehicle.CheckForIllegalCrossThreadCalls = bool
        vehicleAccounts.CheckForIllegalCrossThreadCalls = bool
        backup.CheckForIllegalCrossThreadCalls = bool
        pinc.CheckForIllegalCrossThreadCalls = bool
        cashReport.CheckForIllegalCrossThreadCalls = bool
        sell_on_commission.CheckForIllegalCrossThreadCalls = bool
        discount.CheckForIllegalCrossThreadCalls = bool
        print_invoice.CheckForIllegalCrossThreadCalls = bool
        manageStock.CheckForIllegalCrossThreadCalls = bool
        rentFromSupplier.CheckForIllegalCrossThreadCalls = bool
        salesSeason.CheckForIllegalCrossThreadCalls = bool
        purchaseSeason.CheckForIllegalCrossThreadCalls = bool
        productCommission.CheckForIllegalCrossThreadCalls = bool
        prnt.CheckForIllegalCrossThreadCalls = bool
        prntF.CheckForIllegalCrossThreadCalls = bool
        signBoard.CheckForIllegalCrossThreadCalls = bool
        Return 0
    End Function

    Function frm_back_color(r As Integer, g As Integer, b As Integer)
        addbank.BackColor = Color.FromArgb(r, g, b)
        addDamageProducts.BackColor = Color.FromArgb(r, g, b)
        addemployee.BackColor = Color.FromArgb(r, g, b)
        addfridge.BackColor = Color.FromArgb(r, g, b)
        addnote.BackColor = Color.FromArgb(r, g, b)
        addproduct.BackColor = Color.FromArgb(r, g, b)
        addsupplier.BackColor = Color.FromArgb(r, g, b)
        attendencereport.BackColor = Color.FromArgb(r, g, b)
        companySettings.BackColor = Color.FromArgb(r, g, b)
        createuser.BackColor = Color.FromArgb(r, g, b)
        damageFridge.BackColor = Color.FromArgb(r, g, b)
        dashboard.BackColor = Color.FromArgb(r, g, b)
        duereport.BackColor = Color.FromArgb(r, g, b)
        employeeAccounts.BackColor = Color.FromArgb(r, g, b)
        employeeattendence.BackColor = Color.FromArgb(r, g, b)
        expensecategory.BackColor = Color.FromArgb(r, g, b)
        expensereport.BackColor = Color.FromArgb(r, g, b)
        Form1.BackColor = Color.FromArgb(r, g, b)
        frmBanks.BackColor = Color.FromArgb(r, g, b)
        incomecategory.BackColor = Color.FromArgb(r, g, b)
        Manage_sale.BackColor = Color.FromArgb(r, g, b)
        manageasset.BackColor = Color.FromArgb(r, g, b)
        managebankaccount.BackColor = Color.FromArgb(r, g, b)
        manageDamageProducts.BackColor = Color.FromArgb(r, g, b)
        manageemployee.BackColor = Color.FromArgb(r, g, b)
        manageExepense.BackColor = Color.FromArgb(r, g, b)
        managefridge.BackColor = Color.FromArgb(r, g, b)
        manageincome.BackColor = Color.FromArgb(r, g, b)
        manageproduct.BackColor = Color.FromArgb(r, g, b)
        managepurchase.BackColor = Color.FromArgb(r, g, b)
        managesupplier.BackColor = Color.FromArgb(r, g, b)
        managetransaction.BackColor = Color.FromArgb(r, g, b)
        newexpense.BackColor = Color.FromArgb(r, g, b)
        newincome.BackColor = Color.FromArgb(r, g, b)
        newpurchase.BackColor = Color.FromArgb(r, g, b)
        newsale.BackColor = Color.FromArgb(r, g, b)
        productdelivery.BackColor = Color.FromArgb(r, g, b)
        productcategory.BackColor = Color.FromArgb(r, g, b)
        profitcalculator.BackColor = Color.FromArgb(r, g, b)
        purchasereport.BackColor = Color.FromArgb(r, g, b)
        rentToCustomer.BackColor = Color.FromArgb(r, g, b)
        salesreport.BackColor = Color.FromArgb(r, g, b)
        supplieraccount.BackColor = Color.FromArgb(r, g, b)
        userRoles.BackColor = Color.FromArgb(r, g, b)
        login.BackColor = Color.FromArgb(r, g, b)
        customeraccount.BackColor = Color.FromArgb(r, g, b)
        transactionreport.BackColor = Color.FromArgb(r, g, b)
        managecustomer.BackColor = Color.FromArgb(r, g, b)
        addcustomer.BackColor = Color.FromArgb(r, g, b)
        paySupplierRent.BackColor = Color.FromArgb(r, g, b)
        payCustomerRent.BackColor = Color.FromArgb(r, g, b)
        withdraw.BackColor = Color.FromArgb(r, g, b)
        myaccount.BackColor = Color.FromArgb(r, g, b)
        newvehicle.BackColor = Color.FromArgb(r, g, b)
        managevehicle.BackColor = Color.FromArgb(r, g, b)
        vehicleaccounts.BackColor = Color.FromArgb(r, g, b)
        backup.BackColor = Color.FromArgb(r, g, b)
        pinc.BackColor = Color.FromArgb(r, g, b)
        cashreport.BackColor = Color.FromArgb(r, g, b)
        sell_on_commission.BackColor = Color.FromArgb(r, g, b)
        discount.BackColor = Color.FromArgb(r, g, b)
        print_invoice.BackColor = Color.FromArgb(r, g, b)
        managestock.BackColor = Color.FromArgb(r, g, b)
        rentFromSupplier.BackColor = Color.FromArgb(r, g, b)
        salesSeason.BackColor = Color.FromArgb(r, g, b)
        purchaseseason.BackColor = Color.FromArgb(r, g, b)
        productcommission.BackColor = Color.FromArgb(r, g, b)
        prnt.BackColor = Color.FromArgb(r, g, b)
        prntF.BackColor = Color.FromArgb(r, g, b)
        signBoard.BackColor = Color.FromArgb(r, g, b)
        salestarget.BackColor = Color.FromArgb(r, g, b)
        clear_datatable.BackColor = Color.FromArgb(r, g, b)
        Return 0
    End Function


    Function delete_purchase_invoice()
        supplieraccount.TblSupplierAccountsBindingSource.Filter = "purchaseInvoice =" & managepurchase.TblPurchaseInvoiceDataGridView.Rows(managepurchase.TblPurchaseInvoiceBindingSource.Position).Cells(1).Value.ToString
        manageexpense.TblExpensesBindingSource.Filter = "invoice_no =" & managepurchase.TblPurchaseInvoiceDataGridView.Rows(managepurchase.TblPurchaseInvoiceBindingSource.Position).Cells(1).Value.ToString
        Try
            supplieraccount.TblSupplierAccountsBindingSource.RemoveCurrent()
            manageexpense.TblExpensesBindingSource.RemoveCurrent()
        Catch ex As Exception

        End Try

        supplieraccount.Validate()
        manageexpense.Validate()
        supplieraccount.TblSupplierAccountsBindingSource.EndEdit()
        manageexpense.TblExpensesBindingSource.EndEdit()
        supplieraccount.TableAdapterManager.UpdateAll(supplieraccount.DataSet)
        manageexpense.TableAdapterManager.UpdateAll(manageexpense.DataSet)


        'restock
        For a As Integer = 0 To managepurchase.TblPurchaseBindingSource.Count - 1
            managepurchase.TblProductsBindingSource.Filter = "productCode =" & managepurchase.TblPurchaseDataGridView.Rows(a).Cells(4).Value.ToString
            managepurchase.TblProductsDataGridView.Rows(0).Cells(0).Value = Integer.Parse(managepurchase.TblProductsDataGridView.Rows(0).Cells(0).Value) - Integer.Parse(managepurchase.TblPurchaseDataGridView.Rows(a).Cells(3).Value.ToString)
            managepurchase.Validate()
            managepurchase.TblProductsBindingSource.EndEdit()
            managepurchase.TableAdapterManager.UpdateAll(managepurchase.DataSet)
        Next

        Return 0
    End Function
    Function print_sale_invoice()
        Dim page As New print_invoice


        'invoice generator
        Dim current As Integer = managesale.TblInvoiceBindingSource.Position
        'shop and invoice informaton
        page.Show()
        page.lbl_header.Text = Form1.Label1.Text & " - বিক্রয় রশিদ" '& vbNewLine & 
        page.CompanyLogoPictureBox.Image = Form1.CompanyLogoPictureBox.Image
        page.lbl_address_phone.Text = Form1.CompanyAddressTextBox.Text & ", " & Form1.CompanyPhoneNumberTextBox.Text
        page.lbl_invoice_no.Text = managesale.TblInvoiceDataGridView.Rows(current).Cells(0).Value.ToString
        page.lbl_shop_name.Text = managesale.TblInvoiceDataGridView.Rows(current).Cells(1).Value.ToString
        page.lbl_address.Text = managesale.TblInvoiceDataGridView.Rows(current).Cells(11).Value.ToString
        page.lbl_phone.Text = managesale.TblInvoiceDataGridView.Rows(current).Cells(2).Value.ToString
        page.lbl_date.Text = Date.Parse(managesale.TblInvoiceDataGridView.Rows(current).Cells(10).Value.ToString)
        'pricing
        page.lbl_total_price.Text = managesale.TblInvoiceDataGridView.Rows(current).Cells(3).Value.ToString & dashboard.CurrencyTextBox.Text
        page.lbl_discount.Text = managesale.TblInvoiceDataGridView.Rows(current).Cells(4).Value.ToString & dashboard.CurrencyTextBox.Text
        page.lbl_net_price.Text = managesale.TblInvoiceDataGridView.Rows(current).Cells(5).Value.ToString & dashboard.CurrencyTextBox.Text
        'products
        For a As Integer = 0 To managesale.TblSalesBindingSource.Count - 1
            Dim product_name As String = managesale.TblSalesDataGridView.Rows(a).Cells(0).Value.ToString
            Dim unit_price As String = managesale.TblSalesDataGridView.Rows(a).Cells(3).Value.ToString
            Dim quantity As String = managesale.TblSalesDataGridView.Rows(a).Cells(2).Value.ToString
            Dim discount As String = managesale.TblSalesDataGridView.Rows(a).Cells(5).Value.ToString
            Dim net_price As String = managesale.TblSalesDataGridView.Rows(a).Cells(6).Value.ToString
            page.dtg_products.Rows.Add(product_name, unit_price, quantity, discount, net_price)
        Next
        page.dtg_products.ColumnHeadersDefaultCellStyle.BackColor = Color.White
        page.dtg_products.GridColor = page.dtg_products.BackgroundColor
        '''''''''''''''''
        page.AutoScrollPosition = New Point(0, 0)



        'printing proccess started
        Dim pd As New Printing.PrintDocument
        Dim newprint As Form = page
        Dim p As New Panel
        p = page.Panel1
        newprint.Show()
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     'Dim w As Integer = p.Width
                                     'Dim h As Integer = p.Height

                                     'If w > newprint.Panel1.Width Or h > newprint.Panel1.Height Then

                                     '    w = w / 1.2
                                     '    h = h / 1.2
                                     'ElseIf (w / 1.2) > newprint.Panel1.Width Or (h / 1.2) > newprint.Panel1.Height Then

                                     '    w = (w / 1.2) / 1.2
                                     '    h = (h / 1.2) / 1.2
                                     'End If
                                     'drawing picture
                                     ' p.BackColor = Color.White
                                     Dim bm As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim gp As Graphics = Graphics.FromImage(bm)
                                     Dim rct As New Rectangle(0, 0, p.Width, p.Height)
                                     p.DrawToBitmap(bm, rct)
                                     bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                     e.Graphics.DrawImage(bm, New Rectangle(0, 0, bm.Width, bm.Height))
                                     'Dim pic As New PictureBox
                                     'pic.Height = p.Width
                                     'pic.Width = p.Height + 100
                                     ''bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                     'pic.Image = bm
                                     'pic.SizeMode = PictureBoxSizeMode.StretchImage
                                     'pic.BorderStyle = BorderStyle.FixedSingle
                                     'pic.BackColor = Color.Black

                                     'image size

                                     'size adjustment
                                     'If pic.Height > newprint.Panel1.Height Or pic.Width > newprint.Panel1.Width Then
                                     '    pic.Height = pic.Height / 1.2
                                     '    pic.Width = pic.Width / 1.2
                                     'ElseIf (pic.Height / 1.2) > newprint.Panel1.Height Or (pic.Width / 1.2) > newprint.Panel1.Width Then
                                     '    pic.Height = (pic.Height / 1.2) / 1.2
                                     '    pic.Width = (pic.Width / 1.2) / 1.2
                                     'End If

                                     'pic.Top = 100 '(newprint.Panel1.ClientSize.Height / 2) - (pic.Height / 2)
                                     'pic.Left = 500 '(newprint.Panel1.ClientSize.Width / 2) - (pic.Width / 2)
                                     'Dim rct2 As New Rectangle(3, 3, pic.Height, pic.Width)
                                     'e.Graphics.DrawImage(pic.Image, rct)
                                     ' newprint.Panel1.Controls.Add(pic)


                                     'Dim bmp As Bitmap = New Bitmap(newprint.pnl.Width, newprint.pnl.Height)
                                     'Dim g As Graphics = Graphics.FromImage(bmp)
                                     'newprint.pnl.DrawToBitmap(bmp, newprint.pnl.ClientRectangle)
                                     'Dim newMargins As System.Drawing.Printing.Margins
                                     'newMargins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
                                     'pd.DefaultPageSettings.Margins = newMargins
                                     'Dim imgrect As New Rectangle(5, 5, newprint.pnl.Width, newprint.pnl.Height)
                                     'e.Graphics.DrawImage(bmp, imgrect)
                                 End Sub

        Try
            AddHandler page.btn_print.Click, Function()
                                                 pd.Print()
                                                 Return 0
                                             End Function
            AddHandler page.btn_email.Click, Sub()
                                                 Dim bm As Bitmap = New Bitmap(p.Width, p.Height)
                                                 Dim gp As Graphics = Graphics.FromImage(bm)
                                                 Dim rct As New Rectangle(0, 0, p.Width, p.Height)
                                                 p.DrawToBitmap(bm, rct)
                                                 Dim bitmp(1) As Bitmap
                                                 bitmp(0) = bm
                                                 send_email("Sale invoice, Invoice NO: " & page.lbl_invoice_no.Text, shop_info() &
                                                            vbNewLine & vbNewLine & "Sir " & Form1.Owner_nameTextBox.Text &
                                                            "," & vbNewLine & "This is your sale invoice, " & vbNewLine & "Invoice NO: " & page.lbl_invoice_no.Text & vbNewLine & "Date: " &
                                                            page.lbl_date.Text & vbNewLine & "Shop name: " & page.lbl_shop_name.Text & vbNewLine & "Address: " & page.lbl_address.Text & vbNewLine &
                                                            "Phone: " & page.lbl_phone.Text &
                                                             software_info(), bitmp)
                                             End Sub
            '    AddHandler newprint.btnPrint.Click, Function()
            '                                            p.BackColor = Color.Transparent
            '                                            Return 0
            '                                        End Function
            '    AddHandler newprint.btnClose.Click, Function()
            '                                            p.BackColor = Color.Transparent
            '                                            Return 0
            '                                        End Function
        Catch ex As Exception

        End Try

        Return 0
    End Function
    Function profit_print()
        Dim page As New print_profit
        page.Show()

        page.lbl_shop_name.Text = Form1.Label1.Text & ", " & Form1.CompanyAddressTextBox.Text & ", " & Form1.CompanyPhoneNumberTextBox.Text
        page.CompanyLogoPictureBox.Image = Form1.CompanyLogoPictureBox.Image
        page.lbl_season.Text = profitcalculator.fromDt.Value.Date & " থেকে " & profitcalculator.toDt.Value.Date & " পর্যন্ত "
        'label text
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 1), page.lbl_income)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 2), page.lbl_expense)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 3), page.lbl_net_profit)

        label_text(dtsum(profitcalculator.TblProfitDataGridView, 13), page.lbl_total_sale)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 17), page.lbl_sale_discount)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 13) - dtsum(profitcalculator.TblProfitDataGridView, 17), page.lbl_net_sale)
        'filter paid and due sale
        profitcalculator.TblInvoiceBindingSource.Filter = "date >='" & profitcalculator.fromDt.Value.Date & "' AND date <='" & profitcalculator.toDt.Value.Date & "'"
        label_text((dtsum(profitcalculator.TblInvoiceDataGridView, 0) + dtsum(profitcalculator.TblInvoiceDataGridView, 1)) - dtsum(profitcalculator.TblInvoiceDataGridView, 2), page.lbl_sale_paid)
        label_text(dtsum(profitcalculator.TblInvoiceDataGridView, 2), page.lbl_sale_due)

        label_text(dtsum(profitcalculator.TblProfitDataGridView, 14), page.lbl_total_purchase)
        'filter for paid purchase
        profitcalculator.TblPurchaseInvoiceBindingSource.Filter = "date >='" & profitcalculator.fromDt.Value.Date & "' AND date <='" & profitcalculator.toDt.Value.Date & "'"
        label_text((dtsum(profitcalculator.TblPurchaseInvoiceDataGridView, 0) + dtsum(profitcalculator.TblPurchaseInvoiceDataGridView, 1)) - dtsum(profitcalculator.TblPurchaseInvoiceDataGridView, 2), page.lbl_purchase_paid)
        label_text(dtsum(profitcalculator.TblPurchaseInvoiceDataGridView, 2), page.lbl_purchase_due)

        label_text(dtsum(profitcalculator.TblProfitDataGridView, 10), page.lbl_bank_deposit)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 9), page.lbl_bank_withdraw)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 10) - dtsum(profitcalculator.TblProfitDataGridView, 9), page.lbl_bank_balance)

        label_text(dtsum(profitcalculator.TblProfitDataGridView, 11), page.lbl_owner_withdraw)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 8), page.lbl_cash_balance)

        label_text(dtsum(profitcalculator.TblProfitDataGridView, 17), page.lbl_given_discount)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 22), page.lbl_earned_commission)

        label_text(dtsum(profitcalculator.TblProfitDataGridView, 23), page.lbl_delivery_expense)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 2) - dtsum(profitcalculator.TblProfitDataGridView, 15), page.lbl_expense_without_purchase)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 2) - (dtsum(profitcalculator.TblProfitDataGridView, 15) + dtsum(profitcalculator.TblProfitDataGridView, 12)), page.lbl_expense_without_purchase_damage)
        label_text(dtsum(profitcalculator.TblProfitDataGridView, 12), page.lbl_damage_product)
        'generate revenue
        Dim revenue As Double = 0
        profitcalculator.TblSalesBindingSource.Filter = "date >='" & profitcalculator.fromDt.Value.Date & "' AND date <='" & profitcalculator.toDt.Value.Date & "'"
        For a As Integer = 0 To profitcalculator.TblSalesBindingSource.Count - 1
            Try
                revenue += prc((Double.Parse(profitcalculator.TblSalesDataGridView.Rows(a).Cells(1).Value.ToString) * Double.Parse(profitcalculator.TblSalesDataGridView.Rows(a).Cells(0).Value.ToString)), profitcalculator.TblSalesDataGridView.Rows(a).Cells(2).Value.ToString)
            Catch ex As Exception

            End Try


            'If (profitcalculator.TblSalesDataGridView.Rows(a).Cells(0).Value.ToString.Length > 0) AndAlso (profitcalculator.TblSalesDataGridView.Rows(a).Cells(1).Value.ToString.Length > 0) AndAlso (profitcalculator.TblSalesDataGridView.Rows(a).Cells(2).Value.ToString.Length > 0) Then
            '    revenue += prc((Double.Parse(profitcalculator.TblSalesDataGridView.Rows(a).Cells(1).Value.ToString) * Double.Parse(profitcalculator.TblSalesDataGridView.Rows(a).Cells(0).Value.ToString)), profitcalculator.TblSalesDataGridView.Rows(a).Cells(2).Value.ToString)
            'End If
        Next
        label_text(revenue, page.lbl_revenue)
        'progress
        Dim max As Int32 = Convert.ToInt32(dashboard.prg.Maximum), valu As Int32 = Convert.ToInt32(dashboard.prg.Value)
        If valu <= max Then
            page.prg.Maximum = max
            page.prg.Value = valu
            page.prg.Text = Convert.ToInt32(100 / (Double.Parse(page.prg.Maximum) / Double.Parse(page.prg.Value))) & "%"
            '  page.lblTarget.Text = page.prg.Maximum.ToString & page.CurrencyTextBox.Text
            '   page.lblSold.Text = page.prg.Value.ToString & page.CurrencyTextBox.Text
        ElseIf valu > max Then
            page.prg.Value = max
            page.prg.Text = "100%+"
        Else
            page.prg.Value = 0
            page.prg.Text = "0%"
        End If


        'printing proccess started
        Dim pd As New Printing.PrintDocument
        Dim newprint As Form = page
        Dim p As New Panel
        p = page.Panel1
        newprint.Show()
        AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                     Dim bm As Bitmap = New Bitmap(p.Width, p.Height)
                                     Dim gp As Graphics = Graphics.FromImage(bm)
                                     Dim rct As New Rectangle(0, 0, p.Width, p.Height)
                                     p.DrawToBitmap(bm, rct)
                                     ' bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                     e.Graphics.DrawImage(bm, New Rectangle(0, 0, bm.Width, bm.Height))
                                 End Sub

        Try
            AddHandler page.btn_print.Click, Function()
                                                 pd.Print()
                                                 page.Close()
                                                 Return 0
                                             End Function
            AddHandler page.btn_email.Click, Sub()
                                                 Dim bm As Bitmap = New Bitmap(p.Width, p.Height)
                                                 Dim gp As Graphics = Graphics.FromImage(bm)
                                                 Dim rct As New Rectangle(0, 0, p.Width, p.Height)
                                                 p.DrawToBitmap(bm, rct)
                                                 Dim bitmp(1) As Bitmap
                                                 bitmp(0) = bm
                                                 send_email("ব্যালেন্স স্ট্যাটমেন্ট - " & profitcalculator.fromDt.Value.Date.ToString & " -থেকে " & profitcalculator.toDt.Value.Date.ToString & " পর্যন্ত", shop_info() &
                                                            vbNewLine & vbNewLine & "স্যার " & Form1.Owner_nameTextBox.Text &
                                                            "," & vbNewLine & profitcalculator.fromDt.Value.Date.ToString & " -থেকে " & profitcalculator.toDt.Value.Date.ToString &
                                                            " পর্যন্ত আপনার ব্যালেন্স, ক্রয়-বিক্রয়, আয়-ব্যয়, ব্যাংক লেনদেন, সম্পদের পরিমাণ, অর্জিত মুনাফা ইত্যাদি সংক্রান্ত তথ্যাবলি উল্লেখ করা হলো।" &
                                                              software_info(), bitmp)
                                             End Sub
        Catch ex As Exception

        End Try


        Return 0
    End Function
    Function label_text(d As Double, l As Label)
        l.Text = d & dashboard.CurrencyTextBox.Text
        Return Nothing
    End Function
    Function hidden_dtvalue(dt As DataGridView, s As String)
        Dim sum As Double, a As Double = 0
        For i As Integer = 0 To dt.Rows.Count - 1
            sum += dt.Rows(i).Cells(s).Value.ToString
        Next
        Return sum
    End Function
    Function create()
        Dim thd As New Threading.Thread(New Threading.ThreadStart(Sub()
                                                                      Form1.MenuStrip1.Enabled = False
                                                                      Dim start1 As Date = Date.Parse("10/1/2019")
                                                                      Dim start2 As Date = Date.Parse("11/1/2019")
                                                                      For a = 1 To 31
                                                                          Try
                                                                              Microsoft.VisualBasic.DateString = New Date(start1.Year, start1.Month, start1.Day)
                                                                              lod()
                                                                              start1 = start1.AddDays(1)
                                                                          Catch ex As Exception

                                                                          End Try
                                                                      Next
                                                                      For b = 1 To 30
                                                                          Try
                                                                              Microsoft.VisualBasic.DateString = New Date(start2.Year, start2.Month, start2.Day)
                                                                              lod()
                                                                              start2 = start2.AddDays(1)
                                                                          Catch ex As Exception

                                                                          End Try
                                                                      Next
                                                                      Form1.MenuStrip1.Enabled = True
                                                                  End Sub))
        thd.Start()
        Return Nothing
    End Function
    Sub dash_prg()
        dashboard.Tbl_sales_targetTableAdapter.Fill(dashboard.DataSet.tbl_sales_target)
        If dashboard.Tbl_sales_targetDataGridView.Rows.Count > 1 Then
            dashboard.TblInvoiceBindingSource.Filter = "date >= '" & Today.Month & "/1/" & Today.Year & "' AND date <= '" & Today.Month & "/" & Date.DaysInMonth(Today.Year, Today.Month) & "/" & Today.Year & "'"
            Dim max As Int32 = Convert.ToInt32(dashboard.Tbl_sales_targetDataGridView.Rows(0).Cells(Today.Month - 1).Value.ToString), valu As Int32 = Convert.ToInt32(dtsum(dashboard.TblInvoiceDataGridView, 2))
            If valu <= max Then
                dashboard.prg.Maximum = max
                dashboard.prg.Value = valu
                dashboard.prg.Text = Convert.ToInt32(100 / (Double.Parse(dashboard.prg.Maximum) / Double.Parse(dashboard.prg.Value))) & "%"
                dashboard.lblTarget.Text = dashboard.prg.Maximum.ToString & dashboard.CurrencyTextBox.Text
                dashboard.lblSold.Text = dashboard.prg.Value.ToString & dashboard.CurrencyTextBox.Text
            ElseIf valu > max Then
                dashboard.prg.Value = max
                dashboard.prg.Text = "100%+"
            End If
        Else
            dashboard.prg.Value = 0
            dashboard.prg.Text = "0%"
        End If
    End Sub


    Function animate_prg(prg As CircularProgressBar.CircularProgressBar)
        If prg.Value < prg.Maximum Then
            prg.Value += 1
        Else
            prg.Value = 0
        End If
        Return Nothing
    End Function


    Function print_daily_expense()
        'page loading
        Dim page As New daily_expense_printer
        page.TopLevel = False
        page.Dock = DockStyle.Fill
        Form1.pnlMain.Controls.Clear()
        Form1.pnlMain.Controls.Add(page)
        page.Show()
        'Dim t As New Timer
        't.Interval = 500
        'AddHandler t.Tick, Sub()

        '                   End Sub
        't.Start()
        ''''''''''''''''
        'headers
        'page.TblExpensesBindingSource.Filter = "date = '" & page.dtp.Value.Date & "'"
        'page.CompanyLogoPictureBox.Image = Form1.CompanyLogoPictureBox.Image
        'page.lbl_shop_name.Text = Form1.Label1.Text & ", " & Form1.CompanyAddressTextBox.Text & ", " & Form1.CompanyPhoneNumberTextBox.Text
        'page.lbl_date.Text = page.dtp.Value.Date
        'page.TblExpensesTableAdapter.Fill(page.DataSet.tblExpenses)
        'page.lbl_total_expense.Text = dtsum(page.TblExpensesDataGridView, 0) + dtsum(page.TblExpensesDataGridView, 1) & dashboard.CurrencyTextBox.Text
        ''''''''''''''''
        '' get input

        'With page
        '    If page.TblExpensesBindingSource.Count > 0 Then
        '        If .TblExpensesBindingSource.Count <= 38 Then
        '            For a As Integer = 0 To 37
        '                Dim amount As Double
        '                If pdtgv_1(a, 0, .TblExpensesDataGridView) = Nothing Then
        '                    amount = pdtgv_1(a, 1, .TblExpensesDataGridView)
        '                Else
        '                    amount = pdtgv_1(a, 1, .TblExpensesDataGridView) + pdtgv_1(a, 0, .TblExpensesDataGridView)
        '                End If
        '                .dtg.Rows.Add(pdtgv_1(a, 4, .TblExpensesDataGridView), pdtgv_1(a, 3, .TblExpensesDataGridView), amount & dashboard.CurrencyTextBox.Text)
        '            Next
        '        ElseIf .TblExpensesBindingSource.Count > 38 Then
        '            '1
        '            For a As Integer = 0 To 37
        '                Dim amount As Double
        '                If pdtgv_1(a, 0, .TblExpensesDataGridView) = Nothing Then
        '                    amount = pdtgv_1(a, 1, .TblExpensesDataGridView)
        '                Else
        '                    amount = pdtgv_1(a, 1, .TblExpensesDataGridView) + pdtgv_1(a, 0, .TblExpensesDataGridView)
        '                End If
        '                .dtg.Rows.Add(pdtgv_1(a, 4, .TblExpensesDataGridView), pdtgv_1(a, 3, .TblExpensesDataGridView), amount & dashboard.CurrencyTextBox.Text)
        '            Next
        '            '2
        '            For a As Integer = 37 To 81
        '                Dim amount As Double
        '                If pdtgv_1(a, 0, .TblExpensesDataGridView) = Nothing Then
        '                    amount = pdtgv_1(a, 1, .TblExpensesDataGridView)
        '                Else
        '                    amount = pdtgv_1(a, 1, .TblExpensesDataGridView) + pdtgv_1(a, 0, .TblExpensesDataGridView)
        '                End If
        '                .dtg1.Rows.Add(pdtgv_1(a, 4, .TblExpensesDataGridView), pdtgv_1(a, 3, .TblExpensesDataGridView), amount & dashboard.CurrencyTextBox.Text)
        '            Next
        '        End If
        '    End If
        '    '''''''''''''''
        'End With
        ''prnting process started

        'Dim bitmp(2) As Bitmap
        ''printing proccess started
        'If page.dtg1.Rows.Count = 1 Then
        '    Dim p As New Panel
        '    p = page.Panel1
        '    Dim bp As Bitmap = New Bitmap(p.Width, p.Height)
        '    Dim gp As Graphics = Graphics.FromImage(bp)
        '    Dim rct As New Rectangle(0, 0, p.Width, p.Height)
        '    p.DrawToBitmap(bp, rct)
        '    bitmp(0) = bp
        'ElseIf page.dtg1.Rows.Count > 1 Then
        '    '1
        '    Dim p As New Panel
        '    p = page.Panel1
        '    Dim bp As Bitmap = New Bitmap(p.Width, p.Height)
        '    Dim gp As Graphics = Graphics.FromImage(bp)
        '    Dim rct As New Rectangle(0, 0, p.Width, p.Height)
        '    p.DrawToBitmap(bp, rct)
        '    bitmp(0) = bp
        '    '2            
        '    p = page.Panel2
        '    Dim bp1 As Bitmap = New Bitmap(p.Width, p.Height)
        '    Dim gp1 As Graphics = Graphics.FromImage(bp1)
        '    Dim rct1 As New Rectangle(0, 0, p.Width, p.Height)
        '    p.DrawToBitmap(bp1, rct1)
        '    bitmp(1) = bp1
        'End If
        ' value change
        Dim bitmp(2) As Bitmap
        AddHandler page.dtp.ValueChanged, Sub()
                                              'headers
                                              page.TblExpensesBindingSource.Filter = "date = '" & page.dtp.Value.Date & "'"
                                              page.CompanyLogoPictureBox.Image = Form1.CompanyLogoPictureBox.Image
                                              page.lbl_shop_name.Text = Form1.Label1.Text & ", " & Form1.CompanyAddressTextBox.Text & ", " & Form1.CompanyPhoneNumberTextBox.Text
                                              page.lbl_date.Text = page.dtp.Value.Date
                                              page.TblExpensesTableAdapter.Fill(page.DataSet.tblExpenses)
                                              page.lbl_total_expense.Text = dtsum(page.TblExpensesDataGridView, 0) + dtsum(page.TblExpensesDataGridView, 1) & dashboard.CurrencyTextBox.Text
                                              'clear rows
                                              page.dtg.Rows.Clear()
                                              page.dtg1.Rows.Clear()
                                              '''''''''''''''
                                              ' get input

                                              With page
                                                  If page.TblExpensesBindingSource.Count > 0 Then
                                                      If .TblExpensesBindingSource.Count <= 38 Then
                                                          For a As Integer = 0 To .TblExpensesBindingSource.Count - 1
                                                              Dim amount As Double
                                                              If pdtgv_1(a, 0, .TblExpensesDataGridView) = Nothing Then
                                                                  amount = pdtgv_1(a, 1, .TblExpensesDataGridView)
                                                              Else
                                                                  amount = pdtgv_1(a, 1, .TblExpensesDataGridView) + pdtgv_1(a, 0, .TblExpensesDataGridView)
                                                              End If
                                                              .dtg.Rows.Add(pdtgv_1(a, 4, .TblExpensesDataGridView), pdtgv_1(a, 3, .TblExpensesDataGridView), amount & dashboard.CurrencyTextBox.Text)
                                                          Next
                                                      ElseIf .TblExpensesBindingSource.Count > 38 Then
                                                          '1
                                                          For a As Integer = 0 To .TblExpensesBindingSource.Count - 1
                                                              Dim amount As Double
                                                              If pdtgv_1(a, 0, .TblExpensesDataGridView) = Nothing Then
                                                                  amount = pdtgv_1(a, 1, .TblExpensesDataGridView)
                                                              Else
                                                                  amount = pdtgv_1(a, 1, .TblExpensesDataGridView) + pdtgv_1(a, 0, .TblExpensesDataGridView)
                                                              End If
                                                              .dtg.Rows.Add(pdtgv_1(a, 4, .TblExpensesDataGridView), pdtgv_1(a, 3, .TblExpensesDataGridView), amount & dashboard.CurrencyTextBox.Text)
                                                          Next
                                                          '2
                                                          For a As Integer = 37 To .TblExpensesBindingSource.Count - 1
                                                              Dim amount As Double
                                                              If pdtgv_1(a, 0, .TblExpensesDataGridView) = Nothing Then
                                                                  amount = pdtgv_1(a, 1, .TblExpensesDataGridView)
                                                              Else
                                                                  amount = pdtgv_1(a, 1, .TblExpensesDataGridView) + pdtgv_1(a, 0, .TblExpensesDataGridView)
                                                              End If
                                                              .dtg1.Rows.Add(pdtgv_1(a, 4, .TblExpensesDataGridView), pdtgv_1(a, 3, .TblExpensesDataGridView), amount & dashboard.CurrencyTextBox.Text)
                                                          Next
                                                      End If
                                                  End If
                                                  '''''''''''''''
                                              End With
                                              'prnting process started

                                              ' Dim bitmp(2) As Bitmap
                                              'printing proccess started
                                              If page.dtg1.Rows.Count = 1 Then
                                                  Dim p As New Panel
                                                  p = page.Panel1
                                                  Dim bp As Bitmap = New Bitmap(p.Width, p.Height)
                                                  Dim gp As Graphics = Graphics.FromImage(bp)
                                                  Dim rct As New Rectangle(0, 0, p.Width, p.Height)
                                                  p.DrawToBitmap(bp, rct)
                                                  bitmp(0) = bp
                                              ElseIf page.dtg1.Rows.Count > 1 Then
                                                  '1
                                                  Dim p As New Panel
                                                  p = page.Panel1
                                                  Dim bp As Bitmap = New Bitmap(p.Width, p.Height)
                                                  Dim gp As Graphics = Graphics.FromImage(bp)
                                                  Dim rct As New Rectangle(0, 0, p.Width, p.Height)
                                                  p.DrawToBitmap(bp, rct)
                                                  bitmp(0) = bp
                                                  '2            
                                                  p = page.Panel2
                                                  Dim bp1 As Bitmap = New Bitmap(p.Width, p.Height)
                                                  Dim gp1 As Graphics = Graphics.FromImage(bp1)
                                                  Dim rct1 As New Rectangle(0, 0, p.Width, p.Height)
                                                  p.DrawToBitmap(bp1, rct1)
                                                  bitmp(1) = bp1
                                              End If
                                          End Sub

        page.dtp.Value = Today.Date

        '1
        Dim pd As New Printing.PrintDocument
                                              AddHandler pd.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                                                           ' bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                                                           ' e.Graphics.DrawImage(bitmp(0), New Rectangle(0, 0, bitmp(0).Width, bitmp(0).Height))
                                                                           e.Graphics.DrawImage(bitmp(1), New Rectangle(0, 0, bitmp(1).Width, bitmp(1).Height))
                                                                       End Sub
                                              '2
                                              Dim pd1 As New Printing.PrintDocument
                                              AddHandler pd1.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                                                            ' bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                                                            e.Graphics.DrawImage(bitmp(0), New Rectangle(0, 0, bitmp(0).Width, bitmp(0).Height))
                                                                            ' e.Graphics.DrawImage(bitmp(1), New Rectangle(0, 0, bitmp(1).Width, bitmp(1).Height))
                                                                        End Sub

                                              Try
                                                  AddHandler page.btn_print.Click, Function()
                                                                                       pd.Print()
                                                                                       pd1.Print()
                                                                                       index(29)
                                                                                       fll(29)
                                                                                       ld(29)
                                                                                       Return 0
                                                                                   End Function
                                                  AddHandler page.btn_email.Click, Sub()
                                                                                       ' bm.RotateFlip(RotateFlipType.Rotate90FlipNone)
                                                                                       'e.Graphics.DrawImage(bm, New Rectangle(0, 0, bm.Width, bm.Height))
                                                                                       send_email("দৈনিক ব্যয়সমূহ - " & page.dtp.Value.Date.ToString, shop_info() &
                                                                                                      vbNewLine & vbNewLine & "স্যার " & Form1.Owner_nameTextBox.Text &
                                                                                                      "," & vbNewLine & "আপনার প্রতিষ্ঠানের " &
                                                                                                       page.dtp.Value.Date.ToString & " তারিখের ব্যয়সমূহ নিম্নে উল্লেখ করা হলো।" & software_info(), bitmp)
                                                                                       'index(34)
                                                                                       'fll(34)
                                                                                       'ld(34)
                                                                                   End Sub
                                              Catch ex As Exception

                                              End Try

                                              Return Nothing
    End Function
    Sub langu(l As String)
        If l = "Bangla" Then
            Form1.DashboardToolStripMenuItem.Text = "ড্যাশবোর্ড"

        ElseIf l = "English" Then

        End If
    End Sub
    Function get_current_security(security As Object, monthly_rent As Object, rent_date As Date)

        Return 0
    End Function
End Module


