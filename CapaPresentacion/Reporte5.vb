Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class reporte5

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim p As String
        p = ComboBox1.Text
        Dim Conexion As SqlConnection
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Conexion.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = Conexion
        Adaptador.SelectCommand.CommandText = "reportecompra3"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@P", SqlDbType.VarChar)
        param1.Direction = ParameterDirection.Input
        param1.Value = p
        Adaptador.SelectCommand.Parameters.Add(param1)
        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("P", p)
        FrmReportes1.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes1.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes1.ReportViewer1.LocalReport.ReportPath = "C:\SistemaAlm\ReporteCompra3.rdlc"
        FrmReportes1.ReportViewer1.LocalReport.SetParameters(
       New ReportParameter() {p1})
        FrmReportes1.ReportViewer1.RefreshReport()
        FrmReportes1.Show()
        Conexion.Close()


    End Sub

    Private Sub reporte5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "server=.; DataBase=Almacen; Integrated Security=SSPI"
        conexion.Open()
        comando.CommandText = "select nombre from proveedores"
        lector = comando.ExecuteReader
        While lector.Read()
            ComboBox1.Items.Add(lector(0))
        End While
        lector.Close()
        conexion.Close()


    End Sub

End Class