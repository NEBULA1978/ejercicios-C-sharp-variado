Public Class frmPrincipal
    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click
        'todo se ejecutara all hacer clic
        MsgBox("Hola y bienvenidos")

    End Sub

    Private Sub btnSaludar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSaludar.MouseMove
        MsgBox("No me toques")
    End Sub
End Class
