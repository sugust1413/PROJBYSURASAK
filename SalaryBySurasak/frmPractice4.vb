﻿Public Class frmPractice4
    Const decDISCOUNT_RATE As Double = 0.05
    Dim strId, strName As String
    Dim intAmount As Integer
    Dim dblPrice, dblTotal, dblDiscount, dblNet As Double
    Private Sub frmPractice4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strId = "P001"
        strName = "Computer"
        dblPrice = 55000
        lblProId.Text = strId
        lblProName.Text = strName
        lblProPrice.Text = dblPrice
    End Sub

    Private Sub txtProAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProAmount.TextChanged
        lblProTotal.Text = Val(txtProAmount.Text) * dblPrice
        radProCash.Checked = True
        Call radProCash_Click(sender, e)
    End Sub

   
    Private Sub radProCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radProCash.Click
        dblDiscount = Val(lblProTotal.Text) * decDISCOUNT_RATE
        lblProNet.Text = Val(lblProTotal.Text) - dblDiscount
    End Sub

    Private Sub radProCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radProCredit.Click
        lblProNet.Text = lblProTotal.Text
    End Sub
End Class