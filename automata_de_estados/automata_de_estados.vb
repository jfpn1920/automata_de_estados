Imports System
Module automata_de_estados
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim simbolos(9) As String
        Dim estadosIniciales(9) As String
        Dim estadosFinales(9) As String
        Dim transiciones(9) As String
        Dim entradas(9) As String
        Dim estados(9) As String
        Dim descripciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '----------------------------------------'
        '--|menu_principal_automata_de_estados|--'
        '----------------------------------------'
        Do
            Console.WriteLine("menu principal automata de estados")
            Console.WriteLine("1) Registrar estado")
            Console.WriteLine("2) Editar estado")
            Console.WriteLine("3) Listar estados")
            Console.WriteLine("4) Buscar estado")
            Console.WriteLine("5) Eliminar estado")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '----------------------'
                '--|registrar_estado|--'
                '----------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas estados.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Nombre del estado: ")
                        nombres(cantidad) = Console.ReadLine()
                        Console.Write("Simbolo: ")
                        simbolos(cantidad) = Console.ReadLine()
                        Console.Write("Es estado inicial (Si/No): ")
                        estadosIniciales(cantidad) = Console.ReadLine()
                        Console.Write("Es estado final (Si/No): ")
                        estadosFinales(cantidad) = Console.ReadLine()
                        Console.Write("Transicion: ")
                        transiciones(cantidad) = Console.ReadLine()
                        Console.Write("Entrada: ")
                        entradas(cantidad) = Console.ReadLine()
                        Console.Write("Estado (Activo/Inactivo): ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Descripcion: ")
                        descripciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Estado registrado correctamente.")
                    End If
                '-------------------'
                '--|editar_estado|--'
                '-------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estados registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Simbolo: " & simbolos(i) & " | Estado inicial: " & estadosIniciales(i) & " | Estado final: " & estadosFinales(i) & " | Transicion: " & transiciones(i) & " | Entrada: " & entradas(i) & " | Estado: " & estados(i) & " | Descripcion: " & descripciones(i))
                        Next
                        Console.Write("Ingrese el ID del estado a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre del estado: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nuevo simbolo: ")
                            simbolos(posicion) = Console.ReadLine()
                            Console.Write("Es estado inicial (Si/No): ")
                            estadosIniciales(posicion) = Console.ReadLine()
                            Console.Write("Es estado final (Si/No): ")
                            estadosFinales(posicion) = Console.ReadLine()
                            Console.Write("Nueva transicion: ")
                            transiciones(posicion) = Console.ReadLine()
                            Console.Write("Nueva entrada: ")
                            entradas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado (Activo/Inactivo): ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva descripcion: ")
                            descripciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Estado actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------'
                '--|listar_estados|--'
                '--------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estados registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Simbolo: " & simbolos(i) & " | Estado inicial: " & estadosIniciales(i) & " | Estado final: " & estadosFinales(i) & " | Transicion: " & transiciones(i) & " | Entrada: " & entradas(i) & " | Estado: " & estados(i) & " | Descripcion: " & descripciones(i))
                        Next
                    End If
                '-------------------'
                '--|buscar_estado|--'
                '-------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estados registrados.")
                    Else
                        Console.Write("Ingrese el ID del estado a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Simbolo: " & simbolos(posicion) & " | Estado inicial: " & estadosIniciales(posicion) & " | Estado final: " & estadosFinales(posicion) & " | Transicion: " & transiciones(posicion) & " | Entrada: " & entradas(posicion) & " | Estado: " & estados(posicion) & " | Descripcion: " & descripciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|eliminar_estado|--'
                '---------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estados registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Simbolo: " & simbolos(i) & " | Estado inicial: " & estadosIniciales(i) & " | Estado final: " & estadosFinales(i) & " | Transicion: " & transiciones(i) & " | Entrada: " & entradas(i) & " | Estado: " & estados(i) & " | Descripcion: " & descripciones(i))
                        Next
                        Console.Write("Ingrese el ID del estado a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                simbolos(i) = simbolos(i + 1)
                                estadosIniciales(i) = estadosIniciales(i + 1)
                                estadosFinales(i) = estadosFinales(i + 1)
                                transiciones(i) = transiciones(i + 1)
                                entradas(i) = entradas(i + 1)
                                estados(i) = estados(i + 1)
                                descripciones(i) = descripciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Estado eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen estados registrados.")
                    Else
                        Dim activos As Integer = 0
                        Dim inactivos As Integer = 0
                        Dim iniciales As Integer = 0
                        Dim finales As Integer = 0
                        Dim intermedios As Integer = 0
                        Dim totalTransiciones As Integer = 0
                        Dim simboloMasUtilizado As String = simbolos(0)
                        Dim mayorSimbolo As Integer = 0
                        Dim estadoMasTransiciones As String = nombres(0)
                        Dim mayorTransiciones As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            Select Case estados(i).ToLower()
                                Case "activo"
                                    activos += 1
                                Case "inactivo"
                                    inactivos += 1
                            End Select
                            If estadosIniciales(i).ToLower() = "si" Or estadosIniciales(i).ToLower() = "sí" Then
                                iniciales += 1
                            End If
                            If estadosFinales(i).ToLower() = "si" Or estadosFinales(i).ToLower() = "sí" Then
                                finales += 1
                            End If
                            If (estadosIniciales(i).ToLower() = "no") AndAlso (estadosFinales(i).ToLower() = "no") Then
                                intermedios += 1
                            End If
                            If transiciones(i) <> "" Then
                                totalTransiciones += 1
                            End If
                        Next
                        For i As Integer = 0 To cantidad - 1
                            Dim contadorSimbolo As Integer = 0
                            Dim contadorTransiciones As Integer = 0
                            For j As Integer = 0 To cantidad - 1
                                If simbolos(i).ToLower() = simbolos(j).ToLower() Then
                                    contadorSimbolo += 1
                                End If
                                If nombres(i).ToLower() = transiciones(j).ToLower() Then
                                    contadorTransiciones += 1
                                End If
                            Next
                            If contadorSimbolo > mayorSimbolo Then
                                mayorSimbolo = contadorSimbolo
                                simboloMasUtilizado = simbolos(i)
                            End If
                            If contadorTransiciones > mayorTransiciones Then
                                mayorTransiciones = contadorTransiciones
                                estadoMasTransiciones = nombres(i)
                            End If
                        Next
                        Console.WriteLine("Estados: " & cantidad & " | Activos: " & activos & " | Inactivos: " & inactivos & " | Iniciales: " & iniciales & " | Finales: " & finales & " | Intermedios: " & intermedios & " | Transiciones: " & totalTransiciones & " | Simbolo mas utilizado: " & simboloMasUtilizado & " | Estado con mas transiciones: " & estadoMasTransiciones)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Automata de Estados.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7

    End Sub
End Module