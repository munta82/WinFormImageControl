
Imports System.ComponentModel
Imports System.Configuration.Install
Public Class FormAuth
    'Inherits Form

    Private install As Installer1
    Shared Sub Main()

    End Sub
    Public Sub New(ByVal installer As Installer1)
        InitializeComponent()
        Me.install = installer
    End Sub
    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        If TextBox1.Text <> "12345" Then
            MessageBox.Show("Password incorrect!")
            install.isValid = False
        Else
            install.isValid = True
        End If

        Me.Close()
    End Sub
End Class

<RunInstaller(True)>
Partial Public Class Installer1
    Inherits Installer

    Public isValid As Boolean = False
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
        Throw New NotImplementedException()
    End Sub

    Protected Overrides Sub OnBeforeInstall(ByVal savedState As IDictionary)
        Dim frm As FormAuth = New FormAuth(Me)
        frm.ShowDialog()

        If Me.isValid = False Then
            Throw New Exception("Force to rollback!")
        End If

        MyBase.OnBeforeInstall(savedState)
    End Sub
End Class
