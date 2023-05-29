using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using SWLNReciclado;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.ServiceModel;

/// <summary>
/// Summary description for CCampania
/// </summary>
public class CCampania : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    List<ERUsuario> eUsuarios = new List<ERUsuario>();

    public CCampania()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos
    #region LNServicio
    public ERCampania Obtener_RCampania_O_Sede_Campania_CC(string Campania, string Sede)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = lnServicio.Obtener_RCampania_O_Sede_Campania(Campania, Sede);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erCampania;
    }

    public ERCampania Obtener_RCampania_O_Sede_CC(string Sede)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = lnServicio.Obtener_RCampania_O_Sede(Sede);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erCampania;
    }
    public ECampaniaFinalizadaCompleja Obtener_ECampaniaFinalizadaCompleja_O_Campania_CC(string Campania, string Sede)
    {
        ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
        try
        {
            eCampaniaFinalizadaCompleja = lnServicio.Obtener_ECampaniaFinalizadaCompleja_O_Campania(Campania, Sede);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eCampaniaFinalizadaCompleja;
    }
    public int Obtener_RVotos_O_Campania_CC(string Campania)
    {
        int votos = 0;
        try
        {
            votos = lnServicio.Obtener_RVotos_O_Campania(Campania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return votos;

    }
    public List<ERCampania> Obtener_RCampania_O_CC(string Sede)
    {
        List<ERCampania> lstErCampania = new List<ERCampania>();
        try
        {
            lstErCampania = lnServicio.Obtener_RCampania_O(Sede).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstErCampania;
    }
    #endregion

    #region Registro
    public void Editar_Campania(string Descripcion, string FechaInicio, string FechaFin)
    {
        try
        {
            lnServicio.Actualizar_RCampania_A(Session["EditarCampania"].ToString(), Descripcion, DateTime.Parse(FechaInicio.Trim()), DateTime.Parse(FechaFin.Trim()), Session["Sede"].ToString());
            //Context.Response.Redirect("../../WebForm/Administrador/PGestionCampanias.aspx");
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Eliminar_Campania(string CampaniaEliminar)
    {
        try
        {
            lnServicio.Actualizar_RCampania_A_Estado_Cancelado(CampaniaEliminar.Trim());
            Context.Response.Redirect("../../WebForm/Administrador/PGestionCampanias.aspx");
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Obtener_Organizacion_Ganadora(string NombreCampania, string NombreOrganizacion, string Sede)
    {
        try
        {
            eUsuarios = new List<ERUsuario>();
            lnServicio.Actualizar_RCampania_A_Estado(NombreCampania);
            NombreOrganizacion = lnServicio.Obtener_RVoto_O_Organizacion(NombreCampania);
            eUsuarios = lnServicio.Obtener_RUsuarios_O_Sede(Sede).ToList();
            foreach (var user in eUsuarios)
            {
                lnServicio.Actualizar_RVoto_A(user.Codigo, NombreCampania, NombreOrganizacion, DateTime.Now.Date, user.Creditos, "");
                lnServicio.Actualizar_RUsuario_A_Creditos_Sede(NombreCampania, user.Codigo);
            }
            Session["Campania"] = NombreCampania;
            Session["Sede"] = Sede;
            Session["GANADORA"] = NombreOrganizacion;
            Context.Response.Redirect("../../WebForm/Administrador/PResultadoCampania.aspx");
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}