Module Module1

    Sub Main()
        Dim str1, str2, fstr As String
        Dim char1, char2, char3 As Char
        Dim count As Integer

        str1 = ""
        str2 = ""
        fstr = ""
        char1 = ""
        char2 = ""
        char3 = "*"
        count = 0

        Console.Write("enter string to process : ", str1)
        str1 = Console.ReadLine
        str1 = LCase(str1)
        char1 = Left(str1, 1)
        str2 = Right(str1, Len(str1) - 1)
        For count = 1 To Len(str2)
            char2 = Mid(str2, count, 1)
            If char2 = char1 Then
                fstr = fstr & char3
            Else
                fstr = fstr & char2
            End If

        Next
        Console.WriteLine(" processed string is: " & char1 & fstr)
        Console.ReadKey()

    End Sub

End Module
