Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class reporte1

    Dim conexion As New SqlConnection
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f1 As String
        Dim f2 As String

        f1 = DTP1.Value.Day & "/" & DTP1.Value.Month & "/" & DTP1.Value.Year
        f2 = DTP2.Value.Day & "/" & DTP2.Value.Month & "/" & DTP2.Value.Year

        Dim Conexion As SqlConnection
        Conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Conexion.Open()
        Dim Adaptador As New SqlDataAdapter
        Adaptador.SelectCommand = New SqlCommand
        Adaptador.SelectCommand.Connection = Conexion
        Adaptador.SelectCommand.CommandText = "reporteventa1"
        Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@FI", SqlDbType.Date)
        Dim param2 = New SqlParameter("@FF", SqlDbType.Date)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param1.Value = CDate(f1)
        param2.Value = CDate(f2)
        Adaptador.SelectCommand.Parameters.Add(param1)
        Adaptador.SelectCommand.Parameters.Add(param2)

        Dim Data As New DataSet
        Adaptador.Fill(Data)
        Data.DataSetName = "Data1"
        Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
        Datasource.Name = "DataSet1"
        Datasource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("FI", f1)
        Dim p2 As New ReportParameter("FF", f2)
        FrmReportes1.ReportViewer1.LocalReport.DataSources.Clear()
        FrmReportes1.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes1.ReportViewer1.LocalReport.ReportPath = "C:\SistemaAlm\ReporteVentas1.rdlc"
        FrmReportes1.ReportViewer1.LocalReport.SetParameters(
       New ReportParameter() {p1, p2})
        FrmReportes1.ReportViewer1.RefreshReport()
        FrmReportes1.Show()
        Conexion.Close()


    End Sub

    Private Sub reporte1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "server=.; DataBase=Almacen; Integrated Security=SSPI"
        conexion.Open()
    End Sub

End Class