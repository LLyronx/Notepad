<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.desc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.source = New System.Windows.Forms.TextBox
        Me.Rep = New System.Windows.Forms.Button
        Me.FindNext = New System.Windows.Forms.Button
        Me.RepAll = New System.Windows.Forms.Button
        Me.CapGet = New System.Windows.Forms.CheckBox
        Me.Cancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "查找内容："
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(32, 115)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(237, 21)
        Me.desc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "替换为："
        '
        'source
        '
        Me.source.Location = New System.Drawing.Point(32, 49)
        Me.source.Name = "source"
        Me.source.Size = New System.Drawing.Size(237, 21)
        Me.source.TabIndex = 1
        '
        'Rep
        '
        Me.Rep.Location = New System.Drawing.Point(113, 206)
        Me.Rep.Name = "Rep"
        Me.Rep.Size = New System.Drawing.Size(75, 23)
        Me.Rep.TabIndex = 2
        Me.Rep.Text = "替换"
        Me.Rep.UseVisualStyleBackColor = True
        '
        'FindNext
        '
        Me.FindNext.Location = New System.Drawing.Point(32, 206)
        Me.FindNext.Name = "FindNext"
        Me.FindNext.Size = New System.Drawing.Size(75, 23)
        Me.FindNext.TabIndex = 3
        Me.FindNext.Text = "查找下一个"
        Me.FindNext.UseVisualStyleBackColor = True
        '
        'RepAll
        '
        Me.RepAll.Location = New System.Drawing.Point(194, 206)
        Me.RepAll.Name = "RepAll"
        Me.RepAll.Size = New System.Drawing.Size(75, 23)
        Me.RepAll.TabIndex = 2
        Me.RepAll.Text = "全部替换"
        Me.RepAll.UseVisualStyleBackColor = True
        '
        'CapGet
        '
        Me.CapGet.AutoSize = True
        Me.CapGet.Location = New System.Drawing.Point(32, 168)
        Me.CapGet.Name = "CapGet"
        Me.CapGet.Size = New System.Drawing.Size(84, 16)
        Me.CapGet.TabIndex = 4
        Me.CapGet.Text = "区分大小写"
        Me.CapGet.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(194, 164)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "取消"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.CapGet)
        Me.Controls.Add(Me.FindNext)
        Me.Controls.Add(Me.RepAll)
        Me.Controls.Add(Me.Rep)
        Me.Controls.Add(Me.source)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "替换"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents desc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents source As System.Windows.Forms.TextBox
    Friend WithEvents Rep As System.Windows.Forms.Button
    Friend WithEvents FindNext As System.Windows.Forms.Button
    Friend WithEvents RepAll As System.Windows.Forms.Button
    Friend WithEvents CapGet As System.Windows.Forms.CheckBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
