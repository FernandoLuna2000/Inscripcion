<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Califi_Ing.aspx.cs" Inherits="Inscripciones.Califi_Ing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Seleccione un Alumno:
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" ></asp:DropDownList>
            <br />
                        <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Matrícula:"></asp:Label>
            <asp:Label ID="lblmatricula" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
            <asp:Label ID="lblnombre" runat="server" Text="Label"></asp:Label>
            <br />



            <asp:Label ID="Label2" runat="server" Text="Inglés"></asp:Label>
            <br />
            Calificación Actual:
            <asp:Label ID="lblcaliactualmat" runat="server" Text="Label"></asp:Label>
            <br />
            Ingrese una nueva Calificación:
            <asp:TextBox ID="nuevacaliesp" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Actualizar" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
