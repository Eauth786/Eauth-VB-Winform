Imports Eauth_VB_Winform.Eauth

Public Class eauthRegisterForm
    Dim eauthClass As New EauthPrimaryClass() '  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable

    Private Async Sub eauthRegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Perform initialization request which is required
        If Not Await eauthClass.InitRequest() Then
            MessageBox.Show(EauthPrimaryClass.errorMessage)
            Environment.Exit(0)
        End If
    End Sub

    Private Sub loginInsteadButton_Click(sender As Object, e As EventArgs) Handles loginInsteadButton.Click
        Dim loginForm As New eauthLoginFormUP()

        Me.Hide()

        loginForm.ShowDialog()

        Me.Close()
    End Sub

    Private Async Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        registerButton.Enabled = False
        If Await eauthClass.RegisterRequest(userNameInput.Text, userPasswordInput.Text, licenseKeyInput.Text) Then
            ' Code block executed if credentials are valid:
            MessageBox.Show(EauthPrimaryClass.registeredMessage)
        Else
            MessageBox.Show(EauthPrimaryClass.errorMessage)
        End If
        registerButton.Enabled = True
    End Sub
End Class