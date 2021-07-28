<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarPaciente
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
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btn_MP = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_MS = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVisualizar
        '
        Me.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVisualizar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizar.Location = New System.Drawing.Point(375, 624)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(187, 58)
        Me.btnVisualizar.TabIndex = 166
        Me.btnVisualizar.Text = "VISUALIZAR REGISTRO"
        Me.btnVisualizar.UseVisualStyleBackColor = False
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Actualizar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Actualizar.Location = New System.Drawing.Point(375, 555)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(187, 58)
        Me.btn_Actualizar.TabIndex = 165
        Me.btn_Actualizar.Text = "ACTUALIZAR"
        Me.btn_Actualizar.UseVisualStyleBackColor = False
        '
        'textBox4
        '
        Me.textBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(188, 496)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(170, 26)
        Me.textBox4.TabIndex = 164
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(55, 499)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(83, 18)
        Me.label10.TabIndex = 163
        Me.label10.Text = "Id seguro"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(365, 457)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(208, 40)
        Me.button3.TabIndex = 162
        Me.button3.Text = "Seguro"
        Me.button3.UseVisualStyleBackColor = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(129, 468)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(222, 18)
        Me.label11.TabIndex = 161
        Me.label11.Text = "Actualizar datos de seguro"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(362, 425)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(200, 18)
        Me.label12.TabIndex = 160
        Me.label12.Text = "Actualización de seguro"
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(188, 377)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(170, 26)
        Me.textBox3.TabIndex = 159
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(55, 380)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(80, 18)
        Me.label7.TabIndex = 158
        Me.label7.Text = "Id tarjeta"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.LimeGreen
        Me.button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(357, 322)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(208, 40)
        Me.button2.TabIndex = 157
        Me.button2.Text = "Tarjeta"
        Me.button2.UseVisualStyleBackColor = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(132, 322)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(219, 18)
        Me.label8.TabIndex = 156
        Me.label8.Text = "Actualizar datos de tarjeta"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(309, 290)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(407, 18)
        Me.label9.TabIndex = 155
        Me.label9.Text = "Actualización registro de tarjeta de crédito/ débito"
        '
        'btn_MP
        '
        Me.btn_MP.BackColor = System.Drawing.Color.Yellow
        Me.btn_MP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MP.Location = New System.Drawing.Point(702, 190)
        Me.btn_MP.Name = "btn_MP"
        Me.btn_MP.Size = New System.Drawing.Size(159, 52)
        Me.btn_MP.TabIndex = 154
        Me.btn_MP.Text = "MENU PRINCIPAL"
        Me.btn_MP.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(702, 333)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(159, 52)
        Me.btn_Salir.TabIndex = 153
        Me.btn_Salir.Text = "SALIR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_MS
        '
        Me.Btn_MS.BackColor = System.Drawing.Color.Orchid
        Me.Btn_MS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MS.Location = New System.Drawing.Point(702, 133)
        Me.Btn_MS.Name = "Btn_MS"
        Me.Btn_MS.Size = New System.Drawing.Size(159, 52)
        Me.Btn_MS.TabIndex = 152
        Me.Btn_MS.Text = "MENU SECUNDARIO"
        Me.Btn_MS.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.Orange
        Me.btn_Limpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(702, 78)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(159, 52)
        Me.btn_Limpiar.TabIndex = 151
        Me.btn_Limpiar.Text = "LIMPIAR"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(237, 231)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(242, 26)
        Me.textBox2.TabIndex = 150
        '
        'comboBox1
        '
        Me.comboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(222, 97)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(257, 26)
        Me.comboBox1.TabIndex = 149
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(222, 52)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(257, 26)
        Me.textBox1.TabIndex = 148
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(8, 232)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(214, 18)
        Me.label6.TabIndex = 147
        Me.label6.Text = "Id datos complementarios"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.HotPink
        Me.button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(356, 185)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(208, 40)
        Me.button1.TabIndex = 146
        Me.button1.Text = "Datos Complementarios"
        Me.button1.UseVisualStyleBackColor = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(43, 190)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(280, 18)
        Me.label5.TabIndex = 145
        Me.label5.Text = "Actualizar datos complementarios"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(254, 150)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(331, 18)
        Me.label4.TabIndex = 144
        Me.label4.Text = "Actualización de datos complementarios"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(96, 100)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(93, 18)
        Me.label3.TabIndex = 143
        Me.label3.Text = "Id persona"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(96, 55)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(97, 18)
        Me.label2.TabIndex = 142
        Me.label2.Text = "Id paciente"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(289, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(319, 22)
        Me.label1.TabIndex = 141
        Me.label1.Text = "ACTUALIZACIÓN DE PACIENTES"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_Buscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Location = New System.Drawing.Point(501, 52)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(149, 41)
        Me.btn_Buscar.TabIndex = 167
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'ActualizarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(890, 748)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btn_MP)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Btn_MS)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "ActualizarPaciente"
        Me.Text = "ActualizarPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnVisualizar As Button
    Private WithEvents btn_Actualizar As Button
    Private WithEvents textBox4 As TextBox
    Private WithEvents label10 As Label
    Private WithEvents button3 As Button
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents textBox3 As TextBox
    Private WithEvents label7 As Label
    Private WithEvents button2 As Button
    Private WithEvents label8 As Label
    Private WithEvents label9 As Label
    Private WithEvents btn_MP As Button
    Private WithEvents btn_Salir As Button
    Private WithEvents Btn_MS As Button
    Private WithEvents btn_Limpiar As Button
    Private WithEvents textBox2 As TextBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label6 As Label
    Private WithEvents button1 As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btn_Buscar As Button
End Class
