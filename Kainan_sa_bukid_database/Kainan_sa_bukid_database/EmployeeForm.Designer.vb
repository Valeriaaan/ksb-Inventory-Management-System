<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.EmployeeTitleLabel = New System.Windows.Forms.Label()
        Me.EmployeeClearButton = New System.Windows.Forms.Button()
        Me.EmployeeIDLabel = New System.Windows.Forms.Label()
        Me.EmployeeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.EmployeeNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeMinitTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeFNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeePhoneNumberLabel = New System.Windows.Forms.Label()
        Me.EmployeeAddressLabel = New System.Windows.Forms.Label()
        Me.EmployeeMinitLabel = New System.Windows.Forms.Label()
        Me.EmployeeFNameLabel = New System.Windows.Forms.Label()
        Me.EmployeeLNameLabel = New System.Windows.Forms.Label()
        Me.EmployeeAddButton = New System.Windows.Forms.Button()
        Me.EmployeeLNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeUpdateButton = New System.Windows.Forms.Button()
        Me.EmployeeDeleteButton = New System.Windows.Forms.Button()
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.EmployeeSexLabel = New System.Windows.Forms.Label()
        Me.EmployeeMaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.EmployeeFemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EmployeeTitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 51)
        Me.Panel1.TabIndex = 6
        '
        'EmployeeTitleLabel
        '
        Me.EmployeeTitleLabel.AutoSize = True
        Me.EmployeeTitleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.EmployeeTitleLabel.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.EmployeeTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeTitleLabel.Location = New System.Drawing.Point(18, 9)
        Me.EmployeeTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeTitleLabel.Name = "EmployeeTitleLabel"
        Me.EmployeeTitleLabel.Size = New System.Drawing.Size(146, 37)
        Me.EmployeeTitleLabel.TabIndex = 14
        Me.EmployeeTitleLabel.Text = "Employee"
        '
        'EmployeeClearButton
        '
        Me.EmployeeClearButton.Location = New System.Drawing.Point(264, 508)
        Me.EmployeeClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeClearButton.Name = "EmployeeClearButton"
        Me.EmployeeClearButton.Size = New System.Drawing.Size(416, 43)
        Me.EmployeeClearButton.TabIndex = 40
        Me.EmployeeClearButton.Text = "Clear"
        Me.EmployeeClearButton.UseVisualStyleBackColor = True
        '
        'EmployeeIDLabel
        '
        Me.EmployeeIDLabel.AutoSize = True
        Me.EmployeeIDLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeIDLabel.Location = New System.Drawing.Point(259, 92)
        Me.EmployeeIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeIDLabel.Name = "EmployeeIDLabel"
        Me.EmployeeIDLabel.Size = New System.Drawing.Size(122, 28)
        Me.EmployeeIDLabel.TabIndex = 27
        Me.EmployeeIDLabel.Text = "Employee ID"
        '
        'EmployeeIDComboBox
        '
        Me.EmployeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmployeeIDComboBox.FormattingEnabled = True
        Me.EmployeeIDComboBox.Location = New System.Drawing.Point(426, 84)
        Me.EmployeeIDComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeIDComboBox.Name = "EmployeeIDComboBox"
        Me.EmployeeIDComboBox.Size = New System.Drawing.Size(254, 36)
        Me.EmployeeIDComboBox.TabIndex = 24
        '
        'EmployeeNumberTextBox
        '
        Me.EmployeeNumberTextBox.Location = New System.Drawing.Point(426, 390)
        Me.EmployeeNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.EmployeeNumberTextBox.Name = "EmployeeNumberTextBox"
        Me.EmployeeNumberTextBox.Size = New System.Drawing.Size(254, 34)
        Me.EmployeeNumberTextBox.TabIndex = 35
        '
        'EmployeeAddressTextBox
        '
        Me.EmployeeAddressTextBox.Location = New System.Drawing.Point(426, 339)
        Me.EmployeeAddressTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.EmployeeAddressTextBox.Name = "EmployeeAddressTextBox"
        Me.EmployeeAddressTextBox.Size = New System.Drawing.Size(254, 34)
        Me.EmployeeAddressTextBox.TabIndex = 34
        '
        'EmployeeMinitTextBox
        '
        Me.EmployeeMinitTextBox.Location = New System.Drawing.Point(426, 237)
        Me.EmployeeMinitTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.EmployeeMinitTextBox.Name = "EmployeeMinitTextBox"
        Me.EmployeeMinitTextBox.Size = New System.Drawing.Size(254, 34)
        Me.EmployeeMinitTextBox.TabIndex = 33
        '
        'EmployeeFNameTextBox
        '
        Me.EmployeeFNameTextBox.Location = New System.Drawing.Point(426, 186)
        Me.EmployeeFNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.EmployeeFNameTextBox.Name = "EmployeeFNameTextBox"
        Me.EmployeeFNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.EmployeeFNameTextBox.TabIndex = 32
        '
        'EmployeePhoneNumberLabel
        '
        Me.EmployeePhoneNumberLabel.AutoSize = True
        Me.EmployeePhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeePhoneNumberLabel.Location = New System.Drawing.Point(259, 396)
        Me.EmployeePhoneNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeePhoneNumberLabel.Name = "EmployeePhoneNumberLabel"
        Me.EmployeePhoneNumberLabel.Size = New System.Drawing.Size(144, 28)
        Me.EmployeePhoneNumberLabel.TabIndex = 31
        Me.EmployeePhoneNumberLabel.Text = "Phone Number"
        '
        'EmployeeAddressLabel
        '
        Me.EmployeeAddressLabel.AutoSize = True
        Me.EmployeeAddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeAddressLabel.Location = New System.Drawing.Point(259, 345)
        Me.EmployeeAddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeAddressLabel.Name = "EmployeeAddressLabel"
        Me.EmployeeAddressLabel.Size = New System.Drawing.Size(82, 28)
        Me.EmployeeAddressLabel.TabIndex = 30
        Me.EmployeeAddressLabel.Text = "Address"
        '
        'EmployeeMinitLabel
        '
        Me.EmployeeMinitLabel.AutoSize = True
        Me.EmployeeMinitLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeMinitLabel.Location = New System.Drawing.Point(259, 243)
        Me.EmployeeMinitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeMinitLabel.Name = "EmployeeMinitLabel"
        Me.EmployeeMinitLabel.Size = New System.Drawing.Size(127, 28)
        Me.EmployeeMinitLabel.TabIndex = 29
        Me.EmployeeMinitLabel.Text = "Middle Initial"
        '
        'EmployeeFNameLabel
        '
        Me.EmployeeFNameLabel.AutoSize = True
        Me.EmployeeFNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeFNameLabel.Location = New System.Drawing.Point(259, 192)
        Me.EmployeeFNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeFNameLabel.Name = "EmployeeFNameLabel"
        Me.EmployeeFNameLabel.Size = New System.Drawing.Size(106, 28)
        Me.EmployeeFNameLabel.TabIndex = 28
        Me.EmployeeFNameLabel.Text = "First Name"
        '
        'EmployeeLNameLabel
        '
        Me.EmployeeLNameLabel.AutoSize = True
        Me.EmployeeLNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeLNameLabel.Location = New System.Drawing.Point(259, 141)
        Me.EmployeeLNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeLNameLabel.Name = "EmployeeLNameLabel"
        Me.EmployeeLNameLabel.Size = New System.Drawing.Size(103, 28)
        Me.EmployeeLNameLabel.TabIndex = 26
        Me.EmployeeLNameLabel.Text = "Last Name"
        '
        'EmployeeAddButton
        '
        Me.EmployeeAddButton.Location = New System.Drawing.Point(264, 448)
        Me.EmployeeAddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeAddButton.Name = "EmployeeAddButton"
        Me.EmployeeAddButton.Size = New System.Drawing.Size(416, 43)
        Me.EmployeeAddButton.TabIndex = 25
        Me.EmployeeAddButton.Text = "Add"
        Me.EmployeeAddButton.UseVisualStyleBackColor = True
        '
        'EmployeeLNameTextBox
        '
        Me.EmployeeLNameTextBox.Location = New System.Drawing.Point(426, 135)
        Me.EmployeeLNameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.EmployeeLNameTextBox.Name = "EmployeeLNameTextBox"
        Me.EmployeeLNameTextBox.Size = New System.Drawing.Size(254, 34)
        Me.EmployeeLNameTextBox.TabIndex = 23
        '
        'EmployeeUpdateButton
        '
        Me.EmployeeUpdateButton.Location = New System.Drawing.Point(264, 448)
        Me.EmployeeUpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeUpdateButton.Name = "EmployeeUpdateButton"
        Me.EmployeeUpdateButton.Size = New System.Drawing.Size(416, 43)
        Me.EmployeeUpdateButton.TabIndex = 37
        Me.EmployeeUpdateButton.Text = "Update"
        Me.EmployeeUpdateButton.UseVisualStyleBackColor = True
        '
        'EmployeeDeleteButton
        '
        Me.EmployeeDeleteButton.Location = New System.Drawing.Point(264, 448)
        Me.EmployeeDeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDeleteButton.Name = "EmployeeDeleteButton"
        Me.EmployeeDeleteButton.Size = New System.Drawing.Size(416, 43)
        Me.EmployeeDeleteButton.TabIndex = 36
        Me.EmployeeDeleteButton.Text = "Delete"
        Me.EmployeeDeleteButton.UseVisualStyleBackColor = True
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.AllowUserToAddRows = False
        Me.EmployeeDGV.AllowUserToDeleteRows = False
        Me.EmployeeDGV.AllowUserToResizeColumns = False
        Me.EmployeeDGV.AllowUserToResizeRows = False
        Me.EmployeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDGV.Location = New System.Drawing.Point(13, 60)
        Me.EmployeeDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersWidth = 21
        Me.EmployeeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDGV.RowTemplate.Height = 24
        Me.EmployeeDGV.Size = New System.Drawing.Size(925, 491)
        Me.EmployeeDGV.TabIndex = 39
        '
        'EmployeeSexLabel
        '
        Me.EmployeeSexLabel.AutoSize = True
        Me.EmployeeSexLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.EmployeeSexLabel.Location = New System.Drawing.Point(259, 294)
        Me.EmployeeSexLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmployeeSexLabel.Name = "EmployeeSexLabel"
        Me.EmployeeSexLabel.Size = New System.Drawing.Size(42, 28)
        Me.EmployeeSexLabel.TabIndex = 41
        Me.EmployeeSexLabel.Text = "Sex"
        '
        'EmployeeMaleRadioButton
        '
        Me.EmployeeMaleRadioButton.AutoSize = True
        Me.EmployeeMaleRadioButton.Location = New System.Drawing.Point(426, 290)
        Me.EmployeeMaleRadioButton.Name = "EmployeeMaleRadioButton"
        Me.EmployeeMaleRadioButton.Size = New System.Drawing.Size(76, 32)
        Me.EmployeeMaleRadioButton.TabIndex = 42
        Me.EmployeeMaleRadioButton.TabStop = True
        Me.EmployeeMaleRadioButton.Text = "Male"
        Me.EmployeeMaleRadioButton.UseVisualStyleBackColor = True
        '
        'EmployeeFemaleRadioButton
        '
        Me.EmployeeFemaleRadioButton.AutoSize = True
        Me.EmployeeFemaleRadioButton.Location = New System.Drawing.Point(541, 290)
        Me.EmployeeFemaleRadioButton.Name = "EmployeeFemaleRadioButton"
        Me.EmployeeFemaleRadioButton.Size = New System.Drawing.Size(95, 32)
        Me.EmployeeFemaleRadioButton.TabIndex = 43
        Me.EmployeeFemaleRadioButton.TabStop = True
        Me.EmployeeFemaleRadioButton.Text = "Female"
        Me.EmployeeFemaleRadioButton.UseVisualStyleBackColor = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.EmployeeFemaleRadioButton)
        Me.Controls.Add(Me.EmployeeMaleRadioButton)
        Me.Controls.Add(Me.EmployeeSexLabel)
        Me.Controls.Add(Me.EmployeeClearButton)
        Me.Controls.Add(Me.EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeIDComboBox)
        Me.Controls.Add(Me.EmployeeNumberTextBox)
        Me.Controls.Add(Me.EmployeeAddressTextBox)
        Me.Controls.Add(Me.EmployeeMinitTextBox)
        Me.Controls.Add(Me.EmployeeFNameTextBox)
        Me.Controls.Add(Me.EmployeePhoneNumberLabel)
        Me.Controls.Add(Me.EmployeeAddressLabel)
        Me.Controls.Add(Me.EmployeeMinitLabel)
        Me.Controls.Add(Me.EmployeeFNameLabel)
        Me.Controls.Add(Me.EmployeeLNameLabel)
        Me.Controls.Add(Me.EmployeeAddButton)
        Me.Controls.Add(Me.EmployeeLNameTextBox)
        Me.Controls.Add(Me.EmployeeUpdateButton)
        Me.Controls.Add(Me.EmployeeDeleteButton)
        Me.Controls.Add(Me.EmployeeDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EmployeeForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EmployeeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeClearButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeIDLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeMinitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeFNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeePhoneNumberLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeAddressLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeMinitLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeFNameLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeLNameLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeAddButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeLNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeUpdateButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeDeleteButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeDGV As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeSexLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeMaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EmployeeFemaleRadioButton As System.Windows.Forms.RadioButton
End Class
