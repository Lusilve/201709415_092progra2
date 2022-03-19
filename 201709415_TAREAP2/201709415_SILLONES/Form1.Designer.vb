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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcantidadventas = New System.Windows.Forms.TextBox()
        Me.rbcuerina = New System.Windows.Forms.RadioButton()
        Me.rbcuero = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttoncalcular = New System.Windows.Forms.Button()
        Me.Buttonlimpiar = New System.Windows.Forms.Button()
        Me.Buttonvectores = New System.Windows.Forms.Button()
        Me.Buttonsalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcantidadventas)
        Me.GroupBox1.Controls.Add(Me.rbcuerina)
        Me.GroupBox1.Controls.Add(Me.rbcuero)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SOFA", "INDIVIDUAL", "DOBLE"})
        Me.ComboBox1.Location = New System.Drawing.Point(160, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad a Vender"
        '
        'txtcantidadventas
        '
        Me.txtcantidadventas.Location = New System.Drawing.Point(160, 24)
        Me.txtcantidadventas.Name = "txtcantidadventas"
        Me.txtcantidadventas.Size = New System.Drawing.Size(100, 26)
        Me.txtcantidadventas.TabIndex = 5
        '
        'rbcuerina
        '
        Me.rbcuerina.AutoSize = True
        Me.rbcuerina.Location = New System.Drawing.Point(223, 108)
        Me.rbcuerina.Name = "rbcuerina"
        Me.rbcuerina.Size = New System.Drawing.Size(72, 22)
        Me.rbcuerina.TabIndex = 4
        Me.rbcuerina.Text = "Cuerina"
        Me.rbcuerina.UseVisualStyleBackColor = True
        '
        'rbcuero
        '
        Me.rbcuero.AutoSize = True
        Me.rbcuero.Location = New System.Drawing.Point(160, 108)
        Me.rbcuero.Name = "rbcuero"
        Me.rbcuero.Size = New System.Drawing.Size(61, 22)
        Me.rbcuero.TabIndex = 3
        Me.rbcuero.Text = "Cuero"
        Me.rbcuero.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione Material"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione tipo Sillon"
        '
        'Buttoncalcular
        '
        Me.Buttoncalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Buttoncalcular.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Buttoncalcular.Location = New System.Drawing.Point(141, 205)
        Me.Buttoncalcular.Name = "Buttoncalcular"
        Me.Buttoncalcular.Size = New System.Drawing.Size(151, 31)
        Me.Buttoncalcular.TabIndex = 1
        Me.Buttoncalcular.Text = "Calcular"
        Me.Buttoncalcular.UseVisualStyleBackColor = False
        '
        'Buttonlimpiar
        '
        Me.Buttonlimpiar.BackColor = System.Drawing.Color.PapayaWhip
        Me.Buttonlimpiar.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Buttonlimpiar.Location = New System.Drawing.Point(432, 71)
        Me.Buttonlimpiar.Name = "Buttonlimpiar"
        Me.Buttonlimpiar.Size = New System.Drawing.Size(144, 26)
        Me.Buttonlimpiar.TabIndex = 2
        Me.Buttonlimpiar.Text = "Limpiar"
        Me.Buttonlimpiar.UseVisualStyleBackColor = False
        '
        'Buttonvectores
        '
        Me.Buttonvectores.BackColor = System.Drawing.Color.PapayaWhip
        Me.Buttonvectores.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Buttonvectores.Location = New System.Drawing.Point(432, 100)
        Me.Buttonvectores.Name = "Buttonvectores"
        Me.Buttonvectores.Size = New System.Drawing.Size(144, 26)
        Me.Buttonvectores.TabIndex = 3
        Me.Buttonvectores.Text = "Limpiar Vectores"
        Me.Buttonvectores.UseVisualStyleBackColor = False
        '
        'Buttonsalir
        '
        Me.Buttonsalir.BackColor = System.Drawing.Color.PapayaWhip
        Me.Buttonsalir.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Buttonsalir.Location = New System.Drawing.Point(432, 132)
        Me.Buttonsalir.Name = "Buttonsalir"
        Me.Buttonsalir.Size = New System.Drawing.Size(144, 29)
        Me.Buttonsalir.TabIndex = 4
        Me.Buttonsalir.Text = "Salir"
        Me.Buttonsalir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column7, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(643, 204)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Referencia"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "Cantidad"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tipo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Material"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio Costo"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "% Venta"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 75
        '
        'Column6
        '
        Me.Column6.HeaderText = "Precio Venta"
        Me.Column6.Name = "Column6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(199, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(343, 38)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FABRICA DE SILLONES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(688, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Buttonsalir)
        Me.Controls.Add(Me.Buttonvectores)
        Me.Controls.Add(Me.Buttonlimpiar)
        Me.Controls.Add(Me.Buttoncalcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbcuerina As RadioButton
    Friend WithEvents rbcuero As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Buttoncalcular As Button
    Friend WithEvents Buttonlimpiar As Button
    Friend WithEvents Buttonvectores As Button
    Friend WithEvents Buttonsalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcantidadventas As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
