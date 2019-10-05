Module Module1

    Sub Main()
        Dim str1, str2, char1, char2, nextchar As String
        Dim counter As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        nextchar = ""
        counter = 0

        Console.Write("enter string: ")
        str1 = Console.ReadLine

        Console.Write("enter character to remove: ")
        char1 = Console.ReadLine

        Console.Write("enter character to replace: ")
        char2 = Console.ReadLine

        For counter = 1 To Len(str1)
            nextchar = Mid(str1, counter, 1)
            If nextchar = char1 Then
                nextchar = char2
            End If
            str2 = str2 & nextchar
        Next

        Console.WriteLine("final string = " & str2)
        Console.ReadKey()

    End Sub

End Module
