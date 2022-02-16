<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ImageControl1 = New WinForm_Services.ImageControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CustomButton1 = New WinForm_ImageControl.CustomButton()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ImageControl1
        '
        Me.ImageControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageControl1.Image = Nothing
        Me.ImageControl1.initialimage = Nothing
        Me.ImageControl1.Location = New System.Drawing.Point(5, 48)
        Me.ImageControl1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ImageControl1.Name = "ImageControl1"
        Me.ImageControl1.Origin = New System.Drawing.Point(0, 0)
        Me.ImageControl1.PanButton = System.Windows.Forms.MouseButtons.Left
        Me.ImageControl1.PanMode = True
        Me.ImageControl1.ScrollbarsVisible = True
        Me.ImageControl1.Size = New System.Drawing.Size(925, 415)
        Me.ImageControl1.StretchImageToFit = False
        Me.ImageControl1.TabIndex = 0
        Me.ImageControl1.ZoomFactor = 1.0R
        Me.ImageControl1.ZoomOnMouseWheel = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(15, 590)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Load Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(188, 590)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Zoom Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(315, 590)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 41)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Zoom In"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(15, 544)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Select Destination"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(767, 545)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 35)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Copy "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(205, 548)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(553, 31)
        Me.TextBox1.TabIndex = 7
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(373, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 34)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "<<"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(444, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(61, 34)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = ">>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblFileName
        '
        Me.lblFileName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(254, 498)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(0, 25)
        Me.lblFileName.TabIndex = 10
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.Location = New System.Drawing.Point(188, 640)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(121, 44)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Fit Image"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button9.Location = New System.Drawing.Point(15, 640)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(162, 44)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Actual Pixels"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(317, 649)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(138, 29)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Stretch to Fit"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CustomButton1
        '
        Me.CustomButton1.BackColor = System.Drawing.Color.Maroon
        Me.CustomButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CustomButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomButton1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CustomButton1.ForeColor = System.Drawing.Color.White
        Me.CustomButton1.Location = New System.Drawing.Point(464, 643)
        Me.CustomButton1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.CustomButton1.MinimumSize = New System.Drawing.Size(100, 30)
        Me.CustomButton1.Name = "CustomButton1"
        Me.CustomButton1.Padding = New System.Windows.Forms.Padding(3)
        Me.CustomButton1.Size = New System.Drawing.Size(150, 38)
        Me.CustomButton1.TabIndex = 14
        Me.CustomButton1.Text = "Sample"
        Me.CustomButton1.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(622, 650)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(112, 34)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "Clear"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 754)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.CustomButton1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ImageControl1)
        Me.Name = "Form2"
        Me.Text = "Picture Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageControl1 As WinForm_Services.ImageControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblFileName As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CustomButton1 As CustomButton
    Friend WithEvents Button10 As Button
End Class
