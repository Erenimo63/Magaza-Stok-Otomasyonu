Imports System.Data.SQLite
Public Class urunsatis
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        anasayfa.Show()
        Me.Hide()
    End Sub

    Dim urun_no, fiyat As String
    Dim adet, fiyat1 As Int16
    Dim kdv As Double

    Private Sub urunsatis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using getir As New SQLiteCommand("select urun_kodu from urunler", baglanti)
                baglanti.Open()
                Using oku As SQLiteDataReader = getir.ExecuteReader()
                    Do While oku.Read()
                        combokod.Items.Add(oku("urun_kodu"))
                    Loop
                End Using
            End Using
        End Using
    End Sub

    Private Sub combokod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combokod.SelectedIndexChanged
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using getir As New SQLiteCommand($"select * from urunler where urun_kodu='{combokod.Text}'", baglanti)
                baglanti.Open()
                Using da As New SQLiteDataAdapter(getir)
                    Dim ds As New DataSet
                    da.Fill(ds, "urunler")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "urunler"
                    DataGridView1.Columns(0).HeaderText = "Ürün Kodu"
                    DataGridView1.Columns(1).HeaderText = "Ürün İsmi"
                    DataGridView1.Columns(2).HeaderText = "Ürün Markası"
                    DataGridView1.Columns(3).HeaderText = "Koridor Numarası"
                    DataGridView1.Columns(4).HeaderText = "Raf Numarası"
                    DataGridView1.Columns(5).HeaderText = "Ürün Fiyatı"
                    DataGridView1.Columns(6).HeaderText = "Ürün Adedi"
                End Using
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        urun_no = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtisim.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtmarka.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtfiyat.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        fiyat = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        adet = DataGridView1.CurrentRow.Cells(6).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using kaydet As New SQLiteCommand($"insert into satilan_urunler (urun_ismi,urun_markasi,urun_fiyati,urun_kdv,genel_toplam,tarih,urun_barkodu) values ('{txtisim.Text}','{txtmarka.Text}','{txtfiyat.Text}','{txtkdv.Text}','{txtgeneltoplam.Text}','{tarih.Value.ToString("dd/MM/yyyy")}','{txtbarkod.Text}')", baglanti)
                adet = adet - 1
                Using güncelle As New SQLiteCommand($"update urunler set urun_adedi ='{adet}' where urun_kodu='{urun_no}'", baglanti)
                    baglanti.Open()
                    Try
                        kaydet.ExecuteNonQuery()
                        güncelle.ExecuteNonQuery()
                        MessageBox.Show("Satış Yapıldı")
                    Catch hata As Exception
                        MessageBox.Show(hata.Message)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub txtgeneltoplam_TextChanged(sender As Object, e As EventArgs) Handles txtgeneltoplam.TextChanged
        Convert.ToDouble(fiyat)
        kdv = fiyat1 * 0.18
        txtkdv.Text = kdv.ToString()
        txtgeneltoplam.Text = kdv + fiyat1
    End Sub

    Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim sayi As String
        sayi = NumericUpDown1.Value.ToString()
        Convert.ToInt16(sayi)
        Convert.ToInt16(fiyat)
        fiyat1 = sayi * fiyat
        txtgeneltoplam.Text = fiyat1.ToString()
    End Sub

    Private Sub txtadet_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class