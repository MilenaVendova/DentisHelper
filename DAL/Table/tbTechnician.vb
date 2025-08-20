Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbTechnicianRowChangeEventHandler(ByVal sender As Object, ByVal e As tbTechnicianRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(),
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
Partial Public Class tbTechnician
    Inherits Global.System.Data.TypedTableBase(Of tbTechnicianRow)

    Private columnTechnicianID As Global.System.Data.DataColumn

    Private columnName As Global.System.Data.DataColumn

    Private columnNickName As Global.System.Data.DataColumn

    Private columnPhone As Global.System.Data.DataColumn

    Private columnEmail As Global.System.Data.DataColumn

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New()
        MyBase.New
        Me.TableName = "tbTechnician"
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
    Public ReadOnly Property TechnicianIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnTechnicianID
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
    Public ReadOnly Property NickNameColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnNickName
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
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
    Global.System.ComponentModel.Browsable(False)>
    Public ReadOnly Property Count() As Integer
        Get
            Return Me.Rows.Count
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Default Public ReadOnly Property Item(ByVal index As Integer) As tbTechnicianRow
        Get
            Return CType(Me.Rows(index), tbTechnicianRow)
        End Get
    End Property

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbTechnicianRowChanging As tbTechnicianRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbTechnicianRowChanged As tbTechnicianRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbTechnicianRowDeleting As tbTechnicianRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbTechnicianRowDeleted As tbTechnicianRowChangeEventHandler

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Sub AddtbTechnicianRow(ByVal row As tbTechnicianRow)
        Me.Rows.Add(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Function AddtbTechnicianRow(ByVal Name As String, ByVal NickName As String, ByVal Phone As String, ByVal Email As String) As tbTechnicianRow
        Dim rowtbTechnicianRow As tbTechnicianRow = CType(Me.NewRow, tbTechnicianRow)
        Dim columnValuesArray() As Object = New Object() {Nothing, Name, NickName, Phone, Email}
        rowtbTechnicianRow.ItemArray = columnValuesArray
        Me.Rows.Add(rowtbTechnicianRow)
        Return rowtbTechnicianRow
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function FindByTechnicianID(ByVal TechnicianID As Integer) As tbTechnicianRow
        Return CType(Me.Rows.Find(New Object() {TechnicianID}), tbTechnicianRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overrides Function Clone() As Global.System.Data.DataTable
        Dim cln As tbTechnician = CType(MyBase.Clone, tbTechnician)
        cln.InitVars()
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
        Return New tbTechnician()
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub InitVars()
        Me.columnTechnicianID = MyBase.Columns("TechnicianID")
        Me.columnName = MyBase.Columns("Name")
        Me.columnNickName = MyBase.Columns("NickName")
        Me.columnPhone = MyBase.Columns("Phone")
        Me.columnEmail = MyBase.Columns("Email")
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub InitClass()
        Me.columnTechnicianID = New Global.System.Data.DataColumn("TechnicianID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnTechnicianID)
        Me.columnName = New Global.System.Data.DataColumn("Name", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnName)
        Me.columnNickName = New Global.System.Data.DataColumn("NickName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnNickName)
        Me.columnPhone = New Global.System.Data.DataColumn("Phone", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPhone)
        Me.columnEmail = New Global.System.Data.DataColumn("Email", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnEmail)
        Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnTechnicianID}, True))
        Me.columnTechnicianID.AutoIncrement = True
        Me.columnTechnicianID.AutoIncrementSeed = -1
        Me.columnTechnicianID.AutoIncrementStep = -1
        Me.columnTechnicianID.AllowDBNull = False
        Me.columnTechnicianID.ReadOnly = True
        Me.columnTechnicianID.Unique = True
        Me.columnName.AllowDBNull = False
        Me.columnName.MaxLength = 1024
        Me.columnNickName.MaxLength = 200
        Me.columnPhone.AllowDBNull = False
        Me.columnPhone.MaxLength = 50
        Me.columnEmail.AllowDBNull = False
        Me.columnEmail.MaxLength = 1024

    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function NewtbTechnicianRow() As tbTechnicianRow
        Return CType(Me.NewRow, tbTechnicianRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
        Return New tbTechnicianRow(builder)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function GetRowType() As Global.System.Type
        Return GetType(tbTechnicianRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanged(e)
        If (Not (Me.tbTechnicianRowChangedEvent) Is Nothing) Then
            RaiseEvent tbTechnicianRowChanged(Me, New tbTechnicianRowChangeEvent(CType(e.Row, tbTechnicianRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanging(e)
        If (Not (Me.tbTechnicianRowChangingEvent) Is Nothing) Then
            RaiseEvent tbTechnicianRowChanging(Me, New tbTechnicianRowChangeEvent(CType(e.Row, tbTechnicianRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleted(e)
        If (Not (Me.tbTechnicianRowDeletedEvent) Is Nothing) Then
            RaiseEvent tbTechnicianRowDeleted(Me, New tbTechnicianRowChangeEvent(CType(e.Row, tbTechnicianRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleting(e)
        If (Not (Me.tbTechnicianRowDeletingEvent) Is Nothing) Then
            RaiseEvent tbTechnicianRowDeleting(Me, New tbTechnicianRowChangeEvent(CType(e.Row, tbTechnicianRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub RemovetbTechnicianRow(ByVal row As tbTechnicianRow)
        Me.Rows.Remove(row)
    End Sub
    Private _ta As tbTechnicianTableAdapter
    Private _dbrm As dbrm

    Public ReadOnly Property TableAdapter() As tbTechnicianTableAdapter
        Get
            If _ta Is Nothing Then
                _ta = New tbTechnicianTableAdapter
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
                    _ta = New tbTechnicianTableAdapter
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
                _ta = New tbTechnicianTableAdapter
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
    Partial Public Class tbTechnicianTableAdapter
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
            tableMapping.DataSetTable = "tbTechnician"
            tableMapping.ColumnMappings.Add("TechnicianID", "TechnicianID")
            tableMapping.ColumnMappings.Add("Name", "Name")
            tableMapping.ColumnMappings.Add("NickName", "NickName")
            tableMapping.ColumnMappings.Add("Phone", "Phone")
            tableMapping.ColumnMappings.Add("Email", "Email")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "exec sp_tbTechnician_D @Original_TechnicianID"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_NickName", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NickName", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_NickName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NickName", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbTechnician_I  @Name, @NickName, @Phone, @Email; " &
            "SELECT TechnicianID , Name , NickName , Phone , Email " &
            "FROM tbTechnician " &
            "WHERE TechnicianID = @RETURN_VALUE"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@NickName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NickName", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "exec sp_tbTechnician_U @TechnicianID, @Name, @Original_Name, @NickName, @Original_NickName, @Phone, @Original_Phone, @Email, @Original_Email; " &
            "SELECT TechnicianID , Name , NickName , Phone , Email " &
            "FROM tbTechnician " &
            "WHERE TechnicianID = @TechnicianID"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@NickName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NickName", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Name", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Name", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_NickName", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NickName", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_NickName", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "NickName", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Phone", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Phone", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Email", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Email", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@TechnicianID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
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
            Me._commandCollection(0).CommandText = "sp_tbTechnician_S"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
        Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Overloads Function Fill(ByVal dataTable As tbTechnician) As Integer
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
        Public Overridable Overloads Function GetData() As tbTechnician
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As tbTechnician = New tbTechnician()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Overloads Function Update(ByVal dataTable As tbTechnician) As Integer
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
        Public Overridable Overloads Function Delete(ByVal Original_TechnicianID As Integer, ByVal Original_Name As String, ByVal Original_NickName As String, ByVal Original_Phone As String, ByVal Original_Email As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_TechnicianID, Integer)
            If (Original_Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Name")
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(Original_Name, String)
            End If
            If (Original_NickName Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(2).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(3).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(2).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(3).Value = CType(Original_NickName, String)
            End If
            If (Original_Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Phone")
            Else
                Me.Adapter.DeleteCommand.Parameters(4).Value = CType(Original_Phone, String)
            End If
            If (Original_Email Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Email")
            Else
                Me.Adapter.DeleteCommand.Parameters(5).Value = CType(Original_Email, String)
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
        Public Overridable Overloads Function Insert(ByVal Name As String, ByVal NickName As String, ByVal Phone As String, ByVal Email As String) As Integer
            If (Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Name")
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(Name, String)
            End If
            If (NickName Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(NickName, String)
            End If
            If (Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Phone")
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(Phone, String)
            End If
            If (Email Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Email")
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(Email, String)
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
        Public Overridable Overloads Function Update(ByVal Name As String, ByVal NickName As String, ByVal Phone As String, ByVal Email As String, ByVal Original_TechnicianID As Integer, ByVal Original_Name As String, ByVal Original_NickName As String, ByVal Original_Phone As String, ByVal Original_Email As String, ByVal TechnicianID As Integer) As Integer
            If (Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Name")
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(Name, String)
            End If
            If (NickName Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(1).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(1).Value = CType(NickName, String)
            End If
            If (Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Phone")
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = CType(Phone, String)
            End If
            If (Email Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Email")
            Else
                Me.Adapter.UpdateCommand.Parameters(3).Value = CType(Email, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(4).Value = CType(Original_TechnicianID, Integer)
            If (Original_Name Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Name")
            Else
                Me.Adapter.UpdateCommand.Parameters(5).Value = CType(Original_Name, String)
            End If
            If (Original_NickName Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(6).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(7).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(6).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(7).Value = CType(Original_NickName, String)
            End If
            If (Original_Phone Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Phone")
            Else
                Me.Adapter.UpdateCommand.Parameters(8).Value = CType(Original_Phone, String)
            End If
            If (Original_Email Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Email")
            Else
                Me.Adapter.UpdateCommand.Parameters(9).Value = CType(Original_Email, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(10).Value = CType(TechnicianID, Integer)
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
        Public Overridable Overloads Function Update(ByVal Name As String, ByVal NickName As String, ByVal Phone As String, ByVal Email As String, ByVal Original_TechnicianID As Integer, ByVal Original_Name As String, ByVal Original_NickName As String, ByVal Original_Phone As String, ByVal Original_Email As String) As Integer
            Return Me.Update(Name, NickName, Phone, Email, Original_TechnicianID, Original_Name, Original_NickName, Original_Phone, Original_Email, Original_TechnicianID)
        End Function
    End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbTechnicianRow
    Inherits Global.System.Data.DataRow

    Private tabletbTechnician As tbTechnician

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
        MyBase.New(rb)
        Me.tabletbTechnician = CType(Me.Table, tbTechnician)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property TechnicianID() As Integer
        Get
            Return CType(Me(Me.tabletbTechnician.TechnicianIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbTechnician.TechnicianIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Name() As String
        Get
            Return CType(Me(Me.tabletbTechnician.NameColumn), String)
        End Get
        Set
            Me(Me.tabletbTechnician.NameColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property NickName() As String
        Get
            Try
                Return CType(Me(Me.tabletbTechnician.NickNameColumn), String)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'NickName' in table 'tbTechnician' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbTechnician.NickNameColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Phone() As String
        Get
            Return CType(Me(Me.tabletbTechnician.PhoneColumn), String)
        End Get
        Set
            Me(Me.tabletbTechnician.PhoneColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Email() As String
        Get
            Return CType(Me(Me.tabletbTechnician.EmailColumn), String)
        End Get
        Set
            Me(Me.tabletbTechnician.EmailColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsNickNameNull() As Boolean
        Return Me.IsNull(Me.tabletbTechnician.NickNameColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetNickNameNull()
        Me(Me.tabletbTechnician.NickNameColumn) = Global.System.Convert.DBNull
    End Sub
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
Public Class tbTechnicianRowChangeEvent
    Inherits Global.System.EventArgs

    Private eventRow As tbTechnicianRow

    Private eventAction As Global.System.Data.DataRowAction

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New(ByVal row As tbTechnicianRow, ByVal action As Global.System.Data.DataRowAction)
        MyBase.New
        Me.eventRow = row
        Me.eventAction = action
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property Row() As tbTechnicianRow
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
