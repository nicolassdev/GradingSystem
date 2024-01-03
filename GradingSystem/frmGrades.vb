Imports MySql.Data.MySqlClient

Public Class frmGrades

    Private Sub frmGrades_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()

    End Sub


    Sub loadgrid()

        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable

            With MyCommand
                .Connection = MyCon
                .CommandText = "select  concat(S_FNAME, S_LNAME) as 'Fullname', S_COURSE as 'Course', SUB_NAME as 'Subject',G_PRELIM as 'Prelim', G_MIDTER as 'Midterm', G_SEMI as 'Semi-Final', G_FINAL as 'Final',G_REMARKS as 'Remarks'  from grades inner join student on grades.S_ID = student.S_ID inner join subjects on grades.SUB_ID = subjects.SUB_ID"
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            dgResult.DataSource = dt
            dgResult.RowHeadersVisible = False
            MyCon.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub searchStud(ByVal idnumber)
        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM student WHERE S_ID='" & idnumber & "'"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            If (MySQLData.HasRows = 0) Then
                MsgBox("ID Number not foundxxx.", MsgBoxStyle.Critical, "Error")
                MyCon.Close()
                Exit Sub

            Else

                MySQLData.Read()
                textFname.Text = MySQLData("S_FNAME")  + " " + MySQLData("S_MNAME") + " " + MySQLData("S_LNAME")
             


                MySQLData.Close()
                MyCon.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub searchSub(ByVal idnumbers)
        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM subjects WHERE SUB_ID='" & idnumbers & "'"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            If (MySQLData.HasRows = 0) Then
                MsgBox("ID Number not foundxxx.", MsgBoxStyle.Critical, "Error")
                MyCon.Close()
                Exit Sub

            Else

                MySQLData.Read()
                txtSubName.Text = MySQLData("SUB_NAME")

                MySQLData.Close()
                MyCon.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub fillstudID()

        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM student ORDER BY S_ID ASC"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader

            While (MySQLData.Read())
                cboID.Items.Add(MySQLData("S_ID"))
            End While
            MyCon.Close()
            MySQLData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub fillSubID()

        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM subjects ORDER BY SUB_ID "
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader

            While (MySQLData.Read())
                cboSubID.Items.Add(MySQLData("SUB_ID"))
            End While
            MyCon.Close()
            MySQLData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbGrades.Enabled = False

        cboID.Enabled = True

        fillstudID()

        fillSubID()
        btnCompute.Enabled = False
        btnSave.Enabled = False
        loadgrid()


    End Sub

    'UNLOCK INPUT GRADES IN UI
    Private Sub unlockgbGrades()
        If cboID.Text = "" Or cboSubID.Text = "" Then
            gbGrades.Enabled = False
            btnCompute.Enabled = False
        Else
            gbGrades.Enabled = True
            btnCompute.Enabled = True
        End If
    End Sub
    Private Sub cboID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboID.SelectedIndexChanged
        searchStud(cboID.Text)

        unlockgbGrades()

    End Sub

    'VALIDATION ONLY NUMBER CAN INPUT
   

 
     
    Private Sub cboSubID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubID.SelectedIndexChanged
        searchSub(cboSubID.Text)
        unlockgbGrades()

    End Sub
    Sub clearTxt()
        cboID.Text = ""
        cboSubID.Text = ""
        textFname.Text = ""
        txtSubName.Text = ""
        txtPrelim.Text = ""
        txtMidterm.Text = ""
        txtSemi.Text = ""
        txtFinal.Text = ""
        txtRemarks.Clear()
        txtTotalAverage.Clear()


    End Sub
     
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click


        Dim x As Double = 65
        Dim y As Double = 95

     


        If txtPrelim.Text = "" Or txtMidterm.Text = "" Or txtSemi.Text = "" Or txtFinal.Text = "" Then
            MsgBox("Input Grade", MessageBoxIcon.Exclamation, "Required")
            btnSave.Enabled = False
        ElseIf txtFinal.Text < x Or txtSemi.Text < x Or txtMidterm.Text < x Or txtPrelim.Text < x Then

            MsgBox("Input grade number must be 65 in a above", MessageBoxIcon.Exclamation, "Invalid")


            If txtFinal.Text < x Then
                txtFinal.Clear()
                txtFinal.Focus()
            ElseIf txtSemi.Text < x Then
                txtSemi.Clear()
                txtSemi.Focus()
            ElseIf txtMidterm.Text < x Then
                txtMidterm.Clear()
                txtMidterm.Focus()
            ElseIf txtPrelim.Text < x Then
                txtPrelim.Clear()
                txtPrelim.Focus()

            End If



        ElseIf txtFinal.Text > y Or txtSemi.Text > y Or txtMidterm.Text > y Or txtPrelim.Text > y Then
            MsgBox("Input grade number must be below 95", MessageBoxIcon.Exclamation, "Invalid")

            If txtFinal.Text > y Then
                txtFinal.Clear()
                txtFinal.Focus()
            ElseIf txtSemi.Text > y Then
                txtSemi.Clear()
                txtSemi.Focus()
            ElseIf txtMidterm.Text > y Then
                txtMidterm.Clear()
                txtMidterm.Focus()
            ElseIf txtPrelim.Text > y Then
                txtPrelim.Clear()
                txtPrelim.Focus()

            End If

   


        Else
        btnSave.Enabled = True
        Dim g_prelim As Double
        Dim g_midterm As Double
        Dim g_semi As Double
        Dim g_final As Double
        Dim g_total As Double

        g_final = txtFinal.Text
        g_semi = txtSemi.Text
        g_midterm = txtMidterm.Text
        g_prelim = txtPrelim.Text

        'COMPUTATTION
        g_midterm = g_prelim + txtMidterm.Text
        g_semi = g_midterm + txtSemi.Text
        g_final = g_semi + txtFinal.Text

        'TOTAL AVERAGE
        g_total = g_final / 4
        txtTotalAverage.Text = g_total

        'REMARKS
        Dim remakrs As String = If(g_total >= 75, "PASSED", "FAILED")
            txtRemarks.Text = remakrs
         

        End If
    End Sub

    Private Sub txtPrelim_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrelim.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
        If txtPrelim.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMidterm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMidterm.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
        If txtMidterm.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSemi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSemi.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
        If txtSemi.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFinal.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
        If txtFinal.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub
     
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim queryInsert As String = "INSERT INTO grades(S_ID, SUB_ID, G_PRELIM, G_MIDTER, G_SEMI, G_FINAL, G_REMARKS) VALUES('" & cboID.Text & "','" & cboSubID.Text & "', '" & txtPrelim.Text & "','" & txtMidterm.Text & "','" & txtSemi.Text & "','" & txtFinal.Text & "','" & txtRemarks.Text & "');"
        ExecInsertButton(queryInsert)
        MessageBox.Show("Insert Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        loadgrid()
        clearTxt()
        gbGrades.Enabled = False
        btnSave.Enabled = False
        btnCompute.Enabled = False
    End Sub
 
End Class