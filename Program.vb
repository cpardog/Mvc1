Imports System

Module Program
    Dim total As Integer
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        ' La adici�n es una funci�n definida en el Mod_funciones
        total = Adicion(8, 6)
        Console.WriteLine("La suma con la funci�n nueva es {0} ", total)
        ' La resta es una funci�n definida en el Mod_extensiones
        total = Resta(8, 6)
        Console.WriteLine("La resta con la funci�n nueva es {0} ", total)
        TablaMult(20, 5)
        Console.WriteLine(NomDia(0))
        Console.WriteLine(NomMes(11))
        Console.WriteLine("Este es el ultimo cambio")
        Console.ReadKey()
    End Sub

End Module
