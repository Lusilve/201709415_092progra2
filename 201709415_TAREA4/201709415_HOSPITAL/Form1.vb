Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Call SALIR()

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (index <= 5) Then
            Call mensajes()

            nombre(index) = TXTNOMBRE.Text
            nit(index) = Val(TXTNIT.Text)
            diashosp(index) = Val(InputBox("Ingrese cantidad de dias Hospitalizado"))
            honorarios(index) = Val(InputBox("ingrese los honorarios del doctor"))
            habitacion(index) = CombOSERVICIO.Text
            Select Case (CombOSERVICIO.SelectedIndex)
                Case 0 : calculopriv()
                Case 1 : calculosemi()
                Case 2 : calculonopriv()
            End Select


            subtotal(index) = Math.Round(parcial(), 2)
            descuento(index) = Math.Round(formapago(), 2)
            total(index) = Math.Round(pagototal(), 2)




            DataGridView1.Rows.Add(nombre(index), nit(index), habitacion(index), diashosp(index), encamamiento(index), operacion(index), maternidad(index), formap(index), honorarios(index), subtotal(index), descuento(index), total(index))
            index = index + 1
        End If

        If index = 6 Then
            MsgBox("ya esta llena la base de datos")
            limpiarentradaas()

        End If

    End Sub

    Private Sub ENTRADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADAToolStripMenuItem.Click
        Call limpiarentradaas()

    End Sub

    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        Call limpiarvectores()

    End Sub
End Class
