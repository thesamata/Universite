<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs"
    Inherits="Web_Proje_SCB.About" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron jumbotron-fluid" style="background-color: #7c70e796;">
            <div class="container">
                <center>
                    <h1 class="mt-0">Hakkında</h1>
                </center>

                <p class="lead">
                </p>

            </div>
        </div>
        <center>
            <div class="alert alert-info" role="alert">
                <h1 class="mt-0">Çalışmalar</h1>
            </div>
        </center>
        <hr>
        <div class="card" style="float: left; width: 50%;">
            <iframe height="200px" src="https://www.youtube.com/embed/WGSct_eZ1bM" title="YouTube video player"
                frameborder="0"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"></iframe>
            <div class="card-body">
                <h5 class="card-title">Quntu Work </h5>
                <p class="card-text"></p>
            </div>
        </div>
        <div class="card" style="width: 50%;">
            <iframe height="200px" src="https://www.youtube.com/embed/A5w_21p4YvM" title="YouTube video player"
                frameborder="0"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"></iframe>
            <div class="card-body">
                <h5 class="card-title">Quntu Work </h5>
                <p class="card-text"></p>
            </div>
        </div>
    </asp:Content>
