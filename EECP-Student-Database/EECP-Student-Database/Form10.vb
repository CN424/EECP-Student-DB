Imports System.Data.SqlClient

Public Class Form10

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FIRSTNAME As String = TextBox1.Text
        Dim MIDDLENAME As String = TextBox2.Text
        Dim LASTNAME As String = TextBox3.Text
        Dim COURSE As String = ComboBox2.SelectedItem
        Dim YEAR As String = ComboBox1.SelectedItem
        Dim CITY As String = TextBox5.Text
        Dim PROVINCE As String = TextBox6.Text
        Dim NUMBER As String = TextBox4.Text
        Dim query As String = "INSERT INTO ENROLLMENT VALUES (@FIRSTNAME,@MIDDLENAME,@LASTNAME,@COURSE,@YEAR,@CITY,@PROVINCE,@NUMBER)"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-GJFBTMVR\SQLEXPRESS;Initial Catalog=EECP-DB;Integrated Security=True")

            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FIRSTNAME", FIRSTNAME)
                cmd.Parameters.AddWithValue("@MIDDLENAME", MIDDLENAME)
                cmd.Parameters.AddWithValue("@LASTNAME", LASTNAME)
                cmd.Parameters.AddWithValue("@COURSE", COURSE)
                cmd.Parameters.AddWithValue("@YEAR", YEAR)
                cmd.Parameters.AddWithValue("@CITY", CITY)
                cmd.Parameters.AddWithValue("@PROVINCE", PROVINCE)
                cmd.Parameters.AddWithValue("@NUMBER", NUMBER)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                MessageBox.Show("Thank you for registering, please wait for further announcement with regards to your official enrollment")
            End Using
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Panel11_Click(sender As Object, e As EventArgs) Handles Panel11.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs) Handles Panel10.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class