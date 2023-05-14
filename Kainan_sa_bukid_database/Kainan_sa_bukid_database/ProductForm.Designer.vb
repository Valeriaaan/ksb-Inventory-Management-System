<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductTitleLabel = New System.Windows.Forms.Label()
        Me.ProductClearButton = New System.Windows.Forms.Button()
        Me.ProductIDLabel = New System.Windows.Forms.Label()
        Me.ProductIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCostTextBox = New System.Windows.Forms.TextBox()
        Me.ProductTypeLabel = New System.Windows.Forms.Label()
        Me.ProductCostLabel = New System.Windows.Forms.Label()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.ProductAddButton = New System.Windows.Forms.Button()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductUpdateButton = New System.Windows.Forms.Button()
        Me.ProductDeleteButton = New System.Windows.Forms.Button()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.ProductIngredientNameLabel = New System.Windows.Forms.Label()
        Me.ProductIngredientFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.ProductIngredientDGV = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientName1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddProductIngredientButton = New System.Windows.Forms.Button()
        Me.SalesClearButton = New System.Windows.Forms.Button()
        Me.AddProductIngredientsPanel = New System.Windows.Forms.Panel()
        Me.ProductIngredientNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UpdateProductIngredientsButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductIngredientDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddProductIngredientsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ProductTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 51)
        Me.Panel1.TabIndex = 6
        '
        'ProductTitleLabel
        '
        Me.ProductTitleLabel.AutoSize = True
        Me.ProductTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ProductTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ProductTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.ProductTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductTitleLabel.Name = "ProductTitleLabel"
        Me.ProductTitleLabel.Size = New System.Drawing.Size(122, 37)
        Me.ProductTitleLabel.TabIndex = 14
        Me.ProductTitleLabel.Text = "Product"
        '
        'ProductClearButton
        '
        Me.ProductClearButton.Location = New System.Drawing.Point(264, 354)
        Me.ProductClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductClearButton.Name = "ProductClearButton"
        Me.ProductClearButton.Size = New System.Drawing.Size(416, 43)
        Me.ProductClearButton.TabIndex = 40
        Me.ProductClearButton.Text = "Clear"
        Me.ProductClearButton.UseVisualStyleBackColor = True
        '
        'ProductIDLabel
        '
        Me.ProductIDLabel.AutoSize = True
        Me.ProductIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductIDLabel.Location = New System.Drawing.Point(259, 91)
        Me.ProductIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductIDLabel.Name = "ProductIDLabel"
        Me.ProductIDLabel.Size = New System.Drawing.Size(105, 28)
        Me.ProductIDLabel.TabIndex = 27
        Me.ProductIDLabel.Text = "Product ID"
        '
        'ProductIDComboBox
        '
        Me.ProductIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductIDComboBox.FormattingEnabled = True
        Me.ProductIDComboBox.Location = New System.Drawing.Point(426, 83)
        Me.ProductIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductIDComboBox.Name = "ProductIDComboBox"
        Me.ProductIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.ProductIDComboBox.TabIndex = 24
        '
        'ProductTypeTextBox
        '
        Me.ProductTypeTextBox.Location = New System.Drawing.Point(426, 236)
        Me.ProductTypeTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProductTypeTextBox.Name = "ProductTypeTextBox"
        Me.ProductTypeTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ProductTypeTextBox.TabIndex = 33
        '
        'ProductCostTextBox
        '
        Me.ProductCostTextBox.Location = New System.Drawing.Point(426, 185)
        Me.ProductCostTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProductCostTextBox.Name = "ProductCostTextBox"
        Me.ProductCostTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ProductCostTextBox.TabIndex = 32
        '
        'ProductTypeLabel
        '
        Me.ProductTypeLabel.AutoSize = True
        Me.ProductTypeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductTypeLabel.Location = New System.Drawing.Point(259, 242)
        Me.ProductTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductTypeLabel.Name = "ProductTypeLabel"
        Me.ProductTypeLabel.Size = New System.Drawing.Size(53, 28)
        Me.ProductTypeLabel.TabIndex = 29
        Me.ProductTypeLabel.Text = "Type"
        '
        'ProductCostLabel
        '
        Me.ProductCostLabel.AutoSize = True
        Me.ProductCostLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductCostLabel.Location = New System.Drawing.Point(259, 191)
        Me.ProductCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductCostLabel.Name = "ProductCostLabel"
        Me.ProductCostLabel.Size = New System.Drawing.Size(51, 28)
        Me.ProductCostLabel.TabIndex = 28
        Me.ProductCostLabel.Text = "Cost"
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = True
        Me.ProductNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductNameLabel.Location = New System.Drawing.Point(259, 140)
        Me.ProductNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(64, 28)
        Me.ProductNameLabel.TabIndex = 26
        Me.ProductNameLabel.Text = "Name"
        '
        'ProductAddButton
        '
        Me.ProductAddButton.Location = New System.Drawing.Point(264, 294)
        Me.ProductAddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductAddButton.Name = "ProductAddButton"
        Me.ProductAddButton.Size = New System.Drawing.Size(416, 43)
        Me.ProductAddButton.TabIndex = 25
        Me.ProductAddButton.Text = "Add"
        Me.ProductAddButton.UseVisualStyleBackColor = True
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(426, 134)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.ProductNameTextBox.TabIndex = 23
        '
        'ProductUpdateButton
        '
        Me.ProductUpdateButton.Location = New System.Drawing.Point(264, 294)
        Me.ProductUpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductUpdateButton.Name = "ProductUpdateButton"
        Me.ProductUpdateButton.Size = New System.Drawing.Size(416, 43)
        Me.ProductUpdateButton.TabIndex = 37
        Me.ProductUpdateButton.Text = "Update"
        Me.ProductUpdateButton.UseVisualStyleBackColor = True
        '
        'ProductDeleteButton
        '
        Me.ProductDeleteButton.Location = New System.Drawing.Point(264, 294)
        Me.ProductDeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductDeleteButton.Name = "ProductDeleteButton"
        Me.ProductDeleteButton.Size = New System.Drawing.Size(416, 43)
        Me.ProductDeleteButton.TabIndex = 36
        Me.ProductDeleteButton.Text = "Delete"
        Me.ProductDeleteButton.UseVisualStyleBackColor = True
        '
        'ProductDGV
        '
        Me.ProductDGV.AllowUserToAddRows = False
        Me.ProductDGV.AllowUserToDeleteRows = False
        Me.ProductDGV.AllowUserToResizeColumns = False
        Me.ProductDGV.AllowUserToResizeRows = False
        Me.ProductDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.Location = New System.Drawing.Point(13, 59)
        Me.ProductDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.ReadOnly = True
        Me.ProductDGV.RowHeadersWidth = 21
        Me.ProductDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductDGV.RowTemplate.Height = 24
        Me.ProductDGV.Size = New System.Drawing.Size(925, 492)
        Me.ProductDGV.TabIndex = 39
        '
        'ProductIngredientNameLabel
        '
        Me.ProductIngredientNameLabel.AutoSize = True
        Me.ProductIngredientNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ProductIngredientNameLabel.Location = New System.Drawing.Point(13, 27)
        Me.ProductIngredientNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProductIngredientNameLabel.Name = "ProductIngredientNameLabel"
        Me.ProductIngredientNameLabel.Size = New System.Drawing.Size(138, 28)
        Me.ProductIngredientNameLabel.TabIndex = 82
        Me.ProductIngredientNameLabel.Text = "Product Name"
        '
        'ProductIngredientFLP
        '
        Me.ProductIngredientFLP.Location = New System.Drawing.Point(18, 151)
        Me.ProductIngredientFLP.Name = "ProductIngredientFLP"
        Me.ProductIngredientFLP.Size = New System.Drawing.Size(410, 341)
        Me.ProductIngredientFLP.TabIndex = 86
        '
        'ProductIngredientDGV
        '
        Me.ProductIngredientDGV.AllowUserToAddRows = False
        Me.ProductIngredientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductIngredientDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.IngredientID1, Me.IngredientName1, Me.Quantity})
        Me.ProductIngredientDGV.Location = New System.Drawing.Point(473, 21)
        Me.ProductIngredientDGV.Name = "ProductIngredientDGV"
        Me.ProductIngredientDGV.ReadOnly = True
        Me.ProductIngredientDGV.RowHeadersVisible = False
        Me.ProductIngredientDGV.RowTemplate.Height = 24
        Me.ProductIngredientDGV.Size = New System.Drawing.Size(465, 407)
        Me.ProductIngredientDGV.TabIndex = 87
        '
        'Column3
        '
        Me.Column3.HeaderText = "#"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 30
        '
        'IngredientID1
        '
        Me.IngredientID1.HeaderText = "Ingredient ID"
        Me.IngredientID1.Name = "IngredientID1"
        Me.IngredientID1.ReadOnly = True
        Me.IngredientID1.Visible = False
        Me.IngredientID1.Width = 10
        '
        'IngredientName1
        '
        Me.IngredientName1.HeaderText = "Ingredient Name"
        Me.IngredientName1.Name = "IngredientName1"
        Me.IngredientName1.ReadOnly = True
        Me.IngredientName1.Width = 250
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 200
        '
        'AddProductIngredientButton
        '
        Me.AddProductIngredientButton.Location = New System.Drawing.Point(784, 449)
        Me.AddProductIngredientButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddProductIngredientButton.Name = "AddProductIngredientButton"
        Me.AddProductIngredientButton.Size = New System.Drawing.Size(154, 43)
        Me.AddProductIngredientButton.TabIndex = 88
        Me.AddProductIngredientButton.Text = "Finish"
        Me.AddProductIngredientButton.UseVisualStyleBackColor = True
        '
        'SalesClearButton
        '
        Me.SalesClearButton.Location = New System.Drawing.Point(622, 449)
        Me.SalesClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SalesClearButton.Name = "SalesClearButton"
        Me.SalesClearButton.Size = New System.Drawing.Size(154, 43)
        Me.SalesClearButton.TabIndex = 89
        Me.SalesClearButton.Text = "Clear"
        Me.SalesClearButton.UseVisualStyleBackColor = True
        '
        'AddProductIngredientsPanel
        '
        Me.AddProductIngredientsPanel.Controls.Add(Me.ProductIngredientNameComboBox)
        Me.AddProductIngredientsPanel.Controls.Add(Me.Label1)
        Me.AddProductIngredientsPanel.Controls.Add(Me.SalesClearButton)
        Me.AddProductIngredientsPanel.Controls.Add(Me.AddProductIngredientButton)
        Me.AddProductIngredientsPanel.Controls.Add(Me.ProductIngredientDGV)
        Me.AddProductIngredientsPanel.Controls.Add(Me.ProductIngredientFLP)
        Me.AddProductIngredientsPanel.Controls.Add(Me.ProductIngredientNameLabel)
        Me.AddProductIngredientsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddProductIngredientsPanel.Location = New System.Drawing.Point(0, 51)
        Me.AddProductIngredientsPanel.Name = "AddProductIngredientsPanel"
        Me.AddProductIngredientsPanel.Size = New System.Drawing.Size(951, 513)
        Me.AddProductIngredientsPanel.TabIndex = 41
        '
        'ProductIngredientNameComboBox
        '
        Me.ProductIngredientNameComboBox.FormattingEnabled = True
        Me.ProductIngredientNameComboBox.Location = New System.Drawing.Point(174, 19)
        Me.ProductIngredientNameComboBox.Name = "ProductIngredientNameComboBox"
        Me.ProductIngredientNameComboBox.Size = New System.Drawing.Size(254, 36)
        Me.ProductIngredientNameComboBox.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 65)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Choose the ingredients that that belongs to this product:"
        '
        'UpdateProductIngredientsButton
        '
        Me.UpdateProductIngredientsButton.Location = New System.Drawing.Point(267, 414)
        Me.UpdateProductIngredientsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateProductIngredientsButton.Name = "UpdateProductIngredientsButton"
        Me.UpdateProductIngredientsButton.Size = New System.Drawing.Size(416, 43)
        Me.UpdateProductIngredientsButton.TabIndex = 42
        Me.UpdateProductIngredientsButton.Text = "Update Product Ingredients"
        Me.UpdateProductIngredientsButton.UseVisualStyleBackColor = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.AddProductIngredientsPanel)
        Me.Controls.Add(Me.UpdateProductIngredientsButton)
        Me.Controls.Add(Me.ProductClearButton)
        Me.Controls.Add(Me.ProductIDLabel)
        Me.Controls.Add(Me.ProductIDComboBox)
        Me.Controls.Add(Me.ProductTypeTextBox)
        Me.Controls.Add(Me.ProductCostTextBox)
        Me.Controls.Add(Me.ProductTypeLabel)
        Me.Controls.Add(Me.ProductCostLabel)
        Me.Controls.Add(Me.ProductNameLabel)
        Me.Controls.Add(Me.ProductAddButton)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(Me.ProductUpdateButton)
        Me.Controls.Add(Me.ProductDeleteButton)
        Me.Controls.Add(Me.ProductDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ProductForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductIngredientDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddProductIngredientsPanel.ResumeLayout(False)
        Me.AddProductIngredientsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProductTitleLabel As System.Windows.Forms.Label
    Friend WithEvents ProductClearButton As System.Windows.Forms.Button
    Friend WithEvents ProductIDLabel As System.Windows.Forms.Label
    Friend WithEvents ProductIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductTypeLabel As System.Windows.Forms.Label
    Friend WithEvents ProductCostLabel As System.Windows.Forms.Label
    Friend WithEvents ProductNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProductAddButton As System.Windows.Forms.Button
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductUpdateButton As System.Windows.Forms.Button
    Friend WithEvents ProductDeleteButton As System.Windows.Forms.Button
    Friend WithEvents ProductDGV As System.Windows.Forms.DataGridView
    Friend WithEvents ProductIngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProductIngredientFLP As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ProductIngredientDGV As System.Windows.Forms.DataGridView
    Friend WithEvents AddProductIngredientButton As System.Windows.Forms.Button
    Friend WithEvents SalesClearButton As System.Windows.Forms.Button
    Friend WithEvents AddProductIngredientsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredientName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdateProductIngredientsButton As System.Windows.Forms.Button
    Friend WithEvents ProductIngredientNameComboBox As System.Windows.Forms.ComboBox
End Class
