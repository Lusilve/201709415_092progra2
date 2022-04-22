Module Module1
    Public nombre(7)
    Public nit(7)
    Public dias(7)
    Public tipo_habitacion(7)
    Public forma_pago(7)
    Public interes(7)
    Public pago_parcial(7)
    Public pago_total(7)
    Public Indice As Byte = 0
    Public habita(7)
    Public Const habitacion_sencilla = 250
    Public Const habitacion_doble = 400
    Public Const habitacion_cabaña = 650




    Sub limpiar()
        Dim i As Byte = 0
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 6
            nombre(i) = Nothing
            nit(i) = Nothing
            dias(i) = Nothing
            tipo_habitacion(i) = Nothing
            forma_pago(i) = Nothing
            interes(i) = Nothing
            pago_parcial(i) = Nothing
            pago_total(i) = Nothing
        Next i



    End Sub

End Module
