Module Module1
    Public Const precio_camion = 50
    Public Const precio_moto = 15
    Public nombre(10) As String
    Public valor_paquete(10) As Double
    Public peso(10) As Double
    Public tipo_paquete(10)
    Public envio(10)
    Public precio_parcial(10)
    Public porcentaje(10)
    Public preciototal(10)
    Public precio_envio(10)
    Public paquete(10)

    Public indice As Byte = 0
    Sub Estadisticas1()
        Dim total_losiones As Double = 0
        Dim total_documentos As Double = 0
        Dim cantidad_plasticos As Integer = 0
        Dim cantidad_ropa As Integer = 0
        Dim z As Byte = 0

        For z = 0 To 9
            If paquete(z) = 4 Then
                total_losiones = preciototal(z) + total_losiones
            End If
            If paquete(z) = 0 Then
                total_documentos = preciototal(z) + total_documentos

            End If

            If paquete(z) = 1 Then
                cantidad_ropa = cantidad_ropa + 1
            End If

            If paquete(z) = 3 Then
                cantidad_plasticos = cantidad_plasticos + 1
            End If


        Next z

        Form1.txtdocumentos.Text = (Math.Round((total_documentos), 2))
        Form1.txtlosiones.Text = Math.Round((total_losiones), 2)
        Form1.txtplasticos.Text = Math.Round((cantidad_plasticos), 2)
        Form1.txtropa.Text = Math.Round((cantidad_ropa), 2)
    End Sub

    Sub tipo_envio_paquete()
        If Form1.ComboBox2.SelectedIndex = 0 Then
            precio_envio(indice) = precio_camion

        ElseIf Form1.ComboBox2.SelectedIndex = 1 Then
            precio_envio(indice) = precio_moto

        Else
            MsgBox("seleccione tipo de envio")

        End If
    End Sub



    Function pago_parcial1() As Double
        Dim pago_parcial(10) As Double
        pago_parcial(indice) = valor_paquete(indice) + precio_envio(indice)

        Return pago_parcial(indice)

    End Function


    Sub impuesto()
        If paquete(indice) = 0 Then
            porcentaje(indice) = peso(indice) * (1.5 / 100)
        ElseIf paquete(indice) = 1 Then
            porcentaje(indice) = peso(indice) * (6 / 100)

        ElseIf paquete(indice) = 2 Then
            porcentaje(indice) = peso(indice) * (5.5 / 100)
        ElseIf paquete(indice) = 3 Then
            porcentaje(indice) = peso(indice) * (4.5 / 100)
        ElseIf paquete(indice) = 4 Then
            porcentaje(indice) = peso(indice) * (2 / 100)
        Else
            MsgBox("seleccione un paquete")


        End If
    End Sub


    Sub SALIR()
        If MsgBox("¿REALMENTE DESEA SALIR", vbQuestion + vbYesNo, "SALIR") = vbYes Then
            Form1.Close()
            End

        End If
    End Sub

    Sub mostrar()
        Dim i As Byte

        For i = 0 To 9
            If preciototal(i) <> Nothing Then
                Form1.ListBox1.Items.Add(nombre(i))
                Form1.ListBox2.Items.Add(tipo_paquete(i))
                Form1.ListBox3.Items.Add(envio(i))
                Form1.ListBox4.Items.Add(valor_paquete(i))
                Form1.ListBox5.Items.Add(precio_parcial(i))
                Form1.ListBox6.Items.Add(Math.Round(porcentaje(i), 2))
                Form1.ListBox7.Items.Add(preciototal(i))
                Form1.ListBox8.Items.Add(peso(i))
            Else
                Exit For

            End If
        Next i
        Call Estadisticas1()

    End Sub

    Sub limpiar_entradas()
        Form1.txtnombre.Clear()
        Form1.txtvalor.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1


    End Sub

    Sub limpiar_vextores()
        Dim i As Byte = 0
        For i = 0 To 9
            nombre(i) = Nothing
            valor_paquete(i) = Nothing
            peso(i) = Nothing
            tipo_paquete(i) = Nothing
            envio(i) = Nothing
            precio_parcial(i) = Nothing
            porcentaje(i) = Nothing
            preciototal(i) = Nothing
            precio_envio(i) = Nothing
            paquete(i) = Nothing
            Form1.ListBox1.Items.Clear()
            Form1.ListBox2.Items.Clear()
            Form1.ListBox3.Items.Clear()
            Form1.ListBox4.Items.Clear()
            Form1.ListBox5.Items.Clear()
            Form1.ListBox6.Items.Clear()
            Form1.ListBox7.Items.Clear()
            Form1.ListBox8.Items.Clear()

            Form1.txtdocumentos.Clear()
            Form1.txtlosiones.Clear()
            Form1.txtplasticos.Clear()
            Form1.txtropa.Clear()



        Next
    End Sub
End Module
