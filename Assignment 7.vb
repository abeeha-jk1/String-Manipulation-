Module Module1

    Sub Main()
        Dim Str, FStr As String
        Dim Str1, Str2 As String
        Str = ""
        FStr = ""
        Str1 = ""
        Str2 = ""
        Console.Write("Entre string to be processsed : ")
        Str = Console.ReadLine
        If Len(Str) <= 2 Then
            Console.WriteLine("Too short to be processed : " & Str)
        Else
            Str1 = Left(Str, 2)
            Str2 = Right(Str, 2)
            FStr = Str1 & Str2
            Console.WriteLine("Processed String : " & FStr)

        End If
        Console.ReadKey()

    End Sub

End Module
