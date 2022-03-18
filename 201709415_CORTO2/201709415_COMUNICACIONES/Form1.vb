Public Class Form1

    Private Sub Buttoncalc_Click(sender As Object, e As EventArgs) Handles Buttoncalc.Click
        If index <= 6 Then
            nombre_empleado(index) = txtnombre.Text
            sueldo_bruto(index) = Val(txtvalorbruto.Text)
            Call venta1()
            Call bono1()



            ListBox1.Items.Add(nombre_empleado(index))
            ListBox2.Items.Add(sueldo_bruto(index))
            ListBox5.Items.Add(bono(index))
            ListBox6.Items.Add(comision(index))

            sueldo_total(index) = sueldo_bruto(index) + bono(index) + comision(index)

            ListBox7.Items.Add(sueldo_total(index))



            index = index + 1

        Else index = 7
            MsgBox("vectores llenos")

        End If
    End Sub

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs) Handles Buttonsalir.Click
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Me.Close()
            End

        End If
    End Sub

    Private Sub Buttonlimpiar_Click(sender As Object, e As EventArgs) Handles Buttonlimpiar.Click
        Call limpiar()

    End Sub

    Private Sub Buttonlimpiarvec_Click(sender As Object, e As EventArgs) Handles Buttonlimpiarvec.Click
        Call limpiarvectores()

    End Sub
End Class
