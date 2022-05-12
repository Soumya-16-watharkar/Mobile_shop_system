<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustomerdetails
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtcustid = New System.Windows.Forms.TextBox()
        Me.Txtaddress = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.Txtphoneno = New System.Windows.Forms.TextBox()
        Me.Txtemail = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtbirthdate = New System.Windows.Forms.DateTimePicker()
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
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "cust id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(300, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "cust name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "phone no"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(300, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "birth date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Gender"
        '
        'Txtcustid
        '
        Me.Txtcustid.Location = New System.Drawing.Point(92, 64)
        Me.Txtcustid.Name = "Txtcustid"
        Me.Txtcustid.Size = New System.Drawing.Size(90, 20)
        Me.Txtcustid.TabIndex = 8
        '
        'Txtaddress
        '
        Me.Txtaddress.Location = New System.Drawing.Point(367, 64)
        Me.Txtaddress.Name = "Txtaddress"
        Me.Txtaddress.Size = New System.Drawing.Size(189, 20)
        Me.Txtaddress.TabIndex = 9
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(92, 111)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(185, 20)
        Me.txtcustname.TabIndex = 10
        '
        'Txtphoneno
        '
        Me.Txtphoneno.Location = New System.Drawing.Point(367, 114)
        Me.Txtphoneno.Name = "Txtphoneno"
        Me.Txtphoneno.Size = New System.Drawing.Size(189, 20)
        Me.Txtphoneno.TabIndex = 11
        '
        'Txtemail
        '
        Me.Txtemail.Location = New System.Drawing.Point(92, 160)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(185, 20)
        Me.Txtemail.TabIndex = 12
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(127, 207)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(198, 207)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtbirthdate
        '
        Me.txtbirthdate.Location = New System.Drawing.Point(530, 163)
        Me.txtbirthdate.Name = "txtbirthdate"
        Me.txtbirthdate.Size = New System.Drawing.Size(179, 20)
        Me.txtbirthdate.TabIndex = 15
        '
        'grboxdtls
        '
        Me.grboxdtls.Controls.Add(Me.TextBox1)
        Me.grboxdtls.Controls.Add(Me.RadioButton2)
        Me.grboxdtls.Controls.Add(Me.txtbirthdate)
        Me.grboxdtls.Controls.Add(Me.RadioButton1)
        Me.grboxdtls.Controls.Add(Me.Txtphoneno)
        Me.grboxdtls.Controls.Add(Me.Txtemail)
        Me.grboxdtls.Controls.Add(Me.txtcustname)
        Me.grboxdtls.Controls.Add(Me.Txtaddress)
        Me.grboxdtls.Controls.Add(Me.Txtcustid)
        Me.grboxdtls.Controls.Add(Me.Label8)
        Me.grboxdtls.Controls.Add(Me.Label7)
        Me.grboxdtls.Controls.Add(Me.Label6)
        Me.grboxdtls.Controls.Add(Me.Label5)
        Me.grboxdtls.Controls.Add(Me.Label4)
        Me.grboxdtls.Controls.Add(Me.Label3)
        Me.grboxdtls.Controls.Add(Me.Label2)
        Me.grboxdtls.Controls.Add(Me.Label1)
        Me.grboxdtls.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grboxdtls.Location = New System.Drawing.Point(9, 11)
        Me.grboxdtls.Name = "grboxdtls"
        Me.grboxdtls.Size = New System.Drawing.Size(716, 247)
        Me.grboxdtls.TabIndex = 16
        Me.grboxdtls.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(366, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 16
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(35, 11)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(87, 23)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(133, 11)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(87, 23)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(227, 11)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(87, 23)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(322, 11)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(87, 23)
        Me.btncancel.TabIndex = 21
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(416, 11)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(87, 23)
        Me.btnexit.TabIndex = 22
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.btnupdate)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 40)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'frmcustomerdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(740, 338)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grboxdtls)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmcustomerdetails"
        Me.Text = "customerdetails"
        Me.grboxdtls.ResumeLayout(False)
        Me.grboxdtls.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents Txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents Txtphoneno As System.Windows.Forms.TextBox
    Friend WithEvents Txtemail As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtbirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grboxdtls As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
