'Seth Rasmussen
'RCET 0265
'Spring 2022
'Roll of the Dice



'Write a program that rolls two six-sided dice 1,000 times and accumulates the count of each number rolled efficiently in an array.
'Display the results In the console In formatted columns With headers

'Header row--> the roll result numbers 2 To 12
'Data row --> the total count Of how many times Each number came up

Option Strict On
Option Explicit On

Module rollTheDice

    Sub Main()
        Dim randomNumbers(12) As Integer
        Dim temp As String
        Dim seperator As String = " |"
        Dim padLength As Integer = 5
        Dim lineSeperator As String = "-"
        Dim lineLength As Integer = padLength * (UBound(randomNumbers) + 1)

        'count random numbers
        For i = 1 To 1000
            randomNumbers(GetRandomInteger()) += 1
        Next

        'display random number count(s)
        'headers
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(i) & seperator
            temp = temp.PadLeft(padLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        'display contents of randomNumbers() array
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(randomNumbers(i)) & seperator
            temp = temp.PadLeft(padLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        Console.Read()
    End Sub

    Function GetRandomInteger() As Integer
        Dim value As Integer
        Dim temp As Single
        ' Initialize the random-number generator.
        Randomize()
        temp = (Rnd() * 11) + 2
        value = CInt(System.Math.Floor(CDbl(temp)))

        'Console.WriteLine(temp)
        'Console.WriteLine(value)
        ' Generate random value between 1 and 6.
        ' Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value
    End Function

End Module