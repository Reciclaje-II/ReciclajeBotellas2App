<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PGestionCampanias.aspx.cs" Inherits="PGestionCampanias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SGestionCampanias.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="titulo title">
            <b>CAMPAÑAS SOLIDARIAS</b>
            <p class="cerrar">
                    <a class="link" href="PMenuAdministrador.aspx">X</a>
            </p>
        </div>
        <div>
            <div class="contenedorBoton">
                <asp:Button ID="btnCrearCampania" CssClass="btnCrear" runat="server" Text="CREAR CAMPAÑA" OnClick="btnCrearCampania_Click"/>
                <asp:Button ID="btnCrearOrganizacion" CssClass="btnCrear" runat="server" Text="VER ORGANIZACIONES" PostBackUrl="PGestionOrganizaciones.aspx" />
            </div>
            <asp:GridView ID="gvListaCampanias" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaCampanias_RowCommand">
                <Columns>
                    <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" />
                    <asp:BoundField Visible="false" DataField="DESCRIPCION" HeaderText="DESCRIPCION"  />
                    <asp:BoundField Visible="false" DataField="FECHAINICIO" HeaderText="FECHAINICIO" DataFormatString="{0:d}" />
                    <asp:BoundField Visible="false" DataField="FECHAFIN" HeaderText="FECHAFIN" DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" />
                    <asp:BoundField DataField="SEDE" HeaderText="SEDE" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnCancelar" Text="Eliminar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                    <asp:ButtonField ButtonType="Button" CommandName="btnActualizar" Text="Actualizar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="modal-container-notificacion" id="modalNotificacionContainer">
            <div class="modal-notificacion" id="modalNotificacion">
                <asp:ImageButton ID="btnCerrar" CssClass="btnCerrar" ImageUrl="~/Imagenes/close.png" runat="server" OnClick="btnCerrar_Click"></asp:ImageButton>
                <div class="contenedor">
                    <p class="LBLContenido centrar">
                        ¿ESTA SEGURO/A DE ELIMINAR ESTA CAMPAÑA?      
                        <b>
                            <asp:Label ID="lblCampaniaEliminar" runat="server" Text=""></asp:Label>
                        </b>                        
                    </p>                    
                    <div class="centrar">
                        <asp:Button ID="btnEliminar" runat="server" CssClass="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click"/>
                    </div>
                </div>
            </div>
        </div>
        <script src="../../Guiones/JModalEliminarCampania.js"></script>
    </form>
</asp:Content>


