<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnMenu1 = New BtnMenu.BtnMenu()
        Me.LblFontes1 = New LblFontes.LblFontes()
        Me.BtnImagem3 = New BtnImagem.BtnImagem()
        Me.BtnImagem2 = New BtnImagem.BtnImagem()
        Me.BtnImagem1 = New BtnImagem.BtnImagem()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.BtnMenu1)
        Me.Panel1.Controls.Add(Me.LblFontes1)
        Me.Panel1.Controls.Add(Me.BtnImagem3)
        Me.Panel1.Controls.Add(Me.BtnImagem2)
        Me.Panel1.Controls.Add(Me.BtnImagem1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 258)
        Me.Panel1.TabIndex = 2
        '
        'BtnMenu1
        '
        Me.BtnMenu1.BackColor = System.Drawing.Color.Transparent
        Me.BtnMenu1.Location = New System.Drawing.Point(201, 3)
        Me.BtnMenu1.Name = "BtnMenu1"
        Me.BtnMenu1.Size = New System.Drawing.Size(32, 32)
        Me.BtnMenu1.TabIndex = 8
        Me.BtnMenu1.zEstadoBotao = False
        '
        'LblFontes1
        '
        Me.LblFontes1.BackColor = System.Drawing.Color.Transparent
        Me.LblFontes1.Location = New System.Drawing.Point(-13, 0)
        Me.LblFontes1.Name = "LblFontes1"
        Me.LblFontes1.Size = New System.Drawing.Size(132, 34)
        Me.LblFontes1.TabIndex = 7
        Me.LblFontes1.zTamanhoLetra = 12
        Me.LblFontes1.zTexto = "PAP Titulo"
        '
        'BtnImagem3
        '
        Me.BtnImagem3.BackColor = System.Drawing.Color.SlateGray
        Me.BtnImagem3.Location = New System.Drawing.Point(0, 156)
        Me.BtnImagem3.Name = "BtnImagem3"
        Me.BtnImagem3.Size = New System.Drawing.Size(237, 44)
        Me.BtnImagem3.TabIndex = 6
        Me.BtnImagem3.zAlturaImagem = 38
        Me.BtnImagem3.zComprimentoImagem = 38
        Me.BtnImagem3.zCorFundo = System.Drawing.Color.SlateGray
        Me.BtnImagem3.zCorHover = System.Drawing.Color.LightSlateGray
        Me.BtnImagem3.zCorSelecionado = System.Drawing.Color.SteelBlue
        Me.BtnImagem3.zEstadoBotao = False
        Me.BtnImagem3.zImagem = Global.WindowsApplication1.My.Resources.Resources._9
        Me.BtnImagem3.zTamanhoLetra = 8
        Me.BtnImagem3.zTexto = "Coisa 2"
        '
        'BtnImagem2
        '
        Me.BtnImagem2.BackColor = System.Drawing.Color.SlateGray
        Me.BtnImagem2.Location = New System.Drawing.Point(0, 107)
        Me.BtnImagem2.Name = "BtnImagem2"
        Me.BtnImagem2.Size = New System.Drawing.Size(237, 44)
        Me.BtnImagem2.TabIndex = 5
        Me.BtnImagem2.zAlturaImagem = 38
        Me.BtnImagem2.zComprimentoImagem = 38
        Me.BtnImagem2.zCorFundo = System.Drawing.Color.SlateGray
        Me.BtnImagem2.zCorHover = System.Drawing.Color.LightSlateGray
        Me.BtnImagem2.zCorSelecionado = System.Drawing.Color.SteelBlue
        Me.BtnImagem2.zEstadoBotao = False
        Me.BtnImagem2.zImagem = CType(resources.GetObject("BtnImagem2.zImagem"), System.Drawing.Bitmap)
        Me.BtnImagem2.zTamanhoLetra = 8
        Me.BtnImagem2.zTexto = "Coisa 1"
        '
        'BtnImagem1
        '
        Me.BtnImagem1.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnImagem1.Location = New System.Drawing.Point(0, 57)
        Me.BtnImagem1.Name = "BtnImagem1"
        Me.BtnImagem1.Size = New System.Drawing.Size(237, 44)
        Me.BtnImagem1.TabIndex = 4
        Me.BtnImagem1.zAlturaImagem = 38
        Me.BtnImagem1.zComprimentoImagem = 38
        Me.BtnImagem1.zCorFundo = System.Drawing.Color.SlateGray
        Me.BtnImagem1.zCorHover = System.Drawing.Color.LightSlateGray
        Me.BtnImagem1.zCorSelecionado = System.Drawing.Color.SteelBlue
        Me.BtnImagem1.zEstadoBotao = True
        Me.BtnImagem1.zImagem = Global.WindowsApplication1.My.Resources.Resources._1
        Me.BtnImagem1.zTamanhoLetra = 8
        Me.BtnImagem1.zTexto = "Inicio"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(307, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(483, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ME.CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(345, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ME.CLOSE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(317, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'tmr
        '
        Me.tmr.Interval = 1
        '
        'tmr2
        '
        Me.tmr2.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(456, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents BtnImagem3 As BtnImagem.BtnImagem
    Friend WithEvents BtnImagem2 As BtnImagem.BtnImagem
    Friend WithEvents BtnImagem1 As BtnImagem.BtnImagem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblFontes1 As LblFontes.LblFontes
    Friend WithEvents BtnMenu1 As BtnMenu.BtnMenu

End Class
