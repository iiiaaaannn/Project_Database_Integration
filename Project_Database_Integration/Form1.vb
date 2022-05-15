Public Class Form1

    'FORM 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    'ADD BUTTON
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If fname.Text = "" Or lname.Text = "" Or course.Text = "" Then
                MessageBox.Show("Incomplete Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                newData("INSERT INTO student (fname, lname, course) VALUES ('" & fname.Text & "', '" & lname.Text & "', '" & course.Text & "')")
                loadtbl()
                clearField()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'UPDATE BUTTON
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            updates("UPDATE student SET fname = '" & fname.Text & "', lname = '" & lname.Text & "', course = '" & course.Text & "' WHERE studid = '" & studid.Text & "'")
            loadtbl()
            clearField()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CLEAR BUTTON
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearField()
    End Sub


    'DELETE BUTTON
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            delete("DELETE FROM student WHERE studid = '" & studid.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        clearField()
        loadtbl()

    End Sub

    'LOAD TABLE BUTTON
    Private Sub loadbtn_Click(sender As Object, e As EventArgs) Handles loadbtn.Click
        loadtbl()
    End Sub

    'DATA GRID VIEW CONTENT CELL CLICK EVENT
    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        studid.Text = dgv1.CurrentRow.Cells(0).Value
        fname.Text = dgv1.CurrentRow.Cells(1).Value
        lname.Text = dgv1.CurrentRow.Cells(2).Value
        course.Text = dgv1.CurrentRow.Cells(3).Value
    End Sub

    'SUB PROCEDURE FOR CLEARING THE FIELDS
    Sub clearField()
        studid.Clear()
        fname.Clear()
        lname.Clear()
        course.Clear()
    End Sub

    'SUB PROCEDURE FOR LOADING THE TABLE
    Sub loadtbl()
        Try
            loadtable("SELECT * FROM student", dgv1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CLOSE BUTTON
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class
