Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop.Excel
Imports System.Threading

'this could be a magor change =====================================::::::::///////////////////////////////
Public Class Form1



    Sub InvokeMain()

    End Sub

    Const d2 As Double = 1.128F



    Public main_chart_points As New DataVisualization.Charting.Series

    Public main_points As New DataVisualization.Charting.Series
    Public Moy_chart_points As New DataVisualization.Charting.Series
    Public UCL_chart_points As New DataVisualization.Charting.Series
    Public LCL_chart_points As New DataVisualization.Charting.Series


    Sub DrawAllCharts(arrayref As Object, arrayControl As Object, arrayMR As Object)


        ' ============================================      DRAW MAIN CHART 


        DrawChart(main_chart_points, "CHART 1", arrayref, arrayControl, SeriesChartType.FastLine, Color.BlueViolet, 2.0F)

        '================================================== DRAW MAIN CHART POINTS 



        DrawChart(main_points, "TEST CHART points", arrayref, arrayControl, SeriesChartType.Point, Color.Red, 2.5F)

        ' ==================================== DRAW MOY (average)

        DrawHorizantalLine(Moy_chart_points, "Moy", arrayref, Moy(arrayControl), SeriesChartType.Line, Color.Blue, 1.5F)

        '===================================== DRAW UCL and LCL
        DrawHorizantalLine(UCL_chart_points, "UCL", arrayref, (Moy(arrayControl) + 3 * Moy(arrayMR)) / d2, SeriesChartType.FastLine, Color.Red, 1.5)
        DrawHorizantalLine(LCL_chart_points, "LCL", arrayref, (Moy(arrayControl) - 3 * Moy(arrayMR)) / d2, SeriesChartType.FastLine, Color.Red, 1.5)

        labelCP.Invoke(Sub()
                           labelCP.Text = (Convert.ToInt32(TextboxUSL.Text) - Convert.ToInt32(TextboxLSL.Text)) / Moy(arrayMR) / d2
                       End Sub)
        LabelCPk.Invoke(Sub()
                            Dim val1 = (Moy(arrayControl) - Convert.ToInt32(TextboxLSL.Text)) / 3 * Moy(arrayMR) / d2
                            Dim val2 = (Convert.ToInt32(TextboxUSL.Text) - Moy(arrayControl)) / 3 * Moy(arrayMR) / d2
                            LabelCPk.Text = Math.Min(val1, val2)
                        End Sub)


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
    Public Sub DrawHorizantalLine(chart As DataVisualization.Charting.Series, name As String, refarray As Array, ControlData As Integer, ChartType As SeriesChartType, color As Color, Border As Double)
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
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    '============== CAHNGE: to read path from button 
    Dim Filepath = My.Application.Info.DirectoryPath + "\" + "Test.xlsx"

    Dim FileName = ""

    '========= CHANGE: get filesheet names in drop list
    Dim WorksheetName As String

    Dim int As Integer



    Dim xlapp As New Microsoft.Office.Interop.Excel.Application

    Dim workbook As Microsoft.Office.Interop.Excel.Workbook
    Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim xlrange As Microsoft.Office.Interop.Excel.Range
    Dim xlrow As Integer

    Dim xlColumn As Integer = 1

    Sub MainStart()

        Try
            xlColumn = Convert.ToInt32(TextBoxColumnNb.Text)
            WorksheetName = TextBoxSheetName.Text
            Filepath = My.Application.Info.DirectoryPath + "\" + TextBoxFilePath.Text

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



        Dim dataarrayRef(xlrange.Rows.Count + 1) As String
        Dim dataarrayControled(xlrange.Rows.Count + 1) As String
        Dim dataMR(xlrange.Rows.Count + 1) As Integer

        '============================ populate dataarray

        'For xlrow = 2 To xlrange.Rows.Count
        '    Debug.WriteLine("test    ")
        '    'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)
        '    If Not String.IsNullOrEmpty(xlrange.Cells(xlrow, 1).Text) Then
        '        dataarrayRef(xlrow) = xlrange.Cells(xlrow, 1).Text
        '    Else
        '        dataarrayRef(xlrow) = "0"
        '    End If


        '    Debug.WriteLine(dataarrayRef(xlrow))

        'Next

        ' ============================== populate controled dataarray
        'For xlrow = 2 To xlrange.Rows.Count
        '    'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Rows(xlrow, 1))
        '    If Not String.IsNullOrEmpty(xlrange.Cells(xlrow, xlColumn).Text) Then
        '        dataarrayControled(xlrow) = xlrange.Cells(xlrow, xlColumn).Text
        '    Else
        '        dataarrayControled(xlrow) = "0"
        '    End If

        'Next


        ' =====================================  POPULATE FUNCTIONS
        Dim doubleTemp As Double
        For xlrow = 2 To xlrange.Rows.Count
            'Debug.WriteLine(xlrow.ToString + " // " + xlrange.Cells(xlrow, 1).Text)
            If String.IsNullOrEmpty(xlrange.Cells(xlrow, 1).Text) Or String.IsNullOrEmpty(xlrange.Cells(xlrow, xlColumn).Text) Or Not Double.TryParse(xlrange.Cells(xlrow, xlColumn).Text, doubleTemp) Then
                dataarrayControled(xlrow) = "0"
                dataarrayRef(xlrow) = "0"
            Else
                dataarrayRef(xlrow) = xlrange.Cells(xlrow, 1).Text
                dataarrayControled(xlrow) = xlrange.Cells(xlrow, xlColumn).Text
            End If
        Next
        ' ================================== populate MR

        For index = 3 To UBound(dataarrayControled) - 1
            dataMR(index) = Math.Abs(dataarrayControled(index) - dataarrayControled(index - 1)).ToString()
            'Console.WriteLine(dataarrayControled(index).ToString() + " - " + dataarrayControled(index - 1).ToString() + " = " + dataMR(index - 1).ToString())
            Console.WriteLine(Math.Abs(dataarrayControled(index) - dataarrayControled(index - 1)).ToString())
        Next



        Try
            Chart1.Invoke(Sub()
                              DrawAllCharts(dataarrayRef, dataarrayControled, dataMR)
                          End Sub)

        Catch ex As Exception
            MsgBox(ex.Message)
            Timer1.Stop()
        End Try

    End Sub




    Dim Moyint As Integer
    Dim ElCount As Integer
    Function Moy(array As Object) As Integer

        ElCount = 0
        Moyint = 0

        If IsArray(array) Then
            For i = LBound(array) + 2 To UBound(array) - 1
                Moyint += array(i)
                ElCount += 1
            Next
            Moyint = Moyint / ElCount
        End If

        Return Moyint

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


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
            ReadThread.Abort()
        Catch ex As Exception

        End Try

        Try
            workbook.Close()
        Catch ex As Exception

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
End Class
