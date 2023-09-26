<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PGestionOrganizaciones.aspx.cs" Inherits="PGestionOrganizaciones" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SGestionOrganizaciones.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="titulo">
            <b>ORGANIZACIONES REGISTRADAS</b>
            <p class="cerrar">
                <a class="link" href="PGestionCampanias.aspx">X</a>
            </p>
        </div>
        <div>
            <div class="contenedorBoton">
                <asp:Button ID="btnCrearOrganizacion" CssClass="btnCrear" runat="server" Text="CREAR ORGANIZACIÓN" OnClick="btnCrearOrganizacion_Click" />
            </div>
            <asp:GridView ID="gvOrganizaciones" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvOrganizaciones_RowCommand">
                <Columns>
                    <asp:BoundField DataField="nombreOrganizacion" HeaderText="NOMBRE" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnCancelar" Text="Eliminar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnActualizar" Text="Actualizar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="modal-container-notificacion" id="modalNotificacionContainer">
            <div class="modal-notificacion" id="modalNotificacion">
                <p class="btnCerrar" id="btnCerrar">X</p>
                <div class="contenedor">
                    <p class="LBLContenido centrar">
                        ¿ESTA SEGURO/A DE ELIMINAR ESTA ORGANIZACIÓN?      
                        <b>
                            <asp:Label ID="lblOrganizacion" runat="server" Text=""></asp:Label>
                        </b>
                    </p>
                    <div class="centrar">
                        <asp:Button ID="btnEliminar" runat="server" CssClass="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click"/>
                    </div>
                </div>
            </div>
        </div>
        <script src="../../Guiones/JModalEliminarOrganizacion.js"></script>
    </form>
</asp:Content>


