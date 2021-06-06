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
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "sheet name"
        '
        'TextBoxSheetName
        '
        Me.TextBoxSheetName.Location = New System.Drawing.Point(158, 68)
        Me.TextBoxSheetName.Name = "TextBoxSheetName"
        Me.TextBoxSheetName.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxSheetName.TabIndex = 14
        Me.TextBoxSheetName.Text = "Exemple2_CSV"
        '
        'LabelColNB
        '
        Me.LabelColNB.AutoSize = True
        Me.LabelColNB.Location = New System.Drawing.Point(50, 145)
        Me.LabelColNB.Name = "LabelColNB"
        Me.LabelColNB.Size = New System.Drawing.Size(52, 13)
        Me.LabelColNB.TabIndex = 13
        Me.LabelColNB.Text = "columns: "
        '
        'TextBoxCol1
        '
        Me.TextBoxCol1.Location = New System.Drawing.Point(137, 138)
        Me.TextBoxCol1.Name = "TextBoxCol1"
        Me.TextBoxCol1.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol1.TabIndex = 12
        Me.TextBoxCol1.Text = "D"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "File name(later path)"
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.Location = New System.Drawing.Point(158, 31)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxFilePath.TabIndex = 10
        Me.TextBoxFilePath.Text = "Classeur2.xlsx"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxReadTE
        '
        Me.CheckBoxReadTE.AutoSize = True
        Me.CheckBoxReadTE.Location = New System.Drawing.Point(158, 109)
        Me.CheckBoxReadTE.Name = "CheckBoxReadTE"
        Me.CheckBoxReadTE.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxReadTE.TabIndex = 18
        Me.CheckBoxReadTE.Text = "Read all file"
        Me.CheckBoxReadTE.UseVisualStyleBackColor = True
        '
        'LabelRange
        '
        Me.LabelRange.AutoSize = True
        Me.LabelRange.Location = New System.Drawing.Point(50, 110)
        Me.LabelRange.Name = "LabelRange"
        Me.LabelRange.Size = New System.Drawing.Size(39, 13)
        Me.LabelRange.TabIndex = 20
        Me.LabelRange.Text = "Range"
        '
        'TextBoxRange
        '
        Me.TextBoxRange.Location = New System.Drawing.Point(105, 107)
        Me.TextBoxRange.Name = "TextBoxRange"
        Me.TextBoxRange.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxRange.TabIndex = 19
        Me.TextBoxRange.Text = "10"
        '
        'TextBoxCol2
        '
        Me.TextBoxCol2.Location = New System.Drawing.Point(174, 138)
        Me.TextBoxCol2.Name = "TextBoxCol2"
        Me.TextBoxCol2.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol2.TabIndex = 21
        Me.TextBoxCol2.Text = "D"
        '
        'TextBoxCol3
        '
        Me.TextBoxCol3.Location = New System.Drawing.Point(211, 138)
        Me.TextBoxCol3.Name = "TextBoxCol3"
        Me.TextBoxCol3.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol3.TabIndex = 22
        Me.TextBoxCol3.Text = "D"
        '
        'TextBoxCol4
        '
        Me.TextBoxCol4.Location = New System.Drawing.Point(248, 138)
        Me.TextBoxCol4.Name = "TextBoxCol4"
        Me.TextBoxCol4.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxCol4.TabIndex = 23
        Me.TextBoxCol4.Text = "D"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "refresh time every : "
        '
        'TextBoxInterval
        '
        Me.TextBoxInterval.Location = New System.Drawing.Point(155, 173)
        Me.TextBoxInterval.Name = "TextBoxInterval"
        Me.TextBoxInterval.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxInterval.TabIndex = 12
        Me.TextBoxInterval.Text = "5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "seconds"
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 236)
        Me.Controls.Add(Me.TextBoxCol4)
        Me.Controls.Add(Me.TextBoxCol3)
        Me.Controls.Add(Me.TextBoxCol2)
        Me.Controls.Add(Me.LabelRange)
        Me.Controls.Add(Me.TextBoxRange)
        Me.Controls.Add(Me.CheckBoxReadTE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxSheetName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelColNB)
        Me.Controls.Add(Me.TextBoxInterval)
        Me.Controls.Add(Me.TextBoxCol1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFilePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
