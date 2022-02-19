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
        Me.RBLARGE = New System.Windows.Forms.RadioButton()
        Me.RBMEDIUM = New System.Windows.Forms.RadioButton()
        Me.RBSMALL = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBLONA = New System.Windows.Forms.RadioButton()
        Me.RBSEDA = New System.Windows.Forms.RadioButton()
        Me.RBALGODON = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.ButtonCALCULAR = New System.Windows.Forms.Button()
        Me.ButtonLIMPIAR = New System.Windows.Forms.Button()
        Me.BUTTONSALIR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RBLARGE)
        Me.GroupBox1.Controls.Add(Me.RBMEDIUM)
        Me.GroupBox1.Controls.Add(Me.RBSMALL)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE TAMAÑO"
        '
        'RBLARGE
        '
        Me.RBLARGE.AutoSize = True
        Me.RBLARGE.Location = New System.Drawing.Point(29, 100)
        Me.RBLARGE.Name = "RBLARGE"
        Me.RBLARGE.Size = New System.Drawing.Size(64, 21)
        Me.RBLARGE.TabIndex = 2
        Me.RBLARGE.Text = "LARGE"
        Me.RBLARGE.UseVisualStyleBackColor = True
        '
        'RBMEDIUM
        '
        Me.RBMEDIUM.AutoSize = True
        Me.RBMEDIUM.Location = New System.Drawing.Point(29, 71)
        Me.RBMEDIUM.Name = "RBMEDIUM"
        Me.RBMEDIUM.Size = New System.Drawing.Size(79, 21)
        Me.RBMEDIUM.TabIndex = 1
        Me.RBMEDIUM.Text = "MEDIUM"
        Me.RBMEDIUM.UseVisualStyleBackColor = True
        '
        'RBSMALL
        '
        Me.RBSMALL.AutoSize = True
        Me.RBSMALL.Location = New System.Drawing.Point(29, 43)
        Me.RBSMALL.Name = "RBSMALL"
        Me.RBSMALL.Size = New System.Drawing.Size(66, 21)
        Me.RBSMALL.TabIndex = 0
        Me.RBSMALL.Text = "SMALL"
        Me.RBSMALL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.RBLONA)
        Me.GroupBox2.Controls.Add(Me.RBSEDA)
        Me.GroupBox2.Controls.Add(Me.RBALGODON)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 129)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONE MATERIAL"
        '
        'RBLONA
        '
        Me.RBLONA.AutoSize = True
        Me.RBLONA.Location = New System.Drawing.Point(41, 93)
        Me.RBLONA.Name = "RBLONA"
        Me.RBLONA.Size = New System.Drawing.Size(61, 21)
        Me.RBLONA.TabIndex = 2
        Me.RBLONA.Text = "LONA"
        Me.RBLONA.UseVisualStyleBackColor = True
        '
        'RBSEDA
        '
        Me.RBSEDA.AutoSize = True
        Me.RBSEDA.Location = New System.Drawing.Point(41, 65)
        Me.RBSEDA.Name = "RBSEDA"
        Me.RBSEDA.Size = New System.Drawing.Size(59, 21)
        Me.RBSEDA.TabIndex = 1
        Me.RBSEDA.Text = "SEDA"
        Me.RBSEDA.UseVisualStyleBackColor = True
        '
        'RBALGODON
        '
        Me.RBALGODON.AutoSize = True
        Me.RBALGODON.Location = New System.Drawing.Point(41, 36)
        Me.RBALGODON.Name = "RBALGODON"
        Me.RBALGODON.Size = New System.Drawing.Size(88, 21)
        Me.RBALGODON.TabIndex = 0
        Me.RBALGODON.Text = "ALGODON"
        Me.RBALGODON.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TXTCANTIDAD)
        Me.GroupBox3.Location = New System.Drawing.Point(34, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 91)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INGRESE CANTIDAD"
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(6, 23)
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(138, 24)
        Me.TXTCANTIDAD.TabIndex = 0
        '
        'ButtonCALCULAR
        '
        Me.ButtonCALCULAR.Location = New System.Drawing.Point(232, 178)
        Me.ButtonCALCULAR.Name = "ButtonCALCULAR"
        Me.ButtonCALCULAR.Size = New System.Drawing.Size(87, 26)
        Me.ButtonCALCULAR.TabIndex = 3
        Me.ButtonCALCULAR.Text = "CALCULAR"
        Me.ButtonCALCULAR.UseVisualStyleBackColor = True
        '
        'ButtonLIMPIAR
        '
        Me.ButtonLIMPIAR.Location = New System.Drawing.Point(232, 213)
        Me.ButtonLIMPIAR.Name = "ButtonLIMPIAR"
        Me.ButtonLIMPIAR.Size = New System.Drawing.Size(87, 26)
        Me.ButtonLIMPIAR.TabIndex = 4
        Me.ButtonLIMPIAR.Text = "LIMPIAR"
        Me.ButtonLIMPIAR.UseVisualStyleBackColor = True
        '
        'BUTTONSALIR
        '
        Me.BUTTONSALIR.Location = New System.Drawing.Point(232, 244)
        Me.BUTTONSALIR.Name = "BUTTONSALIR"
        Me.BUTTONSALIR.Size = New System.Drawing.Size(87, 26)
        Me.BUTTONSALIR.TabIndex = 5
        Me.BUTTONSALIR.Text = "SALIR"
        Me.BUTTONSALIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(381, 346)
        Me.Controls.Add(Me.BUTTONSALIR)
        Me.Controls.Add(Me.ButtonLIMPIAR)
        Me.Controls.Add(Me.ButtonCALCULAR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTA DE CHUMPAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBLARGE As RadioButton
    Friend WithEvents RBMEDIUM As RadioButton
    Friend WithEvents RBSMALL As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBLONA As RadioButton
    Friend WithEvents RBSEDA As RadioButton
    Friend WithEvents RBALGODON As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTCANTIDAD As TextBox
    Friend WithEvents ButtonCALCULAR As Button
    Friend WithEvents ButtonLIMPIAR As Button
    Friend WithEvents BUTTONSALIR As Button
End Class
