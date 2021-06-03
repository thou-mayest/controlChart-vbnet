<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxSheetName = New System.Windows.Forms.TextBox()
        Me.LabelColNB = New System.Windows.Forms.Label()
        Me.TextBoxColumnNb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFilePath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxReadTE = New System.Windows.Forms.CheckBox()
        Me.LabelRange = New System.Windows.Forms.Label()
        Me.TextBoxRange = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "sheet name"
        '
        'TextBoxSheetName
        '
        Me.TextBoxSheetName.Location = New System.Drawing.Point(229, 86)
        Me.TextBoxSheetName.Name = "TextBoxSheetName"
        Me.TextBoxSheetName.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxSheetName.TabIndex = 14
        Me.TextBoxSheetName.Text = "Exemple2_CSV"
        '
        'LabelColNB
        '
        Me.LabelColNB.AutoSize = True
        Me.LabelColNB.Location = New System.Drawing.Point(121, 163)
        Me.LabelColNB.Name = "LabelColNB"
        Me.LabelColNB.Size = New System.Drawing.Size(80, 13)
        Me.LabelColNB.TabIndex = 13
        Me.LabelColNB.Text = "Column number"
        '
        'TextBoxColumnNb
        '
        Me.TextBoxColumnNb.Location = New System.Drawing.Point(229, 160)
        Me.TextBoxColumnNb.Name = "TextBoxColumnNb"
        Me.TextBoxColumnNb.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxColumnNb.TabIndex = 12
        Me.TextBoxColumnNb.Text = "4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "File name(later path)"
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.Location = New System.Drawing.Point(229, 49)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxFilePath.TabIndex = 10
        Me.TextBoxFilePath.Text = "Classeur1.xlsx"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(372, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxReadTE
        '
        Me.CheckBoxReadTE.AutoSize = True
        Me.CheckBoxReadTE.Location = New System.Drawing.Point(229, 127)
        Me.CheckBoxReadTE.Name = "CheckBoxReadTE"
        Me.CheckBoxReadTE.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxReadTE.TabIndex = 18
        Me.CheckBoxReadTE.Text = "Read all file"
        Me.CheckBoxReadTE.UseVisualStyleBackColor = True
        '
        'LabelRange
        '
        Me.LabelRange.AutoSize = True
        Me.LabelRange.Location = New System.Drawing.Point(121, 128)
        Me.LabelRange.Name = "LabelRange"
        Me.LabelRange.Size = New System.Drawing.Size(39, 13)
        Me.LabelRange.TabIndex = 20
        Me.LabelRange.Text = "Range"
        '
        'TextBoxRange
        '
        Me.TextBoxRange.Location = New System.Drawing.Point(176, 125)
        Me.TextBoxRange.Name = "TextBoxRange"
        Me.TextBoxRange.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxRange.TabIndex = 19
        Me.TextBoxRange.Text = "10"
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 253)
        Me.Controls.Add(Me.LabelRange)
        Me.Controls.Add(Me.TextBoxRange)
        Me.Controls.Add(Me.CheckBoxReadTE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxSheetName)
        Me.Controls.Add(Me.LabelColNB)
        Me.Controls.Add(Me.TextBoxColumnNb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFilePath)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptionsForm"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSheetName As TextBox
    Friend WithEvents LabelColNB As Label
    Friend WithEvents TextBoxColumnNb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFilePath As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxReadTE As CheckBox
    Friend WithEvents LabelRange As Label
    Friend WithEvents TextBoxRange As TextBox
End Class
