<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbextranjero = New System.Windows.Forms.RadioButton()
        Me.rbguatemalteco = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtetapa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtiempo = New System.Windows.Forms.TextBox()
        Me.txtkm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GUARDARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDENARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btactualizar = New System.Windows.Forms.Button()
        Me.btconsulta = New System.Windows.Forms.Button()
        Me.txtconsulta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtminextra = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtminna = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtkpt = New System.Windows.Forms.TextBox()
        Me.txtkmpc = New System.Windows.Forms.TextBox()
        Me.txtkpro = New System.Windows.Forms.TextBox()
        Me.txtkmovistar = New System.Windows.Forms.TextBox()
        Me.txtsky = New System.Windows.Forms.TextBox()
        Me.txt45km = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.Controls.Add(Me.rbextranjero)
        Me.GroupBox1.Controls.Add(Me.rbguatemalteco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtetapa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Etapa"
        '
        'rbextranjero
        '
        Me.rbextranjero.AutoSize = True
        Me.rbextranjero.Location = New System.Drawing.Point(207, 98)
        Me.rbextranjero.Name = "rbextranjero"
        Me.rbextranjero.Size = New System.Drawing.Size(81, 19)
        Me.rbextranjero.TabIndex = 6
        Me.rbextranjero.TabStop = True
        Me.rbextranjero.Text = "Extranjero"
        Me.rbextranjero.UseVisualStyleBackColor = True
        '
        'rbguatemalteco
        '
        Me.rbguatemalteco.AutoSize = True
        Me.rbguatemalteco.Location = New System.Drawing.Point(102, 98)
        Me.rbguatemalteco.Name = "rbguatemalteco"
        Me.rbguatemalteco.Size = New System.Drawing.Size(94, 19)
        Me.rbguatemalteco.TabIndex = 5
        Me.rbguatemalteco.TabStop = True
        Me.rbguatemalteco.Text = "Guatemalteco"
        Me.rbguatemalteco.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nacionalidad"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SKY", "MOVISTAR", "PRO", "CYCLING", "PRO TEAM"})
        Me.ComboBox1.Location = New System.Drawing.Point(102, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Equipo"
        '
        'txtetapa
        '
        Me.txtetapa.Location = New System.Drawing.Point(102, 26)
        Me.txtetapa.Name = "txtetapa"
        Me.txtetapa.Size = New System.Drawing.Size(121, 23)
        Me.txtetapa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Etapa"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Controls.Add(Me.txtiempo)
        Me.GroupBox2.Controls.Add(Me.txtkm)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 124)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'txtiempo
        '
        Me.txtiempo.Location = New System.Drawing.Point(103, 78)
        Me.txtiempo.Name = "txtiempo"
        Me.txtiempo.Size = New System.Drawing.Size(100, 23)
        Me.txtiempo.TabIndex = 3
        '
        'txtkm
        '
        Me.txtkm.Location = New System.Drawing.Point(103, 35)
        Me.txtkm.Name = "txtkm"
        Me.txtkm.Size = New System.Drawing.Size(100, 23)
        Me.txtkm.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tiempo (min)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Km Recorridos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.CadetBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GUARDARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.ORDENARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GUARDARToolStripMenuItem
        '
        Me.GUARDARToolStripMenuItem.Name = "GUARDARToolStripMenuItem"
        Me.GUARDARToolStripMenuItem.Size = New System.Drawing.Size(73, 19)
        Me.GUARDARToolStripMenuItem.Text = "GUARDAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(73, 19)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'ORDENARToolStripMenuItem
        '
        Me.ORDENARToolStripMenuItem.Name = "ORDENARToolStripMenuItem"
        Me.ORDENARToolStripMenuItem.Size = New System.Drawing.Size(73, 19)
        Me.ORDENARToolStripMenuItem.Text = "ORDENAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(64, 19)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 19)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox3.Controls.Add(Me.btactualizar)
        Me.GroupBox3.Controls.Add(Me.btconsulta)
        Me.GroupBox3.Controls.Add(Me.txtconsulta)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(563, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consultar"
        '
        'btactualizar
        '
        Me.btactualizar.Location = New System.Drawing.Point(103, 60)
        Me.btactualizar.Name = "btactualizar"
        Me.btactualizar.Size = New System.Drawing.Size(75, 22)
        Me.btactualizar.TabIndex = 3
        Me.btactualizar.Text = "Actualizar"
        Me.btactualizar.UseVisualStyleBackColor = True
        '
        'btconsulta
        '
        Me.btconsulta.Location = New System.Drawing.Point(14, 60)
        Me.btconsulta.Name = "btconsulta"
        Me.btconsulta.Size = New System.Drawing.Size(75, 22)
        Me.btconsulta.TabIndex = 2
        Me.btconsulta.Text = "Consultar"
        Me.btconsulta.UseVisualStyleBackColor = True
        '
        'txtconsulta
        '
        Me.txtconsulta.Location = New System.Drawing.Point(90, 18)
        Me.txtconsulta.Name = "txtconsulta"
        Me.txtconsulta.Size = New System.Drawing.Size(100, 23)
        Me.txtconsulta.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Numero etapa"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(734, 142)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "ETAPA"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "EQUIPO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "NACIONALIDAD"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "KM RECORRIDOS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TIEMPO"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PENALIZACION"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "TIEMPO TOTAL"
        Me.Column7.Name = "Column7"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox4.Controls.Add(Me.txtminextra)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtminna)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtkpt)
        Me.GroupBox4.Controls.Add(Me.txtkmpc)
        Me.GroupBox4.Controls.Add(Me.txtkpro)
        Me.GroupBox4.Controls.Add(Me.txtkmovistar)
        Me.GroupBox4.Controls.Add(Me.txtsky)
        Me.GroupBox4.Controls.Add(Me.txt45km)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 307)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(751, 142)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estadisticas"
        '
        'txtminextra
        '
        Me.txtminextra.Location = New System.Drawing.Point(503, 90)
        Me.txtminextra.Name = "txtminextra"
        Me.txtminextra.Size = New System.Drawing.Size(236, 23)
        Me.txtminextra.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(394, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Tiempo Extranjero"
        '
        'txtminna
        '
        Me.txtminna.Location = New System.Drawing.Point(124, 90)
        Me.txtminna.Name = "txtminna"
        Me.txtminna.Size = New System.Drawing.Size(254, 23)
        Me.txtminna.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Tiempo Nacional"
        '
        'txtkpt
        '
        Me.txtkpt.Location = New System.Drawing.Point(639, 53)
        Me.txtkpt.Name = "txtkpt"
        Me.txtkpt.Size = New System.Drawing.Size(100, 23)
        Me.txtkpt.TabIndex = 11
        '
        'txtkmpc
        '
        Me.txtkmpc.Location = New System.Drawing.Point(639, 29)
        Me.txtkmpc.Name = "txtkmpc"
        Me.txtkmpc.Size = New System.Drawing.Size(100, 23)
        Me.txtkmpc.TabIndex = 10
        '
        'txtkpro
        '
        Me.txtkpro.Location = New System.Drawing.Point(412, 53)
        Me.txtkpro.Name = "txtkpro"
        Me.txtkpro.Size = New System.Drawing.Size(100, 23)
        Me.txtkpro.TabIndex = 9
        '
        'txtkmovistar
        '
        Me.txtkmovistar.Location = New System.Drawing.Point(412, 29)
        Me.txtkmovistar.Name = "txtkmovistar"
        Me.txtkmovistar.Size = New System.Drawing.Size(100, 23)
        Me.txtkmovistar.TabIndex = 8
        '
        'txtsky
        '
        Me.txtsky.Location = New System.Drawing.Point(192, 53)
        Me.txtsky.Name = "txtsky"
        Me.txtsky.Size = New System.Drawing.Size(100, 23)
        Me.txtsky.TabIndex = 7
        '
        'txt45km
        '
        Me.txt45km.Location = New System.Drawing.Point(192, 29)
        Me.txt45km.Name = "txt45km"
        Me.txt45km.Size = New System.Drawing.Size(100, 23)
        Me.txt45km.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(542, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Km pro team"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(542, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "km pro ciclyng"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "km pro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(333, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "km movistar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Km Sky"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "nocionales con mas de 45km"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(770, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbextranjero As RadioButton
    Friend WithEvents rbguatemalteco As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtetapa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtiempo As TextBox
    Friend WithEvents txtkm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GUARDARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDENARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btactualizar As Button
    Friend WithEvents btconsulta As Button
    Friend WithEvents txtconsulta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtminextra As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtminna As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtkpt As TextBox
    Friend WithEvents txtkmpc As TextBox
    Friend WithEvents txtkpro As TextBox
    Friend WithEvents txtkmovistar As TextBox
    Friend WithEvents txtsky As TextBox
    Friend WithEvents txt45km As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
