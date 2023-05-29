using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PEditarOrganizacion : System.Web.UI.Page
{
    EROrganizacion eOrganizacion = new EROrganizacion();
    COrganizacion cOrganizacion = new COrganizacion();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarDatos();
        }
    }

    protected void CargarDatos()
    {
        eOrganizacion = new EROrganizacion();
        if (eOrganizacion != null)
        {
            eOrganizacion = cOrganizacion.Obtener_ROrganizacion_O_Nombre_CO(Session["Organizacion"].ToString());
            lblNombre.Text = eOrganizacion.Nombre;
            txbDescripcionEdit.Text = eOrganizacion.Descripcion;
        }
        string pathOrganizacion = eOrganizacion.Nombre;
        pathOrganizacion = pathOrganizacion.ToLower();
        pathOrganizacion = Regex.Replace(pathOrganizacion, @"\s", "");
        string pathImage = @"/Imagenes/Descripcion/" + pathOrganizacion + ".png";
        string pathImageLogo = @"/Imagenes/Logo/" + pathOrganizacion + ".png";
        Image1.ImageUrl = pathImage;
        imgLogo.ImageUrl = pathImageLogo;
        lblDescripcion.Text = eOrganizacion.Descripcion;
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            cOrganizacion = new COrganizacion();
            string nombreO = lblNombre.Text;
            string descripcionO = txbDescripcionEdit.Text;

            if (txbDescripcionEdit.Text != "")
            {
                cOrganizacion.Actualizar_ROrganizacion_A_CO(nombreO, descripcionO);
                string nombreOr = String.Concat(nombreO.Where(c => !Char.IsWhiteSpace(c)));
                if (fluLogo.HasFile)
                {

                    subirImagenLogo(nombreOr.Trim().TrimEnd());
                }
                if (fluDescripcion.HasFile)
                {

                    subirImagenDescripcion(nombreOr.Trim().TrimEnd());
                }
                txbDescripcionEdit.Text = "";
                lblDescripcion.Text = "";
            }

            Response.Redirect("PGestionOrganizaciones.aspx");
        }
        catch (Exception)
        {
            throw;
        }
    }
    private void subirImagenLogo(string nombreOrganizacion)
    {
        string destino = "~/Imagenes/Logo/";
        string carpetaDestino = Server.MapPath(destino);
        if (!Directory.Exists(carpetaDestino))
        {
            Directory.CreateDirectory(carpetaDestino);
        }
        string nombreArchivo = nombreOrganizacion;
        string SaveLocation = carpetaDestino + nombreArchivo;
        fluLogo.SaveAs(Server.MapPath("~/Imagenes/Logo/" + nombreArchivo.TrimEnd() + ".png").Trim());
    }
    private void subirImagenDescripcion(string nombreOrganizacion)
    {
        string destino = "~/Imagenes/Descripcion/";
        string carpetaDestino = Server.MapPath(destino);
        if (!Directory.Exists(carpetaDestino))
        {
            Directory.CreateDirectory(carpetaDestino);
        }
        string nombreArchivo = nombreOrganizacion;
        string SaveLocation = carpetaDestino + nombreArchivo;
        fluDescripcion.SaveAs(Server.MapPath("~/Imagenes/Descripcion/" + nombreArchivo.TrimEnd() + ".png").Trim());
    }
}