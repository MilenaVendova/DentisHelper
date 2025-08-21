Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbDoctor_PracticeRowChangeEventHandler(ByVal sender As Object, ByVal e As tbDoctor_PracticeRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(),
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
Partial Public Class tbDoctor_Practice
	Inherits Global.System.Data.TypedTableBase(Of tbDoctor_PracticeRow)

	Private columnPracticeDoctorID As Global.System.Data.DataColumn

	Private columnPracitceID As Global.System.Data.DataColumn

	Private columnDoctorID As Global.System.Data.DataColumn

	Private columnStartDate As Global.System.Data.DataColumn

	Private columnEndDate As Global.System.Data.DataColumn

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Sub New()
		MyBase.New
		Me.TableName = "tbDoctor_Practice"
		Me.BeginInit()
		Me.InitClass()
		Me.EndInit()
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
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

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
		MyBase.New(info, context)
		Me.InitVars()
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public ReadOnly Property PracticeDoctorIDColumn() As Global.System.Data.DataColumn
		Get
			Return Me.columnPracticeDoctorID
		End Get
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public ReadOnly Property PracitceIDColumn() As Global.System.Data.DataColumn
		Get
			Return Me.columnPracitceID
		End Get
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public ReadOnly Property DoctorIDColumn() As Global.System.Data.DataColumn
		Get
			Return Me.columnDoctorID
		End Get
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public ReadOnly Property StartDateColumn() As Global.System.Data.DataColumn
		Get
			Return Me.columnStartDate
		End Get
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public ReadOnly Property EndDateColumn() As Global.System.Data.DataColumn
		Get
			Return Me.columnEndDate
		End Get
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
	Global.System.ComponentModel.Browsable(False)>
	Public ReadOnly Property Count() As Integer
		Get
			Return Me.Rows.Count
		End Get
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Default Public ReadOnly Property Item(ByVal index As Integer) As tbDoctor_PracticeRow
		Get
			Return CType(Me.Rows(index), tbDoctor_PracticeRow)
		End Get
	End Property

	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Event tbDoctor_PracticeRowChanging As tbDoctor_PracticeRowChangeEventHandler

	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Event tbDoctor_PracticeRowChanged As tbDoctor_PracticeRowChangeEventHandler

	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Event tbDoctor_PracticeRowDeleting As tbDoctor_PracticeRowChangeEventHandler

	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Event tbDoctor_PracticeRowDeleted As tbDoctor_PracticeRowChangeEventHandler

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Overloads Sub AddtbDoctor_PracticeRow(ByVal row As tbDoctor_PracticeRow)
		Me.Rows.Add(row)
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Overloads Function AddtbDoctor_PracticeRow(ByVal PracitceID As Integer, ByVal DoctorID As Integer, ByVal StartDate As Date, ByVal EndDate As Date) As tbDoctor_PracticeRow
		Dim rowtbDoctor_PracticeRow As tbDoctor_PracticeRow = CType(Me.NewRow, tbDoctor_PracticeRow)
		Dim columnValuesArray() As Object = New Object() {Nothing, PracitceID, DoctorID, StartDate, EndDate}
		rowtbDoctor_PracticeRow.ItemArray = columnValuesArray
		Me.Rows.Add(rowtbDoctor_PracticeRow)
		Return rowtbDoctor_PracticeRow
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Function FindByPracticeDoctorID(ByVal PracticeDoctorID As Integer) As tbDoctor_PracticeRow
		Return CType(Me.Rows.Find(New Object() {PracticeDoctorID}), tbDoctor_PracticeRow)
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Overrides Function Clone() As Global.System.Data.DataTable
		Dim cln As tbDoctor_Practice = CType(MyBase.Clone, tbDoctor_Practice)
		cln.InitVars()
		Return cln
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
		Return New tbDoctor_Practice()
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Friend Sub InitVars()
		Me.columnPracticeDoctorID = MyBase.Columns("PracticeDoctorID")
		Me.columnPracitceID = MyBase.Columns("PracitceID")
		Me.columnDoctorID = MyBase.Columns("DoctorID")
		Me.columnStartDate = MyBase.Columns("StartDate")
		Me.columnEndDate = MyBase.Columns("EndDate")
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Private Sub InitClass()
		Me.columnPracticeDoctorID = New Global.System.Data.DataColumn("PracticeDoctorID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
		MyBase.Columns.Add(Me.columnPracticeDoctorID)
		Me.columnPracitceID = New Global.System.Data.DataColumn("PracitceID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
		MyBase.Columns.Add(Me.columnPracitceID)
		Me.columnDoctorID = New Global.System.Data.DataColumn("DoctorID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
		MyBase.Columns.Add(Me.columnDoctorID)
		Me.columnStartDate = New Global.System.Data.DataColumn("StartDate", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
		MyBase.Columns.Add(Me.columnStartDate)
		Me.columnEndDate = New Global.System.Data.DataColumn("EndDate", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
		MyBase.Columns.Add(Me.columnEndDate)
		Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnPracticeDoctorID}, True))
		Me.columnPracticeDoctorID.AutoIncrement = True
		Me.columnPracticeDoctorID.AutoIncrementSeed = -1
		Me.columnPracticeDoctorID.AutoIncrementStep = -1
		Me.columnPracticeDoctorID.AllowDBNull = False
		Me.columnPracticeDoctorID.ReadOnly = True
		Me.columnPracticeDoctorID.Unique = True
		Me.columnPracitceID.AllowDBNull = False
		Me.columnDoctorID.AllowDBNull = False
		Me.columnStartDate.AllowDBNull = False
		Me.Constraints.Add(New System.Data.UniqueConstraint("IX_tbDoctor_Practice_PracticeID_DoctorID_StartDate", New System.Data.DataColumn() {Me.columnDoctorID, Me.columnPracitceID, Me.columnStartDate}, False))
		Me.columnStartDate.DefaultValue = Date.Today
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Function NewtbDoctor_PracticeRow() As tbDoctor_PracticeRow
		Return CType(Me.NewRow, tbDoctor_PracticeRow)
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
		Return New tbDoctor_PracticeRow(builder)
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Overrides Function GetRowType() As Global.System.Type
		Return GetType(tbDoctor_PracticeRow)
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
		MyBase.OnRowChanged(e)
		If (Not (Me.tbDoctor_PracticeRowChangedEvent) Is Nothing) Then
			RaiseEvent tbDoctor_PracticeRowChanged(Me, New tbDoctor_PracticeRowChangeEvent(CType(e.Row, tbDoctor_PracticeRow), e.Action))
		End If
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
		MyBase.OnRowChanging(e)
		If (Not (Me.tbDoctor_PracticeRowChangingEvent) Is Nothing) Then
			RaiseEvent tbDoctor_PracticeRowChanging(Me, New tbDoctor_PracticeRowChangeEvent(CType(e.Row, tbDoctor_PracticeRow), e.Action))
		End If
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
		MyBase.OnRowDeleted(e)
		If (Not (Me.tbDoctor_PracticeRowDeletedEvent) Is Nothing) Then
			RaiseEvent tbDoctor_PracticeRowDeleted(Me, New tbDoctor_PracticeRowChangeEvent(CType(e.Row, tbDoctor_PracticeRow), e.Action))
		End If
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
		MyBase.OnRowDeleting(e)
		If (Not (Me.tbDoctor_PracticeRowDeletingEvent) Is Nothing) Then
			RaiseEvent tbDoctor_PracticeRowDeleting(Me, New tbDoctor_PracticeRowChangeEvent(CType(e.Row, tbDoctor_PracticeRow), e.Action))
		End If
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Sub RemovetbDoctor_PracticeRow(ByVal row As tbDoctor_PracticeRow)
		Me.Rows.Remove(row)
	End Sub
	Private _ta As tbDoctor_PracticeTableAdapter
	Private _dbrm As dbrm

	Public ReadOnly Property TableAdapter() As tbDoctor_PracticeTableAdapter
		Get
			If _ta Is Nothing Then
				_ta = New tbDoctor_PracticeTableAdapter
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
					_ta = New tbDoctor_PracticeTableAdapter
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
				_ta = New tbDoctor_PracticeTableAdapter
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
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"),
	Global.System.ComponentModel.ToolboxItem(True),
	Global.System.ComponentModel.DataObjectAttribute(True),
	Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" &
	", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"),
	Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
	Partial Public Class tbDoctor_PracticeTableAdapter
		Inherits Global.System.ComponentModel.Component

		Private WithEvents _adapter As Global.System.Data.SqlClient.SqlDataAdapter

		Private _connection As Global.System.Data.SqlClient.SqlConnection

		Private _transaction As Global.System.Data.SqlClient.SqlTransaction

		Private _commandCollection() As Global.System.Data.SqlClient.SqlCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Public Sub New()
			MyBase.New
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.SqlClient.SqlDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Friend Property Connection() As Global.System.Data.SqlClient.SqlConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set
				Me._connection = Value
				If (Not (Me.Adapter.InsertCommand) Is Nothing) Then
					Me.Adapter.InsertCommand.Connection = Value
				End If
				If (Not (Me.Adapter.DeleteCommand) Is Nothing) Then
					Me.Adapter.DeleteCommand.Connection = Value
				End If
				If (Not (Me.Adapter.UpdateCommand) Is Nothing) Then
					Me.Adapter.UpdateCommand.Connection = Value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Not (Me.CommandCollection(i)) Is Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.SqlClient.SqlCommand).Connection = Value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Friend Property Transaction() As Global.System.Data.SqlClient.SqlTransaction
			Get
				Return Me._transaction
			End Get
			Set
				Me._transaction = Value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Not (Me.Adapter) Is Nothing) _
				AndAlso (Not (Me.Adapter.DeleteCommand) Is Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Not (Me.Adapter) Is Nothing) _
				AndAlso (Not (Me.Adapter.InsertCommand) Is Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Not (Me.Adapter) Is Nothing) _
				AndAlso (Not (Me.Adapter.UpdateCommand) Is Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Protected ReadOnly Property CommandCollection() As Global.System.Data.SqlClient.SqlCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set
				Me._clearBeforeFill = Value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.SqlClient.SqlDataAdapter()
			Dim tableMapping As Global.System.Data.Common.DataTableMapping = New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "tbDoctor_Practice"
			tableMapping.ColumnMappings.Add("PracticeDoctorID", "PracticeDoctorID")
			tableMapping.ColumnMappings.Add("PracitceID", "PracitceID")
			tableMapping.ColumnMappings.Add("DoctorID", "DoctorID")
			tableMapping.ColumnMappings.Add("StartDate", "StartDate")
			tableMapping.ColumnMappings.Add("EndDate", "EndDate")
			Me._adapter.TableMappings.Add(tableMapping)
			Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
			Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
			Me._adapter.DeleteCommand.Connection = Me.Connection
			Me._adapter.DeleteCommand.CommandText = "exec sp_tbDoctor_Practice_D @Original_PracticeDoctorID"
			Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
			Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracticeDoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeDoctorID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracitceID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracitceID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_StartDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StartDate", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_EndDate", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "EndDate", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
			Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_EndDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "EndDate", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
			Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
			Me._adapter.InsertCommand.Connection = Me.Connection
			Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbDoctor_Practice_I  @PracitceID, @DoctorID, @StartDate, @EndDate; " &
			"SELECT PracticeDoctorID , PracitceID , DoctorID , StartDate , EndDate " &
			"FROM tbDoctor_Practice " &
			"WHERE PracticeDoctorID = @RETURN_VALUE"
			Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
			Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PracitceID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracitceID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@StartDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StartDate", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@EndDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "EndDate", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
			Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
			Me._adapter.UpdateCommand.Connection = Me.Connection
			Me._adapter.UpdateCommand.CommandText = "exec sp_tbDoctor_Practice_U @PracticeDoctorID, @PracitceID, @Original_PracitceID, @DoctorID, @Original_DoctorID, @StartDate, @Original_StartDate, @EndDate, @Original_EndDate; " &
			"SELECT PracticeDoctorID , PracitceID , DoctorID , StartDate , EndDate " &
			"FROM tbDoctor_Practice " &
			"WHERE PracticeDoctorID = @PracticeDoctorID"
			Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PracitceID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracitceID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@StartDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StartDate", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@EndDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "EndDate", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracticeDoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeDoctorID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracitceID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracitceID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_StartDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StartDate", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_EndDate", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "EndDate", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_EndDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "EndDate", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
			Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PracticeDoctorID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeDoctorID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Private Sub InitConnection()
			Me._connection = GS.cnn
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.SqlClient.SqlCommand(0) {}
			Me._commandCollection(0) = New Global.System.Data.SqlClient.SqlCommand()
			Me._commandCollection(0).CommandTimeout = GS.CommandTimeout
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "sp_tbDoctor_Practice_S"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
		Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)>
		Public Overridable Overloads Function Fill(ByVal dataTable As tbDoctor_Practice) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
		Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.[Select], True)>
		Public Overridable Overloads Function GetData() As tbDoctor_Practice
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As tbDoctor_Practice = New tbDoctor_Practice()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
		Public Overridable Overloads Function Update(ByVal dataTable As tbDoctor_Practice) As Integer
			Return Me.Adapter.Update(dataTable)
		End Function


		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
		Public Overridable Overloads Function Update(ByVal dataRow As Global.System.Data.DataRow) As Integer
			Return Me.Adapter.Update(New Global.System.Data.DataRow() {dataRow})
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
		Public Overridable Overloads Function Update(ByVal dataRows() As Global.System.Data.DataRow) As Integer
			Return Me.Adapter.Update(dataRows)
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
		Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Delete, True)>
		Public Overridable Overloads Function Delete(ByVal Original_PracticeDoctorID As Integer, ByVal Original_PracitceID As Integer, ByVal Original_DoctorID As Integer, ByVal Original_StartDate As Date, ByVal Original_EndDate As Global.System.Nullable(Of Date)) As Integer
			Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_PracticeDoctorID, Integer)
			Me.Adapter.DeleteCommand.Parameters(1).Value = CType(Original_PracitceID, Integer)
			Me.Adapter.DeleteCommand.Parameters(2).Value = CType(Original_DoctorID, Integer)
			Me.Adapter.DeleteCommand.Parameters(3).Value = CType(Original_StartDate, Date)
			If (Original_EndDate.HasValue = True) Then
				Me.Adapter.DeleteCommand.Parameters(4).Value = CType(0, Object)
				Me.Adapter.DeleteCommand.Parameters(5).Value = CType(Original_EndDate.Value, Date)
			Else
				Me.Adapter.DeleteCommand.Parameters(4).Value = CType(1, Object)
				Me.Adapter.DeleteCommand.Parameters(5).Value = Global.System.DBNull.Value
			End If
			Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
			If ((Me.Adapter.DeleteCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
			<> Global.System.Data.ConnectionState.Open) Then
				Me.Adapter.DeleteCommand.Connection.Open()
			End If
			Try
				Dim returnValue As Integer = Me.Adapter.DeleteCommand.ExecuteNonQuery
				Return returnValue
			Finally
				If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
					Me.Adapter.DeleteCommand.Connection.Close()
				End If
			End Try
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
		Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Insert, True)>
		Public Overridable Overloads Function Insert(ByVal PracitceID As Integer, ByVal DoctorID As Integer, ByVal StartDate As Date, ByVal EndDate As Global.System.Nullable(Of Date)) As Integer
			Me.Adapter.InsertCommand.Parameters(0).Value = CType(PracitceID, Integer)
			Me.Adapter.InsertCommand.Parameters(1).Value = CType(DoctorID, Integer)
			Me.Adapter.InsertCommand.Parameters(2).Value = CType(StartDate, Date)
			If (EndDate.HasValue = True) Then
				Me.Adapter.InsertCommand.Parameters(3).Value = CType(EndDate.Value, Date)
			Else
				Me.Adapter.InsertCommand.Parameters(3).Value = Global.System.DBNull.Value
			End If
			Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
			If ((Me.Adapter.InsertCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
			<> Global.System.Data.ConnectionState.Open) Then
				Me.Adapter.InsertCommand.Connection.Open()
			End If
			Try
				Dim returnValue As Integer = Me.Adapter.InsertCommand.ExecuteNonQuery
				Return returnValue
			Finally
				If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
					Me.Adapter.InsertCommand.Connection.Close()
				End If
			End Try
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
		Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, True)>
		Public Overridable Overloads Function Update(ByVal PracitceID As Integer, ByVal DoctorID As Integer, ByVal StartDate As Date, ByVal EndDate As Global.System.Nullable(Of Date), ByVal Original_PracticeDoctorID As Integer, ByVal Original_PracitceID As Integer, ByVal Original_DoctorID As Integer, ByVal Original_StartDate As Date, ByVal Original_EndDate As Global.System.Nullable(Of Date), ByVal PracticeDoctorID As Integer) As Integer
			Me.Adapter.UpdateCommand.Parameters(0).Value = CType(PracitceID, Integer)
			Me.Adapter.UpdateCommand.Parameters(1).Value = CType(DoctorID, Integer)
			Me.Adapter.UpdateCommand.Parameters(2).Value = CType(StartDate, Date)
			If (EndDate.HasValue = True) Then
				Me.Adapter.UpdateCommand.Parameters(3).Value = CType(EndDate.Value, Date)
			Else
				Me.Adapter.UpdateCommand.Parameters(3).Value = Global.System.DBNull.Value
			End If
			Me.Adapter.UpdateCommand.Parameters(4).Value = CType(Original_PracticeDoctorID, Integer)
			Me.Adapter.UpdateCommand.Parameters(5).Value = CType(Original_PracitceID, Integer)
			Me.Adapter.UpdateCommand.Parameters(6).Value = CType(Original_DoctorID, Integer)
			Me.Adapter.UpdateCommand.Parameters(7).Value = CType(Original_StartDate, Date)
			If (Original_EndDate.HasValue = True) Then
				Me.Adapter.UpdateCommand.Parameters(8).Value = CType(0, Object)
				Me.Adapter.UpdateCommand.Parameters(9).Value = CType(Original_EndDate.Value, Date)
			Else
				Me.Adapter.UpdateCommand.Parameters(8).Value = CType(1, Object)
				Me.Adapter.UpdateCommand.Parameters(9).Value = Global.System.DBNull.Value
			End If
			Me.Adapter.UpdateCommand.Parameters(10).Value = CType(PracticeDoctorID, Integer)
			Dim previousConnectionState As Global.System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
			If ((Me.Adapter.UpdateCommand.Connection.State And Global.System.Data.ConnectionState.Open) _
			<> Global.System.Data.ConnectionState.Open) Then
				Me.Adapter.UpdateCommand.Connection.Open()
			End If
			Try
				Dim returnValue As Integer = Me.Adapter.UpdateCommand.ExecuteNonQuery
				Return returnValue
			Finally
				If (previousConnectionState = Global.System.Data.ConnectionState.Closed) Then
					Me.Adapter.UpdateCommand.Connection.Close()
				End If
			End Try
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
		Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
		Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
		Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Update, True)>
		Public Overridable Overloads Function Update(ByVal PracitceID As Integer, ByVal DoctorID As Integer, ByVal StartDate As Date, ByVal EndDate As Global.System.Nullable(Of Date), ByVal Original_PracticeDoctorID As Integer, ByVal Original_PracitceID As Integer, ByVal Original_DoctorID As Integer, ByVal Original_StartDate As Date, ByVal Original_EndDate As Global.System.Nullable(Of Date)) As Integer
			Return Me.Update(PracitceID, DoctorID, StartDate, EndDate, Original_PracticeDoctorID, Original_PracitceID, Original_DoctorID, Original_StartDate, Original_EndDate, Original_PracticeDoctorID)
		End Function
	End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbDoctor_PracticeRow
	Inherits Global.System.Data.DataRow

	Private tabletbDoctor_Practice As tbDoctor_Practice

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
		MyBase.New(rb)
		Me.tabletbDoctor_Practice = CType(Me.Table, tbDoctor_Practice)
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Property PracticeDoctorID() As Integer
		Get
			Return CType(Me(Me.tabletbDoctor_Practice.PracticeDoctorIDColumn), Integer)
		End Get
		Set
			Me(Me.tabletbDoctor_Practice.PracticeDoctorIDColumn) = Value
		End Set
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Property PracitceID() As Integer
		Get
			Return CType(Me(Me.tabletbDoctor_Practice.PracitceIDColumn), Integer)
		End Get
		Set
			Me(Me.tabletbDoctor_Practice.PracitceIDColumn) = Value
		End Set
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Property DoctorID() As Integer
		Get
			Return CType(Me(Me.tabletbDoctor_Practice.DoctorIDColumn), Integer)
		End Get
		Set
			Me(Me.tabletbDoctor_Practice.DoctorIDColumn) = Value
		End Set
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Property StartDate() As Date
		Get
			Return CType(Me(Me.tabletbDoctor_Practice.StartDateColumn), Date)
		End Get
		Set
			Me(Me.tabletbDoctor_Practice.StartDateColumn) = Value
		End Set
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Property EndDate() As Date
		Get
			Try
				Return CType(Me(Me.tabletbDoctor_Practice.EndDateColumn), Date)
			Catch e As Global.System.InvalidCastException
				Throw New Global.System.Data.StrongTypingException("The value for column 'EndDate' in table 'tbDoctor_Practice' is DBNull.", e)
			End Try
		End Get
		Set
			Me(Me.tabletbDoctor_Practice.EndDateColumn) = Value
		End Set
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Function IsEndDateNull() As Boolean
		Return Me.IsNull(Me.tabletbDoctor_Practice.EndDateColumn)
	End Function

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Sub SetEndDateNull()
		Me(Me.tabletbDoctor_Practice.EndDateColumn) = Global.System.Convert.DBNull
	End Sub
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
Public Class tbDoctor_PracticeRowChangeEvent
	Inherits Global.System.EventArgs

	Private eventRow As tbDoctor_PracticeRow

	Private eventAction As Global.System.Data.DataRowAction

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public Sub New(ByVal row As tbDoctor_PracticeRow, ByVal action As Global.System.Data.DataRowAction)
		MyBase.New
		Me.eventRow = row
		Me.eventAction = action
	End Sub

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public ReadOnly Property Row() As tbDoctor_PracticeRow
		Get
			Return Me.eventRow
		End Get
	End Property

	<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
	Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
	Public ReadOnly Property Action() As Global.System.Data.DataRowAction
		Get
			Return Me.eventAction
		End Get
	End Property
End Class
