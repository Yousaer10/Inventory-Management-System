'Represents an open connection to a data source
Imports System.Data.OleDb

Public Class frmInventory

    'The stock ID is set to -1 to show it is a new stock and that we are not editing a stock
    Private CurrentStockID As Integer = -1

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideSubMenus()
        LoadComponents()
        Timer3.Enabled = True
        BtnClear.PerformClick()
        BtnStockDelete.Enabled = False
        BtnUpdate.Enabled = False
        TxtStockIn.Enabled = False
        TxtStockOut.Enabled = False
        'Display username
        LblPublicUsername.Text = PublicUsername
        'Enable timer
        Timer2.Enabled = True
        CheckAccessLevel()
    End Sub

    Private Sub CheckAccessLevel()
        'If user has just registered then
        If PublicAccessLevel = 0 Then
            'Disable all buttons
            BtnOpenInventory.Enabled = False
            BtnOpenReminder.Enabled = False
            BtnOpenRepair.Enabled = False
            BtnOpenAdmin.Enabled = False
        ElseIf PublicAccessLevel = 1 Then
            'Enable view repairs button
            BtnOpenInventory.Enabled = False
            BtnOpenReminder.Enabled = False
            BtnOpenSetRepairs.Enabled = False
            BtnOpenAdmin.Enabled = False
        ElseIf PublicAccessLevel = 2 Then
            'Disable Admin button
            BtnOpenAdmin.Enabled = False
        End If
    End Sub

    Private Sub LoadComponents()
        CmbBrand.Items.Clear
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "SELECT DISTINCT STBrand FROM TblStock"
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        CmbBrand.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
        CmbCategory.Items.Clear()
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select DISTINCT STCategory FROM TblStock"
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        CmbCategory.Items.Add(rs(0).ToString)
                    End While
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'The clearing event is separated from UI
        ClearStockFields()
    End Sub

    Private Sub ClearStockFields()
        CurrentStockID = -1
        TxtStockID.Text = "<Automatically Generated>"
        DTPickerStockDateTime.Text = ""
        TxtCategory.Text = ""
        TxtBrand.Text = ""
        TxtItemDescription.Text = ""
        TxtSerialNumber.Text = ""
        TxtStockIn.Text = ""
        TxtStockOut.Text = ""
        LblStock.Text = ""
        BtnStockDelete.Enabled = False
        BtnUpdate.Enabled = False
        TxtStockIn.Text = "0"
        TxtStockOut.Text = "0"
        LblStock.Text = "0"
        TxtStockIn.Enabled = False
        TxtStockOut.Enabled = False
        BtnNewEntry.Enabled = True
    End Sub

    Dim StockIn1 As Integer
    Dim StockOut2 As Integer

    Private Sub BtnNewEntry_Click(sender As Object, e As EventArgs) Handles BtnNewEntry.Click
        StockNewEntry()
    End Sub

    Private Sub StockNewEntry()
        If TxtCategory.Text.Trim.Length = 0 Then
            MessageBox.Show("No Category entered!" & vbCrLf, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCategory.Focus()

        ElseIf TxtBrand.Text.Trim.Length = 0 Then
            MessageBox.Show("No Brand entered!" & vbCrLf, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtBrand.Focus()

        ElseIf TxtItemDescription.Text.Trim.Length = 0 Then
            MessageBox.Show("No Item Description entered!" & vbCrLf, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtItemDescription.Focus()

        ElseIf TxtSerialNumber.Text.Trim.Length = 0 Then
            MessageBox.Show("No Serial Number entered!" & vbCrLf, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtSerialNumber.Focus()

            'If connected to database
        ElseIf DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd

                '----------------------
                'Adding a New Customer
                '----------------------
                CurrentStockID = -1
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Insert into TblStock (STCategory, STBrand, STItemDescription, STSerialNumber, STDateTime, StockIn, StockOut, Stock)"
                .CommandText &= "Values (@Category, @Brand, @ItemDescription, @SerialNumber, @DateTime, @StockIn, @StockOut, @Stock)"
                .Parameters.AddWithValue("@Category", TxtCategory.Text)
                .Parameters.AddWithValue("@Brand", TxtBrand.Text)
                .Parameters.AddWithValue("@ItemDescription", TxtItemDescription.Text)
                .Parameters.AddWithValue("@SerialNumber", TxtSerialNumber.Text)
                .Parameters.AddWithValue("@DateTime", DTPickerStockDateTime.Text)
                .Parameters.AddWithValue("@StockIn", TxtStockIn.Text)
                .Parameters.AddWithValue("@StockOut", TxtStockOut.Text)
                .Parameters.AddWithValue("@Stock", LblStock.Text)
                'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                .ExecuteNonQuery()

                'Now get the auto generated ID of this new stock
                .CommandText = "Select @@Identity"
                'ExecuteScalar - only 1 value back ie, create a new ID.
                CurrentStockID = .ExecuteScalar
                TxtStockID.Text = CurrentStockID
            End With
            'Close database connection
            cn.Close()
            LoadComponents()
            MessageBox.Show("Stock item has been saved." & vbCrLf, "New Stock Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        DTPickerStockDateTime.Text = Date.Now.ToString("HH:mm      dd/MM/yyyy")
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        CallUpdate()
    End Sub

    Private Sub CallUpdate()
        Try
            StockIn1 = TxtStockIn.Text
            StockOut2 = TxtStockOut.Text
            'Calculate stock
            LblStock.Text = StockIn1 - StockOut2
            'If Stock level is 0 then
            If LblStock.Text = "0" Then
                'Notify user
                MessageBox.Show("Note: No more stock available, please reorder stock." & vbCrLf, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'If stock level is less than 0 then
            ElseIf LblStock.Text < 0 Then
                'Display error message
                MessageBox.Show("Error: Stock In must be larger than Stock Out." & vbCrLf, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '
            ElseIf IsNumeric(TxtStockIDSearch.Text) Then
                UpdateStockID(TxtStockIDSearch.Text)
            ElseIf TxtItemDescriptionSearch.Text.Length > 0 Then
                UpdateItemDescription(TxtItemDescriptionSearch.Text)
            ElseIf IsNumeric(TxtStockID.Text) Then
                UpdateStockID(TxtStockID.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Please make sure you have entered stock in and stock out." & vbCrLf, "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub UpdateStockID(StockID As Integer)
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Update TblStock Set STCategory = @Category, STBrand = @Brand, STItemDescription = @ItemDescription, STSerialNumber = @SerialNumber, STDateTime = @DateTime, StockIn = @StockIn, StockOut = @StockOut, Stock = @Stock where StockID = @CurrentStockID"
                .Parameters.AddWithValue("@Category", TxtCategory.Text)
                .Parameters.AddWithValue("@Brand", TxtBrand.Text)
                .Parameters.AddWithValue("@ItemDescription", TxtItemDescription.Text)
                .Parameters.AddWithValue("@SerialNumber", TxtSerialNumber.Text)
                .Parameters.AddWithValue("@DateTime", DTPickerStockDateTime.Text)
                .Parameters.AddWithValue("@StockIn", TxtStockIn.Text)
                .Parameters.AddWithValue("@StockOut", TxtStockOut.Text)
                .Parameters.AddWithValue("@Stock", LblStock.Text)
                .Parameters.AddWithValue("@StockID", CurrentStockID)
                'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                .ExecuteNonQuery()
                MessageBox.Show("Stock Information has been updated." & vbCrLf, "Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub UpdateItemDescription(STItemDescription As String)
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Update TblStock Set STCategory = @Category, STBrand = @Brand, STSerialNumber = @SerialNumber, STDateTime = @DateTime, StockIn = @StockIn, StockOut = @StockOut, Stock = @Stock where STItemDescription = @ItemDescription and StockID = @StockID"
                .Parameters.AddWithValue("@Category", TxtCategory.Text)
                .Parameters.AddWithValue("@Brand", TxtBrand.Text)

                .Parameters.AddWithValue("@SerialNumber", TxtSerialNumber.Text)
                .Parameters.AddWithValue("@DateTime", DTPickerStockDateTime.Text)
                .Parameters.AddWithValue("@StockIn", TxtStockIn.Text)
                .Parameters.AddWithValue("@StockOut", TxtStockOut.Text)
                .Parameters.AddWithValue("@Stock", LblStock.Text)
                .Parameters.AddWithValue("@ItemDescription", TxtItemDescription.Text)
                .Parameters.AddWithValue("@StockID", CurrentStockID)
                'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                .ExecuteNonQuery()
                MessageBox.Show("Stock Information has been updated." & vbCrLf, "Update Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub BtnEditSearch_Click(sender As Object, e As EventArgs) Handles BtnEditSearch.Click
        CallEditSearch()
    End Sub

    Private Sub CallEditSearch()
        If IsNumeric(TxtStockIDSearch.Text) Then

            '--------------------
            'Find Customer by ID
            '--------------------
            DisplayStock(TxtStockIDSearch.Text)

        ElseIf TxtItemDescriptionSearch.Text.Trim.Length = 0 Then
            MessageBox.Show("Please enter an Item Description or Stock ID to search.", "Find Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf TxtItemDescriptionSearch.Text.Length > 0 Then
            'If connected to database
            If DbConnect() Then
                LstStock.Items.Clear()
                Dim SQLCmd As New OleDbCommand
                'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
                With SQLCmd
                    'SQLCmd is uses the connection to save the following information
                    .Connection = cn
                    .CommandText = "Select * From TblStock Where STItemDescription Like @ItemDescriptionSearch"
                    .Parameters.AddWithValue("@ItemDescriptionSearch", "%" & TxtItemDescriptionSearch.Text & "%")
                    Try
                        'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                        Dim rs As OleDbDataReader = .ExecuteReader()
                        'Loops into reading a record set until it stops reading for a record so rs.Read = false
                        While rs.Read
                            Dim DisplayValue As String = rs("STDateTime") & " " & rs("STCategory") & " (" & rs("STBrand") & ")"
                            Dim StockItem As New ListBoxData(DisplayValue, rs("StockID"))
                            LstStock.Items.Add(StockItem)
                        End While
                        rs.Close()
                    Catch ex As Exception
                        If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                            Me.Close()
                        End If
                    End Try
                    If LstStock.Items.Count = 1 Then
                        'Only one name in the list so may as well click on it
                        LstStock.SelectedIndex = 0
                    ElseIf LstStock.Items.Count > 1 Then
                        'Show the list
                        PanSearchList.Visible = True
                    Else
                        MessageBox.Show("There are no Stock Items with that Item Description", "Find Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End With
                'Close database connection
                cn.Close()
            End If
        End If
    End Sub

    Private Sub DisplayStock(StockID As Integer)
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStock where StockID = @SearchID"
                .Parameters.AddWithValue("@SearchID", StockID)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    '----------------------------
                    'DisplayStock(Stock ID)
                    '----------------------------
                    If rs.Read Then
                        CurrentStockID = StockID   '-1 newcustomer only code
                        TxtStockID.Text = rs("StockID")
                        PublicStockID = TxtStockID.Text
                        DTPickerStockDateTime.Value = rs("STDateTime")
                        TxtCategory.Text = rs("STCategory")
                        TxtBrand.Text = rs("STBrand")
                        TxtItemDescription.Text = rs("STItemDescription")
                        TxtSerialNumber.Text = rs("STSerialNumber")
                        TxtStockIn.Text = rs("StockIn")
                        TxtStockOut.Text = rs("StockOut")
                        LblStock.Text = rs("Stock")
                        BtnStockDelete.Enabled = True
                        BtnUpdate.Enabled = True
                        TxtStockIn.Enabled = True
                        TxtStockOut.Enabled = True
                        BtnNewEntry.Enabled = False
                    Else
                        MessageBox.Show("Could not find a Stock with the following ID " & StockID, "Find Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub DisplayStockItemDescription(STItemDescription As String)
        'If connected to database
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information3
                .Connection = cn
                .CommandText = "Select * From TblStock where STItemDescription = @SearchDescriptionID"
                .Parameters.AddWithValue("@SearchDescriptionID", STItemDescription)
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    '----------------------------
                    'Display stock info 
                    '----------------------------
                    If rs.Read Then

                        TxtStockID.Text = rs("StockID")
                        PublicStockID = TxtStockID.Text
                        DTPickerStockDateTime.Value = rs("STDateTime")
                        TxtCategory.Text = rs("STCategory")
                        TxtBrand.Text = rs("STBrand")
                        TxtItemDescription.Text = rs("STItemDescription")
                        TxtSerialNumber.Text = rs("STSerialNumber")
                        TxtStockIn.Text = rs("StockIn")
                        TxtStockOut.Text = rs("StockOut")
                        BtnStockDelete.Enabled = True
                        BtnUpdate.Enabled = True
                        TxtStockIn.Enabled = True
                        TxtStockOut.Enabled = True
                    Else
                        MessageBox.Show("There are no Stock Items with that Item Description", "Find Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
            'Close database connection
            cn.Close()
        End If
    End Sub

    Private Sub BtnClearSearch_Click(sender As Object, e As EventArgs) Handles BtnClearSearch.Click
        CallClearSearch()
    End Sub

    Private Sub CallClearSearch()
        PanSearchList.Visible = True
        'Empties textboxes and listbox content
        TxtStockIDSearch.Text = ""
        TxtItemDescriptionSearch.Text = ""
        LstStock.Items.Clear()
        TxtStockIDSearch.Focus()
    End Sub



    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        CallSearch()
    End Sub

    Private Sub CallSearch()
        Dim BrandIsSelected As Boolean = CmbBrand.SelectedIndex <> -1
        Dim CategoryIsSelected As Boolean = CmbCategory.SelectedIndex <> -1

        If CmbBrand.SelectedIndex = -1 And CmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Brand or Category or Both to perform a search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf BrandIsSelected And CategoryIsSelected Then
            BrandCategoryDisplay()
        ElseIf BrandIsSelected Then
            BrandDisplay()
        ElseIf CategoryIsSelected Then
            CategoryDisplay()
        End If
    End Sub

    Private Sub BrandCategoryDisplay()
        'If connected to database
        If DbConnect() Then
            DgvStockRecords.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * " &
                               "From TblStock " &
                               "Where STBrand Like @BrandSearch and STCategory Like @CategorySearch "
                .Parameters.AddWithValue("@BrandSearch", "%" & CmbBrand.Text & "%")
                .Parameters.AddWithValue("@CategorySearch", "%" & CmbCategory.Text & "%")
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    If rs.Read Then
                        Dim NewStockRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStockRow.CreateCells(DgvStockRecords)
                        NewStockRow.SetValues({rs("StockID"), rs("STDateTime"), rs("STCategory"), rs("STBrand"), rs("STItemDescription"), rs("STSerialNumber"), rs("StockIn"), rs("StockOut"), rs("Stock")})
                        NewStockRow.Tag = rs("StockID")
                        'New rows are created
                        DgvStockRecords.Rows.Add(NewStockRow)
                    Else
                        'Display error message
                        MessageBox.Show("No records found, item does not exist.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BrandDisplay()
        'If connected to database
        If DbConnect() Then
            DgvStockRecords.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn 'SQLCmd is uses the connection to search the following information
                .CommandText = "Select * " &
                               "From TblStock " &
                               "Where STBrand Like @BrandSearch" 'where the surname is like, whatever is typed into the searchsurname textbox
                .Parameters.AddWithValue("@BrandSearch", "%" & CmbBrand.Text & "%") 'This allows the program to search whatever is typed into the searchsurname textbox and also allows to search someone by letters so for example if I type S into the textbox it will search and display everyone that has S in their surname
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStockRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStockRow.CreateCells(DgvStockRecords)
                        NewStockRow.SetValues({rs("StockID"), rs("STDateTime"), rs("STCategory"), rs("STBrand"), rs("STItemDescription"), rs("STSerialNumber"), rs("StockIn"), rs("StockOut"), rs("Stock")})
                        NewStockRow.Tag = rs("StockID")
                        'New rows are created
                        DgvStockRecords.Rows.Add(NewStockRow)
                    End While
                    'Close record set
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub CategoryDisplay()
        'If DbConnect = True/If the database is connected then
        If DbConnect() Then
            DgvStockRecords.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * " &
                               "From TblStock " &
                               "Where STCategory Like @CategorySearch" 'where the surname is like, whatever is typed into the searchsurname textbox
                .Parameters.AddWithValue("@CategorySearch", "%" & CmbCategory.Text & "%") 'This allows the program to search whatever is typed into the searchsurname textbox and also allows to search someone by letters so for example if I type S into the textbox it will search and display everyone that has S in their surname
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        Dim NewStockRow As New DataGridViewRow()
                        'In datagrid, rows for values mentioned below are created
                        NewStockRow.CreateCells(DgvStockRecords)
                        NewStockRow.SetValues({rs("StockID"), rs("STDateTime"), rs("STCategory"), rs("STBrand"), rs("STItemDescription"), rs("STSerialNumber"), rs("StockIn"), rs("StockOut"), rs("Stock")})
                        NewStockRow.Tag = rs("StockID")
                        'New rows are created
                        DgvStockRecords.Rows.Add(NewStockRow)
                    End While
                    'Record set is closed
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BtnViewAll_Click(sender As Object, e As EventArgs) Handles BtnViewAll.Click
        CallViewAll()
    End Sub

    Private Sub CallViewAll()
        'If connected to database
        If DbConnect() Then
            'Items in the rows of the DataGridView are cleared when the user clicks on the new button so the GridBox appears blank
            DgvStockRecords.Rows.Clear()
            Dim SQLCmd As New OleDbCommand
            'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
            With SQLCmd
                'SQLCmd is uses the connection to save the following information
                .Connection = cn
                .CommandText = "Select * From TblStock "
                Try
                    'ExecuteReader is strictly used for fetching records from the SQL Query or Stored Procedure i.e. SELECT Operation.
                    Dim rs As OleDbDataReader = .ExecuteReader()
                    'Loops into reading a record set until it stops reading for a record so rs.Read = false
                    While rs.Read
                        'NewStockRow is declared as DataGridViewRow
                        Dim NewStockRow As New DataGridViewRow()
                        'In DgvDisplay rows for stockid, datetime, category, brand, item description, serial number, stock in, stock out and stock are created
                        NewStockRow.CreateCells(DgvStockRecords)
                        'In the NewStockRow, 9 cells are created for the mentioned record sets 
                        NewStockRow.SetValues({rs("StockID"), rs("STDateTime"), rs("STCategory"), rs("STBrand"), rs("STItemDescription"), rs("STSerialNumber"), rs("StockIn"), rs("StockOut"), rs("Stock")})
                        'StockID (its a hidden value) has been tagged to a row, this allows access to the other record sets in the same row as the StockID in the Database
                        NewStockRow.Tag = rs("StockID")
                        'Adds a new row 
                        DgvStockRecords.Rows.Add(NewStockRow)
                    End While
                    'Record set is closed
                    rs.Close()
                Catch ex As Exception
                    If MessageBox.Show("Database connection error, please close form and try again." & vbCrLf, "Inventory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
                'Makes sure first row is selected if there's only one row in the grid
                If DgvStockRecords.Rows(0).Selected = True Then
                End If
            End With
        End If
        'Close database connection
        cn.Close()
    End Sub

    Private Sub BtnStockDelete_Click(sender As Object, e As EventArgs) Handles BtnStockDelete.Click
        CallStockDelete()
    End Sub

    Private Sub CallStockDelete()
        If MessageBox.Show("Are you sure you want to delete this Stock record?", "Delete Stock", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) = DialogResult.OK Then
            'If connected to database
            If DbConnect() Then
                Dim SQLCmd As New OleDbCommand
                'We can use the With SQLC command/SQLCmd to use to make the code run instead of writing SQLCmd. everytime for a new code
                With SQLCmd
                    'SQLCmd is uses the connection to save the following information
                    .Connection = cn
                    .CommandText = "Delete From TblStock where StockID = @StockDelete"
                    .Parameters.AddWithValue("@StockDelete", CurrentStockID)
                    'ExecuteNonQuery - used for Insert, Update, Delete wont give you any results back.
                    .ExecuteNonQuery()
                    BtnClear.PerformClick()
                End With
                'Close database connection
                cn.Close()
                BtnClearSearch.PerformClick()
            End If
        End If
        LoadComponents()
    End Sub

    Private Sub TxtStockIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStockIn.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then 'Checks if key pressed isn't a digit
            If Asc(e.KeyChar) <> Keys.Back Then 'Checks the key pressed wasn't Backspace
                e.Handled = True 'It doesn't take any further action
            End If
        End If
    End Sub

    Private Sub TxtStockOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStockOut.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then 'Checks if key pressed isn't a digit
            If Asc(e.KeyChar) <> Keys.Back Then 'Checks the key pressed wasn't Backspace
                e.Handled = True 'It doesn't take any further action
            End If
        End If
    End Sub

    Private Sub TxtStockIDSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStockIDSearch.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then 'Checks if key pressed isn't a digit
            If Asc(e.KeyChar) <> Keys.Back Then 'Checks the key pressed wasn't Backspace
                e.Handled = True 'It doesn't take any further action
            End If
        End If
    End Sub

    Private Sub BtnClearDisplaySearch_Click(sender As Object, e As EventArgs) Handles BtnClearDisplaySearch.Click
        'Deselect both comboboxes
        CmbBrand.SelectedIndex = -1
        CmbCategory.SelectedIndex = -1
        DgvStockRecords.Rows.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub LstStock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstStock.SelectedIndexChanged
        If LstStock.SelectedItem IsNot Nothing Then
            Dim SelectedStock As ListBoxData = LstStock.SelectedItem
            DisplayStock(SelectedStock.Identifier)
            TxtStockIn.Enabled = True
            TxtStockOut.Enabled = True
            BtnNewEntry.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Display date and time
        LblSystemDateTime.Text = Date.Now.ToString("HH:mm    dd/MM/yyyy")
    End Sub

    Private Sub HideSubMenus()

        PanelReminder.Visible = False
        PanelRepair.Visible = False

    End Sub

    Private Sub ShowSubMenus(Submenu As Panel)

        If Submenu.Visible = False Then
            HideSubMenus()
            Submenu.Visible = True
        Else
            Submenu.Visible = False
        End If

    End Sub

    Private Sub BtnOpenInventory_Click(sender As Object, e As EventArgs) Handles BtnOpenInventory.Click
    End Sub

    Private Sub BtnOpenReminder_Click(sender As Object, e As EventArgs) Handles BtnOpenReminder.Click
        ShowSubMenus(PanelReminder)
    End Sub

    Private Sub BtnOpenCreateReminder_Click(sender As Object, e As EventArgs) Handles BtnOpenCreateReminder.Click
        frmReminder.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenViewReminders_Click(sender As Object, e As EventArgs) Handles BtnOpenViewReminders.Click
        frmReminderInfo.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenRepair_Click(sender As Object, e As EventArgs) Handles BtnOpenRepair.Click
        ShowSubMenus(PanelRepair)
    End Sub

    Private Sub BtnOpenSetRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenSetRepairs.Click
        frmSetRepair.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenViewRepairs_Click(sender As Object, e As EventArgs) Handles BtnOpenViewRepairs.Click
        frmViewRepairs.Show()
        Me.Close()
    End Sub

    Private Sub BtnOpenAdmin_Click(sender As Object, e As EventArgs) Handles BtnOpenAdmin.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        frmLogin.BtnClear.PerformClick()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub DgvStockRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvStockRecords.CellClick
        DisplayStockCellClick()
    End Sub

    Private Sub DisplayStockCellClick()
        Dim i As Integer
        i = DgvStockRecords.CurrentRow.Index
        TxtStockID.Text = DgvStockRecords.Item(0, i).Value
        TxtCategory.Text = DgvStockRecords.Item(2, i).Value
        TxtBrand.Text = DgvStockRecords.Item(3, i).Value
        TxtItemDescription.Text = DgvStockRecords.Item(4, i).Value
        TxtSerialNumber.Text = DgvStockRecords.Item(5, i).Value
        TxtStockIn.Text = DgvStockRecords.Item(6, i).Value
        TxtStockOut.Text = DgvStockRecords.Item(7, i).Value
        LblStock.Text = DgvStockRecords.Item(8, i).Value
        BtnStockDelete.Enabled = True
        BtnUpdate.Enabled = True
        TxtStockIn.Enabled = True
        TxtStockOut.Enabled = True
        BtnNewEntry.Enabled = False
        CurrentStockID = TxtStockID.Text
    End Sub

End Class