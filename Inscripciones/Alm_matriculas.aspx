<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alm_matriculas.aspx.cs" Inherits="Inscripciones.Alm_matriculas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Busqueda de Alumnos por Matrícula</h1>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" />
            <br />
            Seleccione una matrícula: <asp:DropDownList ID="DDLmatriculas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLmatriculas_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:GridView ID="GVAlumnos" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="matricula" HeaderText="Matrícula" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="descripciongrado" HeaderText="Grado" />
                    <asp:BoundField DataField="descripciongrupo" HeaderText="Grupo" />
                    <asp:BoundField DataField="Calificacion1" HeaderText="Español" />
                    <asp:BoundField DataField="Calificacion2" HeaderText="Inglés" />
                    <asp:BoundField DataField="Calificacion3" HeaderText="Matematicas" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
