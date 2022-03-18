Module Module1

    Public Const precio_tablet = 375
    Public Const precio_drone = 560
    Public Const precio_celular = 1450
    Public Const precio_televisor = 3250
    Public Const porcentaje = 5.5 / 100

    Public nombre_empleado(7) As String
    Public sueldo_bruto(7) As Double
    Public tipo_venta(7) As String
    Public comision(7) As Double
    Public bono(7) As Double
    Public sueldo_total(7) As Double
    Public index As Byte = 0

    Sub venta1()
        If Form1.Rbtablet.Checked Or Form1.RBDRONE.Checked Or Form1.RBCELULAR.Checked Or Form1.RBTELEVISOR.Checked Then
            If Form1.Rbtablet.Checked = True Then

                comision(index) = precio_tablet * porcentaje
            End If
            If Form1.RBDRONE.Checked = True Then

                comision(index) = precio_drone * porcentaje
            End If
            If Form1.RBCELULAR.Checked = True Then

                comision(index) = precio_celular * porcentaje
            End If
            If Form1.RBTELEVISOR.Checked = True Then

                comision(index) = precio_televisor * porcentaje

            End If

        Else
            MsgBox("seleccione tipo de articulo")
        End If
    End Sub

    Sub bono1()
        If sueldo_bruto(index) <= 2000 Then
            bono(index) = sueldo_bruto(index) * 0.03

        ElseIf 2001 <= sueldo_bruto(index) And sueldo_bruto(index) <= 5000 Then
            bono(index) = sueldo_bruto(index) * 0.04

        ElseIf 5001 <= sueldo_bruto(index) Then
            bono(index) = sueldo_bruto(index) * 0.05

        End If
    End Sub



    Sub limpiarvectores()

        index = 0
        ReDim nombre_empleado(7)
        ReDim sueldo_bruto(7)
        ReDim tipo_venta(7)
        ReDim comision(7)
        ReDim bono(7)
        ReDim sueldo_total(7)


    End Sub

    Sub limpiar()
        Form1.txtnombre.Clear()
        Form1.txtvalorbruto.Clear()
        Form1.RBCELULAR.Checked = False
        Form1.RBDRONE.Checked = False
        Form1.Rbtablet.Checked = False
        Form1.RBTELEVISOR.Checked = False
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()



    End Sub
End Module
