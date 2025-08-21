Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbPaymentStatusRowChangeEventHandler(ByVal sender As Object, ByVal e As tbPaymentStatusRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(),
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
Partial Public Class tbPaymentStatus
    Inherits Global.System.Data.TypedTableBase(Of tbPaymentStatusRow)

    Private columnPaymentStatusID As Global.System.Data.DataColumn

    Private columnPaymentStatus As Global.System.Data.DataColumn

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New()
        MyBase.New
        Me.TableName = "tbPaymentStatus"
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
    Public ReadOnly Property PaymentStatusIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPaymentStatusID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property PaymentStatusColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPaymentStatus
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
    Default Public ReadOnly Property Item(ByVal index As Integer) As tbPaymentStatusRow
        Get
            Return CType(Me.Rows(index), tbPaymentStatusRow)
        End Get
    End Property

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPaymentStatusRowChanging As tbPaymentStatusRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPaymentStatusRowChanged As tbPaymentStatusRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPaymentStatusRowDeleting As tbPaymentStatusRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbPaymentStatusRowDeleted As tbPaymentStatusRowChangeEventHandler

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Sub AddtbPaymentStatusRow(ByVal row As tbPaymentStatusRow)
        Me.Rows.Add(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Function AddtbPaymentStatusRow(ByVal PaymentStatus As String) As tbPaymentStatusRow
        Dim rowtbPaymentStatusRow As tbPaymentStatusRow = CType(Me.NewRow, tbPaymentStatusRow)
        Dim columnValuesArray() As Object = New Object() {Nothing, PaymentStatus}
        rowtbPaymentStatusRow.ItemArray = columnValuesArray
        Me.Rows.Add(rowtbPaymentStatusRow)
        Return rowtbPaymentStatusRow
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function FindByPaymentStatusID(ByVal PaymentStatusID As Integer) As tbPaymentStatusRow
        Return CType(Me.Rows.Find(New Object() {PaymentStatusID}), tbPaymentStatusRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overrides Function Clone() As Global.System.Data.DataTable
        Dim cln As tbPaymentStatus = CType(MyBase.Clone, tbPaymentStatus)
        cln.InitVars()
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
        Return New tbPaymentStatus()
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub InitVars()
        Me.columnPaymentStatusID = MyBase.Columns("PaymentStatusID")
        Me.columnPaymentStatus = MyBase.Columns("PaymentStatus")
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub InitClass()
        Me.columnPaymentStatusID = New Global.System.Data.DataColumn("PaymentStatusID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPaymentStatusID)
        Me.columnPaymentStatus = New Global.System.Data.DataColumn("PaymentStatus", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPaymentStatus)
        Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnPaymentStatusID}, True))
        Me.columnPaymentStatusID.AutoIncrement = True
        Me.columnPaymentStatusID.AutoIncrementSeed = -1
        Me.columnPaymentStatusID.AutoIncrementStep = -1
        Me.columnPaymentStatusID.AllowDBNull = False
        Me.columnPaymentStatusID.ReadOnly = True
        Me.columnPaymentStatusID.Unique = True
        Me.columnPaymentStatus.AllowDBNull = False
        Me.columnPaymentStatus.MaxLength = 100

    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function NewtbPaymentStatusRow() As tbPaymentStatusRow
        Return CType(Me.NewRow, tbPaymentStatusRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
        Return New tbPaymentStatusRow(builder)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function GetRowType() As Global.System.Type
        Return GetType(tbPaymentStatusRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanged(e)
        If (Not (Me.tbPaymentStatusRowChangedEvent) Is Nothing) Then
            RaiseEvent tbPaymentStatusRowChanged(Me, New tbPaymentStatusRowChangeEvent(CType(e.Row, tbPaymentStatusRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanging(e)
        If (Not (Me.tbPaymentStatusRowChangingEvent) Is Nothing) Then
            RaiseEvent tbPaymentStatusRowChanging(Me, New tbPaymentStatusRowChangeEvent(CType(e.Row, tbPaymentStatusRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleted(e)
        If (Not (Me.tbPaymentStatusRowDeletedEvent) Is Nothing) Then
            RaiseEvent tbPaymentStatusRowDeleted(Me, New tbPaymentStatusRowChangeEvent(CType(e.Row, tbPaymentStatusRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleting(e)
        If (Not (Me.tbPaymentStatusRowDeletingEvent) Is Nothing) Then
            RaiseEvent tbPaymentStatusRowDeleting(Me, New tbPaymentStatusRowChangeEvent(CType(e.Row, tbPaymentStatusRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub RemovetbPaymentStatusRow(ByVal row As tbPaymentStatusRow)
        Me.Rows.Remove(row)
    End Sub
    Private _ta As tbPaymentStatusTableAdapter
    Private _dbrm As dbrm

    Public ReadOnly Property TableAdapter() As tbPaymentStatusTableAdapter
        Get
            If _ta Is Nothing Then
                _ta = New tbPaymentStatusTableAdapter
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
                    _ta = New tbPaymentStatusTableAdapter
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
                _ta = New tbPaymentStatusTableAdapter
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
    Partial Public Class tbPaymentStatusTableAdapter
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
            tableMapping.DataSetTable = "tbPaymentStatus"
            tableMapping.ColumnMappings.Add("PaymentStatusID", "PaymentStatusID")
            tableMapping.ColumnMappings.Add("PaymentStatus", "PaymentStatus")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "exec sp_tbPaymentStatus_D @Original_PaymentStatusID"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PaymentStatus", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatus", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbPaymentStatus_I  @PaymentStatus; " &
            "SELECT PaymentStatusID , PaymentStatus " &
            "FROM tbPaymentStatus " &
            "WHERE PaymentStatusID = @RETURN_VALUE"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PaymentStatus", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatus", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "exec sp_tbPaymentStatus_U @PaymentStatusID, @PaymentStatus, @Original_PaymentStatus; " &
            "SELECT PaymentStatusID , PaymentStatus " &
            "FROM tbPaymentStatus " &
            "WHERE PaymentStatusID = @PaymentStatusID"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PaymentStatus", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatus", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PaymentStatus", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatus", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PaymentStatusID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
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
            Me._commandCollection(0).CommandText = "sp_tbPaymentStatus_S"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
        Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Overloads Function Fill(ByVal dataTable As tbPaymentStatus) As Integer
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
        Public Overridable Overloads Function GetData() As tbPaymentStatus
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As tbPaymentStatus = New tbPaymentStatus()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Overloads Function Update(ByVal dataTable As tbPaymentStatus) As Integer
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
        Public Overridable Overloads Function Delete(ByVal Original_PaymentStatusID As Integer, ByVal Original_PaymentStatus As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_PaymentStatusID, Integer)
            If (Original_PaymentStatus Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_PaymentStatus")
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(Original_PaymentStatus, String)
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
        Public Overridable Overloads Function Insert(ByVal PaymentStatus As String) As Integer
            If (PaymentStatus Is Nothing) Then
                Throw New Global.System.ArgumentNullException("PaymentStatus")
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(PaymentStatus, String)
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
        Public Overridable Overloads Function Update(ByVal PaymentStatus As String, ByVal Original_PaymentStatusID As Integer, ByVal Original_PaymentStatus As String, ByVal PaymentStatusID As Integer) As Integer
            If (PaymentStatus Is Nothing) Then
                Throw New Global.System.ArgumentNullException("PaymentStatus")
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(PaymentStatus, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(1).Value = CType(Original_PaymentStatusID, Integer)
            If (Original_PaymentStatus Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_PaymentStatus")
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = CType(Original_PaymentStatus, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(3).Value = CType(PaymentStatusID, Integer)
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
        Public Overridable Overloads Function Update(ByVal PaymentStatus As String, ByVal Original_PaymentStatusID As Integer, ByVal Original_PaymentStatus As String) As Integer
            Return Me.Update(PaymentStatus, Original_PaymentStatusID, Original_PaymentStatus, Original_PaymentStatusID)
        End Function
    End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbPaymentStatusRow
    Inherits Global.System.Data.DataRow

    Private tabletbPaymentStatus As tbPaymentStatus

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
        MyBase.New(rb)
        Me.tabletbPaymentStatus = CType(Me.Table, tbPaymentStatus)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property PaymentStatusID() As Integer
        Get
            Return CType(Me(Me.tabletbPaymentStatus.PaymentStatusIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbPaymentStatus.PaymentStatusIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property PaymentStatus() As String
        Get
            Return CType(Me(Me.tabletbPaymentStatus.PaymentStatusColumn), String)
        End Get
        Set
            Me(Me.tabletbPaymentStatus.PaymentStatusColumn) = Value
        End Set
    End Property
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
Public Class tbPaymentStatusRowChangeEvent
    Inherits Global.System.EventArgs

    Private eventRow As tbPaymentStatusRow

    Private eventAction As Global.System.Data.DataRowAction

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New(ByVal row As tbPaymentStatusRow, ByVal action As Global.System.Data.DataRowAction)
        MyBase.New
        Me.eventRow = row
        Me.eventAction = action
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property Row() As tbPaymentStatusRow
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
