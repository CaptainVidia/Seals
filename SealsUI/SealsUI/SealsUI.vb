'Author: George Tang
'Date: 10-6-2021
Imports System.IO
Imports System.Text
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
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            PictureBox.ImageLocation = OpenFileDialog.FileName
        End If
        OpenFileDialog.FileName = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox.Image.Save(SaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub btnCreateBox_Click(sender As Object, e As EventArgs)

    End Sub
    'Dim opf As New OpenFileDialog
    'opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
    Private Sub uploadCSV_Click(sender As Object, e As EventArgs) Handles uploadCSV.Click
        dataGridView.Rows.Clear()
        'Dim opf As New OpenFileDialog
        'opf.Filter = "Choose( *.csv file)"
        Try
            Dim fname As String = "Detection_Results.csv"
            Dim reader As New StreamReader(fname, Encoding.Default)
            Dim sline As String = ""
            Dim colsexpected As Integer = 10
            Dim r As Integer = 0
            sline = reader.ReadLine
            Do
                sline = reader.ReadLine
                If sline Is Nothing Then Exit Do
                Dim words() As String = sline.Split(",")
                dataGridView.Rows.Add()
                For i As Integer = 0 To 9
                    dataGridView.Rows(r).Cells(i).Value = words(i)
                Next
                r = r + 1
            Loop
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub SealsUI_FormClosing(sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        'verify if user wants to quit
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you wan to quit", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    'store csv into an array
    'draw on picture and do a redo function
End Class
