using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class CUOrganizacionUsuario : System.Web.UI.UserControl
{
    public string pathImage { get; set; }
    public int total { get; set; }
    public int votos { get; set; }
    public string organizacionNombre { get; set; }
    public string campaniaNombre { get; set; }
    
    LNServicio lnServicio = new LNServicio();
    ERVoto voto = new ERVoto();
    CUsuario cuUsuario = new CUsuario();
    CCampania ccCampania = new CCampania();
    protected void Page_Load(object sender, EventArgs e)
    {
        
            imbOrganizacion.ImageUrl = pathImage;
            double porcentaje = (double)votos / (double)total;
            porcentaje = porcentaje * 100;
            divVotos.Style["width"] = (int)porcentaje + "%";
            voto = new ERVoto();
            lblOrganizacion.Visible = false;
            btnSi.Visible = false;
            lblOrganizacion.Text = "¿ESTA SEGURO/A QUE QUIERE VOTAR A " + organizacionNombre + "?&nbsp";
            //Session.CodigoUser
            voto = cuUsuario.Obtener_RVoto_O_Codigo_Campania_CU(Session["Codigo"].ToString().ToUpper(), campaniaNombre);
            if (voto.EstadoVoto.Trim() != "")
            {
                btnVotar.Visible = false;
            }
        
    }

    protected void btnVotar_Click(object sender, EventArgs e)
    {
        lblOrganizacion.Visible = true;
        btnSi.Visible = true;
    }

    protected void imbOrganizacion_Click(object sender, ImageClickEventArgs e)
    {
        Session["Organizacion"] = organizacionNombre;
        Response.Redirect("PVerDescripcion.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        voto = new ERVoto();
        //Session.UserCode
        voto = ccCampania.Obtener_RVoto_O_Codigo_Campania_CC(Session["Codigo"].ToString(), campaniaNombre);
        if (voto == null || voto.OrganizacionVoto.Trim() == "")
        {
            //Session.CodigoUser
            cuUsuario.Insertar_RVoto_I_CU(Session["Codigo"].ToString().ToUpper(), campaniaNombre, organizacionNombre, DateTime.Now, "0", EPAEstaticos.EstadoValido);
            Response.Redirect("PVotarOrganizaciones.aspx");
        }
    }
}