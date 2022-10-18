Imports System

Module Program
    Dim total As Integer
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        ' La adición es una función definida en el Mod_funciones
        total = Adicion(8, 6)
        Console.WriteLine("La suma con la función nueva es {0} ", total)
        ' La resta es una función definida en el Mod_extensiones
        total = Resta(8, 6)
        Console.WriteLine("La resta con la función nueva es {0} ", total)
        TablaMult(20, 5)
        Console.WriteLine(NomDia(0))
        Console.WriteLine(NomMes(11))
        Console.WriteLine("Este es el ultimo cambio")
        Console.ReadKey()
    End Sub

End Module
