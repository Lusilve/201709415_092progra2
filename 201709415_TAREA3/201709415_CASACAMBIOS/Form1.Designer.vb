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
        Me.CBventa = New System.Windows.Forms.CheckBox()
        Me.cbcompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTVENTA = New System.Windows.Forms.TextBox()
        Me.TXTCOMPRA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbcocolo = New System.Windows.Forms.RadioButton()
        Me.rbcoeu = New System.Windows.Forms.RadioButton()
        Me.rbcope = New System.Windows.Forms.RadioButton()
        Me.Rbcodo = New System.Windows.Forms.RadioButton()
        Me.rbvenco = New System.Windows.Forms.RadioButton()
        Me.rbvene = New System.Windows.Forms.RadioButton()
        Me.rbvenpe = New System.Windows.Forms.RadioButton()
        Me.rbvendo = New System.Windows.Forms.RadioButton()
        Me.ButtonCALCULAR = New System.Windows.Forms.Button()
        Me.ButtonLIMPIAR = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox1.Controls.Add(Me.CBventa)
        Me.GroupBox1.Controls.Add(Me.cbcompra)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(196, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaccion"
        '
        'CBventa
        '
        Me.CBventa.AutoSize = True
        Me.CBventa.Location = New System.Drawing.Point(19, 75)
        Me.CBventa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBventa.Name = "CBventa"
        Me.CBventa.Size = New System.Drawing.Size(85, 27)
        Me.CBventa.TabIndex = 1
        Me.CBventa.Text = "VENTA"
        Me.CBventa.UseVisualStyleBackColor = True
        '
        'cbcompra
        '
        Me.cbcompra.AutoSize = True
        Me.cbcompra.Location = New System.Drawing.Point(21, 34)
        Me.cbcompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbcompra.Name = "cbcompra"
        Me.cbcompra.Size = New System.Drawing.Size(98, 27)
        Me.cbcompra.TabIndex = 0
        Me.cbcompra.Text = "COMPRA"
        Me.cbcompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox2.Controls.Add(Me.TXTVENTA)
        Me.GroupBox2.Controls.Add(Me.TXTCOMPRA)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(120, 270)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(216, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cantidad"
        '
        'TXTVENTA
        '
        Me.TXTVENTA.Enabled = False
        Me.TXTVENTA.Location = New System.Drawing.Point(113, 66)
        Me.TXTVENTA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTVENTA.Name = "TXTVENTA"
        Me.TXTVENTA.Size = New System.Drawing.Size(81, 30)
        Me.TXTVENTA.TabIndex = 3
        Me.TXTVENTA.Text = "0.00"
        '
        'TXTCOMPRA
        '
        Me.TXTCOMPRA.Enabled = False
        Me.TXTCOMPRA.Location = New System.Drawing.Point(113, 28)
        Me.TXTCOMPRA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTCOMPRA.Name = "TXTCOMPRA"
        Me.TXTCOMPRA.Size = New System.Drawing.Size(81, 30)
        Me.TXTCOMPRA.TabIndex = 2
        Me.TXTCOMPRA.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VENTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPRA"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rbcocolo)
        Me.GroupBox3.Controls.Add(Me.rbcoeu)
        Me.GroupBox3.Controls.Add(Me.rbcope)
        Me.GroupBox3.Controls.Add(Me.Rbcodo)
        Me.GroupBox3.Location = New System.Drawing.Point(234, 18)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(210, 227)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SELECCIONE CAMBIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "COMPRA"
        '
        'rbcocolo
        '
        Me.rbcocolo.AutoSize = True
        Me.rbcocolo.Location = New System.Drawing.Point(24, 178)
        Me.rbcocolo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbcocolo.Name = "rbcocolo"
        Me.rbcocolo.Size = New System.Drawing.Size(82, 27)
        Me.rbcocolo.TabIndex = 3
        Me.rbcocolo.TabStop = True
        Me.rbcocolo.Text = "Colones"
        Me.rbcocolo.UseVisualStyleBackColor = True
        '
        'rbcoeu
        '
        Me.rbcoeu.AutoSize = True
        Me.rbcoeu.Location = New System.Drawing.Point(24, 140)
        Me.rbcoeu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbcoeu.Name = "rbcoeu"
        Me.rbcoeu.Size = New System.Drawing.Size(69, 27)
        Me.rbcoeu.TabIndex = 2
        Me.rbcoeu.TabStop = True
        Me.rbcoeu.Text = "Euros"
        Me.rbcoeu.UseVisualStyleBackColor = True
        '
        'rbcope
        '
        Me.rbcope.AutoSize = True
        Me.rbcope.Location = New System.Drawing.Point(24, 101)
        Me.rbcope.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbcope.Name = "rbcope"
        Me.rbcope.Size = New System.Drawing.Size(133, 27)
        Me.rbcope.TabIndex = 1
        Me.rbcope.TabStop = True
        Me.rbcope.Text = "Peso Mexicano"
        Me.rbcope.UseVisualStyleBackColor = True
        '
        'Rbcodo
        '
        Me.Rbcodo.AutoSize = True
        Me.Rbcodo.Location = New System.Drawing.Point(24, 63)
        Me.Rbcodo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rbcodo.Name = "Rbcodo"
        Me.Rbcodo.Size = New System.Drawing.Size(74, 27)
        Me.Rbcodo.TabIndex = 0
        Me.Rbcodo.TabStop = True
        Me.Rbcodo.Text = "Dollar"
        Me.Rbcodo.UseVisualStyleBackColor = True
        '
        'rbvenco
        '
        Me.rbvenco.AutoSize = True
        Me.rbvenco.Location = New System.Drawing.Point(9, 153)
        Me.rbvenco.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbvenco.Name = "rbvenco"
        Me.rbvenco.Size = New System.Drawing.Size(82, 27)
        Me.rbvenco.TabIndex = 7
        Me.rbvenco.TabStop = True
        Me.rbvenco.Text = "Colones"
        Me.rbvenco.UseVisualStyleBackColor = True
        '
        'rbvene
        '
        Me.rbvene.AutoSize = True
        Me.rbvene.Location = New System.Drawing.Point(9, 115)
        Me.rbvene.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbvene.Name = "rbvene"
        Me.rbvene.Size = New System.Drawing.Size(69, 27)
        Me.rbvene.TabIndex = 6
        Me.rbvene.TabStop = True
        Me.rbvene.Text = "Euros"
        Me.rbvene.UseVisualStyleBackColor = True
        '
        'rbvenpe
        '
        Me.rbvenpe.AutoSize = True
        Me.rbvenpe.Location = New System.Drawing.Point(9, 77)
        Me.rbvenpe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbvenpe.Name = "rbvenpe"
        Me.rbvenpe.Size = New System.Drawing.Size(133, 27)
        Me.rbvenpe.TabIndex = 5
        Me.rbvenpe.TabStop = True
        Me.rbvenpe.Text = "Peso Mexicano"
        Me.rbvenpe.UseVisualStyleBackColor = True
        '
        'rbvendo
        '
        Me.rbvendo.AutoSize = True
        Me.rbvendo.Location = New System.Drawing.Point(9, 38)
        Me.rbvendo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbvendo.Name = "rbvendo"
        Me.rbvendo.Size = New System.Drawing.Size(74, 27)
        Me.rbvendo.TabIndex = 4
        Me.rbvendo.TabStop = True
        Me.rbvendo.Text = "Dollar"
        Me.rbvendo.UseVisualStyleBackColor = True
        '
        'ButtonCALCULAR
        '
        Me.ButtonCALCULAR.Location = New System.Drawing.Point(404, 270)
        Me.ButtonCALCULAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonCALCULAR.Name = "ButtonCALCULAR"
        Me.ButtonCALCULAR.Size = New System.Drawing.Size(119, 31)
        Me.ButtonCALCULAR.TabIndex = 3
        Me.ButtonCALCULAR.Text = "CALCULAR"
        Me.ButtonCALCULAR.UseVisualStyleBackColor = True
        '
        'ButtonLIMPIAR
        '
        Me.ButtonLIMPIAR.Location = New System.Drawing.Point(404, 310)
        Me.ButtonLIMPIAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonLIMPIAR.Name = "ButtonLIMPIAR"
        Me.ButtonLIMPIAR.Size = New System.Drawing.Size(119, 31)
        Me.ButtonLIMPIAR.TabIndex = 4
        Me.ButtonLIMPIAR.Text = "LIMPIAR"
        Me.ButtonLIMPIAR.UseVisualStyleBackColor = True
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(404, 350)
        Me.SALIR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(119, 31)
        Me.SALIR.TabIndex = 5
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GroupBox4.Controls.Add(Me.rbvenco)
        Me.GroupBox4.Controls.Add(Me.rbvene)
        Me.GroupBox4.Controls.Add(Me.rbvenpe)
        Me.GroupBox4.Controls.Add(Me.rbvendo)
        Me.GroupBox4.Location = New System.Drawing.Point(444, 48)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(178, 198)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "VENTA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(643, 429)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.ButtonLIMPIAR)
        Me.Controls.Add(Me.ButtonCALCULAR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBventa As CheckBox
    Friend WithEvents cbcompra As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXTCOMPRA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTVENTA As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbvenco As RadioButton
    Friend WithEvents rbvene As RadioButton
    Friend WithEvents rbvenpe As RadioButton
    Friend WithEvents rbvendo As RadioButton
    Friend WithEvents rbcocolo As RadioButton
    Friend WithEvents rbcoeu As RadioButton
    Friend WithEvents rbcope As RadioButton
    Friend WithEvents Rbcodo As RadioButton
    Friend WithEvents ButtonCALCULAR As Button
    Friend WithEvents ButtonLIMPIAR As Button
    Friend WithEvents SALIR As Button
    Friend WithEvents GroupBox4 As GroupBox
End Class
