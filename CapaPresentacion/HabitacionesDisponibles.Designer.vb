<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HabitacionesDisponibles
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
        Me.IdhabitacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NohabitacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabitacionesDisponiblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Z2HospitalDataSet = New CapaPresentacion.z2HospitalDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HabitacionesDisponiblesTableAdapter = New CapaPresentacion.z2HospitalDataSetTableAdapters.HabitacionesDisponiblesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesDisponiblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Z2HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(596, 271)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(141, 54)
        Me.btn_Salir.TabIndex = 173
        Me.btn_Salir.Text = "CERRAR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdhabitacionDataGridViewTextBoxColumn, Me.NohabitacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HabitacionesDisponiblesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(168, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(378, 185)
        Me.DataGridView1.TabIndex = 172
        '
        'IdhabitacionDataGridViewTextBoxColumn
        '
        Me.IdhabitacionDataGridViewTextBoxColumn.DataPropertyName = "id_habitacion"
        Me.IdhabitacionDataGridViewTextBoxColumn.HeaderText = "id_habitacion"
        Me.IdhabitacionDataGridViewTextBoxColumn.Name = "IdhabitacionDataGridViewTextBoxColumn"
        '
        'NohabitacionDataGridViewTextBoxColumn
        '
        Me.NohabitacionDataGridViewTextBoxColumn.DataPropertyName = "no_habitacion"
        Me.NohabitacionDataGridViewTextBoxColumn.HeaderText = "no_habitacion"
        Me.NohabitacionDataGridViewTextBoxColumn.Name = "NohabitacionDataGridViewTextBoxColumn"
        '
        'HabitacionesDisponiblesBindingSource
        '
        Me.HabitacionesDisponiblesBindingSource.DataMember = "HabitacionesDisponibles"
        Me.HabitacionesDisponiblesBindingSource.DataSource = Me.Z2HospitalDataSet
        '
        'Z2HospitalDataSet
        '
        Me.Z2HospitalDataSet.DataSetName = "z2HospitalDataSet"
        Me.Z2HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 22)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "HABITACIONES DISPONIBLES"
        '
        'HabitacionesDisponiblesTableAdapter
        '
        Me.HabitacionesDisponiblesTableAdapter.ClearBeforeFill = True
        '
        'HabitacionesDisponibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HabitacionesDisponibles"
        Me.Text = "HabitacionesDisponibles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesDisponiblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Z2HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btn_Salir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Z2HospitalDataSet As z2HospitalDataSet
    Friend WithEvents HabitacionesDisponiblesBindingSource As BindingSource
    Friend WithEvents HabitacionesDisponiblesTableAdapter As z2HospitalDataSetTableAdapters.HabitacionesDisponiblesTableAdapter
    Friend WithEvents IdhabitacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NohabitacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
