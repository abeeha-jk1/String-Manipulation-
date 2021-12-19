Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Char1 As Char()
        Dim Alphabets As Boolean
        Dim i As Integer
        Alphabets = True
        Str1 = ""
        Char1 = ""
        i = 0
        Console.Write("Entre String:")
        Str1 = Console.ReadLine
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char1 = UCase(Char1)
            If Char1 < "A" Or Char1 > "Z" Then
                Alphabets = False
            End If

        Next i
        If Alphabets = False Then
            Console.WriteLine("All characters are not alphabets")
        Else
            Console.WriteLine("All characters are alphabets")

        End If
        Console.ReadKey()

    End Sub

End Module
