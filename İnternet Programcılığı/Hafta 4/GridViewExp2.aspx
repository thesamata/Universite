<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewExp2.aspx.cs" Inherits="DatabaseOp.GridViewExp2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Şehir:
            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CityName" DataValueField="Id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT [CityName], [Id] FROM [City]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="VendorName" HeaderText="VendorName" SortExpression="VendorName" />
                    <asp:BoundField DataField="VendorAddress" HeaderText="VendorAddress" SortExpression="VendorAddress" />
                    <asp:BoundField DataField="CityID" HeaderText="CityID" SortExpression="CityID" />
                    <asp:BoundField DataField="VendorPhone" HeaderText="VendorPhone" SortExpression="VendorPhone" />
                    <asp:BoundField DataField="VendorCode" HeaderText="VendorCode" SortExpression="VendorCode" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT * FROM [Vendor] WHERE ([CityID] = @CityID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="CityID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
