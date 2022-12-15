<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_login.Location = New System.Drawing.Point(147, 300)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(93, 33)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(292, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 33)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(132, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(132, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(252, 174)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 23)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(252, 229)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(124, 23)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.Image = Global.OmahLaundry.My.Resources.Resources.Pengantar_Teknologi_Finansial__2_
        Me.PictureBox1.Location = New System.Drawing.Point(158, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 383)
        Me.Panel1.TabIndex = 8
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 383)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
