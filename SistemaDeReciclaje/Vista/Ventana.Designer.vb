<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana
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
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrarForm = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.White
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(689, 387)
        Me.PanelContenedor.TabIndex = 7
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrarForm)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(689, 32)
        Me.PanelBarraTitulo.TabIndex = 9
        '
        'btnCerrarForm
        '
        Me.btnCerrarForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarForm.Image = Global.SistemaDeReciclaje.My.Resources.Resources.Close
        Me.btnCerrarForm.Location = New System.Drawing.Point(668, 10)
        Me.btnCerrarForm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrarForm.Name = "btnCerrarForm"
        Me.btnCerrarForm.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrarForm.TabIndex = 8
        Me.btnCerrarForm.TabStop = False
        '
        'RegistrarEmpresasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 387)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(412, 325)
        Me.Name = "RegistrarEmpresasClientes"
        Me.Text = "RegistrarEmpresasClientes"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnCerrarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnCerrarForm As PictureBox
    Friend WithEvents PanelBarraTitulo As Panel
End Class
