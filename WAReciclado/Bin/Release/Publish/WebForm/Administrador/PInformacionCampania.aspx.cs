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
    ERCampania eCampania = new ERCampania();
    List<ERCampaniaOrganizacion> lstECampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
    CCampaniaOrganizacion cCampaniaOrganizacion = new CCampaniaOrganizacion();

    private string nombreCampania = string.Empty, sede = string.Empty, nombreOrganizacion = string.Empty;
    private DateTime fechaFin = new DateTime();

    CCampania cCampania = new CCampania();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            divContenedor.Controls.Clear();
            if (Session["Sede"] != null)
                sede = Session["Sede"].ToString();
            lstECampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
            if (Session["Campania"] != null)
            {
                nombreCampania = Session["Campania"].ToString();
                lstECampaniaOrganizacion = cCampaniaOrganizacion.Obtener_RCampaniaOrganizacion_O_Campania_CCO(nombreCampania).ToList();
                lblNombreCampania.Text = nombreCampania;
            }
        }
        

        List<int> votosList = new List<int>();
        int auxVotos = 0;

        if (lstECampaniaOrganizacion != null)
        {
            foreach (var item in lstECampaniaOrganizacion)
            {
                string pathOrganizacion = Regex.Replace(item.OrganizacionCampaniaOrganizacion.ToLower(), @"\s", "");
                pathOrganizacion = @"/WAReciclado/Imagenes/Logo/" + pathOrganizacion + ".png";
                int votos = cCampaniaOrganizacion.Obtener_RVotos_O_Campania_Organizacion_CCO(item.CampaniaCampaniaOrganizacion, item.OrganizacionCampaniaOrganizacion);
                CargarOrganizaciones(votos, item.OrganizacionCampaniaOrganizacion, pathOrganizacion);
                votosList.Add(votos);
            }
        }
        if (votosList.Count > 0)
        {
            auxVotos = votosList.Max();
            if (votosList.FindAll(x => x == auxVotos).Count() > 1)
            {
                btnFinalizar.Visible = false;
                lblExep.Visible = true;
                lblExep.Text = "No existen campañas con votos por el momento.";
            }
        }

        eCampania = cCampania.Obtener_RCampania_O_Sede_CC(sede);
        DateTime fechaInicio = eCampania.FechaInicioCampania.Date;
        DateTime fechaFin = eCampania.FechaFinCampania.Date;
        DateTime fechaActual = DateTime.Now.Date;

        lblFechaInicio.Text = fechaInicio.ToShortDateString();
        lblFechaFinal.Text = fechaFin.ToShortDateString();

        if (fechaActual >= fechaInicio || fechaActual <= fechaFin)
        {
            TimeSpan diasRestantes = fechaFin.Subtract(fechaActual);
            lblDiasRestantes.Text = diasRestantes.Days.ToString();

            /////////////////////////////////////////////////////////////////////////que pasa si se tiene dos ganadores
            if (int.Parse(lblDiasRestantes.Text) <= 0)
            {
                cCampania.Obtener_Organizacion_Ganadora(nombreCampania, nombreOrganizacion, sede);
            }
        }
        else
        {
            lblDiasRestantes.Text = "0";
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        hiddenCancelado.Value = "true";
        eCampania = new ERCampania();
        eCampania = cCampania.Obtener_RCampania_O_Sede_CC(sede);

        lblCampaniaFin.Text = "Cancelar la Campaña. ¿Esta seguro/a de cancelar la campaña " + eCampania.NombreCampania + " ?";
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Abrir()", true);
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        
        bool cancelado = hiddenCancelado.Value == "true";
        bool finalizado = hiddenFinalizado.Value == "true";

        if (cancelado)
        {
            cCampania.Eliminar_Campania(nombreCampania);
        }
        else if (finalizado)
        {
            cCampania.Obtener_Organizacion_Ganadora(nombreCampania, nombreOrganizacion, sede);
        }
        
    }
    protected void btnCerrar_Click(object sender, ImageClickEventArgs e)
    {
        hiddenCancelado.Value = "false";
        hiddenFinalizado.Value = "false";

        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Cerrar()", true);
    }

    protected void btnFinalizar_Click(object sender, EventArgs e)
    {
        hiddenFinalizado.Value = "true";
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
        lblCampaniaFin.Text = "Finalizar la Campaña.\n" + "La " + eCampania.NombreCampania + verbo + " el " + fechaFin.ToShortDateString() + "\n" + "¿Esta seguro/a?";
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