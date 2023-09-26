<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PVotarOrganizaciones.aspx.cs" Inherits="PVotarOrganizaciones" %>
<%@ Reference Control="~/Controles/CUOrganizacionUsuario.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Usuario/SVotarOrganizaciones.css" rel="stylesheet" />
    <link href="../../Estilo/Usuario/SOrganizacionUsuario.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset class="field">
            <div class="title">
                <asp:Label ID="lblCampaña" runat="server" Text="Campaña Marzo - Junio" CssClass="lblCampaña"></asp:Label>
                <p class="cerrar">
                    <a class="link" href="PMenuEstudiante.aspx">X</a>
                </p>
            </div>
            <div class="subtitle">
                <asp:Label runat="server" Text="Elige la organización que deseas apoyar" CssClass="lbl"></asp:Label>
            </div>
            <div class="link">
                <asp:HyperLink ID="hlDonadores" runat="server" Font-Size="11" Text="Top 10 Donadores" NavigateUrl="~/WebForm/Usuario/PTopDonadores.aspx"></asp:HyperLink>
            </div>
            <div id="divContenedor" runat="server" class="container">
                
            </div>
        </fieldset>
    </form>
</asp:Content>

