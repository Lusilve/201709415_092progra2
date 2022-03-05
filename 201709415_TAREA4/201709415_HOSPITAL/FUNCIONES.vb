Module FUNCIONES
    Public Const privenca = 350
    Public Const privop = 550
    Public Const privmat = 450
    Public Const semienca = 250
    Public Const semiop = 400
    Public Const semimat = 350
    Public Const npenca = 150
    Public Const npop = 300
    Public Const npmat = 250
    Public index As Byte = 0
    Public nombre(5) As String
    Public nit(5) As Double
    Public habitacion(5) As String
    Public diashosp(5) As Double
    Public honorarios(5) As Double
    Public encamamiento(5) As Double
    Public operacion(5) As Double
    Public maternidad(5) As Double
    Public formap(5) As String
    Public subtotal(5) As Double
    Public descuento(5) As Double
    Public total(5) As Double

    Sub mensajes()
        If Form1.TXTNOMBRE.Text = "" Then
            MsgBox("escribe un nombre")
        End If
        If Form1.TXTNIT.Text = "" Then
            MsgBox("coloca un nit")
        End If



        If Form1.CombOSERVICIO.SelectedIndex = -1 Then
            MsgBox("no selecciono habitacion")
        End If
    End Sub

    Sub calculopriv()
        If Form1.CHKENCAMAMIENTO.Checked Or Form1.CHKOPERACION.Checked Or Form1.CHKMATERNIDAD.Checked Then
            If Form1.CHKENCAMAMIENTO.Checked Then
                encamamiento(index) = privenca
            Else encamamiento(index) = 0
            End If
            If Form1.CHKOPERACION.Checked Then
                operacion(index) = privop
            Else operacion(index) = 0
            End If
            If Form1.CHKMATERNIDAD.Checked Then
                maternidad(index) = privmat
            Else maternidad(index) = 0
            End If
        Else
            MsgBox("no selecciono servicio")

        End If

    End Sub

    Sub calculosemi()
        If Form1.CHKENCAMAMIENTO.Checked Or Form1.CHKOPERACION.Checked Or Form1.CHKMATERNIDAD.Checked Then
            If Form1.CHKENCAMAMIENTO.Checked Then
                encamamiento(index) = semienca
            Else encamamiento(index) = 0
            End If
            If Form1.CHKOPERACION.Checked Then
                operacion(index) = semiop
            Else operacion(index) = 0
            End If
            If Form1.CHKMATERNIDAD.Checked Then
                maternidad(index) = semimat
            Else maternidad(index) = 0
            End If
        Else
            MsgBox("no selecciono servicio")

        End If
    End Sub

    Sub calculonopriv()
        If Form1.CHKENCAMAMIENTO.Checked Or Form1.CHKOPERACION.Checked Or Form1.CHKMATERNIDAD.Checked Then
            If Form1.CHKENCAMAMIENTO.Checked Then
                encamamiento(index) = npenca
            Else encamamiento(index) = 0
            End If
            If Form1.CHKOPERACION.Checked Then
                operacion(index) = npop
            Else operacion(index) = 0
            End If
            If Form1.CHKMATERNIDAD.Checked Then
                maternidad(index) = npmat
            Else maternidad(index) = 0
            End If
        Else
            MsgBox("no selecciono servicio")

        End If
    End Sub

    Function parcial() As Double
        parcial = diashosp(index) * (encamamiento(index) + operacion(index) + maternidad(index))
        Return parcial
    End Function

    Function pagototal() As Double
        pagototal = subtotal(index) + descuento(index)
        Return pagototal

    End Function

    Function formapago() As Double
        Dim desc As Double


        If Form1.RBEFECTIVO.Checked Then
            desc = subtotal(index) * 0.15 * -1
            formap(index) = Form1.RBEFECTIVO.Text
            Return desc
        End If
        If Form1.RBCHEQUE.Checked Then
            desc = subtotal(index) * 0.15 * -1
            formap(index) = Form1.RBCHEQUE.Text
            Return desc

        End If
        If Form1.RBTDEBITO.Checked Then
            desc = subtotal(index) * (+0.08)
            formap(index) = Form1.RBTDEBITO.Text
            Return desc
        End If
        If Form1.RBTCREDITO.Checked Then
            desc = subtotal(index) * (+0.05)
            formap(index) = Form1.RBTCREDITO.Text
            Return desc
        End If
    End Function

    Sub limpiarentradaas()
        Form1.TXTNIT.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.CombOSERVICIO.SelectedIndex = -1
        Form1.CHKENCAMAMIENTO.Checked = False
        Form1.CHKMATERNIDAD.Checked = False
        Form1.CHKOPERACION.Checked = False
        Form1.RBCHEQUE.Checked = False
        Form1.RBEFECTIVO.Checked = False
        Form1.RBTCREDITO.Checked = False
        Form1.RBTDEBITO.Checked = False

    End Sub

    Sub limpiarvectores()
        index = 0
        ReDim nombre(5)
        ReDim nit(5)
        ReDim habitacion(5)
        ReDim diashosp(5)
        ReDim honorarios(5)
        ReDim encamamiento(5)
        ReDim operacion(5)
        ReDim maternidad(5)
        ReDim formap(5)
        ReDim subtotal(5)
        ReDim descuento(5)
        ReDim total(5)

        Form1.DataGridView1.Rows.Clear()
        Form1.TXTNIT.Clear()
        Form1.TXTNOMBRE.Clear()
        Form1.CombOSERVICIO.SelectedIndex = -1
        Form1.CHKENCAMAMIENTO.Checked = False
        Form1.CHKMATERNIDAD.Checked = False
        Form1.CHKOPERACION.Checked = False
        Form1.RBCHEQUE.Checked = False
        Form1.RBEFECTIVO.Checked = False
        Form1.RBTCREDITO.Checked = False
        Form1.RBTDEBITO.Checked = False




    End Sub

    Sub SALIR()
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Form1.Close()
            End

        End If

    End Sub



End Module
