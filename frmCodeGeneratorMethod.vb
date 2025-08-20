Public Class frmCodeGeneratorMethod
    Public Sub InitForm(tb As dsClassControler.tbControlerMethodDataTable, ClassName As String)
        TbControlerMethodBindingSource.DataSource = tb
        TbControlerMethodBindingSource.Filter = "ClassName = '" & ClassName & "'"
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        DialogResult = DialogResult.OK
    End Sub
End Class