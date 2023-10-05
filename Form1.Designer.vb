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
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(287, 208)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Compute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 1
        Label1.Text = "Grade"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(133, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 2
        Label2.Text = "Result"
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(287, 147)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(229, 27)
        TextBox2.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"A", "A-", "B", "C", "D", "E"})
        ComboBox1.Location = New Point(287, 86)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(94, 28)
        ComboBox1.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
