<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PInformacionCampania.aspx.cs" Inherits="PInformacionCampania" %>
<%@ Reference Control="~/Controles/CUOrganizacionAdmin.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SInformacionCampania.css" rel="stylesheet" />
    <link href="../../Estilo/Administrador/SOrganizacionAdmin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="contenedor">
            <p class="cerrar">
                <a class="link" href="PGestionCampanias.aspx">X</a>
            </p>
            <b class="titulo">
                <asp:Label ID="lblNombreCampania" CssClass="titulo" runat="server" Text="Campañas solidarias"></asp:Label>
            </b>         
            <div id="divContenedor" runat="server" class="container">
                
            </div>
            <div class="boton">
                <asp:Button ID="btnFinalizar" CssClass="btnFinalizar" runat="server" Text="FINALIZAR" OnClick="btnFinalizar_Click"/>
            </div>
            <asp:Label ID="lblExep" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <div class="modal-container-notificacion" id="modalNotificacionContainer">
            <div class="modal-notificacion" id="modalNotificacion">
                <asp:ImageButton ID="btnCerrar" CssClass="btnCerrar" ImageUrl="~/Imagenes/close.png" runat="server" OnClick="btnCerrar_Click"></asp:ImageButton>
                <div class="content">
                    <p class="LBLContenido centrar">
                        ¿ESTA SEGURO/A DE FINALIZAR ESTA CAMPAÑA?      
                        <b>
                            <asp:Label ID="lblCampaniaFin" runat="server"></asp:Label>
                        </b>                        
                    </p>                    
                    <div class="centrar">
                        <asp:Button ID="btnAceptar" runat="server" CssClass="btnAceptar" Text="Aceptar" OnClick="btnAceptar_Click"/>
                    </div>
                </div>
            </div>
        </div>
        <script src="../../Guiones/JModalEliminarCampania.js"></script>
    </form>
</asp:Content>


