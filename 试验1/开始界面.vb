Public Class Form1
    Dim cs1 As Integer = 1
    Private Sub 结束ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 结束ToolStripMenuItem.Click
        End
    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        AboutBox1.Show()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down And cs1 = 1 Then
            PictureBox1.Top = PictureBox1.Top + 35
            cs1 = 0
        End If
        If e.KeyCode = Keys.Up And cs1 = 0 Then
            PictureBox1.Top = PictureBox1.Top - 35
            cs1 = 1
        End If
    End Sub
End Class
