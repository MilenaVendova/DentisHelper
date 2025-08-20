<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodeGeneratorMethod
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DsClassControler = New PremierM.dsClassControler()
        Me.TbControlerMethodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbControlerMethodDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.DsClassControler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbControlerMethodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbControlerMethodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsClassControler
        '
        Me.DsClassControler.DataSetName = "dsClassControler"
        Me.DsClassControler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbControlerMethodBindingSource
        '
        Me.TbControlerMethodBindingSource.DataMember = "tbControlerMethod"
        Me.TbControlerMethodBindingSource.DataSource = Me.DsClassControler
        '
        'TbControlerMethodDataGridView
        '
        Me.TbControlerMethodDataGridView.AllowUserToAddRows = False
        Me.TbControlerMethodDataGridView.AllowUserToDeleteRows = False
        Me.TbControlerMethodDataGridView.AllowUserToOrderColumns = True
        Me.TbControlerMethodDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbControlerMethodDataGridView.AutoGenerateColumns = False
        Me.TbControlerMethodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TbControlerMethodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TbControlerMethodDataGridView.DataSource = Me.TbControlerMethodBindingSource
        Me.TbControlerMethodDataGridView.Location = New System.Drawing.Point(1, 1)
        Me.TbControlerMethodDataGridView.Name = "TbControlerMethodDataGridView"
        Me.TbControlerMethodDataGridView.Size = New System.Drawing.Size(468, 454)
        Me.TbControlerMethodDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MethodName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MethodName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ControlerMethod"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ControlerMethod"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(307, 461)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 2
        Me.ButtonOK.Text = "&OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(388, 461)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "&Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'frmCodeGeneratorMethod
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(470, 489)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TbControlerMethodDataGridView)
        Me.Name = "frmCodeGeneratorMethod"
        Me.Text = "Methods"
        CType(Me.DsClassControler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbControlerMethodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbControlerMethodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsClassControler As dsClassControler
    Friend WithEvents TbControlerMethodBindingSource As BindingSource
    Friend WithEvents TbControlerMethodDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
End Class
