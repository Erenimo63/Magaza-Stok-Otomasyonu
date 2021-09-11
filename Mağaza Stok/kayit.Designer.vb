<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kayit
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtadi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnumara = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkimlik = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsoyadi = New System.Windows.Forms.TextBox()
        Me.btngeri = New System.Windows.Forms.Button()
        Me.btnkayit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Personel Adı :"
        '
        'txtadi
        '
        Me.txtadi.Location = New System.Drawing.Point(166, 32)
        Me.txtadi.Name = "txtadi"
        Me.txtadi.Size = New System.Drawing.Size(100, 20)
        Me.txtadi.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Personel Numarası :"
        '
        'txtnumara
        '
        Me.txtnumara.Location = New System.Drawing.Point(166, 109)
        Me.txtnumara.Name = "txtnumara"
        Me.txtnumara.Size = New System.Drawing.Size(100, 20)
        Me.txtnumara.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(282, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Personel Kimlik :"
        '
        'txtkimlik
        '
        Me.txtkimlik.Location = New System.Drawing.Point(436, 109)
        Me.txtkimlik.Name = "txtkimlik"
        Me.txtkimlik.Size = New System.Drawing.Size(100, 20)
        Me.txtkimlik.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(282, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Personel Soyadı :"
        '
        'txtsoyadi
        '
        Me.txtsoyadi.Location = New System.Drawing.Point(436, 32)
        Me.txtsoyadi.Name = "txtsoyadi"
        Me.txtsoyadi.Size = New System.Drawing.Size(100, 20)
        Me.txtsoyadi.TabIndex = 1
        '
        'btngeri
        '
        Me.btngeri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngeri.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btngeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btngeri.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btngeri.Location = New System.Drawing.Point(166, 149)
        Me.btngeri.Name = "btngeri"
        Me.btngeri.Size = New System.Drawing.Size(100, 33)
        Me.btngeri.TabIndex = 5
        Me.btngeri.Text = "Geri"
        Me.btngeri.UseVisualStyleBackColor = True
        '
        'btnkayit
        '
        Me.btnkayit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkayit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnkayit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnkayit.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnkayit.Location = New System.Drawing.Point(285, 149)
        Me.btnkayit.Name = "btnkayit"
        Me.btnkayit.Size = New System.Drawing.Size(100, 33)
        Me.btnkayit.TabIndex = 4
        Me.btnkayit.Text = "Kayıt Ol"
        Me.btnkayit.UseVisualStyleBackColor = True
        '
        'kayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(546, 194)
        Me.Controls.Add(Me.btnkayit)
        Me.Controls.Add(Me.btngeri)
        Me.Controls.Add(Me.txtsoyadi)
        Me.Controls.Add(Me.txtkimlik)
        Me.Controls.Add(Me.txtnumara)
        Me.Controls.Add(Me.txtadi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "kayit"
        Me.Text = "Mağaza Stok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtadi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnumara As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkimlik As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsoyadi As TextBox
    Friend WithEvents btngeri As Button
    Friend WithEvents btnkayit As Button
End Class
