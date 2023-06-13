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
    ERVoto voto;
    public CCampania()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos
    #region LNServicio
    public ERCampania Obtener_RCampania_O_Sede_Campania_CC(string nombreCampania, string sedeCampania)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = lnServicio.Obtener_RCampania_O_Sede_Campania(nombreCampania, sedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erCampania;
    }

    public ERCampania Obtener_RCampania_O_Sede_CC(string sedeCampania)
    {
        ERCampania erCampania = new ERCampania();
        try
        {
            erCampania = lnServicio.Obtener_RCampania_O_Sede(sedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erCampania;
    }
    public ECampaniaFinalizadaCompleja Obtener_ECampaniaFinalizadaCompleja_O_Campania_CC(string nombreCampania, string sedeCampania)
    {
        ECampaniaFinalizadaCompleja eCampaniaFinalizadaCompleja = new ECampaniaFinalizadaCompleja();
        try
        {
            eCampaniaFinalizadaCompleja = lnServicio.Obtener_ECampaniaFinalizadaCompleja_O_Campania(nombreCampania, sedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return eCampaniaFinalizadaCompleja;
    }
    public int Obtener_RVotos_O_Campania_CC(string nombreCampania)
    {
        int votos = 0;
        try
        {
            votos = lnServicio.Obtener_RVotos_O_Campania(nombreCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return votos;

    }
    public List<ERCampania> Obtener_RCampania_O_CC(string sedeCampania)
    {
        List<ERCampania> lstErCampania = new List<ERCampania>();
        try
        {
            lstErCampania = lnServicio.Obtener_RCampania_O(sedeCampania).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstErCampania;
    }
    #endregion

    #region Registro
    public void Editar_Campania(string descripcionCampania, string fechaInicioCampania, string fechaFinCampania)
    {
        try
        {
            lnServicio.Actualizar_RCampania_A(Session["EditarCampania"].ToString(), descripcionCampania, DateTime.Parse(fechaInicioCampania.Trim()), DateTime.Parse(fechaFinCampania.Trim()), Session["Sede"].ToString());
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
    public void Obtener_Organizacion_Ganadora(string nombreCampania, string nombreOrganizacion, string sedeOrganizacion)
    {
        try
        {
            eUsuarios = new List<ERUsuario>();
            lnServicio.Actualizar_RCampania_A_Estado(nombreCampania);
            nombreOrganizacion = lnServicio.Obtener_RVoto_O_Organizacion(nombreCampania);
            eUsuarios = lnServicio.Obtener_RUsuarios_O_Sede(sedeOrganizacion).ToList();
            voto = new ERVoto();
            //Session.UserCode            
            foreach (var user in eUsuarios)
            {
                if (double.Parse(user.CreditosUsuario) > 0)
                {
                    voto = lnServicio.Obtener_RVoto_O_Codigo_Campania(user.CodigoUsuario, nombreCampania);
                    if (voto == null || voto.OrganizacionVoto.Trim() == "")
                    {
                        lnServicio.Insertar_RVoto_I(user.CodigoUsuario, nombreCampania, nombreOrganizacion, DateTime.Now, user.CreditosUsuario, EPAEstaticos.EstadoInvalido);
                    }
                    lnServicio.Actualizar_RVoto_A(user.CodigoUsuario, nombreCampania, nombreOrganizacion, DateTime.Now.Date, user.CreditosUsuario, "");
                    lnServicio.Actualizar_RUsuario_A_Creditos_Sede(user.CodigoUsuario);
                }                
                
            }
            Session["Campania"] = nombreCampania;
            Session["Sede"] = sedeOrganizacion;
            Session["GANADORA"] = nombreOrganizacion;
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