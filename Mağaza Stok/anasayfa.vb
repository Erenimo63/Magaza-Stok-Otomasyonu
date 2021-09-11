Imports System.Data.SQLite
Public Class anasayfa
    Private Sub anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        urunkayit.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        urunsatis.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        uruniade.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        satılanurunler.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        urunbilgi.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        stok.Show()
        Me.Hide()
    End Sub
End Class