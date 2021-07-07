<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCToptions1
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
        Me.btnWindows = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWindows
        '
        Me.btnWindows.Location = New System.Drawing.Point(198, 185)
        Me.btnWindows.Name = "btnWindows"
        Me.btnWindows.Size = New System.Drawing.Size(395, 54)
        Me.btnWindows.TabIndex = 0
        Me.btnWindows.Text = "Windows Tools"
        Me.btnWindows.UseVisualStyleBackColor = True
        '
        'frmCToptions1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWindows)
        Me.Name = "frmCToptions1"
        Me.Opacity = 0.88R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CT options"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWindows As Button
End Class
