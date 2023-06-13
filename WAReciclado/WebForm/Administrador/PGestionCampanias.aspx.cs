using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PGestionCampanias : System.Web.UI.Page
{
    ERCampania eCampania = new ERCampania();
    List<ERCampania> lstERCampania = new List<ERCampania>();
    private string estado = string.Empty;
    private string Id_Campania = string.Empty, sede = string.Empty, organizacion = string.Empty;
    private static int index;

    CCampania cCampania = new CCampania();
    COrganizacion cOrganizacion = new COrganizacion();

    protected void Page_Load(object sender, EventArgs e)
    {
        eCampania = new ERCampania();
        eCampania = cCampania.Obtener_RCampania_O_Sede_CC(Session["Sede"].ToString());
        //LNServicio lNServicio = new LNServicio();
        //lNServicio.Insertar_RContenedor_I("BVR5001132", 1, "12", DateTime.Now);
        if (eCampania.NombreCampania.Trim() != "")
        {
            btnCrearCampania.Visible = false;
        }

        lstERCampania = new List<ERCampania>();
        CargarDatos();


    }

    private void EditarBotones()
    {

        for (int i = 0; i < gvListaCampanias.Rows.Count; i++)
        {
            string valor = gvListaCampanias.Rows[i].Cells[4].Text;

            if (valor == EPAEstaticos.EstadoFinalizada)
            {
                gvListaCampanias.Rows[i].Cells[8].Controls[0].Visible = false;
            }

           

            switch (valor)
            {
                case "AC":
                    gvListaCampanias.Rows[i].Cells[4].Text = "Activa";
                    break;
                
                case "FI":

                    gvListaCampanias.Rows[i].Cells[8].Controls[0].Visible = false;
                    gvListaCampanias.Rows[i].Cells[4].Text = "Finalizada";

                    break;
            }
        }
    }

    private void CargarDatos()
    {
        gvListaCampanias.DataSource = null;
        lstERCampania = cCampania.Obtener_RCampania_O_CC(Session["Sede"].ToString()).Where(campania => campania.EstadoCampania.ToUpper() != "CA").OrderBy(campania => campania.EstadoCampania).ToList();
        gvListaCampanias.DataSource = lstERCampania;
        gvListaCampanias.DataBind();

        EditarBotones();
    }

    #region Metodo cargar lista de campañas 
    protected void btnCrearCampania_Click(object sender, EventArgs e)
    {
        Session["OpcionCampania"] = "0";
        Response.Redirect("PAgregarCampania.aspx");
    }
    #endregion

    #region  ver datos de la campañas 
    protected void gvListaCampanias_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        index = Convert.ToInt32(e.CommandArgument);
        Id_Campania = System.Net.WebUtility.HtmlDecode(gvListaCampanias.Rows[index].Cells[0].Text);
        sede = System.Net.WebUtility.HtmlDecode(gvListaCampanias.Rows[index].Cells[5].Text);
        organizacion = cOrganizacion.Obtener_RVoto_O_Organizacion_CO(Id_Campania);
        if (e.CommandName == "btnVer")
        {
            estado = gvListaCampanias.Rows[index].Cells[4].Text;
            if (estado == "Activa")
            {
                Session["Campania"] = Id_Campania;
                Session["Sede"] = sede;
                Response.Redirect("PInformacionCampania.aspx");
                btnCrearCampania.Text = Id_Campania;
            }
            else if (estado == "Finalizada")
            {
                Session["Campania"] = Id_Campania;
                Session["Sede"] = sede;
                Session["GANADORA"] = organizacion;
                Response.Redirect("PResultadoCampania.aspx");
            }
        }
        if (e.CommandName == "btnActualizar")
        {
            Session["ACCION"] = "A";
            Session["EditarCampania"] = Id_Campania;
            Session["Sede"] = sede;
            Session["OpcionCampania"] = "1";
            Response.Redirect("PAgregarCampania.aspx");
        }
        if (e.CommandName == "btnCancelar")
        {
            lblCampaniaEliminar.Text = Id_Campania;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Abrir()", true);
        }
    }
    #endregion

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        cCampania.Eliminar_Campania(lblCampaniaEliminar.Text);
    }
    protected void btnCerrar_Click(object sender, ImageClickEventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Cerrar()", true);
    }



}