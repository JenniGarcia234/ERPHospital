<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarSituacion
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
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_MP = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_MS = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_Buscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Location = New System.Drawing.Point(425, 59)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(120, 36)
        Me.btn_Buscar.TabIndex = 141
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'btn_MP
        '
        Me.btn_MP.BackColor = System.Drawing.Color.Yellow
        Me.btn_MP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MP.Location = New System.Drawing.Point(587, 159)
        Me.btn_MP.Name = "btn_MP"
        Me.btn_MP.Size = New System.Drawing.Size(135, 62)
        Me.btn_MP.TabIndex = 140
        Me.btn_MP.Text = "MENU PRINCIPAL"
        Me.btn_MP.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(587, 238)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(135, 62)
        Me.btn_Salir.TabIndex = 139
        Me.btn_Salir.Text = "SALIR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_MS
        '
        Me.Btn_MS.BackColor = System.Drawing.Color.Orchid
        Me.Btn_MS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MS.Location = New System.Drawing.Point(587, 106)
        Me.Btn_MS.Name = "Btn_MS"
        Me.Btn_MS.Size = New System.Drawing.Size(135, 62)
        Me.Btn_MS.TabIndex = 138
        Me.Btn_MS.Text = "MENU SECUNDARIO"
        Me.Btn_MS.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.Orange
        Me.btn_Limpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(587, 51)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(135, 62)
        Me.btn_Limpiar.TabIndex = 137
        Me.btn_Limpiar.Text = "LIMPIAR"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Actualizar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Actualizar.Location = New System.Drawing.Point(244, 239)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(163, 78)
        Me.btn_Actualizar.TabIndex = 135
        Me.btn_Actualizar.Text = "ACTUALIZAR"
        Me.btn_Actualizar.UseVisualStyleBackColor = False
        '
        'comboBox2
        '
        Me.comboBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(217, 159)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(190, 26)
        Me.comboBox2.TabIndex = 134
        '
        'comboBox1
        '
        Me.comboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(217, 111)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(190, 26)
        Me.comboBox1.TabIndex = 133
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(217, 72)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(190, 26)
        Me.textBox1.TabIndex = 132
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(63, 159)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(115, 18)
        Me.label4.TabIndex = 131
        Me.label4.Text = "Id_habitación"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(63, 111)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(92, 18)
        Me.label3.TabIndex = 130
        Me.label3.Text = "Id_Ingreso"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(63, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(106, 18)
        Me.label2.TabIndex = 129
        Me.label2.Text = "Id_Situacion"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(190, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(395, 22)
        Me.label1.TabIndex = 128
        Me.label1.Text = "ACTUALIZAR SITUACIÓN DEL PACIENTE"
        '
        'ActualizarSituacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_MP)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Btn_MS)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "ActualizarSituacion"
        Me.Text = "ActualizarSituacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btn_Buscar As Button
    Private WithEvents btn_MP As Button
    Private WithEvents btn_Salir As Button
    Private WithEvents Btn_MS As Button
    Private WithEvents btn_Limpiar As Button
    Private WithEvents btn_Actualizar As Button
    Private WithEvents comboBox2 As ComboBox
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
