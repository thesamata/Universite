<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Basvuru.aspx.cs" Inherits="Week3.Basvuru" %>

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
            width: 303px;
        }
        .auto-style3 {
            width: 303px;
            height: 37px;
        }
        .auto-style4 {
            height: 37px;
        }
        .auto-style5 {
            width: 303px;
            height: 38px;
        }
        .auto-style6 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Başvuru Formu<br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Ad Soyad</td>
                    <td>
                        <asp:TextBox ID="txAdSoyad" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Başlangıç Tarihi</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txBaslangic" runat="server" Width="300px" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Yaş</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txYas" runat="server" Width="300px" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Cinsiyet</td>
                    <td>
                        <asp:RadioButton ID="rbCinsiyetK" runat="server" GroupName="cc" Text="Kadın" />
&nbsp;<asp:RadioButton ID="rbCinsiyetE" runat="server" GroupName="cc" Text="Erkek" />
                        <br />
                        <asp:RadioButtonList ID="rblCinsiyet" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="K">Kadın</asp:ListItem>
                            <asp:ListItem Value="E">Erkek</asp:ListItem>
                            <asp:ListItem Value="D">Diğer</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">E-mail</td>
                    <td>
                        <asp:TextBox ID="txEmail" runat="server" Width="300px" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="txPassword1" runat="server" Width="300px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password (tekrar)</td>
                    <td>
                        <asp:TextBox ID="txPassword2" runat="server" Width="300px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Bildiğiniz Diller</td>
                    <td>
                        <asp:CheckBoxList ID="cblDiller" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                            <asp:ListItem Value="ENG">İngilizce</asp:ListItem>
                            <asp:ListItem Value="DE">Almanca</asp:ListItem>
                            <asp:ListItem Value="RUS">Rusça</asp:ListItem>
                            <asp:ListItem Value="CHI">Çince</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">İl</td>
                    <td>
                        <asp:DropDownList ID="ddlSehir" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Sehir" DataValueField="Id" Width="300px">
                            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Id], [Sehir] FROM [Sehir]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">İlçe</td>
                    <td>
                        <asp:DropDownList ID="ddlIlce" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource2" DataTextField="IlceAdi" DataValueField="ID" EnableViewState="False" Width="300px">
                            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ID], [IlceAdi] FROM [Ilce] WHERE ([SehirID] = @SehirID)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="ddlSehir" Name="SehirID" PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">CV Dosyası</td>
                    <td>
                        <asp:FileUpload ID="fupCV" runat="server" />
&nbsp;&nbsp;
                        <asp:Button ID="btnFileUpload" runat="server" OnClick="btnFileUpload_Click" Text="Dosyayı Yükle" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        <asp:CheckBox ID="cbKabul" runat="server" AutoPostBack="True" OnCheckedChanged="cbKabul_CheckedChanged" Text="Site kurallarını kabul ediyorum." />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnGonder" runat="server" Text="Başvuruyu Gönder" OnClick="btnGonder_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
