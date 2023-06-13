using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PVerDescripcion : System.Web.UI.Page
{
    EROrganizacion eOrganizacion = new EROrganizacion();
    COrganizacion cOrganizacion = new COrganizacion();
    SWLNRecicladoClient swlnReciclado = new SWLNRecicladoClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        //pasar el parametro de la organizacion recicladoClient.Obtener_ROrganizacion_O_Nombre();
        eOrganizacion = new EROrganizacion();
        if (eOrganizacion != null)
        {
            //eROrganizacion = swlnReciclado.Obtener_ROrganizacion_O_Nombre(@"Aldeas Infantiles SOS Bolivia");
            eOrganizacion = cOrganizacion.Obtener_ROrganizacion_O_Nombre_CO(Session["Organizacion"].ToString());
            lblOrganizacion.Text = eOrganizacion.NombreOrganizacion;
        }
        string pathOrganizacion = eOrganizacion.NombreOrganizacion;
        pathOrganizacion = pathOrganizacion.ToLower();
        pathOrganizacion = Regex.Replace(pathOrganizacion, @"\s", "");
        string pathImage = @"/Imagenes/Descripcion/" + pathOrganizacion + ".png";
        imgImagen.ImageUrl = pathImage;
        lblDescripcion.Text = eOrganizacion.DescripcionOrganizacion;//saltos de linea
    }
}