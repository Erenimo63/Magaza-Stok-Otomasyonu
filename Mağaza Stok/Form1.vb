Imports System.Data.SQLite
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()


    End Sub

    Private Sub btnkayit_Click(sender As Object, e As EventArgs) Handles btnkayit.Click
        kayit.Show()
        Me.Hide()
    End Sub

    Private Sub btngiris_Click(sender As Object, e As EventArgs) Handles btngiris.Click
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using sorgu As New SQLiteCommand($"select * from personel where personel_numara='{txtnumara.Text}' and personel_kimlik='{txtkimlik.Text}'", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = sorgu.ExecuteReader()
                    If oku.Read() Then
                        anasayfa.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Personel Numarası Veya Şifre Yanlış")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
