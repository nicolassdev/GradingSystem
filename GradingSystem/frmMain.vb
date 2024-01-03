Public Class frmMain
     
    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        frmStudent.MdiParent = Me
        frmStudent.Show()


    End Sub

    Private Sub GradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradesToolStripMenuItem.Click
        frmGrades.MdiParent = Me
        frmGrades.Show()

    End Sub

    Private Sub TeacherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherToolStripMenuItem.Click
        frmTeacher.MdiParent = Me
        frmTeacher.Show()

    End Sub

    Private Sub SubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsToolStripMenuItem.Click
        frmSubject.MdiParent = Me
        frmSubject.Show()

    End Sub
 
End Class
