Module Module1

    Sub Main()
        EjercicioUno()
        EjercicioDos()
        EjercicioTres()
        EjercicioCuatro()

        Console.ReadKey()
    End Sub

    Sub EjercicioUno()
        Console.WriteLine("...::: PRIMER EJERCICIO :::...")
        Console.Write("Ingrese el tiempo en horas: ")
        Dim horas As Double = Double.Parse(Console.ReadLine())

        Console.Write("Ingrese el tiempo en minutos: ")
        Dim minutos As Double = Double.Parse(Console.ReadLine())

        Dim distanciaKm As Double = 42195
        Dim tiempoTotalHoras As Double = horas + (minutos / 60)
        Dim velocidadKmPorHora As Double = distanciaKm / tiempoTotalHoras

        Dim distanciaMetros As Double = distanciaKm * 1000
        Dim velocidadMetrosPorMinuto As Double = distanciaMetros / (minutos + (horas * 60))
        Dim velocidadMetrosPorSegundo As Double = velocidadMetrosPorMinuto / 60

        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora & " Km/h")
        Console.WriteLine("Velocidad media en Km/min: " & (velocidadKmPorHora / 60) & " Km/min")
        Console.WriteLine("Velocidad media en Km/s: " & (velocidadKmPorHora / 3600) & " Km/s")
        Console.WriteLine("Velocidad media en m/min: " & velocidadMetrosPorMinuto & " m/min")
        Console.WriteLine("Velocidad media en m/s: " & velocidadMetrosPorSegundo & " m/s")

        Console.WriteLine()
        MisDatos()
        Console.WriteLine()
    End Sub

    Sub EjercicioDos()
        Console.WriteLine("...::: SEGUNDO EJERCICIO :::...")
        Console.Write("Ingrese el promedio mensual de infracciones: ")
        Dim promMensual As Double = Double.Parse(Console.ReadLine())

        Dim promMatutino As Double = promMensual * 0.2
        Dim promTarde As Double = promMensual * 0.35
        Dim promNoche As Double = promMensual * 0.45

        Console.WriteLine("Promedio diario matutino de infracciones: " & promMatutino)
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & promTarde)
        Console.WriteLine("Promedio diario nocturno de infracciones: " & promNoche)

        Console.WriteLine()
        MisDatos()
        Console.WriteLine()
    End Sub

    Sub EjercicioTres()
        Console.WriteLine("...::: TERCER EJERCICIO :::...")
        Dim num1, num2 As Integer

        Console.Write("Ingrese el primer numero: ")
        num1 = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el segundo numero: ")
        num2 = Integer.Parse(Console.ReadLine())

        If num1 Mod num2 = 0 Then
            Console.WriteLine("N1: " & num1 & " es divisor de N2: " & num2)
        Else
            Console.WriteLine("N1: " & num1 & " no es divisor de N2: " & num2)
        End If

        Console.WriteLine()
        MisDatos()
        Console.WriteLine()
    End Sub

    Sub EjercicioCuatro()
        Console.WriteLine("...::: CUARTO EJERCICIO :::...")
        Dim v1, v2, v3 As Integer

        Console.Write("Ingrese el primer valor: ")
        v1 = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el segundo valor: ")
        v2 = Integer.Parse(Console.ReadLine())
        Console.Write("Ingrese el tercer valor: ")
        v3 = Integer.Parse(Console.ReadLine())

        Dim mayor, medio, menor As Integer

        If v1 > v2 AndAlso v1 > v3 Then
            mayor = v1
            If v2 > v3 Then
                medio = v2
                menor = v3
            Else
                medio = v3
                menor = v2
            End If
        ElseIf v2 > v1 AndAlso v2 > v3 Then
            mayor = v2
            If v1 > v3 Then
                medio = v1
                menor = v3
            Else
                medio = v3
                menor = v1
            End If
        Else
            mayor = v3
            If v1 > v2 Then
                medio = v1
                menor = v2
            Else
                medio = v2
                menor = v1
            End If
        End If

        Console.WriteLine("El mayor valor es: " & mayor)
        Console.WriteLine("El valor medio es: " & medio)
        Console.WriteLine("El menor valor es: " & menor)

        Console.WriteLine()
        MisDatos()
        Console.WriteLine()
    End Sub

    Sub MisDatos()
        Dim fecha, miString
        Dim nombre As String

        nombre = "Mauricio Alberto Mendoza Reyes"
        fecha = "Septiembre 26, 2023"
        miString = Format(CDate(fecha), "dd MMM yyyy")

        Console.WriteLine("..:: Datos del desarrollador ::..")
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Fecha: " & miString)
    End Sub
End Module
