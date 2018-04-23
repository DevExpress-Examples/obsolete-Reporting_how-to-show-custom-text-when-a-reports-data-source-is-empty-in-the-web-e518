Imports Microsoft.VisualBasic
Imports System
Namespace ShowCustomTextOnEmptyDataSource
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.dataSet11 = New ShowCustomTextOnEmptyDataSource.DataSet1()
			Me.categoriesTableAdapter = New ShowCustomTextOnEmptyDataSource.DataSet1TableAdapters.CategoriesTableAdapter()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataMember = "Categories"
			Me.DetailReport.DataSource = Me.dataSet11
			Me.DetailReport.Name = "DetailReport"
'			Me.DetailReport.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.DetailReport_BeforePrint);
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.Detail1.Height = 50
			Me.Detail1.Name = "Detail1"
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(33, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(150, 25)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold)
			Me.xrLabel2.Location = New System.Drawing.Point(142, 8)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(350, 50)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "No Data Rows"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' DetailReport1
			' 
			Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail2})
			Me.DetailReport1.Level = 1
			Me.DetailReport1.Name = "DetailReport1"
'			Me.DetailReport1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.DetailReport1_BeforePrint_1);
			' 
			' Detail2
			' 
			Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.Detail2.Name = "Detail2"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.DetailReport, Me.DetailReport1})
			Me.Version = "8.2"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private categoriesTableAdapter As ShowCustomTextOnEmptyDataSource.DataSet1TableAdapters.CategoriesTableAdapter
		Private dataSet11 As DataSet1
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail2 As DevExpress.XtraReports.UI.DetailBand
	End Class
End Namespace
