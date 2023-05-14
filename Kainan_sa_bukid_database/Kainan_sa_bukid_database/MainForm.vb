Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        IngredientAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    ' Main Side Navigation Buttons
    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        With DashboardForm
            .TopLevel = False
            ContentPanel.Controls.Add(DashboardForm)

            .DisplayNumberInDashboard("product", .ProductRegisteredLabel)
            .DisplayNumberInDashboard("ingredient", .IngredientsRegisteredLabel)
            .DisplayNumberInDashboard("supplier", .NumberOfSuppliersLabel)
            .DisplayNumberInDashboard("employee", .NumberOfEmployeesLabel)

            .DisplayRecentPurchasesTable()

            .BringToFront()
            .Show()
        End With

        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        IngredientAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        If TransactionAccordionPanel.Visible = False Then
            TransactionAccordionPanel.Visible = True
        Else
            TransactionAccordionPanel.Visible = False
        End If
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        IngredientAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub ProductsBtn_Click(sender As Object, e As EventArgs) Handles ProductsBtn.Click
        If ProductAccordionPanel.Visible = False Then
            ProductAccordionPanel.Visible = True
        Else
            ProductAccordionPanel.Visible = False
        End If
        TransactionAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        IngredientAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub IngredientsBtn_Click(sender As Object, e As EventArgs) Handles IngredientsBtn.Click
        If IngredientAccordionPanel.Visible = False Then
            IngredientAccordionPanel.Visible = True
        Else
            IngredientAccordionPanel.Visible = False
        End If
        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub SupplierBtn_Click(sender As Object, e As EventArgs) Handles SupplierBtn.Click
        If SupplierAccordionPanel.Visible = False Then
            SupplierAccordionPanel.Visible = True
        Else
            SupplierAccordionPanel.Visible = False
        End If
        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        IngredientAccordionPanel.Visible = False
        EmployeeAccordionPanel.Visible = False
    End Sub

    Private Sub EmployeeBtn_Click(sender As Object, e As EventArgs) Handles EmployeeBtn.Click
        If EmployeeAccordionPanel.Visible = False Then
            EmployeeAccordionPanel.Visible = True
        Else
            EmployeeAccordionPanel.Visible = False
        End If
        TransactionAccordionPanel.Visible = False
        ProductAccordionPanel.Visible = False
        SupplierAccordionPanel.Visible = False
        IngredientAccordionPanel.Visible = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Transaction Navigation Buttons
    Private Sub TransactionSalesBtn_Click(sender As Object, e As EventArgs) Handles TransactionSalesBtn.Click
        With SalesForm
            .TopLevel = False
            ContentPanel.Controls.Add(SalesForm)

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub TransactionDeliveryBtn_Click(sender As Object, e As EventArgs) Handles TransactionDeliveryBtn.Click
        With DeliveryForm
            .TopLevel = False
            ContentPanel.Controls.Add(DeliveryForm)

            .DisplayDeliveryIngredientID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub TransactionPurchaseBtn_Click(sender As Object, e As EventArgs) Handles TransactionPurchaseBtn.Click
        With RestockForm
            .TopLevel = False
            ContentPanel.Controls.Add(RestockForm)

            .DisplayRestockIDs()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Product Navigation Buttons
    Private Sub ProductViewBtn_Click(sender As Object, e As EventArgs) Handles ProductViewBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductDGV.Visible = True
            .ProductIDLabel.Visible = False
            .ProductIDComboBox.Visible = False
            .ProductNameLabel.Visible = False
            .ProductNameTextBox.Visible = False
            .ProductCostLabel.Visible = False
            .ProductCostTextBox.Visible = False
            .ProductTypeLabel.Visible = False
            .ProductTypeTextBox.Visible = False

            .ProductAddButton.Visible = False
            .ProductUpdateButton.Visible = False
            .ProductDeleteButton.Visible = False
            .ProductClearButton.Visible = False
            .UpdateProductIngredientsButton.Visible = False

            .AddProductIngredientsPanel.Visible = False

            .DisplayProductTable()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ProductAddBtn_Click(sender As Object, e As EventArgs) Handles ProductAddBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductDGV.Visible = False
            .ProductIDLabel.Visible = True
            .ProductIDComboBox.Visible = True
            .ProductNameLabel.Visible = True
            .ProductNameTextBox.Visible = True
            .ProductCostLabel.Visible = True
            .ProductCostTextBox.Visible = True
            .ProductTypeLabel.Visible = True
            .ProductTypeTextBox.Visible = True

            .ProductAddButton.Visible = True
            .ProductUpdateButton.Visible = False
            .ProductDeleteButton.Visible = False
            .ProductClearButton.Visible = True
            .UpdateProductIngredientsButton.Visible = False

            .ProductIDComboBox.Enabled = False
            .ProductAddButton.Enabled = False

            .ProductNameTextBox.Enabled = True
            .ProductCostTextBox.Enabled = True
            .ProductTypeTextBox.Enabled = True

            .ProductIDComboBox.DataSource = Nothing
            .ProductIDComboBox.Items.Clear()

            .AddProductIngredientsPanel.Visible = False

            .DisplayNextProductID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ProductUpdateBtn_Click(sender As Object, e As EventArgs) Handles ProductUpdateBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductDGV.Visible = False
            .ProductIDLabel.Visible = True
            .ProductIDComboBox.Visible = True
            .ProductNameLabel.Visible = True
            .ProductNameTextBox.Visible = True
            .ProductCostLabel.Visible = True
            .ProductCostTextBox.Visible = True
            .ProductTypeLabel.Visible = True
            .ProductTypeTextBox.Visible = True

            .ProductAddButton.Visible = False
            .ProductUpdateButton.Visible = True
            .ProductDeleteButton.Visible = False
            .ProductClearButton.Visible = True
            .UpdateProductIngredientsButton.Visible = True

            .ProductIDComboBox.Enabled = True
            .ProductUpdateButton.Enabled = False

            .ProductNameTextBox.Enabled = True
            .ProductCostTextBox.Enabled = True
            .ProductTypeTextBox.Enabled = True

            .AddProductIngredientsPanel.Visible = False

            .DisplayProductID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ProductDeleteBtn_Click(sender As Object, e As EventArgs) Handles ProductDeleteBtn.Click
        With ProductForm
            .TopLevel = False
            ContentPanel.Controls.Add(ProductForm)

            .ProductDGV.Visible = False
            .ProductIDLabel.Visible = True
            .ProductIDComboBox.Visible = True
            .ProductNameLabel.Visible = True
            .ProductNameTextBox.Visible = True
            .ProductCostLabel.Visible = True
            .ProductCostTextBox.Visible = True
            .ProductTypeLabel.Visible = True
            .ProductTypeTextBox.Visible = True

            .ProductAddButton.Visible = False
            .ProductUpdateButton.Visible = False
            .ProductDeleteButton.Visible = True
            .ProductClearButton.Visible = True
            .UpdateProductIngredientsButton.Visible = False

            .ProductIDComboBox.Enabled = True
            .ProductDeleteButton.Enabled = False

            .ProductNameTextBox.Enabled = False
            .ProductCostTextBox.Enabled = False
            .ProductTypeTextBox.Enabled = False

            .AddProductIngredientsPanel.Visible = False

            .DisplayProductID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Ingredient Navigation Buttons
    Private Sub IngredientsViewBtn_Click(sender As Object, e As EventArgs) Handles IngredientsViewBtn.Click
        With IngredientForm
            .TopLevel = False
            ContentPanel.Controls.Add(IngredientForm)

            .IngredientDGV.Visible = True

            .IngredientIDLabel.Visible = False
            .IngredientIDComboBox.Visible = False
            .IngredientNameLabel.Visible = False
            .IngredientNameTextBox.Visible = False
            .IngredientExpDateLabel.Visible = False
            .IngredientExpDatePicker.Visible = False
            .IngredientQuantityLabel.Visible = False
            .IngredientQuantityTextBox.Visible = False
            .IngredientSupplierNameLabel.Visible = False
            .IngredientSupplierNameComboBox.Visible = False

            .IngredientAddButton.Visible = False
            .IngredientUpdateButton.Visible = False
            .IngredientDeleteButton.Visible = False
            .IngredientClearButton.Visible = False

            .DisplayIngredientTable()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IngredientsAddBtn_Click(sender As Object, e As EventArgs) Handles IngredientsAddBtn.Click
        With IngredientForm
            .TopLevel = False
            ContentPanel.Controls.Add(IngredientForm)

            .IngredientDGV.Visible = False

            .IngredientIDLabel.Visible = True
            .IngredientIDComboBox.Visible = True
            .IngredientNameLabel.Visible = True
            .IngredientNameTextBox.Visible = True
            .IngredientExpDateLabel.Visible = True
            .IngredientExpDatePicker.Visible = True
            .IngredientQuantityLabel.Visible = False
            .IngredientQuantityTextBox.Visible = False
            .IngredientSupplierNameLabel.Visible = True
            .IngredientSupplierNameComboBox.Visible = True

            .IngredientAddButton.Visible = True
            .IngredientUpdateButton.Visible = False
            .IngredientDeleteButton.Visible = False
            .IngredientClearButton.Visible = True

            .IngredientIDComboBox.Enabled = False
            .IngredientAddButton.Enabled = False

            .IngredientNameTextBox.Enabled = True
            .IngredientExpDatePicker.Enabled = True
            .IngredientQuantityTextBox.Enabled = False
            .IngredientSupplierNameComboBox.Enabled = True

            .IngredientIDComboBox.DataSource = Nothing
            .IngredientIDComboBox.Items.Clear()

            .IngredientSupplierNameComboBox.DataSource = Nothing
            .IngredientSupplierNameComboBox.Items.Clear()

            .DisplayIngredientSupplierName()
            .DisplayNextIngredientID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IngredientsUpdateBtn_Click(sender As Object, e As EventArgs) Handles IngredientsUpdateBtn.Click
        With IngredientForm
            .TopLevel = False
            ContentPanel.Controls.Add(IngredientForm)

            .IngredientDGV.Visible = False

            .IngredientIDLabel.Visible = True
            .IngredientIDComboBox.Visible = True
            .IngredientNameLabel.Visible = True
            .IngredientNameTextBox.Visible = True
            .IngredientExpDateLabel.Visible = True
            .IngredientExpDatePicker.Visible = True
            .IngredientQuantityLabel.Visible = True
            .IngredientQuantityTextBox.Visible = True
            .IngredientSupplierNameLabel.Visible = True
            .IngredientSupplierNameComboBox.Visible = True

            .IngredientAddButton.Visible = False
            .IngredientUpdateButton.Visible = True
            .IngredientDeleteButton.Visible = False
            .IngredientClearButton.Visible = True

            .IngredientIDComboBox.Enabled = True
            .IngredientUpdateButton.Enabled = False

            .IngredientNameTextBox.Enabled = True
            .IngredientExpDatePicker.Enabled = True
            .IngredientQuantityTextBox.Enabled = True
            .IngredientSupplierNameComboBox.Enabled = True

            .DisplayIngredientSupplierName()
            .DisplayIngredientID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub IngredientsDeleteBtn_Click(sender As Object, e As EventArgs) Handles IngredientsDeleteBtn.Click
        With IngredientForm
            .TopLevel = False
            ContentPanel.Controls.Add(IngredientForm)

            .IngredientDGV.Visible = False

            .IngredientIDLabel.Visible = True
            .IngredientIDComboBox.Visible = True
            .IngredientNameLabel.Visible = True
            .IngredientNameTextBox.Visible = True
            .IngredientExpDateLabel.Visible = True
            .IngredientExpDatePicker.Visible = True
            .IngredientQuantityLabel.Visible = False
            .IngredientQuantityTextBox.Visible = False
            .IngredientSupplierNameLabel.Visible = True
            .IngredientSupplierNameComboBox.Visible = True

            .IngredientAddButton.Visible = False
            .IngredientUpdateButton.Visible = False
            .IngredientDeleteButton.Visible = True
            .IngredientClearButton.Visible = True

            .IngredientIDComboBox.Enabled = True
            .IngredientUpdateButton.Enabled = False

            .IngredientNameTextBox.Enabled = False
            .IngredientExpDatePicker.Enabled = False
            .IngredientQuantityTextBox.Enabled = False
            .IngredientSupplierNameComboBox.Enabled = False

            .DisplayIngredientSupplierName()
            .DisplayIngredientID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Supplier Navigation Buttons
    Private Sub SuppliersViewBtn_Click(sender As Object, e As EventArgs) Handles SuppliersViewBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierDGV.Visible = True

            .SupplierIDLabel.Visible = False
            .SupplierIDComboBox.Visible = False
            .SupplierLNameLabel.Visible = False
            .SupplierLNameTextBox.Visible = False
            .SupplierFNameLabel.Visible = False
            .SupplierFNameTextBox.Visible = False
            .SupplierMinitLabel.Visible = False
            .SupplierMinitTextBox.Visible = False
            .SupplierAddressLabel.Visible = False
            .SupplierAddressTextBox.Visible = False
            .SupplierPhoneNumberLabel.Visible = False
            .SupplierNumberTextBox.Visible = False

            .SupplierAddButton.Visible = False
            .SupplierUpdateButton.Visible = False
            .SupplierDeleteButton.Visible = False
            .SupplierClearButton.Visible = False

            .ShowSupplierTable()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SuppliersAddBtn_Click(sender As Object, e As EventArgs) Handles SuppliersAddBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierDGV.Visible = False

            .SupplierIDLabel.Visible = True
            .SupplierIDComboBox.Visible = True
            .SupplierLNameLabel.Visible = True
            .SupplierLNameTextBox.Visible = True
            .SupplierFNameLabel.Visible = True
            .SupplierFNameTextBox.Visible = True
            .SupplierMinitLabel.Visible = True
            .SupplierMinitTextBox.Visible = True
            .SupplierAddressLabel.Visible = True
            .SupplierAddressTextBox.Visible = True
            .SupplierPhoneNumberLabel.Visible = True
            .SupplierNumberTextBox.Visible = True

            .SupplierAddButton.Visible = True
            .SupplierUpdateButton.Visible = False
            .SupplierDeleteButton.Visible = False
            .SupplierClearButton.Visible = True

            .SupplierIDComboBox.Enabled = False
            .SupplierAddButton.Enabled = False

            .SupplierLNameTextBox.Enabled = True
            .SupplierFNameTextBox.Enabled = True
            .SupplierMinitTextBox.Enabled = True
            .SupplierAddressTextBox.Enabled = True
            .SupplierNumberTextBox.Enabled = True

            .SupplierIDComboBox.DataSource = Nothing
            .SupplierIDComboBox.Items.Clear()

            .DisplayNextSupplierID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SuppliersUpdateBtn_Click(sender As Object, e As EventArgs) Handles SuppliersUpdateBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierDGV.Visible = False

            .SupplierIDLabel.Visible = True
            .SupplierIDComboBox.Visible = True
            .SupplierLNameLabel.Visible = True
            .SupplierLNameTextBox.Visible = True
            .SupplierFNameLabel.Visible = True
            .SupplierFNameTextBox.Visible = True
            .SupplierMinitLabel.Visible = True
            .SupplierMinitTextBox.Visible = True
            .SupplierAddressLabel.Visible = True
            .SupplierAddressTextBox.Visible = True
            .SupplierPhoneNumberLabel.Visible = True
            .SupplierNumberTextBox.Visible = True

            .SupplierAddButton.Visible = False
            .SupplierUpdateButton.Visible = True
            .SupplierDeleteButton.Visible = False
            .SupplierClearButton.Visible = True

            .SupplierIDComboBox.Enabled = True
            .SupplierUpdateButton.Enabled = False

            .SupplierLNameTextBox.Enabled = True
            .SupplierFNameTextBox.Enabled = True
            .SupplierMinitTextBox.Enabled = True
            .SupplierAddressTextBox.Enabled = True
            .SupplierNumberTextBox.Enabled = True

            .DisplaySupplierID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SuppliersDeleteBtn_Click(sender As Object, e As EventArgs) Handles SuppliersDeleteBtn.Click
        With SupplierForm
            .TopLevel = False
            ContentPanel.Controls.Add(SupplierForm)

            .SupplierDGV.Visible = False

            .SupplierIDLabel.Visible = True
            .SupplierIDComboBox.Visible = True
            .SupplierLNameLabel.Visible = True
            .SupplierLNameTextBox.Visible = True
            .SupplierFNameLabel.Visible = True
            .SupplierFNameTextBox.Visible = True
            .SupplierMinitLabel.Visible = True
            .SupplierMinitTextBox.Visible = True
            .SupplierAddressLabel.Visible = True
            .SupplierAddressTextBox.Visible = True
            .SupplierPhoneNumberLabel.Visible = True
            .SupplierNumberTextBox.Visible = True

            .SupplierAddButton.Visible = False
            .SupplierUpdateButton.Visible = False
            .SupplierDeleteButton.Visible = True
            .SupplierClearButton.Visible = True

            .SupplierIDComboBox.Enabled = True
            .SupplierLNameTextBox.Enabled = False
            .SupplierFNameTextBox.Enabled = False
            .SupplierMinitTextBox.Enabled = False
            .SupplierAddressTextBox.Enabled = False
            .SupplierNumberTextBox.Enabled = False

            .SupplierDeleteButton.Enabled = False

            .DisplaySupplierID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Employee Navigation Buttons
    Private Sub EmployeeViewBtn_Click(sender As Object, e As EventArgs) Handles EmployeeViewBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeDGV.Visible = True

            .EmployeeIDLabel.Visible = False
            .EmployeeIDComboBox.Visible = False
            .EmployeeLNameLabel.Visible = False
            .EmployeeLNameTextBox.Visible = False
            .EmployeeFNameLabel.Visible = False
            .EmployeeFNameTextBox.Visible = False
            .EmployeeMinitLabel.Visible = False
            .EmployeeMinitTextBox.Visible = False
            .EmployeeSexLabel.Visible = False
            .EmployeeMaleRadioButton.Visible = False
            .EmployeeFemaleRadioButton.Visible = False
            .EmployeeAddressLabel.Visible = False
            .EmployeeAddressTextBox.Visible = False
            .EmployeePhoneNumberLabel.Visible = False
            .EmployeeNumberTextBox.Visible = False

            .EmployeeAddButton.Visible = False
            .EmployeeUpdateButton.Visible = False
            .EmployeeDeleteButton.Visible = False
            .EmployeeClearButton.Visible = False

            .DisplayEmployeeTable()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeAddBtn_Click(sender As Object, e As EventArgs) Handles EmployeeAddBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeDGV.Visible = False

            .EmployeeIDLabel.Visible = True
            .EmployeeIDComboBox.Visible = True
            .EmployeeLNameLabel.Visible = True
            .EmployeeLNameTextBox.Visible = True
            .EmployeeFNameLabel.Visible = True
            .EmployeeFNameTextBox.Visible = True
            .EmployeeMinitLabel.Visible = True
            .EmployeeMinitTextBox.Visible = True
            .EmployeeSexLabel.Visible = True
            .EmployeeMaleRadioButton.Visible = True
            .EmployeeFemaleRadioButton.Visible = True
            .EmployeeAddressLabel.Visible = True
            .EmployeeAddressTextBox.Visible = True
            .EmployeePhoneNumberLabel.Visible = True
            .EmployeeNumberTextBox.Visible = True

            .EmployeeAddButton.Visible = True
            .EmployeeUpdateButton.Visible = False
            .EmployeeDeleteButton.Visible = False
            .EmployeeClearButton.Visible = True

            .EmployeeIDComboBox.Enabled = False
            .EmployeeAddButton.Enabled = False

            .EmployeeLNameTextBox.Enabled = True
            .EmployeeFNameTextBox.Enabled = True
            .EmployeeMinitTextBox.Enabled = True
            .EmployeeMaleRadioButton.Enabled = True
            .EmployeeFemaleRadioButton.Enabled = True
            .EmployeeAddressTextBox.Enabled = True
            .EmployeeNumberTextBox.Enabled = True

            .EmployeeIDComboBox.DataSource = Nothing
            .EmployeeIDComboBox.Items.Clear()

            .DisplayNextEmployeeID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeUpdateBtn_Click(sender As Object, e As EventArgs) Handles EmployeeUpdateBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeDGV.Visible = False

            .EmployeeIDLabel.Visible = True
            .EmployeeIDComboBox.Visible = True
            .EmployeeLNameLabel.Visible = True
            .EmployeeLNameTextBox.Visible = True
            .EmployeeFNameLabel.Visible = True
            .EmployeeFNameTextBox.Visible = True
            .EmployeeMinitLabel.Visible = True
            .EmployeeMinitTextBox.Visible = True
            .EmployeeSexLabel.Visible = True
            .EmployeeMaleRadioButton.Visible = True
            .EmployeeFemaleRadioButton.Visible = True
            .EmployeeAddressLabel.Visible = True
            .EmployeeAddressTextBox.Visible = True
            .EmployeePhoneNumberLabel.Visible = True
            .EmployeeNumberTextBox.Visible = True

            .EmployeeAddButton.Visible = False
            .EmployeeUpdateButton.Visible = True
            .EmployeeDeleteButton.Visible = False
            .EmployeeClearButton.Visible = True

            .EmployeeIDComboBox.Enabled = True
            .EmployeeUpdateButton.Enabled = False

            .EmployeeLNameTextBox.Enabled = True
            .EmployeeFNameTextBox.Enabled = True
            .EmployeeMinitTextBox.Enabled = True
            .EmployeeMaleRadioButton.Enabled = True
            .EmployeeFemaleRadioButton.Enabled = True
            .EmployeeAddressTextBox.Enabled = True
            .EmployeeNumberTextBox.Enabled = True

            .DisplayEmployeeID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeDeleteBtn_Click(sender As Object, e As EventArgs) Handles EmployeeDeleteBtn.Click
        With EmployeeForm
            .TopLevel = False
            ContentPanel.Controls.Add(EmployeeForm)

            .EmployeeDGV.Visible = False

            .EmployeeIDLabel.Visible = True
            .EmployeeIDComboBox.Visible = True
            .EmployeeLNameLabel.Visible = True
            .EmployeeLNameTextBox.Visible = True
            .EmployeeFNameLabel.Visible = True
            .EmployeeFNameTextBox.Visible = True
            .EmployeeMinitLabel.Visible = True
            .EmployeeMinitTextBox.Visible = True
            .EmployeeSexLabel.Visible = True
            .EmployeeMaleRadioButton.Visible = True
            .EmployeeFemaleRadioButton.Visible = True
            .EmployeeAddressLabel.Visible = True
            .EmployeeAddressTextBox.Visible = True
            .EmployeePhoneNumberLabel.Visible = True
            .EmployeeNumberTextBox.Visible = True

            .EmployeeAddButton.Visible = False
            .EmployeeUpdateButton.Visible = False
            .EmployeeDeleteButton.Visible = True
            .EmployeeClearButton.Visible = True

            .EmployeeIDComboBox.Enabled = True
            .EmployeeDeleteButton.Enabled = False

            .EmployeeLNameTextBox.Enabled = False
            .EmployeeFNameTextBox.Enabled = False
            .EmployeeMinitTextBox.Enabled = False
            .EmployeeMaleRadioButton.Enabled = False
            .EmployeeFemaleRadioButton.Enabled = False
            .EmployeeAddressTextBox.Enabled = False
            .EmployeeNumberTextBox.Enabled = False

            .DisplayEmployeeID()
            .ClearTextboxes()
            .BringToFront()
            .Show()
        End With
    End Sub

    
End Class