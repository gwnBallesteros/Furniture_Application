'Name of The Program       Sales Calculator Furniture Application
'Developer                 G.T. Ballesteros
'Date                      June 24, 2022
'Purpose                   Calculate and Display the Sales Tax and Total due amounts.

Option Strict On
Public Class frmFurnitureApplication

    Const _cdecTaxRate = 0.05D
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intSales As Integer
        Dim decTax As Decimal
        Dim decTotalSales As Decimal

        'Calculate the Tax
        Integer.TryParse(TxtSales.Text, intSales)
        decTax = intSales * _cdecTaxRate
        lblTax.Text = decTax.ToString("C2")

        'Calculate the Total Due Amount
        decTotalSales = intSales + decTax
        lblTotal.Text = decTotalSales.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TxtSales.Clear()
        lblTax.Text = ""
        lblTotal.Text = ""
        TxtSales.Focus()
    End Sub

    Private Sub frmFurnitureApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTaxRate.Text = "5% Tax Rate"
        lblTax.Text = ""
        lblTotal.Text = ""
        TxtSales.Focus()
    End Sub

    Private Sub TxtSales_TextChanged(sender As Object, e As EventArgs) Handles TxtSales.TextChanged

    End Sub
End Class
