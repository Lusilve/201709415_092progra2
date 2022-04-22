Module Module1
    Public Const TIPO1 = 500
    Public Const TIPO2 = 400
    Public Const TIPO3 = 300
    Public Const TIPO4 = 200

    Public PLACA(7)
    Public TIPO_AUTO(7)
    Public KMINICIAL(7)
    Public KMFINAL(7)
    Public COBRO_BASE(7)
    Public PAGO_TOTAL(7)
    Public COBRO_KM(7)
    Public INDICE As Byte = 0
    Public X As Byte = 0

    Function KM_RECORRIDOS() As Double
        Dim DIFERENCIA_KM(INDICE) As Double
        DIFERENCIA_KM(INDICE) = KMFINAL(INDICE) - KMINICIAL(INDICE)

        If DIFERENCIA_KM(INDICE) > 70 Then
            COBRO_KM(INDICE) = DIFERENCIA_KM(INDICE) * 5


        ElseIf DIFERENCIA_KM(INDICE) >= 51 And DIFERENCIA_KM(INDICE) <= 70 Then
            COBRO_KM(INDICE) = DIFERENCIA_KM(INDICE) * 4


        ElseIf DIFERENCIA_KM(INDICE) >= 0 And DIFERENCIA_KM(INDICE) <= 50 Then
            COBRO_KM(INDICE) = DIFERENCIA_KM(INDICE) * 3
        Else

        End If

        Return KM_RECORRIDOS


    End Function


    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Clear()
        For X = 0 To 6
            If PLACA(X) <> Nothing Then
                Form1.DataGridView1.Rows.Add(PLACA(X), TIPO_AUTO(X), KMINICIAL(X), KMFINAL(X), COBRO_BASE(X), COBRO_KM(X), PAGO_TOTAL(X))
            Else
                Exit For
            End If
        Next X
    End Sub

    Function VERIFICAR() As Boolean
        Dim placa_igual As Boolean = True
        X = 0

        VERIFICAR = True

        While X <= 6 And (placa_igual)
            If (PLACA(X) <> Nothing) Then
                If PLACA(X) = Form1.TXTPLACA.Text Then
                    Return VERIFICAR = placa_igual = False
                Else
                    X = X + 1
                End If

            Else
                Exit While
            End If

        End While
        If (placa_igual) Then
            Return VERIFICAR

        End If


    End Function

    Sub LIMP_INDICE()

        PLACA(INDICE) = Nothing
        TIPO_AUTO(INDICE) = Nothing
        KMINICIAL(INDICE) = Nothing
        KMFINAL(INDICE) = Nothing
        COBRO_BASE(INDICE) = Nothing
        PAGO_TOTAL(INDICE) = Nothing
        COBRO_KM(INDICE) = Nothing



    End Sub
    Sub SALIR()
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Form1.Close()
            End

        End If
    End Sub


    Sub LIMPIAR_ENTRADAS()
        Form1.TXTPLACA.Clear()
        Form1.TXTKINICIAL.Clear()
        Form1.TXTFINAL.Clear()
        Form1.TXTCONSULTA.Clear()
        Form1.ComboBox1.SelectedIndex = -1

    End Sub

    Sub limpiar_vectores()
        Dim j As Byte = 0
        INDICE = 0

        For j = 0 To 6
            PLACA(j) = Nothing
            TIPO_AUTO(j) = Nothing
            KMINICIAL(j) = Nothing
            KMFINAL(j) = Nothing
            COBRO_BASE(j) = Nothing
            PAGO_TOTAL(j) = Nothing
            COBRO_KM(j) = Nothing
        Next j
        LIMPIAR_ENTRADAS()
        Form1.DataGridView1.Rows.Clear()


    End Sub
End Module
