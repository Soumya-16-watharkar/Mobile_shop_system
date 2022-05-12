
Imports System.Data.SqlClient

Public Class frmcustomerdetails

    Private Sub setActiveButtonOn()

        btnNew.Enabled = True
        btnsave.Enabled = False
        btnupdate.Enabled = True
        btncancel.Enabled = False
        btnexit.Enabled = True
        grboxdtls.Enabled = False

    End Sub




    Private Sub setActiveButtonOff()

        btnNew.Enabled = False
        btnsave.Enabled = True
        btnupdate.Enabled = False
        btncancel.Enabled = False
        btnexit.Enabled = True
        grboxdtls.Enabled = True

    End Sub


    Private Sub frmcustomerdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setActiveButtonOn()

    End Sub


    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Hide()
        Me.Close()
        MDI.Focus()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim q As New customer1
        q.GenerateNext()
        setActiveButtonOff()
        Txtcustid.Text = q.custid
        Txtcustname.Focus()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Txtcustid.Text = ""
        txtcustname.Text = ""
        txtaddress.Text = ""
        Txtphoneno.Text = ""
        Txtemail.Text = ""
        txtbirthdate.Text = ""
        RadioButton1.Text = ""
        RadioButton2.Text = ""
        setActiveButtonOn()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        modifycustomer.ShowDialog()
        Txtcustid.Text = modifycustomer.custid
        txtcustname.Text = modifycustomer.custname
        Txtaddress.Text = modifycustomer.address
        Txtphoneno.Text = Modifycustomer.phoneno
        txtbirthdate.Text = modifycustomer.birthdate
        Txtemail.Text = modifycustomer.email
        If modifycustomer.Gender = "male" Then
            RadioButton1.Checked = True
        ElseIf modifycustomer.Gender = "female" Then
            RadioButton2.Checked = True
        End If

        modifycustomer.Dispose()
        setActiveButtonOff()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim f As Boolean
        Dim q As New customer1
        If txtcustname.Text = "" Or Txtaddress.Text = "" Or Txtphoneno.Text = "" Or Txtemail.Text = "" Or TextBox1.Text = "" Then 'Or txtGendermale.Checked Or txtGenderfemale.Checked Then
            MessageBox.Show("please enter custname, address, phoneno, email, birthdate or Gender")
        Else
            q.custid = Convert.ToInt32(Txtcustid.Text)
            q.custname = txtcustname.Text.ToUpper
            q.address = Txtaddress.Text.ToUpper
            q.phoneno = Txtphoneno.Text.ToUpper
            q.email = Txtemail.Text.ToUpper
            q.birthdate = Convert.ToDateTime(TextBox1.Text)
            q.Gender = RadioButton2.Text.ToUpper
            q.Gender = RadioButton1.Text.ToUpper
            If RadioButton1.Checked = True Then
                q.Gender = "male"
            ElseIf RadioButton2.Checked = True Then
                q.Gender = "Female"
            End If
            f = q.savecustomer1()
            If (f = True) Then
                MessageBox.Show("Record saved successfully")

                btncancel_Click(New System.Object, New System.EventArgs)
            Else
                MessageBox.Show("Record not saved")

            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtbirthdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbirthdate.ValueChanged
        TextBox1.Text = txtbirthdate.Text
    End Sub

   
End Class
