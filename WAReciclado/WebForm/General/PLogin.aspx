<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PLogin.aspx.cs" Inherits="PLogin" %>

<!DOCTYPE html>

<html xmlns:og="http://ogp.me/ns#">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta http-equiv="X-UA-Compatible" content="chrome=1">
    <meta name="keywords" content="universidad, univalle, bolivia, estudiar, sistema informacion, siu, estudar, medicina, sem, vestibular, faculdade, cochabamba, ingenieria, empresas, campus, la paz, trinidad, sucre">
    <meta name="description" content="Universidad del Valle Bolivia, noticias, informacion, facultades, extension, estudiantes internacionales, investigacion, medicina Bolivia">
    <meta property="og:title" content="SIU - Univalle">
    <meta property="og:description" content="S.I.U. Sistema de Información - Univalle">
    <meta property="og:image" content="https://enlace.univalle.edu/san/Imagenes/MasterPage/logo.jpg">
    <title>Servicio de autenticacion Netvalle
    </title>
    <link rel="shortcut icon" href="https://enlace.univalle.edu/san/Imagenes/MasterPage/apple-touch-icon.png" type="image/png">
    <link rel="icon" href="https://enlace.univalle.edu/san/Imagenes/MasterPage/apple-touch-icon.png" type="image/png">
    <link rel="apple-touch-icon" href="https://enlace.univalle.edu/san/Imagenes/MasterPage/apple-touch-icon.png">
    <link rel="author" href="https://plus.google.com/112045553903328672114/posts">
    <style type="text/css">
        html, body, #container {
            min-height: 100%; /* Not supported by IE 5/6, but required for Firefox/Opera */
            width: 100%;
            height: 100%;
            background-color: #151515;
        }

            html > body, html > body #container {
                height: auto;
            }

        body {
            margin: 0;
        }

        #container {
            position: absolute;
            top: 0;
            left: 0;
        }

        #main {
            margin-bottom: 50px;
            height: auto;
        }

        #header {
            width: 98%;
            height: 162px;
            border-bottom: 0px;
        }

        #tab {
            width: 98%;
            overflow: auto;
        }

        #footer {
            position: absolute;
            bottom: 0;
            border-top: 0px;
            width: 100%;
            height: 25px;
        }

        .auto-style1 {
            width: 77%;
        }
    </style>
    <link href="./Servicio de autenticacion Netvalle_files/EstiloSan.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="container" align="center">
            <div id="main">
                <div id="header" align="center">
                    <table style="width: 98%;" border="0" cellpadding="0" cellspacing="0">
                        <tbody>
                            <tr style="height: 55px">
                                <td>
                                    <table style="width: 100%; margin-right: 0px; margin-left: 0px;" cellpadding="0" border="0" cellspacing="0">
                                        <tbody>
                                            <tr>
                                                <td align="left" width="80%">
                                                    <img alt="" src="./Servicio de autenticacion Netvalle_files/LogoUnivalle260x55.png">
                                                </td>
                                                <td>&nbsp;
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr style="height: 102px; background-color: #4D0522;">
                                <td>
                                    <table style="width: 100%; margin-right: 10px; margin-left: 10px;" cellpadding="0" border="0" cellspacing="0">
                                        <tbody>
                                            <tr>
                                                <td width=" 106px" align="left">
                                                    <img alt="" src="./Servicio de autenticacion Netvalle_files/LogoSan106x70.png">
                                                </td>
                                                <td width=" 120px" align="left">
                                                    <img alt="" src="./Servicio de autenticacion Netvalle_files/LetrasSan106x36.png">
                                                </td>
                                                <td width=" 2px" style="background-color: #FFF"></td>
                                                <td class="TituloMasterPage" align="left">&nbsp; Sistema de Información Univalle
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div id="tab">
                    <table id="tContent" cellspacing="0" cellpadding="0" style="border-width: 0px; width: 95%; border-collapse: collapse;">
                        <tbody>
                            <tr>
                                <td style="background-color: #2A2A2A; width: 5px;">
                                    <img id="imgLeftTop" src="./Servicio de autenticacion Netvalle_files/Center5x5.png">
                                </td>
                                <td style="background-color: #2A2A2A;">                                   
                                    <table id="ContentPlaceHolder1_tMainLogin" style="border-width: 0px; width: 100%;">
                                        <tbody>
                                            <tr style="height: 450px;">
                                                <td style="width: 60%;"></td>
                                                <td align="center" style="width: 40%;">
                                                    <div class="BordeLogin">
                                                        <link href="./Servicio de autenticacion Netvalle_files/EstiloSan.css" rel="stylesheet" type="text/css">
                                                        <br>
                                                        <input type="hidden" name="ctl00$ContentPlaceHolder1$cuAutenticar$hddControl1" id="ContentPlaceHolder1_cuAutenticar_hddControl1">
                                                        <table style="border-width: 0px; width: 99%;">
                                                            <tbody>
                                                                <tr class="trSpacing">
                                                                    <td align="left" colspan="2"><span id="ContentPlaceHolder1_cuAutenticar_lblTitulo" class="TituloLogin">iniciar sesión</span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" style="width: 25%;">
                                                                        <br>
                                                                        <span class="TextoLogin">Cuenta:</span>
                                                                    </td>
                                                                    <td align="left" class="auto-style1">
                                                                        <br>
                                                                        <asp:TextBox runat="server" MaxLength="15" ID="txbCuenta" class="TextBox" onkeydown="return DisableCtrlKey(event)" onpaste="return false;" oncopy="return false;" Style="width: 88%;"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right"><span id="ContentPlaceHolder1_cuAutenticar_lblPIN" class="TextoLogin">PIN:</span></td>
                                                                    <td align="left" class="auto-style1">
                                                                        <asp:TextBox runat="server" ID="txbPIN" Style="width: 88%;"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right"><span id="ContentPlaceHolder1_cuAutenticar_Label1" class="TextoLogin">Usuario:</span></td>
                                                                    <td align="left" class="auto-style1">
                                                                        <asp:DropDownList ID="ddlSelectUser" runat="server" Style="width: 90%;" AutoPostBack="true">
                                                                            <asp:ListItem Value="">--Seleccione una opción--</asp:ListItem>
                                                                            <asp:ListItem Value="AD">ADMINISTRATIVO</asp:ListItem>
                                                                            <asp:ListItem Value="EU">ESTUDIANTE</asp:ListItem>
                                                                            <asp:ListItem Value="EM">EMPRESA</asp:ListItem>
                                                                        </asp:DropDownList>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td></td>
                                                                    <td align="center" class="auto-style1">
                                                                        <table>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td>
                                                                                        <div align="center" id="botones" style="font: normal 8px/4px verdana; width: 120px">
                                                                                            <asp:ImageButton ID="Btn1" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/1.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="Btn2" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/2.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="Btn3" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/3.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="Btn4" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/4.png" />&nbsp;<br />
                                                                                            <br />
                                                                                            <asp:ImageButton ID="Btn5" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/5.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="Btn6" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/6.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="Btn7" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/7.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="Btn8" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/8.png" Width="19px" />&nbsp;<br />
                                                                                            <br />
                                                                                            <asp:ImageButton ID="Btn9" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/9.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="Btn0" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/0.png" />&nbsp;
                                                                                           
                                                                                            <asp:ImageButton ID="BtnLimpiar" alt="" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/Limpiar.png" />&nbsp;
                                                                                       
                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="2"><span class="TextoArialXSmallBoldFFF"></span></td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" colspan="2"></td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="4" style="text-align: center;">
                                                                        <asp:ImageButton ID="btnIniciar" runat="server" ImageUrl="./Servicio de autenticacion Netvalle_files/IniciarSessionPlano130x22.png" OnClick="btnIniciar_Click" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="center" colspan="2"><a class="btnRegistrarse" id="btnRegistrarse" href="#">Registrate aqui</a></td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

