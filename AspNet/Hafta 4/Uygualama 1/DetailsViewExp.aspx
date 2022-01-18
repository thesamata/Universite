<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsViewExp.aspx.cs" Inherits="DatabaseOp.DetailsViewExp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="54px" Width="638px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                <EditRowStyle BackColor="#999999" />
                <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="VendorName" HeaderText="VendorName" SortExpression="VendorName" />
                    <asp:BoundField DataField="VendorAddress" HeaderText="VendorAddress" SortExpression="VendorAddress" />
                    <asp:BoundField DataField="CityID" HeaderText="CityID" SortExpression="CityID" />
                    <asp:BoundField DataField="VendorPhone" HeaderText="VendorPhone" SortExpression="VendorPhone" />
                    <asp:BoundField DataField="VendorCode" HeaderText="VendorCode" SortExpression="VendorCode" />
                    <asp:CommandField ButtonType="Button" CancelText="Vazgeç" DeleteText="Sil" EditText="Düzelt" InsertText="Ekle" NewText="Yeni" SelectText="Seç" ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" UpdateText="Güncelle" />
                </Fields>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" DeleteCommand="DELETE FROM [Vendor] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Vendor] ([VendorName], [VendorAddress], [CityID], [VendorPhone], [VendorCode]) VALUES (@VendorName, @VendorAddress, @CityID, @VendorPhone, @VendorCode)" SelectCommand="SELECT * FROM [Vendor]" UpdateCommand="UPDATE [Vendor] SET [VendorName] = @VendorName, [VendorAddress] = @VendorAddress, [CityID] = @CityID, [VendorPhone] = @VendorPhone, [VendorCode] = @VendorCode WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="VendorName" Type="String" />
                    <asp:Parameter Name="VendorAddress" Type="String" />
                    <asp:Parameter Name="CityID" Type="Int32" />
                    <asp:Parameter Name="VendorPhone" Type="String" />
                    <asp:Parameter Name="VendorCode" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="VendorName" Type="String" />
                    <asp:Parameter Name="VendorAddress" Type="String" />
                    <asp:Parameter Name="CityID" Type="Int32" />
                    <asp:Parameter Name="VendorPhone" Type="String" />
                    <asp:Parameter Name="VendorCode" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
