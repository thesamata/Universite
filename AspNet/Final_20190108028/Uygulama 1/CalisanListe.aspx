<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalisanListe.aspx.cs"
    Inherits="Final_20190108028.CalisanListe" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:SqlDataSource ID="SqlDataSourceCALISAN" runat="server"
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
            SelectCommand="SELECT Calisan.Id, Calisan.Adi, Calisan.Soyadi, Calisan.TCKimlikNo, Calisan.Cinsiyet, Calisan.DogumYili, Calisan.BolumID, Calisan.UnvanID, Calisan.BasTarih, Calisan.BitTarih, Unvan.UnvanAdi, Bolum.BolumAdi FROM Calisan INNER JOIN Bolum ON Calisan.BolumID = Bolum.Id INNER JOIN Unvan ON Calisan.UnvanID = Unvan.Id">
        </asp:SqlDataSource>
             <center> <h1>ÇALIŞAN LİSTELE</h1> </center> 
        <br />
        <table class="table"
            style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; margin-top:50px;">
            <tr style="background-color: darkgray;">
                <th><b>Ad</b></th>
                <th><b>Soyad</b></th>
                <th><b>TC</b></th>
                <th><b>Cinsiyet</b></th>
                <th><b>Dogum Yılı</b></th>
                <th><b>Bolum</b></th>
                <th><b>Unvan</b></th>
                <th><b>Başlangıç Tarih</b></th>
                <th><b>Bitiş Tarih</b></th>
                <th><b>Güncelle</b></th>
            </tr>

            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSourceCALISAN">
                <ItemTemplate>
                    <tr style="background-color: lightgray;">
                        <td>
                            <%# DataBinder.Eval(Container.DataItem,"Adi") %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem, "Soyadi" ) %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem,"TCKimlikNo") %>
                        </td>
                        <td>
                            <%# Eval("Cinsiyet").ToString()=="E" ? "Erkek" : Eval("Cinsiyet").ToString()=="K" ? "Kadın"
                                : "" %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem,"DogumYili") %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem, "BolumAdi" ) %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem, "UnvanAdi" ) %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem, "BasTarih" ,"{0:MMMM d, yyyy}") %>
                        </td>
                        <td>
                            <%# DataBinder.Eval(Container.DataItem, "BitTarih" ,"{0:MMMM d, yyyy}") %>
                        </td>
                        <td>
                            <button type="button" class="btn btn-light"> <a href="CalisanGuncelle.aspx?idver=<%# Eval("Id") %> "> Detay </button>
                                    
                        </td>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </asp:Content>