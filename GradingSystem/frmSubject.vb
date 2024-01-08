Imports MySql.Data.MySqlClient

Public Class frmSubject

    Public maxNumber As Integer
    Private idnum As String
    'GENERETA SUBJECT ID
    Sub getSubID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim subID As String
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxNumber = Convert.ToInt32(getmaxSubID()) '3
        idnum = maxNumber + 1 '1 + 1 idnum=4
        subID = "SUB-" & Year & "-" & idnum 'EMP-2023-4
        txtID.Text = subID
    End Sub

    Sub fillTeacherID()

        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM teacher ORDER BY T_ID"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader

            While (MySQLData.Read())
                cboTeacherID.Items.Add(MySQLData("T_ID"))
            End While
            MyCon.Close()
            MySQLData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub loadgrid()

        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable

            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT * FROM subjects ORDER BY SUB_ID LIMIT 5"
                .CommandText = "Select SUB_ID as 'SUBJECT ID', T_ID , T_NAME as 'TEACHER NAME', SUB_NAME as 'SUBJECT TITLE ', SUB_UNIT as 'UNIT', SUB_SYEAR as 'SCHOOL YEAR', SUB_TYPE as 'SUBJECT TYPE' FROM subjects order by SUB_NUM asc "
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            dgSubject.DataSource = dt
            dgSubject.RowHeadersVisible = False
            MyCon.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmSubject_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()

    End Sub



    Private Sub frmSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        btnCancel.Enabled = False
        gbSubjects.Enabled = False
        fillTeacherID()
        txtTeacher.Enabled = False
        loadgrid()

        Me.dgSubject.Columns(1).Visible = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnEdit.Enabled = False
        getSubID()
        dgSubject.Enabled = False
        btnAdd.Enabled = False
        gbSubjects.Enabled = True
    End Sub

    

   
    Private Sub cboTeacherID_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTeacherID.SelectionChangeCommitted
        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM teacher WHERE T_ID='" & cboTeacherID.Text & "'"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            If MySQLData.HasRows Then

                MySQLData.Read()
                txtTeacher.Text = MySQLData("T_FNAME") + " " + MySQLData("T_MNAME") + " " + MySQLData("T_LNAME")
            End If
            MySQLData.Close()
            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cboTeacherID.Text = "" Or txtTeacher.Text = "" Or txtSubName.Text = "" Or txtUnit.Text = "" Or txtYear.Text = "" Or cboType.Text = "" Then
            MsgBox("ALL FIELDS ARE REQUIRED", MessageBoxIcon.Error, " Required")
            Exit Sub


        End If
        If btnSave.Text = "UPDATE" Then

            Dim queryUpdateItem As String = "UPDATE subjects SET T_ID = '" & cboTeacherID.Text & "', SUB_NAME = '" & txtSubName.Text & "',SUB_UNIT = '" & txtUnit.Text & "', SUB_SYEAR = '" & txtYear.Text & "', SUB_TYPE = '" & cboType.Text & "' WHERE SUB_ID = '" & txtID.Text & "';"
            ExecInsertButton(queryUpdateItem)
            MessageBox.Show("Update Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearText()
            loadgrid()
            btnSave.Text = "SAVE"
            btnAdd.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            gbSubjects.Enabled = False
        Else

            Dim queryInsert As String = "INSERT INTO subjects(SUB_ID, T_ID, T_NAME, SUB_NAME, SUB_UNIT, SUB_SYEAR, SUB_TYPE) VALUES('" & txtID.Text & "', '" & Convert.ToString(cboTeacherID.Text).ToUpper & "','" & Convert.ToString(txtTeacher.Text).ToUpper & "','" & Convert.ToString(txtSubName.Text).ToUpper & "','" & Convert.ToString(txtUnit.Text).ToUpper & "','" & Convert.ToString(txtYear.Text).ToUpper & "','" & Convert.ToString(cboType.Text).ToUpper & "');"
            ExecInsertButton(queryInsert)
            MessageBox.Show("Insert Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearText()
            loadgrid()
            btnAdd.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            gbSubjects.Enabled = False

        End If
    End Sub
    Sub clearText()
        txtID.Text = ""
        cboTeacherID.Text = Nothing
        txtTeacher.Text = ""
        txtSubName.Text = ""
        txtUnit.Text = ""
        txtYear.Text = ""
        cboType.Text = Nothing
    End Sub

    Private Sub dgSubject_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubject.CellClick
        btnAdd.Enabled = False
        btnCancel.Enabled = True
        On Error Resume Next
        Dim i As Integer
        i = dgSubject.CurrentRow.Index
        Me.txtID.Text = dgSubject.Item(0, i).Value
        Me.cboTeacherID.Text = dgSubject.Item(1, i).Value
        Me.txtTeacher.Text = dgSubject.Item(2, i).Value
        Me.txtSubName.Text = dgSubject.Item(3, i).Value
        Me.txtUnit.Text = dgSubject.Item(4, i).Value
        Me.txtYear.Text = dgSubject.Item(5, i).Value
        Me.cboType.Text = dgSubject.Item(6, i).Value
         
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtID.Text = "" Then
            MsgBox("Select ID from subject", MessageBoxIcon.Warning, "Required")
            Exit Sub
        Else
            txtID.Enabled = False
            btnSave.Text = "UPDATE"
            btnSave.Enabled = True
            gbSubjects.Enabled = True
            btnAdd.Enabled = False
            btnEdit.Enabled = False

        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        gbSubjects.Enabled = False
        clearText()
        btnSave.Text = "SAVE"
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        dgSubject.Enabled = True
    End Sub
End Class