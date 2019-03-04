<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab12
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
        Me.DgvEmp = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtEmpLName = New System.Windows.Forms.TextBox()
        Me.txtEmpAdress = New System.Windows.Forms.TextBox()
        Me.txtEmpSalary = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panEmp = New System.Windows.Forms.Panel()
        Me.panDgv = New System.Windows.Forms.Panel()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panEmp.SuspendLayout()
        Me.panDgv.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมจัดการข้อมูลพนักงาน"
        '
        'DgvEmp
        '
        Me.DgvEmp.AllowUserToAddRows = False
        Me.DgvEmp.AllowUserToDeleteRows = False
        Me.DgvEmp.AllowUserToResizeColumns = False
        Me.DgvEmp.AllowUserToResizeRows = False
        Me.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmp.Location = New System.Drawing.Point(75, 14)
        Me.DgvEmp.Name = "DgvEmp"
        Me.DgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmp.Size = New System.Drawing.Size(540, 312)
        Me.DgvEmp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รหัสพนักงาน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ที่อยู่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เงินเดือน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(227, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ชื่อพนักงาน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "แผนก"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(470, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "นามสกุล"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(470, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "เพศ"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(532, 55)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(51, 24)
        Me.radMale.TabIndex = 1
        Me.radMale.TabStop = True
        Me.radMale.Text = "ชาย"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.Location = New System.Drawing.Point(601, 55)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(55, 24)
        Me.radFemale.TabIndex = 1
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "หญิง"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'cboDepart
        '
        Me.cboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Location = New System.Drawing.Point(278, 94)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(226, 21)
        Me.cboDepart.TabIndex = 2
        '
        'txtEmpId
        '
        Me.txtEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpId.Location = New System.Drawing.Point(96, 10)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(125, 26)
        Me.txtEmpId.TabIndex = 3
        '
        'txtEmpName
        '
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(310, 10)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(125, 26)
        Me.txtEmpName.TabIndex = 3
        '
        'txtEmpLName
        '
        Me.txtEmpLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpLName.Location = New System.Drawing.Point(541, 10)
        Me.txtEmpLName.Name = "txtEmpLName"
        Me.txtEmpLName.Size = New System.Drawing.Size(125, 26)
        Me.txtEmpLName.TabIndex = 3
        '
        'txtEmpAdress
        '
        Me.txtEmpAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpAdress.Location = New System.Drawing.Point(96, 49)
        Me.txtEmpAdress.Name = "txtEmpAdress"
        Me.txtEmpAdress.Size = New System.Drawing.Size(368, 26)
        Me.txtEmpAdress.TabIndex = 3
        '
        'txtEmpSalary
        '
        Me.txtEmpSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpSalary.Location = New System.Drawing.Point(96, 86)
        Me.txtEmpSalary.Name = "txtEmpSalary"
        Me.txtEmpSalary.Size = New System.Drawing.Size(125, 26)
        Me.txtEmpSalary.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(510, 94)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(591, 94)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(77, 530)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(130, 38)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Text = "เพิ่ม"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(230, 530)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 38)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "แก้ไข"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(388, 530)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 38)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(542, 530)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 38)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "ออก"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panEmp
        '
        Me.panEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panEmp.Controls.Add(Me.Label3)
        Me.panEmp.Controls.Add(Me.txtEmpLName)
        Me.panEmp.Controls.Add(Me.Label2)
        Me.panEmp.Controls.Add(Me.btnCancel)
        Me.panEmp.Controls.Add(Me.Label5)
        Me.panEmp.Controls.Add(Me.btnSave)
        Me.panEmp.Controls.Add(Me.Label6)
        Me.panEmp.Controls.Add(Me.cboDepart)
        Me.panEmp.Controls.Add(Me.txtEmpAdress)
        Me.panEmp.Controls.Add(Me.Label7)
        Me.panEmp.Controls.Add(Me.txtEmpName)
        Me.panEmp.Controls.Add(Me.Label8)
        Me.panEmp.Controls.Add(Me.txtEmpSalary)
        Me.panEmp.Controls.Add(Me.Label4)
        Me.panEmp.Controls.Add(Me.txtEmpId)
        Me.panEmp.Controls.Add(Me.radMale)
        Me.panEmp.Controls.Add(Me.radFemale)
        Me.panEmp.Enabled = False
        Me.panEmp.Location = New System.Drawing.Point(26, 373)
        Me.panEmp.Name = "panEmp"
        Me.panEmp.Size = New System.Drawing.Size(689, 134)
        Me.panEmp.TabIndex = 4
        '
        'panDgv
        '
        Me.panDgv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panDgv.Controls.Add(Me.DgvEmp)
        Me.panDgv.Location = New System.Drawing.Point(28, 37)
        Me.panDgv.Name = "panDgv"
        Me.panDgv.Size = New System.Drawing.Size(687, 340)
        Me.panDgv.TabIndex = 5
        '
        'frmLab12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 590)
        Me.Controls.Add(Me.panDgv)
        Me.Controls.Add(Me.panEmp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab12"
        Me.Text = "frmLab12"
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panEmp.ResumeLayout(False)
        Me.panEmp.PerformLayout()
        Me.panDgv.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvEmp As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents cboDepart As System.Windows.Forms.ComboBox
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtEmpLName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAdress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpSalary As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents panEmp As System.Windows.Forms.Panel
    Friend WithEvents panDgv As System.Windows.Forms.Panel
End Class
