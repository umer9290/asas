Module Module1

    Sub Main()
        Dim str1, alphastr As String
        Dim count As Integer
        Dim isalphabet As Boolean
        Dim nextchar As Char

        str1 = ""
        nextchar = ""
        alphastr = " abcdefghijklmnopqrstuvwxyz "
        count = 0
        isalphabet = True

        Console.Write("Enter String: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        For count = 1 To Len(alphastr)

            nextchar = Mid(alphastr, count, 1)


            If InStr(str1, nextchar) = 0 Then
                isalphabet = False
            ElseIf InStr(str1, nextchar) = 1 Then
                isalphabet = True
                Exit For
            End If


        Next
        If isalphabet = True Then
            Console.WriteLine(" They are all the alphabets. ")
        Else
            Console.WriteLine(" They all are not the alphabets. ")

        End If
        Console.ReadKey()



    End Sub

End Module
