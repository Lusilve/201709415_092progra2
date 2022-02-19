Public Class RESULTADOS
    Private Sub BUTTONREGRESAR_Click(sender As Object, e As EventArgs) Handles ButtonREGRESAR.Click
        Call LIMPIAR()
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub RESULTADOS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Call LIMPIAR()
        Form1.Show()
        Me.Hide()
    End Sub

End Class