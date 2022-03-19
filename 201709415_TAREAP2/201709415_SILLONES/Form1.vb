Public Class Form1



    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        mensajes()
        If indice < 8 Then
            numero(indice) = indice + 1
            tipo(indice) = ComboBox1.SelectedItem
            numero_referencia(indice) = Val(txtreferencia.Text)
            Call materiales()
            Call mano_obra()
            precio_costo(indice) = costo1(precio_mano(indice), cantidad_yarda(indice), preciomaterial(indice))
            porcentaje_venta(indice) = porcentaje()
            precio_venta(indice) = Math.Round(precio_costo(indice) + porcentaje_venta(indice), 2)

            DataGridView1.Rows.Add(numero(indice), numero_referencia(indice), tipo(indice), material(indice), precio_costo(indice), porcentaje_venta(indice), precio_venta(indice))
            indice = indice + 1
            txtreferencia.Focus()

        Else
            MsgBox("Registros llenos, limpiar vectores",, "AVISO")
        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Call limpiar_entradas()

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Call limpiar_vectores()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Call salir()

    End Sub
End Class
