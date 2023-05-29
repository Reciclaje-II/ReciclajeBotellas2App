using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PListadoGramos : System.Web.UI.Page
{
    CContenedor cContenedor = new CContenedor();
    CUsuario cUsuario = new CUsuario();
    List<ERContenedor> lstContenedor = new List<ERContenedor>();
    ERUsuario eUsuario = new ERUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lstContenedor = cContenedor.Obtener_RContenedor_O_Codigo_CTR(Session["Codigo"].ToString()).OrderByDescending(contenedor => contenedor.Fecha).ToList();
            eUsuario = cUsuario.Obtener_RUsuario_O_Codigo_CU(Session["Codigo"].ToString());
            CargarDatos();
            lblCreditos.Text = eUsuario.Creditos;
        }
    }

    public void CargarDatos()
    {
        gvListaGramos.DataSource = null;
        gvListaGramos.DataSource = lstContenedor;
        gvListaGramos.DataBind();
    }

}