Public Class Form1


    Private Sub BTSALIR_Click(sender As Object, e As EventArgs) Handles BTSALIR.Click
        Call SALIR()
    End Sub

    Private Sub BTACEPTAR_Click(sender As Object, e As EventArgs) Handles BTACEPTAR.Click
        If indice < 10 Then





            nombre(indice) = txtnombre.Text
            valor_paquete(indice) = Val(txtvalor.Text)
            peso(indice) = Val(InputBox("ingrese el peso del paquete"))
            tipo_paquete(indice) = ComboBox1.Text
            paquete(indice) = ComboBox1.SelectedIndex
            envio(indice) = ComboBox2.Text
            Call tipo_envio_paquete()
            precio_parcial(indice) = Math.Round(pago_parcial1(), 2)
            Call impuesto()
            preciototal(indice) = Math.Round(precio_parcial(indice) + porcentaje(indice), 2)

            indice = indice + 1

        Else
            MsgBox("vectores llenos")

        End If
    End Sub

    Private Sub BTMOSTRAR_Click(sender As Object, e As EventArgs) Handles BTMOSTRAR.Click
        mostrar()

    End Sub

    Private Sub BTENTRADAS_Click(sender As Object, e As EventArgs) Handles BTENTRADAS.Click
        Call limpiar_entradas()

    End Sub

    Private Sub BTVECTORES_Click(sender As Object, e As EventArgs) Handles BTVECTORES.Click
        Call limpiar_vextores()

    End Sub
End Class
