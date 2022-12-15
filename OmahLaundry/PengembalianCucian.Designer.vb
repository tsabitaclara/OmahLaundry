<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengembalianCucian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfaktur = New System.Windows.Forms.TextBox()
        Me.txtkons = New System.Windows.Forms.TextBox()
        Me.txtberat = New System.Windows.Forms.TextBox()
        Me.txtpakaian = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpanjar = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txtsisa = New System.Windows.Forms.TextBox()
        Me.cmbket = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Konsumen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Berat Cucian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Pakaian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diskon"
        '
        'txtfaktur
        '
        Me.txtfaktur.Location = New System.Drawing.Point(137, 28)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.Size = New System.Drawing.Size(117, 23)
        Me.txtfaktur.TabIndex = 6
        '
        'txtkons
        '
        Me.txtkons.Location = New System.Drawing.Point(137, 61)
        Me.txtkons.Name = "txtkons"
        Me.txtkons.Size = New System.Drawing.Size(117, 23)
        Me.txtkons.TabIndex = 7
        '
        'txtberat
        '
        Me.txtberat.Location = New System.Drawing.Point(137, 93)
        Me.txtberat.Name = "txtberat"
        Me.txtberat.Size = New System.Drawing.Size(36, 23)
        Me.txtberat.TabIndex = 8
        '
        'txtpakaian
        '
        Me.txtpakaian.Location = New System.Drawing.Point(137, 125)
        Me.txtpakaian.Name = "txtpakaian"
        Me.txtpakaian.Size = New System.Drawing.Size(117, 23)
        Me.txtpakaian.TabIndex = 9
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(137, 157)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(117, 23)
        Me.txtharga.TabIndex = 10
        '
        'txtdiskon
        '
        Me.txtdiskon.Location = New System.Drawing.Point(137, 189)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(36, 23)
        Me.txtdiskon.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "%"
        '
        'txtpanjar
        '
        Me.txtpanjar.Location = New System.Drawing.Point(422, 28)
        Me.txtpanjar.Name = "txtpanjar"
        Me.txtpanjar.Size = New System.Drawing.Size(119, 23)
        Me.txtpanjar.TabIndex = 13
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(422, 93)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(119, 23)
        Me.txtbayar.TabIndex = 15
        '
        'txtsisa
        '
        Me.txtsisa.Location = New System.Drawing.Point(422, 125)
        Me.txtsisa.Name = "txtsisa"
        Me.txtsisa.Size = New System.Drawing.Size(119, 23)
        Me.txtsisa.TabIndex = 16
        '
        'cmbket
        '
        Me.cmbket.FormattingEnabled = True
        Me.cmbket.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.cmbket.Location = New System.Drawing.Point(422, 61)
        Me.cmbket.Name = "cmbket"
        Me.cmbket.Size = New System.Drawing.Size(121, 23)
        Me.cmbket.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Panjar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(323, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Keterangan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(323, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total Bayar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Sisa"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(323, 184)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(104, 28)
        Me.btnsimpan.TabIndex = 22
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(443, 184)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(98, 28)
        Me.btnreset.TabIndex = 23
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(323, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 28)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Daftar Cucian"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(443, 227)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 28)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Kembali"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbltanggal.Location = New System.Drawing.Point(73, 226)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(84, 30)
        Me.lbltanggal.TabIndex = 26
        Me.lbltanggal.Text = "Label12"
        '
        'PengembalianCucian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(609, 285)
        Me.Controls.Add(Me.lbltanggal)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbket)
        Me.Controls.Add(Me.txtsisa)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txtpanjar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtpakaian)
        Me.Controls.Add(Me.txtberat)
        Me.Controls.Add(Me.txtkons)
        Me.Controls.Add(Me.txtfaktur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PengembalianCucian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengembalian Cucian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfaktur As TextBox
    Friend WithEvents txtkons As TextBox
    Friend WithEvents txtberat As TextBox
    Friend WithEvents txtpakaian As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpanjar As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents txtsisa As TextBox
    Friend WithEvents cmbket As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lbltanggal As Label
End Class
