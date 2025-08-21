Option Strict Off
Option Explicit On
Imports TrierraSoftDotNET



Public Delegate Sub tbCaseRowChangeEventHandler(ByVal sender As Object, ByVal e As tbCaseRowChangeEvent)

'''<summary>
'''Represents the strongly named DataTable class.
'''</summary>
<Global.System.Serializable(),
Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")>
Partial Public Class tbCase
    Inherits Global.System.Data.TypedTableBase(Of tbCaseRow)

    Private columnCaseID As Global.System.Data.DataColumn

    Private columnStatusID As Global.System.Data.DataColumn

    Private columnPriorityLevelID As Global.System.Data.DataColumn

    Private columnPatientID As Global.System.Data.DataColumn

    Private columnDoctorID As Global.System.Data.DataColumn

    Private columnPracticeID As Global.System.Data.DataColumn

    Private columnTechnicianID As Global.System.Data.DataColumn

    Private columnItemTypeID As Global.System.Data.DataColumn

    Private columnMaterialID As Global.System.Data.DataColumn

    Private columnShadeID As Global.System.Data.DataColumn

    Private columnPaymentStatusID As Global.System.Data.DataColumn

    Private columnCaseDate As Global.System.Data.DataColumn

    Private columnDeadline As Global.System.Data.DataColumn

    Private columnToothNumber As Global.System.Data.DataColumn

    Private columnNotes As Global.System.Data.DataColumn

    Private columnPrice As Global.System.Data.DataColumn

    Private columnDeliveryAddress As Global.System.Data.DataColumn

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New()
        MyBase.New
        Me.TableName = "tbCase"
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
    Public ReadOnly Property CaseIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnCaseID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property StatusIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnStatusID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property PriorityLevelIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPriorityLevelID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property PatientIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPatientID
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
    Public ReadOnly Property PracticeIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPracticeID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property TechnicianIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnTechnicianID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property ItemTypeIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnItemTypeID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property MaterialIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnMaterialID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property ShadeIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnShadeID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property PaymentStatusIDColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPaymentStatusID
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property CaseDateColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnCaseDate
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property DeadlineColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnDeadline
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property ToothNumberColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnToothNumber
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property NotesColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnNotes
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property PriceColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnPrice
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property DeliveryAddressColumn() As Global.System.Data.DataColumn
        Get
            Return Me.columnDeliveryAddress
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
    Default Public ReadOnly Property Item(ByVal index As Integer) As tbCaseRow
        Get
            Return CType(Me.Rows(index), tbCaseRow)
        End Get
    End Property

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbCaseRowChanging As tbCaseRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbCaseRowChanged As tbCaseRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbCaseRowDeleting As tbCaseRowChangeEventHandler

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Event tbCaseRowDeleted As tbCaseRowChangeEventHandler

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Sub AddtbCaseRow(ByVal row As tbCaseRow)
        Me.Rows.Add(row)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overloads Function AddtbCaseRow(
    ByVal StatusID As Integer,
    ByVal PriorityLevelID As Integer,
    ByVal PatientID As Integer,
    ByVal DoctorID As Integer,
    ByVal PracticeID As Integer,
    ByVal TechnicianID As Integer,
    ByVal ItemTypeID As Integer,
    ByVal MaterialID As Integer,
    ByVal ShadeID As Integer,
    ByVal PaymentStatusID As Integer,
    ByVal CaseDate As Date,
    ByVal Deadline As Date,
    ByVal ToothNumber As String,
    ByVal Notes As String,
    ByVal Price As Decimal,
    ByVal DeliveryAddress As String) As tbCaseRow
        Dim rowtbCaseRow As tbCaseRow = CType(Me.NewRow, tbCaseRow)
        Dim columnValuesArray() As Object = New Object() {Nothing, StatusID, PriorityLevelID, PatientID, DoctorID, PracticeID, TechnicianID, ItemTypeID, MaterialID, ShadeID, PaymentStatusID, CaseDate, Deadline, ToothNumber, Notes, Price, DeliveryAddress}
        rowtbCaseRow.ItemArray = columnValuesArray
        Me.Rows.Add(rowtbCaseRow)
        Return rowtbCaseRow
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function FindByCaseID(ByVal CaseID As Integer) As tbCaseRow
        Return CType(Me.Rows.Find(New Object() {CaseID}), tbCaseRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Overrides Function Clone() As Global.System.Data.DataTable
        Dim cln As tbCase = CType(MyBase.Clone, tbCase)
        cln.InitVars()
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
        Return New tbCase()
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub InitVars()
        Me.columnCaseID = MyBase.Columns("CaseID")
        Me.columnStatusID = MyBase.Columns("StatusID")
        Me.columnPriorityLevelID = MyBase.Columns("PriorityLevelID")
        Me.columnPatientID = MyBase.Columns("PatientID")
        Me.columnDoctorID = MyBase.Columns("DoctorID")
        Me.columnPracticeID = MyBase.Columns("PracticeID")
        Me.columnTechnicianID = MyBase.Columns("TechnicianID")
        Me.columnItemTypeID = MyBase.Columns("ItemTypeID")
        Me.columnMaterialID = MyBase.Columns("MaterialID")
        Me.columnShadeID = MyBase.Columns("ShadeID")
        Me.columnPaymentStatusID = MyBase.Columns("PaymentStatusID")
        Me.columnCaseDate = MyBase.Columns("CaseDate")
        Me.columnDeadline = MyBase.Columns("Deadline")
        Me.columnToothNumber = MyBase.Columns("ToothNumber")
        Me.columnNotes = MyBase.Columns("Notes")
        Me.columnPrice = MyBase.Columns("Price")
        Me.columnDeliveryAddress = MyBase.Columns("DeliveryAddress")
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Private Sub InitClass()
        Me.columnCaseID = New Global.System.Data.DataColumn("CaseID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnCaseID)
        Me.columnStatusID = New Global.System.Data.DataColumn("StatusID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnStatusID)
        Me.columnPriorityLevelID = New Global.System.Data.DataColumn("PriorityLevelID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPriorityLevelID)
        Me.columnPatientID = New Global.System.Data.DataColumn("PatientID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPatientID)
        Me.columnDoctorID = New Global.System.Data.DataColumn("DoctorID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnDoctorID)
        Me.columnPracticeID = New Global.System.Data.DataColumn("PracticeID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPracticeID)
        Me.columnTechnicianID = New Global.System.Data.DataColumn("TechnicianID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnTechnicianID)
        Me.columnItemTypeID = New Global.System.Data.DataColumn("ItemTypeID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnItemTypeID)
        Me.columnMaterialID = New Global.System.Data.DataColumn("MaterialID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnMaterialID)
        Me.columnShadeID = New Global.System.Data.DataColumn("ShadeID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnShadeID)
        Me.columnPaymentStatusID = New Global.System.Data.DataColumn("PaymentStatusID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPaymentStatusID)
        Me.columnCaseDate = New Global.System.Data.DataColumn("CaseDate", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnCaseDate)
        Me.columnDeadline = New Global.System.Data.DataColumn("Deadline", GetType(Date), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnDeadline)
        Me.columnToothNumber = New Global.System.Data.DataColumn("ToothNumber", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnToothNumber)
        Me.columnNotes = New Global.System.Data.DataColumn("Notes", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnNotes)
        Me.columnPrice = New Global.System.Data.DataColumn("Price", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnPrice)
        Me.columnDeliveryAddress = New Global.System.Data.DataColumn("DeliveryAddress", GetType(String), Nothing, Global.System.Data.MappingType.Element)
        MyBase.Columns.Add(Me.columnDeliveryAddress)
        Me.Constraints.Add(New Global.System.Data.UniqueConstraint("Constraint1", New Global.System.Data.DataColumn() {Me.columnCaseID}, True))
        Me.columnCaseID.AutoIncrement = True
        Me.columnCaseID.AutoIncrementSeed = -1
        Me.columnCaseID.AutoIncrementStep = -1
        Me.columnCaseID.AllowDBNull = False
        Me.columnCaseID.ReadOnly = True
        Me.columnCaseID.Unique = True
        Me.columnPatientID.AllowDBNull = False
        Me.columnDoctorID.AllowDBNull = False
        Me.columnPracticeID.AllowDBNull = False
        Me.columnItemTypeID.AllowDBNull = False
        Me.columnCaseDate.AllowDBNull = False
        Me.columnToothNumber.AllowDBNull = False
        Me.columnToothNumber.MaxLength = 200
        Me.columnNotes.MaxLength = 1024
        Me.columnDeliveryAddress.MaxLength = 8000
        Me.columnCaseDate.DefaultValue = (Date.Today)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function NewtbCaseRow() As tbCaseRow
        Return CType(Me.NewRow, tbCaseRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
        Return New tbCaseRow(builder)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Function GetRowType() As Global.System.Type
        Return GetType(tbCaseRow)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanged(e)
        If (Not (Me.tbCaseRowChangedEvent) Is Nothing) Then
            RaiseEvent tbCaseRowChanged(Me, New tbCaseRowChangeEvent(CType(e.Row, tbCaseRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowChanging(e)
        If (Not (Me.tbCaseRowChangingEvent) Is Nothing) Then
            RaiseEvent tbCaseRowChanging(Me, New tbCaseRowChangeEvent(CType(e.Row, tbCaseRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleted(e)
        If (Not (Me.tbCaseRowDeletedEvent) Is Nothing) Then
            RaiseEvent tbCaseRowDeleted(Me, New tbCaseRowChangeEvent(CType(e.Row, tbCaseRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
        MyBase.OnRowDeleting(e)
        If (Not (Me.tbCaseRowDeletingEvent) Is Nothing) Then
            RaiseEvent tbCaseRowDeleting(Me, New tbCaseRowChangeEvent(CType(e.Row, tbCaseRow), e.Action))
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub RemovetbCaseRow(ByVal row As tbCaseRow)
        Me.Rows.Remove(row)
    End Sub
    Private _ta As tbCaseTableAdapter
    Private _dbrm As dbrm

    Public ReadOnly Property TableAdapter() As tbCaseTableAdapter
        Get
            If _ta Is Nothing Then
                _ta = New tbCaseTableAdapter
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
                    _ta = New tbCaseTableAdapter
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
                _ta = New tbCaseTableAdapter
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
    Partial Public Class tbCaseTableAdapter
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
            tableMapping.DataSetTable = "tbCase"
            tableMapping.ColumnMappings.Add("CaseID", "CaseID")
            tableMapping.ColumnMappings.Add("StatusID", "StatusID")
            tableMapping.ColumnMappings.Add("PriorityLevelID", "PriorityLevelID")
            tableMapping.ColumnMappings.Add("PatientID", "PatientID")
            tableMapping.ColumnMappings.Add("DoctorID", "DoctorID")
            tableMapping.ColumnMappings.Add("PracticeID", "PracticeID")
            tableMapping.ColumnMappings.Add("TechnicianID", "TechnicianID")
            tableMapping.ColumnMappings.Add("ItemTypeID", "ItemTypeID")
            tableMapping.ColumnMappings.Add("MaterialID", "MaterialID")
            tableMapping.ColumnMappings.Add("ShadeID", "ShadeID")
            tableMapping.ColumnMappings.Add("PaymentStatusID", "PaymentStatusID")
            tableMapping.ColumnMappings.Add("CaseDate", "CaseDate")
            tableMapping.ColumnMappings.Add("Deadline", "Deadline")
            tableMapping.ColumnMappings.Add("ToothNumber", "ToothNumber")
            tableMapping.ColumnMappings.Add("Notes", "Notes")
            tableMapping.ColumnMappings.Add("Price", "Price")
            tableMapping.ColumnMappings.Add("DeliveryAddress", "DeliveryAddress")
            Me._adapter.TableMappings.Add(tableMapping)
            Me._adapter.DeleteCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "exec sp_tbCase_D @Original_CaseID"
            Me._adapter.DeleteCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_StatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StatusID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_StatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StatusID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_PriorityLevelID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PriorityLevelID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PriorityLevelID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PriorityLevelID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PatientID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PatientID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracticeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ItemTypeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ItemTypeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CaseDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseDate", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Deadline", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Deadline", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Deadline", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Deadline", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ToothNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ToothNumber", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Notes", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Notes", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Notes", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Notes", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Price", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Price", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Price", Global.System.Data.SqlDbType.Money, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Price", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_DeliveryAddress", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DeliveryAddress", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DeliveryAddress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DeliveryAddress", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "DECLARE @RETURN_VALUE INT; exec @RETURN_VALUE = sp_tbCase_I  @StatusID, @PriorityLevelID, @PatientID, @DoctorID, @PracticeID, @TechnicianID, @ItemTypeID, @MaterialID, @ShadeID, @PaymentStatusID, @CaseDate, @Deadline, @ToothNumber, @Notes, @Price, @DeliveryAddress; " &
            "SELECT CaseID , StatusID , PriorityLevelID , PatientID , DoctorID , PracticeID , TechnicianID , ItemTypeID , MaterialID , ShadeID , PaymentStatusID , CaseDate , Deadline , ToothNumber , Notes , Price , DeliveryAddress " &
            "FROM tbCase " &
            "WHERE CaseID = @RETURN_VALUE"
            Me._adapter.InsertCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@StatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StatusID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PriorityLevelID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PriorityLevelID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PatientID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PatientID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PracticeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ItemTypeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ItemTypeID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CaseDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseDate", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Deadline", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Deadline", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ToothNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ToothNumber", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Notes", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Notes", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Price", Global.System.Data.SqlDbType.Money, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Price", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DeliveryAddress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DeliveryAddress", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New Global.System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.CommandTimeout = GS.CommandTimeout
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "exec sp_tbCase_U @CaseID, @StatusID, @Original_StatusID, @PriorityLevelID, @Original_PriorityLevelID, @PatientID, @Original_PatientID, @DoctorID, @Original_DoctorID, @PracticeID, @Original_PracticeID, @TechnicianID, @Original_TechnicianID, @ItemTypeID, @Original_ItemTypeID, @MaterialID, @Original_MaterialID, @ShadeID, @Original_ShadeID, @PaymentStatusID, @Original_PaymentStatusID, @CaseDate, @Original_CaseDate, @Deadline, @Original_Deadline, @ToothNumber, @Original_ToothNumber, @Notes, @Original_Notes, @Price, @Original_Price, @DeliveryAddress, @Original_DeliveryAddress; " &
            "SELECT CaseID , StatusID , PriorityLevelID , PatientID , DoctorID , PracticeID , TechnicianID , ItemTypeID , MaterialID , ShadeID , PaymentStatusID , CaseDate , Deadline , ToothNumber , Notes , Price , DeliveryAddress " &
            "FROM tbCase " &
            "WHERE CaseID = @CaseID"
            Me._adapter.UpdateCommand.CommandType = Global.System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@StatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StatusID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PriorityLevelID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PriorityLevelID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PatientID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PatientID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PracticeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ItemTypeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ItemTypeID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CaseDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseDate", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Deadline", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Deadline", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@ToothNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ToothNumber", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Notes", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Notes", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Price", Global.System.Data.SqlDbType.Money, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Price", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@DeliveryAddress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DeliveryAddress", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CaseID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_StatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StatusID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_StatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "StatusID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_PriorityLevelID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PriorityLevelID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PriorityLevelID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PriorityLevelID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PatientID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PatientID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DoctorID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DoctorID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PracticeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PracticeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_TechnicianID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "TechnicianID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ItemTypeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ItemTypeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_MaterialID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "MaterialID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ShadeID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ShadeID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_PaymentStatusID", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "PaymentStatusID", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_CaseDate", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseDate", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Deadline", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Deadline", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Deadline", Global.System.Data.SqlDbType.[Date], 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Deadline", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_ToothNumber", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "ToothNumber", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Notes", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Notes", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Notes", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Notes", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_Price", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Price", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_Price", Global.System.Data.SqlDbType.Money, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "Price", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@IsNull_DeliveryAddress", Global.System.Data.SqlDbType.Int, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DeliveryAddress", Global.System.Data.DataRowVersion.Original, True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@Original_DeliveryAddress", Global.System.Data.SqlDbType.VarChar, 0, Global.System.Data.ParameterDirection.Input, 0, 0, "DeliveryAddress", Global.System.Data.DataRowVersion.Original, False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New Global.System.Data.SqlClient.SqlParameter("@CaseID", Global.System.Data.SqlDbType.Int, 4, Global.System.Data.ParameterDirection.Input, 0, 0, "CaseID", Global.System.Data.DataRowVersion.Current, False, Nothing, "", "", ""))
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
            Me._commandCollection(0).CommandText = "sp_tbCase_S"
            Me._commandCollection(0).CommandType = Global.System.Data.CommandType.StoredProcedure
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"),
        Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Overloads Function Fill(ByVal dataTable As tbCase) As Integer
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
        Public Overridable Overloads Function GetData() As tbCase
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim dataTable As tbCase = New tbCase()
            Me.Adapter.Fill(dataTable)
            Return dataTable
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0"),
        Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Overloads Function Update(ByVal dataTable As tbCase) As Integer
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
        Public Overridable Overloads Function Delete(
        ByVal Original_CaseID As Integer,
        ByVal Original_StatusID As Global.System.Nullable(Of Integer),
        ByVal Original_PriorityLevelID As Global.System.Nullable(Of Integer),
        ByVal Original_PatientID As Integer,
        ByVal Original_DoctorID As Integer,
        ByVal Original_PracticeID As Integer,
        ByVal Original_TechnicianID As Global.System.Nullable(Of Integer),
        ByVal Original_ItemTypeID As Integer,
        ByVal Original_MaterialID As Global.System.Nullable(Of Integer),
        ByVal Original_ShadeID As Global.System.Nullable(Of Integer),
        ByVal Original_PaymentStatusID As Global.System.Nullable(Of Integer),
        ByVal Original_CaseDate As Date,
        ByVal Original_Deadline As Global.System.Nullable(Of Date),
        ByVal Original_ToothNumber As String,
        ByVal Original_Notes As String,
        ByVal Original_Price As Global.System.Nullable(Of Decimal),
        ByVal Original_DeliveryAddress As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(0).Value = CType(Original_CaseID, Integer)
            If (Original_StatusID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = CType(Original_StatusID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(1).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(2).Value = Global.System.DBNull.Value
            End If
            If (Original_PriorityLevelID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(3).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = CType(Original_PriorityLevelID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(3).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(4).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.DeleteCommand.Parameters(5).Value = CType(Original_PatientID, Integer)
            Me.Adapter.DeleteCommand.Parameters(6).Value = CType(Original_DoctorID, Integer)
            Me.Adapter.DeleteCommand.Parameters(7).Value = CType(Original_PracticeID, Integer)
            If (Original_TechnicianID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(8).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(9).Value = CType(Original_TechnicianID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(8).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(9).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.DeleteCommand.Parameters(10).Value = CType(Original_ItemTypeID, Integer)
            If (Original_MaterialID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(11).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(12).Value = CType(Original_MaterialID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(11).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(12).Value = Global.System.DBNull.Value
            End If
            If (Original_ShadeID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(13).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(14).Value = CType(Original_ShadeID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(13).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(14).Value = Global.System.DBNull.Value
            End If
            If (Original_PaymentStatusID.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(15).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(16).Value = CType(Original_PaymentStatusID.Value, Integer)
            Else
                Me.Adapter.DeleteCommand.Parameters(15).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(16).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.DeleteCommand.Parameters(17).Value = CType(Original_CaseDate, Date)
            If (Original_Deadline.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(18).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(19).Value = CType(Original_Deadline.Value, Date)
            Else
                Me.Adapter.DeleteCommand.Parameters(18).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(19).Value = Global.System.DBNull.Value
            End If
            If (Original_ToothNumber Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_ToothNumber")
            Else
                Me.Adapter.DeleteCommand.Parameters(20).Value = CType(Original_ToothNumber, String)
            End If
            If (Original_Notes Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(21).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(22).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(21).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(22).Value = CType(Original_Notes, String)
            End If
            If (Original_Price.HasValue = True) Then
                Me.Adapter.DeleteCommand.Parameters(23).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(24).Value = CType(Original_Price.Value, Decimal)
            Else
                Me.Adapter.DeleteCommand.Parameters(23).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(24).Value = Global.System.DBNull.Value
            End If
            If (Original_DeliveryAddress Is Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(25).Value = CType(1, Object)
                Me.Adapter.DeleteCommand.Parameters(26).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(25).Value = CType(0, Object)
                Me.Adapter.DeleteCommand.Parameters(26).Value = CType(Original_DeliveryAddress, String)
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
        Public Overridable Overloads Function Insert(
        ByVal StatusID As Global.System.Nullable(Of Integer),
        ByVal PriorityLevelID As Global.System.Nullable(Of Integer),
        ByVal PatientID As Integer,
        ByVal DoctorID As Integer,
        ByVal PracticeID As Integer,
        ByVal TechnicianID As Global.System.Nullable(Of Integer),
        ByVal ItemTypeID As Integer,
        ByVal MaterialID As Global.System.Nullable(Of Integer),
        ByVal ShadeID As Global.System.Nullable(Of Integer),
        ByVal PaymentStatusID As Global.System.Nullable(Of Integer),
        ByVal CaseDate As Date,
        ByVal Deadline As Global.System.Nullable(Of Date),
        ByVal ToothNumber As String,
        ByVal Notes As String,
        ByVal Price As Global.System.Nullable(Of Decimal),
        ByVal DeliveryAddress As String) As Integer
            If (StatusID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(0).Value = CType(StatusID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (PriorityLevelID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(1).Value = CType(PriorityLevelID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.InsertCommand.Parameters(2).Value = CType(PatientID, Integer)
            Me.Adapter.InsertCommand.Parameters(3).Value = CType(DoctorID, Integer)
            Me.Adapter.InsertCommand.Parameters(4).Value = CType(PracticeID, Integer)
            If (TechnicianID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(5).Value = CType(TechnicianID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(5).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.InsertCommand.Parameters(6).Value = CType(ItemTypeID, Integer)
            If (MaterialID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(7).Value = CType(MaterialID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(7).Value = Global.System.DBNull.Value
            End If
            If (ShadeID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(8).Value = CType(ShadeID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(8).Value = Global.System.DBNull.Value
            End If
            If (PaymentStatusID.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(9).Value = CType(PaymentStatusID.Value, Integer)
            Else
                Me.Adapter.InsertCommand.Parameters(9).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.InsertCommand.Parameters(10).Value = CType(CaseDate, Date)
            If (Deadline.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(11).Value = CType(Deadline.Value, Date)
            Else
                Me.Adapter.InsertCommand.Parameters(11).Value = Global.System.DBNull.Value
            End If
            If (ToothNumber Is Nothing) Then
                Throw New Global.System.ArgumentNullException("ToothNumber")
            Else
                Me.Adapter.InsertCommand.Parameters(12).Value = CType(ToothNumber, String)
            End If
            If (Notes Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(13).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(13).Value = CType(Notes, String)
            End If
            If (Price.HasValue = True) Then
                Me.Adapter.InsertCommand.Parameters(14).Value = CType(Price.Value, Decimal)
            Else
                Me.Adapter.InsertCommand.Parameters(14).Value = Global.System.DBNull.Value
            End If
            If (DeliveryAddress Is Nothing) Then
                Me.Adapter.InsertCommand.Parameters(15).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(15).Value = CType(DeliveryAddress, String)
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
        ByVal StatusID As Global.System.Nullable(Of Integer),
        ByVal PriorityLevelID As Global.System.Nullable(Of Integer),
        ByVal PatientID As Integer,
        ByVal DoctorID As Integer,
        ByVal PracticeID As Integer,
        ByVal TechnicianID As Global.System.Nullable(Of Integer),
        ByVal ItemTypeID As Integer,
        ByVal MaterialID As Global.System.Nullable(Of Integer),
        ByVal ShadeID As Global.System.Nullable(Of Integer),
        ByVal PaymentStatusID As Global.System.Nullable(Of Integer),
        ByVal CaseDate As Date,
        ByVal Deadline As Global.System.Nullable(Of Date),
        ByVal ToothNumber As String,
        ByVal Notes As String,
        ByVal Price As Global.System.Nullable(Of Decimal),
        ByVal DeliveryAddress As String,
        ByVal Original_CaseID As Integer,
        ByVal Original_StatusID As Global.System.Nullable(Of Integer),
        ByVal Original_PriorityLevelID As Global.System.Nullable(Of Integer),
        ByVal Original_PatientID As Integer,
        ByVal Original_DoctorID As Integer,
        ByVal Original_PracticeID As Integer,
        ByVal Original_TechnicianID As Global.System.Nullable(Of Integer),
        ByVal Original_ItemTypeID As Integer,
        ByVal Original_MaterialID As Global.System.Nullable(Of Integer),
        ByVal Original_ShadeID As Global.System.Nullable(Of Integer),
        ByVal Original_PaymentStatusID As Global.System.Nullable(Of Integer),
        ByVal Original_CaseDate As Date,
        ByVal Original_Deadline As Global.System.Nullable(Of Date),
        ByVal Original_ToothNumber As String,
        ByVal Original_Notes As String,
        ByVal Original_Price As Global.System.Nullable(Of Decimal),
        ByVal Original_DeliveryAddress As String,
        ByVal CaseID As Integer) As Integer
            If (StatusID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(0).Value = CType(StatusID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(0).Value = Global.System.DBNull.Value
            End If
            If (PriorityLevelID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(1).Value = CType(PriorityLevelID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(1).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(2).Value = CType(PatientID, Integer)
            Me.Adapter.UpdateCommand.Parameters(3).Value = CType(DoctorID, Integer)
            Me.Adapter.UpdateCommand.Parameters(4).Value = CType(PracticeID, Integer)
            If (TechnicianID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(5).Value = CType(TechnicianID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(5).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(6).Value = CType(ItemTypeID, Integer)
            If (MaterialID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(7).Value = CType(MaterialID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(7).Value = Global.System.DBNull.Value
            End If
            If (ShadeID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(8).Value = CType(ShadeID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(8).Value = Global.System.DBNull.Value
            End If
            If (PaymentStatusID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(9).Value = CType(PaymentStatusID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(9).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(10).Value = CType(CaseDate, Date)
            If (Deadline.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(11).Value = CType(Deadline.Value, Date)
            Else
                Me.Adapter.UpdateCommand.Parameters(11).Value = Global.System.DBNull.Value
            End If
            If (ToothNumber Is Nothing) Then
                Throw New Global.System.ArgumentNullException("ToothNumber")
            Else
                Me.Adapter.UpdateCommand.Parameters(12).Value = CType(ToothNumber, String)
            End If
            If (Notes Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(13).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(13).Value = CType(Notes, String)
            End If
            If (Price.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(14).Value = CType(Price.Value, Decimal)
            Else
                Me.Adapter.UpdateCommand.Parameters(14).Value = Global.System.DBNull.Value
            End If
            If (DeliveryAddress Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(15).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(15).Value = CType(DeliveryAddress, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(16).Value = CType(Original_CaseID, Integer)
            If (Original_StatusID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(17).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(18).Value = CType(Original_StatusID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(17).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(18).Value = Global.System.DBNull.Value
            End If
            If (Original_PriorityLevelID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(19).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(20).Value = CType(Original_PriorityLevelID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(19).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(20).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(21).Value = CType(Original_PatientID, Integer)
            Me.Adapter.UpdateCommand.Parameters(22).Value = CType(Original_DoctorID, Integer)
            Me.Adapter.UpdateCommand.Parameters(23).Value = CType(Original_PracticeID, Integer)
            If (Original_TechnicianID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(24).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(25).Value = CType(Original_TechnicianID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(24).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(25).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(26).Value = CType(Original_ItemTypeID, Integer)
            If (Original_MaterialID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(27).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(28).Value = CType(Original_MaterialID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(27).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(28).Value = Global.System.DBNull.Value
            End If
            If (Original_ShadeID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(29).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(30).Value = CType(Original_ShadeID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(29).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(30).Value = Global.System.DBNull.Value
            End If
            If (Original_PaymentStatusID.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(31).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(32).Value = CType(Original_PaymentStatusID.Value, Integer)
            Else
                Me.Adapter.UpdateCommand.Parameters(31).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(32).Value = Global.System.DBNull.Value
            End If
            Me.Adapter.UpdateCommand.Parameters(33).Value = CType(Original_CaseDate, Date)
            If (Original_Deadline.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(34).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(35).Value = CType(Original_Deadline.Value, Date)
            Else
                Me.Adapter.UpdateCommand.Parameters(34).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(35).Value = Global.System.DBNull.Value
            End If
            If (Original_ToothNumber Is Nothing) Then
                Throw New Global.System.ArgumentNullException("Original_ToothNumber")
            Else
                Me.Adapter.UpdateCommand.Parameters(36).Value = CType(Original_ToothNumber, String)
            End If
            If (Original_Notes Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(37).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(38).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(37).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(38).Value = CType(Original_Notes, String)
            End If
            If (Original_Price.HasValue = True) Then
                Me.Adapter.UpdateCommand.Parameters(39).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(40).Value = CType(Original_Price.Value, Decimal)
            Else
                Me.Adapter.UpdateCommand.Parameters(39).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(40).Value = Global.System.DBNull.Value
            End If
            If (Original_DeliveryAddress Is Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(41).Value = CType(1, Object)
                Me.Adapter.UpdateCommand.Parameters(42).Value = Global.System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(41).Value = CType(0, Object)
                Me.Adapter.UpdateCommand.Parameters(42).Value = CType(Original_DeliveryAddress, String)
            End If
            Me.Adapter.UpdateCommand.Parameters(43).Value = CType(CaseID, Integer)
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
        ByVal StatusID As Global.System.Nullable(Of Integer),
        ByVal PriorityLevelID As Global.System.Nullable(Of Integer),
        ByVal PatientID As Integer,
        ByVal DoctorID As Integer,
        ByVal PracticeID As Integer,
        ByVal TechnicianID As Global.System.Nullable(Of Integer),
        ByVal ItemTypeID As Integer,
        ByVal MaterialID As Global.System.Nullable(Of Integer),
        ByVal ShadeID As Global.System.Nullable(Of Integer),
        ByVal PaymentStatusID As Global.System.Nullable(Of Integer),
        ByVal CaseDate As Date,
        ByVal Deadline As Global.System.Nullable(Of Date),
        ByVal ToothNumber As String,
        ByVal Notes As String,
        ByVal Price As Global.System.Nullable(Of Decimal),
        ByVal DeliveryAddress As String,
        ByVal Original_CaseID As Integer,
        ByVal Original_StatusID As Global.System.Nullable(Of Integer),
        ByVal Original_PriorityLevelID As Global.System.Nullable(Of Integer),
        ByVal Original_PatientID As Integer,
        ByVal Original_DoctorID As Integer,
        ByVal Original_PracticeID As Integer,
        ByVal Original_TechnicianID As Global.System.Nullable(Of Integer),
        ByVal Original_ItemTypeID As Integer,
        ByVal Original_MaterialID As Global.System.Nullable(Of Integer),
        ByVal Original_ShadeID As Global.System.Nullable(Of Integer),
        ByVal Original_PaymentStatusID As Global.System.Nullable(Of Integer),
        ByVal Original_CaseDate As Date,
        ByVal Original_Deadline As Global.System.Nullable(Of Date),
        ByVal Original_ToothNumber As String,
        ByVal Original_Notes As String,
        ByVal Original_Price As Global.System.Nullable(Of Decimal),
        ByVal Original_DeliveryAddress As String) As Integer
            Return Me.Update(StatusID, PriorityLevelID, PatientID, DoctorID, PracticeID, TechnicianID, ItemTypeID, MaterialID, ShadeID, PaymentStatusID, CaseDate, Deadline, ToothNumber, Notes, Price, DeliveryAddress, Original_CaseID, Original_StatusID, Original_PriorityLevelID, Original_PatientID, Original_DoctorID, Original_PracticeID, Original_TechnicianID, Original_ItemTypeID, Original_MaterialID, Original_ShadeID, Original_PaymentStatusID, Original_CaseDate, Original_Deadline, Original_ToothNumber, Original_Notes, Original_Price, Original_DeliveryAddress, Original_CaseID)
        End Function
    End Class

End Class

'''<summary>
'''Represents strongly named DataRow class.
'''</summary>
Partial Public Class tbCaseRow
    Inherits Global.System.Data.DataRow

    Private tabletbCase As tbCase

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
        MyBase.New(rb)
        Me.tabletbCase = CType(Me.Table, tbCase)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property CaseID() As Integer
        Get
            Return CType(Me(Me.tabletbCase.CaseIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbCase.CaseIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property StatusID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbCase.StatusIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'StatusID' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.StatusIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property PriorityLevelID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbCase.PriorityLevelIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'PriorityLevelID' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.PriorityLevelIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property PatientID() As Integer
        Get
            Return CType(Me(Me.tabletbCase.PatientIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbCase.PatientIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property DoctorID() As Integer
        Get
            Return CType(Me(Me.tabletbCase.DoctorIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbCase.DoctorIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property PracticeID() As Integer
        Get
            Return CType(Me(Me.tabletbCase.PracticeIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbCase.PracticeIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property TechnicianID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbCase.TechnicianIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'TechnicianID' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.TechnicianIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property ItemTypeID() As Integer
        Get
            Return CType(Me(Me.tabletbCase.ItemTypeIDColumn), Integer)
        End Get
        Set
            Me(Me.tabletbCase.ItemTypeIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property MaterialID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbCase.MaterialIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'MaterialID' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.MaterialIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property ShadeID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbCase.ShadeIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'ShadeID' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.ShadeIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property PaymentStatusID() As Integer
        Get
            Try
                Return CType(Me(Me.tabletbCase.PaymentStatusIDColumn), Integer)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'PaymentStatusID' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.PaymentStatusIDColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property CaseDate() As Date
        Get
            Return CType(Me(Me.tabletbCase.CaseDateColumn), Date)
        End Get
        Set
            Me(Me.tabletbCase.CaseDateColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Deadline() As Date
        Get
            Try
                Return CType(Me(Me.tabletbCase.DeadlineColumn), Date)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'Deadline' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.DeadlineColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property ToothNumber() As String
        Get
            Return CType(Me(Me.tabletbCase.ToothNumberColumn), String)
        End Get
        Set
            Me(Me.tabletbCase.ToothNumberColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Notes() As String
        Get
            Try
                Return CType(Me(Me.tabletbCase.NotesColumn), String)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'Notes' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.NotesColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property Price() As Decimal
        Get
            Try
                Return CType(Me(Me.tabletbCase.PriceColumn), Decimal)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'Price' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.PriceColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Property DeliveryAddress() As String
        Get
            Try
                Return CType(Me(Me.tabletbCase.DeliveryAddressColumn), String)
            Catch e As Global.System.InvalidCastException
                Throw New Global.System.Data.StrongTypingException("The value for column 'DeliveryAddress' in table 'tbCase' is DBNull.", e)
            End Try
        End Get
        Set
            Me(Me.tabletbCase.DeliveryAddressColumn) = Value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsStatusIDNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.StatusIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetStatusIDNull()
        Me(Me.tabletbCase.StatusIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsPriorityLevelIDNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.PriorityLevelIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetPriorityLevelIDNull()
        Me(Me.tabletbCase.PriorityLevelIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsTechnicianIDNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.TechnicianIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetTechnicianIDNull()
        Me(Me.tabletbCase.TechnicianIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsMaterialIDNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.MaterialIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetMaterialIDNull()
        Me(Me.tabletbCase.MaterialIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsShadeIDNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.ShadeIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetShadeIDNull()
        Me(Me.tabletbCase.ShadeIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsPaymentStatusIDNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.PaymentStatusIDColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetPaymentStatusIDNull()
        Me(Me.tabletbCase.PaymentStatusIDColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsDeadlineNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.DeadlineColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetDeadlineNull()
        Me(Me.tabletbCase.DeadlineColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsNotesNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.NotesColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetNotesNull()
        Me(Me.tabletbCase.NotesColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsPriceNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.PriceColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetPriceNull()
        Me(Me.tabletbCase.PriceColumn) = Global.System.Convert.DBNull
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Function IsDeliveryAddressNull() As Boolean
        Return Me.IsNull(Me.tabletbCase.DeliveryAddressColumn)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub SetDeliveryAddressNull()
        Me(Me.tabletbCase.DeliveryAddressColumn) = Global.System.Convert.DBNull
    End Sub
End Class

'''<summary>
'''Row event argument class
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
Public Class tbCaseRowChangeEvent
    Inherits Global.System.EventArgs

    Private eventRow As tbCaseRow

    Private eventAction As Global.System.Data.DataRowAction

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public Sub New(ByVal row As tbCaseRow, ByVal action As Global.System.Data.DataRowAction)
        MyBase.New
        Me.eventRow = row
        Me.eventAction = action
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
    Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")>
    Public ReadOnly Property Row() As tbCaseRow
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
