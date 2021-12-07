<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GriedViewExp.aspx.cs" Inherits="DatabaseOp.GriedViewExp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="VendorCode" HeaderText="Satıcı Kodu" SortExpression="VendorCode" />
                    <asp:BoundField DataField="VendorName" HeaderText="Satıcı Adı" SortExpression="VendorName" />
                    <asp:BoundField DataField="VendorAddress" HeaderText="Adres" SortExpression="VendorAddress" />
                    <asp:BoundField DataField="CityID" HeaderText="Şehir" SortExpression="CityID" />
                    <asp:BoundField DataField="VendorPhone" HeaderText="Telefon" SortExpression="VendorPhone" />
                    <asp:CommandField ButtonType="Button" CancelText="Vazgeç" DeleteText="Sil" EditText="Düzelt" InsertText="Ekle" NewText="Yeni" SelectText="Seç" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" UpdateText="Güncelle" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" Visible="False" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" DeleteCommand="DELETE FROM [Vendor] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Vendor] ([VendorName], [VendorAddress], [CityID], [VendorPhone], [VendorCode]) VALUES (@VendorName, @VendorAddress, @CityID, @VendorPhone, @VendorCode)" SelectCommand="SELECT [VendorName], [VendorAddress], [CityID], [VendorPhone], [VendorCode], [Id] FROM [Vendor] ORDER BY [VendorName]" UpdateCommand="UPDATE [Vendor] SET [VendorName] = @VendorName, [VendorAddress] = @VendorAddress, [CityID] = @CityID, [VendorPhone] = @VendorPhone, [VendorCode] = @VendorCode WHERE [Id] = @Id">
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
