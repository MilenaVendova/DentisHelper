Imports System.IO
Imports System.Text
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
'123
Public Class frmCodeGenerator
    Private _ProjectPath As String
    Private _XMLPath As String
#Region "Properties"
    Public Property ProjectPath As String
        Get
            Return _ProjectPath
        End Get
        Set(value As String)
            _ProjectPath = value
        End Set
    End Property
#End Region

#Region "Methods"
    Private Sub GenerateTableCodeCSharp(dt As DataTable)
        Dim sb As New StringBuilder, sbSetData As New StringBuilder, sbGetData As New StringBuilder
        sb.AppendLine("using Microsoft.Data.SqlClient;")
        sb.AppendLine("using " & My.Application.Info.ProductName & "API.Services;")
        sb.AppendLine("using System.Collections.Generic;")
        sb.AppendLine("using System.Data;")
        sb.AppendLine("using System.Threading.Tasks;")
        sb.AppendLine("using System.Threading;")
        sb.AppendLine("using System;")
        sb.AppendLine("namespace " & My.Application.Info.ProductName & "API.Models")
        sb.AppendLine("{")
        sb.AppendLine("public class " & dt.TableName & "Row")
        sb.AppendLine("{")
        For Each col As DataColumn In dt.Columns
            sb.AppendLine("public " & GetColType(col.DataType, col.AllowDBNull, True) & " " & col.ColumnName & " { get; set; }")
            sbSetData.Append("this." & col.ColumnName & " = ")
            sbGetData.Append("""" & col.ColumnName & """ => ")
            If col.AllowDBNull Then
                sbSetData.Append("(dReader[""" & col.ColumnName & """] != DBNull.Value) ? ")
                If col.DataType.IsValueType Then
                    sbGetData.AppendLine("(this." & col.ColumnName & ".HasValue) ? this." & col.ColumnName & " : DBNull.Value,")
                Else
                    sbGetData.AppendLine("(this." & col.ColumnName & " != null) ? this." & col.ColumnName & " : DBNull.Value,")
                End If
            Else
                If col.DataType.IsValueType Then
                    sbGetData.AppendLine("this." & col.ColumnName & ",")
                Else
                    sbGetData.AppendLine("(this." & col.ColumnName & " != null) ? this." & col.ColumnName & " : DBNull.Value,")
                End If
            End If
            sbSetData.Append("(" & GetColType(col.DataType, False, False) & ")dReader[""" & col.ColumnName & """]")
            If col.AllowDBNull Then
                sbSetData.AppendLine(" : null;")
            Else
                sbSetData.AppendLine(";")
            End If
        Next
        sb.AppendLine("public void SetDataFromSQL(SqlDataReader dReader)")
        sb.AppendLine("{")
        sb.Append(sbSetData.ToString)
        sb.AppendLine("}")
        sb.AppendLine("public object GetData(string Name)")
        sb.AppendLine("{")
        sb.AppendLine("return Name switch")
        sb.AppendLine("{")
        sb.Append(sbGetData.ToString)
        sb.AppendLine("_ => DBNull.Value,")
        sb.AppendLine("};")
        sb.AppendLine("}")
        sb.AppendLine("}")
        'End datarow class

        sb.AppendLine("public class " & dt.TableName & " :  List<" & dt.TableName & "Row>")
        sb.AppendLine("{")
        sb.AppendLine("private readonly MyConnection _Connection;")
        sb.AppendLine("public " & dt.TableName & "(MyConnection mc) : base()")
        sb.AppendLine("{")
        sb.AppendLine("_Connection = mc;")
        sb.AppendLine("}")
        sb.Append(GenerateSelectCommands(dt.TableName))
        sb.Append(GenerateInsertCommand(dt.TableName))
        sb.Append(GenerateUpdateCommand(dt.TableName))
        sb.Append(GenerateDeleteCommand(dt.TableName))
        sb.Append(GenerateSetCommandParameterValue(dt.TableName))
        sb.AppendLine("}")
        sb.AppendLine("}")
        txtCode.Text = sb.ToString
    End Sub

    Private Function GenerateSelectCommands(tbName As String) As String
        Dim sb As New StringBuilder
        Dim ta As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & tbName & "+" & tbName & "TableAdapter"))
        Dim BindingFlags As BindingFlags = BindingFlags.Public + BindingFlags.NonPublic + BindingFlags.Instance
        Dim field As PropertyInfo = ta.GetType().GetProperty("CommandCollection", BindingFlags)
        Dim cmds As SqlCommand() = field.GetValue(ta, Nothing)
        Dim i As Integer
        Dim cmdName As String
        Dim methodName As String
        For Each cmd As SqlCommand In cmds
            cmdName = "SelectCommand"
            methodName = "Fill"
            If i > 0 Then
                cmdName &= i
                methodName &= i
            End If
            If RadioButtonModel.Checked Then
                sb.Append(GenerateCommand(cmd, cmdName, True))
                sb.Append(GenerateFill(cmd, methodName, cmdName, tbName & "Row"))
            ElseIf RadioButtonController.Checked Then
                sb.Append(GenerateControllerCommand(cmd, methodName, tbName, True))
            End If
            i += 1
        Next
        Return sb.ToString
    End Function

    Private Function GenerateCallCommand(cmd As SqlCommand, methodName As String, cmdName As String, TaskType As String) As String
        Dim sb As New StringBuilder, sbFnParam As New StringBuilder, sbCmdParam As New StringBuilder, clrType As String, clrName As String
        For Each p As SqlParameter In cmd.Parameters
            If p.Direction <> ParameterDirection.ReturnValue Then
                If sbFnParam.Length > 0 Then
                    sbFnParam.Append(", ")
                End If
                clrType = GetClrType(p.SqlDbType, True) 'p.IsNullable)
                clrName = p.ParameterName.Substring(1, p.ParameterName.Length - 1)
                sbFnParam.Append(clrType)
                sbFnParam.Append(" " & clrName)
                sbCmdParam.Append(cmdName & ".Parameters[""" & p.ParameterName & """].Value = ")
                If clrType = "string?" Then
                    sbCmdParam.AppendLine("(" & clrName & " is not null) ? " & clrName & " : DBNull.Value;")
                Else
                    sbCmdParam.AppendLine("(" & clrName & ".HasValue) ? " & clrName & " : DBNull.Value;")
                End If
            End If
        Next
        sb.Append("public async Task<" & TaskType & "> " & methodName & "(")
        If sbFnParam.Length > 0 Then
            sb.Append(sbFnParam.ToString & ", ")
        End If
        sb.AppendLine("CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("ConnectionState cs = _Connection.cnn.State;")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.Append(sbCmdParam.ToString)
        Return sb.ToString
    End Function
    Private Function GenerateControllerCommand(cmd As SqlCommand, methodName As String, className As String, table As Boolean) As String
        Dim sb As New StringBuilder,
            sbFnParam As New StringBuilder,
            sbCallParam As New StringBuilder,
            sbCmdParam As New StringBuilder,
            clrType As String,
            clrName As String,
            objName As String,
            i As Integer,
            inputClass As Boolean,
            methodControlerName As String

        If table Then
            objName = "tb"
            methodControlerName = methodName
        Else
            sb.AppendLine("//[Route(""api/[controller]"")]")
            sb.AppendLine("//[ApiController]")
            sb.AppendLine("//[Authorize]")
            sb.AppendLine("//: Controller")
            sb.AppendLine("")
            objName = "cmd"
            methodControlerName = className
            If className.StartsWith("fsp_") OrElse className.StartsWith("rsp_") Then
                methodControlerName = className.Substring(4, className.Length - 4)
            Else
                methodControlerName = className
            End If
        End If

        For Each p As SqlParameter In cmd.Parameters
            If p.Direction <> ParameterDirection.ReturnValue Then
                i += 1
            End If
        Next
        inputClass = (i >= 1)
        If inputClass Then
            If methodControlerName.StartsWith("Fill") Then
                methodControlerName = "FillBy"
                For Each p As SqlParameter In cmd.Parameters
                    If p.Direction <> ParameterDirection.ReturnValue Then
                        methodControlerName &= p.ParameterName.Substring(1, p.ParameterName.Length - 1)
                    End If
                Next
            End If
            sb.Append("public class " & methodControlerName & "Input")
            sb.AppendLine("{")
        End If

        For Each p As SqlParameter In cmd.Parameters
            If p.Direction <> ParameterDirection.ReturnValue Then
                clrType = GetClrType(p.SqlDbType, True)
                clrName = p.ParameterName.Substring(1, p.ParameterName.Length - 1)
                If inputClass Then
                    sb.AppendLine("public " & clrType & " " & clrName & " { get; set; }")
                    sbCallParam.Append("input." & clrName & ", ")
                Else
                    sbFnParam.Append(clrType)
                    sbFnParam.Append(" " & clrName & ", ")
                    sbCallParam.Append(" " & clrName & ", ")
                End If
            End If
        Next

        If inputClass Then
            sb.AppendLine("}")
            sbFnParam.Append(methodControlerName & "Input input, ")
        End If

        sb.AppendLine("[HttpGet]")
        sb.Append("public async Task<IActionResult> " & methodControlerName & "(")
        sb.Append(sbFnParam.ToString)
        sb.AppendLine("CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("MyConnection? mc = ConnectionManager.GetConnection(User!.Identity!.Name!);")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.AppendLine(className & " " & objName & " = new(mc!);")
        If table Then
            sb.AppendLine("await " & objName & "." & methodName & "(" & sbCallParam.ToString & "ct);")
            sb.AppendLine("return Ok(tb);")
        Else
            sb.AppendLine("return Ok(await " & objName & "." & methodName & "(" & sbCallParam.ToString & "ct));")
        End If
        sb.AppendLine("}")
        sb.AppendLine("catch (System.Exception ex)")
        sb.AppendLine("{")
        sb.AppendLine("return BadRequest(Json(ex.Message));")
        sb.AppendLine("}")
        sb.AppendLine("finally")
        sb.AppendLine("{")
        sb.AppendLine("mc?.Release();")
        sb.AppendLine("}")
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateOpenConnection() As String
        Dim sb As New StringBuilder
        sb.AppendLine("if (cs != ConnectionState.Open)")
        sb.AppendLine("{")
        sb.AppendLine("await _Connection.cnn.OpenAsync(ct);")
        sb.Append("}")
        Return sb.ToString
    End Function

    Private Function GenerateCloseConnection() As String
        Dim sb As New StringBuilder
        sb.AppendLine("catch")
        sb.AppendLine("{")
        sb.AppendLine("throw;")
        sb.AppendLine("}")
        sb.AppendLine("finally")
        sb.AppendLine("{")
        sb.AppendLine("if (cs == ConnectionState.Closed)")
        sb.AppendLine("{")
        sb.AppendLine("await _Connection.cnn.CloseAsync();")
        sb.AppendLine("}")
        sb.Append("}")
        Return sb.ToString
    End Function

    Private Function GenerateFill(cmd As SqlCommand, methodName As String, cmdName As String, rowName As String) As String
        Dim sb As New StringBuilder
        sb.Append(GenerateCallCommand(cmd, methodName, cmdName, "int"))
        sb.AppendLine("int i = 0;")
        sb.AppendLine(GenerateOpenConnection)
        sb.AppendLine("SqlDataReader dReader = await " & cmdName & ".ExecuteReaderAsync(ct);")
        sb.AppendLine("while (await dReader.ReadAsync(ct))")
        sb.AppendLine("{")
        sb.AppendLine(rowName & " dr = new " & rowName & "();")
        sb.AppendLine("dr.SetDataFromSQL(dReader);")
        sb.AppendLine("Add(dr);")
        sb.AppendLine("i += 1;")
        sb.AppendLine("}")
        sb.AppendLine("await dReader.CloseAsync();")
        sb.AppendLine("return i;")
        sb.AppendLine("}")
        sb.Append(GenerateCloseConnection)
        sb.AppendLine("}")
        Return sb.ToString
    End Function
    Private Function GenerateCommandTypeScript(cmd As SqlCommand, methodName As String, subMethodName As String) As String
        Dim sb As New StringBuilder, st As String
        If cmd.Parameters.Count > 0 Then
            sb.Append("export Interface I" & methodName)
            If subMethodName IsNot Nothing Then
                sb.Append("_" & subMethodName)
            End If
            sb.AppendLine(" {")
            For Each p As SqlParameter In cmd.Parameters
                If p.Direction <> ParameterDirection.ReturnValue Then
                    sb.Append(p.ParameterName.Substring(1, p.ParameterName.Length - 1))
                    st = GetTypeScriptType(p.SqlDbType)
                    If p.IsNullable OrElse st = "string" Then
                        sb.Append("?")
                    End If
                    sb.Append(": ")
                    sb.Append(st)
                    sb.AppendLine(";")
                End If
            Next
            sb.AppendLine("}")
        End If
        Return sb.ToString
    End Function

    Private Function GenerateExecuteNonQuery(cmd As SqlCommand, cmdName As String) As String
        Dim sb As New StringBuilder
        sb.Append(GenerateCallCommand(cmd, "ExecuteNonQuery", cmdName, "int"))
        sb.AppendLine("int i = 0;")
        sb.AppendLine(GenerateOpenConnection)
        sb.AppendLine("i = await " & cmdName & ".ExecuteNonQueryAsync(ct);")
        sb.AppendLine("return i;")
        sb.AppendLine("}")
        sb.AppendLine(GenerateCloseConnection)
        sb.AppendLine("}")
        Return sb.ToString
    End Function
    Private Function GenerateExecuteScalar(cmd As SqlCommand, cmdName As String, TaskType As String) As String
        Dim sb As New StringBuilder
        sb.Append(GenerateCallCommand(cmd, "ExecuteScalar", cmdName, "object"))
        sb.AppendLine(GenerateOpenConnection)
        sb.AppendLine("object obj = await " & cmdName & ".ExecuteScalarAsync(ct);")
        sb.AppendLine("return obj;")
        sb.AppendLine("}")
        sb.AppendLine(GenerateCloseConnection)
        sb.AppendLine("}")
        Return sb.ToString
    End Function
    Private Function GenerateExecuteReader(cmd As SqlCommand, cmdName As String) As String
        Dim sb As New StringBuilder
        sb.Append(GenerateCallCommand(cmd, "ExecuteReader", cmdName, "SqlDataReader"))
        sb.AppendLine(GenerateOpenConnection)
        sb.AppendLine("return await " & cmdName & ".ExecuteReaderAsync(ct);")
        sb.AppendLine("}")
        sb.AppendLine("catch")
        sb.AppendLine("{")
        sb.AppendLine("throw;")
        sb.AppendLine("}")
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateInsertCommand(tbName As String) As String
        Dim sb As New StringBuilder
        Dim ta As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & tbName & "+" & tbName & "TableAdapter"))
        Dim BindingFlags As BindingFlags = BindingFlags.Public + BindingFlags.NonPublic + BindingFlags.Instance
        Dim field As PropertyInfo = ta.GetType().GetProperty("Adapter", BindingFlags)
        Dim cmd As SqlCommand = field.GetValue(ta, Nothing).InsertCommand
        If cmd IsNot Nothing Then
            If RadioButtonModel.Checked Then
                sb.Append(GenerateCommand(cmd, "InsertCommand", True))
                sb.Append(GenerateExecInsert(tbName))
            Else
                sb.Append(GenerateControllerInsert(tbName))
            End If
            Return sb.ToString
        Else
            Return String.Empty
        End If
    End Function

    Private Function GenerateUpdateCommand(tbName As String) As String
        Dim sb As New StringBuilder
        Dim ta As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & tbName & "+" & tbName & "TableAdapter"))
        Dim BindingFlags As BindingFlags = BindingFlags.Public + BindingFlags.NonPublic + BindingFlags.Instance
        Dim field As PropertyInfo = ta.GetType().GetProperty("Adapter", BindingFlags)
        Dim cmd As SqlCommand = field.GetValue(ta, Nothing).UpdateCommand
        If cmd IsNot Nothing Then
            If RadioButtonModel.Checked Then
                sb.Append(GenerateCommand(cmd, "UpdateCommand", True))
                sb.Append(GenerateExecUpdate(tbName))
            Else
                sb.Append(GenerateControllerUpdate(tbName))
            End If
            Return sb.ToString
        Else
            Return String.Empty
        End If
    End Function

    Private Function GenerateDeleteCommand(tbName As String) As String
        Dim sb As New StringBuilder
        Dim ta As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & tbName & "+" & tbName & "TableAdapter"))
        Dim BindingFlags As BindingFlags = BindingFlags.Public + BindingFlags.NonPublic + BindingFlags.Instance
        Dim field As PropertyInfo = ta.GetType().GetProperty("Adapter", BindingFlags)
        Dim cmd As SqlCommand = field.GetValue(ta, Nothing).DeleteCommand
        If cmd IsNot Nothing Then
            If RadioButtonModel.Checked Then
                sb.Append(GenerateCommand(cmd, "DeleteCommand", True))
                sb.Append(GenerateExecDelete(tbName))
            Else
                sb.Append(GenerateControllerDelete(tbName))
            End If
            Return sb.ToString
        Else
            Return String.Empty
        End If
    End Function
    Private Sub GenerateCommandControllerCSharp(cmdClass As Object, objectName As String)
        Dim cmd As SqlCommand = CType(cmdClass.cmd, SqlCommand)
        If cmd IsNot Nothing Then
            Dim sb As New StringBuilder
            Dim mi As MethodInfo() = cmdClass.GetType().GetMethods
            For Each m As MethodInfo In mi
                If m.Name.ToLower = "executenonquery" OrElse m.Name.ToLower = "executescalar" OrElse m.Name.ToLower = "executereader" Then
                    sb.Append(GenerateControllerCommand(cmd, m.Name, objectName, False))
                    Exit For
                End If
            Next
            txtCode.Text = sb.ToString
        End If
    End Sub
    Private Function GenerateCommand(cmd As SqlCommand, cmdName As String, IsAdapterCommand As Boolean) As String
        Dim sb As New StringBuilder
        sb.AppendLine("private SqlCommand? _" & cmdName & ";")
        sb.AppendLine("private SqlCommand " & cmdName)
        sb.AppendLine("{")
        sb.AppendLine("get")
        sb.AppendLine("{")
        sb.AppendLine("if (_" & cmdName & " is null)")
        sb.AppendLine("{")
        sb.AppendLine("_" & cmdName & " = new SqlCommand();")
        sb.AppendLine("_" & cmdName & ".Connection = _Connection.cnn;")
        sb.AppendLine("_" & cmdName & ".CommandTimeout = ConnectionManager.CommandTimeout;")
        sb.AppendLine("_" & cmdName & ".CommandText = """ & cmd.CommandText & """;")
        sb.AppendLine("_" & cmdName & ".CommandType = CommandType." & cmd.CommandType.ToString & ";")
        For Each p As SqlParameter In cmd.Parameters
            sb.Append("_" & cmdName & ".Parameters.Add(new SqlParameter(")
            sb.Append("""" & p.ParameterName & """, ")
            sb.Append("SqlDbType." & p.SqlDbType.ToString & ", ")
            sb.Append(p.Size.ToString & ", ")
            sb.Append("ParameterDirection." & p.Direction.ToString & ", ")
            If Not IsAdapterCommand Then
                sb.Append(p.IsNullable.ToString.ToLower & ", ")
            End If
            sb.Append(p.Precision.ToString & ", ")
            sb.Append(p.Scale.ToString & ", ")
            sb.Append("""" & p.SourceColumn.ToString & """, ")
            sb.Append("DataRowVersion." & p.SourceVersion.ToString & ", ")
            If IsAdapterCommand Then
                sb.Append(p.SourceColumnNullMapping.ToString.ToLower & ", ")
                sb.AppendLine("null, """", """", """"));")
            Else
                sb.AppendLine("null));")
            End If
        Next
        sb.AppendLine("}")
        sb.AppendLine("return _" & cmdName & ";")
        sb.AppendLine("}")
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateExecInsert(tbName As String) As String
        Dim sb As New StringBuilder
        sb.AppendLine("public async Task<" & tbName & "Row> Insert(" & tbName & "Row drCurrent, CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("ConnectionState cs = _Connection.cnn.State;")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.AppendLine("SetCommandParameterValue(InsertCommand, null, drCurrent);")
        sb.AppendLine(GenerateOpenConnection)
        sb.AppendLine("SqlDataReader dReader = await InsertCommand.ExecuteReaderAsync(ct);")
        sb.AppendLine("while (await dReader.ReadAsync(ct))")
        sb.AppendLine("{")
        sb.AppendLine("drCurrent.SetDataFromSQL(dReader);")
        sb.AppendLine("}")
        sb.AppendLine("await dReader.CloseAsync();")
        sb.AppendLine("return drCurrent;")
        sb.AppendLine("}")
        sb.AppendLine(GenerateCloseConnection)
        sb.AppendLine("}")
        Return sb.ToString
    End Function
    Private Function GenerateControllerInsert(tbName As String) As String
        Dim sb As New StringBuilder
        sb.AppendLine("[HttpPut]")
        sb.AppendLine("public async Task<IActionResult> Insert(" & tbName & "Row drCurrent, CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("MyConnection? mc = ConnectionManager.GetConnection(User!.Identity!.Name!);")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.AppendLine(tbName & " tb = new(mc!);")
        sb.AppendLine("return Ok(await tb.Insert(drCurrent, ct));")
        sb.AppendLine("}")
        sb.AppendLine("catch (System.Exception ex)")
        sb.AppendLine("{")
        sb.AppendLine("return BadRequest(Json(ex.Message));")
        sb.AppendLine("}")
        sb.AppendLine("finally")
        sb.AppendLine("{")
        sb.AppendLine("mc?.Release();")
        sb.AppendLine("}")
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateExecUpdate(tbName As String) As String
        Dim sb As New StringBuilder
        sb.AppendLine("public async Task<" & tbName & "Row> Update(" & tbName & "Row drOriginal, " & tbName & "Row drCurrent, CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("ConnectionState cs = _Connection.cnn.State;")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.AppendLine("SetCommandParameterValue(UpdateCommand, drOriginal, drCurrent);")
        sb.AppendLine(GenerateOpenConnection)
        sb.AppendLine("SqlDataReader dReader = await UpdateCommand.ExecuteReaderAsync(ct);")
        sb.AppendLine("while (await dReader.ReadAsync(ct))")
        sb.AppendLine("{")
        sb.AppendLine("drCurrent.SetDataFromSQL(dReader);")
        sb.AppendLine("}")
        sb.AppendLine("await dReader.CloseAsync();")
        sb.AppendLine("return drCurrent;")
        sb.AppendLine("}")
        sb.AppendLine(GenerateCloseConnection)
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateControllerUpdate(tbName As String) As String
        Dim sb As New StringBuilder
        sb.AppendLine("public class " & tbName & "RowUpdate")
        sb.AppendLine("{")
        sb.AppendLine("public " & tbName & "Row? Original { get; set; }")
        sb.AppendLine("public " & tbName & "Row? Current { get; set; }")
        sb.AppendLine("}")
        sb.AppendLine("[HttpPost]")
        sb.AppendLine("public async Task<IActionResult> Update(" & tbName & "RowUpdate dr, CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("MyConnection? mc = ConnectionManager.GetConnection(User!.Identity!.Name!);")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.AppendLine(tbName & " tb = new(mc!);")
        sb.AppendLine("return Ok(await tb.Update(dr.Original!, dr.Current!, ct));")
        sb.AppendLine("}")
        sb.AppendLine("catch (System.Exception ex)")
        sb.AppendLine("{")
        sb.AppendLine("return BadRequest(Json(ex.Message));")
        sb.AppendLine("}")
        sb.AppendLine("finally")
        sb.AppendLine("{")
        sb.AppendLine("mc?.Release();")
        sb.AppendLine("}")
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateExecDelete(tbName As String) As String
        Dim sb As New StringBuilder
        sb.AppendLine("public async Task<int> Delete(" & tbName & "Row drOriginal, CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("ConnectionState cs = _Connection.cnn.State;")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.AppendLine("SetCommandParameterValue(DeleteCommand, drOriginal, null);")
        sb.AppendLine(GenerateOpenConnection)
        sb.AppendLine("int i = await DeleteCommand.ExecuteNonQueryAsync(ct);")
        sb.AppendLine("return i;")
        sb.AppendLine("}")
        sb.AppendLine(GenerateCloseConnection)
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateControllerDelete(tbName As String) As String
        Dim sb As New StringBuilder
        sb.AppendLine("[HttpDelete]")
        sb.AppendLine("public async Task<IActionResult> Delete(" & tbName & "Row drOriginal, CancellationToken ct)")
        sb.AppendLine("{")
        sb.AppendLine("MyConnection? mc = ConnectionManager.GetConnection(User!.Identity!.Name!);")
        sb.AppendLine("try")
        sb.AppendLine("{")
        sb.AppendLine(tbName & " tb = new(mc!);")
        sb.AppendLine("await tb.Delete(drOriginal, ct);")
        sb.AppendLine("return Ok();")
        sb.AppendLine("}")
        sb.AppendLine("catch (System.Exception ex)")
        sb.AppendLine("{")
        sb.AppendLine("return BadRequest(Json(ex.Message));")
        sb.AppendLine("}")
        sb.AppendLine("finally")
        sb.AppendLine("{")
        sb.AppendLine("mc?.Release();")
        sb.AppendLine("}")
        sb.AppendLine("}")
        Return sb.ToString
    End Function

    Private Function GenerateSetCommandParameterValue(tbName As String)
        Dim sb As New StringBuilder
        sb.AppendLine("private static void SetCommandParameterValue(SqlCommand cmd, " & tbName & "Row? drOriginal, " & tbName & "Row? drCurrent)")
        sb.AppendLine("{")
        sb.AppendLine("foreach (SqlParameter p in cmd.Parameters)")
        sb.AppendLine("{")
        sb.AppendLine("if (!p.SourceColumnNullMapping)")
        sb.AppendLine("{")
        sb.AppendLine("if (p.SourceVersion == DataRowVersion.Original)")
        sb.AppendLine("{")
        sb.AppendLine("p.Value = drOriginal!.GetData(p.SourceColumn);")
        sb.AppendLine("}")
        sb.AppendLine("else")
        sb.AppendLine("{")
        sb.AppendLine("p.Value = drCurrent!.GetData(p.SourceColumn);")
        sb.AppendLine("}")
        sb.AppendLine("}")
        sb.AppendLine("else")
        sb.AppendLine("{")
        sb.AppendLine("p.Value = DBNull.Value;")
        sb.AppendLine("}")
        sb.AppendLine("}")
        sb.AppendLine("}")
        Return sb
    End Function

    Public Function GetClrType(sqlType As SqlDbType, AllowNull As Boolean) As String
        Select Case sqlType
            Case SqlDbType.BigInt
                If AllowNull Then
                    Return "long?"
                Else
                    Return "long"
                End If
            Case SqlDbType.Binary, SqlDbType.Image, SqlDbType.Timestamp, SqlDbType.VarBinary
                Return "byte[]"
            Case SqlDbType.Bit
                If AllowNull Then
                    Return "bool?"
                Else
                    Return "bool"
                End If
            Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NText, SqlDbType.NVarChar, SqlDbType.Text, SqlDbType.VarChar, SqlDbType.Xml
                Return "string?"
            Case SqlDbType.DateTime, SqlDbType.SmallDateTime, SqlDbType.Date, SqlDbType.Time, SqlDbType.DateTime2
                If AllowNull Then
                    Return "DateTime?"
                Else
                    Return "DateTime"
                End If
            Case SqlDbType.Decimal, SqlDbType.Money, SqlDbType.SmallMoney
                If AllowNull Then
                    Return "decimal?"
                Else
                    Return "decimal"
                End If
            Case SqlDbType.Float
                If AllowNull Then
                    Return "double?"
                Else
                    Return "double"
                End If

            Case SqlDbType.Int
                If AllowNull Then
                    Return "int?"
                Else
                    Return "int"
                End If
            Case SqlDbType.Real
                If AllowNull Then
                    Return "float?"
                Else
                    Return "float"
                End If
            Case SqlDbType.UniqueIdentifier
                If AllowNull Then
                    Return "Guid?"
                Else
                    Return "Guid"
                End If
            Case SqlDbType.SmallInt
                If AllowNull Then
                    Return "short?"
                Else
                    Return "short"
                End If
            Case SqlDbType.TinyInt
                If AllowNull Then
                    Return "byte?"
                Else
                    Return "byte"
                End If
            Case SqlDbType.Variant, SqlDbType.Udt
                Return "object"
            Case SqlDbType.Structured
                Return "DataTable"
            Case SqlDbType.DateTimeOffset
                If AllowNull Then
                    Return "DateTimeOffset?"
                Else
                    Return "DateTimeOffset"
                End If
            Case Else
                Throw New ArgumentOutOfRangeException("Unknown sqlType")
        End Select
    End Function

    Public Function GetTypeScriptType(sqlType As SqlDbType) As String
        Select Case sqlType
            Case SqlDbType.Int, SqlDbType.SmallInt, SqlDbType.TinyInt, SqlDbType.BigInt, SqlDbType.Real, SqlDbType.Decimal, SqlDbType.Money, SqlDbType.SmallMoney, SqlDbType.Float
                Return "number"
            Case SqlDbType.Binary, SqlDbType.Image, SqlDbType.Timestamp, SqlDbType.VarBinary
                Return "Blob"
            Case SqlDbType.Bit
                Return "boolean"
            Case SqlDbType.Char, SqlDbType.NChar, SqlDbType.NText, SqlDbType.NVarChar, SqlDbType.Text, SqlDbType.VarChar, SqlDbType.Xml, SqlDbType.UniqueIdentifier
                Return "string"
            Case SqlDbType.DateTime, SqlDbType.SmallDateTime, SqlDbType.Date, SqlDbType.Time, SqlDbType.DateTime2, SqlDbType.DateTimeOffset
                Return "Date"
            Case SqlDbType.Variant, SqlDbType.Udt
                Return "any"
            Case Else
                Throw New ArgumentOutOfRangeException("Unknown sqlType")
        End Select
    End Function

    Private Function GetTypeScriptColType(ColType As Type) As String
        Dim s As String = ColType.Name.ToString.ToLower
        Select Case s
            Case "int16", "int32", "int64", "decimal", "long", "double", "float", "short", "byte"
                s = "number"
            Case "byte()"
                s = "Blob"
            Case "object"
                s = "any"
            Case "guid"
                s = "string"
            Case "datetime"
                s = "Date"
        End Select
        Return s
    End Function
    Private Function GetTypeScriptColValue(ColType As Type) As String
        Dim s As String = ColType.Name.ToString.ToLower
        Select Case s
            Case "int16", "int32", "int64", "decimal", "long", "double", "float", "short", "byte"
                s = "0"
            Case "byte()"
                s = "[]"
            Case "object"
                s = "new object()"
            Case "guid"
                s = "string"
            Case "datetime"
                s = "new Date()"
            Case "boolean"
                s = "false"
            Case "string"
                s = "''"
        End Select
        Return s
    End Function

    Private Function GetColType(ColType As Type, AllowNull As Boolean, bProperty As Boolean)
        Dim s As String = ColType.Name.ToString
        Select Case s
            Case "Int16"
                s = "short"
            Case "Int32"
                s = "int"
            Case "Int64"
                s = "long"
            Case "Boolean"
                s = "bool"
        End Select
        If s <> "DateTime" Then
            s = s.ToLower
        End If
        If AllowNull AndAlso ColType.IsValueType Then
            s &= "?"
        End If
        If bProperty AndAlso s = "string" Then
            s = "string?"
        End If
        Return s
    End Function

    Private Sub GenerateCommandCodeCSharp(cmdClass As Object, objectName As String)

        Dim cmd As SqlCommand = CType(cmdClass.cmd, SqlCommand)
        If cmd IsNot Nothing Then
            Dim sb As New StringBuilder
            sb.AppendLine("using Microsoft.Data.SqlClient;")
            sb.AppendLine("using " & My.Application.Info.ProductName & "API.Services;")
            sb.AppendLine("using System.Collections.Generic;")
            sb.AppendLine("using System.Data;")
            sb.AppendLine("using System.Threading.Tasks;")
            sb.AppendLine("using System.Threading;")
            sb.AppendLine("using System;")
            sb.AppendLine("namespace " & My.Application.Info.ProductName & "API.Models")
            sb.AppendLine("{")
            sb.AppendLine("public class " & objectName)
            sb.AppendLine("{")
            sb.AppendLine("private readonly MyConnection _Connection;")
            sb.AppendLine("public " & objectName & "(MyConnection mc)")
            sb.AppendLine("{")
            sb.AppendLine("_Connection = mc;")
            sb.AppendLine("}")
            For Each p As SqlParameter In cmd.Parameters
                If p.Direction = ParameterDirection.InputOutput OrElse p.Direction = ParameterDirection.Output Then
                    sb.AppendLine("public " & GetClrType(p.SqlDbType, p.IsNullable) & " " & p.ParameterName.Substring(1, p.ParameterName.Length - 1))
                    sb.AppendLine("{")
                    sb.AppendLine("get")
                    sb.AppendLine("{")
                    sb.Append("return ")
                    If p.IsNullable Then
                        sb.AppendLine("(" & objectName & "Command" & ".Parameters[""" & p.ParameterName & """].Value == DBNull.Value) ? null : (" & GetClrType(p.SqlDbType, False) & ")" & objectName & "Command" & ".Parameters[""" & p.ParameterName & """].Value;")
                    Else
                        sb.AppendLine("(" & GetClrType(p.SqlDbType, False) & ")" & objectName & "Command" & ".Parameters[""" & p.ParameterName & """].Value;")
                    End If
                    sb.AppendLine("}")
                    sb.AppendLine("}")
                End If
            Next
            sb.AppendLine(GenerateCommand(cmd, objectName & "Command", False))
            Dim mi As MethodInfo() = cmdClass.GetType().GetMethods
            For Each m As MethodInfo In mi
                If m.Name.ToLower = "executenonquery" Then
                    sb.Append(GenerateExecuteNonQuery(cmd, objectName & "Command"))
                    Exit For
                End If
                If m.Name.ToLower = "executescalar" Then
                    sb.Append(GenerateExecuteScalar(cmd, objectName & "Command", "object"))
                    Exit For
                End If
                If m.Name.ToLower = "executereader" Then
                    sb.Append(GenerateExecuteReader(cmd, objectName & "Command"))
                    Exit For
                End If
            Next
            sb.AppendLine("}")
            sb.AppendLine("}")
            txtCode.Text = sb.ToString
        End If
    End Sub
    Private Sub GenerateTypeScriptInterfaceTable(dt As DataTable)
        Dim sb As New StringBuilder, sbInit As New StringBuilder
        Dim ClassProperties As New Dictionary(Of String, Type)
        Dim sbJson As New StringBuilder
        Dim col As DataColumn

        sbJson.AppendLine("{")
        For Each col In dt.Columns
            sbJson.Append(vbTab & """" & col.ColumnName & """")
            sbJson.Append(": ")
            Select Case col.DataType.Name.ToString.ToLower
                Case "int16", "int32", "int64", "decimal", "long", "double", "float", "short", "byte"
                    sbJson.Append("0")
                Case "byte()"
                    sbJson.Append("[0,0]")
                Case "object"
                    sbJson.Append("{}")
                Case "guid"
                    sbJson.Append("""30F0EF94-B692-431D-9923-2940A54A8458""")
                Case "datetime"
                    sbJson.Append("""2023-09-11T16:47:58.303""")
                Case "boolean"
                    sbJson.Append("false")
                Case Else
                    sbJson.Append("""""")
            End Select
            If col.Ordinal < dt.Columns.Count - 1 Then
                sbJson.Append(",")
            End If
            sbJson.AppendLine()
            ClassProperties.Add(col.ColumnName, col.DataType)
        Next
        sbJson.Append("}" & vbCrLf)

        'Create object from JSON
        Dim CustomClass As Type = CreateClass("Person", ClassProperties)
        Dim ow As Object = JsonConvert.DeserializeObject(sbJson.ToString, CustomClass)
        Dim jss As New JsonSerializerSettings()
        jss.ContractResolver = New CamelCasePropertyNamesContractResolver()
        Dim sJson As String = JsonConvert.SerializeObject(ow, jss)
        sJson = sJson.Substring(1, Len(sJson) - 1)
        sJson = sJson.Replace("""", "")
        Dim sJsonArray As String() = sJson.Split(",")
        Dim JsonName As String
        sb.AppendLine("export interface I" & dt.TableName & "Row {")
        sbInit.AppendLine("/*")
        sbInit.AppendLine("= {")
        For i As Integer = 0 To sJsonArray.Length - 1
            JsonName = sJsonArray(i).Split(":")(0)
            col = dt.Columns(i)
            sb.Append(JsonName)
            sbInit.Append(JsonName)
            If col.AllowDBNull Then
                sb.Append("?")
            End If
            sb.Append(": ")
            sbInit.Append(": ")
            If col.AllowDBNull Then
                sbInit.Append("undefined")
            Else
                sbInit.Append(GetTypeScriptColValue(col.DataType))
            End If
            sb.Append(GetTypeScriptColType(col.DataType))
            sb.AppendLine(";")
            sbInit.AppendLine(",")
        Next
        sb.AppendLine("}")
        sbInit.AppendLine("}")
        sbInit.AppendLine("*/")
        sb.Append(sbInit.ToString)
        txtCode.Text = sb.ToString
    End Sub
    Private Sub GenerateTypeScriptInterfaceCommand(cmdClass As Object, ObjectName As String)
        Dim sb As New StringBuilder
        Dim cmd As SqlCommand = CType(cmdClass.cmd, SqlCommand)
        txtCode.Text = GenerateCommandTypeScript(cmd, ObjectName, Nothing)
    End Sub
    Private Sub GenerateTableControllerCSharp(dt As DataTable)
        Dim sb As New StringBuilder, sbSetData As New StringBuilder, sbGetData As New StringBuilder
        sb.AppendLine("//using Microsoft.AspNetCore.Authorization;")
        sb.AppendLine("//[Route(""api/[controller]"")]")
        sb.AppendLine("//[ApiController]")
        sb.AppendLine("//[Authorize]")
        sb.AppendLine("")
        sb.Append(GenerateSelectCommands(dt.TableName))
        sb.Append(GenerateInsertCommand(dt.TableName))
        sb.Append(GenerateUpdateCommand(dt.TableName))
        sb.Append(GenerateDeleteCommand(dt.TableName))
        txtCode.Text = sb.ToString
    End Sub
    Public Shared Function CreateClass(ByVal className As String, ByVal properties As Dictionary(Of String, Type)) As Type

        Dim myDomain As AppDomain = AppDomain.CurrentDomain
        Dim myAsmName As New AssemblyName("MyAssembly")
        Dim myAssembly As AssemblyBuilder = myDomain.DefineDynamicAssembly(myAsmName, AssemblyBuilderAccess.Run)

        Dim myModule As ModuleBuilder = myAssembly.DefineDynamicModule("MyModule")

        Dim myType As TypeBuilder = myModule.DefineType(className, TypeAttributes.Public)

        myType.DefineDefaultConstructor(MethodAttributes.Public)

        For Each o In properties

            Dim prop As PropertyBuilder = myType.DefineProperty(o.Key, PropertyAttributes.HasDefault, o.Value, Nothing)

            Dim field As FieldBuilder = myType.DefineField("_" + o.Key, o.Value, FieldAttributes.[Private])

            Dim getter As MethodBuilder = myType.DefineMethod("get_" + o.Key, MethodAttributes.[Public] Or MethodAttributes.SpecialName Or MethodAttributes.HideBySig, o.Value, Type.EmptyTypes)
            Dim getterIL As ILGenerator = getter.GetILGenerator()
            getterIL.Emit(OpCodes.Ldarg_0)
            getterIL.Emit(OpCodes.Ldfld, field)
            getterIL.Emit(OpCodes.Ret)

            Dim setter As MethodBuilder = myType.DefineMethod("set_" + o.Key, MethodAttributes.[Public] Or MethodAttributes.SpecialName Or MethodAttributes.HideBySig, Nothing, New Type() {o.Value})
            Dim setterIL As ILGenerator = setter.GetILGenerator()
            setterIL.Emit(OpCodes.Ldarg_0)
            setterIL.Emit(OpCodes.Ldarg_1)
            setterIL.Emit(OpCodes.Stfld, field)
            setterIL.Emit(OpCodes.Ret)

            prop.SetGetMethod(getter)
            prop.SetSetMethod(setter)
        Next
        Return myType.CreateType()
    End Function
    Private Sub GenerateAngularService(dt As DataTable)
        Dim Name As String
        If dt.TableName.StartsWith("tb") Then
            Name = dt.TableName.Substring(2, dt.TableName.Length - 2)
        Else
            Name = dt.TableName
        End If
        Dim s As String = "
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, tap } from 'rxjs';
import { I{0}Row } from '../api/{2}';

const API_URL = environment.apiURL;

@Injectable({
    providedIn: 'root',
})
export class {1}Service {
    constructor(private http: HttpClient) {}

    public {0}?: I{0}Row[];
    public New{1}?: I{0}Row;

    Get{1}(): Observable<I{0}Row[]> {
        return this.http
            .get<I{0}Row[]>(`${API_URL}{1}`, null, {
                withCredentials: true,
            })
            .pipe(tap((response: I{0}Row[]) => (this.{0} = response)));
    }

    Add{1}({1}Row: I{0}Row) {
        return this.http
            .put<I{0}Row>(`${API_URL}{1}`, {1}Row, {
                withCredentials: true,
            })
            .pipe(
                tap((response: I{0}Row) => {
                    this.New{1} = response;
                    this.{0}?.push(response);
                })
            );
    }

    Edit{1}(original: I{0}Row, current: I{0}Row) {
        const data = { original, current };
        return this.http
            .post<I{0}Row>(`${API_URL}{1}`, data, {
                withCredentials: true,
            })
            .pipe(
                tap((response: I{0}Row) => {
                    this.New{1} = response;
                })
            );
    }

    Delete{1}(original: I{0}Row) {
        return this.http.delete<number>(`${API_URL}{1}`, original, {
            withCredentials: true,
        });
    }
}
"
        s = s.Replace("{0}", dt.TableName)
        s = s.Replace("{1}", Name)
        s = s.Replace("{2}", Name.ToLower)
        txtCode.Text &= s
    End Sub
#End Region

#Region "Handles"
    Private Sub frmCodeGenerator_Load(sender As Object, e As EventArgs) Handles Me.Load
        If _ProjectPath Is Nothing Then
            _ProjectPath = Application.StartupPath & "\..\..\DentisHelper.vbproj"
            _XMLPath = Application.StartupPath & "\..\..\dsClassController.xml"
        End If
        Dim reader As New StreamReader(_ProjectPath, Encoding.Default)
        Dim s, sprev, ObjectName, ObjectPath As String
        sprev = ""
        Do
            s = reader.ReadLine
            If Not String.IsNullOrEmpty(s) Then
                If s.Contains("<Compile Include=""DAL\") Then
                    ObjectName = s.Trim.Replace("<Compile Include=""DAL\", "").Replace(".vb"" />", "").Replace(".vb"">", "")
                    If Not ObjectName.StartsWith("Dataset\") Then
                        ObjectPath = "\DAL\" & ObjectName & ".vb"
                        tbObject.Rows.Add(New Object() {ObjectName, ObjectPath})
                    End If
                End If
                If s.Contains("<Link>") Then
                    ObjectName = s.Trim.Replace("<Link>DAL\", "").Replace(".vb</Link>", "")
                    ObjectPath = sprev.Replace("<Compile Include= """, "").Replace(""" > ", "").Trim
                    tbObject.Rows.Add(New Object() {ObjectName, ObjectPath})
                End If
                sprev = s
            End If
        Loop Until s Is Nothing
    End Sub
    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click
        Try

            If lbObjects.SelectedItem IsNot Nothing Then
                Dim ObjectPath, ObjectName As String
                ObjectPath = lbObjects.SelectedValue.ToString
                ObjectName = CType(lbObjects.SelectedItem, DataRowView)("ObjectName").ToString
                If RadioButtonModel.Checked Then
                    If ObjectName.Contains("Table\") Then
                        ObjectName = ObjectName.Remove(0, 6)
                        Dim dt As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & ObjectName))
                        If dt IsNot Nothing AndAlso TypeOf (dt) Is DataTable Then
                            GenerateTableCodeCSharp(CType(dt, DataTable))
                        End If
                    Else
                        ObjectName = ObjectName.Remove(0, 8)
                        Dim cmdClass As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & ObjectName))
                        If cmdClass IsNot Nothing Then
                            GenerateCommandCodeCSharp(cmdClass, ObjectName)
                        End If
                    End If
                ElseIf RadioButtonTypeScript.Checked Then
                    If ObjectName.Contains("Table\") Then
                        ObjectName = ObjectName.Remove(0, 6)
                        Dim dt As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & ObjectName))
                        If dt IsNot Nothing AndAlso TypeOf (dt) Is DataTable Then
                            GenerateTypeScriptInterfaceTable(CType(dt, DataTable))
                            GenerateAngularService(CType(dt, DataTable))
                        End If
                    Else
                        ObjectName = ObjectName.Remove(0, 8)
                        Dim cmdClass As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & ObjectName))
                        If cmdClass IsNot Nothing Then
                            GenerateTypeScriptInterfaceCommand(cmdClass, ObjectName)
                        End If
                    End If
                ElseIf RadioButtonController.Checked Then
                    If ObjectName.Contains("Table\") Then
                        ObjectName = ObjectName.Remove(0, 6)
                        Dim dt As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & ObjectName))
                        If dt IsNot Nothing AndAlso TypeOf (dt) Is DataTable Then
                            GenerateTableControllerCSharp(CType(dt, DataTable))
                        End If
                    Else
                        ObjectName = ObjectName.Remove(0, 8)
                        Dim cmdClass As Object = Activator.CreateInstance(Type.GetType(Application.ProductName & "." & ObjectName))
                        If cmdClass IsNot Nothing Then
                            GenerateCommandControllerCSharp(cmdClass, ObjectName)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        If String.IsNullOrEmpty(txtFilter.Text) Then
            bsObject.Filter = Nothing
        Else
            bsObject.Filter = "ObjectName Like '*" & txtFilter.Text & "*'"
        End If
    End Sub
#End Region

End Class
