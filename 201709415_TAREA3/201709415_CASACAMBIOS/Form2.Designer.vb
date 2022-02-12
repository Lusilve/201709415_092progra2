<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbcomto = New System.Windows.Forms.Label()
        Me.lbcomco = New System.Windows.Forms.Label()
        Me.Lbcomca = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbvento = New System.Windows.Forms.Label()
        Me.lbvenco = New System.Windows.Forms.Label()
        Me.lbvenca = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BUTTONREGRESAR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Snow
        Me.GroupBox1.Controls.Add(Me.lbcomto)
        Me.GroupBox1.Controls.Add(Me.lbcomco)
        Me.GroupBox1.Controls.Add(Me.Lbcomca)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(239, 198)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COMPRA"
        '
        'lbcomto
        '
        Me.lbcomto.AutoSize = True
        Me.lbcomto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbcomto.Location = New System.Drawing.Point(159, 126)
        Me.lbcomto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbcomto.Name = "lbcomto"
        Me.lbcomto.Size = New System.Drawing.Size(31, 15)
        Me.lbcomto.TabIndex = 5
        Me.lbcomto.Text = "0.00"
        '
        'lbcomco
        '
        Me.lbcomco.AutoSize = True
        Me.lbcomco.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbcomco.Location = New System.Drawing.Point(159, 92)
        Me.lbcomco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbcomco.Name = "lbcomco"
        Me.lbcomco.Size = New System.Drawing.Size(31, 15)
        Me.lbcomco.TabIndex = 4
        Me.lbcomco.Text = "0.00"
        '
        'Lbcomca
        '
        Me.Lbcomca.AutoSize = True
        Me.Lbcomca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbcomca.Location = New System.Drawing.Point(159, 48)
        Me.Lbcomca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbcomca.Name = "Lbcomca"
        Me.Lbcomca.Size = New System.Drawing.Size(31, 15)
        Me.Lbcomca.TabIndex = 3
        Me.Lbcomca.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Comision"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cambio "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox2.Controls.Add(Me.lbvento)
        Me.GroupBox2.Controls.Add(Me.lbvenco)
        Me.GroupBox2.Controls.Add(Me.lbvenca)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 236)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(239, 158)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VENTA"
        '
        'lbvento
        '
        Me.lbvento.AutoSize = True
        Me.lbvento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbvento.Location = New System.Drawing.Point(159, 126)
        Me.lbvento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbvento.Name = "lbvento"
        Me.lbvento.Size = New System.Drawing.Size(31, 15)
        Me.lbvento.TabIndex = 8
        Me.lbvento.Text = "0.00"
        '
        'lbvenco
        '
        Me.lbvenco.AutoSize = True
        Me.lbvenco.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbvenco.Location = New System.Drawing.Point(159, 86)
        Me.lbvenco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbvenco.Name = "lbvenco"
        Me.lbvenco.Size = New System.Drawing.Size(31, 15)
        Me.lbvenco.TabIndex = 7
        Me.lbvenco.Text = "0.00"
        '
        'lbvenca
        '
        Me.lbvenca.AutoSize = True
        Me.lbvenca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbvenca.Location = New System.Drawing.Point(159, 48)
        Me.lbvenca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbvenca.Name = "lbvenca"
        Me.lbvenca.Size = New System.Drawing.Size(31, 15)
        Me.lbvenca.TabIndex = 6
        Me.lbvenca.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Comision"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 48)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cambio "
        '
        'BUTTONREGRESAR
        '
        Me.BUTTONREGRESAR.Location = New System.Drawing.Point(301, 46)
        Me.BUTTONREGRESAR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BUTTONREGRESAR.Name = "BUTTONREGRESAR"
        Me.BUTTONREGRESAR.Size = New System.Drawing.Size(107, 35)
        Me.BUTTONREGRESAR.TabIndex = 7
        Me.BUTTONREGRESAR.Text = "REGRESAR"
        Me.BUTTONREGRESAR.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(421, 405)
        Me.Controls.Add(Me.BUTTONREGRESAR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form2"
        Me.Text = "Resultados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BUTTONREGRESAR As Button
    Friend WithEvents lbcomto As Label
    Friend WithEvents lbcomco As Label
    Friend WithEvents Lbcomca As Label
    Friend WithEvents lbvento As Label
    Friend WithEvents lbvenco As Label
    Friend WithEvents lbvenca As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
