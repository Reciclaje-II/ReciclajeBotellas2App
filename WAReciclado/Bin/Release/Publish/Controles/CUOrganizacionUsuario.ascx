<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CUOrganizacionUsuario.ascx.cs" Inherits="CUOrganizacionUsuario" %>

<link href="../Estilo/Usuario/SOrganizacionUsuario.css" rel="stylesheet" />
<div class="card" runat="server">
    <div class="imagen">
        <asp:ImageButton ID="imbOrganizacion" runat="server" Width="100%" OnClick="imbOrganizacion_Click" />
    </div>
    <div class="contenedorProgressBar">
        <div id="divVotos" runat="server"></div>
    </div>
    <div class="contenedorBoton">
        <asp:Button ID="btnVotar" CssClass="botonVotar" runat="server" Text="Votar" OnClick="btnVotar_Click" />
    </div>  
    <div>
            <asp:Label ID="lblOrganizacion" runat="server" Text=""></asp:Label>
     <div class="centrar">
            <asp:Button ID="btnSi" runat="server" CssClass="botonSi" Text="✓" OnClick="btnAceptar_Click"/>
     </div>
    </div>
</div>