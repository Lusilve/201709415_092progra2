Imports System.Math

Public Class Form1
    Const precioarroz As Double = 2
    Const precioazucar As Double = 2.5
    Const preciofrijol As Double = 1.75

    Dim pagosiniva As Double = 0
    Dim totaliva As Double = 0
    Dim pagoiva As Double = 0
    Dim desc As Double = 0
    Dim pagofinal As Double = 0

    Private Sub Bcalcular_Click(sender As Object, e As EventArgs) Handles Bcalcular.Click
        pagosiniva = Round((TextBoxarroz.Text * precioarroz + TextBoxazucar.Text * precioazucar + TextBoxfrijol.Text * preciofrijol), 2)
        totaliva = Round((pagosiniva * 0.12), 2)
        pagoiva = Round((pagosiniva + totaliva), 2)
        desc = Round((pagoiva * 0.025), 2)
        pagofinal = Round((pagoiva - desc), 2)

        TextBoxsiniva.Text = pagosiniva
        TextBoxIVA.Text = totaliva
        TextBoxPAIVA.Text = pagoiva
        TextBoxDESCUENTO.Text = desc
        TextBoxPTOTAL.Text = pagofinal

        Pago.Visible = True



    End Sub

    Private Sub Bnew_Click(sender As Object, e As EventArgs) Handles Bnew.Click
        TextBoxsiniva.Clear()
        TextBoxIVA.Clear()
        TextBoxPAIVA.Clear()
        TextBoxDESCUENTO.Clear()
        TextBoxPTOTAL.Clear()
        TextBoxarroz.Clear()
        TextBoxazucar.Clear()
        TextBoxfrijol.Clear()
        TextBoxazucar.Focus()

        Pago.Visible = False

    End Sub

    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click
        Me.Close()

    End Sub
    Private Sub TextBoxazucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxazucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxarroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxarroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxfrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxfrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


End Class
