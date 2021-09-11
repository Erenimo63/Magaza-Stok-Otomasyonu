<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class urunkayit
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txturunkod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txturunismi = New System.Windows.Forms.TextBox()
        Me.txtmarka = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkoridor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtraf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfiyat = New System.Windows.Forms.TextBox()
        Me.btnkayit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtadet = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txturunkod
        '
        Me.txturunkod.Location = New System.Drawing.Point(166, 7)
        Me.txturunkod.Name = "txturunkod"
        Me.txturunkod.Size = New System.Drawing.Size(132, 20)
        Me.txturunkod.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ürün Kodu : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ürün İsmi :"
        '
        'txturunismi
        '
        Me.txturunismi.Location = New System.Drawing.Point(166, 43)
        Me.txturunismi.Name = "txturunismi"
        Me.txturunismi.Size = New System.Drawing.Size(132, 20)
        Me.txturunismi.TabIndex = 1
        '
        'txtmarka
        '
        Me.txtmarka.Location = New System.Drawing.Point(166, 79)
        Me.txtmarka.Name = "txtmarka"
        Me.txtmarka.Size = New System.Drawing.Size(132, 20)
        Me.txtmarka.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ürün Markası :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Koridar Numarası :"
        '
        'txtkoridor
        '
        Me.txtkoridor.Location = New System.Drawing.Point(166, 115)
        Me.txtkoridor.Name = "txtkoridor"
        Me.txtkoridor.Size = New System.Drawing.Size(132, 20)
        Me.txtkoridor.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Raf Numarası :"
        '
        'txtraf
        '
        Me.txtraf.Location = New System.Drawing.Point(166, 151)
        Me.txtraf.Name = "txtraf"
        Me.txtraf.Size = New System.Drawing.Size(132, 20)
        Me.txtraf.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Ürün Fiyatı :"
        '
        'txtfiyat
        '
        Me.txtfiyat.Location = New System.Drawing.Point(166, 188)
        Me.txtfiyat.Name = "txtfiyat"
        Me.txtfiyat.Size = New System.Drawing.Size(132, 20)
        Me.txtfiyat.TabIndex = 5
        '
        'btnkayit
        '
        Me.btnkayit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkayit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnkayit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnkayit.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnkayit.Location = New System.Drawing.Point(12, 273)
        Me.btnkayit.Name = "btnkayit"
        Me.btnkayit.Size = New System.Drawing.Size(91, 33)
        Me.btnkayit.TabIndex = 9
        Me.btnkayit.Text = "Geri"
        Me.btnkayit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Location = New System.Drawing.Point(208, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Ürün Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Ürün Adedi :"
        '
        'txtadet
        '
        Me.txtadet.Location = New System.Drawing.Point(166, 224)
        Me.txtadet.Name = "txtadet"
        Me.txtadet.Size = New System.Drawing.Size(132, 20)
        Me.txtadet.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.Location = New System.Drawing.Point(110, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Stok Ekle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'urunkayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(311, 313)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnkayit)
        Me.Controls.Add(Me.txtadet)
        Me.Controls.Add(Me.txtfiyat)
        Me.Controls.Add(Me.txtraf)
        Me.Controls.Add(Me.txtmarka)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtkoridor)
        Me.Controls.Add(Me.txturunismi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txturunkod)
        Me.Controls.Add(Me.Label1)
        Me.Name = "urunkayit"
        Me.Text = "Mağaza Stok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txturunkod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txturunismi As TextBox
    Friend WithEvents txtmarka As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtkoridor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtraf As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfiyat As TextBox
    Friend WithEvents btnkayit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtadet As TextBox
    Friend WithEvents Button2 As Button
End Class
