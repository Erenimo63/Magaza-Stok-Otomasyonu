<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btngiris = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnkayit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkimlik = New System.Windows.Forms.TextBox()
        Me.txtnumara = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btngiris
        '
        Me.btngiris.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btngiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btngiris.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btngiris.Location = New System.Drawing.Point(12, 167)
        Me.btngiris.Name = "btngiris"
        Me.btngiris.Size = New System.Drawing.Size(166, 33)
        Me.btngiris.TabIndex = 2
        Me.btngiris.Text = "Giriş"
        Me.btngiris.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.Location = New System.Drawing.Point(139, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Çıkış"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnkayit
        '
        Me.btnkayit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkayit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnkayit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnkayit.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnkayit.Location = New System.Drawing.Point(184, 167)
        Me.btnkayit.Name = "btnkayit"
        Me.btnkayit.Size = New System.Drawing.Size(164, 33)
        Me.btnkayit.TabIndex = 3
        Me.btnkayit.Text = "Kayıt"
        Me.btnkayit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Personel Numarası :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Personel Kimlik :"
        '
        'txtkimlik
        '
        Me.txtkimlik.Location = New System.Drawing.Point(184, 112)
        Me.txtkimlik.Name = "txtkimlik"
        Me.txtkimlik.Size = New System.Drawing.Size(164, 20)
        Me.txtkimlik.TabIndex = 1
        '
        'txtnumara
        '
        Me.txtnumara.Location = New System.Drawing.Point(184, 30)
        Me.txtnumara.Name = "txtnumara"
        Me.txtnumara.Size = New System.Drawing.Size(164, 20)
        Me.txtnumara.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(360, 252)
        Me.Controls.Add(Me.txtnumara)
        Me.Controls.Add(Me.txtkimlik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnkayit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btngiris)
        Me.Name = "Form1"
        Me.Text = "Mağaza Stok"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btngiris As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnkayit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtkimlik As TextBox
    Friend WithEvents txtnumara As TextBox
End Class
