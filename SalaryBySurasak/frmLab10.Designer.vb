<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.lblSumA = New System.Windows.Forms.Label()
        Me.lblSumB = New System.Windows.Forms.Label()
        Me.lblSumC = New System.Windows.Forms.Label()
        Me.lblMaxSaleName = New System.Windows.Forms.Label()
        Me.lblMaxSaleAmount = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณยอดขายจากอาร์เรย์"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(223, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "รวมยอดขายสินค้า A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "รายการข้อมูล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "รวมยอดขายสินค้า B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "รวมยอดขายสินค้า C"
        '
        'lstData
        '
        Me.lstData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 20
        Me.lstData.Items.AddRange(New Object() {",0,0,0", ",0,0,0", ",0,0,0", ",0,0,0", ",0,0,0"})
        Me.lstData.Location = New System.Drawing.Point(31, 95)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(161, 164)
        Me.lstData.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ผู้ที่ทำยอดขายสูงสุด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(223, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "เป็นเงิน"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "พนักงานขายคนที่"
        '
        'cboIndex
        '
        Me.cboIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(34, 298)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(157, 28)
        Me.cboIndex.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "ชื่อพนักงานขาย"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(224, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 28)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "ยอดขาย A"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(315, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "ยอดขาย B"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(406, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 28)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "ยอดขาย C"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaleName
        '
        Me.txtSaleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleName.Location = New System.Drawing.Point(32, 386)
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(160, 26)
        Me.txtSaleName.TabIndex = 9
        '
        'txtSaleA
        '
        Me.txtSaleA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleA.Location = New System.Drawing.Point(228, 386)
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(80, 26)
        Me.txtSaleA.TabIndex = 9
        Me.txtSaleA.Text = "0"
        '
        'txtSaleB
        '
        Me.txtSaleB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleB.Location = New System.Drawing.Point(322, 386)
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(80, 26)
        Me.txtSaleB.TabIndex = 9
        Me.txtSaleB.Text = "0"
        '
        'txtSaleC
        '
        Me.txtSaleC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleC.Location = New System.Drawing.Point(416, 386)
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(80, 26)
        Me.txtSaleC.TabIndex = 9
        Me.txtSaleC.Text = "0"
        '
        'lblSumA
        '
        Me.lblSumA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSumA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumA.Location = New System.Drawing.Point(380, 95)
        Me.lblSumA.Name = "lblSumA"
        Me.lblSumA.Size = New System.Drawing.Size(130, 20)
        Me.lblSumA.TabIndex = 3
        '
        'lblSumB
        '
        Me.lblSumB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSumB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumB.Location = New System.Drawing.Point(380, 140)
        Me.lblSumB.Name = "lblSumB"
        Me.lblSumB.Size = New System.Drawing.Size(130, 20)
        Me.lblSumB.TabIndex = 3
        '
        'lblSumC
        '
        Me.lblSumC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSumC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumC.Location = New System.Drawing.Point(380, 187)
        Me.lblSumC.Name = "lblSumC"
        Me.lblSumC.Size = New System.Drawing.Size(130, 20)
        Me.lblSumC.TabIndex = 3
        '
        'lblMaxSaleName
        '
        Me.lblMaxSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMaxSaleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMaxSaleName.Location = New System.Drawing.Point(380, 266)
        Me.lblMaxSaleName.Name = "lblMaxSaleName"
        Me.lblMaxSaleName.Size = New System.Drawing.Size(130, 20)
        Me.lblMaxSaleName.TabIndex = 3
        '
        'lblMaxSaleAmount
        '
        Me.lblMaxSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMaxSaleAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMaxSaleAmount.Location = New System.Drawing.Point(380, 306)
        Me.lblMaxSaleAmount.Name = "lblMaxSaleAmount"
        Me.lblMaxSaleAmount.Size = New System.Drawing.Size(130, 20)
        Me.lblMaxSaleAmount.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAdd.Location = New System.Drawing.Point(448, 429)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 29)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmLab10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 463)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMaxSaleAmount)
        Me.Controls.Add(Me.lblMaxSaleName)
        Me.Controls.Add(Me.lblSumC)
        Me.Controls.Add(Me.lblSumB)
        Me.Controls.Add(Me.lblSumA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab10"
        Me.Text = "frmLab10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSaleName As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleA As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleB As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleC As System.Windows.Forms.TextBox
    Friend WithEvents lblSumA As System.Windows.Forms.Label
    Friend WithEvents lblSumB As System.Windows.Forms.Label
    Friend WithEvents lblSumC As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleName As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleAmount As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
