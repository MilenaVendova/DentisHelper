Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbMaterialRowChangeEventHandler(ByVal sender As Object, ByVal e As tbMaterialRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(),
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
Partial Public Class tbMaterial
    Inherits Global.System.Data.TypedTableBase(Of tbMaterialRow)

    Private columnMaterialID As Global.System.Data.DataColumn

    Private columnMaterialtype As Global.System.Data.DataColumn

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New()
        MyBase.New
        Me.TableName = "tbMaterial"
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
    Public ReadOnly Property MaterialIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnMaterialID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property MaterialtypeColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnMaterialtype
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
    Default Public ReadOnly Property Item(ByVal index As Integer) As tbMaterialRow
        Get
            Return CType(Me.Rows(index), tbMaterialRow)
        End Get
    End Property

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMaterialRowChanging As tbMaterialRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMaterialRowChanged As tbMaterialRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMaterialRowDeleting As tbMaterialRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMaterialRowDeleted As tbMaterialRowChangeEventHandler

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Sub AddtbMaterialRow(ByVal row As tbMaterialRow)
        Me.Rows.Add(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Function AddtbMaterialRow(ByVal Materialtype As String) As tbMaterialRow
        Dim rowtbMaterialRow As tbMaterialRow = CType(Me.NewRow, tbMaterialRow)
        Dim columnValuesArray() As Object = New Object() {Nothing, Materialtype}
        rowtbMaterialRow.ItemArray = columnValuesArray
        Me.Rows.Add(rowtbMaterialRow)
        Return rowtbMaterialRow
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function FindByMaterialID(ByVal MaterialID As Integer) As tbMaterialRow
        Return CType(Me.Rows.Find(New Object() {MaterialID}), tbMaterialRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overrides Function Clone() As Global.System.Data.DataTable
        Dim cln As tbMaterial = CType(MyBase.Clone, tbMaterial)
        cln.InitVars()
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
        Return New tbMaterial()
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub InitVars()
        Me.columnMaterialID = MyBase.Columns("MaterialID")
        Me.columnMaterialtype = MyBase.Columns("Materialtype")
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub InitClass()
        Me.columnMaterialID = New Global.System.Data.DataColumn("MaterialID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnMaterialID)
        Me.columnMaterialtype = New Global.System.Data.DataColumn("Materialtype", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnMaterialtype)
        Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnMaterialID}, True))
        Me.columnMaterialID.AutoIncrement = True
        Me.columnMaterialID.AutoIncrementSeed = -1
        Me.columnMaterialID.AutoIncrementStep = -1
        Me.columnMaterialID.AllowDBNull = False
        Me.columnMaterialID.ReadOnly = True
        Me.columnMaterialID.Unique = True
        Me.columnMaterialtype.AllowDBNull = False
        Me.columnMaterialtype.MaxLength = 200

    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function NewtbMaterialRow() As tbMaterialRow
        Return CType(Me.NewRow, tbMaterialRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
        Return New tbMaterialRow(builder)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function GetRowType() As Global.System.Type
        Return GetType(tbMaterialRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanged(e)
        If (Not (Me.tbMaterialRowChangedEvent) Is Nothing) Then
            RaiseEvent tbMaterialRowChanged(Me, New tbMaterialRowChangeEvent(CType(e.Row, tbMaterialRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanging(e)
        If (Not (Me.tbMaterialRowChangingEvent) Is Nothing) Then
            RaiseEvent tbMaterialRowChanging(Me, New tbMaterialRowChangeEvent(CType(e.Row, tbMaterialRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleted(e)
        If (Not (Me.tbMaterialRowDeletedEvent) Is Nothing) Then
            RaiseEvent tbMaterialRowDeleted(Me, New tbMaterialRowChangeEvent(CType(e.Row, tbMaterialRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleting(e)
        If (Not (Me.tbMaterialRowDeletingEvent) Is Nothing) Then
            RaiseEvent tbMaterialRowDeleting(Me, New tbMaterialRowChangeEvent(CType(e.Row, tbMaterialRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub RemovetbMaterialRow(ByVal row As tbMaterialRow)
        Me.Rows.Remove(row)
    End Sub
    Private _ta As tbMaterialTableAdapter
    Private _dbrm As dbrm

    Public ReadOnly Property TableAdapter() As tbMaterialTableAdapter
        Get
            If _ta Is Nothing Then
                _ta = New tbMaterialTableAdapter
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
                    _ta = New tbMaterialTableAdapter
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
                _ta = New tbMaterialTableAdapter
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
    Partial Public Class tbMaterialTableAdapter
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
            tableMapping.DataSetTable = "tbMaterial"
            tableMapping.ColumnMappings.Add("MaterialID", "MaterialID")
            tableMapping.ColumnMappings.Add("Materialtype", "Materialtype")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "exec sp_tbMaterial_D @Original_MaterialID"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Materialtype", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Materialtype", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbMaterial_I  @Materialtype; " &
            "SELECT MaterialID , Materialtype " &
            "FROM tbMaterial " &
            "WHERE MaterialID = @RETURN_VALUE"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Materialtype", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Materialtype", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "exec sp_tbMaterial_U @MaterialID, @Materialtype, @Original_Materialtype; " &
            "SELECT MaterialID , Materialtype " &
            "FROM tbMaterial " &
            "WHERE MaterialID = @MaterialID"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Materialtype", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Materialtype", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Materialtype", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Materialtype", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@MaterialID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
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
            Me._commandCollection(0).CommandText = "sp_tbMaterial_S"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
        Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Overloads Function Fill(ByVal dataTable As tbMaterial) As Integer
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
        Public Overridable Overloads Function GetData() As tbMaterial
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As tbMaterial = New tbMaterial()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Overloads Function Update(ByVal dataTable As tbMaterial) As Integer
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
        Public Overridable Overloads Function Delete(ByVal Original_MaterialID As Integer, ByVal Original_Materialtype As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_MaterialID, Integer)
            If (Original_Materialtype Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Materialtype")
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(Original_Materialtype, String)
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
        Public Overridable Overloads Function Insert(ByVal Materialtype As String) As Integer
            If (Materialtype Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Materialtype")
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(Materialtype, String)
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
        Public Overridable Overloads Function Update(ByVal Materialtype As String, ByVal Original_MaterialID As Integer, ByVal Original_Materialtype As String, ByVal MaterialID As Integer) As Integer
            If (Materialtype Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Materialtype")
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(Materialtype, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(1).Value = CType(Original_MaterialID, Integer)
            If (Original_Materialtype Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_Materialtype")
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = CType(Original_Materialtype, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(3).Value = CType(MaterialID, Integer)
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
        Public Overridable Overloads Function Update(ByVal Materialtype As String, ByVal Original_MaterialID As Integer, ByVal Original_Materialtype As String) As Integer
            Return Me.Update(Materialtype, Original_MaterialID, Original_Materialtype, Original_MaterialID)
        End Function
    End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbMaterialRow
    Inherits Global.System.Data.DataRow

    Private tabletbMaterial As tbMaterial

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
        MyBase.New(rb)
        Me.tabletbMaterial = CType(Me.Table, tbMaterial)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property MaterialID() As Integer
        Get
            Return CType(Me(Me.tabletbMaterial.MaterialIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbMaterial.MaterialIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Materialtype() As String
        Get
            Return CType(Me(Me.tabletbMaterial.MaterialtypeColumn), String)
        End Get
        Set
            Me(Me.tabletbMaterial.MaterialtypeColumn) = Value
        End Set
    End Property
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
Public Class tbMaterialRowChangeEvent
    Inherits Global.System.EventArgs

    Private eventRow As tbMaterialRow

    Private eventAction As Global.System.Data.DataRowAction

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New(ByVal row As tbMaterialRow, ByVal action As Global.System.Data.DataRowAction)
        MyBase.New
        Me.eventRow = row
        Me.eventAction = action
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property Row() As tbMaterialRow
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
