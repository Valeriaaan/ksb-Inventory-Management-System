Public Class SalesForm
    Private WithEvents ProductPanel As Panel
    Private WithEvents ProductTopPanel As Panel
    Private WithEvents ProductIDLabel As Label
    Private WithEvents ProductNameLabel As Label
    Private WithEvents ProductCost As Label

    Dim PaymentMethod As String

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SalesFLP.Controls.Clear()
        SalesFLP.AutoScroll = True
        Try
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                openCon()
            ElseIf con.State = ConnectionState.Open Then
                ' Connection is already open, do nothing
            End If

            cmd.CommandText = "SELECT * FROM product"
            reader = cmd.ExecuteReader()
            While reader.Read()
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub

    Sub DisplayProducts()
        SalesFLP.Controls.Clear()
        SalesFLP.AutoScroll = True
        Try
            con.Open()
            cmd.CommandText = "SELECT p_id, p_name, p_type, p_cost FROM product"
            reader = cmd.ExecuteReader
            While reader.Read
                Load_controls()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Sub Load_controls()

        ProductPanel = New Panel
        With ProductPanel
            .Width = 190
            .Height = 100
            .BackColor = Color.FromArgb(40, 40, 40)
            .Tag = reader.Item("p_id").ToString
        End With

        ProductTopPanel = New Panel
        With ProductTopPanel
            .Width = 170
            .Height = 10
            .BackColor = Color.FromArgb(40, 40, 40)
            .Dock = DockStyle.Top
            .Tag = reader.Item("p_id").ToString
        End With

        ProductIDLabel = New Label
        With ProductIDLabel
            .ForeColor = Color.Orange
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = reader.Item("p_id").ToString
        End With

        ProductNameLabel = New Label
        With ProductNameLabel
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = reader.Item("p_id").ToString
        End With

        ProductCost = New Label
        With ProductCost
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
            .Dock = DockStyle.Top
            .Tag = reader.Item("p_id").ToString
        End With

        ProductIDLabel.Text = " Product ID         : " & reader.Item("p_id").ToString
        ProductNameLabel.Text = " Product Name  : " & reader.Item("p_name").ToString
        ProductCost.Text = " Cost                    : ₱ " & reader.Item("p_cost").ToString


        ProductPanel.Controls.Add(ProductCost)
        ProductPanel.Controls.Add(ProductNameLabel)
        ProductPanel.Controls.Add(ProductIDLabel)

        ProductPanel.Controls.Add(ProductTopPanel)
        SalesFLP.Controls.Add(ProductPanel)

        AddHandler ProductIDLabel.Click, AddressOf SelectItem_Click
        AddHandler ProductNameLabel.Click, AddressOf SelectItem_Click
        AddHandler ProductCost.Click, AddressOf SelectItem_Click
        AddHandler ProductPanel.Click, AddressOf SelectItem_Click
    End Sub

    Public Sub SelectItem_Click(sender As Object, e As EventArgs)
        openCon()
        Try
            cmd.CommandText = "SELECT p_id, p_name, p_cost FROM product WHERE p_id like '" & sender.tag.ToString & "%' "
            reader = cmd.ExecuteReader
            While reader.Read
                Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
                For Each itm As DataGridViewRow In SalesDGV.Rows
                    If itm.Cells(1).Value IsNot Nothing Then
                        If itm.Cells(1).Value.ToString = reader.Item("p_id") Then
                            exist = True
                            numrow = itm.Index
                            numtext = CInt(itm.Cells(4).Value)
                            Exit For
                        End If
                    End If

                Next

                If exist = False Then
                    Dim price As Decimal = reader("p_cost")
                    Dim subtotalprice As Double
                    subtotalprice = price * 1
                    SalesDGV.Rows.Add(SalesDGV.Rows.Count + 1, reader.Item("p_id"), reader.Item("p_name"), reader.Item("p_cost"), 1, subtotalprice)
                Else
                    SalesDGV.Rows(numrow).Cells(4).Value = CInt("1") + numtext
                    SalesDGV.Rows(numrow).Cells(5).Value = SalesDGV.Rows(numrow).Cells(3).Value * SalesDGV.Rows(numrow).Cells(4).Value
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Dispose()
        con.Close()
    End Sub

    Private Sub SalesBuyButton_Click(sender As Object, e As EventArgs) Handles SalesBuyButton.Click
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO customer (c_name, c_payment_method) VALUES ('" & SalesCustomerNameTextBox.Text & "', '" & PaymentMethod & "')"
            If MsgBox("Do you want to continue this transaction?", MsgBoxStyle.YesNo) = vbYes Then
                cmd.ExecuteNonQuery()

                For j As Integer = 0 To SalesDGV.Rows.Count - 1 Step +1
                    cmd.CommandText = "INSERT INTO orders (c_id, p_id, qty, date) VALUES ((SELECT c_id FROM customer WHERE c_name = '" & SalesCustomerNameTextBox.Text & "'),'" & SalesDGV.Rows(j).Cells(1).Value & "', '" & SalesDGV.Rows(j).Cells(4).Value & "', '" & SalesDatePicker.Text & "')"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "UPDATE ingredient SET i_qty = i_qty - (SELECT c.qty FROM contains c INNER JOIN ingredient i ON c.i_id = i.i_id WHERE c.p_id = '" & SalesDGV.Rows(j).Cells(1).Value & "' AND c.i_id = ingredient.i_id) WHERE i_id IN (SELECT i_id FROM contains WHERE p_id = '" & SalesDGV.Rows(j).Cells(1).Value & "')"

                    cmd.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Transaction complete!")
        con.Close()
    End Sub

    Sub new_order()
        DisplayProducts()
        SalesDGV.Rows.Clear()
    End Sub

    Private Sub SalesCashRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SalesCashRadioButton.CheckedChanged
        If SalesCashRadioButton.Checked = True Then
            PaymentMethod = "Cash"
        End If
    End Sub

    Private Sub SalesGcashRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SalesGcashRadioButton.CheckedChanged
        If SalesGcashRadioButton.Checked Then
            PaymentMethod = "Gcash"
        End If
    End Sub

    Private Sub SalesClearButton_Click(sender As Object, e As EventArgs) Handles SalesClearButton.Click
        SalesDGV.Rows.Clear()
    End Sub
End Class