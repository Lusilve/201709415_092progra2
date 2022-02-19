Public Class Form1
    Private Sub ButtonLIMPIAR_Click(sender As Object, e As EventArgs) Handles ButtonLIMPIAR.Click
        Call LIMPIAR()

    End Sub

    Private Sub BUTTONSALIR_Click(sender As Object, e As EventArgs) Handles BUTTONSALIR.Click
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Me.Close()
            End
        Else
            LIMPIAR()

        End If
    End Sub

    Private Sub BUTTONCALCULAR_Click(sender As Object, e As EventArgs) Handles ButtonCALCULAR.Click
        Call MENSAJES()
        If RBSMALL.Checked Then
            sub1 = Val(TXTCANTIDAD.Text) * MOSMALL
            sub2 = Val(TXTCANTIDAD.Text) * YARDASMALL
        End If
        If RBMEDIUM.Checked Then
            sub1 = Val(TXTCANTIDAD.Text) * MOMEDIUM
            sub2 = Val(TXTCANTIDAD.Text) * YARDAMEDIUM

        End If
        If RBLARGE.Checked Then
            sub1 = Val(TXTCANTIDAD.Text) * MOLARGE
            sub2 = Val(TXTCANTIDAD.Text) * YARDALARGE
        End If
        If RBALGODON.Checked Then
            sub3 = MATALGODON
        End If
        If RBSEDA.Checked Then
            sub3 = MATSEDA
        End If
        If RBLONA.Checked Then
            sub3 = MATLONA

        End If

        COSTO1 = Math.Round(calculo1(sub1, sub2, sub3), 2)
        VENTA = Math.Round(COSTO1 * porcentajeventa)
        PRECIOVENTATO = Math.Round(COSTO1 + VENTA, 2)

        RESULTADOS.TXTCOSTO.Text = COSTO1
        RESULTADOS.TXTVENTA.Text = VENTA
        RESULTADOS.TXTPVENTA.Text = PRECIOVENTATO

        Me.Hide()
        RESULTADOS.Show()



    End Sub



    'PARA NO INGRESAR LETRAS
    Private Sub TXTCANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCANTIDAD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
