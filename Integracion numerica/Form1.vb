Imports info.lundin.math
Public Class Form1
    Dim a, b, n, ec, h, suma, suma1, cs, q, w, fInicial, fFInal As Single

    Private Sub btnSimpson_Click(sender As Object, e As EventArgs) Handles btnSimpson.Click
        a = tbA.Text
        b = tbB.Text
        cs = tbCS.Text
        i = 0
        fInicial = f(a)
        fFInal = f(b)
        redon = cs + 2
        ec = 0.5 * 10 ^ (-cs)
        n = 4
        h = ((b - a) / (2 * n))
        err(i) = 1
        suma = 0
        suma1 = 0
        For k = 1 To n
            suma = suma + 4 * f(a + ((2 * k - 1) * h))
            suma1 = suma1 + 2 * f(a + (2 * k * h))
        Next k
        integral(i) = h / 3 * (f(a) - f(b) + suma + suma1)
        salida.Rows.Add(n, integral(i), err(i))

        Do While err(i) > ec
            n = n + 4
            i = i + 1
            h = ((b - a) / (2 * n))
            suma = 0
            suma1 = 0
            For k = 1 To n
                suma = suma + 4 * f(a + ((2 * k - 1) * h))
                suma1 = suma1 + 2 * f(a + (2 * k * h))
            Next k
            integral(i) = h / 3 * (f(a) - f(b) + suma + suma1)
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop
    End Sub

    Dim g As Graphics

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub btnTrapecios_Click(sender As Object, e As EventArgs) Handles btnTrapecios.Click
        a = tbA.Text
        b = tbB.Text
        cs = tbCS.Text
        i = 0
        fInicial = f(a)
        fFInal = f(b)
        redon = cs + 2
        ec = 0.5 * 10 ^ (-cs)
        n = 10
        h = ((b - a) / n)
        err(i) = 1
        suma = 0
        For k = 1 To n - 1
            suma = suma + 2 * f(a + (k * h))
        Next k
        integral(i) = h / 2 * (f(a) + f(b) + suma)
        salida.Rows.Add(n, integral(i), err(i))

        Do While err(i) > ec
            n = n + 10
            i = i + 1
            h = ((b - a) / n)
            suma = 0
            For k = 1 To n - 1
                suma = suma + 2 * f(a + (k * h))
            Next k
            integral(i) = h / 2 * (f(a) + f(b) + suma)
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop
    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = Graf.CreateGraphics
        q = tbRangoInicial.Text
        Do While q <= tbRangoFinal.Text
            Graf.Series(0).Points.AddXY(Math.Round(q, 1), f(q))
            q = q + 0.1
        Loop
        w = a
        Do While w <= b
            Graf.Series(1).Points.AddXY(Math.Round(w, 1), f(w))
            w = w + 0.1
        Loop
    End Sub

    Dim i, redon As Integer

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        tbA.Text = ""
        tbB.Text = ""
        tbCS.Text = ""
        tbFuncion.Text = ""
        tbRangoFinal.Text = ""
        tbRangoInicial.Text = ""
        salida.Rows.Clear()
        Graf.Series(0).Points.Clear()
        Graf.Series(1).Points.Clear()
    End Sub

    Dim integral(500), err(500) As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tbFuncion.Text)
    End Function

    Private Sub btnRectangulos_Click(sender As Object, e As EventArgs) Handles btnRectangulos.Click
        a = tbA.Text
        b = tbB.Text
        cs = tbCS.Text
        i = 0
        redon = cs + 2
        ec = 0.5 * 10 ^ (-cs)
        n = 100
        h = (b - a) / n
        err(i) = 1
        suma = 0
        For k = 0 To n - 1
            suma = suma + h * f(a + (k * h))
        Next k
        integral(i) = suma
        salida.Rows.Add(n, integral(i), err(i))

        Do While err(i) > ec
            n = n + 100
            i = i + 1
            h = (b - a) / n
            suma = 0
            For k = 0 To n - 1
                suma = suma + h * f(a + k * h)
            Next k
            integral(i) = suma
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop
    End Sub
End Class
