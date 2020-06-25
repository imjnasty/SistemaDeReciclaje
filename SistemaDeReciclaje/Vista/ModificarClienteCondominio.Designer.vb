<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarClienteCondominio
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
        Me.btnCerrarForm.TabIndex = 12
        Me.btnCerrarForm.TabStop = False
        '
        'ModificarClienteCondominio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCerrarForm)
        Me.Name = "ModificarClienteCondominio"
        Me.Text = "ModificarClienteCondominio"
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrarForm As PictureBox
End Class
