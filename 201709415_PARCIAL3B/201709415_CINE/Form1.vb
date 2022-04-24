Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If INDICE < 7 Then

            CINE(INDICE, 0) = Val(TXTNIT.Text)
            CINE(INDICE, 1) = (TXTPELICULA.Text)
            Call CANTIDAD_BOLETOS()
            CINE(INDICE, 5) = Math.Round(CINE(INDICE, 2) * PRECIO_NORMAL + CINE(INDICE, 3) * PRECIO_3D + CINE(INDICE, 4) * PRECIO_4DX, 2)

            INDICE = INDICE + 1
            LIMPIAR_ENTRADADAS()

        Else INDICE = 7
            MsgBox("MATRIZ LLENA")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Call MOSTRAR()

    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        Call LIMPIAR_MATRIZ()
        TXTNIT.Focus()

    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        Dim buscar As Boolean = True
        X = 0
        While X <= 6 And buscar
            If CINE(X, 0) <> Nothing Then
                If CINE(X, 0) = Val(TXTBUSCAR.Text) Then
                    buscar = False
                Else
                    X = X + 1
                End If
            Else
                Exit While
            End If
        End While

        If buscar Then
            MsgBox("LA COMPRA CON EL NUMERO DE NIT NO EXISTE")
            TXTBUSCAR.Focus()
        Else
            MsgBox("LA COMPRA CON EL NUMERO DE NIT SE ENCONTRO")
            TXTNIT.Text = CINE(X, 0)
            TXTPELICULA.Text = CINE(X, 1)
            TXTBOLETOS.Text = CINE(X, 2)
            TXTN3D.Text = CINE(X, 3)
            TXTN4DX.Text = CINE(X, 4)

            If CINE(X, 2) <> 0 Then
                CHKNORMAL.Checked = True
            End If
            If CINE(X, 3) <> 0 Then
                CHK3D.Checked = True

            End If
            If CINE(X, 4) <> 0 Then
                CHK4DX.Checked = True

            End If
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(CINE(X, 0), CINE(X, 1), CINE(X, 2), CINE(X, 3), CINE(X, 4), CINE(X, 5))

            INDICE = X
        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click

        CINE(INDICE, 0) = Val(TXTNIT.Text)
        CINE(INDICE, 1) = (TXTPELICULA.Text)
        Call CANTIDAD_BOLETOS()
        CINE(INDICE, 5) = Math.Round(CINE(INDICE, 2) * PRECIO_NORMAL + CINE(INDICE, 3) * PRECIO_3D + CINE(INDICE, 4) * PRECIO_4DX, 2)
        MsgBox("COMPRA ACTUALIZADA")
        INDICE = 7
        LIMPIAR_ENTRADADAS()
    End Sub
End Class
