Module Module1
    Public Const precio_jugo = 8.5
    Public Const precio_galletas = 4.25
    Public Const precio_frituras = 11.2
    Public Const precio_baterias = 15
    Public precio(6) As Double
    Public nombre_pack(6) As String
    Public producto(6) As String
    Public numero_inventario(6) As Double
    Public numero_deseado(6) As Double
    Public numero_packs(6) As Integer
    Public NUMERO_SOBRANTE(6) As Integer
    Public SOBRANTE(6) As Integer
    Public VALOR_PACK(6) As Double
    Public VALOR_SOBRANTE(6) As Double
    Public TOTAL(6) As Double
    Public descuento(6) As Double
    Public descuentototal(6) As Double
    Public INDICE As Byte = 0
    Sub NUMEROS_INVENTARIOS()
        If numero_inventario(INDICE) < numero_deseado(INDICE) Then
            MsgBox("numero de inventario debe ser mayor a deseado")
        End If
        If Form1.ComboBox1.SelectedIndex = -1 Then
            MsgBox("seleccione producto")
        End If

    End Sub

    Sub tipo_producto()
        Select Case Form1.ComboBox1.SelectedIndex
            Case 0 : producto(INDICE) = Form1.ComboBox1.SelectedItem
                precio(INDICE) = precio_jugo
            Case 1 : producto(INDICE) = Form1.ComboBox1.SelectedItem
                precio(INDICE) = precio_galletas
            Case 2 : producto(INDICE) = Form1.ComboBox1.SelectedItem
                precio(INDICE) = precio_frituras
            Case 3 : producto(INDICE) = Form1.ComboBox1.SelectedItem
                precio(INDICE) = precio_baterias
        End Select

    End Sub
    Function numero_packs_division(inv As Double, des As Double)
        Dim cantidad_packs(6) As Integer
        cantidad_packs(INDICE) = inv / des
        Return cantidad_packs(INDICE)
    End Function
    Function numero_sobrante_mod(inv As Integer, des As Integer)
        SOBRANTE(INDICE) = inv Mod des
        Return SOBRANTE(INDICE)
    End Function

    Sub descuento12()



        If 10 <= numero_packs(INDICE) Then
            descuento(INDICE) = 0.1

        ElseIf 5 <= numero_packs(INDICE) And numero_packs(INDICE) <= 9 Then
            descuento(INDICE) = 0.05





        ElseIf 0 <= numero_packs(INDICE) And numero_packs(INDICE) <= 3 Then
            descuento(INDICE) = 0.03
        End If
    End Sub


    Sub SALIR()
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Form1.Close()
            End

        End If
    End Sub



End Module
