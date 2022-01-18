<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExternalSQL.aspx.cs" Inherits="DatabaseOp.ExternalSQL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CityName" DataValueField="Id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ExternalSQLConnectionString %>" SelectCommand="SELECT * FROM [City]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
