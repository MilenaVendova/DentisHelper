Imports TrierraSoftDotNET
Public Class frmMain
    Private Sub frmMain_ExecuteCommand(sender As Object, e As KeyEventArgs) Handles Me.ExecuteCommand
        Select Case tsCommand.Text.ToUpper
            Case "CG"
                GS.OpenMDIChild(GetType(frmCodeGenerator))
        End Select
    End Sub
End Class
