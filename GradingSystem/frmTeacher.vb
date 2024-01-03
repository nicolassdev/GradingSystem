Public Class frmTeacher
    Public maxNumber As Integer
    Private idnum As String

    Sub getTeacherID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim teacherID As String
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxNumber = Convert.ToInt32(getmaxTeacherID()) '3
        idnum = maxNumber + 1 '1 + 1 idnum=4
        teacherID = "TEACHER-" & Year & "-" & idnum 'EMP-2023-4
        txtID.Text = teacherID
    End Sub
    Private Sub frmTeacher_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()

    End Sub

    Sub loadgrid()

        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable

            With MyCommand
                .Connection = MyCon
                .CommandText = "Select T_ID as 'Teacher ID', T_FNAME as 'Firstname', T_MNAME as 'Middlename', T_LNAME as'Lastname' FROM teacher order by T_NUM asc"
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            dgTeacher.DataSource = dt
            dgTeacher.RowHeadersVisible = False
            MyCon.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "ADD"
        Button2.Text = "SAVE"
        gbTeacher.Enabled = False
        Button2.Enabled = False
        loadgrid()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True
        getTeacherID()
        gbTeacher.Enabled = True
        txtID.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtFname.Text = "" Or txtMname.Text = "" Or txtLname.Text = "" Then
            MsgBox("ALL FIELDS ARE REQUIRED! ", MessageBoxIcon.Error, "Required")
            Exit Sub
        Else
            Dim queryInsert As String = "INSERT INTO teacher(T_ID, T_FNAME, T_MNAME, T_LNAME ) VALUES('" & txtID.Text & "', '" & Convert.ToString(txtFname.Text).ToUpper & "','" & Convert.ToString(txtMname.Text).ToUpper & "','" & Convert.ToString(txtLname.Text).ToUpper & "');"
            ExecInsertButton(queryInsert)
            MessageBox.Show("Insert Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearText()
            Button1.Enabled = True
            Button2.Enabled = False
            gbTeacher.Enabled = False
            loadgrid()


        End If
    End Sub

    Sub clearText()
        txtID.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""

    End Sub

End Class