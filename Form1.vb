Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String
        grade = ComboBox1.Text

        grade = Microsoft.VisualBasic.LCase(ComboBox1.Text)
        grade = Microsoft.VisualBasic.UCase(ComboBox1.Text)
        'grade = Trim(TextBox1.Text)
        Select Case grade
            Case "A"
                TextBox2.Text = "High Distinction"
            Case "A-"
                TextBox2.Text = "Distinction"
            Case "B"
                TextBox2.Text = "Credit"
            Case "C"
                TextBox2.Text = "Pass"
            Case Else
                TextBox2.Text = "Fail"
        End Select

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub
End Class
