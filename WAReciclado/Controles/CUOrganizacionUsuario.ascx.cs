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
    SWLNRecicladoClient swlnReciclado = new SWLNRecicladoClient();
    LNServicio lnServicio = new LNServicio();
    ERVoto voto = new ERVoto();
    protected void Page_Load(object sender, EventArgs e)
    {
        imbOrganizacion.ImageUrl = pathImage;
        double porcentaje = (double)votos / (double)total;
        porcentaje = porcentaje * 100;
        divVotos.Style["width"] = (int)porcentaje + "%";
        swlnReciclado = new SWLNRecicladoClient();
        voto = new ERVoto();
        lblOrganizacion.Visible = false;
        btnSi.Visible = false;
        lblOrganizacion.Text = "¿ESTA SEGURO/A QUE QUIERE VOTAR A " + organizacionNombre + "?&nbsp";
        //Session.CodigoUser
        voto = lnServicio.Obtener_RVoto_O_Codigo_Campania(Session["Codigo"].ToString().ToUpper(), campaniaNombre);
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
        Session["NombreOrganizacion"] = organizacionNombre;
        Response.Redirect("PVerDescripcion.aspx");
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        swlnReciclado = new SWLNRecicladoClient();
        voto = new ERVoto();
        //Session.UserCode
        voto = lnServicio.Obtener_RVoto_O_Codigo_Campania(Session["CodigoUsuario"].ToString(), campaniaNombre);
        if (voto == null || voto.OrganizacionVoto.Trim() == "")
        {
            //Session.CodigoUser
            lnServicio.Insertar_RVoto_I(Session["CodigoUsuario"].ToString().ToUpper(), campaniaNombre, organizacionNombre, DateTime.Now, "0", "Valido", DateTime.Now);
            Response.Redirect("PVotarOrganizaciones.aspx");
        }
    }
}