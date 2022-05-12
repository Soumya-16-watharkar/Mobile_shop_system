Public Class frmlogin

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Hide()
        txtusename.Focus()

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtusename.Text = "1" And txtpass.text = "1" Then
            Timer1.Start()
            ProgressBar1.Show()
        Else
            MessageBox.Show("wrong username and password try again....")
            txtusename.Focus()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtusename.Text = ""
        txtpass.Text = ""
        txtusename.Focus()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
       
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(4)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MDI.Show()
        End If
        Me.Hide()
    End Sub
End Class