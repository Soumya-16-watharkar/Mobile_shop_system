<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdealeraccessoriestransaction
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
        Me.Txtdeaid = New System.Windows.Forms.TextBox()
        Me.Txtaccquantity = New System.Windows.Forms.TextBox()
        Me.Txtaccid = New System.Windows.Forms.TextBox()
        Me.Txtaccprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaccdate = New System.Windows.Forms.DateTimePicker()
        Me.groupboxdtls = New System.Windows.Forms.GroupBox()
        Me.Browsedeaid = New System.Windows.Forms.Button()
        Me.Browseaccname = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtaccname = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.groupboxdtls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dealer Accessories Transaction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "dea id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "acc id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(373, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "date"
        '
        'Txtdeaid
        '
        Me.Txtdeaid.Location = New System.Drawing.Point(114, 70)
        Me.Txtdeaid.Name = "Txtdeaid"
        Me.Txtdeaid.Size = New System.Drawing.Size(116, 20)
        Me.Txtdeaid.TabIndex = 5
        '
        'Txtaccquantity
        '
        Me.Txtaccquantity.Location = New System.Drawing.Point(114, 121)
        Me.Txtaccquantity.Name = "Txtaccquantity"
        Me.Txtaccquantity.Size = New System.Drawing.Size(116, 20)
        Me.Txtaccquantity.TabIndex = 6
        '
        'Txtaccid
        '
        Me.Txtaccid.Location = New System.Drawing.Point(432, 71)
        Me.Txtaccid.Name = "Txtaccid"
        Me.Txtaccid.Size = New System.Drawing.Size(116, 20)
        Me.Txtaccid.TabIndex = 7
        '
        'Txtaccprice
        '
        Me.Txtaccprice.Location = New System.Drawing.Point(114, 164)
        Me.Txtaccprice.Name = "Txtaccprice"
        Me.Txtaccprice.Size = New System.Drawing.Size(116, 20)
        Me.Txtaccprice.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "price"
        '
        'txtaccdate
        '
        Me.txtaccdate.Location = New System.Drawing.Point(580, 118)
        Me.txtaccdate.Name = "txtaccdate"
        Me.txtaccdate.Size = New System.Drawing.Size(175, 20)
        Me.txtaccdate.TabIndex = 11
        '
        'groupboxdtls
        '
        Me.groupboxdtls.Controls.Add(Me.txttotal)
        Me.groupboxdtls.Controls.Add(Me.Label8)
        Me.groupboxdtls.Controls.Add(Me.Browsedeaid)
        Me.groupboxdtls.Controls.Add(Me.Browseaccname)
        Me.groupboxdtls.Controls.Add(Me.Button1)
        Me.groupboxdtls.Controls.Add(Me.Label7)
        Me.groupboxdtls.Controls.Add(Me.txtaccname)
        Me.groupboxdtls.Controls.Add(Me.TextBox1)
        Me.groupboxdtls.Controls.Add(Me.txtaccdate)
        Me.groupboxdtls.Controls.Add(Me.Label6)
        Me.groupboxdtls.Controls.Add(Me.Txtaccprice)
        Me.groupboxdtls.Controls.Add(Me.Txtaccid)
        Me.groupboxdtls.Controls.Add(Me.Txtaccquantity)
        Me.groupboxdtls.Controls.Add(Me.Txtdeaid)
        Me.groupboxdtls.Controls.Add(Me.Label5)
        Me.groupboxdtls.Controls.Add(Me.Label4)
        Me.groupboxdtls.Controls.Add(Me.Label3)
        Me.groupboxdtls.Controls.Add(Me.Label2)
        Me.groupboxdtls.Controls.Add(Me.Label1)
        Me.groupboxdtls.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupboxdtls.Location = New System.Drawing.Point(7, 13)
        Me.groupboxdtls.Name = "groupboxdtls"
        Me.groupboxdtls.Size = New System.Drawing.Size(767, 235)
        Me.groupboxdtls.TabIndex = 12
        Me.groupboxdtls.TabStop = False
        '
        'Browsedeaid
        '
        Me.Browsedeaid.Location = New System.Drawing.Point(251, 69)
        Me.Browsedeaid.Name = "Browsedeaid"
        Me.Browsedeaid.Size = New System.Drawing.Size(87, 23)
        Me.Browsedeaid.TabIndex = 17
        Me.Browsedeaid.Text = "Browse"
        Me.Browsedeaid.UseVisualStyleBackColor = True
        '
        'Browseaccname
        '
        Me.Browseaccname.Location = New System.Drawing.Point(581, 171)
        Me.Browseaccname.Name = "Browseaccname"
        Me.Browseaccname.Size = New System.Drawing.Size(87, 23)
        Me.Browseaccname.TabIndex = 16
        Me.Browseaccname.Text = "Browse"
        Me.Browseaccname.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(573, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "acc name"
        '
        'txtaccname
        '
        Me.txtaccname.Location = New System.Drawing.Point(433, 171)
        Me.txtaccname.Name = "txtaccname"
        Me.txtaccname.Size = New System.Drawing.Size(142, 20)
        Me.txtaccname.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(432, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 12
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(75, 19)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(73, 23)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(171, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(73, 23)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(265, 19)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(80, 23)
        Me.btnupdate.TabIndex = 15
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(352, 19)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(87, 23)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(447, 19)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(87, 23)
        Me.btnexit.TabIndex = 18
        Me.btnexit.Text = "exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.btnupdate)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Location = New System.Drawing.Point(87, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 59)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "total"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(114, 209)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(116, 20)
        Me.txttotal.TabIndex = 21
        '
        'frmdealeraccessoriestransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(787, 335)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupboxdtls)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmdealeraccessoriestransaction"
        Me.Text = "frmdealeraccessoriestransaction"
        Me.groupboxdtls.ResumeLayout(False)
        Me.groupboxdtls.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtdeaid As System.Windows.Forms.TextBox
    Friend WithEvents Txtaccquantity As System.Windows.Forms.TextBox
    Friend WithEvents Txtaccid As System.Windows.Forms.TextBox
    Friend WithEvents Txtaccprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtaccdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents groupboxdtls As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtaccname As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Browseaccname As System.Windows.Forms.Button
    Friend WithEvents Browsedeaid As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
