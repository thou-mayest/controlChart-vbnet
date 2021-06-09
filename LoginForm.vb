Public Class LoginForm

    Const loginstr = "melek_harbaoui"
    Const pass = "sagemsagem"
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chartform As New Form1

        If (TextBox1.Text = loginstr And TextBox2.Text = pass) Then
            chartform.Show()
            Me.Close()
        Else
            MsgBox("LOGIN FAILED CREDS NOT VALID", MsgBoxStyle.Critical, "ERROR")
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class