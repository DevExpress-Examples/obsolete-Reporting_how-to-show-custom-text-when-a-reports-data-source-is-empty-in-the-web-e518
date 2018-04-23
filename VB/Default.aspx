<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ShowCustomTextOnEmptyDataSource._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxxr:reportviewer id="ReportViewer1" runat="server" report="<%#New ShowCustomTextOnEmptyDataSource.XtraReport1()%>"
			reportname="ShowCustomTextOnEmptyDataSource.XtraReport1">
<Border BorderColor="#E0E0E0" BorderStyle="Solid"></Border>
</dxxr:reportviewer>

	</div>
	</form>
</body>
</html>