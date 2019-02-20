<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice2
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
        Me.txtBaht = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLock = New System.Windows.Forms.RadioButton()
        Me.radUnLock = New System.Windows.Forms.RadioButton()
        Me.radUs = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radKorea = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณอัตราแลกเปลี่ยน"
        '
        'txtBaht
        '
        Me.txtBaht.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBaht.Location = New System.Drawing.Point(103, 66)
        Me.txtBaht.Name = "txtBaht"
        Me.txtBaht.Size = New System.Drawing.Size(189, 49)
        Me.txtBaht.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "เงินไทย"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "แลกได้"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblResult.Location = New System.Drawing.Point(103, 277)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(189, 64)
        Me.lblResult.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.Location = New System.Drawing.Point(318, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 63)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "ปิด"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUnLock)
        Me.GroupBox1.Controls.Add(Me.radLock)
        Me.GroupBox1.Location = New System.Drawing.Point(318, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ควบคุม"
        '
        'radLock
        '
        Me.radLock.AutoSize = True
        Me.radLock.Location = New System.Drawing.Point(6, 30)
        Me.radLock.Name = "radLock"
        Me.radLock.Size = New System.Drawing.Size(49, 17)
        Me.radLock.TabIndex = 0
        Me.radLock.TabStop = True
        Me.radLock.Text = "Lock"
        Me.radLock.UseVisualStyleBackColor = True
        '
        'radUnLock
        '
        Me.radUnLock.AutoSize = True
        Me.radUnLock.Location = New System.Drawing.Point(6, 65)
        Me.radUnLock.Name = "radUnLock"
        Me.radUnLock.Size = New System.Drawing.Size(63, 17)
        Me.radUnLock.TabIndex = 0
        Me.radUnLock.TabStop = True
        Me.radUnLock.Text = "UnLock"
        Me.radUnLock.UseVisualStyleBackColor = True
        '
        'radUs
        '
        Me.radUs.AutoSize = True
        Me.radUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radUs.Location = New System.Drawing.Point(142, 147)
        Me.radUs.Name = "radUs"
        Me.radUs.Size = New System.Drawing.Size(73, 22)
        Me.radUs.TabIndex = 0
        Me.radUs.TabStop = True
        Me.radUs.Text = "US(39)"
        Me.radUs.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radFrench.Location = New System.Drawing.Point(142, 189)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(98, 22)
        Me.radFrench.TabIndex = 1
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French(37)"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radKorea
        '
        Me.radKorea.AutoSize = True
        Me.radKorea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radKorea.Location = New System.Drawing.Point(142, 234)
        Me.radKorea.Name = "radKorea"
        Me.radKorea.Size = New System.Drawing.Size(92, 22)
        Me.radKorea.TabIndex = 2
        Me.radKorea.TabStop = True
        Me.radKorea.Text = "Korea(30)"
        Me.radKorea.UseVisualStyleBackColor = True
        '
        'frmPractice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 376)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.radKorea)
        Me.Controls.Add(Me.radFrench)
        Me.Controls.Add(Me.radUs)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBaht)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แบบฝึกปฏิบัติสัปดาห์ที่ 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBaht As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radUnLock As System.Windows.Forms.RadioButton
    Friend WithEvents radLock As System.Windows.Forms.RadioButton
    Friend WithEvents radUs As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radKorea As System.Windows.Forms.RadioButton
End Class
