<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.NumberOfEmployeesLabel = New System.Windows.Forms.Label()
        Me.NumberOfEmpasloyeesLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.NumberOfSuppliersLabel = New System.Windows.Forms.Label()
        Me.NumberOfasdSuppliersLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IngredientsRegisteredLabel = New System.Windows.Forms.Label()
        Me.asd = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ProductRegisteredLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IngredientTitleLabel = New System.Windows.Forms.Label()
        Me.RecentSalesDGV = New System.Windows.Forms.DataGridView()
        Me.RecentDeliveryDGV = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RecentPurchasesDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.RecentSalesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecentDeliveryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecentPurchasesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 111)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Controls.Add(Me.NumberOfEmployeesLabel)
        Me.Panel6.Controls.Add(Me.NumberOfEmpasloyeesLabel)
        Me.Panel6.Location = New System.Drawing.Point(701, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(210, 100)
        Me.Panel6.TabIndex = 2
        '
        'NumberOfEmployeesLabel
        '
        Me.NumberOfEmployeesLabel.AutoSize = True
        Me.NumberOfEmployeesLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfEmployeesLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfEmployeesLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfEmployeesLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfEmployeesLabel.Name = "NumberOfEmployeesLabel"
        Me.NumberOfEmployeesLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfEmployeesLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfEmployeesLabel.TabIndex = 2
        Me.NumberOfEmployeesLabel.Text = "0"
        '
        'NumberOfEmpasloyeesLabel
        '
        Me.NumberOfEmpasloyeesLabel.AutoSize = True
        Me.NumberOfEmpasloyeesLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NumberOfEmpasloyeesLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfEmpasloyeesLabel.Location = New System.Drawing.Point(0, 69)
        Me.NumberOfEmpasloyeesLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfEmpasloyeesLabel.Name = "NumberOfEmpasloyeesLabel"
        Me.NumberOfEmpasloyeesLabel.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.NumberOfEmpasloyeesLabel.Size = New System.Drawing.Size(195, 31)
        Me.NumberOfEmpasloyeesLabel.TabIndex = 1
        Me.NumberOfEmpasloyeesLabel.Text = "Number of Employees"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel4.Controls.Add(Me.NumberOfSuppliersLabel)
        Me.Panel4.Controls.Add(Me.NumberOfasdSuppliersLabel)
        Me.Panel4.Location = New System.Drawing.Point(472, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 100)
        Me.Panel4.TabIndex = 2
        '
        'NumberOfSuppliersLabel
        '
        Me.NumberOfSuppliersLabel.AutoSize = True
        Me.NumberOfSuppliersLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NumberOfSuppliersLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfSuppliersLabel.Location = New System.Drawing.Point(0, 0)
        Me.NumberOfSuppliersLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfSuppliersLabel.Name = "NumberOfSuppliersLabel"
        Me.NumberOfSuppliersLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.NumberOfSuppliersLabel.Size = New System.Drawing.Size(65, 75)
        Me.NumberOfSuppliersLabel.TabIndex = 2
        Me.NumberOfSuppliersLabel.Text = "0"
        '
        'NumberOfasdSuppliersLabel
        '
        Me.NumberOfasdSuppliersLabel.AutoSize = True
        Me.NumberOfasdSuppliersLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NumberOfasdSuppliersLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfasdSuppliersLabel.Location = New System.Drawing.Point(0, 69)
        Me.NumberOfasdSuppliersLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.NumberOfasdSuppliersLabel.Name = "NumberOfasdSuppliersLabel"
        Me.NumberOfasdSuppliersLabel.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.NumberOfasdSuppliersLabel.Size = New System.Drawing.Size(183, 31)
        Me.NumberOfasdSuppliersLabel.TabIndex = 1
        Me.NumberOfasdSuppliersLabel.Text = "Number of Suppliers"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.IngredientsRegisteredLabel)
        Me.Panel3.Controls.Add(Me.asd)
        Me.Panel3.Location = New System.Drawing.Point(243, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 100)
        Me.Panel3.TabIndex = 2
        '
        'IngredientsRegisteredLabel
        '
        Me.IngredientsRegisteredLabel.AutoSize = True
        Me.IngredientsRegisteredLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.IngredientsRegisteredLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientsRegisteredLabel.Location = New System.Drawing.Point(0, 0)
        Me.IngredientsRegisteredLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.IngredientsRegisteredLabel.Name = "IngredientsRegisteredLabel"
        Me.IngredientsRegisteredLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.IngredientsRegisteredLabel.Size = New System.Drawing.Size(65, 75)
        Me.IngredientsRegisteredLabel.TabIndex = 2
        Me.IngredientsRegisteredLabel.Text = "0"
        '
        'asd
        '
        Me.asd.AutoSize = True
        Me.asd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.asd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asd.Location = New System.Drawing.Point(0, 69)
        Me.asd.Margin = New System.Windows.Forms.Padding(0)
        Me.asd.Name = "asd"
        Me.asd.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.asd.Size = New System.Drawing.Size(197, 31)
        Me.asd.TabIndex = 1
        Me.asd.Text = "Ingredients Registered"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Controls.Add(Me.ProductRegisteredLabel)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(14, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 100)
        Me.Panel5.TabIndex = 1
        '
        'ProductRegisteredLabel
        '
        Me.ProductRegisteredLabel.AutoSize = True
        Me.ProductRegisteredLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductRegisteredLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductRegisteredLabel.Location = New System.Drawing.Point(0, 0)
        Me.ProductRegisteredLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProductRegisteredLabel.Name = "ProductRegisteredLabel"
        Me.ProductRegisteredLabel.Padding = New System.Windows.Forms.Padding(8)
        Me.ProductRegisteredLabel.Size = New System.Drawing.Size(65, 75)
        Me.ProductRegisteredLabel.TabIndex = 1
        Me.ProductRegisteredLabel.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.Label1.Size = New System.Drawing.Size(171, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Registered"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.IngredientTitleLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(951, 51)
        Me.Panel2.TabIndex = 9
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
        Me.IngredientTitleLabel.Size = New System.Drawing.Size(160, 37)
        Me.IngredientTitleLabel.TabIndex = 14
        Me.IngredientTitleLabel.Text = "Dashboard"
        '
        'RecentSalesDGV
        '
        Me.RecentSalesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecentSalesDGV.Location = New System.Drawing.Point(26, 210)
        Me.RecentSalesDGV.Name = "RecentSalesDGV"
        Me.RecentSalesDGV.RowTemplate.Height = 24
        Me.RecentSalesDGV.Size = New System.Drawing.Size(439, 342)
        Me.RecentSalesDGV.TabIndex = 10
        '
        'RecentDeliveryDGV
        '
        Me.RecentDeliveryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecentDeliveryDGV.Location = New System.Drawing.Point(484, 210)
        Me.RecentDeliveryDGV.Name = "RecentDeliveryDGV"
        Me.RecentDeliveryDGV.RowTemplate.Height = 24
        Me.RecentDeliveryDGV.Size = New System.Drawing.Size(439, 152)
        Me.RecentDeliveryDGV.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 179)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 28)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Recent Sales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(479, 179)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 28)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Recent Deliveries"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(479, 369)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 28)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Recent Purchases"
        '
        'RecentPurchasesDGV
        '
        Me.RecentPurchasesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecentPurchasesDGV.Location = New System.Drawing.Point(484, 400)
        Me.RecentPurchasesDGV.Name = "RecentPurchasesDGV"
        Me.RecentPurchasesDGV.RowTemplate.Height = 24
        Me.RecentPurchasesDGV.Size = New System.Drawing.Size(439, 152)
        Me.RecentPurchasesDGV.TabIndex = 16
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.RecentPurchasesDGV)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RecentDeliveryDGV)
        Me.Controls.Add(Me.RecentSalesDGV)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DashboardForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.RecentSalesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecentDeliveryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecentPurchasesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents IngredientTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberOfasdSuppliersLabel As System.Windows.Forms.Label
    Friend WithEvents asd As System.Windows.Forms.Label
    Friend WithEvents NumberOfEmpasloyeesLabel As System.Windows.Forms.Label
    Friend WithEvents ProductRegisteredLabel As System.Windows.Forms.Label
    Friend WithEvents RecentSalesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents RecentDeliveryDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RecentPurchasesDGV As System.Windows.Forms.DataGridView
    Friend WithEvents NumberOfEmployeesLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfSuppliersLabel As System.Windows.Forms.Label
    Friend WithEvents IngredientsRegisteredLabel As System.Windows.Forms.Label
End Class
