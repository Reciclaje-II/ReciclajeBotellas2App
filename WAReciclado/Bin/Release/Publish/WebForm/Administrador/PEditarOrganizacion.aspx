<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PEditarOrganizacion.aspx.cs" Inherits="PEditarOrganizacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SNuevaOrg.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <legend class="bold"></legend>
        <div>
            <div class="lblTitle title">
                <asp:Label Font-Size="20" CssClass="lblTitle" runat="server" Font-Bold="True" Text="EDITAR ORGANIZACIÓN"></asp:Label>
                <p class="cerrar">
                    <a class="link" href="PGestionOrganizaciones.aspx">X</a>
                </p>
            </div>
            <form runat="server">
                <div class="bodyText">
                    <asp:Label Font-Size="10" runat="server" Font-Bold="false" Text="NOMBRE:"></asp:Label>
                    <asp:Label Font-Size="10" ID="lblNombre" runat="server" Font-Bold="false" Text=""></asp:Label>                     
                </div>
                <div class="bodyText">
                    <asp:Label Font-Size="10" runat="server" Font-Bold="false" Text="DESCRIPCIÓN:"></asp:Label>
                    <asp:TextBox CssClass="BackGroundTxt" ID="txbDescripcionEdit" TextMode="MultiLine" runat="server" Width="100%" Wrap="False" required="true" ></asp:TextBox >
                    <asp:Label Font-Size="10" ID="lblDescripcion" runat="server" Font-Bold="false" Text=""></asp:Label>

                </div>
                <div class="bodyText">
                    <asp:Label Font-Size="10" runat="server" Font-Bold="false" Text="IMÁGENES"></asp:Label>
                </div>
                <div class="bodyText">
                    <div class="center">
                        <asp:Label CssClass="color" Font-Size="10" runat="server" Font-Bold="true" Text="LOGO"></asp:Label>
                        <div class="file-select" id="src-file1">
                            <asp:FileUpload type="file" ID="fluLogo" runat="server" accept="image/png" onchange="mostrarImagenLogo(this)"  />

                        </div>

                        <asp:Label CssClass="color marginLeft" Font-Size="10" runat="server" Font-Bold="true" Text="DESCRIPCIÓN"></asp:Label>
                        <div class="file-select" id="src-file2">
                            <asp:FileUpload type="file" ID="fluDescripcion" runat="server" accept="image/png" onchange="mostrarImagenDescripcion(this)"   />

                        </div>
                        <br />
                        <br />
                        <asp:Image ID="imgLogo" CssClass="imagenLogo" runat="server" Width="200px" Height="200px" />
                        <asp:Image ID="Image1" CssClass="marginLeft imagenDescripcion" runat="server" Width="200px" Height="200px" />
                    </div>
                </div>
                <div class="bodyText center">
                    <asp:Button ID="btnGuardar" CssClass="boton1" Height="30px" CausesValidation="true" Font-Bold="true" Font-Size="10" runat="server" Text="GUARDAR" Width="20%" OnClick="btnGuardar_Click" />
                </div>
            </form>
        </div>
    </fieldset>
    <script src="../../Guiones/JCargarImagenes.js"></script>
</asp:Content>


