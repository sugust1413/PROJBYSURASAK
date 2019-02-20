<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice11
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
        Me.dgvInformation = New System.Windows.Forms.DataGridView()
        Me.lblProId = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.lblUnitInStock = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมแสดงรายชื่อสินค้า"
        '
        'dgvInformation
        '
        Me.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformation.Location = New System.Drawing.Point(36, 73)
        Me.dgvInformation.Name = "dgvInformation"
        Me.dgvInformation.Size = New System.Drawing.Size(629, 311)
        Me.dgvInformation.TabIndex = 1
        '
        'lblProId
        '
        Me.lblProId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblProId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProId.Location = New System.Drawing.Point(41, 400)
        Me.lblProId.Name = "lblProId"
        Me.lblProId.Size = New System.Drawing.Size(99, 30)
        Me.lblProId.TabIndex = 2
        '
        'lblProName
        '
        Me.lblProName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProName.Location = New System.Drawing.Point(146, 400)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(192, 30)
        Me.lblProName.TabIndex = 2
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnitPrice.Location = New System.Drawing.Point(344, 400)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(99, 30)
        Me.lblUnitPrice.TabIndex = 2
        '
        'lblUnitInStock
        '
        Me.lblUnitInStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUnitInStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnitInStock.Location = New System.Drawing.Point(454, 400)
        Me.lblUnitInStock.Name = "lblUnitInStock"
        Me.lblUnitInStock.Size = New System.Drawing.Size(99, 30)
        Me.lblUnitInStock.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(566, 400)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 30)
        Me.lblTotal.TabIndex = 2
        '
        'frmPractice11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 450)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblUnitInStock)
        Me.Controls.Add(Me.lblUnitPrice)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblProId)
        Me.Controls.Add(Me.dgvInformation)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice11"
        Me.Text = "frmPractice11"
        CType(Me.dgvInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvInformation As System.Windows.Forms.DataGridView
    Friend WithEvents lblProId As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents lblUnitInStock As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
