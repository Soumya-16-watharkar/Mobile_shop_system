Imports System.Data.SqlClient

Public Class frmdealeraccessoriestransaction
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




    Private Sub frmdealeraccessoriestransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setActiveButtonOn()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
        Me.Close()
        MDI.Focus()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim q As New dealeraccessories
        q.generateNext()
        setActiveButtonOff()
        Txtdeaid.Text = q.deaid
        txtaccname.Focus()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Txtdeaid.Text = ""
        Txtaccid.Text = ""
        Txtaccquantity.Text = ""
        TextBox1.Text = ""
        Txtaccprice.Text = ""
        txtaccname.Text = ""
        txttotal.Text = ""
        setActiveButtonOn()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Modifydealeraccessories.ShowDialog()
        Txtdeaid.Text = Modifydealeraccessories.deaid
        Txtaccid.Text = Modifydealeraccessories.accid
        Txtaccquantity.Text = Modifydealeraccessories.quantity
        TextBox1.Text = Modifydealeraccessories.accdate
        Txtaccprice.Text = Modifydealeraccessories.price
        txtaccname.Text = Modifydealeraccessories.accname
        txttotal.Text = Modifydealeraccessories.total

        Modifydealeraccessories.Dispose()
        setActiveButtonOff()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim f As Boolean
        Dim q As New dealeraccessories
        If Txtdeaid.Text = "" Or Txtaccid.Text = "" Or Txtaccquantity.Text = "" Or Txtdeaid.Text = "" Or Txtaccprice.Text = "" Or txtaccname.Text = "" Then
            MessageBox.Show("please enter accid, quantity, accdate, price or accname")
        Else
            q.deaid = Convert.ToInt32(Txtaccid.Text)
            q.accid = Convert.ToInt32(Txtaccid.Text)
            q.quantity = Convert.ToInt32(Txtaccquantity.Text)
            q.accdate = Convert.ToDateTime(TextBox1.Text)
            q.price = Convert.ToInt32(Txtaccprice.Text)
            q.accname = txtaccname.Text.ToUpper
            q.total = Convert.ToInt32(txttotal.Text)
            f = q.savedealeraccessories
            f = q.savestock()

            If (f = True) Then
                MessageBox.Show("Record saved successfully")

                btncancel_Click(New System.Object, New System.EventArgs)
            Else
                MessageBox.Show("Record not saved")

            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaccdate.ValueChanged
        TextBox1.Text = txtaccdate.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Modifydealeraccessories.ShowDialog()
        Txtaccid.Text = Modifydealeraccessories.accid
        setActiveButtonOff()

    End Sub

    Private Sub Browseaccname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browseaccname.Click
        Modifyaccessories.ShowDialog()
        txtaccname.Text = Modifyaccessories.accname
        Txtaccid.Text = Modifyaccessories.accid
        setActiveButtonOff()


    End Sub

    Private Sub Browsedeaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browsedeaid.Click
        Modifydealer.ShowDialog()
        Txtdeaid.Text = Modifydealer.deaid
    End Sub
End Class
