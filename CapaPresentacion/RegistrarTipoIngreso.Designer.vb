<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarTipoIngreso
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
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.btn_MP = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_MS = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboBox1
        '
        Me.comboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Hospitalización", "Ambulatorio", "Citaciones"})
        Me.comboBox1.Location = New System.Drawing.Point(213, 130)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(213, 26)
        Me.comboBox1.TabIndex = 98
        '
        'btn_Registrar
        '
        Me.btn_Registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Registrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Registrar.Location = New System.Drawing.Point(244, 202)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(167, 54)
        Me.btn_Registrar.TabIndex = 96
        Me.btn_Registrar.Text = "REGISTRAR "
        Me.btn_Registrar.UseVisualStyleBackColor = False
        '
        'btn_MP
        '
        Me.btn_MP.BackColor = System.Drawing.Color.Yellow
        Me.btn_MP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MP.Location = New System.Drawing.Point(561, 195)
        Me.btn_MP.Name = "btn_MP"
        Me.btn_MP.Size = New System.Drawing.Size(139, 52)
        Me.btn_MP.TabIndex = 95
        Me.btn_MP.Text = "MENU PRINCIPAL"
        Me.btn_MP.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(561, 270)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(139, 52)
        Me.btn_Salir.TabIndex = 94
        Me.btn_Salir.Text = "SALIR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_MS
        '
        Me.Btn_MS.BackColor = System.Drawing.Color.Orchid
        Me.Btn_MS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MS.Location = New System.Drawing.Point(561, 138)
        Me.Btn_MS.Name = "Btn_MS"
        Me.Btn_MS.Size = New System.Drawing.Size(139, 52)
        Me.Btn_MS.TabIndex = 93
        Me.Btn_MS.Text = "MENU SECUNDARIO"
        Me.Btn_MS.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.Orange
        Me.btn_Limpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(561, 83)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(139, 52)
        Me.btn_Limpiar.TabIndex = 92
        Me.btn_Limpiar.Text = "LIMPIAR"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(213, 83)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(213, 26)
        Me.textBox1.TabIndex = 91
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(21, 130)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(104, 18)
        Me.label3.TabIndex = 90
        Me.label3.Text = "Descripción"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(21, 83)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(149, 18)
        Me.label2.TabIndex = 89
        Me.label2.Text = "Id Tipo de ingreso"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(281, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(303, 22)
        Me.label1.TabIndex = 88
        Me.label1.Text = "REGISTRAR TIPO DE INGRESO"
        '
        'RegistrarTipoIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.btn_Registrar)
        Me.Controls.Add(Me.btn_MP)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Btn_MS)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "RegistrarTipoIngreso"
        Me.Text = "RegistrarTipoIngreso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents comboBox1 As ComboBox
    Private WithEvents btn_Registrar As Button
    Private WithEvents btn_MP As Button
    Private WithEvents btn_Salir As Button
    Private WithEvents Btn_MS As Button
    Private WithEvents btn_Limpiar As Button
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
