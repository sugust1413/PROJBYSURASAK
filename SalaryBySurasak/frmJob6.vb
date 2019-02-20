Public Class frmJob6
    Dim car As Double = 1250000
    Dim total As Double = car
    Private Sub chkCarForMe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.CheckedChanged
        If chkCarForMe.Checked = True Then
            gpb1.Enabled = True
            gpb2.Enabled = True
            lblStartPrice.Text = car
            lblPaidPrice.Text = total
        Else
            If MsgBox("ต้องการยกเลิกซื้อรถใช่หรือไม่?", vbYesNo, "ตอบ YES หรือ No") = vbNo Then
                chkCarForMe.Checked = True
            Else
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                lblPaidPrice.Text = ""
                gpb1.Enabled = False
                gpb2.Enabled = False
            End If
        End If
    End Sub
    Private Sub frmJob6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gpb1.Enabled = False
        gpb2.Enabled = False
        lblItemsPrice1.Text = 40000
        lblItemsPrice2.Text = 50000
        lblItemsPrice3.Text = 20000
        lblItemsPrice4.Text = 30000
        lblStartPrice.Text = car
        lblFree1.Text = 25000
        lblFree2.Text = 15000
        lblFree3.Text = 35000
        total = total + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked = True Then
            total = total - Val(lblFree1.Text)
            lblPaidPrice.Text = total
        Else
            total = total + Val(lblFree1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked = True Then
            total = total - Val(lblFree2.Text)
            lblPaidPrice.Text = total
        Else
            total = total + Val(lblFree2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked = True Then
            total = total - Val(lblFree3.Text)
            lblPaidPrice.Text = total
        Else
            total = total + Val(lblFree3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            total = total + Val(lblItemsPrice1.Text)
            lblPaidPrice.Text = total
        Else
            total = total - Val(lblItemsPrice1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked = True Then
            total = total + Val(lblItemsPrice2.Text)
            lblPaidPrice.Text = total
        Else
            total = total - Val(lblItemsPrice2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked = True Then
            total = total + Val(lblItemsPrice3.Text)
            lblPaidPrice.Text = total
        Else
            total = total - Val(lblItemsPrice3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then
            total = total + Val(lblItemsPrice4.Text)
            lblPaidPrice.Text = total
        Else
            total = total - Val(lblItemsPrice4.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
End Class