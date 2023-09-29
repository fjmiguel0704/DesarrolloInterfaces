Public Class Form1

    Dim persona As New Libreria.NetComun.clsPersona
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TxtSaludar.Click
        If TxtNombre.Text = "" Then
            Label1.Text = "El nombre no puede estar vacío"
        Else
            Label1.Text = ""
            MessageBox.Show("Hola " + TxtNombre.Text)
        End If

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
