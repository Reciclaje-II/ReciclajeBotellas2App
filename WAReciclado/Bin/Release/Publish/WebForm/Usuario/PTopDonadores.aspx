<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PTopDonadores.aspx.cs" Inherits="PTopDonadores" %>
<%@ Reference Control="~/Controles/CUTopUsuario.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Usuario/STopDonadores.css" rel="stylesheet" />
    <link href="../../Estilo/Usuario/STopUsuario.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="ContentTitle">
            <div class="title">
                <asp:Label ID="lblContenidoTitulo" class="LblContenido" runat="server" Text="TOP 10 DONADORES"></asp:Label>
                <p class="cerrar">
                    <a class="link" href="PVotarOrganizaciones.aspx">X</a>
                </p>
            </div>
            <br />
            <asp:Label ID="lblContenidoDescripcion" class="LblDescripcion" runat="server" Text="El estudiante con mayor cantidad de créditos donados recibirá muchas sorpresas..."></asp:Label>
        </div>
        <div id="divContenedor" runat="server">
        </div>
    </form>
</asp:Content>


