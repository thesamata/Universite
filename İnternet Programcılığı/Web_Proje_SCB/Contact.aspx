<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
  CodeBehind="Contact.aspx.cs" Inherits="Web_Proje_SCB.Contact" %>

  <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <center>
      <div class="jumbotron" style="width: 80%; background-color: #4a50e796;">

        <h5 class="mt-0">İletişim Bilgileri</h5>
        <hr>
        <div class="alert alert-light" role="alert">
          <p>Bize email ile ulaşabilirsiniz</p>
          <p>info@quntu.com</p>
          Çalışma saatlerimiz:
          <br>
          Hafta içi: 8:00 - 18:00
          <br>
          Cumartesi: 9:00 - 13:30
        </div>
        <hr>
        <h5 class="mt-0">İletişim</h5>
        <div class="form-group">
          <label for="exampleFormControlInput1">Name</label>
          <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="@Name">
        </div>

        <div class="form-group">
          <label for="exampleFormControlInput1">Email address</label>
          <input type="email" class="form-control" id="exampleFormControlInput2" placeholder="name@example.com">
        </div>

        <div class="form-group">
          <label for="exampleFormControlTextarea1">Explanation</label>
          <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
        </div>
        <asp:Button ID="GndrBTN" class="btn btn-dark" runat="server" Text="Gönder" OnClick="Button1_Click" />

      </div>
      <!-- Map -->
      <div id="contact" class="map">
        <iframe width="100%" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"
          src="https://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Twitter,+Inc.,+Market+Street,+San+Francisco,+CA&amp;aq=0&amp;oq=twitter&amp;sll=28.659344,-81.187888&amp;sspn=0.128789,0.264187&amp;ie=UTF8&amp;hq=Twitter,+Inc.,+Market+Street,+San+Francisco,+CA&amp;t=m&amp;z=15&amp;iwloc=A&amp;output=embed"></iframe>
        <br />
        <small>
          <a
            href="https://maps.google.com/maps?f=q&amp;source=embed&amp;hl=en&amp;geocode=&amp;q=Twitter,+Inc.,+Market+Street,+San+Francisco,+CA&amp;aq=0&amp;oq=twitter&amp;sll=28.659344,-81.187888&amp;sspn=0.128789,0.264187&amp;ie=UTF8&amp;hq=Twitter,+Inc.,+Market+Street,+San+Francisco,+CA&amp;t=m&amp;z=15&amp;iwloc=A"></a>
        </small>
      </div>
      <!-- /Map -->
    </center>
  </asp:Content>
