<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NationalRailViewer.Web.Default" %>

<%@ Register TagPrefix="uc" TagName="DeparturesGrid" Src="~/UserControls/DeparturesGrid.ascx" %>
<%@ Register TagPrefix="uc" TagName="ArrivalsGrid" Src="~/UserControls/ArrivalsGrid.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Scripts/Bootstrap/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="Scripts/CSS/BootstrapOverrides.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Live Departure & Arrival board for <strong><%= Station %></strong></h1>
            <div>
                <asp:Panel runat="server" ID="pnlError" CssClass="alert alert-danger">
                    <span class="close" data-dismiss="alert">&times</span>
                    <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                    <span>Unable to load data for <%= Station %><</span>
                </asp:Panel>
                <uc:DeparturesGrid runat="server" ID="ucDepartures" />
                <br />
                <uc:ArrivalsGrid runat="server" ID="ucArrivals" />
                <br />
            </div>
            <div class="well well-sm">Last Updated: <%= GeneratedAt.ToString("dd/MM/yyyy HH:mm:ss") %></div>
        </div>
    </form>
</body>
</html>
