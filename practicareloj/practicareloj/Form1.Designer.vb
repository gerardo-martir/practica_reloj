<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.relok = New System.Windows.Forms.Label()
        Me.relok2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'relok
        '
        Me.relok.AutoSize = True
        Me.relok.Font = New System.Drawing.Font("Palatino Linotype", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relok.Location = New System.Drawing.Point(26, 9)
        Me.relok.Name = "relok"
        Me.relok.Size = New System.Drawing.Size(151, 128)
        Me.relok.TabIndex = 0
        Me.relok.Text = "00"
        '
        'relok2
        '
        Me.relok2.AutoSize = True
        Me.relok2.Font = New System.Drawing.Font("Palatino Linotype", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relok2.Location = New System.Drawing.Point(206, 9)
        Me.relok2.Name = "relok2"
        Me.relok2.Size = New System.Drawing.Size(151, 128)
        Me.relok2.TabIndex = 1
        Me.relok2.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 128)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Dia
        '
        Me.Dia.AutoSize = True
        Me.Dia.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.Location = New System.Drawing.Point(9, 137)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(160, 65)
        Me.Dia.TabIndex = 3
        Me.Dia.Text = "Lunes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "09 / Marzo / 2026"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 257)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.relok2)
        Me.Controls.Add(Me.relok)
        Me.Name = "Form1"
        Me.Text = "rELOJ DIGITAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents relok As Label
    Friend WithEvents relok2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dia As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
