Imports Eauth_VB_Winform.Eauth

Public Class eauthLoginFormLK
    Dim eauthClass As New EauthPrimaryClass() '  Creates a new instance of the "EauthPrimaryClass" class and assigns it to the "eauthClass" variable

    Private Async Sub eauthLoginFormLK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Perform initialization request which is required
        If Not Await eauthClass.InitRequest() Then
            MessageBox.Show(EauthPrimaryClass.errorMessage)
            Environment.Exit(0)
        End If
    End Sub

    Private Async Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        loginButton.Enabled = False
        If Await eauthClass.LoginRequest("", "", licenseKeyInput.Text) Then
            ' Code block executed if credentials are valid:
            MessageBox.Show(EauthPrimaryClass.loggedMessage & vbCrLf & "Rank: " & EauthPrimaryClass.userRank & vbCrLf & "Hardware-ID: " & EauthPrimaryClass.userHwid & vbCrLf & "Register Date: " & EauthPrimaryClass.registerDate & vbCrLf & "Expire Date: " & EauthPrimaryClass.expireDate)
        Else
            MessageBox.Show(EauthPrimaryClass.errorMessage)
        End If
        loginButton.Enabled = True
    End Sub

    Private Sub returnInsteadButton_Click(sender As Object, e As EventArgs) Handles returnInsteadButton.Click
        Dim loginForm As New eauthLoginFormUP()

        Me.Hide()

        loginForm.ShowDialog()

        Me.Close()
    End Sub
End Class