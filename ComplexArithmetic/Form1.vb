Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Price As Decimal
        Dim Quantity As Decimal
        Dim Discount As Decimal
        Dim VAT As Decimal
        Dim TotalPrice As Decimal
        Dim TotalVAT As Decimal


        Price = 10
        Discount = 2
        Quantity = 10
        VAT = 0.15
        TotalPrice = ((Price - Discount) * Quantity)
        MsgBox("The total price without VAT is " & TotalPrice)

        TotalVAT = ((Price - Discount) * Quantity) * VAT + ((Price - Discount) * Quantity)
        MsgBox("The total price with VAT is " & TotalVAT)
    End Sub
End Class
