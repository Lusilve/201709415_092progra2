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
        Me.txtvalorbruto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Groupbox2 = New System.Windows.Forms.GroupBox()
        Me.RBTELEVISOR = New System.Windows.Forms.RadioButton()
        Me.RBCELULAR = New System.Windows.Forms.RadioButton()
        Me.RBDRONE = New System.Windows.Forms.RadioButton()
        Me.Rbtablet = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Buttoncalc = New System.Windows.Forms.Button()
        Me.Buttonlimpiar = New System.Windows.Forms.Button()
        Me.Buttonlimpiarvec = New System.Windows.Forms.Button()
        Me.Buttonsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Groupbox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtvalorbruto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtvalorbruto
        '
        Me.txtvalorbruto.Location = New System.Drawing.Point(102, 87)
        Me.txtvalorbruto.Name = "txtvalorbruto"
        Me.txtvalorbruto.Size = New System.Drawing.Size(100, 23)
        Me.txtvalorbruto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor del bruto"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(102, 30)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 23)
        Me.txtnombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre "
        '
        'Groupbox2
        '
        Me.Groupbox2.Controls.Add(Me.RBTELEVISOR)
        Me.Groupbox2.Controls.Add(Me.RBCELULAR)
        Me.Groupbox2.Controls.Add(Me.RBDRONE)
        Me.Groupbox2.Controls.Add(Me.Rbtablet)
        Me.Groupbox2.Location = New System.Drawing.Point(341, 35)
        Me.Groupbox2.Name = "Groupbox2"
        Me.Groupbox2.Size = New System.Drawing.Size(186, 144)
        Me.Groupbox2.TabIndex = 1
        Me.Groupbox2.TabStop = False
        Me.Groupbox2.Text = "Venta"
        '
        'RBTELEVISOR
        '
        Me.RBTELEVISOR.AutoSize = True
        Me.RBTELEVISOR.Location = New System.Drawing.Point(36, 97)
        Me.RBTELEVISOR.Name = "RBTELEVISOR"
        Me.RBTELEVISOR.Size = New System.Drawing.Size(81, 19)
        Me.RBTELEVISOR.TabIndex = 3
        Me.RBTELEVISOR.TabStop = True
        Me.RBTELEVISOR.Text = "TELEVISOR"
        Me.RBTELEVISOR.UseVisualStyleBackColor = True
        '
        'RBCELULAR
        '
        Me.RBCELULAR.AutoSize = True
        Me.RBCELULAR.Location = New System.Drawing.Point(36, 72)
        Me.RBCELULAR.Name = "RBCELULAR"
        Me.RBCELULAR.Size = New System.Drawing.Size(74, 19)
        Me.RBCELULAR.TabIndex = 2
        Me.RBCELULAR.Text = "CELULAR"
        Me.RBCELULAR.UseVisualStyleBackColor = True
        '
        'RBDRONE
        '
        Me.RBDRONE.AutoSize = True
        Me.RBDRONE.Location = New System.Drawing.Point(36, 47)
        Me.RBDRONE.Name = "RBDRONE"
        Me.RBDRONE.Size = New System.Drawing.Size(64, 19)
        Me.RBDRONE.TabIndex = 1
        Me.RBDRONE.TabStop = True
        Me.RBDRONE.Text = "DRONE"
        Me.RBDRONE.UseVisualStyleBackColor = True
        '
        'Rbtablet
        '
        Me.Rbtablet.AutoSize = True
        Me.Rbtablet.Location = New System.Drawing.Point(36, 22)
        Me.Rbtablet.Name = "Rbtablet"
        Me.Rbtablet.Size = New System.Drawing.Size(63, 19)
        Me.Rbtablet.TabIndex = 0
        Me.Rbtablet.TabStop = True
        Me.Rbtablet.Text = "TABLET"
        Me.Rbtablet.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(12, 259)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 94)
        Me.ListBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(143, 259)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 94)
        Me.ListBox2.TabIndex = 3
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 15
        Me.ListBox5.Location = New System.Drawing.Point(286, 259)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(85, 94)
        Me.ListBox5.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Valor bruto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "comision"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(313, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "bono"
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 15
        Me.ListBox6.Location = New System.Drawing.Point(404, 259)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(85, 94)
        Me.ListBox6.TabIndex = 13
        '
        'ListBox7
        '
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 15
        Me.ListBox7.Location = New System.Drawing.Point(526, 256)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(85, 94)
        Me.ListBox7.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(541, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Sueldo total"
        '
        'Buttoncalc
        '
        Me.Buttoncalc.Location = New System.Drawing.Point(606, 51)
        Me.Buttoncalc.Name = "Buttoncalc"
        Me.Buttoncalc.Size = New System.Drawing.Size(148, 23)
        Me.Buttoncalc.TabIndex = 16
        Me.Buttoncalc.Text = "Calcular"
        Me.Buttoncalc.UseVisualStyleBackColor = True
        '
        'Buttonlimpiar
        '
        Me.Buttonlimpiar.Location = New System.Drawing.Point(607, 93)
        Me.Buttonlimpiar.Name = "Buttonlimpiar"
        Me.Buttonlimpiar.Size = New System.Drawing.Size(147, 23)
        Me.Buttonlimpiar.TabIndex = 17
        Me.Buttonlimpiar.Text = "Limpiar "
        Me.Buttonlimpiar.UseVisualStyleBackColor = True
        '
        'Buttonlimpiarvec
        '
        Me.Buttonlimpiarvec.Location = New System.Drawing.Point(607, 130)
        Me.Buttonlimpiarvec.Name = "Buttonlimpiarvec"
        Me.Buttonlimpiarvec.Size = New System.Drawing.Size(147, 23)
        Me.Buttonlimpiarvec.TabIndex = 18
        Me.Buttonlimpiarvec.Text = "limpiar vectores"
        Me.Buttonlimpiarvec.UseVisualStyleBackColor = True
        '
        'Buttonsalir
        '
        Me.Buttonsalir.Location = New System.Drawing.Point(614, 166)
        Me.Buttonsalir.Name = "Buttonsalir"
        Me.Buttonsalir.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsalir.TabIndex = 19
        Me.Buttonsalir.Text = "salir"
        Me.Buttonsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Buttonsalir)
        Me.Controls.Add(Me.Buttonlimpiarvec)
        Me.Controls.Add(Me.Buttonlimpiar)
        Me.Controls.Add(Me.Buttoncalc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.ListBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Groupbox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Groupbox2.ResumeLayout(False)
        Me.Groupbox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtvalorbruto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Groupbox2 As GroupBox
    Friend WithEvents RBTELEVISOR As RadioButton
    Friend WithEvents RBCELULAR As RadioButton
    Friend WithEvents RBDRONE As RadioButton
    Friend WithEvents Rbtablet As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox6 As ListBox
    Friend WithEvents ListBox7 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Buttoncalc As Button
    Friend WithEvents Buttonlimpiar As Button
    Friend WithEvents Buttonlimpiarvec As Button
    Friend WithEvents Buttonsalir As Button
End Class
