Public Class Form1
    Public savedfinding As String = ""

    Dim hasSaved As Boolean = True
    Dim neverSaved As Boolean = True
    Dim filetitle As String = "无标题"
    Dim filename As String = "无标题"
    Public Const programname As String = "记事本"
    Dim updistance As Integer = 65
    Dim leftdistance As Integer = 15

    Dim cliped As String
    Dim lastdo As String = ""
    Dim laststate As Integer = 1
    Dim lastundosave As String = ""

    Dim nowfont As Font

    Private Sub updatestatuslist()
        If StateItem.Checked = True Then
            StatusList.Visible = True
            updistance = 87
        Else
            StatusList.Visible = False
            updistance = 65
        End If
        texts.Width = Me.Width - leftdistance
        texts.Height = Me.Height - updistance
        Blank.Text = "第" + Str(texts.GetLineFromCharIndex(texts.GetFirstCharIndexOfCurrentLine()) + 1) + " 行，第" + Str(texts.SelectionStart - texts.GetFirstCharIndexOfCurrentLine() + 1) + " 列"
    End Sub

    Private Sub updateall()
        updatestatuslist()
        OpenFileDialog.FileName = ""
        SaveFileDialog.FileName = filetitle
        Me.Text = filetitle + " - " + programname

        If texts.SelectedText = "" Then
            CutItem.Enabled = False
            CopyItem.Enabled = False
            DeleteItem.Enabled = False
        Else
            CutItem.Enabled = True
            CopyItem.Enabled = True
            DeleteItem.Enabled = True
        End If
        If AutoWrapItem.Checked = False Then
            GotoItem.Enabled = True
        Else
            GotoItem.Enabled = False
        End If
        If texts.Text = "" Then
            FindItem.Enabled = False
            FindNextItem.Enabled = False
        Else
            FindItem.Enabled = True
            FindNextItem.Enabled = True
        End If
        If texts.WordWrap = False Then
            StateItem.Enabled = True
        Else
            StateItem.Enabled = False
            StateItem.Checked = False
        End If
    End Sub

    Private Function AskIfSave() As Boolean
        Dim temp As Integer
        temp = MsgBox("文件" + filetitle + "已更改，是否保存？", 48 + 3, programname)
        If temp = 6 Then
            If neverSaved = True Then
                If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    filename = SaveFileDialog.FileName
                    filetitle = Split(filename, "\")(UBound(Split(filename, "\")))
                    savefile()
                Else
                    Return False
                End If
            Else
                savefile()
            End If
            Return True
        ElseIf temp = 7 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub savefile()
        Dim filenum As Integer = FreeFile()
        FileOpen(filenum, filename, OpenMode.Output)
        Print(filenum, texts.Text)
        FileClose(filenum)
        neverSaved = False
        hasSaved = True
        updateall()
    End Sub
    Private Sub openfile()
        Dim filenum As Integer = FreeFile()
        FileOpen(filenum, filename, OpenMode.Input)
        texts.Text = ""
        Do While Not EOF(filenum)
            texts.Text += LineInput(filenum) + vbCrLf
        Loop
        FileClose(filenum)
        neverSaved = False
        updateall()
        laststate = 0
    End Sub

    Public Sub New()
        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        StatusList.Visible = False
        Me.KeyPreview = True

        OpenFileDialog.Multiselect = False
        OpenFileDialog.Filter = "Document files(*.txt) | *.txt|Configure files(*.inf *.ini)|*.inf;*.ini|All Files(*.*)|*.*"

        SaveFileDialog.Filter = "Document files(*.txt) | *.txt|Configure files(*.inf *.ini)|*.inf;*.ini|All Files(*.*)|*.*"

        updateall()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If hasSaved = False Then
            If AskIfSave() = False Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        updateall()
    End Sub

    Private Sub ControlPanel_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ControlPanel.MouseClick
        updateall()
    End Sub

    Private Sub ControlPanel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ControlPanel.MouseMove
        updateall()
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        texts.Width = Me.Width - leftdistance
        texts.Height = Me.Height - updistance
    End Sub

    Private Sub texts_KeyDown(sender As Object, e As KeyEventArgs) Handles texts.KeyDown
        updatestatuslist()
    End Sub

    Private Sub texts_KeyUp(sender As Object, e As KeyEventArgs) Handles texts.KeyUp
        updatestatuslist()
    End Sub


    Private Sub texts_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles texts.MouseClick
        updatestatuslist()
    End Sub

    Private Sub texts_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles texts.TextChanged
        hasSaved = False
        If Form3.form3abs = False Then
            Form2.nowis = 1
        End If
        Dim nowstate As Integer
        If Len(texts.Text) - Len(lastdo) > 0 Then
            nowstate = 1
        ElseIf Len(texts.Text) - Len(lastdo) = 0 Then
            nowstate = 2
        Else
            nowstate = 3
        End If
        If nowstate <> laststate Then
            lastundosave = lastdo
        End If
        lastdo = texts.Text
        laststate = nowstate
    End Sub

    '下面是“文件”菜单的各项
    Private Sub NewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewItem.Click
        If hasSaved = False Then
            If (AskIfSave() = True) Then
                texts.Text = ""
                hasSaved = True
                neverSaved = True
                filename = "无标题"
                filetitle = "无标题"
            End If
        Else
            texts.Text = ""
            hasSaved = True
            neverSaved = True
            filename = "无标题"
            filetitle = "无标题"
        End If
        updateall()
    End Sub
    Private Sub OpenItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenItem.Click
        If (OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If hasSaved = False Then
                If (AskIfSave() = True) Then
                    filename = OpenFileDialog.FileName
                    filetitle = Split(filename, "\")(UBound(Split(filename, "\")))
                    openfile()
                End If
            Else
                filename = OpenFileDialog.FileName
                filetitle = Split(filename, "\")(UBound(Split(filename, "\")))
                openfile()
            End If
        End If
    End Sub

    Private Sub SaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveItem.Click
        If neverSaved = True Then
            If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                filename = SaveFileDialog.FileName
                filetitle = Split(filename, "\")(UBound(Split(filename, "\")))
                savefile()
            End If
        Else
            savefile()
        End If
    End Sub

    Private Sub OtherSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherSaveItem.Click
        If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            filename = SaveFileDialog.FileName
            filetitle = Split(filename, "\")(UBound(Split(filename, "\")))
            savefile()
        End If
    End Sub

    Private Sub PrintItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintItem.Click
        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument.PrinterSettings = PrintDialog.PrinterSettings
            PrintDocument.DocumentName = filename
            PrintDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        e.Graphics.DrawString(texts.Text, texts.Font, New Pen(Color.Black, 1).Brush, 30, 30)
    End Sub

    Private Sub ExitItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitItem.Click
        If hasSaved = False Then
            If AskIfSave() = True Then
                End
            End If
        Else
            End
        End If
    End Sub

    '下面是“编辑”菜单的各项

    Private Sub UndoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoItem.Click
        Dim temp As String = texts.Text
        texts.Text = lastundosave
        lastundosave = temp
        lastdo = texts.Text
        laststate = 0

    End Sub

    Private Sub CutItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutItem.Click
        Clipboard.Clear()
        Clipboard.SetText(texts.SelectedText)
        texts.SelectedText = ""
    End Sub

    Private Sub CopyItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyItem.Click
        Clipboard.Clear()
        Clipboard.SetText(texts.SelectedText)
    End Sub

    Private Sub PasteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteItem.Click
        texts.SelectedText = Clipboard.GetText
    End Sub

    Private Sub DeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteItem.Click
        texts.SelectedText = ""
    End Sub

    Private Sub SelectAllItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllItem.Click
        texts.SelectionStart = 0
        texts.SelectionLength = Len(texts.Text)
    End Sub

    Private Sub FindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindItem.Click
        Form2.Show()
    End Sub

    Private Sub FindNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindNextItem.Click
        If savedfinding = "" Then
            Form2.Show()
        Else
            Form2.nextdothings()
        End If
    End Sub

    Private Sub ReplaceItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceItem.Click
        Form3.Show()
    End Sub

    Private Sub GotoItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoItem.Click
        Dim nowline = 1
        Dim enters = 1
        Dim targetline = InputBox("请输入行数", "转到", "1")
        If IsNumeric(targetline) = False Or Val(targetline) < 1 Then
            MsgBox("超出范围", 48, "记事本")
        Else
            Do While nowline < targetline
                enters = InStr(enters + 1, texts.Text, vbCrLf)
                nowline += 1
                If enters = 0 Then
                    MsgBox("超出范围", 48, "记事本")
                    Exit Do
                End If
            Loop
        End If
        If nowline = targetline Then
            texts.SelectionStart = enters + 1
        End If
    End Sub

    Private Sub DateItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateItem.Click
        texts.SelectedText = Now()
    End Sub
    '下面是“格式”菜单的各项
    Private Sub AutoWrapItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoWrapItem.Click
        If AutoWrapItem.Checked = True Then
            texts.WordWrap = True
        Else
            texts.WordWrap = False
        End If
        updateall()
    End Sub

    Private Sub FontItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontItem.Click
        If FontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            texts.Font = FontDialog.Font
        End If
    End Sub

    '下面是“查看”菜单的各项

    Private Sub StateItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StateItem.Click
        updateall()
    End Sub

    '下面是“帮助”菜单的各项
    Private Sub HelpItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpItem.Click
        MsgBox("记事本的特点是只支持纯文本。一般来说，如果把文本从网页复制并粘贴到一个文字处理软件，它的格式和嵌入的媒体将会被一起粘贴并且难以去除。但是，如果将这样一个文本先粘贴到记事本中，然后从记事本中再次复制到下最终需要的软件里，记事本将会去除所有的格式，只留下纯文本，在某些情况下相当有用。记事本几乎可以编辑任何文件，但不包括Unix风格的文本文件。", 64, "记事本")
    End Sub

    Private Sub AboutItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutItem.Click
        About.ShowDialog()
    End Sub

End Class
