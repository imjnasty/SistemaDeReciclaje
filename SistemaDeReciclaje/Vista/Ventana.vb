Imports System.Runtime.InteropServices

Public Class Ventana
    Private Sub RegistrarEmpresasClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrarForm_Click_1(sender As Object, e As EventArgs) Handles btnCerrarForm.Click
        Me.Visible = False
    End Sub

#Region "Funcionalidades del formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#End Region

End Class