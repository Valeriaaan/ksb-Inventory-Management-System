<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestockForm
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
        Me.RestockDatePickerLabel = New System.Windows.Forms.Label()
        Me.RestockIngredientIDLabel = New System.Windows.Forms.Label()
        Me.RestockIngredientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.RestockQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.RestockEmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.RestockEmployeeNameLabel = New System.Windows.Forms.Label()
        Me.RestockEmployeeIDLabel = New System.Windows.Forms.Label()
        Me.RestockIngredientNameLabel = New System.Windows.Forms.Label()
        Me.RestockIngredientNameTextBox = New System.Windows.Forms.TextBox()
        Me.RestockAddStockButton = New System.Windows.Forms.Button()
        Me.RestockCostTextBox = New System.Windows.Forms.TextBox()
        Me.RestockCostLabel = New System.Windows.Forms.Label()
        Me.RestockDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.RestockQuantityLabel = New System.Windows.Forms.Label()
        Me.RestockEmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.TabIndex = 8
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
        Me.IngredientTitleLabel.Size = New System.Drawing.Size(120, 37)
        Me.IngredientTitleLabel.TabIndex = 14
        Me.IngredientTitleLabel.Text = "Restock"
        '
        'RestockDatePickerLabel
        '
        Me.RestockDatePickerLabel.AutoSize = True
        Me.RestockDatePickerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RestockDatePickerLabel.Location = New System.Drawing.Point(259, 294)
        Me.RestockDatePickerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RestockDatePickerLabel.Name = "RestockDatePickerLabel"
        Me.RestockDatePickerLabel.Size = New System.Drawing.Size(53, 28)
        Me.RestockDatePickerLabel.TabIndex = 73
        Me.RestockDatePickerLabel.Text = "Date"
        '
        'RestockIngredientIDLabel
        '
        Me.RestockIngredientIDLabel.AutoSize = True
        Me.RestockIngredientIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RestockIngredientIDLabel.Location = New System.Drawing.Point(259, 92)
        Me.RestockIngredientIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RestockIngredientIDLabel.Name = "RestockIngredientIDLabel"
        Me.RestockIngredientIDLabel.Size = New System.Drawing.Size(126, 28)
        Me.RestockIngredientIDLabel.TabIndex = 66
        Me.RestockIngredientIDLabel.Text = "Ingredient ID"
        '
        'RestockIngredientIDComboBox
        '
        Me.RestockIngredientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RestockIngredientIDComboBox.FormattingEnabled = True
        Me.RestockIngredientIDComboBox.Location = New System.Drawing.Point(426, 84)
        Me.RestockIngredientIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RestockIngredientIDComboBox.Name = "RestockIngredientIDComboBox"
        Me.RestockIngredientIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.RestockIngredientIDComboBox.TabIndex = 64
        '
        'RestockQuantityTextBox
        '
        Me.RestockQuantityTextBox.Location = New System.Drawing.Point(426, 339)
        Me.RestockQuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RestockQuantityTextBox.Name = "RestockQuantityTextBox"
        Me.RestockQuantityTextBox.Size = New System.Drawing.Size(254, 34)
        Me.RestockQuantityTextBox.TabIndex = 71
        '
        'RestockEmployeeNameTextBox
        '
        Me.RestockEmployeeNameTextBox.Enabled = False
        Me.RestockEmployeeNameTextBox.Location = New System.Drawing.Point(426, 237)
        Me.RestockEmployeeNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RestockEmployeeNameTextBox.Name = "RestockEmployeeNameTextBox"
        Me.RestockEmployeeNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.RestockEmployeeNameTextBox.TabIndex = 70
        '
        'RestockEmployeeNameLabel
        '
        Me.RestockEmployeeNameLabel.AutoSize = True
        Me.RestockEmployeeNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RestockEmployeeNameLabel.Location = New System.Drawing.Point(259, 243)
        Me.RestockEmployeeNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RestockEmployeeNameLabel.Name = "RestockEmployeeNameLabel"
        Me.RestockEmployeeNameLabel.Size = New System.Drawing.Size(155, 28)
        Me.RestockEmployeeNameLabel.TabIndex = 68
        Me.RestockEmployeeNameLabel.Text = "Employee Name"
        '
        'RestockEmployeeIDLabel
        '
        Me.RestockEmployeeIDLabel.AutoSize = True
        Me.RestockEmployeeIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RestockEmployeeIDLabel.Location = New System.Drawing.Point(259, 192)
        Me.RestockEmployeeIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RestockEmployeeIDLabel.Name = "RestockEmployeeIDLabel"
        Me.RestockEmployeeIDLabel.Size = New System.Drawing.Size(122, 28)
        Me.RestockEmployeeIDLabel.TabIndex = 67
        Me.RestockEmployeeIDLabel.Text = "Employee ID"
        '
        'RestockIngredientNameLabel
        '
        Me.RestockIngredientNameLabel.AutoSize = True
        Me.RestockIngredientNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RestockIngredientNameLabel.Location = New System.Drawing.Point(259, 141)
        Me.RestockIngredientNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RestockIngredientNameLabel.Name = "RestockIngredientNameLabel"
        Me.RestockIngredientNameLabel.Size = New System.Drawing.Size(159, 28)
        Me.RestockIngredientNameLabel.TabIndex = 65
        Me.RestockIngredientNameLabel.Text = "Ingredient Name"
        '
        'RestockIngredientNameTextBox
        '
        Me.RestockIngredientNameTextBox.Enabled = False
        Me.RestockIngredientNameTextBox.Location = New System.Drawing.Point(426, 135)
        Me.RestockIngredientNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RestockIngredientNameTextBox.Name = "RestockIngredientNameTextBox"
        Me.RestockIngredientNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.RestockIngredientNameTextBox.TabIndex = 63
        '
        'RestockAddStockButton
        '
        Me.RestockAddStockButton.Location = New System.Drawing.Point(264, 449)
        Me.RestockAddStockButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RestockAddStockButton.Name = "RestockAddStockButton"
        Me.RestockAddStockButton.Size = New System.Drawing.Size(416, 43)
        Me.RestockAddStockButton.TabIndex = 72
        Me.RestockAddStockButton.Text = "Restock"
        Me.RestockAddStockButton.UseVisualStyleBackColor = True
        '
        'RestockCostTextBox
        '
        Me.RestockCostTextBox.Location = New System.Drawing.Point(426, 390)
        Me.RestockCostTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RestockCostTextBox.Name = "RestockCostTextBox"
        Me.RestockCostTextBox.Size = New System.Drawing.Size(254, 34)
        Me.RestockCostTextBox.TabIndex = 74
        '
        'RestockCostLabel
        '
        Me.RestockCostLabel.AutoSize = True
        Me.RestockCostLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RestockCostLabel.Location = New System.Drawing.Point(259, 396)
        Me.RestockCostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RestockCostLabel.Name = "RestockCostLabel"
        Me.RestockCostLabel.Size = New System.Drawing.Size(51, 28)
        Me.RestockCostLabel.TabIndex = 75
        Me.RestockCostLabel.Text = "Cost"
        '
        'RestockDatePicker
        '
        Me.RestockDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RestockDatePicker.Location = New System.Drawing.Point(426, 288)
        Me.RestockDatePicker.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.RestockDatePicker.Name = "RestockDatePicker"
        Me.RestockDatePicker.Size = New System.Drawing.Size(254, 34)
        Me.RestockDatePicker.TabIndex = 76
        Me.RestockDatePicker.Value = New Date(2023, 5, 4, 0, 0, 0, 0)
        '
        'RestockQuantityLabel
        '
        Me.RestockQuantityLabel.AutoSize = True
        Me.RestockQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.RestockQuantityLabel.Location = New System.Drawing.Point(259, 345)
        Me.RestockQuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RestockQuantityLabel.Name = "RestockQuantityLabel"
        Me.RestockQuantityLabel.Size = New System.Drawing.Size(88, 28)
        Me.RestockQuantityLabel.TabIndex = 77
        Me.RestockQuantityLabel.Text = "Quantity"
        '
        'RestockEmployeeIDComboBox
        '
        Me.RestockEmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RestockEmployeeIDComboBox.FormattingEnabled = True
        Me.RestockEmployeeIDComboBox.Location = New System.Drawing.Point(426, 184)
        Me.RestockEmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RestockEmployeeIDComboBox.Name = "RestockEmployeeIDComboBox"
        Me.RestockEmployeeIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.RestockEmployeeIDComboBox.TabIndex = 78
        '
        'RestockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.RestockEmployeeIDComboBox)
        Me.Controls.Add(Me.RestockQuantityLabel)
        Me.Controls.Add(Me.RestockDatePicker)
        Me.Controls.Add(Me.RestockCostLabel)
        Me.Controls.Add(Me.RestockCostTextBox)
        Me.Controls.Add(Me.RestockDatePickerLabel)
        Me.Controls.Add(Me.RestockIngredientIDLabel)
        Me.Controls.Add(Me.RestockIngredientIDComboBox)
        Me.Controls.Add(Me.RestockQuantityTextBox)
        Me.Controls.Add(Me.RestockEmployeeNameTextBox)
        Me.Controls.Add(Me.RestockEmployeeNameLabel)
        Me.Controls.Add(Me.RestockEmployeeIDLabel)
        Me.Controls.Add(Me.RestockIngredientNameLabel)
        Me.Controls.Add(Me.RestockIngredientNameTextBox)
        Me.Controls.Add(Me.RestockAddStockButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RestockForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IngredientTitleLabel As System.Windows.Forms.Label
    Friend WithEvents RestockDatePickerLabel As System.Windows.Forms.Label
    Friend WithEvents RestockIngredientIDLabel As System.Windows.Forms.Label
    Friend WithEvents RestockIngredientIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RestockQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RestockEmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RestockEmployeeNameLabel As System.Windows.Forms.Label
    Friend WithEvents RestockEmployeeIDLabel As System.Windows.Forms.Label
    Friend WithEvents RestockIngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents RestockIngredientNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RestockAddStockButton As System.Windows.Forms.Button
    Friend WithEvents RestockCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RestockCostLabel As System.Windows.Forms.Label
    Friend WithEvents RestockDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RestockQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents RestockEmployeeIDComboBox As System.Windows.Forms.ComboBox
End Class
