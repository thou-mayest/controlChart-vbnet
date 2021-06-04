Public Class Options
    Public Shared FilePath As String = "Classeur1.xlsx"
    Public Shared SheetName As String = "Exemple2_CSV"
    Public Shared ColumnNb As Integer = 4
    Public Shared Column1 As String = "D"
    Public Shared Column2 As String = "D"
    Public Shared Column3 As String = "D"
    Public Shared Column4 As String = "D"
    Public Shared LinesRange As Integer = 10
    Public Shared ReadToEnd As Boolean = False


    Public Shared Function ColumnFromChar(column As String)

        Dim chr = column.ToCharArray()
        Array.Reverse(chr)
        Dim rev As String = chr

        Dim result As Integer
        For index = 0 To rev.Length - 1

            result += Math.Pow(26, index) * SimplePos(rev(index)) ' ================= TOOK ME 40min AM STUPID XD

        Next
        Return result
    End Function

    Public Shared Function SimplePos(str As String)
        Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Return alphabet.IndexOf(str.ToUpper) + 1
    End Function

    Public Shared Function CharFromInt(index As Integer)
        Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Return alphabet(index)
    End Function
End Class
