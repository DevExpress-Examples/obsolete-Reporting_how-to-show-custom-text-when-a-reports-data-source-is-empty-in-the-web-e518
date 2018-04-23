Imports DevExpress.XtraReports.UI
' ...

Public Class XtraReport1

    Private emptyDataSource As Boolean = False

    Private Sub DetailReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DetailReport.BeforePrint
        ' Uncomment the following line, to see the report's data.
        ' CategoriesTableAdapter.Fill(DataSet11.Categories)

        If (CType(sender, XtraReportBase)).DataSource IsNot Nothing Then
            emptyDataSource = (CType((CType(sender, XtraReportBase)).DataSource, DataSet1)).Categories.Rows.Count = 0
        Else
            emptyDataSource = True
        End If

        e.Cancel = emptyDataSource
    End Sub

    Private Sub DetailReport1_BeforePrint_1(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles DetailReport1.BeforePrint
        e.Cancel = Not emptyDataSource
    End Sub
End Class