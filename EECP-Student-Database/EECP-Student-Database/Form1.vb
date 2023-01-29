
Public Class Form1

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

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Form10.Show()
        Me.Hide()
    End Sub

End Class
