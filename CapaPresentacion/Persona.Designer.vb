<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Persona
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
        Me.IdpersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdidentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZZHospitalDataSet = New CapaPresentacion.ZZHospitalDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PersonaTableAdapter = New CapaPresentacion.ZZHospitalDataSetTableAdapters.personaTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZZHospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.Color.Red
        Me.btn_Salir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.Location = New System.Drawing.Point(569, 356)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(193, 54)
        Me.btn_Salir.TabIndex = 176
        Me.btn_Salir.Text = "CERRAR"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdpersonaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidopDataGridViewTextBoxColumn, Me.ApellidomDataGridViewTextBoxColumn, Me.IdidentificacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(93, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 255)
        Me.DataGridView1.TabIndex = 175
        '
        'IdpersonaDataGridViewTextBoxColumn
        '
        Me.IdpersonaDataGridViewTextBoxColumn.DataPropertyName = "id_persona"
        Me.IdpersonaDataGridViewTextBoxColumn.HeaderText = "id_persona"
        Me.IdpersonaDataGridViewTextBoxColumn.Name = "IdpersonaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidopDataGridViewTextBoxColumn
        '
        Me.ApellidopDataGridViewTextBoxColumn.DataPropertyName = "apellido_p"
        Me.ApellidopDataGridViewTextBoxColumn.HeaderText = "apellido_p"
        Me.ApellidopDataGridViewTextBoxColumn.Name = "ApellidopDataGridViewTextBoxColumn"
        '
        'ApellidomDataGridViewTextBoxColumn
        '
        Me.ApellidomDataGridViewTextBoxColumn.DataPropertyName = "apellido_m"
        Me.ApellidomDataGridViewTextBoxColumn.HeaderText = "apellido_m"
        Me.ApellidomDataGridViewTextBoxColumn.Name = "ApellidomDataGridViewTextBoxColumn"
        '
        'IdidentificacionDataGridViewTextBoxColumn
        '
        Me.IdidentificacionDataGridViewTextBoxColumn.DataPropertyName = "id_identificacion"
        Me.IdidentificacionDataGridViewTextBoxColumn.HeaderText = "id_identificacion"
        Me.IdidentificacionDataGridViewTextBoxColumn.Name = "IdidentificacionDataGridViewTextBoxColumn"
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "persona"
        Me.PersonaBindingSource.DataSource = Me.ZZHospitalDataSet
        '
        'ZZHospitalDataSet
        '
        Me.ZZHospitalDataSet.DataSetName = "ZZHospitalDataSet"
        Me.ZZHospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 22)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "REGISTRO DE PERSONAS"
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Persona"
        Me.Text = "Persona"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZZHospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btn_Salir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ZZHospitalDataSet As ZZHospitalDataSet
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As ZZHospitalDataSetTableAdapters.personaTableAdapter
    Friend WithEvents IdpersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdidentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
