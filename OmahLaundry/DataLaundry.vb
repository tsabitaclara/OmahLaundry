Imports System.Data.Odbc

Public Class DataLaundry
    Dim Conn As OdbcConnection
    Dim Command As OdbcCommand
    Dim SDA As OdbcDataAdapter
    Dim Reader As OdbcDataReader
    Dim DS As DataSet
    Dim dt As New DataTable
    Dim bin As String

    Sub koneksi()
        Conn = New OdbcConnection("dsn=omahlaundry")
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Public Sub tampilcucian()
        Call koneksi()
        SDA = New OdbcDataAdapter("SELECT * From penyerahancucian", Conn)
        DS = New DataSet
        DS.Clear()
        SDA.Fill(DS, "penyerahancucian")
        dgcucian.DataSource = DS.Tables("penyerahancucian")
        With dgcucian
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub DataLaundry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        tampilcucian()

    End Sub

    Private Sub dgcucian_DoubleClick(sender As Object, e As EventArgs) Handles dgcucian.DoubleClick
        'jika diklik 2 kali, maka akan form pengembalian cucian untuk melakukan transaksi pengembalian cucian
        PengembalianCucian.txtfaktur.Text = dgcucian.SelectedRows.Item(0).Cells("Faktur").Value
        PengembalianCucian.cekfaktur()
        PengembalianCucian.Show()
        Me.Hide()
    End Sub

    Private Sub txtkons_TextChanged(sender As Object, e As EventArgs) Handles txtkons.TextChanged
        Call koneksi()
        Command = New OdbcCommand("Select * from penyerahancucian where konsumen like '%" & txtkons.Text & "%'", Conn)
        Reader = Command.ExecuteReader
        Reader.Read()
        If Reader.HasRows Then
            Call koneksi()
            SDA = New OdbcDataAdapter("Select * from penyerahancucian where konsumen like '%" & txtkons.Text & "%'", Conn)
            DS = New DataSet
            SDA.Fill(DS)
            dgcucian.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampilcucian()
    End Sub

    Private Sub rdkonsumen_CheckedChanged(sender As Object, e As EventArgs) Handles rdkonsumen.CheckedChanged
        txtkons.Enabled = True
        txtfaktur.Enabled = False
        txtkons.Focus()
    End Sub

    Private Sub rdfaktur_CheckedChanged(sender As Object, e As EventArgs) Handles rdfaktur.CheckedChanged
        txtfaktur.Enabled = True
        txtkons.Enabled = False
        txtfaktur.Focus()
    End Sub

    Private Sub txtfaktur_TextChanged(sender As Object, e As EventArgs) Handles txtfaktur.TextChanged
        Call koneksi()
        Command = New OdbcCommand("Select * FROM penyerahancucian where Faktur like '%" & txtfaktur.Text & "%'", Conn)
        Reader = Command.ExecuteReader
        Reader.Read()
        If Reader.HasRows Then
            Call koneksi()
            SDA = New OdbcDataAdapter("Select * FROM penyerahancucian where Faktur like '%" & txtfaktur.Text & "%'", Conn)
            DS = New DataSet
            SDA.Fill(DS)
            dgcucian.DataSource = DS.Tables(0)
        Else
            MsgBox("Data tidak Ditemukan!")
        End If
    End Sub
End Class