Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class Pelanggan
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

    Sub LoadData()
        Call koneksi()
        SDA = New OdbcDataAdapter("SELECT * From Pelanggan", Conn)
        DS = New DataSet
        DS.Clear()
        SDA.Fill(DS, "pelanggan")
        dgpelanggan.DataSource = DS.Tables("pelanggan")
        With dgpelanggan
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightCoral
        End With
    End Sub

    Private Sub bersih()
        txtkode.Text = ""
        txtnama.Text = ""
        cmbjeniskel.Text = ""
        txtalamat.Text = ""
        txthp.Text = ""
    End Sub

    Public Sub kode()
        Call koneksi()
        Command = New OdbcCommand("SELECT * FROM pelanggan where kode in (select max(kode) from pelanggan)", Conn)
        Dim hitung As Integer
        Reader = Command.ExecuteReader()
        Reader.Read()
        If Not Reader.HasRows Then
            txtkode.Text = "PLG" + "001"
        Else
            hitung = Val(Microsoft.VisualBasic.Right(Reader.Item("kode").ToString, 3)) + 1
            txtkode.Text = "PLG" + "00" & hitung
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub bttnsimpan_Click(sender As Object, e As EventArgs) Handles bttnsimpan.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or cmbjeniskel.Text = "" Or txtalamat.Text = "" Or txthp.Text = "" Then
            MsgBox("Data belum lengkap, silahkan lengkapi data terlebih dahulu!")
        Else
            koneksi()
            Dim inputdata As String = "INSERT INTO pelanggan VALUES (
                    '" & txtkode.Text & "',
                    '" & txtnama.Text & "',
                    '" & cmbjeniskel.Text & "',
                    '" & txtalamat.Text & "',
                    '" & txthp.Text & "' )"
            Command = New OdbcCommand(inputdata, Conn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Ditampilkan")
            bersih()
            LoadData()
            kode()
        End If
    End Sub

    Private Sub bttnhapus_Click(sender As Object, e As EventArgs) Handles bttnhapus.Click
        koneksi()
        Dim hapusdata As String = "DELETE FROM pelanggan WHERE kode = '" & txtkode.Text & "'"
        Command = New OdbcCommand(hapusdata, Conn)
        Command.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil Dihapus")
        bersih()
        LoadData()
        kode()
    End Sub

    Private Sub bttnedit_Click(sender As Object, e As EventArgs) Handles bttnedit.Click
        If txtkode.Text = "" Or txtnama.Text = "" Or cmbjeniskel.Text = "" Or txtalamat.Text = "" Or txthp.Text = "" Then
            MsgBox("Data belum lengkap, silahkan lengkapi data terlebih dahulu!")
        Else
            Call koneksi()
            Dim editdata As String
            editdata = "UPDATE pelanggan SET nama = '" & txtnama.Text &
                    "', jenis_kelamin = '" & cmbjeniskel.Text &
                    "', alamat = '" & txtalamat.Text &
                    "', nohp = '" & txthp.Text &
                    "' WHERE kode = '" & txtkode.Text & "'"
            Command = New OdbcCommand(editdata, Conn)
            Command.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diedit")
        End If
        bersih()
        LoadData()
        kode()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bersih()
        kode()
    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        LoadData()
        kode()
    End Sub


    Private Sub txtkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Command = New OdbcCommand("SELECT * FROM pelanggan WHERE kode = '" & txtkode.Text & "'", Conn)
            Reader = Command.ExecuteReader
            Reader.Read()
            If Reader.HasRows Then
                txtnama.Text = Reader.Item("nama")
                cmbjeniskel.Text = Reader.Item("jenis_kelamin")
                txtalamat.Text = Reader.Item("alamat")
                txthp.Text = Reader.Item("nohp")
            Else
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

End Class