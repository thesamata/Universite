<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataListExp.aspx.cs" Inherits="DatabaseOp.DataListExp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid black;
            background-color: white;
        }
        .auto-style2 {
            width: 229px;
        }
        .auto-style3 {
            width: 298px;
        }
        .auto-style4 {
            width: 314px;
        }
        .auto-style5 {
            width: 290px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
                <HeaderTemplate>
                    <br />
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2"><strong>Satıcı Adı</strong></td>
                            <td class="auto-style3"><strong>Satıcı Kodu</strong></td>
                            <td class="auto-style4"><strong>Adres</strong></td>
                            <td class="auto-style5"><strong>Şehir</strong></td>
                            <td><strong>Telefon</strong></td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style2">
                                <asp:Label ID="VendorNameLabel" runat="server" Text='<%# Eval("VendorName") %>' />
                            </td>
                            <td class="auto-style3">
                                <asp:Label ID="VendorCodeLabel" runat="server" Text='<%# Eval("VendorCode") %>' />
                            </td>
                            <td class="auto-style4">
                                <asp:Label ID="VendorAddressLabel" runat="server" Text='<%# Eval("VendorAddress") %>' />
                            </td>
                            <td class="auto-style5">
                                <asp:Label ID="CityIDLabel" runat="server" Text='<%# Eval("CityID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="VendorPhoneLabel" runat="server" Text='<%# Eval("VendorPhone") %>' />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT [VendorName], [VendorAddress], [CityID], [VendorPhone], [VendorCode] FROM [Vendor]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
