<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CUOrganizacionAdmin.ascx.cs" Inherits="CUOrganizacionAdmin" %>

<link href="../Estilo/Administrador/SOrganizacionAdmin.css" rel="stylesheet" />

<div class="card" runat="server">
    <div class="imagen">
        <asp:Image ID="imgOrganizacion" runat="server" Width="100%" />
    </div>
    <div class="votos">
        <asp:Label ID="lblVotos" runat="server"></asp:Label>
    </div>    
</div>
