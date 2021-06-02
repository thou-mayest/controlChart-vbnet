<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBoxFilePath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxColumnNb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSheetName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextboxUSL = New System.Windows.Forms.TextBox()
        Me.TextboxLSL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelCP = New System.Windows.Forms.Label()
        Me.LabelCPk = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(106, 73)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(1060, 416)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1083, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "create chart "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 463)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.Location = New System.Drawing.Point(272, 12)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxFilePath.TabIndex = 4
        Me.TextBoxFilePath.Text = "Classeur1.xlsx"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File name(later path)"
        '
        'TextBoxColumnNb
        '
        Me.TextBoxColumnNb.Location = New System.Drawing.Point(272, 38)
        Me.TextBoxColumnNb.Name = "TextBoxColumnNb"
        Me.TextBoxColumnNb.Size = New System.Drawing.Size(31, 20)
        Me.TextBoxColumnNb.TabIndex = 6
        Me.TextBoxColumnNb.Text = "4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Column number"
        '
        'TextBoxSheetName
        '
        Me.TextBoxSheetName.Location = New System.Drawing.Point(471, 12)
        Me.TextBoxSheetName.Name = "TextBoxSheetName"
        Me.TextBoxSheetName.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxSheetName.TabIndex = 8
        Me.TextBoxSheetName.Text = "Exemple2_CSV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "sheet name"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(994, 525)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 28)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'TextboxUSL
        '
        Me.TextboxUSL.Location = New System.Drawing.Point(994, 8)
        Me.TextboxUSL.Name = "TextboxUSL"
        Me.TextboxUSL.Size = New System.Drawing.Size(68, 20)
        Me.TextboxUSL.TabIndex = 11
        Me.TextboxUSL.Text = "0"
        '
        'TextboxLSL
        '
        Me.TextboxLSL.Location = New System.Drawing.Point(994, 41)
        Me.TextboxLSL.Name = "TextboxLSL"
        Me.TextboxLSL.Size = New System.Drawing.Size(68, 20)
        Me.TextboxLSL.TabIndex = 12
        Me.TextboxLSL.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(962, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "USL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(962, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "LSL"
        '
        'labelCP
        '
        Me.labelCP.AutoSize = True
        Me.labelCP.Location = New System.Drawing.Point(1018, 433)
        Me.labelCP.Name = "labelCP"
        Me.labelCP.Size = New System.Drawing.Size(13, 13)
        Me.labelCP.TabIndex = 9
        Me.labelCP.Text = "0"
        '
        'LabelCPk
        '
        Me.LabelCPk.AutoSize = True
        Me.LabelCPk.Location = New System.Drawing.Point(1018, 464)
        Me.LabelCPk.Name = "LabelCPk"
        Me.LabelCPk.Size = New System.Drawing.Size(13, 13)
        Me.LabelCPk.TabIndex = 13
        Me.LabelCPk.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(991, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CP:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(991, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "CPk:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 565)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelCPk)
        Me.Controls.Add(Me.TextboxLSL)
        Me.Controls.Add(Me.TextboxUSL)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.labelCP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxSheetName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxColumnNb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFilePath)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExcelGraph"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBoxFilePath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxColumnNb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSheetName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextboxUSL As TextBox
    Friend WithEvents TextboxLSL As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labelCP As Label
    Friend WithEvents LabelCPk As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
