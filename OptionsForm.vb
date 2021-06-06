Public Class OptionsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Options.FilePath = TextBoxFilePath.Text
        Options.SheetName = TextBoxSheetName.Text
        Options.Column1 = TextBoxCol1.Text
        Options.Column2 = TextBoxCol2.Text
        Options.Column3 = TextBoxCol3.Text
        Options.Column4 = TextBoxCol4.Text
        If Not String.IsNullOrEmpty(TextBoxCol4.Text) Then
            If Not (Convert.ToInt32(TextBoxInterval.Text) < 1) Then
                Options.interval = Convert.ToInt32(TextBoxInterval.Text) * 1000

            Else
                MsgBox("intervalle de temps ne peut pas etre 0")
                Options.interval = 5 * 1000
            End If

        End If



        Options.LinesRange = Convert.ToInt32(TextBoxRange.Text)

        If CheckBoxReadTE.Checked Then
            Options.ReadToEnd = True
            TextBoxCol1.Enabled = False
        Else
            Options.ReadToEnd = False
            TextBoxCol1.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxFilePath.Text = Options.FilePath
        TextBoxSheetName.Text = Options.SheetName
        TextBoxCol1.Text = Options.Column1
        TextBoxCol2.Text = Options.Column2
        TextBoxCol3.Text = Options.Column3
        TextBoxCol4.Text = Options.Column4
        TextBoxInterval.Text = Options.interval / 1000


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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'MsgBox(Options.ColumnFromChar(TextBoxCol1.Text).ToString())
        'MsgBox(Options.CharFromInt((Convert.ToInt32(TextBoxCol2.Text)) - 1).ToString())

        MsgBox(Options.ColumnFromChar(TextBoxCol1.Text))
    End Sub
End Class