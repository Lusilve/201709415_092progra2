Module Module1

    Public HOTEL(7, 7)
    Public Const estandar = 250
    Public Const ac = 290
    Public Const jacuzzi = 370
    Public indice As Byte = 0
    Public x As Byte

    Sub COBRO()
        If Val(HOTEL(indice, 2)) > 4 Then
            HOTEL(indice, 5) = Math.Round((HOTEL(indice, 2) - 4) * 60, 2)

        Else
            HOTEL(indice, 5) = 0

        End If
    End Sub
    Sub MOSTRAR()
        Form1.DataGridView1.Rows.Clear()


        x = 0
        While (x <= 7)
            If HOTEL(x, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(HOTEL(x, 0), HOTEL(x, 1), HOTEL(x, 2), HOTEL(x, 3), HOTEL(x, 4), HOTEL(x, 5), HOTEL(x, 6))
            Else
                Exit While

            End If
            x = x + 1
        End While
    End Sub
    Sub limpiar()
        Form1.DataGridView1.Rows.Clear()
        x = 0
        While x <= 7
            HOTEL(x, 0) = Nothing
            HOTEL(x, 1) = Nothing
            HOTEL(x, 2) = Nothing
            HOTEL(x, 3) = Nothing
            HOTEL(x, 4) = Nothing
            HOTEL(x, 5) = Nothing
            HOTEL(x, 6) = Nothing


            x = X + 1

        End While

    End Sub

End Module
