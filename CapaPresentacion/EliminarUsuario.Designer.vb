<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarUsuario
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
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_MP = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_MS = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_Eliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.Location = New System.Drawing.Point(254, 357)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(155, 50)
        Me.btn_Eliminar.TabIndex = 156
        Me.btn_Eliminar.Text = "ELIMINAR"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(254, 421)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(155, 50)
        Me.button2.TabIndex = 155
        Me.button2.Text = "VISUALIZAR REGISTRO"
        Me.button2.UseVisualStyleBackColor = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_Buscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Location = New System.Drawing.Point(449, 71)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(112, 44)
        Me.btn_Buscar.TabIndex = 154
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'btn_MP
        '
        Me.btn_MP.BackColor = System.Drawing.Color.Yellow
        Me.btn_MP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MP.Location = New System.Drawing.Point(640, 205)
        Me.btn_MP.Name = "btn_MP"
        Me.btn_MP.Size = New System.Drawing.Size(148, 58)
        Me.btn_MP.TabIndex = 153
        Me.btn_MP.Text = "MENU PRINCIPAL"
        Me.btn_MP.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(640, 272)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(148, 58)
        Me.btn_Salir.TabIndex = 152
        Me.btn_Salir.Text = "SALIR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_MS
        '
        Me.Btn_MS.BackColor = System.Drawing.Color.Orchid
        Me.Btn_MS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MS.Location = New System.Drawing.Point(640, 148)
        Me.Btn_MS.Name = "Btn_MS"
        Me.Btn_MS.Size = New System.Drawing.Size(148, 58)
        Me.Btn_MS.TabIndex = 151
        Me.Btn_MS.Text = "MENU SECUNDARIO"
        Me.Btn_MS.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.Orange
        Me.btn_Limpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(640, 93)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(148, 58)
        Me.btn_Limpiar.TabIndex = 150
        Me.btn_Limpiar.Text = "LIMPIAR"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(195, 224)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(234, 26)
        Me.textBox3.TabIndex = 149
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(195, 180)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(234, 26)
        Me.textBox2.TabIndex = 148
        '
        'comboBox2
        '
        Me.comboBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(195, 264)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(234, 26)
        Me.comboBox2.TabIndex = 147
        '
        'comboBox1
        '
        Me.comboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(195, 126)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(234, 26)
        Me.comboBox1.TabIndex = 146
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(195, 81)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(234, 26)
        Me.textBox1.TabIndex = 145
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(39, 264)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(86, 18)
        Me.label8.TabIndex = 144
        Me.label8.Text = "Id función"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(42, 223)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(102, 18)
        Me.label7.TabIndex = 143
        Me.label7.Text = "Contraseña"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(30, 179)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(159, 18)
        Me.label6.TabIndex = 142
        Me.label6.Text = "Nombre de usuario"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(42, 122)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(105, 18)
        Me.label3.TabIndex = 141
        Me.label3.Text = "Id empleado"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(42, 77)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 18)
        Me.label2.TabIndex = 140
        Me.label2.Text = "Id usuario"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(280, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(279, 22)
        Me.label1.TabIndex = 139
        Me.label1.Text = "ELIMINACIÓN DE USUARIOS"
        '
        'EliminarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_MP)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Btn_MS)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "EliminarUsuario"
        Me.Text = "EliminarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btn_Eliminar As Button
    Private WithEvents button2 As Button
    Private WithEvents btn_Buscar As Button
    Private WithEvents btn_MP As Button
    Private WithEvents btn_Salir As Button
    Private WithEvents Btn_MS As Button
    Private WithEvents btn_Limpiar As Button
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents comboBox2 As ComboBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
