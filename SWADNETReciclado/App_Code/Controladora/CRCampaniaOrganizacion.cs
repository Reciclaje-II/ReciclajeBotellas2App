using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CRCampaniaOrganizacion
/// </summary>
public class CRCampaniaOrganizacion
{
    #region Metodos privados
    private ADRCampaniaOrganizacion adRCampaniaOrganizacion;
    #endregion
    #region Metodos publicos
    public CRCampaniaOrganizacion()
    {
        adRCampaniaOrganizacion = new ADRCampaniaOrganizacion();
    }

    public void Insertar_RCampaniaOrganizacion_I(ERCampaniaOrganizacion eRCampaniaOrganizacion)
    {
        adRCampaniaOrganizacion.Insertar_RCampaniaOrganizacion_I(eRCampaniaOrganizacion);
    }

    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string Campania)
    {
        ERCampaniaOrganizacion eRCampaniaOrganizacion;
        List<ERCampaniaOrganizacion> lstERCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        DTORCampaniaOrganizacion dtoRCampaniaOrganizacion = adRCampaniaOrganizacion.Obtener_RCampaniaOrganizacion_O_Campania(Campania);
        foreach (DTORCampaniaOrganizacion.RCampaniaOrganizacionRow drRCampaniaOrganizacion in dtoRCampaniaOrganizacion.RCampaniaOrganizacion.Rows)
        {
            eRCampaniaOrganizacion = new ERCampaniaOrganizacion();
            eRCampaniaOrganizacion.Campania = drRCampaniaOrganizacion.Campania.TrimEnd();
            eRCampaniaOrganizacion.Organizacion = drRCampaniaOrganizacion.Organizacion.TrimEnd();
            lstERCampaniaOrganizacion.Add(eRCampaniaOrganizacion);
        }
        return lstERCampaniaOrganizacion;

    }
    #endregion
}