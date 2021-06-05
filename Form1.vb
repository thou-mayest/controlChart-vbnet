Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop.Excel
Imports System.Threading

Public Class Form1



    Sub InvokeMain()

    End Sub

    Const d2 As Double = 1.128F
    Const d4 As Double = 3.267F
    Const D3 As Double = 0F

    Public main_chart_points As New DataVisualization.Charting.Series

    Public main_points As New DataVisualization.Charting.Series
    Public Moy_chart_points As New DataVisualization.Charting.Series
    Public UCL_chart_points As New DataVisualization.Charting.Series
    Public LCL_chart_points As New DataVisualization.Charting.Series

    Public main_chart_points2 As New DataVisualization.Charting.Series
    Public main_points2 As New DataVisualization.Charting.Series
    Public Moy_chart_points2 As New DataVisualization.Charting.Series
    Public UCL_chart_points2 As New DataVisualization.Charting.Series
    Public LCL_chart_points2 As New DataVisualization.Charting.Series

    Sub DrawAllCharts(arrayref As Object, arrayControl As Object, etendue As Object)

        ' ================================================================================================================
        ' ============================================      DRAW MAIN CHART ===================================================


        DrawChart(main_chart_points, "CONTROLLED 1", arrayref, arrayControl, SeriesChartType.FastLine, Color.ForestGreen, 1.3F)

        '================================================== DRAW MAIN CHART POINTS 



        DrawChart(main_points, "CONTROLED points", arrayref, arrayControl, SeriesChartType.Point, Color.ForestGreen, 2.5F)

        ' ==================================== DRAW MOY (average)

        DrawHorizantalLine(Moy_chart_points, "Moy", arrayref, Moy(arrayControl), SeriesChartType.Line, Color.Blue, 1.8F)
        Debug.WriteLine(Moy(arrayControl) & " : this is moyint")

        '===================================== DRAW LSC and LIC
        DrawHorizantalLine(UCL_chart_points, "LSC", arrayref, (Moy(arrayControl) + 3 * Moy(etendue)) / d2, SeriesChartType.FastLine, Color.PaleVioletRed, 1.5)
        DrawHorizantalLine(LCL_chart_points, "LCL", arrayref, (Moy(arrayControl) - 3 * Moy(etendue)) / d2, SeriesChartType.FastLine, Color.Red, 1.5)

        ' ==================================== TEMP UCL AND LCL

        'DrawHorizantalLine(UCL_chart_points, "LSC", arrayref, (Moy(arrayControl) + 3 * 7) / d2, SeriesChartType.FastLine, Color.PaleVioletRed, 1.5)
        'DrawHorizantalLine(LCL_chart_points, "LCL", arrayref, (Moy(arrayControl) - 3 * 7) / d2, SeriesChartType.FastLine, Color.Red, 1.5)

        labelCP.Invoke(Sub()
                           labelCP.Text = (Convert.ToInt32(TextboxUSL.Text) - Convert.ToInt32(TextboxLSL.Text)) / Moy(etendue) / d2
                       End Sub)
        LabelCPk.Invoke(Sub()
                            Dim val1 = (Moy(arrayControl) - Convert.ToInt32(TextboxLSL.Text)) / 3 * Moy(etendue) / d2
                            Dim val2 = (Convert.ToInt32(TextboxUSL.Text) - Moy(arrayControl)) / 3 * Moy(etendue) / d2
                            LabelCPk.Text = Math.Min(val1, val2)
                        End Sub)

        Chart1.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = ChartDashStyle.DashDot
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = ChartDashStyle.DashDot

        'Chart1.ChartAreas(0).AxisY.Maximum = 0.5
        ' ================================================================================================================
        ' ============================================      DRAW etendue CHART ===========================================

        DrawChart(main_chart_points2, "CONTROLLED 1", arrayref, etendue, SeriesChartType.FastLine, Color.ForestGreen, 1.3F)

        '================================================== DRAW MAIN CHART POINTS 



        DrawChart(main_points2, "CONTROLED points", arrayref, etendue, SeriesChartType.Point, Color.ForestGreen, 2.5F)

        ' ==================================== DRAW MOY (average)

        DrawHorizantalLine(Moy_chart_points2, "Moy", arrayref, Moy(etendue), SeriesChartType.Line, Color.Blue, 1.8F)

        '===================================== DRAW LSC and LIC
        DrawHorizantalLine(UCL_chart_points2, "LSC", arrayref, d4 * Moy(etendue), SeriesChartType.FastLine, Color.PaleVioletRed, 1.5)
        DrawHorizantalLine(LCL_chart_points2, "LCL", arrayref, D3 * Moy(etendue), SeriesChartType.FastLine, Color.Red, 1.5)
        Debug.WriteLine(d4 * Moy(etendue) & " : LSC")

        ' ==============://///////////// CHANGE LABEL NAME AND CALC CPK  &&..
        labelCP.Invoke(Sub()
                           LabelCP2.Text = (Convert.ToInt32(TextboxUSL.Text) - Convert.ToInt32(TextboxLSL.Text)) / Moy(etendue) / d2
                       End Sub)
        LabelCPk.Invoke(Sub()
                            Dim val1 = (Moy(arrayControl) - Convert.ToInt32(TextboxLSL.Text)) / 3 * Moy(etendue) / d2

                            Dim val2 = (Convert.ToInt32(TextboxUSL.Text) - Moy(arrayControl)) / 3 * Moy(etendue) / d2
                            LabelCPK2.Text = Math.Min(val1, val2)
                        End Sub)

        Chart2.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = ChartDashStyle.DashDot
        Chart2.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = ChartDashStyle.DashDot


    End Sub

    Dim tempd As Double
    Public Sub DrawChart(chart As DataVisualization.Charting.Series, name As String, refarray As Array, ControlData As Array, ChartType As SeriesChartType, color As Color, Border As Double)
        chart.Points.Clear()
        chart.Name = name
        chart.ChartType = ChartType
        chart.Color = color
        chart.BorderWidth = Border

        For index = 2 To UBound(refarray) - 1
            If Not String.IsNullOrEmpty(refarray(index)) Then
                chart.Points.AddXY(refarray(index), ControlData(index))
            End If


        Next
    End Sub
    Public Sub DrawHorizantalLine(chart As DataVisualization.Charting.Series, name As String, refarray As Array, ControlData As Double, ChartType As SeriesChartType, color As Color, Border As Double)
        chart.Points.Clear()
        chart.Name = name
        chart.ChartType = ChartType
        chart.Color = color
        chart.BorderWidth = Border

        For index = 2 To UBound(refarray) - 1
            chart.Points.AddXY(refarray(index), ControlData)
            'chart.Points.AddXY(refarray(index), 0.002)
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Running..."


        'MainStart()

        Timer1.Interval = 5000
        Timer1.Start()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DrawAllCharts()
        'ReadFromXL()

        ' =============== insitialize charts series
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
            ' =============== init chart2
            Chart2.Series.Add(main_chart_points2)
            main_chart_points.Name = "MAIN CHART"
            Chart2.Series.Add(Moy_chart_points2)
            Moy_chart_points.Name = "MOY"
            Chart2.Series.Add(main_points2)
            main_points.Name = "MAIN CHART POINTS"
            Chart2.Series.Add(UCL_chart_points2)
            UCL_chart_points.Name = "UCL CHART"
            Chart2.Series.Add(LCL_chart_points2)
            LCL_chart_points.Name = "LCL CHART"
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
    Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim xlrange As Microsoft.Office.Interop.Excel.Range
    Dim xlrow As Integer

    Dim range As Integer
    Dim xlColumn As Integer = 1

    Sub MainStart()

        Try

            WorksheetName = Options.SheetName
            Filepath = My.Application.Info.DirectoryPath + "\" + Options.FilePath

            ReadFromXL()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub ReadFromXL()

        'xlapp = New Application

        Console.WriteLine(WorksheetName + "   /  " + Filepath)


        workbook = xlapp.Workbooks.Open(Filepath)

        xlworksheet = workbook.Worksheets(WorksheetName)

        xlrange = xlworksheet.UsedRange


        If Options.ReadToEnd Then
            range = xlrange.Rows.Count + 1
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



        Debug.WriteLine(range & " : range")
        ' =====================================  POPULATE FUNCTIONS p1 and ref

        Dim doubleTemp As Double
        xlColumn = Options.ColumnFromChar(Options.Column1)
        'Debug.WriteLine(xlColumn & ": xlcolumn")
        Try
            For xlrow = 2 To range
                'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)
                If String.IsNullOrEmpty(xlrange.Cells(xlrow, 1).Text) Or String.IsNullOrEmpty(xlrange.Cells(xlrow, xlColumn).Text) Or Not Double.TryParse(xlrange.Cells(xlrow, xlColumn).Text, doubleTemp) Then
                    P1(xlrow) = "0"
                    dataarrayRef(xlrow) = "0"
                Else
                    dataarrayRef(xlrow) = xlrange.Cells(xlrow, 1).Text
                    P1(xlrow) = xlrange.Cells(xlrow, xlColumn).Text
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message & " : populate function p1 and ref")
        End Try


        ' =====================================  POPULATE FUNCTIONS p2 

        xlColumn = Options.ColumnFromChar(Options.Column2)

        For xlrow = 2 To range
            'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)
            If String.IsNullOrEmpty(xlrange.Cells(xlrow, xlColumn).Text) Or Not Double.TryParse(xlrange.Cells(xlrow, xlColumn).Text, doubleTemp) Then
                P2(xlrow) = "0"

            Else

                P2(xlrow) = xlrange.Cells(xlrow, xlColumn).Text
            End If
        Next

        ' =====================================  POPULATE FUNCTIONS p3

        xlColumn = Options.ColumnFromChar(Options.Column3)

        For xlrow = 2 To range
            'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)
            If String.IsNullOrEmpty(xlrange.Cells(xlrow, xlColumn).Text) Or Not Double.TryParse(xlrange.Cells(xlrow, xlColumn).Text, doubleTemp) Then
                P3(xlrow) = "0"

            Else

                P3(xlrow) = xlrange.Cells(xlrow, xlColumn).Text
            End If
        Next

        ' =====================================  POPULATE FUNCTIONS p4

        xlColumn = Options.ColumnFromChar(Options.Column4)

        For xlrow = 2 To range
            'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)
            If String.IsNullOrEmpty(xlrange.Cells(xlrow, xlColumn).Text) Or Not Double.TryParse(xlrange.Cells(xlrow, xlColumn).Text, doubleTemp) Then
                P4(xlrow) = "0"

            Else

                P4(xlrow) = xlrange.Cells(xlrow, xlColumn).Text
            End If
        Next

        ' ================================== calc and populate Moy

        For xlrow = 2 To range
            arraymoy(xlrow) = Convert.ToDouble((Convert.ToDouble(P1(xlrow)) + Convert.ToDouble(P2(xlrow)) + Convert.ToDouble(P3(xlrow)) + Convert.ToDouble(P4(xlrow))) / 4) * 100
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

        Catch ex As Exception
            MsgBox(ex.Message & "  : 1 ")
            Timer1.Stop()
        End Try

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

    Private Sub TextboxUSL_Leave(sender As Object, e As EventArgs) Handles TextboxUSL.Leave
        Try
            Convert.ToInt32(TextboxUSL.Text)
        Catch ex As Exception
            MsgBox("USL field should be an int")
            TextboxUSL.Select()
        End Try
    End Sub

    Private Sub TextboxLSL_Leave(sender As Object, e As EventArgs) Handles TextboxLSL.Leave
        Try
            Convert.ToInt32(TextboxLSL.Text)
        Catch ex As Exception
            MsgBox("LSL field should be an int")
            TextboxLSL.Select()
        End Try
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        OptionsForm.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextboxUSL_TextChanged(sender As Object, e As EventArgs) Handles TextboxUSL.TextChanged

    End Sub
End Class