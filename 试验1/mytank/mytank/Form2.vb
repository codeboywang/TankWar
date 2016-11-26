Public Class Form2
    Dim sum As Integer = 0 '得分
    Dim lu(1) As Integer
    Dim ld(1) As Integer
    Dim ru(1) As Integer
    Dim rd(1) As Integer
    '子弹坐标
    Dim slu(1) As Integer
    Dim sld(1) As Integer
    Dim sru(1) As Integer
    Dim srd(1) As Integer
    '敌方坦克坐标
    Dim elu(1) As Integer
    Dim eld(1) As Integer
    Dim eru(1) As Integer
    Dim erd(1) As Integer
    '敌方子弹坐标
    Dim eslu(1) As Integer
    Dim esld(1) As Integer
    Dim esru(1) As Integer
    Dim esrd(1) As Integer

    Dim epos As Integer '敌方坦克方向
    Dim espos As Integer '敌方子弹方向
    Dim t As Integer '计时
    Dim turn As Integer
    Dim r As Integer '返回主菜单的一个判断
    Dim pos As Integer '记录坦克方向，1234，上下左右
    Dim spos As Integer '子弹方向
    Dim amsum As Integer '子弹数
    Dim eamsum As Integer '敌方子弹数
    Dim map(30, 30) As Integer '0-空地 1-墙  2-老家 9-player1’s tank
    Dim elife As Integer '记录敌方坦克的生命数
    Dim amomap(30, 30) As Integer '记录我方子弹的地图
    Dim emap(30, 30) As Integer '记录敌方坦克的地图
    Dim eamomap(30, 30) As Integer '记录敌方子弹的地图
    'Dim msp2 As New System.Media.SoundPlayer(My.Resources.jm)
    Dim shot As New System.Media.SoundPlayer(My.Resources.Gunfire)
    Dim hit As New System.Media.SoundPlayer(My.Resources.hit)
    'Dim udie As New System.Media.SoundPlayer(My.Resources.playerdie)
    Dim bang As New System.Media.SoundPlayer(My.Resources.Bang)


    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'msp2.Stop()
        Me.GameMediaPlayer1.close()
        Form1.msp1.Play()
        If r = 1 Then
            Form1.Show()
        End If
        If r = 0 Then
            End
        End If
    End Sub
    'Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
    '    If keyData = Keys.Left Or keyData = Keys.Right Or keyData = Keys.Up Or keyData = Keys.Down Then
    '        Return False '如果是方向键返回FALSE,意思是继续执行form的keydown事件.

    '    Else
    '        Return MyBase.ProcessDialogKey(keyData)
    '    End If
    'End Function

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKW.gif"
            mytank1.Image = My.Resources.TKW
            pos = 1
        End If
        If e.KeyCode = Keys.Down Then
            'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKS.gif"
            mytank1.Image = My.Resources.TKS
            pos = 2
        End If
        If e.KeyCode = Keys.Left Then
            'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKA.gif"
            mytank1.Image = My.Resources.TKA
            pos = 3
        End If
        If e.KeyCode = Keys.Right Then
            'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKD.gif"
            mytank1.Image = My.Resources.TKD
            pos = 4
        End If


        If e.KeyCode = Keys.Up And mytank1.Top >= 50 And map(ru(0), ru(1) + 1) = 0 And map(lu(0), lu(1) + 1) = 0 Then
            If emap(ru(0), ru(1) + 1) = 0 And emap(lu(0), lu(1) + 1) = 0 Then
                'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKW.gif"
                mytank1.Image = My.Resources.TKW
                mytank1.Top = mytank1.Top - 20
                map(lu(0), lu(1)) = 0
                map(ld(0), ld(1)) = 0
                map(ru(0), ru(1)) = 0
                map(rd(0), rd(1)) = 0
                lu(1) += 1
                ld(1) += 1
                ru(1) += 1
                rd(1) += 1
                map(lu(0), lu(1)) = 9
                map(ld(0), ld(1)) = 9
                map(ru(0), ru(1)) = 9
                map(rd(0), rd(1)) = 9
                pos = 1
            End If
        End If
        If e.KeyCode = Keys.Down And mytank1.Top <= 490 And map(rd(0), rd(1) - 1) = 0 And map(ld(0), ld(1) - 1) = 0 Then
            If emap(rd(0), rd(1) - 1) = 0 And emap(ld(0), ld(1) - 1) = 0 Then
                'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKS.gif"
                mytank1.Image = My.Resources.TKS
                mytank1.Top = mytank1.Top + 20
                map(lu(0), lu(1)) = 0
                map(ld(0), ld(1)) = 0
                map(ru(0), ru(1)) = 0
                map(rd(0), rd(1)) = 0
                lu(1) -= 1
                ld(1) -= 1
                ru(1) -= 1
                rd(1) -= 1
                map(lu(0), lu(1)) = 9
                map(ld(0), ld(1)) = 9
                map(ru(0), ru(1)) = 9
                map(rd(0), rd(1)) = 9
                pos = 2
            End If
        End If
        If e.KeyCode = Keys.Left And mytank1.Left >= 20 And map(lu(0) - 1, lu(1)) = 0 And map(ld(0) - 1, ld(1)) = 0 Then
            If emap(lu(0) - 1, lu(1)) = 0 And emap(ld(0) - 1, ld(1)) = 0 Then
                'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKA.gif"
                mytank1.Image = My.Resources.TKA
                mytank1.Left = mytank1.Left - 20
                map(lu(0), lu(1)) = 0
                map(ld(0), ld(1)) = 0
                map(ru(0), ru(1)) = 0
                map(rd(0), rd(1)) = 0
                lu(0) -= 1
                ld(0) -= 1
                ru(0) -= 1
                rd(0) -= 1
                map(lu(0), lu(1)) = 9
                map(ld(0), ld(1)) = 9
                map(ru(0), ru(1)) = 9
                map(rd(0), rd(1)) = 9
                pos = 3
            End If
        End If
        If e.KeyCode = Keys.Right And mytank1.Left <= 460 And map(ru(0) + 1, ru(1)) = 0 And map(rd(0) + 1, rd(1)) = 0 Then
            If emap(ru(0) + 1, ru(1)) = 0 And emap(rd(0) + 1, rd(1)) = 0 Then
                'mytank1.ImageLocation = Application.StartupPath & "\subpart\icon\TKD.gif"
                mytank1.Image = My.Resources.TKD
                mytank1.Left = mytank1.Left + 20
                map(lu(0), lu(1)) = 0
                map(ld(0), ld(1)) = 0
                map(ru(0), ru(1)) = 0
                map(rd(0), rd(1)) = 0
                lu(0) += 1
                ld(0) += 1
                ru(0) += 1
                rd(0) += 1
                map(lu(0), lu(1)) = 9
                map(ld(0), ld(1)) = 9
                map(ru(0), ru(1)) = 9
                map(rd(0), rd(1)) = 9
                pos = 4
            End If
        End If
        ' shoot
        If e.KeyCode = Keys.J And amsum = 1 And pos = 1 Then
            shot.Play()
            If lu(1) + 2 <= 26 And ru(1) + 2 <= 26 And map(lu(0), lu(1) + 2) = 0 And map(ru(0), ru(1) + 2) = 0 And emap(lu(0), lu(1) + 2) = 0 And emap(ru(0), ru(1) + 2) = 0 Then
                spos = pos
                amup.Top = mytank1.Top - 40
                amup.Left = mytank1.Left
                amup.Show()
                amsum = 0
                amomap(lu(0), lu(1) + 2) = 1
                amomap(ld(0), ld(1) + 2) = 1
                amomap(ru(0), ru(1) + 2) = 1
                amomap(rd(0), rd(1) + 2) = 1
                slu(0) = lu(0)
                slu(1) = lu(1) + 2
                sld(0) = ld(0)
                sld(1) = ld(1) + 2
                sru(0) = ru(0)
                sru(1) = ru(1) + 2
                srd(0) = rd(0)
                srd(1) = rd(1) + 2
            End If
            If emap(lu(0), lu(1) + 2) = 1 Or emap(ru(0), ru(1) + 2) = 1 Then
                If elife = 0 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU WIN!!")
                End If
                If elife > 0 Then
                    For i = 1 To 2
                        For j = 25 To 26
                            emap(i, j) = 1
                        Next
                    Next
                    emap(erd(0), erd(1)) = 0
                    emap(elu(0), elu(1)) = 0
                    emap(eld(0), eld(1)) = 0
                    emap(eru(0), eru(1)) = 0
                    sum = sum + 1
                    Label2.Text = sum
                    Etank.Left = 0
                    Etank.Top = 30
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                    Etank.Show()
                    elu(0) = 1
                    elu(1) = 26
                    eld(0) = 1
                    eld(1) = 25
                    eru(0) = 2
                    eru(1) = 26
                    erd(0) = 2
                    erd(1) = 25
                    epos = 2
                    elife = elife - 1
                    etan.Start()
                End If
            End If
        End If
        If e.KeyCode = Keys.J And amsum = 1 And pos = 2 Then
            shot.Play()
            If ld(1) >= 3 And rd(1) >= 3 Then
                If map(ld(0), ld(1) - 2) = 0 And map(rd(0), rd(1) - 2) = 0 And emap(ld(0), ld(1) - 2) = 0 And emap(rd(0), rd(1) - 2) = 0 Then
                    spos = pos
                    amdown.Top = mytank1.Top + 40
                    amdown.Left = mytank1.Left
                    amdown.Show()
                    amsum = 0
                    amomap(lu(0), lu(1) - 2) = 1
                    amomap(ld(0), ld(1) - 2) = 1
                    amomap(ru(0), ru(1) - 2) = 1
                    amomap(rd(0), rd(1) - 2) = 1
                    slu(0) = lu(0)
                    slu(1) = lu(1) - 2
                    sld(0) = ld(0)
                    sld(1) = ld(1) - 2
                    sru(0) = ru(0)
                    sru(1) = ru(1) - 2
                    srd(0) = rd(0)
                    srd(1) = rd(1) - 2
                End If
                If emap(ld(0), ld(1) - 2) = 1 Or emap(rd(0), rd(1) - 2) = 1 Then
                    If elife = 0 Then
                        r = 1
                        Me.Close()
                        MsgBox("YOU WIN!!")
                    End If
                    If elife > 0 Then
                        For i = 1 To 2
                            For j = 25 To 26
                                emap(i, j) = 1
                            Next
                        Next
                        emap(erd(0), erd(1)) = 0
                        emap(elu(0), elu(1)) = 0
                        emap(eld(0), eld(1)) = 0
                        emap(eru(0), eru(1)) = 0
                        sum = sum + 1
                        Label2.Text = sum
                        Etank.Left = 0
                        Etank.Top = 30
                        'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                        Etank.Image = My.Resources.DTKS
                        Etank.Show()
                        elu(0) = 1
                        elu(1) = 26
                        eld(0) = 1
                        eld(1) = 25
                        eru(0) = 2
                        eru(1) = 26
                        erd(0) = 2
                        erd(1) = 25
                        epos = 2
                        elife = elife - 1
                        etan.Start()
                    End If
                End If
            End If
        End If

        If e.KeyCode = Keys.J And amsum = 1 And pos = 3 Then
            shot.Play()
            If ld(0) >= 3 And lu(0) >= 3 Then
                If map(ld(0) - 2, ld(1)) = 0 And map(lu(0) - 2, lu(1)) = 0 And emap(ld(0) - 2, ld(1)) = 0 And emap(lu(0) - 2, lu(1)) = 0 Then
                    spos = pos
                    amleft.Top = mytank1.Top
                    amleft.Left = mytank1.Left - 40
                    amleft.Show()
                    amsum = 0
                    amomap(lu(0) - 2, lu(1)) = 1
                    amomap(ld(0) - 2, ld(1)) = 1
                    amomap(ru(0) - 2, ru(1)) = 1
                    amomap(rd(0) - 2, rd(1)) = 1
                    slu(0) = lu(0) - 2
                    slu(1) = lu(1)
                    sld(0) = ld(0) - 2
                    sld(1) = ld(1)
                    sru(0) = ru(0) - 2
                    sru(1) = ru(1)
                    srd(0) = rd(0) - 2
                    srd(1) = rd(1)
                End If
                If emap(ld(0) - 2, ld(1)) = 1 Or emap(lu(0) - 2, lu(1)) = 1 Then
                    If elife = 0 Then
                        r = 1
                        Me.Close()
                        MsgBox("YOU WIN!!")
                    End If
                    If elife > 0 Then
                        For i = 1 To 2
                            For j = 25 To 26
                                emap(i, j) = 1
                            Next
                        Next
                        emap(erd(0), erd(1)) = 0
                        emap(elu(0), elu(1)) = 0
                        emap(eld(0), eld(1)) = 0
                        emap(eru(0), eru(1)) = 0
                        sum = sum + 1
                        Label2.Text = sum
                        Etank.Left = 0
                        Etank.Top = 30
                        'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                        Etank.Image = My.Resources.DTKS
                        Etank.Show()
                        elu(0) = 1
                        elu(1) = 26
                        eld(0) = 1
                        eld(1) = 25
                        eru(0) = 2
                        eru(1) = 26
                        erd(0) = 2
                        erd(1) = 25
                        epos = 2
                        elife = elife - 1
                        etan.Start()
                    End If
                End If
            End If
        End If
        If e.KeyCode = Keys.J And amsum = 1 And pos = 4 Then
            shot.Play()
            If rd(0) + 2 <= 26 And ru(0) + 2 <= 26 And map(rd(0) + 2, rd(1)) = 0 And map(ru(0) + 2, ru(1)) = 0 And emap(rd(0) + 2, rd(1)) = 0 And emap(ru(0) + 2, ru(1)) = 0 Then
                spos = pos
                amright.Top = mytank1.Top
                amright.Show()
                amsum = 0
                amright.Left = mytank1.Left + 40
                amomap(lu(0) + 2, lu(1)) = 1
                amomap(ld(0) + 2, ld(1)) = 1
                amomap(ru(0) + 2, ru(1)) = 1
                amomap(rd(0) + 2, rd(1)) = 1
                slu(0) = lu(0) + 2
                slu(1) = lu(1)
                sld(0) = ld(0) + 2
                sld(1) = ld(1)
                sru(0) = ru(0) + 2
                sru(1) = ru(1)
                srd(0) = rd(0) + 2
                srd(1) = rd(1)
            End If
            If emap(rd(0) + 2, rd(1)) = 1 Or emap(ru(0) + 2, ru(1)) = 1 Then
                If elife = 0 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU WIN!!")
                End If
                If elife > 0 Then
                    For i = 1 To 2
                        For j = 25 To 26
                            emap(i, j) = 1
                        Next
                    Next
                    emap(erd(0), erd(1)) = 0
                    emap(elu(0), elu(1)) = 0
                    emap(eld(0), eld(1)) = 0
                    emap(eru(0), eru(1)) = 0
                    sum = sum + 1
                    Label2.Text = sum
                    Etank.Left = 0
                    Etank.Top = 30
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                    Etank.Show()
                    elu(0) = 1
                    elu(1) = 26
                    eld(0) = 1
                    eld(1) = 25
                    eru(0) = 2
                    eru(1) = 26
                    erd(0) = 2
                    erd(1) = 25
                    epos = 2
                    elife = elife - 1
                    etan.Start()
                End If
            End If
        End If
        If amsum = 0 Then
            ammo.Start()
            ammo.Enabled = True
            ammo.Interval = 100 '间隔0.1秒
        End If
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sum = 0
        lu(0) = 1
        lu(1) = 2
        ld(0) = 1
        ld(1) = 1
        ru(0) = 2
        ru(1) = 2
        rd(0) = 2
        rd(1) = 1

        slu(0) = 0
        slu(1) = 0
        sld(0) = 0
        sld(1) = 0
        sru(0) = 0
        sru(1) = 0
        srd(0) = 0
        srd(1) = 0

        elu(0) = 1
        elu(1) = 26
        eld(0) = 1
        eld(1) = 25
        eru(0) = 2
        eru(1) = 26
        erd(0) = 2
        erd(1) = 25

        eslu(0) = 0
        eslu(1) = 0
        esld(0) = 0
        esld(1) = 0
        esru(0) = 0
        esru(1) = 0
        esrd(0) = 0
        esrd(1) = 0

        epos = 2
        pos = 1
        amsum = 1
        eamsum = 1
        r = 0
        turn = 10
        t = 0
        elife = 3
        amup.Hide()
        amdown.Hide()
        amleft.Hide()
        amright.Hide()
        '初始化 map
        For i = 0 To 30
            For j = 0 To 30
                map(i, j) = 0
            Next
        Next
        '初始化 amomap
        For i = 0 To 30
            For j = 0 To 30
                amomap(i, j) = 0
            Next
        Next

        '横墙
        For i = 1 To 10
            For j = 11 To 12
                map(i, j) = 1
            Next
        Next
        '竖墙
        For i = 19 To 20
            For j = 1 To 10
                map(i, j) = 1
            Next
        Next
        '横墙2
        For i = 9 To 18
            For j = 17 To 18
                map(i, j) = 1
            Next
        Next
        '两点墙
        For i = 13 To 14
            For j = 19 To 22
                map(i, j) = 1
            Next
        Next
        '老家
        For i = 13 To 14
            For j = 1 To 2
                map(i, j) = 2
            Next
        Next
        ' player1's tank
        For i = 1 To 2
            For j = 1 To 2
                map(i, j) = 9
            Next
        Next
        '初始化 Emap
        For i = 0 To 30
            For j = 0 To 30
                emap(i, j) = 0
            Next
        Next
        '初始化 Eamomap
        For i = 0 To 30
            For j = 0 To 30
                eamomap(i, j) = 0
            Next
        Next
        '初始化etank
        For i = 1 To 2
            For j = 25 To 26
                emap(i, j) = 1
            Next
        Next
        Label2.Text = sum
        Label4.Text = t & "秒"
        'msp2.Play()
        With Me.GameMediaPlayer1
            .URL = "C:\copyme\game.mid"
            .settings.playCount = -1
            .settings.autoStart = True
        End With

        etan.Start()
        etan.Enabled = True
        etan.Interval = 200 '间隔0.2秒

    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
    Private Sub 主菜单ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 主菜单ToolStripMenuItem.Click
        Form1.Show()
        'msp2.Stop()
        GameMediaPlayer1.close()
            'With Form1.StartMediaPlayer1
            '    .URL = Application.StartupPath & "\subpart\sound\start.mid"
            '    .settings.playCount = -1
            '    .settings.autoStart = True
            'End With
            r = 1
            Me.Close()
    End Sub
    Private Sub 结束ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 结束ToolStripMenuItem.Click
        End
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Enabled = True
        Timer1.Interval = 1000 '间隔一秒
        t = t + 1
        Label4.Text = t & "秒"
    End Sub

    Private Sub 帮助ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 帮助ToolStripMenuItem1.Click
        Help.Show()
    End Sub

    Private Sub ammo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ammo.Tick
        If spos = 1 Then
            If map(slu(0), slu(1) + 1) = 2 Or map(sru(0), sru(1) + 1) = 2 Then
                r = 1
                Me.Close()
                MsgBox("GAME OVER")
            End If
            If (sru(1) + 1 <= 26 And slu(1) + 1 <= 26) And (map(slu(0), slu(1) + 1) = 0 And map(sru(0), sru(1) + 1) = 0) Then
                amup.Top = amup.Top - 20
                amup.Left = amup.Left
                Refresh()
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                amomap(srd(0), srd(1)) = 0
                slu(1) = slu(1) + 1
                sld(1) = sld(1) + 1
                sru(1) = sru(1) + 1
                srd(1) = srd(1) + 1
                amomap(slu(0), slu(1)) = 1
                amomap(sld(0), sld(1)) = 1
                amomap(sru(0), sru(1)) = 1
                amomap(srd(0), srd(1)) = 1
            End If
            If (sru(1) = 26 Or slu(1) = 26) Or (map(slu(0), slu(1) + 1) = 1 Or map(sru(0), sru(1) + 1) = 1) Then
                amsum = 1
                amup.Hide()
                hit.Play()
                ammo.Stop()
                amomap(srd(0), srd(1)) = 0
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
            End If
            If emap(slu(0), slu(1) + 1) = 1 Or emap(sru(0), sru(1) + 1) = 1 Then
                amsum = 1
                amup.Hide()
                ammo.Stop()
                amomap(srd(0), srd(1)) = 0
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                Etank.Hide()
                bang.Play()
                etan.Stop()
                emap(erd(0), erd(1)) = 0
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0
                sum = sum + 1
                Label2.Text = sum
                If elife = 0 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU WIN!!")
                End If
                If elife > 0 Then
                    For i = 1 To 2
                        For j = 25 To 26
                            emap(i, j) = 1
                        Next
                    Next
                    Etank.Left = 0
                    Etank.Top = 30
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS

                    Etank.Show()
                    elu(0) = 1
                    elu(1) = 26
                    eld(0) = 1
                    eld(1) = 25
                    eru(0) = 2
                    eru(1) = 26
                    erd(0) = 2
                    erd(1) = 25
                    epos = 2
                    elife = elife - 1
                    etan.Start()
                End If
            End If
        End If
        If spos = 2 Then
            If map(sld(0), sld(1) - 1) = 2 Or map(srd(0), srd(1) - 1) = 2 Then
                r = 1
                Me.Close()
                MsgBox("GAME OVER")
            End If
            If srd(1) - 1 >= 1 And sld(1) - 1 >= 1 And (map(sld(0), sld(1) - 1) = 0 And map(srd(0), srd(1) - 1) = 0) Then
                amdown.Top = amdown.Top + 20
                amdown.Left = amdown.Left
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                amomap(srd(0), srd(1)) = 0
                slu(1) = slu(1) - 1
                sld(1) = sld(1) - 1
                sru(1) = sru(1) - 1
                srd(1) = srd(1) - 1
                amomap(slu(0), slu(1)) = 1
                amomap(sld(0), sld(1)) = 1
                amomap(sru(0), sru(1)) = 1
                amomap(srd(0), srd(1)) = 1
            End If
            If srd(1) = 1 And sld(1) = 1 Or (map(sld(0), sld(1) - 1) = 1 Or map(srd(0), srd(1) - 1) = 1) Then
                amsum = 1
                amdown.Hide()
                hit.Play()
                ammo.Stop()
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                amomap(srd(0), srd(1)) = 0
            End If
            If emap(sld(0), sld(1) - 1) = 1 Or emap(srd(0), srd(1) - 1) = 1 Then
                amsum = 1
                amdown.Hide()
                ammo.Stop()
                amomap(srd(0), srd(1)) = 0
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                Etank.Hide()
                bang.Play()
                etan.Stop()
                emap(erd(0), erd(1)) = 0
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0
                sum = sum + 1
                Label2.Text = sum
                If elife = 0 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU WIN!!")
                End If
                If elife > 0 Then
                    For i = 1 To 2
                        For j = 25 To 26
                            emap(i, j) = 1
                        Next
                    Next
                    Etank.Left = 0
                    Etank.Top = 30
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                    Etank.Show()
                    elu(0) = 1
                    elu(1) = 26
                    eld(0) = 1
                    eld(1) = 25
                    eru(0) = 2
                    eru(1) = 26
                    erd(0) = 2
                    erd(1) = 25
                    epos = 2
                    elife = elife - 1
                    etan.Start()
                End If
            End If
        End If
        If spos = 3 Then
            If map(slu(0) - 1, slu(1)) = 2 Or map(sld(0) - 1, sld(1)) = 2 Then
                r = 1
                Me.Close()
                MsgBox("GAME OVER")
            End If
            If slu(0) - 1 >= 1 And sld(0) - 1 >= 1 And (map(slu(0) - 1, slu(1)) = 0 And map(sld(0) - 1, sld(1)) = 0) Then
                amleft.Top = amleft.Top
                amleft.Left = amleft.Left - 20
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                amomap(srd(0), srd(1)) = 0
                slu(0) = slu(0) - 1
                sld(0) = sld(0) - 1
                sru(0) = sru(0) - 1
                srd(0) = srd(0) - 1
                amomap(slu(0), slu(1)) = 1
                amomap(sld(0), sld(1)) = 1
                amomap(sru(0), sru(1)) = 1
                amomap(srd(0), srd(1)) = 1
            End If
            If slu(0) = 1 And sld(0) = 1 Or (map(slu(0) - 1, slu(1)) = 1 Or map(sld(0) - 1, sld(1)) = 1) Then
                amsum = 1
                amleft.Hide()
                hit.Play()
                ammo.Stop()
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                amomap(srd(0), srd(1)) = 0
            End If
            If emap(slu(0) - 1, slu(1)) = 1 Or emap(sld(0) - 1, sld(1)) = 1 Then
                amsum = 1
                amleft.Hide()
                ammo.Stop()
                amomap(srd(0), srd(1)) = 0
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                Etank.Hide()
                bang.Play()
                etan.Stop()
                emap(erd(0), erd(1)) = 0
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0
                sum = sum + 1
                Label2.Text = sum
                If elife = 0 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU WIN!!")
                End If
                If elife > 0 Then
                    For i = 1 To 2
                        For j = 25 To 26
                            emap(i, j) = 1
                        Next
                    Next
                    Etank.Left = 0
                    Etank.Top = 30
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                    Etank.Show()
                    elu(0) = 1
                    elu(1) = 26
                    eld(0) = 1
                    eld(1) = 25
                    eru(0) = 2
                    eru(1) = 26
                    erd(0) = 2
                    erd(1) = 25
                    epos = 2
                    elife = elife - 1
                    etan.Start()
                End If
            End If

        End If

        If spos = 4 Then
            If map(sru(0) + 1, sru(1)) = 2 Or map(srd(0) + 1, srd(1)) = 2 Then
                r = 1
                Me.Close()
                MsgBox("GAME OVER")
            End If

            If sru(0) + 1 <= 26 And srd(0) + 1 <= 26 And (map(sru(0) + 1, sru(1)) = 0 And map(srd(0) + 1, srd(1)) = 0) Then
                amright.Top = amright.Top
                amright.Left = amright.Left + 20
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                amomap(srd(0), srd(1)) = 0
                slu(0) = slu(0) + 1
                sld(0) = sld(0) + 1
                sru(0) = sru(0) + 1
                srd(0) = srd(0) + 1
                amomap(slu(0), slu(1)) = 1
                amomap(sld(0), sld(1)) = 1
                amomap(sru(0), sru(1)) = 1
                amomap(srd(0), srd(1)) = 1
            End If
            If sru(0) = 26 And srd(0) = 26 Or (map(sru(0) + 1, sru(1)) = 1 Or map(srd(0) + 1, srd(1)) = 1) Then
                amsum = 1
                amright.Hide()
                hit.Play()
                ammo.Stop()
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                amomap(srd(0), srd(1)) = 0
            End If
            If emap(sru(0) + 1, sru(1)) = 1 Or emap(srd(0) + 1, srd(1)) = 1 Then
                amsum = 1
                amright.Hide()
                ammo.Stop()
                amomap(srd(0), srd(1)) = 0
                amomap(slu(0), slu(1)) = 0
                amomap(sld(0), sld(1)) = 0
                amomap(sru(0), sru(1)) = 0
                Etank.Hide()
                bang.Play()
                etan.Stop()
                emap(erd(0), erd(1)) = 0
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0

                sum = sum + 1
                Label2.Text = sum
                If elife = 0 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU WIN!!")
                End If
                If elife > 0 Then
                    For i = 1 To 2
                        For j = 25 To 26
                            emap(i, j) = 1
                        Next
                    Next
                    Etank.Left = 0
                    Etank.Top = 30
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                    Etank.Show()
                    elu(0) = 1
                    elu(1) = 26
                    eld(0) = 1
                    eld(1) = 25
                    eru(0) = 2
                    eru(1) = 26
                    erd(0) = 2
                    erd(1) = 25
                    epos = 2
                    elife = elife - 1
                    etan.Start()
                End If
            End If
        End If
    End Sub

    Private Sub etan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etan.Tick
        If epos = 1 And turn >= 2 Then
            If elu(1) + 1 <= 26 And eru(1) + 1 <= 26 And map(elu(0), elu(1) + 1) = 0 And map(eru(0), eru(1) + 1) = 0 Then
                Etank.Top = Etank.Top - 20
                Etank.Left = Etank.Left
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0
                emap(erd(0), erd(1)) = 0
                elu(1) += 1
                eld(1) += 1
                eru(1) += 1
                erd(1) += 1
                emap(elu(0), elu(1)) = 1
                emap(eld(0), eld(1)) = 1
                emap(eru(0), eru(1)) = 1
                emap(erd(0), erd(1)) = 1
                turn = Rnd() * 10
            Else
                epos = Rnd() * 3 + 1
                If epos = 1 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKW.gif"
                    Etank.Image = My.Resources.DTKW
                End If
                If epos = 2 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                End If
                If epos = 3 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKA.gif"
                    Etank.Image = My.Resources.DTKA
                End If
                If epos = 4 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKD.gif"
                    Etank.Image = My.Resources.DTKD
                End If
                turn = Rnd() * 10
            End If
        End If
        If epos = 2 And turn >= 2 Then
            If eld(1) - 1 >= 1 And erd(1) - 1 >= 1 And map(eld(0), eld(1) - 1) = 0 And map(erd(0), erd(1) - 1) = 0 Then
                Etank.Top = Etank.Top + 20
                Etank.Left = Etank.Left
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0
                emap(erd(0), erd(1)) = 0
                elu(1) -= 1
                eld(1) -= 1
                eru(1) -= 1
                erd(1) -= 1
                emap(elu(0), elu(1)) = 1
                emap(eld(0), eld(1)) = 1
                emap(eru(0), eru(1)) = 1
                emap(erd(0), erd(1)) = 1
                turn = Rnd() * 10
            Else
                epos = Rnd() * 3 + 1
                If epos = 1 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKW.gif"
                    Etank.Image = My.Resources.DTKW
                End If
                If epos = 2 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                End If
                If epos = 3 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKA.gif"
                    Etank.Image = My.Resources.DTKA
                End If
                If epos = 4 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKD.gif"
                    Etank.Image = My.Resources.DTKD
                End If
                turn = Rnd() * 10
            End If
        End If
        If epos = 3 And turn >= 2 Then
            If elu(0) - 1 >= 1 And eld(0) - 1 >= 1 And map(elu(0) - 1, elu(1)) = 0 And map(eld(0) - 1, eld(1)) = 0 Then
                Etank.Top = Etank.Top
                Etank.Left = Etank.Left - 20
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0
                emap(erd(0), erd(1)) = 0
                elu(0) -= 1
                eld(0) -= 1
                eru(0) -= 1
                erd(0) -= 1
                emap(elu(0), elu(1)) = 1
                emap(eld(0), eld(1)) = 1
                emap(eru(0), eru(1)) = 1
                emap(erd(0), erd(1)) = 1
                turn = Rnd() * 10
            Else
                epos = Rnd() * 3 + 1
                If epos = 1 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKW.gif"
                    Etank.Image = My.Resources.DTKW
                End If
                If epos = 2 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                End If
                If epos = 3 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKA.gif"
                    Etank.Image = My.Resources.DTKA
                End If
                If epos = 4 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKD.gif"
                    Etank.Image = My.Resources.DTKD
                End If
                turn = Rnd() * 10
            End If
        End If
        If epos = 4 And turn >= 2 Then
            If eru(0) + 1 <= 26 And erd(0) + 1 <= 26 And map(eru(0) + 1, eru(1)) = 0 And map(erd(0) + 1, erd(1)) = 0 Then
                Etank.Top = Etank.Top
                Etank.Left = Etank.Left + 20
                emap(elu(0), elu(1)) = 0
                emap(eld(0), eld(1)) = 0
                emap(eru(0), eru(1)) = 0
                emap(erd(0), erd(1)) = 0
                elu(0) += 1
                eld(0) += 1
                eru(0) += 1
                erd(0) += 1
                emap(elu(0), elu(1)) = 1
                emap(eld(0), eld(1)) = 1
                emap(eru(0), eru(1)) = 1
                emap(erd(0), erd(1)) = 1
                turn = Rnd() * 10
            Else
                epos = Rnd() * 3 + 1
                If epos = 1 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKW.gif"
                    Etank.Image = My.Resources.DTKW
                End If
                If epos = 2 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKS.gif"
                    Etank.Image = My.Resources.DTKS
                End If
                If epos = 3 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKA.gif"
                    Etank.Image = My.Resources.DTKA
                End If
                If epos = 4 Then
                    'Etank.ImageLocation = Application.StartupPath & "\subpart\icon\DTKD.gif"
                    Etank.Image = My.Resources.DTKD
                End If
                turn = Rnd() * 10
            End If
        End If

        If (turn = 1 Or turn = 0) And eamsum = 1 Then

            If epos = 1 Then
                If elu(1) + 2 <= 26 And eru(1) + 2 <= 26 And map(elu(0), elu(1) + 2) = 0 And map(eru(0), eru(1) + 2) = 0 Then
                    espos = epos
                    eamup.Top = Etank.Top - 40
                    eamup.Left = Etank.Left
                    eamup.Show()
                    eamsum = 0
                    eamomap(elu(0), elu(1) + 2) = 1
                    eamomap(eld(0), eld(1) + 2) = 1
                    eamomap(eru(0), eru(1) + 2) = 1
                    eamomap(erd(0), erd(1) + 2) = 1
                    eslu(0) = elu(0)
                    eslu(1) = elu(1) + 2
                    esld(0) = eld(0)
                    esld(1) = eld(1) + 2
                    esru(0) = eru(0)
                    esru(1) = eru(1) + 2
                    esrd(0) = erd(0)
                    esrd(1) = erd(1) + 2
                End If
                If map(elu(0), elu(1) + 2) = 9 Or map(eru(0), eru(1) + 2) = 9 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU LOST!!")
                End If
                If map(elu(0), elu(1) + 2) = 2 Or map(eru(0), eru(1) + 2) = 2 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU DIED!!")
                End If
            End If
            If epos = 2 Then
                If eld(1) >= 3 And erd(1) >= 3 Then
                    If map(eld(0), eld(1) - 2) = 0 And map(erd(0), erd(1) - 2) = 0 Then
                        espos = epos
                        eamdown.Top = Etank.Top + 40
                        eamdown.Left = Etank.Left
                        eamdown.Show()
                        eamsum = 0
                        eamomap(elu(0), elu(1) - 2) = 1
                        eamomap(eld(0), eld(1) - 2) = 1
                        eamomap(eru(0), eru(1) - 2) = 1
                        eamomap(erd(0), erd(1) - 2) = 1
                        eslu(0) = elu(0)
                        eslu(1) = elu(1) - 2
                        esld(0) = eld(0)
                        esld(1) = eld(1) - 2
                        esru(0) = eru(0)
                        esru(1) = eru(1) - 2
                        esrd(0) = erd(0)
                        esrd(1) = erd(1) - 2
                    End If
                    If map(eld(0), eld(1) - 2) = 9 Or map(erd(0), erd(1) - 2) = 9 Then
                        r = 1
                        Me.Close()
                        MsgBox("YOU DIED!!")
                    End If
                    If map(eld(0), eld(1) - 2) = 2 Or map(erd(0), erd(1) - 2) = 2 Then
                        r = 1
                        Me.Close()
                        MsgBox("YOU LOST!!")
                    End If
                End If
            End If

            If epos = 3 Then
                If eld(0) >= 3 And elu(0) >= 3 Then
                    If map(eld(0) - 2, eld(1)) = 0 And map(elu(0) - 2, elu(1)) = 0 Then
                        espos = epos
                        eamleft.Top = Etank.Top
                        eamleft.Left = Etank.Left - 40
                        eamleft.Show()
                        eamsum = 0
                        eamomap(elu(0) - 2, elu(1)) = 1
                        eamomap(eld(0) - 2, eld(1)) = 1
                        eamomap(eru(0) - 2, eru(1)) = 1
                        eamomap(erd(0) - 2, erd(1)) = 1
                        eslu(0) = elu(0) - 2
                        eslu(1) = elu(1)
                        esld(0) = eld(0) - 2
                        esld(1) = eld(1)
                        esru(0) = eru(0) - 2
                        esru(1) = eru(1)
                        esrd(0) = erd(0) - 2
                        esrd(1) = erd(1)
                    End If
                    If map(eld(0) - 2, eld(1)) = 9 Or map(elu(0) - 2, elu(1)) = 9 Then
                        r = 1
                        Me.Close()
                        MsgBox("YOU DIED!!")
                    End If
                    If map(eld(0) - 2, eld(1)) = 2 Or map(elu(0) - 2, elu(1)) = 2 Then
                        r = 1
                        Me.Close()
                        MsgBox("YOU LOST!!")
                    End If
                End If
            End If

            If epos = 4 Then
                If erd(0) + 2 <= 26 And eru(0) + 2 <= 26 And map(erd(0) + 2, erd(1)) = 0 And map(eru(0) + 2, eru(1)) = 0 Then
                    espos = epos
                    eamright.Top = Etank.Top
                    eamright.Show()
                    eamsum = 0
                    eamright.Left = Etank.Left + 40
                    eamomap(elu(0) + 2, elu(1)) = 1
                    eamomap(eld(0) + 2, eld(1)) = 1
                    eamomap(eru(0) + 2, eru(1)) = 1
                    eamomap(erd(0) + 2, erd(1)) = 1
                    eslu(0) = elu(0) + 2
                    eslu(1) = elu(1)
                    esld(0) = eld(0) + 2
                    esld(1) = eld(1)
                    esru(0) = eru(0) + 2
                    esru(1) = eru(1)
                    esrd(0) = erd(0) + 2
                    esrd(1) = erd(1)
                End If
                If map(rd(0) + 2, rd(1)) = 9 Or map(ru(0) + 2, ru(1)) = 9 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU DIED!!")
                End If
                If map(rd(0) + 2, rd(1)) = 2 Or map(ru(0) + 2, ru(1)) = 2 Then
                    r = 1
                    Me.Close()
                    MsgBox("YOU LOST!!")
                End If
            End If
            If eamsum = 0 Then
                eammo.Start()
                eammo.Enabled = True
                eammo.Interval = 100
            End If
            turn = Rnd() * 10
        End If
        If turn = 1 And eamsum = 0 Then
            turn = Rnd() * 10
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Label5.Text = Application.StartupPath
    End Sub

    Private Sub eammo_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles eammo.Tick
        If espos = 1 Then
            If map(eslu(0), eslu(1) + 1) = 2 Or map(esru(0), esru(1) + 1) = 2 Then
                r = 1
                'udie.Play()
                Me.Close()
                MsgBox("GAME OVER")
            End If
            If (esru(1) + 1 <= 26 And eslu(1) + 1 <= 26) And (map(eslu(0), eslu(1) + 1) = 0 And map(esru(0), esru(1) + 1) = 0) Then
                eamup.Top = eamup.Top - 20
                eamup.Left = eamup.Left
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
                eamomap(esrd(0), esrd(1)) = 0
                eslu(1) = eslu(1) + 1
                esld(1) = esld(1) + 1
                esru(1) = esru(1) + 1
                esrd(1) = esrd(1) + 1
                eamomap(eslu(0), eslu(1)) = 1
                eamomap(esld(0), esld(1)) = 1
                eamomap(esru(0), esru(1)) = 1
                eamomap(esrd(0), esrd(1)) = 1
            End If
            If (esru(1) = 26 Or eslu(1) = 26) Or (map(eslu(0), eslu(1) + 1) = 1 Or map(esru(0), esru(1) + 1) = 1) Then
                eamsum = 1
                eamup.Hide()
                eammo.Stop()
                eamomap(esrd(0), esrd(1)) = 0
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
            End If
            If map(eslu(0), eslu(1) + 1) = 2 Or map(esru(0), esru(1) + 1) = 2 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU LOST!!")
            End If
            If map(eslu(0), eslu(1) + 1) = 9 Or map(esru(0), esru(1) + 1) = 9 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU DIED!!")
            End If
        End If


        If espos = 2 Then
            If map(esld(0), esld(1) - 1) = 2 Or map(esrd(0), esrd(1) - 1) = 2 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("GAME OVER")
            End If
            If (esrd(1) - 1 >= 1 And esld(1) - 1 >= 1) And (map(esld(0), esld(1) - 1) = 0 And map(esrd(0), esrd(1) - 1) = 0) Then
                eamdown.Top = eamdown.Top + 20
                eamdown.Left = eamdown.Left
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
                eamomap(esrd(0), esrd(1)) = 0
                eslu(1) = eslu(1) - 1
                esld(1) = esld(1) - 1
                esru(1) = esru(1) - 1
                esrd(1) = esrd(1) - 1
                eamomap(eslu(0), eslu(1)) = 1
                eamomap(esld(0), esld(1)) = 1
                eamomap(esru(0), esru(1)) = 1
                eamomap(esrd(0), esrd(1)) = 1
            End If
            If (esrd(1) = 1 Or esld(1) = 1) Or (map(esld(0), esld(1) - 1) = 1 Or map(esrd(0), esrd(1) - 1) = 1) Then
                eamsum = 1
                eamdown.Hide()
                eammo.Stop()
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
                eamomap(esrd(0), esrd(1)) = 0
            End If
            If map(esld(0), esld(1) - 1) = 2 Or map(esrd(0), esrd(1) - 1) = 2 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU LOST!!")
            End If
            If map(esld(0), esld(1) - 1) = 9 Or map(esrd(0), esrd(1) - 1) = 9 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU DIED!!")
            End If
        End If

        If espos = 3 Then
            If map(eslu(0) - 1, eslu(1)) = 2 Or map(esld(0) - 1, esld(1)) = 2 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("GAME OVER")
            End If
            If eslu(0) - 1 >= 1 And esld(0) - 1 >= 1 And (map(eslu(0) - 1, eslu(1)) = 0 And map(esld(0) - 1, esld(1)) = 0) Then
                eamleft.Top = eamleft.Top
                eamleft.Left = eamleft.Left - 20
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
                eamomap(esrd(0), esrd(1)) = 0
                eslu(0) = eslu(0) - 1
                esld(0) = esld(0) - 1
                esru(0) = esru(0) - 1
                esrd(0) = esrd(0) - 1
                eamomap(eslu(0), eslu(1)) = 1
                eamomap(esld(0), esld(1)) = 1
                eamomap(esru(0), esru(1)) = 1
                eamomap(esrd(0), esrd(1)) = 1
            End If
            If eslu(0) = 1 And esld(0) = 1 Or (map(eslu(0) - 1, eslu(1)) = 1 Or map(esld(0) - 1, esld(1)) = 1) Then
                eamsum = 1
                eamleft.Hide()
                eammo.Stop()
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
                eamomap(esrd(0), esrd(1)) = 0
            End If
            If map(eslu(0) - 1, eslu(1)) = 2 Or map(esld(0) - 1, esld(1)) = 2 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU LOST!!")
            End If
            If map(eslu(0) - 1, eslu(1)) = 9 Or map(esld(0) - 1, esld(1)) = 9 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU DIED!!")
            End If

        End If

        If espos = 4 Then
            If map(esru(0) + 1, esru(1)) = 2 Or map(esrd(0) + 1, esrd(1)) = 2 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("GAME OVER")
            End If

            If esru(0) + 1 <= 26 And esrd(0) + 1 <= 26 And (map(esru(0) + 1, esru(1)) = 0 And map(esrd(0) + 1, esrd(1)) = 0) Then
                eamright.Top = eamright.Top
                eamright.Left = eamright.Left + 20
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
                eamomap(esrd(0), esrd(1)) = 0
                eslu(0) = eslu(0) + 1
                esld(0) = esld(0) + 1
                esru(0) = esru(0) + 1
                esrd(0) = esrd(0) + 1
                eamomap(eslu(0), eslu(1)) = 1
                eamomap(esld(0), esld(1)) = 1
                eamomap(esru(0), esru(1)) = 1
                eamomap(esrd(0), esrd(1)) = 1
            End If
            If esru(0) = 26 And esrd(0) = 26 Or (map(esru(0) + 1, esru(1)) = 1 Or map(esrd(0) + 1, esrd(1)) = 1) Then
                eamsum = 1
                eamright.Hide()
                eammo.Stop()
                eamomap(eslu(0), eslu(1)) = 0
                eamomap(esld(0), esld(1)) = 0
                eamomap(esru(0), esru(1)) = 0
                eamomap(esrd(0), esrd(1)) = 0
            End If
            If map(esru(0) + 1, esru(1)) = 2 Or map(esrd(0) + 1, esrd(1)) = 2 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU LOST!!")
            End If
            If map(esru(0) + 1, esru(1)) = 9 Or map(esrd(0) + 1, esrd(1)) = 9 Then
                'udie.Play()
                r = 1
                Me.Close()
                MsgBox("YOU DIED!!")
            End If
        End If
    End Sub
End Class