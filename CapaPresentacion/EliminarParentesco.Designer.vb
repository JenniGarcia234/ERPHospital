﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarParentesco
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
        Me.btn_MP = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_MS = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_Eliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.Location = New System.Drawing.Point(216, 221)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(168, 54)
        Me.btn_Eliminar.TabIndex = 153
        Me.btn_Eliminar.Text = "ELIMINAR"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_MP
        '
        Me.btn_MP.BackColor = System.Drawing.Color.Yellow
        Me.btn_MP.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MP.Location = New System.Drawing.Point(593, 185)
        Me.btn_MP.Name = "btn_MP"
        Me.btn_MP.Size = New System.Drawing.Size(140, 55)
        Me.btn_MP.TabIndex = 151
        Me.btn_MP.Text = "MENU PRINCIPAL"
        Me.btn_MP.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(593, 260)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(140, 55)
        Me.btn_Salir.TabIndex = 150
        Me.btn_Salir.Text = "SALIR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_MS
        '
        Me.Btn_MS.BackColor = System.Drawing.Color.Orchid
        Me.Btn_MS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MS.Location = New System.Drawing.Point(593, 128)
        Me.Btn_MS.Name = "Btn_MS"
        Me.Btn_MS.Size = New System.Drawing.Size(140, 55)
        Me.Btn_MS.TabIndex = 149
        Me.Btn_MS.Text = "MENU SECUNDARIO"
        Me.Btn_MS.UseVisualStyleBackColor = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.Orange
        Me.btn_Limpiar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Location = New System.Drawing.Point(593, 73)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(140, 55)
        Me.btn_Limpiar.TabIndex = 148
        Me.btn_Limpiar.Text = "LIMPIAR"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(192, 105)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(214, 26)
        Me.textBox2.TabIndex = 147
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(192, 58)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(214, 26)
        Me.textBox1.TabIndex = 146
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(39, 105)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(104, 18)
        Me.label3.TabIndex = 145
        Me.label3.Text = "Descripción"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(39, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(119, 18)
        Me.label2.TabIndex = 144
        Me.label2.Text = "Id parentesco"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(298, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(244, 22)
        Me.label1.TabIndex = 143
        Me.label1.Text = "ELIMINAR PARENTESCO"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_Buscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Location = New System.Drawing.Point(424, 58)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(118, 42)
        Me.btn_Buscar.TabIndex = 154
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'EliminarParentesco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_MP)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.Btn_MS)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "EliminarParentesco"
        Me.Text = "EliminarParentesco"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btn_Eliminar As Button
    Private WithEvents btn_MP As Button
    Private WithEvents btn_Salir As Button
    Private WithEvents Btn_MS As Button
    Private WithEvents btn_Limpiar As Button
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btn_Buscar As Button
End Class
