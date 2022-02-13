Imports System.Linq

Public Class Form1
    Public _availableImages As AvailableImages
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillComboBox()
    End Sub

    Private Sub FillComboBox()
        Dim enumType As System.Type = GetType(System.Drawing.RotateFlipType)
        Dim EnumValues As System.Array = System.Enum.GetValues(enumType)
        Dim Enumerator As System.Collections.IEnumerator = EnumValues.GetEnumerator()

        While Enumerator.MoveNext
            ComboBox1.Items.Add(Enumerator.Current)
        End While
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ImageControl1.InvertColors()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ImageControl1.ZoomIn()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ImageControl1.ZoomOut()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ImageControl1.RotateFlip(Me.ComboBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ImageControl1.Image = Nothing
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Me.ImageControl1.StretchImageToFit = CheckBox2.Checked
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ImageControl1.fittoscreen()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

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

                'ImageControl1.Image = New Bitmap(dlg.FileName)
                _availableImages = New AvailableImages(System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName)).Where(Function(m) m.ToUpper().EndsWith("JPG") OrElse m.ToUpper().EndsWith("BMP") OrElse m.ToUpper().EndsWith("GIF") OrElse m.ToUpper().EndsWith("PNG")), OpenFileDialog1.FileName)

            End If
        End With

        'Using dlg As OpenFileDialog = New OpenFileDialog()
        '    dlg.Title = "Open Image"
        '    dlg.Filter = "All|*.jpg;*.bmp;*.gif;*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png"

        '    If dlg.ShowDialog() = DialogResult.OK Then
        '        ImageControl1.Image = New Bitmap(dlg.FileName)
        '        _availableImages = New AvailableImages(System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(dlg.FileName)).Where(Function(m) m.ToUpper().EndsWith("JPG") OrElse m.ToUpper().EndsWith("BMP") OrElse m.ToUpper().EndsWith("GIF") OrElse m.ToUpper().EndsWith("PNG")), dlg.FileName)
        '    End If
        'End Using

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Me.ImageControl1.PanMode = RadioButton1.Checked
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Me.ImageControl1.StretchImageToFit = False
        Me.CheckBox2.Checked = False
        Me.ImageControl1.Origin = New Point(0, 0)
        Me.ImageControl1.ZoomFactor = 1
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'Dim nextImage As Bitmap
        'nextImage = _availableImages.GetNextImage()

        ImageControl1.Image = _availableImages.GetNextImage()

        Dim filArray As Array = _availableImages.selectedImageFilePath.Split("\")
        Dim fileName As String = filArray(filArray.Length - 1)

        lblFileName.Text = fileName
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ImageControl1.Image = _availableImages.GetPrevImage()

        Dim filArray As Array = _availableImages.selectedImageFilePath.Split("\")
        Dim fileName As String = filArray(filArray.Length - 1)

        lblFileName.Text = fileName
    End Sub

    Private Sub btnSelectFolder_Click(sender As Object, e As EventArgs) Handles btnSelectFolder.Click
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
    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click


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

        MessageBox.Show(fileName + "Successfully copied to destination folder")
    End Sub
End Class

Public Class AvailableImages
    Public _images As List(Of String)
    Public _selectedImage As Integer
    Public selectedImageFilePath As String
    Public Sub New(ByVal images As IEnumerable(Of String), ByVal Optional selectedImage As String = Nothing)
        _images = images.ToList()
        _selectedImage = If(selectedImage Is Nothing, 0, _images.IndexOf(selectedImage))
    End Sub

    Public Function GetPrevImage() As Bitmap
        Dim prevImgIndex As Integer
        selectedImageFilePath = ""
        If _selectedImage = 0 Then
            prevImgIndex = CSharpImpl.__Assign(_selectedImage, If((_selectedImage) >= _images.Count, 0, _selectedImage))

        ElseIf _selectedImage = -1 Then
            prevImgIndex = CSharpImpl.__Assign(_selectedImage, If(System.Threading.Interlocked.Increment(_selectedImage) >= _images.Count, 0, _selectedImage))

        Else
            prevImgIndex = CSharpImpl.__Assign(_selectedImage, If(System.Threading.Interlocked.Decrement(_selectedImage) >= _images.Count, 0, _selectedImage))

        End If

        Dim FilePath As String = _images(prevImgIndex)

        Dim filArray As Array = _images(prevImgIndex).Split("\")

        Dim fileName As String = filArray(filArray.Length - 1)

        selectedImageFilePath = FilePath

        Return New Bitmap(_images(prevImgIndex))
    End Function

    Public Function GetNextImage() As Bitmap
        Dim index As Integer
        selectedImageFilePath = String.Empty

        index = CSharpImpl.__Assign(_selectedImage, If(System.Threading.Interlocked.Increment(_selectedImage) >= _images.Count, 0, _selectedImage))
        Dim FilePath As String = _images(index)

        Dim filArray As Array = _images(index).Split("\")

        Dim fileName As String = filArray(filArray.Length - 1)

        selectedImageFilePath = FilePath

        Return New Bitmap(_images(index))
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class

