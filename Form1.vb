Public Class Form1

    Private Function ValidateInputC() As Boolean

        Dim intNumber As Decimal
        Dim blnValidC As Boolean = False
        Try
            intNumber = Convert.ToDecimal(txtCost.Text)
            If intNumber > 0D Then
                blnValidC = True
                Return blnValidC
            Else
                MsgBox("Please Enter a number greater than 0", , "Error")
            End If

        Catch ex As FormatException
            MsgBox("Please enter a valid amount", , "Error")

        Catch ex As OverflowException
            MsgBox("Please enter a reasonable amount", , "Error")

        Catch Exception As SystemException
            MsgBox("Entry Invalid. Please enter a valid number representing the number in your party", , "Error")

        End Try

        txtCost.Focus()
        txtCost.Clear()
        Return blnValidC
    End Function

    Private Function ValidateInputP() As Boolean

        Dim intNumber As Decimal
        Dim blnValidP As Boolean = False
        Try
            intNumber = Convert.ToDecimal(txtPrice.Text)
            If intNumber > 0D Then
                blnValidP = True
                Return blnValidP
            Else
                MsgBox("Please Enter a number greater than 0", , "Error")
            End If

        Catch ex As FormatException
            MsgBox("Please enter a valid amount", , "Error")

        Catch ex As OverflowException
            MsgBox("Please enter a reasonable amount", , "Error")

        Catch Exception As SystemException
            MsgBox("Entry Invalid. Please enter a valid number representing the number in your party", , "Error")

        End Try

        txtPrice.Focus()
        txtPrice.Clear()
        Return blnValidP
    End Function
    Private Function ComputeProfit(ByVal txtPrice As Decimal, ByVal txtCost As Decimal) As Decimal
        Dim profitAmount As Decimal
        profitAmount = (txtPrice - txtCost)

        Return profitAmount
    End Function

    Private Function ComputeProfitM(ByVal txtPrice As Integer, ByVal txtCost As Integer) As Decimal
        Dim profitMargin As Decimal
        profitMargin = (ComputeProfit(txtPrice, txtCost) / txtPrice) * 100

        Return profitMargin
    End Function

    Private Sub ClearForm()
        lblProfitHeader.Visible = False
        lblProfitMarginHeader.Visible = False
        lblProfit.Visible = False
        lblProfitM.Visible = False
        txtCost.Clear()
        txtPrice.Clear()
        txtCost.Focus()
        txtPrice.Focus()
    End Sub

    Private Sub btnClesr_Click(sender As Object, e As EventArgs) Handles btnClesr.Click
        ClearForm()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim blnAmountIsValidC As Boolean = False
        Dim blnAmountIsValidP As Boolean = False
        Dim intPrice As Decimal
        Dim intCost As Decimal
        Dim intProfit As Decimal
        Dim intProfitM As Decimal

        blnAmountIsValidC = ValidateInputC()
        blnAmountIsValidP = ValidateInputP()

        If blnAmountIsValidC = True And blnAmountIsValidP = True Then
            intCost = Convert.ToDecimal(txtCost.Text)
            intPrice = Convert.ToDecimal(txtPrice.Text)
            intProfit = ComputeProfit(intPrice, intCost)
            intProfitM = Math.Round(ComputeProfitM(intPrice, intCost))
        End If

        lblProfit.Text = intProfit.ToString("C")
        lblProfit.Visible = True
        lblProfitHeader.Visible = True

        lblProfitM.Text = intProfitM.ToString() & "%"
        lblProfitM.Visible = True
        lblProfitMarginHeader.Visible = True

    End Sub
End Class
