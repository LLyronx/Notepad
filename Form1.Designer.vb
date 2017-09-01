<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ControlPanel = New System.Windows.Forms.MenuStrip
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OtherSaveItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.UndoItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.CutItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.FindItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindNextItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReplaceItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GotoItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.SelectAllItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DateItem = New System.Windows.Forms.ToolStripMenuItem
        Me.格式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoWrapItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WatchMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.StateItem = New System.Windows.Forms.ToolStripMenuItem
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutItem = New System.Windows.Forms.ToolStripMenuItem
        Me.texts = New System.Windows.Forms.TextBox
        Me.StatusList = New System.Windows.Forms.StatusStrip
        Me.Blank = New System.Windows.Forms.ToolStripStatusLabel
        Me.FontDialog = New System.Windows.Forms.FontDialog
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument
        Me.ControlPanel.SuspendLayout()
        Me.StatusList.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.EditMenu, Me.格式ToolStripMenuItem, Me.WatchMenu, Me.帮助ToolStripMenuItem})
        Me.ControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(391, 24)
        Me.ControlPanel.TabIndex = 0
        Me.ControlPanel.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewItem, Me.OpenItem, Me.SaveItem, Me.OtherSaveItem, Me.ToolStripMenuItem1, Me.PrintItem, Me.ToolStripMenuItem2, Me.ExitItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.文件ToolStripMenuItem.Text = "文件(&F)"
        '
        'NewItem
        '
        Me.NewItem.Name = "NewItem"
        Me.NewItem.Size = New System.Drawing.Size(142, 22)
        Me.NewItem.Text = "新建(&N)"
        '
        'OpenItem
        '
        Me.OpenItem.Name = "OpenItem"
        Me.OpenItem.Size = New System.Drawing.Size(142, 22)
        Me.OpenItem.Text = "打开(&O)..."
        '
        'SaveItem
        '
        Me.SaveItem.Name = "SaveItem"
        Me.SaveItem.Size = New System.Drawing.Size(142, 22)
        Me.SaveItem.Text = "保存(&S)"
        '
        'OtherSaveItem
        '
        Me.OtherSaveItem.Name = "OtherSaveItem"
        Me.OtherSaveItem.Size = New System.Drawing.Size(142, 22)
        Me.OtherSaveItem.Text = "另存为(&A)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(139, 6)
        '
        'PrintItem
        '
        Me.PrintItem.Name = "PrintItem"
        Me.PrintItem.Size = New System.Drawing.Size(142, 22)
        Me.PrintItem.Text = "打印(&P)..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 6)
        '
        'ExitItem
        '
        Me.ExitItem.Name = "ExitItem"
        Me.ExitItem.Size = New System.Drawing.Size(142, 22)
        Me.ExitItem.Text = "退出(&X)"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoItem, Me.ToolStripMenuItem3, Me.CutItem, Me.CopyItem, Me.PasteItem, Me.DeleteItem, Me.ToolStripMenuItem4, Me.FindItem, Me.FindNextItem, Me.ReplaceItem, Me.GotoItem, Me.ToolStripMenuItem5, Me.SelectAllItem, Me.DateItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(59, 20)
        Me.EditMenu.Text = "编辑(&E)"
        '
        'UndoItem
        '
        Me.UndoItem.Name = "UndoItem"
        Me.UndoItem.Size = New System.Drawing.Size(148, 22)
        Me.UndoItem.Text = "撤销(&U)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(145, 6)
        '
        'CutItem
        '
        Me.CutItem.Name = "CutItem"
        Me.CutItem.Size = New System.Drawing.Size(148, 22)
        Me.CutItem.Text = "剪切(&T)"
        '
        'CopyItem
        '
        Me.CopyItem.Name = "CopyItem"
        Me.CopyItem.Size = New System.Drawing.Size(148, 22)
        Me.CopyItem.Text = "复制(&C)"
        '
        'PasteItem
        '
        Me.PasteItem.Name = "PasteItem"
        Me.PasteItem.Size = New System.Drawing.Size(148, 22)
        Me.PasteItem.Text = "粘贴(&P)"
        '
        'DeleteItem
        '
        Me.DeleteItem.Name = "DeleteItem"
        Me.DeleteItem.Size = New System.Drawing.Size(148, 22)
        Me.DeleteItem.Text = "删除(&L)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(145, 6)
        '
        'FindItem
        '
        Me.FindItem.Name = "FindItem"
        Me.FindItem.Size = New System.Drawing.Size(148, 22)
        Me.FindItem.Text = "查找(&F)..."
        '
        'FindNextItem
        '
        Me.FindNextItem.Name = "FindNextItem"
        Me.FindNextItem.Size = New System.Drawing.Size(148, 22)
        Me.FindNextItem.Text = "查找下一个(&N)"
        '
        'ReplaceItem
        '
        Me.ReplaceItem.Name = "ReplaceItem"
        Me.ReplaceItem.Size = New System.Drawing.Size(148, 22)
        Me.ReplaceItem.Text = "替换(&R)..."
        '
        'GotoItem
        '
        Me.GotoItem.Name = "GotoItem"
        Me.GotoItem.Size = New System.Drawing.Size(148, 22)
        Me.GotoItem.Text = "转到(&G)..."
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(145, 6)
        '
        'SelectAllItem
        '
        Me.SelectAllItem.Name = "SelectAllItem"
        Me.SelectAllItem.Size = New System.Drawing.Size(148, 22)
        Me.SelectAllItem.Text = "全选(&A)"
        '
        'DateItem
        '
        Me.DateItem.Name = "DateItem"
        Me.DateItem.Size = New System.Drawing.Size(148, 22)
        Me.DateItem.Text = "时间/日期(&D)"
        '
        '格式ToolStripMenuItem
        '
        Me.格式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoWrapItem, Me.FontItem})
        Me.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem"
        Me.格式ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.格式ToolStripMenuItem.Text = "格式(&O)"
        '
        'AutoWrapItem
        '
        Me.AutoWrapItem.CheckOnClick = True
        Me.AutoWrapItem.Name = "AutoWrapItem"
        Me.AutoWrapItem.Size = New System.Drawing.Size(136, 22)
        Me.AutoWrapItem.Text = "自动换行(&W)"
        '
        'FontItem
        '
        Me.FontItem.Name = "FontItem"
        Me.FontItem.Size = New System.Drawing.Size(136, 22)
        Me.FontItem.Text = "字体(&F)..."
        '
        'WatchMenu
        '
        Me.WatchMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StateItem})
        Me.WatchMenu.Name = "WatchMenu"
        Me.WatchMenu.Size = New System.Drawing.Size(59, 20)
        Me.WatchMenu.Text = "查看(&V)"
        '
        'StateItem
        '
        Me.StateItem.CheckOnClick = True
        Me.StateItem.Name = "StateItem"
        Me.StateItem.Size = New System.Drawing.Size(124, 22)
        Me.StateItem.Text = "状态栏(&V)"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpItem, Me.ToolStripMenuItem6, Me.AboutItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.帮助ToolStripMenuItem.Text = "帮助(&H)"
        '
        'HelpItem
        '
        Me.HelpItem.Name = "HelpItem"
        Me.HelpItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpItem.Text = "查看帮助(&H)"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(149, 6)
        '
        'AboutItem
        '
        Me.AboutItem.Name = "AboutItem"
        Me.AboutItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutItem.Text = "关于记事本(&A)"
        '
        'texts
        '
        Me.texts.Location = New System.Drawing.Point(0, 28)
        Me.texts.Multiline = True
        Me.texts.Name = "texts"
        Me.texts.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.texts.Size = New System.Drawing.Size(285, 235)
        Me.texts.TabIndex = 1
        Me.texts.WordWrap = False
        '
        'StatusList
        '
        Me.StatusList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Blank})
        Me.StatusList.Location = New System.Drawing.Point(0, 300)
        Me.StatusList.Name = "StatusList"
        Me.StatusList.Size = New System.Drawing.Size(391, 22)
        Me.StatusList.TabIndex = 2
        Me.StatusList.Text = "StatusStrip1"
        '
        'Blank
        '
        Me.Blank.Name = "Blank"
        Me.Blank.Size = New System.Drawing.Size(281, 17)
        Me.Blank.Text = "                                              "
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 322)
        Me.Controls.Add(Me.StatusList)
        Me.Controls.Add(Me.texts)
        Me.Controls.Add(Me.ControlPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ControlPanel
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        Me.StatusList.ResumeLayout(False)
        Me.StatusList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ControlPanel As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherSaveItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents texts As System.Windows.Forms.TextBox
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 格式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WatchMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StateItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusList As System.Windows.Forms.StatusStrip
    Friend WithEvents Blank As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AutoWrapItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents UndoItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindNextItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GotoItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument

End Class
