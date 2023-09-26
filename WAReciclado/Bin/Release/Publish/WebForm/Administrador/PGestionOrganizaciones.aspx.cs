using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PGestionOrganizaciones : System.Web.UI.Page
{
    COrganizacion cOrganizacion = new COrganizacion();
    List<EROrganizacion> lstEOrganizacion = new List<EROrganizacion>();
    int index;
    string organizacion;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            CargarGrid();
        }
        
    }
    public void CargarGrid()
    {
        gvOrganizaciones.DataSource = null;
        lstEOrganizacion = cOrganizacion.Obtener_ROrganizaciones_O_CO().ToList();
        gvOrganizaciones.DataSource = lstEOrganizacion;
        gvOrganizaciones.DataBind();
    }

    protected void gvOrganizaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        index = Convert.ToInt32(e.CommandArgument);
        organizacion = System.Net.WebUtility.HtmlDecode(gvOrganizaciones.Rows[index].Cells[0].Text);
        if (e.CommandName == "btnActualizar")
        {
            Session["Organizacion"] = organizacion.ToUpper();
            Server.Transfer("PEditarOrganizacion.aspx");
        }
        if (e.CommandName == "btnCancelar")
        {
            lblOrganizacion.Text = organizacion;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Abrir()", true);
        }
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        cOrganizacion.Eliminar_Organizacion(lblOrganizacion.Text);
    }

    protected void btnCrearOrganizacion_Click(object sender, EventArgs e)
    {
        Session["Accion"] = "0";
        Response.Redirect("PNuevaOrganizacion.aspx");
    }
}