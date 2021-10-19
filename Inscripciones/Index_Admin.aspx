<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index_Admin.aspx.cs" Inherits="Inscripciones.Index_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bienvenido Administrador</h2>
            <asp:Button ID="Button1" runat="server" Text="Inscribir Alumno" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Cambiar Grupo" OnClick="Button2_Click" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Listado" OnClick="Button3_Click" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Alumnos Reprobados" OnClick="Button4_Click" />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Buscar por Matrícula" OnClick="Button5_Click" />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Cuadro de Honor" OnClick="Button6_Click" />
            <br />
            <footer>
                <asp:Button ID="Button7" runat="server" Text="Cerrar Sesión" OnClick="Button7_Click" />
            </footer>
        </div>
    </form>
</body>
</html>
