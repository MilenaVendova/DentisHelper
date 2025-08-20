<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCodeGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbObjects = New System.Windows.Forms.ListBox()
        Me.bsObject = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsObject = New System.Data.DataSet()
        Me.tbObject = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnGO = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonController = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTypeScript = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModel = New System.Windows.Forms.RadioButton()
        Me.txtCode = New System.Windows.Forms.TextBox()
        CType(Me.bsObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbObjects
        '
        Me.lbObjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbObjects.DataSource = Me.bsObject
        Me.lbObjects.DisplayMember = "ObjectName"
        Me.lbObjects.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbObjects.FormattingEnabled = True
        Me.lbObjects.ItemHeight = 15
        Me.lbObjects.Location = New System.Drawing.Point(3, 71)
        Me.lbObjects.Name = "lbObjects"
        Me.lbObjects.Size = New System.Drawing.Size(263, 379)
        Me.lbObjects.Sorted = True
        Me.lbObjects.TabIndex = 0
        Me.lbObjects.ValueMember = "ObjectPath"
        '
        'bsObject
        '
        Me.bsObject.DataMember = "tbObject"
        Me.bsObject.DataSource = Me.dsObject
        '
        'dsObject
        '
        Me.dsObject.DataSetName = "dsObject"
        Me.dsObject.Tables.AddRange(New System.Data.DataTable() {Me.tbObject})
        '
        'tbObject
        '
        Me.tbObject.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.tbObject.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"ObjectName"}, True)})
        Me.tbObject.PrimaryKey = New System.Data.DataColumn() {Me.DataColumn1}
        Me.tbObject.TableName = "tbObject"
        '
        'DataColumn1
        '
        Me.DataColumn1.AllowDBNull = False
        Me.DataColumn1.ColumnName = "ObjectName"
        '
        'DataColumn2
        '
        Me.DataColumn2.AllowDBNull = False
        Me.DataColumn2.Caption = "ObjectPath"
        Me.DataColumn2.ColumnName = "ObjectPath"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFilter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbObjects)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtCode)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 1
        '
        'btnGO
        '
        Me.btnGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnGO.Location = New System.Drawing.Point(224, 10)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(40, 23)
        Me.btnGO.TabIndex = 3
        Me.btnGO.Text = "GO"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(4, 10)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(213, 23)
        Me.txtFilter.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButtonController)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTypeScript)
        Me.GroupBox1.Controls.Add(Me.RadioButtonModel)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 36)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'RadioButtonController
        '
        Me.RadioButtonController.AutoSize = True
        Me.RadioButtonController.Location = New System.Drawing.Point(90, 12)
        Me.RadioButtonController.Name = "RadioButtonController"
        Me.RadioButtonController.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonController.TabIndex = 2
        Me.RadioButtonController.Text = "Controler"
        Me.RadioButtonController.UseVisualStyleBackColor = True
        '
        'RadioButtonTypeScript
        '
        Me.RadioButtonTypeScript.AutoSize = True
        Me.RadioButtonTypeScript.Location = New System.Drawing.Point(174, 12)
        Me.RadioButtonTypeScript.Name = "RadioButtonTypeScript"
        Me.RadioButtonTypeScript.Size = New System.Drawing.Size(76, 17)
        Me.RadioButtonTypeScript.TabIndex = 1
        Me.RadioButtonTypeScript.Text = "TypeScript"
        Me.RadioButtonTypeScript.UseVisualStyleBackColor = True
        '
        'RadioButtonModel
        '
        Me.RadioButtonModel.AutoSize = True
        Me.RadioButtonModel.Checked = True
        Me.RadioButtonModel.Location = New System.Drawing.Point(17, 12)
        Me.RadioButtonModel.Name = "RadioButtonModel"
        Me.RadioButtonModel.Size = New System.Drawing.Size(54, 17)
        Me.RadioButtonModel.TabIndex = 0
        Me.RadioButtonModel.TabStop = True
        Me.RadioButtonModel.Text = "Model"
        Me.RadioButtonModel.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtCode.Location = New System.Drawing.Point(0, 0)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCode.Size = New System.Drawing.Size(530, 450)
        Me.txtCode.TabIndex = 0
        '
        'frmCodeGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmCodeGenerator"
        Me.Text = "Trierra Soft Code Generator"
        CType(Me.bsObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbObject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbObjects As ListBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtCode As TextBox
    Friend WithEvents dsObject As DataSet
    Friend WithEvents tbObject As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents btnGO As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents bsObject As BindingSource
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonTypeScript As RadioButton
    Friend WithEvents RadioButtonModel As RadioButton
    Friend WithEvents RadioButtonController As RadioButton
End Class
