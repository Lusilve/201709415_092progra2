Module Module1
    Public ETAPA(12) As Double
    Public EQUIPO(12) As String
    Public NACIONALIDAD(12) As String
    Public KMRECORRIDOS(12) As Double
    Public TIEMPO(12) As Double
    Public PENALIZACION(12) As Double
    Public TIEMPO_TOTAL(12) As Double
    Public INDICE As Byte = 0
    Public X As Byte
    Public g As Byte

    'variables para las estadisticas
    Public NACIONALES_45 As Double
    Public km_SKY As Double
    Public km_MOVISTAR As Double
    Public km_PRO As Double
    Public km1_CICLYNG As Double
    Public km_PROTEAM As Double
    Public TIEMPO_NACIONALES As Double
    Public TIEMPO_EXTRANJEROS As Double
    Public hora_nacional As Integer
    Public hora_extranjero As Integer
    Public minutos_naciona As Integer
    Public minutos_extranjeros As Integer


    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True
        Dim v As Byte

        v = 0
        comprobar_repetido = True
        While (v <= 11) And (encontrado)

            If (ETAPA(v) <> Nothing) Then

                If (ETAPA(v) = Val(Form1.txtetapa.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    v = v + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function


    Sub ESTADISTICAS()


        For X = 0 To 11
            If NACIONALIDAD(X) = Form1.rbguatemalteco.Text And KMRECORRIDOS(X) >= 45 Then
                NACIONALES_45 = NACIONALES_45 + 1
            End If

            If EQUIPO(X) = "SKY" Then
                km_SKY = KMRECORRIDOS(X) + km_SKY

            End If

            If EQUIPO(X) = "MOVISTAR" Then
                km_MOVISTAR = KMRECORRIDOS(X) + km_MOVISTAR

            End If

            If EQUIPO(X) = "PRO" Then
                km_PRO = KMRECORRIDOS(X) + km_PRO

            End If

            If EQUIPO(X) = "CYCLING" Then
                km1_CICLYNG = KMRECORRIDOS(X) + km1_CICLYNG

            End If
            If EQUIPO(X) = "PRO TEAM" Then
                km_PROTEAM = KMRECORRIDOS(X) + km_PROTEAM

            End If
            If NACIONALIDAD(X) = Form1.rbguatemalteco.Text Then
                TIEMPO_NACIONALES = TIEMPO_TOTAL(X) + TIEMPO_NACIONALES

            End If

            If NACIONALIDAD(X) = Form1.rbextranjero.Text Then
                TIEMPO_EXTRANJEROS = TIEMPO_TOTAL(X) + TIEMPO_EXTRANJEROS

            End If





        Next X


        hora_nacional = TIEMPO_NACIONALES / 60
        hora_extranjero = TIEMPO_EXTRANJEROS / 60
        minutos_naciona = TIEMPO_NACIONALES Mod 60
        minutos_extranjeros = TIEMPO_EXTRANJEROS Mod 60


    End Sub
    Sub PENALIZADOR()
        If TIEMPO(INDICE) > 160 Then
            PENALIZACION(INDICE) = 50
        ElseIf TIEMPO(INDICE) > 140 And TIEMPO(INDICE) <= 160 Then
            PENALIZACION(INDICE) = 40
        ElseIf TIEMPO(INDICE) > 120 And TIEMPO(INDICE) <= 140 Then

            PENALIZACION(INDICE) = 30
        ElseIf TIEMPO(INDICE) < 85 And EQUIPO(INDICE) = "MOVISTAR" Then
            PENALIZACION(INDICE) = -15
        ElseIf TIEMPO(INDICE) < 85 And EQUIPO(INDICE) = "PRO TEAM" Then
            PENALIZACION(INDICE) = -10
        Else

        End If



    End Sub
    Sub SALIR()
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Form1.Close()
            End

        End If
    End Sub


    Sub LIMPIAR_ENTRADAS()
        Form1.txtetapa.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.txtkm.Clear()
        Form1.txtiempo.Clear()
        Form1.rbextranjero.Checked = False
        Form1.rbguatemalteco.Checked = False


    End Sub
    Sub LIMPIAR_ESTADISTICAS()
        Form1.txt45km.Clear()
        Form1.txtconsulta.Clear()
        Form1.txtkmovistar.Clear()
        Form1.txtsky.Clear()
        Form1.txtkpro.Clear()
        Form1.txtkmpc.Clear()
        Form1.txtkpt.Clear()
        Form1.txtminna.Clear()
        Form1.txtminextra.Clear()
        Form1.txtetapa.Focus()
    End Sub
    Sub LIMPIAR_VECTORES1()
        Dim J As Byte = 0
        INDICE = 0

        For J = 0 To 11
            ETAPA(J) = Nothing
            EQUIPO(J) = Nothing
            NACIONALIDAD(J) = Nothing
            KMRECORRIDOS(J) = Nothing
            TIEMPO(J) = Nothing
            PENALIZACION(J) = Nothing
            TIEMPO_TOTAL(J) = Nothing
        Next J

        LIMPIAR_ENTRADAS()
        LIMPIAR_ESTADISTICAS()
        Form1.DataGridView1.Rows.Clear()


    End Sub
    Sub MOSTRAR()
        X = 0
        While X <= 12


            If ETAPA(X) <> Nothing Then
                Form1.DataGridView1.Rows.Add(ETAPA(X), EQUIPO(X), NACIONALIDAD(X), KMRECORRIDOS(X), TIEMPO(X), PENALIZACION(X), TIEMPO_TOTAL(X))
            Else
                Exit While
            End If
            X = X + 1
        End While

        Call ESTADISTICAS()

        Form1.txt45km.Text = NACIONALES_45
        Form1.txtsky.Text = km_SKY
        Form1.txtkmovistar.Text = km_MOVISTAR
        Form1.txtkpro.Text = km_PRO
        Form1.txtkmpc.Text = km1_CICLYNG
        Form1.txtkpt.Text = km_PROTEAM
        Form1.txtminna.Text = Str(hora_nacional) & "HORAS" & Str(minutos_naciona) & "MINUTOS"
        Form1.txtminextra.Text = Str(hora_extranjero) & "HORAS" & Str(minutos_extranjeros) & "MINUTOS"


    End Sub

    Sub LIMP_INDICE()
        ETAPA(INDICE) = Nothing
        EQUIPO(INDICE) = Nothing
        NACIONALIDAD(INDICE) = Nothing
        KMRECORRIDOS(INDICE) = Nothing
        TIEMPO(INDICE) = Nothing
        PENALIZACION(INDICE) = Nothing
        TIEMPO_TOTAL(INDICE) = Nothing
    End Sub
End Module
