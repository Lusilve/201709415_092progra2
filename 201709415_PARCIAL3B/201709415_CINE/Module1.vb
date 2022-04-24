Module Module1
    Public CINE(7, 6)
    Public Const PRECIO_NORMAL = 44
    Public Const PRECIO_3D = 62
    Public Const PRECIO_4DX = 104

    Public INDICE As Byte = 0
    Public X As Byte





    Sub CANTIDAD_BOLETOS()
        If Form1.CHKNORMAL.Checked Or Form1.CHK3D.Checked Or Form1.CHK4DX.Checked Then
            If Form1.CHKNORMAL.Checked Then
                CINE(INDICE, 2) = Val(Form1.TXTBOLETOS.Text)
            Else
                CINE(INDICE, 2) = 0
            End If
            If Form1.CHK3D.Checked Then
                CINE(INDICE, 3) = Val(Form1.TXTN3D.Text)
            Else
                CINE(INDICE, 3) = 0
            End If

            If Form1.CHK4DX.Checked Then
                CINE(INDICE, 4) = Val(Form1.TXTN4DX.Text)
            Else
                CINE(INDICE, 4) = 0
            End If

        End If
    End Sub


    Sub MOSTRAR()
        X = 0
        While (X <= 6)
            If CINE(X, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(CINE(X, 0), CINE(X, 1), CINE(X, 2), CINE(X, 3), CINE(X, 4), CINE(X, 5))
            Else
                Exit While

            End If
            X = X + 1
        End While
    End Sub

    Sub LIMPIAR_ENTRADADAS()
        Form1.TXTNIT.Clear()
        Form1.TXTPELICULA.Clear()
        Form1.TXTBOLETOS.Clear()
        Form1.TXTN3D.Clear()
        Form1.TXTN4DX.Clear()
        Form1.TXTBUSCAR.Clear()
        Form1.CHKNORMAL.Checked = False
        Form1.CHK3D.Checked = False
        Form1.CHK4DX.Checked = False

    End Sub


    Sub LIMPIAR_MATRIZ()
        Form1.DataGridView1.Rows.Clear()
        While X <= 6
            CINE(X, 0) = Nothing
            CINE(X, 1) = Nothing
            CINE(X, 2) = Nothing
            CINE(X, 3) = Nothing
            CINE(X, 4) = Nothing
            CINE(X, 5) = Nothing

            X = X + 1

        End While
        LIMPIAR_ENTRADADAS()

    End Sub
End Module
