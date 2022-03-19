Module Funciones
    Public referencia(8) As Byte
    Public cantidad(8) As Double
    Public tipo(8) As String
    Public material(8) As String
    Public preciomaterial(8) As Double
    Public precio_costo(8) As Double
    Public precio_mano(8) As Double
    Public cantidad_yarda(8) As Double
    Public porcentaje_venta(8) As Double
    Public precio_venta(8) As Double
    Public indice As Byte = 0

    Public Const precio_sofa = 250.99
    Public Const precio_individual = 150.99
    Public Const preciod_doble = 200.99
    Public Const precio_cuero = 75
    Public Const precio_cuerina = 45.99
    Public Const yarda_sofa = 8
    Public Const yarda_individual = 3.5
    Public Const yarda_doble = 6

    Sub mensajes()
        If IsNumeric(Form1.txtcantidadventas.Text) = False Then

            MsgBox("ingrese datos validos",, "Numero de unidades a vender")

        End If

        If (Form1.ComboBox1.SelectedIndex = -1) Or (Form1.rbcuero.Checked = 0 And Form1.rbcuerina.Checked = 0) Then
            MsgBox("Seleccione tipo y material",, "ERROR")

        End If

    End Sub

    Sub materiales()
        If Form1.rbcuerina.Checked Or Form1.rbcuero.Checked Then

            If Form1.rbcuero.Checked = True Then
                material(indice) = Form1.rbcuero.Text
                preciomaterial(indice) = precio_cuero
            Else Form1.rbcuerina.Checked = True
                material(indice) = Form1.rbcuerina.Text
                preciomaterial(indice) = precio_cuerina
            End If

        End If

    End Sub

    Sub mano_obra()
        Select Case tipo(indice)
            Case "SOFA"
                precio_mano(indice) = precio_sofa
                cantidad_yarda(indice) = yarda_sofa
            Case "INDIVIDUAL"
                precio_mano(indice) = precio_individual
                cantidad_yarda(indice) = yarda_individual
            Case "DOBLE"
                precio_mano(indice) = preciod_doble
                cantidad_yarda(indice) = yarda_sofa

        End Select
    End Sub

    Function costo1(numero_ventas As Double, pmano As Double, cyarda As Double, tmaterial As Double)
        Dim pcosto(8) As Double

        pcosto(indice) = numero_ventas * (pmano + (cyarda * tmaterial))
        Return Math.Round(pcosto(indice), 2)

    End Function

    Function porcentaje()
        porcentaje = 0.65 * (precio_costo(indice))
        Return Math.Round(porcentaje, 2)
    End Function

    Sub limpiar_entradas()
        Form1.txtcantidadventas.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.rbcuerina.Checked = False
        Form1.rbcuero.Checked = False
        Form1.DataGridView1.Rows.Clear()
        Form1.txtcantidadventas.Focus()


    End Sub

    Sub limpiar_vectores()
        indice = 0
        ReDim referencia(8)
        ReDim cantidad(8)
        ReDim tipo(8)
        ReDim material(8)
        ReDim preciomaterial(8)
        ReDim precio_costo(8)
        ReDim precio_mano(8)
        ReDim cantidad_yarda(8)
        ReDim porcentaje_venta(8)
        ReDim precio_venta(8)
        Call limpiar_entradas()

    End Sub
    Sub salir()
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Form1.Close()
            End
        End If
    End Sub


End Module
