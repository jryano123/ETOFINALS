Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Text



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.FileSystem.DeleteFile("C:\Users\Administrator\Desktop\Student Info\Mytest.txt",
Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox11.Text = " "
        TextBox12.Text = " "
        TextBox1.Text = " "
        TextBox2.Text = " "
        ComboBox1.Text = " "
        ComboBox2.Text = " "
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()

    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click

        Dim filePath As String = "C:\Users\Administrator\Desktop\Mytest.txt"
        Dim writer As New System.IO.StreamWriter("C:\Users\Administrator\Desktop\Mytest.txt")
        Dim studentLastName As String = TextBox5.Text ' Replace TextBox1 with the name of your TextBox control
        Dim studentFirstName As String = TextBox6.Text
        Dim studentMiddleName As String = TextBox7.Text
        Dim studentDateofBirth As String = TextBox11.Text
        Dim studentEmailAddress As String = TextBox12.Text
        Dim studentDepartment As String = ComboBox1.Text
        Dim studentCourse As String = ComboBox2.Text
        Dim studentContactNumber As String = TextBox1.Text
        Dim studentContactPerson As String = TextBox2.Text


        writer.WriteLine("StudentName: " & studentLastName & studentFirstName & studentMiddleName)
        writer.WriteLine("Date of Birth: " & studentDateofBirth)
        writer.WriteLine("Email Address: " & studentEmailAddress)
        writer.WriteLine("Department: " & studentDepartment)
        writer.WriteLine("Course: " & studentCourse)
        writer.WriteLine("Contact Number: " & studentContactNumber)
        writer.WriteLine("Contact Person: " & studentContactPerson)
        writer.Close()

        MessageBox.Show("New Student profile Saved to Notepad document.", "New Student Profile, Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Dim path As String = "C:\Users\Administrator\Desktop\Student Info\Mytest.txt"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("StudentName: " & studentLastName & studentFirstName & studentMiddleName & vbCrLf & "Date of Birth: " & studentDateofBirth & vbCrLf &
"Email Address: " & studentEmailAddress & vbCrLf &
"Department: " & studentDepartment & vbCrLf &
"Course: " & studentCourse & vbCrLf &
"Contact Number: " & studentContactNumber & vbCrLf &
"Contact Person: " & studentContactPerson)


        fs.Write(info, 0, info.Length)
            fs.Close()
        End Sub







        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filePath As String = "C:\Users\Administrator\Desktop\VB.txt"
        Dim writer As New System.IO.StreamWriter("C:\Users\Administrator\Desktop\VB.txt")

        Dim studentLastName As String = TextBox5.Text ' Replace TextBox1 with the name of your TextBox control
        Dim studentFirstName As String = TextBox6.Text
        Dim studentMiddleName As String = TextBox7.Text
        Dim studentDateofBirth As String = TextBox11.Text
        Dim studentEmailAddress As String = TextBox12.Text
        Dim studentDepartment As String = ComboBox1.Text
        Dim studentCourse As String = ComboBox2.Text
        Dim studentContactNumber As String = TextBox1.Text
        Dim studentContactPerson As String = TextBox2.Text


        writer.WriteLine("StudentName: " & studentLastName & studentFirstName & studentMiddleName)
        writer.WriteLine("Date of Birth: " & studentDateofBirth)
        writer.WriteLine("Email Address: " & studentEmailAddress)
        writer.WriteLine("Department: " & studentDepartment)
        writer.WriteLine("Course: " & studentCourse)
        writer.WriteLine("Contact Number: " & studentContactNumber)
        writer.WriteLine("Contact Person: " & studentContactPerson)
        writer.Close()

        MessageBox.Show("Student profile updated to Notepad document.", "Profile Updated, Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MessageBox.Show("Student profile has been Saved to Notepad document.", "Student Profile Saved, Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
