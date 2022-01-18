<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Uygulama_1.Defoult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/js/all.min.js">

    </script>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Test</title>
</head>
<body>
        
    <div class ="form">
     
    <form id="form1" runat="server">
         <div class="sm">
            <a href="#"> <i class ="fab fa-facebook-f"></i></a>
            <a href="#"> <i class ="fab fa-twitter"></i></a>
            <a href="#"> <i class ="fab fa-instagram"></i></a>
            <a href="#"> <i class ="fab fa-github"></i></a>         
        </div>

        <div>
            <asp:Label ID="Label1" runat="server"> <h1> Login </h1> </asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"  placeholder="@Username"> </asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="@Password" type="password"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" type="password"  />
        </div>
    </form>
    </div>

</body>
</html>
