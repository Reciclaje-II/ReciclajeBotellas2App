

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;
 

public partial class PLogin : System.Web.UI.Page

{

    SWLNRecicladoClient swLNReciclado = new SWLNRecicladoClient();

    ERUsuarioNetvalle eUsuarioNetvalle = new ERUsuarioNetvalle();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }

    }

    protected void btnIniciar_Click(object sender, ImageClickEventArgs e)
    {
        if (txbCuenta.Text.Trim() != "")

        {
            eUsuarioNetvalle = new ERUsuarioNetvalle();
            eUsuarioNetvalle = swLNReciclado.Obtener_RUsuarioNetvalle_O_Codigo_Pass_Rol(txbCuenta.Text.Trim().ToUpper(), "0000", ddlSelectUser.SelectedValue);
            if (eUsuarioNetvalle.CodigoUsuarioNetvalle.Trim() != "")
            {
                Session["Codigo"] = eUsuarioNetvalle.CodigoUsuarioNetvalle.ToUpper();
                Session["Sede"] = eUsuarioNetvalle.SedeUsuarioNetvalle.ToUpper();
                //if (ddlSelectUser.SelectedValue == "AD")
                //{
                //    Session["Rol"] = "ADMINISTRATIVO";

                //    Response.Redirect("/WAReciclado/WebForm/Administrador/PMenuAdministrador.aspx");
                //}

                if (ddlSelectUser.SelectedValue == "EU")
                {
                    Session["Rol"] = "ESTUDIANTE";
                    Response.Redirect("/WAReciclado/WebForm/Usuario/PMenuEstudiante.aspx");
                }

            }

            else if (txbCuenta.Text.Trim() != eUsuarioNetvalle.CodigoUsuarioNetvalle.ToUpper())
            {
                lblMensaje.Text = "Usuario no encontrado";
                txbCuenta.Text = "";
            }
        }
        else if (txbCuenta.Text.Trim() == "")
        {
            lblMensaje.Text = "Introdusca codigo de usuario";
        }

    }

}
