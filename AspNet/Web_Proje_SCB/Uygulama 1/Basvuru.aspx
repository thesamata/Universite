<%@ Page Title="Basvuru" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Basvuru.aspx.cs"
    Inherits="Web_Proje_SCB.Basvuru" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron jumbotron-fluid">
            <center>
                <h5 class="mt-0">GENEL BİLGİLER</h5>
            </center>
            <table class="table">
                <tr>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">İsim</span>
                            </div>
                            <asp:TextBox ID="txtAdSoyad" class="form-control" runat="server" Width="200px">
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="RqfAdSoyad" runat="server" ControlToValidate="txtAdSoyad"
                                ErrorMessage="İsim Girmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                            </asp:RequiredFieldValidator>
                        </div>
                    </td>
                    <td>

                        <div class="input-group mb-3" aria-orientation="vertical">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Cinsiyet</span>
                            </div>
                            <asp:RadioButtonList ID="CinsiyetRB" runat="server" RepeatDirection="Horizontal"
                                Height="1px">
                                <asp:ListItem Value="K">Kadın</asp:ListItem>
                                <asp:ListItem Value="E">Erkek</asp:ListItem>
                            </asp:RadioButtonList>

                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Uyruk</span>
                            </div>
                            <asp:DropDownList ID="DdlUyruk" class="custom-select" runat="server"
                                AppendDataBoundItems="True" DataValueField="Id" Width="200px" ViewStateMode="Enabled"
                                DataTextField="UlkeAdi" DataSourceID="SqlDataSource_Ulke">
                                <asp:ListItem Value="0">Seçiniz</asp:ListItem>

                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RqfUyruk" runat="server" ControlToValidate="DdlUyruk"
                                ErrorMessage="Uyruk Seçmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1"
                                InitialValue="0">*
                            </asp:RequiredFieldValidator>
                            <asp:SqlDataSource ID="SqlDataSource_Ulke" runat="server"
                                ConnectionString="<%$ ConnectionStrings:ConnectionStringSCB %>"
                                SelectCommand="SELECT [Id], [UlkeAdi] FROM [Ulke]"></asp:SqlDataSource>

                        </div>
                    </td>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Dogum Tarihi</span>
                            </div>
                            <asp:TextBox ID="txtDgmTrh" runat="server" TextMode="Date" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RqfDgmTrh" runat="server" ControlToValidate="txtDgmTrh"
                                ErrorMessage="Doğum Tarihi Girmek Zorunludur" ForeColor="Red"
                                ValidationGroup="validgrup1">*
                            </asp:RequiredFieldValidator>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Email</span>
                            </div>
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RqfEmail" runat="server" ControlToValidate="txtEmail"
                                ErrorMessage="Email Girmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1">*
                            </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                                ControlToValidate="txtEmail" ErrorMessage="Email Formatı Olmak Zorundadır"
                                ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                ValidationGroup="validgrup1">*
                            </asp:RegularExpressionValidator>
                        </div>
                    </td>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Tel No</span>
                            </div>
                            <asp:TextBox ID="txtTelNo" class="form-control" runat="server" TextMode="Number"
                                Width="200px">
                            </asp:TextBox>
                            <asp:RequiredFieldValidator ID="RqfTelno" runat="server" ControlToValidate="txtTelNo"
                                ErrorMessage="Telefon Girmek Zorunlu" ForeColor="Red" ValidationGroup="validgrup1">*
                            </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                ControlToValidate="txtTelNo" ErrorMessage="Telefon 532-3334455 şeklinde olmalıdır"
                                ForeColor="Red" ValidationExpression="\d{3}\d{7}" ValidationGroup="validgrup1">*
                            </asp:RegularExpressionValidator>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="input-group mb-3" style="left: 0px; top: 0px">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Ülke</span>
                            </div>
                            <asp:DropDownList ID="DdlUlke" class="custom-select" runat="server"
                                AppendDataBoundItems="True" DataValueField="Id" Width="200px" ViewStateMode="Enabled"
                                EnableViewState="False" AutoPostBack="True" DataTextField="UlkeAdi"
                                DataSourceID="SqlDataSource_Ulke">
                                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RqfUlke" runat="server" ControlToValidate="DdlUlke"
                                ErrorMessage="Ülke Seçmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1"
                                InitialValue="0">*
                            </asp:RequiredFieldValidator>

                        </div>
                    </td>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Sehir</span>
                            </div>
                            <asp:DropDownList ID="Ddlil" class="custom-select" runat="server" DataTextField="SehirAdi"
                                DataValueField="Id" AppendDataBoundItems="True" AutoPostBack="True" Width="200px"
                                DataSourceID="SqlDataSource_Sehir" EnableViewState="False">
                                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RqfIl" runat="server" ControlToValidate="Ddlil"
                                ErrorMessage="İl Seçmek Zorunludur" ForeColor="Red" ValidationGroup="validgrup1"
                                InitialValue="0">*
                            </asp:RequiredFieldValidator>

                            <asp:SqlDataSource ID="SqlDataSource_Sehir" runat="server"
                                ConnectionString="<%$ ConnectionStrings:ConnectionStringSCB %>"
                                SelectCommand="SELECT [Id], [SehirAdi] FROM [Sehir] WHERE ([UlkeId] = @UlkeId)">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="DdlUlke" Name="UlkeId" PropertyName="SelectedValue"
                                        Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>


                        </div>
                    </td>
                </tr>
            </table>

            <hr />
            <center>
                <h5 class="mt-0">EĞİTİM BİLGİLERİ</h5>
            </center>
            <hr />

            <table class="table">
                <tr>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Açıklama</span>
                            </div>
                            <asp:TextBox ID="txtKariyer" class="form-control" runat="server" TextMode="MultiLine"
                                Width="200px">
                            </asp:TextBox>
                        </div>
                    </td>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Eğitim Durumu</span>
                            </div>
                            <asp:DropDownList ID="DdlEgitmDurum" class="custom-select" runat="server" Width="200px"
                                AutoPostBack="True">
                                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                                <asp:ListItem Value="L">Lise</asp:ListItem>
                                <asp:ListItem Value="U">Üniversite</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RqfEgtm" runat="server" ControlToValidate="DdlEgitmDurum"
                                ErrorMessage="Eğitim Durumu Seçmek Zorunlu" ForeColor="Red" ValidationGroup="validgrup1"
                                InitialValue="0">*</asp:RequiredFieldValidator>
                        </div>
                        <span>Devam ediyorum</span>
                        <asp:CheckBox ID="devamCB" runat="server" AutoPostBack="True" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Başlangıç Tarihi</span>
                            </div>
                            <asp:TextBox ID="TxtBsTrh" runat="server" TextMode="Date" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RqfBslngTrh" runat="server" ControlToValidate="TxtBsTrh"
                                ErrorMessage="Başlangıç Tarihi Zorunlu" ForeColor="Red" ValidationGroup="validgrup1">*
                            </asp:RequiredFieldValidator>
                        </div>
                    </td>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <span class="input-group-text">Bitiş Tarihi</span>
                            </div>
                            <asp:TextBox ID="TxtBtsTrh" runat="server" TextMode="Date" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RqfBtsTrh" runat="server" ControlToValidate="TxtBtsTrh"
                                ErrorMessage="Bitiş Tarihi Zorunlu" ForeColor="Red" ValidationGroup="validgrup1">**
                            </asp:RequiredFieldValidator>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <asp:Label ID="LiseLbl" class="input-group-text" runat="server" Text="Lise"></asp:Label>

                            </div>
                            <asp:DropDownList ID="DdlLise" class="custom-select" runat="server"
                                DataSourceID="SqlDataSource_Lise" DataTextField="LiseAdi" DataValueField="Id"
                                Width="200px" AppendDataBoundItems="True">
                                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RqfLise" runat="server" ControlToValidate="DdlLise"
                                ErrorMessage="Lise girmek Zorunlu" ForeColor="Red" ValidationGroup="validgrup1"
                                InitialValue="0">*
                            </asp:RequiredFieldValidator>
                            <asp:SqlDataSource ID="SqlDataSource_Lise" runat="server"
                                ConnectionString="<%$ ConnectionStrings:ConnectionStringSCB %>"
                                SelectCommand="SELECT [Id], [LiseAdi] FROM [Lise]"></asp:SqlDataSource>
                        </div>
                        <div class="input-group mb-3">
                            <div class="input-group-prepend">
                                <asp:Label ID="uniAdiLbl" class="input-group-text" runat="server" Text="Üniversite">
                                </asp:Label>

                            </div>
                            <asp:DropDownList ID="DdlUni" class="custom-select" runat="server"
                                DataSourceID="SqlDataSource_Uni" DataTextField="UniversiteAdi" DataValueField="Id"
                                Width="200px" AppendDataBoundItems="True">
                                <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RqfUni" runat="server" ControlToValidate="DdlUni"
                                ErrorMessage="Üniversite girmek Zorunlu" ForeColor="Red" ValidationGroup="validgrup1"
                                InitialValue="0">*
                            </asp:RequiredFieldValidator>
                            <asp:SqlDataSource ID="SqlDataSource_Uni" runat="server"
                                ConnectionString="<%$ ConnectionStrings:ConnectionStringSCB %>"
                                SelectCommand="SELECT [Id], [UniversiteAdi] FROM [Universite]"></asp:SqlDataSource>
                        </div>
                    </td>
                    <td>
                        <div class="custom-file">
                            <asp:FileUpload ID="FUBlg" runat="server" Width="200px" />
                            <label for="customFile">Özgeçmiş Dosyası </label>
                        </div>

                    </td>
                </tr>
                <tr>
                    <td>
                        <span>Site kurallarını ve KVKK koşullarını kabul ediyorum<br />
                        </span>
                        &nbsp;
                        <asp:CheckBox ID="kktcCB" runat="server" AutoPostBack="True"
                            OnCheckedChanged="kktcCB_CheckedChanged" />
                    </td>
                </tr>
            </table>
            <center>
                <asp:Button ID="GonderButton" class="btn btn-dark" runat="server" Text="Deaktif"
                    OnClick="GonderButton_Click" ValidationGroup="validgrup1" Enabled="False" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="validgrup1" />
            </center>
        </div>
    </asp:Content>
