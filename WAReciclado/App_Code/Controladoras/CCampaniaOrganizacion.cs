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
    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania_CCO(string campaniaCampaniaOrganizacion)
    {
        List<ERCampaniaOrganizacion> lstErCampania = new List<ERCampaniaOrganizacion>();
        try
        {
            lstErCampania = lnServicio.Obtener_RCampaniaOrganizacion_O_Campania(campaniaCampaniaOrganizacion).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstErCampania;
    }
    #endregion

    #region Registro
    public int Obtener_RVotos_O_Campania_Organizacion_CCO(string campaniaCampaniaOrganizacion, string organizacionCampaniaOrganizacion)
    {
        int votos = 0;
        try
        {
            votos = lnServicio.Obtener_RVotos_O_Campania_Organizacion(campaniaCampaniaOrganizacion, organizacionCampaniaOrganizacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }

        return votos;

    }
    public void Insertar_Campania_Organizacion(string nombreCampania, string fechaFinCampania, string descripcionCampania, string fechaInicioCampania, List<ECampaniaAux> lstOrganizaciones)
    {
        try
        {
            lstERCampania = new List<ERCampania>();
            string NombreCampania = SUtil.NombreCampaniasConvert(nombreCampania.Trim().ToUpper(), Session["Sede"].ToString(), fechaFinCampania.Trim());
            lstERCampania = lnServicio.Obtener_RCampania_O(Session["Sede"].ToString()).ToList();
            int CantidadExistentes=0;
            foreach (var item in lstERCampania)
            {
                var nombreCampaniaSplit = item.NombreCampania.Split('-');
                var nombreCampaniaToUpper = nombreCampania.ToUpper();
                if (nombreCampaniaSplit[1] == nombreCampaniaToUpper)
                {
                    CantidadExistentes ++;
                }
            }
            if (CantidadExistentes > 0)
            {
                NombreCampania = NombreCampania + '-' + CantidadExistentes;
            }


            lnServicio.Insertar_RCampania_I(NombreCampania, descripcionCampania, DateTime.Parse(fechaInicioCampania.Trim()), DateTime.Parse(fechaFinCampania.Trim()), Session["Sede"].ToString());

            for (int i = 0; i < lstOrganizaciones.Count; i++)
            {
                lnServicio.Insertar_RCampaniaOrganizacion_I(NombreCampania, lstOrganizaciones[i].NombreOrganizacion);
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