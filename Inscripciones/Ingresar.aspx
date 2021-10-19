<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="Inscripciones.Ingresar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario                              "></asp:Label>
            <asp:TextBox ID="Txbuser" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contraseña                               "></asp:Label>
            <asp:TextBox ID="Txpass" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Btnac" runat="server" Text="Ingresar" OnClick="Btnac_Click" />
        </div>
            </center>
        </div>
    </form>
</body>
</html>
