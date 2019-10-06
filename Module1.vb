Module Module1

    Sub Main()
        Dim str1, str2, char1, nextchar As String
        Dim counter As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        nextchar = ""

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        char1 = Console.ReadLine

        For counter 1 to Len(str1)
            nextchar = Mid(str1, counter, 1)
            If nextchar <> char1 Then
                str2 = str2 & nextchar
            End If
        Next

        Console.WriteLine("final string: " & str2)
        Console.ReadKey()

    End Sub

End Module
