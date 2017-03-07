<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DeparturesGrid.ascx.cs" Inherits="NationalRailViewer.Web.UserControls.DeparturesGrid" %>
<asp:GridView runat="server"
    ID="gvData" 
    EmptyDataText="No records to display" 
    Caption="Departures"
    CssClass="table table-striped table-bordered"
    AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField HeaderText="Due" HeaderStyle-CssClass="col-md-2" DataField="std" />
        <asp:BoundField HeaderText="Leaving From" HeaderStyle-CssClass="col-md-4" DataField="origin[0].locationName" />
        <asp:BoundField HeaderText="To" HeaderStyle-CssClass="col-md-4" DataField="destination[0].locationName" />
        <asp:BoundField HeaderText="Status" HeaderStyle-CssClass="col-md-1" DataField="etd" />
        <asp:BoundField HeaderText="Platform" HeaderStyle-CssClass="col-md-1" DataField="platform" />
    </Columns>
</asp:GridView>