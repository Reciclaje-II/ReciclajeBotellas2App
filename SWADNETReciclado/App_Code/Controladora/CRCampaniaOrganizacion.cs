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

    public List<ERCampaniaOrganizacion> Obtener_RCampaniaOrganizacion_O_Campania(string CampaniaCampaniaOrganizacion) 
    {
        ERCampaniaOrganizacion eRCampaniaOrganizacion;
        List<ERCampaniaOrganizacion> lstERCampaniaOrganizacion = new List<ERCampaniaOrganizacion>();
        DTORCampaniaOrganizacion dtoRCampaniaOrganizacion = adRCampaniaOrganizacion.Obtener_RCampaniaOrganizacion_O_Campania(CampaniaCampaniaOrganizacion);
        foreach (DTORCampaniaOrganizacion.RCampaniaOrganizacionRow drRCampaniaOrganizacion in dtoRCampaniaOrganizacion.RCampaniaOrganizacion.Rows)
        {
            eRCampaniaOrganizacion = new ERCampaniaOrganizacion();
            eRCampaniaOrganizacion.CampaniaCampaniaOrganizacion = drRCampaniaOrganizacion.CampaniaCampaniaOrganizacion.TrimEnd();
            eRCampaniaOrganizacion.OrganizacionCampaniaOrganizacion = drRCampaniaOrganizacion.OrganizacionCampaniaOrganizacion.TrimEnd();
            eRCampaniaOrganizacion.IdCampaniaOrganizacion = drRCampaniaOrganizacion.IdCampaniaOrganizacion;
            eRCampaniaOrganizacion.FechaRegistroCampaniaOrganizacion = drRCampaniaOrganizacion.FechaRegistroCampaniaOrganizacion;
            eRCampaniaOrganizacion.FechaModificacionCampaniaOrganizacion = drRCampaniaOrganizacion.FechaModificacionCampaniaOrganizacion;
            eRCampaniaOrganizacion.EstadoCampaniaOrganizacion = drRCampaniaOrganizacion.EstadoCampaniaOrganizacion;
            lstERCampaniaOrganizacion.Add(eRCampaniaOrganizacion);
        }
        return lstERCampaniaOrganizacion;

    }
    #endregion
}