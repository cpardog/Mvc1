Module Mod_Extensiones
    'Esta función está definida para ser utilizada desde el módulo principal
    Function Resta(par1 As Integer, par2 As Integer) As Integer
        Resta = par1 - par2
    End Function
    'Función que devuelve el número del día
    ' Esto lo hace de acuerdo a su nummeración Lunes=1 ... Domingo=7
    Function NomDia(dia As Integer) As String
        Dim elnombre As String = String.Empty
        If dia < 1 Or dia > 7 Then
            Return "Error de numeración Verifique sus datos ... "
        End If

        Select Case dia
            Case 1
                elnombre = "Lunes"
            Case 2
                elnombre = "Martes"
            Case 3
                elnombre = "Miércoles"
            Case 4
                elnombre = "Jueves"
            Case 5
                elnombre = "Viernes"
            Case 6
                elnombre = "Sábado"
            Case 7
                elnombre = "Domingo"
        End Select
        NomDia = "El nombre del día es = " & elnombre
    End Function
End Module
