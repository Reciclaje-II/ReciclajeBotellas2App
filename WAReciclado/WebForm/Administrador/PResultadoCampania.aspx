<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PResultadoCampania.aspx.cs" Inherits="PResultadoCampania" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SResultadoCampania.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contenedor">
        <b class="titulo">
            <asp:Label ID="lblNombreCampania" runat="server" Text="Campañas solidarias"></asp:Label>
            <p class="cerrar">
                <a href="PGestionCampanias.aspx" class="link">X</a>
            </p>
        </b>
        <p>
            La Campaña a terminado y estos son los resultados
        </p>
        <div class="detalles">
            <table class="contenido">
                <tr>
                    <td class="izquierda">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/perfil.png" class="imagen" />
                    </td>
                    <td class="derecha">
                        <div class="titulo">
                            <b>GANADOR</b>
                        </div>
                        <div>
                            <b class="label">Votos:</b>
                            <p>
                                <asp:Label ID="lblVotos" runat="server" Text="500/1000"></asp:Label>
                            </p>
                        </div>
                        <div>
                            <b class="label">Monto recaudado:</b>
                            <p>
                                <asp:Label ID="lblMonto" runat="server" Text="1000 Bs."></asp:Label>
                            </p>
                        </div>
                        <div>
                            <b class="label">Mejor donador:</b>
                            <p>
                                <asp:Label ID="lblMejorDonador" runat="server" Text="Juan Perez"></asp:Label>
                            </p>
                            <p>
                                <asp:Label ID="lblCantidadDonada" runat="server" Text="200 creditos" ForeColor="#028B10"></asp:Label>
                            </p>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>


