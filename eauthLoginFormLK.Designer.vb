<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eauthLoginFormLK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.backPanel = New System.Windows.Forms.Panel()
        Me.licenseKeyLabel = New System.Windows.Forms.Label()
        Me.returnInsteadButton = New System.Windows.Forms.Button()
        Me.licenseKeyInput = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.backPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'backPanel
        '
        Me.backPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.backPanel.Controls.Add(Me.licenseKeyLabel)
        Me.backPanel.Controls.Add(Me.returnInsteadButton)
        Me.backPanel.Controls.Add(Me.licenseKeyInput)
        Me.backPanel.Controls.Add(Me.loginButton)
        Me.backPanel.Location = New System.Drawing.Point(12, 12)
        Me.backPanel.Name = "backPanel"
        Me.backPanel.Size = New System.Drawing.Size(243, 203)
        Me.backPanel.TabIndex = 0
        '
        'licenseKeyLabel
        '
        Me.licenseKeyLabel.AutoSize = True
        Me.licenseKeyLabel.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.licenseKeyLabel.ForeColor = System.Drawing.Color.White
        Me.licenseKeyLabel.Location = New System.Drawing.Point(8, 48)
        Me.licenseKeyLabel.Name = "licenseKeyLabel"
        Me.licenseKeyLabel.Size = New System.Drawing.Size(84, 14)
        Me.licenseKeyLabel.TabIndex = 8
        Me.licenseKeyLabel.Text = "License Key"
        '
        'returnInsteadButton
        '
        Me.returnInsteadButton.BackColor = System.Drawing.Color.Transparent
        Me.returnInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.returnInsteadButton.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.returnInsteadButton.ForeColor = System.Drawing.Color.White
        Me.returnInsteadButton.Location = New System.Drawing.Point(31, 145)
        Me.returnInsteadButton.Name = "returnInsteadButton"
        Me.returnInsteadButton.Size = New System.Drawing.Size(173, 33)
        Me.returnInsteadButton.TabIndex = 6
        Me.returnInsteadButton.Text = "Return Instead"
        Me.returnInsteadButton.UseVisualStyleBackColor = False
        '
        'licenseKeyInput
        '
        Me.licenseKeyInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.licenseKeyInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.licenseKeyInput.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.licenseKeyInput.ForeColor = System.Drawing.Color.White
        Me.licenseKeyInput.Location = New System.Drawing.Point(11, 65)
        Me.licenseKeyInput.MaxLength = 16
        Me.licenseKeyInput.Name = "licenseKeyInput"
        Me.licenseKeyInput.Size = New System.Drawing.Size(219, 15)
        Me.licenseKeyInput.TabIndex = 4
        Me.licenseKeyInput.UseSystemPasswordChar = True
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loginButton.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.loginButton.ForeColor = System.Drawing.Color.White
        Me.loginButton.Location = New System.Drawing.Point(31, 106)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(173, 33)
        Me.loginButton.TabIndex = 3
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'eauthLoginFormLK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(267, 227)
        Me.Controls.Add(Me.backPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "eauthLoginFormLK"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eauth.us.to"
        Me.backPanel.ResumeLayout(False)
        Me.backPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backPanel As Panel
    Friend WithEvents loginButton As Button
    Friend WithEvents licenseKeyInput As TextBox
    Friend WithEvents returnInsteadButton As Button
    Friend WithEvents licenseKeyLabel As Label
End Class
