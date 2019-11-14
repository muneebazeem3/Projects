Module Module1

    Sub Main()
        Dim currentchar, lastcharcount, count As Integer
        Dim str1, nextchar, repeatedchar, str2 As String

        currentchar = 0
        lastcharcount = 1
        count = 0
        str1 = ""
        nextchar = ""
        repeatedchar = ""
        str2 = ""
        Console.Write("enter a string: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

            For count = 1 To Len(str1)
                str2 = str1
                nextchar = Mid(str1, count, 1)
                Do Until InStr(str2, nextchar) = 0
                    currentchar = currentchar + 1
                    str2 = Left(str2, InStr(str2, nextchar) - 1) & Right(str2, Len(str2) - InStr(str2, nextchar))
                Loop
                If currentchar > lastcharcount Then
                repeatedchar = nextchar
                End If
                lastcharcount = currentchar
                currentchar = 0
            Next

        If repeatedchar = "" Then
            Console.WriteLine("No string has been repeated ")
        End If
        If repeatedchar <> "" Then
            Console.WriteLine("Most repeated char is: " & repeatedchar)
        Else
        End If

        Console.WriteLine("Entered string is not valid ")
        End If

        Console.ReadKey()
    End Sub

End Module
