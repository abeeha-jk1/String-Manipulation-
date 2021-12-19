Module Module1

    Sub Main()


        Dim Str1 As String
        Dim Char1, Char2 As Char
        Dim i, digitCount, charCount, count As Integer

        Str1 = ""
        Char1 = ""
        Char2 = ""
        i = 0
        digitCount = 0
        charCount = 0
        count = 0

        Console.Write("Enter string :  ")
        Str1 = Console.ReadLine

        Console.Write(" Enter character to be counted from the string:  ")
        Char2 = Console.ReadLine

        Char2 = UCase(Char2)

        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Char1 = UCase(Char1)
            If Char1 >= "A" And Char1 <= "Z" Then
                charCount = charCount + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                digitCount = digitCount + 1
            End If
            If Char1 = Char2 Then
                count = count + 1
            End If
        Next

        Console.WriteLine("Total Alphabets are: " & charCount)
        Console.WriteLine("Total Digits are: " & digitCount)
        Console.WriteLine("Counted characters are:  " & count)
        Console.ReadKey()
    End Sub

End Module
