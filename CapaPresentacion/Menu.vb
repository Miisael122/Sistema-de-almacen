Imports System.Runtime.InteropServices

Public Class Menucont

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub

    Private Sub cmdmax_Click(sender As Object, e As EventArgs) Handles cmdmax.Click
        cmdmax.Visible = False
        cmdrestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdrestaurar_Click(sender As Object, e As EventArgs) Handles cmdrestaurar.Click
        cmdrestaurar.Visible = False
        cmdmax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdmin_Click(sender As Object, e As EventArgs) Handles cmdmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles cabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultarmenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarmenu.Tick
        If menuop.Width <= 60 Then
            Me.tmOcultarmenu.Enabled = False
        Else
            Me.menuop.Width = menuop.Width - 20
        End If
    End Sub

    Private Sub tmMostrarmenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarmenu.Tick
        If menuop.Width >= 190 Then
            Me.tmMostrarmenu.Enabled = False
        Else
            Me.menuop.Width = menuop.Width + 20
        End If
    End Sub

    Private Sub cmdmenu_Click(sender As Object, e As EventArgs) Handles cmdmenu.Click
        If menuop.Width = 190 Then
            tmOcultarmenu.Enabled = True
        ElseIf menuop.Width <= 60 Then
            tmMostrarmenu.Enabled = True
        End If
    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(New frmCategorias)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel(New frmProductos)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(New frmProveedores)
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(New frmVentas)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFormEnPanel(New Pagos)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AbrirFormEnPanel(New frmCompras)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AbrirFormEnPanel(New Consultas)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AbrirFormEnPanel(New Reportes)
    End Sub

    Private Sub Menu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F Then
            System.Diagnostics.Process.Start("C:\SistemaAlm\help.chm")
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AbrirFormEnPanel(New Historico)
    End Sub
End Class