<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalisanEkle.aspx.cs"
    Inherits="Final_20190108028.CalisanEkle" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <center>
            <h1>ÇALIŞAN EKLE</h1>
        </center>
        <table class="table" style="margin-top:50px; background-color: lightgrey">
            <tr>
                <td>Adı</td>
                <td>
                    <asp:TextBox ID="txtAd" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RqfAd" runat="server" ControlToValidate="txtAd"
                        ErrorMessage="İsim Girmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Soyadı</td>
                <td>
                    <asp:TextBox ID="txtSoyad" class="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RqfSoyad" runat="server" ControlToValidate="txtSoyad"
                        ErrorMessage="Soyad Girmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                    </asp:RequiredFieldValidator>
                </td>

            </tr>
            <tr>
                <td>TC Kimlik No </td>
                <td>
                    <asp:TextBox ID="txtTC" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RqfTc" runat="server" ControlToValidate="txtTC"
                        ErrorMessage="Tc 11 haneli olmalıdır" ValidationExpression="\d{9}\d{2}" ForeColor="Red"
                        ValidationGroup="validgrup1">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RqfTcBosmu" runat="server" ControlToValidate="txtTC"
                        ErrorMessage="Tc Girmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Cinsiyet</td>
                <td>
                    <asp:RadioButtonList ID="RBCinsiyet" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="E">Erkek</asp:ListItem>
                        <asp:ListItem Value="K">Kadın</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RqfCinsiyet" runat="server" ControlToValidate="RBCinsiyet"
                        ErrorMessage="Cinsiyet Seçmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Doğum Yılı</td>
                <td>
                    <asp:TextBox ID="txtDogum" class="form-control" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RangeValidator ID="RqfDgmTrhRang" runat="server" ControlToValidate="txtDogum"
                        ErrorMessage="1950 – 2004 arasında bilgi girilmelidir" ForeColor="Red" MaximumValue="2004"
                        MinimumValue="1950" ValidationGroup="validgrup1">*
                    </asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="RqfDgmTrh" runat="server" ControlToValidate="txtDogum"
                        ErrorMessage="Doğum Tarihi zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Bölüm</td>
                <td>
                    <asp:DropDownList ID="DdlBolum" class="form-control" runat="server"
                        DataSourceID="SqlDataSourceBOLUM" DataTextField="BolumAdi" DataValueField="Id"
                        AppendDataBoundItems="True">
                        <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSourceBOLUM" runat="server"
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                        SelectCommand="SELECT [Id], [BolumAdi] FROM [Bolum]"></asp:SqlDataSource>
                    <asp:RequiredFieldValidator ID="RqfBolum" runat="server" ControlToValidate="DdlBolum"
                        ErrorMessage="Bölüm zorunludur" ForeColor="Red" ValidationGroup="validgrup1" InitialValue="0">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Unvan</td>
                <td>
                    <asp:DropDownList ID="DdlUnvan" class="form-control" runat="server" AppendDataBoundItems="True"
                        DataSourceID="SqlDataSourceUNVAN" DataTextField="UnvanAdi" DataValueField="Id">
                        <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSourceUNVAN" runat="server"
                        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                        SelectCommand="SELECT [UnvanAdi], [Id] FROM [Unvan]"></asp:SqlDataSource>
                    <asp:RequiredFieldValidator ID="RqfUnvan" runat="server" ControlToValidate="DdlUnvan"
                        ErrorMessage="Unvan zorunludur" ForeColor="Red" ValidationGroup="validgrup1" InitialValue="0">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Başlangıç Tarihi</td>
                <td>
                    <asp:TextBox ID="txtBasTrh" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RqfBasTrh" runat="server" ControlToValidate="txtBasTrh"
                        ErrorMessage="Başlangıç Tarihi zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Bitiş Tarihi </td>
                <td>
                    <asp:TextBox ID="txtBtsTrh" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
                    <asp:CompareValidator ID="CValidTrh" runat="server" ControlToCompare="txtBasTrh"
                        ControlToValidate="txtBtsTrh" ErrorMessage="Bitiş Tarihi Başlangıç Tarihinden küçük olamaz"
                        ForeColor="Red" ValidationGroup="validgrup1" Operator="GreaterThanEqual">*
                    </asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Kaydet</td>
                <td>
                    <asp:Button ID="btnKayit" class="btn btn-info" runat="server" Text="Kaydet"
                        OnClick="btnKayit_Click" ValidationGroup="validgrup1" />
                </td>
            </tr>
        </table>
        <center>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validgrup1" />
        </center>
    </asp:Content>