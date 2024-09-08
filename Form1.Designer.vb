<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(323, 11)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 23)
        Button1.TabIndex = 0
        Button1.Text = "Gen URL"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 23)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(400, 400)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 447)
        Button2.Name = "Button2"
        Button2.Size = New Size(400, 23)
        Button2.TabIndex = 3
        Button2.Text = "SAVE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 500)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button

End Class
