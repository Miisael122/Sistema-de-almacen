Imports CapaNegocios
Imports CapaEntidad


Public Class frmProveedores

    Dim CapaNegocio As New ProveedoresCN

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlDataAdapter1.Fill(DataSet11.proveedores)

    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click

        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).BeginEdit()
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(1) = txtnombre.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(2) = txttelefono.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(3) = txtdomicilio.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(4) = txtcolonia.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(5) = txtcp.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(6) = txtciudad.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(7) = txtcorreo.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(8) = txtrepresentante.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).Item(9) = txtsaldo.Text
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).EndEdit()


        SqlDataAdapter1.Update(DataSet11, "proveedores")
        DataSet11.Tables("Proveedores").Rows(dgproveedores.SelectedRows(0).Index).AcceptChanges()
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.proveedores)



    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then

            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("nombre", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("nombre", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub cmdinsertar_Click(sender As Object, e As EventArgs) Handles cmdinsertar.Click

        CapaNegocio.insertadatos(txtnombre.Text, txttelefono.Text, txtdomicilio.Text, txtcolonia.Text, txtcp.Text, txtciudad.Text, txtcorreo.Text, txtrepresentante.Text, CDbl(txtsaldo.Text))
        dgproveedores.DataSource = CapaNegocio.mostrardatos.Tables("MUESTRA")

        cmdEditar.Enabled = True
        cmdSiguiente.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        cmdSiguiente.Enabled = True
        cmdinsertar.Enabled = False

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        cmdinsertar.Enabled = True
        cmdEditar.Enabled = False
        cmdSiguiente.Enabled = False
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
        cmdSiguiente.Enabled = False

        txtnombre.Text = ""
        txttelefono.Text = ""
        txtdomicilio.Text = ""
        txtcolonia.Text = 0
        txtcp.Text = ""
        txtciudad.Text = ""
        txtcorreo.Text = ""
        txtrepresentante.Text = ""
        txtsaldo.Text = 0


    End Sub

    Private Sub cmdsaldo_Click(sender As Object, e As EventArgs) Handles cmdsaldo.Click
        Me.Dispose()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click

        ProveedoresBindingSource.MoveNext()

    End Sub


    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ProveedoresBindingSource.MoveFirst()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ProveedoresBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ProveedoresBindingSource.MoveLast()
    End Sub


End Class