Imports System.Data.Odbc


Public Class PengembalianCucian
    Dim Conn As OdbcConnection
    Dim Command As OdbcCommand
    Dim SDA As OdbcDataAdapter
    Dim Reader As OdbcDataReader
    Dim DS As DataSet
    Dim sisa As String = ""
    Sub koneksi()
        Conn = New OdbcConnection("dsn=omahlaundry")
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        DataLaundry.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MenuUtama.Show()
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
        txtbayar.Text = ""
        txtsisa.Text = ""
    End Sub

    Public Sub cekfaktur()
        Call koneksi()
        Command = New OdbcCommand("INSERT INTO pengembaliancucian (Faktur, Tanggal_Kembali, Konsumen, Berat_Cucian, Jumlah_Pakaian, Harga, Diskon, Panjar)
                    VALUES ('" & txtfaktur.Text & "' , 
                    '" & lbltanggal.Text & "',
                    '" & txtkons.Text & "',
                    '" & txtberat.Text & "',
                    '" & txtpakaian.Text & "',
                    '" & txtharga.Text & "',
                    '" & txtdiskon.Text & "',
                    '" & txtpanjar.Text & "' )")
            Command.ExecuteNonQuery()

    End Sub

    Private Sub PengembalianCucian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        lbltanggal.Text = Now.Date
    End Sub

    Private Sub txtfaktur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfaktur.KeyPress
        If e.KeyChar = Chr(13) Then 'jika user menekan enter
            Call koneksi()
            Command = New OdbcCommand("SELECT * FROM penyerahancucian where Faktur = '" & txtfaktur.Text & "' ", Conn)
            Reader = Command.ExecuteReader
            Reader.Read()
            If Reader.HasRows Then
                txtkons.Text = Reader.Item("Konsumen")
                txtberat.Text = Reader.Item("Berat_Cucian")
                txtpakaian.Text = Reader.Item("Jumlah_Pakaian")
                txtharga.Text = Reader.Item("Harga")
                txtdiskon.Text = Reader.Item("Diskon")
                txtpanjar.Text = Reader.Item("Panjar")
                cmbket.Text = Reader.Item("Keterangan")
                txtbayar.Text = Reader.Item("Total_Bayar")
                txtsisa.Text = Reader.Item("Sisa")
            Else
                MsgBox("Faktur Tidak Terdaftar", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub cmbket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbket.SelectedIndexChanged
        If cmbket.Text = "Lunas" Then
            txtsisa.Text = "0"
            btnsimpan.Enabled = True
        ElseIf cmbket.Text = "Belum Lunas" Then
            txtsisa.Text = sisa
            btnsimpan.Enabled = False
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        awal()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtfaktur.Text = "" Or txtkons.Text = "" Or txtberat.Text = "" Or txtpakaian.Text = "" Or txtharga.Text = "" Or txtdiskon.Text = "" Or txtpanjar.Text = "" Or txtsisa.Text = "" Or txtbayar.Text = "" Then
            MsgBox("Data belum lengkap, silahkan lengkapi data terlebih dahulu!")
        Else
            Call koneksi()
            Dim inputdata As String = "INSERT INTO pengembaliancucian (Faktur, Tanggal_Kembali, Konsumen, Berat_Cucian, Jumlah_Pakaian, Harga, Panjar)
                    VALUES ('" & txtfaktur.Text & "' , 
                    '" & lbltanggal.Text & "',
                    '" & txtkons.Text & "',
                    '" & txtberat.Text & "',
                    '" & txtpakaian.Text & "',
                    '" & txtharga.Text & "',
                    '" & txtpanjar.Text & "' )"
            Command = New OdbcCommand(inputdata, Conn)
            Command.ExecuteNonQuery()
            Command = New OdbcCommand("DELETE From penyerahancucian WHERE Faktur = '" & txtfaktur.Text & "'", Conn)
            Command.ExecuteNonQuery()
            awal()
            DataLaundry.Show()
        End If
    End Sub

    Private Sub txtfaktur_TextChanged(sender As Object, e As EventArgs) Handles txtfaktur.TextChanged

    End Sub

    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles txtbayar.TextChanged

    End Sub
End Class