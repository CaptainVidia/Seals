<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SealsUI
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.btnRadPup = New System.Windows.Forms.RadioButton()
        Me.btnRadFemale = New System.Windows.Forms.RadioButton()
        Me.btnRadMale = New System.Windows.Forms.RadioButton()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        Me.image = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.image_path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xmin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ymin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xmax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ymax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.confidence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.y_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.uploadCSV = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox.SuspendLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnExit.Location = New System.Drawing.Point(674, 596)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(178, 64)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(32, 37)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(557, 472)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(58, 599)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(168, 64)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "Upload Picture"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSave.Location = New System.Drawing.Point(490, 596)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(178, 64)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save Picture"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "save pic|*.jpg"
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.btnRadPup)
        Me.grpBox.Controls.Add(Me.btnRadFemale)
        Me.grpBox.Controls.Add(Me.btnRadMale)
        Me.grpBox.Location = New System.Drawing.Point(927, 599)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(200, 100)
        Me.grpBox.TabIndex = 6
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Choose a Category"
        '
        'btnRadPup
        '
        Me.btnRadPup.AutoSize = True
        Me.btnRadPup.Location = New System.Drawing.Point(23, 65)
        Me.btnRadPup.Name = "btnRadPup"
        Me.btnRadPup.Size = New System.Drawing.Size(44, 17)
        Me.btnRadPup.TabIndex = 2
        Me.btnRadPup.TabStop = True
        Me.btnRadPup.Text = "Pup"
        Me.btnRadPup.UseVisualStyleBackColor = True
        '
        'btnRadFemale
        '
        Me.btnRadFemale.AutoSize = True
        Me.btnRadFemale.Location = New System.Drawing.Point(23, 42)
        Me.btnRadFemale.Name = "btnRadFemale"
        Me.btnRadFemale.Size = New System.Drawing.Size(59, 17)
        Me.btnRadFemale.TabIndex = 1
        Me.btnRadFemale.TabStop = True
        Me.btnRadFemale.Text = "Female"
        Me.btnRadFemale.UseVisualStyleBackColor = True
        '
        'btnRadMale
        '
        Me.btnRadMale.AutoSize = True
        Me.btnRadMale.Location = New System.Drawing.Point(23, 19)
        Me.btnRadMale.Name = "btnRadMale"
        Me.btnRadMale.Size = New System.Drawing.Size(48, 17)
        Me.btnRadMale.TabIndex = 0
        Me.btnRadMale.TabStop = True
        Me.btnRadMale.Text = "Male"
        Me.btnRadMale.UseVisualStyleBackColor = True
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.image, Me.image_path, Me.xmin, Me.ymin, Me.xmax, Me.ymax, Me.label, Me.confidence, Me.x_size, Me.y_size})
        Me.dataGridView.Location = New System.Drawing.Point(595, 37)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.Size = New System.Drawing.Size(1042, 472)
        Me.dataGridView.TabIndex = 7
        '
        'image
        '
        Me.image.HeaderText = "image"
        Me.image.Name = "image"
        '
        'image_path
        '
        Me.image_path.HeaderText = "image_path"
        Me.image_path.Name = "image_path"
        '
        'xmin
        '
        Me.xmin.HeaderText = "xmin"
        Me.xmin.Name = "xmin"
        '
        'ymin
        '
        Me.ymin.HeaderText = "ymin"
        Me.ymin.Name = "ymin"
        '
        'xmax
        '
        Me.xmax.HeaderText = "xmax"
        Me.xmax.Name = "xmax"
        '
        'ymax
        '
        Me.ymax.HeaderText = "ymax"
        Me.ymax.Name = "ymax"
        '
        'label
        '
        Me.label.HeaderText = "label"
        Me.label.Name = "label"
        '
        'confidence
        '
        Me.confidence.HeaderText = "confidence"
        Me.confidence.Name = "confidence"
        '
        'x_size
        '
        Me.x_size.HeaderText = "x_size"
        Me.x_size.Name = "x_size"
        '
        'y_size
        '
        Me.y_size.HeaderText = "y_size"
        Me.y_size.Name = "y_size"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1133, 602)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 64)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Delete Box"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'uploadCSV
        '
        Me.uploadCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadCSV.Location = New System.Drawing.Point(232, 599)
        Me.uploadCSV.Name = "uploadCSV"
        Me.uploadCSV.Size = New System.Drawing.Size(157, 64)
        Me.uploadCSV.TabIndex = 9
        Me.uploadCSV.Text = "Upload CSV"
        Me.uploadCSV.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SealsUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1754, 754)
        Me.Controls.Add(Me.uploadCSV)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "SealsUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seals UI"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents btnImport As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents grpBox As GroupBox
    Friend WithEvents btnRadPup As RadioButton
    Friend WithEvents btnRadFemale As RadioButton
    Friend WithEvents btnRadMale As RadioButton
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents uploadCSV As Button
    Friend WithEvents image As DataGridViewTextBoxColumn
    Friend WithEvents image_path As DataGridViewTextBoxColumn
    Friend WithEvents xmin As DataGridViewTextBoxColumn
    Friend WithEvents ymin As DataGridViewTextBoxColumn
    Friend WithEvents xmax As DataGridViewTextBoxColumn
    Friend WithEvents ymax As DataGridViewTextBoxColumn
    Friend WithEvents label As DataGridViewTextBoxColumn
    Friend WithEvents confidence As DataGridViewTextBoxColumn
    Friend WithEvents x_size As DataGridViewTextBoxColumn
    Friend WithEvents y_size As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
