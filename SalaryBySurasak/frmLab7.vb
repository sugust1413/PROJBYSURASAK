Public Class frmLab7
    Dim i As Integer
    Private Sub frmLab7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub
    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text <> "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        LstAdd.Items.Add(txtAdd.Text)
        LstAdd.SelectedIndex = 0
        LstAdd.SelectedIndex = LstAdd.Items.Count - 1
        txtAdd.Clear()
    End Sub
    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Dim n1 As Integer = LstAdd.SelectedIndex
        Dim n2 As Integer
        If LstAdd.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Listbox")
        Else
            cboOutput.Items.Add(LstAdd.SelectedItem)
            n2 = cboOutput.Items.Count
            cboOutput.SelectedIndex = n2 - 1
            LstAdd.Items.RemoveAt(n1)
            If LstAdd.Items.Count <= n1 Then
                LstAdd.SelectedIndex = LstAdd.Items.Count - 1
            Else
                LstAdd.SelectedIndex = n1
            End If
        End If
    End Sub
    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click

        If LstAdd.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Listbox")

        Else
            For i As Integer = 0 To LstAdd.Items.Count - 1
                cboOutput.Items.Add(LstAdd.Items(i))
            Next
            LstAdd.Items.Clear()
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If

    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If cboOutput.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Combobox")
        Else
            LstAdd.Items.Add(cboOutput.SelectedItem)
            cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
            LstAdd.SelectedIndex = LstAdd.Items.Count - 1
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If cboOutput.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Combobox")
        Else
            For i As Integer = 0 To cboOutput.Items.Count - 1
                LstAdd.Items.Add(cboOutput.Items(i))
            Next
            cboOutput.Items.Clear()
            LstAdd.SelectedIndex = (LstAdd.Items.Count - 1)
        End If
    End Sub
    Private Sub cboOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        LstAdd.Items.Clear()
        cboOutput.Items.Clear()
        txtAdd.Clear()
        lblOutput.Text = ""
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class