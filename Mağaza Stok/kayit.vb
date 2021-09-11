Imports System.Data.SQLite
Public Class kayit
    Private Sub btngeri_Click(sender As Object, e As EventArgs) Handles btngeri.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub kayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnkayit_Click(sender As Object, e As EventArgs) Handles btnkayit.Click
        Using baglanti = New SQLiteConnection("Data source=db/magaza.db")
            Using kayit As New SQLiteCommand($"insert into personel (personel_adi,personel_soyadi,personel_numara,personel_kimlik) values ('{txtadi.Text}','{txtsoyadi.Text}','{txtnumara.Text}','{txtkimlik.Text}')", baglanti)
                baglanti.Open()
                Try
                    kayit.ExecuteNonQuery()
                    MessageBox.Show("Kayıt Yapıldı")
                Catch hata As Exception
                    MessageBox.Show(hata.Message)
                End Try
            End Using
        End Using
    End Sub
End Class