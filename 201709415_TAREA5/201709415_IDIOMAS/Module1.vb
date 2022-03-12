Module Module1
    Public Const PRECIOINGLES = 150
    Public Const PRECIOPORTUGIES = 80
    Public Const PRECIOFRANCES = 125

    Public IDIOMAS(7, 9) As String
    Public INDEX As Byte = 0

    Sub mensajes()
        If Form1.TXTNOMBRE.Text = "" Then

            MsgBox("ingrese nombre")

        End If

        If Form1.TXTCARNET.Text = "" Then
            MsgBox("ingrese carnet")
        End If


    End Sub


    'aqui se mostrara las horas que se cursara en cada dia 
    Sub hora_dias()
        If Form1.chkviernes.Checked Or Form1.chksabado.Checked Then

            If Form1.chkviernes.Checked Then
                IDIOMAS(INDEX, 4) = Val(Form1.TXTHORAVIERNES.Text)
            Else
                IDIOMAS(INDEX, 4) = 0
            End If
            If Form1.chksabado.Checked Then
                IDIOMAS(INDEX, 5) = Val(Form1.TXTHORASABADO.Text)
            Else
                IDIOMAS(INDEX, 5) = 0
            End If
        Else
            MsgBox("seleccione dia")
        End If
    End Sub

    'aqui se mostrara la forma de pago
    Sub formadepago()

        If Form1.RBEFECTIVO.Checked Or Form1.RBCHEQUE.Checked Then


            If Form1.RBEFECTIVO.Checked = True Then
                IDIOMAS(INDEX, 6) = Form1.RBEFECTIVO.Text
            Else
                Form1.RBCHEQUE.Checked = True
                IDIOMAS(INDEX, 6) = Form1.RBCHEQUE.Text
            End If
        Else
            MsgBox("seleccione forma de pago")
        End If
    End Sub


    'DESCUENTOS TOTALES 
    Function desc_total1(pparcial As Double)
        Dim desc_total As Double
        If Form1.RBEFECTIVO.Checked = True And Form1.chksabado.Checked = True And Form1.chkviernes.Checked = True Then
            desc_total = pparcial * 0.05 + pparcial * 0.02
            Return desc_total
        ElseIf Form1.RBCHEQUE.Checked = True And Form1.chksabado.Checked = True And Form1.chkviernes.Checked = True Then
            desc_total = pparcial * 0.05 + pparcial * 0.015
            Return desc_total
        ElseIf Form1.RBEFECTIVO.Checked = True Then
            desc_total = pparcial * 0.02
            Return desc_total
        Else Form1.RBCHEQUE.Checked = True
            desc_total = pparcial * 0.015
            Return Math.Round(desc_total, 2)

        End If
    End Function
    Function pago_total(pparcial As Double, desct As Double)
        Dim pagototal As Double

        pagototal = pparcial - desct

        Return Math.Round(pagototal, 2)


    End Function

    Sub limpiar_entradas()
        Form1.TXTCARNET.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTHORASABADO.Clear()
        Form1.TXTHORAVIERNES.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.chkviernes.Checked = 0
        Form1.chksabado.Checked = 0
        Form1.RBCHEQUE.Checked = 0
        Form1.RBEFECTIVO.Checked = 0
        Form1.TXTNOMBRE.Focus()

    End Sub

    Sub limpiar_matriz()
        INDEX = 0
        Form1.DataGridView1.Rows.Clear()


    End Sub


    Sub SALIR()
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Form1.Close()
            End
        Else
            limpiar_entradas()

        End If

    End Sub




End Module
