Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbPatientRowChangeEventHandler(ByVal sender As Object, ByVal e As tbPatientRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(), _
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>  _
Partial Public Class tbPatient
Inherits Global.System.Data.TypedTableBase(Of tbPatientRow)

Private columnPatientID As Global.System.Data.DataColumn

Private columnName As Global.System.Data.DataColumn

Private columnBirthDate As Global.System.Data.DataColumn

Private columnHealthInsuranceNumber As Global.System.Data.DataColumn

Private columnShadeID As Global.System.Data.DataColumn

Private columnPhone As Global.System.Data.DataColumn

Private columnEmail As Global.System.Data.DataColumn

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub New()
MyBase.New
Me.TableName = "tbPatient"
Me.BeginInit
Me.InitClass
Me.EndInit
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Friend Sub New(ByVal table As Global.System.Data.DataTable)
MyBase.New
Me.TableName = table.TableName
If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
Me.CaseSensitive = table.CaseSensitive
End If
If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
Me.Locale = table.Locale
End If
If (table.Namespace <> table.DataSet.Namespace) Then
Me.Namespace = table.Namespace
End If
Me.Prefix = table.Prefix
Me.MinimumCapacity = table.MinimumCapacity
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
MyBase.New(info, context)
Me.InitVars
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property PatientIDColumn() As Global.System.Data.DataColumn
Get
Return Me.columnPatientID
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property NameColumn() As Global.System.Data.DataColumn
Get
Return Me.columnName
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property BirthDateColumn() As Global.System.Data.DataColumn
Get
Return Me.columnBirthDate
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property HealthInsuranceNumberColumn() As Global.System.Data.DataColumn
Get
Return Me.columnHealthInsuranceNumber
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property ShadeIDColumn() As Global.System.Data.DataColumn
Get
Return Me.columnShadeID
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property PhoneColumn() As Global.System.Data.DataColumn
Get
Return Me.columnPhone
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property EmailColumn() As Global.System.Data.DataColumn
Get
Return Me.columnEmail
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Browsable(false)>  _
Public ReadOnly Property Count() As Integer
Get
Return Me.Rows.Count
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Default ReadOnly Property Item(ByVal index As Integer) As tbPatientRow
Get
Return CType(Me.Rows(index), tbPatientRow)
End Get
End Property

<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Event tbPatientRowChanging As tbPatientRowChangeEventHandler

<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Event tbPatientRowChanged As tbPatientRowChangeEventHandler

<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Event tbPatientRowDeleting As tbPatientRowChangeEventHandler

<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Event tbPatientRowDeleted As tbPatientRowChangeEventHandler

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Overloads Sub AddtbPatientRow(ByVal row As tbPatientRow)
Me.Rows.Add(row)
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Overloads Function AddtbPatientRow(ByVal Name As String, ByVal BirthDate As Date, ByVal HealthInsuranceNumber As String, ByVal ShadeID As Integer, ByVal Phone As String, ByVal Email As String) As tbPatientRow
Dim rowtbPatientRow As tbPatientRow = CType(Me.NewRow, tbPatientRow)
Dim columnValuesArray() As Object = New Object() {Nothing, Name, BirthDate, HealthInsuranceNumber, ShadeID, Phone, Email}
rowtbPatientRow.ItemArray = columnValuesArray
Me.Rows.Add(rowtbPatientRow)
Return rowtbPatientRow
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Function FindByPatientID(ByVal PatientID As Integer) As tbPatientRow
Return CType(Me.Rows.Find(New Object() {PatientID}),tbPatientRow)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Overrides Function Clone() As Global.System.Data.DataTable
Dim cln As tbPatient = CType(MyBase.Clone, tbPatient)
cln.InitVars
Return cln
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
Return New tbPatient()
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Friend Sub InitVars()
Me.columnPatientID = MyBase.Columns("PatientID")
Me.columnName = MyBase.Columns("Name")
Me.columnBirthDate = MyBase.Columns("BirthDate")
Me.columnHealthInsuranceNumber = MyBase.Columns("HealthInsuranceNumber")
Me.columnShadeID = MyBase.Columns("ShadeID")
Me.columnPhone = MyBase.Columns("Phone")
Me.columnEmail = MyBase.Columns("Email")
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Private Sub InitClass()
Me.columnPatientID = New Global.System.Data.DataColumn("PatientID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
MyBase.Columns.Add(Me.columnPatientID)
Me.columnName = New Global.System.Data.DataColumn("Name", GetType(String), Nothing, Global.System.Data.MappingType.Element)
MyBase.Columns.Add(Me.columnName)
Me.columnBirthDate = New Global.System.Data.DataColumn("BirthDate", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
MyBase.Columns.Add(Me.columnBirthDate)
Me.columnHealthInsuranceNumber = New Global.System.Data.DataColumn("HealthInsuranceNumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
MyBase.Columns.Add(Me.columnHealthInsuranceNumber)
Me.columnShadeID = New Global.System.Data.DataColumn("ShadeID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
MyBase.Columns.Add(Me.columnShadeID)
Me.columnPhone = New Global.System.Data.DataColumn("Phone", GetType(String), Nothing, Global.System.Data.MappingType.Element)
MyBase.Columns.Add(Me.columnPhone)
Me.columnEmail = New Global.System.Data.DataColumn("Email", GetType(String), Nothing, Global.System.Data.MappingType.Element)
MyBase.Columns.Add(Me.columnEmail)
Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnPatientID}, true))
Me.columnPatientID.AutoIncrement = true
Me.columnPatientID.AutoIncrementSeed = -1
Me.columnPatientID.AutoIncrementStep = -1
Me.columnPatientID.AllowDBNull = false
Me.columnPatientID.ReadOnly = true
Me.columnPatientID.Unique = true
Me.columnName.AllowDBNull = false
Me.columnName.MaxLength = 1024
Me.columnHealthInsuranceNumber.MaxLength = 20
Me.columnPhone.MaxLength = 20
Me.columnEmail.MaxLength = 2147483647
Me.Constraints.Add(New System.Data.UniqueConstraint("UX_tbPatient_HealthInsuranceNumber", New System.Data.DataColumn() { Me.columnHealthInsuranceNumber}, False))
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Function NewtbPatientRow() As tbPatientRow
Return CType(Me.NewRow, tbPatientRow)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
Return New tbPatientRow(builder)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Overrides Function GetRowType() As Global.System.Type
Return GetType(tbPatientRow)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
MyBase.OnRowChanged(e)
If (Not (Me.tbPatientRowChangedEvent) Is Nothing) Then
RaiseEvent tbPatientRowChanged(Me, New tbPatientRowChangeEvent(CType(e.Row, tbPatientRow), e.Action))
End If
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
MyBase.OnRowChanging(e)
If (Not (Me.tbPatientRowChangingEvent) Is Nothing) Then
RaiseEvent tbPatientRowChanging(Me, New tbPatientRowChangeEvent(CType(e.Row, tbPatientRow), e.Action))
End If
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
MyBase.OnRowDeleted(e)
If (Not (Me.tbPatientRowDeletedEvent) Is Nothing) Then
RaiseEvent tbPatientRowDeleted(Me, New tbPatientRowChangeEvent(CType(e.Row, tbPatientRow), e.Action))
End If
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
MyBase.OnRowDeleting(e)
If (Not (Me.tbPatientRowDeletingEvent) Is Nothing) Then
RaiseEvent tbPatientRowDeleting(Me, New tbPatientRowChangeEvent(CType(e.Row, tbPatientRow), e.Action))
End If
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub RemovetbPatientRow(ByVal row As tbPatientRow)
Me.Rows.Remove(row)
End Sub
Private _ta As tbPatientTableAdapter
        Private _dbrm As dbrm

        Public ReadOnly Property TableAdapter() As tbPatientTableAdapter
            Get
                If _ta Is Nothing Then
                    _ta = New tbPatientTableAdapter
                End If
                Return _ta
            End Get
        End Property

        Public Property InstantUpdate() As Boolean
            Get
                If _dbrm Is Nothing Then
                    Return False
                Else
                    Return _dbrm.InstantUpdate
                End If
            End Get
            Set(ByVal value As Boolean)
                If value Then
                    If _ta Is Nothing Then
                        _ta = New tbPatientTableAdapter
                    End If
                    If _dbrm Is Nothing Then
                        _dbrm = New dbrm(Me, _ta)
                    End If
                    _dbrm.InstantUpdate = True
                Else
                    If _dbrm IsNot Nothing Then
                        _dbrm.InstantUpdate = False
                    End If
                End If
            End Set
        End Property

        Public Function Fill() As Integer
            Dim result As Integer
            If _dbrm IsNot Nothing Then
                _dbrm.BeginFill()
                result = _ta.Fill(Me)
                _dbrm.EndFill()
            Else
                If _ta Is Nothing Then
                    _ta = New tbPatientTableAdapter
                End If
                result = _ta.Fill(Me)
            End If
            Return result
        End Function

        Public Sub BeginFill()
            If _dbrm IsNot Nothing Then
                _dbrm.BeginFill()
            End If
        End Sub

        Public Sub EndFill()
            If _dbrm IsNot Nothing Then
                _dbrm.EndFill()
            End If
        End Sub

'''<summary>
'''Represents the connection and commands used to retrieve and save data.
'''</summary>
<Global.System.ComponentModel.DesignerCategoryAttribute("code"), _
Global.System.ComponentModel.ToolboxItem(true), _
Global.System.ComponentModel.DataObjectAttribute(true), _
Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner"& _
", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
Partial Public Class tbPatientTableAdapter
Inherits Global.System.ComponentModel.Component

Private WithEvents _adapter As Global.System.Data.SqlClient.SqlDataAdapter

Private _connection As Global.System.Data.SqlClient.SqlConnection

Private _transaction As Global.System.Data.SqlClient.SqlTransaction

Private _commandCollection() As Global.System.Data.SqlClient.SqlCommand

Private _clearBeforeFill As Boolean

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub New()
MyBase.New
Me.ClearBeforeFill = true
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected Friend ReadOnly Property Adapter() As Global.System.Data.SqlClient.SqlDataAdapter
Get
If (Me._adapter Is Nothing) Then
Me.InitAdapter
End If
Return Me._adapter
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Friend Property Connection() As Global.System.Data.SqlClient.SqlConnection
Get
If (Me._connection Is Nothing) Then
Me.InitConnection
End If
Return Me._connection
End Get
Set
Me._connection = value
If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
Me.Adapter.InsertCommand.Connection = value
End If
If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
Me.Adapter.DeleteCommand.Connection = value
End If
If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
Me.Adapter.UpdateCommand.Connection = value
End If
Dim i As Integer = 0
Do While (i < Me.CommandCollection.Length)
If (Not (Me.CommandCollection(i)) Is Nothing) Then
CType(Me.CommandCollection(i), Global.System.Data.SqlClient.SqlCommand).Connection = value
End If
i = (i + 1)
Loop
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Friend Property Transaction() As Global.System.Data.SqlClient.SqlTransaction
Get
Return Me._transaction
End Get
Set
Me._transaction = value
Dim i As Integer = 0
Do While (i < Me.CommandCollection.Length)
Me.CommandCollection(i).Transaction = Me._transaction
i = (i + 1)
Loop
If ((Not (Me.Adapter) Is Nothing)  _
AndAlso (Not (Me.Adapter.DeleteCommand) Is Nothing)) Then
Me.Adapter.DeleteCommand.Transaction = Me._transaction
End If
If ((Not (Me.Adapter) Is Nothing)  _
AndAlso (Not (Me.Adapter.InsertCommand) Is Nothing)) Then
Me.Adapter.InsertCommand.Transaction = Me._transaction
End If
If ((Not (Me.Adapter) Is Nothing)  _
AndAlso (Not (Me.Adapter.UpdateCommand) Is Nothing)) Then
Me.Adapter.UpdateCommand.Transaction = Me._transaction
End If
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Protected ReadOnly Property CommandCollection() As Global.System.Data.SqlClient.SqlCommand()
Get
If (Me._commandCollection Is Nothing) Then
Me.InitCommandCollection
End If
Return Me._commandCollection
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property ClearBeforeFill() As Boolean
Get
Return Me._clearBeforeFill
End Get
Set
Me._clearBeforeFill = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Private Sub InitAdapter()
Me._adapter = New Global.System.Data.SqlClient.SqlDataAdapter()
Dim tableMapping As Global.System.Data.Common.DataTableMapping = New Global.System.Data.Common.DataTableMapping()
tableMapping.SourceTable = "Table"
tableMapping.DataSetTable = "tbPatient"
tableMapping.ColumnMappings.Add("PatientID", "PatientID")
tableMapping.ColumnMappings.Add("Name", "Name")
tableMapping.ColumnMappings.Add("BirthDate", "BirthDate")
tableMapping.ColumnMappings.Add("HealthInsuranceNumber", "HealthInsuranceNumber")
tableMapping.ColumnMappings.Add("ShadeID", "ShadeID")
tableMapping.ColumnMappings.Add("Phone", "Phone")
tableMapping.ColumnMappings.Add("Email", "Email")
Me._adapter.TableMappings.Add(tableMapping)
Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
Me._adapter.DeleteCommand.Connection = Me.Connection
Me._adapter.DeleteCommand.CommandText = "exec sp_tbPatient_D @Original_PatientID"
Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PatientID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PatientID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_BirthDate", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "BirthDate", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_BirthDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "BirthDate", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_HealthInsuranceNumber", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "HealthInsuranceNumber", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_HealthInsuranceNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "HealthInsuranceNumber", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Phone", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
Me._adapter.InsertCommand.Connection = Me.Connection
Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbPatient_I  @Name, @BirthDate, @HealthInsuranceNumber, @ShadeID, @Phone, @Email; " & _
"SELECT PatientID , Name , BirthDate , HealthInsuranceNumber , ShadeID , Phone , Email " & _
"FROM tbPatient " & _
"WHERE PatientID = @RETURN_VALUE"
Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@BirthDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "BirthDate", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@HealthInsuranceNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "HealthInsuranceNumber", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
Me._adapter.UpdateCommand.Connection = Me.Connection
Me._adapter.UpdateCommand.CommandText = "exec sp_tbPatient_U @PatientID, @Name, @Original_Name, @BirthDate, @Original_BirthDate, @HealthInsuranceNumber, @Original_HealthInsuranceNumber, @ShadeID, @Original_ShadeID, @Phone, @Original_Phone, @Email, @Original_Email; " & _
"SELECT PatientID , Name , BirthDate , HealthInsuranceNumber , ShadeID , Phone , Email " & _
"FROM tbPatient " & _
"WHERE PatientID = @PatientID"
Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@BirthDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "BirthDate", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@HealthInsuranceNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "HealthInsuranceNumber", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PatientID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PatientID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_BirthDate", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "BirthDate", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_BirthDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "BirthDate", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_HealthInsuranceNumber", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "HealthInsuranceNumber", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_HealthInsuranceNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "HealthInsuranceNumber", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Phone", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, true, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, false, Nothing, "", "", ""))
Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PatientID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "PatientID", Global.System.Data.DataRowVersion.Current, false, Nothing, "", "", ""))
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Private Sub InitConnection()
Me._connection = GS.cnn
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Private Sub InitCommandCollection()
Me._commandCollection = New Global.System.Data.SqlClient.SqlCommand(0) {}
Me._commandCollection(0) = New Global.System.Data.SqlClient.SqlCommand()
Me._commandCollection(0).CommandTimeout = GS.CommandTimeout
Me._commandCollection(0).Connection = Me.Connection
Me._commandCollection(0).CommandText = "sp_tbPatient_S"
Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),  _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),  _
Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, true) > _
Public Overloads Overridable Function Fill(ByVal dataTable As tbPatient) As Integer
Me.Adapter.SelectCommand = Me.CommandCollection(0)
If (Me.ClearBeforeFill = true) Then
dataTable.Clear
End If
Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
Return returnValue
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), _
Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], true)> _
Public Overloads Overridable Function GetData() As tbPatient
Me.Adapter.SelectCommand = Me.CommandCollection(0)
Dim dataTable As tbPatient = New tbPatient()
Me.Adapter.Fill(dataTable)
Return dataTable
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
Public Overloads Overridable Function Update(ByVal dataTable As tbPatient) As Integer
Return Me.Adapter.Update(dataTable)
End Function


<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>  _
Public Overloads Overridable Function Update(ByVal dataRow As Global.System.Data.DataRow) As Integer
Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),  _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter") > _
Public Overloads Overridable Function Update(ByVal dataRows() As Global.System.Data.DataRow) As Integer
Return Me.Adapter.Update(dataRows)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), _
Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Delete, true)>  _
Public Overloads Overridable Function Delete(ByVal Original_PatientID As Integer, ByVal Original_Name As String, ByVal Original_BirthDate As Global.System.Nullable(Of Date), ByVal Original_HealthInsuranceNumber As String, ByVal Original_ShadeID As Global.System.Nullable(Of Integer), ByVal Original_Phone As String) As Integer
Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_PatientID, Integer)
If (Original_Name Is Nothing) Then
Throw New Global.System.ArgumentNullException("Original_Name")
Else
Me.Adapter.DeleteCommand.Parameters(1).Value = CType(Original_Name, String)
End If
If (Original_BirthDate.HasValue = true) Then
Me.Adapter.DeleteCommand.Parameters(2).Value = CType(0, Object)
Me.Adapter.DeleteCommand.Parameters(3).Value = CType(Original_BirthDate.Value, Date)
Else
Me.Adapter.DeleteCommand.Parameters(2).Value = CType(1, Object)
Me.Adapter.DeleteCommand.Parameters(3).Value = Global.System.DBNull.Value
End If
If (Original_HealthInsuranceNumber Is Nothing) Then
Me.Adapter.DeleteCommand.Parameters(4).Value = CType(1, Object)
Me.Adapter.DeleteCommand.Parameters(5).Value = Global.System.DBNull.Value
Else
Me.Adapter.DeleteCommand.Parameters(4).Value = CType(0, Object)
Me.Adapter.DeleteCommand.Parameters(5).Value = CType(Original_HealthInsuranceNumber, String)
End If
If (Original_ShadeID.HasValue = true) Then
Me.Adapter.DeleteCommand.Parameters(6).Value = CType(0, Object)
Me.Adapter.DeleteCommand.Parameters(7).Value = CType(Original_ShadeID.Value, Integer)
Else
Me.Adapter.DeleteCommand.Parameters(6).Value = CType(1, Object)
Me.Adapter.DeleteCommand.Parameters(7).Value = Global.System.DBNull.Value
End If
If (Original_Phone Is Nothing) Then
Me.Adapter.DeleteCommand.Parameters(8).Value = CType(1, Object)
Me.Adapter.DeleteCommand.Parameters(9).Value = Global.System.DBNull.Value
Else
Me.Adapter.DeleteCommand.Parameters(8).Value = CType(0, Object)
Me.Adapter.DeleteCommand.Parameters(9).Value = CType(Original_Phone, String)
End If
Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
<> Global.System.Data.ConnectionState.Open) Then
Me.Adapter.DeleteCommand.Connection.Open
End If
Try
Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery
Return returnValue
Finally
If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
Me.Adapter.DeleteCommand.Connection.Close
End If
End Try
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), _
Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, true)>  _
Public Overloads Overridable Function Insert(ByVal Name As String, ByVal BirthDate As Global.System.Nullable(Of Date), ByVal HealthInsuranceNumber As String, ByVal ShadeID As Global.System.Nullable(Of Integer), ByVal Phone As String, ByVal Email As String) As Integer
If (Name Is Nothing) Then
Throw New Global.System.ArgumentNullException("Name")
Else
Me.Adapter.InsertCommand.Parameters(0).Value = CType(Name, String)
End If
If (BirthDate.HasValue = true) Then
Me.Adapter.InsertCommand.Parameters(1).Value = CType(BirthDate.Value, Date)
Else
Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
End If
If (HealthInsuranceNumber Is Nothing) Then
Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
Else
Me.Adapter.InsertCommand.Parameters(2).Value = CType(HealthInsuranceNumber, String)
End If
If (ShadeID.HasValue = true) Then
Me.Adapter.InsertCommand.Parameters(3).Value = CType(ShadeID.Value, Integer)
Else
Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
End If
If (Phone Is Nothing) Then
Me.Adapter.InsertCommand.Parameters(4).Value = Global.System.DBNull.Value
Else
Me.Adapter.InsertCommand.Parameters(4).Value = CType(Phone, String)
End If
If (Email Is Nothing) Then
Me.Adapter.InsertCommand.Parameters(5).Value = Global.System.DBNull.Value
Else
Me.Adapter.InsertCommand.Parameters(5).Value = CType(Email, String)
End If
Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
<> Global.System.Data.ConnectionState.Open) Then
Me.Adapter.InsertCommand.Connection.Open
End If
Try
Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
Return returnValue
Finally
If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
Me.Adapter.InsertCommand.Connection.Close
End If
End Try
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), _
Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, true)>  _
Public Overloads Overridable Function Update(ByVal Name As String, ByVal BirthDate As Global.System.Nullable(Of Date), ByVal HealthInsuranceNumber As String, ByVal ShadeID As Global.System.Nullable(Of Integer), ByVal Phone As String, ByVal Email As String, ByVal Original_PatientID As Integer, ByVal Original_Name As String, ByVal Original_BirthDate As Global.System.Nullable(Of Date), ByVal Original_HealthInsuranceNumber As String, ByVal Original_ShadeID As Global.System.Nullable(Of Integer), ByVal Original_Phone As String, ByVal PatientID As Integer) As Integer
If (Name Is Nothing) Then
Throw New Global.System.ArgumentNullException("Name")
Else
Me.Adapter.UpdateCommand.Parameters(0).Value = CType(Name, String)
End If
If (BirthDate.HasValue = true) Then
Me.Adapter.UpdateCommand.Parameters(1).Value = CType(BirthDate.Value, Date)
Else
Me.Adapter.UpdateCommand.Parameters(1).Value = Global.System.DBNull.Value
End If
If (HealthInsuranceNumber Is Nothing) Then
Me.Adapter.UpdateCommand.Parameters(2).Value = Global.System.DBNull.Value
Else
Me.Adapter.UpdateCommand.Parameters(2).Value = CType(HealthInsuranceNumber, String)
End If
If (ShadeID.HasValue = true) Then
Me.Adapter.UpdateCommand.Parameters(3).Value = CType(ShadeID.Value, Integer)
Else
Me.Adapter.UpdateCommand.Parameters(3).Value = Global.System.DBNull.Value
End If
If (Phone Is Nothing) Then
Me.Adapter.UpdateCommand.Parameters(4).Value = Global.System.DBNull.Value
Else
Me.Adapter.UpdateCommand.Parameters(4).Value = CType(Phone, String)
End If
If (Email Is Nothing) Then
Me.Adapter.UpdateCommand.Parameters(5).Value = Global.System.DBNull.Value
Else
Me.Adapter.UpdateCommand.Parameters(5).Value = CType(Email, String)
End If
Me.Adapter.UpdateCommand.Parameters(6).Value = CType(Original_PatientID, Integer)
If (Original_Name Is Nothing) Then
Throw New Global.System.ArgumentNullException("Original_Name")
Else
Me.Adapter.UpdateCommand.Parameters(7).Value = CType(Original_Name, String)
End If
If (Original_BirthDate.HasValue = true) Then
Me.Adapter.UpdateCommand.Parameters(8).Value = CType(0, Object)
Me.Adapter.UpdateCommand.Parameters(9).Value = CType(Original_BirthDate.Value, Date)
Else
Me.Adapter.UpdateCommand.Parameters(8).Value = CType(1, Object)
Me.Adapter.UpdateCommand.Parameters(9).Value = Global.System.DBNull.Value
End If
If (Original_HealthInsuranceNumber Is Nothing) Then
Me.Adapter.UpdateCommand.Parameters(10).Value = CType(1, Object)
Me.Adapter.UpdateCommand.Parameters(11).Value = Global.System.DBNull.Value
Else
Me.Adapter.UpdateCommand.Parameters(10).Value = CType(0, Object)
Me.Adapter.UpdateCommand.Parameters(11).Value = CType(Original_HealthInsuranceNumber, String)
End If
If (Original_ShadeID.HasValue = true) Then
Me.Adapter.UpdateCommand.Parameters(12).Value = CType(0, Object)
Me.Adapter.UpdateCommand.Parameters(13).Value = CType(Original_ShadeID.Value, Integer)
Else
Me.Adapter.UpdateCommand.Parameters(12).Value = CType(1, Object)
Me.Adapter.UpdateCommand.Parameters(13).Value = Global.System.DBNull.Value
End If
If (Original_Phone Is Nothing) Then
Me.Adapter.UpdateCommand.Parameters(14).Value = CType(1, Object)
Me.Adapter.UpdateCommand.Parameters(15).Value = Global.System.DBNull.Value
Else
Me.Adapter.UpdateCommand.Parameters(14).Value = CType(0, Object)
Me.Adapter.UpdateCommand.Parameters(15).Value = CType(Original_Phone, String)
End If
Me.Adapter.UpdateCommand.Parameters(16).Value = CType(PatientID, Integer)
Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
If ((Me.Adapter.UpdateCommand.Connection.State And Global.System.Data.ConnectionState.Open)  _
<> Global.System.Data.ConnectionState.Open) Then
Me.Adapter.UpdateCommand.Connection.Open
End If
Try
Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery
Return returnValue
Finally
If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
Me.Adapter.UpdateCommand.Connection.Close
End If
End Try
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"), _
Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), _
Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, true)>  _
Public Overloads Overridable Function Update(ByVal Name As String, ByVal BirthDate As Global.System.Nullable(Of Date), ByVal HealthInsuranceNumber As String, ByVal ShadeID As Global.System.Nullable(Of Integer), ByVal Phone As String, ByVal Email As String, ByVal Original_PatientID As Integer, ByVal Original_Name As String, ByVal Original_BirthDate As Global.System.Nullable(Of Date), ByVal Original_HealthInsuranceNumber As String, ByVal Original_ShadeID As Global.System.Nullable(Of Integer), ByVal Original_Phone As String) As Integer
Return Me.Update(Name, BirthDate, HealthInsuranceNumber, ShadeID, Phone, Email, Original_PatientID, Original_Name, Original_BirthDate, Original_HealthInsuranceNumber, Original_ShadeID, Original_Phone, Original_PatientID)
End Function
End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbPatientRow
Inherits Global.System.Data.DataRow

Private tabletbPatient As tbPatient

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
MyBase.New(rb)
Me.tabletbPatient = CType(Me.Table, tbPatient)
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property PatientID() As Integer
Get
Return CType(Me(Me.tabletbPatient.PatientIDColumn), Integer)
End Get
Set
Me(Me.tabletbPatient.PatientIDColumn) = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property Name() As String
Get
Return CType(Me(Me.tabletbPatient.NameColumn), String)
End Get
Set
Me(Me.tabletbPatient.NameColumn) = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property BirthDate() As Date
Get
Try
Return CType(Me(Me.tabletbPatient.BirthDateColumn), Date)
Catch e As Global.System.InvalidCastException
Throw New Global.System.Data.StrongTypingException("The value for column 'BirthDate' in table 'tbPatient' is DBNull.", e)
End Try
End Get
Set
Me(Me.tabletbPatient.BirthDateColumn) = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property HealthInsuranceNumber() As String
Get
Try
Return CType(Me(Me.tabletbPatient.HealthInsuranceNumberColumn), String)
Catch e As Global.System.InvalidCastException
Throw New Global.System.Data.StrongTypingException("The value for column 'HealthInsuranceNumber' in table 'tbPatient' is DBNull.", e)
End Try
End Get
Set
Me(Me.tabletbPatient.HealthInsuranceNumberColumn) = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property ShadeID() As Integer
Get
Try
Return CType(Me(Me.tabletbPatient.ShadeIDColumn), Integer)
Catch e As Global.System.InvalidCastException
Throw New Global.System.Data.StrongTypingException("The value for column 'ShadeID' in table 'tbPatient' is DBNull.", e)
End Try
End Get
Set
Me(Me.tabletbPatient.ShadeIDColumn) = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property Phone() As String
Get
Try
Return CType(Me(Me.tabletbPatient.PhoneColumn), String)
Catch e As Global.System.InvalidCastException
Throw New Global.System.Data.StrongTypingException("The value for column 'Phone' in table 'tbPatient' is DBNull.", e)
End Try
End Get
Set
Me(Me.tabletbPatient.PhoneColumn) = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Property Email() As String
Get
Try
Return CType(Me(Me.tabletbPatient.EmailColumn), String)
Catch e As Global.System.InvalidCastException
Throw New Global.System.Data.StrongTypingException("The value for column 'Email' in table 'tbPatient' is DBNull.", e)
End Try
End Get
Set
Me(Me.tabletbPatient.EmailColumn) = value
End Set
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Function IsBirthDateNull() As Boolean
Return Me.IsNull(Me.tabletbPatient.BirthDateColumn)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub SetBirthDateNull()
Me(Me.tabletbPatient.BirthDateColumn) = Global.System.Convert.DBNull
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Function IsHealthInsuranceNumberNull() As Boolean
Return Me.IsNull(Me.tabletbPatient.HealthInsuranceNumberColumn)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub SetHealthInsuranceNumberNull()
Me(Me.tabletbPatient.HealthInsuranceNumberColumn) = Global.System.Convert.DBNull
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Function IsShadeIDNull() As Boolean
Return Me.IsNull(Me.tabletbPatient.ShadeIDColumn)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub SetShadeIDNull()
Me(Me.tabletbPatient.ShadeIDColumn) = Global.System.Convert.DBNull
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Function IsPhoneNull() As Boolean
Return Me.IsNull(Me.tabletbPatient.PhoneColumn)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub SetPhoneNull()
Me(Me.tabletbPatient.PhoneColumn) = Global.System.Convert.DBNull
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Function IsEmailNull() As Boolean
Return Me.IsNull(Me.tabletbPatient.EmailColumn)
End Function

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub SetEmailNull()
Me(Me.tabletbPatient.EmailColumn) = Global.System.Convert.DBNull
End Sub
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Class tbPatientRowChangeEvent
Inherits Global.System.EventArgs

Private eventRow As tbPatientRow

Private eventAction As Global.System.Data.DataRowAction

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public Sub New(ByVal row As tbPatientRow, ByVal action As Global.System.Data.DataRowAction)
MyBase.New
Me.eventRow = row
Me.eventAction = action
End Sub

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property Row() As tbPatientRow
Get
Return Me.eventRow
End Get
End Property

<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>  _
Public ReadOnly Property Action() As Global.System.Data.DataRowAction
Get
Return Me.eventAction
End Get
End Property
End Class
