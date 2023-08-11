<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class eauthLoginFormUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.backPanel = New System.Windows.Forms.Panel()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.registerInsteadButton = New System.Windows.Forms.Button()
        Me.keyLoginButton = New System.Windows.Forms.Button()
        Me.userPasswordInput = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.userNameInput = New System.Windows.Forms.TextBox()
        Me.backPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'backPanel
        '
        Me.backPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.backPanel.Controls.Add(Me.passwordLabel)
        Me.backPanel.Controls.Add(Me.registerInsteadButton)
        Me.backPanel.Controls.Add(Me.keyLoginButton)
        Me.backPanel.Controls.Add(Me.userPasswordInput)
        Me.backPanel.Controls.Add(Me.loginButton)
        Me.backPanel.Controls.Add(Me.usernameLabel)
        Me.backPanel.Controls.Add(Me.userNameInput)
        Me.backPanel.Location = New System.Drawing.Point(12, 12)
        Me.backPanel.Name = "backPanel"
        Me.backPanel.Size = New System.Drawing.Size(243, 308)
        Me.backPanel.TabIndex = 0
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.passwordLabel.ForeColor = System.Drawing.Color.White
        Me.passwordLabel.Location = New System.Drawing.Point(8, 83)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(63, 14)
        Me.passwordLabel.TabIndex = 8
        Me.passwordLabel.Text = "Password"
        '
        'registerInsteadButton
        '
        Me.registerInsteadButton.BackColor = System.Drawing.Color.Transparent
        Me.registerInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.registerInsteadButton.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.registerInsteadButton.ForeColor = System.Drawing.Color.White
        Me.registerInsteadButton.Location = New System.Drawing.Point(30, 231)
        Me.registerInsteadButton.Name = "registerInsteadButton"
        Me.registerInsteadButton.Size = New System.Drawing.Size(173, 33)
        Me.registerInsteadButton.TabIndex = 7
        Me.registerInsteadButton.Text = "Need an Account"
        Me.registerInsteadButton.UseVisualStyleBackColor = False
        '
        'keyLoginButton
        '
        Me.keyLoginButton.BackColor = System.Drawing.Color.Transparent
        Me.keyLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.keyLoginButton.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.keyLoginButton.ForeColor = System.Drawing.Color.White
        Me.keyLoginButton.Location = New System.Drawing.Point(30, 192)
        Me.keyLoginButton.Name = "keyLoginButton"
        Me.keyLoginButton.Size = New System.Drawing.Size(173, 33)
        Me.keyLoginButton.TabIndex = 6
        Me.keyLoginButton.Text = "Login with Key"
        Me.keyLoginButton.UseVisualStyleBackColor = False
        '
        'userPasswordInput
        '
        Me.userPasswordInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.userPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userPasswordInput.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.userPasswordInput.ForeColor = System.Drawing.Color.White
        Me.userPasswordInput.Location = New System.Drawing.Point(11, 100)
        Me.userPasswordInput.MaxLength = 16
        Me.userPasswordInput.Name = "userPasswordInput"
        Me.userPasswordInput.Size = New System.Drawing.Size(219, 15)
        Me.userPasswordInput.TabIndex = 4
        Me.userPasswordInput.UseSystemPasswordChar = True
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loginButton.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.loginButton.ForeColor = System.Drawing.Color.White
        Me.loginButton.Location = New System.Drawing.Point(30, 153)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(173, 33)
        Me.loginButton.TabIndex = 3
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.usernameLabel.ForeColor = System.Drawing.Color.White
        Me.usernameLabel.Location = New System.Drawing.Point(8, 22)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(63, 14)
        Me.usernameLabel.TabIndex = 2
        Me.usernameLabel.Text = "Username"
        '
        'userNameInput
        '
        Me.userNameInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.userNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userNameInput.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.userNameInput.ForeColor = System.Drawing.Color.White
        Me.userNameInput.Location = New System.Drawing.Point(11, 43)
        Me.userNameInput.MaxLength = 16
        Me.userNameInput.Name = "userNameInput"
        Me.userNameInput.Size = New System.Drawing.Size(219, 15)
        Me.userNameInput.TabIndex = 1
        '
        'eauthLoginFormUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(267, 332)
        Me.Controls.Add(Me.backPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "eauthLoginFormUP"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eauth.us.to"
        Me.backPanel.ResumeLayout(False)
        Me.backPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backPanel As Panel
    Friend WithEvents userNameInput As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents userPasswordInput As TextBox
    Friend WithEvents registerInsteadButton As Button
    Friend WithEvents keyLoginButton As Button
    Friend WithEvents passwordLabel As Label
End Class
