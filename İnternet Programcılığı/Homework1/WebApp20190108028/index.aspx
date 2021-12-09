<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs"
Inherits="WebApp20190108028.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Şafak Ödev</title>

    <style type="text/css">
      .auto-style1 {
        height: 30px;
      }
      .auto-style2 {
        width: 89px;
      }
      .auto-style3 {
        height: 30px;
        width: 89px;
      }
    </style>
    <link href="ScbCss.css" rel="stylesheet" />
  </head>
  <body>
    <form id="form1" runat="server">
      <div class="form">
        <h1>Şafak Can Bav</h1>
        <table>
          <tr>
            <td>Ad Soyad</td>
            <td class="auto-style1">
              <asp:TextBox
                ID="txtAdSoyad"
                class="formtext"
                runat="server"
              ></asp:TextBox>
              <asp:RequiredFieldValidator
                ID="RqfAdSoyad"
                runat="server"
                ControlToValidate="txtAdSoyad"
                ErrorMessage="İsim Girmek Zorunludur"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >*</asp:RequiredFieldValidator
              >
            </td>
            <td class="auto-style2">Cinsiyet</td>
            <td class="auto-style1">
              <asp:RadioButtonList
                ID="RdCnsBtn"
                runat="server"
                RepeatDirection="Horizontal"
                AutoPostBack="True"
                OnSelectedIndexChanged="RdCnsBtn_SelectedIndexChanged"
              >
                <asp:ListItem Value="K" class="label">Kadın</asp:ListItem>
                <asp:ListItem Value="E" class="label">Erkek</asp:ListItem>
                <asp:ListItem Value="D" class="label">Diğer</asp:ListItem>
              </asp:RadioButtonList>
            </td>
          </tr>

          <tr>
            <td>Uyruk</td>
            <td class="auto-style1">
              <asp:DropDownList
                ID="DdlUyruk"
                class="droplist"
                runat="server"
                DataSourceID="SqlDataSource1"
                DataTextField="UlkeAdi"
                DataValueField="Id"
                AppendDataBoundItems="True"
              >
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
              </asp:DropDownList>
              <asp:SqlDataSource
                ID="SqlDataSource1"
                runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT [Id], [UlkeAdi] FROM [Ulke]"
              ></asp:SqlDataSource>
            </td>

            <td class="auto-style2">Doğum Tarihi</td>
            <td class="auto-style1">
              <asp:TextBox
                ID="txtDgmTrh"
                class="formtakvim"
                runat="server"
                TextMode="Date"
              ></asp:TextBox>
              <asp:RequiredFieldValidator
                ID="RqfDgmTrh"
                runat="server"
                ControlToValidate="txtDgmTrh"
                ErrorMessage="Doğum Tarihi Girmek Zorunludur"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >*</asp:RequiredFieldValidator
              >
            </td>
          </tr>
          <tr>
            <td class="auto-style1">Email</td>
            <td class="auto-style1">
              <asp:TextBox
                ID="txtEmail"
                class="formtext"
                runat="server"
                TextMode="Email"
              ></asp:TextBox>
              <asp:RequiredFieldValidator
                ID="RqfEmail"
                runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Email Girmek Zorunludur"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >*</asp:RequiredFieldValidator
              >
              <asp:RegularExpressionValidator
                ID="RegularExpressionValidator2"
                runat="server"
                ControlToValidate="txtEmail"
                ErrorMessage="Email Formatı Olmak Zorundadır"
                ForeColor="Red"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ValidationGroup="validgrup1"
                >*</asp:RegularExpressionValidator
              >
            </td>
            <td class="auto-style3">Sürücü Belgesi</td>
            <td class="auto-style1">
              <asp:DropDownList
                ID="DropDownList2"
                class="droplist"
                runat="server"
              >
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>A1</asp:ListItem>
                <asp:ListItem>A2</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>B2</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>D</asp:ListItem>
                <asp:ListItem>E</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
                <asp:ListItem>G</asp:ListItem>
                <asp:ListItem>H</asp:ListItem>
                <asp:ListItem>K</asp:ListItem>
                <asp:ListItem Value="UlsA">Uluslar Arası</asp:ListItem>
              </asp:DropDownList>
            </td>
          </tr>
          <tr>
            <td>Ülke</td>
            <td class="auto-style1">
              <asp:DropDownList
                ID="DdlUlke"
                class="droplist"
                runat="server"
                AppendDataBoundItems="True"
                AutoPostBack="True"
                DataSourceID="SqlDataSource1"
                DataTextField="UlkeAdi"
                DataValueField="Id"
              >
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
              </asp:DropDownList>
              <asp:RequiredFieldValidator
                ID="RqfUlke"
                runat="server"
                ControlToValidate="DdlUlke"
                ErrorMessage="Ülke Seçmek Zorunludur"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                InitialValue="0"
                >*</asp:RequiredFieldValidator
              >
            </td>

            <td class="auto-style2">İl</td>
            <td class="auto-style1">
              <asp:DropDownList
                ID="Ddlil"
                class="droplist"
                runat="server"
                AppendDataBoundItems="True"
                DataSourceID="SqlDataSource2"
                DataTextField="SehirAdi"
                DataValueField="Id"
                EnableViewState="False"
              >
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
              </asp:DropDownList>
              <asp:SqlDataSource
                ID="SqlDataSource2"
                runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT [Id], [SehirAdi] FROM [Sehir] WHERE ([UlkeId] = @UlkeId)"
              >
                <SelectParameters>
                  <asp:ControlParameter
                    ControlID="DdlUlke"
                    Name="UlkeId"
                    PropertyName="SelectedValue"
                    Type="Int32"
                  />
                </SelectParameters>
              </asp:SqlDataSource>
              <asp:RequiredFieldValidator
                ID="RqfIl"
                runat="server"
                ControlToValidate="Ddlil"
                ErrorMessage="İl Seçmek Zorunludur"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                InitialValue="0"
                >*</asp:RequiredFieldValidator
              >
            </td>
          </tr>
          <tr>
            <td>Telefon Numarası</td>
            <td class="auto-style1">
              <asp:TextBox
                ID="txtTelNo"
                class="formtext"
                runat="server"
                TextMode="Number"
              ></asp:TextBox>
              <asp:RequiredFieldValidator
                ID="RqfTelno"
                runat="server"
                ControlToValidate="txtTelNo"
                ErrorMessage="Telefon Girmek Zorunlu"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >*</asp:RequiredFieldValidator
              >
              <asp:RegularExpressionValidator
                ID="RegularExpressionValidator1"
                runat="server"
                ControlToValidate="txtTelNo"
                ErrorMessage="Telefon 532-3334455 şeklinde olmalıdır"
                ForeColor="Red"
                ValidationExpression="\d{3}\d{7}"
                ValidationGroup="validgrup1"
                >*</asp:RegularExpressionValidator
              >
            </td>
            <td class="auto-style2">Kariyer bilgisi</td>
            <td class="auto-style1">
              <asp:TextBox
                ID="txtKariyer"
                class="formtext"
                runat="server"
                TextMode="MultiLine"
                Width="181px"
              ></asp:TextBox>
            </td>
          </tr>

          <tr>
            <td>
              <asp:Label
                ID="lblAskr"
                runat="server"
                Text="Askerlik Durumu"
              ></asp:Label>
            </td>
            <td aria-orientation="horizontal" class="auto-style1">
              <asp:RadioButtonList
                ID="RdaskrBtn"
                runat="server"
                RepeatDirection="Horizontal"
              >
                <asp:ListItem class="label" Value="0">Yaptı</asp:ListItem>
                <asp:ListItem class="label" Value="1">Yapmadı</asp:ListItem>
              </asp:RadioButtonList>
            </td>
          </tr>
          <tr>
            <td>
              <hr />
            </td>
            <td>
              <hr />
            </td>
            <td class="auto-style2">
              <hr />
            </td>
            <td>
              <hr />
            </td>
          </tr>
          <tr>
            <td>Eğitim Durumu</td>
            <td>
              <asp:DropDownList
                ID="DdlEgtm"
                class="droplist"
                runat="server"
                AutoPostBack="True"
                OnSelectedIndexChanged="DdlEgtm_SelectedIndexChanged"
              >
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                <asp:ListItem Value="1">Lise</asp:ListItem>
                <asp:ListItem Value="2">Üniversite</asp:ListItem>
              </asp:DropDownList>
              <asp:RequiredFieldValidator
                ID="RqfEgtm"
                runat="server"
                ControlToValidate="DdlEgtm"
                ErrorMessage="Eğitim Durumu Seçmek Zorunlu"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                InitialValue="0"
                >*</asp:RequiredFieldValidator
              >
            </td>
          </tr>
          <tr>
            <td>Başlangıç Tarihi</td>
            <td>
              <asp:TextBox
                ID="TxtBsTrh"
                class="formtakvim"
                runat="server"
                TextMode="Date"
              ></asp:TextBox>
              <asp:RequiredFieldValidator
                ID="RqfBslngTrh"
                runat="server"
                ControlToValidate="TxtBsTrh"
                ErrorMessage="Başlangıç Tarihi Zorunlu"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >*</asp:RequiredFieldValidator
              >
            </td>
            <td class="auto-style2">Bitiş Tarihi</td>
            <td>
              <asp:TextBox
                ID="TxtBtsTrh"
                class="formtakvim"
                runat="server"
                TextMode="Date"
              ></asp:TextBox>
              <asp:RequiredFieldValidator
                ID="RqfBtsTrh"
                runat="server"
                ControlToValidate="TxtBtsTrh"
                ErrorMessage="Bitiş Tarihi Zorunlu"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >**</asp:RequiredFieldValidator
              >
            </td>
          </tr>
          <tr>
            <td>Devam Durumu</td>
            <td>
              <asp:CheckBox
                ID="CBDevam"
                class="label"
                runat="server"
                AutoPostBack="True"
                Text="Devam Ediyorum"
                OnCheckedChanged="CBDevam_CheckedChanged"
              />
            </td>
          </tr>
          <tr>
            <td class="auto-style2">
              <asp:Label
                ID="LiseLbl"
                runat="server"
                Text="Lise Adı"
              ></asp:Label>
              <asp:Label
                ID="UniLbl"
                runat="server"
                Text="Üniversite Adı"
              ></asp:Label>
            </td>
            <td class="auto-style2">
              <asp:DropDownList
                ID="DdlLise"
                class="droplist"
                runat="server"
                DataTextField="LiseAdi"
                DataValueField="Id"
                AppendDataBoundItems="True"
                DataSourceID="SqlDataSource3"
              >
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
              </asp:DropDownList>
              <asp:SqlDataSource
                ID="SqlDataSource3"
                runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT [Id], [LiseAdi] FROM [Lise]"
              ></asp:SqlDataSource>
              <asp:RequiredFieldValidator
                ID="RqfLise"
                runat="server"
                ControlToValidate="DdlLise"
                ErrorMessage="Lise Girmek  Zorunlu"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >*</asp:RequiredFieldValidator
              >
              <asp:DropDownList
                ID="DdUni"
                class="droplist"
                runat="server"
                DataTextField="UniversiteAdi"
                DataValueField="Id"
                AppendDataBoundItems="True"
                DataSourceID="SqlDataSource4"
              >
                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
              </asp:DropDownList>
              <asp:SqlDataSource
                ID="SqlDataSource4"
                runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT [Id], [UniversiteAdi] FROM [Universite]"
              ></asp:SqlDataSource>
              <asp:RequiredFieldValidator
                ID="RqfUni"
                runat="server"
                ControlToValidate="DdUni"
                ErrorMessage="Üniversite Girmek  Zorunlu"
                ForeColor="Red"
                ValidationGroup="validgrup1"
                >*</asp:RequiredFieldValidator
              >
            </td>
          </tr>
          <tr>
            <td>Özgeçmiş Dosyası</td>
            <td>
              <asp:FileUpload ID="FUBlg" class="formtext" runat="server" />
            </td>
          </tr>
          <tr>
            <td class="auto-style1">Gönder</td>
            <td class="auto-style1">
              <asp:CheckBox
                ID="KvkCB"
                runat="server"
                class="label"
                Text="Site kurallarını ve KVKK koşullarını kabul"
                AutoPostBack="True"
                OnCheckedChanged="CheckBox2_CheckedChanged"
              />
            </td>
            <td class="auto-style3"></td>
            <td class="auto-style1">
              <asp:Button
                ID="gndBtn"
                runat="server"
                Text="Deaktif"
                Enabled="False"
                ValidationGroup="validgrup1"
                OnClick="gndBtn_Click"
              />
            </td>
          </tr>
          <tr>
            <td>
              <asp:Label ID="LblBlg" runat="server"></asp:Label>
            </td>
            <td>
              <asp:ValidationSummary
                ID="ValidationSummary1"
                runat="server"
                ValidationGroup="validgrup1"
              />
            </td>
            <td class="auto-style2"></td>
            <td></td>
          </tr>
        </table>
      </div>
    </form>
  </body>
</html>
