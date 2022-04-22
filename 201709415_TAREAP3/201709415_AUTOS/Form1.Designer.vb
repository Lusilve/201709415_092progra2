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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTFINAL = New System.Windows.Forms.TextBox()
        Me.TXTKINICIAL = New System.Windows.Forms.TextBox()
        Me.TXTPLACA = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTUALIZARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTCONSULTA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTFINAL)
        Me.GroupBox1.Controls.Add(Me.TXTKINICIAL)
        Me.GroupBox1.Controls.Add(Me.TXTPLACA)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE RENTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "KM FINAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "KM INICIAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NUMERO DE PLACA"
        '
        'TXTFINAL
        '
        Me.TXTFINAL.Location = New System.Drawing.Point(244, 72)
        Me.TXTFINAL.Name = "TXTFINAL"
        Me.TXTFINAL.Size = New System.Drawing.Size(72, 23)
        Me.TXTFINAL.TabIndex = 2
        '
        'TXTKINICIAL
        '
        Me.TXTKINICIAL.Location = New System.Drawing.Point(80, 70)
        Me.TXTKINICIAL.Name = "TXTKINICIAL"
        Me.TXTKINICIAL.Size = New System.Drawing.Size(71, 23)
        Me.TXTKINICIAL.TabIndex = 1
        '
        'TXTPLACA
        '
        Me.TXTPLACA.Location = New System.Drawing.Point(145, 29)
        Me.TXTPLACA.Name = "TXTPLACA"
        Me.TXTPLACA.Size = New System.Drawing.Size(171, 23)
        Me.TXTPLACA.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONE TIPO DE AUTO"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"TIPO 1", "TIPO 2", "TIPO 3", "TIPO 4"})
        Me.ComboBox1.Location = New System.Drawing.Point(37, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULOToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.CONSULTARToolStripMenuItem, Me.ACTUALIZARToolStripMenuItem, Me.ELIMINARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(772, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULOToolStripMenuItem
        '
        Me.CALCULOToolStripMenuItem.Name = "CALCULOToolStripMenuItem"
        Me.CALCULOToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CALCULOToolStripMenuItem.Text = "CALCULO"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'CONSULTARToolStripMenuItem
        '
        Me.CONSULTARToolStripMenuItem.Name = "CONSULTARToolStripMenuItem"
        Me.CONSULTARToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CONSULTARToolStripMenuItem.Text = "CONSULTAR"
        '
        'ACTUALIZARToolStripMenuItem
        '
        Me.ACTUALIZARToolStripMenuItem.Name = "ACTUALIZARToolStripMenuItem"
        Me.ACTUALIZARToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ACTUALIZARToolStripMenuItem.Text = "ACTUALIZAR"
        '
        'ELIMINARToolStripMenuItem
        '
        Me.ELIMINARToolStripMenuItem.Name = "ELIMINARToolStripMenuItem"
        Me.ELIMINARToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ELIMINARToolStripMenuItem.Text = "ELIMINAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(750, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox3.Controls.Add(Me.TXTCONSULTA)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(415, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 51)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONSULTAR"
        '
        'TXTCONSULTA
        '
        Me.TXTCONSULTA.Location = New System.Drawing.Point(58, 19)
        Me.TXTCONSULTA.Name = "TXTCONSULTA"
        Me.TXTCONSULTA.Size = New System.Drawing.Size(100, 23)
        Me.TXTCONSULTA.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PLACA"
        '
        'Column2
        '
        Me.Column2.HeaderText = "PLACA"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "TIPO"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "KM INICIAL"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "KM FINAL"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "COBRO BASE"
        Me.Column6.Name = "Column6"
        '
        'Column8
        '
        Me.Column8.HeaderText = "COBRO POR KM"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "PAGO TOTAL"
        Me.Column7.Name = "Column7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 414)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTFINAL As TextBox
    Friend WithEvents TXTKINICIAL As TextBox
    Friend WithEvents TXTPLACA As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACTUALIZARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTCONSULTA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
