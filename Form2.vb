Public Class Form2
    Public nowis As Integer = 1
    Dim nowstring As String = ""
    Public Sub New()

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        FindBox.Text = Form1.savedfinding
        nowis = 1
    End Sub
    Public Function realfinding(ByVal nowstring As String, ByVal findstring As String, Optional ByVal seladded As Integer = 0) As Boolean
        If InStr(nowstring, findstring) = 0 Then
            nowis = 1
            realfinding = False
        Else
            nowis = InStr(nowstring, findstring) + nowis - 1
            Form1.texts.SelectionStart = nowis - 1 + seladded
            Form1.texts.SelectionLength = findstring.Length
            nowis = nowis + 1
            realfinding = True
        End If
        Form1.savedfinding = FindBox.Text
    End Function
    Public Sub nextdothings()
        Dim findstring As String = ""
        Dim seladded As Integer

        If AllBox.Checked = False Then
            nowstring = Mid(Form1.texts.SelectedText, nowis)
            seladded = Form1.texts.SelectionStart
        Else
            nowstring = Mid(Form1.texts.Text, nowis)
            seladded = 0
        End If

        If CapGet.Checked = False Then
            nowstring = UCase(nowstring)
            findstring = UCase(FindBox.Text)
        Else
            findstring = FindBox.Text
        End If
        If realfinding(nowstring, findstring, seladded) = False Then
            MsgBox("没有查找到""" + FindBox.Text + """", 64, Form1.programname)
        End If
    End Sub
    Private Sub GetNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetNext.Click
        nextdothings()
    End Sub

    Private Sub AllBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllBox.CheckedChanged
        nowis = 1
    End Sub

    Private Sub CapGet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapGet.CheckedChanged
        nowis = 1
    End Sub

    Private Sub FindBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindBox.TextChanged
        nowis = 1
    End Sub

    Private Sub CancelBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBox.Click
        Me.Close()
    End Sub
End Class