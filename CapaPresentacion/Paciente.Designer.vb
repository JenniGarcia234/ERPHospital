<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paciente
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
        Me.IdpacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IddatoscDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtarjetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZZ1HospitalDataSet = New CapaPresentacion.ZZ1HospitalDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PacienteTableAdapter = New CapaPresentacion.ZZ1HospitalDataSetTableAdapters.pacienteTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZZ1HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(542, 360)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(193, 54)
        Me.btn_Salir.TabIndex = 179
        Me.btn_Salir.Text = "CERRAR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpacienteDataGridViewTextBoxColumn, Me.IdpersonaDataGridViewTextBoxColumn, Me.IddatoscDataGridViewTextBoxColumn, Me.IdtarjetaDataGridViewTextBoxColumn, Me.IdpolizaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PacienteBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(66, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 255)
        Me.DataGridView1.TabIndex = 178
        '
        'IdpacienteDataGridViewTextBoxColumn
        '
        Me.IdpacienteDataGridViewTextBoxColumn.DataPropertyName = "id_paciente"
        Me.IdpacienteDataGridViewTextBoxColumn.HeaderText = "id_paciente"
        Me.IdpacienteDataGridViewTextBoxColumn.Name = "IdpacienteDataGridViewTextBoxColumn"
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
        'IdtarjetaDataGridViewTextBoxColumn
        '
        Me.IdtarjetaDataGridViewTextBoxColumn.DataPropertyName = "id_tarjeta"
        Me.IdtarjetaDataGridViewTextBoxColumn.HeaderText = "id_tarjeta"
        Me.IdtarjetaDataGridViewTextBoxColumn.Name = "IdtarjetaDataGridViewTextBoxColumn"
        '
        'IdpolizaDataGridViewTextBoxColumn
        '
        Me.IdpolizaDataGridViewTextBoxColumn.DataPropertyName = "id_poliza"
        Me.IdpolizaDataGridViewTextBoxColumn.HeaderText = "id_poliza"
        Me.IdpolizaDataGridViewTextBoxColumn.Name = "IdpolizaDataGridViewTextBoxColumn"
        '
        'PacienteBindingSource
        '
        Me.PacienteBindingSource.DataMember = "paciente"
        Me.PacienteBindingSource.DataSource = Me.ZZ1HospitalDataSet
        '
        'ZZ1HospitalDataSet
        '
        Me.ZZ1HospitalDataSet.DataSetName = "ZZ1HospitalDataSet"
        Me.ZZ1HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 22)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "REGISTRO DE PACIENTES"
        '
        'PacienteTableAdapter
        '
        Me.PacienteTableAdapter.ClearBeforeFill = True
        '
        'Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Paciente"
        Me.Text = "Paciente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZZ1HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btn_Salir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ZZ1HospitalDataSet As ZZ1HospitalDataSet
    Friend WithEvents PacienteBindingSource As BindingSource
    Friend WithEvents PacienteTableAdapter As ZZ1HospitalDataSetTableAdapters.pacienteTableAdapter
    Friend WithEvents IdpacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdpersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IddatoscDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtarjetaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdpolizaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
