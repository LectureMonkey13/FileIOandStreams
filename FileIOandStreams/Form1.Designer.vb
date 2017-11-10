<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdTestFileIO = New System.Windows.Forms.Button()
        Me.cmdTestStreams = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 199)
        Me.TextBox1.TabIndex = 0
        '
        'cmdTestFileIO
        '
        Me.cmdTestFileIO.Location = New System.Drawing.Point(13, 226)
        Me.cmdTestFileIO.Name = "cmdTestFileIO"
        Me.cmdTestFileIO.Size = New System.Drawing.Size(75, 23)
        Me.cmdTestFileIO.TabIndex = 1
        Me.cmdTestFileIO.Text = "Test File I/O"
        Me.cmdTestFileIO.UseVisualStyleBackColor = True
        '
        'cmdTestStreams
        '
        Me.cmdTestStreams.Location = New System.Drawing.Point(95, 226)
        Me.cmdTestStreams.Name = "cmdTestStreams"
        Me.cmdTestStreams.Size = New System.Drawing.Size(81, 23)
        Me.cmdTestStreams.TabIndex = 2
        Me.cmdTestStreams.Text = "Test Streams"
        Me.cmdTestStreams.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.Location = New System.Drawing.Point(197, 226)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuit.TabIndex = 3
        Me.cmdQuit.Text = "Quit"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdTestStreams)
        Me.Controls.Add(Me.cmdTestFileIO)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmdTestFileIO As Button
    Friend WithEvents cmdTestStreams As Button
    Friend WithEvents cmdQuit As Button
End Class
