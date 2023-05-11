Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public reader As MySqlDataReader
    Public data As New DataSet
    Public t As New DataTable
    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=;database=testing1"
        con.Open()
    End Sub

    Sub CheckAllTextBoxes(ComponentName, FormName)
        Dim allFilled As Boolean = True
        For Each ctrl As Control In FormName.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text = "" Then
                    allFilled = False
                    Exit For
                End If
            End If
        Next
        ComponentName.Enabled = allFilled
    End Sub

End Module
