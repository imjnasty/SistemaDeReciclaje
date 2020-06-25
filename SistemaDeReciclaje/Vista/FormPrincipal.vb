Imports System.Runtime.InteropServices

Public Class FormPrincipal
    'llamar clase conectar
    Dim con As Conectar = New Conectar()





#Region "FUNCIONALIDADES DEL FORMULARIO"
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False

    End Sub



    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub
#End Region




    'Metodo del form principal que me llama al metodo conector de la clase conectar
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'llamar metodo de una clase

        Try
            con.conector()
            MsgBox("Conectado a la base de datos")
        Catch ex As Exception
            MsgBox("Error al conectar " & ex.Message)
        End Try



    End Sub





    'METODO DE ABRIR FORMULARIO
    Public Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(Of EmpresasClientes)()
        Button1.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(Of CrearClienteDomicilio)()
        Button2.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(Of ModificarClienteEmpresa)()
        Button4.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFormEnPanel(Of FechaRetiroEmpresa)()
        Button5.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        AbrirFormEnPanel(Of Valorizacion)()
        Button18.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AbrirFormEnPanel(Of BuscarClienteDomicilio)()
        Button8.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AbrirFormEnPanel(Of ModificarClienteDomicilio)()
        Button9.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AbrirFormEnPanel(Of FechaRetiroDomicilio)()
        Button10.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AbrirFormEnPanel(Of CrearClienteCondominio)()
        Button12.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AbrirFormEnPanel(Of BuscarClienteCondominio)()
        Button13.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AbrirFormEnPanel(Of ModificarClienteCondominio)()
        Button14.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AbrirFormEnPanel(Of FechaRetiroCondominio)()
        Button15.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AbrirFormEnPanel(Of GestionPago)()
        Button16.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        AbrirFormEnPanel(Of GenerarHojaRuta)()
        Button17.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Panelinvisible1.Visible = True) Then

            Panelinvisible1.Visible = False


        Else
            Panelinvisible1.Visible = True
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (Panelinvisible3.Visible = True) Then

            Panelinvisible3.Visible = False


        Else
            Panelinvisible3.Visible = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Panelinvisible2.Visible = True) Then

            Panelinvisible2.Visible = False


        Else
            Panelinvisible2.Visible = True
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(Of BuscarClienteEmpresa)()
        Button3.BackColor = Color.FromArgb(50, 205, 50)
    End Sub

    ''METODO/EVENTO AL CERRAR FORMS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ''CONDICION SI FORMS ESTA ABIERTO

        ''Cliente Empresa
        If (Application.OpenForms("EmpresasCliente") Is Nothing) Then
            Button1.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("BuscarClienteEmpresa") Is Nothing) Then
            Button3.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("ModificarClienteEmpresa") Is Nothing) Then
            Button4.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("FechaRetiroEmpresa") Is Nothing) Then
            Button5.BackColor = Color.FromArgb(0, 100, 0)
        End If

        ''Cliente Domicilio
        If (Application.OpenForms("CrearClienteDomicilio") Is Nothing) Then
            Button2.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("BuscarClienteDomicilio") Is Nothing) Then
            Button8.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("ModificarClienteDomicilio") Is Nothing) Then
            Button9.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("FechaRetiroDomicilio") Is Nothing) Then
            Button10.BackColor = Color.FromArgb(0, 100, 0)
        End If

        ''Cliente Condominio
        If (Application.OpenForms("CrearClienteCondominio") Is Nothing) Then
            Button12.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("BuscarClienteCondominio") Is Nothing) Then
            Button13.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("ModificarClienteCondominio") Is Nothing) Then
            Button14.BackColor = Color.FromArgb(0, 100, 0)
        End If
        If (Application.OpenForms("FechaRetiroCondominio") Is Nothing) Then
            Button15.BackColor = Color.FromArgb(0, 100, 0)
        End If

        ''Gestion de Pago
        If (Application.OpenForms("Valorizacion") Is Nothing) Then
            Button18.BackColor = Color.FromArgb(0, 100, 0)
        End If

        ''Hoja de ruta
        If (Application.OpenForms("Valorizacion") Is Nothing) Then
            Button17.BackColor = Color.FromArgb(0, 100, 0)
        End If

        ''Valorizacion
        If (Application.OpenForms("Valorizacion") Is Nothing) Then
            Button18.BackColor = Color.FromArgb(0, 100, 0)
        End If
    End Sub

End Class
