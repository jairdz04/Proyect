﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerificarCod.aspx.cs" Inherits="Proyect.Web.VerificarCod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Verificación codigo</title>
     <link href="EstiloReg.css" rel="stylesheet" type="text/css" media="all" />
     
</head>
<body>
    <form id="form1" runat="server">
       
    <div>

        
         
    
         
 
    
        <asp:Label ID="Label1" runat="server" Text="Digite código"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Verificar" />
        <br />

        
         
    
         
 
    
    </div>
    </form>
</body>
</html>
