Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Security.Principal
Imports System.Text
Imports System.Text.Json

Namespace Eauth
    Class EauthPrimaryClass
        ' Required configuration '
        Private accountKey As String = "" ' Your account key goes here
        Private applicationKey As String = "" ' Your application key goes here
        Private applicationID As String = "" ' Your application ID goes here
        Private applicationVersion As String = "1.0" ' Your application version goes here
        ' Advanced configuration '
        Private invalidAccountKeyMessage As String = "Invalid account key!"
        Private invalidApplicationKeyMessage As String = "Invalid application key!"
        Private invalidRequestMessage As String = "Invalid request!"
        Private outdatedVersionMessage As String = "Outdated version, please upgrade!"
        Private busySessionsMessage As String = "Please try again later!"
        Private unavaiableSessionMessage As String = "Invalid session. Please re-launch the app!"
        Private usedSessionMessage As String = "Why did the computer go to therapy? Because it had a case of 'Request Repeatitis' and couldn't stop asking for the same thing over and over again!"
        Private overcrowdedSessionMessage As String = "Session limit exceeded. Please re-launch the app!"
        Private expiredSessionMessage As String = "Your session has timed out. please re-launch the app!"
        Private invalidUserMessage As String = "Incorrect login credentials!"
        Private bannedHwidMessage As String = "Access denied!"
        Private incorrectHwidMessage As String = "Hardware ID mismatch. Please try again with the correct device!"
        Private expiredUserMessage As String = "Your subscription has ended. Please renew to continue using our service!"
        Private usedNameMessage As String = "Username already taken. Please choose a different username!"
        Private invalidKeyMessage As String = "Invalid key. Please enter a valid key!"
        Private upgradeYourEauthMessage As String = "Upgrade your Eauth plan to exceed the limits!"
        ' Dynamic configuration '
        Private Shared init As Boolean
        Private Shared sessionID As String
        Private Shared appStatus As String
        Public Shared appName As String
        Public Shared loggedMessage As String
        Public Shared registeredMessage As String
        Private Shared login As Boolean
        Public Shared userRank As String
        Public Shared registerDate As String
        Public Shared expireDate As String
        Public Shared userHwid As String
        Private Shared register As Boolean
        Public Shared errorMessage As String
        Private Shared ReadOnly _client As HttpClient = New HttpClient()

        Public Shared Function ComputeSHA512(ByVal input As String) As String
            Using sha512 As SHA512 = SHA512.Create()
                Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
                Dim hashBytes As Byte() = sha512.ComputeHash(inputBytes)
                Dim sb As StringBuilder = New StringBuilder()

                For Each b As Byte In hashBytes
                    sb.Append(b.ToString("x2"))
                Next

                Return sb.ToString()
            End Using
        End Function

        Private Function GenerateAuthToken(ByVal message As String, ByVal appID As String) As String
            Dim timestamp As Long = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
            Dim authToken As String = timestamp.ToString().Substring(0, timestamp.ToString().Length - 2) & message & appID
            Return ComputeSHA512(authToken)
        End Function

        Private Async Function EauthRequest(ByVal data As Dictionary(Of String, String)) As Task(Of String)
            Dim url = "https://eauth.us.to/api/1.1/"
            Dim request = New HttpRequestMessage(HttpMethod.Post, url)
            request.Headers.Add("User-Agent", "e_a_u_t_h")
            Dim content = New FormUrlEncodedContent(data)
            content.Headers.ContentType = New MediaTypeHeaderValue("application/x-www-form-urlencoded")
            request.Content = content
            Dim response = Await _client.SendAsync(request)
            Dim responseContent = Await response.Content.ReadAsStringAsync()
            Dim document As JsonDocument = JsonDocument.Parse(responseContent)
            Dim message As String = document.RootElement.GetProperty("message").GetString()

            If message = "init_success" OrElse message = "login_success" OrElse message = "register_success" OrElse message = "var_grab_success" Then
                Dim authorizationKey As String = response.Headers.GetValues("Authorization").FirstOrDefault()

                If authorizationKey <> GenerateAuthToken(responseContent, applicationID) Then
                    Environment.[Exit](0)
                End If
            End If

            Return responseContent
        End Function

        Private Sub LogEauthError(ByVal message As String)
            errorMessage = message
        End Sub

        Public Function GetHardwareID() As String
            Dim hardwareID As String = String.Empty

            If RuntimeInformation.IsOSPlatform(OSPlatform.Windows) Then
                hardwareID = WindowsIdentity.GetCurrent().User.Value
            ElseIf RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                Dim machineIDFile As String = "/etc/machine-id"

                If File.Exists(machineIDFile) Then
                    hardwareID = File.ReadAllText(machineIDFile).Trim()
                End If
            Else
                Throw New PlatformNotSupportedException()
            End If

            Return hardwareID
        End Function

        Public Async Function InitRequest() As Task(Of Boolean)
            If init Then
                Return init
            End If

            Dim data = New Dictionary(Of String, String) From {
                {"sort", "init"},
                {"appkey", applicationKey},
                {"acckey", accountKey},
                {"version", applicationVersion.ToString()}
            }
            Dim response = Await EauthRequest(data)
            Dim document As JsonDocument = JsonDocument.Parse(response)
            Dim message As String = document.RootElement.GetProperty("message").GetString()

            If message = "init_success" Then
                init = True
                sessionID = document.RootElement.GetProperty("session_id").GetString()
                appStatus = document.RootElement.GetProperty("app_status").GetString()
                appName = document.RootElement.GetProperty("app_name").GetString()
                loggedMessage = document.RootElement.GetProperty("logged_message").GetString()
                registeredMessage = document.RootElement.GetProperty("registered_message").GetString()
            ElseIf message = "invalid_account_key" Then
                LogEauthError(invalidAccountKeyMessage)
            ElseIf message = "invalid_application_key" Then
                LogEauthError(invalidApplicationKeyMessage)
            ElseIf message = "invalid_request" Then
                LogEauthError(invalidRequestMessage)
            ElseIf message = "version_outdated" Then
                Dim download_link As String = document.RootElement.GetProperty("download_link").GetString()
                If download_link <> "" Then
                    Process.Start(download_link)
                End If

                LogEauthError(outdatedVersionMessage)
            ElseIf message = "maximum_sessions_reached" Then
                LogEauthError(busySessionsMessage)
            ElseIf message = "init_paused" Then
                LogEauthError(document.RootElement.GetProperty("paused_message").GetString())
            End If

            Return init
        End Function

        Public Async Function RegisterRequest(ByVal username As String, ByVal password As String, ByVal key As String) As Task(Of Boolean)
            If register OrElse login Then
                LogEauthError(usedSessionMessage)
                Return False
            End If

            Dim data = New Dictionary(Of String, String) From {
                {"sort", "register"},
                {"sessionid", sessionID},
                {"username", username},
                {"password", password},
                {"key", key},
                {"hwid", GetHardwareID()}
            }
            Dim response = Await EauthRequest(data)
            Dim document As JsonDocument = JsonDocument.Parse(response)
            Dim message As String = document.RootElement.GetProperty("message").GetString()

            If message = "register_success" Then
                register = True
            ElseIf message = "session_unavailable" Then
                LogEauthError(unavaiableSessionMessage)
            ElseIf message = "session_already_used" Then
                LogEauthError(usedSessionMessage)
            ElseIf message = "invalid_request" Then
                LogEauthError(invalidRequestMessage)
            ElseIf message = "invalid_account_key" Then
                LogEauthError(invalidAccountKeyMessage)
            ElseIf message = "session_overcrowded" Then
                LogEauthError(overcrowdedSessionMessage)
            ElseIf message = "session_expired" Then
                LogEauthError(expiredSessionMessage)
            ElseIf message = "name_already_used" Then
                LogEauthError(usedNameMessage)
            ElseIf message = "key_unavailable" Then
                LogEauthError(invalidKeyMessage)
            ElseIf message = "maximum_users_reached" Then
                LogEauthError(upgradeYourEauthMessage)
            ElseIf message = "hwid_is_banned" Then
                LogEauthError(bannedHwidMessage)
            End If

            Return register
        End Function

        Public Async Function LoginRequest(ByVal username As String, ByVal password As String, ByVal key As String) As Task(Of Boolean)
            If login Then
                Return login
            End If

            If key.Length > 0 Then
                username = CSharpImpl.__Assign(password, key)
                Dim register_data = New Dictionary(Of String, String) From {
                    {"sort", "register"},
                    {"sessionid", sessionID},
                    {"username", username},
                    {"password", password},
                    {"key", key},
                    {"hwid", GetHardwareID()}
                }
                Dim register_response = Await EauthRequest(register_data)
                Dim register_document As JsonDocument = JsonDocument.Parse(register_response)
                Dim register_message As String = register_document.RootElement.GetProperty("message").GetString()

                If register_message = "register_success" OrElse register_message = "name_already_used" Then
                    login = True
                Else
                    LogEauthError(invalidKeyMessage)
                End If
            End If

            Dim data = New Dictionary(Of String, String) From {
                {"sort", "login"},
                {"sessionid", sessionID},
                {"username", username},
                {"password", password},
                {"hwid", GetHardwareID()}
            }
            Dim response = Await EauthRequest(data)
            Dim document As JsonDocument = JsonDocument.Parse(response)
            Dim message As String = document.RootElement.GetProperty("message").GetString()

            If message = "login_success" Then
                login = True
                userRank = document.RootElement.GetProperty("rank").GetString()
                registerDate = document.RootElement.GetProperty("register_date").GetString()
                expireDate = document.RootElement.GetProperty("expire_date").GetString()
                userHwid = document.RootElement.GetProperty("hwid").GetString()
            ElseIf message = "invalid_account_key" Then
                LogEauthError(invalidAccountKeyMessage)
            ElseIf message = "session_unavailable" Then
                LogEauthError(unavaiableSessionMessage & " " & sessionID & " " & response)
            ElseIf message = "invalid_request" Then
                LogEauthError(invalidRequestMessage)
            ElseIf message = "session_already_used" Then
                LogEauthError(usedSessionMessage)
            ElseIf message = "session_overcrowded" Then
                LogEauthError(overcrowdedSessionMessage)
            ElseIf message = "session_expired" Then
                LogEauthError(expiredSessionMessage)
            ElseIf message = "account_unavailable" Then
                LogEauthError(invalidUserMessage)
            ElseIf message = "hwid_is_banned" Then
                LogEauthError(bannedHwidMessage)
            ElseIf message = "hwid_incorrect" Then
                LogEauthError(incorrectHwidMessage)
            ElseIf message = "subscription_expired" Then
                LogEauthError(expiredUserMessage)
            End If

            Return login
        End Function

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
