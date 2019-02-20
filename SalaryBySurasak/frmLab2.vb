Public Class frmLab2
    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        Dim SaleComputer As Double
        Dim SalePrinter As Double
        Dim TotalSale As Double
        Dim CommissionCom As Double
        Dim CommissionPrinter As Double
        Dim TotalCommission As Double

        SaleComputer = Val(txtSaleCom.Text)
        SalePrinter = Val(txtSalePrinter.Text)
        TotalSale = SaleComputer + SalePrinter
        CommissionCom = SaleComputer * 0.05
        CommissionPrinter = SalePrinter * 0.1
        TotalCommission = CommissionCom + CommissionPrinter

        lblSaleCom.Text = SaleComputer.ToString + " บาท "
        lblSalePrinter.Text = SalePrinter.ToString + " บาท"
        lblTotalSale.Text = TotalSale.ToString + " บาท"
        lblCommissionCom.Text = CommissionCom.ToString + " บาท"
        lblCommissionPrinter.Text = CommissionPrinter.ToString + " บาท"
        lblTotalCommission.Text = TotalCommission.ToString + " บาท"
    End Sub
End Class