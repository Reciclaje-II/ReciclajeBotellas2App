using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PResultadoCampania : System.Web.UI.Page
{
    CCampania cCampania = new CCampania();
    CCampaniaOrganizacion cCampaniaOrganizacion = new CCampaniaOrganizacion();
    ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
    private string nombreCampania = string.Empty, sede = string.Empty, nombreOrganizacion = string.Empty;
    private int votosOrganizacion = int.MinValue, votosCampania = int.MinValue;

    protected void Page_Load(object sender, EventArgs e)
    {
        eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
        if (Session["Campania"] != null && Session["Sede"] != null && Session["GANADORA"] != null)
        {
            nombreCampania = Session["Campania"].ToString();
            sede = Session["Sede"].ToString();
            nombreOrganizacion = Session["GANADORA"].ToString();
        }

        if (eCampaniaFinalizadaCompleja != null)
        {
            eCampaniaFinalizadaCompleja = cCampania.Obtener_ECampaniaFinalizadaCompleja_O_Campania_CC(nombreCampania, sede);
        }

        votosOrganizacion = cCampaniaOrganizacion.Obtener_RVotos_O_Campania_Organizacion_CCO(nombreCampania, nombreOrganizacion);
        votosCampania = cCampania.Obtener_RVotos_O_Campania_CC(nombreCampania);
        lblVotos.Text = votosOrganizacion + "/" + votosCampania;
        lblMejorDonador.Text = eCampaniaFinalizadaCompleja.MejorDonadorCampania;
        lblMonto.Text = eCampaniaFinalizadaCompleja.RecaudacionCampania + " créditos";
        lblNombreCampania.Text = eCampaniaFinalizadaCompleja.OrganizacionCampania;
        lblCantidadDonada.Text = eCampaniaFinalizadaCompleja.DonacionCampania.ToString();

        string pathResultado = eCampaniaFinalizadaCompleja.OrganizacionCampania;
        pathResultado = pathResultado.ToLower();
        pathResultado = Regex.Replace(pathResultado, @"\s", "");
        string pathImage = @"/Imagenes/Logo/" + pathResultado + ".png";
        Image1.ImageUrl = pathImage;

    }
}