'Represents an open connection to a data source
Imports System.Data.OleDb
'Represents files and the file system
Imports System.IO

Module ModMain

    'Declares the following variables as strings which are used throughout the program
    Public PublicStaffName, PublicStaffSurname, PublicStaffID, PublicStaffPin, PublicReminderID, PublicStockID, PublicAccessLevel, PublicUsername As String

    ' Function to find "TopGift Final" directory dynamically
    Public Function FindTopGiftFinalDirectory() As String
        Dim currentDir As String = AppDomain.CurrentDomain.BaseDirectory

        ' Loop through parent directories to find "TopGift Final"
        While Not Directory.Exists(Path.Combine(currentDir, "TopGift Final"))
            Dim parentDir As String = Directory.GetParent(currentDir)?.FullName
            If String.IsNullOrEmpty(parentDir) Then Exit While
            currentDir = parentDir
        End While

        ' Return the found path or default to the current directory
        Return Path.Combine(currentDir, "TopGift Final")
    End Function

    ' Get the root directory dynamically
    Public ReadOnly RootDirectory As String = FindTopGiftFinalDirectory()

    ' Set the database path dynamically inside "TopGift Final"
    Public ReadOnly DatabasePath As String = Path.Combine(RootDirectory, "TopGift.mdb")


    ' Define the connection string with the dynamic path
    Public ReadOnly ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabasePath & ";Persist Security Info=False;"

    ' Database connection object
    Public cn As OleDbConnection

    Public Function DbConnect() As Boolean
        Try
            ' Check if the database file exists
            If Not File.Exists(DatabasePath) Then
                MessageBox.Show("Database file not found: " & DatabasePath)
                Return False
            End If
            ' Show the database path in a message box
            ' MessageBox.Show("Using database located at: " & DatabasePath)
            ' Establish connection
            cn = New OleDbConnection(ConnectionString)
            cn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Unable to open the database: " & ex.Message)
            Return False
        End Try
    End Function

    Public Class ListBoxData
        'Data is the values that are displayed
        Public Data As String
        'Identifier is the Primary key
        Public Identifier As Integer

        Public Sub New(NewData As String, NewIdentifier As Integer)
            'This sub procedure tells the class how we can add new data 
            Data = NewData
            Identifier = NewIdentifier
        End Sub

        Public Overrides Function ToString() As String
            'Whenever a procedure asks to run the ListBoxDara this Public function sets it so that it only returns the data(displays the values/data)
            Return Data
        End Function

    End Class

End Module