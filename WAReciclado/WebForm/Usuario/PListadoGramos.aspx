<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PListadoGramos.aspx.cs" Inherits="PListadoGramos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Usuario/SListadoGramos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <legend class="bold">Lista de Gramos</legend>
        <form id="form1" runat="server">
            <asp:GridView ID="gvListaGramos" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Gramos" HeaderText="GRAMOS" />
                    <asp:BoundField DataField="Fecha" HeaderText="FECHA" />
                </Columns>
            </asp:GridView>

            <table class="formulario">
                <tr>
                    <td class="fila">
                        <asp:Label CssClass="lblGramos" runat="server" Font-Bold="True" Text="Creditos acumulados:"></asp:Label>
                        <asp:Label ID="lblCreditos" CssClass="lbGramos" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </form>
    </fieldset>
</asp:Content>
