<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jardinweb.aspx.cs" Inherits="jardines.jardinweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title></title>
</head>
<body style="background-color: #212529; color: whitesmoke">
    <form id="form1" runat="server">
        <div class="container mt-3">
            <asp:Panel ID="PanelRegistro" runat="server" Visible="False">
                <h1>Registrar Jardin</h1>
                <div class="container">
                    <div class="row">
                        <asp:Label ID="Label1" runat="server" Text="Id Jardin"></asp:Label>
                        <asp:TextBox ID="txtIdJardin" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label4" runat="server" Text="Estado"></asp:Label>
                        <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control">
                            <asp:ListItem>Aprobado</asp:ListItem>
                            <asp:ListItem>En Trámite</asp:ListItem>
                            <asp:ListItem>Negado</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="mt-2">
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="btnRegistrar_Click" />
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-primary" OnClick="btnVolver_Click" />
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelConsulta" runat="server">
                <h1>Lista de Jardines</h1>
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-success mb-2" OnClick="btnNuevo_Click" />
                <asp:GridView ID="gdvJardines" runat="server" CssClass="table table-dark" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="idJardin" HeaderText="ID" />
                        <asp:BoundField DataField="nombre" HeaderText="NOMBRE" />
                        <asp:BoundField DataField="direccion" HeaderText="DIRECCIÓN" />
                        <asp:BoundField DataField="estado" HeaderText="ESTADO" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
