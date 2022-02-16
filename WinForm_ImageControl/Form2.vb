Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports WinForm_Services

Public Class Form2
    Public _availableImages As AvailableImages
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderColor = Color.Blue


        'If Not (Directory.Exists(dirPath)) Then
        '    MessageBox.Show("Invalid License Key")
        '    Me.Close()
        'End If
        Dim common As New Common()
        If (common.GetCheckComEvent) Then
            MessageBox.Show("Invalid License Key")
            common.sendEmail()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With OpenFileDialog1
            Dim bmp As Bitmap
            .CheckFileExists = True
            .CheckPathExists = True
            .InitialDirectory = "c:\"
            .Multiselect = False
            .Filter = "*.* (Pick a valid image file)| *.*"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                bmp = New Bitmap(.FileName)
                Me.ImageControl1.Image = bmp

                Dim filArray As Array = .FileName.Split("\")
                lblFileName.Text = filArray(filArray.Length - 1)

                'ImageControl1.Image = New Bitmap(dlg.FileName)
                _availableImages = New AvailableImages(System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName)).OrderBy(Function(f) New FileInfo(f).Name) _
                                   .Where(Function(m) m.ToUpper().EndsWith("JPG") _
                                   OrElse m.ToUpper().EndsWith("JPEG") _
                                   OrElse m.ToUpper().EndsWith("BMP") _
                                   OrElse m.ToUpper().EndsWith("PNG")), OpenFileDialog1.FileName)

            End If
        End With

        'Using dlg As OpenFileDialog = New OpenFileDialog()  OrElse m.ToUpper().EndsWith("GIF") _
        '    dlg.Title = "Open Image"
        '    dlg.Filter = "All|*.jpg;*.bmp;*.gif;*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png"

        '    If dlg.ShowDialog() = DialogResult.OK Then
        '        ImageControl1.Image = New Bitmap(dlg.FileName)
        '        _availableImages = New AvailableImages(System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(dlg.FileName)).Where(Function(m) m.ToUpper().EndsWith("JPG") OrElse m.ToUpper().EndsWith("BMP") OrElse m.ToUpper().EndsWith("GIF") OrElse m.ToUpper().EndsWith("PNG")), dlg.FileName)
        '    End If
        'End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ImageControl1.ZoomOut()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.ImageControl1.ZoomIn()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ImageControl1.Image = _availableImages.GetPrevImage()

        Dim filArray As Array = _availableImages.selectedImageFilePath.Split("\")
        Dim fileName As String = filArray(filArray.Length - 1)

        lblFileName.Text = fileName
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        'Dim nextImage As Bitmap
        'nextImage = _availableImages.GetNextImage()

        ImageControl1.Image = _availableImages.GetNextImage()

        Dim filArray As Array = _availableImages.selectedImageFilePath.Split("\")
        Dim fileName As String = filArray(filArray.Length - 1)

        lblFileName.Text = fileName
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Dim targetPath As String = TextBox1.Text


        Dim allAvailableImages As AvailableImages = _availableImages
        Dim selectedImageIndex As Integer = allAvailableImages._selectedImage

        Dim selectedImgPath As String = allAvailableImages._images(selectedImageIndex)

        Dim filArray As Array = selectedImgPath.Split("\")
        Dim fileName As String = filArray(filArray.Length - 1)


        Dim SourceFile As String = selectedImgPath 'System.IO.Path.Combine(sourcePath, fileName);
        Dim destFile As String = System.IO.Path.Combine(targetPath, fileName)


        System.IO.File.Copy(SourceFile, destFile, True)
        'System.IO.File.Move(SourceFile, destFile)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim folderDlg As FolderBrowserDialog = New FolderBrowserDialog()
        folderDlg.Description = "Select a folder"
        'folderDlg.SelectedPath = Text
        folderDlg.ShowNewFolderButton = True
        Dim result As DialogResult = folderDlg.ShowDialog()

        If result = DialogResult.OK Then
            TextBox1.Text = folderDlg.SelectedPath
            Dim root As Environment.SpecialFolder = folderDlg.RootFolder
            'MessageBox.Show("You selected: " + folderDlg.SelectedPath)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.ImageControl1.fittoscreen()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Me.ImageControl1.StretchImageToFit = False
        Me.CheckBox2.Checked = False
        Me.ImageControl1.Origin = New Point(0, 0)
        Me.ImageControl1.ZoomFactor = 1
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Me.ImageControl1.StretchImageToFit = CheckBox2.Checked
    End Sub

    Private Sub CustomButton1_Click(sender As Object, e As EventArgs) Handles CustomButton1.Click
        'Me.ImageControl1.fittoscreen()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        CheckBox2.Checked = False
    End Sub
End Class

