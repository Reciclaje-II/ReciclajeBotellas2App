using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNReciclado;

public partial class PNuevaOrganizacion : System.Web.UI.Page
{
    COrganizacion cOrganizacion = new COrganizacion();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            if (Session["Accion"] == null) hpRedireccion.NavigateUrl = "PGestionOrganizaciones.aspx";

            if (Session["Accion"].ToString() == "1") hpRedireccion.NavigateUrl = "PAgregarCampania.aspx";
            else hpRedireccion.NavigateUrl = "PGestionOrganizaciones.aspx";
        }
        
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            if (txbNombre.Text != "" && txbDescripcion.Text != "")
            {
                cOrganizacion = new COrganizacion();

                string nombreO = txbNombre.Text.Trim().ToLower();
                string descripcionO = txbDescripcion.Text;

                if (cOrganizacion.Obtener_ROrganizacion_O_Nombre_CO(nombreO).NombreOrganizacion == "") 
                {
                    cOrganizacion.Insertar_ROrganizacion_I_CO(nombreO, descripcionO);
                    string nombreOr = String.Concat(nombreO.Where(c => !Char.IsWhiteSpace(c)));
                    subirImagenLogo(nombreOr.Trim().TrimEnd(), fluLogo);
                    subirImagenDescripcion(nombreOr.Trim().TrimEnd(), fluDescripcion);
                    txbDescripcion.Text = "";
                    txbNombre.Text = "";
                    Response.Redirect("PGestionOrganizaciones.aspx");
                }
                else
                {
                    string estado = cOrganizacion.Obtener_ROrganizacion_O_Nombre_CO(nombreO).EstadoOrganizacion;
                    if ( estado == EPAEstaticos.EstadoCancelada)
                    {
                        cOrganizacion.Actualizar_ROrganizacion_A_CO(nombreO, descripcionO);
                        string nombreOr = String.Concat(nombreO.Where(c => !Char.IsWhiteSpace(c)));
                        subirImagenLogo(nombreOr.Trim().TrimEnd(), fluLogo);
                        subirImagenDescripcion(nombreOr.Trim().TrimEnd(), fluDescripcion);
                        txbDescripcion.Text = "";
                        txbNombre.Text = "";
                        Response.Redirect("PGestionOrganizaciones.aspx");
                    }
                    else
                    {
                        lblDescripcion.Text = "Organización ya existente";
                    }
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    private void subirImagenLogo(string nombreOrganizacion, FileUpload fluImage)
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
    private void subirImagenDescripcion(string nombreOrganizacion, FileUpload fluImage)
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