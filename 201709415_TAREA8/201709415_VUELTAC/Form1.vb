Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Call SALIR()

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Call LIMPIAR_ENTRADAS()

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Call LIMPIAR_VECTORES1()
        Call LIMPIAR_ESTADISTICAS()

        DataGridView1.Rows.Clear()

    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If (INDICE <= 11) Then

            If (Not (comprobar_repetido())) Then
                MsgBox("numero de etapa repetido")
                txtetapa.Focus()

            Else
                If IsNumeric(txtetapa.Text) Then
                    ETAPA(INDICE) = Val(txtetapa.Text)
                Else
                    MsgBox("INGRESE DATOS CORRECTOS")
                    LIMP_INDICE()
                    txtetapa.Focus()

                End If

                Select Case ComboBox1.SelectedIndex
                    Case 0 : EQUIPO(INDICE) = "SKY"
                    Case 1 : EQUIPO(INDICE) = "MOVISTAR"
                    Case 2 : EQUIPO(INDICE) = "PRO"
                    Case 3 : EQUIPO(INDICE) = "CYCLING"
                    Case 4 : EQUIPO(INDICE) = "PRO TEAM"
                    Case Else
                        MsgBox("SELECCIONE EQUIPO")
                        LIMP_INDICE()

                End Select

                If rbextranjero.Checked Or rbguatemalteco.Checked Then
                    If rbguatemalteco.Checked = True Then
                        NACIONALIDAD(INDICE) = rbguatemalteco.Text
                    End If
                    If rbextranjero.Checked = True Then

                        NACIONALIDAD(INDICE) = rbextranjero.Text
                    End If

                Else
                    MsgBox("SELECCIONE NACIONALIDAD")
                    LIMP_INDICE()

                End If

                If IsNumeric(txtkm.Text) Then
                    KMRECORRIDOS(INDICE) = Val(txtkm.Text)

                Else
                    MsgBox("INTRODUZCA DATOS CORRECOTS")
                    LIMP_INDICE()
                    txtkm.Focus()

                End If

                If IsNumeric(txtiempo.Text) Then
                    TIEMPO(INDICE) = Val(txtiempo.Text)

                Else
                    MsgBox("INTRODUZCA DATOS CORRECOTS")
                    LIMP_INDICE()
                    txtiempo.Focus()

                End If

                PENALIZADOR()
                TIEMPO_TOTAL(INDICE) = Math.Round(TIEMPO(INDICE) + PENALIZACION(INDICE), 2)


                INDICE = INDICE + 1

                LIMPIAR_ENTRADAS()






            End If

        End If
        If INDICE = 12 Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Call MOSTRAR()

    End Sub

    Private Sub btconsulta_Click(sender As Object, e As EventArgs) Handles btconsulta.Click
        g = 0

        For g = 0 To 11
            If ETAPA(g) <> Nothing Then
                If Val(ETAPA(g)) = Val(txtconsulta.Text) Then
                    MsgBox("corredor encontrado")
                    Exit For
                End If

            Else
                Exit For
            End If
        Next g


        If g = 12 Then
            MsgBox("corredor no encontrado")
            txtconsulta.Focus()
        Else
            txtetapa.Text = ETAPA(g)
            txtiempo.Text = TIEMPO(g)
            txtkm.Text = KMRECORRIDOS(g)
            ComboBox1.Text = EQUIPO(g)

            If NACIONALIDAD(g) = "Guatemalteco" Then
                rbguatemalteco.Checked = True

            Else
                rbextranjero.Checked = True
            End If

            DataGridView1.Rows.Clear()
            LIMPIAR_ESTADISTICAS()
            DataGridView1.Rows.Add(ETAPA(g), EQUIPO(g), NACIONALIDAD(g), KMRECORRIDOS(g), TIEMPO(g), PENALIZACION(g), TIEMPO_TOTAL(g))
            INDICE = g

        End If

    End Sub

    Private Sub btactualizar_Click(sender As Object, e As EventArgs) Handles btactualizar.Click

        If IsNumeric(txtetapa.Text) Then
            ETAPA(INDICE) = Val(txtetapa.Text)
        Else
            MsgBox("INGRESE DATOS CORRECTOS")
            LIMP_INDICE()
            txtetapa.Focus()

        End If

        Select Case ComboBox1.SelectedIndex
            Case 0 : EQUIPO(INDICE) = "SKY"
            Case 1 : EQUIPO(INDICE) = "MOVISTAR"
            Case 2 : EQUIPO(INDICE) = "PRO"
            Case 3 : EQUIPO(INDICE) = "CYCLING"
            Case 4 : EQUIPO(INDICE) = "PRO TEAM"
            Case Else
                MsgBox("SELECCIONE EQUIPO")
                LIMP_INDICE()

        End Select

        If rbextranjero.Checked Or rbguatemalteco.Checked Then
            If rbguatemalteco.Checked = True Then
                NACIONALIDAD(INDICE) = rbguatemalteco.Text
            End If
            If rbextranjero.Checked = True Then

                NACIONALIDAD(INDICE) = rbextranjero.Text
            End If

        Else
            MsgBox("SELECCIONE NACIONALIDAD")
            LIMP_INDICE()

        End If

        If IsNumeric(txtkm.Text) Then
            KMRECORRIDOS(INDICE) = Val(txtkm.Text)

        Else
            MsgBox("INTRODUZCA DATOS CORRECOTS")
            LIMP_INDICE()
            txtkm.Focus()

        End If

        If IsNumeric(txtiempo.Text) Then
            TIEMPO(INDICE) = Val(txtiempo.Text)

        Else
            MsgBox("INTRODUZCA DATOS CORRECOTS")
            LIMP_INDICE()
            txtiempo.Focus()

        End If

        PENALIZADOR()
        TIEMPO_TOTAL(INDICE) = Math.Round(TIEMPO(INDICE) + PENALIZACION(INDICE), 2)

        MsgBox("REGISTRO ACTUALIZADO")
        DataGridView1.Rows.Clear()

        INDICE = 12

    End Sub

    Private Sub ORDENARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARToolStripMenuItem.Click
        Dim I As Byte
        Dim j As Byte
        Dim temp1 As Double
        Dim temp2 As String
        Dim temp3 As String
        Dim temp4 As Double
        Dim temp5 As Double
        Dim temp6 As Double
        Dim temp7 As Double

        For I = 0 To 10
            For j = I + 1 To 11
                If ETAPA(j) <> Nothing Then
                    If ETAPA(I) > ETAPA(j) Then
                        temp1 = ETAPA(I)
                        ETAPA(I) = ETAPA(j)
                        ETAPA(j) = temp1

                        temp2 = EQUIPO(I)
                        EQUIPO(I) = EQUIPO(j)
                        EQUIPO(j) = temp2

                        temp3 = NACIONALIDAD(I)
                        NACIONALIDAD(I) = NACIONALIDAD(j)
                        NACIONALIDAD(j) = temp3

                        temp4 = KMRECORRIDOS(I)
                        KMRECORRIDOS(I) = KMRECORRIDOS(j)
                        KMRECORRIDOS(j) = temp4

                        temp5 = TIEMPO(I)
                        TIEMPO(I) = TIEMPO(j)
                        TIEMPO(j) = temp5

                        temp6 = PENALIZACION(I)
                        PENALIZACION(I) = PENALIZACION(j)
                        PENALIZACION(j) = temp6

                        temp7 = TIEMPO_TOTAL(I)
                        TIEMPO_TOTAL(I) = TIEMPO_TOTAL(j)
                        TIEMPO_TOTAL(j) = temp7



                    End If
                End If
            Next j
        Next I
        DataGridView1.Rows.Clear()

        Call MOSTRAR()


    End Sub
End Class
