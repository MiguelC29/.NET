<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ninioweb.aspx.cs" Inherits="jardines.ninioweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <title></title>
</head>
<body style="background-color: #212529; color: whitesmoke">
    <form id="form1" runat="server">
        <div class="container mt-3">
            <asp:Panel ID="PanelRegistro" runat="server" Visible="False">
                <h1><asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label></h1>
                <div class="container">
                    <div class="row">
                        <asp:Label ID="lblIdNino" runat="server" Text="Id Niño"></asp:Label>
                        <asp:TextBox ID="txtIdNino" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label2" runat="server" Text="NIUP"></asp:Label>
                        <asp:TextBox ID="txtNIUP" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label4" runat="server" Text="Tipo de Sangre"></asp:Label>
                        <asp:DropDownList ID="ddlTipoSangre" runat="server" CssClass="form-control">
                            <asp:ListItem>O +</asp:ListItem>
                            <asp:ListItem>O -</asp:ListItem>
                            <asp:ListItem>A +</asp:ListItem>
                            <asp:ListItem>A -</asp:ListItem>
                            <asp:ListItem>AB +</asp:ListItem>
                            <asp:ListItem>AB -</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label3" runat="server" Text="Ciudad de Nacimiento"></asp:Label>
                        <asp:TextBox ID="txtCiudadNacimiento" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label1" runat="server" Text="Peso en Kilogramos"></asp:Label>
                        <asp:TextBox ID="txtPeso" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label5" runat="server" Text="Estatura en metros"></asp:Label>
                        <asp:TextBox ID="txtEstatura" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label6" runat="server" Text="Jardin"></asp:Label>
                        <asp:DropDownList ID="ddlJardin" runat="server"></asp:DropDownList>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label7" runat="server" Text="Acudiente"></asp:Label>
                        <asp:DropDownList ID="ddlAcudiente" runat="server"></asp:DropDownList>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label8" runat="server" Text="Niño"></asp:Label>
                        <asp:DropDownList ID="ddlDatosBasicos" runat="server"></asp:DropDownList>
                    </div>
                    <div class="row">
                        <asp:Label ID="Label9" runat="server" Text="EPS"></asp:Label>
                        <asp:DropDownList ID="ddlEps" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                <div class="mt-2">
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="btnRegistrar_Click" />
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-primary" OnClick="btnEditar_Click" Visible="False" />
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-primary" OnClick="btnVolver_Click" />
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelConsulta" runat="server">
                <h1>Lista de Niños</h1>
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="btn btn-success mb-2" OnClick="btnNuevo_Click" />
                <asp:GridView ID="gdvNinos" runat="server" CssClass="table table-secondary" AutoGenerateColumns="False" OnRowCommand="gdvNinos_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="idNino" HeaderText="ID NIÑO" />
                        <asp:BoundField DataField="NUIP" HeaderText="NUIP" />
                        <asp:BoundField DataField="idDatosBasicos.nombres" HeaderText="NOMBRE" />
                        <asp:BoundField DataField="idDatosBasicos.fechaNacimiento" HeaderText="Fecha de Nacimiento" />
                        <asp:BoundField DataField="tipoSangre" HeaderText="Tipo de Sangre" />
                        <asp:TemplateField HeaderText="ACCIONES">
                            <ItemTemplate>
                                <asp:ImageButton ID="imgBtnEditar" runat="server" ImageUrl="~/img/edit.png" Width="25px" CommandName="Editar" />
                                <asp:ImageButton ID="imgBtnEliminar" runat="server" ImageUrl="~/img/delete.png" Width="25px" CommandName="Eliminar" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
