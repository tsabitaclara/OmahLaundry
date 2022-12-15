<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txthp = New System.Windows.Forms.TextBox()
        Me.cmbjeniskel = New System.Windows.Forms.ComboBox()
        Me.bttnsimpan = New System.Windows.Forms.Button()
        Me.bttnhapus = New System.Windows.Forms.Button()
        Me.bttnedit = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dgpelanggan = New System.Windows.Forms.DataGridView()
        CType(Me.dgpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No Hp"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(147, 32)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(129, 23)
        Me.txtkode.TabIndex = 5
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(147, 64)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(129, 23)
        Me.txtnama.TabIndex = 6
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(378, 32)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(272, 23)
        Me.txtalamat.TabIndex = 7
        '
        'txthp
        '
        Me.txthp.Location = New System.Drawing.Point(378, 64)
        Me.txthp.Name = "txthp"
        Me.txthp.Size = New System.Drawing.Size(140, 23)
        Me.txthp.TabIndex = 8
        '
        'cmbjeniskel
        '
        Me.cmbjeniskel.FormattingEnabled = True
        Me.cmbjeniskel.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbjeniskel.Location = New System.Drawing.Point(147, 96)
        Me.cmbjeniskel.Name = "cmbjeniskel"
        Me.cmbjeniskel.Size = New System.Drawing.Size(129, 23)
        Me.cmbjeniskel.TabIndex = 9
        '
        'bttnsimpan
        '
        Me.bttnsimpan.Location = New System.Drawing.Point(41, 141)
        Me.bttnsimpan.Name = "bttnsimpan"
        Me.bttnsimpan.Size = New System.Drawing.Size(75, 28)
        Me.bttnsimpan.TabIndex = 10
        Me.bttnsimpan.Text = "Simpan"
        Me.bttnsimpan.UseVisualStyleBackColor = True
        '
        'bttnhapus
        '
        Me.bttnhapus.Location = New System.Drawing.Point(147, 141)
        Me.bttnhapus.Name = "bttnhapus"
        Me.bttnhapus.Size = New System.Drawing.Size(75, 28)
        Me.bttnhapus.TabIndex = 11
        Me.bttnhapus.Text = "Hapus"
        Me.bttnhapus.UseVisualStyleBackColor = True
        '
        'bttnedit
        '
        Me.bttnedit.Location = New System.Drawing.Point(250, 141)
        Me.bttnedit.Name = "bttnedit"
        Me.bttnedit.Size = New System.Drawing.Size(75, 28)
        Me.bttnedit.TabIndex = 12
        Me.bttnedit.Text = "Edit"
        Me.bttnedit.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(355, 141)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 28)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(462, 141)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 28)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Kembali"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dgpelanggan
        '
        Me.dgpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpelanggan.Location = New System.Drawing.Point(23, 193)
        Me.dgpelanggan.Name = "dgpelanggan"
        Me.dgpelanggan.RowTemplate.Height = 25
        Me.dgpelanggan.Size = New System.Drawing.Size(649, 186)
        Me.dgpelanggan.TabIndex = 15
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(694, 380)
        Me.Controls.Add(Me.dgpelanggan)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.bttnedit)
        Me.Controls.Add(Me.bttnhapus)
        Me.Controls.Add(Me.bttnsimpan)
        Me.Controls.Add(Me.cmbjeniskel)
        Me.Controls.Add(Me.txthp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.dgpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txthp As TextBox
    Friend WithEvents cmbjeniskel As ComboBox
    Friend WithEvents bttnsimpan As Button
    Friend WithEvents bttnhapus As Button
    Friend WithEvents bttnedit As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents dgpelanggan As DataGridView
End Class
