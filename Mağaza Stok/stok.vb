Imports System.Data.SQLite
Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class stok
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        anasayfa.Show()
        Me.Hide()
    End Sub


    Private Sub stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using getir As New SQLiteCommand("select urun_kodu,urun_ismi,urun_markasi,urun_adedi from urunler", baglanti)
                baglanti.Open()
                Using da As New SQLiteDataAdapter(getir)
                    Dim ds As New DataSet
                    da.Fill(ds, "urunler")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "urunler"
                    DataGridView1.Columns(0).HeaderText = "Ürün Kodu"
                    DataGridView1.Columns(1).HeaderText = "Ürün İsmi"
                    DataGridView1.Columns(2).HeaderText = "Ürün Markası"
                    DataGridView1.Columns(3).HeaderText = "Ürün Adedi"
                End Using
            End Using
        End Using
    End Sub

    Private Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(DataGridView1.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(DataGridView1.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(DataGridView1.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(DataGridView1.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(DataGridView1.Columns(0).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(0).Value.ToString()
            dataRow(DataGridView1.Columns(1).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(1).Value.ToString()
            dataRow(DataGridView1.Columns(2).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(2).Value.ToString()
            dataRow(DataGridView1.Columns(3).HeaderText.ToString()) = DataGridView1.Rows(i).Cells(3).Value.ToString()

            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function


    Private Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)


        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(4)
        PdfTable.TotalWidth = 490.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {2.0F, 2.0F, 2.0F, 2.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Urun Kodu", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Urun Ismi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Urun Markasi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Urun Adedi", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)


        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then
            'Now add the data from datatable to pdf table
            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next
            'Adding pdftable to the pdfdocument
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using baglanti As New SQLiteConnection("data source=db/magaza.db")
            Using getir As New SQLiteCommand($"select urun_kodu,urun_ismi,urun_markasi,urun_adedi from urunler where urun_kodu='{txtkod.Text}'", baglanti)
                baglanti.Open()
                Using da As New SQLiteDataAdapter(getir)
                    Dim ds As New DataSet
                    da.Fill(ds, "urunler")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "urunler"
                    DataGridView1.Columns(0).HeaderText = "Ürün Kodu"
                    DataGridView1.Columns(1).HeaderText = "Ürün İsmi"
                    DataGridView1.Columns(2).HeaderText = "Ürün Markası"
                    DataGridView1.Columns(3).HeaderText = "Ürün Adedi"
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            MsgBox("PDF Oluşturmak İçin İsim Giriniz")
            Exit Sub
        Else
            ExportDataToPDFTable()
            MsgBox("PDF Oluşturuldu")
        End If
    End Sub
End Class