﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblidade = New System.Windows.Forms.Label()
        Me.lbllocalidade = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.chkMorada = New System.Windows.Forms.CheckBox()
        Me.chkMorada1 = New System.Windows.Forms.CheckBox()
        Me.chkNIF = New System.Windows.Forms.CheckBox()
        Me.chknome = New System.Windows.Forms.CheckBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.rctNome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctTelemovel = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctIII = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctMorada = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctNIF = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckkTel = New System.Windows.Forms.CheckBox()
        Me.mtbTlm = New System.Windows.Forms.MaskedTextBox()
        Me.mtbNIF = New System.Windows.Forms.MaskedTextBox()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.cmblocalidade = New System.Windows.Forms.ComboBox()
        Me.pnl1.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl1.Controls.Add(Me.pct1)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(682, 93)
        Me.pnl1.TabIndex = 4
        '
        'pct1
        '
        Me.pct1.BackgroundImage = CType(resources.GetObject("pct1.BackgroundImage"), System.Drawing.Image)
        Me.pct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct1.Location = New System.Drawing.Point(3, 5)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(88, 88)
        Me.pct1.TabIndex = 42
        Me.pct1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(96, 21)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(586, 55)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Clientes"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblidade
        '
        Me.lblidade.AutoSize = True
        Me.lblidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidade.ForeColor = System.Drawing.Color.White
        Me.lblidade.Location = New System.Drawing.Point(627, 552)
        Me.lblidade.Name = "lblidade"
        Me.lblidade.Size = New System.Drawing.Size(19, 14)
        Me.lblidade.TabIndex = 17
        Me.lblidade.Text = "---"
        '
        'lbllocalidade
        '
        Me.lbllocalidade.AutoSize = True
        Me.lbllocalidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocalidade.ForeColor = System.Drawing.Color.White
        Me.lbllocalidade.Location = New System.Drawing.Point(627, 596)
        Me.lbllocalidade.Name = "lbllocalidade"
        Me.lbllocalidade.Size = New System.Drawing.Size(19, 14)
        Me.lbllocalidade.TabIndex = 20
        Me.lbllocalidade.Text = "---"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.ForeColor = System.Drawing.Color.White
        Me.lblnome.Location = New System.Drawing.Point(627, 529)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(19, 14)
        Me.lblnome.TabIndex = 16
        Me.lblnome.Text = "---"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.White
        Me.lblemail.Location = New System.Drawing.Point(627, 574)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(19, 14)
        Me.lblemail.TabIndex = 19
        Me.lblemail.Text = "---"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.Color.White
        Me.lbl13.Location = New System.Drawing.Point(535, 596)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(57, 14)
        Me.lbl13.TabIndex = 11
        Me.lbl13.Text = "Telemóvel:"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.White
        Me.lbl12.Location = New System.Drawing.Point(535, 574)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(46, 14)
        Me.lbl12.TabIndex = 9
        Me.lbl12.Text = "Morada:"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.White
        Me.lbl10.Location = New System.Drawing.Point(535, 552)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(25, 14)
        Me.lbl10.TabIndex = 5
        Me.lbl10.Text = "NIF:"
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.White
        Me.lbl9.Location = New System.Drawing.Point(535, 529)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(87, 14)
        Me.lbl9.TabIndex = 0
        Me.lbl9.Text = "Nome do Cliente:"
        '
        'chkMorada
        '
        Me.chkMorada.AutoSize = True
        Me.chkMorada.Location = New System.Drawing.Point(743, 342)
        Me.chkMorada.Name = "chkMorada"
        Me.chkMorada.Size = New System.Drawing.Size(15, 14)
        Me.chkMorada.TabIndex = 25
        Me.chkMorada.UseVisualStyleBackColor = True
        '
        'chkMorada1
        '
        Me.chkMorada1.AutoSize = True
        Me.chkMorada1.Location = New System.Drawing.Point(743, 281)
        Me.chkMorada1.Name = "chkMorada1"
        Me.chkMorada1.Size = New System.Drawing.Size(15, 14)
        Me.chkMorada1.TabIndex = 24
        Me.chkMorada1.UseVisualStyleBackColor = True
        '
        'chkNIF
        '
        Me.chkNIF.AutoSize = True
        Me.chkNIF.Location = New System.Drawing.Point(743, 218)
        Me.chkNIF.Name = "chkNIF"
        Me.chkNIF.Size = New System.Drawing.Size(15, 14)
        Me.chkNIF.TabIndex = 23
        Me.chkNIF.UseVisualStyleBackColor = True
        '
        'chknome
        '
        Me.chknome.AutoSize = True
        Me.chknome.Location = New System.Drawing.Point(743, 156)
        Me.chknome.Name = "chknome"
        Me.chknome.Size = New System.Drawing.Size(15, 14)
        Me.chknome.TabIndex = 22
        Me.chknome.UseVisualStyleBackColor = True
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(518, 258)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(32, 15)
        Me.lbl6.TabIndex = 22
        Me.lbl6.Text = "Rua:"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(518, 196)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(212, 15)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "Número de Indetificação Fiscal (NIF):"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(518, 135)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(102, 15)
        Me.lbl2.TabIndex = 20
        Me.lbl2.Text = "Nome do Cliente:"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(76, 135)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(436, 509)
        Me.dgv1.TabIndex = 15
        '
        'rctNome
        '
        Me.rctNome.BackColor = System.Drawing.Color.White
        Me.rctNome.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctNome.BorderColor = System.Drawing.Color.White
        Me.rctNome.CornerRadius = 2
        Me.rctNome.Location = New System.Drawing.Point(521, 150)
        Me.rctNome.Name = "rctNome"
        Me.rctNome.Size = New System.Drawing.Size(210, 25)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctTelemovel, Me.rctIII, Me.rctMorada, Me.rctNIF, Me.rctNome})
        Me.ShapeContainer1.Size = New System.Drawing.Size(781, 662)
        Me.ShapeContainer1.TabIndex = 26
        Me.ShapeContainer1.TabStop = False
        '
        'rctTelemovel
        '
        Me.rctTelemovel.BackColor = System.Drawing.Color.White
        Me.rctTelemovel.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctTelemovel.BorderColor = System.Drawing.Color.White
        Me.rctTelemovel.CornerRadius = 2
        Me.rctTelemovel.Location = New System.Drawing.Point(521, 401)
        Me.rctTelemovel.Name = "rctTelemovel"
        Me.rctTelemovel.Size = New System.Drawing.Size(210, 25)
        '
        'rctIII
        '
        Me.rctIII.BackColor = System.Drawing.Color.White
        Me.rctIII.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctIII.BorderColor = System.Drawing.Color.White
        Me.rctIII.CornerRadius = 2
        Me.rctIII.Location = New System.Drawing.Point(520, 336)
        Me.rctIII.Name = "rctIII"
        Me.rctIII.Size = New System.Drawing.Size(210, 25)
        '
        'rctMorada
        '
        Me.rctMorada.BackColor = System.Drawing.Color.White
        Me.rctMorada.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctMorada.BorderColor = System.Drawing.Color.White
        Me.rctMorada.CornerRadius = 2
        Me.rctMorada.Location = New System.Drawing.Point(521, 274)
        Me.rctMorada.Name = "rctMorada"
        Me.rctMorada.Size = New System.Drawing.Size(210, 25)
        '
        'rctNIF
        '
        Me.rctNIF.BackColor = System.Drawing.Color.White
        Me.rctNIF.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctNIF.BorderColor = System.Drawing.Color.White
        Me.rctNIF.CornerRadius = 2
        Me.rctNIF.Location = New System.Drawing.Point(521, 212)
        Me.rctNIF.Name = "rctNIF"
        Me.rctNIF.Size = New System.Drawing.Size(210, 25)
        '
        'txtnome
        '
        Me.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.ForeColor = System.Drawing.Color.Black
        Me.txtnome.Location = New System.Drawing.Point(530, 156)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(193, 14)
        Me.txtnome.TabIndex = 27
        Me.txtnome.Tag = ""
        '
        'txtRua
        '
        Me.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRua.ForeColor = System.Drawing.Color.Black
        Me.txtRua.Location = New System.Drawing.Point(530, 280)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(193, 14)
        Me.txtRua.TabIndex = 28
        Me.txtRua.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(518, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Localidade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(518, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Telemóvel:"
        '
        'ckkTel
        '
        Me.ckkTel.AutoSize = True
        Me.ckkTel.Location = New System.Drawing.Point(743, 408)
        Me.ckkTel.Name = "ckkTel"
        Me.ckkTel.Size = New System.Drawing.Size(15, 14)
        Me.ckkTel.TabIndex = 32
        Me.ckkTel.UseVisualStyleBackColor = True
        '
        'mtbTlm
        '
        Me.mtbTlm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbTlm.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.mtbTlm.Location = New System.Drawing.Point(529, 408)
        Me.mtbTlm.Mask = "000000000"
        Me.mtbTlm.Name = "mtbTlm"
        Me.mtbTlm.Size = New System.Drawing.Size(195, 14)
        Me.mtbTlm.TabIndex = 33
        '
        'mtbNIF
        '
        Me.mtbNIF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNIF.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.mtbNIF.Location = New System.Drawing.Point(528, 218)
        Me.mtbNIF.Mask = "000000000"
        Me.mtbNIF.Name = "mtbNIF"
        Me.mtbNIF.Size = New System.Drawing.Size(195, 14)
        Me.mtbNIF.TabIndex = 35
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 662)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.Black
        Me.btnEntrar.Location = New System.Drawing.Point(520, 464)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(77, 22)
        Me.btnEntrar.TabIndex = 39
        Me.btnEntrar.Text = "Inserir"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(603, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 22)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Procurar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(681, 464)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 22)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Alterar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(517, 502)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Cliente selecionado"
        '
        'btnDesativar
        '
        Me.btnDesativar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDesativar.FlatAppearance.BorderSize = 0
        Me.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesativar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ForeColor = System.Drawing.Color.Black
        Me.btnDesativar.Location = New System.Drawing.Point(520, 622)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(236, 22)
        Me.btnDesativar.TabIndex = 43
        Me.btnDesativar.Text = "Desativar Cliente"
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'cmblocalidade
        '
        Me.cmblocalidade.BackColor = System.Drawing.Color.White
        Me.cmblocalidade.FormattingEnabled = True
        Me.cmblocalidade.Location = New System.Drawing.Point(530, 338)
        Me.cmblocalidade.Name = "cmblocalidade"
        Me.cmblocalidade.Size = New System.Drawing.Size(193, 21)
        Me.cmblocalidade.TabIndex = 44
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 662)
        Me.Controls.Add(Me.cmblocalidade)
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.lbllocalidade)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lblidade)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lblnome)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.mtbNIF)
        Me.Controls.Add(Me.mtbTlm)
        Me.Controls.Add(Me.ckkTel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.chkMorada)
        Me.Controls.Add(Me.chkMorada1)
        Me.Controls.Add(Me.chkNIF)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.chknome)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.pnl1.ResumeLayout(False)
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblidade As System.Windows.Forms.Label
    Friend WithEvents lbllocalidade As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents chkMorada As System.Windows.Forms.CheckBox
    Friend WithEvents chkMorada1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNIF As System.Windows.Forms.CheckBox
    Friend WithEvents chknome As System.Windows.Forms.CheckBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents rctNome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents rctIII As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctMorada As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctNIF As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtRua As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rctTelemovel As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckkTel As System.Windows.Forms.CheckBox
    Friend WithEvents mtbTlm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbNIF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents cmblocalidade As System.Windows.Forms.ComboBox
End Class
