Public Class frmJob4
    Dim datNowDate As Date = Date.Now
    Const decR_BONUS As Double = 0.2
    Const decR_ALLOW As Double = 0.01
    Const decR_Tax As Double = 0.07
    Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = datNowDate
    End Sub
    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_Tax

        lblYearSalary.Text = FormatNumber(dblYearSalary)
        lblBonus.Text = FormatNumber(dblBonus)
        lblAllIncome.Text = FormatNumber(dblAllIncome)
        lblAollowance.Text = FormatNumber(dblAllowance)
        lblTax.Text = FormatNumber(dblTax)
    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = datNowDate.ToShortDateString()
    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = datNowDate
    End Sub
    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = datNowDate.ToLongDateString()
    End Sub
End Class