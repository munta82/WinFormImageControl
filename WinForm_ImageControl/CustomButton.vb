Public Class CustomButton
    Inherits Button

    Private Shared _normalFont As Font = New Font("Arial", 10.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
    Private Shared _back As Color = System.Drawing.Color.Black
    Private Shared _border As Color = System.Drawing.Color.Black
    Private Shared _activeBorder As Color = System.Drawing.Color.Red
    Private Shared _fore As Color = System.Drawing.Color.White
    Private Shared _margin As Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
    Private Shared _padding As Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
    Private Shared _minSize As Size = New System.Drawing.Size(100, 30)
    Private _active As Boolean

    Public Sub New()
        MyBase.New()
        MyBase.Font = _normalFont
        MyBase.BackColor = _border
        MyBase.ForeColor = _fore
        MyBase.FlatAppearance.BorderColor = _back
        MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        MyBase.Margin = _margin
        MyBase.Padding = _padding
        MyBase.MinimumSize = _minSize
    End Sub

    Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
        MyBase.OnControlAdded(e)
        UseVisualStyleBackColor = False
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        If Not _active Then MyBase.FlatAppearance.BorderColor = _activeBorder
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        If Not _active Then MyBase.FlatAppearance.BorderColor = _border
    End Sub

    Public Sub SetStateActive()
        _active = True
        MyBase.FlatAppearance.BorderColor = _activeBorder
    End Sub

    Public Sub SetStateNormal()
        _active = False
        MyBase.FlatAppearance.BorderColor = _border
    End Sub
End Class
