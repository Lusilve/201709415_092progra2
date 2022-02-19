Module FUNCIONES
    Public Const MOSMALL = 65.5
    Public Const MOMEDIUM = 85.99
    Public Const MOLARGE = 99.99
    Public Const MATALGODON = 15
    Public Const MATSEDA = 23.99
    Public Const MATLONA = 30.99
    Public Const YARDASMALL = 2
    Public Const YARDAMEDIUM = 2.5
    Public Const YARDALARGE = 3
    Public Const porcentajeventa = 65 / 100
    Public sub1 As Double = 0
    Public sub2 As Double = 0
    Public sub3 As Double = 0
    Public COSTO1 As Double = 0
    Public VENTA As Double = 0
    Public PRECIOVENTATO As Double = 0




    Public Sub MENSAJES()
        If Form1.TXTCANTIDAD.Text = "" Then
            MsgBox("NO INGRESO CANTIDAD")

        End If

        If Form1.RBSMALL.Checked = False And Form1.RBMEDIUM.Checked = False And Form1.RBLARGE.Checked = False Then
            MsgBox("NO SELECCIONO TAMAÑO")

        End If

        If Form1.RBALGODON.Checked = False And Form1.RBSEDA.Checked = False And Form1.RBLONA.Checked = False Then
            MsgBox("NO SELECCIONO MATERIAL")


        End If

    End Sub


    Function calculo1(mo As Double, tam As Double, mat As Double)
        calculo1 = mo + tam * mat
        Return calculo1
    End Function

    Public Sub LIMPIAR()
        Form1.TXTCANTIDAD.Clear()
        Form1.RBSMALL.Checked = False
        Form1.RBMEDIUM.Checked = False
        Form1.RBLARGE.Checked = False
        Form1.RBALGODON.Checked = False
        Form1.RBSEDA.Checked = False
        Form1.RBLONA.Checked = False
        RESULTADOS.TXTCOSTO.Clear()
        RESULTADOS.TXTVENTA.Clear()
        RESULTADOS.TXTPVENTA.Clear()

    End Sub


End Module
