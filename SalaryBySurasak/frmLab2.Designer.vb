<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaleCom = New System.Windows.Forms.TextBox()
        Me.txtSalePrinter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.lblSaleCom = New System.Windows.Forms.Label()
        Me.lblSalePrinter = New System.Windows.Forms.Label()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.lblCommissionCom = New System.Windows.Forms.Label()
        Me.lblCommissionPrinter = New System.Windows.Forms.Label()
        Me.lblTotalCommission = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณยอดขายสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computer Acer Veriton x5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Printer HP M529DN"
        '
        'txtSaleCom
        '
        Me.txtSaleCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleCom.Location = New System.Drawing.Point(310, 69)
        Me.txtSaleCom.Name = "txtSaleCom"
        Me.txtSaleCom.Size = New System.Drawing.Size(160, 31)
        Me.txtSaleCom.TabIndex = 0
        '
        'txtSalePrinter
        '
        Me.txtSalePrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSalePrinter.Location = New System.Drawing.Point(310, 113)
        Me.txtSalePrinter.Name = "txtSalePrinter"
        Me.txtSalePrinter.Size = New System.Drawing.Size(160, 31)
        Me.txtSalePrinter.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(306, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ยอดขาย Computer Acer Veriton x5  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ยอดขาย Printer HP M529DN :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ค่าคอมมิชชั่น Printer HP M529DN :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(344, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "ค่าคอมมิชชั่น Computer Acer Veriton x5  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ยอดขายรวม :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 24)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ค่าคอมมิชชั่นรวม :"
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSum.ForeColor = System.Drawing.Color.Red
        Me.btnSum.Location = New System.Drawing.Point(310, 150)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(160, 60)
        Me.btnSum.TabIndex = 4
        Me.btnSum.Text = "คำนวณ"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'lblSaleCom
        '
        Me.lblSaleCom.AutoSize = True
        Me.lblSaleCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSaleCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSaleCom.Location = New System.Drawing.Point(403, 226)
        Me.lblSaleCom.Name = "lblSaleCom"
        Me.lblSaleCom.Size = New System.Drawing.Size(155, 24)
        Me.lblSaleCom.TabIndex = 5
        Me.lblSaleCom.Text = "                             "
        '
        'lblSalePrinter
        '
        Me.lblSalePrinter.AutoSize = True
        Me.lblSalePrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSalePrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSalePrinter.Location = New System.Drawing.Point(403, 265)
        Me.lblSalePrinter.Name = "lblSalePrinter"
        Me.lblSalePrinter.Size = New System.Drawing.Size(155, 24)
        Me.lblSalePrinter.TabIndex = 5
        Me.lblSalePrinter.Text = "                             "
        '
        'lblTotalSale
        '
        Me.lblTotalSale.AutoSize = True
        Me.lblTotalSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalSale.Location = New System.Drawing.Point(403, 300)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(155, 24)
        Me.lblTotalSale.TabIndex = 5
        Me.lblTotalSale.Text = "                             "
        '
        'lblCommissionCom
        '
        Me.lblCommissionCom.AutoSize = True
        Me.lblCommissionCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCommissionCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommissionCom.Location = New System.Drawing.Point(403, 336)
        Me.lblCommissionCom.Name = "lblCommissionCom"
        Me.lblCommissionCom.Size = New System.Drawing.Size(155, 24)
        Me.lblCommissionCom.TabIndex = 5
        Me.lblCommissionCom.Text = "                             "
        '
        'lblCommissionPrinter
        '
        Me.lblCommissionPrinter.AutoSize = True
        Me.lblCommissionPrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCommissionPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommissionPrinter.Location = New System.Drawing.Point(403, 371)
        Me.lblCommissionPrinter.Name = "lblCommissionPrinter"
        Me.lblCommissionPrinter.Size = New System.Drawing.Size(155, 24)
        Me.lblCommissionPrinter.TabIndex = 5
        Me.lblCommissionPrinter.Text = "                             "
        '
        'lblTotalCommission
        '
        Me.lblTotalCommission.AutoSize = True
        Me.lblTotalCommission.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalCommission.Location = New System.Drawing.Point(403, 408)
        Me.lblTotalCommission.Name = "lblTotalCommission"
        Me.lblTotalCommission.Size = New System.Drawing.Size(155, 24)
        Me.lblTotalCommission.TabIndex = 5
        Me.lblTotalCommission.Text = "                             "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(487, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "บาท"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(487, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 25)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "บาท"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(302, 439)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(230, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Project By Surasak Pongtanee Bis2N1  RMUTI"
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 461)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTotalCommission)
        Me.Controls.Add(Me.lblCommissionPrinter)
        Me.Controls.Add(Me.lblCommissionCom)
        Me.Controls.Add(Me.lblTotalSale)
        Me.Controls.Add(Me.lblSalePrinter)
        Me.Controls.Add(Me.lblSaleCom)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSalePrinter)
        Me.Controls.Add(Me.txtSaleCom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab2"
        Me.Text = "frmLab2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSaleCom As System.Windows.Forms.TextBox
    Friend WithEvents txtSalePrinter As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents lblSaleCom As System.Windows.Forms.Label
    Friend WithEvents lblSalePrinter As System.Windows.Forms.Label
    Friend WithEvents lblTotalSale As System.Windows.Forms.Label
    Friend WithEvents lblCommissionCom As System.Windows.Forms.Label
    Friend WithEvents lblCommissionPrinter As System.Windows.Forms.Label
    Friend WithEvents lblTotalCommission As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
