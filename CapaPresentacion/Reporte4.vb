Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class reporte4

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim p1 As Double
        Dim p2 As Double

        p1 = CDbl(MaskedTextBox1.Text)
        p2 = CDbl(MaskedTextBox2.Text)

        Dim Conexion As SqlConnection
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Conexion.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = Conexion
        Adaptador.SelectCommand.CommandText = "reportecompra2"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@PI", SqlDbType.Money)
        Dim param2 = New SqlParameter("@PF", SqlDbType.Money)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param1.Value = CDbl(p1)
        param2.Value = CDbl(p2)
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)

        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim pp1 As New ReportParameter("PI", p1)
        Dim pp2 As New ReportParameter("PF", p2)
        FrmReportes1.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes1.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes1.ReportViewer1.LocalReport.ReportPath = "C:\SistemaAlm\ReporteCompra2.rdlc"
        FrmReportes1.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {pp1, pp2})
        FrmReportes1.ReportViewer1.RefreshReport()
        FrmReportes1.Show()
        Conexion.Close()


    End Sub

    Private Sub reporte4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "server=.; DataBase=Almacen; Integrated Security=SSPI"
        conexion.Open()
    End Sub

End Class