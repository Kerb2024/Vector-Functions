Imports System

Module Program
    Sub Main(args As String())
        Dim userinput As Char = "3"
        Dim xIn As Integer
        Dim yIn As Integer
        Dim widthIn As Integer
        Dim heightIn As Integer
        Dim radiusIn As Integer
        Dim colourIn As String
        Dim fillIn As String
        Dim strokeWidthIn As Integer
        Dim endN As Boolean = True
        Dim rxIn As Integer = 0
        Dim ryIn As Integer = 0
        Dim pointsIn As String = ""
        Dim pointsComplete As Boolean = False

        Do Until endN = False
            Console.WriteLine("press 1 to draw a square, press 2 to draw a circle, press 3 to draw a polygon")
            userinput = Console.ReadLine

            If userinput = "1" Then
                Console.WriteLine("input the x coordinate")
                xIn = Console.ReadLine
                Console.WriteLine("input the y coordinate")
                yIn = Console.ReadLine
                Console.WriteLine("input the width")
                widthIn = Console.ReadLine
                Console.WriteLine("input the height")
                heightIn = Console.ReadLine
                Console.WriteLine("input the colour")
                colourIn = Console.ReadLine 
                Console.WriteLine("input the fill")
                fillIn = Console.ReadLine
                Console.WriteLine("input the stroke width")
                strokeWidthIn = Console.ReadLine
                Console.WriteLine("Do you want to bevel the corners")
                userinput = Console.ReadLine
                If userinput = "yes" Then
                    Console.WriteLine("input the x radius of the corner")
                    rxIn = Console.ReadLine
                    Console.WriteLine("input the y radius of the corner")
                    ryIn = Console.ReadLine
                End If
                Console.WriteLine()
                Console.WriteLine(draw_rect(xIn, yIn, widthIn, heightIn, colourIn, fillIn, strokeWidthIn, rxIn, ryIn))

            ElseIf userinput = "2" Then
                Console.WriteLine("input the x coordinate of the centre of the circle")
                xIn = Console.ReadLine
                Console.WriteLine("input the y coordinate of the centre of the circle")
                yIn = Console.ReadLine
                Console.WriteLine("input the radius")
                radiusIn = Console.ReadLine
                Console.WriteLine("input the colour")
                colourIn = Console.ReadLine
                Console.WriteLine("input the fill")
                fillIn = Console.ReadLine
                Console.WriteLine("input the stroke width")
                strokeWidthIn = Console.ReadLine
                Console.WriteLine()
                Console.WriteLine(draw_circle(xIn, yIn, radiusIn, colourIn, fillIn, strokeWidthIn))

            Else
                Console.WriteLine("Input the line colour")
                colourIn = Console.ReadLine
                Console.WriteLine("Input the fill colour")
                fillIn = Console.ReadLine
                Console.WriteLine("input the stroke width")
                strokeWidthIn = Console.ReadLine
                Console.WriteLine("Begin inputting the points")
                Do Until pointsComplete = True
                    Console.WriteLine("input the point coordinates")
                    pointsIn = pointsIn & " " & Console.ReadLine
                    Console.WriteLine()
                    Console.WriteLine("The current points stored are: " & pointsIn)
                    Console.WriteLine("are these all the points you want to input?")
                    If Console.ReadLine = "y" Then
                        pointsComplete = True
                    End If
                Loop
                Console.WriteLine()
                Console.WriteLine(draw_polygon(pointsIn, colourIn, fillIn, strokeWidthIn))
            End If
            Console.WriteLine()
            Console.WriteLine("To draw another shape, input y, to end the program, input n")
            userinput = Console.ReadLine
            If userinput = "n" Then
                End
            Else
                endN = True
            End If
        Loop

        Console.ReadLine()
    End Sub
    Function draw_polygon(points As String, colour As String, fill As String, strokewidth As Integer)
        Console.WriteLine(codeStart)
        Console.WriteLine("<polyline points=""" & points & """ stroke=""" & colour & """ fill=""" & fill & """ stroke-width=""" & strokewidth & """/>""")
        Console.WriteLine(codeEnd)
    End Function
    Function draw_circle(x As Integer, y As Integer, radius As Integer, colour As String, fill As String, strokeWidth As Integer)
        Console.WriteLine(codeStart)
        Console.WriteLine("""<circle cx = """ & x & """ cy=""" & y & """ r=""" & radius & """ stroke=""" & colour & """ fill=""" & fill & """ stroke-width=""" & strokeWidth & """/>""")
        Console.WriteLine(codeEnd)
    End Function
    Function draw_rect(x As Integer, y As Integer, width As Integer, height As Integer, colour As String, fill As String, strokeWidth As Integer, rx As Integer, ry As Integer) As String
        Console.WriteLine(codeStart)
        Console.WriteLine("<rect x=""" & x & """ y=""" & y & """ rx=""" & rx & """ ry=""" & ry & """ width=""" & width & """ height=""" & height & """ stroke=""" & colour & """ fill=""" & fill & """ stroke-width=""" & strokeWidth & """/>")
        Console.WriteLine(codeEnd)
    End Function

    Function codeStart()
        Console.WriteLine("<?xml version=" & """1.0""" & " standalone=" & """no""" & "?>")
        Console.WriteLine("<svg width=" & """200""" & " height=""400""" & " version=""1.1""" & " xmlns=""http://www.w3.org/2000/svg"">")
    End Function

    Function codeEnd()
        Console.WriteLine("</svg>")
    End Function
End Module
