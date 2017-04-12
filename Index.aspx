<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label5" runat="server" style="font-weight: 700; font-size: xx-large" Text="Livraria Leia Feliz ;)"></asp:Label>
        <br />
        <br />
    
        <asp:Label ID="lblUsuario" runat="server" Text="Usuário:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Label ID="lblMensagem" runat="server" Text="Mensagem"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
