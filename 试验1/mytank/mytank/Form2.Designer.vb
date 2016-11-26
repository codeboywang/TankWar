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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.主菜单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.结束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ammo = New System.Windows.Forms.Timer(Me.components)
        Me.etan = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.eammo = New System.Windows.Forms.Timer(Me.components)
        Me.tree2 = New System.Windows.Forms.PictureBox()
        Me.tree3 = New System.Windows.Forms.PictureBox()
        Me.tree1 = New System.Windows.Forms.PictureBox()
        Me.tree4 = New System.Windows.Forms.PictureBox()
        Me.tree6 = New System.Windows.Forms.PictureBox()
        Me.tree5 = New System.Windows.Forms.PictureBox()
        Me.eamright = New System.Windows.Forms.PictureBox()
        Me.eamleft = New System.Windows.Forms.PictureBox()
        Me.eamdown = New System.Windows.Forms.PictureBox()
        Me.eamup = New System.Windows.Forms.PictureBox()
        Me.Etank = New System.Windows.Forms.PictureBox()
        Me.amleft = New System.Windows.Forms.PictureBox()
        Me.amdown = New System.Windows.Forms.PictureBox()
        Me.amright = New System.Windows.Forms.PictureBox()
        Me.amup = New System.Windows.Forms.PictureBox()
        Me.wall16 = New System.Windows.Forms.PictureBox()
        Me.wall17 = New System.Windows.Forms.PictureBox()
        Me.wall14 = New System.Windows.Forms.PictureBox()
        Me.wall13 = New System.Windows.Forms.PictureBox()
        Me.wall15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.wall12 = New System.Windows.Forms.PictureBox()
        Me.wall6 = New System.Windows.Forms.PictureBox()
        Me.wall7 = New System.Windows.Forms.PictureBox()
        Me.wall8 = New System.Windows.Forms.PictureBox()
        Me.wall9 = New System.Windows.Forms.PictureBox()
        Me.wall10 = New System.Windows.Forms.PictureBox()
        Me.wall1 = New System.Windows.Forms.PictureBox()
        Me.wall2 = New System.Windows.Forms.PictureBox()
        Me.wall3 = New System.Windows.Forms.PictureBox()
        Me.wall4 = New System.Windows.Forms.PictureBox()
        Me.wall5 = New System.Windows.Forms.PictureBox()
        Me.home = New System.Windows.Forms.PictureBox()
        Me.wall11 = New System.Windows.Forms.PictureBox()
        Me.mytank1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GameMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tree2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tree3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tree4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tree6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tree5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eamright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eamleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eamdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eamup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Etank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amleft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mytank1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(644, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.主菜单ToolStripMenuItem, Me.结束ToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        '主菜单ToolStripMenuItem
        '
        Me.主菜单ToolStripMenuItem.Name = "主菜单ToolStripMenuItem"
        Me.主菜单ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.主菜单ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.主菜单ToolStripMenuItem.Text = "主菜单"
        '
        '结束ToolStripMenuItem
        '
        Me.结束ToolStripMenuItem.Name = "结束ToolStripMenuItem"
        Me.结束ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.结束ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.结束ToolStripMenuItem.Text = "结束"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于ToolStripMenuItem, Me.帮助ToolStripMenuItem1})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '帮助ToolStripMenuItem1
        '
        Me.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1"
        Me.帮助ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.帮助ToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.帮助ToolStripMenuItem1.Text = "帮助"
        '
        'GameMediaPlayer1
        '
        Me.GameMediaPlayer1.Enabled = True
        Me.GameMediaPlayer1.Location = New System.Drawing.Point(411, 30)
        Me.GameMediaPlayer1.Name = "GameMediaPlayer1"
        Me.GameMediaPlayer1.OcxState = CType(resources.GetObject("GameMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GameMediaPlayer1.Size = New System.Drawing.Size(51, 41)
        Me.GameMediaPlayer1.TabIndex = 3
        Me.GameMediaPlayer1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("楷体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "得分"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(551, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("楷体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(551, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "计时"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(550, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ammo
        '
        '
        'etan
        '
        Me.etan.Enabled = True
        Me.etan.Interval = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(102, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "地址"
        '
        'eammo
        '
        '
        'tree2
        '
        Me.tree2.BackColor = System.Drawing.Color.Transparent
        Me.tree2.Image = CType(resources.GetObject("tree2.Image"), System.Drawing.Image)
        Me.tree2.Location = New System.Drawing.Point(440, 310)
        Me.tree2.Name = "tree2"
        Me.tree2.Size = New System.Drawing.Size(40, 40)
        Me.tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tree2.TabIndex = 50
        Me.tree2.TabStop = False
        '
        'tree3
        '
        Me.tree3.BackColor = System.Drawing.Color.Transparent
        Me.tree3.Image = CType(resources.GetObject("tree3.Image"), System.Drawing.Image)
        Me.tree3.Location = New System.Drawing.Point(480, 310)
        Me.tree3.Name = "tree3"
        Me.tree3.Size = New System.Drawing.Size(40, 40)
        Me.tree3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tree3.TabIndex = 49
        Me.tree3.TabStop = False
        '
        'tree1
        '
        Me.tree1.BackColor = System.Drawing.Color.Transparent
        Me.tree1.Image = CType(resources.GetObject("tree1.Image"), System.Drawing.Image)
        Me.tree1.Location = New System.Drawing.Point(440, 350)
        Me.tree1.Name = "tree1"
        Me.tree1.Size = New System.Drawing.Size(40, 40)
        Me.tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tree1.TabIndex = 48
        Me.tree1.TabStop = False
        '
        'tree4
        '
        Me.tree4.BackColor = System.Drawing.Color.Transparent
        Me.tree4.Image = CType(resources.GetObject("tree4.Image"), System.Drawing.Image)
        Me.tree4.Location = New System.Drawing.Point(80, 270)
        Me.tree4.Name = "tree4"
        Me.tree4.Size = New System.Drawing.Size(40, 40)
        Me.tree4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tree4.TabIndex = 47
        Me.tree4.TabStop = False
        '
        'tree6
        '
        Me.tree6.BackColor = System.Drawing.Color.Transparent
        Me.tree6.Image = CType(resources.GetObject("tree6.Image"), System.Drawing.Image)
        Me.tree6.Location = New System.Drawing.Point(40, 230)
        Me.tree6.Name = "tree6"
        Me.tree6.Size = New System.Drawing.Size(40, 40)
        Me.tree6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tree6.TabIndex = 46
        Me.tree6.TabStop = False
        '
        'tree5
        '
        Me.tree5.BackColor = System.Drawing.Color.Transparent
        Me.tree5.Image = CType(resources.GetObject("tree5.Image"), System.Drawing.Image)
        Me.tree5.Location = New System.Drawing.Point(80, 230)
        Me.tree5.Name = "tree5"
        Me.tree5.Size = New System.Drawing.Size(40, 40)
        Me.tree5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tree5.TabIndex = 45
        Me.tree5.TabStop = False
        '
        'eamright
        '
        Me.eamright.Image = CType(resources.GetObject("eamright.Image"), System.Drawing.Image)
        Me.eamright.Location = New System.Drawing.Point(0, 122)
        Me.eamright.Name = "eamright"
        Me.eamright.Size = New System.Drawing.Size(40, 40)
        Me.eamright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eamright.TabIndex = 44
        Me.eamright.TabStop = False
        Me.eamright.Visible = False
        '
        'eamleft
        '
        Me.eamleft.Image = CType(resources.GetObject("eamleft.Image"), System.Drawing.Image)
        Me.eamleft.Location = New System.Drawing.Point(61, 76)
        Me.eamleft.Name = "eamleft"
        Me.eamleft.Size = New System.Drawing.Size(40, 40)
        Me.eamleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eamleft.TabIndex = 43
        Me.eamleft.TabStop = False
        Me.eamleft.Visible = False
        '
        'eamdown
        '
        Me.eamdown.BackColor = System.Drawing.Color.Transparent
        Me.eamdown.Image = CType(resources.GetObject("eamdown.Image"), System.Drawing.Image)
        Me.eamdown.Location = New System.Drawing.Point(46, 30)
        Me.eamdown.Name = "eamdown"
        Me.eamdown.Size = New System.Drawing.Size(40, 40)
        Me.eamdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eamdown.TabIndex = 42
        Me.eamdown.TabStop = False
        Me.eamdown.Visible = False
        '
        'eamup
        '
        Me.eamup.BackColor = System.Drawing.Color.Transparent
        Me.eamup.Image = CType(resources.GetObject("eamup.Image"), System.Drawing.Image)
        Me.eamup.Location = New System.Drawing.Point(0, 76)
        Me.eamup.Name = "eamup"
        Me.eamup.Size = New System.Drawing.Size(40, 40)
        Me.eamup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eamup.TabIndex = 41
        Me.eamup.TabStop = False
        Me.eamup.Visible = False
        '
        'Etank
        '
        Me.Etank.Image = CType(resources.GetObject("Etank.Image"), System.Drawing.Image)
        Me.Etank.Location = New System.Drawing.Point(0, 30)
        Me.Etank.Name = "Etank"
        Me.Etank.Size = New System.Drawing.Size(40, 40)
        Me.Etank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Etank.TabIndex = 39
        Me.Etank.TabStop = False
        '
        'amleft
        '
        Me.amleft.Image = CType(resources.GetObject("amleft.Image"), System.Drawing.Image)
        Me.amleft.Location = New System.Drawing.Point(46, 464)
        Me.amleft.Name = "amleft"
        Me.amleft.Size = New System.Drawing.Size(40, 40)
        Me.amleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.amleft.TabIndex = 38
        Me.amleft.TabStop = False
        Me.amleft.Visible = False
        '
        'amdown
        '
        Me.amdown.BackColor = System.Drawing.Color.Transparent
        Me.amdown.Image = CType(resources.GetObject("amdown.Image"), System.Drawing.Image)
        Me.amdown.Location = New System.Drawing.Point(46, 510)
        Me.amdown.Name = "amdown"
        Me.amdown.Size = New System.Drawing.Size(40, 40)
        Me.amdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.amdown.TabIndex = 37
        Me.amdown.TabStop = False
        Me.amdown.Visible = False
        '
        'amright
        '
        Me.amright.Image = CType(resources.GetObject("amright.Image"), System.Drawing.Image)
        Me.amright.Location = New System.Drawing.Point(91, 510)
        Me.amright.Name = "amright"
        Me.amright.Size = New System.Drawing.Size(40, 40)
        Me.amright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.amright.TabIndex = 36
        Me.amright.TabStop = False
        Me.amright.Visible = False
        '
        'amup
        '
        Me.amup.BackColor = System.Drawing.Color.Transparent
        Me.amup.Image = CType(resources.GetObject("amup.Image"), System.Drawing.Image)
        Me.amup.Location = New System.Drawing.Point(0, 470)
        Me.amup.Name = "amup"
        Me.amup.Size = New System.Drawing.Size(40, 40)
        Me.amup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.amup.TabIndex = 35
        Me.amup.TabStop = False
        Me.amup.Visible = False
        '
        'wall16
        '
        Me.wall16.Image = CType(resources.GetObject("wall16.Image"), System.Drawing.Image)
        Me.wall16.Location = New System.Drawing.Point(240, 150)
        Me.wall16.Name = "wall16"
        Me.wall16.Size = New System.Drawing.Size(40, 40)
        Me.wall16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall16.TabIndex = 28
        Me.wall16.TabStop = False
        '
        'wall17
        '
        Me.wall17.Image = CType(resources.GetObject("wall17.Image"), System.Drawing.Image)
        Me.wall17.Location = New System.Drawing.Point(240, 110)
        Me.wall17.Name = "wall17"
        Me.wall17.Size = New System.Drawing.Size(40, 40)
        Me.wall17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall17.TabIndex = 27
        Me.wall17.TabStop = False
        '
        'wall14
        '
        Me.wall14.Image = CType(resources.GetObject("wall14.Image"), System.Drawing.Image)
        Me.wall14.Location = New System.Drawing.Point(280, 190)
        Me.wall14.Name = "wall14"
        Me.wall14.Size = New System.Drawing.Size(40, 40)
        Me.wall14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall14.TabIndex = 26
        Me.wall14.TabStop = False
        '
        'wall13
        '
        Me.wall13.Image = CType(resources.GetObject("wall13.Image"), System.Drawing.Image)
        Me.wall13.Location = New System.Drawing.Point(240, 190)
        Me.wall13.Name = "wall13"
        Me.wall13.Size = New System.Drawing.Size(40, 40)
        Me.wall13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall13.TabIndex = 25
        Me.wall13.TabStop = False
        '
        'wall15
        '
        Me.wall15.Image = CType(resources.GetObject("wall15.Image"), System.Drawing.Image)
        Me.wall15.Location = New System.Drawing.Point(320, 190)
        Me.wall15.Name = "wall15"
        Me.wall15.Size = New System.Drawing.Size(40, 40)
        Me.wall15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall15.TabIndex = 24
        Me.wall15.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(160, 190)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'wall12
        '
        Me.wall12.Image = CType(resources.GetObject("wall12.Image"), System.Drawing.Image)
        Me.wall12.Location = New System.Drawing.Point(200, 190)
        Me.wall12.Name = "wall12"
        Me.wall12.Size = New System.Drawing.Size(40, 40)
        Me.wall12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall12.TabIndex = 22
        Me.wall12.TabStop = False
        '
        'wall6
        '
        Me.wall6.Image = CType(resources.GetObject("wall6.Image"), System.Drawing.Image)
        Me.wall6.Location = New System.Drawing.Point(360, 510)
        Me.wall6.Name = "wall6"
        Me.wall6.Size = New System.Drawing.Size(40, 40)
        Me.wall6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall6.TabIndex = 21
        Me.wall6.TabStop = False
        '
        'wall7
        '
        Me.wall7.Image = CType(resources.GetObject("wall7.Image"), System.Drawing.Image)
        Me.wall7.Location = New System.Drawing.Point(360, 470)
        Me.wall7.Name = "wall7"
        Me.wall7.Size = New System.Drawing.Size(40, 40)
        Me.wall7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall7.TabIndex = 20
        Me.wall7.TabStop = False
        '
        'wall8
        '
        Me.wall8.Image = CType(resources.GetObject("wall8.Image"), System.Drawing.Image)
        Me.wall8.Location = New System.Drawing.Point(360, 430)
        Me.wall8.Name = "wall8"
        Me.wall8.Size = New System.Drawing.Size(40, 40)
        Me.wall8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall8.TabIndex = 19
        Me.wall8.TabStop = False
        '
        'wall9
        '
        Me.wall9.Image = CType(resources.GetObject("wall9.Image"), System.Drawing.Image)
        Me.wall9.Location = New System.Drawing.Point(360, 390)
        Me.wall9.Name = "wall9"
        Me.wall9.Size = New System.Drawing.Size(40, 40)
        Me.wall9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall9.TabIndex = 18
        Me.wall9.TabStop = False
        '
        'wall10
        '
        Me.wall10.Image = CType(resources.GetObject("wall10.Image"), System.Drawing.Image)
        Me.wall10.Location = New System.Drawing.Point(360, 350)
        Me.wall10.Name = "wall10"
        Me.wall10.Size = New System.Drawing.Size(40, 40)
        Me.wall10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall10.TabIndex = 17
        Me.wall10.TabStop = False
        '
        'wall1
        '
        Me.wall1.Image = CType(resources.GetObject("wall1.Image"), System.Drawing.Image)
        Me.wall1.Location = New System.Drawing.Point(0, 310)
        Me.wall1.Name = "wall1"
        Me.wall1.Size = New System.Drawing.Size(40, 40)
        Me.wall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall1.TabIndex = 16
        Me.wall1.TabStop = False
        '
        'wall2
        '
        Me.wall2.Image = CType(resources.GetObject("wall2.Image"), System.Drawing.Image)
        Me.wall2.Location = New System.Drawing.Point(40, 310)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(40, 40)
        Me.wall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall2.TabIndex = 15
        Me.wall2.TabStop = False
        '
        'wall3
        '
        Me.wall3.Image = CType(resources.GetObject("wall3.Image"), System.Drawing.Image)
        Me.wall3.Location = New System.Drawing.Point(120, 310)
        Me.wall3.Name = "wall3"
        Me.wall3.Size = New System.Drawing.Size(40, 40)
        Me.wall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall3.TabIndex = 14
        Me.wall3.TabStop = False
        '
        'wall4
        '
        Me.wall4.Image = CType(resources.GetObject("wall4.Image"), System.Drawing.Image)
        Me.wall4.Location = New System.Drawing.Point(80, 310)
        Me.wall4.Name = "wall4"
        Me.wall4.Size = New System.Drawing.Size(40, 40)
        Me.wall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall4.TabIndex = 13
        Me.wall4.TabStop = False
        '
        'wall5
        '
        Me.wall5.Image = CType(resources.GetObject("wall5.Image"), System.Drawing.Image)
        Me.wall5.Location = New System.Drawing.Point(160, 310)
        Me.wall5.Name = "wall5"
        Me.wall5.Size = New System.Drawing.Size(40, 40)
        Me.wall5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wall5.TabIndex = 12
        Me.wall5.TabStop = False
        '
        'home
        '
        Me.home.BackColor = System.Drawing.Color.Transparent
        Me.home.Image = CType(resources.GetObject("home.Image"), System.Drawing.Image)
        Me.home.Location = New System.Drawing.Point(240, 510)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(40, 40)
        Me.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.home.TabIndex = 9
        Me.home.TabStop = False
        '
        'wall11
        '
        Me.wall11.BackColor = System.Drawing.Color.White
        Me.wall11.BackgroundImage = CType(resources.GetObject("wall11.BackgroundImage"), System.Drawing.Image)
        Me.wall11.Location = New System.Drawing.Point(520, 25)
        Me.wall11.Name = "wall11"
        Me.wall11.Size = New System.Drawing.Size(124, 525)
        Me.wall11.TabIndex = 5
        Me.wall11.TabStop = False
        '
        'mytank1
        '
        Me.mytank1.Image = CType(resources.GetObject("mytank1.Image"), System.Drawing.Image)
        Me.mytank1.Location = New System.Drawing.Point(0, 510)
        Me.mytank1.Name = "mytank1"
        Me.mytank1.Size = New System.Drawing.Size(40, 40)
        Me.mytank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mytank1.TabIndex = 4
        Me.mytank1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(644, 551)
        Me.Controls.Add(Me.tree2)
        Me.Controls.Add(Me.tree3)
        Me.Controls.Add(Me.tree1)
        Me.Controls.Add(Me.tree4)
        Me.Controls.Add(Me.tree6)
        Me.Controls.Add(Me.tree5)
        Me.Controls.Add(Me.eamright)
        Me.Controls.Add(Me.eamleft)
        Me.Controls.Add(Me.eamdown)
        Me.Controls.Add(Me.eamup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Etank)
        Me.Controls.Add(Me.amleft)
        Me.Controls.Add(Me.amdown)
        Me.Controls.Add(Me.amright)
        Me.Controls.Add(Me.amup)
        Me.Controls.Add(Me.wall16)
        Me.Controls.Add(Me.wall17)
        Me.Controls.Add(Me.wall14)
        Me.Controls.Add(Me.wall13)
        Me.Controls.Add(Me.wall15)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.wall12)
        Me.Controls.Add(Me.wall6)
        Me.Controls.Add(Me.wall7)
        Me.Controls.Add(Me.wall8)
        Me.Controls.Add(Me.wall9)
        Me.Controls.Add(Me.wall10)
        Me.Controls.Add(Me.wall1)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.wall3)
        Me.Controls.Add(Me.wall4)
        Me.Controls.Add(Me.wall5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.home)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.wall11)
        Me.Controls.Add(Me.mytank1)
        Me.Controls.Add(Me.GameMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GameMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tree2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tree3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tree4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tree6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tree5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eamright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eamleft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eamdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eamup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Etank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amleft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mytank1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 主菜单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 结束ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mytank1 As System.Windows.Forms.PictureBox
    Friend WithEvents GameMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents wall11 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents home As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents 帮助ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wall5 As System.Windows.Forms.PictureBox
    Friend WithEvents wall4 As System.Windows.Forms.PictureBox
    Friend WithEvents wall3 As System.Windows.Forms.PictureBox
    Friend WithEvents wall2 As System.Windows.Forms.PictureBox
    Friend WithEvents wall1 As System.Windows.Forms.PictureBox
    Friend WithEvents wall10 As System.Windows.Forms.PictureBox
    Friend WithEvents wall9 As System.Windows.Forms.PictureBox
    Friend WithEvents wall8 As System.Windows.Forms.PictureBox
    Friend WithEvents wall7 As System.Windows.Forms.PictureBox
    Friend WithEvents wall6 As System.Windows.Forms.PictureBox
    Friend WithEvents wall12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents wall15 As System.Windows.Forms.PictureBox
    Friend WithEvents wall13 As System.Windows.Forms.PictureBox
    Friend WithEvents wall14 As System.Windows.Forms.PictureBox
    Friend WithEvents wall17 As System.Windows.Forms.PictureBox
    Friend WithEvents wall16 As System.Windows.Forms.PictureBox
    Friend WithEvents amup As System.Windows.Forms.PictureBox
    Friend WithEvents amright As System.Windows.Forms.PictureBox
    Friend WithEvents amdown As System.Windows.Forms.PictureBox
    Friend WithEvents amleft As System.Windows.Forms.PictureBox
    Friend WithEvents ammo As System.Windows.Forms.Timer
    Friend WithEvents Etank As System.Windows.Forms.PictureBox
    Friend WithEvents etan As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents eammo As System.Windows.Forms.Timer
    Friend WithEvents eamup As System.Windows.Forms.PictureBox
    Friend WithEvents eamdown As System.Windows.Forms.PictureBox
    Friend WithEvents eamleft As System.Windows.Forms.PictureBox
    Friend WithEvents eamright As System.Windows.Forms.PictureBox
    Friend WithEvents tree5 As System.Windows.Forms.PictureBox
    Friend WithEvents tree6 As System.Windows.Forms.PictureBox
    Friend WithEvents tree4 As System.Windows.Forms.PictureBox
    Friend WithEvents tree1 As System.Windows.Forms.PictureBox
    Friend WithEvents tree3 As System.Windows.Forms.PictureBox
    Friend WithEvents tree2 As System.Windows.Forms.PictureBox
End Class
