<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESULTADOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RESULTADOS))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTCOSTO = New System.Windows.Forms.TextBox()
        Me.TXTVENTA = New System.Windows.Forms.TextBox()
        Me.TXTPVENTA = New System.Windows.Forms.TextBox()
        Me.ButtonREGRESAR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TXTPVENTA)
        Me.GroupBox1.Controls.Add(Me.TXTVENTA)
        Me.GroupBox1.Controls.Add(Me.TXTCOSTO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COSTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "%PRECIO VENTA (+)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PRECIO FINAL (=)"
        '
        'TXTCOSTO
        '
        Me.TXTCOSTO.Location = New System.Drawing.Point(155, 29)
        Me.TXTCOSTO.Name = "TXTCOSTO"
        Me.TXTCOSTO.Size = New System.Drawing.Size(132, 24)
        Me.TXTCOSTO.TabIndex = 3
        '
        'TXTVENTA
        '
        Me.TXTVENTA.Location = New System.Drawing.Point(155, 70)
        Me.TXTVENTA.Name = "TXTVENTA"
        Me.TXTVENTA.Size = New System.Drawing.Size(132, 24)
        Me.TXTVENTA.TabIndex = 4
        '
        'TXTPVENTA
        '
        Me.TXTPVENTA.Location = New System.Drawing.Point(155, 111)
        Me.TXTPVENTA.Name = "TXTPVENTA"
        Me.TXTPVENTA.Size = New System.Drawing.Size(132, 24)
        Me.TXTPVENTA.TabIndex = 5
        '
        'ButtonREGRESAR
        '
        Me.ButtonREGRESAR.Location = New System.Drawing.Point(92, 189)
        Me.ButtonREGRESAR.Name = "ButtonREGRESAR"
        Me.ButtonREGRESAR.Size = New System.Drawing.Size(105, 36)
        Me.ButtonREGRESAR.TabIndex = 1
        Me.ButtonREGRESAR.Text = "REGRESAR"
        Me.ButtonREGRESAR.UseVisualStyleBackColor = True
        '
        'RESULTADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(332, 259)
        Me.Controls.Add(Me.ButtonREGRESAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "RESULTADOS"
        Me.Text = "RESULTADOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTPVENTA As TextBox
    Friend WithEvents TXTVENTA As TextBox
    Friend WithEvents TXTCOSTO As TextBox
    Friend WithEvents ButtonREGRESAR As Button
End Class
