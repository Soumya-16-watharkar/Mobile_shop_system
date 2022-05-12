<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaccessoriesdetails
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
        Me.Txtaccid = New System.Windows.Forms.TextBox()
        Me.Txtaccname = New System.Windows.Forms.TextBox()
        Me.Txtaccprice = New System.Windows.Forms.TextBox()
        Me.Txtaccwaranty = New System.Windows.Forms.TextBox()
        Me.groupboxdtls = New System.Windows.Forms.GroupBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.groupboxdtls.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accessories Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "acc id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "acc name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "waranty"
        '
        'Txtaccid
        '
        Me.Txtaccid.Location = New System.Drawing.Point(74, 63)
        Me.Txtaccid.Name = "Txtaccid"
        Me.Txtaccid.Size = New System.Drawing.Size(100, 20)
        Me.Txtaccid.TabIndex = 5
        '
        'Txtaccname
        '
        Me.Txtaccname.Location = New System.Drawing.Point(263, 63)
        Me.Txtaccname.Name = "Txtaccname"
        Me.Txtaccname.Size = New System.Drawing.Size(100, 20)
        Me.Txtaccname.TabIndex = 6
        '
        'Txtaccprice
        '
        Me.Txtaccprice.Location = New System.Drawing.Point(74, 110)
        Me.Txtaccprice.Name = "Txtaccprice"
        Me.Txtaccprice.Size = New System.Drawing.Size(100, 20)
        Me.Txtaccprice.TabIndex = 7
        '
        'Txtaccwaranty
        '
        Me.Txtaccwaranty.Location = New System.Drawing.Point(263, 113)
        Me.Txtaccwaranty.Name = "Txtaccwaranty"
        Me.Txtaccwaranty.Size = New System.Drawing.Size(100, 20)
        Me.Txtaccwaranty.TabIndex = 8
        '
        'groupboxdtls
        '
        Me.groupboxdtls.Controls.Add(Me.Txtaccwaranty)
        Me.groupboxdtls.Controls.Add(Me.Txtaccprice)
        Me.groupboxdtls.Controls.Add(Me.Txtaccname)
        Me.groupboxdtls.Controls.Add(Me.Txtaccid)
        Me.groupboxdtls.Controls.Add(Me.Label5)
        Me.groupboxdtls.Controls.Add(Me.Label4)
        Me.groupboxdtls.Controls.Add(Me.Label3)
        Me.groupboxdtls.Controls.Add(Me.Label2)
        Me.groupboxdtls.Controls.Add(Me.Label1)
        Me.groupboxdtls.Location = New System.Drawing.Point(10, 13)
        Me.groupboxdtls.Name = "groupboxdtls"
        Me.groupboxdtls.Size = New System.Drawing.Size(383, 156)
        Me.groupboxdtls.TabIndex = 9
        Me.groupboxdtls.TabStop = False
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(33, 11)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(66, 23)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(108, 11)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(64, 23)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(182, 11)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(63, 23)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(258, 11)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(65, 23)
        Me.btncancel.TabIndex = 14
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(329, 11)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(61, 23)
        Me.btnexit.TabIndex = 15
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(439, 44)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'frmaccessoriesdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(466, 264)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupboxdtls)
        Me.Name = "frmaccessoriesdetails"
        Me.Text = "frmaccessoriesdetails"
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
    Friend WithEvents Txtaccid As System.Windows.Forms.TextBox
    Friend WithEvents Txtaccname As System.Windows.Forms.TextBox
    Friend WithEvents Txtaccprice As System.Windows.Forms.TextBox
    Friend WithEvents Txtaccwaranty As System.Windows.Forms.TextBox
    Friend WithEvents groupboxdtls As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
