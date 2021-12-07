<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewExp.aspx.cs" Inherits="DatabaseOp.ListViewExp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="3">
                <AlternatingItemTemplate>
                    <td runat="server" style="background-color: #FFFFFF;color: #284775;">VendorName:
                        <asp:Label ID="VendorNameLabel" runat="server" Text='<%# Eval("VendorName") %>' />
                        <br />VendorAddress:
                        <asp:Label ID="VendorAddressLabel" runat="server" Text='<%# Eval("VendorAddress") %>' />
                        <br />CityID:
                        <asp:Label ID="CityIDLabel" runat="server" Text='<%# Eval("CityID") %>' />
                        <br />VendorPhone:
                        <asp:Label ID="VendorPhoneLabel" runat="server" Text='<%# Eval("VendorPhone") %>' />
                        <br />VendorCode:
                        <asp:Label ID="VendorCodeLabel" runat="server" Text='<%# Eval("VendorCode") %>' />
                        <br /></td>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <td runat="server" style="background-color: #999999;">VendorName:
                        <asp:TextBox ID="VendorNameTextBox" runat="server" Text='<%# Bind("VendorName") %>' />
                        <br />VendorAddress:
                        <asp:TextBox ID="VendorAddressTextBox" runat="server" Text='<%# Bind("VendorAddress") %>' />
                        <br />CityID:
                        <asp:TextBox ID="CityIDTextBox" runat="server" Text='<%# Bind("CityID") %>' />
                        <br />VendorPhone:
                        <asp:TextBox ID="VendorPhoneTextBox" runat="server" Text='<%# Bind("VendorPhone") %>' />
                        <br />VendorCode:
                        <asp:TextBox ID="VendorCodeTextBox" runat="server" Text='<%# Bind("VendorCode") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        <br /></td>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
<td runat="server" />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <InsertItemTemplate>
                    <td runat="server" style="">VendorName:
                        <asp:TextBox ID="VendorNameTextBox" runat="server" Text='<%# Bind("VendorName") %>' />
                        <br />VendorAddress:
                        <asp:TextBox ID="VendorAddressTextBox" runat="server" Text='<%# Bind("VendorAddress") %>' />
                        <br />CityID:
                        <asp:TextBox ID="CityIDTextBox" runat="server" Text='<%# Bind("CityID") %>' />
                        <br />VendorPhone:
                        <asp:TextBox ID="VendorPhoneTextBox" runat="server" Text='<%# Bind("VendorPhone") %>' />
                        <br />VendorCode:
                        <asp:TextBox ID="VendorCodeTextBox" runat="server" Text='<%# Bind("VendorCode") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        <br /></td>
                </InsertItemTemplate>
                <ItemTemplate>
                    <td runat="server" style="background-color: #E0FFFF;color: #333333;">Satıcı Adı:
                        <asp:Label ID="VendorNameLabel" runat="server" Text='<%# Eval("VendorName") %>' />
                        <br />Adres:
                        <asp:Label ID="VendorAddressLabel" runat="server" Text='<%# Eval("VendorAddress") %>' />
                        <br />CityID:
                        <asp:Label ID="CityIDLabel" runat="server" Text='<%# Eval("CityID") %>' />
                        <br />VendorPhone:
                        <asp:Label ID="VendorPhoneLabel" runat="server" Text='<%# Eval("VendorPhone") %>' />
                        <br />VendorCode:
                        <asp:Label ID="VendorCodeLabel" runat="server" Text='<%# Eval("VendorCode") %>' />
                        <br /></td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                                <asp:DataPager ID="DataPager1" runat="server" PageSize="12">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <td runat="server" style="background-color: #E2DED6;font-weight: bold;color: #333333;">VendorName:
                        <asp:Label ID="VendorNameLabel" runat="server" Text='<%# Eval("VendorName") %>' />
                        <br />VendorAddress:
                        <asp:Label ID="VendorAddressLabel" runat="server" Text='<%# Eval("VendorAddress") %>' />
                        <br />CityID:
                        <asp:Label ID="CityIDLabel" runat="server" Text='<%# Eval("CityID") %>' />
                        <br />VendorPhone:
                        <asp:Label ID="VendorPhoneLabel" runat="server" Text='<%# Eval("VendorPhone") %>' />
                        <br />VendorCode:
                        <asp:Label ID="VendorCodeLabel" runat="server" Text='<%# Eval("VendorCode") %>' />
                        <br /></td>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT [VendorName], [VendorAddress], [CityID], [VendorPhone], [VendorCode] FROM [Vendor]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
