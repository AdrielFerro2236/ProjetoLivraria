<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExcluirUsuario.aspx.cs" Inherits="Usuarios_ExcluirUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: x-large" Text="Excluir Usuário"></asp:Label>
    
    </div>
        <p>
            <asp:Label ID="lblId" runat="server" Text="Código:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblSobreNome" runat="server" Text="SobreNome:"></asp:Label>
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" BorderStyle="None" Text="Email:"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblUserName" runat="server" Text="Nome do Usuário:"></asp:Label>
            <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="lblErro" runat="server" Text="Mensagem"></asp:Label>
        <p style="height: 20px">
            Tem certeza que deseja excluir?<br />
            <asp:Button ID="btnSim" runat="server" OnClick="btnSim_Click" Text="Sim, pode continuar" />
        </p>
    </form>
</body>
</html>
