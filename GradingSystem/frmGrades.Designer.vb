<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
        Me.txtPrelim = New System.Windows.Forms.TextBox()
        Me.txtMidterm = New System.Windows.Forms.TextBox()
        Me.txtSemi = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbGrades = New System.Windows.Forms.GroupBox()
        Me.txtTotalAverage = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbSubject = New System.Windows.Forms.GroupBox()
        Me.txtSubName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboSubID = New System.Windows.Forms.ComboBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.textFname = New System.Windows.Forms.TextBox()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbStudInfo = New System.Windows.Forms.GroupBox()
        Me.dgResult = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gbGrades.SuspendLayout()
        Me.gbSubject.SuspendLayout()
        Me.gbStudInfo.SuspendLayout()
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPrelim
        '
        Me.txtPrelim.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrelim.Location = New System.Drawing.Point(146, 21)
        Me.txtPrelim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrelim.Name = "txtPrelim"
        Me.txtPrelim.Size = New System.Drawing.Size(37, 29)
        Me.txtPrelim.TabIndex = 0
        '
        'txtMidterm
        '
        Me.txtMidterm.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMidterm.Location = New System.Drawing.Point(146, 55)
        Me.txtMidterm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMidterm.Name = "txtMidterm"
        Me.txtMidterm.Size = New System.Drawing.Size(37, 29)
        Me.txtMidterm.TabIndex = 1
        '
        'txtSemi
        '
        Me.txtSemi.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemi.Location = New System.Drawing.Point(146, 90)
        Me.txtSemi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSemi.Name = "txtSemi"
        Me.txtSemi.Size = New System.Drawing.Size(37, 29)
        Me.txtSemi.TabIndex = 2
        '
        'txtFinal
        '
        Me.txtFinal.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal.Location = New System.Drawing.Point(146, 125)
        Me.txtFinal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(37, 29)
        Me.txtFinal.TabIndex = 3
        '
        'txtRemarks
        '
        Me.txtRemarks.Enabled = False
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(146, 197)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(73, 29)
        Me.txtRemarks.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Prelim Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Midterm Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Semi-final Grade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Final Grade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Remarks"
        '
        'gbGrades
        '
        Me.gbGrades.Controls.Add(Me.txtTotalAverage)
        Me.gbGrades.Controls.Add(Me.Label12)
        Me.gbGrades.Controls.Add(Me.Label5)
        Me.gbGrades.Controls.Add(Me.Label4)
        Me.gbGrades.Controls.Add(Me.Label3)
        Me.gbGrades.Controls.Add(Me.Label2)
        Me.gbGrades.Controls.Add(Me.Label1)
        Me.gbGrades.Controls.Add(Me.txtRemarks)
        Me.gbGrades.Controls.Add(Me.txtFinal)
        Me.gbGrades.Controls.Add(Me.txtSemi)
        Me.gbGrades.Controls.Add(Me.txtMidterm)
        Me.gbGrades.Controls.Add(Me.txtPrelim)
        Me.gbGrades.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGrades.Location = New System.Drawing.Point(40, 173)
        Me.gbGrades.Margin = New System.Windows.Forms.Padding(2)
        Me.gbGrades.Name = "gbGrades"
        Me.gbGrades.Padding = New System.Windows.Forms.Padding(2)
        Me.gbGrades.Size = New System.Drawing.Size(259, 244)
        Me.gbGrades.TabIndex = 11
        Me.gbGrades.TabStop = False
        Me.gbGrades.Text = "Grade"
        '
        'txtTotalAverage
        '
        Me.txtTotalAverage.Enabled = False
        Me.txtTotalAverage.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAverage.Location = New System.Drawing.Point(146, 161)
        Me.txtTotalAverage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalAverage.Name = "txtTotalAverage"
        Me.txtTotalAverage.Size = New System.Drawing.Size(37, 29)
        Me.txtTotalAverage.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 164)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 19)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Total Average"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Blue
        Me.btnSave.Location = New System.Drawing.Point(420, 358)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 41)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 27)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Subject ID"
        '
        'gbSubject
        '
        Me.gbSubject.Controls.Add(Me.txtSubName)
        Me.gbSubject.Controls.Add(Me.Label11)
        Me.gbSubject.Controls.Add(Me.cboSubID)
        Me.gbSubject.Controls.Add(Me.Label10)
        Me.gbSubject.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSubject.Location = New System.Drawing.Point(480, 38)
        Me.gbSubject.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSubject.Name = "gbSubject"
        Me.gbSubject.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSubject.Size = New System.Drawing.Size(367, 126)
        Me.gbSubject.TabIndex = 14
        Me.gbSubject.TabStop = False
        Me.gbSubject.Text = "Subject Info"
        '
        'txtSubName
        '
        Me.txtSubName.Enabled = False
        Me.txtSubName.Location = New System.Drawing.Point(40, 82)
        Me.txtSubName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubName.Multiline = True
        Me.txtSubName.Name = "txtSubName"
        Me.txtSubName.Size = New System.Drawing.Size(267, 29)
        Me.txtSubName.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 57)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 23)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Subject Name"
        '
        'cboSubID
        '
        Me.cboSubID.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubID.FormattingEnabled = True
        Me.cboSubID.Location = New System.Drawing.Point(132, 24)
        Me.cboSubID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSubID.Name = "cboSubID"
        Me.cboSubID.Size = New System.Drawing.Size(157, 27)
        Me.cboSubID.TabIndex = 13
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.Blue
        Me.btnCompute.Location = New System.Drawing.Point(315, 358)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(83, 41)
        Me.btnCompute.TabIndex = 15
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'textFname
        '
        Me.textFname.Enabled = False
        Me.textFname.Location = New System.Drawing.Point(65, 82)
        Me.textFname.Margin = New System.Windows.Forms.Padding(2)
        Me.textFname.Multiline = True
        Me.textFname.Name = "textFname"
        Me.textFname.Size = New System.Drawing.Size(267, 29)
        Me.textFname.TabIndex = 0
        '
        'cboID
        '
        Me.cboID.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(135, 24)
        Me.cboID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(157, 27)
        Me.cboID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Student ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 57)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Full Name"
        '
        'gbStudInfo
        '
        Me.gbStudInfo.Controls.Add(Me.Label7)
        Me.gbStudInfo.Controls.Add(Me.Label6)
        Me.gbStudInfo.Controls.Add(Me.cboID)
        Me.gbStudInfo.Controls.Add(Me.textFname)
        Me.gbStudInfo.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStudInfo.Location = New System.Drawing.Point(43, 38)
        Me.gbStudInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.gbStudInfo.Name = "gbStudInfo"
        Me.gbStudInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.gbStudInfo.Size = New System.Drawing.Size(387, 126)
        Me.gbStudInfo.TabIndex = 10
        Me.gbStudInfo.TabStop = False
        Me.gbStudInfo.Text = "Student Info"
        '
        'dgResult
        '
        Me.dgResult.AllowUserToAddRows = False
        Me.dgResult.AllowUserToDeleteRows = False
        Me.dgResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgResult.Location = New System.Drawing.Point(0, 421)
        Me.dgResult.Margin = New System.Windows.Forms.Padding(2)
        Me.dgResult.Name = "dgResult"
        Me.dgResult.ReadOnly = True
        Me.dgResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResult.Size = New System.Drawing.Size(924, 109)
        Me.dgResult.TabIndex = 16
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Blue
        Me.btnClear.Location = New System.Drawing.Point(523, 358)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 41)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(924, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgResult)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.gbSubject)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbGrades)
        Me.Controls.Add(Me.gbStudInfo)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbGrades.ResumeLayout(False)
        Me.gbGrades.PerformLayout()
        Me.gbSubject.ResumeLayout(False)
        Me.gbSubject.PerformLayout()
        Me.gbStudInfo.ResumeLayout(False)
        Me.gbStudInfo.PerformLayout()
        CType(Me.dgResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPrelim As System.Windows.Forms.TextBox
    Friend WithEvents txtMidterm As System.Windows.Forms.TextBox
    Friend WithEvents txtSemi As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbGrades As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbSubject As System.Windows.Forms.GroupBox
    Friend WithEvents txtSubName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboSubID As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAverage As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents textFname As System.Windows.Forms.TextBox
    Friend WithEvents cboID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbStudInfo As System.Windows.Forms.GroupBox
    Friend WithEvents dgResult As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
