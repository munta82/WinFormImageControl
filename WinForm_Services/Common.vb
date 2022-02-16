Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class Common

    Private Function GetIPAddress() As String
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        Dim addresses As IPAddress() = Dns.GetHostEntry(strHostName).AddressList
        Dim IPAddresses As String = ""
        For Each address As IPAddress In addresses
            IPAddresses += String.Format("{0} = {1} ({2}) -- ", strHostName, address, address.AddressFamily)
        Next
        Dim strComputerName As String = Environment.MachineName.ToString()
        IPAddresses = IPAddresses & "--" & strComputerName

        Return IPAddresses
    End Function
    Public Function GetCheckComEvent() As Boolean
        Dim dirPath As String = "C:\3SK82-5VK83\3607335770.txt"
        If Not (File.Exists(dirPath)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub sendEmail()
        Try
            Dim msg As MailMessage = New MailMessage()
            msg.From = New MailAddress("vkskproductinfo@gmail.com")
            msg.[To].Add("vkskproductinfo@gmail.com")
            msg.Subject = "Image control is installed on another machine"
            msg.Body = "Image control is installed on another machine  " + GetIPAddress()
            Dim smt As SmtpClient = New SmtpClient()
            smt.Host = "smtp.gmail.com"
            Dim ntcd As System.Net.NetworkCredential = New NetworkCredential()
            smt.UseDefaultCredentials = False
            ntcd.UserName = "vkskproductinfo@gmail.com"
            ntcd.Password = "vksk@123"
            smt.Credentials = ntcd
            'smt.SendAsync(msg, msg.Subject)
            smt.EnableSsl = True
            smt.Port = 587
            smt.Send(msg)
            'MessageBox.Show("Your Mail is sended")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
