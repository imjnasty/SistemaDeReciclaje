<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearClienteDomicilio
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
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Image = Global.SistemaDeReciclaje.My.Resources.Resources.cancel
        Me.btnCerrarForm.Location = New System.Drawing.Point(9, 10)
        Me.btnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 8
        Me.btnCerrarForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(77, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Crear Cliente Domicilio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(68, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(68, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Dirección:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(154, 202)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(68, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Referencia:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(154, 257)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 20)
        Me.TextBox3.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(68, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Sector:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(154, 310)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(240, 20)
        Me.TextBox4.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(475, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Nombre:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(561, 150)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(240, 20)
        Me.TextBox5.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(475, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Apellido:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(561, 200)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(240, 20)
        Me.TextBox6.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(475, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Telefòno:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(561, 256)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(240, 20)
        Me.TextBox7.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(475, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 19)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Plan:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(561, 308)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(240, 20)
        Me.TextBox8.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button1.Location = New System.Drawing.Point(561, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 36)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CrearClienteDomicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(930, 525)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrarForm)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CrearClienteDomicilio"
        Me.Text = "Form2"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrarForm As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
End Class
