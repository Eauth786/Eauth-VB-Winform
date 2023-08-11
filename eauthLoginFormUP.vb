Imports Eauth_VB_Winform.Eauth

Public Class eauthLoginFormUP
    Dim eauthClass As New EauthPrimaryClass() '  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable

    Private Async Sub eauthLoginFormUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Perform initialization request which is required
        If Not Await eauthClass.InitRequest() Then
            MessageBox.Show(EauthPrimaryClass.errorMessage)
            Environment.Exit(0)
        End If
    End Sub

    Private Async Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        loginButton.Enabled = False
        If Await eauthClass.LoginRequest(userNameInput.Text, userPasswordInput.Text, "") Then
            ' Code block executed if credentials are valid:
            MessageBox.Show(EauthPrimaryClass.loggedMessage & vbCrLf & "Rank: " & EauthPrimaryClass.userRank & vbCrLf & "Hardware-ID: " & EauthPrimaryClass.userHwid & vbCrLf & "Register Date: " & EauthPrimaryClass.registerDate & vbCrLf & "Expire Date: " & EauthPrimaryClass.expireDate)
        Else
            MessageBox.Show(EauthPrimaryClass.errorMessage)
        End If
        loginButton.Enabled = True
    End Sub

    Private Sub keyLoginButton_Click(sender As Object, e As EventArgs) Handles keyLoginButton.Click
        Dim loginForm As New eauthLoginFormLK()

        Me.Hide()

        loginForm.ShowDialog()

        Me.Close()
    End Sub

    Private Sub registerInsteadButton_Click(sender As Object, e As EventArgs) Handles registerInsteadButton.Click
        Dim registerForm As New eauthRegisterForm()

        Me.Hide()

        registerForm.ShowDialog()

        Me.Close()
    End Sub
End Class