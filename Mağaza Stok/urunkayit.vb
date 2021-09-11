Imports System.Data.SQLite
Public Class urunkayit
    Private Sub btnkayit_Click(sender As Object, e As EventArgs) Handles btnkayit.Click
        anasayfa.Show()
        Me.Hide()

    End Sub

    Private Sub urunkayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using kayit As New SQLiteCommand($"insert into urunler (urun_kodu,urun_ismi,urun_markasi,koridor_numarasi,raf_numarasi,urun_fiyati,urun_adedi) values ('{txturunkod.Text}','{txturunismi.Text}','{txtmarka.Text}','{txtkoridor.Text}','{txtraf.Text}','{txtfiyat.Text}','{txtadet.Text}')", baglanti)
                Try
                    baglanti.Open()
                    kayit.ExecuteNonQuery()
                    MessageBox.Show("Kayıt Yapıldı")
                Catch hata As Exception
                    MessageBox.Show("Hata :" + hata.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim urun, adet As Integer
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using getir As New SQLiteCommand($"select urun_adedi from urunler where urun_kodu='{txturunkod.Text}'", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = getir.ExecuteReader()
                    oku.Read()
                    urun = Convert.ToInt16(txtadet.Text)
                    adet = Convert.ToInt16(oku("urun_adedi"))
                    adet = urun + adet
                    Using ekle As New SQLiteCommand($"update urunler set urun_adedi='{adet}' where urun_kodu='{txturunkod.Text}'", baglanti)
                        Try
                            ekle.ExecuteNonQuery()
                            MessageBox.Show("Stok Eklendi")
                        Catch hata As Exception
                            MessageBox.Show("Stok Eklenemedi" + hata.Message)
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class