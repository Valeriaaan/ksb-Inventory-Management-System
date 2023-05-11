<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SideNavDrawer = New System.Windows.Forms.Panel()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.EmployeeAccordionPanel = New System.Windows.Forms.Panel()
        Me.EmployeeDeleteBtn = New System.Windows.Forms.Button()
        Me.EmployeeUpdateBtn = New System.Windows.Forms.Button()
        Me.EmployeeAddBtn = New System.Windows.Forms.Button()
        Me.EmployeeViewBtn = New System.Windows.Forms.Button()
        Me.EmployeeBtn = New System.Windows.Forms.Button()
        Me.SupplierAccordionPanel = New System.Windows.Forms.Panel()
        Me.SuppliersDeleteBtn = New System.Windows.Forms.Button()
        Me.SuppliersUpdateBtn = New System.Windows.Forms.Button()
        Me.SuppliersAddBtn = New System.Windows.Forms.Button()
        Me.SuppliersViewBtn = New System.Windows.Forms.Button()
        Me.SupplierBtn = New System.Windows.Forms.Button()
        Me.IngredientAccordionPanel = New System.Windows.Forms.Panel()
        Me.IngredientsDeleteBtn = New System.Windows.Forms.Button()
        Me.IngredientsUpdateBtn = New System.Windows.Forms.Button()
        Me.IngredientsAddBtn = New System.Windows.Forms.Button()
        Me.IngredientsViewBtn = New System.Windows.Forms.Button()
        Me.IngredientsBtn = New System.Windows.Forms.Button()
        Me.ProductAccordionPanel = New System.Windows.Forms.Panel()
        Me.ProductDeleteBtn = New System.Windows.Forms.Button()
        Me.ProductUpdateBtn = New System.Windows.Forms.Button()
        Me.ProductAddBtn = New System.Windows.Forms.Button()
        Me.ProductViewBtn = New System.Windows.Forms.Button()
        Me.ProductsBtn = New System.Windows.Forms.Button()
        Me.TransactionAccordionPanel = New System.Windows.Forms.Panel()
        Me.TransactionPurchaseBtn = New System.Windows.Forms.Button()
        Me.TransactionDeliveryBtn = New System.Windows.Forms.Button()
        Me.TransactionSalesBtn = New System.Windows.Forms.Button()
        Me.TransactionBtn = New System.Windows.Forms.Button()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LogoPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.SideNavDrawer.SuspendLayout()
        Me.EmployeeAccordionPanel.SuspendLayout()
        Me.SupplierAccordionPanel.SuspendLayout()
        Me.IngredientAccordionPanel.SuspendLayout()
        Me.ProductAccordionPanel.SuspendLayout()
        Me.TransactionAccordionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SideNavDrawer
        '
        Me.SideNavDrawer.AutoScroll = True
        Me.SideNavDrawer.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.SideNavDrawer.Controls.Add(Me.ExitBtn)
        Me.SideNavDrawer.Controls.Add(Me.EmployeeAccordionPanel)
        Me.SideNavDrawer.Controls.Add(Me.EmployeeBtn)
        Me.SideNavDrawer.Controls.Add(Me.SupplierAccordionPanel)
        Me.SideNavDrawer.Controls.Add(Me.SupplierBtn)
        Me.SideNavDrawer.Controls.Add(Me.IngredientAccordionPanel)
        Me.SideNavDrawer.Controls.Add(Me.IngredientsBtn)
        Me.SideNavDrawer.Controls.Add(Me.ProductAccordionPanel)
        Me.SideNavDrawer.Controls.Add(Me.ProductsBtn)
        Me.SideNavDrawer.Controls.Add(Me.TransactionAccordionPanel)
        Me.SideNavDrawer.Controls.Add(Me.TransactionBtn)
        Me.SideNavDrawer.Controls.Add(Me.DashboardBtn)
        Me.SideNavDrawer.Controls.Add(Me.Panel2)
        Me.SideNavDrawer.Controls.Add(Me.LogoPanel)
        Me.SideNavDrawer.Controls.Add(Me.Panel1)
        Me.SideNavDrawer.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideNavDrawer.Location = New System.Drawing.Point(0, 0)
        Me.SideNavDrawer.Margin = New System.Windows.Forms.Padding(4)
        Me.SideNavDrawer.Name = "SideNavDrawer"
        Me.SideNavDrawer.Size = New System.Drawing.Size(264, 606)
        Me.SideNavDrawer.TabIndex = 0
        '
        'ExitBtn
        '
        Me.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ExitBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_logout_24
        Me.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.Location = New System.Drawing.Point(0, 1577)
        Me.ExitBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.ExitBtn.Size = New System.Drawing.Size(243, 55)
        Me.ExitBtn.TabIndex = 15
        Me.ExitBtn.Text = " Exit"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'EmployeeAccordionPanel
        '
        Me.EmployeeAccordionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.EmployeeAccordionPanel.Controls.Add(Me.EmployeeDeleteBtn)
        Me.EmployeeAccordionPanel.Controls.Add(Me.EmployeeUpdateBtn)
        Me.EmployeeAccordionPanel.Controls.Add(Me.EmployeeAddBtn)
        Me.EmployeeAccordionPanel.Controls.Add(Me.EmployeeViewBtn)
        Me.EmployeeAccordionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeAccordionPanel.Location = New System.Drawing.Point(0, 1349)
        Me.EmployeeAccordionPanel.Name = "EmployeeAccordionPanel"
        Me.EmployeeAccordionPanel.Size = New System.Drawing.Size(243, 228)
        Me.EmployeeAccordionPanel.TabIndex = 12
        '
        'EmployeeDeleteBtn
        '
        Me.EmployeeDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmployeeDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeDeleteBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeDeleteBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeDeleteBtn.Image = CType(resources.GetObject("EmployeeDeleteBtn.Image"), System.Drawing.Image)
        Me.EmployeeDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeDeleteBtn.Location = New System.Drawing.Point(0, 165)
        Me.EmployeeDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeDeleteBtn.Name = "EmployeeDeleteBtn"
        Me.EmployeeDeleteBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.EmployeeDeleteBtn.Size = New System.Drawing.Size(243, 55)
        Me.EmployeeDeleteBtn.TabIndex = 9
        Me.EmployeeDeleteBtn.Text = "  Delete Employee Data"
        Me.EmployeeDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmployeeDeleteBtn.UseVisualStyleBackColor = True
        '
        'EmployeeUpdateBtn
        '
        Me.EmployeeUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmployeeUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeUpdateBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeUpdateBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeUpdateBtn.Image = CType(resources.GetObject("EmployeeUpdateBtn.Image"), System.Drawing.Image)
        Me.EmployeeUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeUpdateBtn.Location = New System.Drawing.Point(0, 110)
        Me.EmployeeUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeUpdateBtn.Name = "EmployeeUpdateBtn"
        Me.EmployeeUpdateBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.EmployeeUpdateBtn.Size = New System.Drawing.Size(243, 55)
        Me.EmployeeUpdateBtn.TabIndex = 8
        Me.EmployeeUpdateBtn.Text = "  Update Employee Data"
        Me.EmployeeUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmployeeUpdateBtn.UseVisualStyleBackColor = True
        '
        'EmployeeAddBtn
        '
        Me.EmployeeAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmployeeAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeAddBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeAddBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeAddBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeAddBtn.Image = CType(resources.GetObject("EmployeeAddBtn.Image"), System.Drawing.Image)
        Me.EmployeeAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeAddBtn.Location = New System.Drawing.Point(0, 55)
        Me.EmployeeAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeAddBtn.Name = "EmployeeAddBtn"
        Me.EmployeeAddBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.EmployeeAddBtn.Size = New System.Drawing.Size(243, 55)
        Me.EmployeeAddBtn.TabIndex = 7
        Me.EmployeeAddBtn.Text = "  Add New Employee"
        Me.EmployeeAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmployeeAddBtn.UseVisualStyleBackColor = True
        '
        'EmployeeViewBtn
        '
        Me.EmployeeViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmployeeViewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeViewBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeViewBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeViewBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeViewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeViewBtn.Image = CType(resources.GetObject("EmployeeViewBtn.Image"), System.Drawing.Image)
        Me.EmployeeViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeViewBtn.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeViewBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeViewBtn.Name = "EmployeeViewBtn"
        Me.EmployeeViewBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.EmployeeViewBtn.Size = New System.Drawing.Size(243, 55)
        Me.EmployeeViewBtn.TabIndex = 6
        Me.EmployeeViewBtn.Text = "  View Employee List"
        Me.EmployeeViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmployeeViewBtn.UseVisualStyleBackColor = True
        '
        'EmployeeBtn
        '
        Me.EmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmployeeBtn.FlatAppearance.BorderSize = 0
        Me.EmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EmployeeBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_name_tag_24
        Me.EmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeBtn.Location = New System.Drawing.Point(0, 1294)
        Me.EmployeeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeBtn.Name = "EmployeeBtn"
        Me.EmployeeBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.EmployeeBtn.Size = New System.Drawing.Size(243, 55)
        Me.EmployeeBtn.TabIndex = 11
        Me.EmployeeBtn.Text = " Employees"
        Me.EmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmployeeBtn.UseVisualStyleBackColor = True
        '
        'SupplierAccordionPanel
        '
        Me.SupplierAccordionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.SupplierAccordionPanel.Controls.Add(Me.SuppliersDeleteBtn)
        Me.SupplierAccordionPanel.Controls.Add(Me.SuppliersUpdateBtn)
        Me.SupplierAccordionPanel.Controls.Add(Me.SuppliersAddBtn)
        Me.SupplierAccordionPanel.Controls.Add(Me.SuppliersViewBtn)
        Me.SupplierAccordionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SupplierAccordionPanel.Location = New System.Drawing.Point(0, 1066)
        Me.SupplierAccordionPanel.Name = "SupplierAccordionPanel"
        Me.SupplierAccordionPanel.Size = New System.Drawing.Size(243, 228)
        Me.SupplierAccordionPanel.TabIndex = 10
        '
        'SuppliersDeleteBtn
        '
        Me.SuppliersDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SuppliersDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SuppliersDeleteBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SuppliersDeleteBtn.FlatAppearance.BorderSize = 0
        Me.SuppliersDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SuppliersDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SuppliersDeleteBtn.Image = CType(resources.GetObject("SuppliersDeleteBtn.Image"), System.Drawing.Image)
        Me.SuppliersDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersDeleteBtn.Location = New System.Drawing.Point(0, 165)
        Me.SuppliersDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SuppliersDeleteBtn.Name = "SuppliersDeleteBtn"
        Me.SuppliersDeleteBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.SuppliersDeleteBtn.Size = New System.Drawing.Size(243, 55)
        Me.SuppliersDeleteBtn.TabIndex = 9
        Me.SuppliersDeleteBtn.Text = "  Delete Supplier Data"
        Me.SuppliersDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SuppliersDeleteBtn.UseVisualStyleBackColor = True
        '
        'SuppliersUpdateBtn
        '
        Me.SuppliersUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SuppliersUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SuppliersUpdateBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SuppliersUpdateBtn.FlatAppearance.BorderSize = 0
        Me.SuppliersUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SuppliersUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SuppliersUpdateBtn.Image = CType(resources.GetObject("SuppliersUpdateBtn.Image"), System.Drawing.Image)
        Me.SuppliersUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersUpdateBtn.Location = New System.Drawing.Point(0, 110)
        Me.SuppliersUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SuppliersUpdateBtn.Name = "SuppliersUpdateBtn"
        Me.SuppliersUpdateBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.SuppliersUpdateBtn.Size = New System.Drawing.Size(243, 55)
        Me.SuppliersUpdateBtn.TabIndex = 8
        Me.SuppliersUpdateBtn.Text = "  Update Supplier Data"
        Me.SuppliersUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SuppliersUpdateBtn.UseVisualStyleBackColor = True
        '
        'SuppliersAddBtn
        '
        Me.SuppliersAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SuppliersAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SuppliersAddBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SuppliersAddBtn.FlatAppearance.BorderSize = 0
        Me.SuppliersAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SuppliersAddBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SuppliersAddBtn.Image = CType(resources.GetObject("SuppliersAddBtn.Image"), System.Drawing.Image)
        Me.SuppliersAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersAddBtn.Location = New System.Drawing.Point(0, 55)
        Me.SuppliersAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SuppliersAddBtn.Name = "SuppliersAddBtn"
        Me.SuppliersAddBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.SuppliersAddBtn.Size = New System.Drawing.Size(243, 55)
        Me.SuppliersAddBtn.TabIndex = 7
        Me.SuppliersAddBtn.Text = "  Add New Supplier"
        Me.SuppliersAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SuppliersAddBtn.UseVisualStyleBackColor = True
        '
        'SuppliersViewBtn
        '
        Me.SuppliersViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SuppliersViewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SuppliersViewBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SuppliersViewBtn.FlatAppearance.BorderSize = 0
        Me.SuppliersViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SuppliersViewBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuppliersViewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SuppliersViewBtn.Image = CType(resources.GetObject("SuppliersViewBtn.Image"), System.Drawing.Image)
        Me.SuppliersViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersViewBtn.Location = New System.Drawing.Point(0, 0)
        Me.SuppliersViewBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SuppliersViewBtn.Name = "SuppliersViewBtn"
        Me.SuppliersViewBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.SuppliersViewBtn.Size = New System.Drawing.Size(243, 55)
        Me.SuppliersViewBtn.TabIndex = 6
        Me.SuppliersViewBtn.Text = "  View Supplier List"
        Me.SuppliersViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SuppliersViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SuppliersViewBtn.UseVisualStyleBackColor = True
        '
        'SupplierBtn
        '
        Me.SupplierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SupplierBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SupplierBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SupplierBtn.FlatAppearance.BorderSize = 0
        Me.SupplierBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.SupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_supplier_24
        Me.SupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SupplierBtn.Location = New System.Drawing.Point(0, 1011)
        Me.SupplierBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierBtn.Name = "SupplierBtn"
        Me.SupplierBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.SupplierBtn.Size = New System.Drawing.Size(243, 55)
        Me.SupplierBtn.TabIndex = 9
        Me.SupplierBtn.Text = " Suppliers"
        Me.SupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SupplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SupplierBtn.UseVisualStyleBackColor = True
        '
        'IngredientAccordionPanel
        '
        Me.IngredientAccordionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.IngredientAccordionPanel.Controls.Add(Me.IngredientsDeleteBtn)
        Me.IngredientAccordionPanel.Controls.Add(Me.IngredientsUpdateBtn)
        Me.IngredientAccordionPanel.Controls.Add(Me.IngredientsAddBtn)
        Me.IngredientAccordionPanel.Controls.Add(Me.IngredientsViewBtn)
        Me.IngredientAccordionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.IngredientAccordionPanel.Location = New System.Drawing.Point(0, 783)
        Me.IngredientAccordionPanel.Name = "IngredientAccordionPanel"
        Me.IngredientAccordionPanel.Size = New System.Drawing.Size(243, 228)
        Me.IngredientAccordionPanel.TabIndex = 8
        '
        'IngredientsDeleteBtn
        '
        Me.IngredientsDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IngredientsDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IngredientsDeleteBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.IngredientsDeleteBtn.FlatAppearance.BorderSize = 0
        Me.IngredientsDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngredientsDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientsDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IngredientsDeleteBtn.Image = CType(resources.GetObject("IngredientsDeleteBtn.Image"), System.Drawing.Image)
        Me.IngredientsDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsDeleteBtn.Location = New System.Drawing.Point(0, 165)
        Me.IngredientsDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientsDeleteBtn.Name = "IngredientsDeleteBtn"
        Me.IngredientsDeleteBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.IngredientsDeleteBtn.Size = New System.Drawing.Size(243, 55)
        Me.IngredientsDeleteBtn.TabIndex = 9
        Me.IngredientsDeleteBtn.Text = "  Delete Ingredient Data"
        Me.IngredientsDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IngredientsDeleteBtn.UseVisualStyleBackColor = True
        '
        'IngredientsUpdateBtn
        '
        Me.IngredientsUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IngredientsUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IngredientsUpdateBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.IngredientsUpdateBtn.FlatAppearance.BorderSize = 0
        Me.IngredientsUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngredientsUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientsUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IngredientsUpdateBtn.Image = CType(resources.GetObject("IngredientsUpdateBtn.Image"), System.Drawing.Image)
        Me.IngredientsUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsUpdateBtn.Location = New System.Drawing.Point(0, 110)
        Me.IngredientsUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientsUpdateBtn.Name = "IngredientsUpdateBtn"
        Me.IngredientsUpdateBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.IngredientsUpdateBtn.Size = New System.Drawing.Size(243, 55)
        Me.IngredientsUpdateBtn.TabIndex = 8
        Me.IngredientsUpdateBtn.Text = "  Update Ingredient Data"
        Me.IngredientsUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IngredientsUpdateBtn.UseVisualStyleBackColor = True
        '
        'IngredientsAddBtn
        '
        Me.IngredientsAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IngredientsAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IngredientsAddBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.IngredientsAddBtn.FlatAppearance.BorderSize = 0
        Me.IngredientsAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngredientsAddBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientsAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IngredientsAddBtn.Image = CType(resources.GetObject("IngredientsAddBtn.Image"), System.Drawing.Image)
        Me.IngredientsAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsAddBtn.Location = New System.Drawing.Point(0, 55)
        Me.IngredientsAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientsAddBtn.Name = "IngredientsAddBtn"
        Me.IngredientsAddBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.IngredientsAddBtn.Size = New System.Drawing.Size(243, 55)
        Me.IngredientsAddBtn.TabIndex = 7
        Me.IngredientsAddBtn.Text = "  Add New Ingredients"
        Me.IngredientsAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IngredientsAddBtn.UseVisualStyleBackColor = True
        '
        'IngredientsViewBtn
        '
        Me.IngredientsViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IngredientsViewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IngredientsViewBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.IngredientsViewBtn.FlatAppearance.BorderSize = 0
        Me.IngredientsViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngredientsViewBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientsViewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IngredientsViewBtn.Image = CType(resources.GetObject("IngredientsViewBtn.Image"), System.Drawing.Image)
        Me.IngredientsViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsViewBtn.Location = New System.Drawing.Point(0, 0)
        Me.IngredientsViewBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientsViewBtn.Name = "IngredientsViewBtn"
        Me.IngredientsViewBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.IngredientsViewBtn.Size = New System.Drawing.Size(243, 55)
        Me.IngredientsViewBtn.TabIndex = 6
        Me.IngredientsViewBtn.Text = "  View Ingredient List"
        Me.IngredientsViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IngredientsViewBtn.UseVisualStyleBackColor = True
        '
        'IngredientsBtn
        '
        Me.IngredientsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IngredientsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IngredientsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.IngredientsBtn.FlatAppearance.BorderSize = 0
        Me.IngredientsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.IngredientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngredientsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IngredientsBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_ingredients_24
        Me.IngredientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsBtn.Location = New System.Drawing.Point(0, 728)
        Me.IngredientsBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.IngredientsBtn.Name = "IngredientsBtn"
        Me.IngredientsBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.IngredientsBtn.Size = New System.Drawing.Size(243, 55)
        Me.IngredientsBtn.TabIndex = 7
        Me.IngredientsBtn.Text = " Ingredients"
        Me.IngredientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngredientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IngredientsBtn.UseVisualStyleBackColor = True
        '
        'ProductAccordionPanel
        '
        Me.ProductAccordionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ProductAccordionPanel.Controls.Add(Me.ProductDeleteBtn)
        Me.ProductAccordionPanel.Controls.Add(Me.ProductUpdateBtn)
        Me.ProductAccordionPanel.Controls.Add(Me.ProductAddBtn)
        Me.ProductAccordionPanel.Controls.Add(Me.ProductViewBtn)
        Me.ProductAccordionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductAccordionPanel.Location = New System.Drawing.Point(0, 500)
        Me.ProductAccordionPanel.Name = "ProductAccordionPanel"
        Me.ProductAccordionPanel.Size = New System.Drawing.Size(243, 228)
        Me.ProductAccordionPanel.TabIndex = 6
        '
        'ProductDeleteBtn
        '
        Me.ProductDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProductDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductDeleteBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductDeleteBtn.FlatAppearance.BorderSize = 0
        Me.ProductDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductDeleteBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_delete_24
        Me.ProductDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductDeleteBtn.Location = New System.Drawing.Point(0, 165)
        Me.ProductDeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductDeleteBtn.Name = "ProductDeleteBtn"
        Me.ProductDeleteBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ProductDeleteBtn.Size = New System.Drawing.Size(243, 55)
        Me.ProductDeleteBtn.TabIndex = 9
        Me.ProductDeleteBtn.Text = "  Delete Product Data"
        Me.ProductDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProductDeleteBtn.UseVisualStyleBackColor = True
        '
        'ProductUpdateBtn
        '
        Me.ProductUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProductUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductUpdateBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductUpdateBtn.FlatAppearance.BorderSize = 0
        Me.ProductUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductUpdateBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductUpdateBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_edit_24
        Me.ProductUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductUpdateBtn.Location = New System.Drawing.Point(0, 110)
        Me.ProductUpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductUpdateBtn.Name = "ProductUpdateBtn"
        Me.ProductUpdateBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ProductUpdateBtn.Size = New System.Drawing.Size(243, 55)
        Me.ProductUpdateBtn.TabIndex = 8
        Me.ProductUpdateBtn.Text = "  Update Product Data"
        Me.ProductUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProductUpdateBtn.UseVisualStyleBackColor = True
        '
        'ProductAddBtn
        '
        Me.ProductAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProductAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductAddBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductAddBtn.FlatAppearance.BorderSize = 0
        Me.ProductAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductAddBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductAddBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_add_24
        Me.ProductAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductAddBtn.Location = New System.Drawing.Point(0, 55)
        Me.ProductAddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductAddBtn.Name = "ProductAddBtn"
        Me.ProductAddBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ProductAddBtn.Size = New System.Drawing.Size(243, 55)
        Me.ProductAddBtn.TabIndex = 7
        Me.ProductAddBtn.Text = "  Add New Product"
        Me.ProductAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProductAddBtn.UseVisualStyleBackColor = True
        '
        'ProductViewBtn
        '
        Me.ProductViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProductViewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductViewBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductViewBtn.FlatAppearance.BorderSize = 0
        Me.ProductViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductViewBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductViewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductViewBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_view_24
        Me.ProductViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductViewBtn.Location = New System.Drawing.Point(0, 0)
        Me.ProductViewBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductViewBtn.Name = "ProductViewBtn"
        Me.ProductViewBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ProductViewBtn.Size = New System.Drawing.Size(243, 55)
        Me.ProductViewBtn.TabIndex = 6
        Me.ProductViewBtn.Text = "  View Product List"
        Me.ProductViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProductViewBtn.UseVisualStyleBackColor = True
        '
        'ProductsBtn
        '
        Me.ProductsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductsBtn.FlatAppearance.BorderSize = 0
        Me.ProductsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductsBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_product_24
        Me.ProductsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductsBtn.Location = New System.Drawing.Point(0, 445)
        Me.ProductsBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ProductsBtn.Name = "ProductsBtn"
        Me.ProductsBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.ProductsBtn.Size = New System.Drawing.Size(243, 55)
        Me.ProductsBtn.TabIndex = 5
        Me.ProductsBtn.Text = " Products"
        Me.ProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProductsBtn.UseVisualStyleBackColor = True
        '
        'TransactionAccordionPanel
        '
        Me.TransactionAccordionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TransactionAccordionPanel.Controls.Add(Me.TransactionPurchaseBtn)
        Me.TransactionAccordionPanel.Controls.Add(Me.TransactionDeliveryBtn)
        Me.TransactionAccordionPanel.Controls.Add(Me.TransactionSalesBtn)
        Me.TransactionAccordionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TransactionAccordionPanel.Location = New System.Drawing.Point(0, 272)
        Me.TransactionAccordionPanel.Name = "TransactionAccordionPanel"
        Me.TransactionAccordionPanel.Size = New System.Drawing.Size(243, 173)
        Me.TransactionAccordionPanel.TabIndex = 14
        '
        'TransactionPurchaseBtn
        '
        Me.TransactionPurchaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TransactionPurchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransactionPurchaseBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.TransactionPurchaseBtn.FlatAppearance.BorderSize = 0
        Me.TransactionPurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionPurchaseBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionPurchaseBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TransactionPurchaseBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_basket_24
        Me.TransactionPurchaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionPurchaseBtn.Location = New System.Drawing.Point(0, 110)
        Me.TransactionPurchaseBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionPurchaseBtn.Name = "TransactionPurchaseBtn"
        Me.TransactionPurchaseBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.TransactionPurchaseBtn.Size = New System.Drawing.Size(243, 55)
        Me.TransactionPurchaseBtn.TabIndex = 8
        Me.TransactionPurchaseBtn.Text = "  Ingredient Purchases"
        Me.TransactionPurchaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionPurchaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransactionPurchaseBtn.UseVisualStyleBackColor = True
        '
        'TransactionDeliveryBtn
        '
        Me.TransactionDeliveryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TransactionDeliveryBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransactionDeliveryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.TransactionDeliveryBtn.FlatAppearance.BorderSize = 0
        Me.TransactionDeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionDeliveryBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionDeliveryBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TransactionDeliveryBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_delivery_truck_24
        Me.TransactionDeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionDeliveryBtn.Location = New System.Drawing.Point(0, 55)
        Me.TransactionDeliveryBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionDeliveryBtn.Name = "TransactionDeliveryBtn"
        Me.TransactionDeliveryBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.TransactionDeliveryBtn.Size = New System.Drawing.Size(243, 55)
        Me.TransactionDeliveryBtn.TabIndex = 7
        Me.TransactionDeliveryBtn.Text = "  Ingredient Delivery"
        Me.TransactionDeliveryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionDeliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransactionDeliveryBtn.UseVisualStyleBackColor = True
        '
        'TransactionSalesBtn
        '
        Me.TransactionSalesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TransactionSalesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransactionSalesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.TransactionSalesBtn.FlatAppearance.BorderSize = 0
        Me.TransactionSalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionSalesBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionSalesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TransactionSalesBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_shopping_cart_24
        Me.TransactionSalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionSalesBtn.Location = New System.Drawing.Point(0, 0)
        Me.TransactionSalesBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionSalesBtn.Name = "TransactionSalesBtn"
        Me.TransactionSalesBtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.TransactionSalesBtn.Size = New System.Drawing.Size(243, 55)
        Me.TransactionSalesBtn.TabIndex = 6
        Me.TransactionSalesBtn.Text = "  Sales Order"
        Me.TransactionSalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionSalesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransactionSalesBtn.UseVisualStyleBackColor = True
        '
        'TransactionBtn
        '
        Me.TransactionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TransactionBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransactionBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.TransactionBtn.FlatAppearance.BorderSize = 0
        Me.TransactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.TransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.TransactionBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_transaction_24
        Me.TransactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionBtn.Location = New System.Drawing.Point(0, 217)
        Me.TransactionBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionBtn.Name = "TransactionBtn"
        Me.TransactionBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.TransactionBtn.Size = New System.Drawing.Size(243, 55)
        Me.TransactionBtn.TabIndex = 13
        Me.TransactionBtn.Text = " Transactions"
        Me.TransactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransactionBtn.UseVisualStyleBackColor = True
        '
        'DashboardBtn
        '
        Me.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DashboardBtn.Image = Global.Kainan_sa_bukid_database.My.Resources.Resources.icons8_dashboard_24
        Me.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.Location = New System.Drawing.Point(0, 162)
        Me.DashboardBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.DashboardBtn.Size = New System.Drawing.Size(243, 55)
        Me.DashboardBtn.TabIndex = 0
        Me.DashboardBtn.Text = " Dashboard"
        Me.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 142)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(243, 20)
        Me.Panel2.TabIndex = 0
        '
        'LogoPanel
        '
        Me.LogoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.LogoPanel.BackgroundImage = Global.Kainan_sa_bukid_database.My.Resources.Resources.image_removebg_preview__8_
        Me.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoPanel.Location = New System.Drawing.Point(0, 20)
        Me.LogoPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(243, 122)
        Me.LogoPanel.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 20)
        Me.Panel1.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(264, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(959, 43)
        Me.Panel3.TabIndex = 1
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.White
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ContentPanel.Location = New System.Drawing.Point(264, 43)
        Me.ContentPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(959, 564)
        Me.ContentPanel.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SideNavDrawer)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.SideNavDrawer.ResumeLayout(False)
        Me.EmployeeAccordionPanel.ResumeLayout(False)
        Me.SupplierAccordionPanel.ResumeLayout(False)
        Me.IngredientAccordionPanel.ResumeLayout(False)
        Me.ProductAccordionPanel.ResumeLayout(False)
        Me.TransactionAccordionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SideNavDrawer As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents LogoPanel As System.Windows.Forms.Panel
    Friend WithEvents DashboardBtn As System.Windows.Forms.Button
    Friend WithEvents ProductsBtn As System.Windows.Forms.Button
    Friend WithEvents ProductAccordionPanel As System.Windows.Forms.Panel
    Friend WithEvents ProductDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents ProductUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents ProductAddBtn As System.Windows.Forms.Button
    Friend WithEvents ProductViewBtn As System.Windows.Forms.Button
    Friend WithEvents IngredientsBtn As System.Windows.Forms.Button
    Friend WithEvents IngredientAccordionPanel As System.Windows.Forms.Panel
    Friend WithEvents IngredientsDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents IngredientsUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents IngredientsAddBtn As System.Windows.Forms.Button
    Friend WithEvents IngredientsViewBtn As System.Windows.Forms.Button
    Friend WithEvents SupplierAccordionPanel As System.Windows.Forms.Panel
    Friend WithEvents SuppliersDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents SuppliersUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents SuppliersAddBtn As System.Windows.Forms.Button
    Friend WithEvents SuppliersViewBtn As System.Windows.Forms.Button
    Friend WithEvents SupplierBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeAccordionPanel As System.Windows.Forms.Panel
    Friend WithEvents EmployeeDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeAddBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeViewBtn As System.Windows.Forms.Button
    Friend WithEvents EmployeeBtn As System.Windows.Forms.Button
    Friend WithEvents TransactionBtn As System.Windows.Forms.Button
    Friend WithEvents TransactionAccordionPanel As System.Windows.Forms.Panel
    Friend WithEvents TransactionPurchaseBtn As System.Windows.Forms.Button
    Friend WithEvents TransactionDeliveryBtn As System.Windows.Forms.Button
    Friend WithEvents TransactionSalesBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
