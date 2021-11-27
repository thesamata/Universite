<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Urun.aspx.cs"
  Inherits="Shop_20190108028.Urun" %>
  <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="jumbotron">
      <table style="width: 100%">
        <tr>
          <td style="width: 410px">Ürün Adı :</td>
          <td style="padding-bottom: 2px; width: 396px">
            <asp:TextBox ID="txtUrunAdi" placeholder="Ürün Adı" runat="server"></asp:TextBox>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RqfUrunAdi" runat="server" ControlToValidate="txtUrunAdi"
              ErrorMessage="Ürün Adı Zorunludur" ForeColor="#0097A7" ValidationGroup="RqfUrun">*
            </asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 410px; height: 24px">Ürün Kodu :</td>
          <td style="padding-bottom: 2px; width: 396px; height: 24px">
            <asp:TextBox ID="txtUrunKodu" placeholder="Ürün Kodu" runat="server"></asp:TextBox>
          </td>
          <td style="height: 24px">
            <asp:RequiredFieldValidator ID="RqfUrunKodu" runat="server" ControlToValidate="txtUrunKodu"
              ErrorMessage="Ürün Adı Zorunludur" ForeColor="#0097A7" ValidationGroup="RqfUrun">*
            </asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 410px; height: 24px">Satıc</td>
          <td style="padding-bottom: 2px; width: 396px; height: 24px">
            <asp:DropDownList ID="ddlSatici" placeholder="Satıc" runat="server" AppendDataBoundItems="True"
              DataSourceID="SqlDataSource" DataTextField="SaticiAdi" DataValueField="Id">
              <asp:ListItem Value="0">Seçiniz </asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource" runat="server"
              ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
              SelectCommand="SELECT [Id], [SaticiAdi] FROM [Satici]"></asp:SqlDataSource>
          </td>
          <td style="height: 24px">
            <asp:RequiredFieldValidator ID="RqfSaticiAdi" runat="server" ControlToValidate="ddlSatici"
              ErrorMessage="Satıcı Seçimi Zorunludur" ForeColor="#0097A7" InitialValue="0" ValidationGroup="RqfUrun">*
            </asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="height: 24px; width: 410px">Birim Fiyatı :</td>
          <td style="padding-bottom: 2px; height: 24px; width: 396px">
            <asp:TextBox ID="txtBirimFiyat" placeholder="Birim Fiyatı" runat="server" TextMode="Number">
            </asp:TextBox>
          </td>
          <td style="height: 24px">
            <asp:RequiredFieldValidator ID="RqfBirimFiyat" runat="server" ControlToValidate="txtBirimFiyat"
              ErrorMessage="Ürün Birim fiyat zorunludur" ForeColor="#0097A7" ValidationGroup="RqfUrun">*
            </asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 410px">Stok Adedi :</td>
          <td style="padding-bottom: 2px; width: 396px">
            <asp:TextBox ID="txtStok" placeholder="Stok Adedi" runat="server" TextMode="Number">
            </asp:TextBox>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RqfUrunKodu0" runat="server" ControlToValidate="txtStok"
              ErrorMessage="Stok adet zorunludur" ForeColor="#0097A7" ValidationGroup="RqfUrun">*
            </asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtStok"
              ErrorMessage="Stok Adeti 0 İle 1000 Arası Olmalıdır" ForeColor="#0097A7" MaximumValue="1000"
              MinimumValue="0" ValidationGroup="RqfUrun">*</asp:RangeValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 410px">Açıklama :</td>
          <td style="padding-bottom: 2px; width: 396px">
            <asp:TextBox ID="txtAciklama" placeholder="Açıklama" runat="server" TextMode="MultiLine" Width="206px">
            </asp:TextBox>
          </td>
        </tr>
        <tr>
          <td style="width: 410px">Kaydet</td>
          <td style="padding-bottom: 2px; width: 396px">
            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click"
              ValidationGroup="RqfUrun" />
          </td>
        </tr>
      </table>


      <asp:SqlDataSource ID="UrunSqlDataSource" runat="server"
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Urun]">
      </asp:SqlDataSource>

      <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#0097A7" ValidationGroup="RqfUrun" />
    </div>
    <center>
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id"
        DataSourceID="UrunSqlDataSource">
        <Columns>
          <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
          <asp:BoundField DataField="UrunAdi" HeaderText="UrunAdi" SortExpression="UrunAdi" />
          <asp:BoundField DataField="UrunKodu" HeaderText="UrunKodu" SortExpression="UrunKodu" />
          <asp:BoundField DataField="SaticiID" HeaderText="SaticiID" SortExpression="SaticiID" />
          <asp:BoundField DataField="BirimFiyat" HeaderText="BirimFiyat" SortExpression="BirimFiyat" />
          <asp:BoundField DataField="StokAdedi" HeaderText="StokAdedi" SortExpression="StokAdedi" />
          <asp:BoundField DataField="Aciklama" HeaderText="Aciklama" SortExpression="Aciklama" />
        </Columns>
      </asp:GridView>
    </center>
  </asp:Content>