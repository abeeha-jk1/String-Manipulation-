Module Module1

    Sub Main()
        Dim stra, strb, f2a, f2b, remaininga, remainingb As String

        stra = ""
        strb = ""
        f2a = ""
        f2b = ""
        remaininga = ""
        remainingb = ""

        Console.Write("enter first string: ")
        stra = Console.ReadLine

        Console.Write("enter second string: ")
        strb = Console.ReadLine

        If Len(stra) < 2 Then
            Console.WriteLine("string is too short to be processed")
        Else
            f2a = Left(stra, 2)
            f2b = Left(strb, 2)
            remaininga = Right(stra, Len(stra) - 2)
            remainingb = Right(strb, Len(strb) - 2)
        End If

        Console.WriteLine(" final string is: " & f2b & remaininga & " " & f2a & remainingb)



        Console.ReadKey()

    End Sub

End Module
