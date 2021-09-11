Imports System.Data.SQLite
Public Class uruniade
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        anasayfa.Show()
        Me.Hide()
    End Sub
    Dim barkod, urun_ismi, urun_markasi As String
    Private Sub uruniade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using getir As New SQLiteCommand($"select * from satilan_urunler where urun_barkodu='{TextBox4.Text}'", baglanti)
                baglanti.Open()
                Using da As New SQLiteDataAdapter(getir)
                    Dim ds As New DataSet
                    da.Fill(ds, "satilan_urunler")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "satilan_urunler"
                    DataGridView1.Columns(0).HeaderText = "Ürün İsmi"
                    DataGridView1.Columns(1).HeaderText = "Ürün Markası"
                    DataGridView1.Columns(2).HeaderText = "Ürün Fiyatı"
                    DataGridView1.Columns(3).HeaderText = "Ürün KDV"
                    DataGridView1.Columns(4).HeaderText = "Genel Toplam"
                    DataGridView1.Columns(5).HeaderText = "Tarih"
                    DataGridView1.Columns(6).HeaderText = "Ürün Barkodu"
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        barkod = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        urun_ismi = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        urun_markasi = DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adet As Int16
        Using baglanti As New SQLiteConnection("data source = db/magaza.db")
            Using getir As New SQLiteCommand($"select urun_adedi from urunler where urun_ismi='{urun_ismi}' and urun_markasi='{urun_markasi}'", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = getir.ExecuteReader()
                    oku.Read()
                    adet = oku("urun_adedi")
                    adet = adet + 1
                    Using sil As New SQLiteCommand($"delete from satilan_urunler where urun_barkodu='{barkod}'", baglanti)
                        Using güncelle As New SQLiteCommand($"update urunler set urun_adedi='{adet}'", baglanti)
                            Try
                                güncelle.ExecuteNonQuery()
                                sil.ExecuteNonQuery()
                                MessageBox.Show("İade Alındı")
                            Catch hata As Exception
                                MessageBox.Show(hata.Message)
                            End Try
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class