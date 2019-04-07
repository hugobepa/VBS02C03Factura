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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CostePiezas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTCliente = New System.Windows.Forms.TextBox()
        Me.TXTPartes = New System.Windows.Forms.TextBox()
        Me.TXTHoras = New System.Windows.Forms.TextBox()
        Me.BTNFactura = New System.Windows.Forms.Button()
        Me.LSTFactura = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NombreCliente"
        '
        'CostePiezas
        '
        Me.CostePiezas.AutoSize = True
        Me.CostePiezas.Location = New System.Drawing.Point(44, 117)
        Me.CostePiezas.Name = "CostePiezas"
        Me.CostePiezas.Size = New System.Drawing.Size(38, 13)
        Me.CostePiezas.TabIndex = 1
        Me.CostePiezas.Text = "Piezas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horas"
        '
        'TXTCliente
        '
        Me.TXTCliente.Location = New System.Drawing.Point(139, 34)
        Me.TXTCliente.Name = "TXTCliente"
        Me.TXTCliente.Size = New System.Drawing.Size(218, 20)
        Me.TXTCliente.TabIndex = 3
        '
        'TXTPartes
        '
        Me.TXTPartes.Location = New System.Drawing.Point(139, 117)
        Me.TXTPartes.Name = "TXTPartes"
        Me.TXTPartes.Size = New System.Drawing.Size(100, 20)
        Me.TXTPartes.TabIndex = 4
        '
        'TXTHoras
        '
        Me.TXTHoras.Location = New System.Drawing.Point(139, 79)
        Me.TXTHoras.Name = "TXTHoras"
        Me.TXTHoras.Size = New System.Drawing.Size(100, 20)
        Me.TXTHoras.TabIndex = 5
        '
        'BTNFactura
        '
        Me.BTNFactura.Location = New System.Drawing.Point(265, 75)
        Me.BTNFactura.Name = "BTNFactura"
        Me.BTNFactura.Size = New System.Drawing.Size(92, 62)
        Me.BTNFactura.TabIndex = 6
        Me.BTNFactura.Text = "Factura"
        Me.BTNFactura.UseVisualStyleBackColor = True
        '
        'LSTFactura
        '
        Me.LSTFactura.FormattingEnabled = True
        Me.LSTFactura.Location = New System.Drawing.Point(139, 158)
        Me.LSTFactura.Name = "LSTFactura"
        Me.LSTFactura.Size = New System.Drawing.Size(218, 121)
        Me.LSTFactura.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 308)
        Me.Controls.Add(Me.LSTFactura)
        Me.Controls.Add(Me.BTNFactura)
        Me.Controls.Add(Me.TXTHoras)
        Me.Controls.Add(Me.TXTPartes)
        Me.Controls.Add(Me.TXTCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CostePiezas)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CostePiezas As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTCliente As TextBox
    Friend WithEvents TXTPartes As TextBox
    Friend WithEvents TXTHoras As TextBox
    Friend WithEvents BTNFactura As Button
    Friend WithEvents LSTFactura As ListBox
End Class
