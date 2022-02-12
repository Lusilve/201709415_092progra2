Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BUTTONREGRESAR.Click
        Form1.Show()
        Me.Close()
        Call limpiar()




    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
        Call limpiar()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If Form1.Rbcodo.Checked Then
            Lbcomca.Text = Str(CALCULARCOMPRA(Form1.TXTCOMPRA.Text, pdollar))
        ElseIf Form1.rbcope.Checked Then
            Lbcomca.Text = Str(CALCULARCOMPRA(Form1.TXTCOMPRA.Text, pmexico))
        ElseIf Form1.rbcoeu.Checked Then
            Lbcomca.Text = Str(CALCULARCOMPRA(Form1.TXTCOMPRA.Text, peuro))
        ElseIf Form1.rbcocolo.Checked Then
            Lbcomca.Text = Str(CALCULARCOMPRA(Form1.TXTCOMPRA.Text, pcolon))

        Else
            Lbcomca.Text = 0
        End If

        If (Form1.cbcompra.Checked Or Form1.CBventa.Checked) Then

            If Form1.cbcompra.Checked Then
                lbcomco.Text = Str(CALCULARCOMISIONCOMPRA(Form1.TXTCOMPRA.Text, comixcompra))
            End If
            If Form1.CBventa.Checked Then
                lbvenco.Text = Str(CALCULARCOMISIONVENTA(Form1.TXTVENTA.Text))
            End If
        Else
            MsgBox("ERROR, NO SELECCIONO TRANSACCION")

        End If

        If Form1.rbvendo.Checked Then
            lbvenca.Text = Str(CALCULARVENTA(Form1.TXTVENTA.Text, pdollar))
        ElseIf Form1.rbvenpe.Checked Then
            lbvenca.Text = Str(CALCULARVENTA(Form1.TXTVENTA.Text, pmexico))
        ElseIf Form1.rbvene.Checked Then
            lbvenca.Text = Str(CALCULARVENTA(Form1.TXTVENTA.Text, peuro))
        ElseIf Form1.rbvenco.Checked Then
            lbvenca.Text = Str(CALCULARVENTA(Form1.TXTVENTA.Text, pcolon))

        Else
            lbvenca.Text = 0
        End If


        lbcomto.Text = CALCULARPAGOTOTALCOMPRA(Form1.TXTCOMPRA.Text)
        lbvento.Text = CALCULARPAGOTOTALVENTA(Form1.TXTVENTA.Text)






    End Sub

End Class