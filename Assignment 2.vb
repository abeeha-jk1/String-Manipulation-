Module Module1

    Sub Main()


        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        i = 0

        Console.Write("Enter string to be processed:    ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to replace from the string:    ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replace instead:    ")
        Char3 = Console.ReadLine

        For i = 1 To Len(Str1)
            Char2 = Mid(Str1, i, 1)
            If Char1 <> Char2 Then
                Str2 = Str2 & Char2
            Else
                Str2 = Str2 & Char3
            End If
        Next

        Console.WriteLine("The string after replacement is:    " & Str2)

        Console.ReadKey()
    End Sub

End Module
