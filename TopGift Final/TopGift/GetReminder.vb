Imports System.Data.OleDb
Imports System.Reflection


Public Class GetReminder
    Dim Index As Integer
    Public Property Number() As Integer
        Get
            Return 5
        End Get
        Set(ByVal value As Integer)
            Index = 5
        End Set
    End Property

    Dim ReminderDate As DateTime
    Private Sub ReminderNotification()

        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            With SQLCmd
                .Connection = cn
                .CommandText = "SELECT TOP 1 * FROM TblReminder WHERE ReminderDate = @Date ORDER BY ReminderDate ASC"
                SQLCmd.Parameters.Add("@Date", OleDbType.Date).Value = Now
                Dim rs As OleDbDataReader = .ExecuteReader()
                If rs.Read Then
                    For Index As Long = 0 To rs.FieldCount - 1
                        Select Case rs.GetName(Index).ToUpper
                            Case "ReminderDate"
                                If Not IsDBNull(rs.GetValue(Index)) Then ReminderDate = rs.GetValue(Index)
                        End Select
                    Next

                End If
            End With
        End If
        cn.Close()
    End Sub

End Class
