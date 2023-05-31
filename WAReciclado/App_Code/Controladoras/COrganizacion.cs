using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using SWLNReciclado;
using System.IO;
using System.Web.UI;
using System.ServiceModel;

/// <summary>
/// Summary description for COrganizacion
/// </summary>
public class COrganizacion : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();

    public COrganizacion()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos

    #region LNServicio
    public List<EROrganizacion> Obtener_ROrganizaciones_O_CO()
    {
        List<EROrganizacion> lstErOrganizacion = new List<EROrganizacion>();
        try
        {
            lstErOrganizacion = lnServicio.Obtener_ROrganizaciones_O().ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstErOrganizacion;
    }
    public EROrganizacion Obtener_ROrganizacion_O_Nombre_CO(string NombreOrganizacion)
    {
        EROrganizacion erOganizacion = new EROrganizacion();
        try
        {
            erOganizacion = lnServicio.Obtener_ROrganizacion_O_Nombre(NombreOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erOganizacion;
    }
    public string Obtener_RVoto_O_Organizacion_CO(string Campania)
    {
        string organizacion = string.Empty;
        try
        {
            organizacion = lnServicio.Obtener_RVoto_O_Organizacion(Campania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return organizacion;

    }
    public void Actualizar_ROrganizacion_A_CO(string NombreOrganizacion, string DescripcionOrganizacion)
    {
        try
        {
            lnServicio.Actualizar_ROrganizacion_A(NombreOrganizacion, DescripcionOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Insertar_ROrganizacion_I_CO(string NombreOrganizacion, string DescripcionOrganizacion)
    {
        try
        {
            lnServicio.Insertar_ROrganizacion_I(NombreOrganizacion, DescripcionOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #region Registro
    public void Eliminar_Organizacion(string Organizacion)
    {
        try
        {
            lnServicio.Eliminar_ROrganizacion_E_Nombre(Organizacion.Trim().ToUpper());
            Context.Response.Redirect("../../WebForm/Administrador/PGestionOrganizaciones.aspx");
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}