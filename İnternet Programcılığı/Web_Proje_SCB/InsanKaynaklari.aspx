<%@ Page Title="Ik" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="InsanKaynaklari.aspx.cs" Inherits="Web_Proje_SCB.InsanKaynaklari" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron jumbotron-fluid">
            <asp:SqlDataSource ID="SqlDataSource_Grid" runat="server"
                ConnectionString="<%$ ConnectionStrings:ConnectionStringSCB %>"
                SelectCommand="SELECT Basvuru.Id, Basvuru.AdSoyad, Basvuru.Cinsiyet, Basvuru.UyrukId, Basvuru.DogumTarihi, Basvuru.Email, Basvuru.Telefon, Basvuru.EgitimDurumu, Basvuru.BasvuruSonucu, Ulke.UlkeAdi FROM Basvuru INNER JOIN Ulke ON Basvuru.UyrukId = Ulke.Id">
            </asp:SqlDataSource>
            <center>
           <table class="table" style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; width:95%">
                <tr style="background-color: #4a50e796;">
                    <th><b>Ad Soyad</b></th>
                    <th><b>Cinsiyet</b></th>
                    <th><b>Uyruk</b></th>
                    <th><b>Dogum Tarihi</b></th>
                    <th><b>Email</b></th>
                    <th><b>Telefon</b></th>
                    <th><b>Egitim Durumu</b></th>
                    <th><b>Basvuru Sonucu</b></th>
                    <th><b>Detay</b></th>
                    <th><b>Sil</b></th>
                </tr>
                <asp:Repeater ID="Repeater" runat="server" DataSourceID="SqlDataSource_Grid">
                    <ItemTemplate>
                        <tr style="background-color: #7c70e796;">
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "AdSoyad" ) %>
                            </td>
                            <td>
                                <%# Eval("Cinsiyet").ToString()=="E" ? "Erkek" : 
                                    Eval("Cinsiyet").ToString()=="K" ? "Kadın" : "" %>        
                            </td>
                            <td>
                                <%# DataBinder.Eval(Container.DataItem, "UlkeAdi" ) %>
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
                                    Eval("BasvuruSonucu").ToString()=="2" ? "Olumsuz" :"" %>
                                  
                            </td>       
                            <td><button type="button" class="btn btn-outline-light"> <a href="Detay.aspx?idver=<%# Eval("id") %>"><img  style="height:20px" src="Photos/Basvuru/detay.png" /> </a>  </button></td>
                            <td><button type="button" class="btn btn-outline-danger"> <a href="Delete.aspx?idver=<%# Eval("id") %>"><img  style="height:20px" src="Photos/Basvuru/trash.png" /> </a>  </button></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
                </center>
        </div>
    </asp:Content>
