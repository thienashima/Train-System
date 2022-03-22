Public Class LandingPage
    Private Sub cmdSignIn_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        LoginForm.Show()
    End Sub

    Private Sub cmdSignUp_Click(sender As Object, e As EventArgs) Handles cmdSignUp.Click
        Registration.Show()

    End Sub
End Class