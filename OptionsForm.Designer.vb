<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSheetName = New System.Windows.Forms.TextBox()
        Me.LabelColNB = New System.Windows.Forms.Label()
        Me.TextBoxCol1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFilePath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxReadTE = New System.Windows.Forms.CheckBox()
        Me.LabelRange = New System.Windows.Forms.Label()
        Me.TextBoxRange = New System.Windows.Forms.TextBox()
        Me.TextBoxCol2 = New System.Windows.Forms.TextBox()
        Me.TextBoxCol3 = New System.Windows.Forms.TextBox()
        Me.TextBoxCol4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxInterval = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBoxLang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxServerPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxFromServer = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(8, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "SHEET NAME: "
        '
        'TextBoxSheetName
        '
        Me.TextBoxSheetName.Enabled = False
        Me.TextBoxSheetName.Location = New System.Drawing.Point(91, 121)
        Me.TextBoxSheetName.Name = "TextBoxSheetName"
        Me.TextBoxSheetName.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxSheetName.TabIndex = 14
        Me.TextBoxSheetName.Text = "selected automatically"
        '
        'LabelColNB
        '
        Me.LabelColNB.AutoSize = True
        Me.LabelColNB.Location = New System.Drawing.Point(6, 72)
        Me.LabelColNB.Name = "LabelColNB"
        Me.LabelColNB.Size = New System.Drawing.Size(66, 13)
        Me.LabelColNB.TabIndex = 13
        Me.LabelColNB.Text = "COLUMNS: "
        '
        'TextBoxCol1
        '
        Me.TextBoxCol1.Location = New System.Drawing.Point(93, 65)
        Me.TextBoxCol1.Name = "TextBoxCol1"
        Me.TextBoxCol1.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol1.TabIndex = 6
        Me.TextBoxCol1.Text = "D"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "FILE PATH: "
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.Location = New System.Drawing.Point(91, 19)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxFilePath.TabIndex = 1
        Me.TextBoxFilePath.Text = "Classeur2.xlsx"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(602, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxReadTE
        '
        Me.CheckBoxReadTE.AutoSize = True
        Me.CheckBoxReadTE.Location = New System.Drawing.Point(114, 19)
        Me.CheckBoxReadTE.Name = "CheckBoxReadTE"
        Me.CheckBoxReadTE.Size = New System.Drawing.Size(103, 17)
        Me.CheckBoxReadTE.TabIndex = 4
        Me.CheckBoxReadTE.Text = "READ ALL FILE"
        Me.CheckBoxReadTE.UseVisualStyleBackColor = True
        '
        'LabelRange
        '
        Me.LabelRange.AutoSize = True
        Me.LabelRange.Location = New System.Drawing.Point(6, 20)
        Me.LabelRange.Name = "LabelRange"
        Me.LabelRange.Size = New System.Drawing.Size(51, 13)
        Me.LabelRange.TabIndex = 20
        Me.LabelRange.Text = "RANGE: "
        '
        'TextBoxRange
        '
        Me.TextBoxRange.Location = New System.Drawing.Point(61, 17)
        Me.TextBoxRange.Name = "TextBoxRange"
        Me.TextBoxRange.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxRange.TabIndex = 3
        Me.TextBoxRange.Text = "10"
        '
        'TextBoxCol2
        '
        Me.TextBoxCol2.Location = New System.Drawing.Point(130, 65)
        Me.TextBoxCol2.Name = "TextBoxCol2"
        Me.TextBoxCol2.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol2.TabIndex = 7
        Me.TextBoxCol2.Text = "D"
        '
        'TextBoxCol3
        '
        Me.TextBoxCol3.Location = New System.Drawing.Point(167, 65)
        Me.TextBoxCol3.Name = "TextBoxCol3"
        Me.TextBoxCol3.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol3.TabIndex = 8
        Me.TextBoxCol3.Text = "D"
        '
        'TextBoxCol4
        '
        Me.TextBoxCol4.Location = New System.Drawing.Point(204, 65)
        Me.TextBoxCol4.Name = "TextBoxCol4"
        Me.TextBoxCol4.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol4.TabIndex = 9
        Me.TextBoxCol4.Text = "D"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "REFRESH TIME EVERY:"
        '
        'TextBoxInterval
        '
        Me.TextBoxInterval.Location = New System.Drawing.Point(151, 100)
        Me.TextBoxInterval.Name = "TextBoxInterval"
        Me.TextBoxInterval.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxInterval.TabIndex = 10
        Me.TextBoxInterval.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "seconds"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "BROWSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(114, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "CHECK DEVIATION"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBoxLang
        '
        Me.ComboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLang.FormattingEnabled = True
        Me.ComboBoxLang.Items.AddRange(New Object() {"Fr", "En"})
        Me.ComboBoxLang.Location = New System.Drawing.Point(114, 138)
        Me.ComboBoxLang.Name = "ComboBoxLang"
        Me.ComboBoxLang.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxLang.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "LANGUAGE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBoxSheetName)
        Me.GroupBox1.Controls.Add(Me.TextBoxServerPath)
        Me.GroupBox1.Controls.Add(Me.TextBoxFilePath)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFromServer)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 174)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(205, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'TextBoxServerPath
        '
        Me.TextBoxServerPath.Location = New System.Drawing.Point(11, 95)
        Me.TextBoxServerPath.Name = "TextBoxServerPath"
        Me.TextBoxServerPath.Size = New System.Drawing.Size(290, 20)
        Me.TextBoxServerPath.TabIndex = 1
        Me.TextBoxServerPath.Text = "Classeur2.xlsx"
        '
        'CheckBoxFromServer
        '
        Me.CheckBoxFromServer.AutoSize = True
        Me.CheckBoxFromServer.Location = New System.Drawing.Point(11, 45)
        Me.CheckBoxFromServer.Name = "CheckBoxFromServer"
        Me.CheckBoxFromServer.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxFromServer.TabIndex = 4
        Me.CheckBoxFromServer.Text = "FROM FTP SERVER: "
        Me.CheckBoxFromServer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelRange)
        Me.GroupBox2.Controls.Add(Me.TextBoxCol1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxLang)
        Me.GroupBox2.Controls.Add(Me.TextBoxInterval)
        Me.GroupBox2.Controls.Add(Me.TextBoxCol4)
        Me.GroupBox2.Controls.Add(Me.LabelColNB)
        Me.GroupBox2.Controls.Add(Me.TextBoxCol3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBoxCol2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBoxRange)
        Me.GroupBox2.Controls.Add(Me.CheckBoxReadTE)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(354, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 174)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Graph "
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 232)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSheetName As TextBox
    Friend WithEvents LabelColNB As Label
    Friend WithEvents TextBoxCol1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFilePath As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxReadTE As CheckBox
    Friend WithEvents LabelRange As Label
    Friend WithEvents TextBoxRange As TextBox
    Friend WithEvents TextBoxCol2 As TextBox
    Friend WithEvents TextBoxCol3 As TextBox
    Friend WithEvents TextBoxCol4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxInterval As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBoxLang As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxServerPath As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBoxFromServer As CheckBox
End Class
