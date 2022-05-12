Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim cn As New SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim cr As New CrystalReport1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\vb\mobileshopmanagementsystem\mobileshopmanagementsystem\mobileshop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
        cmd = New SqlCommand("select * from transactiondetails", cn)
        dr = cmd.executereader
        dt.Load(dr)
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        dr.Close()


    End Sub
End Class
   