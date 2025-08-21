Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbMessageRowChangeEventHandler(ByVal sender As Object, ByVal e As tbMessageRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(),
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
Partial Public Class tbMessage
    Inherits Global.System.Data.TypedTableBase(Of tbMessageRow)

    Private columnMessageID As Global.System.Data.DataColumn

    Private columnRecieverID As Global.System.Data.DataColumn

    Private columnSenderID As Global.System.Data.DataColumn

    Private columnCaseID As Global.System.Data.DataColumn

    Private columnmessage As Global.System.Data.DataColumn

    Private columndate As Global.System.Data.DataColumn

    Private columnReaded As Global.System.Data.DataColumn

    Private columnIsFile As Global.System.Data.DataColumn

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New()
        MyBase.New
        Me.TableName = "tbMessage"
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
    Public ReadOnly Property MessageIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnMessageID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property RecieverIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnRecieverID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property SenderIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnSenderID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property CaseIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnCaseID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property messageColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnmessage
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property dateColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columndate
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property ReadedColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnReaded
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property IsFileColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnIsFile
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
    Default Public ReadOnly Property Item(ByVal index As Integer) As tbMessageRow
        Get
            Return CType(Me.Rows(index), tbMessageRow)
        End Get
    End Property

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMessageRowChanging As tbMessageRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMessageRowChanged As tbMessageRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMessageRowDeleting As tbMessageRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbMessageRowDeleted As tbMessageRowChangeEventHandler

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Sub AddtbMessageRow(ByVal row As tbMessageRow)
        Me.Rows.Add(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Function AddtbMessageRow(ByVal RecieverID As Integer, ByVal SenderID As Integer, ByVal CaseID As Integer, ByVal message As String, ByVal _date As Date, ByVal Readed As Boolean, ByVal IsFile As Boolean) As tbMessageRow
        Dim rowtbMessageRow As tbMessageRow = CType(Me.NewRow, tbMessageRow)
        Dim columnValuesArray() As Object = New Object() {Nothing, RecieverID, SenderID, CaseID, message, _date, Readed, IsFile}
        rowtbMessageRow.ItemArray = columnValuesArray
        Me.Rows.Add(rowtbMessageRow)
        Return rowtbMessageRow
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function FindByMessageID(ByVal MessageID As Integer) As tbMessageRow
        Return CType(Me.Rows.Find(New Object() {MessageID}), tbMessageRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overrides Function Clone() As Global.System.Data.DataTable
        Dim cln As tbMessage = CType(MyBase.Clone, tbMessage)
        cln.InitVars()
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
        Return New tbMessage()
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub InitVars()
        Me.columnMessageID = MyBase.Columns("MessageID")
        Me.columnRecieverID = MyBase.Columns("RecieverID")
        Me.columnSenderID = MyBase.Columns("SenderID")
        Me.columnCaseID = MyBase.Columns("CaseID")
        Me.columnmessage = MyBase.Columns("message")
        Me.columndate = MyBase.Columns("date")
        Me.columnReaded = MyBase.Columns("Readed")
        Me.columnIsFile = MyBase.Columns("IsFile")
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub InitClass()
        Me.columnMessageID = New Global.System.Data.DataColumn("MessageID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnMessageID)
        Me.columnRecieverID = New Global.System.Data.DataColumn("RecieverID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnRecieverID)
        Me.columnSenderID = New Global.System.Data.DataColumn("SenderID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnSenderID)
        Me.columnCaseID = New Global.System.Data.DataColumn("CaseID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnCaseID)
        Me.columnmessage = New Global.System.Data.DataColumn("message", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnmessage)
        Me.columndate = New Global.System.Data.DataColumn("date", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
        Me.columndate.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "dateColumn")
        Me.columndate.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columndate")
        Me.columndate.ExtendedProperties.Add("Generator_UserColumnName", "date")
        MyBase.Columns.Add(Me.columndate)
        Me.columnReaded = New Global.System.Data.DataColumn("Readed", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnReaded)
        Me.columnIsFile = New Global.System.Data.DataColumn("IsFile", GetType(Boolean), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnIsFile)
        Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnMessageID}, True))
        Me.columnMessageID.AutoIncrement = True
        Me.columnMessageID.AutoIncrementSeed = -1
        Me.columnMessageID.AutoIncrementStep = -1
        Me.columnMessageID.AllowDBNull = False
        Me.columnMessageID.ReadOnly = True
        Me.columnMessageID.Unique = True
        Me.columnSenderID.AllowDBNull = False
        Me.columnmessage.AllowDBNull = False
        Me.columnmessage.MaxLength = 1024
        Me.columndate.AllowDBNull = False
        Me.columnReaded.AllowDBNull = False
        Me.columnIsFile.AllowDBNull = False
        Me.columnReaded.DefaultValue = ((0))
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function NewtbMessageRow() As tbMessageRow
        Return CType(Me.NewRow, tbMessageRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
        Return New tbMessageRow(builder)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function GetRowType() As Global.System.Type
        Return GetType(tbMessageRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanged(e)
        If (Not (Me.tbMessageRowChangedEvent) Is Nothing) Then
            RaiseEvent tbMessageRowChanged(Me, New tbMessageRowChangeEvent(CType(e.Row, tbMessageRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanging(e)
        If (Not (Me.tbMessageRowChangingEvent) Is Nothing) Then
            RaiseEvent tbMessageRowChanging(Me, New tbMessageRowChangeEvent(CType(e.Row, tbMessageRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleted(e)
        If (Not (Me.tbMessageRowDeletedEvent) Is Nothing) Then
            RaiseEvent tbMessageRowDeleted(Me, New tbMessageRowChangeEvent(CType(e.Row, tbMessageRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleting(e)
        If (Not (Me.tbMessageRowDeletingEvent) Is Nothing) Then
            RaiseEvent tbMessageRowDeleting(Me, New tbMessageRowChangeEvent(CType(e.Row, tbMessageRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub RemovetbMessageRow(ByVal row As tbMessageRow)
        Me.Rows.Remove(row)
    End Sub
    Private _ta As tbMessageTableAdapter
    Private _dbrm As dbrm

    Public ReadOnly Property TableAdapter() As tbMessageTableAdapter
        Get
            If _ta Is Nothing Then
                _ta = New tbMessageTableAdapter
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
                    _ta = New tbMessageTableAdapter
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
                _ta = New tbMessageTableAdapter
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
    Partial Public Class tbMessageTableAdapter
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
            tableMapping.DataSetTable = "tbMessage"
            tableMapping.ColumnMappings.Add("MessageID", "MessageID")
            tableMapping.ColumnMappings.Add("RecieverID", "RecieverID")
            tableMapping.ColumnMappings.Add("SenderID", "SenderID")
            tableMapping.ColumnMappings.Add("CaseID", "CaseID")
            tableMapping.ColumnMappings.Add("message", "message")
            tableMapping.ColumnMappings.Add("date", "date")
            tableMapping.ColumnMappings.Add("Readed", "Readed")
            tableMapping.ColumnMappings.Add("IsFile", "IsFile")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "exec sp_tbMessage_D @Original_MessageID"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_MessageID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MessageID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_RecieverID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RecieverID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_RecieverID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RecieverID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_SenderID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SenderID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_message", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "message", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_date", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "date", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Readed", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Readed", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_IsFile", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "IsFile", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbMessage_I  @RecieverID, @SenderID, @CaseID, @message, @date, @Readed, @IsFile; " &
            "SELECT MessageID , RecieverID , SenderID , CaseID , message , date , Readed , IsFile " &
            "FROM tbMessage " &
            "WHERE MessageID = @RETURN_VALUE"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RecieverID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RecieverID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@SenderID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SenderID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@message", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "message", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@date", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "date", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Readed", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Readed", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsFile", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "IsFile", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "exec sp_tbMessage_U @MessageID, @RecieverID, @Original_RecieverID, @SenderID, @Original_SenderID, @CaseID, @Original_CaseID, @message, @Original_message, @date, @Original_date, @Readed, @Original_Readed, @IsFile, @Original_IsFile; " &
            "SELECT MessageID , RecieverID , SenderID , CaseID , message , date , Readed , IsFile " &
            "FROM tbMessage " &
            "WHERE MessageID = @MessageID"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@RecieverID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RecieverID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@SenderID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SenderID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@message", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "message", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@date", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "date", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Readed", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Readed", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsFile", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "IsFile", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_MessageID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MessageID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_RecieverID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RecieverID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_RecieverID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "RecieverID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_SenderID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "SenderID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_message", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "message", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_date", Global.System.Data.SqlDbType.DateTime, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "date", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Readed", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Readed", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_IsFile", Global.System.Data.SqlDbType.Bit, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "IsFile", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@MessageID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "MessageID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
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
            Me._commandCollection(0).CommandText = "sp_tbMessage_S"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
        Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Overloads Function Fill(ByVal dataTable As tbMessage) As Integer
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
        Public Overridable Overloads Function GetData() As tbMessage
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As tbMessage = New tbMessage()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Overloads Function Update(ByVal dataTable As tbMessage) As Integer
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
        Public Overridable Overloads Function Delete(ByVal Original_MessageID As Integer, ByVal Original_RecieverID As Global.System.Nullable(Of Integer), ByVal Original_SenderID As Integer, ByVal Original_CaseID As Global.System.Nullable(Of Integer), ByVal Original_message As String, ByVal Original_date As Date, ByVal Original_Readed As Boolean, ByVal Original_IsFile As Boolean) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_MessageID, Integer)
            If (Original_RecieverID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = CType(Original_RecieverID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.DeleteCommand.Parameters(3).Value = CType(Original_SenderID, Integer)
            If (Original_CaseID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(4).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(5).Value = CType(Original_CaseID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(4).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(5).Value = Global.System.DBNull.Value
            End If
            If (Original_message Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_message")
            Else
                Me.Adapter.DeleteCommand.Parameters(6).Value = CType(Original_message, String)
            End If
            Me.Adapter.DeleteCommand.Parameters(7).Value = CType(Original_date, Date)
            Me.Adapter.DeleteCommand.Parameters(8).Value = CType(Original_Readed, Boolean)
            Me.Adapter.DeleteCommand.Parameters(9).Value = CType(Original_IsFile, Boolean)
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
        Public Overridable Overloads Function Insert(ByVal RecieverID As Global.System.Nullable(Of Integer), ByVal SenderID As Integer, ByVal CaseID As Global.System.Nullable(Of Integer), ByVal message As String, ByVal _date As Date, ByVal Readed As Boolean, ByVal IsFile As Boolean) As Integer
            If (RecieverID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(RecieverID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.InsertCommand.Parameters(1).Value = CType(SenderID, Integer)
            If (CaseID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(2).Value = CType(CaseID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (message Is Nothing) Then
                Throw New Global.System.ArgumentNullException("message")
            Else
                Me.Adapter.InsertCommand.Parameters(3).Value = CType(message, String)
            End If
            Me.Adapter.InsertCommand.Parameters(4).Value = CType(_date, Date)
            Me.Adapter.InsertCommand.Parameters(5).Value = CType(Readed, Boolean)
            Me.Adapter.InsertCommand.Parameters(6).Value = CType(IsFile, Boolean)
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
        ByVal RecieverID As Global.System.Nullable(Of Integer),
        ByVal SenderID As Integer,
        ByVal CaseID As Global.System.Nullable(Of Integer),
        ByVal message As String,
        ByVal _date As Date,
        ByVal Readed As Boolean,
        ByVal IsFile As Boolean,
        ByVal Original_MessageID As Integer,
        ByVal Original_RecieverID As Global.System.Nullable(Of Integer),
        ByVal Original_SenderID As Integer,
        ByVal Original_CaseID As Global.System.Nullable(Of Integer),
        ByVal Original_message As String,
        ByVal Original_date As Date,
        ByVal Original_Readed As Boolean,
        ByVal Original_IsFile As Boolean,
        ByVal MessageID As Integer) As Integer
            If (RecieverID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(RecieverID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(1).Value = CType(SenderID, Integer)
            If (CaseID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(2).Value = CType(CaseID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (message Is Nothing) Then
                Throw New Global.System.ArgumentNullException("message")
            Else
                Me.Adapter.UpdateCommand.Parameters(3).Value = CType(message, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(4).Value = CType(_date, Date)
            Me.Adapter.UpdateCommand.Parameters(5).Value = CType(Readed, Boolean)
            Me.Adapter.UpdateCommand.Parameters(6).Value = CType(IsFile, Boolean)
            Me.Adapter.UpdateCommand.Parameters(7).Value = CType(Original_MessageID, Integer)
            If (Original_RecieverID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(8).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(9).Value = CType(Original_RecieverID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(8).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(9).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(10).Value = CType(Original_SenderID, Integer)
            If (Original_CaseID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(11).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(12).Value = CType(Original_CaseID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(11).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(12).Value = Global.System.DBNull.Value
            End If
            If (Original_message Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_message")
            Else
                Me.Adapter.UpdateCommand.Parameters(13).Value = CType(Original_message, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(14).Value = CType(Original_date, Date)
            Me.Adapter.UpdateCommand.Parameters(15).Value = CType(Original_Readed, Boolean)
            Me.Adapter.UpdateCommand.Parameters(16).Value = CType(Original_IsFile, Boolean)
            Me.Adapter.UpdateCommand.Parameters(17).Value = CType(MessageID, Integer)
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
        Public Overridable Overloads Function Update(ByVal RecieverID As Global.System.Nullable(Of Integer), ByVal SenderID As Integer, ByVal CaseID As Global.System.Nullable(Of Integer), ByVal message As String, ByVal _date As Date, ByVal Readed As Boolean, ByVal IsFile As Boolean, ByVal Original_MessageID As Integer, ByVal Original_RecieverID As Global.System.Nullable(Of Integer), ByVal Original_SenderID As Integer, ByVal Original_CaseID As Global.System.Nullable(Of Integer), ByVal Original_message As String, ByVal Original_date As Date, ByVal Original_Readed As Boolean, ByVal Original_IsFile As Boolean) As Integer
            Return Me.Update(RecieverID, SenderID, CaseID, message, _date, Readed, IsFile, Original_MessageID, Original_RecieverID, Original_SenderID, Original_CaseID, Original_message, Original_date, Original_Readed, Original_IsFile, Original_MessageID)
        End Function
    End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbMessageRow
    Inherits Global.System.Data.DataRow

    Private tabletbMessage As tbMessage

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
        MyBase.New(rb)
        Me.tabletbMessage = CType(Me.Table, tbMessage)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property MessageID() As Integer
        Get
            Return CType(Me(Me.tabletbMessage.MessageIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbMessage.MessageIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property RecieverID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbMessage.RecieverIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'RecieverID' in table 'tbMessage' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbMessage.RecieverIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property SenderID() As Integer
        Get
            Return CType(Me(Me.tabletbMessage.SenderIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbMessage.SenderIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property CaseID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbMessage.CaseIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'CaseID' in table 'tbMessage' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbMessage.CaseIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property message() As String
        Get
            Return CType(Me(Me.tabletbMessage.messageColumn), String)
        End Get
        Set
            Me(Me.tabletbMessage.messageColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property _date() As Date
        Get
            Return CType(Me(Me.tabletbMessage.dateColumn), Date)
        End Get
        Set
            Me(Me.tabletbMessage.dateColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Readed() As Boolean
        Get
            Return CType(Me(Me.tabletbMessage.ReadedColumn), Boolean)
        End Get
        Set
            Me(Me.tabletbMessage.ReadedColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property IsFile() As Boolean
        Get
            Return CType(Me(Me.tabletbMessage.IsFileColumn), Boolean)
        End Get
        Set
            Me(Me.tabletbMessage.IsFileColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsRecieverIDNull() As Boolean
        Return Me.IsNull(Me.tabletbMessage.RecieverIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetRecieverIDNull()
        Me(Me.tabletbMessage.RecieverIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsCaseIDNull() As Boolean
        Return Me.IsNull(Me.tabletbMessage.CaseIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetCaseIDNull()
        Me(Me.tabletbMessage.CaseIDColumn) = Global.System.Convert.DBNull
    End Sub
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
Public Class tbMessageRowChangeEvent
    Inherits Global.System.EventArgs

    Private eventRow As tbMessageRow

    Private eventAction As Global.System.Data.DataRowAction

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New(ByVal row As tbMessageRow, ByVal action As Global.System.Data.DataRowAction)
        MyBase.New
        Me.eventRow = row
        Me.eventAction = action
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property Row() As tbMessageRow
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