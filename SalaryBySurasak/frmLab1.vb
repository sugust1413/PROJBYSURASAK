Public Class frmLab1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblYearIncome.Text = Val(txtSalary.Text) * 12
        lblTax.Text = Val(lblYearIncome.Text) * 0.05
        lblBalance.Text = Val(lblYearIncome.Text) - Val(lblTax.Text)
    End Sub
End Class
