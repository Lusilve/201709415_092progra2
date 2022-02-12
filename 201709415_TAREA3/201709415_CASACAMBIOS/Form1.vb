Public Class Form1


    Private Sub ButtonCALCULAR_Click(sender As Object, e As EventArgs) Handles ButtonCALCULAR.Click
        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub cbcompra_CheckedChanged(sender As Object, e As EventArgs) Handles cbcompra.CheckedChanged
        If cbcompra.Checked = True Then
            TXTCOMPRA.Enabled = True
        Else
            TXTCOMPRA.Enabled = False

        End If
    End Sub
    Private Sub cbVENTA_CheckedChanged(sender As Object, e As EventArgs) Handles CBventa.CheckedChanged
        If CBventa.Checked = True Then
            TXTVENTA.Enabled = True
        Else
            TXTVENTA.Enabled = False

        End If
    End Sub

    Private Sub ButtonLIMPIAR_Click(sender As Object, e As EventArgs) Handles ButtonLIMPIAR.Click
        Call limpiar()
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Me.Close()
            End
        Else
            limpiar()

        End If

    End Sub
End Class
