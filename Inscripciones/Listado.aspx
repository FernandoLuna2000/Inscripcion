<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Inscripciones.LIstado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="LblSaludo" runat="server" Text="Lista de Estudiantes por Grado"></asp:Label></h1>
            <br />
            <asp:Button ID="Button1" runat="server" Text="volver" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="lblinstrucciones" runat="server" Text="Selecciona un Grado"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Gardos:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <br />
            Seleccione el grupo a ver:
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="A">Grupo A</asp:ListItem>
                <asp:ListItem Value="B">Grupo B</asp:ListItem>
                <asp:ListItem Value="C">Grupo C</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="Matrícula" datafield="matricula"/>
                    <asp:BoundField HeaderText="Nombre" datafield="nombre"/>
                    <asp:BoundField  HeaderText="Español" datafield="Calificacion1"/>
                    <asp:BoundField HeaderText="Ingles" datafield="Calificacion2"/>
                    <asp:BoundField HeaderText="Matemáticas" datafield="Calificacion3"/>
                    <asp:BoundField HeaderText="Promedio" datafield="promedio"/>
                    <asp:BoundField HeaderText="Grado" datafield="descripciongrado"/>
                    <asp:BoundField HeaderText="Grupo" datafield="descripciongrupo"/>
                    <asp:BoundField HeaderText="Aprobadas" datafield="Aprobadas"/>
                    <asp:BoundField HeaderText="Reprobadas" datafield="Reprobadas"/>
                </Columns>
            </asp:GridView>
            <br />
            Alumnos en el Grupo: <asp:Label ID="lbltalum" runat="server" Text="Label"></asp:Label>
            <br />
            Promedio del Grupo: <asp:Label ID="lblprogru" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
