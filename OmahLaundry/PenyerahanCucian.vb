Imports System.Data.Odbc


Public Class PenyerahanCucian
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
    Sub LoadData()
        Call koneksi()
        SDA = New OdbcDataAdapter("select * from penyerahancucian", Conn)
        DS = New DataSet
        DS.Clear()
        SDA.Fill(DS, "penyerahancucian")
        dgpenyerahan.DataSource = DS.Tables("penyerahancucian")
        With dgpenyerahan
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightCoral
        End With
    End Sub

    Public Sub awal()
        txtfaktur.Text = ""
        txtkons.Text = ""
        txtberat.Text = ""
        txtpakaian.Text = ""
        txtharga.Text = ""
        txtdiskon.Text = "0"
        txtpanjar.Text = ""
        cmbket.Text = ""
        rdbukan.Checked = True
        txtbayar.Text = ""
        txtsisa.Text = ""
        faktur()
    End Sub

    Public Sub faktur()
        Call koneksi()
        Command = New OdbcCommand("SELECT * From penyerahancucian where Faktur in (select(max(Faktur)) from penyerahancucian)", Conn)
        Dim hitung As Integer
        Reader = Command.ExecuteReader()
        Reader.Read()
        If Not Reader.HasRows Then
            txtfaktur.Text = Format(Today, "ddMMyy") + "001"
        Else
            hitung = Val(Microsoft.VisualBasic.Right(Reader.Item("Faktur").ToString, 3)) + 1
            txtfaktur.Text = Format(Today, "ddMMyy") + "00" & hitung
        End If
    End Sub

    Public Sub bayar()
        txtbayar.Text = Val(txtharga.Text) - (Val(txtdiskon.Text) / 100 * Val(txtharga.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MenuUtama.Show()
    End Sub

    Private Sub txtpanjar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpanjar.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpanjar_Leave(sender As Object, e As EventArgs) Handles txtpanjar.Leave
        txtsisa.Text = Val(txtbayar.Text) - Val(txtpanjar.Text)
        If Val(txtsisa.Text) <= 0 Then
            cmbket.Text = "Lunas"
            txtsisa.Text = "0"
        End If
        If txtsisa.Text = "0" Then
            cmbket.Text = "Lunas"
        Else
            cmbket.Text = "Belum Lunas"
        End If
        btnsimpan.Focus()
    End Sub

    Private Sub rdanggota_CheckedChanged(sender As Object, e As EventArgs) Handles rdanggota.CheckedChanged
        cmbkode.Enabled = True
        txtdiskon.Text = "15"
        kode()
        bayar()
    End Sub

    Private Sub rdbukan_CheckedChanged(sender As Object, e As EventArgs) Handles rdbukan.CheckedChanged
        cmbkode.Enabled = False
        cmbkode.Text = ""
        txtnama.Text = ""
        txtdiskon.Text = "0"
        bayar()
        txtberat.Focus()
    End Sub

    Private Sub txtberat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtberat.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtberat_Leave(sender As Object, e As EventArgs) Handles txtberat.Leave
        txtharga.Text = Val(txtberat.Text) * 6000
        bayar()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        awal()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtfaktur.Text = "" Or txtkons.Text = "" Or txtpakaian.Text = "" Or txtharga.Text = "" Or txtdiskon.Text = "" Or txtpanjar.Text = "" Then
            MsgBox("Data Belum Lengkap, Silahkan Lengkapi Data Terlebih Dahulu!")
        Else
            Call koneksi()
            Dim inputdata As String = "INSERT INTO penyerahancucian (Faktur, Tanggal_Serah, Konsumen, Berat_Cucian, Jumlah_Pakaian, Harga, Diskon, Panjar, Total_Bayar, Sisa, Keterangan)
                    VALUES ('" & txtfaktur.Text & "' , 
                    '" & lbltanggal.Text & "',
                    '" & txtkons.Text & "',
                    '" & txtberat.Text & "',
                    '" & txtpakaian.Text & "',
                    '" & txtharga.Text & "',
                    '" & txtdiskon.Text & "',
                    '" & txtpanjar.Text & "',
                    '" & txtsisa.Text & "',
                    '" & txtbayar.Text & "',
                    '" & cmbket.Text & "')"
            Command = New OdbcCommand(inputdata, Conn)
            Command.ExecuteNonQuery()
            MsgBox("Data Berhasil Ditambahkan!")
            awal()
            LoadData()

        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Call koneksi()
        Command = New OdbcCommand("Select * FROM penyerahancucian where Faktur like '%" & txtcari.Text & "%'", Conn)
        Reader = Command.ExecuteReader
        Reader.Read()
        If Reader.HasRows Then
            Call koneksi()
            SDA = New OdbcDataAdapter("Select * FROM penyerahancucian where Faktur like '%" & txtcari.Text & "%'", Conn)
            DS = New DataSet
            SDA.Fill(DS)
            dgpenyerahan.DataSource = DS.Tables(0)
        Else
            MsgBox("Data tidak Ditemukan!")
        End If
    End Sub


    Private Sub txtpakaian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpakaian.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PenyerahanCucian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        faktur()
        lbltanggal.Text = Today.Date
        LoadData()
    End Sub

    Sub kode()
        Call koneksi()
        Command = New OdbcCommand("SELECT kode FROM pelanggan", Conn)
        Reader = Command.ExecuteReader
        Reader.Read()
        If Reader.HasRows Then
            While Reader.Read
                cmbkode.Items.Add(Reader.Item(0))
            End While
        End If
    End Sub

    Private Sub cmbkode_Leave(sender As Object, e As EventArgs) Handles cmbkode.Leave
        txtnama.Text = txtkons.Text
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class

