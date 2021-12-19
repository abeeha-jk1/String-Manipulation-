Module Module1

    Sub Main()
        Dim str1 As String
        Dim chara, chare, chari, charo, charu, thischar As Char
        Dim i, ca, ce, co, cu, ci As Integer

        str1 = ""
        chara = "a"
        chare = "e"
        chari = "i"
        charo = "o"
        charu = "u"
        thischar = ""

        i = 0
        ca = 0
        ce = 0
        co = 0
        cu = 0
        ci = 0

        Console.Write("Enter string to process:  ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            thischar = Mid(str1, i, 1)
            thischar = LCase(thischar)

            If thischar = chara Then
                ca = ca + 1
            ElseIf thischar = chare Then
                ce = ce + 1
            ElseIf thischar = chari Then
                ci = ci + 1
            ElseIf thischar = charo Then
                co = co + 1
            ElseIf thischar = charu Then
                cu = cu + 1
            End If

        Next i

        Console.WriteLine(" total no. of vowels in this string are: ")
        Console.WriteLine("a = " & ca)
        Console.WriteLine("e = " & ce)
        Console.WriteLine("i = " & ci)
        Console.WriteLine("o = " & co)
        Console.WriteLine("u = " & cu)






        Console.ReadKey()



    End Sub

End Module
