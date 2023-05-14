Public Class RestockForm

    Private Sub RestockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub DisplayRestockIDs()
        Dim t1 As New DataTable
        Dim t2 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM ingredient"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)

            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(t2)

            RestockIngredientIDComboBox.DataSource = t1
            RestockIngredientIDComboBox.DisplayMember = "i_id"
            RestockIngredientIDComboBox.ValueMember = "i_id"

            RestockEmployeeIDComboBox.DataSource = t2
            RestockEmployeeIDComboBox.DisplayMember = "e_id"
            RestockEmployeeIDComboBox.ValueMember = "e_id"

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub ClearTextboxes()
        RestockEmployeeNameTextBox.Clear()
        RestockIngredientNameTextBox.Clear()
        RestockQuantityTextBox.Clear()
        RestockCostTextBox.Clear()
    End Sub

    ' Restok Button Click Handlers
    Private Sub RestockAddStockButton_Click(sender As Object, e As EventArgs) Handles RestockAddStockButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO buy_by (i_id,e_id,qty,date,cost) VALUES ('" & RestockIngredientIDComboBox.Text & "','" & RestockEmployeeIDComboBox.Text & "', '" & RestockQuantityTextBox.Text & "', '" & RestockDatePicker.Text & "', '" & RestockCostTextBox.Text & "' )"

            cmd.CommandText = "INSERT INTO handle_by (i_id,e_id,qty,date) VALUES ('" & RestockIngredientIDComboBox.Text & "','" & RestockEmployeeIDComboBox.Text & "', '" & RestockQuantityTextBox.Text & "', '" & RestockDatePicker.Text & "', '" & RestockCostTextBox.Text & "' )"

            cmd.CommandText = "UPDATE ingredient SET i_qty = i_qty + " & RestockQuantityTextBox.Text & " WHERE i_id = '" & RestockIngredientIDComboBox.Text & "'"

            If MsgBox("Receive delivery update the record?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()
                MsgBox("Delivery Received and Record Has Been Updated.")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        ClearTextboxes()
    End Sub

    ' Restock Component Conditions 
    Private Sub RestockCostTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RestockCostTextBox.KeyPress
        ' Allow only digits, decimal separator, backspace and delete keys
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ".") AndAlso (e.KeyChar <> ",") AndAlso (e.KeyChar <> ChrW(Keys.Back)) AndAlso (e.KeyChar <> ChrW(Keys.Delete)) Then
            e.Handled = True ' Ignore the keypress
        End If

        ' Allow only one decimal separator
        If (e.KeyChar = ".") OrElse (e.KeyChar = ",") Then
            If RestockCostTextBox.Text.Contains(".") OrElse RestockCostTextBox.Text.Contains(",") Then
                e.Handled = True ' Ignore the keypress
            End If
        End If
    End Sub

    Private Sub RestockQuantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RestockQuantityTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub RestockIngredientNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles RestockIngredientNameTextBox.TextChanged
        CheckAllTextBoxes(RestockAddStockButton, Me)
    End Sub

    Private Sub RestockEmployeeNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles RestockEmployeeNameTextBox.TextChanged
        CheckAllTextBoxes(RestockAddStockButton, Me)
    End Sub

    Private Sub RestockQuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles RestockQuantityTextBox.TextChanged
        CheckAllTextBoxes(RestockAddStockButton, Me)
    End Sub

    Private Sub RestockCostTextBox_TextChanged(sender As Object, e As EventArgs) Handles RestockCostTextBox.TextChanged
        CheckAllTextBoxes(RestockAddStockButton, Me)
    End Sub

    Private Sub RestockIngredientIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RestockIngredientIDComboBox.SelectedIndexChanged
        If RestockIngredientIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM ingredient WHERE i_id='" & RestockIngredientIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    RestockIngredientNameTextBox.Text = reader.GetString("i_name")
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub RestockEmployeeIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RestockEmployeeIDComboBox.SelectedIndexChanged
        If RestockEmployeeIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM employee WHERE e_id='" & RestockEmployeeIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim fname As String = reader.GetString("e_fname")
                    Dim lname As String = reader.GetString("e_lname")
                    Dim minit As String = reader.GetString("e_minit")
                    RestockEmployeeNameTextBox.Text = lname + ", " + fname + " " + minit
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