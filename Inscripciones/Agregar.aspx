<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="Inscripciones.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Rellene los Campos</h1>
            <asp:Button ID="Button2" runat="server" Text="Volver" OnClick="Button2_Click" />
            <br />
            <asp:Label ID="Lblmatricula" runat="server" Text="Matrícula:"></asp:Label>
            <asp:TextBox ID="Txbmatricula" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lblnombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="Txbnombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Grado:"></asp:Label>
            <asp:DropDownList ID="Ddlgrado" runat="server"  AutoPostBack="True"></asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Grupo:"></asp:Label>
            <asp:DropDownList ID="Ddlgrupo" runat="server" AutoPostBack="True"></asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
