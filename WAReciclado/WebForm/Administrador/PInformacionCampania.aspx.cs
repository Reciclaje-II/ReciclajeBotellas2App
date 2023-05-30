using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PInformacionCampania : System.Web.UI.Page
{
    SWLNRecicladoClient swlnReciclado = new SWLNRecicladoClient();
    ERCampania eCampania = new ERCampania();
    List<ERCampaniaOrganizacion> eCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
    List<ERUsuario> eUsuarios = new List<ERUsuario>();
    CCampaniaOrganizacion cCampaniaOrganizacion = new CCampaniaOrganizacion();

    private string nombreCampania = string.Empty, sede = string.Empty, nombreOrganizacion = string.Empty;
    private DateTime fechaFin = new DateTime();

    LNServicio lnServicio = new LNServicio();
    CCampania cCampania = new CCampania();

    protected void Page_Load(object sender, EventArgs e)
    {
        divContenedor.Controls.Clear();
        if (Session["Sede"] != null)
            sede = Session["Sede"].ToString();
        eCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        if (Session["Campania"] != null)
        {
            nombreCampania = Session["Campania"].ToString();
            eCampaniaOrganizacion = cCampaniaOrganizacion.Obtener_RCampaniaOrganizacion_O_Campania_CCO(nombreCampania).ToList();
            lblNombreCampania.Text = nombreCampania;
        }

        List<int> votosList = new List<int>();
        int auxVotos = 0;

        if (eCampaniaOrganizacion != null)
        {
            foreach (var item in eCampaniaOrganizacion)
            {
                string pathOrganizacion = Regex.Replace(item.OrganizacionCampaniaOrganizacion.ToLower(), @"\s", "");
                pathOrganizacion = @"/Imagenes/Logo/" + pathOrganizacion + ".png";
                int votos = cCampaniaOrganizacion.Obtener_RVotos_O_Campania_Organizacion_CCO(item.CampaniaCampaniaOrganizacion, item.OrganizacionCampaniaOrganizacion);
                CargarOrganizaciones(votos, item.OrganizacionCampaniaOrganizacion, pathOrganizacion);
                votosList.Add(votos);
            }
        }

        auxVotos = votosList.Max();
        if (votosList.FindAll(x => x == auxVotos).Count() > 1)
        {
            btnFinalizar.Visible = false;
            lblExep.Visible = true;
            lblExep.Text = "No existe campaña ganadora por el momento.";
        }
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        cCampania.Obtener_Organizacion_Ganadora(nombreCampania, nombreOrganizacion, sede);
    }

    protected void btnCerrar_Click(object sender, ImageClickEventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Cerrar()", true);
    }

    protected void btnFinalizar_Click(object sender, EventArgs e)
    {
        //cCampania.Finalizar_Campania(fechaFin, sede, lblCampaniaFin.Text);
        eCampania = new ERCampania();
        eCampania = cCampania.Obtener_RCampania_O_Sede_CC(sede);
        fechaFin = eCampania.FechaFinCampania;
        string verbo = string.Empty;
        if (fechaFin < DateTime.Now.Date)
            verbo = " venció ";
        if (fechaFin > DateTime.Now.Date)
            verbo = " vencerá ";
        if (fechaFin == DateTime.Now.Date)
            verbo = " vence ";
        lblCampaniaFin.Text = "La " + eCampania.NombreCampania + verbo + " el " + fechaFin.ToShortDateString();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Abrir()", true);
    }

    public void CargarOrganizaciones(int votos, string organizacion, string path)
    {
        CUOrganizacionAdmin cardOrganizacion;
        cardOrganizacion = (CUOrganizacionAdmin)LoadControl("~/Controles/CUOrganizacionAdmin.ascx");
        cardOrganizacion.Votos = votos;
        cardOrganizacion.OrganizacionNombre = organizacion;
        cardOrganizacion.PathImage = path;
        divContenedor.Controls.Add(cardOrganizacion);
    }
}