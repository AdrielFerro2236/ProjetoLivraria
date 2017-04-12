<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PainelAdmin.aspx.cs" Inherits="PainelAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label5" runat="server" Text="Label - "></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx" style="text-decoration: underline">Sair</asp:HyperLink>
        <br />
        <br />
    
        <asp:Label ID="Label4" runat="server" style="font-weight: 700; font-size: xx-large" Text="Livraria Leia Feliz :)"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="lblAdmin" runat="server" style="font-weight: 700" Text="Painel Administrativo"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblUsuario" runat="server" style="font-weight: 700" Text="Usuário"></asp:Label>
        </p>
        <ul>
            <li>
                <asp:Label ID="lblCadastrar" runat="server" Text="Cadastrar Novo"></asp:Label>
            </li>
            <li>
                <asp:Label ID="lblListarTodos" runat="server" Text="Listar Todos"></asp:Label>
            </li>
            <li>
                <asp:Label ID="lblPesquisar" runat="server" Text="Pesquisar"></asp:Label>
            </li>
        </ul>
        <p>
            <asp:Label ID="lblProdutos" runat="server" style="font-weight: 700" Text="Produtos"></asp:Label>
        </p>
        <ul>
            <li>
                <asp:Label ID="lblCadastrarProdu" runat="server" Text="Cadastrar Novo"></asp:Label>
            </li>
            <li>
                <asp:Label ID="lblListarNovo02" runat="server" Text="Listar Todos"></asp:Label>
            </li>
            <li>
                <asp:Label ID="lblPesquisar02" runat="server" Text="Pesquisar"></asp:Label>
            </li>
        </ul>
    </form>
</body>
</html>
