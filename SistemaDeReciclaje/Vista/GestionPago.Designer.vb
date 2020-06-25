<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnCerrarForm.TabIndex = 14
        Me.btnCerrarForm.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(75, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Gestiòn de Pago"
        '
        'GestionPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrarForm)
        Me.Name = "GestionPago"
        Me.Text = "GestionPago"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrarForm As PictureBox
    Friend WithEvents Label1 As Label
End Class
