<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cambiar_Grupo.aspx.cs" Inherits="Inscripciones.Cambiar_Grupo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Seleccione un ID: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
            <br />
            <h1><asp:Label ID="lblnombre" runat="server" Text=""></asp:Label></h1>
            <br />
            Grado Actual: <h3><asp:Label ID="lblgrdactual" runat="server" Text=""></asp:Label></h3>
            Grupo Actual: <h3><asp:Label ID="lblgruactual" runat="server" Text=""></asp:Label></h3>
            <br />
            Grupo Nuevo: <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="actualizar" runat="server" Text="cambiar" OnClick="actualizar_Click" />
        </div>
    </form>
</body>
</html>
