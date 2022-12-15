<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PenyerahanCucian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfaktur = New System.Windows.Forms.TextBox()
        Me.txtkons = New System.Windows.Forms.TextBox()
        Me.txtberat = New System.Windows.Forms.TextBox()
        Me.txtpakaian = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.txtpanjar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdbukan = New System.Windows.Forms.RadioButton()
        Me.rdanggota = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsisa = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbket = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbkode = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgpenyerahan = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgpenyerahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faktur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Berat Cucian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Konsumen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jumlah Pakaian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Panjar"
        '
        'txtfaktur
        '
        Me.txtfaktur.Location = New System.Drawing.Point(169, 36)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.Size = New System.Drawing.Size(155, 23)
        Me.txtfaktur.TabIndex = 8
        '
        'txtkons
        '
        Me.txtkons.Location = New System.Drawing.Point(169, 62)
        Me.txtkons.Name = "txtkons"
        Me.txtkons.Size = New System.Drawing.Size(155, 23)
        Me.txtkons.TabIndex = 9
        '
        'txtberat
        '
        Me.txtberat.Location = New System.Drawing.Point(169, 90)
        Me.txtberat.Name = "txtberat"
        Me.txtberat.Size = New System.Drawing.Size(44, 23)
        Me.txtberat.TabIndex = 10
        '
        'txtpakaian
        '
        Me.txtpakaian.Location = New System.Drawing.Point(169, 120)
        Me.txtpakaian.Name = "txtpakaian"
        Me.txtpakaian.Size = New System.Drawing.Size(44, 23)
        Me.txtpakaian.TabIndex = 11
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(169, 151)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(86, 23)
        Me.txtharga.TabIndex = 12
        '
        'txtdiskon
        '
        Me.txtdiskon.Location = New System.Drawing.Point(169, 182)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(44, 23)
        Me.txtdiskon.TabIndex = 13
        '
        'txtpanjar
        '
        Me.txtpanjar.Location = New System.Drawing.Point(169, 212)
        Me.txtpanjar.Name = "txtpanjar"
        Me.txtpanjar.Size = New System.Drawing.Size(86, 23)
        Me.txtpanjar.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Kg"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(492, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Pelanggan"
        '
        'rdbukan
        '
        Me.rdbukan.AutoSize = True
        Me.rdbukan.Location = New System.Drawing.Point(607, 61)
        Me.rdbukan.Name = "rdbukan"
        Me.rdbukan.Size = New System.Drawing.Size(117, 19)
        Me.rdbukan.TabIndex = 18
        Me.rdbukan.TabStop = True
        Me.rdbukan.Text = "Bukan Pelanggan"
        Me.rdbukan.UseVisualStyleBackColor = True
        '
        'rdanggota
        '
        Me.rdanggota.AutoSize = True
        Me.rdanggota.Location = New System.Drawing.Point(505, 61)
        Me.rdanggota.Name = "rdanggota"
        Me.rdanggota.Size = New System.Drawing.Size(81, 19)
        Me.rdanggota.TabIndex = 19
        Me.rdanggota.TabStop = True
        Me.rdanggota.Text = "Pelanggan"
        Me.rdanggota.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(492, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Kode Pelanggan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(492, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Nama Pelanggan"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(637, 120)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(140, 23)
        Me.txtnama.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtsisa)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtbayar)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.cmbket)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(468, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 125)
        Me.Panel1.TabIndex = 24
        '
        'txtsisa
        '
        Me.txtsisa.Location = New System.Drawing.Point(150, 78)
        Me.txtsisa.Name = "txtsisa"
        Me.txtsisa.Size = New System.Drawing.Size(106, 23)
        Me.txtsisa.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Sisa"
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(150, 45)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(106, 23)
        Me.txtbayar.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Total Bayar"
        '
        'cmbket
        '
        Me.cmbket.FormattingEnabled = True
        Me.cmbket.Location = New System.Drawing.Point(150, 15)
        Me.cmbket.Name = "cmbket"
        Me.cmbket.Size = New System.Drawing.Size(140, 23)
        Me.cmbket.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Keterangan"
        '
        'cmbkode
        '
        Me.cmbkode.FormattingEnabled = True
        Me.cmbkode.Location = New System.Drawing.Point(637, 90)
        Me.cmbkode.Name = "cmbkode"
        Me.cmbkode.Size = New System.Drawing.Size(140, 23)
        Me.cmbkode.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgpenyerahan)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(30, 337)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 310)
        Me.Panel2.TabIndex = 26
        '
        'dgpenyerahan
        '
        Me.dgpenyerahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpenyerahan.Location = New System.Drawing.Point(14, 96)
        Me.dgpenyerahan.Name = "dgpenyerahan"
        Me.dgpenyerahan.RowTemplate.Height = 25
        Me.dgpenyerahan.Size = New System.Drawing.Size(748, 167)
        Me.dgpenyerahan.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.txtcari)
        Me.Panel4.Location = New System.Drawing.Point(14, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(211, 64)
        Me.Panel4.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Cari"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 15)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Faktur"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(68, 28)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(124, 23)
        Me.txtcari.TabIndex = 27
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltanggal.Location = New System.Drawing.Point(100, 264)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(111, 37)
        Me.lbltanggal.TabIndex = 28
        Me.lbltanggal.Text = "Label17"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(462, 295)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(93, 36)
        Me.btnsimpan.TabIndex = 29
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(570, 295)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(93, 36)
        Me.btnreset.TabIndex = 30
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(684, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 36)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Kembali"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbltanggal)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(12, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(816, 335)
        Me.Panel3.TabIndex = 32
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.Location = New System.Drawing.Point(-12, -10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(841, 661)
        Me.Panel5.TabIndex = 29
        '
        'PenyerahanCucian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(840, 659)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbkode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.rdanggota)
        Me.Controls.Add(Me.rdbukan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtpanjar)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtpakaian)
        Me.Controls.Add(Me.txtberat)
        Me.Controls.Add(Me.txtkons)
        Me.Controls.Add(Me.txtfaktur)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "PenyerahanCucian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PenyerahanCucian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgpenyerahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfaktur As TextBox
    Friend WithEvents txtkons As TextBox
    Friend WithEvents txtberat As TextBox
    Friend WithEvents txtpakaian As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents txtpanjar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rdbukan As RadioButton
    Friend WithEvents rdanggota As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbket As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbkode As ComboBox
    Friend WithEvents txtsisa As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtcari As TextBox
    Friend WithEvents lbltanggal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgpenyerahan As DataGridView
End Class
