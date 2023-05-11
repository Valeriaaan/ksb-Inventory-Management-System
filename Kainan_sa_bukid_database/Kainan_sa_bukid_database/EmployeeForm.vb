Public Class EmployeeForm
    Dim sex As String
    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployeeTable()
    End Sub

    ' Sub classes 
    Sub DisplayEmployeeTable()
        Dim EmployeeTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT e_id as 'ID', e_lname as 'Last Name', e_fname as 'First Name', e_minit as 'Middle Initial', e_sex as 'Sex', e_address as 'Address', e_number as 'Phone Number' FROM employee"
            adapter.SelectCommand = cmd
            EmployeeTable.Clear()

            adapter.Fill(EmployeeTable)
            EmployeeDGV.DataSource = EmployeeTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ClearTextboxes()
        EmployeeLNameTextBox.Clear()
        EmployeeFNameTextBox.Clear()
        EmployeeMinitTextBox.Clear()
        EmployeeMaleRadioButton.Checked = False
        EmployeeFemaleRadioButton.Checked = False
        EmployeeAddressTextBox.Clear()
        EmployeeNumberTextBox.Clear()
    End Sub

    Sub DisplayEmployeeID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM employee"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)

            EmployeeIDComboBox.DataSource = t1

            EmployeeIDComboBox.DisplayMember = "e_id"
            EmployeeIDComboBox.ValueMember = "e_id"

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub DisplayNextEmployeeID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(e_id) FROM employee"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                EmployeeIDComboBox.Items.Add("1")
                EmployeeIDComboBox.Text = "1"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                EmployeeIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                EmployeeIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EmployeeMaleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EmployeeMaleRadioButton.CheckedChanged
        EmployeeMaleRadioButton.Enabled = True
        sex = "Male"
    End Sub
    Private Sub EmployeeFemaleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EmployeeFemaleRadioButton.CheckedChanged
        EmployeeFemaleRadioButton.Enabled = True
        sex = "Female"
    End Sub

    ' Button Clicks
    Private Sub EmployeeAddButton_Click(sender As Object, e As EventArgs) Handles EmployeeAddButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO employee (e_lname,e_fname,e_minit,e_sex,e_address,`e_number`) VALUES ('" & EmployeeLNameTextBox.Text & "','" & EmployeeFNameTextBox.Text & "', '" & EmployeeMinitTextBox.Text & "', '" & sex & "','" & EmployeeAddressTextBox.Text & "', '" & EmployeeNumberTextBox.Text & "')"
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
        DisplayNextEmployeeID()
    End Sub

    Private Sub EmployeeUpdateButton_Click(sender As Object, e As EventArgs) Handles EmployeeUpdateButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE employee SET e_lname = '" & EmployeeLNameTextBox.Text & "', e_fname = '" & EmployeeFNameTextBox.Text & "', e_minit = '" & EmployeeMinitTextBox.Text & "', e_sex = '" & sex & "', e_address = '" & EmployeeAddressTextBox.Text & "', e_number = '" & EmployeeNumberTextBox.Text & "' WHERE e_id = '" & EmployeeIDComboBox.Text & "'"
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
        DisplayEmployeeID()
    End Sub

    Private Sub EmployeeDeleteButton_Click(sender As Object, e As EventArgs) Handles EmployeeDeleteButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM employee WHERE e_id = '" & EmployeeIDComboBox.Text & "'"
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
        DisplayEmployeeID()
    End Sub

    Private Sub EmployeeClearButton_Click(sender As Object, e As EventArgs) Handles EmployeeClearButton.Click
        ClearTextboxes()
    End Sub

    ' Button exceptions
    Private Sub EmployeeNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeNumberTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub EmployeeNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeNumberTextBox.TextChanged
        If EmployeeNumberTextBox.TextLength > 11 Then
            EmployeeNumberTextBox.Text = EmployeeNumberTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            EmployeeNumberTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub EmployeeMinitTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeMinitTextBox.TextChanged
        If EmployeeMinitTextBox.TextLength > 1 Then
            EmployeeMinitTextBox.Text = EmployeeMinitTextBox.Text.Substring(0, 1) ' Truncate the text to 1 character
            EmployeeMinitTextBox.SelectionStart = 1 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub TextBoxForAdd_TextChanged(sender As Object, e As EventArgs) Handles EmployeeLNameTextBox.TextChanged, EmployeeFNameTextBox.TextChanged, EmployeeMinitTextBox.TextChanged, EmployeeAddressTextBox.TextChanged, EmployeeNumberTextBox.TextChanged
        CheckAllTextBoxes(EmployeeAddButton, Me)
    End Sub

    Private Sub TextBoxForUpdate_TextChanged(sender As Object, e As EventArgs) Handles EmployeeLNameTextBox.TextChanged, EmployeeFNameTextBox.TextChanged, EmployeeMinitTextBox.TextChanged, EmployeeAddressTextBox.TextChanged, EmployeeNumberTextBox.TextChanged
        CheckAllTextBoxes(EmployeeUpdateButton, Me)
    End Sub

    Private Sub TextBoxForDelete_TextChanged(sender As Object, e As EventArgs) Handles EmployeeLNameTextBox.TextChanged, EmployeeFNameTextBox.TextChanged, EmployeeMinitTextBox.TextChanged, EmployeeAddressTextBox.TextChanged, EmployeeNumberTextBox.TextChanged
        CheckAllTextBoxes(EmployeeDeleteButton, Me)
    End Sub

    Private Sub EmployeeIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmployeeIDComboBox.SelectedIndexChanged
        If EmployeeIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM employee WHERE e_id='" & EmployeeIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    EmployeeLNameTextBox.Text = reader.GetString("e_lname")
                    EmployeeFNameTextBox.Text = reader.GetString("e_fname")
                    EmployeeMinitTextBox.Text = reader.GetString("e_minit")
                    EmployeeAddressTextBox.Text = reader.GetString("e_address")
                    EmployeeNumberTextBox.Text = reader.GetString("e_number")
                    sex = reader.GetString("e_sex")

                    If sex = "Male" Then
                        EmployeeMaleRadioButton.Checked = True
                    ElseIf sex = "Female" Then
                        EmployeeFemaleRadioButton.Checked = True
                    End If

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