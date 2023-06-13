<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PAgregarCampania.aspx.cs" Inherits="PAgregarCampania" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SAgregarCampania.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
    <link href="../../Estilo/Administrador/SModalAgregarCampania.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="divCentro title">
            <asp:Label ID="lblCampaniaEditAddTitulo" CssClass="lblCampaniaEditAdd" runat="server"></asp:Label>
            <p class="cerrar">
                <a class="link" href="PGestionCampanias.aspx">X</a>
            </p>
        </div>
        <div class="container">
            <div class="row100">
                <div class="col">
                    <div class="inputBox">
                        <asp:Label CssClass="textLlenar" Text="Nombre de la campaña: " runat="server"></asp:Label>
                        <asp:TextBox ID="txbNombreCmpania" CssClass="txbNameCampain" runat="server"></asp:TextBox>
                        <span class="line"></span>
                    </div>
                </div>
                <div class="col">
                    <div>
                        <asp:Label CssClass="textLlenar" Text="Descripción: " runat="server"></asp:Label>
                        <asp:TextBox CssClass="txbDescriptionCampain" ID="txbDescripcion" runat="server"></asp:TextBox>
                        <span class="line"></span>
                    </div>
                </div>
                <div class="row100">
                    <div class="col">
                        <div class="inputBox">
                            <asp:Label CssClass="textEstatico" Text="Fecha de apertura:" runat="server"></asp:Label>
                            <asp:TextBox ID="txbFechaInicio" runat="server" TextMode="Date"></asp:TextBox>
                            <asp:Label CssClass="txbFechaCierre" Text="Fecha de cierre: " runat="server"></asp:Label><asp:TextBox ID="txbFechaFin" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col">
                        </div>
                    </div>
                    <asp:DropDownList CssClass="drpOrganizacion" ID="DropDownListOrganizaciones" runat="server"  DataTextField="NombreOrganizacion" DataValueField="NombreOrganizacion" Width="165px" Height="30px"></asp:DropDownList>
                        <SelectParameters>
                            <asp:Parameter DefaultValue="1" Name="Estado" Type="Byte" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:Button ID="btnAñadirListaOrganizaciones" CssClass="btnAddOrg" runat="server" Text="+" OnClick="btnAñadirListaOrganizaciones_Click" />
                    <br />
                    <asp:Label CssClass="textEstatico" Text="Organizaciones Seleccionadas:" runat="server"></asp:Label><br />
                    <div class="divCentrogrv">
                        <asp:GridView ID="GridViewListaOrganizaciones" CssClass="gridview" AutoGenerateColumns="false" runat="server" OnRowCommand="GridViewListaOrganizaciones_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="NombreOrganizacion" SortExpression="organization" />
                                <asp:ButtonField ButtonType="Button" CommandName="btnEliminar" Text="ELIMINAR" ControlStyle-CssClass="button" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    <asp:Label ID="lblListaOrganizaciones" Text="" runat="server" />
                    <br />
                    <asp:Label ID="lblExep" runat="server" ForeColor="Red"></asp:Label>
                    <div class="divCentro">
                        <div class="inputBox">
                            <asp:Button ID="btnGuardarCampania" CssClass="btnAddCampain" runat="server" Text="Crear" OnClick="btnGuardarCampania_Click" />
                            <span class="line"></span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="modal-container" id="modalContainer">
            <div class="modal" id="modalConfirmarDatosCampania">
                <div>
                    <div>
                        <div class="divCentro">
                            <asp:Label CssClass="lblCampaniaEditAdd" Text="¿ESTA SEGURO QUE DESEA REGISTRAR?" runat="server"></asp:Label>
                        </div>
                        <br />
                        <div class="divIzquierda">
                            <asp:Label CssClass="textEstatico" Text="Nombre de Campaña: " runat="server"></asp:Label>
                            <asp:Label CssClass="textEstaticoModal" ID="lblDatosNombreCampania" runat="server"></asp:Label>
                            <br />
                            <asp:Label CssClass="textEstatico" Text="Descripción: " runat="server"></asp:Label>
                            <asp:Label CssClass="textEstaticoModal" ID="lblDatosDescripcionCampania" runat="server"></asp:Label><br />
                            <asp:Label CssClass="textEstatico" Text="Y con las organizaciones:" runat="server"></asp:Label>
                        </div>
                        <div class="divCentrogrv">
                            <asp:GridView CssClass="gridview" ID="grvOrganizacionesModal" AutoGenerateColumns="false" runat="server" OnRowCommand="GridViewListaOrganizaciones_RowCommand">
                                <Columns>
                                    <asp:BoundField DataField="NombreOrganizacion" HeaderText="ORGANIZACION" SortExpression="organization" />
                                </Columns>
                            </asp:GridView>
                        </div>
                        <div class="divCentro">
                            <asp:Button CssClass="btnMod" ID="btnGuardarAccionesRealizadas" runat="server" Text="ACEPTAR" OnClick="btnGuardarAccionesRealizadas_Click" />
                            <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" CssClass="btnMod" OnClick="btnCancelar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <script src="../../Guiones/JModalAgregarCampania.js"></script>
    </form>
</asp:Content>


