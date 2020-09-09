Public Class frmInfo
    Private Sub cmdRegresar_Click(sender As Object, e As EventArgs) Handles cmdRegresar.Click
        Me.Hide()
        frmEntrada.Show()
    End Sub

    Private Sub cmdFin_Click(sender As Object, e As EventArgs) Handles cmdFin.Click
        Close()
    End Sub
End Class