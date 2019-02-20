<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice10
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(65, 86)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(141, 147)
        Me.lstData.TabIndex = 0
        '
        'lblAvg
        '
        Me.lblAvg.Location = New System.Drawing.Point(283, 118)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(197, 115)
        Me.lblAvg.TabIndex = 1
        Me.lblAvg.Text = "Label1"
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(65, 278)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(202, 21)
        Me.cboIndex.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(317, 278)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(152, 20)
        Me.txtInput.TabIndex = 3
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(516, 274)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(63, 34)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Button1"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmPractice10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 427)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmPractice10"
        Me.Text = "frmPractice10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents lblAvg As System.Windows.Forms.Label
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
