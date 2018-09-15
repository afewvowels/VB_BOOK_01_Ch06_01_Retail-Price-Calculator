' Author: Keith Smith
' Date: 15 September 2018

Option Explicit On
Option Strict On

Public Class RetailPriceCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Temp variable for TryParse method
        Dim decTemp As Decimal

        ' Main logic, contains data validation checks
        ' #1. Check that neither tbxWholesaleCost nor tbxMarkup has been left blank
        If tbxWholesaleCost.Text Is String.Empty Or tbxMarkup.Text Is String.Empty Then
            MessageBox.Show("Please fill out all data entry forms",
                            "Missing Data Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            ' #2. Check that tbxWholesaleCost contains a numeric value
        ElseIf Not Decimal.TryParse(tbxWholesaleCost.Text, decTemp) Then
            MessageBox.Show("Please use a number for the wholesale cost",
                "Improperly Formatted Data Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            ' #3. Check that tbxMarkup.Text contains a numeric value
        ElseIf Not Decimal.TryParse(tbxMarkup.Text, decTemp) Then
            MessageBox.Show("Please use a number for the retail markup",
                "Improperly Formatted Data Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            ' #4. If all checks have been passed, then pass the entered
            '     data on to the function and place the return value in
            '     tbxRetail textbox
        Else
            tbxRetail.Text = CalculateRetail(Decimal.Parse(tbxWholesaleCost.Text),
                                        Decimal.Parse(tbxMarkup.Text))
        End If
    End Sub
    ' This function takes in a wholesale cost decimal and a markup percentage decimal
    ' and returns a formatted string value representing the retail cost:
    ' RetailPrice = (WholesaleCost + (WholesaleCost * (Markup / 100))
    Private Function CalculateRetail(ByVal decWholesaleCost As Decimal, ByVal decMarkupPercent As Decimal)
        Return (decWholesaleCost * (decMarkupPercent / 100D) + decWholesaleCost).ToString("c")
    End Function
End Class
