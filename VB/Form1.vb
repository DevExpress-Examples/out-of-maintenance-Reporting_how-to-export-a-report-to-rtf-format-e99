Imports System.Diagnostics
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button1.Click
        ' A path to export a report.
        Dim reportPath As String = "c:\\Test.rtf"

        ' Create a report instance.
        Dim report As New XtraReport1()

        ' Export the report to RTF.
        report.ExportToRtf(reportPath)

        ' Show the result.
        StartProcess(reportPath)
    End Sub

    ' Use this method if you want to automaically open
    ' the created RTF file in the default program.
    Public Sub StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
    End Sub
End Class
