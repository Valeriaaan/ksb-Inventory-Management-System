Public Class ProductForm

    Private WithEvents IngredientPanel As Panel
    Private WithEvents IngredientTopPanel As Panel
    Private WithEvents IngredientIDLabel As Label
    Private WithEvents IngredientNameLabel As Label

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayIngredients()
        DisplayProductTable()
    End Sub

    ' Sub classes 
    Sub DisplayProductTable()
        Dim ProductTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT p_id as 'ID', p_name as 'Product Name', p_cost as 'Product Cost', p_type as 'Product Type' FROM product"
            adapter.SelectCommand = cmd
            ProductTable.Clear()

            adapter.Fill(ProductTable)
            ProductDGV.DataSource = ProductTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ClearTextboxes()
        ProductNameTextBox.DataBindings.Clear()
        ProductCostTextBox.DataBindings.Clear()
        ProductTypeTextBox.DataBindings.Clear()

        ProductNameTextBox.Text = ""
        ProductCostTextBox.Text = ""
        ProductTypeTextBox.Text = ""
    End Sub

    Sub DisplayProductID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM product"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)

            ProductIDComboBox.DataSource = t1

            ProductIDComboBox.DisplayMember = "p_name"
            ProductIDComboBox.ValueMember = "p_id"

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub DisplayNextProductID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(p_id) FROM product"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                ProductIDComboBox.Items.Add("1")
                ProductIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                ProductIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                ProductIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Button clicks
    Private Sub ProductAddButton_Click(sender As Object, e As EventArgs) Handles ProductAddButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO product (p_name,`p_cost`,p_type) VALUES ('" & ProductNameTextBox.Text & "','" & ProductCostTextBox.Text & "', '" & ProductTypeTextBox.Text & "')"
            If MsgBox("Do you want to save this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("New Record Added.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        ClearTextboxes()
        DisplayNextProductID()
    End Sub

    Private Sub ProductUpdateButton_Click(sender As Object, e As EventArgs) Handles ProductUpdateButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE product SET p_name ='" & ProductNameTextBox.Text & "', p_cost = '" & ProductCostTextBox.Text & "', p_type = '" & ProductTypeTextBox.Text & "' WHERE p_id = '" & ProductIDComboBox.Text & "'"
            If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Updated.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        ClearTextboxes()
        DisplayProductID()
    End Sub

    Private Sub ProductDeleteButton_Click(sender As Object, e As EventArgs) Handles ProductDeleteButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM product WHERE p_id = '" & ProductIDComboBox.Text & "'"
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Record Has Been Deleted.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        ClearTextboxes()
        DisplayProductID()
    End Sub


    Private Sub UpdateProductIngredientsButton_Click(sender As Object, e As EventArgs) Handles UpdateProductIngredientsButton.Click
        AddProductIngredientsPanel.Show()
        AddProductIngredientsPanel.BringToFront()
    End Sub

    Private Sub ProductClearButton_Click(sender As Object, e As EventArgs) Handles ProductClearButton.Click
        ClearTextboxes()
    End Sub

    ' Button exceptions

    Private Sub ProductCostTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductCostTextBox.KeyPress
        ' Allow only digits, decimal separator, backspace and delete keys
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ".") AndAlso (e.KeyChar <> ",") AndAlso (e.KeyChar <> ChrW(Keys.Back)) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Ignore the keypress
        End If

        ' Allow only one decimal separator
        If (e.KeyChar = ".") OrElse (e.KeyChar = ",") Then
            If ProductCostTextBox.Text.Contains(".") OrElse ProductCostTextBox.Text.Contains(",") Then
                e.Handled = True ' Ignore the keypress
            End If
        End If
    End Sub

    Private Sub TextBoxForAdd_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged, ProductCostTextBox.TextChanged, ProductTypeTextBox.TextChanged
        CheckAllTextBoxes(ProductAddButton, Me)
    End Sub

    Private Sub TextBoxForUpdate_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged, ProductCostTextBox.TextChanged, ProductTypeTextBox.TextChanged
        CheckAllTextBoxes(ProductUpdateButton, Me)
    End Sub

    Private Sub TextBoxForDelete_TextChanged(sender As Object, e As EventArgs) Handles ProductNameTextBox.TextChanged, ProductCostTextBox.TextChanged, ProductTypeTextBox.TextChanged
        CheckAllTextBoxes(ProductDeleteButton, Me)
    End Sub

    Private Sub ProductIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductIDComboBox.SelectedIndexChanged
        If ProductIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM product WHERE p_name='" & ProductIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    ProductNameTextBox.Text = reader.GetString("p_id")
                    ProductCostTextBox.Text = reader.GetString("p_cost")
                    ProductTypeTextBox.Text = reader.GetString("p_type")
                End If
                reader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub


    ' --------------------------------------------------ADDING INGREDIENTS--------------------------------------------'
    Sub DisplayIngredients()
        ProductIngredientFLP.Controls.Clear()
        ProductIngredientFLP.AutoScroll = True
        Try
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                openCon()
            ElseIf con.State = ConnectionState.Open Then
                ' Connection is already open, do nothing
            End If

            cmd.CommandText = "SELECT * FROM ingredient"
            reader = cmd.ExecuteReader()
            While reader.Read()
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub


    Sub Load_controls()

        IngredientPanel = New Panel
        With IngredientPanel
            .Width = 190
            .Height = 70
            .BackColor = Color.FromArgb(40, 40, 40)
            .Tag = reader.Item("i_id").ToString
        End With

        IngredientTopPanel = New Panel
        With IngredientTopPanel
            .Width = 170
            .Height = 10
            .BackColor = Color.FromArgb(40, 40, 40)
            .Dock = DockStyle.Top
            .Tag = reader.Item("i_id").ToString
        End With

        IngredientIDLabel = New Label
        With IngredientIDLabel
            .ForeColor = Color.Orange
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = reader.Item("i_id").ToString
        End With

        IngredientNameLabel = New Label
        With IngredientNameLabel
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = reader.Item("i_id").ToString
        End With

        IngredientIDLabel.Text = " Ingredient ID         : " & reader.Item("i_id").ToString
        IngredientNameLabel.Text = " Ingredient Name  : " & reader.Item("i_name").ToString

        IngredientPanel.Controls.Add(IngredientNameLabel)
        IngredientPanel.Controls.Add(IngredientIDLabel)

        IngredientPanel.Controls.Add(IngredientTopPanel)
        ProductIngredientFLP.Controls.Add(IngredientPanel)

        AddHandler IngredientIDLabel.Click, AddressOf SelectIngredient_Click
        AddHandler IngredientNameLabel.Click, AddressOf SelectIngredient_Click
        AddHandler IngredientPanel.Click, AddressOf SelectIngredient_Click
    End Sub

    Public Sub SelectIngredient_Click(sender As Object, e As EventArgs)
        openCon()
        Try
            cmd.CommandText = "SELECT i_id, i_name, i_qty FROM ingredient WHERE i_id like '" & sender.tag.ToString & "%' "
            reader = cmd.ExecuteReader
            While reader.Read
                Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
                For Each itm As DataGridViewRow In ProductIngredientDGV.Rows
                    If itm.Cells(1).Value IsNot Nothing Then
                        If itm.Cells(1).Value.ToString = reader.Item("i_id") Then
                            exist = True
                            numrow = itm.Index
                            numtext = CInt(itm.Cells(3).Value)
                            Exit For
                        End If
                    End If

                Next

                If exist = False Then
                    ProductIngredientDGV.Rows.Add(ProductIngredientDGV.Rows.Count + 1, reader.Item("i_id"), reader.Item("i_name"), 1)
                Else
                    ProductIngredientDGV.Rows(numrow).Cells(3).Value = CInt("1") + numtext
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Dispose()
        con.Close()
    End Sub

    Private Sub AddProductIngredientButton_Click(sender As Object, e As EventArgs) Handles AddProductIngredientButton.Click
        openCon()
        Try
            cmd.Connection = con
            If MsgBox("Do you want to add the following ingredients to this product?", MsgBoxStyle.YesNo) = vbYes Then
                For j As Integer = 0 To ProductIngredientDGV.Rows.Count - 1 Step +1
                    cmd.CommandText = "INSERT INTO contains (p_id, i_id, qty) VALUES ((SELECT p_id FROM product WHERE p_name = '" & ProductIngredientNameTextBox.Text & "'), '" & ProductIngredientDGV.Rows(j).Cells(1).Value & "','" & ProductIngredientDGV.Rows(j).Cells(3).Value & "')"
                    cmd.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Ingredients added!")
        con.Close()
    End Sub

End Class