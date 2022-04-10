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
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTACEPTAR = New System.Windows.Forms.Button()
        Me.BTMOSTRAR = New System.Windows.Forms.Button()
        Me.BTVECTORES = New System.Windows.Forms.Button()
        Me.BTENTRADAS = New System.Windows.Forms.Button()
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtropa = New System.Windows.Forms.TextBox()
        Me.txtplasticos = New System.Windows.Forms.TextBox()
        Me.txtdocumentos = New System.Windows.Forms.TextBox()
        Me.txtlosiones = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.lb = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.txtvalor)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(156, 74)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(100, 23)
        Me.txtvalor.TabIndex = 3
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(158, 36)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(98, 23)
        Me.txtnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor del paquete (Q)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Envio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Metodo de Envio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seleccione tipo "
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CAMION", "MOTOCICLETA"})
        Me.ComboBox2.Location = New System.Drawing.Point(140, 65)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(99, 23)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DOCUMENTOS", "ROPA", "ARTICULOS NO PERECEDEROS", "ARTICULOS DE PLASTICO", "LOCIONES"})
        Me.ComboBox1.Location = New System.Drawing.Point(140, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(99, 23)
        Me.ComboBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(12, 215)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 94)
        Me.ListBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(138, 215)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(97, 94)
        Me.ListBox2.TabIndex = 3
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 15
        Me.ListBox3.Location = New System.Drawing.Point(241, 215)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(84, 94)
        Me.ListBox3.TabIndex = 4
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 15
        Me.ListBox4.Location = New System.Drawing.Point(408, 213)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(95, 94)
        Me.ListBox4.TabIndex = 5
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 15
        Me.ListBox5.Location = New System.Drawing.Point(509, 213)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(93, 94)
        Me.ListBox5.TabIndex = 6
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 15
        Me.ListBox6.Location = New System.Drawing.Point(608, 213)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(83, 94)
        Me.ListBox6.TabIndex = 7
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 15
        Me.ListBox7.Location = New System.Drawing.Point(697, 213)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(91, 94)
        Me.ListBox7.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PeachPuff
        Me.Label5.Location = New System.Drawing.Point(12, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PeachPuff
        Me.Label6.Location = New System.Drawing.Point(136, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Paquete"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.PeachPuff
        Me.Label7.Location = New System.Drawing.Point(241, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Envio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.PeachPuff
        Me.Label8.Location = New System.Drawing.Point(405, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Valor del Paquete"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.PeachPuff
        Me.Label9.Location = New System.Drawing.Point(509, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Pago Parcial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.PeachPuff
        Me.Label10.Location = New System.Drawing.Point(608, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Impuesto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.PeachPuff
        Me.Label11.Location = New System.Drawing.Point(697, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Pago Total"
        '
        'BTACEPTAR
        '
        Me.BTACEPTAR.Location = New System.Drawing.Point(227, 146)
        Me.BTACEPTAR.Name = "BTACEPTAR"
        Me.BTACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.BTACEPTAR.TabIndex = 16
        Me.BTACEPTAR.Text = "ACEPTAR"
        Me.BTACEPTAR.UseVisualStyleBackColor = True
        '
        'BTMOSTRAR
        '
        Me.BTMOSTRAR.Location = New System.Drawing.Point(348, 146)
        Me.BTMOSTRAR.Name = "BTMOSTRAR"
        Me.BTMOSTRAR.Size = New System.Drawing.Size(75, 23)
        Me.BTMOSTRAR.TabIndex = 17
        Me.BTMOSTRAR.Text = "MOSTRAR"
        Me.BTMOSTRAR.UseVisualStyleBackColor = True
        '
        'BTVECTORES
        '
        Me.BTVECTORES.Location = New System.Drawing.Point(652, 46)
        Me.BTVECTORES.Name = "BTVECTORES"
        Me.BTVECTORES.Size = New System.Drawing.Size(136, 23)
        Me.BTVECTORES.TabIndex = 18
        Me.BTVECTORES.Text = "Limpiar Vectores "
        Me.BTVECTORES.UseVisualStyleBackColor = True
        '
        'BTENTRADAS
        '
        Me.BTENTRADAS.Location = New System.Drawing.Point(652, 84)
        Me.BTENTRADAS.Name = "BTENTRADAS"
        Me.BTENTRADAS.Size = New System.Drawing.Size(136, 23)
        Me.BTENTRADAS.TabIndex = 19
        Me.BTENTRADAS.Text = "Limpiar Entradas"
        Me.BTENTRADAS.UseVisualStyleBackColor = True
        '
        'BTSALIR
        '
        Me.BTSALIR.Location = New System.Drawing.Point(467, 146)
        Me.BTSALIR.Name = "BTSALIR"
        Me.BTSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BTSALIR.TabIndex = 20
        Me.BTSALIR.Text = "SALIR"
        Me.BTSALIR.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox3.Controls.Add(Me.txtropa)
        Me.GroupBox3.Controls.Add(Me.txtplasticos)
        Me.GroupBox3.Controls.Add(Me.txtdocumentos)
        Me.GroupBox3.Controls.Add(Me.txtlosiones)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 94)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estadisticas"
        '
        'txtropa
        '
        Me.txtropa.Location = New System.Drawing.Point(476, 54)
        Me.txtropa.Name = "txtropa"
        Me.txtropa.Size = New System.Drawing.Size(100, 23)
        Me.txtropa.TabIndex = 7
        '
        'txtplasticos
        '
        Me.txtplasticos.Location = New System.Drawing.Point(476, 18)
        Me.txtplasticos.Name = "txtplasticos"
        Me.txtplasticos.Size = New System.Drawing.Size(100, 23)
        Me.txtplasticos.TabIndex = 6
        '
        'txtdocumentos
        '
        Me.txtdocumentos.Location = New System.Drawing.Point(145, 54)
        Me.txtdocumentos.Name = "txtdocumentos"
        Me.txtdocumentos.Size = New System.Drawing.Size(100, 23)
        Me.txtdocumentos.TabIndex = 5
        '
        'txtlosiones
        '
        Me.txtlosiones.Location = New System.Drawing.Point(145, 18)
        Me.txtlosiones.Name = "txtlosiones"
        Me.txtlosiones.Size = New System.Drawing.Size(100, 23)
        Me.txtlosiones.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(265, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Total de ropa enviada"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Envios Documentos(Q)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(195, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Total de articulos plasticos enviados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Envios losiones (Q)"
        '
        'ListBox8
        '
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 15
        Me.ListBox8.Location = New System.Drawing.Point(331, 215)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(71, 94)
        Me.ListBox8.TabIndex = 22
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.BackColor = System.Drawing.Color.PeachPuff
        Me.lb.Location = New System.Drawing.Point(334, 196)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(32, 15)
        Me.lb.TabIndex = 23
        Me.lb.Text = "Peso"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BTSALIR)
        Me.Controls.Add(Me.BTENTRADAS)
        Me.Controls.Add(Me.BTVECTORES)
        Me.Controls.Add(Me.BTMOSTRAR)
        Me.Controls.Add(Me.BTACEPTAR)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "ENVIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BTACEPTAR As Button
    Friend WithEvents BTMOSTRAR As Button
    Friend WithEvents BTVECTORES As Button
    Friend WithEvents BTENTRADAS As Button
    Friend WithEvents BTSALIR As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtropa As TextBox
    Friend WithEvents txtplasticos As TextBox
    Friend WithEvents txtdocumentos As TextBox
    Friend WithEvents txtlosiones As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ListBox8 As ListBox
    Friend WithEvents lb As Label
End Class
