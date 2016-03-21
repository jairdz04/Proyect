<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Proyect.Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    

   <link href="EstiloIndex.css" rel="stylesheet" type="text/css" media="all" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="Contenedor">
    
 
   <div id="user">
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="TextBox1" runat="server" Height="15px" Width="120px"></asp:TextBox>
   </div>
        
                                                                       <br />
        
   <div id="pass">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" OnTextChanged="TextBox2_TextChanged" Height="15px" Width="120px" ></asp:TextBox>

   </div>
    

       
    <div id="log">
        &nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Login" Height="31px" Width="83px"  />
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Registrarme" Height="31px" Width="83px" OnClick="Button2_Click" />
    </div>   

 


    </div>
    </form>
</body>
</html>
