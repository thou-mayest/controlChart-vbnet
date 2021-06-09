Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.Threading

Public Class Form1



    Sub InvokeMain()

    End Sub

    Const d2 As Double = 1.128F
    Const d4 As Double = 3.267F
    Const D3 As Double = 0F
    Dim sigma As Double
    Dim cp As Double
    Dim cpk As Double
    Dim cpm As Double

    Public main_chart_points As New DataVisualization.Charting.Series
    Public main_points As New DataVisualization.Charting.Series
    Public Moy_chart_points As New DataVisualization.Charting.Series
    Public UCL_chart_points As New DataVisualization.Charting.Series
    Public LCL_chart_points As New DataVisualization.Charting.Series
    Public TI_chart_points As New DataVisualization.Charting.Series
    Public ts_chart_points As New DataVisualization.Charting.Series


    Public main_chart_points2 As New DataVisualization.Charting.Series
    Public main_points2 As New DataVisualization.Charting.Series
    Public Moy_chart_points2 As New DataVisualization.Charting.Series
    Public UCL_chart_points2 As New DataVisualization.Charting.Series
    Public LCL_chart_points2 As New DataVisualization.Charting.Series
    Public TI_chart_points2 As New DataVisualization.Charting.Series
    Public ts_chart_points2 As New DataVisualization.Charting.Series

    Sub DrawAllCharts(arrayref As Object, arrayControl As Object, etendue As Object)

        ' ================================================================================================================
        ' ============================================      DRAW MAIN CHART ===================================================
        sigma = Moy(etendue) / d2

        DrawChart(main_chart_points, "CONTROLLED 1", arrayref, arrayControl, SeriesChartType.FastLine, Color.ForestGreen, 1.3F)

        '================================================== DRAW MAIN CHART POINTS 



        DrawChart(main_points, "CONTROLED points", arrayref, arrayControl, SeriesChartType.Point, Color.ForestGreen, 2.5F)

        If (Options.CheckDer) Then
            CheckPoints(main_points, (Moy(arrayControl) + 3 * sigma), (Moy(arrayControl) - 3 * sigma), Moy(arrayControl))
        End If
        ' ==================================== DRAW MOY (average)

        DrawHorizantalLine(Moy_chart_points, "Moy", arrayref, Moy(arrayControl), SeriesChartType.Line, Color.Blue, 1.8F)


        '===================================== DRAW LSC and LIC
        DrawHorizantalLine(UCL_chart_points, "LSC", arrayref, (Moy(arrayControl) + 3 * sigma), SeriesChartType.FastLine, Color.PaleVioletRed, 1.5)
        DrawHorizantalLine(LCL_chart_points, "LCL", arrayref, (Moy(arrayControl) - 3 * sigma), SeriesChartType.FastLine, Color.PaleVioletRed, 1.5)

        LabelUCL.Invoke(Sub()
                            LabelUCL.Text = String.Format("{0:0.00}", (Moy(arrayControl) + 3 * sigma))
                        End Sub)
        LabelLCL.Invoke(Sub()
                            LabelLCL.Text = String.Format("{0:0.00}", (Moy(arrayControl) - 3 * sigma))
                        End Sub)

        DrawHorizantalLine(ts_chart_points, "TS", arrayref, Convert.ToDouble(Options.replace(TextboxTS.Text)), SeriesChartType.FastLine, Color.Red, 1)
        DrawHorizantalLine(TI_chart_points, "TI", arrayref, Convert.ToDouble(Options.replace(TextboxTI.Text)), SeriesChartType.FastLine, Color.Red, 1)


        labelCP.Invoke(Sub()
                           cp = (Convert.ToDouble(Options.replace(TextboxTS.Text)) - Convert.ToDouble(Options.replace(TextboxTI.Text))) / (6 * sigma)
                           labelCP.Text = String.Format("{0:0.000}", cp)
                           Debug.WriteLine(cp & " cp")
                           If cp < 1.33 Then
                               labelCP.ForeColor = Color.Red
                           ElseIf cp > 1.67 Then
                               labelCP.ForeColor = Color.ForestGreen

                           Else
                               labelCP.ForeColor = Color.DarkOrange
                           End If



                       End Sub)


        LabelCPk.Invoke(Sub()
                            Dim val1 = (Moy(arrayControl) - Convert.ToDouble(Options.replace(TextboxTI.Text))) / (3 * sigma)
                            Dim val2 = (Convert.ToDouble(Options.replace(TextboxTS.Text)) - Moy(arrayControl)) / (3 * sigma)
                            cpk = Math.Min(val1, val2)
                            LabelCPk.Text = String.Format("{0:0.000}", cpk)
                            If cpk < 1.33 Then
                                LabelCPk.ForeColor = Color.Red
                            ElseIf cp > 1.67 Then
                                LabelCPk.ForeColor = Color.ForestGreen

                            Else
                                LabelCPk.ForeColor = Color.DarkOrange
                            End If

                        End Sub)

        LabelCpm.Invoke(Sub()
                            cpm = cp / (Math.Sqrt(1 + 9 * Math.Pow((cp - cpk), 2)))
                            LabelCpm.Text = String.Format("{0:0.00}", cpm)

                            If cpm < 1.33 Then
                                LabelCpm.ForeColor = Color.Red
                            ElseIf cp > 1.67 Then
                                LabelCpm.ForeColor = Color.ForestGreen

                            Else
                                LabelCpm.ForeColor = Color.DarkOrange
                            End If
                        End Sub)

        Chart1.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = ChartDashStyle.DashDot
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = ChartDashStyle.DashDot



        'Chart1.ChartAreas(0).AxisY.Maximum = 0.5
        ' ================================================================================================================
        ' ============================================      DRAW etendue CHART ===========================================

        DrawChart(main_chart_points2, "CONTROLLED 1", arrayref, etendue, SeriesChartType.FastLine, Color.ForestGreen, 1.3F)

        '================================================== DRAW MAIN CHART POINTS 



        DrawChart(main_points2, "CONTROLED points", arrayref, etendue, SeriesChartType.Point, Color.ForestGreen, 2.5F)


        If (Options.CheckDer) Then
            CheckPoints(main_points2, d4 * Moy(etendue), D3 * Moy(etendue), Moy(etendue))
        End If
        ' ==================================== DRAW MOY (average)

        DrawHorizantalLine(Moy_chart_points2, "Moy", arrayref, Moy(etendue), SeriesChartType.Line, Color.Blue, 1.8F)

        '===================================== DRAW LSC and LIC
        DrawHorizantalLine(UCL_chart_points2, "LSC", arrayref, d4 * Moy(etendue), SeriesChartType.FastLine, Color.PaleVioletRed, 1.5)
        DrawHorizantalLine(LCL_chart_points2, "LCL", arrayref, D3 * Moy(etendue), SeriesChartType.FastLine, Color.PaleVioletRed, 1.5)

        LabelUCL2.Invoke(Sub()
                             LabelUCL2.Text = String.Format("{0:0.00}", (Moy(arrayControl) + 3 * sigma))
                         End Sub)
        LabelLCL2.Invoke(Sub()
                             LabelLCL2.Text = String.Format("{0:0.00}", (Moy(arrayControl) - 3 * sigma))
                         End Sub)

        DrawHorizantalLine(ts_chart_points2, "TS", arrayref, Convert.ToDouble(Options.replace(TextboxTS2.Text)), SeriesChartType.FastLine, Color.Red, 1)
        DrawHorizantalLine(TI_chart_points2, "TI", arrayref, Convert.ToDouble(Options.replace(TextboxTI2.Text)), SeriesChartType.FastLine, Color.Red, 1)

        ' ==============://///////////// CHANGE LABEL NAME AND CALC CPK  &&..
        LabelCP2.Invoke(Sub()
                            cp = (Convert.ToDouble(Options.replace(TextboxTS2.Text)) - Convert.ToDouble(Options.replace(TextboxTI2.Text))) / (6 * sigma)
                            LabelCP2.Text = String.Format("{0:0.00}", cp)
                            If cp < 1.33 Then
                                LabelCP2.ForeColor = Color.Red
                            ElseIf cp > 1.67 Then
                                LabelCP2.ForeColor = Color.ForestGreen

                            Else
                                LabelCP2.ForeColor = Color.DarkOrange
                            End If
                        End Sub)
        LabelCPK2.Invoke(Sub()
                             Dim val1 = (Moy(arrayControl) - Convert.ToDouble(Options.replace(TextboxTI2.Text))) / (3 * sigma)
                             Dim val2 = (Convert.ToDouble(Options.replace(TextboxTS2.Text)) - Moy(arrayControl)) / (3 * sigma)
                             cpk = Math.Min(val1, val2)
                             LabelCPK2.Text = String.Format("{0:0.00}", cpk)
                             If cpk < 1.33 Then
                                 LabelCPK2.ForeColor = Color.Red
                             ElseIf cp > 1.67 Then
                                 LabelCPK2.ForeColor = Color.ForestGreen

                             Else
                                 LabelCPK2.ForeColor = Color.DarkOrange
                             End If

                         End Sub)

        LabelCpm.Invoke(Sub()
                            cpm = cp / (Math.Sqrt(1 + 9 * Math.Pow((cp - cpk), 2)))
                            LabelCpm2.Text = String.Format("{0:0.00}", cpm)

                            If cpm < 1.33 Then
                                LabelCpm2.ForeColor = Color.Red
                            ElseIf cp > 1.67 Then
                                LabelCpm2.ForeColor = Color.ForestGreen

                            Else
                                LabelCpm2.ForeColor = Color.DarkOrange
                            End If
                        End Sub)

        Chart2.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = ChartDashStyle.DashDot
        Chart2.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = ChartDashStyle.DashDot


    End Sub

    Dim pointY As Double
    Dim inarow(7) As Double
    Dim tempSomme As Double
    Private Sub CheckPoints(chart As DataVisualization.Charting.Series, ucl As Double, lcl As Double, moy As Double)

        For i = 1 To chart.Points().Count - 1
            pointY = chart.Points(i).YValues(0)


            If pointY < lcl Or pointY > ucl Then
                chart.Points(i).Color = Color.Red
            End If

            Try
                tempSomme = 0
                For index = i To i - 6 Step -1
                    tempSomme += (chart.Points(index).YValues(0) - moy) / Math.Abs((chart.Points(index).YValues(0) - moy))
                    ' Debug.WriteLine(tempSomme & " // " & "i: " & i.ToString())
                Next
                If tempSomme = 7 Then
                    For j = i To (i - 6) Step -1
                        chart.Points(j).Color = Color.Orange
                    Next
                End If
                If tempSomme = -7 Then
                    For k = i To i - 6 Step -1
                        chart.Points(k).Color = Color.Orange
                    Next
                End If
            Catch ex As Exception

            End Try




        Next



    End Sub
    Public Sub DrawChart(chart As DataVisualization.Charting.Series, name As String, refarray As Array, ControlData As Array, ChartType As SeriesChartType, color As Color, Border As Double)
        chart.Points.Clear()
        chart.Name = name
        chart.ChartType = ChartType
        chart.Color = color
        chart.BorderWidth = Border

        For index = 2 To UBound(refarray) - 1

            chart.Points.AddXY(refarray(index), ControlData(index))

        Next


    End Sub

    Public Sub DrawPoints()

    End Sub
    Public Sub DrawHorizantalLine(chart As DataVisualization.Charting.Series, name As String, refarray As Array, ControlData As Double, ChartType As SeriesChartType, color As Color, Border As Double)
        chart.Points.Clear()
        chart.Name = name
        chart.ChartType = ChartType
        chart.Color = color
        chart.BorderWidth = Border

        For index = 2 To UBound(refarray) - 1
            chart.Points.AddXY(refarray(index), ControlData)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Running..."


        'MainStart()


        If Options.interval <> 0 Then
            Timer1.Interval = Options.interval
            Timer1.Start()
        Else
            MsgBox(" intervalle ne peut pas etre nulle ")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DrawAllCharts()
        'ReadFromXL()

        OptionsForm.Show()
        ' =============== insitialize charts series
        LabelUCL.ForeColor = Color.PaleVioletRed
        LabelUCLword.ForeColor = Color.PaleVioletRed

        LabelLCL.ForeColor = Color.PaleVioletRed
        LabelLCLword.ForeColor = Color.PaleVioletRed

        LabelUCL2.ForeColor = Color.PaleVioletRed
        LabelUCLword2.ForeColor = Color.PaleVioletRed

        LabelLCL2.ForeColor = Color.PaleVioletRed
        LabelLCLword2.ForeColor = Color.PaleVioletRed
        Try
            Chart1.Series.Add(main_chart_points)
            main_chart_points.Name = "MAIN CHART"
            Chart1.Series.Add(Moy_chart_points)
            Moy_chart_points.Name = "MOY"
            Chart1.Series.Add(main_points)
            main_points.Name = "MAIN CHART POINTS"
            Chart1.Series.Add(UCL_chart_points)
            UCL_chart_points.Name = "UCL CHART"
            Chart1.Series.Add(LCL_chart_points)
            LCL_chart_points.Name = "LCL CHART"
            Chart1.Series.Add(TI_chart_points)
            TI_chart_points.Name = "TI "
            Chart1.Series.Add(ts_chart_points)
            ts_chart_points.Name = "TS"
            ' =============== init chart2
            Chart2.Series.Add(main_chart_points2)
            main_chart_points2.Name = "MAIN CHART"
            Chart2.Series.Add(Moy_chart_points2)
            Moy_chart_points2.Name = "MOY"
            Chart2.Series.Add(main_points2)
            main_points2.Name = "MAIN CHART POINTS"
            Chart2.Series.Add(UCL_chart_points2)
            UCL_chart_points2.Name = "UCL CHART"
            Chart2.Series.Add(LCL_chart_points2)
            LCL_chart_points2.Name = "LCL CHART"
            Chart2.Series.Add(TI_chart_points2)
            TI_chart_points2.Name = "TI "
            Chart2.Series.Add(ts_chart_points2)
            ts_chart_points2.Name = "TS"
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub


    '============== CAHNGE: to read path from button 
    Dim Filepath As String

    Dim FileName As String

    '========= CHANGE: get filesheet names in drop list
    Dim WorksheetName As String

    Dim int As Integer



    Dim xlapp As New Microsoft.Office.Interop.Excel.Application

    Dim workbook As Microsoft.Office.Interop.Excel.Workbook
    Dim worksheets As Excel.Sheets
    Dim xlworksheet As Microsoft.Office.Interop.Excel._Worksheet
    Dim xlrange As Microsoft.Office.Interop.Excel.Range
    Dim xlrow As Integer

    Dim range As Integer
    Dim xlColumn As Integer = 1

    Sub MainStart()

        Try

            'WorksheetName = Options.SheetName

            Filepath = Options.FilePath

            ReadFromXL()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ReadFromXL()






        workbook = xlapp.Workbooks.Open(Filepath)

        'new here 
        worksheets = workbook.Worksheets()
        Try
            xlworksheet = worksheets(0)
        Catch ex As Exception
            xlworksheet = worksheets(1)
        End Try


        'xlworksheet = workbook.Worksheets(Options.SheetName)

        xlrange = xlworksheet.UsedRange


        If Options.ReadToEnd Then
            range = xlrange.Rows.Count
        Else
            range = Options.LinesRange + 1
        End If




        Dim dataarrayRef(range + 1) As String
        Dim arraymoy(range + 1) As Double
        Dim P1(range + 1) As String
        Dim P2(range + 1) As String
        Dim P3(range + 1) As String
        Dim P4(range + 1) As String
        Dim etendue(range + 1) As Double

        LabelRange.Invoke(Sub()
                              LabelRange.Text = range
                          End Sub)
        LabelRange2.Invoke(Sub()
                               LabelRange2.Text = range
                           End Sub)

        Debug.WriteLine(range & " : range")
        ' =====================================  POPULATE FUNCTIONS p1 and ref


        xlColumn = Options.ColumnFromChar(Options.Column1)
        'Debug.WriteLine(xlColumn & ": xlcolumn")
        Try
            For xlrow = 2 To range
                'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)

                dataarrayRef(xlrow) = xlrange.Cells(xlrow, 1).Text
                P1(xlrow) = xlrange.Cells(xlrow, xlColumn).Text

            Next

        Catch ex As Exception
            MsgBox(ex.Message & " : populate function p1 and ref")
        End Try


        ' =====================================  POPULATE FUNCTIONS p2 

        xlColumn = Options.ColumnFromChar(Options.Column2)

        For xlrow = 2 To range
            'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)

            P2(xlrow) = xlrange.Cells(xlrow, xlColumn).Text

        Next

        ' =====================================  POPULATE FUNCTIONS p3

        xlColumn = Options.ColumnFromChar(Options.Column3)

        For xlrow = 2 To range
            'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)


            P3(xlrow) = xlrange.Cells(xlrow, xlColumn).Text

        Next

        ' =====================================  POPULATE FUNCTIONS p4

        xlColumn = Options.ColumnFromChar(Options.Column4)

        For xlrow = 2 To range
            'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)
            If xlColumn > 0 Then
                P4(xlrow) = xlrange.Cells(xlrow, xlColumn).Text
            Else

                P4(xlrow) = "0"
            End If
        Next


        ' ================================== calc and populate Moy

        For xlrow = 2 To range

            Try
                arraymoy(xlrow) = ((Convert.ToDouble(Options.replace(P1(xlrow))) + Convert.ToDouble(Options.replace(P2(xlrow))) + Convert.ToDouble(Options.replace(P3(xlrow))) + Convert.ToDouble(Options.replace(P4(xlrow)))) / 4) 'change if p4 null
                Debug.WriteLine(P3(xlrow) & " : moy p1")
                Debug.WriteLine(P4(xlrow) & " : moy p4")
            Catch ex As Exception
                arraymoy(xlrow) = 0
            End Try

            'Debug.WriteLine(Convert.ToDouble(arraymoy(xlrow)))
        Next

        ' ================================= calculate and populate "etendue"

        For xlrow = 3 To range
            etendue(xlrow) = Math.Abs(arraymoy(xlrow) - arraymoy(xlrow - 1))
        Next

        Try
            Chart1.Invoke(Sub()
                              DrawAllCharts(dataarrayRef, arraymoy, etendue)
                          End Sub)



            'xlapp.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
            'Timer1.Stop()
        End Try

        xlapp.UserControl = True

        workbook = Nothing
        worksheets = Nothing
        xlworksheet = Nothing
        xlrange = Nothing

    End Sub



    Dim Moyint As Double
    Dim ElCount As Integer
    Function Moy(array As Object) As Double

        ElCount = 0
        Moyint = 0

        If IsArray(array) Then
            For i = LBound(array) + 2 To UBound(array) - 1
                Moyint += Convert.ToDouble(array(i))
                ElCount += 1
            Next
            Moyint = Moyint / ElCount
        End If



        Return Moyint

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button1.Text = "Start"

        Timer1.Stop()


    End Sub

    Dim ReadThread As Threading.Thread

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MainStart()
        ReadThread = New Thread(New ThreadStart(AddressOf MainStart))
        ReadThread.Start()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


        Try
            Timer1.Stop()

        Catch ex As Exception
            MsgBox("timer not stoped")
        End Try
        Try
            ReadThread.Abort()
        Catch ex As Exception
            MsgBox("tread not sotpped")
        End Try
        Try
            workbook.Close()
        Catch ex As Exception
            MsgBox("workbook not closed: " & ex.Message)
        End Try

        Try
            xlapp.Quit()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TextboxUSL_Leave(sender As Object, e As EventArgs) Handles TextboxTS.Leave
        Try

            Convert.ToDouble(Options.replace(TextboxTS.Text))
        Catch ex As Exception
            MsgBox("TS doit etre reelle")
            TextboxTS.Select()
        End Try
    End Sub

    Private Sub TextboxLSL_Leave(sender As Object, e As EventArgs) Handles TextboxTI.Leave

        Try

            Convert.ToDouble(Options.replace(TextboxTI.Text))
        Catch ex As Exception
            MsgBox("TI doit etre reelle")
            TextboxTI.Select()
        End Try
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        OptionsForm.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Title2.Click, Title1.Click

    End Sub

    Private Sub TextboxUSL_TextChanged(sender As Object, e As EventArgs) Handles TextboxTS.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Label12.Click, LabelUCL.Click, LabelRange.Click, LabelLCL.Click, LabelUCLword.Click, Label13.Click, LabelLCLword.Click, LabelUCLword2.Click, LabelUCL2.Click, LabelRange2.Click, LabelLCLword2.Click, LabelLCL2.Click, Label15.Click

    End Sub

    Private Sub labelCP_Click(sender As Object, e As EventArgs) Handles labelCP.Click, LabelCpm.Click

    End Sub

    Private Sub TextboxTS2_Leave(sender As Object, e As EventArgs) Handles TextboxTS2.Leave

    End Sub

    Private Sub TextboxTI2_Leave(sender As Object, e As EventArgs) Handles TextboxTI2.Leave

    End Sub
End Class