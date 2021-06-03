Public Class OptionsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Options.FilePath = TextBoxFilePath.Text
        Options.SheetName = TextBoxSheetName.Text
        Options.ColumnNb = Convert.ToInt32(TextBoxColumnNb.Text)
        Options.LinesRange = Convert.ToInt32(TextBoxRange.Text)

        If CheckBoxReadTE.Checked Then
            Options.ReadToEnd = True
            TextBoxColumnNb.Enabled = False
        Else
            Options.ReadToEnd = False
            TextBoxColumnNb.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxFilePath.Text = Options.FilePath
        TextBoxSheetName.Text = Options.SheetName
        TextBoxColumnNb.Text = Options.ColumnNb.ToString()
        TextBoxRange.Text = Options.LinesRange

        If Options.ReadToEnd Then
            CheckBoxReadTE.Checked = True
            TextBoxRange.Enabled = False
        Else
            CheckBoxReadTE.Checked = False
            TextBoxRange.Enabled = True
        End If

    End Sub

    Private Sub CheckBoxReadTE_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxReadTE.CheckedChanged
        If CheckBoxReadTE.Checked Then
            TextBoxRange.Enabled = False
        Else
            TextBoxRange.Enabled = True
        End If
    End Sub
End Class