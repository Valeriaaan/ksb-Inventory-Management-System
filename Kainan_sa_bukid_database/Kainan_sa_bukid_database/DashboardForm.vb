Public Class DashboardForm

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayNumberInDashboard("product", ProductRegisteredLabel)
        DisplayNumberInDashboard("ingredient", IngredientsRegisteredLabel)
        DisplayNumberInDashboard("supplier", NumberOfSuppliersLabel)
        DisplayNumberInDashboard("employee", NumberOfEmployeesLabel)
        DisplayRecentPurchasesTable()
    End Sub

    Sub DisplayRecentDeliveryTable()
        Dim RecentDeliveryTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT s_id as 'ID', s_lname as 'Last Name', s_fname as 'First Name', s_minit as 'Middle Initial', s_address as 'Address', s_number as 'Phone Number' FROM supplier"
            adapter.SelectCommand = cmd
            RecentDeliveryTable.Clear()

            adapter.Fill(RecentDeliveryTable)
            RecentDeliveryDGV.DataSource = RecentDeliveryTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub DisplayRecentPurchasesTable()
        Dim RecentPurchasesTable As New DataTable
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT i_id as 'Ingredient ID', e_id as 'Employee ID', date as 'Date', qty as 'Quantity', cost as 'Cost' FROM buy_by"
            adapter.SelectCommand = cmd
            RecentPurchasesTable.Clear()

            adapter.Fill(RecentPurchasesTable)
            RecentPurchasesDGV.DataSource = RecentPurchasesTable

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub DisplayNumberInDashboard(TableName, LabelName)
        Dim count As Integer = 0
        openCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM " & TableName
            count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                LabelName.Text = count.ToString()
            Else
                LabelName.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class