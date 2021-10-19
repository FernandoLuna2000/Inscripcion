<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index_Mate.aspx.cs" Inherits="Inscripciones.Index_Mate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bienvenido Profesor de Matemáticas</h2>
            <asp:Button ID="Button1" runat="server" Text="Cambiar Calificaciones" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Buscar por Matrícula" OnClick="Button2_Click" />
            <br />
            <footer>
                <asp:Button ID="Button3" runat="server" Text="Cerrar Sesión" OnClick="Button3_Click" />
            </footer>
        </div>
    </form>
</body>
</html>
