<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Me.SupplierLNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierAddButton = New System.Windows.Forms.Button()
        Me.SupplierLNameLabel = New System.Windows.Forms.Label()
        Me.SupplierFNameLabel = New System.Windows.Forms.Label()
        Me.SupplierMinitLabel = New System.Windows.Forms.Label()
        Me.SupplierAddressLabel = New System.Windows.Forms.Label()
        Me.SupplierPhoneNumberLabel = New System.Windows.Forms.Label()
        Me.SupplierFNameTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierMinitTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierDeleteButton = New System.Windows.Forms.Button()
        Me.SupplierUpdateButton = New System.Windows.Forms.Button()
        Me.SupplierDGV = New System.Windows.Forms.DataGridView()
        Me.SupplierIDLabel = New System.Windows.Forms.Label()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SupplierTitleLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SupplierClearButton = New System.Windows.Forms.Button()
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierLNameTextBox
        '
        Me.SupplierLNameTextBox.Location = New System.Drawing.Point(426, 134)
        Me.SupplierLNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SupplierLNameTextBox.Name = "SupplierLNameTextBox"
        Me.SupplierLNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SupplierLNameTextBox.TabIndex = 2
        '
        'SupplierAddButton
        '
        Me.SupplierAddButton.Location = New System.Drawing.Point(264, 405)
        Me.SupplierAddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierAddButton.Name = "SupplierAddButton"
        Me.SupplierAddButton.Size = New System.Drawing.Size(416, 43)
        Me.SupplierAddButton.TabIndex = 6
        Me.SupplierAddButton.Text = "Add"
        Me.SupplierAddButton.UseVisualStyleBackColor = True
        '
        'SupplierLNameLabel
        '
        Me.SupplierLNameLabel.AutoSize = True
        Me.SupplierLNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierLNameLabel.Location = New System.Drawing.Point(259, 140)
        Me.SupplierLNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierLNameLabel.Name = "SupplierLNameLabel"
        Me.SupplierLNameLabel.Size = New System.Drawing.Size(103, 28)
        Me.SupplierLNameLabel.TabIndex = 7
        Me.SupplierLNameLabel.Text = "Last Name"
        '
        'SupplierFNameLabel
        '
        Me.SupplierFNameLabel.AutoSize = True
        Me.SupplierFNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierFNameLabel.Location = New System.Drawing.Point(259, 191)
        Me.SupplierFNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierFNameLabel.Name = "SupplierFNameLabel"
        Me.SupplierFNameLabel.Size = New System.Drawing.Size(106, 28)
        Me.SupplierFNameLabel.TabIndex = 10
        Me.SupplierFNameLabel.Text = "First Name"
        '
        'SupplierMinitLabel
        '
        Me.SupplierMinitLabel.AutoSize = True
        Me.SupplierMinitLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierMinitLabel.Location = New System.Drawing.Point(259, 242)
        Me.SupplierMinitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierMinitLabel.Name = "SupplierMinitLabel"
        Me.SupplierMinitLabel.Size = New System.Drawing.Size(127, 28)
        Me.SupplierMinitLabel.TabIndex = 11
        Me.SupplierMinitLabel.Text = "Middle Initial"
        '
        'SupplierAddressLabel
        '
        Me.SupplierAddressLabel.AutoSize = True
        Me.SupplierAddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierAddressLabel.Location = New System.Drawing.Point(259, 293)
        Me.SupplierAddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierAddressLabel.Name = "SupplierAddressLabel"
        Me.SupplierAddressLabel.Size = New System.Drawing.Size(82, 28)
        Me.SupplierAddressLabel.TabIndex = 12
        Me.SupplierAddressLabel.Text = "Address"
        '
        'SupplierPhoneNumberLabel
        '
        Me.SupplierPhoneNumberLabel.AutoSize = True
        Me.SupplierPhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierPhoneNumberLabel.Location = New System.Drawing.Point(259, 344)
        Me.SupplierPhoneNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierPhoneNumberLabel.Name = "SupplierPhoneNumberLabel"
        Me.SupplierPhoneNumberLabel.Size = New System.Drawing.Size(144, 28)
        Me.SupplierPhoneNumberLabel.TabIndex = 13
        Me.SupplierPhoneNumberLabel.Text = "Phone Number"
        '
        'SupplierFNameTextBox
        '
        Me.SupplierFNameTextBox.Location = New System.Drawing.Point(426, 185)
        Me.SupplierFNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SupplierFNameTextBox.Name = "SupplierFNameTextBox"
        Me.SupplierFNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SupplierFNameTextBox.TabIndex = 14
        '
        'SupplierMinitTextBox
        '
        Me.SupplierMinitTextBox.Location = New System.Drawing.Point(426, 236)
        Me.SupplierMinitTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SupplierMinitTextBox.Name = "SupplierMinitTextBox"
        Me.SupplierMinitTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SupplierMinitTextBox.TabIndex = 15
        '
        'SupplierAddressTextBox
        '
        Me.SupplierAddressTextBox.Location = New System.Drawing.Point(426, 287)
        Me.SupplierAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SupplierAddressTextBox.Name = "SupplierAddressTextBox"
        Me.SupplierAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SupplierAddressTextBox.TabIndex = 16
        '
        'SupplierNumberTextBox
        '
        Me.SupplierNumberTextBox.Location = New System.Drawing.Point(426, 338)
        Me.SupplierNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SupplierNumberTextBox.Name = "SupplierNumberTextBox"
        Me.SupplierNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.SupplierNumberTextBox.TabIndex = 17
        '
        'SupplierDeleteButton
        '
        Me.SupplierDeleteButton.Location = New System.Drawing.Point(264, 405)
        Me.SupplierDeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierDeleteButton.Name = "SupplierDeleteButton"
        Me.SupplierDeleteButton.Size = New System.Drawing.Size(416, 43)
        Me.SupplierDeleteButton.TabIndex = 18
        Me.SupplierDeleteButton.Text = "Delete"
        Me.SupplierDeleteButton.UseVisualStyleBackColor = True
        '
        'SupplierUpdateButton
        '
        Me.SupplierUpdateButton.Location = New System.Drawing.Point(264, 405)
        Me.SupplierUpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierUpdateButton.Name = "SupplierUpdateButton"
        Me.SupplierUpdateButton.Size = New System.Drawing.Size(416, 43)
        Me.SupplierUpdateButton.TabIndex = 19
        Me.SupplierUpdateButton.Text = "Update"
        Me.SupplierUpdateButton.UseVisualStyleBackColor = True
        '
        'SupplierDGV
        '
        Me.SupplierDGV.AllowUserToAddRows = False
        Me.SupplierDGV.AllowUserToDeleteRows = False
        Me.SupplierDGV.AllowUserToResizeColumns = False
        Me.SupplierDGV.AllowUserToResizeRows = False
        Me.SupplierDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SupplierDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SupplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDGV.Location = New System.Drawing.Point(13, 59)
        Me.SupplierDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierDGV.Name = "SupplierDGV"
        Me.SupplierDGV.ReadOnly = True
        Me.SupplierDGV.RowHeadersWidth = 21
        Me.SupplierDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SupplierDGV.RowTemplate.Height = 24
        Me.SupplierDGV.Size = New System.Drawing.Size(925, 492)
        Me.SupplierDGV.TabIndex = 21
        '
        'SupplierIDLabel
        '
        Me.SupplierIDLabel.AutoSize = True
        Me.SupplierIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierIDLabel.Location = New System.Drawing.Point(259, 91)
        Me.SupplierIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierIDLabel.Name = "SupplierIDLabel"
        Me.SupplierIDLabel.Size = New System.Drawing.Size(109, 28)
        Me.SupplierIDLabel.TabIndex = 9
        Me.SupplierIDLabel.Text = "Supplier ID"
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(426, 83)
        Me.SupplierIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.SupplierIDComboBox.TabIndex = 4
        '
        'SupplierTitleLabel
        '
        Me.SupplierTitleLabel.AutoSize = True
        Me.SupplierTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SupplierTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.SupplierTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SupplierTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.SupplierTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SupplierTitleLabel.Name = "SupplierTitleLabel"
        Me.SupplierTitleLabel.Size = New System.Drawing.Size(126, 37)
        Me.SupplierTitleLabel.TabIndex = 14
        Me.SupplierTitleLabel.Text = "Supplier"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SupplierTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 51)
        Me.Panel1.TabIndex = 5
        '
        'SupplierClearButton
        '
        Me.SupplierClearButton.Location = New System.Drawing.Point(264, 465)
        Me.SupplierClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierClearButton.Name = "SupplierClearButton"
        Me.SupplierClearButton.Size = New System.Drawing.Size(416, 43)
        Me.SupplierClearButton.TabIndex = 22
        Me.SupplierClearButton.Text = "Clear"
        Me.SupplierClearButton.UseVisualStyleBackColor = True
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.SupplierClearButton)
        Me.Controls.Add(Me.SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDComboBox)
        Me.Controls.Add(Me.SupplierNumberTextBox)
        Me.Controls.Add(Me.SupplierAddressTextBox)
        Me.Controls.Add(Me.SupplierMinitTextBox)
        Me.Controls.Add(Me.SupplierFNameTextBox)
        Me.Controls.Add(Me.SupplierPhoneNumberLabel)
        Me.Controls.Add(Me.SupplierAddressLabel)
        Me.Controls.Add(Me.SupplierMinitLabel)
        Me.Controls.Add(Me.SupplierFNameLabel)
        Me.Controls.Add(Me.SupplierLNameLabel)
        Me.Controls.Add(Me.SupplierAddButton)
        Me.Controls.Add(Me.SupplierLNameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SupplierUpdateButton)
        Me.Controls.Add(Me.SupplierDeleteButton)
        Me.Controls.Add(Me.SupplierDGV)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "SupplierForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SupplierLNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierAddButton As System.Windows.Forms.Button
    Friend WithEvents SupplierLNameLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierFNameLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierMinitLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierAddressLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierPhoneNumberLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierFNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierMinitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierDeleteButton As System.Windows.Forms.Button
    Friend WithEvents SupplierUpdateButton As System.Windows.Forms.Button
    Friend WithEvents SupplierDGV As System.Windows.Forms.DataGridView
    Friend WithEvents SupplierIDLabel As System.Windows.Forms.Label
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SupplierClearButton As System.Windows.Forms.Button

End Class
