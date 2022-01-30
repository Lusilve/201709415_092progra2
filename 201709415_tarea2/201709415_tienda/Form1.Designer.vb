<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cantidad = New System.Windows.Forms.GroupBox()
        Me.TextBoxfrijol = New System.Windows.Forms.TextBox()
        Me.TextBoxarroz = New System.Windows.Forms.TextBox()
        Me.TextBoxazucar = New System.Windows.Forms.TextBox()
        Me.Labelfrijol = New System.Windows.Forms.Label()
        Me.Labelarroz = New System.Windows.Forms.Label()
        Me.labelazucar = New System.Windows.Forms.Label()
        Me.Bcalcular = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.Bnew = New System.Windows.Forms.Button()
        Me.Pago = New System.Windows.Forms.GroupBox()
        Me.LABELPAGOIVA = New System.Windows.Forms.Label()
        Me.VALORIVA = New System.Windows.Forms.Label()
        Me.Labelsiniva = New System.Windows.Forms.Label()
        Me.LabelDESCUENTO = New System.Windows.Forms.Label()
        Me.Labelpagototal = New System.Windows.Forms.Label()
        Me.TextBoxsiniva = New System.Windows.Forms.TextBox()
        Me.TextBoxIVA = New System.Windows.Forms.TextBox()
        Me.TextBoxPAIVA = New System.Windows.Forms.TextBox()
        Me.TextBoxDESCUENTO = New System.Windows.Forms.TextBox()
        Me.TextBoxPTOTAL = New System.Windows.Forms.TextBox()
        Me.cantidad.SuspendLayout()
        Me.Pago.SuspendLayout()
        Me.SuspendLayout()
        '
        'cantidad
        '
        Me.cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.cantidad.Controls.Add(Me.TextBoxfrijol)
        Me.cantidad.Controls.Add(Me.TextBoxarroz)
        Me.cantidad.Controls.Add(Me.TextBoxazucar)
        Me.cantidad.Controls.Add(Me.Labelfrijol)
        Me.cantidad.Controls.Add(Me.Labelarroz)
        Me.cantidad.Controls.Add(Me.labelazucar)
        Me.cantidad.Location = New System.Drawing.Point(32, 3)
        Me.cantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cantidad.Size = New System.Drawing.Size(229, 125)
        Me.cantidad.TabIndex = 0
        Me.cantidad.TabStop = False
        Me.cantidad.Text = "Cantidad"
        '
        'TextBoxfrijol
        '
        Me.TextBoxfrijol.Location = New System.Drawing.Point(135, 87)
        Me.TextBoxfrijol.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxfrijol.Name = "TextBoxfrijol"
        Me.TextBoxfrijol.Size = New System.Drawing.Size(62, 23)
        Me.TextBoxfrijol.TabIndex = 5
        Me.TextBoxfrijol.Text = "0"
        '
        'TextBoxarroz
        '
        Me.TextBoxarroz.Location = New System.Drawing.Point(135, 58)
        Me.TextBoxarroz.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxarroz.Name = "TextBoxarroz"
        Me.TextBoxarroz.Size = New System.Drawing.Size(62, 23)
        Me.TextBoxarroz.TabIndex = 4
        Me.TextBoxarroz.Text = "0"
        '
        'TextBoxazucar
        '
        Me.TextBoxazucar.BackColor = System.Drawing.Color.White
        Me.TextBoxazucar.Location = New System.Drawing.Point(135, 27)
        Me.TextBoxazucar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxazucar.Name = "TextBoxazucar"
        Me.TextBoxazucar.Size = New System.Drawing.Size(62, 23)
        Me.TextBoxazucar.TabIndex = 3
        Me.TextBoxazucar.Text = "0"
        '
        'Labelfrijol
        '
        Me.Labelfrijol.AutoSize = True
        Me.Labelfrijol.Location = New System.Drawing.Point(7, 95)
        Me.Labelfrijol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelfrijol.Name = "Labelfrijol"
        Me.Labelfrijol.Size = New System.Drawing.Size(85, 15)
        Me.Labelfrijol.TabIndex = 2
        Me.Labelfrijol.Text = "Libras de frijol"
        '
        'Labelarroz
        '
        Me.Labelarroz.AutoSize = True
        Me.Labelarroz.Location = New System.Drawing.Point(7, 61)
        Me.Labelarroz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelarroz.Name = "Labelarroz"
        Me.Labelarroz.Size = New System.Drawing.Size(85, 15)
        Me.Labelarroz.TabIndex = 1
        Me.Labelarroz.Text = "Libras de arroz"
        '
        'labelazucar
        '
        Me.labelazucar.AutoSize = True
        Me.labelazucar.Location = New System.Drawing.Point(7, 30)
        Me.labelazucar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelazucar.Name = "labelazucar"
        Me.labelazucar.Size = New System.Drawing.Size(92, 15)
        Me.labelazucar.TabIndex = 0
        Me.labelazucar.Text = "Libras de azucar"
        '
        'Bcalcular
        '
        Me.Bcalcular.Location = New System.Drawing.Point(29, 147)
        Me.Bcalcular.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bcalcular.Name = "Bcalcular"
        Me.Bcalcular.Size = New System.Drawing.Size(70, 27)
        Me.Bcalcular.TabIndex = 1
        Me.Bcalcular.Text = "Calcular"
        Me.Bcalcular.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.Location = New System.Drawing.Point(194, 147)
        Me.Bsalir.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(74, 27)
        Me.Bsalir.TabIndex = 2
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'Bnew
        '
        Me.Bnew.Location = New System.Drawing.Point(116, 147)
        Me.Bnew.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Bnew.Name = "Bnew"
        Me.Bnew.Size = New System.Drawing.Size(70, 27)
        Me.Bnew.TabIndex = 3
        Me.Bnew.Text = "Nuevo"
        Me.Bnew.UseVisualStyleBackColor = True
        '
        'Pago
        '
        Me.Pago.Controls.Add(Me.TextBoxPTOTAL)
        Me.Pago.Controls.Add(Me.TextBoxDESCUENTO)
        Me.Pago.Controls.Add(Me.TextBoxPAIVA)
        Me.Pago.Controls.Add(Me.TextBoxIVA)
        Me.Pago.Controls.Add(Me.TextBoxsiniva)
        Me.Pago.Controls.Add(Me.Labelpagototal)
        Me.Pago.Controls.Add(Me.LabelDESCUENTO)
        Me.Pago.Controls.Add(Me.LABELPAGOIVA)
        Me.Pago.Controls.Add(Me.VALORIVA)
        Me.Pago.Controls.Add(Me.Labelsiniva)
        Me.Pago.Location = New System.Drawing.Point(32, 198)
        Me.Pago.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Pago.Name = "Pago"
        Me.Pago.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Pago.Size = New System.Drawing.Size(220, 179)
        Me.Pago.TabIndex = 4
        Me.Pago.TabStop = False
        Me.Pago.Text = "Pago"
        Me.Pago.Visible = False
        '
        'LABELPAGOIVA
        '
        Me.LABELPAGOIVA.AutoSize = True
        Me.LABELPAGOIVA.Location = New System.Drawing.Point(4, 96)
        Me.LABELPAGOIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LABELPAGOIVA.Name = "LABELPAGOIVA"
        Me.LABELPAGOIVA.Size = New System.Drawing.Size(79, 15)
        Me.LABELPAGOIVA.TabIndex = 2
        Me.LABELPAGOIVA.Text = "Valor con IVA"
        '
        'VALORIVA
        '
        Me.VALORIVA.AutoSize = True
        Me.VALORIVA.Location = New System.Drawing.Point(5, 66)
        Me.VALORIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VALORIVA.Name = "VALORIVA"
        Me.VALORIVA.Size = New System.Drawing.Size(92, 15)
        Me.VALORIVA.TabIndex = 1
        Me.VALORIVA.Text = "VALOR DEL IVA"
        '
        'Labelsiniva
        '
        Me.Labelsiniva.AutoSize = True
        Me.Labelsiniva.Location = New System.Drawing.Point(8, 36)
        Me.Labelsiniva.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelsiniva.Name = "Labelsiniva"
        Me.Labelsiniva.Size = New System.Drawing.Size(76, 15)
        Me.Labelsiniva.TabIndex = 0
        Me.Labelsiniva.Text = "Pago Sin IVA"
        '
        'LabelDESCUENTO
        '
        Me.LabelDESCUENTO.AutoSize = True
        Me.LabelDESCUENTO.Location = New System.Drawing.Point(7, 123)
        Me.LabelDESCUENTO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDESCUENTO.Name = "LabelDESCUENTO"
        Me.LabelDESCUENTO.Size = New System.Drawing.Size(60, 15)
        Me.LabelDESCUENTO.TabIndex = 3
        Me.LabelDESCUENTO.Text = "Descuento"
        '
        'Labelpagototal
        '
        Me.Labelpagototal.AutoSize = True
        Me.Labelpagototal.Location = New System.Drawing.Point(5, 153)
        Me.Labelpagototal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelpagototal.Name = "Labelpagototal"
        Me.Labelpagototal.Size = New System.Drawing.Size(74, 15)
        Me.Labelpagototal.TabIndex = 4
        Me.Labelpagototal.Text = "Total a Pagar"
        '
        'TextBoxsiniva
        '
        Me.TextBoxsiniva.Location = New System.Drawing.Point(122, 27)
        Me.TextBoxsiniva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxsiniva.Name = "TextBoxsiniva"
        Me.TextBoxsiniva.Size = New System.Drawing.Size(75, 23)
        Me.TextBoxsiniva.TabIndex = 5
        '
        'TextBoxIVA
        '
        Me.TextBoxIVA.Location = New System.Drawing.Point(122, 63)
        Me.TextBoxIVA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxIVA.Name = "TextBoxIVA"
        Me.TextBoxIVA.Size = New System.Drawing.Size(75, 23)
        Me.TextBoxIVA.TabIndex = 6
        '
        'TextBoxPAIVA
        '
        Me.TextBoxPAIVA.Location = New System.Drawing.Point(122, 93)
        Me.TextBoxPAIVA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxPAIVA.Name = "TextBoxPAIVA"
        Me.TextBoxPAIVA.Size = New System.Drawing.Size(75, 23)
        Me.TextBoxPAIVA.TabIndex = 7
        '
        'TextBoxDESCUENTO
        '
        Me.TextBoxDESCUENTO.Location = New System.Drawing.Point(122, 123)
        Me.TextBoxDESCUENTO.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxDESCUENTO.Name = "TextBoxDESCUENTO"
        Me.TextBoxDESCUENTO.Size = New System.Drawing.Size(75, 23)
        Me.TextBoxDESCUENTO.TabIndex = 8
        '
        'TextBoxPTOTAL
        '
        Me.TextBoxPTOTAL.Location = New System.Drawing.Point(122, 153)
        Me.TextBoxPTOTAL.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxPTOTAL.Name = "TextBoxPTOTAL"
        Me.TextBoxPTOTAL.Size = New System.Drawing.Size(75, 23)
        Me.TextBoxPTOTAL.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(295, 420)
        Me.Controls.Add(Me.Pago)
        Me.Controls.Add(Me.Bnew)
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.Bcalcular)
        Me.Controls.Add(Me.cantidad)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIENDA"
        Me.cantidad.ResumeLayout(False)
        Me.cantidad.PerformLayout()
        Me.Pago.ResumeLayout(False)
        Me.Pago.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cantidad As GroupBox
    Friend WithEvents TextBoxfrijol As TextBox
    Friend WithEvents TextBoxarroz As TextBox
    Friend WithEvents TextBoxazucar As TextBox
    Friend WithEvents Labelfrijol As Label
    Friend WithEvents Labelarroz As Label
    Friend WithEvents labelazucar As Label
    Friend WithEvents Bcalcular As Button
    Friend WithEvents Bsalir As Button
    Friend WithEvents Bnew As Button
    Friend WithEvents Pago As GroupBox
    Friend WithEvents LABELPAGOIVA As Label
    Friend WithEvents VALORIVA As Label
    Friend WithEvents Labelsiniva As Label
    Friend WithEvents TextBoxPTOTAL As TextBox
    Friend WithEvents TextBoxDESCUENTO As TextBox
    Friend WithEvents TextBoxPAIVA As TextBox
    Friend WithEvents TextBoxIVA As TextBox
    Friend WithEvents TextBoxsiniva As TextBox
    Friend WithEvents Labelpagototal As Label
    Friend WithEvents LabelDESCUENTO As Label
End Class
