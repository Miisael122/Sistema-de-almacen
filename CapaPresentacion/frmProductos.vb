Imports CapaNegocios
Imports CapaEntidad

Public Class frmProductos

    Dim CapaNegocio As New ProductosCN

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlDataAdapter1.Fill(DataSet11.productos)

        RemoveHandler cboCategoria.SelectedIndexChanged, AddressOf cboCategoria_SelectedIndexChanged
        cboCategoria.DataSource = CapaNegocio.subecbo.Tables("SUBE")
        cboCategoria.DisplayMember = "concepto"
        cboCategoria.ValueMember = "idCategoria"
        AddHandler cboCategoria.SelectedIndexChanged, AddressOf cboCategoria_SelectedIndexChanged


    End Sub


    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click

        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).BeginEdit()
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).Item(1) = Val(cboCategoria.SelectedValue)
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).Item(2) = txtNombre.Text
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).Item(3) = txtPrecio.Text
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).Item(4) = txtCosto.Text
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).Item(5) = txtExistencia.Text
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).Item(6) = txtMaximos.Text
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).Item(7) = txtMinimos.Text
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).EndEdit()


        SqlDataAdapter1.Update(DataSet11, "productos")
        DataSet11.Tables("Productos").Rows(dgProductos.SelectedRows(0).Index).AcceptChanges()
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.productos)



    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then

            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("nombreProducto", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("nombreProducto", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub


    Private Sub cmdInsertar_Click(sender As Object, e As EventArgs) Handles cmdInsertar.Click

        CapaNegocio.insertadatos(Val(cboCategoria.SelectedValue), txtNombre.Text, CDbl(txtPrecio.Text), CDbl(txtCosto.Text), Val(txtExistencia.Text), Val(txtMaximos.Text), Val(txtMinimos.Text))
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.productos)

        cmdEditar.Enabled = True
        cmdSiguiente.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        cmdSiguiente.Enabled = True
        cmdInsertar.Enabled = False

    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        cmdInsertar.Enabled = True
        cmdEditar.Enabled = False
        cmdSiguiente.Enabled = False
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
        cmdSiguiente.Enabled = False

        cboCategoria.Text = ""
        txtNombre.Text = ""
        txtPrecio.Text = ""
        txtCosto.Text = ""
        txtExistencia.Text = 0
        txtMaximos.Text = ""
        txtMinimos.Text = ""


    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click

        ProductosBindingSource.MoveNext()

    End Sub


    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ProductosBindingSource.MoveFirst()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ProductosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ProductosBindingSource.MoveLast()
    End Sub


End Class