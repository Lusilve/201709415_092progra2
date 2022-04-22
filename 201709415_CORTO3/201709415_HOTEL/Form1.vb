Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If Indice < 7 Then
            nombre(Indice) = TXTNOMBRE.Text
            nit(Indice) = Val(TXTNIT.Text)
            dias(Indice) = Val(TXTDIAS.Text)
            tipo_habitacion(Indice) = ComboHABITACION.SelectedItem
            Select Case ComboHABITACION.SelectedIndex
                Case 0 : habita(Indice) = habitacion_sencilla * dias(Indice)
                Case 1 : habita(Indice) = habitacion_doble * dias(Indice)
                Case 2 : habita(Indice) = habitacion_cabaña * dias(Indice)
            End Select

            Select Case ComboPAGO.SelectedIndex
                Case 0 : interes(Indice) = habita(Indice) * 0.15 * -1
                Case 1 : interes(Indice) = habita(Indice) * 0.03
                Case 2 : interes(Indice) = 0
                Case 3 : interes(Indice) = 0
            End Select


            forma_pago(Indice) = ComboPAGO.SelectedItem
            pago_parcial(Indice) = habita(Indice)
            pago_total(Indice) = Math.Round(pago_parcial(Indice) + interes(Indice), 2)
            Indice = Indice + 1
        Else
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Call limpiar()
        TXTNOMBRE.Clear()
        TXTNIT.Clear()
        TXTDIAS.Clear()
        ComboHABITACION.SelectedIndex = -1
        ComboPAGO.SelectedIndex = -1
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        Dim I = 0
        While (I <= 6)
            If (nit(I) <> Nothing) Then
                DataGridView1.Rows.Add(nombre(I), nit(I), tipo_habitacion(I), dias(I), forma_pago(I), pago_parcial(I), interes(I), pago_total(I))
            Else
                Exit While
            End If
            I = I + 1
        End While


    End Sub
End Class
