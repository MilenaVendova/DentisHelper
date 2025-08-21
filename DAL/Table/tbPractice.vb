Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbPracticeRowChangeEventHandler(ByVal sender As Object, ByVal e As tbPracticeRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(),
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
Partial Public Class tbPractice
    Inherits Global.System.Data.TypedTableBase(Of tbPracticeRow)

    Private columnPracticeID As Global.System.Data.DataColumn

    Private columnName As Global.System.Data.DataColumn

    Private columnCompanyName As Global.System.Data.DataColumn

    Private columnAdress As Global.System.Data.DataColumn

    Private columnPhone As Global.System.Data.DataColumn

    Private columnEmail As Global.System.Data.DataColumn

    Private columnTaxID As Global.System.Data.DataColumn

    Private columnOpeningHours As Global.System.Data.DataColumn

    Private columnDelivaryMethod As Global.System.Data.DataColumn

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New()
        MyBase.New
        Me.TableName = "tbPractice"
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
    Public ReadOnly Property PracticeIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPracticeID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property NameColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnName
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property CompanyNameColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnCompanyName
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property AdressColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnAdress
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property PhoneColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPhone
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property EmailColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnEmail
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property TaxIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnTaxID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property OpeningHoursColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnOpeningHours
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property DelivaryMethodColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnDelivaryMethod
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
    Default Public ReadOnly Property Item(ByVal index As Integer) As tbPracticeRow
        Get
            Return CType(Me.Rows(index), tbPracticeRow)
        End Get
    End Property

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPracticeRowChanging As tbPracticeRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPracticeRowChanged As tbPracticeRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPracticeRowDeleting As tbPracticeRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPracticeRowDeleted As tbPracticeRowChangeEventHandler

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Sub AddtbPracticeRow(ByVal row As tbPracticeRow)
        Me.Rows.Add(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Function AddtbPracticeRow(ByVal Name As String, ByVal CompanyName As String, ByVal Adress As String, ByVal Phone As String, ByVal Email As String, ByVal TaxID As String, ByVal OpeningHours As String, ByVal DelivaryMethod As String) As tbPracticeRow
        Dim rowtbPracticeRow As tbPracticeRow = CType(Me.NewRow, tbPracticeRow)
        Dim columnValuesArray() As Object = New Object() {Nothing, Name, CompanyName, Adress, Phone, Email, TaxID, OpeningHours, DelivaryMethod}
        rowtbPracticeRow.ItemArray = columnValuesArray
        Me.Rows.Add(rowtbPracticeRow)
        Return rowtbPracticeRow
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function FindByPracticeID(ByVal PracticeID As Integer) As tbPracticeRow
        Return CType(Me.Rows.Find(New Object() {PracticeID}), tbPracticeRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overrides Function Clone() As Global.System.Data.DataTable
        Dim cln As tbPractice = CType(MyBase.Clone, tbPractice)
        cln.InitVars()
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
        Return New tbPractice()
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub InitVars()
        Me.columnPracticeID = MyBase.Columns("PracticeID")
        Me.columnName = MyBase.Columns("Name")
        Me.columnCompanyName = MyBase.Columns("CompanyName")
        Me.columnAdress = MyBase.Columns("Adress")
        Me.columnPhone = MyBase.Columns("Phone")
        Me.columnEmail = MyBase.Columns("Email")
        Me.columnTaxID = MyBase.Columns("TaxID")
        Me.columnOpeningHours = MyBase.Columns("OpeningHours")
        Me.columnDelivaryMethod = MyBase.Columns("DelivaryMethod")
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub InitClass()
        Me.columnPracticeID = New Global.System.Data.DataColumn("PracticeID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPracticeID)
        Me.columnName = New Global.System.Data.DataColumn("Name", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnName)
        Me.columnCompanyName = New Global.System.Data.DataColumn("CompanyName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnCompanyName)
        Me.columnAdress = New Global.System.Data.DataColumn("Adress", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnAdress)
        Me.columnPhone = New Global.System.Data.DataColumn("Phone", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPhone)
        Me.columnEmail = New Global.System.Data.DataColumn("Email", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnEmail)
        Me.columnTaxID = New Global.System.Data.DataColumn("TaxID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnTaxID)
        Me.columnOpeningHours = New Global.System.Data.DataColumn("OpeningHours", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnOpeningHours)
        Me.columnDelivaryMethod = New Global.System.Data.DataColumn("DelivaryMethod", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnDelivaryMethod)
        Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnPracticeID}, True))
        Me.columnPracticeID.AutoIncrement = True
        Me.columnPracticeID.AutoIncrementSeed = -1
        Me.columnPracticeID.AutoIncrementStep = -1
        Me.columnPracticeID.AllowDBNull = False
        Me.columnPracticeID.ReadOnly = True
        Me.columnPracticeID.Unique = True
        Me.columnName.AllowDBNull = False
        Me.columnName.MaxLength = 1024
        Me.columnCompanyName.AllowDBNull = False
        Me.columnCompanyName.MaxLength = 1024
        Me.columnAdress.AllowDBNull = False
        Me.columnAdress.MaxLength = 200
        Me.columnPhone.AllowDBNull = False
        Me.columnPhone.MaxLength = 100
        Me.columnEmail.MaxLength = 1024
        Me.columnTaxID.MaxLength = 1024
        Me.columnOpeningHours.MaxLength = 100
        Me.columnDelivaryMethod.MaxLength = 200
        Me.Constraints.Add(New System.Data.UniqueConstraint("ID_tbPractice_CompanyName", New System.Data.DataColumn() {Me.columnCompanyName}, False))
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function NewtbPracticeRow() As tbPracticeRow
        Return CType(Me.NewRow, tbPracticeRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
        Return New tbPracticeRow(builder)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function GetRowType() As Global.System.Type
        Return GetType(tbPracticeRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanged(e)
        If (Not (Me.tbPracticeRowChangedEvent) Is Nothing) Then
            RaiseEvent tbPracticeRowChanged(Me, New tbPracticeRowChangeEvent(CType(e.Row, tbPracticeRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanging(e)
        If (Not (Me.tbPracticeRowChangingEvent) Is Nothing) Then
            RaiseEvent tbPracticeRowChanging(Me, New tbPracticeRowChangeEvent(CType(e.Row, tbPracticeRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleted(e)
        If (Not (Me.tbPracticeRowDeletedEvent) Is Nothing) Then
            RaiseEvent tbPracticeRowDeleted(Me, New tbPracticeRowChangeEvent(CType(e.Row, tbPracticeRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleting(e)
        If (Not (Me.tbPracticeRowDeletingEvent) Is Nothing) Then
            RaiseEvent tbPracticeRowDeleting(Me, New tbPracticeRowChangeEvent(CType(e.Row, tbPracticeRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub RemovetbPracticeRow(ByVal row As tbPracticeRow)
        Me.Rows.Remove(row)
    End Sub
    Private _ta As tbPracticeTableAdapter
    Private _dbrm As dbrm

    Public ReadOnly Property TableAdapter() As tbPracticeTableAdapter
        Get
            If _ta Is Nothing Then
                _ta = New tbPracticeTableAdapter
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
                    _ta = New tbPracticeTableAdapter
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
                _ta = New tbPracticeTableAdapter
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
    Partial Public Class tbPracticeTableAdapter
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
            tableMapping.DataSetTable = "tbPractice"
            tableMapping.ColumnMappings.Add("PracticeID", "PracticeID")
            tableMapping.ColumnMappings.Add("Name", "Name")
            tableMapping.ColumnMappings.Add("CompanyName", "CompanyName")
            tableMapping.ColumnMappings.Add("Adress", "Adress")
            tableMapping.ColumnMappings.Add("Phone", "Phone")
            tableMapping.ColumnMappings.Add("Email", "Email")
            tableMapping.ColumnMappings.Add("TaxID", "TaxID")
            tableMapping.ColumnMappings.Add("OpeningHours", "OpeningHours")
            tableMapping.ColumnMappings.Add("DelivaryMethod", "DelivaryMethod")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "exec sp_tbPractice_D @Original_PracticeID"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracticeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CompanyName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CompanyName", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Adress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Adress", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Email", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_TaxID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TaxID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_TaxID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TaxID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_OpeningHours", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "OpeningHours", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_OpeningHours", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "OpeningHours", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_DelivaryMethod", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DelivaryMethod", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DelivaryMethod", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DelivaryMethod", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbPractice_I  @Name, @CompanyName, @Adress, @Phone, @Email, @TaxID, @OpeningHours, @DelivaryMethod; " &
            "SELECT PracticeID , Name , CompanyName , Adress , Phone , Email , TaxID , OpeningHours , DelivaryMethod " &
            "FROM tbPractice " &
            "WHERE PracticeID = @RETURN_VALUE"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CompanyName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CompanyName", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Adress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Adress", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@TaxID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TaxID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@OpeningHours", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "OpeningHours", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DelivaryMethod", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DelivaryMethod", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "exec sp_tbPractice_U @PracticeID, @Name, @Original_Name, @CompanyName, @Original_CompanyName, @Adress, @Original_Adress, @Phone, @Original_Phone, @Email, @Original_Email, @TaxID, @Original_TaxID, @OpeningHours, @Original_OpeningHours, @DelivaryMethod, @Original_DelivaryMethod; " &
            "SELECT PracticeID , Name , CompanyName , Adress , Phone , Email , TaxID , OpeningHours , DelivaryMethod " &
            "FROM tbPractice " &
            "WHERE PracticeID = @PracticeID"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CompanyName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CompanyName", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Adress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Adress", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@TaxID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TaxID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@OpeningHours", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "OpeningHours", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DelivaryMethod", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DelivaryMethod", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracticeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CompanyName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CompanyName", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Adress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Adress", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Email", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_TaxID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TaxID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_TaxID", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TaxID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_OpeningHours", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "OpeningHours", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_OpeningHours", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "OpeningHours", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_DelivaryMethod", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DelivaryMethod", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DelivaryMethod", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DelivaryMethod", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PracticeID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
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
            Me._commandCollection(0).CommandText = "sp_tbPractice_S"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
        Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Overloads Function Fill(ByVal dataTable As tbPractice) As Integer
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
        Public Overridable Overloads Function GetData() As tbPractice
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As tbPractice = New tbPractice()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Overloads Function Update(ByVal dataTable As tbPractice) As Integer
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
        Public Overridable Overloads Function Delete(ByVal Original_PracticeID As Integer, ByVal Original_Name As String, ByVal Original_CompanyName As String, ByVal Original_Adress As String, ByVal Original_Phone As String, ByVal Original_Email As String, ByVal Original_TaxID As String, ByVal Original_OpeningHours As String, ByVal Original_DelivaryMethod As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_PracticeID, Integer)
            If (Original_Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Name")
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(Original_Name, String)
            End If
            If (Original_CompanyName Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_CompanyName")
            Else
                Me.Adapter.DeleteCommand.Parameters(2).Value = CType(Original_CompanyName, String)
            End If
            If (Original_Adress Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Adress")
            Else
                Me.Adapter.DeleteCommand.Parameters(3).Value = CType(Original_Adress, String)
            End If
            If (Original_Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Phone")
            Else
                Me.Adapter.DeleteCommand.Parameters(4).Value = CType(Original_Phone, String)
            End If
            If (Original_Email Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(5).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(6).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(5).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(6).Value = CType(Original_Email, String)
            End If
            If (Original_TaxID Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(7).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(8).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(7).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(8).Value = CType(Original_TaxID, String)
            End If
            If (Original_OpeningHours Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(9).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(10).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(9).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(10).Value = CType(Original_OpeningHours, String)
            End If
            If (Original_DelivaryMethod Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(11).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(12).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(11).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(12).Value = CType(Original_DelivaryMethod, String)
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
        Public Overridable Overloads Function Insert(ByVal Name As String, ByVal CompanyName As String, ByVal Adress As String, ByVal Phone As String, ByVal Email As String, ByVal TaxID As String, ByVal OpeningHours As String, ByVal DelivaryMethod As String) As Integer
            If (Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Name")
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(Name, String)
            End If
            If (CompanyName Is Nothing) Then
                Throw New Global.System.ArgumentNullException("CompanyName")
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(CompanyName, String)
            End If
            If (Adress Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Adress")
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(Adress, String)
            End If
            If (Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Phone")
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(Phone, String)
            End If
            If (Email Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(4).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(4).Value = CType(Email, String)
            End If
            If (TaxID Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(5).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(5).Value = CType(TaxID, String)
            End If
            If (OpeningHours Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(6).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(6).Value = CType(OpeningHours, String)
            End If
            If (DelivaryMethod Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(7).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(7).Value = CType(DelivaryMethod, String)
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
        Public Overridable Overloads Function Update(
        ByVal Name As String,
        ByVal CompanyName As String,
        ByVal Adress As String,
        ByVal Phone As String,
        ByVal Email As String,
        ByVal TaxID As String,
        ByVal OpeningHours As String,
        ByVal DelivaryMethod As String,
        ByVal Original_PracticeID As Integer,
        ByVal Original_Name As String,
        ByVal Original_CompanyName As String,
        ByVal Original_Adress As String,
        ByVal Original_Phone As String,
        ByVal Original_Email As String,
        ByVal Original_TaxID As String,
        ByVal Original_OpeningHours As String,
        ByVal Original_DelivaryMethod As String,
        ByVal PracticeID As Integer) As Integer
            If (Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Name")
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(Name, String)
            End If
            If (CompanyName Is Nothing) Then
                Throw New Global.System.ArgumentNullException("CompanyName")
            Else
                Me.Adapter.UpdateCommand.Parameters(1).Value = CType(CompanyName, String)
            End If
            If (Adress Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Adress")
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = CType(Adress, String)
            End If
            If (Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Phone")
            Else
                Me.Adapter.UpdateCommand.Parameters(3).Value = CType(Phone, String)
            End If
            If (Email Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(4).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(4).Value = CType(Email, String)
            End If
            If (TaxID Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(5).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(5).Value = CType(TaxID, String)
            End If
            If (OpeningHours Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(6).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(6).Value = CType(OpeningHours, String)
            End If
            If (DelivaryMethod Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(7).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(7).Value = CType(DelivaryMethod, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(8).Value = CType(Original_PracticeID, Integer)
            If (Original_Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Name")
            Else
                Me.Adapter.UpdateCommand.Parameters(9).Value = CType(Original_Name, String)
            End If
            If (Original_CompanyName Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_CompanyName")
            Else
                Me.Adapter.UpdateCommand.Parameters(10).Value = CType(Original_CompanyName, String)
            End If
            If (Original_Adress Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Adress")
            Else
                Me.Adapter.UpdateCommand.Parameters(11).Value = CType(Original_Adress, String)
            End If
            If (Original_Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Phone")
            Else
                Me.Adapter.UpdateCommand.Parameters(12).Value = CType(Original_Phone, String)
            End If
            If (Original_Email Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(13).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(14).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(13).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(14).Value = CType(Original_Email, String)
            End If
            If (Original_TaxID Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(15).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(16).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(15).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(16).Value = CType(Original_TaxID, String)
            End If
            If (Original_OpeningHours Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(17).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(18).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(17).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(18).Value = CType(Original_OpeningHours, String)
            End If
            If (Original_DelivaryMethod Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(19).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(20).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(19).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(20).Value = CType(Original_DelivaryMethod, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(21).Value = CType(PracticeID, Integer)
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
        Public Overridable Overloads Function Update(
        ByVal Name As String,
        ByVal CompanyName As String,
        ByVal Adress As String,
        ByVal Phone As String,
        ByVal Email As String,
        ByVal TaxID As String,
        ByVal OpeningHours As String,
        ByVal DelivaryMethod As String,
        ByVal Original_PracticeID As Integer,
        ByVal Original_Name As String,
        ByVal Original_CompanyName As String,
        ByVal Original_Adress As String,
        ByVal Original_Phone As String,
        ByVal Original_Email As String,
        ByVal Original_TaxID As String,
        ByVal Original_OpeningHours As String,
        ByVal Original_DelivaryMethod As String) As Integer
            Return Me.Update(Name, CompanyName, Adress, Phone, Email, TaxID, OpeningHours, DelivaryMethod, Original_PracticeID, Original_Name, Original_CompanyName, Original_Adress, Original_Phone, Original_Email, Original_TaxID, Original_OpeningHours, Original_DelivaryMethod, Original_PracticeID)
        End Function
    End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbPracticeRow
    Inherits Global.System.Data.DataRow

    Private tabletbPractice As tbPractice

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
        MyBase.New(rb)
        Me.tabletbPractice = CType(Me.Table, tbPractice)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property PracticeID() As Integer
        Get
            Return CType(Me(Me.tabletbPractice.PracticeIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbPractice.PracticeIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Name() As String
        Get
            Return CType(Me(Me.tabletbPractice.NameColumn), String)
        End Get
        Set
            Me(Me.tabletbPractice.NameColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property CompanyName() As String
        Get
            Return CType(Me(Me.tabletbPractice.CompanyNameColumn), String)
        End Get
        Set
            Me(Me.tabletbPractice.CompanyNameColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Adress() As String
        Get
            Return CType(Me(Me.tabletbPractice.AdressColumn), String)
        End Get
        Set
            Me(Me.tabletbPractice.AdressColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Phone() As String
        Get
            Return CType(Me(Me.tabletbPractice.PhoneColumn), String)
        End Get
        Set
            Me(Me.tabletbPractice.PhoneColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Email() As String
        Get
            Try
                Return CType(Me(Me.tabletbPractice.EmailColumn), String)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'Email' in table 'tbPractice' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbPractice.EmailColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property TaxID() As String
        Get
            Try
                Return CType(Me(Me.tabletbPractice.TaxIDColumn), String)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'TaxID' in table 'tbPractice' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbPractice.TaxIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property OpeningHours() As String
        Get
            Try
                Return CType(Me(Me.tabletbPractice.OpeningHoursColumn), String)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'OpeningHours' in table 'tbPractice' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbPractice.OpeningHoursColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property DelivaryMethod() As String
        Get
            Try
                Return CType(Me(Me.tabletbPractice.DelivaryMethodColumn), String)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'DelivaryMethod' in table 'tbPractice' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbPractice.DelivaryMethodColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsEmailNull() As Boolean
        Return Me.IsNull(Me.tabletbPractice.EmailColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetEmailNull()
        Me(Me.tabletbPractice.EmailColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsTaxIDNull() As Boolean
        Return Me.IsNull(Me.tabletbPractice.TaxIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetTaxIDNull()
        Me(Me.tabletbPractice.TaxIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsOpeningHoursNull() As Boolean
        Return Me.IsNull(Me.tabletbPractice.OpeningHoursColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetOpeningHoursNull()
        Me(Me.tabletbPractice.OpeningHoursColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsDelivaryMethodNull() As Boolean
        Return Me.IsNull(Me.tabletbPractice.DelivaryMethodColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetDelivaryMethodNull()
        Me(Me.tabletbPractice.DelivaryMethodColumn) = Global.System.Convert.DBNull
    End Sub
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
Public Class tbPracticeRowChangeEvent
    Inherits Global.System.EventArgs

    Private eventRow As tbPracticeRow

    Private eventAction As Global.System.Data.DataRowAction

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New(ByVal row As tbPracticeRow, ByVal action As Global.System.Data.DataRowAction)
        MyBase.New
        Me.eventRow = row
        Me.eventAction = action
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property Row() As tbPracticeRow
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