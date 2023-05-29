<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PVerDescripcion.aspx.cs" Inherits="PVerDescripcion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Usuario/SVerDescripcion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset class="field">
            <div class="title">
                <asp:Label ID="lblOrganizacion" runat="server" Text="BANCO DE ALIMENTOS DE BOLIVIA" CssClass="lblOrganizacion"></asp:Label>
                <p class="cerrar">
                    <a class="link" href="PVotarOrganizaciones.aspx">X</a>
                </p>
            </div>
            <div class="container">
                <div class="img">
                    <asp:Image ID="imgImagen" ImageUrl="~/Imagenes/foto.jpg" CssClass="imgImagen" runat="server" />
                </div>
                <div class="text">
                    <h2>¿Quiénes somos?</h2>
                    <br />
                    <asp:Label ID="lblDescripcion" CssClass="lblDescripcion" Text="El Banco de Alimentos de Bolivia es el primer banco de alimentos del país, una fundación que se dedica a recolectar y rescatar alimento en buen estado que ya no será comercializado, para su posterior redistribución a instituciones que atienden poblaciones vulnerables." runat="server" />
                </div>
            </div>
        </fieldset>
    </form>
</asp:Content>


