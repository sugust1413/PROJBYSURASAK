Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit, price, unit As Double
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        price = Val(txtPrice.Text)
        unit = Val(txtUnit.Text)
        decDiscount = 0
        If txtProduct.Text = "" Or price = 0 Or unit = 0 Or decTotal < 0 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If radMember.Checked = True And radPaid.Checked = True Then
                If lblTotal.Text < 1000 Then
                    decDiscount = 0
                ElseIf lblTotal.Text < 5000 Then
                    decDiscount = Val(lblTotal.Text) * 0.05
                ElseIf lblTotal.Text < 10000 Then
                    decDiscount = Val(lblTotal.Text) * 0.1
                Else
                    decDiscount = Val(lblTotal.Text) * 0.15
                End If
                decNet = decTotal - decDiscount
                decCredit = 0
            ElseIf radMember.Checked = True And radCredit.Checked = True Then
                decDiscount = 0
                decNet = 0
                decCredit = decTotal
            Else
                decNet = decTotal - decDiscount
                decCredit = 0
            End If
        End If
        lblDiscount.Text = FormatNumber(decDiscount)
        lblPaid.Text = FormatNumber(decNet)
        lblCredit.Text = FormatNumber(decCredit)
    End Sub
    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub
    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gpbPaid.Enabled = True
    End Sub
    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gpbPaid.Enabled = False
        radPaid.Checked = True
    End Sub
    Private Sub radPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub
    Private Sub radCredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCredit.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub
End Class