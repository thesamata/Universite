<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Web_Proje_SCB._Default" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron jumbotron-fluid" style="background-color: #7c70e796;">
            <div class="container">
                <div class="media">
                    <img class="mr-3" style="height: 100px;" src="Photos/Logolar/LogoGif-unscreen.gif"
                        alt="Generic placeholder image">
                    <div class="media-body">
                        <h5 class="mt-0">Quntu Nedir</h5>
                        <p class="lead">Quntu bizim Oyun, Yazılım, Tasarım ve diğer bir çok IT üzerine olan işleri
                            yaptığımız
                            minik bir Şirkettir. Eger bizimle çalışmak isterseniz yukarıdaki görselden veya buradan
                            ulaşabilirsiniz
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img class="d-block w-100" src="Photos/Slider/Photo1.png" alt="First slide" />
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100" src="Photos/Slider/Photo2.png" alt="Second slide" />
                </div>
                <div class="carousel-item">
                    <img class="d-block w-100" src="Photos/Slider/Photo3.png" alt="Third slide" />
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>

    </asp:Content>
