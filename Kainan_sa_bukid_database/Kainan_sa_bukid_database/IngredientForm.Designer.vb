<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngredientForm
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
        Me.IngredientTitleLabel = New System.Windows.Forms.Label()
        Me.IngredientClearButton = New System.Windows.Forms.Button()
        Me.IngredientIDLabel = New System.Windows.Forms.Label()
        Me.IngredientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.IngredientSupplierNameLabel = New System.Windows.Forms.Label()
        Me.IngredientExpDateLabel = New System.Windows.Forms.Label()
        Me.IngredientNameLabel = New System.Windows.Forms.Label()
        Me.IngredientAddButton = New System.Windows.Forms.Button()
        Me.IngredientNameTextBox = New System.Windows.Forms.TextBox()
        Me.IngredientUpdateButton = New System.Windows.Forms.Button()
        Me.IngredientDeleteButton = New System.Windows.Forms.Button()
        Me.IngredientDGV = New System.Windows.Forms.DataGridView()
        Me.IngredientSupplierNameComboBox = New System.Windows.Forms.ComboBox()
        Me.IngredientExpDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.IngredientQuantityLabel = New System.Windows.Forms.Label()
        Me.IngredientQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.IngredientDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 6
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
        Me.IngredientTitleLabel.Size = New System.Drawing.Size(155, 37)
        Me.IngredientTitleLabel.TabIndex = 14
        Me.IngredientTitleLabel.Text = "Ingredient"
        '
        'IngredientClearButton
        '
        Me.IngredientClearButton.Location = New System.Drawing.Point(264, 350)
        Me.IngredientClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientClearButton.Name = "IngredientClearButton"
        Me.IngredientClearButton.Size = New System.Drawing.Size(416, 43)
        Me.IngredientClearButton.TabIndex = 39
        Me.IngredientClearButton.Text = "Clear"
        Me.IngredientClearButton.UseVisualStyleBackColor = True
        '
        'IngredientIDLabel
        '
        Me.IngredientIDLabel.AutoSize = True
        Me.IngredientIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientIDLabel.Location = New System.Drawing.Point(259, 91)
        Me.IngredientIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientIDLabel.Name = "IngredientIDLabel"
        Me.IngredientIDLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IngredientIDLabel.Size = New System.Drawing.Size(126, 28)
        Me.IngredientIDLabel.TabIndex = 27
        Me.IngredientIDLabel.Text = "Ingredient ID"
        '
        'IngredientIDComboBox
        '
        Me.IngredientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IngredientIDComboBox.FormattingEnabled = True
        Me.IngredientIDComboBox.Location = New System.Drawing.Point(426, 83)
        Me.IngredientIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientIDComboBox.Name = "IngredientIDComboBox"
        Me.IngredientIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.IngredientIDComboBox.TabIndex = 24
        '
        'IngredientSupplierNameLabel
        '
        Me.IngredientSupplierNameLabel.AutoSize = True
        Me.IngredientSupplierNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientSupplierNameLabel.Location = New System.Drawing.Point(259, 242)
        Me.IngredientSupplierNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientSupplierNameLabel.Name = "IngredientSupplierNameLabel"
        Me.IngredientSupplierNameLabel.Size = New System.Drawing.Size(142, 28)
        Me.IngredientSupplierNameLabel.TabIndex = 30
        Me.IngredientSupplierNameLabel.Text = "Supplier Name"
        '
        'IngredientExpDateLabel
        '
        Me.IngredientExpDateLabel.AutoSize = True
        Me.IngredientExpDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientExpDateLabel.Location = New System.Drawing.Point(259, 191)
        Me.IngredientExpDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientExpDateLabel.Name = "IngredientExpDateLabel"
        Me.IngredientExpDateLabel.Size = New System.Drawing.Size(146, 28)
        Me.IngredientExpDateLabel.TabIndex = 28
        Me.IngredientExpDateLabel.Text = "Expiration Date"
        '
        'IngredientNameLabel
        '
        Me.IngredientNameLabel.AutoSize = True
        Me.IngredientNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientNameLabel.Location = New System.Drawing.Point(259, 140)
        Me.IngredientNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientNameLabel.Name = "IngredientNameLabel"
        Me.IngredientNameLabel.Size = New System.Drawing.Size(64, 28)
        Me.IngredientNameLabel.TabIndex = 26
        Me.IngredientNameLabel.Text = "Name"
        '
        'IngredientAddButton
        '
        Me.IngredientAddButton.Location = New System.Drawing.Point(264, 290)
        Me.IngredientAddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientAddButton.Name = "IngredientAddButton"
        Me.IngredientAddButton.Size = New System.Drawing.Size(416, 43)
        Me.IngredientAddButton.TabIndex = 25
        Me.IngredientAddButton.Text = "Add"
        Me.IngredientAddButton.UseVisualStyleBackColor = True
        '
        'IngredientNameTextBox
        '
        Me.IngredientNameTextBox.Location = New System.Drawing.Point(426, 134)
        Me.IngredientNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.IngredientNameTextBox.Name = "IngredientNameTextBox"
        Me.IngredientNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.IngredientNameTextBox.TabIndex = 23
        '
        'IngredientUpdateButton
        '
        Me.IngredientUpdateButton.Location = New System.Drawing.Point(264, 290)
        Me.IngredientUpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientUpdateButton.Name = "IngredientUpdateButton"
        Me.IngredientUpdateButton.Size = New System.Drawing.Size(416, 43)
        Me.IngredientUpdateButton.TabIndex = 37
        Me.IngredientUpdateButton.Text = "Update"
        Me.IngredientUpdateButton.UseVisualStyleBackColor = True
        '
        'IngredientDeleteButton
        '
        Me.IngredientDeleteButton.Location = New System.Drawing.Point(264, 290)
        Me.IngredientDeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientDeleteButton.Name = "IngredientDeleteButton"
        Me.IngredientDeleteButton.Size = New System.Drawing.Size(416, 43)
        Me.IngredientDeleteButton.TabIndex = 36
        Me.IngredientDeleteButton.Text = "Delete"
        Me.IngredientDeleteButton.UseVisualStyleBackColor = True
        '
        'IngredientDGV
        '
        Me.IngredientDGV.AllowUserToAddRows = False
        Me.IngredientDGV.AllowUserToDeleteRows = False
        Me.IngredientDGV.AllowUserToResizeColumns = False
        Me.IngredientDGV.AllowUserToResizeRows = False
        Me.IngredientDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IngredientDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.IngredientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngredientDGV.Location = New System.Drawing.Point(13, 59)
        Me.IngredientDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientDGV.Name = "IngredientDGV"
        Me.IngredientDGV.ReadOnly = True
        Me.IngredientDGV.RowHeadersWidth = 21
        Me.IngredientDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IngredientDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.IngredientDGV.RowTemplate.Height = 24
        Me.IngredientDGV.Size = New System.Drawing.Size(925, 492)
        Me.IngredientDGV.TabIndex = 38
        '
        'IngredientSupplierNameComboBox
        '
        Me.IngredientSupplierNameComboBox.FormattingEnabled = True
        Me.IngredientSupplierNameComboBox.Location = New System.Drawing.Point(426, 234)
        Me.IngredientSupplierNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientSupplierNameComboBox.Name = "IngredientSupplierNameComboBox"
        Me.IngredientSupplierNameComboBox.Size = New System.Drawing.Size(254, 36)
        Me.IngredientSupplierNameComboBox.TabIndex = 40
        '
        'IngredientExpDatePicker
        '
        Me.IngredientExpDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.IngredientExpDatePicker.Location = New System.Drawing.Point(426, 185)
        Me.IngredientExpDatePicker.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.IngredientExpDatePicker.Name = "IngredientExpDatePicker"
        Me.IngredientExpDatePicker.Size = New System.Drawing.Size(254, 34)
        Me.IngredientExpDatePicker.TabIndex = 41
        Me.IngredientExpDatePicker.Value = New Date(2023, 5, 4, 0, 0, 0, 0)
        '
        'IngredientQuantityLabel
        '
        Me.IngredientQuantityLabel.AutoSize = True
        Me.IngredientQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.IngredientQuantityLabel.Location = New System.Drawing.Point(259, 434)
        Me.IngredientQuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IngredientQuantityLabel.Name = "IngredientQuantityLabel"
        Me.IngredientQuantityLabel.Size = New System.Drawing.Size(88, 28)
        Me.IngredientQuantityLabel.TabIndex = 29
        Me.IngredientQuantityLabel.Text = "Quantity"
        '
        'IngredientQuantityTextBox
        '
        Me.IngredientQuantityTextBox.Location = New System.Drawing.Point(426, 428)
        Me.IngredientQuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.IngredientQuantityTextBox.Name = "IngredientQuantityTextBox"
        Me.IngredientQuantityTextBox.Size = New System.Drawing.Size(254, 34)
        Me.IngredientQuantityTextBox.TabIndex = 33
        '
        'IngredientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.IngredientExpDatePicker)
        Me.Controls.Add(Me.IngredientSupplierNameComboBox)
        Me.Controls.Add(Me.IngredientClearButton)
        Me.Controls.Add(Me.IngredientIDLabel)
        Me.Controls.Add(Me.IngredientIDComboBox)
        Me.Controls.Add(Me.IngredientQuantityTextBox)
        Me.Controls.Add(Me.IngredientSupplierNameLabel)
        Me.Controls.Add(Me.IngredientQuantityLabel)
        Me.Controls.Add(Me.IngredientExpDateLabel)
        Me.Controls.Add(Me.IngredientNameLabel)
        Me.Controls.Add(Me.IngredientAddButton)
        Me.Controls.Add(Me.IngredientNameTextBox)
        Me.Controls.Add(Me.IngredientUpdateButton)
        Me.Controls.Add(Me.IngredientDeleteButton)
        Me.Controls.Add(Me.IngredientDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "IngredientForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IngredientDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IngredientTitleLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientClearButton As System.Windows.Forms.Button
    Friend WithEvents IngredientIDLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IngredientSupplierNameLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientExpDateLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientAddButton As System.Windows.Forms.Button
    Friend WithEvents IngredientNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IngredientUpdateButton As System.Windows.Forms.Button
    Friend WithEvents IngredientDeleteButton As System.Windows.Forms.Button
    Friend WithEvents IngredientDGV As System.Windows.Forms.DataGridView
    Friend WithEvents IngredientSupplierNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IngredientExpDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IngredientQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientQuantityTextBox As System.Windows.Forms.TextBox
End Class
