<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemployeedetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtsalary = New System.Windows.Forms.TextBox()
        Me.txtemailid = New System.Windows.Forms.TextBox()
        Me.Txtphoneno = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtbirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Txtempname = New System.Windows.Forms.TextBox()
        Me.Txtempid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grboxdtls = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grboxdtls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(26, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "emp id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "emp name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "birth date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Gender"
        '
        'Txtsalary
        '
        Me.Txtsalary.Location = New System.Drawing.Point(493, 189)
        Me.Txtsalary.Name = "Txtsalary"
        Me.Txtsalary.Size = New System.Drawing.Size(100, 20)
        Me.Txtsalary.TabIndex = 17
        '
        'txtemailid
        '
        Me.txtemailid.Location = New System.Drawing.Point(493, 151)
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(167, 20)
        Me.txtemailid.TabIndex = 16
        '
        'Txtphoneno
        '
        Me.Txtphoneno.Location = New System.Drawing.Point(493, 104)
        Me.Txtphoneno.Name = "Txtphoneno"
        Me.Txtphoneno.Size = New System.Drawing.Size(137, 20)
        Me.Txtphoneno.TabIndex = 15
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(493, 56)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(137, 20)
        Me.txtaddress.TabIndex = 14
        '
        'txtbirthdate
        '
        Me.txtbirthdate.Location = New System.Drawing.Point(237, 154)
        Me.txtbirthdate.Name = "txtbirthdate"
        Me.txtbirthdate.Size = New System.Drawing.Size(155, 20)
        Me.txtbirthdate.TabIndex = 13
        '
        'Txtempname
        '
        Me.Txtempname.Location = New System.Drawing.Point(98, 107)
        Me.Txtempname.Name = "Txtempname"
        Me.Txtempname.Size = New System.Drawing.Size(175, 20)
        Me.Txtempname.TabIndex = 12
        '
        'Txtempid
        '
        Me.Txtempid.Location = New System.Drawing.Point(98, 63)
        Me.Txtempid.Name = "Txtempid"
        Me.Txtempid.Size = New System.Drawing.Size(84, 20)
        Me.Txtempid.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(413, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "salary"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(170, 196)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(98, 196)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "email-id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "phone no."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'grboxdtls
        '
        Me.grboxdtls.Controls.Add(Me.TextBox1)
        Me.grboxdtls.Controls.Add(Me.Txtsalary)
        Me.grboxdtls.Controls.Add(Me.Label9)
        Me.grboxdtls.Controls.Add(Me.txtemailid)
        Me.grboxdtls.Controls.Add(Me.Label8)
        Me.grboxdtls.Controls.Add(Me.Txtphoneno)
        Me.grboxdtls.Controls.Add(Me.Label7)
        Me.grboxdtls.Controls.Add(Me.Label6)
        Me.grboxdtls.Controls.Add(Me.txtaddress)
        Me.grboxdtls.Controls.Add(Me.Label4)
        Me.grboxdtls.Controls.Add(Me.Label5)
        Me.grboxdtls.Controls.Add(Me.Txtempid)
        Me.grboxdtls.Controls.Add(Me.Txtempname)
        Me.grboxdtls.Controls.Add(Me.txtbirthdate)
        Me.grboxdtls.Controls.Add(Me.Label3)
        Me.grboxdtls.Controls.Add(Me.Label2)
        Me.grboxdtls.Controls.Add(Me.Label1)
        Me.grboxdtls.Controls.Add(Me.RadioButton2)
        Me.grboxdtls.Controls.Add(Me.RadioButton1)
        Me.grboxdtls.Location = New System.Drawing.Point(6, 9)
        Me.grboxdtls.Name = "grboxdtls"
        Me.grboxdtls.Size = New System.Drawing.Size(663, 239)
        Me.grboxdtls.TabIndex = 18
        Me.grboxdtls.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 154)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 18
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(74, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(157, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(240, 19)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 21
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(332, 19)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 23
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(419, 19)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 24
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnupdate)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 57)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'frmemployeedetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(690, 343)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grboxdtls)
        Me.Name = "frmemployeedetails"
        Me.Text = "frmemployeedetails"
        Me.grboxdtls.ResumeLayout(False)
        Me.grboxdtls.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents Txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtempname As System.Windows.Forms.TextBox
    Friend WithEvents Txtempid As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents grboxdtls As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
