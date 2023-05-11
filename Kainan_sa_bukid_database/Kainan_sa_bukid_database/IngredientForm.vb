Public Class IngredientForm

    Private Sub ingredients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayIngredientTable()
    End Sub

    Sub DisplayIngredientTable()
        Dim IngredientTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT i_id as 'ID', i_name as 'Name', i_expiration_date as 'Expiration Date', i_qty as 'Quantity', s_id as 'Supplier ID' FROM ingredient"
            adapter.SelectCommand = cmd
            IngredientTable.Clear()

            adapter.Fill(IngredientTable)
            IngredientDGV.DataSource = IngredientTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ClearTextboxes()
        IngredientNameTextBox.Clear()
        IngredientQuantityTextBox.Clear()
    End Sub

    Sub DisplayIngredientID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM ingredient"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)
            IngredientIDComboBox.DataSource = t1
            IngredientIDComboBox.DisplayMember = "i_id"
            IngredientIDComboBox.ValueMember = "i_id"
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub DisplayIngredientSupplierID()
        Dim t2 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t2)

            IngredientSupplierIDComboBox.DataSource = t2
            IngredientSupplierIDComboBox.DisplayMember = "s_id"
            IngredientSupplierIDComboBox.ValueMember = "s_id"
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub DisplayNextIngredientID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(i_id) FROM ingredient"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                IngredientIDComboBox.Items.Add("10000")
                IngredientIDComboBox.Text = "10000"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                IngredientIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                IngredientIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub IngredientAddButton_Click(sender As Object, e As EventArgs) Handles IngredientAddButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO ingredient (i_name,i_expiration_date,s_id) VALUES ('" & IngredientNameTextBox.Text & "','" & IngredientExpDatePicker.Text & "', '" & IngredientSupplierIDComboBox.Text & "')"
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
        DisplayIngredientID()
        DisplayIngredientSupplierID()
    End Sub

    Private Sub IngredientUpdateButton_Click(sender As Object, e As EventArgs) Handles IngredientUpdateButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE ingredient SET i_name ='" & IngredientNameTextBox.Text & "', i_expiration_date = '" & IngredientExpDatePicker.Text & "', i_qty = '" & IngredientQuantityTextBox.Text & "',s_id = '" & IngredientSupplierIDComboBox.Text & "' WHERE i_id = '" & IngredientIDComboBox.Text & "'"
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
        DisplayIngredientID()
        DisplayIngredientSupplierID()
    End Sub

    Private Sub IngredientDeleteButton_Click(sender As Object, e As EventArgs) Handles IngredientDeleteButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM ingredient WHERE i_id = '" & IngredientIDComboBox.Text & "'"
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
        DisplayIngredientID()
        DisplayIngredientSupplierID()
    End Sub

    Private Sub IngredientClearButton_Click(sender As Object, e As EventArgs) Handles IngredientClearButton.Click
        ClearTextboxes()
    End Sub

    ' Button exceptions
    Private Sub IngredientQuantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IngredientQuantityTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub TextBoxForAdd_TextChanged(sender As Object, e As EventArgs) Handles IngredientNameTextBox.TextChanged
        If IngredientNameTextBox.TextLength > 0 Then
            IngredientAddButton.Enabled = True
        Else
            IngredientAddButton.Enabled = False
        End If
    End Sub

    Private Sub TextBoxForUpdate_TextChanged(sender As Object, e As EventArgs) Handles IngredientNameTextBox.TextChanged
        If IngredientNameTextBox.TextLength > 0 Then
            IngredientUpdateButton.Enabled = True
        Else
            IngredientUpdateButton.Enabled = False
        End If
    End Sub

    Private Sub TextBoxForDelete_TextChanged(sender As Object, e As EventArgs) Handles IngredientNameTextBox.TextChanged
        If IngredientNameTextBox.TextLength > 0 Then
            IngredientDeleteButton.Enabled = True
        Else
            IngredientDeleteButton.Enabled = False
        End If
    End Sub

    Private Sub IngredientIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IngredientIDComboBox.SelectedIndexChanged
        If IngredientIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM ingredient WHERE i_id='" & IngredientIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    IngredientNameTextBox.Text = reader.GetString("i_name")
                    IngredientExpDatePicker.Text = reader.GetString("i_expiration_date")
                    IngredientQuantityTextBox.Text = reader.GetString("i_qty")
                    IngredientSupplierIDComboBox.Text = reader.GetString("s_id")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

End Class