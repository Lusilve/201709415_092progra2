Public Class Form1
    Private Sub CALCULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULOToolStripMenuItem.Click
        If (VERIFICAR()) Then
            If INDICE < 7 Then


                If IsNumeric(TXTPLACA.Text) Then
                    PLACA(INDICE) = Val(TXTPLACA.Text)
                Else
                    MsgBox("INGRESE UN NUMERO DE PLACA CORRECTO")
                    LIMP_INDICE()
                    TXTPLACA.Focus()
                    Exit Sub
                End If

                If IsNumeric(TXTKINICIAL.Text) And IsNumeric(TXTFINAL.Text) Then
                    If Val(TXTKINICIAL.Text) < Val(TXTFINAL.Text) Then
                        KMINICIAL(INDICE) = Val(TXTKINICIAL.Text)
                        KMFINAL(INDICE) = Val(TXTFINAL.Text)
                    Else
                        MsgBox("km inicial tienen que ser menor que km final")
                        LIMP_INDICE()
                        TXTKINICIAL.Focus()
                        Exit Sub
                    End If

                Else
                    MsgBox("INGRESE DATOS CORRECTOS")
                    LIMP_INDICE()
                    TXTKINICIAL.Focus()
                    Exit Sub
                End If

                KM_RECORRIDOS()

                Select Case ComboBox1.SelectedIndex
                    Case 0 : TIPO_AUTO(INDICE) = "TIPO 1"
                        COBRO_BASE(INDICE) = TIPO1
                    Case 1 : TIPO_AUTO(INDICE) = "TIPO 2"
                        COBRO_BASE(INDICE) = TIPO2
                    Case 2 : TIPO_AUTO(INDICE) = "TIPO 3"
                        COBRO_BASE(INDICE) = TIPO3
                    Case 3 : TIPO_AUTO(INDICE) = "TIPO 4"
                        COBRO_BASE(INDICE) = TIPO4
                    Case Else
                        MsgBox("SELECCIONE UN AUTO")
                        LIMP_INDICE()
                        Exit Sub

                End Select

                PAGO_TOTAL(INDICE) = Math.Round(COBRO_BASE(INDICE) + COBRO_KM(INDICE), 2)


                INDICE = INDICE + 1
                LIMPIAR_ENTRADAS()

            End If
        Else
                    MsgBox("COLOQUE UNA PLACA DISTINTA",, "PLACA")
                TXTPLACA.Focus()

            End If
            If INDICE = 7 Then
                MsgBox("VECTORES LLENOS")
            End If

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Call SALIR()

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Call MOSTRAR()

    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        Call limpiar_vectores()

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim buscar As Boolean = True
        X = 0

        While X <= 6 And buscar
            If PLACA(X) <> Nothing Then
                If PLACA(X) = Val(TXTCONSULTA.Text) Then
                    buscar = False
                Else
                    X = X + 1
                End If
            Else
                Exit While
            End If

        End While

        If (buscar) Then
            MsgBox("Placa no encontrado")
            TXTCONSULTA.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")
            TXTPLACA.Text = PLACA(X)
            TXTKINICIAL.Text = KMINICIAL(X)
            TXTFINAL.Text = KMFINAL(X)
            ComboBox1.Text = TIPO_AUTO(X)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(PLACA(X), TIPO_AUTO(X), KMINICIAL(X), KMFINAL(X), COBRO_BASE(X), COBRO_KM(X), PAGO_TOTAL(X))
            INDICE = X
        End If

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click

        If IsNumeric(TXTPLACA.Text) Then
            PLACA(INDICE) = Val(TXTPLACA.Text)
        Else
            MsgBox("INGRESE UN NUMERO DE PLACA CORRECTO")
            LIMP_INDICE()
            TXTPLACA.Focus()
            Exit Sub
        End If

        If IsNumeric(TXTKINICIAL.Text) And IsNumeric(TXTFINAL.Text) Then
            If Val(TXTKINICIAL.Text) < Val(TXTFINAL.Text) Then
                KMINICIAL(INDICE) = Val(TXTKINICIAL.Text)
                KMFINAL(INDICE) = Val(TXTFINAL.Text)
            Else
                MsgBox("km inicial tienen que ser menor que km final")
                LIMP_INDICE()
                TXTKINICIAL.Focus()
                Exit Sub
            End If

        Else
            MsgBox("INGRESE DATOS CORRECTOS")
            LIMP_INDICE()
            TXTKINICIAL.Focus()
            Exit Sub
        End If

        KM_RECORRIDOS()

        Select Case ComboBox1.SelectedIndex
            Case 0 : TIPO_AUTO(INDICE) = "TIPO 1"
                COBRO_BASE(INDICE) = TIPO1
            Case 1 : TIPO_AUTO(INDICE) = "TIPO 2"
                COBRO_BASE(INDICE) = TIPO2
            Case 2 : TIPO_AUTO(INDICE) = "TIPO 3"
                COBRO_BASE(INDICE) = TIPO3
            Case 3 : TIPO_AUTO(INDICE) = "TIPO 4"
                COBRO_BASE(INDICE) = TIPO4
            Case Else
                MsgBox("SELECCIONE UN AUTO")
                LIMP_INDICE()
                Exit Sub

        End Select

        PAGO_TOTAL(INDICE) = Math.Round(COBRO_BASE(INDICE) + COBRO_KM(INDICE), 2)
        MsgBox("Registro actualizado correctamente en la matriz")
        INDICE = 7
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click

        PLACA(INDICE) = Nothing
        TIPO_AUTO(INDICE) = Nothing
        KMINICIAL(INDICE) = Nothing
        KMFINAL(INDICE) = Nothing
        COBRO_BASE(INDICE) = Nothing

        PAGO_TOTAL(INDICE) = Nothing
        COBRO_KM(INDICE) = Nothing

        For X = INDICE To 5
            PLACA(X) = PLACA(X + 1)
            TIPO_AUTO(X) = TIPO_AUTO(X + 1)
            KMINICIAL(X) = KMINICIAL(X + 1)
            KMFINAL(X) = KMFINAL(X + 1)
            COBRO_BASE(X) = COBRO_BASE(X + 1)

            PAGO_TOTAL(X) = PAGO_TOTAL(X + 1)
            COBRO_KM(X) = COBRO_KM(X + 1)
        Next X

        MsgBox("Registro Eliminado exitosamente")
        PLACA(X) = Nothing
        TIPO_AUTO(X) = Nothing
        KMINICIAL(X) = Nothing
        KMFINAL(X) = Nothing
        COBRO_BASE(X) = Nothing

        PAGO_TOTAL(X) = Nothing
        COBRO_KM(X) = Nothing
        INDICE = X
        LIMPIAR_ENTRADAS()
        DataGridView1.Rows.Clear()

    End Sub
End Class
