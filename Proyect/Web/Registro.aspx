<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyect.Web.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro</title>
    <link href="EstiloReg.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nombres"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Tipo de identificación"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
            <asp:ListItem>C.C</asp:ListItem>
            <asp:ListItem>T.I</asp:ListItem>
            <asp:ListItem>Pasaporte</asp:ListItem>
        </asp:RadioButtonList>
        &nbsp;<br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Identificación"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label> <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Femenino</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Tipo de usuario"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Fecha de nacimiento"></asp:Label>
        
        <br />
        <asp:Label ID="Label8" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Confirmar Contraseña"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Pregunta de seguridad "></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Respuesta"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
