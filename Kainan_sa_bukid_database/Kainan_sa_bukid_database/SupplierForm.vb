
Public Class SupplierForm

    Private Sub SupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowSupplierTable()
    End Sub

    ' Sub Procedures 
    Sub ShowSupplierTable()
        Dim SupplierTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT s_id as 'ID', s_lname as 'Last Name', s_fname as 'First Name', s_minit as 'Middle Initial', s_address as 'Address', s_number as 'Phone Number' FROM supplier"
            adapter.SelectCommand = cmd
            SupplierTable.Clear()

            adapter.Fill(SupplierTable)
            SupplierDGV.DataSource = SupplierTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub ClearTextboxes()
        SupplierLNameTextBox.Clear()
        SupplierFNameTextBox.Clear()
        SupplierMinitTextBox.Clear()
        SupplierAddressTextBox.Clear()
        SupplierNumberTextBox.Clear()
    End Sub

    Sub DisplaySupplierID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM supplier"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)

            SupplierIDComboBox.DataSource = t1

            SupplierIDComboBox.DisplayMember = "s_id"
            SupplierIDComboBox.ValueMember = "s_id"

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub DisplayNextSupplierID()
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT MAX(s_id) FROM supplier"
            Dim result As Object = cmd.ExecuteScalar()

            If result Is DBNull.Value Then
                SupplierIDComboBox.Items.Add("40000")
                SupplierIDComboBox.Text = "40000"
            Else
                Dim finalId As Integer = CInt(result) + 1

                ' Add the incremented final id value to the SupplierIDComboBox items
                SupplierIDComboBox.Items.Add(finalId.ToString())

                ' Set the SupplierIDComboBox text to the incremented final id value
                SupplierIDComboBox.Text = finalId.ToString()
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' Supplier Button Click Handlers
    Private Sub SupplierAddButton_Click(sender As Object, e As EventArgs) Handles SupplierAddButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO supplier (s_lname,s_fname,s_minit,s_address,`s_number`) VALUES ('" & SupplierLNameTextBox.Text & "','" & SupplierFNameTextBox.Text & "', '" & SupplierMinitTextBox.Text & "', '" & SupplierAddressTextBox.Text & "', '" & SupplierNumberTextBox.Text & "')"
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
        DisplayNextSupplierID()
    End Sub

    Private Sub SupplierUpdateButton_Click(sender As Object, e As EventArgs) Handles SupplierUpdateButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE supplier SET s_lname ='" & SupplierLNameTextBox.Text & "', s_fname = '" & SupplierFNameTextBox.Text & "', s_minit = '" & SupplierMinitTextBox.Text & "', s_address = '" & SupplierAddressTextBox.Text & "', s_number = '" & SupplierNumberTextBox.Text & "' WHERE s_id = '" & SupplierIDComboBox.Text & "'"
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
        DisplaySupplierID()
    End Sub

    Private Sub SupplierDeleteButton_Click(sender As Object, e As EventArgs) Handles SupplierDeleteButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM supplier WHERE s_id = '" & SupplierIDComboBox.Text & "'"
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
        DisplaySupplierID()
    End Sub

    Private Sub SupplierClearButton_Click(sender As Object, e As EventArgs) Handles SupplierClearButton.Click
        ClearTextboxes()
    End Sub

    ' Supplier Component Conditions
    Private Sub SupplierNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SupplierNumberTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub SupplierNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierNumberTextBox.TextChanged
        If SupplierNumberTextBox.TextLength > 11 Then
            SupplierNumberTextBox.Text = SupplierNumberTextBox.Text.Substring(0, 11) ' Truncate the text to 11 characters
            SupplierNumberTextBox.SelectionStart = 11 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub SupplierMinitTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierMinitTextBox.TextChanged
        If SupplierMinitTextBox.TextLength > 1 Then
            SupplierMinitTextBox.Text = SupplierMinitTextBox.Text.Substring(0, 1) ' Truncate the text to 1 character
            SupplierMinitTextBox.SelectionStart = 1 ' Move the cursor to the end of the text
        End If
    End Sub

    Private Sub TextBoxForAdd_TextChanged(sender As Object, e As EventArgs) Handles SupplierLNameTextBox.TextChanged, SupplierFNameTextBox.TextChanged, SupplierMinitTextBox.TextChanged, SupplierAddressTextBox.TextChanged, SupplierNumberTextBox.TextChanged
        CheckAllTextBoxes(SupplierAddButton, Me)
    End Sub

    Private Sub TextBoxForUpdate_TextChanged(sender As Object, e As EventArgs) Handles SupplierLNameTextBox.TextChanged, SupplierFNameTextBox.TextChanged, SupplierMinitTextBox.TextChanged, SupplierAddressTextBox.TextChanged, SupplierNumberTextBox.TextChanged
        CheckAllTextBoxes(SupplierUpdateButton, Me)
    End Sub

    Private Sub TextBoxForDelete_TextChanged(sender As Object, e As EventArgs) Handles SupplierLNameTextBox.TextChanged, SupplierFNameTextBox.TextChanged, SupplierMinitTextBox.TextChanged, SupplierAddressTextBox.TextChanged, SupplierNumberTextBox.TextChanged
        CheckAllTextBoxes(SupplierDeleteButton, Me)
    End Sub

    Private Sub SupplierIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierIDComboBox.SelectedIndexChanged
        If SupplierIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM supplier WHERE s_id='" & SupplierIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then
                    SupplierLNameTextBox.Text = reader.GetString("s_lname")
                    SupplierFNameTextBox.Text = reader.GetString("s_fname")
                    SupplierMinitTextBox.Text = reader.GetString("s_minit")
                    SupplierAddressTextBox.Text = reader.GetString("s_address")
                    SupplierNumberTextBox.Text = reader.GetString("s_number")
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
