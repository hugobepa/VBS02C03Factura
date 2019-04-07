Public Class Form1
    Private Sub BTNFactura_Click(sender As Object, e As EventArgs) Handles BTNFactura.Click
        Dim horas, piezas, total As Double
        Dim cliente As String

        LSTFactura.Items.Clear()
        If IsNumeric(TXTHoras.Text) And IsNumeric(TXTPartes.Text) And TXTCliente.Text <> "" Then
            horas = CDbl(TXTHoras.Text.Trim)
            piezas = CDbl(TXTPartes.Text.Trim)
            cliente = TXTCliente.Text.TrimEnd

            Dim manoObra As Double = horas * 35
            Dim costePiezas As Double = piezas + (piezas * 0.05)
            total = manoObra + costePiezas

            LSTFactura.Items.Add("Customer: " & cliente)
            LSTFactura.Items.Add("mano de obra: " & FormatCurrency(manoObra))
            LSTFactura.Items.Add("Coste piezas: " & FormatCurrency(costePiezas))
            LSTFactura.Items.Add("Total; " & FormatCurrency(total))

        Else
            MessageBox.Show("campos vacios")

        End If
    End Sub
End Class
