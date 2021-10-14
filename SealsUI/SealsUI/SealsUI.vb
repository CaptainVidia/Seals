'Author: George Tang
'Date: 10-6-2021
Public Class SealsUI
    Dim Draw As Boolean
    Dim DrawColor As Color = Color.Black
    Dim DrawSize As Integer = 6
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'verify if user wants to quit
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to Quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            'verify for exit
            Application.Exit()
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub btnCreateBox_Click(sender As Object, e As EventArgs)
        Dim result As Integer
        result = CheckBox.Show("Male Female Pup", "Choose a Category", CheckBoxRenderer)
    End Sub
    'store csv into an array
    'draw on picture and do a redo function
End Class
