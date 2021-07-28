<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visitante
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
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdvisitanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IddatoscDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdparentescoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZZ2HospitalDataSet = New CapaPresentacion.ZZ2HospitalDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VisitanteTableAdapter = New CapaPresentacion.ZZ2HospitalDataSetTableAdapters.visitanteTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZZ2HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(542, 360)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(193, 54)
        Me.btn_Salir.TabIndex = 182
        Me.btn_Salir.Text = "CERRAR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdvisitanteDataGridViewTextBoxColumn, Me.IdpersonaDataGridViewTextBoxColumn, Me.IddatoscDataGridViewTextBoxColumn, Me.IdparentescoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VisitanteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(66, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 255)
        Me.DataGridView1.TabIndex = 181
        '
        'IdvisitanteDataGridViewTextBoxColumn
        '
        Me.IdvisitanteDataGridViewTextBoxColumn.DataPropertyName = "id_visitante"
        Me.IdvisitanteDataGridViewTextBoxColumn.HeaderText = "id_visitante"
        Me.IdvisitanteDataGridViewTextBoxColumn.Name = "IdvisitanteDataGridViewTextBoxColumn"
        '
        'IdpersonaDataGridViewTextBoxColumn
        '
        Me.IdpersonaDataGridViewTextBoxColumn.DataPropertyName = "id_persona"
        Me.IdpersonaDataGridViewTextBoxColumn.HeaderText = "id_persona"
        Me.IdpersonaDataGridViewTextBoxColumn.Name = "IdpersonaDataGridViewTextBoxColumn"
        '
        'IddatoscDataGridViewTextBoxColumn
        '
        Me.IddatoscDataGridViewTextBoxColumn.DataPropertyName = "id_datos_c"
        Me.IddatoscDataGridViewTextBoxColumn.HeaderText = "id_datos_c"
        Me.IddatoscDataGridViewTextBoxColumn.Name = "IddatoscDataGridViewTextBoxColumn"
        '
        'IdparentescoDataGridViewTextBoxColumn
        '
        Me.IdparentescoDataGridViewTextBoxColumn.DataPropertyName = "id_parentesco"
        Me.IdparentescoDataGridViewTextBoxColumn.HeaderText = "id_parentesco"
        Me.IdparentescoDataGridViewTextBoxColumn.Name = "IdparentescoDataGridViewTextBoxColumn"
        '
        'VisitanteBindingSource
        '
        Me.VisitanteBindingSource.DataMember = "visitante"
        Me.VisitanteBindingSource.DataSource = Me.ZZ2HospitalDataSet
        '
        'ZZ2HospitalDataSet
        '
        Me.ZZ2HospitalDataSet.DataSetName = "ZZ2HospitalDataSet"
        Me.ZZ2HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 22)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "REGISTRO DE VISITANTES"
        '
        'VisitanteTableAdapter
        '
        Me.VisitanteTableAdapter.ClearBeforeFill = True
        '
        'Visitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Visitante"
        Me.Text = "Visitante"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZZ2HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btn_Salir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ZZ2HospitalDataSet As ZZ2HospitalDataSet
    Friend WithEvents VisitanteBindingSource As BindingSource
    Friend WithEvents VisitanteTableAdapter As ZZ2HospitalDataSetTableAdapters.visitanteTableAdapter
    Friend WithEvents IdvisitanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdpersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IddatoscDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdparentescoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
