<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterExp.aspx.cs" Inherits="DatabaseOp.RepeaterExp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table {
            border: 1px solid black;
            width: 350px;
            border-collapse: collapse;
        }

        td {
            border: 1px solid black;
            padding: 5px;
        }

        th {
            background-color: navy;
            color: white;
            border: 1px solid black;
            padding: 10px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
      <table>
          <tr>
              <th><b>Satıcı Adı</b></th>
              <th><b>Kodu</b></th>
              <th><b>Adres</b></th>
              <th><b>Şehir</b></th>
          </tr>
          <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
              <ItemTemplate>
                  <tr>
                      <td><%# DataBinder.Eval(Container.DataItem, "VendorName") %> </td>
                      <td><%# DataBinder.Eval(Container.DataItem, "VendorCode") %> </td>
                      <td><%# DataBinder.Eval(Container.DataItem, "VendorAddress") %> </td>
                      <td><%# DataBinder.Eval(Container.DataItem, "CityName") %> </td>
                  </tr>
 
              </ItemTemplate>
          </asp:Repeater>
    </table>



                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLConnectionString %>" SelectCommand="SELECT VendorCode, VendorName, VendorAddress, City.CityName, VendorPhone FROM Vendor
JOIN City ON Vendor.CityID = City.Id;"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
