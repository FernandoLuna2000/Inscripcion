<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mejores_Promedios.aspx.cs" Inherits="Inscripciones.Mejores_Promedios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cuadro de Honor</h1>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
            <br />
            <h3>Grupo A</h3>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="promedio" HeaderText="Promedio" />
                    <asp:BoundField DataField="descripciongrado" HeaderText="Grado" />
                    <asp:BoundField DataField="descripciongrupo" HeaderText="Grupo" />
                </Columns>
            </asp:GridView>
            <br />
            <h3>Grupo B</h3>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="promedio" HeaderText="Promedio" />
                    <asp:BoundField DataField="descripciongrado" HeaderText="Grado" />
                    <asp:BoundField DataField="descripciongrupo" HeaderText="Grupo" />
                </Columns>
            </asp:GridView>
            <br />
            <h3>Grupo C</h3>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="promedio" HeaderText="Promedio" />
                    <asp:BoundField DataField="descripciongrado" HeaderText="Grado" />
                    <asp:BoundField DataField="descripciongrupo" HeaderText="Grupo" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
