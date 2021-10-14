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
        Me.btnDeleteBox = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.btnRadMale = New System.Windows.Forms.RadioButton()
        Me.btnRadFemale = New System.Windows.Forms.RadioButton()
        Me.btnRadPup = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnExit.Location = New System.Drawing.Point(704, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 64)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(32, 37)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(530, 472)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnImport.Location = New System.Drawing.Point(704, 37)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(143, 64)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "Upload"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnDeleteBox
        '
        Me.btnDeleteBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnDeleteBox.Location = New System.Drawing.Point(704, 349)
        Me.btnDeleteBox.Name = "btnDeleteBox"
        Me.btnDeleteBox.Size = New System.Drawing.Size(143, 51)
        Me.btnDeleteBox.TabIndex = 4
        Me.btnDeleteBox.Text = "Delete Box"
        Me.btnDeleteBox.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSave.Location = New System.Drawing.Point(704, 107)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 64)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "save pic|*.jpg"
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.btnRadPup)
        Me.grpBox.Controls.Add(Me.btnRadFemale)
        Me.grpBox.Controls.Add(Me.btnRadMale)
        Me.grpBox.Location = New System.Drawing.Point(704, 190)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(200, 100)
        Me.grpBox.TabIndex = 6
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Choose a Category"
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
        'SealsUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 561)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDeleteBox)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "SealsUI"
        Me.Text = "Seals UI"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents btnImport As Button
    Friend WithEvents btnDeleteBox As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents grpBox As GroupBox
    Friend WithEvents btnRadPup As RadioButton
    Friend WithEvents btnRadFemale As RadioButton
    Friend WithEvents btnRadMale As RadioButton
End Class
