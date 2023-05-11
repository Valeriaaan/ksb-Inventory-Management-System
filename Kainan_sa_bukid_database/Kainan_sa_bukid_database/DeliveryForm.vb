Public Class DeliveryForm

    Private Sub DeliveryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ClearTextboxes()
        DeliveryIngredientNameTextBox.Clear()
        DeliverySupplierIDTextBox.Clear()
        DeliverySupplierNameTextBox.Clear()
        DeliveryQuantityTextBox.Clear()
    End Sub

    Sub DisplayDeliveryIngredientID()
        Dim t1 As New DataTable
        openCon()
        Try
            cmd.CommandText = "SELECT * FROM ingredient WHERE s_id > 0"
            adapter.SelectCommand = cmd
            adapter.Fill(t1)

            DeliveryIngredientIDComboBox.DataSource = t1

            DeliveryIngredientIDComboBox.DisplayMember = "i_id"
            DeliveryIngredientIDComboBox.ValueMember = "i_id"

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeliveryReceiveButton_Click(sender As Object, e As EventArgs) Handles DeliveryReceiveButton.Click
        openCon()
        Try
            cmd.CommandText = "UPDATE ingredient SET i_qty = i_qty + '" & DeliveryQuantityTextBox.Text & "' WHERE i_id = '" & DeliveryIngredientIDComboBox.Text & "'"
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

    ' button exceptions
    Private Sub DeliveryQuantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DeliveryQuantityTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Delete) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub DeliveryIngredientNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles DeliveryIngredientNameTextBox.TextChanged
        CheckAllTextBoxes(DeliveryReceiveButton, Me)
    End Sub

    Private Sub DeliveryQuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles DeliveryQuantityTextBox.TextChanged
        CheckAllTextBoxes(DeliveryReceiveButton, Me)
    End Sub

    Private Sub DeliveryIngredientIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeliveryIngredientIDComboBox.SelectedIndexChanged
        If DeliveryIngredientIDComboBox.SelectedIndex > -1 Then
            Try
                cmd.CommandText = "SELECT i.i_name, i.s_id, s.s_lname, s.s_fname, s.s_minit FROM ingredient i INNER JOIN supplier s ON i.s_id = s.s_id WHERE i.i_id='" & DeliveryIngredientIDComboBox.Text & "'"

                If con.State = ConnectionState.Closed Then
                    con.Open()
                ElseIf con.State = ConnectionState.Open Then
                    ' Connection is already open, do nothing
                End If

                reader = cmd.ExecuteReader()

                If reader.Read() Then

                    Dim lname As String = reader.GetString("s_lname")
                    Dim fname As String = reader.GetString("s_fname")
                    Dim minit As String = reader.GetString("s_minit")

                    DeliveryIngredientNameTextBox.Text = reader.GetString("i_name")
                    DeliverySupplierIDTextBox.Text = reader.GetString("s_id")
                    DeliverySupplierNameTextBox.Text = lname + ", " + fname + " " + minit + "."

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