<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarUsuario.aspx.cs" Inherits="Usuarios_CadastrarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCadastroUsuario" runat="server" Text="Cadastrar Usuário"></asp:Label>
        <p>
            <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSobreNome" runat="server" Text="SobreNome:"></asp:Label>
            <asp:TextBox ID="txtSobreNome" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblNomeUsuario" runat="server" Text="Nome do Usuario:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />
        </p>
        <p>
            <asp:Label ID="lblMensagem" runat="server" Text="Mensagem"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        </p>
    </form>
</body>
</html>
