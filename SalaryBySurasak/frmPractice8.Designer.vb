<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice8
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYourSale = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblCommTotal = New System.Windows.Forms.Label()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขายรวม"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "พนง.ขาย ,  ยอดขาย,   คอมมิชชัน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ค่าคอมมิชชันรวม"
        '
        'lstData
        '
        Me.lstData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 20
        Me.lstData.Location = New System.Drawing.Point(16, 60)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(330, 204)
        Me.lstData.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(16, 270)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 26)
        Me.txtName.TabIndex = 4
        '
        'txtYourSale
        '
        Me.txtYourSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtYourSale.Location = New System.Drawing.Point(188, 270)
        Me.txtYourSale.Name = "txtYourSale"
        Me.txtYourSale.Size = New System.Drawing.Size(73, 26)
        Me.txtYourSale.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(267, 271)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 25)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblCommTotal
        '
        Me.lblCommTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCommTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommTotal.Location = New System.Drawing.Point(358, 186)
        Me.lblCommTotal.Name = "lblCommTotal"
        Me.lblCommTotal.Size = New System.Drawing.Size(116, 28)
        Me.lblCommTotal.TabIndex = 2
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaleTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaleTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSaleTotal.Location = New System.Drawing.Point(358, 111)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(116, 28)
        Me.lblSaleTotal.TabIndex = 2
        '
        'frmPractice8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 512)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtYourSale)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.lblSaleTotal)
        Me.Controls.Add(Me.lblCommTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice8"
        Me.Text = "frmPractice8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtYourSale As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblCommTotal As System.Windows.Forms.Label
    Friend WithEvents lblSaleTotal As System.Windows.Forms.Label
End Class
