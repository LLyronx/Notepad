Public Class Form3
    Dim a As Integer = 0
    Public Sub New()

        ' 此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Form2.nowis = 1
        source.Focus()
    End Sub
    Private Sub FindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindNext.Click
        nextdothings(a)
    End Sub

    Private Sub nextdothings(ByRef result As Integer)
        Dim findstring As String = ""
        Dim nowstring As String = Mid(Form1.texts.Text, Form2.nowis)
        If CapGet.Checked = False Then
            nowstring = UCase(nowstring)
            findstring = UCase(source.Text)
        Else
            findstring = source.Text
        End If
        If Form2.realfinding(nowstring, findstring) = True Then
            result = 1
        Else
            result = 0
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CapGet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapGet.CheckedChanged
        Form2.nowis = 1
    End Sub


    Private Sub Rep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rep.Click
        If a = 1 Then
            Form1.texts.SelectedText = desc.Text
            nextdothings(a)
        Else
            nextdothings(a)
            If a = 1 Then
                Form1.texts.SelectedText = desc.Text
                Form2.nowis = Form1.texts.SelectionStart + Form1.texts.SelectionLength
            Else
                MsgBox("没有查找到""" + source.Text + """", 64, Form1.programname)
            End If
        End If
    End Sub

    Private Sub RepAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepAll.Click
        Do While True
            nextdothings(a)
            If a = 0 Then
                Exit Do
            End If
            Form1.texts.SelectedText = desc.Text
            Form2.nowis = Form1.texts.SelectionStart + Form1.texts.SelectionLength
        Loop
    End Sub
End Class