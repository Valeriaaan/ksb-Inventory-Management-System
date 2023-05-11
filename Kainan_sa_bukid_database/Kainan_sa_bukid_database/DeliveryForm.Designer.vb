<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryForm
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
        Me.DeliveryQuantityLabel = New System.Windows.Forms.Label()
        Me.DeliveryIngredientIDLabel = New System.Windows.Forms.Label()
        Me.DeliveryIngredientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DeliveryQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DeliverySupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.DeliverySupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.DeliverySupplierNameLabel = New System.Windows.Forms.Label()
        Me.DeliverySupplierIDLabel = New System.Windows.Forms.Label()
        Me.DeliveryIngredientNameLabel = New System.Windows.Forms.Label()
        Me.DeliveryIngredientNameTextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryReceiveButton = New System.Windows.Forms.Button()
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
        Me.IngredientTitleLabel.Size = New System.Drawing.Size(127, 37)
        Me.IngredientTitleLabel.TabIndex = 14
        Me.IngredientTitleLabel.Text = "Delivery"
        '
        'DeliveryQuantityLabel
        '
        Me.DeliveryQuantityLabel.AutoSize = True
        Me.DeliveryQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeliveryQuantityLabel.Location = New System.Drawing.Point(259, 294)
        Me.DeliveryQuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeliveryQuantityLabel.Name = "DeliveryQuantityLabel"
        Me.DeliveryQuantityLabel.Size = New System.Drawing.Size(88, 28)
        Me.DeliveryQuantityLabel.TabIndex = 61
        Me.DeliveryQuantityLabel.Text = "Quantity"
        '
        'DeliveryIngredientIDLabel
        '
        Me.DeliveryIngredientIDLabel.AutoSize = True
        Me.DeliveryIngredientIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeliveryIngredientIDLabel.Location = New System.Drawing.Point(259, 92)
        Me.DeliveryIngredientIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeliveryIngredientIDLabel.Name = "DeliveryIngredientIDLabel"
        Me.DeliveryIngredientIDLabel.Size = New System.Drawing.Size(126, 28)
        Me.DeliveryIngredientIDLabel.TabIndex = 48
        Me.DeliveryIngredientIDLabel.Text = "Ingredient ID"
        '
        'DeliveryIngredientIDComboBox
        '
        Me.DeliveryIngredientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeliveryIngredientIDComboBox.FormattingEnabled = True
        Me.DeliveryIngredientIDComboBox.Location = New System.Drawing.Point(426, 84)
        Me.DeliveryIngredientIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DeliveryIngredientIDComboBox.Name = "DeliveryIngredientIDComboBox"
        Me.DeliveryIngredientIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.DeliveryIngredientIDComboBox.TabIndex = 45
        '
        'DeliveryQuantityTextBox
        '
        Me.DeliveryQuantityTextBox.Location = New System.Drawing.Point(426, 288)
        Me.DeliveryQuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeliveryQuantityTextBox.Name = "DeliveryQuantityTextBox"
        Me.DeliveryQuantityTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DeliveryQuantityTextBox.TabIndex = 55
        '
        'DeliverySupplierNameTextBox
        '
        Me.DeliverySupplierNameTextBox.Enabled = False
        Me.DeliverySupplierNameTextBox.Location = New System.Drawing.Point(426, 237)
        Me.DeliverySupplierNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeliverySupplierNameTextBox.Name = "DeliverySupplierNameTextBox"
        Me.DeliverySupplierNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DeliverySupplierNameTextBox.TabIndex = 54
        '
        'DeliverySupplierIDTextBox
        '
        Me.DeliverySupplierIDTextBox.Enabled = False
        Me.DeliverySupplierIDTextBox.Location = New System.Drawing.Point(426, 186)
        Me.DeliverySupplierIDTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeliverySupplierIDTextBox.Name = "DeliverySupplierIDTextBox"
        Me.DeliverySupplierIDTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DeliverySupplierIDTextBox.TabIndex = 53
        '
        'DeliverySupplierNameLabel
        '
        Me.DeliverySupplierNameLabel.AutoSize = True
        Me.DeliverySupplierNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeliverySupplierNameLabel.Location = New System.Drawing.Point(259, 243)
        Me.DeliverySupplierNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeliverySupplierNameLabel.Name = "DeliverySupplierNameLabel"
        Me.DeliverySupplierNameLabel.Size = New System.Drawing.Size(142, 28)
        Me.DeliverySupplierNameLabel.TabIndex = 50
        Me.DeliverySupplierNameLabel.Text = "Supplier Name"
        '
        'DeliverySupplierIDLabel
        '
        Me.DeliverySupplierIDLabel.AutoSize = True
        Me.DeliverySupplierIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeliverySupplierIDLabel.Location = New System.Drawing.Point(259, 192)
        Me.DeliverySupplierIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeliverySupplierIDLabel.Name = "DeliverySupplierIDLabel"
        Me.DeliverySupplierIDLabel.Size = New System.Drawing.Size(109, 28)
        Me.DeliverySupplierIDLabel.TabIndex = 49
        Me.DeliverySupplierIDLabel.Text = "Supplier ID"
        '
        'DeliveryIngredientNameLabel
        '
        Me.DeliveryIngredientNameLabel.AutoSize = True
        Me.DeliveryIngredientNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.DeliveryIngredientNameLabel.Location = New System.Drawing.Point(259, 141)
        Me.DeliveryIngredientNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DeliveryIngredientNameLabel.Name = "DeliveryIngredientNameLabel"
        Me.DeliveryIngredientNameLabel.Size = New System.Drawing.Size(159, 28)
        Me.DeliveryIngredientNameLabel.TabIndex = 47
        Me.DeliveryIngredientNameLabel.Text = "Ingredient Name"
        '
        'DeliveryIngredientNameTextBox
        '
        Me.DeliveryIngredientNameTextBox.Enabled = False
        Me.DeliveryIngredientNameTextBox.Location = New System.Drawing.Point(426, 135)
        Me.DeliveryIngredientNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DeliveryIngredientNameTextBox.Name = "DeliveryIngredientNameTextBox"
        Me.DeliveryIngredientNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DeliveryIngredientNameTextBox.TabIndex = 44
        '
        'DeliveryReceiveButton
        '
        Me.DeliveryReceiveButton.Location = New System.Drawing.Point(264, 350)
        Me.DeliveryReceiveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeliveryReceiveButton.Name = "DeliveryReceiveButton"
        Me.DeliveryReceiveButton.Size = New System.Drawing.Size(416, 43)
        Me.DeliveryReceiveButton.TabIndex = 57
        Me.DeliveryReceiveButton.Text = "Receive"
        Me.DeliveryReceiveButton.UseVisualStyleBackColor = True
        '
        'DeliveryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.DeliveryQuantityLabel)
        Me.Controls.Add(Me.DeliveryIngredientIDLabel)
        Me.Controls.Add(Me.DeliveryIngredientIDComboBox)
        Me.Controls.Add(Me.DeliveryQuantityTextBox)
        Me.Controls.Add(Me.DeliverySupplierNameTextBox)
        Me.Controls.Add(Me.DeliverySupplierIDTextBox)
        Me.Controls.Add(Me.DeliverySupplierNameLabel)
        Me.Controls.Add(Me.DeliverySupplierIDLabel)
        Me.Controls.Add(Me.DeliveryIngredientNameLabel)
        Me.Controls.Add(Me.DeliveryIngredientNameTextBox)
        Me.Controls.Add(Me.DeliveryReceiveButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DeliveryForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IngredientTitleLabel As System.Windows.Forms.Label
    Friend WithEvents DeliveryQuantityLabel As System.Windows.Forms.Label
    Friend WithEvents DeliveryIngredientIDLabel As System.Windows.Forms.Label
    Friend WithEvents DeliveryIngredientIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeliveryQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliverySupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliverySupplierIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliverySupplierNameLabel As System.Windows.Forms.Label
    Friend WithEvents DeliverySupplierIDLabel As System.Windows.Forms.Label
    Friend WithEvents DeliveryIngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents DeliveryIngredientNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveryReceiveButton As System.Windows.Forms.Button
End Class
