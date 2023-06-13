<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PNuevaOrganizacion.aspx.cs" Inherits="PNuevaOrganizacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SNuevaOrg.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <fieldset>
            <legend class="bold"></legend>
            <div>
                <div class="lblTitle title">
                    <asp:Label Font-Size="20" CssClass="lblTitle" runat="server" Font-Bold="True" Text="AGREGAR ORGANIZACIÓN"></asp:Label>
                    <p class="cerrar">
                        <asp:HyperLink ID="hpRedireccion" CssClass="link" runat="server">X</asp:HyperLink>
                    </p>
                </div>
                <div class="bodyText">
                    <asp:Label Font-Size="10" runat="server" Font-Bold="false" Text="NOMBRE:"></asp:Label>
                    <asp:TextBox CssClass="BackGroundTxt" ID="txbNombre" runat="server" Width="480px" required=""></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txbNombre" ErrorMessage="Este campo es obligatorio" ForeColor="Red" Display="Dynamic" ToolTip="Este campo es obligatorio" runat="server"></asp:RequiredFieldValidator>
                </div>
                <div class="bodyText">
                    <asp:Label Font-Size="10" runat="server" Font-Bold="false" Text="DESCRIPCIÓN:"></asp:Label>
                    <asp:TextBox CssClass="BackGroundTxt" ID="txbDescripcion" TextMode="MultiLine" runat="server" Width="100%" Wrap="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txbDescripcion" ErrorMessage="Este campo es obligatorio" ForeColor="Red" Display="Dynamic" ToolTip="Este campo es obligatorio" runat="server"></asp:RequiredFieldValidator>
                <asp:Label Font-Size="10" ID="lblDescripcion" runat="server" Font-Bold="false" Text="" ForeColor="Red"  ></asp:Label>

                </div>
                <div class="bodyText">
                    <asp:Label Font-Size="10" runat="server" Font-Bold="false" Text="IMÁGENES"></asp:Label>
                </div>
                <div class="bodyText">
                    <div class="center">
                        <asp:Label CssClass="color" Font-Size="10" runat="server" Font-Bold="true" Text="LOGO"></asp:Label>
                        <div class="file-select" id="src-file1">
                            <asp:FileUpload type="file" ID="fluLogo" runat="server" accept="image/png" onchange="mostrarImagenLogo(this)" required="true" />

                        </div>

                        <asp:Label CssClass="color marginLeft" Font-Size="10" runat="server" Font-Bold="true" Text="DESCRIPCIÓN"></asp:Label>
                        <div class="file-select" id="src-file2">
                            <asp:FileUpload type="file" ID="fluDescripcion" runat="server" accept="image/png" onchange="mostrarImagenDescripcion(this)" required="true" />

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

            </div>
        </fieldset>
        <script src="../../Guiones/JCargarImagenes.js"></script>
    </form>
</asp:Content>



