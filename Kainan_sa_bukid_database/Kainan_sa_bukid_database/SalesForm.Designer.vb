<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IngredientTitleLabel = New System.Windows.Forms.Label()
        Me.SalesPaymentMethodLabel = New System.Windows.Forms.Label()
        Me.SalesCustomerNameLabel = New System.Windows.Forms.Label()
        Me.SalesCustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.SalesGcashRadioButton = New System.Windows.Forms.RadioButton()
        Me.SalesCashRadioButton = New System.Windows.Forms.RadioButton()
        Me.SalesFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.SalesDGV = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBuyButton = New System.Windows.Forms.Button()
        Me.SalesClearButton = New System.Windows.Forms.Button()
        Me.SalesDateLabel = New System.Windows.Forms.Label()
        Me.SalesDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.SalesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.IngredientTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 51)
        Me.Panel1.TabIndex = 7
        '
        'IngredientTitleLabel
        '
        Me.IngredientTitleLabel.AutoSize = True
        Me.IngredientTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.IngredientTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.IngredientTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.IngredientTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientTitleLabel.Name = "IngredientTitleLabel"
        Me.IngredientTitleLabel.Size = New System.Drawing.Size(83, 37)
        Me.IngredientTitleLabel.TabIndex = 14
        Me.IngredientTitleLabel.Text = "Sales"
        '
        'SalesPaymentMethodLabel
        '
        Me.SalesPaymentMethodLabel.AutoSize = True
        Me.SalesPaymentMethodLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SalesPaymentMethodLabel.Location = New System.Drawing.Point(13, 126)
        Me.SalesPaymentMethodLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SalesPaymentMethodLabel.Name = "SalesPaymentMethodLabel"
        Me.SalesPaymentMethodLabel.Size = New System.Drawing.Size(162, 28)
        Me.SalesPaymentMethodLabel.TabIndex = 47
        Me.SalesPaymentMethodLabel.Text = "Payment Method"
        '
        'SalesCustomerNameLabel
        '
        Me.SalesCustomerNameLabel.AutoSize = True
        Me.SalesCustomerNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SalesCustomerNameLabel.Location = New System.Drawing.Point(13, 77)
        Me.SalesCustomerNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SalesCustomerNameLabel.Name = "SalesCustomerNameLabel"
        Me.SalesCustomerNameLabel.Size = New System.Drawing.Size(153, 28)
        Me.SalesCustomerNameLabel.TabIndex = 45
        Me.SalesCustomerNameLabel.Text = "Customer Name"
        '
        'SalesCustomerNameTextBox
        '
        Me.SalesCustomerNameTextBox.Location = New System.Drawing.Point(174, 71)
        Me.SalesCustomerNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SalesCustomerNameTextBox.Name = "SalesCustomerNameTextBox"
        Me.SalesCustomerNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SalesCustomerNameTextBox.TabIndex = 42
        '
        'SalesGcashRadioButton
        '
        Me.SalesGcashRadioButton.AutoSize = True
        Me.SalesGcashRadioButton.Location = New System.Drawing.Point(303, 126)
        Me.SalesGcashRadioButton.Name = "SalesGcashRadioButton"
        Me.SalesGcashRadioButton.Size = New System.Drawing.Size(85, 32)
        Me.SalesGcashRadioButton.TabIndex = 69
        Me.SalesGcashRadioButton.TabStop = True
        Me.SalesGcashRadioButton.Text = "Gcash"
        Me.SalesGcashRadioButton.UseVisualStyleBackColor = True
        '
        'SalesCashRadioButton
        '
        Me.SalesCashRadioButton.AutoSize = True
        Me.SalesCashRadioButton.Location = New System.Drawing.Point(202, 124)
        Me.SalesCashRadioButton.Name = "SalesCashRadioButton"
        Me.SalesCashRadioButton.Size = New System.Drawing.Size(74, 32)
        Me.SalesCashRadioButton.TabIndex = 70
        Me.SalesCashRadioButton.TabStop = True
        Me.SalesCashRadioButton.Text = "Cash"
        Me.SalesCashRadioButton.UseVisualStyleBackColor = True
        '
        'SalesFLP
        '
        Me.SalesFLP.Location = New System.Drawing.Point(18, 233)
        Me.SalesFLP.Name = "SalesFLP"
        Me.SalesFLP.Size = New System.Drawing.Size(410, 306)
        Me.SalesFLP.TabIndex = 72
        '
        'SalesDGV
        '
        Me.SalesDGV.AllowUserToAddRows = False
        Me.SalesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.ProductID, Me.ProductName1, Me.Cost, Me.Quantity, Me.Total})
        Me.SalesDGV.Location = New System.Drawing.Point(473, 71)
        Me.SalesDGV.Name = "SalesDGV"
        Me.SalesDGV.ReadOnly = True
        Me.SalesDGV.RowHeadersVisible = False
        Me.SalesDGV.RowTemplate.Height = 24
        Me.SalesDGV.Size = New System.Drawing.Size(465, 407)
        Me.SalesDGV.TabIndex = 73
        '
        'Column3
        '
        Me.Column3.HeaderText = "#"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 30
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "Product ID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        Me.ProductID.Visible = False
        Me.ProductID.Width = 10
        '
        'ProductName1
        '
        Me.ProductName1.HeaderText = "Product Name"
        Me.ProductName1.Name = "ProductName1"
        Me.ProductName1.ReadOnly = True
        Me.ProductName1.Width = 170
        '
        'Cost
        '
        Me.Cost.HeaderText = "Cost"
        Me.Cost.Name = "Cost"
        Me.Cost.ReadOnly = True
        Me.Cost.Width = 92
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 93
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 92
        '
        'SalesBuyButton
        '
        Me.SalesBuyButton.Location = New System.Drawing.Point(784, 499)
        Me.SalesBuyButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SalesBuyButton.Name = "SalesBuyButton"
        Me.SalesBuyButton.Size = New System.Drawing.Size(154, 43)
        Me.SalesBuyButton.TabIndex = 74
        Me.SalesBuyButton.Text = "Buy"
        Me.SalesBuyButton.UseVisualStyleBackColor = True
        '
        'SalesClearButton
        '
        Me.SalesClearButton.Location = New System.Drawing.Point(622, 499)
        Me.SalesClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SalesClearButton.Name = "SalesClearButton"
        Me.SalesClearButton.Size = New System.Drawing.Size(154, 43)
        Me.SalesClearButton.TabIndex = 75
        Me.SalesClearButton.Text = "Clear"
        Me.SalesClearButton.UseVisualStyleBackColor = True
        '
        'SalesDateLabel
        '
        Me.SalesDateLabel.AutoSize = True
        Me.SalesDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SalesDateLabel.Location = New System.Drawing.Point(13, 176)
        Me.SalesDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SalesDateLabel.Name = "SalesDateLabel"
        Me.SalesDateLabel.Size = New System.Drawing.Size(53, 28)
        Me.SalesDateLabel.TabIndex = 79
        Me.SalesDateLabel.Text = "Date"
        '
        'SalesDatePicker
        '
        Me.SalesDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SalesDatePicker.Location = New System.Drawing.Point(174, 171)
        Me.SalesDatePicker.Name = "SalesDatePicker"
        Me.SalesDatePicker.Size = New System.Drawing.Size(254, 34)
        Me.SalesDatePicker.TabIndex = 80
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.SalesDatePicker)
        Me.Controls.Add(Me.SalesDateLabel)
        Me.Controls.Add(Me.SalesClearButton)
        Me.Controls.Add(Me.SalesBuyButton)
        Me.Controls.Add(Me.SalesDGV)
        Me.Controls.Add(Me.SalesFLP)
        Me.Controls.Add(Me.SalesCashRadioButton)
        Me.Controls.Add(Me.SalesGcashRadioButton)
        Me.Controls.Add(Me.SalesPaymentMethodLabel)
        Me.Controls.Add(Me.SalesCustomerNameLabel)
        Me.Controls.Add(Me.SalesCustomerNameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SalesForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SalesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IngredientTitleLabel As System.Windows.Forms.Label
    Friend WithEvents SalesPaymentMethodLabel As System.Windows.Forms.Label
    Friend WithEvents SalesCustomerNameLabel As System.Windows.Forms.Label
    Friend WithEvents SalesCustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesGcashRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SalesCashRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SalesFLP As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SalesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents SalesBuyButton As System.Windows.Forms.Button
    Friend WithEvents SalesClearButton As System.Windows.Forms.Button
    Friend WithEvents SalesDateLabel As System.Windows.Forms.Label
    Friend WithEvents SalesDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
