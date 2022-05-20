Public Class Form1
    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If indice < 7 Then

            HOTEL(indice, 0) = Val(TXTNIT.Text)
            HOTEL(indice, 1) = (TXTNOMBRE.Text)
            HOTEL(indice, 2) = Val(TXTPERSONAS.Text)

            Select Case COMBOHABITACION.SelectedIndex
                Case 0 : HOTEL(indice, 3) = "ESTANDAR"
                    HOTEL(indice, 4) = estandar
                Case 1 : HOTEL(indice, 3) = "A/C"
                    HOTEL(indice, 4) = ac
                Case 2 : HOTEL(indice, 3) = "JACUZZI"
                    HOTEL(indice, 4) = jacuzzi
            End Select

            COBRO()

            HOTEL(indice, 6) = Math.Round(HOTEL(indice, 4) + HOTEL(indice, 5), 2)


            indice = indice + 1
        Else indice = 7
            MsgBox("matriz llena")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Call MOSTRAR()

    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        Dim buscar As Boolean = True
        x = 0
        While x <= 7 And buscar
            If HOTEL(x, 0) <> Nothing Then
                If HOTEL(x, 0) = Val(TXTBUSCAR.Text) Then
                    buscar = False
                Else
                    x = x + 1
                End If
            Else
                Exit While
            End If
        End While

        If buscar Then
            MsgBox("NIT NO EXISTE")
            TXTBUSCAR.Focus()
        Else
            MsgBox("EL NUMERO DE NIT SE ENCONTRO")
            TXTNIT.Text = HOTEL(x, 0)
            TXTNOMBRE.Text = HOTEL(x, 1)
            TXTPERSONAS.Text = HOTEL(x, 2)
            COMBOHABITACION.Text = HOTEL(x, 3)




            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(HOTEL(x, 0), HOTEL(x, 1), HOTEL(x, 2), HOTEL(x, 3), HOTEL(x, 4), HOTEL(x, 5), HOTEL(x, 6))

            indice = x
        End If
    End Sub


    Private Sub ORDENARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As String
        For i = 0 To 5
            For j = i + 1 To 6

                If (HOTEL(j, 0) <> Nothing) Then
                    If (Val(HOTEL(i, 0)) < Val(HOTEL(j, 0))) Then
                        temp1 = HOTEL(i, 0)
                        HOTEL(i, 0) = HOTEL(j, 0)
                        HOTEL(j, 0) = temp1
                        temp1 = HOTEL(i, 1)
                        HOTEL(i, 1) = HOTEL(j, 1)
                        HOTEL(j, 1) = temp1
                        temp1 = HOTEL(i, 2)
                        HOTEL(i, 2) = HOTEL(j, 2)
                        HOTEL(j, 2) = temp1
                        temp1 = HOTEL(i, 3)
                        HOTEL(i, 3) = HOTEL(j, 3)
                        HOTEL(j, 3) = temp1
                        temp1 = HOTEL(i, 4)
                        HOTEL(i, 4) = HOTEL(j, 4)
                        HOTEL(j, 4) = temp1
                        HOTEL(i, 5) = HOTEL(j, 5)
                        HOTEL(j, 5) = temp1
                        HOTEL(i, 6) = HOTEL(j, 6)
                        HOTEL(j, 6) = temp1

                    End If
                Else
                    Exit For
                End If
            Next j
        Next i
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        Call limpiar()
        TXTNIT.Clear()
        TXTNOMBRE.Clear()
        TXTPERSONAS.Clear()
        COMBOHABITACION.SelectedIndex = -1
        TXTBUSCAR.Clear()


    End Sub
End Class
