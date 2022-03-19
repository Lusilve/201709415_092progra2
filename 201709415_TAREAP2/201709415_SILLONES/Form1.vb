Public Class Form1

    Private Sub Buttonvectores_Click(sender As Object, e As EventArgs) Handles Buttonvectores.Click
        Call limpiar_vectores()

    End Sub

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs) Handles Buttonsalir.Click
        Call salir()

    End Sub

    Private Sub Buttoncalcular_Click(sender As Object, e As EventArgs) Handles Buttoncalcular.Click
        mensajes()
        If indice < 8 Then
            referencia(indice) = indice + 1
            tipo(indice) = ComboBox1.SelectedItem
            cantidad(indice) = Val(txtcantidadventas.Text)
            Call materiales()
            Call mano_obra()
            precio_costo(indice) = costo1(cantidad(indice), precio_mano(indice), cantidad_yarda(indice), preciomaterial(indice))
            porcentaje_venta(indice) = porcentaje()
            precio_venta(indice) = Math.Round(precio_costo(indice) + porcentaje_venta(indice), 2)

            DataGridView1.Rows.Add(referencia(indice), cantidad(indice), tipo(indice), material(indice), precio_costo(indice), porcentaje_venta(indice), precio_venta(indice))
            indice = indice + 1
            txtcantidadventas.Focus()

        Else
            MsgBox("datos llenos, limpiar vectores",, "error")
        End If

    End Sub

    Private Sub Buttonlimpiar_Click(sender As Object, e As EventArgs) Handles Buttonlimpiar.Click
        Call limpiar_entradas()

    End Sub


End Class
