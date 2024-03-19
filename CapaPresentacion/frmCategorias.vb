Imports CapaNegocios
Imports CapaEntidad
Imports System.Data.SqlClient

Public Class frmCategorias

    Dim CapaNegocio As New CategoriasCN


    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlDataAdapter1.Fill(DataSet11.categorias)

    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click


        DataSet11.Tables("Categorias").Rows(dgCategorias.SelectedRows(0).Index).BeginEdit()
        DataSet11.Tables("Categorias").Rows(dgCategorias.SelectedRows(0).Index).Item(1) = txtConcepto.Text
        DataSet11.Tables("Categorias").Rows(dgCategorias.SelectedRows(0).Index).EndEdit()


        SqlDataAdapter1.Update(DataSet11, "categorias")
        DataSet11.Tables("Categorias").Rows(dgCategorias.SelectedRows(0).Index).AcceptChanges()
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.categorias)


    End Sub

    Private Sub SqlDataAdapter1_RowUpdated(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles SqlDataAdapter1.RowUpdated
        If e.Status = UpdateStatus.ErrorsOccurred Then

            MessageBox.Show(e.Errors.Message & vbCrLf &
            e.Row.Item("concepto", DataRowVersion.Original) & vbCrLf &
            e.Row.Item("concepto", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub





    Private Sub cmdInsertar_Click(sender As Object, e As EventArgs) Handles cmdInsertar.Click


        CapaNegocio.insertadatos(txtConcepto.Text)
        DataSet11.Clear()
        SqlDataAdapter1.Fill(DataSet11.categorias)



        cmdEditar.Enabled = True
        cmdSiguiente.Enabled = True
        cmdInicio.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        cmdSiguiente.Enabled = True
        cmdInsertar.Enabled = False



    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click

        CategoriasBindingSource.MoveNext()

    End Sub


    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CategoriasBindingSource.MoveFirst()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CategoriasBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CategoriasBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        cmdInsertar.Enabled = True
        cmdEditar.Enabled = False
        cmdSiguiente.Enabled = False
        cmdInicio.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
        cmdSiguiente.Enabled = False
        txtConcepto.Text = ""
    End Sub


End Class
