﻿Option Strict On
Module Module1
    'Función que cuenta cuantos ceros hay en un array
    Function contarCeros(ByVal matriz() As Integer) As Integer
        Dim contador As Integer = 0

        'Esto es para los que no entienden el for each, yo no quería
        'For i As Integer = 0 To matriz.Length - 1 Step 1
        '    If matriz(i) = 0 Then
        '        contador += 1
        '    End If
        'Next

        For Each numero As Integer In matriz
            If numero = 0 Then
                contador += 1
            End If
        Next

        Return contador
    End Function
    Sub Main()
        Dim notasProgramacion() As Integer = {0, 0, 0, 1, 2, 3, 7, 0, 0}

        Dim numeroCeros As Integer = contarCeros(notasProgramacion)
        Console.WriteLine("Hay " & numeroCeros & " ceros en programacion")
        Console.ReadLine()
    End Sub

End Module
