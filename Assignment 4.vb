Module Module1

    Sub Main()
        Dim Str As String
        Dim Char1, Char2, Char3 As Char
        Dim i, j, c, Max As Integer
        Str = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        i = 0
        j = 0
        Max = 0
        Console.Write("Entre string to be processed : ")
        Str = Console.ReadLine
        For i = 1 To Len(Str)
            c = 0
            Char1 = Mid(Str, i, 1)
            For j = 1 To Len(Str)
                Char2 = Mid(Str, j, i)
                If Char1 = Char2 Then
                    c = c + 1
                End If
            Next
            If c > Max Then
                Max = c
                Char3 = Char1
            End If
        Next
        Console.WriteLine("Most repeated character is : " & Char3)
        Console.WriteLine("Number of times it is repeated is : " & Max)
        Console.ReadKey()

    End Sub

End Module
