<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GetNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FindBox = New System.Windows.Forms.TextBox()
        Me.CapGet = New System.Windows.Forms.CheckBox()
        Me.Range = New System.Windows.Forms.GroupBox()
        Me.SelectedBox = New System.Windows.Forms.RadioButton()
        Me.AllBox = New System.Windows.Forms.RadioButton()
        Me.CancelBox = New System.Windows.Forms.Button()
        Me.Range.SuspendLayout()
        Me.SuspendLayout()
        '
        'GetNext
        '
        Me.GetNext.Location = New System.Drawing.Point(249, 12)
        Me.GetNext.Name = "GetNext"
        Me.GetNext.Size = New System.Drawing.Size(102, 27)
        Me.GetNext.TabIndex = 0
        Me.GetNext.Text = "查找下一个"
        Me.GetNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "查找内容"
        '
        'FindBox
        '
        Me.FindBox.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FindBox.Location = New System.Drawing.Point(64, 36)
        Me.FindBox.Name = "FindBox"
        Me.FindBox.Size = New System.Drawing.Size(151, 26)
        Me.FindBox.TabIndex = 2
        '
        'CapGet
        '
        Me.CapGet.AutoSize = True
        Me.CapGet.Location = New System.Drawing.Point(7, 98)
        Me.CapGet.Name = "CapGet"
        Me.CapGet.Size = New System.Drawing.Size(84, 16)
        Me.CapGet.TabIndex = 3
        Me.CapGet.Text = "区分大小写"
        Me.CapGet.UseVisualStyleBackColor = True
        '
        'Range
        '
        Me.Range.Controls.Add(Me.SelectedBox)
        Me.Range.Controls.Add(Me.AllBox)
        Me.Range.Location = New System.Drawing.Point(106, 68)
        Me.Range.Name = "Range"
        Me.Range.Size = New System.Drawing.Size(245, 46)
        Me.Range.TabIndex = 4
        Me.Range.TabStop = False
        Me.Range.Text = "范围"
        '
        'SelectedBox
        '
        Me.SelectedBox.AutoSize = True
        Me.SelectedBox.Location = New System.Drawing.Point(125, 28)
        Me.SelectedBox.Name = "SelectedBox"
        Me.SelectedBox.Size = New System.Drawing.Size(83, 16)
        Me.SelectedBox.TabIndex = 0
        Me.SelectedBox.TabStop = True
        Me.SelectedBox.Text = "选中的部分"
        Me.SelectedBox.UseVisualStyleBackColor = True
        '
        'AllBox
        '
        Me.AllBox.AutoSize = True
        Me.AllBox.Checked = True
        Me.AllBox.Location = New System.Drawing.Point(12, 28)
        Me.AllBox.Name = "AllBox"
        Me.AllBox.Size = New System.Drawing.Size(47, 16)
        Me.AllBox.TabIndex = 0
        Me.AllBox.TabStop = True
        Me.AllBox.Text = "全部"
        Me.AllBox.UseVisualStyleBackColor = True
        '
        'CancelBox
        '
        Me.CancelBox.Location = New System.Drawing.Point(249, 45)
        Me.CancelBox.Name = "CancelBox"
        Me.CancelBox.Size = New System.Drawing.Size(102, 27)
        Me.CancelBox.TabIndex = 5
        Me.CancelBox.Text = "取消"
        Me.CancelBox.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 134)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelBox)
        Me.Controls.Add(Me.Range)
        Me.Controls.Add(Me.CapGet)
        Me.Controls.Add(Me.FindBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GetNext)
        Me.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Name = "Form2"
        Me.Text = "查找"
        Me.Range.ResumeLayout(False)
        Me.Range.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GetNext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FindBox As System.Windows.Forms.TextBox
    Friend WithEvents CapGet As System.Windows.Forms.CheckBox
    Friend WithEvents Range As System.Windows.Forms.GroupBox
    Friend WithEvents SelectedBox As System.Windows.Forms.RadioButton
    Friend WithEvents AllBox As System.Windows.Forms.RadioButton
    Friend WithEvents CancelBox As System.Windows.Forms.Button
End Class
