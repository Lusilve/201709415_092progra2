Public Class Form1
    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If INDICE < 6 Then
            numero_inventario(INDICE) = Val(TXTINVENTARIOS.Text)
            numero_deseado(INDICE) = Val(TXTDESEADO.Text)
            Call NUMEROS_INVENTARIOS()
            Call tipo_producto()
            Call descuento12()


            nombre_pack(INDICE) = InputBox("INGRESE NOMBRE DE PACK")
            numero_packs(INDICE) = numero_packs_division(numero_inventario(INDICE), numero_deseado(INDICE))
            NUMERO_SOBRANTE(INDICE) = numero_sobrante_mod(numero_inventario(INDICE), numero_deseado(INDICE))
            VALOR_PACK(INDICE) = Math.Round(numero_packs(INDICE) * precio(INDICE), 2)
            VALOR_SOBRANTE(INDICE) = Math.Round(NUMERO_SOBRANTE(INDICE) * precio(INDICE), 2)
            descuentototal(INDICE) = Math.Round(numero_packs(INDICE) * descuento(INDICE), 2)
            TOTAL(INDICE) = Math.Round(VALOR_PACK(INDICE) - descuentototal(INDICE) + VALOR_SOBRANTE(INDICE), 2)

            DataGridView1.Rows.Add(nombre_pack(INDICE), producto(INDICE), numero_inventario(INDICE), numero_deseado(INDICE), numero_packs(INDICE), NUMERO_SOBRANTE(INDICE), VALOR_PACK(INDICE), VALOR_SOBRANTE(INDICE), descuentototal(INDICE), TOTAL(INDICE))

            INDICE = INDICE + 1
        Else
            MsgBox("DATOS LLENOS")
        End If
    End Sub


    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Call SALIR()

    End Sub

    Private Sub LIMPIARDATAGRIDVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARDATAGRIDVIEWToolStripMenuItem.Click
        TXTDESEADO.Clear()
        TXTINVENTARIOS.Clear()
        ComboBox1.SelectedIndex = -1
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        INDICE = 0
        ReDim precio(6)
        ReDim nombre_pack(6)
        ReDim producto(6)
        ReDim numero_inventario(6)
        ReDim numero_deseado(6)
        ReDim numero_packs(6)
        ReDim NUMERO_SOBRANTE(6)
        ReDim SOBRANTE(6)
        ReDim VALOR_PACK(6)
        ReDim VALOR_SOBRANTE(6)
        ReDim TOTAL(6)
        ReDim descuento(6)
        ReDim descuentototal(6)

        TXTDESEADO.Clear()
        TXTINVENTARIOS.Clear()
        ComboBox1.SelectedIndex = -1
        DataGridView1.Rows.Clear()


    End Sub
End Class
