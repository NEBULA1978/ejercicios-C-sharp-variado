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
        Me.components = New System.ComponentModel.Container()
        Me.TimerPrueba = New System.Windows.Forms.Timer(Me.components)
        Me.LblValor = New System.Windows.Forms.Label()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.BtnDetener = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TimerPrueba
        '
        '
        'LblValor
        '
        Me.LblValor.AutoSize = True
        Me.LblValor.Location = New System.Drawing.Point(352, 272)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(39, 13)
        Me.LblValor.TabIndex = 0
        Me.LblValor.Text = "Label1"
        '
        'BtnInicio
        '
        Me.BtnInicio.Location = New System.Drawing.Point(564, 143)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(75, 23)
        Me.BtnInicio.TabIndex = 1
        Me.BtnInicio.Text = "Inicio"
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'BtnDetener
        '
        Me.BtnDetener.Location = New System.Drawing.Point(564, 199)
        Me.BtnDetener.Name = "BtnDetener"
        Me.BtnDetener.Size = New System.Drawing.Size(75, 23)
        Me.BtnDetener.TabIndex = 2
        Me.BtnDetener.Text = "Detener"
        Me.BtnDetener.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDetener)
        Me.Controls.Add(Me.BtnInicio)
        Me.Controls.Add(Me.LblValor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerPrueba As Timer
    Friend WithEvents LblValor As Label
    Friend WithEvents BtnInicio As Button
    Friend WithEvents BtnDetener As Button
End Class
