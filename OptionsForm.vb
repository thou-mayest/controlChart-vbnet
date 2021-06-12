Public Class OptionsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Options.FilePath = TextBoxFilePath.Text
        Options.SheetName = TextBoxSheetName.Text
        Options.CheckDer = CheckBox1.Checked
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

        Options.Lang = ComboBoxLang.SelectedItem
        Options.LinesRange = Convert.ToInt32(TextBoxRange.Text)

        Options.FromServer = CheckBoxFromServer.Checked
        Options.ServerPath = TextBoxServerPath.Text

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
        CheckBox1.Checked = Options.CheckDer
        TextBoxCol1.Text = Options.Column1
        TextBoxCol2.Text = Options.Column2
        TextBoxCol3.Text = Options.Column3
        TextBoxCol4.Text = Options.Column4
        TextBoxInterval.Text = Options.interval / 1000


        ' ===== build path from current date 
        If Options.FromServer Then
            CheckBoxFromServer.Checked = True
            DateTimePicker1.Enabled = True
            TextBoxServerPath.Enabled = True
        Else
            CheckBoxFromServer.Checked = False
            DateTimePicker1.Enabled = False
            TextBoxServerPath.Enabled = False
        End If

        DateTimePicker1.Value = Date.Today
        Dim an = DateTimePicker1.Value.Year
        Dim mois = DateTimePicker1.Value.Month
        Dim jour = DateTimePicker1.Value.Day

        If Options.ServerPath = "" Then
            TextBoxServerPath.Text = "ftp://bnr-cptf1/home/lvuser/natinst/LabVIEW Data/Log_TF/log_CSV/" & an & "/" & mois & "/" & jour & ".CSV"
        Else
            TextBoxServerPath.Text = Options.ServerPath
        End If


        If Options.Lang = "Fr" Then
            ComboBoxLang.SelectedItem = ComboBoxLang.Items(0)
        ElseIf Options.Lang = "" Then
            If System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToUpper.Contains("FR") Then
                ComboBoxLang.SelectedItem = ComboBoxLang.Items(0)
            Else
                ComboBoxLang.SelectedItem = ComboBoxLang.Items(1)
            End If
        Else
            ComboBoxLang.SelectedItem = ComboBoxLang.Items(1)
        End If




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

    Private Sub CkeckBoxFromServer_checkedChanged(sender As Object, e As EventArgs) Handles CheckBoxFromServer.CheckedChanged
        If CheckBoxFromServer.Checked Then
            DateTimePicker1.Enabled = True
            TextBoxServerPath.Enabled = True
            TextBoxFilePath.Enabled = False
        Else
            DateTimePicker1.Enabled = False
            CheckBoxFromServer.Checked = False
            TextBoxServerPath.Enabled = False
            TextBoxFilePath.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'MsgBox(Options.ColumnFromChar(TextBoxCol1.Text).ToString())
        'MsgBox(Options.CharFromInt((Convert.ToInt32(TextBoxCol2.Text)) - 1).ToString())

        MsgBox(Options.ColumnFromChar(TextBoxCol1.Text))
    End Sub

    Dim fbrowser As New OpenFileDialog

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        fbrowser.Title = "Fichier a ouvrir"

        fbrowser.InitialDirectory = My.Application.Info.DirectoryPath
        If fbrowser.ShowDialog() = DialogResult.OK Then
            TextBoxFilePath.Text = fbrowser.FileName
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        TextBoxServerPath.Text = "ftp://bnr-cptf1/home/lvuser/natinst/LabVIEW Data/Log_TF/log_CSV/" & DateTimePicker1.Value.Year & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Day & ".CSV"

    End Sub
End Class