<%@ Page Title="Detay" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detay.aspx.cs"
    Inherits="Web_Proje_SCB.Detay" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="jumbotron" style="width: 100%;">
            <asp:GridView ID="GridView1" class="table" style="width:200px" runat="server">
            </asp:GridView>

            <table class="table"
                style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; width:95%">
                <tr style="background-color: #4a50e796;">
                    <th><b>Ad Soyad</b></th>
                    <th><b>Cinsiyet</b></th>
                    <th><b>Uyruk</b></th>
                    <th><b>Dogum Tarihi</b></th>
                    <th><b>Email</b></th>
                    <th><b>Telefon</b></th>
                    <th><b>EgitimDurumu</b></th>
                    <th><b>Basvuru Sonucu</b></th>
                    <th><b>Cv Dosyası</b></th>
                </tr>
                <asp:Repeater ID="Repeater" runat="server">
                    <ItemTemplate>
                        <tr style="background-color: #7c70e796;">
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "AdSoyad" ) %>
                            </td>
                            <td>
                                <%# Eval("Cinsiyet").ToString()=="E" ? "Erkek" : Eval("Cinsiyet").ToString()=="K"
                                    ? "Kadın" : "" %>
                            </td>
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "UyrukId" ) %>
                            </td>
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "DogumTarihi" ,"{0:MMMM d, yyyy}") %>
                            </td>
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "Email" ) %>
                            </td>
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "Telefon" ) %>
                            </td>
                            <td>
                                <%# Eval("EgitimDurumu").ToString()=="L" ? "Lise" : Eval("EgitimDurumu").ToString()=="U"
                                    ? "Üniversite" : "" %>
                            </td>
                            <td>
                                <%# Eval("BasvuruSonucu").ToString()=="1" ? "Olumlu" :
                                    Eval("BasvuruSonucu").ToString()=="2" ? "Olumsuz" :
                                    Eval("BasvuruSonucu").ToString()=="" ? "Belirsiz" :"" %>
                            </td>
                            <td>
                                <%# Eval("OzgecmisDosyaAd").ToString()=="" ? "Cv Yok" :
                                    Eval("OzgecmisDosyaAd").ToString()!="" ? "" : "" %>
                                    <asp:LinkButton ID="Dowloand_Cv" runat="server" class="btn btn-outline-light" OnClick="Dowloand_File" visible ='<%# (Eval("OzgecmisDosyaAd").ToString()) == "" ? false : true %> '><img  style="height:35px" src="Photos/Basvuru/cv.png" /></asp:LinkButton>            
                            </td>

                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <center>
                <div class="alert alert-info" role="alert" style="width:70%">
                    <asp:RadioButtonList ID="sonucRB" runat="server">
                        <asp:ListItem Value="1">&nbsp;Olumlu</asp:ListItem>
                        <asp:ListItem Value="2">&nbsp;Olumsuz</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="sonucRB" ErrorMessage="Bu alanı seçmek zorunludur" ValidationGroup="ReqGr"></asp:RequiredFieldValidator>
                </div>
                <asp:Button ID="VeriUpdate" runat="server" Text="Güncelle" class="btn btn-info"
                    OnClick="veriUpdate_Click" ValidationGroup="ReqGr" />
            </center>
        </div>
    </asp:Content>
