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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.CombOSERVICIO = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CHKMATERNIDAD = New System.Windows.Forms.CheckBox()
        Me.CHKOPERACION = New System.Windows.Forms.CheckBox()
        Me.CHKENCAMAMIENTO = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBTCREDITO = New System.Windows.Forms.RadioButton()
        Me.RBCHEQUE = New System.Windows.Forms.RadioButton()
        Me.RBTDEBITO = New System.Windows.Forms.RadioButton()
        Me.RBEFECTIVO = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLUMN2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLUMN8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTRADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTNIT)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL PACIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NIT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOMBRE"
        '
        'TXTNIT
        '
        Me.TXTNIT.Location = New System.Drawing.Point(130, 80)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(100, 23)
        Me.TXTNIT.TabIndex = 1
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(130, 33)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(239, 23)
        Me.TXTNOMBRE.TabIndex = 0
        '
        'CombOSERVICIO
        '
        Me.CombOSERVICIO.FormattingEnabled = True
        Me.CombOSERVICIO.Items.AddRange(New Object() {"PRIVADA", "SEMIPRIVADA", "NO PRIVADA"})
        Me.CombOSERVICIO.Location = New System.Drawing.Point(33, 52)
        Me.CombOSERVICIO.Name = "CombOSERVICIO"
        Me.CombOSERVICIO.Size = New System.Drawing.Size(121, 23)
        Me.CombOSERVICIO.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SELECCIONE HABITACION"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox2.Controls.Add(Me.CHKMATERNIDAD)
        Me.GroupBox2.Controls.Add(Me.CHKOPERACION)
        Me.GroupBox2.Controls.Add(Me.CHKENCAMAMIENTO)
        Me.GroupBox2.Controls.Add(Me.CombOSERVICIO)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 202)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVICIO"
        '
        'CHKMATERNIDAD
        '
        Me.CHKMATERNIDAD.AutoSize = True
        Me.CHKMATERNIDAD.Location = New System.Drawing.Point(33, 153)
        Me.CHKMATERNIDAD.Name = "CHKMATERNIDAD"
        Me.CHKMATERNIDAD.Size = New System.Drawing.Size(99, 19)
        Me.CHKMATERNIDAD.TabIndex = 2
        Me.CHKMATERNIDAD.Text = "MATERNIDAD"
        Me.CHKMATERNIDAD.UseVisualStyleBackColor = True
        '
        'CHKOPERACION
        '
        Me.CHKOPERACION.AutoSize = True
        Me.CHKOPERACION.Location = New System.Drawing.Point(33, 128)
        Me.CHKOPERACION.Name = "CHKOPERACION"
        Me.CHKOPERACION.Size = New System.Drawing.Size(92, 19)
        Me.CHKOPERACION.TabIndex = 1
        Me.CHKOPERACION.Text = "OPERACION"
        Me.CHKOPERACION.UseVisualStyleBackColor = True
        '
        'CHKENCAMAMIENTO
        '
        Me.CHKENCAMAMIENTO.AutoSize = True
        Me.CHKENCAMAMIENTO.Location = New System.Drawing.Point(33, 103)
        Me.CHKENCAMAMIENTO.Name = "CHKENCAMAMIENTO"
        Me.CHKENCAMAMIENTO.Size = New System.Drawing.Size(119, 19)
        Me.CHKENCAMAMIENTO.TabIndex = 0
        Me.CHKENCAMAMIENTO.Text = "ENCAMAMIENTO"
        Me.CHKENCAMAMIENTO.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox3.Controls.Add(Me.RBTCREDITO)
        Me.GroupBox3.Controls.Add(Me.RBCHEQUE)
        Me.GroupBox3.Controls.Add(Me.RBTDEBITO)
        Me.GroupBox3.Controls.Add(Me.RBEFECTIVO)
        Me.GroupBox3.Location = New System.Drawing.Point(657, 84)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 149)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "METODO DE PAGO"
        '
        'RBTCREDITO
        '
        Me.RBTCREDITO.AutoSize = True
        Me.RBTCREDITO.Location = New System.Drawing.Point(26, 100)
        Me.RBTCREDITO.Name = "RBTCREDITO"
        Me.RBTCREDITO.Size = New System.Drawing.Size(83, 19)
        Me.RBTCREDITO.TabIndex = 3
        Me.RBTCREDITO.TabStop = True
        Me.RBTCREDITO.Text = "T. CREDITO"
        Me.RBTCREDITO.UseVisualStyleBackColor = True
        '
        'RBCHEQUE
        '
        Me.RBCHEQUE.AutoSize = True
        Me.RBCHEQUE.Location = New System.Drawing.Point(26, 50)
        Me.RBCHEQUE.Name = "RBCHEQUE"
        Me.RBCHEQUE.Size = New System.Drawing.Size(71, 19)
        Me.RBCHEQUE.TabIndex = 2
        Me.RBCHEQUE.TabStop = True
        Me.RBCHEQUE.Text = "CHEQUE"
        Me.RBCHEQUE.UseVisualStyleBackColor = True
        '
        'RBTDEBITO
        '
        Me.RBTDEBITO.AutoSize = True
        Me.RBTDEBITO.Location = New System.Drawing.Point(26, 75)
        Me.RBTDEBITO.Name = "RBTDEBITO"
        Me.RBTDEBITO.Size = New System.Drawing.Size(75, 19)
        Me.RBTDEBITO.TabIndex = 1
        Me.RBTDEBITO.TabStop = True
        Me.RBTDEBITO.Text = "T. DEBITO"
        Me.RBTDEBITO.UseVisualStyleBackColor = True
        '
        'RBEFECTIVO
        '
        Me.RBEFECTIVO.AutoSize = True
        Me.RBEFECTIVO.Location = New System.Drawing.Point(26, 25)
        Me.RBEFECTIVO.Name = "RBEFECTIVO"
        Me.RBEFECTIVO.Size = New System.Drawing.Size(76, 19)
        Me.RBEFECTIVO.TabIndex = 0
        Me.RBEFECTIVO.TabStop = True
        Me.RBEFECTIVO.Text = "EFECTIVO"
        Me.RBEFECTIVO.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.COLUMN2, Me.Column3, Me.Column4, Me.Column7, Me.Column5, Me.Column6, Me.COLUMN8, Me.Column12, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 296)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(915, 172)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOMBRE"
        Me.Column1.Name = "Column1"
        '
        'COLUMN2
        '
        Me.COLUMN2.HeaderText = "NIT"
        Me.COLUMN2.Name = "COLUMN2"
        Me.COLUMN2.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "HABITACION"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "DIAS HOSP."
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "ENCA."
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "OP."
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "MAT."
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'COLUMN8
        '
        Me.COLUMN8.HeaderText = "FORMA PAGO"
        Me.COLUMN8.Name = "COLUMN8"
        '
        'Column12
        '
        Me.Column12.HeaderText = "honorarios"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 75
        '
        'Column9
        '
        Me.Column9.HeaderText = "SUBTOTAL"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 75
        '
        'Column10
        '
        Me.Column10.HeaderText = "DESC./REC"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 75
        '
        'Column11
        '
        Me.Column11.HeaderText = "TOTAL"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(379, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SERVICIO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(930, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRADAToolStripMenuItem, Me.VECTORESToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'ENTRADAToolStripMenuItem
        '
        Me.ENTRADAToolStripMenuItem.Name = "ENTRADAToolStripMenuItem"
        Me.ENTRADAToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ENTRADAToolStripMenuItem.Text = "ENTRADA"
        '
        'VECTORESToolStripMenuItem
        '
        Me.VECTORESToolStripMenuItem.Name = "VECTORESToolStripMenuItem"
        Me.VECTORESToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.VECTORESToolStripMenuItem.Text = "VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(930, 492)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents CombOSERVICIO As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CHKMATERNIDAD As CheckBox
    Friend WithEvents CHKOPERACION As CheckBox
    Friend WithEvents CHKENCAMAMIENTO As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RBTCREDITO As RadioButton
    Friend WithEvents RBCHEQUE As RadioButton
    Friend WithEvents RBTDEBITO As RadioButton
    Friend WithEvents RBEFECTIVO As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTRADAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents COLUMN2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents COLUMN8 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
