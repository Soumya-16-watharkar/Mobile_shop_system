Imports System.Data.SqlClient

Public Class frmaccessoriesdetails

    Private Sub setActiveButtonOn()

        btnNew.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btncancel.Enabled = False
        btnexit.Enabled = True
        groupboxdtls.Enabled = False

    End Sub

    Private Sub setActiveButtonOff()

        btnNew.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btncancel.Enabled = False
        btnexit.Enabled = True
        groupboxdtls.Enabled = True

    End Sub

    Private Sub frmaccessoriesdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setActiveButtonOn()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
        Me.Close()
        MDI.Focus()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim q As New accessories
        q.generateNext()
        setActiveButtonOff()
        Txtaccid.Text = q.accid
        Txtaccname.Focus()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Txtaccid.Text = ""
        Txtaccname.Text = ""
        Txtaccprice.Text = ""
        Txtaccwaranty.Text = ""
        setActiveButtonOn()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Modifyaccessories.ShowDialog()
        Txtaccid.Text = Modifyaccessories.accid
        Txtaccname.Text = Modifyaccessories.accname
        Txtaccprice.Text = Modifyaccessories.price
        Txtaccwaranty.Text = Modifyaccessories.waranty

        Modifyaccessories.Dispose()
        setActiveButtonOff()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim f As Boolean
        Dim q As New accessories
        If Txtaccid.Text = "" Or Txtaccname.Text = "" Or Txtaccprice.Text = "" Or Txtaccwaranty.Text = "" Then
            MessageBox.Show("please enter accname, price or waranty")
        Else
            q.accid = Convert.ToInt32(Txtaccid.Text)
            q.accname = Txtaccname.Text.ToUpper
            q.price = Convert.ToInt32(Txtaccprice.Text)
            q.waranty = Txtaccwaranty.Text.ToUpper


            f = q.saveaccessories()
            If (f = True) Then
                MessageBox.Show("Record saved successfully")

                btncancel_Click(New System.Object, New System.EventArgs)
            Else
                MessageBox.Show("Record not saved")

            End If
        End If
    End Sub
End Class