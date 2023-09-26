using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PVotarOrganizaciones : System.Web.UI.Page
{
    CUOrganizacionUsuario cardOrganizacion;
    ERCampania eCampania = new ERCampania();
    CCampania cCampania = new CCampania();
    SWLNRecicladoClient swlnReciclado = new SWLNRecicladoClient();
    List<ERCampaniaOrganizacion> eCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
    protected void Page_Load(object sender, EventArgs e)
    {
        divContenedor.Controls.Clear();
        eCampania = new ERCampania();
        //Session.SedeUser
        eCampania = cCampania.Obtener_RCampania_O_Sede_CC(Session["Sede"].ToString());
        eCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        if (eCampania.NombreCampania.Trim() != "")
        {
            eCampaniaOrganizacion = swlnReciclado.Obtener_RCampaniaOrganizacion_O_Campania(eCampania.NombreCampania).ToList();
            lblCampaña.Text = eCampania.NombreCampania;
        }
        else
            lblCampaña.Text = "NO HAY CAMPAÑAS EN ESTE MOMENTO";

        if (eCampaniaOrganizacion != null)
        {
            foreach (var item in eCampaniaOrganizacion)
            {
                cardOrganizacion = (CUOrganizacionUsuario)LoadControl("~/Controles/CUOrganizacionUsuario.ascx");
                string pathOrganizacion = item.OrganizacionCampaniaOrganizacion;
                pathOrganizacion = pathOrganizacion.ToLower();
                pathOrganizacion = Regex.Replace(pathOrganizacion, @"\s", "");
                cardOrganizacion.pathImage = @"/WAReciclado/Imagenes/Logo/" + pathOrganizacion + ".png";
                int total = swlnReciclado.Obtener_RVotos_O_Campania(item.CampaniaCampaniaOrganizacion);
                int votos = swlnReciclado.Obtener_RVotos_O_Campania_Organizacion(item.CampaniaCampaniaOrganizacion, item.OrganizacionCampaniaOrganizacion);
                if (total == 0 || total.ToString() == "")
                {
                    total = 100;
                    votos = 0;
                }
                cardOrganizacion.total = total;
                cardOrganizacion.votos = votos;
                cardOrganizacion.campaniaNombre = item.CampaniaCampaniaOrganizacion;
                cardOrganizacion.organizacionNombre = item.OrganizacionCampaniaOrganizacion;
                divContenedor.Controls.Add(cardOrganizacion);
            }
        }
    }
}