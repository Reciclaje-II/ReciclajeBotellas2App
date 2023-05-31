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
public class CCampaniaOrganizacion : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    List<ERCampania> lstERCampania = new List<ERCampania>();

    public CCampaniaOrganizacion()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos

    #region LNServicio
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania_CCO(string Campania)
    {
        List<ERCampaniaOrganizacion> lstErCampania = new List<ERCampaniaOrganizacion>();
        try
        {
            lstErCampania = lnServicio.Obtener_RCampaniaOrganizacion_O_Campania(Campania).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstErCampania;
    }
    #endregion

    #region Registro
    public int Obtener_RVotos_O_Campania_Organizacion_CCO(string CampaniaCampaniaOrganizacion, string OrganizacionCampaniaOrganizacion)
    {
        int votos = 0;
        try
        {
            votos = lnServicio.Obtener_RVotos_O_Campania_Organizacion(CampaniaCampaniaOrganizacion, OrganizacionCampaniaOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        
        return votos;

    }
    public void Insertar_Campania_Organizacion(string NombreCampania, string FechaFin, string Descripcion, string FechaInicio, List<ECampaniaAux> lstOrganizaciones)
    {
        try
        {
            lstERCampania = new List<ERCampania>();
            string nombreCampania = SUtil.NombreCampaniasConvert(NombreCampania.Trim().ToUpper(), Session["Sede"].ToString(), FechaFin.Trim());
            lstERCampania = lnServicio.Obtener_RCampania_O(Session["Sede"].ToString()).ToList();
            foreach (var item in lstERCampania)
            {
                if (item.Nombre == nombreCampania)
                {
                    if (nombreCampania.Split('|').Count() == 2)
                    {
                        string[] aux = nombreCampania.Split('|');
                        int nuevoNumeroNombre = int.Parse(aux[1]) + 1;
                        nombreCampania = aux[0] + "|" + nuevoNumeroNombre.ToString();
                    }
                    else nombreCampania = nombreCampania + "|1";
                }
            }

            lnServicio.Insertar_RCampania_I(nombreCampania, Descripcion, DateTime.Parse(FechaInicio.Trim()), DateTime.Parse(FechaFin.Trim()), Session["Sede"].ToString());

            for (int i = 0; i < lstOrganizaciones.Count; i++)
            {
                lnServicio.Insertar_RCampaniaOrganizacion_I(nombreCampania, lstOrganizaciones[i].organizacion);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}