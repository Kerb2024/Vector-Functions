Imports System

Module Program
    Sub Main(args As String())
        Dim userinput As Integer = 1
        Dim xIn As Integer = 10
        Dim yIn As Integer = 10
        Dim widthIn As Integer = 30
        Dim heightIn As Integer = 30
        Dim colourIn As String = "black"
        'Console.WriteLine("press 1 to draw a square, press 2 to draw a circle")
        'userinput = Console.ReadLine

        If userinput = 1 Then
            'Console.WriteLine("input the x coordinate")
            'xIn = Console.ReadLine
            'Console.WriteLine("input the y coordinate")
            'yIn = Console.ReadLine
            'Console.WriteLine("input the width")
            'widthIn = Console.ReadLine
            'Console.WriteLine("input the height")
            'heightIn = Console.ReadLine
            'Console.WriteLine("input the colour")
            'colourIn = Console.ReadLine
            Console.WriteLine(draw_rect(xIn, yIn, widthIn, heightIn, colourIn))
        End If
        Console.ReadLine()
    End Sub

    Function draw_rect(x As Integer, y As Integer, width As Integer, height As Integer, colour As String) As String
        Console.WriteLine("<rect x=""" & x & """ y=""" & y & """ width=""" & width & """ height=""" & height & """ stroke=""" & colour & """ fill=""transparent"" stroke-width=""5""/>")

    End Function

    Function codeStart()
        Console.WriteLine("<?xml version=" & """1.0""" & " standalone=" & """no""" & "?>")
        Console.WriteLine("<svg width=" & """200""" & " height=""400""" & "version=""1.1""" & " xmlns=""http://www.w3.org/2000/svg"">")
        Console.WriteLine()
    End Function

    Function codeEnd()
        Console.WriteLine("</svg>")
    End Function
End Module
