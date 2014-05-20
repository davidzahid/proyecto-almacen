Public Class accesoadmin



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (administrador(UsernameTextBox.Text, PasswordTextBox.Text)) Then
            Panel.Show()
            value.Text = 1
            asignar(value.Text)
            Me.Close()


        Else
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        'CON LA SIGUIENTE INSTRUCCIÓN, AL MOMENTO DE PRESIONAR LA TECLA
        'ENTER NOS DIRIGIRA AL BOTON DE ACCEDER'

        If e.KeyCode = Keys.Enter Then
            OK_Click(sender, e)
        End If
    End Sub


End Class
