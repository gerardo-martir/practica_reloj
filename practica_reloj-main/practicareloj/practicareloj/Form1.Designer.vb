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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.configuraciontlabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.relok3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'relok
        '
        Me.relok.AutoSize = True
        Me.relok.BackColor = System.Drawing.Color.DarkGray
        Me.relok.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relok.ForeColor = System.Drawing.SystemColors.Info
        Me.relok.Location = New System.Drawing.Point(138, 330)
        Me.relok.Name = "relok"
        Me.relok.Size = New System.Drawing.Size(101, 85)
        Me.relok.TabIndex = 0
        Me.relok.Text = "00"
        '
        'relok2
        '
        Me.relok2.AutoSize = True
        Me.relok2.BackColor = System.Drawing.Color.DarkGray
        Me.relok2.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relok2.ForeColor = System.Drawing.SystemColors.Info
        Me.relok2.Location = New System.Drawing.Point(234, 330)
        Me.relok2.Name = "relok2"
        Me.relok2.Size = New System.Drawing.Size(101, 85)
        Me.relok2.TabIndex = 1
        Me.relok2.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(219, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 51)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Dia
        '
        Me.Dia.AutoSize = True
        Me.Dia.BackColor = System.Drawing.Color.DarkGray
        Me.Dia.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.ForeColor = System.Drawing.SystemColors.Info
        Me.Dia.Location = New System.Drawing.Point(168, 448)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(125, 50)
        Me.Dia.TabIndex = 3
        Me.Dia.Text = "Lunes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(148, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "09 / Marzo / 2026"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.practicareloj.My.Resources.Resources._965cd27fb6f52e93c88f65f5699825c3__rabbits_bunny
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(-314, -21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1141, 903)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox2.Image = Global.practicareloj.My.Resources.Resources.options_icon_png_15
        Me.PictureBox2.Location = New System.Drawing.Point(99, 404)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.configuraciontlabel)
        Me.Panel1.Location = New System.Drawing.Point(138, 330)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 196)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'configuraciontlabel
        '
        Me.configuraciontlabel.AutoSize = True
        Me.configuraciontlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.configuraciontlabel.ForeColor = System.Drawing.SystemColors.Info
        Me.configuraciontlabel.Location = New System.Drawing.Point(7, 14)
        Me.configuraciontlabel.Name = "configuraciontlabel"
        Me.configuraciontlabel.Size = New System.Drawing.Size(154, 25)
        Me.configuraciontlabel.TabIndex = 0
        Me.configuraciontlabel.Text = "configuracion"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"rojo", "amarillo", "blanco", "azul", "verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'relok3
        '
        Me.relok3.AutoSize = True
        Me.relok3.BackColor = System.Drawing.Color.DarkGray
        Me.relok3.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relok3.ForeColor = System.Drawing.SystemColors.Info
        Me.relok3.Location = New System.Drawing.Point(209, 296)
        Me.relok3.Name = "relok3"
        Me.relok3.Size = New System.Drawing.Size(56, 48)
        Me.relok3.TabIndex = 8
        Me.relok3.Text = "00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 695)
        Me.Controls.Add(Me.relok3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.relok2)
        Me.Controls.Add(Me.relok)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "rELOJ DIGITAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents relok As Label
    Friend WithEvents relok2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dia As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents configuraciontlabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents relok3 As Label
End Class
