
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Public Class login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If TextBox1.Text = "admin" And TextBox2.Text = "admin123" Then
            MenuUtama.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password Salah!", "Konfirmasi")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox1.Focus()
            Return
        End If
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
            Return
        End If
        TextBox2.Focus()
    End Sub
End Class
