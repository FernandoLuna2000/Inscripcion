<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reprobados.aspx.cs" Inherits="Inscripciones.Reprobados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Lista de ALumnos Reprobados</h1>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
            <br />
            <asp:GridView ID="GVRepro" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="matricula" HeaderText="Matrícula" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="descripciongrado" HeaderText="Grado" />
                    <asp:BoundField DataField="descripciongrupo" HeaderText="Grupo" />
                    <asp:BoundField DataField="reprobadas" HeaderText="No.Reprobadas" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
