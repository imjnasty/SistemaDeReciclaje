<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Valorizacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Materialbox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Kilostext = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Mesbox = New System.Windows.Forms.ComboBox()
        Me.Añotext = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Diabox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Image = Global.SistemaDeReciclaje.My.Resources.Resources.cancel
        Me.btnCerrarForm.Location = New System.Drawing.Point(11, 11)
        Me.btnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 6
        Me.btnCerrarForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(39, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Valorización"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(39, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Material"
        '
        'Materialbox
        '
        Me.Materialbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Materialbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Materialbox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Materialbox.ForeColor = System.Drawing.Color.White
        Me.Materialbox.FormattingEnabled = True
        Me.Materialbox.Items.AddRange(New Object() {"Aluminio", "Metal", "Cartón", "Papel Blanco", "Papel Mixto", "Vidrio", "Pet", "HDPE", "LDPE", "PP", "PS", "Otros"})
        Me.Materialbox.Location = New System.Drawing.Point(132, 197)
        Me.Materialbox.Name = "Materialbox"
        Me.Materialbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Materialbox.Size = New System.Drawing.Size(168, 23)
        Me.Materialbox.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Kilos"
        '
        'Kilostext
        '
        Me.Kilostext.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Kilostext.ForeColor = System.Drawing.Color.White
        Me.Kilostext.Location = New System.Drawing.Point(132, 387)
        Me.Kilostext.Name = "Kilostext"
        Me.Kilostext.Size = New System.Drawing.Size(168, 20)
        Me.Kilostext.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button2.Location = New System.Drawing.Point(214, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 34)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(360, 197)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(580, 228)
        Me.DataGridView1.TabIndex = 29
        '
        'Mesbox
        '
        Me.Mesbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Mesbox.ForeColor = System.Drawing.Color.White
        Me.Mesbox.FormattingEnabled = True
        Me.Mesbox.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.Mesbox.Location = New System.Drawing.Point(132, 286)
        Me.Mesbox.Name = "Mesbox"
        Me.Mesbox.Size = New System.Drawing.Size(168, 21)
        Me.Mesbox.TabIndex = 30
        '
        'Añotext
        '
        Me.Añotext.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Añotext.ForeColor = System.Drawing.Color.White
        Me.Añotext.Location = New System.Drawing.Point(132, 337)
        Me.Añotext.Name = "Añotext"
        Me.Añotext.Size = New System.Drawing.Size(168, 20)
        Me.Añotext.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(46, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Año"
        '
        'Diabox
        '
        Me.Diabox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Diabox.ForeColor = System.Drawing.Color.White
        Me.Diabox.FormattingEnabled = True
        Me.Diabox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.Diabox.Location = New System.Drawing.Point(132, 246)
        Me.Diabox.Name = "Diabox"
        Me.Diabox.Size = New System.Drawing.Size(168, 21)
        Me.Diabox.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 19)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Dia"
        '
        'Valorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1327, 717)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Diabox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Añotext)
        Me.Controls.Add(Me.Mesbox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Kilostext)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Materialbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrarForm)
        Me.Name = "Valorizacion"
        Me.Text = "Valorizacion"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrarForm As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Materialbox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Kilostext As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Mesbox As ComboBox
    Friend WithEvents Añotext As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Diabox As ComboBox
    Friend WithEvents Label6 As Label
End Class
