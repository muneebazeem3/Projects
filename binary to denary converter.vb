Module Module1

    Sub Main()
        Dim newnum, counter, finalans As Integer
        Dim validbinarystring As Boolean
        Dim str1, str2, newchar As String

        str1 = ""
        str2 = ""
        newchar = ""
        counter = 0
        newnum = 0
        finalans = 0
        validbinarystring = True

        Console.Write("enter binary string: ")
        str1 = Console.ReadLine

        If Len(str1) <= 8 And Len(str1) > 0 Then
            For counter = 1 To Len(str1)
                newchar = Mid(str1, counter, 1)
                If newchar <> "1" And newchar <> "0" Then
                    validbinarystring = False

                End If

            Next
        Else
            validbinarystring = True

        End If

        If validbinarystring = False Then
            Console.WriteLine("entered string is not a binary number")
        Else
            Console.WriteLine("entered string is a binary string")
            validbinarystring = True

        End If
        If validbinarystring = True Then
            For counter = 1 To Len(str1)
                str2 = Mid(str1, counter, 1) & str2
            Next

            For counter = 1 To Len(str2)
                newchar = Mid(str2, counter, 1)
                newnum = 0
                If newchar = "1" Then
                    newnum = 1
                End If
                If counter = 1 Then
                    finalans = finalans + newnum
                    If counter = 2 Then
                        finalans = finalans + newnum * 2
                        If counter = 3 Then
                            finalans = finalans + newnum * 4
                            If counter = 4 Then
                                finalans = finalans + newnum * 8
                                If counter = 5 Then
                                    finalans = finalans + newnum * 1
                                    If counter = 6 Then
                                        finalans = finalans + newnum * 32
                                        If counter = 7 Then
                                            finalans = finalans + newnum * 6
                                            If counter = 8 Then
                                                finalans = finalans + newnum * 128
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            Console.WriteLine(str1 & " = " & finalans)
        End If

        Console.ReadKey()

    End Sub

End Module
