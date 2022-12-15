<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataLaundry
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
        Me.rdkonsumen = New System.Windows.Forms.RadioButton()
        Me.rdfaktur = New System.Windows.Forms.RadioButton()
        Me.txtkons = New System.Windows.Forms.TextBox()
        Me.txtfaktur = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgcucian = New System.Windows.Forms.DataGridView()
        CType(Me.dgcucian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari :"
        '
        'rdkonsumen
        '
        Me.rdkonsumen.AutoSize = True
        Me.rdkonsumen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdkonsumen.Location = New System.Drawing.Point(92, 17)
        Me.rdkonsumen.Name = "rdkonsumen"
        Me.rdkonsumen.Size = New System.Drawing.Size(82, 19)
        Me.rdkonsumen.TabIndex = 2
        Me.rdkonsumen.TabStop = True
        Me.rdkonsumen.Text = "Konsumen"
        Me.rdkonsumen.UseVisualStyleBackColor = False
        '
        'rdfaktur
        '
        Me.rdfaktur.AutoSize = True
        Me.rdfaktur.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdfaktur.Location = New System.Drawing.Point(325, 19)
        Me.rdfaktur.Name = "rdfaktur"
        Me.rdfaktur.Size = New System.Drawing.Size(58, 19)
        Me.rdfaktur.TabIndex = 3
        Me.rdfaktur.TabStop = True
        Me.rdfaktur.Text = "Faktur"
        Me.rdfaktur.UseVisualStyleBackColor = False
        '
        'txtkons
        '
        Me.txtkons.Location = New System.Drawing.Point(180, 16)
        Me.txtkons.Name = "txtkons"
        Me.txtkons.Size = New System.Drawing.Size(120, 23)
        Me.txtkons.TabIndex = 4
        '
        'txtfaktur
        '
        Me.txtfaktur.Location = New System.Drawing.Point(383, 16)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.Size = New System.Drawing.Size(121, 23)
        Me.txtfaktur.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(12, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 48)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tampilkan Semua Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 37)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgcucian
        '
        Me.dgcucian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcucian.Location = New System.Drawing.Point(21, 70)
        Me.dgcucian.Name = "dgcucian"
        Me.dgcucian.RowTemplate.Height = 25
        Me.dgcucian.Size = New System.Drawing.Size(676, 207)
        Me.dgcucian.TabIndex = 9
        '
        'DataLaundry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(718, 334)
        Me.Controls.Add(Me.dgcucian)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtfaktur)
        Me.Controls.Add(Me.txtkons)
        Me.Controls.Add(Me.rdfaktur)
        Me.Controls.Add(Me.rdkonsumen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DataLaundry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataLaundry"
        CType(Me.dgcucian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdkonsumen As RadioButton
    Friend WithEvents rdfaktur As RadioButton
    Friend WithEvents txtkons As TextBox
    Friend WithEvents txtfaktur As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dgcucian As DataGridView
End Class
