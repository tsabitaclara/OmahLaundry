Imports System.Data.Odbc


Module Module1
    Dim Conn As OdbcConnection
    Dim Command As OdbcCommand
    Dim SDA As OdbcDataAdapter
    Dim Reader As OdbcDataReader
    Dim DS As DataSet

    Sub koneksi()
        Conn = New OdbcConnection("dsn=omahlaundry")
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

End Module
