Imports System.Data.SqlClient

Public Class Database
    Public Shared ReadOnly Property ConnectionString As String = "Server=localhost\SQLEXPRESS;Database=MedsoftDB;Trusted_Connection=True;TrustServerCertificate=True;"

    Public Shared Function GetConnectionString() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function
End Class