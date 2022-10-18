Module Mod_funciones
    'Esta función está definida para ser utilizada desde el módulo principal
    Public suma1 As Integer
    Function Adicion(par1 As Integer, par2 As Integer) As Integer
        Adicion = par1 + par2
    End Function
    'Esta función genera tablas de multiplicar de manera genérica
    'Numtabla es el número de la tabla
    'Numlineas hace referencia a cuantas lineas desea imprimir
    Sub TablaMult(NumTabla As Integer, Numlineas As Integer)
        Dim i As Integer
        For i = 1 To Numlineas
            Console.WriteLine(NumTabla & " * " & i & " = " & NumTabla * i)
        Next
    End Sub
    'Esta función le permite obtner el nombre del mes según su número
    Function NomMes(mes As Integer) As String
        Dim elnombre As String = String.Empty
        If mes < 1 Or mes > 12 Then
            Return "Error de numeración Verifique sus datos ... "
        End If
        Select Case mes
            Case 1
                elnombre = "Enero"
            Case 2
                elnombre = "Febrero"
            Case 3
                elnombre = "Marzo"
            Case 4
                elnombre = "Abril"
            Case 5
                elnombre = "Mayo"
            Case 6
                elnombre = "Junio"
            Case 7
                elnombre = "Julio"
            Case 8
                elnombre = "Agosto"
            Case 9
                elnombre = "Septiembre"
            Case 10
                elnombre = "Octubre"
            Case 11
                elnombre = "Noviembre"
            Case 12
                elnombre = "Diciembre"
        End Select
        NomMes = "El nombre del Mes es = " & elnombre
    End Function
End Module
