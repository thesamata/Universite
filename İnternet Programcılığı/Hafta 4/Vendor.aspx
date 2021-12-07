<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="DatabaseOp.Vendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #0033cc;
            background-color: #e9e9e9;
        }
        .auto-style2 {
            width: 277px;
        }
        .auto-style3 {
            width: 277px;
            height: 37px;
        }
        .auto-style4 {
            height: 37px;
        }
        .auto-style5 {
            width: 277px;
            height: 118px;
        }
        .auto-style6 {
            height: 118px;
        }
    </style>
</head>
<body>
    <h1>Satıcı Bilgisi Ekleme</h1>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Satıcı Kodu</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtVCode" runat="server" Width="400px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtVCode" ErrorMessage="Satıcı kodu girilmelidir." ForeColor="Red" ValidationGroup="val1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Satıcı Adı</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtVName" runat="server" Width="400px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtVName" ErrorMessage="Satıcı adı girilmelidir." ForeColor="Red" ValidationGroup="val1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Satıcı Adresi</td>
            <td>
                <asp:TextBox ID="txtVAddress" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">İl</td>
            <td class="auto-style6">
                <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource1" DataTextField="CityName" DataValueField="Id">
                    <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT [Id], [CityName] FROM [City] ORDER BY [CityName]"></asp:SqlDataSource>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="İl seçilmelidir." ForeColor="Red" InitialValue="0" ValidationGroup="val1">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Telefon No</td>
            <td>
                <asp:TextBox ID="txtVPhone" runat="server" Width="400px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <br />
                <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" ValidationGroup="val1" Width="150px" />
                <asp:Button ID="btnAra" runat="server" Text="Tabloda Ara"  Width="150px" OnClick="btnAra_Click" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle"  Width="150px" OnClick="btnGuncelle_Click" />
                <asp:Button ID="btnGuncelleId" runat="server" Text="Güncelle - Id"  Width="150px" OnClick="btnGuncelleId_Click"/>
                <asp:Button ID="btnSil" runat="server" Text="Sil"  Width="150px" OnClick="btnSil_Click" />
            </td>
        </tr>
    </table>
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="val1" />
            <br />
        </div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
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
    </form>
</body>
</html>
