<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Satici.aspx.cs"
  Inherits="Shop_20190108028.Satici" %>
  <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
      <table class="nav-justified">
        <tr>
          <td style="width: 461px">Satıcı Unvanı :</td>
          <td style="padding-bottom: 2px; width: 387px">
            <asp:TextBox ID="txtSaticiAdi" placeholder="Satıcı Ünvanı" runat="server"></asp:TextBox>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RqfSaticiUnvan" runat="server" ControlToValidate="txtSaticiAdi"
              ErrorMessage="Satıcı Ünvan Zorunludur" ForeColor="#0097A7" ValidationGroup="RqfSatci">*
            </asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="height: 27px; width: 461px">Satıcı Adresi :</td>
          <td style="padding-bottom: 2px; height: 27px; width: 387px">
            <asp:TextBox ID="txtSaticiAdres" placeholder="Satıcı Adresi" runat="server"></asp:TextBox>
          </td>

          <td>
            <asp:RequiredFieldValidator ID="RqfSaticiAdres" runat="server" ControlToValidate="txtSaticiAdres"
              ErrorMessage="Satıcı Adres Zorunludur" ForeColor="#0097A7" ValidationGroup="RqfSatci">*
            </asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 461px">Şehir :</td>
          <td style="padding-bottom: 2px; width: 387px">
            <asp:DropDownList ID="ddlSehir" placeholder="Şehir" runat="server" AppendDataBoundItems="True"
              DataSourceID="SCBSqlDataSource" DataTextField="Sehir" DataValueField="Id">
              <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SCBSqlDataSource" runat="server"
              ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
              SelectCommand="SELECT [Id], [Sehir], [TelefonKod] FROM [Sehir]"></asp:SqlDataSource>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RqfSehir" runat="server" ControlToValidate="ddlSehir"
              ErrorMessage="Şehir Zorunludur" ForeColor="#0097A7" ValidationGroup="RqfSatci" InitialValue="0">*
            </asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 461px; height: 24px">Telefon No :</td>
          <td style="padding-bottom: 2px; width: 387px; height: 24px">
            <asp:TextBox ID="txtTelefon" placeholder="Telefon No" runat="server" TextMode="Number"></asp:TextBox>
          </td>
          <td style="height: 24px">
            <asp:RequiredFieldValidator ID="RqfTelefon" runat="server" ControlToValidate="txtTelefon"
              ErrorMessage="Telefon Girmek Zorunludur" ForeColor="#0097A7" ValidationGroup="RqfSatci">*
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server"
              ControlToValidate="txtTelefon" ErrorMessage="Telefon 532-3334455 şeklinde olmalıdır" ForeColor="#0097A7"
              ValidationExpression="\d{3}\d{7}" ValidationGroup="RqfSatci">*</asp:RegularExpressionValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 461px; height: 24px">E-mail :</td>
          <td style="padding-bottom: 2px; width: 387px; height: 24px">
            <asp:TextBox ID="txtEmail" placeholder="Email" runat="server"></asp:TextBox>
          </td>
          <td style="height: 24px">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail"
              ErrorMessage="Email Girmek Zorunludur" ForeColor="#0097A7" ValidationGroup="RqfSatci">*
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ControlToValidate="txtEmail"
              ErrorMessage="Email Formatı Olmak Zorundadır" ForeColor="#0097A7"
              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="RqfSatci">*
            </asp:RegularExpressionValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 461px">Kaydet
          <td style="padding-bottom: 2px; width: 387px">
            <asp:Button ID="btnKaydet" placeholder="Kaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click"
              style="height: 26px" ValidationGroup="RqfSatci" />
          </td>
          <td></td>
        </tr>
      </table>
      <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        SelectCommand="SELECT * FROM [Satici]"></asp:SqlDataSource>
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#0097A7" ValidationGroup="RqfSatci" />
    </div>
      <center>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id"
          DataSourceID="SqlDataSource">
          <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="SaticiAdi" HeaderText="SaticiAdi" SortExpression="SaticiAdi" />
            <asp:BoundField DataField="SaticiAdres" HeaderText="SaticiAdres" SortExpression="SaticiAdres" />
            <asp:BoundField DataField="SehirID" HeaderText="SehirID" SortExpression="SehirID" />
            <asp:BoundField DataField="Telefon" HeaderText="Telefon" SortExpression="Telefon" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
          </Columns>
        </asp:GridView>
      </center>
  </asp:Content>