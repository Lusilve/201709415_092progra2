Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Call SALIR()

    End Sub

    Private Sub chkviernes_CheckedChanged(sender As Object, e As EventArgs) Handles chkviernes.CheckedChanged
        If chkviernes.Checked = True Then
            GroupBoxVIERNES.Visible = True

        Else
            GroupBoxVIERNES.Visible = False

        End If

    End Sub

    Private Sub chksabado_CheckedChanged(sender As Object, e As EventArgs) Handles chksabado.CheckedChanged
        If chksabado.Checked = True Then
            GROUPBOXSABADO.Visible = True

        Else
            GROUPBOXSABADO.Visible = False

        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem1.Click
        If INDEX <= 7 Then
            Call mensajes()



            IDIOMAS(INDEX, 0) = TXTNOMBRE.Text
            IDIOMAS(INDEX, 1) = TXTCARNET.Text
            IDIOMAS(INDEX, 2) = Format(DateTimePicker1.Value, "dd/MM/yyyy")
            IDIOMAS(INDEX, 3) = ComboBox1.Text
            Call hora_dias()
            Call formadepago()

            'Aqui se mostrara el precio parcial de las horas a cursar 
            Select Case ComboBox1.SelectedIndex
                Case 0 : IDIOMAS(INDEX, 7) = PRECIOINGLES * IDIOMAS(INDEX, 4) + PRECIOINGLES * IDIOMAS(INDEX, 5)
                Case 1 : IDIOMAS(INDEX, 7) = PRECIOPORTUGIES * (IDIOMAS(INDEX, 4)) + PRECIOPORTUGIES * (IDIOMAS(INDEX, 5))
                Case 2 : IDIOMAS(INDEX, 7) = PRECIOFRANCES * IDIOMAS(INDEX, 4) + PRECIOFRANCES * IDIOMAS(INDEX, 5)
                Case Else
                    MsgBox("seleccione idioma")
            End Select


            IDIOMAS(INDEX, 8) = Str(desc_total1(IDIOMAS(INDEX, 7)))
            IDIOMAS(INDEX, 9) = Str(pago_total(IDIOMAS(INDEX, 7), IDIOMAS(INDEX, 8)))



            DataGridView1.Rows.Add(IDIOMAS(INDEX, 0), IDIOMAS(INDEX, 1), IDIOMAS(INDEX, 2), IDIOMAS(INDEX, 3), IDIOMAS(INDEX, 4), IDIOMAS(INDEX, 5), IDIOMAS(INDEX, 6), IDIOMAS(INDEX, 7), IDIOMAS(INDEX, 8), IDIOMAS(INDEX, 9))
            INDEX = INDEX + 1


        Else INDEX = 8
            MsgBox("Matrices llenas")


        End If
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Call limpiar_entradas()

    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        Call limpiar_matriz()

    End Sub
End Class
