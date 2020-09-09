Public Class frmEntrada
    Private Sub cmdVisual_Click(sender As Object, e As EventArgs) Handles cmdVisual.Click
        Me.Hide()
        frmInfo.Show()
    End Sub

    Private Sub cmdTerminar_Click(sender As Object, e As EventArgs) Handles cmdTerminar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        frmInfo.txtInfoOut.Text = frmInfo.txtInfoOut.Text & txtUserin.Text
        frmInfo.txtInfoOut.Text = frmInfo.txtInfoOut.Text & " " & txtContrin.Text & vbNewLine
        frmInfo.txtInfUltima.Text = txtUserin.Text + " " & txtContrin.Text
        txtUserin.Text = ""
        txtContrin.Text = ""
        txtUserin.Focus()
    End Sub
End Class
