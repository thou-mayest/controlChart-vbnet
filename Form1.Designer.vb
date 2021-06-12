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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextboxTS = New System.Windows.Forms.TextBox()
        Me.TextboxTI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelCP = New System.Windows.Forms.Label()
        Me.LabelCPk = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Title1 = New System.Windows.Forms.Label()
        Me.LabelLCL = New System.Windows.Forms.Label()
        Me.LabelRange = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelLCLword = New System.Windows.Forms.Label()
        Me.LabelUCL = New System.Windows.Forms.Label()
        Me.LabelUCLword = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelCpm = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextboxTS2 = New System.Windows.Forms.TextBox()
        Me.TextboxTI2 = New System.Windows.Forms.TextBox()
        Me.LabelCPK2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelLCL2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelRange2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelCpm2 = New System.Windows.Forms.Label()
        Me.LabelLCLword2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelUCL2 = New System.Windows.Forms.Label()
        Me.LabelCP2 = New System.Windows.Forms.Label()
        Me.LabelUCLword2 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BorderlineWidth = 0
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.White
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Silver
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 39)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(1172, 219)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        Title3.Name = "Title1"
        Me.Chart1.Titles.Add(Title3)
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1048, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(923, 539)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 43)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'TextboxTS
        '
        Me.TextboxTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextboxTS.Location = New System.Drawing.Point(1083, 140)
        Me.TextboxTS.Name = "TextboxTS"
        Me.TextboxTS.Size = New System.Drawing.Size(68, 20)
        Me.TextboxTS.TabIndex = 11
        Me.TextboxTS.Text = "0"
        '
        'TextboxTI
        '
        Me.TextboxTI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextboxTI.Location = New System.Drawing.Point(1083, 166)
        Me.TextboxTI.Name = "TextboxTI"
        Me.TextboxTI.Size = New System.Drawing.Size(68, 20)
        Me.TextboxTI.TabIndex = 12
        Me.TextboxTI.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(974, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "UPPER SPEC LIMIT:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(974, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "LOWER SPEC LIMIT: "
        '
        'labelCP
        '
        Me.labelCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelCP.AutoSize = True
        Me.labelCP.BackColor = System.Drawing.Color.White
        Me.labelCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCP.Location = New System.Drawing.Point(1045, 206)
        Me.labelCP.Name = "labelCP"
        Me.labelCP.Size = New System.Drawing.Size(15, 16)
        Me.labelCP.TabIndex = 9
        Me.labelCP.Text = "0"
        '
        'LabelCPk
        '
        Me.LabelCPk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCPk.AutoSize = True
        Me.LabelCPk.BackColor = System.Drawing.Color.White
        Me.LabelCPk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCPk.Location = New System.Drawing.Point(1045, 222)
        Me.LabelCPk.Name = "LabelCPk"
        Me.LabelCPk.Size = New System.Drawing.Size(15, 16)
        Me.LabelCPk.TabIndex = 13
        Me.LabelCPk.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1008, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cp:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1008, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cpk:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1178, 31)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(49, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(138, 28)
        Me.OptionsToolStripMenuItem.Text = "options"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1178, 510)
        Me.Panel1.TabIndex = 15
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer1.Panel1.Controls.Add(Me.Title1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextboxTS)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextboxTI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelCPk)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelLCL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelRange)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelLCLword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelUCL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelUCLword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelCpm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.labelCP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chart1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer1.Panel2.Controls.Add(Me.Title2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextboxTS2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextboxTI2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelCPK2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelLCL2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelRange2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelCpm2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelLCLword2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelUCL2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelCP2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelUCLword2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1178, 510)
        Me.SplitContainer1.SplitterDistance = 261
        Me.SplitContainer1.TabIndex = 0
        '
        'Title1
        '
        Me.Title1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title1.AutoSize = True
        Me.Title1.BackColor = System.Drawing.Color.Silver
        Me.Title1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.Location = New System.Drawing.Point(418, 4)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(205, 32)
        Me.Title1.TabIndex = 9
        Me.Title1.Text = "X BAR CHART"
        '
        'LabelLCL
        '
        Me.LabelLCL.AutoSize = True
        Me.LabelLCL.BackColor = System.Drawing.SystemColors.Window
        Me.LabelLCL.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLCL.Location = New System.Drawing.Point(3, 130)
        Me.LabelLCL.Name = "LabelLCL"
        Me.LabelLCL.Size = New System.Drawing.Size(16, 20)
        Me.LabelLCL.TabIndex = 9
        Me.LabelLCL.Text = "0"
        '
        'LabelRange
        '
        Me.LabelRange.AutoSize = True
        Me.LabelRange.BackColor = System.Drawing.Color.White
        Me.LabelRange.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRange.Location = New System.Drawing.Point(3, 173)
        Me.LabelRange.Name = "LabelRange"
        Me.LabelRange.Size = New System.Drawing.Size(16, 20)
        Me.LabelRange.TabIndex = 9
        Me.LabelRange.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 20)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "RANGE:"
        '
        'LabelLCLword
        '
        Me.LabelLCLword.AutoSize = True
        Me.LabelLCLword.BackColor = System.Drawing.SystemColors.Window
        Me.LabelLCLword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLCLword.Location = New System.Drawing.Point(3, 114)
        Me.LabelLCLword.Name = "LabelLCLword"
        Me.LabelLCLword.Size = New System.Drawing.Size(38, 20)
        Me.LabelLCLword.TabIndex = 9
        Me.LabelLCLword.Text = "LCL:"
        '
        'LabelUCL
        '
        Me.LabelUCL.AutoSize = True
        Me.LabelUCL.BackColor = System.Drawing.SystemColors.Window
        Me.LabelUCL.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUCL.Location = New System.Drawing.Point(3, 81)
        Me.LabelUCL.Name = "LabelUCL"
        Me.LabelUCL.Size = New System.Drawing.Size(16, 20)
        Me.LabelUCL.TabIndex = 9
        Me.LabelUCL.Text = "0"
        '
        'LabelUCLword
        '
        Me.LabelUCLword.AutoSize = True
        Me.LabelUCLword.BackColor = System.Drawing.SystemColors.Window
        Me.LabelUCLword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUCLword.Location = New System.Drawing.Point(3, 65)
        Me.LabelUCLword.Name = "LabelUCLword"
        Me.LabelUCLword.Size = New System.Drawing.Size(39, 20)
        Me.LabelUCLword.TabIndex = 9
        Me.LabelUCLword.Text = "UCL:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1008, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Cpm:"
        '
        'LabelCpm
        '
        Me.LabelCpm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCpm.AutoSize = True
        Me.LabelCpm.BackColor = System.Drawing.Color.White
        Me.LabelCpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCpm.Location = New System.Drawing.Point(1045, 190)
        Me.LabelCpm.Name = "LabelCpm"
        Me.LabelCpm.Size = New System.Drawing.Size(15, 16)
        Me.LabelCpm.TabIndex = 9
        Me.LabelCpm.Text = "0"
        '
        'Title2
        '
        Me.Title2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title2.AutoSize = True
        Me.Title2.BackColor = System.Drawing.Color.Silver
        Me.Title2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2.Location = New System.Drawing.Point(418, -1)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(218, 32)
        Me.Title2.TabIndex = 9
        Me.Title2.Text = "RANGE CHART"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1008, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cpk:"
        '
        'TextboxTS2
        '
        Me.TextboxTS2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextboxTS2.Location = New System.Drawing.Point(1083, 121)
        Me.TextboxTS2.Name = "TextboxTS2"
        Me.TextboxTS2.Size = New System.Drawing.Size(68, 20)
        Me.TextboxTS2.TabIndex = 19
        Me.TextboxTS2.Text = "0"
        '
        'TextboxTI2
        '
        Me.TextboxTI2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextboxTI2.Location = New System.Drawing.Point(1083, 147)
        Me.TextboxTI2.Name = "TextboxTI2"
        Me.TextboxTI2.Size = New System.Drawing.Size(68, 20)
        Me.TextboxTI2.TabIndex = 20
        Me.TextboxTI2.Text = "0"
        '
        'LabelCPK2
        '
        Me.LabelCPK2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCPK2.AutoSize = True
        Me.LabelCPK2.BackColor = System.Drawing.Color.White
        Me.LabelCPK2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCPK2.Location = New System.Drawing.Point(1053, 207)
        Me.LabelCPK2.Name = "LabelCPK2"
        Me.LabelCPK2.Size = New System.Drawing.Size(15, 16)
        Me.LabelCPK2.TabIndex = 22
        Me.LabelCPK2.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(974, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "LOWER SPEC LIMIT: "
        '
        'LabelLCL2
        '
        Me.LabelLCL2.AutoSize = True
        Me.LabelLCL2.BackColor = System.Drawing.SystemColors.Window
        Me.LabelLCL2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLCL2.Location = New System.Drawing.Point(3, 129)
        Me.LabelLCL2.Name = "LabelLCL2"
        Me.LabelLCL2.Size = New System.Drawing.Size(16, 20)
        Me.LabelLCL2.TabIndex = 9
        Me.LabelLCL2.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1008, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cpm:"
        '
        'LabelRange2
        '
        Me.LabelRange2.AutoSize = True
        Me.LabelRange2.BackColor = System.Drawing.Color.White
        Me.LabelRange2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRange2.Location = New System.Drawing.Point(3, 172)
        Me.LabelRange2.Name = "LabelRange2"
        Me.LabelRange2.Size = New System.Drawing.Size(16, 20)
        Me.LabelRange2.TabIndex = 9
        Me.LabelRange2.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1008, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Cp:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "RANGE:"
        '
        'LabelCpm2
        '
        Me.LabelCpm2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCpm2.AutoSize = True
        Me.LabelCpm2.BackColor = System.Drawing.Color.White
        Me.LabelCpm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCpm2.Location = New System.Drawing.Point(1053, 175)
        Me.LabelCpm2.Name = "LabelCpm2"
        Me.LabelCpm2.Size = New System.Drawing.Size(15, 16)
        Me.LabelCpm2.TabIndex = 18
        Me.LabelCpm2.Text = "0"
        '
        'LabelLCLword2
        '
        Me.LabelLCLword2.AutoSize = True
        Me.LabelLCLword2.BackColor = System.Drawing.SystemColors.Window
        Me.LabelLCLword2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLCLword2.Location = New System.Drawing.Point(3, 113)
        Me.LabelLCLword2.Name = "LabelLCLword2"
        Me.LabelLCLword2.Size = New System.Drawing.Size(38, 20)
        Me.LabelLCLword2.TabIndex = 9
        Me.LabelLCLword2.Text = "LCL:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(974, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "UPPER SPEC LIMIT:"
        '
        'LabelUCL2
        '
        Me.LabelUCL2.AutoSize = True
        Me.LabelUCL2.BackColor = System.Drawing.SystemColors.Window
        Me.LabelUCL2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUCL2.Location = New System.Drawing.Point(3, 80)
        Me.LabelUCL2.Name = "LabelUCL2"
        Me.LabelUCL2.Size = New System.Drawing.Size(16, 20)
        Me.LabelUCL2.TabIndex = 9
        Me.LabelUCL2.Text = "0"
        '
        'LabelCP2
        '
        Me.LabelCP2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCP2.AutoSize = True
        Me.LabelCP2.BackColor = System.Drawing.Color.White
        Me.LabelCP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCP2.Location = New System.Drawing.Point(1053, 191)
        Me.LabelCP2.Name = "LabelCP2"
        Me.LabelCP2.Size = New System.Drawing.Size(15, 16)
        Me.LabelCP2.TabIndex = 18
        Me.LabelCP2.Text = "0"
        '
        'LabelUCLword2
        '
        Me.LabelUCLword2.AutoSize = True
        Me.LabelUCLword2.BackColor = System.Drawing.SystemColors.Window
        Me.LabelUCLword2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUCLword2.Location = New System.Drawing.Point(3, 64)
        Me.LabelUCLword2.Name = "LabelUCLword2"
        Me.LabelUCLword2.Size = New System.Drawing.Size(39, 20)
        Me.LabelUCLword2.TabIndex = 9
        Me.LabelUCLword2.Text = "UCL:"
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart2.BorderlineWidth = 0
        Me.Chart2.BorderSkin.BackColor = System.Drawing.Color.White
        Me.Chart2.BorderSkin.PageColor = System.Drawing.Color.Silver
        Me.Chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(3, 34)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Size = New System.Drawing.Size(1172, 211)
        Me.Chart2.TabIndex = 14
        Me.Chart2.Text = "Chart2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1178, 583)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL CHART APP"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextboxTS As TextBox
    Friend WithEvents TextboxTI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents labelCP As Label
    Friend WithEvents LabelCPk As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents TextboxTS2 As TextBox
    Friend WithEvents TextboxTI2 As TextBox
    Friend WithEvents LabelCPK2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelCP2 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Title1 As Label
    Friend WithEvents Title2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelCpm As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelCpm2 As Label
    Friend WithEvents LabelLCL As Label
    Friend WithEvents LabelRange As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelLCLword As Label
    Friend WithEvents LabelUCL As Label
    Friend WithEvents LabelUCLword As Label
    Friend WithEvents LabelLCL2 As Label
    Friend WithEvents LabelRange2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LabelLCLword2 As Label
    Friend WithEvents LabelUCL2 As Label
    Friend WithEvents LabelUCLword2 As Label
End Class
