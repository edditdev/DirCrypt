<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.FileTxtPath = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SelectDirectory = New System.Windows.Forms.FolderBrowserDialog()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PasswordBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EncGroup = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DecGroup = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EncTab = New Guna.UI2.WinForms.Guna2Button()
        Me.DecTab = New Guna.UI2.WinForms.Guna2Button()
        Me.Mother = New System.Windows.Forms.Panel()
        Me.Bar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.StatLbl = New System.Windows.Forms.Label()
        Me.LoadingPanel = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.EncGroup.SuspendLayout()
        Me.DecGroup.SuspendLayout()
        Me.LoadingPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&DIRCRYPT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(32, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Encrypt && Decrypt your directory"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.FileTxtPath)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(36, 92)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(453, 88)
        Me.Guna2GroupBox1.TabIndex = 2
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Button1.BorderRadius = 3
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(351, 39)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(91, 26)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Select"
        '
        'FileTxtPath
        '
        Me.FileTxtPath.BorderColor = System.Drawing.Color.DarkGray
        Me.FileTxtPath.BorderRadius = 3
        Me.FileTxtPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FileTxtPath.DefaultText = ""
        Me.FileTxtPath.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.FileTxtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.FileTxtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FileTxtPath.DisabledState.Parent = Me.FileTxtPath
        Me.FileTxtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FileTxtPath.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.FileTxtPath.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.FileTxtPath.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.FileTxtPath.FocusedState.ForeColor = System.Drawing.Color.Silver
        Me.FileTxtPath.FocusedState.Parent = Me.FileTxtPath
        Me.FileTxtPath.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FileTxtPath.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.FileTxtPath.HoverState.Parent = Me.FileTxtPath
        Me.FileTxtPath.Location = New System.Drawing.Point(11, 39)
        Me.FileTxtPath.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FileTxtPath.Name = "FileTxtPath"
        Me.FileTxtPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FileTxtPath.PlaceholderForeColor = System.Drawing.Color.Black
        Me.FileTxtPath.PlaceholderText = "Directory path, choose yours."
        Me.FileTxtPath.ReadOnly = True
        Me.FileTxtPath.SelectedText = ""
        Me.FileTxtPath.ShadowDecoration.Parent = Me.FileTxtPath
        Me.FileTxtPath.Size = New System.Drawing.Size(336, 26)
        Me.FileTxtPath.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 11.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(9, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "File selection"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.PasswordBox)
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(36, 186)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(453, 88)
        Me.Guna2GroupBox2.TabIndex = 3
        '
        'PasswordBox
        '
        Me.PasswordBox.BorderColor = System.Drawing.Color.DarkGray
        Me.PasswordBox.BorderRadius = 3
        Me.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBox.DefaultText = ""
        Me.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.Gray
        Me.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.DisabledState.Parent = Me.PasswordBox
        Me.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.PasswordBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.PasswordBox.FocusedState.ForeColor = System.Drawing.Color.Silver
        Me.PasswordBox.FocusedState.Parent = Me.PasswordBox
        Me.PasswordBox.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.PasswordBox.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.PasswordBox.HoverState.Parent = Me.PasswordBox
        Me.PasswordBox.Location = New System.Drawing.Point(11, 39)
        Me.PasswordBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordBox.PlaceholderForeColor = System.Drawing.Color.Black
        Me.PasswordBox.PlaceholderText = "Password (remember your password!)"
        Me.PasswordBox.SelectedText = ""
        Me.PasswordBox.ShadowDecoration.Parent = Me.PasswordBox
        Me.PasswordBox.Size = New System.Drawing.Size(431, 26)
        Me.PasswordBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(9, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password for directory"
        '
        'EncGroup
        '
        Me.EncGroup.BorderColor = System.Drawing.Color.Gray
        Me.EncGroup.BorderRadius = 5
        Me.EncGroup.Controls.Add(Me.Guna2Button3)
        Me.EncGroup.Controls.Add(Me.Label5)
        Me.EncGroup.CustomBorderColor = System.Drawing.Color.Gray
        Me.EncGroup.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.EncGroup.FillColor = System.Drawing.Color.Transparent
        Me.EncGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EncGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.EncGroup.Location = New System.Drawing.Point(35, 491)
        Me.EncGroup.Name = "EncGroup"
        Me.EncGroup.ShadowDecoration.Parent = Me.EncGroup
        Me.EncGroup.Size = New System.Drawing.Size(453, 88)
        Me.EncGroup.TabIndex = 4
        Me.EncGroup.Visible = False
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Button3.BorderRadius = 3
        Me.Guna2Button3.BorderThickness = 1
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(13, 39)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(429, 26)
        Me.Guna2Button3.TabIndex = 3
        Me.Guna2Button3.Text = "Start encrypting"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 11.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(9, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Encryption"
        '
        'DecGroup
        '
        Me.DecGroup.BorderColor = System.Drawing.Color.Gray
        Me.DecGroup.BorderRadius = 5
        Me.DecGroup.Controls.Add(Me.Guna2Button4)
        Me.DecGroup.Controls.Add(Me.Label6)
        Me.DecGroup.CustomBorderColor = System.Drawing.Color.Gray
        Me.DecGroup.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.DecGroup.FillColor = System.Drawing.Color.Transparent
        Me.DecGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DecGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DecGroup.Location = New System.Drawing.Point(35, 585)
        Me.DecGroup.Name = "DecGroup"
        Me.DecGroup.ShadowDecoration.Parent = Me.DecGroup
        Me.DecGroup.Size = New System.Drawing.Size(453, 88)
        Me.DecGroup.TabIndex = 5
        Me.DecGroup.Visible = False
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Button4.BorderRadius = 3
        Me.Guna2Button4.BorderThickness = 1
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(13, 39)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(429, 26)
        Me.Guna2Button4.TabIndex = 3
        Me.Guna2Button4.Text = "Start decrypting"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 11.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(9, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Decryption"
        '
        'EncTab
        '
        Me.EncTab.BorderColor = System.Drawing.Color.Gray
        Me.EncTab.BorderRadius = 3
        Me.EncTab.BorderThickness = 1
        Me.EncTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.EncTab.CheckedState.Parent = Me.EncTab
        Me.EncTab.CustomImages.Parent = Me.EncTab
        Me.EncTab.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.EncTab.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EncTab.ForeColor = System.Drawing.Color.White
        Me.EncTab.HoverState.BorderColor = System.Drawing.Color.DarkGray
        Me.EncTab.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.EncTab.HoverState.ForeColor = System.Drawing.Color.Black
        Me.EncTab.HoverState.Parent = Me.EncTab
        Me.EncTab.Location = New System.Drawing.Point(36, 286)
        Me.EncTab.Name = "EncTab"
        Me.EncTab.ShadowDecoration.Parent = Me.EncTab
        Me.EncTab.Size = New System.Drawing.Size(219, 32)
        Me.EncTab.TabIndex = 8
        Me.EncTab.Text = "Encryption"
        '
        'DecTab
        '
        Me.DecTab.BorderColor = System.Drawing.Color.Gray
        Me.DecTab.BorderRadius = 3
        Me.DecTab.BorderThickness = 1
        Me.DecTab.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.DecTab.CheckedState.Parent = Me.DecTab
        Me.DecTab.CustomImages.Parent = Me.DecTab
        Me.DecTab.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.DecTab.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DecTab.ForeColor = System.Drawing.Color.White
        Me.DecTab.HoverState.BorderColor = System.Drawing.Color.DarkGray
        Me.DecTab.HoverState.FillColor = System.Drawing.Color.DarkGray
        Me.DecTab.HoverState.ForeColor = System.Drawing.Color.Black
        Me.DecTab.HoverState.Parent = Me.DecTab
        Me.DecTab.Location = New System.Drawing.Point(261, 286)
        Me.DecTab.Name = "DecTab"
        Me.DecTab.ShadowDecoration.Parent = Me.DecTab
        Me.DecTab.Size = New System.Drawing.Size(228, 32)
        Me.DecTab.TabIndex = 9
        Me.DecTab.Text = "Decryption"
        '
        'Mother
        '
        Me.Mother.Location = New System.Drawing.Point(36, 324)
        Me.Mother.Name = "Mother"
        Me.Mother.Size = New System.Drawing.Size(453, 92)
        Me.Mother.TabIndex = 10
        '
        'Bar
        '
        Me.Bar.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Bar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Bar.Location = New System.Drawing.Point(17, 22)
        Me.Bar.Name = "Bar"
        Me.Bar.ProgressColor = System.Drawing.Color.Silver
        Me.Bar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Bar.ShadowDecoration.Parent = Me.Bar
        Me.Bar.Size = New System.Drawing.Size(441, 2)
        Me.Bar.TabIndex = 11
        Me.Bar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'StatLbl
        '
        Me.StatLbl.AutoSize = True
        Me.StatLbl.BackColor = System.Drawing.Color.Transparent
        Me.StatLbl.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.StatLbl.ForeColor = System.Drawing.Color.Gray
        Me.StatLbl.Location = New System.Drawing.Point(14, 5)
        Me.StatLbl.Name = "StatLbl"
        Me.StatLbl.Size = New System.Drawing.Size(43, 13)
        Me.StatLbl.TabIndex = 4
        Me.StatLbl.Text = "Status"
        Me.StatLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LoadingPanel
        '
        Me.LoadingPanel.Controls.Add(Me.Bar)
        Me.LoadingPanel.Controls.Add(Me.StatLbl)
        Me.LoadingPanel.Location = New System.Drawing.Point(19, 422)
        Me.LoadingPanel.Name = "LoadingPanel"
        Me.LoadingPanel.Size = New System.Drawing.Size(485, 35)
        Me.LoadingPanel.TabIndex = 12
        Me.LoadingPanel.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(523, 460)
        Me.Controls.Add(Me.LoadingPanel)
        Me.Controls.Add(Me.EncGroup)
        Me.Controls.Add(Me.Mother)
        Me.Controls.Add(Me.DecTab)
        Me.Controls.Add(Me.EncTab)
        Me.Controls.Add(Me.DecGroup)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DirCrypt @ github.com/edditdev"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.EncGroup.ResumeLayout(False)
        Me.EncGroup.PerformLayout()
        Me.DecGroup.ResumeLayout(False)
        Me.DecGroup.PerformLayout()
        Me.LoadingPanel.ResumeLayout(False)
        Me.LoadingPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents FileTxtPath As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SelectDirectory As FolderBrowserDialog
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PasswordBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EncGroup As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DecGroup As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents EncTab As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DecTab As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Mother As Panel
    Friend WithEvents Bar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents StatLbl As Label
    Friend WithEvents LoadingPanel As Panel
End Class
