Module Module1
    Public Const pdollar = 7.69
    Public Const pmexico = 38 / 100
    Public Const peuro = 8.79
    Public Const pcolon = 12 / 1000
    Public Const comixcompra = 25 / 1000
    Public Const comixventa = 30 / 1000
    Dim PAGOPARCOMPRA As Double = 0
    Dim COMISIONCOMPRA As Double = 0
    Dim PAGOTOTALCOMPRA As Double = 0
    Dim PAGOPARVENTA As Double = 0
    Dim COMISIONVENTA As Double = 0
    Dim PAGOTOTALVENTA As Double = 0
    Sub limpiar()
        Form1.TXTCOMPRA.Text = 0.00
        Form1.TXTVENTA.Text = 0.00
        Form1.cbcompra.Checked = False
        Form1.CBventa.Checked = False
        Form1.Rbcodo.Checked = False
        Form1.rbcope.Checked = False
        Form1.rbcoeu.Checked = False
        Form1.rbcocolo.Checked = False
        Form1.rbvendo.Checked = False
        Form1.rbvenpe.Checked = False
        Form1.rbvene.Checked = False
        Form1.rbvenco.Checked = False
        Form2.lbvento.Text = ""

    End Sub

    Function CALCULARCOMPRA(CANTIDADCOMPRA As Double, TIPOCOMPRA As Double)
        If CANTIDADCOMPRA > 0 Then
            PAGOPARCOMPRA = CANTIDADCOMPRA / TIPOCOMPRA
        Else
            PAGOPARCOMPRA = 0

        End If

        Return Math.Round(PAGOPARCOMPRA, 2)
    End Function

    Function CALCULARCOMISIONCOMPRA(CANTIDADCOMPRA As Double, TIPOTRANSACCION As Double)
        If CANTIDADCOMPRA > 0 Then
            COMISIONCOMPRA = PAGOPARCOMPRA * comixcompra
        Else
            COMISIONCOMPRA = 0

        End If

        Return Math.Round(COMISIONCOMPRA, 2)
    End Function



    Function CALCULARPAGOTOTALCOMPRA(CANTIDADCOMPRA As Double)
        If CANTIDADCOMPRA > 0 Then
            PAGOTOTALCOMPRA = PAGOPARCOMPRA - COMISIONCOMPRA
        Else
            PAGOTOTALCOMPRA = 0
        End If

        Return Math.Round(PAGOTOTALCOMPRA, 2)
    End Function

    Function CALCULARVENTA(CANTIDADVENTA As Double, TIPOVENTA As Double)
        If CANTIDADVENTA > 0 Then
            PAGOPARVENTA = CANTIDADVENTA * TIPOVENTA
        Else
            PAGOPARVENTA = 0
        End If

        Return Math.Round(PAGOPARVENTA, 2)
    End Function

    Function CALCULARCOMISIONVENTA(CANTIDADVENTA As Double)
        If CANTIDADVENTA > 0 Then
            COMISIONVENTA = CANTIDADVENTA * comixventa
        Else
            COMISIONVENTA = 0
        End If

        Return Math.Round(COMISIONVENTA, 2)
    End Function

    Function CALCULARPAGOTOTALVENTA(CANTIDADVENTA As Double)
        If CANTIDADVENTA > 0 Then
            PAGOTOTALVENTA = PAGOPARVENTA + COMISIONVENTA
        Else
            PAGOTOTALVENTA = 0

        End If

        Return Math.Round(PAGOTOTALVENTA, 2)
    End Function



End Module
